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

namespace StAccount
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
        public void LoadCD_AsaseACC()
        {
            foreach (DockPanel pnl in dockManagerMain.Panels)
                pnl.Enabled = false;

            repositoryItemLookUpEditasase_code.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT asase_code, asase_year, SPOS,
            (Select SCHOOL From TBLSCHOOL Where SPOS = CD_AsaseACC.SPOS) AS SCHOOL, school_allcode FROM CD_AsaseACC ORDER BY asase_code DESC");
            DataTable dt = (DataTable)repositoryItemLookUpEditasase_code.DataSource;
            if (dt.Rows.Count == 0)
            {
                CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CD_AsaseACC) { Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CD_AsaseACC.png"], 32, false) };
                FrmCode.ShowDialog();
                Application.Exit();
            }
            else
            {
                barEditItemasase_code.EditValue = dt.Rows[0]["asase_code"];
                DevExpress.XtraEditors.Controls.ButtonPredefines btn = new DevExpress.XtraEditors.Controls.ButtonPredefines();
                btn = DevExpress.XtraEditors.Controls.ButtonPredefines.OK;
                repositoryItemLookUpEditasase_code_ButtonClick(repositoryItemLookUpEditasase_code, new DevExpress.XtraEditors.Controls.ButtonPressedEventArgs(new DevExpress.XtraEditors.Controls.EditorButton(btn)));
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
            LoadSQLReports();
            //Load Skins and layout
            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(galleryControlSkins, true);
            UserLookAndFeel.Default.StyleChanged += Default_StyleChanged;
            if (System.IO.File.Exists(FXFW.SqlDB.StyleSettingsPath))
                UserLookAndFeel.Default.SetSkinStyle(LoadSettings(FXFW.SqlDB.StyleSettingsPath).SkinName);
            if (System.IO.File.Exists(FXFW.SqlDB.duckSettingsPath))
                dockManagerMain.RestoreLayoutFromXml(FXFW.SqlDB.duckSettingsPath);
            // Show Splash Screen..
            using (SplashFrm SC = new SplashFrm())
                SC.ShowDialog();
            // Show Login Screen..
            using (LoginFrm FrmLogin = new LoginFrm())
            {
                // Create Administrator user if not exists b4 show login form
                RoleDetialFrm role = new RoleDetialFrm();
                role.PrepareAdminRole();
                role.Dispose();

                FrmLogin.ShowDialog();
            }
            //must choose asase_code to enable the application //Load CD_Asase
            LoadCD_AsaseACC();

            LoadUserPriv(FXFW.SqlDB.UserInfo.UserID);
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
            AboutBoxFrm FrmAboutBox = new AboutBoxFrm() { Icon = FXFW.SqlDB.MakeIcon(StAccount.Properties.Resources.About, 32, false) };
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
            rpt.CreateDataSource("DataSourceStAccount", true, true, "Data Sources", constringpro, FXFW.Settings.CredentialRetrievalValues.Store, false, constring.UserID, constring.Password);
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
            rpt.CreateReport("GroupDS", "DataSourceStAccount", FXFW.SqlDB.ReportPath, 10080, reports);
            FXFW.SqlDB.DeploySSRSReports(rpt);

            FXFW.SqlDB.ChangePublicSSRSAuthType();
            
        }
        private void repositoryItemLookUpEditasase_code_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Kind)
            {
                case DevExpress.XtraEditors.Controls.ButtonPredefines.OK:
                    if (barEditItemasase_code.EditValue == null)
                    {
                        foreach (DockPanel pnl in dockManagerMain.Panels)
                            pnl.Enabled = false;
                    }
                    else
                    {
                        //barEditItemasase_code.Enabled = false;
                        foreach (DockPanel pnl in dockManagerMain.Panels)
                            pnl.Enabled = true;
                        FXFW.SqlDB.asase_code = barEditItemasase_code.EditValue.ToString();
                        Program.ShowMsg("تم اختيار العام الدراسي", false, this);
                        //Program.Logger.LogThis("تم اختيار العام الدراسي", Text, FXFW.Logger.OpType.success, null, null, this);
                    }
                    //e.Button.Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Delete;
                    break;
                case DevExpress.XtraEditors.Controls.ButtonPredefines.Delete:
                    foreach (DockPanel pnl in dockManagerMain.Panels)
                        pnl.Enabled = false;
                    barEditItemasase_code.EditValue = null;
                    FXFW.SqlDB.asase_code = string.Empty;
                    //e.Button.Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.OK;
                    Program.ShowMsg("تم اختيار العام الدراسي", false, this);
                    //Program.Logger.LogThis("تم اختيار العام الدراسي", Text, FXFW.Logger.OpType.success, null, null, this);
                    break;
                default:
                    break;
            }
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
        private void navBarItemAccCD_AsaseACC_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CD_AsaseACC) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CD_AsaseACC.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemAccCD_PayType_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CD_PayType) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CD_PayType.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemCD_PayTypeDetiel_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CD_PayTypeDetiel) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CD_PayTypeDetiel.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemCD_PayMony_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CD_PayMony) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CD_PayMony.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemCD_Discounts_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CD_Discounts) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CD_Discounts.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemAccCD_Acounts_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            AccTypesFrm FrmAccTypes = new AccTypesFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CD_Acounts.png"], 32, false) };
            FrmAccTypes.Show();
        }
        private void navBarItemAccCD_KastNo_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CD_KastNo) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CD_KastNo.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemAccCD_KastSaf_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CD_KastSaf) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CD_KastSaf.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemAccCD_KastBnood_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CD_KastBnood) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CD_KastBnood.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemAccTBL_DiscountSt_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            TBL_DiscountStFrm FrmTBL_DiscountSt = new TBL_DiscountStFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["TBL_DiscountSt.png"], 32, false) };
            FrmTBL_DiscountSt.Show();
        }
        private void navBarItemAccTBL_OutSchool_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            TBL_OutSchoolFrm FrmTBL_OutSchool = new TBL_OutSchoolFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["TBL_OutSchool.png"], 32, false) };
            FrmTBL_OutSchool.Show();
        }
        private void navBarItemAccTBLSelectSTEdafy_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            TBLSelectSTEdafyFrm FrmTBLSelectSTEdafy = new TBLSelectSTEdafyFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["TBLSelectSTEdafy.png"], 32, false) };
            FrmTBLSelectSTEdafy.Show();
        }
        private void navBarItemAccTBLMothsleat_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            TBLMothsleatFrm FrmTBLMothsleat = new TBLMothsleatFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["TBLMothsleat.png"], 32, false) };
            FrmTBLMothsleat.Show();
        }
        private void navBarItemAccTBLEstrdad_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            TBLEstrdadFrm FrmTBLEstrdad = new TBLEstrdadFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["TBLEstrdad.png"], 32, false) };
            FrmTBLEstrdad.Show();
        }
        private void navBarItemAccTBLKazna_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            TBLKaznaFrm FrmTBLKazna = new TBLKaznaFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["TBLKazna.png"], 32, false) };
            FrmTBLKazna.Show();
        }
        #endregion
        
    }
}