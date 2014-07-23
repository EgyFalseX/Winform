using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;


namespace CenterBotControl
{
    public class CenterBot : IDisposable , INotifyPropertyChanged
    {
        #region Vars
        public int ID = new Random().Next(60000);
        private DateTime StartupTime = DateTime.Now;
        private const string BotProofCaption = "© CenterBot.com 2013";
        public const string BotTitle = "CenterBotControl[BW]";
        private const string ProcessName = "CenterBot";
        public const string DisconnectedMSG = "Disconnected from server";
        public const string LoginSuccessfulMSG = "Login Successful";
        public const string EmptySlotTitle = "[Empty]";
        public const string ErrorScriptSteps = "Error - Next position is too far!";
        public const string ErrorHSIsDown = "* HS Server is busy or down!";
        public const string ErrorC9PingTimeOut = "C9 Error (Ping timeout)";
        public const string botTerminatedString = "Ibot Process Terminated";
        public const string ErrorStuckOnLogin = "Error_Stuck_On_Login";
        private Process _process;
        private Account _account;
        private StatusType _status = StatusType.Nothing;
        public System.Threading.Timer tmrPuls;
        public System.Threading.Timer tmrLogin;
        public bool HSState = true;

        private double _StartupSkill, _StartupGold, _StartupExperience = 0;

        public delegate void ChangedEventhandler(CenterBot sender, StatusType e); public event ChangedEventhandler StateChanged;
        public delegate void LogAddedEventhandler(CenterBot sender, string Log); public event LogAddedEventhandler LogAdded;
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        # region IntPtr
        
        public IntPtr MainWindowHandle { get; set; }
        private IntPtr MainTabsHandle { get; set; }
        private IntPtr CharNameHandle { get; set; }
        private IntPtr AreaHandle { get; set; }
        private IntPtr GuildNameHandle { get; set; }
        private IntPtr SkillPointHandle { get; set; }
        private IntPtr GoldHandle { get; set; }
        private IntPtr ExperienceHandle { get; set; }
        private IntPtr LevelHandle { get; set; }
        private IntPtr PosXHandle { get; set; }
        private IntPtr PosYHandle { get; set; }
        private IntPtr DiedCountHandle { get; set; }
        private IntPtr ServerNameHandle { get; set; }
        private IntPtr CharInvListHandle { get; set; }
        private IntPtr statusLogHandle { get; set; }

        private IntPtr CharHPProgressBarHandle { get; set; }
        private IntPtr CharMPProgressBarHandle { get; set; }
        private IntPtr CharExpProgressBarHandle { get; set; }
        private IntPtr CharBerzerkProgressBarHandle { get; set; }

        # endregion

        # region Types
        private enum CtrID : int
        {
            MainTabControl = 0x00000001,//
            CharNameID = 0x001007A8,//0x00030972,//
            GuildNameID = 0x000B0A06,//
            SkillPointID = 0x00020980,//
            GoldID = 0x0002097E,//
            ExperienceID = 0x000209A6,//
            LevelID = 0x0002097A,//
            PosXID = 0x00020ABE,//
            PosYID = 0x00030994,//
            DiedCountID = 0x00020A42,//
            StatusLogID = 0x00020AC6,//

            InfoTabID = 0x000E0C12,//
            InfoTabTabControlID = 0x00000002,//
            InventoryTabID = 0x00020C50,//
            CharInventoryID = 0x00010C5C,//

            LoginTabID = 0x00020B54,//
            SilkroadLoginFrameID = 0x00020B1C,//
            ServerNameID = 0x00020AEA,//

            CharHPProgressBarID = 0x00050914,//
            CharMPProgressBarID = 0x0002097C,//
            CharExpProgressBarID = 0x000B08C2,//
            CharBerzerkProgressBarID = 0x000E08D8,//
            AreaID = 0x000B08EA,//

        }
        public enum StatusType
        {
            Connecting_please_wait,
            Ready_to_login,
            Sending_login_informations,
            Sending_secondary_passcode,
            Character_listing,
            Login_Successful,
            Disconnected_from_server,
            bot_Process_Terminated,
            Error_Script_Steps,
            Error_Stuck_On_Login,
            Error_C9PingTimeOut,
            Error_HS_Is_Down,
            Nothing,
            Unknown
        }
        # endregion

        public CenterBot()
        {
            //InitPulsTimer();
            //InitiTmrLogin();  
        }
        public static CenterBot Createbot(Process botProcess = null)
        {
            CenterBot bot = new CenterBot();
            bot._process = botProcess;
            return bot;
        }
        
        public void StartLoginTimer()
        {
            if (tmrLogin == null)
                tmrLogin = new System.Threading.Timer(_ => tmrLogin_Tick(), null, 1000 * 60 * 5, System.Threading.Timeout.Infinite);
        }
        public void StartPlusTimer()
        {
            Console.WriteLine("Plus Starting");
            tmrPuls = new System.Threading.Timer(_ => tmrPuls_Tick(), null, 1000, 1000 * 1);
        }
        void tmrPuls_Tick()
        {
            if (_process == null || _process.HasExited)
                return;
            ////////////GetClientlessLoginLog();
            GetStatusLogList();
            if (_status == StatusType.Login_Successful)
            {
                GetCharInventory();
                InitiProperties();
            }
        }
        void tmrLogin_Tick()
        {
            tmrLogin.Dispose(); tmrLogin = null;
            if (_process == null || _process.HasExited)
                return;

            if (_status != StatusType.Login_Successful)
                AddEventItem("[00:00:00] " + ErrorStuckOnLogin);
        }

        public void PrepareHandlers()
        {
            MainWindowHandle = FindMainWindowInProcess(BotProofCaption);
            MainTabsHandle = Win32.GetDlgItem(MainWindowHandle, (int)CtrID.MainTabControl);

            //GuildNameHandle = Win32.GetWindow(MainWindowHandle, Win32.GetWindow_Cmd.GW_HWNDFIRST);
            //SkillPointHandle = Win32.GetWindow(GuildNameHandle, Win32.GetWindow_Cmd.GW_HWNDNEXT);
            //GoldHandle = Win32.GetWindow(SkillPointHandle, Win32.GetWindow_Cmd.GW_HWNDNEXT);
            //ExperienceHandle = Win32.GetWindow(GoldHandle, Win32.GetWindow_Cmd.GW_HWNDNEXT);
            //LevelHandle = Win32.GetWindow(ExperienceHandle, Win32.GetWindow_Cmd.GW_HWNDNEXT);
            //PosXHandle = Win32.GetWindow(LevelHandle, Win32.GetWindow_Cmd.GW_HWNDNEXT);
            //PosYHandle = Win32.GetWindow(PosXHandle, Win32.GetWindow_Cmd.GW_HWNDNEXT);
            //DiedCountHandle = Win32.GetWindow(PosYHandle, Win32.GetWindow_Cmd.GW_HWNDNEXT);
            //statusLogHandle = Win32.GetWindow(DiedCountHandle, Win32.GetWindow_Cmd.GW_HWNDNEXT);


            GuildNameHandle = Win32.GetDlgItem(MainWindowHandle, (int)CtrID.GuildNameID);
            SkillPointHandle = Win32.GetDlgItem(MainWindowHandle, (int)CtrID.SkillPointID);
            GoldHandle = Win32.GetDlgItem(MainWindowHandle, (int)CtrID.GoldID);
            ExperienceHandle = Win32.GetDlgItem(MainWindowHandle, (int)CtrID.ExperienceID);
            LevelHandle = Win32.GetDlgItem(MainWindowHandle, (int)CtrID.LevelID);
            PosXHandle = Win32.GetDlgItem(MainWindowHandle, (int)CtrID.PosXID);
            PosYHandle = Win32.GetDlgItem(MainWindowHandle, (int)CtrID.PosYID);
            DiedCountHandle = Win32.GetDlgItem(MainWindowHandle, (int)CtrID.DiedCountID);
            statusLogHandle = Win32.GetDlgItem(MainWindowHandle, (int)CtrID.StatusLogID);
            //GET CharInvListHandle
            IntPtr InfoTabWH = Win32.GetDlgItem(MainTabsHandle, (int)CtrID.InfoTabID);
            IntPtr InfoTabTabControlWH = Win32.GetDlgItem(InfoTabWH, (int)CtrID.InfoTabTabControlID);
            IntPtr InventoryTabWH = Win32.GetDlgItem(InfoTabTabControlWH, (int)CtrID.InventoryTabID);
            CharInvListHandle = Win32.GetDlgItem(InventoryTabWH, (int)CtrID.CharInventoryID);
            //GET ServerNameHandle
            IntPtr LoginTabWH = Win32.GetDlgItem(MainTabsHandle, (int)CtrID.LoginTabID);
            IntPtr SilkroadLoginFrameWH = Win32.GetDlgItem(LoginTabWH, (int)CtrID.SilkroadLoginFrameID);
            ServerNameHandle = Win32.GetDlgItem(SilkroadLoginFrameWH, (int)CtrID.ServerNameID);
            CharNameHandle = Win32.GetDlgItem(SilkroadLoginFrameWH, (int)CtrID.CharNameID);

            CharHPProgressBarHandle = Win32.GetDlgItem(MainWindowHandle, (int)CtrID.CharHPProgressBarID);
            CharMPProgressBarHandle = Win32.GetDlgItem(MainWindowHandle, (int)CtrID.CharMPProgressBarID);
            CharExpProgressBarHandle = Win32.GetDlgItem(MainWindowHandle, (int)CtrID.CharExpProgressBarID);
            CharBerzerkProgressBarHandle = Win32.GetDlgItem(MainWindowHandle, (int)CtrID.CharBerzerkProgressBarID);

            AreaHandle = Win32.GetDlgItem(MainWindowHandle, (int)CtrID.AreaID);

        }
        public void InitiProperties()
        {
            GetCharName(); GetGuildName();
            GetSkillPoint(); GetGold();
            GetExperience(); GetLevel();
            GetPosX(); GetPosY();
            GetDiedCount();
            GetServerName();
            GetCharHPProgressBar(); GetCharMPProgressBar(); GetCharExpProgressBar(); GetCharBerzerkProgressBar();

            if (_StartupExperience == 0 && _StartupGold == 0 && _StartupExperience == 0)
            {
                if (_SkillPoint != string.Empty && _Gold != string.Empty && _Experience != string.Empty)
                {
                    _StartupSkill = Convert.ToDouble(_SkillPoint);
                    _StartupGold = Convert.ToDouble(_Gold);
                    _StartupExperience = Convert.ToDouble(_Experience);
                }
            }
            else
            {
                CalcSkillPointPerHour(); CalcGoldPerHour(); CalcExperiencePerHour();
            }
        }
        public static bool IsProcessbot(Process process)
        {
            if (process.ProcessName == ProcessName)
                return true;
            else
                return false;
        }
        private void SetMainWindowTitle()
        {
            if (BotAccount != null)
            {
                Win32.SetWindowText(MainWindowHandle, String.Format("{0} - {1}", BotTitle, BotAccount.CharName));
            }
            //if (BotAccount != null)
            //    Win32.SetWindowText(MainWindowHandle, String.Format("{0} - {1}", BotTitle, BotAccount.autoSelectChar));
            //else
            //{
            //    GetCharName();
            //    Win32.SetWindowText(MainWindowHandle, String.Format("{0} - {1}", BotTitle, CharName));
            //}
        }
        
        # region Properties
        public Process BotProcess
        {
            get
            {
                return _process;
            }
            set
            {
                _process = value;
                OnPropertyChanged("BotProcess");
            }
        }
        public Account BotAccount
        {
            get { return _account; }
            set 
            {
                //if (value != null)
                //    Managed = true;
                _account = value;
                if (value != null)
                {
                    _CharName = _account.CharName;
                    _ServerName = DataManager.ServerList[_account.silkroadServer];
                    SetMainWindowTitle();
                }
            }
        }

        private string _CharName;
        private void GetCharName()
        {
            Int32 size = Win32.SendMessage((int)CharNameHandle, Win32.WM_GETTEXTLENGTH, 0, 0).ToInt32();
            StringBuilder data = new StringBuilder(size + 1);
            Win32.SendMessage(CharNameHandle, Win32.WM_GETTEXT, data.Capacity, data);
            //CharName = _CharName if its not <None>
            if (data.ToString() != "<None>")
            {
                if (data.ToString() != _CharName)
                {
                    _CharName = data.ToString();
                    OnPropertyChanged("CharName");
                }
                return;
            }
        }
        public string CharName
        {
            get { return _CharName; }
        }

        private string _GuildName;
        private void GetGuildName()
        {
            Int32 size = Win32.SendMessage((int)GuildNameHandle, Win32.WM_GETTEXTLENGTH, 0, 0).ToInt32();
            StringBuilder data = new StringBuilder(size + 1);
            Win32.SendMessage(GuildNameHandle, Win32.WM_GETTEXT, data.Capacity, data);
            if (data.ToString() != _GuildName)
            {
                _GuildName = data.ToString();
                OnPropertyChanged("GuildName");
            }
        }
        public string GuildName
        {
            get { return _GuildName; }
        }

        private string _SkillPoint;
        private void GetSkillPoint()
        {
            Int32 size = Win32.SendMessage((int)SkillPointHandle, Win32.WM_GETTEXTLENGTH, 0, 0).ToInt32();
            StringBuilder data = new StringBuilder(size + 1);
            Win32.SendMessage(SkillPointHandle, Win32.WM_GETTEXT, data.Capacity, data);
            if (data.ToString() != _SkillPoint)
            {
                _SkillPoint = data.ToString();
                OnPropertyChanged("SkillPoint");
            }
        }
        public string SkillPoint
        {
            get { return Misc.FormateNumber(_SkillPoint); }
        }
        private void CalcSkillPointPerHour()
        {
            if (_Gold == string.Empty)
                return;
            TimeSpan ts = DateTime.Now.Subtract(StartupTime);
            double gained = Convert.ToDouble(_SkillPoint) - _StartupSkill;
            double NewSkillPointPetHour = (gained / ts.TotalSeconds) * 60 * 60;

            SkillPointPetHour = Misc.FormateNumber(NewSkillPointPetHour);
            OnPropertyChanged("SkillPointPetHour");
        }
        public string SkillPointPetHour
        {
            get;
            private set;
        }

        private string _Gold;
        private void GetGold()
        {
            Int32 size = Win32.SendMessage((int)GoldHandle, Win32.WM_GETTEXTLENGTH, 0, 0).ToInt32();
            StringBuilder data = new StringBuilder(size + 1);
            Win32.SendMessage(GoldHandle, Win32.WM_GETTEXT, data.Capacity, data);
            if (data.ToString() != _Gold)
            {
                _Gold = data.ToString();
                OnPropertyChanged("Gold");
            }
        }
        public string Gold
        {
            get { return Misc.FormateNumber(_Gold); }
        }
        private void CalcGoldPerHour()
        {
            if (_Gold == string.Empty)
                return;
            TimeSpan ts = DateTime.Now.Subtract(StartupTime);
            double gained = Convert.ToDouble(_Gold) - _StartupGold;
            double NewGoldPetHour = (gained / ts.TotalSeconds) * 60 * 60;

            GoldPetHour = Misc.FormateNumber(NewGoldPetHour);
            OnPropertyChanged("GoldPetHour");
        }
        public string GoldPetHour
        {
            get;
            private set;
        }

        private string _Experience;
        private void GetExperience()
        {
            Int32 size = Win32.SendMessage((int)ExperienceHandle, Win32.WM_GETTEXTLENGTH, 0, 0).ToInt32();
            StringBuilder data = new StringBuilder(size + 1);
            Win32.SendMessage(ExperienceHandle, Win32.WM_GETTEXT, data.Capacity, data);
            if (data.ToString() != _Experience)
            {
                _Experience = data.ToString();
                OnPropertyChanged("Experience");
            }
        }
        public string Experience
        {
            get { return Misc.FormateNumber(_Experience); }
        }
        private void CalcExperiencePerHour()
        {
            if (_Experience == string.Empty)
                return;
            TimeSpan ts = DateTime.Now.Subtract(StartupTime);
            double gained = Convert.ToDouble(_Experience) - _StartupExperience;
            double NewExperiencePetHour = (gained / ts.TotalSeconds) * 60 * 60;
            ExperiencePetHour = _Experience;
            OnPropertyChanged("ExperiencePetHour");
        }
        public string ExperiencePetHour
        {
            get;
            private set;
        }

        private string _Level;
        private void GetLevel()
        {
            Int32 size = Win32.SendMessage((int)LevelHandle, Win32.WM_GETTEXTLENGTH, 0, 0).ToInt32();
            StringBuilder data = new StringBuilder(size + 1);
            Win32.SendMessage(LevelHandle, Win32.WM_GETTEXT, data.Capacity, data);
            if (data.ToString() != _Level)
            {
                _Level = data.ToString();
                OnPropertyChanged("Level");
            }
        }
        public string Level
        {
            get { return _Level; }
        }

        private string _PosX;
        private void GetPosX()
        {
            Int32 size = Win32.SendMessage((int)PosXHandle, Win32.WM_GETTEXTLENGTH, 0, 0).ToInt32();
            StringBuilder data = new StringBuilder(size + 1);
            Win32.SendMessage(PosXHandle, Win32.WM_GETTEXT, data.Capacity, data);
            if (data.ToString() != _PosX)
            {
                _PosX = data.ToString();
                OnPropertyChanged("PosX");
            }
        }
        public string PosX
        {
            get { return _PosX; }
        }

        private string _PosY;
        private void GetPosY()
        {
            Int32 size = Win32.SendMessage((int)PosYHandle, Win32.WM_GETTEXTLENGTH, 0, 0).ToInt32();
            StringBuilder data = new StringBuilder(size + 1);
            Win32.SendMessage(PosYHandle, Win32.WM_GETTEXT, data.Capacity, data);
            if (data.ToString() != _PosY)
            {
                _PosY = data.ToString();
                OnPropertyChanged("PosY");
            }
        }
        public string PosY
        {
            get { return _PosY; }
        }

        private string _DiedCount;
        private void GetDiedCount()
        {
            Int32 size = Win32.SendMessage((int)DiedCountHandle, Win32.WM_GETTEXTLENGTH, 0, 0).ToInt32();
            StringBuilder data = new StringBuilder(size + 1);
            Win32.SendMessage(DiedCountHandle, Win32.WM_GETTEXT, data.Capacity, data);
            if (data.ToString() != _DiedCount)
            {
                _DiedCount = data.ToString();
                OnPropertyChanged("DiedCount");
            }
        }
        public string DiedCount
        {
            get { return _DiedCount; }
        }

        private int _DCCount;
        public int DCCount
        {
            get { return _DCCount; }
        }

        private int _TryConnectCount;
        public int TryConnectCount
        {
            get { return _TryConnectCount; }
        }

        private string _ServerName;
        private void GetServerName()
        {
            if (BotAccount != null)
            {
                if (DataManager.ServerList[BotAccount.silkroadServer] != _ServerName)
                {
                    _ServerName = DataManager.ServerList[BotAccount.silkroadServer];
                    OnPropertyChanged("ServerName");
                }
                return;
            }
            Int32 size = Win32.SendMessage((int)ServerNameHandle, Win32.WM_GETTEXTLENGTH, 0, 0).ToInt32();
            StringBuilder data = new StringBuilder(size + 1);
            Win32.SendMessage(ServerNameHandle, Win32.WM_GETTEXT, data.Capacity, data);
            if (data.ToString() != _ServerName)
            {
                _ServerName = data.ToString();
                OnPropertyChanged("ServerName");
            }
        }
        public string ServerName
        {
            get { return _ServerName; }
        }

        private List<string> _ClientlessLoginLogList = new List<string>();
        public StatusType LastStatus
        {
            get
            {
                if (_ClientlessLoginLogList.Count == 0)
                {
                    if (_process == null || _process.HasExited)
                        return StatusType.bot_Process_Terminated;
                    else
                        return StatusType.Unknown;
                }
                else
                    return ClientlessLoginLogAnalysis(_ClientlessLoginLogList[_ClientlessLoginLogList.Count - 1]);
            }
        }

        private List<string> _StatusLogList = new List<string>();
        public List<string> StatusLogList
        {
            get
            { return _StatusLogList; }
        }

        public int CharInventoryFreeSlot { get; set; }
        private List<string> _CharInventor = new List<string>();
        public List<string> CharInventory
        {
            get
            { return _CharInventor; }
        }

        public int PetInventoryFreeSlot { get; set; }
        private List<string> _PetInventor = new List<string>();
        public List<string> PetInventory
        {
            get
            { return _PetInventor; }
        }

        public StatusType Status
        {
            get { return _status; }
        }

        public bool Visable
        {
            get { return Win32.IsWindowVisible(MainWindowHandle.ToInt32()); }
            set
            {
                if (value)
                    MainWindowStyle(Win32.WindowShowStyle.Show);
                else
                    MainWindowStyle(Win32.WindowShowStyle.Hide);
                OnPropertyChanged("Visable");
            }
        }

        private int[] _CharHPProgressBar = new int[3];
        private void GetCharHPProgressBar()
        {
             int[] outInt = new int[3];

             outInt[0] = Win32.SendMessage(CharHPProgressBarHandle, (uint)Win32.ProgressBar_Cmd.PBM_GETRANGE, true, 0);
             outInt[1] = Win32.SendMessage(CharHPProgressBarHandle, (uint)Win32.ProgressBar_Cmd.PBM_GETRANGE, false, 0);
             outInt[2] = Win32.SendMessage(CharHPProgressBarHandle, (int)Win32.ProgressBar_Cmd.PBM_GETPOS, 0, 0);

             if (outInt[0] != _CharHPProgressBar[0] || outInt[1] != _CharHPProgressBar[1] || outInt[2] != _CharHPProgressBar[2])
             {
                 _CharHPProgressBar[0] = outInt[0]; _CharHPProgressBar[1] = outInt[1]; _CharHPProgressBar[2] = outInt[2];
                 OnPropertyChanged("CharHPProgressBar");
             }
        }
        public int[] CharHPProgressBar
        {
            get { return _CharHPProgressBar; }
        }

        private int[] _CharMPProgressBar = new int[3];
        private void GetCharMPProgressBar()
        {
            int[] outInt = new int[3];

            outInt[0] = Win32.SendMessage(CharMPProgressBarHandle, (uint)Win32.ProgressBar_Cmd.PBM_GETRANGE, true, 0);
            outInt[1] = Win32.SendMessage(CharMPProgressBarHandle, (uint)Win32.ProgressBar_Cmd.PBM_GETRANGE, false, 0);
            outInt[2] = Win32.SendMessage(CharMPProgressBarHandle, (int)Win32.ProgressBar_Cmd.PBM_GETPOS, 0, 0);

            if (outInt[0] != _CharMPProgressBar[0] || outInt[1] != _CharMPProgressBar[1] || outInt[2] != _CharMPProgressBar[2])
            {
                _CharMPProgressBar[0] = outInt[0]; _CharMPProgressBar[1] = outInt[1]; _CharMPProgressBar[2] = outInt[2];
                OnPropertyChanged("CharMPProgressBar");
            }
        }
        public int[] CharMPProgressBar
        {
            get { return _CharMPProgressBar; }
        }

        private int[] _CharExpProgressBar = new int[3];
        private void GetCharExpProgressBar()
        {
            int[] outInt = new int[3];

            outInt[0] = Win32.SendMessage(CharExpProgressBarHandle, (uint)Win32.ProgressBar_Cmd.PBM_GETRANGE, true, 0);
            outInt[1] = Win32.SendMessage(CharExpProgressBarHandle, (uint)Win32.ProgressBar_Cmd.PBM_GETRANGE, false, 0);
            outInt[2] = Win32.SendMessage(CharExpProgressBarHandle, (int)Win32.ProgressBar_Cmd.PBM_GETPOS, 0, 0);

            if (outInt[0] != _CharExpProgressBar[0] || outInt[1] != _CharExpProgressBar[1] || outInt[2] != _CharExpProgressBar[2])
            {
                _CharExpProgressBar[0] = outInt[0]; _CharExpProgressBar[1] = outInt[1]; _CharExpProgressBar[2] = outInt[2];
                OnPropertyChanged("CharExpProgressBar");
            }
        }
        public int[] CharExpProgressBar
        {
            get { return _CharExpProgressBar; }
        }

        private int[] _CharBerzerkProgressBar = new int[3];
        private void GetCharBerzerkProgressBar()
        {
            int[] outInt = new int[3];

            outInt[0] = Win32.SendMessage(CharBerzerkProgressBarHandle, (uint)Win32.ProgressBar_Cmd.PBM_GETRANGE, true, 0);
            outInt[1] = Win32.SendMessage(CharBerzerkProgressBarHandle, (uint)Win32.ProgressBar_Cmd.PBM_GETRANGE, false, 0);
            outInt[2] = Win32.SendMessage(CharBerzerkProgressBarHandle, (int)Win32.ProgressBar_Cmd.PBM_GETPOS, 0, 0);

            if (outInt[0] != _CharBerzerkProgressBar[0] || outInt[1] != _CharBerzerkProgressBar[1] || outInt[2] != _CharBerzerkProgressBar[2])
            {
                _CharBerzerkProgressBar[0] = outInt[0]; _CharBerzerkProgressBar[1] = outInt[1]; _CharBerzerkProgressBar[2] = outInt[2];
                OnPropertyChanged("CharBerzerkProgressBar");
            }
        }
        public int[] CharBerzerkProgressBar
        {
            get { return _CharBerzerkProgressBar; }
        }


        // Create the OnPropertyChanged method to raise the event 
        private void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
        # endregion

        private StatusType ClientlessLoginLogAnalysis(string log)
        {
            StatusType typ = StatusType.Unknown;
            if (log.Length == 0)
                return typ;
            string data = log.Substring(11);
            switch (data)
            {
                case "Connecting please wait... using login server: 0":
                case "Connecting please wait... using login server: 1":
                case "Connecting please wait... using login server: 2":
                case "Connecting please wait... using login server: 3":
                case "Connecting please wait... using login server: 4":
                case "Connecting please wait... using login server: 5":
                case "Connecting please wait... using login server: 6":
                    typ = StatusType.Connecting_please_wait;
                    break;
                case "Ready to login":
                    typ = StatusType.Ready_to_login;
                    break;
                case "Sending login informations":
                    typ = StatusType.Sending_login_informations;
                    break;
                case "Sending secondary passcode":
                    typ = StatusType.Sending_secondary_passcode;
                    break;
                case "Character listing":
                    typ = StatusType.Character_listing;
                    break;
                case "Login Successful":
                    typ = StatusType.Login_Successful;
                    break;
                case "Disconnected from server":
                    typ = StatusType.Disconnected_from_server;
                    break;
                case botTerminatedString:
                    typ = StatusType.bot_Process_Terminated;
                    break;
                case ErrorStuckOnLogin:
                    typ = StatusType.Error_Stuck_On_Login;
                    break;
                case ErrorScriptSteps:
                    typ = StatusType.Error_Script_Steps;
                    break;
                case ErrorC9PingTimeOut:
                     typ = StatusType.Error_C9PingTimeOut;
                    break;
                case ErrorHSIsDown:
                    typ = StatusType.Error_HS_Is_Down;
                    break;
                default://Unknown
                    break;
            }
            return typ;
        }
        private void AddEventItem(string item, bool StopActions = false)
        {
            _ClientlessLoginLogList.Add(item);
            _status = ClientlessLoginLogAnalysis(item);
            Console.WriteLine(_status.ToString());
            if (StopActions)
                return;
            switch (_status)
            {
                case StatusType.Connecting_please_wait:
                    StartLoginTimer();
                    _TryConnectCount++;
                    OnPropertyChanged("TryConnectCount");
                    break;
                case StatusType.Sending_login_informations:
                    break;
                case StatusType.Sending_secondary_passcode:
                    break;
                case StatusType.Character_listing:
                    break;
                case StatusType.Login_Successful:
                    if (tmrLogin != null)
                    {
                        tmrLogin.Dispose();
                        tmrLogin = null;
                    }
                    break;
                case StatusType.Disconnected_from_server:
                    _DCCount++;
                    OnPropertyChanged("DCCount");
                    StartLoginTimer();
                    break;
                case StatusType.bot_Process_Terminated:
                case StatusType.Error_Stuck_On_Login:
                case StatusType.Error_Script_Steps:
                    _StatusLogList.Clear();
                    _ClientlessLoginLogList.Clear();
                    break;
                case StatusType.Error_HS_Is_Down:
                    HSState = false;
                    break;
                case StatusType.Unknown:
                    break;
            }
            if (StateChanged != null)
                StateChanged(this, _status);
        }

        private void GetCharInventory()
        {
            bool InvChanded = false;
            Int32 size = Win32.SendMessage((int)CharInvListHandle, Win32.CB_GETCOUNT, 0, 0).ToInt32();
            if (_CharInventor.Count == 0)
                _CharInventor = new List<string>(new string[size]);

            CharInventoryFreeSlot = 0;
            for (int i = 0; i < size; i++)
            {
                int strLen = Win32.SendMessage((int)CharInvListHandle, Win32.CB_GETLBTEXTLEN, i, 0).ToInt32();
                StringBuilder text = new StringBuilder(255);
                Win32.SendMessage(CharInvListHandle, Win32.CB_GETLBTEXT, i, text);
                if (text.ToString() != _CharInventor[i])
                    InvChanded = true;
                _CharInventor[i] = text.ToString();
                if (text.ToString() == EmptySlotTitle)
                    CharInventoryFreeSlot++;
            }
            if (InvChanded)
            {
                Program.Logger.AddLog(Log.LogType.Debug, Log.LogLevel.Debug, "Char Inv Changed");
                OnPropertyChanged("CharInventory");
            }
        }

        private void AddStatusLogListItem(string item)
        {
            _StatusLogList.Add(item);
            if (LogAdded != null)
                LogAdded(this, item);// Rise event LogAdded

            //if (item.Contains(ErrorScriptSteps))
            //    AddEventItem("[00:00:00] " + ErrorScriptSteps);
            //else if (item.Contains(ErrorHSIsDown))
            //    AddEventItem("[00:00:00] " + ErrorHSIsDown);
        }
        private void GetStatusLogList()
        {
            Int32 size = Win32.SendMessage((int)statusLogHandle, Win32.CB_GETCOUNT, 0, 0).ToInt32();
            if (size == 0 || size == _StatusLogList.Count)
                return;
            for (int i = (size - _StatusLogList.Count) - 1; i >= 0; i--)
            {
                if (size == _StatusLogList.Count)
                    return;
                int strLen = Win32.SendMessage((int)statusLogHandle, Win32.CB_GETLBTEXTLEN, i, 0).ToInt32();
                StringBuilder text = new StringBuilder(255);
                Win32.SendMessage(statusLogHandle, Win32.CB_GETLBTEXT, i, text);
                AddStatusLogListItem(text.ToString());
            }
        }

        private IntPtr FindMainWindowInProcess(string compareTitle)
        {
            IntPtr windowHandle = IntPtr.Zero;

            foreach (ProcessThread t in _process.Threads)
            {
                windowHandle = FindMainWindowInThread(t.Id, compareTitle);
                if (windowHandle != IntPtr.Zero)
                {
                    break;
                }
            }

            return windowHandle;
        }
        private IntPtr FindMainWindowInThread(int threadId, string compareTitle)
        {
            IntPtr windowHandle = IntPtr.Zero;
            Win32.EnumThreadWindows(threadId, (hWnd, lParam) =>
            {
                if (Win32.FindWindowEx(hWnd, IntPtr.Zero, null, compareTitle) != IntPtr.Zero)
                {
                    windowHandle = hWnd;
                    return false;
                }
                else
                    return true;
            }, IntPtr.Zero);

            return windowHandle;
        }
        public void MainWindowStyle(Win32.WindowShowStyle style)
        {
            Win32.ShowWindowAsync(MainWindowHandle, style);
            //ShowWindow(MainWindowHandle, SW_HIDE);
            //ShowWindow(MainWindowHandle, SW_SHOWNORMAL);
            //SendMessage(MainWindowHandle, WM_SYSCOMMAND, SC_MINIMIZE, 0);
        }

        private Process Runbot()
        {
            Process process = new Process();
            process.StartInfo = new ProcessStartInfo(Properties.Settings.Default.CenterBotPath, BotAccount.CommandLineArg)
            {
                WorkingDirectory = Properties.Settings.Default.CenterBotPath.Substring(0, Properties.Settings.Default.CenterBotPath.LastIndexOf(Convert.ToChar("\\")))
            };
            process.Start();
            process.WaitForInputIdle();
            return process;
        }
        public void Start()
        {
            if (_process == null)
            {
                _process = Runbot();
                PrepareHandlers();
            }
            _process.Exited += _process_Exited;
            StartPlusTimer();
            System.Threading.Thread.Sleep(500);
            Visable = false;
        }
        public void Stop()
        {
            lock (this)
            {
                Dispose();
            }
        }
        private void PerformClick(IntPtr hwnd)
        {
            Win32.SendMessage(hwnd, Win32.BM_CLICK, 0, 0);
        }
        public void PerformRestartBot()
        {
            //_process_Exited(null, EventArgs.Empty);
            if (_process != null && !_process.HasExited)
            {
                _process.Kill();
                _process.WaitForExit();
            }
            //Start();
        }

        void _process_Exited(object sender, EventArgs e)
        {
            if (!HSState)
                return;
            AddEventItem("[00:00:00] " + botTerminatedString);
        }

        # region Dispose
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_process != null)
                {
                    _process.Exited -= _process_Exited;
                    if (!_process.HasExited)
                        _process.Kill();
                    _process.Dispose();
                    _process = null;

                }
                _ClientlessLoginLogList.Clear();
                _StatusLogList.Clear();
                _CharInventor.Clear();
                _PetInventor.Clear();
            }
        }
        ~CenterBot()
        {
            Dispose(false);
        }
        # endregion

    }
}
