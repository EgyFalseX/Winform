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
    public partial class AccTypesDlgFrm : DevExpress.XtraEditors.XtraForm
    {
        public string AccountName = string.Empty;
        public string AccountID = string.Empty;

        public AccTypesDlgFrm()
        {
            InitializeComponent();
        }

        private void AccTypesDlgFrm_Load(object sender, EventArgs e)
        {
            //TLAccNames
            TLAccNames.Nodes[0].Tag = "FalseX";
            TLAccNames.Nodes[0].SetValue(1, "0");
            TLAccNames.Nodes[0].SetValue(2, "شجرة الحسابات");
            LoadNodes("0", TLAccNames.Nodes[0], true);
            
        }
        private void LoadNodes(string ParentID, TreeListNode Nodi, bool LoadChildNodes)
        {
            Nodi.Nodes.Clear();
            DataTable NodesTbl = new DataTable("NodeZ");
            NodesTbl = FXFW.SqlDB.LoadDataTable("SELECT AccountId, AccountTreeId, AccountDes, (SELECT KhtamiaccName FROM CDKHTAMIACOUNT WHERE (KhtamiaccID = TBL_Accountes.KhtamiaccID)) AS AsKhtamiaccName, (SELECT AccNatueName FROM CDAccountNature WHERE (AccNatueID = TBL_Accountes.AccNatueID)) AS AccNatueName, AccountBudget, AccountSort FROM TBL_Accountes WHERE (PairantAccount = " + ParentID + ") ORDER BY AccountSort");
            foreach (DataRow row in NodesTbl.Rows)
            {
                TreeListNode NewNode = this.TLAccNames.AppendNode(new object[] { 
                    row["AccountDes"].ToString(),
                    row["AccountId"].ToString() }, Nodi.Id, 0, 1, -1);
                if (LoadChildNodes)
                {
                    LoadNodes(ParentID, NewNode, false);
                }
            }
        }

        private void TLAccNames_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            if ((string)TLAccNames.Selection[0].GetValue(1).ToString() != "0")
                BtnOk.Enabled = true;
            else
                BtnOk.Enabled = false;
            string NodeID = "0";
            if (e.Node.GetValue(1) != null)
            {
                if ((string)e.Node.GetValue(1) != "0")
                {
                    NodeID = e.Node.GetValue(1).ToString();
                }
            }
            LoadNodes(NodeID, e.Node, true);
        }

        private void TLAccNames_AfterExpand(object sender, DevExpress.XtraTreeList.NodeEventArgs e)
        {
            string NodeID = "0";
            if (e.Node.GetValue(1) != null)
            {
                if ((string)e.Node.GetValue(1) != "0")
                {
                    NodeID = e.Node.GetValue(1).ToString();
                }
            }
            LoadNodes(NodeID, e.Node, true);
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (TLAccNames.Selection[0].GetValue(1).ToString() != "0")
            {
                AccountName = TLAccNames.Selection[0].GetValue(0).ToString() ;
                AccountID = TLAccNames.Selection[0].GetValue(1).ToString();
                this.Close();
            }
            else
                MessageBox.Show("من فضلك قم بأختار اسم الحساب اولا", "بيانات غير كامله", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            AccountName = string.Empty;
            AccountID = string.Empty;
            this.Close();
        }
    }
}