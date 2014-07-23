using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;


namespace IbotControl
{
    public class IBot : IDisposable , INotifyPropertyChanged
    {
        #region Vars
        public int ID = new Random().Next(60000);
        private DateTime StartupTime = DateTime.Now;
        private const string DonatebtnCaption = "DONATE!";
        public const string BotTitle = "ISRO - iBot";
        private const string ProcessName = "iBot";
        private const string MapWindowTitle = "[iBot] Silkroad Map";
        public const string DisconnectedMSG = "Disconnected from server";
        public const string LoginSuccessfulMSG = "Login Successful";
        public const string EmptySlotTitle = "[Empty]";
        public const string ErrorScriptSteps = "Error - Next position is too far!";
        public const string ErrorHSIsDown = "* HS Server is busy or down!";
        public const string ErrorC9PingTimeOut = "C9 Error (Ping timeout)";
        public const string IbotTerminatedString = "Ibot Process Terminated";
        public const string ErrorStuckOnLogin = "Error_Stuck_On_Login";
        private Process _process;
        private Account _account;
        private StatusType _status = StatusType.Nothing;
        public System.Threading.Timer tmrPuls;
        public System.Threading.Timer tmrLogin;
        public bool HSState = true;

        private double _StartupSkill, _StartupGold, _StartupExperience = 0;

        public delegate void ChangedEventhandler(IBot sender, StatusType e); public event ChangedEventhandler StateChanged;
        public delegate void LogAddedEventhandler(IBot sender, string Log); public event LogAddedEventhandler LogAdded;
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        # region IntPtr
        private IntPtr MainWindowHandle { get; set; }
        private IntPtr MainTabsHandle { get; set; }
        private IntPtr LoginTabsHandle { get; set; }
        private IntPtr ClientlessLoginLogHandle { get; set; }
        private IntPtr PlayerInfoFrameHandle { get; set; }
        private IntPtr CharNameHandle { get; set; }
        private IntPtr TrainingStatisticsHnadle { get; set; }
        private IntPtr GuildNameHandle { get; set; }
        private IntPtr SkillPointHandle { get; set; }
        private IntPtr GoldHandle { get; set; }
        private IntPtr ExperienceHandle { get; set; }
        private IntPtr LevelHandle { get; set; }
        private IntPtr PosXHandle { get; set; }
        private IntPtr PosYHandle { get; set; }
        private IntPtr PickItemsHandle { get; set; }
        private IntPtr DiedCountHandle { get; set; }
        private IntPtr LoopCountHandle { get; set; }
        private IntPtr ServerNameHandle { get; set; }
        private IntPtr AutoSelectCharNameTBHandle { get; set; }
        private IntPtr ConnectCharBtnHandle { get; set; }
        private IntPtr ConnectLoginBtnHandle { get; set; }
        private IntPtr CharInvListHandle { get; set; }
        private IntPtr PetInvListHandle { get; set; }
        private IntPtr StatusLogFrameHandle { get; set; }
        private IntPtr statusLogListHandle { get; set; }
        private IntPtr ReturnToTownBtnHandle { get; set; }

        private IntPtr CharHPProgressBarHandle { get; set; }
        private IntPtr CharMPProgressBarHandle { get; set; }
        private IntPtr CharExpProgressBarHandle { get; set; }
        private IntPtr CharBerzerkProgressBarHandle { get; set; }
        private IntPtr PetHPProgressBarHandle { get; set; }
        private IntPtr PetHGPProgressBarHandle { get; set; }
        private IntPtr TransHPProgressBarHandle { get; set; }

        # endregion

        # region Types
        private enum CtrID : int
        {
            PlayerInfoFrame = 0x000001A5,//421
            CharNameID = 0x000001BB,//443
            GuildNameID = 0x000001BA,
            SkillPointID = 0x000001B9, //441
            GoldID = 0x000001B8,//440
            ExperienceID = 0x000001AD,//429
            LevelID = 0x000001B5,//437
            PosXID = 0x000001B6,//438
            PosYID = 0x000001AE,//430
            PickItemsID = 0x000001CA,//458
            DiedCountID = 0x000001C9,//457
            LoopCountID = 0x000001C2,//450
            ClientLessLoginLog = 0x00000288,//648
            ServerNameID = 0x00000269,//617
            ConnectCharBtnID = 0x00000268,//616
            AutoSelectCharNameTBID = 0x00000276,//630
            CharInventoryID = 0x000001E8,//488
            PetInventoryID = 0x000001D3,//467
            StatusLogFrameID = 0x000002E3,//741
            StatusLogID = 0x000002E5,//741
            MapFunctionsFrameID = 0x00000009,//9
            ReturnToTownBtnID = 0x0000000A,//10
            ConnectLoginBtnID = 0x000001F8,//504
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
            Ibot_Process_Terminated,
            Error_Script_Steps,
            Error_Stuck_On_Login,
            Error_C9PingTimeOut,
            Error_HS_Is_Down,
            Nothing,
            Unknown
        }
        # endregion

        public IBot()
        {
            //InitPulsTimer();
            //InitiTmrLogin();  
        }
        public static IBot CreateIbot(Process botProcess = null)
        {
            IBot bot = new IBot();
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
            GetClientlessLoginLog();
            GetStatusLogList();
            if (_status == StatusType.Login_Successful)
            {
                GetCharInventory();
                GetPetInventory();
                InitiProperties();
            }
        }
        void tmrLogin_Tick()
        {
            tmrLogin.Dispose(); tmrLogin = null;
            if (_process == null || _process.HasExited)
                return;

            if (_status != StatusType.Login_Successful)
                AddClientlessLoginLogItem("[00:00:00] " + ErrorStuckOnLogin);
        }

        public void PrepareHandlers()
        {
            MainWindowHandle = FindMainWindowInProcess(DonatebtnCaption); 
            MainTabsHandle = Win32.FindWindowEx(MainWindowHandle, IntPtr.Zero, "SSTabCtlWndClass", null);
            PlayerInfoFrameHandle = Win32.GetDlgItem(MainTabsHandle, (int)CtrID.PlayerInfoFrame);
            CharNameHandle = Win32.GetDlgItem(PlayerInfoFrameHandle, (int)CtrID.CharNameID);
            TrainingStatisticsHnadle = Win32.FindWindowEx(MainTabsHandle, IntPtr.Zero, "ThunderRT6Frame", "Training Statistics");
            GuildNameHandle = Win32.GetDlgItem(PlayerInfoFrameHandle, (int)CtrID.GuildNameID);
            SkillPointHandle = Win32.GetDlgItem(PlayerInfoFrameHandle, (int)CtrID.SkillPointID);
            GoldHandle = Win32.GetDlgItem(PlayerInfoFrameHandle, (int)CtrID.GoldID);
            ExperienceHandle = Win32.GetDlgItem(PlayerInfoFrameHandle, (int)CtrID.ExperienceID);
            LevelHandle = Win32.GetDlgItem(PlayerInfoFrameHandle, (int)CtrID.LevelID);
            PosXHandle = Win32.GetDlgItem(PlayerInfoFrameHandle, (int)CtrID.PosXID);
            PosYHandle = Win32.GetDlgItem(PlayerInfoFrameHandle, (int)CtrID.PosYID);
            PickItemsHandle = Win32.GetDlgItem(TrainingStatisticsHnadle, (int)CtrID.PickItemsID);
            DiedCountHandle = Win32.GetDlgItem(TrainingStatisticsHnadle, (int)CtrID.DiedCountID);
            LoopCountHandle = Win32.GetDlgItem(TrainingStatisticsHnadle, (int)CtrID.LoopCountID);
            StatusLogFrameHandle = Win32.GetDlgItem(MainTabsHandle, (int)CtrID.StatusLogFrameID);
            statusLogListHandle = Win32.GetDlgItem(StatusLogFrameHandle, (int)CtrID.StatusLogID);

            ClientlessLoginLogHandle = IntPtr.Zero;
            while (ClientlessLoginLogHandle == IntPtr.Zero)
            {
                LoginTabsHandle = Win32.FindWindowEx(MainTabsHandle, LoginTabsHandle, "SSTabCtlWndClass", null);
                IntPtr ClientlessLoginLog = Win32.FindWindowEx(LoginTabsHandle, IntPtr.Zero, "ThunderRT6Frame", "Clientless Login Log");
                if (ClientlessLoginLog == IntPtr.Zero)
                    continue;
                ClientlessLoginLogHandle = Win32.GetDlgItem(ClientlessLoginLog, (int)CtrID.ClientLessLoginLog);
            }

            ServerNameHandle = IntPtr.Zero;
            while (ServerNameHandle == IntPtr.Zero)
            {
                LoginTabsHandle = Win32.FindWindowEx(MainTabsHandle, LoginTabsHandle, "SSTabCtlWndClass", null);
                IntPtr LoginInformation = Win32.FindWindowEx(LoginTabsHandle, IntPtr.Zero, "ThunderRT6Frame", "Login Information");
                if (LoginInformation == IntPtr.Zero)
                    continue;
                ServerNameHandle = Win32.GetDlgItem(LoginInformation, (int)CtrID.ServerNameID);
                ConnectCharBtnHandle = Win32.GetDlgItem(LoginInformation, (int)CtrID.ConnectCharBtnID);

                IntPtr AutoSelectCharacter = Win32.FindWindowEx(LoginTabsHandle, IntPtr.Zero, "ThunderRT6Frame", "Auto-Select Character");
                AutoSelectCharNameTBHandle = Win32.GetDlgItem(AutoSelectCharacter, (int)CtrID.AutoSelectCharNameTBID);
            }

            CharInvListHandle = IntPtr.Zero; PetInvListHandle = IntPtr.Zero;
            while (CharInvListHandle == IntPtr.Zero && PetInvListHandle == IntPtr.Zero)
            {
                LoginTabsHandle = Win32.FindWindowEx(MainTabsHandle, LoginTabsHandle, "SSTabCtlWndClass", null);
                if (Win32.FindWindowEx(LoginTabsHandle, IntPtr.Zero, "ThunderRT6Frame", "Clientless Login Log") != IntPtr.Zero)
                {
                    IntPtr Sub2ndTab = Win32.FindWindowEx(LoginTabsHandle, IntPtr.Zero, "SSTabCtlWndClass", null);

                    IntPtr PlayerInv = Win32.FindWindowEx(Sub2ndTab, IntPtr.Zero, "ThunderRT6Frame", "Player Inventory");
                    CharInvListHandle = Win32.GetDlgItem(PlayerInv, (int)CtrID.CharInventoryID);

                    IntPtr PetInv = Win32.FindWindowEx(Sub2ndTab, IntPtr.Zero, "ThunderRT6Frame", "Pet Inventory");
                    PetInvListHandle = Win32.GetDlgItem(PetInv, (int)CtrID.PetInventoryID);
                }
                else
                    continue;
            }

            while (ConnectLoginBtnHandle == IntPtr.Zero)
            {
                LoginTabsHandle = Win32.FindWindowEx(MainTabsHandle, LoginTabsHandle, "SSTabCtlWndClass", null);
                IntPtr LoginType = Win32.FindWindowEx(LoginTabsHandle, IntPtr.Zero, "ThunderRT6Frame", "Login Type");
                if (LoginType == IntPtr.Zero)
                    continue;
                ConnectLoginBtnHandle = Win32.GetDlgItem(LoginType, (int)CtrID.ConnectLoginBtnID);
            }

            IntPtr CurForLoop = IntPtr.Zero;
            
            CurForLoop = Win32.FindWindowEx(PlayerInfoFrameHandle, CurForLoop, "ThunderRT6UserControlDC", null);
            CharHPProgressBarHandle = Win32.FindWindowEx(CurForLoop, IntPtr.Zero, "msctls_progress32", null);

            CurForLoop = Win32.FindWindowEx(PlayerInfoFrameHandle, CurForLoop, "ThunderRT6UserControlDC", null);
            PetHPProgressBarHandle = Win32.FindWindowEx(CurForLoop, IntPtr.Zero, "msctls_progress32", null);

            CurForLoop = Win32.FindWindowEx(PlayerInfoFrameHandle, CurForLoop, "ThunderRT6UserControlDC", null);
            CharMPProgressBarHandle = Win32.FindWindowEx(CurForLoop, IntPtr.Zero, "msctls_progress32", null);

            CurForLoop = Win32.FindWindowEx(PlayerInfoFrameHandle, CurForLoop, "ThunderRT6UserControlDC", null);
            CharExpProgressBarHandle = Win32.FindWindowEx(CurForLoop, IntPtr.Zero, "msctls_progress32", null);

            CurForLoop = Win32.FindWindowEx(PlayerInfoFrameHandle, CurForLoop, "ThunderRT6UserControlDC", null);
            CharBerzerkProgressBarHandle = Win32.FindWindowEx(CurForLoop, IntPtr.Zero, "msctls_progress32", null);

            CurForLoop = Win32.FindWindowEx(PlayerInfoFrameHandle, CurForLoop, "ThunderRT6UserControlDC", null);
            PetHGPProgressBarHandle = Win32.FindWindowEx(CurForLoop, IntPtr.Zero, "msctls_progress32", null);

            CurForLoop = Win32.FindWindowEx(PlayerInfoFrameHandle, CurForLoop, "ThunderRT6UserControlDC", null);
            TransHPProgressBarHandle = Win32.FindWindowEx(CurForLoop, IntPtr.Zero, "msctls_progress32", null);

            //while (CharHPProgressBarHandle == IntPtr.Zero || CharMPProgressBarHandle == IntPtr.Zero || CharExpProgressBarHandle == IntPtr.Zero ||
            //    CharBerzerkProgressBarHandle == IntPtr.Zero || PetHPProgressBarHandle == IntPtr.Zero || PetHGPProgressBarHandle == IntPtr.Zero || TransHPProgressBarHandle == IntPtr.Zero)
            //    {
            //}
            //int PBColor = Win32.SendMessageA(PB, 8193, 0, 0);
            //Color color = Misc.GetColor((uint)PBColor);
            //if (color == Color.Maroon)
            //    CharHPProgressBarHandle = PB;
            //else if (color == Color.Navy)
            //    CharMPProgressBarHandle = PB;
            //else if (color == Color.Green)
            //    CharExpProgressBarHandle = PB;
            //else if (color == Color.FromArgb(0xFF, 0x80, 0x80))
            //    CharBerzerkProgressBarHandle = PB;
            //else if (color == Color.Gray)
            //    PetHPProgressBarHandle = PB;
            //else if (color == Color.FromArgb(0xC0, 0xC0, 0x00))
            //    PetHGPProgressBarHandle = PB;
            //else if (color == Color.FromArgb(0xFF, 0x80, 0x00))
            //    TransHPProgressBarHandle = PB;

            //Win32.SendMessage(MainWindowHandle.ToInt32(), Win32.WM_KEYDOWN, Win32.VK_CONTROL, 0);
            //Win32.SendMessage(MainWindowHandle.ToInt32(), Win32.WM_KEYDOWN, Win32.VK_M, 0); 
            //Win32.SendMessage(MainWindowHandle.ToInt32(), Win32.WM_KEYUP, Win32.VK_CONTROL, 0);
            //IntPtr MapWindowHandle = FindMainWindowInProcess("Map Functions");
            //IntPtr MapFunctionFrame = Win32.GetDlgItem(MapWindowHandle, (int)CtrID.MapFunctionsFrameID);
            //ReturnToTownBtnHandle = Win32.GetDlgItem(MapFunctionFrame, (int)CtrID.ReturnToTownBtnID);
        }
        public void InitiProperties()
        {
            GetCharName(); GetGuildName();
            GetSkillPoint(); GetGold();
            GetExperience(); GetLevel();
            GetPosX(); GetPosY();
            GetPickItems(); GetDiedCount();
            GetLoopCount(); GetServerName();
            GetCharHPProgressBar(); GetCharMPProgressBar(); GetCharExpProgressBar(); GetCharBerzerkProgressBar(); GetPetHPProgressBar();
            GetPetHGPProgressBar(); GetTransHPProgressBar();
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
                Win32.SetWindowText(MainWindowHandle, String.Format("{0} - {1}", BotTitle, BotAccount.autoSelectChar));
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
                    _CharName = _account.autoSelectChar;
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
            Int32 sizeTB = Win32.SendMessage((int)AutoSelectCharNameTBHandle, Win32.WM_GETTEXTLENGTH, 0, 0).ToInt32();
            StringBuilder dataTB = new StringBuilder(sizeTB + 1);
            Win32.SendMessage(AutoSelectCharNameTBHandle, Win32.WM_GETTEXT, dataTB.Capacity, dataTB);
            //CharName = _CharNameTB if its not Empty or it will be <None>
            if (dataTB.ToString() != string.Empty)
            {
                if (dataTB.ToString() != _CharName)
                {
                    _CharName = dataTB.ToString();
                    OnPropertyChanged("CharName");
                }
            }
            else
            {
                if (data.ToString() != _CharName)
                {
                    _CharName = data.ToString();
                    OnPropertyChanged("CharName");
                }
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
            ExperiencePetHour = Misc.FormateNumber(NewExperiencePetHour);
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

        private string _PickItems;
        private void GetPickItems()
        {
            Int32 size = Win32.SendMessage((int)PickItemsHandle, Win32.WM_GETTEXTLENGTH, 0, 0).ToInt32();
            StringBuilder data = new StringBuilder(size + 1);
            Win32.SendMessage(PickItemsHandle, Win32.WM_GETTEXT, data.Capacity, data);
            if (data.ToString() != _PickItems)
            {
                _PickItems = data.ToString();
                OnPropertyChanged("PickItems");
            }
        }
        public string PickItems
        {
            get { return _PickItems; }
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

        private string _LoopCount;
        private void GetLoopCount()
        {
            Int32 size = Win32.SendMessage((int)LoopCountHandle, Win32.WM_GETTEXTLENGTH, 0, 0).ToInt32();
            StringBuilder data = new StringBuilder(size + 1);
            Win32.SendMessage(LoopCountHandle, Win32.WM_GETTEXT, data.Capacity, data);
            if (data.ToString() != _LoopCount)
            {
                _LoopCount = data.ToString();
                OnPropertyChanged("LoopCount");
            }
        }
        public string LoopCount
        {
            get { return _LoopCount; }
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
                        return StatusType.Ibot_Process_Terminated;
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

        private int[] _PetHPProgressBar = new int[3];
        private void GetPetHPProgressBar()
        {
            int[] outInt = new int[3];

            outInt[0] = Win32.SendMessage(PetHPProgressBarHandle, (uint)Win32.ProgressBar_Cmd.PBM_GETRANGE, true, 0);
            outInt[1] = Win32.SendMessage(PetHPProgressBarHandle, (uint)Win32.ProgressBar_Cmd.PBM_GETRANGE, false, 0);
            outInt[2] = Win32.SendMessage(PetHPProgressBarHandle, (int)Win32.ProgressBar_Cmd.PBM_GETPOS, 0, 0);

            if (outInt[0] != _PetHPProgressBar[0] || outInt[1] != _PetHPProgressBar[1] || outInt[2] != _PetHPProgressBar[2])
            {
                _PetHPProgressBar[0] = outInt[0]; _PetHPProgressBar[1] = outInt[1]; _PetHPProgressBar[2] = outInt[2];
                OnPropertyChanged("PetHPProgressBar");
            }
        }
        public int[] PetHPProgressBar
        {
            get { return _PetHPProgressBar; }
        }

        private int[] _PetHGPProgressBar = new int[3];
        private void GetPetHGPProgressBar()
        {
            int[] outInt = new int[3];

            outInt[0] = Win32.SendMessage(PetHGPProgressBarHandle, (uint)Win32.ProgressBar_Cmd.PBM_GETRANGE, true, 0);
            outInt[1] = Win32.SendMessage(PetHGPProgressBarHandle, (uint)Win32.ProgressBar_Cmd.PBM_GETRANGE, false, 0);
            outInt[2] = Win32.SendMessage(PetHGPProgressBarHandle, (int)Win32.ProgressBar_Cmd.PBM_GETPOS, 0, 0);

            if (outInt[0] != _PetHGPProgressBar[0] || outInt[1] != _PetHGPProgressBar[1] || outInt[2] != _PetHGPProgressBar[2])
            {
                _PetHGPProgressBar[0] = outInt[0]; _PetHGPProgressBar[1] = outInt[1]; _PetHGPProgressBar[2] = outInt[2];
                OnPropertyChanged("PetHGPProgressBar");
            }
        }
        public int[] PetHGPProgressBar
        {
            get { return _PetHGPProgressBar; }
        }

        private int[] _TransHPProgressBar = new int[3];
        private void GetTransHPProgressBar()
        {
            int[] outInt = new int[3];

            outInt[0] = Win32.SendMessage(TransHPProgressBarHandle, (uint)Win32.ProgressBar_Cmd.PBM_GETRANGE, true, 0);
            outInt[1] = Win32.SendMessage(TransHPProgressBarHandle, (uint)Win32.ProgressBar_Cmd.PBM_GETRANGE, false, 0);
            outInt[2] = Win32.SendMessage(TransHPProgressBarHandle, (int)Win32.ProgressBar_Cmd.PBM_GETPOS, 0, 0);

            if (outInt[0] != _TransHPProgressBar[0] || outInt[1] != _TransHPProgressBar[1] || outInt[2] != _TransHPProgressBar[2])
            {
                _TransHPProgressBar[0] = outInt[0]; _TransHPProgressBar[1] = outInt[1]; _TransHPProgressBar[2] = outInt[2];
                OnPropertyChanged("TransHPProgressBar");
            }
        }
        public int[] TransHPProgressBar
        {
            get { return _TransHPProgressBar; }
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
                case IbotTerminatedString:
                    typ = StatusType.Ibot_Process_Terminated;
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
        private void AddClientlessLoginLogItem(string item, bool StopActions = false)
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
                case StatusType.Ready_to_login:
                    PerformClick(ConnectCharBtnHandle);
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
                case StatusType.Ibot_Process_Terminated:
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
        public void GetClientlessLoginLog()
        {
            if (_process == null || _process.HasExited)
                return;
            //System.Threading.ThreadPool.QueueUserWorkItem((o) =>
            //{
            //});
            Int32 size = Win32.SendMessage((int)ClientlessLoginLogHandle, Win32.CB_GETCOUNT, 0, 0).ToInt32();
            if (size == 0 || size == _ClientlessLoginLogList.Count)
                return;
            for (int i = (size - _ClientlessLoginLogList.Count) - 1; i >= 0; i--)
            {
                if (size == _ClientlessLoginLogList.Count)
                    return;
                int strLen = Win32.SendMessage((int)ClientlessLoginLogHandle, Win32.CB_GETLBTEXTLEN, i, 0).ToInt32();
                StringBuilder text = new StringBuilder(255);
                Win32.SendMessage(ClientlessLoginLogHandle, Win32.CB_GETLBTEXT, i, text);
                AddClientlessLoginLogItem(text.ToString());
            }
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
        private void GetPetInventory()
        {
            bool InvChanded = false;
            Int32 size = Win32.SendMessage((int)PetInvListHandle, Win32.CB_GETCOUNT, 0, 0).ToInt32();
            if (_PetInventor.Count == 0)
                _PetInventor = new List<string>(new string[size]);
            PetInventoryFreeSlot = 0;
            for (int i = 0; i < size; i++)
            {
                int strLen = Win32.SendMessage((int)PetInvListHandle, Win32.CB_GETLBTEXTLEN, i, 0).ToInt32();
                StringBuilder text = new StringBuilder(255);
                Win32.SendMessage(PetInvListHandle, Win32.CB_GETLBTEXT, i, text);
                if (text.ToString() != _PetInventor[i])
                    InvChanded = true;
                _PetInventor[i] = text.ToString();
                if (text.ToString() == EmptySlotTitle)
                    PetInventoryFreeSlot++;
            }
            if (InvChanded)
                OnPropertyChanged("PetInventory");
        }

        private void AddStatusLogListItem(string item)
        {
            _StatusLogList.Add(item);
            if (LogAdded != null)
                LogAdded(this, item);// Rise event LogAdded
            if (item.Contains(ErrorScriptSteps))
                AddClientlessLoginLogItem("[00:00:00] " + ErrorScriptSteps);
            else if (item.Contains(ErrorHSIsDown))
                AddClientlessLoginLogItem("[00:00:00] " + ErrorHSIsDown);
        }
        private void GetStatusLogList()
        {
            Int32 size = Win32.SendMessage((int)statusLogListHandle, Win32.CB_GETCOUNT, 0, 0).ToInt32();
            if (size == 0 || size == _StatusLogList.Count)
                return;
            for (int i = (size - _StatusLogList.Count) - 1; i >= 0; i--)
            {
                if (size == _StatusLogList.Count)
                    return;
                int strLen = Win32.SendMessage((int)statusLogListHandle, Win32.CB_GETLBTEXTLEN, i, 0).ToInt32();
                StringBuilder text = new StringBuilder(255);
                Win32.SendMessage(statusLogListHandle, Win32.CB_GETLBTEXT, i, text);
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

        private Process RunIbot()
        {
            Process process = new Process();
            process.StartInfo = new ProcessStartInfo(BotAccount.IbotFilePath, BotAccount.CommandLineArg)
            {
                WorkingDirectory = BotAccount.IbotFilePath.Substring(0, BotAccount.IbotFilePath.LastIndexOf(Convert.ToChar("\\")))
            };
            process.Start();
            process.WaitForInputIdle();
            return process;
        }
        public void Start()
        {
            if (_process == null)
            {
                _process = RunIbot();
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
        public void PerformReturnToCity()
        {
            PerformClick(ReturnToTownBtnHandle);
        }

        void _process_Exited(object sender, EventArgs e)
        {
            if (!HSState)
                return;
            AddClientlessLoginLogItem("[00:00:00] " + IbotTerminatedString);
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
        ~IBot()
        {
            Dispose(false);
        }
        # endregion

    }
}
