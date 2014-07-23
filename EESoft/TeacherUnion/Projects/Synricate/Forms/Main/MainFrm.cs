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

namespace Synricate
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
            SkinHelper.InitSkinGallery(rgbiSkins, true);
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
        #endregion
        #region -   Event Handlers   -
        private void FrmMain_Load(object sender, EventArgs e)
        {
            //Load Reports from file and create its item in the interface
            LoadCReports();
            //Load Skins and layout
            InitSkinGallery();
            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(rgbiSkins, true, true);
            rgbiSkins.GalleryItemClick += rgbiSkins_GalleryItemClick;
            if (System.IO.File.Exists(FXFW.SqlDB.StyleSettingsPath))
                UserLookAndFeel.Default.SetSkinStyle(LoadSettings(FXFW.SqlDB.StyleSettingsPath).SkinName);

            IsMdiContainer = true;

            using (SplashFrm SC = new SplashFrm())// Show Splash Screen..
                SC.ShowDialog();
            using (LoginFrm FrmLogin = new LoginFrm())
            {
                 //Create Administrator user if not exists b4 show login form
                //RoleDetialFrm role = new RoleDetialFrm();
                //role.PrepareAdminRole();
                //role.Dispose();
                FrmLogin.ShowDialog();
            }

            //FXFW.SqlDB.UserInfo = new FXFW.SqlDB.UserInfoStruct() { UserID = "1", UserName = "Admin" };

            //LoadUserPriv(FXFW.SqlDB.UserInfo.UserID);
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
            //if (mbReportsRetirement.EditValue == null)
            //    return;

            //CrystalDecisions.Shared.TableLogOnInfos crtableLogoninfos = new CrystalDecisions.Shared.TableLogOnInfos();
            //CrystalDecisions.Shared.TableLogOnInfo crtableLogoninfo = new CrystalDecisions.Shared.TableLogOnInfo();
            //CrystalDecisions.Shared.ConnectionInfo crConnectionInfo = new CrystalDecisions.Shared.ConnectionInfo();
            //CrystalDecisions.CrystalReports.Engine.Tables CrTables = SQLProvider.crRep[Convert.ToInt16(mbReportsRetirement.EditValue)].CRReport.Database.Tables;
            //System.Data.OleDb.OleDbConnectionStringBuilder ConString = new System.Data.OleDb.OleDbConnectionStringBuilder(SQLProvider.AccConStr);
            //crConnectionInfo.ServerName = ConString.DataSource;
            //crConnectionInfo.DatabaseName = ConString.FileName;
            ////crConnectionInfo.UserID = ConString.UserID;
            ////crConnectionInfo.Password = ConString.Password;
            //SQLProvider.crRep[Convert.ToInt16(mbReportsRetirement.EditValue)].CRReport.DataSourceConnections[0].SetConnection(ConString.DataSource, ConString.FileName, string.Empty, string.Empty);
            //SQLProvider.crRep[Convert.ToInt16(mbReportsRetirement.EditValue)].CRReport.SetDatabaseLogon(string.Empty, string.Empty, ConString.DataSource, ConString.FileName, true);

            //foreach (CrystalDecisions.Shared.IConnectionInfo info in SQLProvider.crRep[Convert.ToInt16(mbReportsRetirement.EditValue)].CRReport.DataSourceConnections)
            //{
            //    info.SetConnection(ConString.DataSource, ConString.FileName, string.Empty, string.Empty);
            //}
            //foreach (CrystalDecisions.CrystalReports.Engine.ReportDocument sub in SQLProvider.crRep[Convert.ToInt16(mbReportsRetirement.EditValue)].CRReport.Subreports)
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

            //RepForm.CRViewer.ReportSource = SQLProvider.crRep[Convert.ToInt16(mbReportsRetirement.EditValue)].CRReport;
            //RepForm.CRViewer.Refresh();
            //RepForm.ReportName = SQLProvider.crRep[Convert.ToInt16(mbReportsRetirement.EditValue)].RepCaption;
            //RepForm.MdiParent = this;
            //RepForm.Show();
        }
        private void mbBookingCDSyndicate_ItemClick(object sender, ItemClickEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDSyndicate) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["CDSyndicate.png"], 32, false) };
            FrmCode.Show();
        }
        private void mbBookingCDSubCommitte_ItemClick(object sender, ItemClickEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDSubCommitte) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["CDSubCommitte.png"], 32, false) };
            FrmCode.Show();
        }
        private void mbSynricateCDSCommitte_ItemClick(object sender, ItemClickEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDSCommitte) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["CDSCommitte.png"], 32, false) };
            FrmCode.Show();
        }
        private void mbSynricateCDCommitteJop_ItemClick(object sender, ItemClickEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDCommitteJop) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["CDCommitteJop.png"], 32, false) };
            FrmCode.Show();
        }
        private void mbSynricateCDJop_ItemClick(object sender, ItemClickEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDJop) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["CDJop.png"], 32, false) };
            FrmCode.Show();
        }
        private void mbSynricateCDYear_ItemClick(object sender, ItemClickEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDYear) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["CDYear.png"], 32, false) };
            FrmCode.Show();
        }
        private void mbSynricateCDMonth_ItemClick(object sender, ItemClickEventArgs e)
        {
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDMonth) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["CDMonth.png"], 32, false) };
            FrmCode.Show();
        }
        private void mbSynricateTBLMeeting_ItemClick(object sender, ItemClickEventArgs e)
        {
            TBLMeetingFrm FrmTBLMeeting = new TBLMeetingFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["TBLMeeting.png"], 32, false) };
            FrmTBLMeeting.Show();
        }
        private void mbSynricateTBLMember_ItemClick(object sender, ItemClickEventArgs e)
        {
            TBLMemberFrm FrmTBLMember = new TBLMemberFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["TBLMember.png"], 32, false) };
            FrmTBLMember.Show();
        }
        private void mbSynricateTBLSCommitteMember_ItemClick(object sender, ItemClickEventArgs e)
        {
            TBLSCommitteMemberFrm FrmTBLSCommitteMember = new TBLSCommitteMemberFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["TBLSCommitteMember.png"], 32, false) };
            FrmTBLSCommitteMember.Show();
        }
        private void mbSynricateTBLPlan_ItemClick(object sender, ItemClickEventArgs e)
        {
            TBLPlanFrm FrmTBLPlan = new TBLPlanFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["TBLPlan.png"], 32, false) };
            FrmTBLPlan.Show();
        }
        private void mbSynricatesms_ItemClick(object sender, ItemClickEventArgs e)
        {
            smsFrm Frmsms = new smsFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["sms.png"], 32, false) };
            Frmsms.Show();
        }
        private void mbSynricateScheduler_ItemClick(object sender, ItemClickEventArgs e)
        {
            SchedulerFrm FrmScheduler = new SchedulerFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Scheduler.png"], 32, false) };
            FrmScheduler.Show();
        }
        #endregion

    }

}