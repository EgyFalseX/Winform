using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraBars;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Members.Forms.Data;
using DevExpress.XtraSplashScreen;

namespace Members
{
    
    public partial class MainFrm : XtraForm
    {

        #region -   Variables   -
        DataTable RoleDetialsTbl = new DataTable("FalseX2012");
        #endregion
        #region -   Functions   -
        public MainFrm()
        {
            InitializeComponent();
            //Load Skins and layout
            InitSkinGallery();
            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(mbMembersSkins, true, true);
            mbMembersSkins.GalleryItemClick += rgbiSkins_GalleryItemClick;
            if (System.IO.File.Exists(FXFW.SqlDB.StyleSettingsPath))
                UserLookAndFeel.Default.SetSkinStyle(LoadSettings(FXFW.SqlDB.StyleSettingsPath).SkinName);
            
            IsMdiContainer = true;

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
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(mbMembersSkins, true);
        }
        private void LoadCReports()
        {
            //DataTable dt = new DataTable();
            //dt.Columns.Add("RepCaption");
            //dt.Columns.Add("CRReport");
            //for (int i = 0; i < SQLProvider.crRep.Length; i++)
            //{
            //    DataRow row = dt.NewRow();
            //    row["RepCaption"] = SQLProvider.crRep[i].RepCaption;
            //    row["CRReport"] = i;
            //    dt.Rows.Add(row);
            //}
            //repositoryItemLookUpEditCRRep.DataSource = dt;
            //repositoryItemLookUpEditCRRep.DisplayMember = "RepCaption";
            //repositoryItemLookUpEditCRRep.ValueMember = "CRReport";

        }
        private void LoadUserPriv(string RoleID)
        {
            //Hide All Tools
            SQLProvider.FillUserPrv();
            for (int i = 0; i < ribbonControl.Items.Count; i++)
            {
                if (ribbonControl.Items[i].GetType().Name == "BarButtonItem")
                {
                    if (ribbonControl.Items[i].Name == "mbMembersHelp" || ribbonControl.Items[i].Name == "mbMembersExit" || ribbonControl.Items[i].Name == "mbMembersAbout" ||
                        ribbonControl.Items[i].Name == "mbMembersSkins" || ribbonControl.Items[i].Name == "mbMembersInfo" || ribbonControl.Items[i].Name == "mbMembersStatus" ||
                        ribbonControl.Items[i].Name == "mbMembersPasswordChanger")
                        continue;
                    ribbonControl.Items[i].Visibility = BarItemVisibility.Never;
                }

            }
            //Customizing menu visibility depand on user roles
            foreach (DataSources.dsTeachersUnion.RoleDetialRow row in SQLProvider.ds.RoleDetial)
            {
                for (int i = 0; i < ribbonControl.Items.Count; i++)
                {
                    if (row.MenuItemName == ribbonControl.Items[i].Name)
                        ribbonControl.Items[i].Visibility = BarItemVisibility.Always;                        
                }
            }
        }
        #endregion
        #region -   Event Handlers   -

        private void FrmMain_Load(object sender, EventArgs e)
        {
            LoadUserPriv(FXFW.SqlDB.UserInfo.UserID);

            this.Text += " - " + Program.UserInfo.RealName;
        }
        private void MainFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
        private void iMembersExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }
        private void mbMembersAbout_ItemClick(object sender, ItemClickEventArgs e)
        {
            Members.Forms.Main.AboutUs abus = new Forms.Main.AboutUs();
            abus.ShowDialog();
        }
        void rgbiSkins_GalleryItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e)
        {
            FXFW.UserSkinSettings us = new FXFW.UserSkinSettings();
            us.SkinName = UserLookAndFeel.Default.ActiveSkinName;
            SaveSettings(us);
        }
        private void mbDBChange_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("åá ÇäÊ ãÊÃßÏ¿", "ÊÍÒíÜÜÜÜÜÑ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            if (File.Exists(SQLProvider.DBPath))
            {
                File.Delete(SQLProvider.DBPath);
                Application.Restart();
            }
        }
        private void siInfo_ItemDoubleClick(object sender, ItemClickEventArgs e)
        {
            Program.Logger.ShowHideLogWindow = true;
        }
        private void repositoryItemLookUpEditCRRep_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.OK)
            //    return;
            //RepCRGeneralFrm RepForm = new RepCRGeneralFrm();
            //if (mbReportsMembers.EditValue == null)
            //    return;

            //CrystalDecisions.Shared.TableLogOnInfos crtableLogoninfos = new CrystalDecisions.Shared.TableLogOnInfos();
            //CrystalDecisions.Shared.TableLogOnInfo crtableLogoninfo = new CrystalDecisions.Shared.TableLogOnInfo();
            //CrystalDecisions.Shared.ConnectionInfo crConnectionInfo = new CrystalDecisions.Shared.ConnectionInfo();
            //CrystalDecisions.CrystalReports.Engine.Tables CrTables = SQLProvider.crRep[Convert.ToInt16(mbReportsMembers.EditValue)].CRReport.Database.Tables;
            //System.Data.OleDb.OleDbConnectionStringBuilder ConString = new System.Data.OleDb.OleDbConnectionStringBuilder(SQLProvider.AccConStr);
            //crConnectionInfo.ServerName = ConString.DataSource;
            //crConnectionInfo.DatabaseName = ConString.FileName;
            ////crConnectionInfo.UserID = ConString.UserID;
            ////crConnectionInfo.Password = ConString.Password;
            //SQLProvider.crRep[Convert.ToInt16(mbReportsMembers.EditValue)].CRReport.DataSourceConnections[0].SetConnection(ConString.DataSource, ConString.FileName, string.Empty, string.Empty);
            //SQLProvider.crRep[Convert.ToInt16(mbReportsMembers.EditValue)].CRReport.SetDatabaseLogon(string.Empty, string.Empty, ConString.DataSource, ConString.FileName, true);

            //foreach (CrystalDecisions.Shared.IConnectionInfo info in SQLProvider.crRep[Convert.ToInt16(mbReportsMembers.EditValue)].CRReport.DataSourceConnections)
            //{
            //    info.SetConnection(ConString.DataSource, ConString.FileName, string.Empty, string.Empty);
            //}
            //foreach (CrystalDecisions.CrystalReports.Engine.ReportDocument sub in SQLProvider.crRep[Convert.ToInt16(mbReportsMembers.EditValue)].CRReport.Subreports)
            //{
            //    foreach (CrystalDecisions.Shared.IConnectionInfo info in sub.DataSourceConnections)
            //    {
            //        info.SetConnection(ConString.DataSource, ConString.FileName, string.Empty, string.Empty);
            //    }
            //}

            //foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
            //{
            //    crtableLogoninfo = CrTable.LogOnInfo;
            //    crtableLogoninfo.ConnectionInfo = crConnectionInfo;
            //    CrTable.ApplyLogOnInfo(crtableLogoninfo);
            //}

            //RepForm.CRViewer.ReportSource = SQLProvider.crRep[Convert.ToInt16(mbReportsMembers.EditValue)].CRReport;
            //RepForm.CRViewer.Refresh();
            //RepForm.ReportName = SQLProvider.crRep[Convert.ToInt16(mbReportsMembers.EditValue)].RepCaption;
            //RepForm.MdiParent = this;
            //RepForm.Show();
        }
        private void mbMembersAppOptions_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Forms.Main.AppOptionsFrm FrmData = new Forms.Main.AppOptionsFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Options32.png"], 32, false) };
                FrmData.Show();    
            }));
            SplashScreenManager.CloseForm();
            
        }
        private void mbMembersPasswordChanger_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Forms.Main.PasswordChangerFrm FrmData = new Forms.Main.PasswordChangerFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Users.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersRoles_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                RolesFrm FrmData = new RolesFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Roles.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersUsers_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                UsersFrm FrmData = new UsersFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Users.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersUserRoles_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                UserRolesFrm FrmData = new UserRolesFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["UserRoles.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersRoleDetail_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                RoleDetailFrm FrmData = new RoleDetailFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["RoleDetail.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersCDGov_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDGov) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["CDGov.png"], 32, false) };
                FrmCode.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersCDMarkez_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDMarkez) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["CDMarkez.png"], 32, false) };
                FrmCode.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersCDSyndicate_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDSyndicate) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["CDSyndicate.png"], 32, false) };
                FrmCode.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersCDSubCommitte_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDSubCommitte) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["CDSubCommitte.png"], 32, false) };
                FrmCode.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersCDBirthPlace_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDBirthPlace) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["CDBirthPlace.png"], 32, false) };
                FrmCode.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersCDJop_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDJop) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["CDJop.png"], 32, false) };
                FrmCode.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersCDJobtitle_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDJobtitle) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["CDJop.png"], 32, false) };
                FrmCode.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersCDJobDescription_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDJobDescription) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["CDJobDescription.png"], 32, false) };
                FrmCode.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersCDGehaType_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDGehaType) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["CDGehaType.png"], 32, false) };
                FrmCode.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersCDModerea_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDModerea) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["CDModerea.png"], 32, false) };
                FrmCode.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersCDEDARET_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDEDARET) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["CDEDARET.png"], 32, false) };
                FrmCode.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersCDGeha_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDGeha) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["CDGeha.png"], 32, false) };
                FrmCode.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersCDQualification_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDQualification) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["CDQualification.png"], 32, false) };
                FrmCode.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersCDSpecialization_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDSpecialization) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["CDSpecialization.png"], 32, false) };
                FrmCode.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersCDEstefaaKed_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDEstefaaKed) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["CDEstefaaKed.png"], 32, false) };
                FrmCode.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersCDAttachmentType_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDAttachmentType) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["CDAttachmentType.png"], 32, false) };
                FrmCode.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersTBLMembersFast_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                TBLMembersFastFrm FrmData = new TBLMembersFastFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["TBLMembers.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersTBLMembersFast2_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                TBLMembersFast2Frm FrmData = new TBLMembersFast2Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["TBLMembers.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersTBLMembersFastKid_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                TBLMembersFastKidFrm FrmData = new TBLMembersFastKidFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["TBLMembers.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }

        private void mbMembersTBLHafza_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                TBLHafzaFrm FrmData = new TBLHafzaFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["TBLHafza.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersTBLMemberCard_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                TBLMemberCardFrm FrmData = new TBLMemberCardFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["TBLMemberCard.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersTBLPrintCard_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                TBLPrintCardFrm FrmData = new TBLPrintCardFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["TBLPrintCard.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersTBLPrintCardRe_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                TBLPrintCardReFrm FrmData = new TBLPrintCardReFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["TBLPrintCard.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersTBLPrintCard3_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                TBLPrintCard3Frm FrmData = new TBLPrintCard3Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["TBLPrintCard.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersTBLPrintCardRe3_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                TBLPrintCardRe3Frm FrmData = new TBLPrintCardRe3Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["TBLPrintCard.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersTBLPrintCardFawry_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                TBLPrintCardFawryFrm FrmData = new TBLPrintCardFawryFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["TBLPrintCard.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersTBLMandoop_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                TBLMandoopFrm FrmData = new TBLMandoopFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["TBLMandoop.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersTBLHafzaTasleem_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                TBLHafzaTasleemFrm FrmData = new TBLHafzaTasleemFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["TBLHafza.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersReceipts_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                ReceiptsFrm FrmData = new ReceiptsFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Receipts.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersTblMemberAttach_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                TblMemberAttachFrm FrmData = new TblMemberAttachFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["TblMemberAttach.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersTBLHafzaweb_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                TBLHafzawebFrm FrmData = new TBLHafzawebFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["TBLHafza.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersTBLManualArsheef_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                TBLManualArsheefFrm FrmData = new TBLManualArsheefFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["UserRoles.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersTBLMemberWeb_ItemClick(object sender, ItemClickEventArgs e)
        {
            //SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            //this.Invoke(new MethodInvoker(() =>
            //{
            //    TBLHafzawebFrm FrmData = new TBLHafzawebFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["TBLHafza.png"], 32, false) };
            //    FrmData.Show();
            //}));
            //SplashScreenManager.CloseForm();
        }
        private void mbMembersTBLHafzawebNoTarhelEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                TBLHafzawebNoTarhelEditFrm FrmData = new TBLHafzawebNoTarhelEditFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["TBLMembers.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersImportFromWeb_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                ImportFromWebFrm FrmData = new ImportFromWebFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["ImportData.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersTBLMemberOld_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                TBLMemberOldFrm FrmData = new TBLMemberOldFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["TBLMembers.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersTBLMemberEsalat_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                TBLMemberEsalatFrm FrmData = new TBLMemberEsalatFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Receipts.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersTBLAksat_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                TBLAksatFrm FrmData = new TBLAksatFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["TBLAksat.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersTBLAksatWindow_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                TBLAksatWindowFrm FrmData = new TBLAksatWindowFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["TBLAksat.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersTBLEmpWork_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                TBLEmpWorkFrm FrmData = new TBLEmpWorkFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["TBLEmpWork32.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersTBLUserMistake_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                TBLUserMistakeFrm FrmData = new TBLUserMistakeFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["TBLUserMistake32.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersFixesalnoTBLMembers_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                FixesalnoTBLMembersFrm FrmData = new FixesalnoTBLMembersFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Fixs32.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersFixesalnoTBLMemberWeb_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                FixesalnoTBLMemberWebFrm FrmData = new FixesalnoTBLMemberWebFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["TBLMembers.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersTBLMembersFastMaashat_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                TBLMembersFastMaashatFrm FrmData = new TBLMembersFastMaashatFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["TBLMembers.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbTBLMembersFast3_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                TBLMembersFast3Frm FrmData = new TBLMembersFast3Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["TBLMembers.png"], 32, false) };
                FrmData.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersQry1_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry1Frm FrmQry = new Qry1Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmQry.Show();

            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersQry3_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry3Frm FrmQry = new Qry3Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmQry.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersQry5_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry5Frm FrmQry = new Qry5Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmQry.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersQry6_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry6Frm FrmQry = new Qry6Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmQry.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersQry7_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry7Frm FrmQry = new Qry7Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmQry.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersQry8_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry8Frm FrmQry = new Qry8Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmQry.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersQry9_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry9Frm FrmQry = new Qry9Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmQry.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersQry10_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry10Frm FrmQry = new Qry10Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmQry.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersQry11_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                SplashScreenManager.CloseForm();
                Qry11Frm FrmQry = new Qry11Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmQry.Show();
            }));
        }
        private void mbMembersQry12_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry12Frm FrmQry = new Qry12Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmQry.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersQry13_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry13Frm FrmQry = new Qry13Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmQry.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersQry14_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry14Frm FrmQry = new Qry14Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmQry.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersQry15_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry15Frm FrmQry = new Qry15Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmQry.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersQry16_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry16Frm FrmQry = new Qry16Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmQry.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersQry17_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry17Frm FrmQry = new Qry17Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmQry.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersQry18_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry18Frm FrmQry = new Qry18Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmQry.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersQry19_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry19Frm FrmQry = new Qry19Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmQry.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersQry20_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry20Frm FrmQry = new Qry20Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmQry.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersQry21_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Members.Forms.Qry.Qry21Frm FrmQry = new Members.Forms.Qry.Qry21Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmQry.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersQry22_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Members.Forms.Qry.Qry22Frm FrmQry = new Members.Forms.Qry.Qry22Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmQry.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersQry23_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Members.Forms.Qry.Qry23Frm FrmQry = new Members.Forms.Qry.Qry23Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmQry.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersQry24_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Members.Forms.Qry.Qry24Frm FrmQry = new Members.Forms.Qry.Qry24Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmQry.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersQry25_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Members.Forms.Qry.Qry25Frm FrmQry = new Members.Forms.Qry.Qry25Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmQry.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersQry26_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Members.Forms.Qry.Qry26Frm FrmQry = new Members.Forms.Qry.Qry26Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmQry.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersQry27_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Members.Forms.Qry.Qry27Frm FrmQry = new Members.Forms.Qry.Qry27Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmQry.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersQry28_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Members.Forms.Qry.Qry28Frm FrmQry = new Members.Forms.Qry.Qry28Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmQry.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersQry29_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Members.Forms.Qry.Qry29Frm FrmQry = new Members.Forms.Qry.Qry29Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmQry.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersQry5a_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Members.Forms.Qry.Qry5aFrm FrmQry = new Members.Forms.Qry.Qry5aFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmQry.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersQry30_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Members.Forms.Qry.Qry30Frm FrmQry = new Members.Forms.Qry.Qry30Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmQry.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersQry31_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Members.Forms.Qry.Qry31Frm FrmQry = new Members.Forms.Qry.Qry31Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmQry.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersQry32_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Members.Forms.Qry.Qry32Frm FrmQry = new Members.Forms.Qry.Qry32Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmQry.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersQry33_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Members.Forms.Qry.Qry33Frm FrmQry = new Members.Forms.Qry.Qry33Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmQry.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersSPro_0001_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Members.Forms.Qry.SPro_0001Frm FrmQry = new Members.Forms.Qry.SPro_0001Frm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Qry.png"], 32, false) };
                FrmQry.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersXRep02_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                XRep02 FrmRep = new XRep02();
                Misc.Misc.ShowPrintPreview(FrmRep);

            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersXRep03_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                XRep03 FrmRep = new XRep03();
                Misc.Misc.ShowPrintPreview(FrmRep);
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersXRep04_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                XRep04 FrmRep = new XRep04();
                Misc.Misc.ShowPrintPreview(FrmRep);
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersXRep05_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                XRep05 FrmRep = new XRep05();
                Misc.Misc.ShowPrintPreview(FrmRep);
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersXRep06_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                XRep06 FrmRep = new XRep06();
                Misc.Misc.ShowPrintPreview(FrmRep);
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersXRep07_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                XRep07 FrmRep = new XRep07();
                Misc.Misc.ShowPrintPreview(FrmRep);
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersRep08_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                XRep08 FrmRep = new XRep08();
                Misc.Misc.ShowPrintPreview(FrmRep);
            }));
            SplashScreenManager.CloseForm();
        }
        private void barButtonItemXRepBarcodeTester_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                XRepBarcodeTester FrmRep = new XRepBarcodeTester();
                Misc.Misc.ShowPrintPreview(FrmRep);
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbMembersFiximgPath_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Forms.Temporary.FiximgPathFrm frm = new Forms.Temporary.FiximgPathFrm() { MdiParent = this };
                frm.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        
        #endregion



        



    }

}