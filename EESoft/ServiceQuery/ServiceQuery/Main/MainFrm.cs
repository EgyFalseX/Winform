using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Runtime.Serialization.Formatters.Binary;
using DevExpress.LookAndFeel;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraNavBar;

namespace ServiceQuery
{
    public partial class MainFrm : DevExpress.XtraEditors.XtraForm
    {

        #region -   Variables   -
        DataTable RoleDetialsTbl = new DataTable("FalseX2012");
        #endregion
        #region -   Functions   -
        public MainFrm()
        {
            InitializeComponent();
        }
        private static FXFW.UserSkinSettings LoadSettings(string fileName)
        {
            FXFW.UserSkinSettings us = null;
            BinaryFormatter binFormat = new BinaryFormatter();
            System.IO.Stream fStream = new System.IO.FileStream(fileName, System.IO.FileMode.Open);
            try { us = binFormat.Deserialize(fStream) as FXFW.UserSkinSettings; }
            finally { fStream.Close(); }
            return us;
        }
        private static void SaveSettings(FXFW.UserSkinSettings us)
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            using (System.IO.Stream fStream = new System.IO.FileStream(FXFW.SqlDB.StyleSettingsPath, System.IO.FileMode.Create, System.IO.FileAccess.Write, System.IO.FileShare.None))
            {
                binFormat.Serialize(fStream, us);
                fStream.Close();
            }
        }

        private void LoadSQLReports() 
        {
            if (FXFW.SqlDB.SQLRep == null)
                return;
            for (int i = 0; i < FXFW.SqlDB.SQLRep.Length; i++)
            {
                DevExpress.XtraNavBar.NavBarItem navBarItemRPT = new DevExpress.XtraNavBar.NavBarItem() {
                    Caption = FXFW.SqlDB.SQLRep[i].RepCaption, 
                    LargeImageIndex = 44, SmallImageIndex = 4, 
                    Name = FXFW.SqlDB.SQLRep[i].RepFileName.Replace(".rdl", ""), Tag = i };
                navBarControlReport.Items.Add(navBarItemRPT);
                navBarControlReport.Groups[(int)FXFW.SqlDB.ConvertStringToInt(FXFW.SqlDB.SQLRep[i].RepPosition)].ItemLinks.Add(navBarItemRPT);
                //navBarGroup4.ItemLinks.Add(navBarItemRPT);
                navBarItemRPT.LinkClicked += navBarItemRPT_LinkClicked;
                
            }
        }
        private void LoadUserPriv(string RoleID)
        {
            //Hide All Tools
            foreach (DevExpress.XtraNavBar.NavBarItem item in navBarControlCode.Items)
                item.Visible = false;
            foreach (DevExpress.XtraNavBar.NavBarItem item in navBarControlData.Items)
                item.Visible = false;
            foreach (DevExpress.XtraNavBar.NavBarItem item in navBarControlPriv.Items)
                item.Visible = false;
            foreach (DevExpress.XtraNavBar.NavBarItem item in navBarControlQry.Items)
                item.Visible = false;
            foreach (DevExpress.XtraNavBar.NavBarItem item in navBarControlReport.Items)
                item.Visible = false;

            RoleDetialsTbl = FXFW.SqlDB.LoadDataTable("SELECT RoleDetial.MenuItemName FROM UserRoles INNER JOIN RoleDetial ON UserRoles.RoleId = RoleDetial.RoleID WHERE UserRoles.UserId = " + FXFW.SqlDB.UserInfo.UserID);

            foreach (DataRow row in RoleDetialsTbl.Rows)
            {
                foreach (NavBarItem item in navBarControlCode.Items)//code
                {
                    if (item.Name.Replace("navBarItem", "") == row["MenuItemName"].ToString())
                    {
                        item.Visible = true;
                        goto nextOne;
                    }
                }
                foreach (NavBarItem item in navBarControlData.Items)//data
                {
                    if (item.Name.Replace("navBarItem", "") == row["MenuItemName"].ToString())
                    {
                        item.Visible = true;
                        goto nextOne;
                    }
                }
                foreach (NavBarItem item in navBarControlPriv.Items)//priv
                {
                    if (item.Name.Replace("navBarItem", "") == row["MenuItemName"].ToString())
                    {
                        item.Visible = true;
                        goto nextOne;
                    }
                }
                foreach (NavBarItem item in navBarControlQry.Items)//qry
                {
                    if (item.Name.Replace("navBarItem", "") == row["MenuItemName"].ToString())
                    {
                        item.Visible = true;
                        goto nextOne;
                    }
                }
                foreach (NavBarItem item in navBarControlReport.Items)//report
                {
                    if (item.Name.Replace("navBarItem", "") == row["MenuItemName"].ToString())
                    {
                        item.Visible = true;
                        goto nextOne;
                    }
                }
            nextOne:
                ;
                //continue;
            }
        }
#endregion
        #region - Event Handlers -
        private void MainFrm_Load(object sender, EventArgs e)
        {
            //FXFW.SqlDB.UserInfo = new FXFW.SqlDB.UserInfoStruct() { UserID = "1", UserName = "admin"};

            //Load Reports from file and create its item in the interface
            //////LoadSQLReports();
            //Load Skins and layout
            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(galleryControlSkins, true);
            UserLookAndFeel.Default.StyleChanged += Default_StyleChanged;
            if (System.IO.File.Exists(FXFW.SqlDB.StyleSettingsPath))
                UserLookAndFeel.Default.SetSkinStyle(LoadSettings(FXFW.SqlDB.StyleSettingsPath).SkinName);
            if (System.IO.File.Exists(FXFW.SqlDB.duckSettingsPath))
                dockManagerMain.RestoreLayoutFromXml(FXFW.SqlDB.duckSettingsPath);
            // Show Splash Screen..
            //////using (SplashFrm SC = new SplashFrm())
            //////    SC.ShowDialog();
            // Show Login Screen..
            //////using (LoginFrm FrmLogin = new LoginFrm())
            //////{
            //////    // Create Administrator user if not exists b4 show login form
            //////    RoleDetialFrm role = new RoleDetialFrm();
            //////    role.PrepareAdminRole();
            //////    role.Dispose();

            //////    FrmLogin.ShowDialog();
            //////}
            ////////must choose asase_code to enable the application //Load CD_Asase

            //////LoadUserPriv(FXFW.SqlDB.UserInfo.UserID);
            FXFW.SqlDB.UserInfo.UserID = "1";
        }
        private void Logging_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Program.Logger.ShowHideLogWindow = true;
        }
        private void mbConnection_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزيـــــر", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            if (System.IO.File.Exists(FXFW.SqlDB.DBPath))
            {
                System.IO.File.Delete(FXFW.SqlDB.DBPath);
                Application.Restart();
            }
        }
        private void mbExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }
        private void MainFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            dockManagerMain.SaveLayoutToXml(FXFW.SqlDB.duckSettingsPath);
        }
        private void Default_StyleChanged(object sender, EventArgs e)
        {
            FXFW.UserSkinSettings us = new FXFW.UserSkinSettings { SkinName = UserLookAndFeel.Default.ActiveSkinName };
            SaveSettings(us);
        }
        private void mbAboutUs_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AboutBoxFrm FrmAboutBox = new AboutBoxFrm() { Icon = FXFW.SqlDB.MakeIcon(ServiceQuery.Properties.Resources.About, 32, false) };
            FrmAboutBox.ShowDialog();
        }
        private void mbCode_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DPCode.Visibility = DockVisibility.Visible;
        }
        private void mbData_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DPData.Visibility = DockVisibility.Visible;
        }
        private void mbQuery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DPQuery.Visibility = DockVisibility.Visible;
        }
        private void mbReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DPReport.Visibility = DockVisibility.Visible;
        }
        private void mbPriv_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DPPriv.Visibility = DockVisibility.Visible;
        }
        private void mbResult_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DPResult.Visibility = DockVisibility.Visible;
        }
        private void mbSkins_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DPSkins.Visibility = DockVisibility.Visible;
        }
        private void mbcascade_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }
        private void mbtileVertical_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
        private void mbtileHorizontal_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }
        private void mbcloseAll_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        private void navBarItemDeployRpt_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                if (!FXFW.SqlDB.ChangeBasicSSRSAuthType())
                    MessageBox.Show("لم يتم تعديل صلاحيات خادم التقارير ", "خطـــــــــــاء", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطـــــــــــاء", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            FXFW.Settings rpt = new FXFW.Settings();
            string reportserver = FXFW.SqlDB.ReportURL.Replace("http://", "");
            reportserver = reportserver.Substring(0, reportserver.IndexOf("/"));
            string[] arr = FXFW.SqlDB.ReportURL.Split(Convert.ToChar("/"));
            rpt.GlobalSettings(reportserver, arr[arr.Length - 1]);
            System.Data.SqlClient.SqlConnectionStringBuilder constring = new System.Data.SqlClient.SqlConnectionStringBuilder(FXFW.SqlDB.SqlConStr);
            string constringpro = string.Format(@"data source={0};initial catalog={1}", constring.DataSource, constring.InitialCatalog);
            rpt.CreateDataSource("DataSourceServiceQuery", true, true, "Data Sources", constringpro, FXFW.Settings.CredentialRetrievalValues.Store, false, constring.UserID, constring.Password);
            FXFW.Settings.Report[] reports = null;
            foreach (FXFW.SqlDB.SQLReportsStr item in FXFW.SqlDB.SQLRep)
            {
                if (reports == null)
                    Array.Resize<FXFW.Settings.Report>(ref reports, 1);
                else
                    Array.Resize<FXFW.Settings.Report>(ref reports, reports.Length + 1);
                
                reports[reports.Length - 1].Name = item.RepFileName.Replace(".rdl", "");
                reports[reports.Length - 1].FilePathValue = @"\rdl\" + item.RepFileName;
            }
            rpt.CreateReport("GroupDS", "DataSourceServiceQuery", FXFW.SqlDB.ReportPath, 10080, reports);
            FXFW.SqlDB.DeploySSRSReports(rpt);

            FXFW.SqlDB.ChangePublicSSRSAuthType();
            
        }
        private void navBarItemEditorRoleFrm_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            RolesFrm FrmRoles = new RolesFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["Roles.png"], 32, false) };
            FrmRoles.Show();
        }
        private void navBarItemRoleDetial_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            RoleDetialFrm FrmRoleDetial = new RoleDetialFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["RoleDetial.png"], 32, false) };
            FrmRoleDetial.Show();
        }
        private void navBarItemUsers_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            UsersFrm FrmUsers = new UsersFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["Users.png"], 32, false) };
            FrmUsers.Show();
        }
        private void navBarItemUserRoles_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            UserRolesFrm FrmUserRoles = new UserRolesFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["RoleDetial.png"], 32, false) };
            FrmUserRoles.Show();
        }
        private void navBarItemAppOptions_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            AppOptionsFrm FrmAppOptions = new AppOptionsFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["AppOptions.png"], 32, false) };
            FrmAppOptions.Show();
        }
        private void navBarItemRPT_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            DevExpress.XtraNavBar.NavBarItem NBI = (DevExpress.XtraNavBar.NavBarItem)sender;
            RepGeneralFrm FrmRepGeneral = new RepGeneralFrm() { MdiParent = this, rptSelectedIndex = (int)NBI.Tag };
            FrmRepGeneral.Show();
        }
        
        private void navBarItemServiceQueryCDEdara_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDEdara) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["Roles.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemServiceQueryCDserviceType_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDserviceType) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["Roles.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemServiceQueryCDReply_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDReply) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["Roles.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemServiceQueryCDSyndicate_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDSyndicate) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["Roles.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemServiceQueryCDSubCommitte_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDSubCommitte) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["Roles.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemServiceQueryCDAttatech_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDAttatech) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["Roles.png"], 32, false) };
            FrmCode.Show();
        }

        private void navBarItemServiceQueryTBLWared_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            
            TBLWaredFrm FrmTBLWared = new TBLWaredFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["Roles.png"], 32, false) };
            FrmTBLWared.Show();
        }
        
        #endregion

    }
}