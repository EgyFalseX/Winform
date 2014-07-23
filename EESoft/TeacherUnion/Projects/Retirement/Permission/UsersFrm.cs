using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace Retirement
{
    public partial class UsersFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        DataTable ItemsTbl = new DataTable("Items");
        #endregion
        #region -   Functions   -
        private void LoadData()
        {
            ItemsTbl = new DataTable("Items");
            ItemsTbl = FXFW.SqlDB.LoadDataTable("SELECT UserID, UserName, UserPass, IsActive FROM Users");
            LUEItems.Properties.DataSource = ItemsTbl;
            LUEItems.Properties.DisplayMember = "UserName";
            LUEItems.Properties.ValueMember = "UserID";
        }
        public UsersFrm()
        {
            InitializeComponent();
        }
        private void ActivePriv()
        {
            bool Selecting = false, Inserting = false, Updateing = false, Deleting = false;
            FXFW.SqlDB.GetFormPriv("Retirement" + Name.Replace("Frm", ""), ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
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
                SqlCommand Cmd = new SqlCommand(String.Format("DELETE FROM Users WHERE (UserID = {0})", LUEItems.EditValue), Con);
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
            if (TxtAddPass1.Text.Trim().Length == 0 || TxtAddPass1.Text.Trim() != TxtAddPass2.Text.Trim())
            {
                Program.ShowMsg("من فضلك ادخل كلمة المرور ..", true, this);
                return;
            }
            using (SqlConnection Con = new SqlConnection(FXFW.SqlDB.SqlConStr))
            {
                SqlCommand Cmd = new SqlCommand(String.Format("INSERT INTO Users (UserID, UserName, UserPass, IsActive) VALUES ({0}, N'{1}', N'{2}', N'{3}')", FXFW.SqlDB.GetNewID("Users", "UserID"), TxtAddItem.Text.Trim(), TxtAddPass1.Text.Trim(), CEAddActive.Checked.ToString()), Con);
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
            if (TxtEditPass1.Text.Trim().Length == 0 || TxtEditPass1.Text.Trim() != TxtEditPass2.Text.Trim())
            {
                Program.ShowMsg("من فضلك ادخل كلمة المرور ..", true, this);
                return;
            }
            using (SqlConnection Con = new SqlConnection(FXFW.SqlDB.SqlConStr))
            {
                SqlCommand Cmd = new SqlCommand(String.Format("UPDATE Users SET UserName = N'{0}', UserPass = N'{1}', IsActive = N'{2}' WHERE (UserID = {3})", TxtEditItem.Text.Trim(), TxtEditPass1.Text.Trim(), CEEditActive.Checked.ToString(), LUEItems.EditValue), Con);
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
            if (TxtAddItem.Text.Trim().Length > 0)
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
                TxtEditPass1.Text = ItemsTbl.Rows[LUEItems.ItemIndex]["UserPass"].ToString();
                TxtEditPass2.Text = ItemsTbl.Rows[LUEItems.ItemIndex]["UserPass"].ToString();
                if (ItemsTbl.Rows[LUEItems.ItemIndex]["IsActive"].ToString() == "True")
                    CEEditActive.Checked = true;
                else
                    CEEditActive.Checked = false;
                BtnUpdate.Enabled = true;
                BtnDelete.Enabled = true;
            }
            else
            {
                TxtEditItem.Text = string.Empty;
                TxtEditPass1.Text = string.Empty;
                TxtEditPass2.Text = string.Empty;
                CEEditActive.Checked = true;
                BtnUpdate.Enabled = false;
                BtnDelete.Enabled = false;
            }
        }
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            LUEItems.EditValue = null;
        }
       
        #endregion
    }
}