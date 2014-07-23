using System;
using System.Data;
using System.Data.SqlClient;
using DevExpress.XtraBars;

namespace Training_Center
{
    public partial class EditorRoleMenuFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        DataTable RolesTbl = new DataTable("Roles");
        DataTable RoleDetialsTbl = new DataTable("Detials");
        #endregion
        #region -   Functions   -
        public EditorRoleMenuFrm()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            RolesTbl = new DataTable("Roles");
            RolesTbl = MyCL.LoadDataTable("SELECT RoleID, RoleName, RoleDesc FROM Roles");
            LUEItems.Properties.DataSource = RolesTbl;
            LUEItems.Properties.DisplayMember = "RoleName";
            LUEItems.Properties.ValueMember = "RoleID";
        }
        private void ClearMenuCheck()
        {
            foreach (BarItem item in barManager.Items)
            {
                if (item is BarCheckItem)
                    ((BarCheckItem)item).Checked = false;
            }
        }
        private void AddRemoveMenuItem(string RoleID, string MenuName)
        {
            DataTable dt = MyCL.LoadDataTable(string.Format(@"SELECT * FROM RoleDetial WHERE RoleID = {0} AND MenuItemName = '{1}'", RoleID, MenuName));
            using (SqlConnection con = new SqlConnection(MyCL.SqlConStr))
            {
                SqlCommand cmd = new SqlCommand("", con);
                try
                {
                    if (dt.Rows.Count > 0)
                    {
                        cmd.CommandText = string.Format(@"Delete From RoleDetial WHERE (RoleID = {0} AND MenuItemName = '{1}')", RoleID, MenuName);
                    }
                    else
                    {
                        cmd.CommandText = string.Format(@"INSERT INTO RoleDetial(RoleID, MenuItemName) VALUES ({0}, '{1}')", RoleID, MenuName);
                    }
                    con.Open();
                    cmd.ExecuteNonQuery();
                    //MyCL.ShowMsg("تم التعديل ...", false, this);
                }
                catch (SqlException ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                    //MyCL.ShowMsg(MyCL.CheckExp(ex), true, this);
                }
                con.Close();
            }
        }
        #endregion
        #region -   Event Handlers   -
        private void EditorRoleMenuFrm_Load(object sender, EventArgs e)
        {
            LoadData();
            barManager.MdiMenuMergeStyle = BarMdiMenuMergeStyle.Never;
        }
        private void LUEItems_EditValueChanged(object sender, EventArgs e)
        {
            ClearMenuCheck();
            if (LUEItems.EditValue == null)
                barMM.Visible = false;
            else
            {
                LoadRoleDetial(LUEItems.EditValue.ToString());
                barMM.Visible = true;
            }
        }
        private void LoadRoleDetial(string RoleID)
        {
            RoleDetialsTbl = new DataTable("Detials");
            RoleDetialsTbl = MyCL.LoadDataTable(@"SELECT RoleID, MenuItemName FROM RoleDetial WHERE RoleID = " + RoleID);
            foreach (DataRow row in RoleDetialsTbl.Rows)
            {
                foreach (BarItem item in barManager.Items)
                {
                    if (item.Name == row["MenuItemName"].ToString())
                    {
                        ((BarCheckItem)item).Checked = true;
                        break;
                    }
                }
            }
        }
        private void mb_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            AddRemoveMenuItem(LUEItems.EditValue.ToString(), e.Item.Name);
        }
        #endregion

    }
}