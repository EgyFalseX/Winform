using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using IbotControl.Hackshield;
using System.Management;
using System.Management.Instrumentation;

namespace IbotControl
{
    public partial class MainFrm : Form
    {
        HackshieldServer hsServer = null;
        Color AccountAutoStartEnabledColor = Color.Lime;
        Color AccountAutoStartDisabledColor = Color.DarkGreen;

        public MainFrm()
        {
            InitializeComponent();

            Program.Logger.AddUI(tbLog, Log.LogLevel.Stander);//Assgin to logger
            cbServer.DataSource = new BindingSource(DataManager.ServerList, null);// fill server list
            cbServer.DisplayMember = "Value"; cbServer.ValueMember = "Key";

            tabPageHachshield.Hide();

            pbCharHP.ShowText = true; pbCharMP.ShowText = true; pbCharExp.ShowText = true;
            pbCharBerzerg.ShowText = true; pbPetHP.ShowText = true; pbPetHGP.ShowText = true;
            pbTransHP.ShowText = true;

            cbHackshieldIP.SelectedIndex = 0; cbAccIP.SelectedIndex = 0; cbServer.SelectedIndex = 0;

        }
      
        private void FillAccountsInfoList()
        {
            lvAccount.Items.Clear();
            foreach (Account account in Program.DM.Accounts)
            {
                ListViewItem lvi = new ListViewItem(account.autoSelectChar);
                if (account.Start)
                    lvi.ForeColor = AccountAutoStartEnabledColor;                    
                else
                    lvi.ForeColor = AccountAutoStartDisabledColor;
                lvi.SubItems.Add(DataManager.ServerList[account.silkroadServer]);
                lvAccount.Items.Add(lvi);
            }
        }
        private void FillAccountInfoUI(int index)
        {
            Account account = Program.DM.Accounts[index];
            cbServer.SelectedValue = account.silkroadServer;
            tbUsername.Text = account.silkroadUser;
            tbPassword.Text = account.silkroadPass;
            tbPasscode.Text = account.secondPasscode;
            tbCharName.Text = account.autoSelectChar;
            cbAccIP.SelectedIndex = Convert.ToInt32(account.changeLoginIP);
            cbStart.Checked = account.Start;
            cbDCRestart.Checked = account.DCRestart;
            cbRestartUnknowSpot.Checked = account.RestartUnknowSpot;
            lblIbotAccountPath.Text = account.IbotFilePath;
        }
        private void FillBotsInfoUI(IBot bot)
        {
            lblCharName.Text = bot.CharName;
            lblSkill.Text = bot.SkillPoint;
            lblGold.Text = bot.Gold;
            lblExp.Text = bot.Experience;
            lblLvl.Text = bot.Level;
            lblItems.Text = bot.PickItems;
            lblDied.Text = bot.DiedCount;
            lblLoop.Text = bot.LoopCount;
            lblStatus.Text = bot.Status.ToString();
            lblExpPerHour.Text = bot.ExperiencePetHour;
            lblGoldPerHour.Text = bot.GoldPetHour;
            lblSkillPerHour.Text = bot.SkillPointPetHour;
            lblDCCount.Text = bot.DCCount.ToString();
            lblTryConnectCount.Text = bot.TryConnectCount.ToString();

            //pbCharHP.Minimum = bot.CharHPProgressBar[0];
            //pbCharHP.Maximum = bot.CharHPProgressBar[1];
            pbCharHP.Value = bot.CharHPProgressBar[2];

            //pbCharMP.Minimum = bot.CharMPProgressBar[0];
            //pbCharMP.Maximum = bot.CharMPProgressBar[1];
            pbCharMP.Value = bot.CharMPProgressBar[2];

            //pbCharExp.Minimum = bot.CharExpProgressBar[0];
            //pbCharExp.Maximum = bot.CharExpProgressBar[1];
            pbCharExp.Value = bot.CharExpProgressBar[2];

            //pbCharBerzerg.Minimum = bot.CharBerzerkProgressBar[0];
            //pbCharBerzerg.Maximum = bot.CharBerzerkProgressBar[1];
            pbCharBerzerg.Value = bot.CharBerzerkProgressBar[2];            

            //pbPetHP.Minimum = bot.PetHPProgressBar[0];
            //pbPetHP.Maximum = bot.PetHPProgressBar[1];
            pbPetHP.Value = bot.PetHPProgressBar[2];

            //pbPetHGP.Minimum = bot.PetHGPProgressBar[0];
            //pbPetHGP.Maximum = bot.PetHGPProgressBar[1];
            pbPetHGP.Value = bot.PetHGPProgressBar[2];

            //pbTransHP.Minimum = bot.TransHPProgressBar[0];
            //pbTransHP.Maximum = bot.TransHPProgressBar[1];
            pbTransHP.Value = bot.TransHPProgressBar[2];

            //if (tabControlBotInfo.SelectedTab == tabPageBotLog)
            //{
            //    lbBotLog.Items.Clear();
            //    lbBotLog.Items.AddRange(bot.StatusLogList.ToArray());
            //    //lbBotLog.SelectedIndex = lbBotLog.Items.Count - 1;
            //}

      }
        private void UpdateBotList(IBot bot)
        {
            for (int i = 0; i < LVBots.Items.Count; i++)
            {
                ListViewItem lvi = LVBots.Items[i];
                if (bot.ID.ToString() == lvi.SubItems[3].Text)
                {
                    lvi.Text = bot.CharName;
                    lvi.SubItems[1].Text = bot.ServerName;
                    if (bot.Visable)
                        lvi.SubItems[2].Text = "V";
                    else
                        lvi.SubItems[2].Text = "H";
                    switch (bot.Status)
                    {
                        case IBot.StatusType.Disconnected_from_server:
                        case IBot.StatusType.Error_Script_Steps:
                        case IBot.StatusType.Error_Stuck_On_Login:
                        case IBot.StatusType.Ibot_Process_Terminated:
                        case IBot.StatusType.Unknown:
                        case IBot.StatusType.Nothing:
                             lvi.StateImageIndex = 0;
                            break;
                        case IBot.StatusType.Character_listing:
                        case IBot.StatusType.Connecting_please_wait:
                        case IBot.StatusType.Ready_to_login:
                        case IBot.StatusType.Sending_login_informations:
                        case IBot.StatusType.Sending_secondary_passcode:
                            lvi.StateImageIndex = 1;
                            break;
                        case IBot.StatusType.Login_Successful:
                            lvi.StateImageIndex = 2;
                            break;
                    }
                    break;
                }
            }
            
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            Program.BM.BotListChanged += BM_BotListChanged;
            Program.BM.AccountListChanged += BM_AccountListChanged;
            FillAccountsInfoList();

            Automation();
        }
        #region Menu Handlers
        private void MainFrm_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                this.Visible = false;
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.DM.SaveSettings();
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvAccount.SelectedItems.Count == 0)
                return;
            FillAccountInfoUI(lvAccount.SelectedIndices[0]);
        }
        private void contextMenuStripBots_PaddingChanged(object sender, EventArgs e)
        {
            if (LVBots.SelectedIndices.Count == 0)
            {
                BottoolStripMenuItemClose.Enabled = false;
                ToolStripMenuItemShowHide.Enabled = false;
                return;
            }
            else
            {
                BottoolStripMenuItemClose.Enabled = true;
                ToolStripMenuItemShowHide.Enabled = true;
                if (Program.BM.Bots[LVBots.SelectedIndices[0]].Visable)
                    ToolStripMenuItemShowHide.Text = "Hide";
                else
                    ToolStripMenuItemShowHide.Text = "Show";
            }

        }
        private void toolStripMenuItemCloseBot_Click(object sender, EventArgs e)
        {
            if (LVBots.SelectedIndices.Count == 0)
                return;
            if (MessageBox.Show("Are You Sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            Program.BM.KillBotProcess(LVBots.SelectedIndices[0]);
        }
        private void toolStripMenuItemCloseAllBots_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            for (int i = Program.BM.Bots.Count - 1; i >= 0; i--)
            {
                Program.BM.KillBotProcess(i);                
            }
            //for (int i = 0; i < Program.BM.Bots.Count; i++)
            //{
            //}
        }
        private void showhideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LVBots.SelectedIndices.Count == 0)
                return;
            Program.BM.Bots[LVBots.SelectedIndices[0]].Visable = !Program.BM.Bots[LVBots.SelectedIndices[0]].Visable;
        }
        private void hideAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (IBot bot in Program.BM.Bots)
            {
                bot.Visable = false;
                Application.DoEvents();
            }
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs frm = new AboutUs();
            frm.ShowDialog();
           // MessageBox.Show("mohamed.aly.omer@gmail.com", "About us", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void outputWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OutputFrm dbug = new OutputFrm(); dbug.Show();
        }
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void notifyIconApp_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button != System.Windows.Forms.MouseButtons.Left)
                return;
            this.Visible = !this.Visible;
            if (Visible)
                this.WindowState = FormWindowState.Normal;
        }
        #endregion
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Program.BM.AddAccount(cbServer.SelectedValue.ToString(), tbUsername.Text, tbPassword.Text, tbPasscode.Text, 
                tbCharName.Text, cbAccIP.SelectedIndex.ToString(), cbStart.Checked, cbDCRestart.Checked, cbRestartUnknowSpot.Checked, lblIbotAccountPath.Text);
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lvAccount.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select account");
                return;
            }
            Program.BM.UpdateAccount(lvAccount.SelectedIndices[0], cbServer.SelectedValue.ToString(),
                tbUsername.Text, tbPassword.Text, tbPasscode.Text, tbCharName.Text, cbAccIP.SelectedIndex.ToString(), cbStart.Checked,
                cbDCRestart.Checked, cbRestartUnknowSpot.Checked, lblIbotAccountPath.Text);
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lvAccount.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select account");
                return;
            }
            if (MessageBox.Show("Are You Sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            Program.BM.RemoveAccount(lvAccount.SelectedIndices[0]);
        }
        
        private void lvAccount_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = lvAccount.FocusedItem;
            if (Program.DM.Accounts[item.Index].Start)
            {
                Program.DM.Accounts[item.Index].Start = false;
                item.ForeColor = AccountAutoStartDisabledColor;
            }
            else
            {
                Program.DM.Accounts[item.Index].Start = true;
                item.ForeColor = AccountAutoStartEnabledColor;
            }
            FillAccountInfoUI(item.Index);
            btnUpdate_Click(null, EventArgs.Empty);
        }
        private void lvAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvAccount.SelectedIndices.Count == 0)
                return;
            FillAccountInfoUI(lvAccount.SelectedIndices[0]);
        }
        private void btnSelectAccountIbot_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;
            lblIbotAccountPath.Text = ofd.FileName;

        }
        private void LVBots_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            //if (LVBots.SelectedIndices.Count == 0)
            //    return;
            //Program.BM.Bots[e.Item.Index].Visable = e.Item.Checked;
        }
        private void LVBots_DoubleClick(object sender, EventArgs e)
        {
            if (LVBots.SelectedIndices.Count == 0)
                return;
            Program.BM.Bots[LVBots.SelectedIndices[0]].Visable = !Program.BM.Bots[LVBots.SelectedIndices[0]].Visable;
        }
        private void LVBots_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LVBots.SelectedIndices.Count == 0)
                return;
            IBot bot = Program.BM.Bots[LVBots.SelectedIndices[0]];
            bot.InitiProperties();
            FillBotsInfoUI(bot);
            tabControlBotInfo_Selected(tabControlBotInfo, new TabControlEventArgs(tabControlBotInfo.SelectedTab, 0, TabControlAction.Selected));
        }
        private void tabControlBotInfo_Selected(object sender, TabControlEventArgs e)
        { 
            if (LVBots.SelectedItems.Count == 0)
                return;
            IBot bot = Program.BM.Bots[LVBots.SelectedIndices[0]];

            if (tabControlBotInfo.SelectedTab == tabPageInventory)
            {
                lbCharInventory.Items.Clear();
                lbCharInventory.Items.AddRange(bot.CharInventory.ToArray());
                lblCharInvFreeSlot.Text = bot.CharInventoryFreeSlot.ToString();

                lbPetInventory.Items.Clear();
                lbPetInventory.Items.AddRange(bot.PetInventory.ToArray());
                lblPetInvFreeSlot.Text = bot.PetInventoryFreeSlot.ToString();
            }
            else if (tabControlBotInfo.SelectedTab == tabPageBotLog)
            {
                lbBotLog.Items.Clear();
                lbBotLog.Items.AddRange(bot.StatusLogList.ToArray());
                lbBotLog.SelectedIndex = lbBotLog.Items.Count - 1;
            }
        }

        private void TmrUIBotInfo_Tick(object sender, EventArgs e)
        {
            //if (LVBots.SelectedIndices.Count == 0)
            //    return;
            //FillBotsInfoUI(Program.BM.Bots[LVBots.SelectedIndices[0]]);
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            MethodInvoker action = new MethodInvoker(() =>
            {

                btnStart.Enabled = false;
                btnStop.Enabled = false;
                tabControl1.SelectedTab = tabPageBots;
                if (LVBots.Items.Count == 0)
                    Program.BM.Start(false);
                else
                    Program.BM.Start(true);
                btnStop.Enabled = true;
            });
            this.Invoke(action);
            //ThreadPool.QueueUserWorkItem((o) => 
            //{
            //});
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            Program.BM.Stop();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }
        void BM_AccountListChanged(object sender, BotsManager.ChangesType e)
        {
            Account account = (Account)sender;
            switch (e)
            {
                case BotsManager.ChangesType.Added:
                    ListViewItem lviAdd = new ListViewItem(account.autoSelectChar);
                    if (account.Start)
                        lviAdd.ForeColor = AccountAutoStartEnabledColor;
                    else
                        lviAdd.ForeColor = AccountAutoStartDisabledColor;
                    lviAdd.SubItems.Add(DataManager.ServerList[account.silkroadServer]);
                    lvAccount.Items.Add(lviAdd);
                    break;
                case BotsManager.ChangesType.Updated:
                    ListViewItem lviUpdate = lvAccount.SelectedItems[0];
                    lviUpdate.Text = account.autoSelectChar;
                    if (account.Start)
                        lviUpdate.ForeColor = AccountAutoStartEnabledColor;
                    else
                        lviUpdate.ForeColor = AccountAutoStartDisabledColor;
                    lviUpdate.SubItems[1].Text = DataManager.ServerList[account.silkroadServer];
                    break;
                case BotsManager.ChangesType.Deleted:
                    foreach (ListViewItem item in lvAccount.Items)
                    {
                        if (item.Text == account.autoSelectChar && item.SubItems[1].Text == DataManager.ServerList[account.silkroadServer])
                        {
                            item.Remove();
                            break;
                        }
                    }
                    break;
            }
        }
        void BM_BotListChanged(object sender, BotsManager.ChangesType e)
        {
            MethodInvoker action = new MethodInvoker(() =>
                {
                    IBot bot = (IBot)sender;
                    switch (e)
                    {
                        case BotsManager.ChangesType.Added:
                            ListViewItem lvi = new ListViewItem(bot.CharName);
                            lvi.SubItems.Add(bot.ServerName);
                            if (bot.Visable)
                                lvi.SubItems.Add("V");
                            else
                                lvi.SubItems.Add("H");
                            lvi.SubItems.Add(bot.ID.ToString());
                            lvi.StateImageIndex = 0;
                            LVBots.Items.Add(lvi);
                            bot.StateChanged += bot_StateChanged;
                            bot.PropertyChanged += bot_PropertyChanged;
                            bot.LogAdded += bot_LogAdded;
                            break;
                        case BotsManager.ChangesType.Deleted:
                            foreach (ListViewItem item in LVBots.Items)
                            {
                                if (item.Text == bot.CharName && item.SubItems[1].Text == bot.ServerName)
                                {
                                    item.Remove();
                                    break; ;
                                }
                            }
                            break;
                    }
                });
            this.Invoke(action);
        }

        void bot_LogAdded(IBot sender, string Log)
        {
            MethodInvoker action = delegate
            {
                if (LVBots.SelectedItems.Count == 0)
                    return;
                if (sender.ID != Program.BM.Bots[LVBots.SelectedIndices[0]].ID)
                    return;
                if (Log.Contains("Error - h2f - 3018"))
                    return;
                lbBotLog.Items.Add(Log);
            };
            this.Invoke(action);
        }
        void bot_StateChanged(IBot sender, IBot.StatusType e)
        {
            MethodInvoker action = delegate
            {
                if (LVBots.SelectedItems.Count == 0)
                    return;
                if (sender.ID != Program.BM.Bots[LVBots.SelectedIndices[0]].ID)
                    return;
                lblStatus.Text = e.ToString();
                UpdateBotList(sender);
            };
            this.Invoke(action);
           
        }
        void bot_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            MethodInvoker action = delegate
            {
                IBot bot = (IBot)sender;
                UpdateBotList(bot);
                if (LVBots.SelectedItems.Count == 0)
                    return;
                if (bot.ID != Program.BM.Bots[LVBots.SelectedIndices[0]].ID)
                    return;

                switch (e.PropertyName)
                {
                    case "CharName":
                        lblCharName.Text = bot.CharName;
                        break;
                    case "SkillPoint":
                        lblSkill.Text = bot.SkillPoint;
                        break;
                    case "Gold":
                        lblGold.Text = bot.Gold;
                        break;
                    case "Experience":
                        lblExp.Text = bot.Experience;
                        break;
                    case "Level":
                        lblLvl.Text = bot.Level;
                        break;
                    case "PickItems":
                        lblItems.Text = bot.PickItems;
                        break;
                    case "DiedCount":
                        lblDied.Text = bot.DiedCount;
                        break;
                    case "LoopCount":
                        lblLoop.Text = bot.LoopCount;
                        break;
                    case "DCCount":
                        lblDCCount.Text = bot.DCCount.ToString();
                        break;
                    case "TryConnectCount":
                        lblTryConnectCount.Text = bot.TryConnectCount.ToString();
                        break;
                    case "SkillPointPetHour":
                        lblSkillPerHour.Text = bot.SkillPointPetHour.ToString();
                        break;
                    case "GoldPetHour":
                        lblGoldPerHour.Text = bot.GoldPetHour.ToString();
                        break;
                    case "ExperiencePetHour":
                        lblExpPerHour.Text = bot.ExperiencePetHour.ToString();
                        break;
                    case "CharInventory":
                        if (tabControlBotInfo.SelectedTab != tabPageInventory)
                            break;
                        try
                        {
                            lbCharInventory.Items.Clear();
                            lbCharInventory.Items.AddRange(bot.CharInventory.ToArray());
                            lblCharInvFreeSlot.Text = bot.CharInventoryFreeSlot.ToString();
                        }
                        catch{ }
                        break;
                    case "PetInventory":
                        if (tabControlBotInfo.SelectedTab != tabPageInventory)
                            break;
                        try
                        {
                            lbPetInventory.Items.Clear();
                            lbPetInventory.Items.AddRange(bot.PetInventory.ToArray());
                            lblPetInvFreeSlot.Text = bot.PetInventoryFreeSlot.ToString();
                        }
                        catch { }
                        break;
                    case "CharHPProgressBar":
                          //pbCharHP.Minimum = bot.CharHPProgressBar[0];
                          //pbCharHP.Maximum = bot.CharHPProgressBar[1];
                          pbCharHP.Value = bot.CharHPProgressBar[2];
                        break;
                    case "CharMPProgressBar":
                        //pbCharMP.Minimum = bot.CharMPProgressBar[0];
                        //pbCharMP.Maximum = bot.CharMPProgressBar[1];
                        pbCharMP.Value = bot.CharMPProgressBar[2];
                        break;
                    case "CharExpProgressBar":
                        //pbCharExp.Minimum = bot.CharExpProgressBar[0];
                        //pbCharExp.Maximum = bot.CharExpProgressBar[1];
                        pbCharExp.Value = bot.CharExpProgressBar[2];
                        break;
                    case "CharBerzerkProgressBar":
                       //pbCharBerzerg.Minimum = bot.CharBerzerkProgressBar[0];
                       //pbCharBerzerg.Maximum = bot.CharBerzerkProgressBar[1];
                        pbCharBerzerg.Value = bot.CharBerzerkProgressBar[2];                        
                        break;
                    case "PetHPProgressBar":
                        //pbPetHP.Minimum = bot.PetHPProgressBar[0];
                        //pbPetHP.Maximum = bot.PetHPProgressBar[1];
                        pbPetHP.Value = bot.PetHPProgressBar[2];
                        break;
                    case "PetHGPProgressBar":
                        //pbPetHGP.Minimum = bot.PetHGPProgressBar[0];
                        //pbPetHGP.Maximum = bot.PetHGPProgressBar[1];
                        pbPetHGP.Value = bot.PetHGPProgressBar[2];
                        break;
                    case "TransHPProgressBar":
                        //pbTransHP.Minimum = bot.TransHPProgressBar[0];
                        //pbTransHP.Maximum = bot.TransHPProgressBar[1];
                        pbTransHP.Value = bot.TransHPProgressBar[2];
                        break;
                }
            };
            this.Invoke(action);
        }

        #region Hackshield
        private void btnStartHackshield_Click(object sender, EventArgs e)
        {
            if (cbHackshieldIP.Text == string.Empty || tbHackshieldPort.Text == string.Empty)
            {
                MessageBox.Show("Enter An IP and Port", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            rtbHachshield.Clear();
            hsServer = new HackshieldServer(rtbHachshield);
            hsServer.ClientStyleChanged += hsServer_ClientStyleChanged;
            hsServer.StartHackshield(cbHackshieldIP.Text, tbHackshieldPort.Text);
            hsServer.HSProcess.Exited += HSProcess_Exited;
            hsServer.ReceivedStatus +=hsServer_ReceivedStatus;
            this.WindowState = FormWindowState.Maximized;
            btnStartHackshield.Enabled = false;
            btnStopHackshield.Enabled = true;
        }
        void hsServer_ClientStyleChanged(Win32.WindowShowStyle style)
        {
            MethodInvoker action = delegate
           {
               gbClient.Enabled = true;
               if (style == Win32.WindowShowStyle.Hide)
                   cbShowHideClient.Checked = false;
               else if (style == Win32.WindowShowStyle.Show)
                   cbShowHideClient.Checked = true;
           };
            this.Invoke(action);
        }
        void HSProcess_Exited(object sender, EventArgs e)
        {
            btnStopHackshield_Click(btnStopHackshield, new EventArgs());
        }
        void hsServer_ReceivedStatus(object sender, HSTypes.HSLogTypes e)
        {
            //if (e == HSTypes.HSLogTypes.WaitingForHSClient)
            //    btnStart_Click(btnStart, new EventArgs());
            if (e == HSTypes.HSLogTypes.CriticalError)
            {
                this.Invoke(new MethodInvoker(() => 
                {
                    btnStart.PerformClick();
                }));
            }
        }
        private void btnStopHackshield_Click(object sender, EventArgs e)
        {
            System.Threading.ThreadPool.QueueUserWorkItem((o) =>
            {
                MethodInvoker method = new MethodInvoker(() =>
                {
                    btnStopHackshield.Enabled = false;
                    if (hsServer == null)
                        return;
                    hsServer.Dispose();
                    btnStartHackshield.Enabled = true;
                    rtbHachshield.Clear();
                });
                this.Invoke(method);
            });
        }
        private void cbShowHideClient_CheckedChanged(object sender, EventArgs e)
        {
            if (hsServer == null || hsServer.Sro_ClientHandle == IntPtr.Zero)
                gbClient.Enabled = false;

            if (cbShowHideClient.Checked)
                hsServer.SroClientStyle(Win32.WindowShowStyle.Show);
            else
                hsServer.SroClientStyle(Win32.WindowShowStyle.Hide);
        }
        private void btnResizeClient_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(tbx.Text);
                int y = Convert.ToInt32(tby.Text);
                hsServer.ResizeClient(x, y);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        #endregion

        #region Options Tab
        private void btnIbotPath_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;
            Properties.Settings.Default.IbotPath = ofd.FileName;
            lblIbotPath.Text = ofd.FileName;
        }
        private void btnSroPath_Click(object sender, EventArgs e)
        {
            fbd.Description = "Select Silkroad Directory";
            if (fbd.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;
            Properties.Settings.Default.SroPath = fbd.SelectedPath;
            lblSroPath.Text = fbd.SelectedPath;

        }
        private void Automation()
        {
            if (!Properties.Settings.Default.RunAtStartup)
                return;
            tabControl1.SelectedTab = tabPageHachshield;
            btnStartHackshield_Click(btnStartHackshield, new EventArgs());
            hsServer.ReceivedStatus += hsServer_ReceivedStatus;
        }
        
        #endregion

    }
}