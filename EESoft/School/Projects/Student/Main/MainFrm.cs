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

namespace Student
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
        public static void RebuildForms()
        {
            //Code

        }
        private void LoadCD_Asase()
        {
            foreach (DockPanel pnl in dockManagerMain.Panels)
                pnl.Enabled = false;

            repositoryItemLookUpEditasase_code.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT asase_code, asase_year, SPOS FROM CD_Asase ORDER BY asase_code DESC");
            DataTable dt = (DataTable)repositoryItemLookUpEditasase_code.DataSource;
            if (dt.Rows.Count == 0)
            {
                CD_AsaseFrm FrmCD_Asase = new CD_AsaseFrm() { Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CD_Asase.png"], 32, false) };
                FrmCD_Asase.ShowDialog();
                Application.Restart();
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
                    LargeImageIndex = 44, SmallImageIndex = 44, 
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
            //Get ready all forms (Disabled)
            RebuildForms();
            //must choose asase_code to enable the application //Load CD_Asase
            LoadCD_Asase();

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
            AboutBoxFrm FrmAboutBox = new AboutBoxFrm() { Icon = FXFW.SqlDB.MakeIcon(Student.Properties.Resources.About, 32, false) };
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
            rpt.CreateDataSource("DataSourceStudent", true, true, "Data Sources", constringpro, FXFW.Settings.CredentialRetrievalValues.Store, false, constring.UserID, constring.Password);
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
            rpt.CreateReport("GroupDS", "DataSourceStudent", FXFW.SqlDB.ReportPath, 10080, reports);
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
                    break;
                default:
                    break;
            }
        }
        private void navBarItemCDMarahel_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.GridViewNames.CDMarahel) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CDMarahel.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemCDAlsofof_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.GridViewNames.CDAlsofof) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CDAlsofof.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemCDEFasl_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.GridViewNames.CDEFasl) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CDEFasl.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemCDAlokobat_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.GridViewNames.CDAlokobat) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CDAlokobat.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemCDColekeyat_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.GridViewNames.CDColekeyat) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CDColekeyat.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemCDDyana_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.GridViewNames.CDDyana) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CDDyana.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemcdEyab_code_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.GridViewNames.cdEyab_code) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["cdEyab_code.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemCDGov_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.GridViewNames.CDGov) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CDGov.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemCDHaletalked_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.GridViewNames.CDHaletalked) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CDHaletalked.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemCDHealth_office_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.GridViewNames.CDHealth_office) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CDHealth_office.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemCDJop_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.GridViewNames.CDJop) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CDJop.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemCDLogatcode_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.GridViewNames.CDLogatcode) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CDLogatcode.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemCDEltataem_code_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.GridViewNames.CDEltataem_code) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CDEltataem_code.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemCDGamaat_alnashat_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.GridViewNames.CDGamaat_alnashat) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CDGamaat_alnashat.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemCDMantaka_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.GridViewNames.CDMantaka) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CDMantaka.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemCDMarakez_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.GridViewNames.CDMarakez) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CDMarakez.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemCDMawad_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.GridViewNames.CDMawad) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CDMawad.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemCDnationalty_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.GridViewNames.CDnationalty) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CDnationalty.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemCDQualification_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.GridViewNames.CDQualification) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CDQualification.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemCDEqamaType_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.GridViewNames.CDEqamaType) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CDEqamaType.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemCDSaltalkaraba_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.GridViewNames.CDSaltalkaraba) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CDSaltalkaraba.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemCDTakasosat_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.GridViewNames.CDTakasosat) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CDTakasosat.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemCDAlanshata_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.GridViewNames.CDAlanshata) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CDAlanshata.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemCDRelativeCode_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.GridViewNames.CDRelativeCode) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CDRelativeCode.png"], 32, false) };
            FrmCode.Show();
        }
        private void navBarItemCD_Asase_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            CD_AsaseFrm FrmCD_Asase = new CD_AsaseFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CD_Asase.png"], 32, false) };
            FrmCD_Asase.Show();
        }
        private void navBarItemstudent_t_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            student_tFrm Frmstudent_t = new student_tFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["student_t.png"], 32, false) };
            Frmstudent_t.Show();
        }
        private void navBarItemstu_haletalked_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            stu_haletalkedFrm Frmstu_haletalked = new stu_haletalkedFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["stu_haletalked.png"], 32, false) };
            Frmstu_haletalked.Show();
        }
        private void navBarItemstu_logatcode_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            stu_logatcodeFrm Frmstu_logatcode = new stu_logatcodeFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["stu_logatcode.png"], 32, false) };
            Frmstu_logatcode.Show();
        }
        private void navBarItemstu_colekeyat_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            stu_colekeyatFrm Frmstu_colekeyat = new stu_colekeyatFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["stu_colekeyat.png"], 32, false) };
            Frmstu_colekeyat.Show();
        }
        private void navBarItemstu_alokobat_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            stu_alokobatFrm Frmstu_alokobat = new stu_alokobatFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["stu_alokobat.png"], 32, false) };
            Frmstu_alokobat.Show();
        }
        private void navBarItemstu_almawaheb_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            stu_almawahebFrm Frmstu_almawaheb = new stu_almawahebFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["stu_almawaheb.png"], 32, false) };
            Frmstu_almawaheb.Show();
        }
        private void navBarItemstu_eyab_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            stu_eyabFrm Frmstu_eyab = new stu_eyabFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["stu_eyab.png"], 32, false) };
            Frmstu_eyab.Show();
        }
        private void navBarItemTBLstudent_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            TBLstudentFrm FrmTBLstudent = new TBLstudentFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["TBLstudent.png"], 32, false) };
            FrmTBLstudent.Show();
        }
        private void navBarItemstu_ezn_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            stu_eznFrm Frmstu_ezn = new stu_eznFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["stu_ezn.png"], 32, false) };
            Frmstu_ezn.Show();
        }
        private void navBarItemstu_takasosat_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            stu_takasosatFrm Frmstu_takasosat = new stu_takasosatFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["stu_takasosat.png"], 32, false) };
            Frmstu_takasosat.Show();
        }
        private void navBarItemstu_fatherCall_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            stu_fatherCallFrm Frmstu_fatherCall = new stu_fatherCallFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["stu_fatherCall.png"], 32, false) };
            Frmstu_fatherCall.Show();
        }
        private void navBarItemstu_gamaat_alnashat_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            stu_gamaat_alnashatFrm Frmstu_gamaat_alnashat = new stu_gamaat_alnashatFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["stu_gamaat_alnashat.png"], 32, false) };
            Frmstu_gamaat_alnashat.Show();
        }
        private void navBarItemstu_nashat_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            stu_nashatFrm Frmstu_nashat = new stu_nashatFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["stu_nashat.png"], 32, false) };
            Frmstu_nashat.Show();
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
        private void navBarItemQryStudentContacts_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            QryStudentContactsFrm FrmQryStudentContacts = new QryStudentContactsFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["QryStudentContacts.png"], 32, false) };
            FrmQryStudentContacts.Show();
        }
        private void navBarItemQryStudentInfo_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            QryStudentInfoFrm FrmQryStudentInfo = new QryStudentInfoFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["QryStudentInfo.png"], 32, false) };
            FrmQryStudentInfo.Show();
        }
        private void navBarItemRPT_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            DevExpress.XtraNavBar.NavBarItem NBI = (DevExpress.XtraNavBar.NavBarItem)sender;
            RepGeneralFrm FrmRepGeneral = new RepGeneralFrm() { MdiParent = this, rptSelectedIndex = (int)NBI.Tag };
            FrmRepGeneral.Show();
        }
        #endregion

        
    }

}
