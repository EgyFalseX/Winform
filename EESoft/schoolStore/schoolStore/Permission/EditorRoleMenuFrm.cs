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
    public partial class EditorRoleMenuFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        DataTable RolesTbl = new DataTable("Roles");
        DataTable RoleDetialsTbl = new DataTable("Detials");
        private ToolStripMenuItem[] MenuItemZ = null;
        #endregion
        #region -   Functions   -
        public EditorRoleMenuFrm()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            RolesTbl = new DataTable("Roles");
            RolesTbl = FXFW.SqlDB.LoadDataTable("SELECT RoleID, RoleName, RoleDesc FROM Roles");
            LUEItems.Properties.DataSource = RolesTbl;
            LUEItems.Properties.DisplayMember = "RoleName";
            LUEItems.Properties.ValueMember = "RoleID";
        }
        private void LoadMenuItem()
        {
            foreach (ToolStripMenuItem item in menuStrip.Items)
                GetSubMenuItem(item);
        }
        private void GetSubMenuItem(ToolStripMenuItem MItem)
        {
            foreach (ToolStripMenuItem item in MItem.DropDownItems)
            {
                if (MenuItemZ == null)
                {
                    MenuItemZ = new ToolStripMenuItem[1];
                }
                else
                {
                    ToolStripMenuItem[] tempItemList = new ToolStripMenuItem[MenuItemZ.Length + 1];
                    MenuItemZ.CopyTo(tempItemList, 0);
                    MenuItemZ = tempItemList;
                }
                MenuItemZ[MenuItemZ.Length - 1] = item;

                if (item.DropDownItems != null)
                {
                    GetSubMenuItem(item);
                }
            }
        }
        private void ClearMenuCheck()
        {
            if (MenuItemZ == null)
                return;
            foreach (ToolStripMenuItem item in MenuItemZ)
                item.CheckState = CheckState.Unchecked;
        }
        private void AddRemoveMenuItem(string RoleID, string MenuName)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                cmd.CommandText = string.Format(@"IF EXISTS (SELECT * FROM RoleDetial WHERE RoleID = {0} AND MenuItemName = N'{1}')
                                    Delete From RoleDetial WHERE (RoleID = {2} AND MenuItemName = N'{3}')
                                    Else
                                    INSERT INTO RoleDetial(RoleID, MenuItemName) VALUES ({4}, N'{5}')", RoleID, MenuName, RoleID, MenuName, RoleID, MenuName);
                con.Open();
                cmd.ExecuteNonQuery();
                //Program.msg("Role Items Updated ...", false, "", this);
            }
            catch (SqlException ex)
            {
                Program.msg(FXFW.SqlDB.CheckExp(ex), true, ex.Number.ToString(), this);
            }
            con.Close();
        }
        private void LoadSQLReports()
        {
            try
            {
                if (FXFW.SqlDB.SQLRep == null)
                    return;
                for (int i = 0; i < FXFW.SqlDB.SQLRep.Length; i++)
                {
                    ToolStripMenuItem TSMI = new ToolStripMenuItem();
                    TSMI.Name = FXFW.SqlDB.SQLRep[i].RepFileName.Replace(".rdl", "");
                    TSMI.Text = FXFW.SqlDB.SQLRep[i].RepCaption;
                    TSMI.ImageIndex = 0;
                    TSMI.Tag = i;
                    TSMI.CheckOnClick = true;
                    TSMI.Image = global::schoolStore.Properties.Resources.Report;
                    //TSMI.Visible = false;
                    ((ToolStripMenuItem)printingToolStripMenuItem.DropDownItems[Convert.ToInt16(FXFW.SqlDB.SQLRep[i].RepPosition)]).DropDownItems.Add(TSMI);
                    TSMI.Click += ToolStripMenuItem_Click;
                }
            }
            catch (Exception ex)
            {
                Program.msg(ex.Message, true, "", this);
            }
        }
        #endregion
        #region -   Event Handlers   -
        private void EditorRoleMenuFrm_Load(object sender, EventArgs e)
        {
            LoadSQLReports();
            LoadMenuItem();
            LoadData();
        }
        private void LUEItems_EditValueChanged(object sender, EventArgs e)
        {
            ClearMenuCheck();
            if (LUEItems.EditValue == null)
                menuStrip.Visible = false;
            else
            {
                LoadRoleDetial(LUEItems.EditValue.ToString());
                menuStrip.Visible = true;
            }
        }
        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FXFW.SqlDB.IsNullOrEmpty(LUEItems.EditValue))
            {
                ToolStripMenuItem MenuItem = (ToolStripMenuItem)sender;
                AddRemoveMenuItem(LUEItems.EditValue.ToString(), MenuItem.Name);    
            }
        }
        private void LoadRoleDetial(string RoleID)
        {
            RoleDetialsTbl = new DataTable("Detials");
            RoleDetialsTbl = FXFW.SqlDB.LoadDataTable(@"SELECT RoleID, MenuItemName FROM RoleDetial WHERE RoleID = " + RoleID);
            foreach (DataRow row in RoleDetialsTbl.Rows)
            {
                foreach (ToolStripMenuItem item in MenuItemZ)
                {
                    if (item.Name == row["MenuItemName"].ToString())
                    {
                        item.CheckState = CheckState.Checked;
                        break;
                    }
                }
            }
        }
        #endregion
    }
}