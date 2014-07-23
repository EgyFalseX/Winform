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

namespace RetirementCenter.Forms.Data
{
    public partial class RoleSyndicateFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        DataTable RoleTbl = new DataTable("Role");
        DataTable SyndicateTbl = new DataTable("Syndicate");
        #endregion
        #region -   Functions   -
        private void LoadData()
        {
            RoleTbl = new DataTable("Role");
            RoleTbl = FXFW.SqlDB.LoadDataTable("SELECT RoleID, RoleName FROM Roles");
            LUEItems.Properties.DataSource = RoleTbl;
            LUEItems.Properties.DisplayMember = "RoleName";
            LUEItems.Properties.ValueMember = "RoleID";
        }
        private void LoadSyndicates(string RoleID)
        {
            SyndicateTbl = new DataTable("Syndicate");
            SyndicateTbl = FXFW.SqlDB.LoadDataTable(string.Format(@"SELECT SyndicateId, Syndicate, 
            ISNULL((SELECT '1' FROM RoleSyndicate WHERE RoleID = {0} AND SyndicateId = CDSyndicate.SyndicateId), 0) AS Active
            FROM CDSyndicate", RoleID));
            CLSCRole.Items.Clear();
            foreach (DataRow row in SyndicateTbl.Rows)
            {
                if ((string)row["Active"] == "0")
                    CLSCRole.Items.Add(row["SyndicateId"].ToString(), row["Syndicate"].ToString(), CheckState.Unchecked, true);
                else
                    CLSCRole.Items.Add(row["SyndicateId"].ToString(), row["Syndicate"].ToString(), CheckState.Checked, true);
            }
        }
        public RoleSyndicateFrm()
        {
            InitializeComponent();
        }
        private void ActivePriv()
        {
            return;//ActivePrivReady
            bool Selecting = false, Inserting = false, Updateing = false, Deleting = false;
            SQLProvider.GetFormPriv(this.Name, ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
            LUEItems.Visible = Selecting;
            if (Inserting || Updateing || Deleting)
                BtnUpdate.Visible = true;
        }
        #endregion
        #region -   Event Handlers   -
        private void EditorJobFrm_Load(object sender, EventArgs e)
        {
            ActivePriv();
            LoadData();
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection Con = new SqlConnection(FXFW.SqlDB.SqlConStr))
            {
                SqlCommand Cmd = new SqlCommand("", Con);
                SqlTransaction trn = null;
                try
                {
                    Con.Open();
                    trn = Con.BeginTransaction();
                    Cmd.Transaction = trn;
                    Cmd.CommandText = string.Format("Delete From RoleSyndicate Where RoleID = {0}", LUEItems.EditValue);
                    Cmd.ExecuteNonQuery();
                    foreach (DataRow row in SyndicateTbl.Rows)
                    {
                        if (row["Active"].ToString() == "1")
                        {
                            Cmd.CommandText = String.Format("INSERT INTO RoleSyndicate (RoleID, SyndicateId) VALUES ({0}, {1})", LUEItems.EditValue, row["SyndicateId"].ToString());
                            Cmd.ExecuteNonQuery();
                        }
                    }
                    trn.Commit();
                    LoadSyndicates(LUEItems.EditValue.ToString());
                    Program.ShowMsg("تم التعديل ..", false, this, true);
                    Program.Logger.LogThis("تم التعديل ..", Text, FXFW.Logger.OpType.success, null, null, this);
                }
                catch (Exception ex)
                {
                    trn.Rollback();
                    msgDlg.Show(ex.Message);
                    Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, ex, null, this);
                }
            }
        }
        private void LUEItems_EditValueChanged(object sender, EventArgs e)
        {
            TxtNote.Text = string.Empty;
            if (LUEItems.ItemIndex > -1)
            {
                LoadSyndicates(LUEItems.EditValue.ToString());
                BtnUpdate.Enabled = true;
            }
            else
                BtnUpdate.Enabled = false;
        }
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void CLSCRole_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            if (e.State == CheckState.Checked)
                SyndicateTbl.Rows[e.Index]["Active"] = "1";
            else
                SyndicateTbl.Rows[e.Index]["Active"] = "0";
        }
        #endregion
    }
}