using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

using System.Text;
using System.Windows.Forms;

namespace CenterBotControl
{
    public class BotsManager
    {

        public BotsManager()
        {
            //ManagerOnline = true;
            //GetStartedIBots();
        }
        public List<CenterBot> Bots = new List<CenterBot>();
        public enum ChangesType
        {
            Added,
            Updated,
            Deleted
        }
        public delegate void BotListChangedEventhandler(object sender, ChangesType e);
        public event BotListChangedEventhandler BotListChanged;
        public event BotListChangedEventhandler AccountListChanged;
        private bool ManagerOnline;

        public void AddAccount(string Server, string User, string Password, string Passcode, string Charname, string IP, bool Start)
        {
            Account acc = new Account(Server, User, Password, Start, IP, Passcode, Charname);
            AddAccount(acc);
        }
        public void AddAccount(Account account)
        {
            Program.DM.Accounts.Add(account);
            if (AccountListChanged != null)
                AccountListChanged(account, ChangesType.Added);

            if (account.Start && ManagerOnline)
                AddBot(account);
        }
        public void UpdateAccount(int index, string Server, string User, string Password, string Passcode, string Charname, string IP, bool Start)
        {
            Account account = Program.DM.Accounts[index];
            account.silkroadServer = Server;
            account.silkroadUser = User;
            account.silkroadPass = Password;
            account.secondPasscode = Passcode;
            account.CharName = Charname;
            account.LoginIP = IP;
            if (AccountListChanged != null)
                AccountListChanged(account, ChangesType.Updated);
            account.Start = Start;
            if (account.Start && ManagerOnline && account.bot == null)
                AddBot(account);
        }
        public void RemoveAccount(int index)
        {
            if (Program.DM.Accounts[index].bot != null)
            {
                MessageBox.Show("Can't delete bot already processed.", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (AccountListChanged != null)
                AccountListChanged(Program.DM.Accounts[index], ChangesType.Deleted);
            Program.DM.Accounts.RemoveAt(index);
        }
        public Account SearchAccount(string CharName, string silkroadServer)
        {
            Account acc = null;
            for (int i = 0; i < Program.DM.Accounts.Count; i++)
            {
                if (Program.DM.Accounts[i].CharName == CharName && DataManager.ServerList[Program.DM.Accounts[i].silkroadServer] == silkroadServer)
                {
                    acc = Program.DM.Accounts[i];
                    break;
                }
            }
            return acc;
        }

        public void AddBot(Account account)
        {
            lock (this)
            {
                CenterBot bot = CenterBot.Createbot();
                account.bot = bot; bot.BotAccount = account;
                AddBot(bot);
            }
        }
        private void Addbot(Process botprocess)
        {
            lock (this)
            {
                CenterBot bot = CenterBot.Createbot(botprocess);
                bot.PrepareHandlers(); bot.InitiProperties(); /////bot.GetClientlessLoginLog();
                if (bot.CharName == string.Empty)
                    return;
                Account account = SearchAccount(bot.CharName, bot.ServerName);
                if (account != null)
                    account.bot = bot; bot.BotAccount = account;
                AddBot(bot);
            }
        }
        private void AddBot(CenterBot bot)
        {
            Bots.Add(bot);
            bot.StateChanged += bot_StateChanged;
            bot.PropertyChanged += bot_PropertyChanged;

            Program.Logger.AddLog(Log.LogType.Info, Log.LogLevel.Stander, string.Format("[{0}][{1}]- Ready", bot.CharName, bot.ServerName));
            if (BotListChanged != null)
                BotListChanged(bot, ChangesType.Added);
            bot.Start();
        }
        public void RemoveBot(CenterBot bot)
        {
            if (BotListChanged != null)
                BotListChanged(bot, ChangesType.Deleted);
            bot.StateChanged -= bot_StateChanged; bot.PropertyChanged -= bot_PropertyChanged;
            bot.BotAccount.bot = null;
            Program.Logger.AddLog(Log.LogType.Info, Log.LogLevel.Stander, string.Format("[{0}][{1}]- Closed", bot.BotAccount.CharName, DataManager.ServerList[bot.BotAccount.silkroadServer]));
            lock (Bots)
                Bots.Remove(bot);
            bot.Dispose();
        }
        private void GetStartedBots()
        {
            foreach (Process process in Process.GetProcesses())
            {
                bool isbot = CenterBot.IsProcessbot(process);
                if (!isbot)
                    continue;
                bool found = false;
                foreach (CenterBot bot in Bots)
                {
                    if (bot.BotProcess != null && bot.BotProcess.Id == process.Id)
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    Addbot(process);
                    System.Threading.Thread.Sleep(1000);
                }
            }
        }
        public void KillBotProcess(int botIndex)
        {
            Process process = Bots[botIndex].BotProcess;
            if (process != null)
            {
                if (!process.HasExited)
                    process.Kill();
            }
        }
        public CenterBot SearchBot(string CharName, string ServerName)
        {
            CenterBot bot = null;
            for (int i = 0; i < Bots.Count; i++)
            {
                if (Bots[i].CharName == CharName && Bots[i].ServerName == ServerName)
                {
                    bot = Bots[i];
                    break;
                }
            }
            return bot;
        }
        
        void bot_StateChanged(CenterBot sender, CenterBot.StatusType e)
        {
            if (!ManagerOnline)
            {
                if (e == CenterBot.StatusType.bot_Process_Terminated)
                {
                    sender.Stop();
                    RemoveBot(sender);
                }
                return;
            }
            Log.LogType logtyp = Log.LogType.Stander;
            Log.LogLevel loglvl = Log.LogLevel.Stander;
            switch (e)
            {
                case CenterBot.StatusType.Connecting_please_wait:
                     logtyp = Log.LogType.Info;
                     loglvl = Log.LogLevel.Debug;
                     break;
                case CenterBot.StatusType.Ready_to_login:
                     logtyp = Log.LogType.Info;
                     loglvl = Log.LogLevel.Debug;
                     break;
                case CenterBot.StatusType.Sending_login_informations:
                     logtyp = Log.LogType.Info;
                     loglvl = Log.LogLevel.Debug;
                     break;
                case CenterBot.StatusType.Sending_secondary_passcode:
                     logtyp = Log.LogType.Info;
                     loglvl = Log.LogLevel.Debug;
                     break;
                case CenterBot.StatusType.Character_listing:
                     logtyp = Log.LogType.Info;
                     loglvl = Log.LogLevel.Debug;
                     break;
                case CenterBot.StatusType.Login_Successful:
                     logtyp = Log.LogType.Info;
                     loglvl = Log.LogLevel.Stander;
                     break;
                case CenterBot.StatusType.Disconnected_from_server:
                     logtyp = Log.LogType.Error;
                     loglvl = Log.LogLevel.Stander;
                     sender.StartLoginTimer();
                     break;
                case CenterBot.StatusType.bot_Process_Terminated:
                    logtyp = Log.LogType.Error;
                    loglvl = Log.LogLevel.Debug;
                    sender.Stop();
                    if (sender.BotAccount == null || !sender.BotAccount.Start)
                        RemoveBot(sender);
                    else if (sender.BotAccount.DCRestart)
                        sender.Start();
                    break;
                case CenterBot.StatusType.Error_Stuck_On_Login:
                    logtyp = Log.LogType.Error;
                    loglvl = Log.LogLevel.Debug;
                    try
                    {
                        sender.Stop();
                        if (!sender.BotAccount.Start)
                            RemoveBot(sender);
                        else
                            sender.Start();
                    }
                    catch { }
                    break;
                case CenterBot.StatusType.Error_Script_Steps:
                case CenterBot.StatusType.Error_C9PingTimeOut:
                    logtyp = Log.LogType.Error;
                    loglvl = Log.LogLevel.Debug;
                    //try
                    //{
                    //    if (sender.BotAccount == null)
                    //        break;
                    //    sender.Stop();
                    //    if (!sender.BotAccount.Start)
                    //        RemoveBot(sender);
                    //    else
                    //        sender.Start();
                    //}
                    //catch { }
                    break;
                case CenterBot.StatusType.Error_HS_Is_Down:
                      logtyp = Log.LogType.Error;
                      loglvl = Log.LogLevel.Stander;
                    if (sender.BotAccount == null)
                        break;
                    sender.Stop();
                    RemoveBot(sender);
                    System.Threading.ThreadPool.QueueUserWorkItem((o) =>
                        {
                            sender.BotAccount.bot = null;
                            Random sleepTime = new Random();
                            System.Threading.Thread.Sleep(sleepTime.Next(120000, 130000));
                            if (ManagerOnline)
                                AddBot(sender.BotAccount);
                        });
                    break;
                case CenterBot.StatusType.Unknown:
                    logtyp = Log.LogType.Error;
                    loglvl = Log.LogLevel.Stander;
                    break;
            }
            if (sender.BotAccount == null)
                Program.Logger.AddLog(logtyp, loglvl, string.Format("[{0}][{1}]-{2}", sender.CharName, sender.ServerName, e.ToString()));
            else
                Program.Logger.AddLog(logtyp, loglvl, string.Format("[{0}][{1}]-{2}", sender.BotAccount.CharName, DataManager.ServerList[sender.BotAccount.silkroadServer], e.ToString()));
        }
        void bot_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "":
                    break;
            }
        }

        private void Resume()
        {
            for (int i = 0; i < Bots.Count; i++)
            {
                if (Bots[i].LastStatus != CenterBot.StatusType.Unknown)
                    bot_StateChanged(Bots[i], Bots[i].LastStatus);
            }
        }

        public void Start(bool resume)
        {
            ThreadPool.QueueUserWorkItem((o) => 
            {
                ManagerOnline = true;
                GetStartedBots();
                for (int i = 0; i < Program.DM.Accounts.Count; i++)
                {
                    if (Program.DM.Accounts[i].bot != null || !Program.DM.Accounts[i].Start)
                        continue;
                    AddBot(Program.DM.Accounts[i]);
                }
                if (resume)
                {
                    Resume();
                }
            });
            
        }
        public void Stop()
        {
            ManagerOnline = false;
        }

    }
}
