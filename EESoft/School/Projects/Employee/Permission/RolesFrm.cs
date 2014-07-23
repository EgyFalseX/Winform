using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace Employee
{
    public partial class RolesFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        DataTable ItemsTbl = new DataTable("Items");
        #endregion
        #region -   Functions   -
        private void LoadData()
        {
            ItemsTbl = new DataTable("Items");
            ItemsTbl = FXFW.SqlDB.LoadDataTable("SELECT RoleID, RoleName, RoleDesc FROM Roles");
            LUEItems.Properties.DataSource = ItemsTbl;
            LUEItems.Properties.DisplayMember = "RoleName";
            LUEItems.Properties.ValueMember = "RoleID";
        }
        public RolesFrm()
        {
            InitializeComponent();
        }
        private void ActivePriv()
        {
            bool Selecting = false, Inserting = false, Updateing = false, Deleting = false;
            FXFW.SqlDB.GetFormPriv("Emp" + Name.Replace("Frm", ""), ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
            groupControlSelect.Visible = Selecting;
            groupControlInsert.Visible = Inserting;
            groupControlUpdate.Visible = Updateing;
            BtnDelete.Visible = false;
        }
        #endregion
        #region -   Event Handlers   -
        private void EditorJobFrm_Load(object sender, EventArgs e)
        {
            ActivePriv();
            LoadData();
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد ..?!", "تأكيد الحذف..", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;

            using (SqlConnection Con = new SqlConnection(FXFW.SqlDB.SqlConStr))
            {
                SqlCommand Cmd = new SqlCommand(String.Format("DELETE FROM Roles WHERE (RoleID = {0})", LUEItems.EditValue), Con);
                try
                {
                    Con.Open();
                    Cmd.ExecuteNonQuery();
                    LoadData();
                    LUEItems.ItemIndex = -1;
                    Program.ShowMsg("تم الحذف ..", false, this);
                    Program.Logger.LogThis("تم الحذف ..", Text, FXFW.Logger.OpType.success, null, null, this);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, ex, null, this);

                }
            }
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection Con = new SqlConnection(FXFW.SqlDB.SqlConStr))
            {
                SqlCommand Cmd = new SqlCommand(String.Format("INSERT INTO Roles (RoleID, RoleName, RoleDesc) VALUES ({0}, N'{1}', N'{2}')", FXFW.SqlDB.GetNewID("Roles", "RoleID"), TxtNewItem.Text.Trim(), TxtNewDes.Text.Trim()), Con);
                try
                {
                    Con.Open();
                    Cmd.ExecuteNonQuery();
                    LoadData();
                    Program.ShowMsg("تم الاضافه ..", false, this);
                    Program.Logger.LogThis("تم الاضافه ..", Text, FXFW.Logger.OpType.success, null, null, this);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, ex, null, this);
                }
            }
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection Con = new SqlConnection(FXFW.SqlDB.SqlConStr))
            {
                SqlCommand Cmd = new SqlCommand(String.Format("UPDATE Roles SET RoleName = N'{0}', RoleDesc = N'{1}' WHERE (RoleID = {2})", TxtEditItem.Text.Trim(), TxtEditDes.Text.Trim(), LUEItems.EditValue), Con);
                try
                {
                    Con.Open();
                    Cmd.ExecuteNonQuery();
                    LoadData();
                    Program.ShowMsg("تم التعديل ..", false, this);
                    Program.Logger.LogThis("تم التعديل ..", Text, FXFW.Logger.OpType.success, null, null, this);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, ex, null, this);
                }
            }
        }
        private void TxtNewItem_EditValueChanged(object sender, EventArgs e)
        {
            if (TxtNewItem.Text.Trim().Length > 0)
                BtnAdd.Enabled = true;
            else
                BtnAdd.Enabled = false;
        }
        private void TxtEditItem_EditValueChanged(object sender, EventArgs e)
        {
            if (TxtEditItem.Text.Trim().Length > 0 && LUEItems.ItemIndex > -1)
                BtnUpdate.Enabled = true;
            else
                BtnUpdate.Enabled = false;
        }
        private void LUEItems_EditValueChanged(object sender, EventArgs e)
        {
            if (LUEItems.ItemIndex > -1)
            {
                TxtEditItem.Text = LUEItems.Text;
                TxtEditDes.Text = ItemsTbl.Rows[LUEItems.ItemIndex]["RoleDesc"].ToString();
                BtnUpdate.Enabled = true;
                BtnDelete.Enabled = true;
            }
            else
            {
                TxtEditItem.Text = string.Empty;
                TxtEditDes.Text = string.Empty;
                BtnUpdate.Enabled = false;
                BtnDelete.Enabled = false;
            }
        }
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        
        #endregion
    }
}