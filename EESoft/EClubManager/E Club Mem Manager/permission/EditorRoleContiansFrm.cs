using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using DevExpress.XtraEditors.Controls;

namespace E_Club_Mem_Manager
{
    public partial class EditorRoleContiansFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        DataTable ItemTbl = new DataTable("Items");
        DataTable RolesTbl = new DataTable("Roles");
        #endregion
        #region -   Functions   -
        private void LoadData()
        {
            RolesTbl = new DataTable("Roles");
            RolesTbl = Program.MC.LoadDataTable("SELECT RoleID, RoleName, RoleDesc FROM aspnet_Roles", Program.MC.SQLConStrMembers);
            LUERoles.Properties.DataSource = RolesTbl;
            LUERoles.Properties.DisplayMember = "RoleName";
            LUERoles.Properties.ValueMember = "RoleID";
        }
        private void LoadItems(string Roleid)
        {
            ItemTbl = new DataTable("Items");
            ItemTbl = Program.MC.LoadDataTable("SELECT ObjectId, ObjectName, NAME, descreption_object, (SELECT '1' AS Active FROM TBL_OBJECTABLTY WHERE (RoleId = " + Roleid + ") AND (OBJECTId = TBL_Objects.ObjectId)) AS Active FROM TBL_Objects", Program.MC.SQLConStrMembers);
            CLSCItem.Items.Clear();
            foreach (DataRow row in ItemTbl.Rows)
            {
                if (row["Active"] == System.DBNull.Value)
                    CLSCItem.Items.Add(row["ObjectId"].ToString(), row["ObjectName"].ToString(), CheckState.Unchecked, true);
                else
                    CLSCItem.Items.Add(row["ObjectId"].ToString(), row["ObjectName"].ToString(), CheckState.Checked, true);
            }
        }
        public EditorRoleContiansFrm()
        {
            InitializeComponent();
        }
        #endregion
        #region -   Event Handlers   -
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection Con = new SqlConnection(Program.MC.SQLConStrMembers))
            {
                SqlCommand Cmd = new SqlCommand("", Con);
                SqlTransaction trn = null;
                try
                {
                    Con.Open();
                    trn = Con.BeginTransaction();
                    Cmd.Transaction = trn;
                    Cmd.CommandText = string.Format("Delete From TBL_OBJECTABLTY Where RoleId = N'{0}'", LUERoles.EditValue);
                    Cmd.ExecuteNonQuery();
                    foreach (DataRow row in ItemTbl.Rows)
                    {
                        if (row["Active"].ToString() == "1")
                            Cmd.CommandText = String.Format("INSERT INTO TBL_OBJECTABLTY (RoleId, OBJECTId, ABL_OPEN) VALUES ({0}, {1}, 1)", LUERoles.EditValue, row["ObjectId"].ToString());
                        else
                            Cmd.CommandText = String.Format("INSERT INTO TBL_OBJECTABLTY (RoleId, OBJECTId, ABL_OPEN) VALUES ({0}, {1}, 0)", LUERoles.EditValue, row["ObjectId"].ToString());
                        Cmd.ExecuteNonQuery();
                    }
                    trn.Commit();
                    LoadItems(LUERoles.EditValue.ToString());
                    MessageBox.Show("تم التعــــديل ", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    trn.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void LUEItems_EditValueChanged(object sender, EventArgs e)
        {
            TxtNote.Text = string.Empty;
            if (LUERoles.ItemIndex > -1)
            {
                LoadItems(LUERoles.EditValue.ToString());
                BtnUpdate.Enabled = true;
            }
            else
                BtnUpdate.Enabled = false;
        }
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void EditorRoleContiansFrm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void CLSCItem_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            if (e.State == CheckState.Checked)
                ItemTbl.Rows[e.Index]["Active"] = "1";
            else
                ItemTbl.Rows[e.Index]["Active"] = "0";
        }
        private void CLSCItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CLSCItem.SelectedIndex != -1)
                TxtNote.Text = ItemTbl.Rows[CLSCItem.SelectedIndex]["descreption_object"].ToString();
            else
                TxtNote.Text = string.Empty;
        }
        #endregion
        
    }
}