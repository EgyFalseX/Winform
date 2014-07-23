using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using DevExpress.XtraNavBar;

namespace Employee
{
    public partial class RoleDetialFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        DataTable RolesTbl = new DataTable("Roles");
        DataTable RoleDetialsTbl = new DataTable("Detials");
        #endregion
        #region -   Functions   -
        public RoleDetialFrm()
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
        private void ClearMenuCheck()
        {
            foreach (NavBarItem item in navBarControlCode.Items)
                item.SmallImageIndex = -1;
            foreach (NavBarItem item in navBarControlData.Items)
                item.SmallImageIndex = -1;
            foreach (NavBarItem item in navBarControlPriv.Items)
                item.SmallImageIndex = -1;
            foreach (NavBarItem item in navBarControlQry.Items)
                item.SmallImageIndex = -1;
            foreach (NavBarItem item in navBarControlReport.Items)
                item.SmallImageIndex = -1;
        }
        private void AddRemoveMenuItem(string RoleID, string MenuName, string Selecting, string Inserting, string Updateing, string Deleting)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                cmd.CommandText = string.Format(@"IF EXISTS (SELECT * FROM RoleDetial WHERE RoleID = {0} AND MenuItemName = N'{1}')
                Delete From RoleDetial WHERE (RoleID = {2} AND MenuItemName = N'{3}')
                Else
                INSERT INTO RoleDetial(RoleID, MenuItemName, Selecting, Inserting, Updateing, Deleting) VALUES ({4}, N'{5}', '{6}', '{7}', '{8}', '{9}')", 
                RoleID, MenuName, RoleID, MenuName, RoleID, MenuName, Selecting, Inserting, Updateing, Deleting);
               
                con.Open();
                cmd.ExecuteNonQuery();
                Program.ShowMsg("تم تعديل عنصر السماحيه", false, this);
                Program.Logger.LogThis("تم تعديل عنصر السماحيه", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
            con.Close();
        }
        private void AddRemoveMenuItem(string MenuName)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                con.Open();
                cmd.CommandText = string.Format(@"IF NOT EXISTS(Select * From Users Where UserID = 1) 
                Insert Into Users (UserID, UserName, UserPass, IsActive, LastActivityDate) VALUES (1, 'admin', 'admin', 'true', GETDATE())
                
                IF NOT EXISTS(Select * From Roles Where RoleID = 1) 
                Insert Into Roles (RoleID, RoleName, RoleDesc) VALUES (1, N'Administrator', N'This is the Administrators Role')

                IF NOT EXISTS(Select * From UserRoles Where RoleID = 1 And UserId = 1) 
                Insert Into UserRoles (UserId, RoleID) VALUES (1, 1)

                IF NOT EXISTS (SELECT * FROM RoleDetial WHERE RoleID = 1 AND MenuItemName = N'{0}')
                INSERT INTO RoleDetial(RoleID, MenuItemName, Selecting, Inserting, Updateing, Deleting) VALUES (1, N'{0}', 'true', 'true', 'true', 'true')",
                MenuName);
                
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
            con.Close();
        }
        private void LoadRoleDetial(string RoleID)
        {
            RoleDetialsTbl = new DataTable("Detials");
            RoleDetialsTbl = FXFW.SqlDB.LoadDataTable(@"SELECT RoleID, MenuItemName FROM RoleDetial WHERE RoleID = " + RoleID);
            foreach (DataRow row in RoleDetialsTbl.Rows)
            {
                foreach (NavBarItem item in navBarControlCode.Items)//code
                {
                    if (item.Name.Replace("navBarItem", "") == row["MenuItemName"].ToString())
                    {
                        item.SmallImageIndex = item.LargeImageIndex;
                        goto nextOne;
                    }
                }
                foreach (NavBarItem item in navBarControlData.Items)//data
                {
                    if (item.Name.Replace("navBarItem", "") == row["MenuItemName"].ToString())
                    {
                        item.SmallImageIndex = item.LargeImageIndex;
                        goto nextOne;
                    }
                }
                foreach (NavBarItem item in navBarControlPriv.Items)//priv
                {
                    if (item.Name.Replace("navBarItem", "") == row["MenuItemName"].ToString())
                    {
                        item.SmallImageIndex = item.LargeImageIndex;
                        goto nextOne;
                    }
                }
                foreach (NavBarItem item in navBarControlQry.Items)//qry
                {
                    if (item.Name.Replace("navBarItem", "") == row["MenuItemName"].ToString())
                    {
                        item.SmallImageIndex = item.LargeImageIndex;
                        goto nextOne;
                    }
                }
                foreach (NavBarItem item in navBarControlReport.Items)//report
                {
                    if (item.Name.Replace("navBarItem", "") == row["MenuItemName"].ToString())
                    {
                        item.SmallImageIndex = item.LargeImageIndex;
                        goto nextOne;
                    }
                }
            nextOne:
                ;
                //continue;
            }
        }
        private void ActivePriv()
        {
            bool Selecting = false, Inserting = false, Updateing = false, Deleting = false;
            FXFW.SqlDB.GetFormPriv("Emp" + Name.Replace("Frm", ""), ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
            groupControlSelect.Visible = Selecting;
            if (Inserting || Updateing || Deleting)
                pnlContainerMain.Enabled = true;
            else
                pnlContainerMain.Enabled = false;
        }
        private void LoadSQLReports()
        {
            if (FXFW.SqlDB.SQLRep == null)
                return;
            for (int i = 0; i < FXFW.SqlDB.SQLRep.Length; i++)
            {
                DevExpress.XtraNavBar.NavBarItem navBarItemRPT = new DevExpress.XtraNavBar.NavBarItem()
                {
                    Caption = FXFW.SqlDB.SQLRep[i].RepCaption,
                    LargeImageIndex = 4,
                    SmallImageIndex = 4,
                    Name = FXFW.SqlDB.SQLRep[i].RepFileName.Replace(".rdl", ""),
                    Tag = i
                };
                navBarControlReport.Items.Add(navBarItemRPT);
                navBarControlReport.Groups[(int)FXFW.SqlDB.ConvertStringToInt(FXFW.SqlDB.SQLRep[i].RepPosition)].ItemLinks.Add(navBarItemRPT);
                //navBarGroup4.ItemLinks.Add(navBarItemRPT);
                navBarItemRPT.LinkClicked += navBarItem_LinkClicked;

            }
        }
        public void PrepareAdminRole()
        {
            LoadSQLReports();
            foreach (NavBarItem item in navBarControlCode.Items)
                AddRemoveMenuItem(item.Name.Replace("navBarItem", ""));
            foreach (NavBarItem item in navBarControlData.Items)
                AddRemoveMenuItem(item.Name.Replace("navBarItem", ""));
            foreach (NavBarItem item in navBarControlPriv.Items)
                AddRemoveMenuItem(item.Name.Replace("navBarItem", ""));
            foreach (NavBarItem item in navBarControlQry.Items)
                AddRemoveMenuItem(item.Name.Replace("navBarItem", ""));
            foreach (NavBarItem item in navBarControlReport.Items)
                AddRemoveMenuItem(item.Name.Replace("navBarItem", ""));
        }
        #endregion
        #region - Event Handlers -
        private void EditorRoleMenuFrm_Load(object sender, EventArgs e)
        {
            LoadSQLReports();
            ActivePriv();
            ClearMenuCheck();
            LoadData();
        }
        private void LUEItems_EditValueChanged(object sender, EventArgs e)
        {
            ClearMenuCheck();
            if (LUEItems.EditValue == null)
                pnlContainerMain.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            else
            {
                LoadRoleDetial(LUEItems.EditValue.ToString());
                pnlContainerMain.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
            }
        }
        private void navBarItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            NavBarItem NBI = (NavBarItem)sender;
            AddRemoveMenuItem(LUEItems.EditValue.ToString(), NBI.Name.Replace("navBarItem", ""), CESelect.Checked.ToString(), CEInsert.Checked.ToString(), CEUpdate.Checked.ToString(), CEDelete.Checked.ToString());
            if (NBI.SmallImageIndex == -1)
                NBI.SmallImageIndex = NBI.LargeImageIndex;
            else
                NBI.SmallImageIndex = -1;
        }
        
        #endregion
    }
}