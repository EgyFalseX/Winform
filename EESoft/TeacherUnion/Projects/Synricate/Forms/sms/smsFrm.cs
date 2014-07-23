using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Threading;
using System.IO.Ports;
using System.Data.SqlClient;
using System.Management;


namespace Synricate
{
    public partial class smsFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        private DataTable Members = new DataTable();
        public AutoResetEvent receiveNow;
        enum messageStatus
        {
            ارسلت,
            فشلت,
            جاهزه
        }
        #endregion
        #region -   Functions   -

        public smsFrm()
        {
            InitializeComponent();
        }
        private void LoadPorts()
        {
            CBEPort.Properties.Items.AddRange(SerialPort.GetPortNames());
        }
        private static DataTable LoadSetting()
        {
            return FXFW.SqlDB.LoadDataTable(@"Select ServiceNum From Setting");
        }
        private static DataTable LoadTemplates()
        {
            return FXFW.SqlDB.LoadDataTable(@"Select TemplateId, TemplateTitle, TemplateBody From Templates");
        }
        private DataTable LoadMembers()
        {
            Members = FXFW.SqlDB.LoadDataTable(@"SELECT MemberId, LagnaNoaeaId, SubCommitteId, CommittejopId, workstartdate, workenddate,
            (SELECT MemberName FROM TBLMember WHERE MemberId = TBLSCommitteMember.MemberId) AS MemberName,
            (SELECT SubCommitte FROM CDSubCommitte WHERE SubCommitteId = TBLSCommitteMember.SubCommitteId) AS SubCommitte,
            (SELECT LagnaNoaeaName FROM CDSCommitte WHERE LagnaNoaeaId = TBLSCommitteMember.LagnaNoaeaId) AS LagnaNoaeaName,
            (SELECT CommittejopName FROM CDCommitteJop WHERE CommittejopId = TBLSCommitteMember.CommittejopId) AS CommittejopName,
            (SELECT Membermobil FROM TBLMember WHERE MemberId = TBLSCommitteMember.MemberId) AS Membermobil,
            'False' AS checked
            FROM TBLSCommitteMember");
            return Members;
        }
        private static DataTable LoadMessages()
        {
            return FXFW.SqlDB.LoadDataTable(@"Select messageid, messageBody, number, status, SendTime From Messages");
        }
        public string ReadResponse(int timeout)
        {
            string buffer = string.Empty;
            try
            {
                do
                {
                    if (receiveNow.WaitOne(timeout, false))
                    {
                        string t = USBserialPort.ReadExisting();
                        buffer += t;
                    }
                    else
                    {
                        if (buffer.Length > 0)
                            throw new ApplicationException("Response received is incomplete.");
                        else
                            throw new ApplicationException("No data received from phone.");
                    }
                }
                while (!buffer.EndsWith("\r\nOK\r\n") && !buffer.EndsWith("\r\n> ") && !buffer.EndsWith("\r\nERROR\r\n"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return buffer;
        }
        public string ExecCommand(string command, int responseTimeout)
        {
            try
            {
                USBserialPort.DiscardOutBuffer();
                USBserialPort.DiscardInBuffer();
                receiveNow.Reset();
                USBserialPort.Write(command + "\r");

                string input = ReadResponse(responseTimeout);
                if ((input.Length == 0) || ((!input.EndsWith("\r\n> ")) && (!input.EndsWith("\r\nOK\r\n"))))
                    throw new ApplicationException("تم استقبال رسالة خطاء من البورت");
                return input;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private static string GetPDU(string ServiceCenterNumber, string Destination_Address, string User_Data)
        {
            FXPDU.SMS PDUCls = new FXPDU.SMS();
            PDUCls.TP_Data_Coding_Scheme = FXPDU.SMS.ENUM_TP_DCS.UCS2;
            PDUCls.ServiceCenterNumber = ServiceCenterNumber;
            PDUCls.TP_Destination_Address = Destination_Address;
            PDUCls.TP_User_Data = User_Data;
            PDUCls.TP_Status_Report_Request = FXPDU.SMS.ENUM_TP_SRI.No_SMS_Report;
            PDUCls.TP_Validity_Period = FXPDU.SMS.ENUM_TP_VALID_PERIOD.Maximum;
            PDUCls.TP_Message_Reference = 0;
            return PDUCls.GetSMSPDUCode();
        }
        private static string GetPDULength(string PDU)
        {
            int strLen = Convert.ToInt32(PDU.Substring(0, 2));
            strLen *= 2;
            strLen = PDU.Length - strLen - 2;
            strLen /= 2;
            return strLen.ToString();
        }
        private void SaveSentMessageLog(string messageBody, string number, messageStatus Status)
        {
            using (SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr))
            {
                SqlCommand cmd = new SqlCommand("", con);
                try
                {
                    cmd.CommandText = string.Format(@"Insert Into Messages (messageBody, number, status, SendTime) VALUES (N'{0}', N'{1}', N'{2}', GETDATE())", 
                        messageBody, number, Status);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                    Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
                }
                con.Close();
            }
        }
        private string getMsgVars(string msg, string MobileNo)
        {
            if (msg.Contains("[الاسم]"))
            {
                for (int i = 0; i < Members.Rows.Count; i++)
                {
                    if (MobileNo == Members.Rows[i]["Membermobil"].ToString())
                    {
                        msg = msg.Replace("[الاسم]", Members.Rows[i]["MemberName"].ToString());
                    }
                }
            }
            if (msg.Contains("[الوظيفه]"))
            {
                for (int i = 0; i < Members.Rows.Count; i++)
                {
                    if (MobileNo == Members.Rows[i]["Membermobil"].ToString())
                    {
                        msg = msg.Replace("[الوظيفه]", Members.Rows[i]["CommittejopName"].ToString());
                    }
                }
            }
            

            return msg;
        }
        private static string[] MsgPrepare(string msg)
        {
            int loopCount = msg.Length / 70;
            if (msg.Length % 70 > 0)
                loopCount++;

            string[] returnMe = new string[0];
            for (int i = 0; i < loopCount; i++)
            {
                Array.Resize<string>(ref returnMe, returnMe.Length + 1);
                returnMe[returnMe.Length - 1] = msg.Substring(i * 70);
                if (returnMe[returnMe.Length - 1].Length > 70)
                    returnMe[returnMe.Length - 1] = returnMe[returnMe.Length - 1].Remove(70);
            }
            return returnMe;
        }
        public static Single ConvertStringToInt(string str, string Comma)
        {
            string ReturnMe = string.Empty;
            int count = 0;
            foreach (char c in str.ToCharArray())
            {
                if (c == Convert.ToChar(Comma) && count < 1)
                {
                    ReturnMe += ".";
                    count++;
                }
                if (char.IsNumber(c))
                {
                    ReturnMe += c.ToString();
                }
            }
            if (ReturnMe == string.Empty)
            {
                ReturnMe = "0";
            }
            return Convert.ToSingle(ReturnMe);
        }
        static string DeviceFullName(string ComName)
        {
            string ReturnMe = string.Empty;
            try
            {

                ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PnPEntity WHERE Caption LIKE '%(" + ComName + ")%'");
                foreach (ManagementObject queryObj in searcher.Get())
                {
                    ReturnMe = queryObj["Caption"].ToString();
                    //if (queryObj["Caption"].ToString().Contains("(" + ComName))
                    //{
                        
                    //    break;
                    //}
                }
            }
            catch (ManagementException e)
            {
                MessageBox.Show(e.Message);
            }
            return ReturnMe;
        }

        #endregion
        #region - Event Handlers -
        
        private void smsFrm_Load(object sender, EventArgs e)
        {
            LoadPorts();// Load PortsName in list.
            USBserialPort.Encoding = Encoding.GetEncoding("iso-8859-1");
            gridControlMain.MainView = gridViewSetting;
            gridControlMain.DataSource = LoadSetting();

        }
        private void CBEPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBEPort.SelectedIndex < 0)
            {
                LblDeviceName.Text = string.Empty;
                return;
            }
            LblDeviceName.Text = DeviceFullName(CBEPort.Text);
        }
        private void BtnSetting_Click(object sender, EventArgs e)
        {
            gridControlMain.MainView = gridViewSetting;
            gridControlMain.DataSource = LoadSetting();
        }
        private void BtnMSG_Click(object sender, EventArgs e)
        {
            gridControlMain.MainView = gridViewMessages;
            gridControlMain.DataSource = LoadMessages();
        }
        private void BtnTemplate_Click(object sender, EventArgs e)
        {
            gridControlMain.MainView = gridViewTemplates;
            gridControlMain.DataSource = LoadTemplates();
        }
        private void BtnMember_Click(object sender, EventArgs e)
        {
            gridControlMain.MainView = gridViewTBLSCommitteMember;
            gridControlMain.DataSource = LoadMembers();
        }
        private void BtnConnect_Click(object sender, EventArgs e)
        {
            if (USBserialPort.IsOpen)
                USBserialPort.Close();
            receiveNow = new AutoResetEvent(false);
            try
            {
                USBserialPort.PortName = CBEPort.Text;
                USBserialPort.Open();
                string recievedData = ExecCommand("AT", 300);//No phone connected
                USBserialPort.DtrEnable = true;
                USBserialPort.RtsEnable = true;

                if (USBserialPort != null)
                {
                    PnlConnection.Enabled = false;
                    PnlSend.Enabled = true;
                    BtnDisconnect.Visible = true;
                    ////////////////TmrSignal.Enabled = true;
                    Program.ShowMsg("تم الاتصال من خلال بورت : " + CBEPort.Text, false, this);

                }
                else
                    Program.ShowMsg("لم يتم الاتصال من خلال بورت", true, this);//Invalid port settings
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطــــاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                TmrSignal.Enabled = false;
                USBserialPort.Close();
                PnlConnection.Enabled = true;
                PnlSend.Enabled = false;
                BtnDisconnect.Visible = false;
                Program.ShowMsg("تم قطع الاتصال", false, this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطــــاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void USBserialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                if (e.EventType == SerialData.Chars)
                {
                    receiveNow.Set();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            TmrSignal.Stop(); TmrSignal.Enabled = false;// stop getting the signal and get ready to send sms

            try
            {
                string recievedData = ExecCommand("AT", 300);//No phone connected
                recievedData = ExecCommand("AT+CMGF=0", 300);//Failed to set message format.
                recievedData = ExecCommand("AT+CSMS=0", 300);//Failed to set message format.
                if (recievedData.Contains("ERROR"))
                {
                    Program.ShowMsg("لم يتم الارسال", true, this);
                    return;
                }

                PBSend.Properties.Maximum = LBCSendTo.Items.Count;
                PBSend.EditValue = "0";
                for (int i = 0; i < LBCSendTo.Items.Count; i++)
                {
                    string command = string.Empty;
                    string Logger = string.Empty;
                    PBSend.EditValue = Convert.ToInt32(PBSend.EditValue) + 1;
                    string msgWithoutVar = getMsgVars(TxtMsg.Text, LBCSendTo.Items[i].ToString());// Replace [Stu_Name] And [Father]1 Name with the 1 in DB

                    if (msgWithoutVar == string.Empty)
                    {
                        Program.ShowMsg("خطاء في العوامل", true, this);
                        return;
                    }
                    string[] msg = MsgPrepare(msgWithoutVar);// Split msg to msg[].length=70
                    foreach (string item in msg)
                    {
                        Application.DoEvents();
                        string pdu = GetPDU(TxtServiceNum.Text.Trim(), LBCSendTo.Items[i].ToString(), item);
                        string pduLength = GetPDULength(pdu);
                        Logger += ExecCommand("AT+CMGS=" + pduLength, 300);//Failed to set message Length.
                        command = String.Format("{0}{1}\r", pdu, char.ConvertFromUtf32(26));
                        Logger += ExecCommand(command, 10000);//"Failed to send message
                        Logger = "\r\nOK\r\n";
                        if (recievedData.EndsWith("\r\nOK\r\n"))
                        {
                            SaveSentMessageLog(item, LBCSendTo.Items[i].ToString(), messageStatus.ارسلت);
                            Program.ShowMsg("تم الارسال الي " + LBCSendTo.Items[i].ToString(), false, this);
                        }
                        else if (recievedData.Contains("ERROR"))
                        {
                            SaveSentMessageLog(item, LBCSendTo.Items[i].ToString(), messageStatus.فشلت);
                            Program.ShowMsg("لم يتم الارسال الي " + LBCSendTo.Items[i].ToString(), true, this);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            TmrSignal.Enabled = true;// start getting the signal again
            PBSend.EditValue = "0";
        }
        private void BtnSaveMsg_Click(object sender, EventArgs e)
        {
            foreach (string Mymobile in LBCSendTo.Items)
            {
                string[] msg = MsgPrepare(getMsgVars(TxtMsg.Text, Mymobile));// Split msg to msg[].length=70
                foreach (string Mymsg in msg)
                    SaveSentMessageLog(Mymsg, Mymobile, messageStatus.جاهزه);
            }
            Program.ShowMsg("تم الحفظ", false, this);
        }
        private void BtnDelSendTo_Click(object sender, EventArgs e)
        {
            if (LBCSendTo.SelectedItem != null)
                LBCSendTo.Items.Remove(LBCSendTo.SelectedItem);
        }
        private void btnExcel_Click(object sender, EventArgs e)
        {
            ImportExcelDataFrm frm = new ImportExcelDataFrm();
            if (frm.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }
            gridControlMain.MainView = gridViewExcel;
            gridControlMain.DataSource = frm.Mobiles;
        }
        private void repositoryItemButtonEditSettingUse_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (gridControlMain.MainView.Name)
            {
                case "gridViewSetting":
                    DataRow rowSetting = gridViewSetting.GetFocusedDataRow();
                    TxtServiceNum.Text = rowSetting["ServiceNum"].ToString();
                    break;
                case "gridViewTBLSCommitteMember":
                    DataRow rowContacts = gridViewTBLSCommitteMember.GetFocusedDataRow();
                    if (LBCSendTo.FindString(rowContacts["MemberName"].ToString()) == -1)
                        LBCSendTo.Items.Add(rowContacts["MemberName"]);
                    break;

                case "gridViewMessages":
                    DataRow rowMessages = gridViewMessages.GetFocusedDataRow();
                    if (LBCSendTo.FindString(rowMessages["number"].ToString()) == -1)
                        LBCSendTo.Items.Add(rowMessages["number"]);
                    if (!TxtMsg.Text.Contains(rowMessages["messageBody"].ToString()))
                        TxtMsg.Text += rowMessages["messageBody"];
                    break;

                case "gridViewTemplates":
                    DataRow rowTemplates = gridViewTemplates.GetFocusedDataRow();
                    TxtMsg.Text += rowTemplates["TemplateBody"];
                    break;
                default:
                    break;
            }
        }
        private void repositoryItemButtonEditSettingDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل نت متأكد؟", "تحزير...!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.No)
                return;
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                con.Open();
                switch (gridControlMain.MainView.Name)
                {
                    case "gridViewSetting":
                        DataRow rowSetting = gridViewSetting.GetFocusedDataRow();
                        cmd.CommandText = String.Format("Delete From Setting Where ServiceNum = N'{0}'", rowSetting["ServiceNum"]);
                        cmd.ExecuteNonQuery();
                        gridControlMain.DataSource = LoadSetting();
                        break;
                    case "gridViewMessages":
                        DataRow rowMessages = gridViewMessages.GetFocusedDataRow();
                        cmd.CommandText = String.Format("Delete From Messages Where messageid = {0}", rowMessages["messageid"]);
                        cmd.ExecuteNonQuery();
                        gridControlMain.DataSource = LoadMessages();
                        break;
                    case "gridViewTemplates":
                        DataRow rowTemplates = gridViewTemplates.GetFocusedDataRow();
                        cmd.CommandText = String.Format("Delete From Templates Where TemplateId = {0}", rowTemplates["TemplateId"]);
                        cmd.ExecuteNonQuery();
                        gridControlMain.DataSource = LoadTemplates();
                        break;
                    default:
                        break;
                }
                Program.ShowMsg("تم الحذف", false, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
            }
            con.Close();
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                con.Open();
                switch (gridControlMain.MainView.Name)
                {
                    case "gridViewSetting":
                        DataRow rowSetting = gridViewSetting.GetFocusedDataRow();
                        cmd.CommandText = String.Format(@"IF Not exists(select * from Setting Where ServiceNum = N'{0}')
                        Insert Into Setting (ServiceNum) VALUES (N'{0}')", rowSetting["ServiceNum"]);
                        cmd.ExecuteNonQuery();
                        gridControlMain.DataSource = LoadSetting();
                        break;
                    case "gridViewTemplates":
                        DataRow rowTemplates = gridViewTemplates.GetFocusedDataRow();
                        if (rowTemplates["TemplateId"].ToString() == string.Empty)
                        {
                            cmd.CommandText = String.Format(@"Insert Into Templates (TemplateBody) VALUES (N'{0}')", rowTemplates["TemplateBody"]);
                        }
                        else
                        {
                            cmd.CommandText = String.Format(@"Update Templates Set TemplateBody = N'{0}' Where TemplateId = {1}",
                            rowTemplates["TemplateBody"], rowTemplates["TemplateId"]);
                        }
                        cmd.ExecuteNonQuery();
                        gridControlMain.DataSource = LoadTemplates();
                        break;
                    default:
                        break;
                }
                Program.ShowMsg("تم الحفظ", false, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
            }
        }
        private void TmrSignal_Tick(object sender, EventArgs e)
        {
            try
            {
                string signal = ExecCommand("AT+CSQ", 5000);
                if (signal.Contains("+CSQ:"))
                    PBSignal.EditValue = ConvertStringToInt(signal.Substring(signal.IndexOf(Convert.ToChar(":")) + 1), ",");
                else
                    PBSignal.EditValue = "0";
            }
            catch
            {
                PBSignal.EditValue = "0";
                TmrSignal.Enabled = false;
            }
        }
        private void TxtMsg_EditValueChanged(object sender, EventArgs e)
        {
            LblMsgCounter.Text = (TxtMsg.Text.Length / 70).ToString();
            if ((TxtMsg.Text.Length % 70) > 0)
                LblMsgCounter.Text = (Convert.ToInt32(LblMsgCounter.Text) + 1).ToString();
            LblCharCounter.Text = ((Convert.ToInt32(LblMsgCounter.Text) * 70) - TxtMsg.Text.Length).ToString();

            LblCharCounter.Text = "عدد الحروف: " + LblCharCounter.Text;
            LblMsgCounter.Text = "عدد الرسائل: " + LblMsgCounter.Text;
        }
        private void CBAddVar_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.OK)
                return;
            if (TxtMsg.Text != string.Empty)
            {
                if (TxtMsg.Text[TxtMsg.Text.Length - 1] != Convert.ToChar(" "))
                    TxtMsg.Text += " ";
            }
            TxtMsg.Text += CBAddVar.SelectedText;
        }
        private void CMSdataschool_Opening(object sender, CancelEventArgs e)
        {
            switch (gridControlMain.MainView.Name)
            {
                case "gridViewMessages":
                    toolStripMenuItemAdd.Visible = false;
                    break;
                case "gridViewTBLSCommitteMember":
                    toolStripMenuItemAdd.Visible = true;
                    toolStripMenuItemSelectAll.Visible = true;
                    break;
                case "gridViewExcel":
                    toolStripMenuItemAdd.Visible = true;
                    toolStripMenuItemSelectAll.Visible = true;
                    break;
                default:
                    e.Cancel = true;
                    break;
            }
        }
        private void toolStripMenuItemSelectAll_Click(object sender, EventArgs e)
        {
            switch (gridControlMain.MainView.Name)
            {
                case "gridViewMessages":
                    for (int i = 0; i < gridViewMessages.RowCount; i++)
                    {
                        DataRowView row = (DataRowView)gridViewMessages.GetRow(gridViewMessages.GetVisibleRowHandle(i));
                        row["checked"] = !Convert.ToBoolean(row["checked"]);
                    }
                    break;
                case "gridViewTBLSCommitteMember":
                    for (int i = 0; i < gridViewTBLSCommitteMember.RowCount; i++)
                    {
                        DataRowView row = (DataRowView)gridViewTBLSCommitteMember.GetRow(gridViewTBLSCommitteMember.GetVisibleRowHandle(i));
                        row["checked"] = !Convert.ToBoolean(row["checked"]);
                    }
                    break;
                case "gridViewExcel":
                    for (int i = 0; i < gridViewExcel.RowCount; i++)
                    {
                        DataRowView row = (DataRowView)gridViewExcel.GetRow(gridViewExcel.GetVisibleRowHandle(i));
                        row["checked"] = !Convert.ToBoolean(row["checked"]);
                    }
                    break;
                default:
                    break;
            }
        }
        private void toolStripMenuItemAdd_Click(object sender, EventArgs e)
        {
            switch (gridControlMain.MainView.Name)
            {
                case "gridViewTBLSCommitteMember":
                    for (int i = 0; i < gridViewTBLSCommitteMember.RowCount; i++)
                    {
                        DataRowView row = (DataRowView)gridViewTBLSCommitteMember.GetRow(gridViewTBLSCommitteMember.GetVisibleRowHandle(i));
                        if (Convert.ToBoolean(row["checked"]))
                        {
                            if (row["Membermobil"].ToString() == string.Empty)
                                continue;
                            if (LBCSendTo.FindString(row["Membermobil"].ToString()) == -1)
                                LBCSendTo.Items.Add(row["Membermobil"]);
                        }
                    }
                    break;
                case "gridViewExcel":
                    for (int i = 0; i < gridViewExcel.RowCount; i++)
                    {
                        DataRowView row = (DataRowView)gridViewExcel.GetRow(gridViewExcel.GetVisibleRowHandle(i));
                        if (Convert.ToBoolean(row["checked"]))
                        {
                            if (row["mobile"].ToString() == string.Empty)
                                continue;
                            if (LBCSendTo.FindString(row["mobile"].ToString()) == -1)
                                LBCSendTo.Items.Add(row["mobile"]);
                        }
                    }
                    break;
                default:
                    break;
            }
        }
      
        #endregion

        
    }
}