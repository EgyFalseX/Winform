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
using DevExpress.XtraEditors.Controls;

namespace Employee
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
        private void LoadAsase()
        {
            foreach (DockPanel pnl in dockManagerMain.Panels)
                pnl.Enabled = false;

            repositoryItemLookUpEditasase_code.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT asase_code, asase_year, SPOS,
            (Select SCHOOL From TBLSCHOOL Where SPOS = CD_AsaseEmp.SPOS) AS SCHOOL, school_allcode FROM CD_AsaseEmp ORDER BY asase_code DESC");
            DataTable dt = (DataTable)repositoryItemLookUpEditasase_code.DataSource;
            if (dt.Rows.Count == 0)
            {
                CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CD_AsaseEmp) { Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CD_AsaseEmp.png"], 32, false) };
                FrmCode.ShowDialog();
                Application.Restart();
            }
            else
            {
                barEditItemasase_code.EditValue = dt.Rows[0]["asase_code"];
                ButtonPredefines btn = new ButtonPredefines();
                btn = ButtonPredefines.OK;
                repositoryItemLookUpEditasase_code_ButtonClick(repositoryItemLookUpEditasase_code, new ButtonPressedEventArgs(new EditorButton(btn)));
            }

            DataTable SalaryTbl = SQLProvider.SelectCD_AsaseSalary();
            repositoryItemLookUpEditAsaseSalary.DataSource = SalaryTbl;
            if (SalaryTbl.Rows.Count != 0)
                barEditItemAsaseSalary.EditValue = SalaryTbl.Rows[0]["AsaseSalaryId"];
            ButtonPredefines btnSalary = new ButtonPredefines();
            btnSalary = ButtonPredefines.OK;
            repositoryItemLookUpEditAsaseSalary_ButtonClick(repositoryItemLookUpEditAsaseSalary, new ButtonPressedEventArgs(new EditorButton(btnSalary)));
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
            LoadAsase();

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
            AboutBoxFrm FrmAboutBox = new AboutBoxFrm() { Icon = FXFW.SqlDB.MakeIcon(Employee.Properties.Resources.About, 32, false) };
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
            rpt.CreateDataSource("DataSourceEmployee", true, true, "Data Sources", constringpro, FXFW.Settings.CredentialRetrievalValues.Store, false, constring.UserID, constring.Password);
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
            rpt.CreateReport("GroupDS", "DataSourceEmployee", FXFW.SqlDB.ReportPath, 10080, reports);
            FXFW.SqlDB.DeploySSRSReports(rpt);

            FXFW.SqlDB.ChangePublicSSRSAuthType();
            
        }
        private void repositoryItemLookUpEditasase_code_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Kind)
            {
                case ButtonPredefines.OK:
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
                        Program.ShowMsg("تم اختيار العام", false, this);
                        //Program.Logger.LogThis("تم اختيار العام الدراسي", Text, FXFW.Logger.OpType.success, null, null, this);
                    }
                    //e.Button.Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Delete;
                    break;
                case ButtonPredefines.Delete:
                    foreach (DockPanel pnl in dockManagerMain.Panels)
                        pnl.Enabled = false;
                    barEditItemasase_code.EditValue = null;
                    FXFW.SqlDB.asase_code = string.Empty;
                    //e.Button.Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.OK;
                    Program.ShowMsg("تم اختيار العام", false, this);
                    //Program.Logger.LogThis("تم اختيار العام الدراسي", Text, FXFW.Logger.OpType.success, null, null, this);
                    break;
                default:
                    break;
            }
        }
        private void repositoryItemLookUpEditAsaseSalary_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            switch (e.Button.Kind)
            {
                case ButtonPredefines.OK:
                    if (barEditItemAsaseSalary.EditValue != null)
                    {
                        SQLProvider.AsaseSalaryId = barEditItemAsaseSalary.EditValue;
                        Program.ShowMsg("تم اختيار السنه الماليه", false, this);
                    }
                    else
                        Program.ShowMsg("لم يتم اختيار السنه الماليه", true, this);
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
        private void navBarItemCD_AsaseEmp_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CD_AsaseEmp) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CD_AsaseEmp.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemCD_EmpState_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CD_EmpState) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CD_EmpState.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemCD_JobDescription_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CD_JobDescription) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CD_JobDescription.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemCD_EmpJob_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CD_EmpJob) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CD_EmpJob.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemCD_Department_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CD_Department) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CD_Department.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemCD_Subject_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CD_Subject) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CD_Subject.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemCD_QualifiedPlace_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CD_QualifiedPlace) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CD_QualifiedPlace.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemCDQualification_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDQualification) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CDQualification.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemCD_Specialization_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CD_Specialization) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CD_Specialization.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemCD_MaritalStatus_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CD_MaritalStatus) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CD_MaritalStatus.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemCD_Courses_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CD_Courses) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CD_Courses.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemCDPlaceTraining_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDPlaceTraining) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CDPlaceTraining.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemCD_AgazaType_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CD_AgazaType) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CD_AgazaType.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemCDTakdeer_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDTakdeer) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CDTakdeer.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemCD_EznType_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CD_EznType) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CD_EznType.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemCD_GzaaType_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CD_GzaaType) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CD_GzaaType.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemCD_GehaGazaa_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CD_GehaGazaa) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CD_GehaGazaa.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemCD_EmpTIME_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CD_EmpTIME) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CD_EmpTIME.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemEmpCDGov_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDGov) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CDGov.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemEmpCD_AsaseSalary_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CD_AsaseSalary) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CD_AsaseSalary.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemTBL_Emp_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            TBL_EmpFrm FrmData = new TBL_EmpFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["TBL_Emp.png"], 32, false) };
            FrmData.Show();
        }
        private void navBarItemEmp_Moaahel_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            Emp_MoaahelFrm FrmData = new Emp_MoaahelFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["Emp_Moaahel.png"], 32, false) };
            FrmData.Show();
        }
        private void navBarItemEMP_agazat_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            EMP_agazatFrm FrmData = new EMP_agazatFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["EMP_agazat.png"], 32, false) };
            FrmData.Show();
        }
        private void navBarItemEMP_Later_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            EMP_LaterFrm FrmData = new EMP_LaterFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["EMP_Later.png"], 32, false) };
            FrmData.Show();
        }
        private void navBarItemEMP_ezn_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            EMP_eznFrm FrmData = new EMP_eznFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["EMP_ezn.png"], 32, false) };
            FrmData.Show();
        }
        private void navBarItemEMP_gzaat_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            EMP_gzaatFrm FrmData = new EMP_gzaatFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["EMP_gzaat.png"], 32, false) };
            FrmData.Show();
        }
        private void navBarItemEMP_training_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            EMP_trainingFrm FrmData = new EMP_trainingFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["EMP_training.png"], 32, false) };
            FrmData.Show();
        }
        private void navBarItemEMP_TAMEEN_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            EMP_TAMEENFrm FrmData = new EMP_TAMEENFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["EMP_TAMEEN.png"], 32, false) };
            FrmData.Show();
        }
        private void navBarItemEMP_report_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            EMP_reportFrm FrmData = new EMP_reportFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["EMP_report.png"], 32, false) };
            FrmData.Show();
        }
        private void navBarItemEmpTBLEmpKashf_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            TBLEmpKashfFrm FrmData = new TBLEmpKashfFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["TBLEmpKashf.png"], 32, false) };
            FrmData.Show();
        }
        private void navBarItemEmpTBLSalary_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            TBLSalaryFrm FrmData = new TBLSalaryFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["TBLSalary.png"], 32, false) };
            FrmData.Show();
        }

        #endregion

        

    }

}
