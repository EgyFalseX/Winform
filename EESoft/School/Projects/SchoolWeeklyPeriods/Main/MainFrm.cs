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

namespace SchoolWeeklyPeriods
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
        public void LoadCD_Asasetime()
        {
            foreach (DockPanel pnl in dockManagerMain.Panels)
                pnl.Enabled = false;

            repositoryItemLookUpEditasase_code.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT asase_code, asase_year, SPOS,
            (Select SCHOOL From TBLSCHOOL Where SPOS = CD_Asasetime.SPOS) AS SCHOOL, school_allcode FROM CD_Asasetime ORDER BY asase_code DESC");
            DataTable dt = (DataTable)repositoryItemLookUpEditasase_code.DataSource;
            if (dt.Rows.Count == 0)
            {
                CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CD_Asasetime) { Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CD_Asasetime.png"], 32, false) };
                FrmCode.ExitAfterSave = true;
                FrmCode.ShowDialog();
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
            LoadCD_Asasetime();

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
            AboutBoxFrm FrmAboutBox = new AboutBoxFrm() { Icon = FXFW.SqlDB.MakeIcon(SchoolWeeklyPeriods.Properties.Resources.About, 32, false) };
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
            rpt.CreateDataSource("DataSourceSchoolWeeklyPeriods", true, true, "Data Sources", constringpro, FXFW.Settings.CredentialRetrievalValues.Store, false, constring.UserID, constring.Password);
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
            rpt.CreateReport("GroupDS", "DataSourceSchoolWeeklyPeriods", FXFW.SqlDB.ReportPath, 10080, reports);
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
        private void navBarItemTimeCD_Asasetime_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CD_Asasetime) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CD_Asasetime.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemTimeCDAlhasas_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDAlhasas) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CDAlhasas.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemTimeCDAlsofof_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDAlsofof) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CDAlsofof.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemTimeCDEFasl_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDEFasl) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CDEFasl.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemTimeCDDayname_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDDayname) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CDDayname.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemTimeCD_HesaTime_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CD_HesaTime) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CD_HesaTime.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemTimeCDSubjectWekly_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDSubjectWekly) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CDSubjectWekly.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemTimeCDPlace_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDPlace) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CDPlace.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemTimeCD_EmpState_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CD_EmpState) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CD_EmpState.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemTimeCD_JobDescription_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CD_JobDescription) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CD_JobDescription.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemTimeCD_EmpJob_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CD_EmpJob) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CD_EmpJob.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemTimeCD_Department_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CD_Department) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CD_Department.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemTimeCD_Subject_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CD_Subject) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CD_Subject.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemTimeCD_QualifiedPlace_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CD_QualifiedPlace) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CD_QualifiedPlace.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemTimeCDQualification_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDQualification) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CDQualification.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemTimeCD_Specialization_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CD_Specialization) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CD_Specialization.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemTimeCD_MaritalStatus_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CD_MaritalStatus) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CD_MaritalStatus.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemTimeCD_AgazaType_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CD_AgazaType) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CD_AgazaType.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemTimeTBL_Priority_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.TBL_Priority) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["TBL_Priority.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemTimeTBLNesab_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            TBLNesabFrm FrmTBLNesab = new TBLNesabFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["TBLNesab.png"], 32, false) };
            FrmTBLNesab.Show();
        }
        private void navBarItemTimeTBLTeacherNoDays_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            TBLTeacherNoDaysFrm FrmTBLTeacherNoDays = new TBLTeacherNoDaysFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["TBLTeacherNoDays.png"], 32, false) };
            FrmTBLTeacherNoDays.Show();
        }
        private void navBarItemTimeTBLTeachersPlan_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            TBLTeachersPlanFrm FrmTBLTeachersPlan = new TBLTeachersPlanFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["TBLTeachersPlan.png"], 32, false) };
            FrmTBLTeachersPlan.Show();
        }
        private void navBarItemTimeTBLTimeTable_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            TBLTimeTableFrm FrmTBLTimeTable = new TBLTimeTableFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["TBLTimeTable.png"], 32, false) };
            FrmTBLTimeTable.Show();
        }
        private void navBarItemTimeTBL_Emp_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            TBL_EmpFrm FrmTBL_Emp = new TBL_EmpFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["TBL_Emp.png"], 32, false) };
            FrmTBL_Emp.Show();
        }
        private void navBarItemTimeEMP_agazat_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            EMP_agazatFrm DATA = new EMP_agazatFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["EMP_gzaat.png"], 32, false) };
            DATA.Show();
        }

        private void navBarItemTimeQryWeekTeacherTable_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            QryWeekTeacherTableFrm FrmQryWeekTeacherTable = new QryWeekTeacherTableFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["TBLNesab.png"], 32, false) };
            FrmQryWeekTeacherTable.Show();
        }
        private void navBarItemTimeQryWeekFaslTable_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            QryWeekFaslTableFrm FrmQryWeekFaslTable = new QryWeekFaslTableFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["QryWeekFaslTable.png"], 32, false) };
            FrmQryWeekFaslTable.Show();
        }
        private void navBarItemTimeTBLAhteaty_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            TBLAhteatyFrm FrmTBLAhteaty = new TBLAhteatyFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["TBLAhteaty.png"], 32, false) };
            FrmTBLAhteaty.Show();
        }
        private void navBarItemTimeQryTblAhteaty_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            QryTblAhteatyFrm FrmQryTblAhteaty = new QryTblAhteatyFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["TBLAhteaty.png"], 32, false) };
            FrmQryTblAhteaty.Show();
        }
        
        #endregion

    }
}