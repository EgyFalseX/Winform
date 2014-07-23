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

namespace schoolStore
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
            TreeListAcc.Nodes[0].SetValue(6, "-1");
            LoadNodes("0", TreeListAcc.Nodes[0], true);
            FillDefaultData();
        }
        private void LoadNodes(string ParentID, TreeListNode Nodi, bool LoadChildNodes)
        {
            Nodi.Nodes.Clear();
            DataTable NodesTbl = new DataTable("NodeZ");
            NodesTbl = FXFW.SqlDB.LoadDataTable("SELECT AccountId, AccountTreeId, AccountDes, (SELECT KhtamiaccName FROM CDKHTAMIACOUNT WHERE (KhtamiaccID = TBL_Accountes.KhtamiaccID)) AS AsKhtamiaccName, (SELECT AccNatueName FROM CDAccountNature WHERE (AccNatueID = TBL_Accountes.AccNatueID)) AS AccNatueName, AccountBudget, AccountSort FROM TBL_Accountes WHERE (PairantAccount = " + ParentID + ") ORDER BY AccountSort");
            foreach (DataRow row in NodesTbl.Rows)
            {
                TreeListNode NewNode =  this.TreeListAcc.AppendNode(new object[] { 
                    row["AccountDes"].ToString(),
                    row["AccountTreeId"].ToString(),
                    row["AccountDes"].ToString(),
                    row["AccNatueName"].ToString(),
                    row["AccountBudget"].ToString(),
                    row["AsKhtamiaccName"].ToString(),
                    row["AccountId"].ToString() }, Nodi.Id, 0, 1, -1);
                if (LoadChildNodes)
                    LoadNodes(ParentID, NewNode, false);
            }
        }
        private void FillDefaultData()
        {
            AccTypesTbl = new DataTable("FalseX");
            FinlAccTbl = new DataTable("FalseX");
            SqlDataAdapter da = new SqlDataAdapter("",FXFW.SqlDB.SqlConStr);
            try
            {
                //Load All Account Types
                da.SelectCommand.CommandText = "SELECT AccNatueID, AccNatueName FROM CDAccountNature";
                da.Fill(AccTypesTbl);
                //Load All Finall Accounts
                da.SelectCommand.CommandText = "SELECT KhtamiaccID, KhtamiaccName FROM CDKHTAMIACOUNT";
                da.Fill(FinlAccTbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            LUEAccType.Properties.DataSource = AccTypesTbl;
            LUEAccType.Properties.DisplayMember = "AccNatueName";
            LUEAccType.Properties.ValueMember = "AccNatueID";
            LUEAccEndCount.Properties.DataSource = FinlAccTbl;
            LUEAccEndCount.Properties.DisplayMember = "KhtamiaccName";
            LUEAccEndCount.Properties.ValueMember = "KhtamiaccID";
        }
        private string GetNewTreeId(string ParentID, string ParentTreeID)
        {
            string ReturnMe = string.Empty;
            string LatestTreeID = "0";
            SqlConnection Con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand Cmd = new SqlCommand("", Con);
            if ((string)ParentID == "-1")// The Parent is the root
            {
                Cmd = new SqlCommand("SELECT TOP (1) AccountTreeId FROM TBL_Accountes WHERE (PairantAccount = 0) ORDER BY AccountSort DESC", Con);
            }
            else
            {
                Cmd = new SqlCommand("SELECT TOP (1) AccountTreeId FROM TBL_Accountes WHERE (PairantAccount = " + ParentID + ") ORDER BY AccountSort DESC", Con);
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
            string ReturnMe = string.Empty;
            SqlConnection Con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand Cmd = new SqlCommand("SELECT ISNULL(MAX(AccountId) + 1, 1) AS NewID FROM TBL_Accountes AS NewID", Con);
            try
            {
                Con.Open();
                ReturnMe=Cmd.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Con.Close();
            return ReturnMe;
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
            if (e.Node.GetValue(6) != null)
            {
                if ((string)e.Node.GetValue(6) != "-1")
                {
                    NodeID = e.Node.GetValue(6).ToString();    
                }
            }
            LoadNodes(NodeID, e.Node, true);
        }
        private void TreeListAcc_AfterExpand(object sender, DevExpress.XtraTreeList.NodeEventArgs e)
        {
            string NodeID = "0";
            if (e.Node.GetValue(6) != null)
            {
                if ((string)e.Node.GetValue(6) != "-1")
                {
                    NodeID = e.Node.GetValue(6).ToString();
                }
            }
            LoadNodes(NodeID, e.Node, true);
        }
        private void BtnNew_Click(object sender, EventArgs e)
        {
            //fill codes group
            LblAccCode.Text = NewNodeID();
            LblTreeID.Text = GetNewTreeId(TreeListAcc.Selection[0].GetValue(6).ToString(), TreeListAcc.Selection[0].GetValue(1).ToString());
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

            string AccountId = "NULL", AccountTreeId = "NULL", PairantAccount = "NULL", AccountDes = "NULL", AccountSort = "NULL", KhtamiaccID = "NULL", AccNatueID = "NULL", AccountBudget = "NULL";
            SqlConnection Con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand Cmd = new SqlCommand("", Con);
            AccountId = NewNodeID();
            AccountTreeId = LblTreeID.Text;
            if (TreeListAcc.Selection[0].GetValue(6).ToString() == "-1")
                PairantAccount = "0";
            else
                PairantAccount = TreeListAcc.Selection[0].GetValue(6).ToString();
            if (TxtAccName.Text.Trim().Length != 0) AccountDes = "N'" + TxtAccName.Text.Trim() + "'";
            AccountSort = GetNextSoftID(TreeListAcc.Selection[0].GetValue(6).ToString());
            if (LUEAccEndCount.EditValue != null) KhtamiaccID = LUEAccEndCount.EditValue.ToString();
            if (LUEAccType.EditValue != null) AccNatueID = LUEAccType.EditValue.ToString();
            if (TxtBudge.Text.Trim().Length != 0) AccountBudget = TxtBudge.Text.Trim();
            Cmd.CommandText = "INSERT INTO TBL_Accountes (AccountId, AccountTreeId, PairantAccount, AccountDes, AccountSort, KhtamiaccID, AccNatueID, AccountBudget) VALUES (" + AccountId + ", " + AccountTreeId + ", " + PairantAccount + ", " + AccountDes + ", " + AccountSort + ", " + KhtamiaccID + ", " + AccNatueID + ", " + AccountBudget + ")";
            try
            {
                Con.Open();
                Cmd.ExecuteNonQuery();
                TreeListAcc_AfterExpand(TreeListAcc,new DevExpress.XtraTreeList.NodeEventArgs(TreeListAcc.Selection[0]));
                BtnCancel_Click(BtnCancel, new EventArgs());
                MessageBox.Show("تم اضافة الحساب", "تمت العمليه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Con.Close();
        }
        private string GetNextSoftID(string  ParentID)
        {
            if ((string)ParentID == "-1")
            {
                ParentID = "0";
            }
            string ReturnMe = string.Empty;
            SqlConnection Con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand Cmd = new SqlCommand("SELECT TOP (1) AccountSort FROM TBL_Accountes WHERE (PairantAccount = " + ParentID + ") ORDER BY AccountSort DESC", Con);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Con.Close();
            return ReturnMe;
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (!CheckEmptyNode(TreeListAcc.Selection[0].GetValue(6).ToString()))
            {
                MessageBox.Show("لا يمكن حذف حساب به حسابات فرعيه","خطـــا",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            SqlConnection Con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand Cmd = new SqlCommand("DELETE FROM TBL_Accountes WHERE (AccountId = " + TreeListAcc.Selection[0].GetValue(6).ToString() + ")", Con);
            try
            {
                Con.Open();
                Cmd.ExecuteNonQuery();
                //TreeListAcc_AfterExpand(TreeListAcc, new DevExpress.XtraTreeList.NodeEventArgs(TreeListAcc.Selection[0]));
                TreeListAcc.DeleteSelectedNodes();
                MessageBox.Show("تم حذف الحساب", "تمت العمليه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Con.Close();
        }
        private bool CheckEmptyNode(string AccountID)
        {
            if (AccountID == "-1")
            {
                return false;
            }
            bool ReturnMe = false;
            SqlConnection Con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand Cmd = new SqlCommand("SELECT COUNT(*) AS FalseX FROM TBL_Accountes WHERE (PairantAccount = " + AccountID + ")", Con);
            SqlDataReader dr;
            try
            {
                Con.Open();
                dr = Cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    ReturnMe = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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