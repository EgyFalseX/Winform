using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using DevExpress.XtraTreeList.Nodes;

namespace StAccount
{
    public partial class AccTypesFrm : DevExpress.XtraEditors.XtraForm
    {

        DataTable AccTypesTbl = new DataTable("FalseX");
        DataTable FinlAccTbl = new DataTable("FalseX");
        public AccTypesFrm()
        {
            InitializeComponent();
        }
        private void AccTypesFrm_Load(object sender, EventArgs e)
        {
            TreeListAcc.Nodes[0].Tag = "FalseX";
            TreeListAcc.Nodes[0].SetValue(1, "0");
            TreeListAcc.Nodes[0].SetValue(2, "شجرة الحسابات");
            TreeListAcc.Nodes[0].SetValue(3, "-1");
            LoadNodes("0", TreeListAcc.Nodes[0], true);
        }
        private void LoadNodes(string ParentID, TreeListNode Nodi, bool LoadChildNodes)
        {
            Nodi.Nodes.Clear();
            DataTable NodesTbl = new DataTable("NodeZ");
            NodesTbl = FXFW.SqlDB.LoadDataTable(@"SELECT AccountId, AccountTreeId, AccountDes, 
            AccountSort FROM CD_Acounts WHERE (PairantAccount = " + ParentID + ") ORDER BY AccountSort");
            
            foreach (DataRow row in NodesTbl.Rows)
            {
                TreeListNode NewNode =  this.TreeListAcc.AppendNode(new object[] { 
                    row["AccountDes"].ToString(),
                    row["AccountTreeId"].ToString(),
                    row["AccountDes"].ToString(),
                    row["AccountId"].ToString() }, Nodi.Id, 0, 1, -1);
                if (LoadChildNodes)
                    LoadNodes(ParentID, NewNode, false);
            }
        }
        
        private string GetNewTreeId(string ParentID, string ParentTreeID)
        {
            string ReturnMe = string.Empty;
            string LatestTreeID = "0";
            SqlConnection Con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand Cmd = new SqlCommand("", Con);
            if ((string)ParentID == "-1")// The Parent is the root
            {
                Cmd = new SqlCommand("SELECT TOP (1) AccountTreeId FROM CD_Acounts WHERE (PairantAccount = 0) ORDER BY AccountSort DESC", Con);
            }
            else
            {
                Cmd = new SqlCommand("SELECT TOP (1) AccountTreeId FROM CD_Acounts WHERE (PairantAccount = " + ParentID + ") ORDER BY AccountSort DESC", Con);
            }
            
            SqlDataReader dr;
            try
            {
                Con.Open();
                dr = Cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    LatestTreeID = dr.GetValue(0).ToString();
                }

                ReturnMe = IncreaseTreeID(LatestTreeID, ParentTreeID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Con.Close();
            return ReturnMe;
        }
        private string IncreaseTreeID(string TreeID, string ParentTreeID)
        {
            string ReturnMe = string.Empty;
            int NewIDLen = 0;
            if (ParentTreeID == "0")
            {
                ParentTreeID = string.Empty;
            }
            switch (ParentTreeID.Length)
            {
                case 0:
                    NewIDLen = 1;
                    break;
                case 1:// Level 1
                    NewIDLen = 3;
                    break;
                case 3:// Level 2
                    NewIDLen = 6;
                    break;
                case 6:// Level 3
                    NewIDLen = 10;
                    break;
                case 10:// Level 4
                    NewIDLen = 15;
                    break;
                case 15:// Level 5
                    NewIDLen = 21;
                    break;
                case 21:// Level 6
                    NewIDLen = 28;
                    break;
                case 28:// Level 7
                    NewIDLen = 36;
                    break;
                case 36:// Level 8
                    NewIDLen = 45;
                    break;
                case 45:// Level 9
                    NewIDLen = 55;
                    break;
                case 55:// Level 10
                    NewIDLen = 66;
                    break;
                default:
                    break;
            }
            if (TreeID.Length >= NewIDLen)
            {
                TreeID = TreeID.Substring(ParentTreeID.Length);
            }
            ReturnMe = (Convert.ToInt16(TreeID) + 1).ToString();



            if ((ReturnMe.Length + ParentTreeID.Length) > NewIDLen)
            {
                return string.Empty;
            }
            for (int i = ReturnMe.Length; i < (NewIDLen - ParentTreeID.Length); i++)
            {
                ReturnMe = "0" + ReturnMe;
            }
            ReturnMe = ParentTreeID + ReturnMe;
            return ReturnMe;
        }
        private string NewNodeID()
        {
            return FXFW.SqlDB.GetNewID("CD_Acounts", "AccountId");
        }
        private void TreeListAcc_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            
            if (TreeListAcc.Selection.Count == 0)
                BtnDelete.Enabled = false;
            else
            {
                if ((string)TreeListAcc.Selection[0].Tag == "FalseX")// The Root
                    BtnDelete.Enabled = false;
                else
                    BtnDelete.Enabled = true;
            }

            string NodeID = "0";
            if (e.Node.GetValue(3) != null)
            {
                if ((string)e.Node.GetValue(3) != "-1")
                {
                    NodeID = e.Node.GetValue(3).ToString();    
                }
            }
            LoadNodes(NodeID, e.Node, true);
        }
        private void TreeListAcc_AfterExpand(object sender, DevExpress.XtraTreeList.NodeEventArgs e)
        {
            string NodeID = "0";
            if (e.Node.GetValue(3) != null)
            {
                if ((string)e.Node.GetValue(3) != "-1")
                {
                    NodeID = e.Node.GetValue(3).ToString();
                }
            }
            LoadNodes(NodeID, e.Node, true);
        }
        private void BtnNew_Click(object sender, EventArgs e)
        {
            //fill codes group
            LblAccCode.Text = NewNodeID();
            LblTreeID.Text = GetNewTreeId(TreeListAcc.Selection[0].GetValue(3).ToString(), TreeListAcc.Selection[0].GetValue(1).ToString());
            LblParentName.Text = TreeListAcc.Selection[0].GetValue(2).ToString();
            //disable unneeded controls
            TreeListAcc.Enabled = false;
            BtnCancel.Enabled = true;
            GCCodes.Visible = true;
            GCDetails.Visible = true;
            BtnSave.Visible = true;
            BtnCancel.Visible = true;
            TxtAccName.Focus();
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            //clear codes group
            LblAccCode.Text = "None";
            LblTreeID.Text = "None";
            LblParentName.Text = "None";
            //enable needed controls
            TreeListAcc.Enabled = true;
            BtnCancel.Enabled = false;
            GCCodes.Visible = false;
            GCDetails.Visible = false;
            BtnSave.Visible = false;
            BtnCancel.Visible = false;
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            // Save new Node.

            string AccountId = "NULL", AccountTreeId = "NULL", PairantAccount = "NULL",  AccountDes = "NULL", AccountSort = "NULL";
            SqlConnection Con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand Cmd = new SqlCommand("", Con);
            AccountId = NewNodeID();
            AccountTreeId = LblTreeID.Text;
            if (TreeListAcc.Selection[0].GetValue(3).ToString() == "-1")
                PairantAccount = "0";
            else
                PairantAccount = TreeListAcc.Selection[0].GetValue(3).ToString();
            if (TxtAccName.Text.Trim().Length != 0)
                AccountDes = String.Format("N'{0}'", TxtAccName.Text.Trim());
            else
                AccountDes = "NULL";
            AccountSort = GetNextSoftID(TreeListAcc.Selection[0].GetValue(3).ToString());

            Cmd.CommandText = String.Format(@"INSERT INTO CD_Acounts (AccountId, AccountTreeId, PairantAccount, AccountDes, AccountSort) VALUES ({0}, {1}, {2}, {3}, {4})", 
            AccountId, AccountTreeId, PairantAccount, AccountDes, AccountSort);
            try
            {
                Con.Open();
                Cmd.ExecuteNonQuery();
                TreeListAcc_AfterExpand(TreeListAcc,new DevExpress.XtraTreeList.NodeEventArgs(TreeListAcc.Selection[0]));
                BtnCancel_Click(BtnCancel, new EventArgs());
                Program.ShowMsg("تم الحفظ", false, this);
                Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
            Con.Close();
        }
        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (TreeListAcc.Selection[0].GetValue(3).ToString() == "-1")
            {
                TreeListAcc.Selection[0].SetValue(2, "شجرة الحسابات");
                return;
            }
            if (MessageBox.Show("هل انت متأكد؟", "تحزير - تعديل", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.No)
                return;
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                con.Open();
                cmd.CommandText = string.Format(@"UPDATE CD_Acounts SET AccountDes = N'{0}' Where AccountId = {1}", TreeListAcc.Selection[0].GetValue(2), TreeListAcc.Selection[0].GetValue(3));
                cmd.ExecuteNonQuery();
                Program.ShowMsg("تم التعديل", false, this);
                Program.Logger.LogThis("تم التعديل", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
            con.Close();

        }
        private string GetNextSoftID(string  ParentID)
        {
            if ((string)ParentID == "-1")
            {
                ParentID = "0";
            }
            string ReturnMe = string.Empty;
            SqlConnection Con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand Cmd = new SqlCommand(String.Format("SELECT TOP (1) AccountSort FROM CD_Acounts WHERE (PairantAccount = {0}) ORDER BY AccountSort DESC", ParentID), Con);
            SqlDataReader dr;
            try
            {
                Con.Open();
                dr = Cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    ReturnMe = dr.GetValue(0).ToString();
                    ReturnMe = (Convert.ToInt16(ReturnMe) + 1).ToString();
                }
                else
                    ReturnMe = "1";
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
            Con.Close();
            return ReturnMe;
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (CheckNodeHaveChild(TreeListAcc.Selection[0].GetValue(3).ToString()))
            {
                Program.ShowMsg("لا يمكن حذف حساب به حسابات فرعيه", true, this);
                Program.Logger.LogThis("لا يمكن حذف حساب به حسابات فرعيه", Text, FXFW.Logger.OpType.information, null, null, this);
                return;
            }
            if (MessageBox.Show("هل انت متأكد؟", "تحزير - حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.No)
                return;
            SqlConnection Con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand Cmd = new SqlCommand(String.Format("DELETE FROM CD_Acounts WHERE (AccountId = {0})", TreeListAcc.Selection[0].GetValue(3)), Con);
            try
            {
                Con.Open();
                Cmd.ExecuteNonQuery();
                //TreeListAcc_AfterExpand(TreeListAcc, new DevExpress.XtraTreeList.NodeEventArgs(TreeListAcc.Selection[0]));
                TreeListAcc.DeleteSelectedNodes();
                Program.ShowMsg("تم الحذف", false, this);
                Program.Logger.LogThis("تم الحذف", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
            Con.Close();
        }
        private bool CheckNodeHaveChild(string AccountID)
        {
            if (AccountID == "-1")
            {
                return false;
            }
            bool ReturnMe = false;
            SqlConnection Con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", Con);
            cmd.CommandText = string.Format(@"if exists(SELECT * FROM CD_Acounts WHERE (PairantAccount = {0}))
                                            select 'true'
                                            else
                                            select 'false'", AccountID);
            try
            {
                Con.Open();
                ReturnMe = Convert.ToBoolean(cmd.ExecuteScalar().ToString());
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
            Con.Close();
            return ReturnMe;
        }
        private void TxtAccName_EditValueChanged(object sender, EventArgs e)
        {
            if (TxtAccName.Text.Trim().Length > 0)
            {
                BtnSave.Enabled = true;
            }
            else
            {
                BtnSave.Enabled = false;
            }
        }

        

    }
}