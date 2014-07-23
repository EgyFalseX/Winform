using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace schoolStore
{
    public partial class AccTreeOptionsFrm : DevExpress.XtraEditors.XtraForm
    {

        #region -   Functions   -
        public AccTreeOptionsFrm()
        {
            InitializeComponent();
        }
        private void LoadTreeView(TreeView TV)
        {
            TV.Nodes.Clear();
            DataTable TblTBL_Accountes = new DataTable("TblTBL_Accountes");
            TblTBL_Accountes = FXFW.SqlDB.LoadDataTable("Select AccountId, AccountDes, AccountTreeId, PairantAccount From TBL_Accountes Where PairantAccount = 0");
            foreach (DataRow row in TblTBL_Accountes.Rows)
            {
                TreeNode NewNode = TV.Nodes.Add(row["AccountId"].ToString(), row["AccountDes"].ToString(), 0);
                LoadSubRoot(NewNode);
            }
        }
        private void LoadSubRoot(TreeNode Nodi)
        {
            DataTable TblTBL_Accountes = new DataTable("TblTBL_Accountes");
            TblTBL_Accountes = FXFW.SqlDB.LoadDataTable("Select AccountId, AccountDes, AccountTreeId, PairantAccount From TBL_Accountes Where PairantAccount = " + Nodi.Name);
            foreach (DataRow row in TblTBL_Accountes.Rows)
            {
                TreeNode NewNode = Nodi.Nodes.Add(row["AccountId"].ToString(), row["AccountDes"].ToString(), 0);
                LoadSubRoot(NewNode);
            }
        }
        private string SelectNode(TreeView TV, string AccountId)
        {
            string RetuenMe = string.Empty;
            try
            {
                RetuenMe = FXFW.SqlDB.LoadDataTable(@"Select AccountDes From TBL_Accountes Where AccountId = " + AccountId).Rows[0][0].ToString();
                TreeNode[] Nodz = TV.Nodes.Find(AccountId, true);
                if (Nodz.Length > 0)
                    TV.SelectedNode = Nodz[0];
                else
                {
                    RetuenMe = string.Empty;
                    TV.SelectedNode = null;
                }
            }
            catch
            {
                return string.Empty;
            }
            return RetuenMe;
        }
        #endregion
        #region -   Event Handlers   -
        private void AccTreeOptionsFrm_Load(object sender, EventArgs e)
        {
            LoadTreeView(TVsupplier);
            string supplier = Program.GetOptionValue(Program.AppOptions.supplier);
            if (supplier == string.Empty) 
                Txtsupplier.Text = string.Empty;
            else
                Txtsupplier.Text = SelectNode(TVsupplier, Program.GetOptionValue(Program.AppOptions.supplier));
        }
        private void xtraTabControlMain_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            switch (e.Page.Name)
            {
                case "xtraTabPagesupplier":
                    LoadTreeView(TVsupplier);
                    string supplier = Program.GetOptionValue(Program.AppOptions.supplier);
                    if (supplier == string.Empty)
                        Txtsupplier.Text = string.Empty;
                    else
                        Txtsupplier.Text = SelectNode(TVsupplier, Program.GetOptionValue(Program.AppOptions.supplier));
                    break;
                case "xtraTabPagecustomer":
                    LoadTreeView(TVcustomer);
                    string customer = Program.GetOptionValue(Program.AppOptions.customer);
                    if (customer == string.Empty)
                        Txtcustomer.Text = string.Empty;
                    else
                        Txtcustomer.Text = SelectNode(TVcustomer, Program.GetOptionValue(Program.AppOptions.customer));
                    break;
                case "New":
                    break;

            }
        }
        private void Btnsupplier_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟","تحزيـــــر",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            if (TVsupplier.SelectedNode == null)
            {
                Program.msg("من فضلك اختار حساب", true, "", this);
                return;
            }
            if (Program.SetOptionValue(Program.AppOptions.supplier, TVsupplier.SelectedNode.Name))
                Program.msg("تم الحفــــــــــظ", false, "", this);
            else
                Program.msg("لم يتم الحفـــظ", true, "", this);
        }
        private void Btncustomer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزيـــــر", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            if (TVcustomer.SelectedNode == null)
            {
                Program.msg("من فضلك اختار حساب", true, "", this);
                return;
            }
            if (Program.SetOptionValue(Program.AppOptions.customer, TVcustomer.SelectedNode.Name))
                Program.msg("تم الحفــــــــــظ", false, "", this);
            else
                Program.msg("لم يتم الحفـــظ", true, "", this);
        }
        #endregion
    }
}