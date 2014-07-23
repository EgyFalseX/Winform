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
using DevExpress.XtraSplashScreen;
using Fellowship.Data;

namespace Fellowship
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
            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(mbFellowshipSkins, true, true);
            mbFellowshipSkins.GalleryItemClick += rgbiSkins_GalleryItemClick;
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
            SkinHelper.InitSkinGallery(mbFellowshipSkins, true);
        }
        private void LoadUserPriv1(string RoleID)
        {
            return;
            //Hide All Tools
            SQLProvider.FillUserPrv();
            for (int i = 0; i < ribbonControl.Items.Count; i++)
            {
                if (ribbonControl.Items[i].GetType().Name == "BarButtonItem")
                {
                    if (ribbonControl.Items[i].Name == "mbFellowshipHelp" || ribbonControl.Items[i].Name == "mbFellowshipExit" || ribbonControl.Items[i].Name == "mbFellowshipAbout" ||
                        ribbonControl.Items[i].Name == "mbFellowshipSkins" || ribbonControl.Items[i].Name == "mbFellowshipInfo" || ribbonControl.Items[i].Name == "mbFellowshipStatus" ||
                        ribbonControl.Items[i].Name == "mbFellowshipPasswordChanger")
                        continue;
                    ribbonControl.Items[i].Visibility = BarItemVisibility.Never;
                }

            }
            RoleDetialsTbl = FXFW.SqlDB.LoadDataTable("SELECT RoleDetial.MenuItemName FROM UserRoles INNER JOIN RoleDetial ON UserRoles.RoleId = RoleDetial.RoleID WHERE UserRoles.UserId = " + FXFW.SqlDB.UserInfo.UserID);
            foreach (DataRow row in RoleDetialsTbl.Rows)
            {
                for (int i = 0; i < ribbonControl.Items.Count; i++)
                {
                    if (row["MenuItemName"].ToString() == ribbonControl.Items[i].Name)
                        ribbonControl.Items[i].Visibility = BarItemVisibility.Always;
                }
            }
            ////Customizing menu visibility depand on user roles
            //foreach (DataSources.dsRetirementCenter.RoleDetialRow row in SQLProvider.ds.RoleDetial)
            //{
            //    for (int i = 0; i < ribbonControl.Items.Count; i++)
            //    {
            //        if (row.MenuItemName == ribbonControl.Items[i].Name)
            //            ribbonControl.Items[i].Visibility = BarItemVisibility.Always;                        
            //    }
            //}
        }
        private void LoadUserPriv(string RoleID)
        {
            //Hide All Tools
            SQLProvider.FillUserPrv();
            for (int i = 0; i < ribbonControl.Items.Count; i++)
            {
                if (ribbonControl.Items[i].GetType().Name == "BarButtonItem")
                {
                    if (ribbonControl.Items[i].Name == "mbFellowshipHelp" || ribbonControl.Items[i].Name == "mbFellowshipExit" || ribbonControl.Items[i].Name == "mbFellowshipAbout" ||
                        ribbonControl.Items[i].Name == "mbFellowshipSkins" || ribbonControl.Items[i].Name == "mbFellowshipInfo" || ribbonControl.Items[i].Name == "mbFellowshipStatus" ||
                        ribbonControl.Items[i].Name == "mbFellowshipPasswordChanger")
                        continue;
                    ribbonControl.Items[i].Visibility = BarItemVisibility.Never;
                }

            }
            //Customizing menu visibility depand on user roles
            foreach (DataSources.DSFellowship.RoleDetialRow row in SQLProvider.ds.RoleDetial)
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
            
            //// Show Login Screen..
            //using (LoginFrm FrmLogin = new LoginFrm())
            //{
            //    // Create Administrator user if not exists b4 show login form

            //    //RoleDetialFrm role = new RoleDetialFrm();
            //    //role.PrepareAdminRole();
            //    //role.Dispose();
            //    FrmLogin.ShowDialog();
            //}

            LoadUserPriv(FXFW.SqlDB.UserInfo.UserID);
            this.Text += " - " + Program.UserInfo.UserName;
              
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
            AboutBoxFrm abus = new AboutBoxFrm();
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
            if (System.IO.File.Exists(FXFW.SqlDB.DBPath))
            {
                System.IO.File.Delete(FXFW.SqlDB.DBPath);
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
            //SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            //this.Invoke(new MethodInvoker(() =>
            //{
            //    Forms.Main.AppOptionsFrm FrmData = new Forms.Main.AppOptionsFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Options32.png"], 32, false) };
            //    FrmData.Show();    
            //}));
            //SplashScreenManager.CloseForm();
            
        }
        private void mbMembersPasswordChanger_ItemClick(object sender, ItemClickEventArgs e)
        {
            //SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            //this.Invoke(new MethodInvoker(() =>
            //{
            //    Forms.Main.PasswordChangerFrm FrmData = new Forms.Main.PasswordChangerFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(ribbonImageCollectionLarge.Images["Users.png"], 32, false) };
            //    FrmData.Show();
            //}));
            //SplashScreenManager.CloseForm();
        }
        private void mbFellowshipRoles_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                RolesFrm Data = new RolesFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["Roles.png"], 32, false) };
                Data.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbFellowshipUsers_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                UsersFrm Data = new UsersFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["Users.png"], 32, false) };
                Data.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbFellowshipUserRoles_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                UserRolesFrm Data = new UserRolesFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["UserRoles.png"], 32, false) };
                Data.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbFellowshipRoleDetail_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                RoleDetailFrm Data = new RoleDetailFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["RoleDetial.png"], 32, false) };
                Data.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbFellowshipCDSyndicate_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                CodeFrm FrmCode = new CodeFrm(Types.TablesNames.CDSyndicate) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CDSyndicate.png"], 32, false) };
                FrmCode.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbFellowshipCDEDARET_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                CodeFrm FrmCode = new CodeFrm(Types.TablesNames.CDEDARET) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CDEDARET.png"], 32, false) };
                FrmCode.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbFellowshipCDModerea_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                CodeFrm FrmCode = new CodeFrm(Types.TablesNames.CDModerea) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CDModerea.png"], 32, false) };
                FrmCode.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbFellowshipCDState_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                CodeFrm FrmCode = new CodeFrm(Types.TablesNames.CDState) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CDState.png"], 32, false) };
                FrmCode.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbFellowshipCDJob_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                CodeFrm FrmCode = new CodeFrm(Types.TablesNames.CDJob) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CDJob.png"], 32, false) };
                FrmCode.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbFellowshipCDAttach_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                CodeFrm FrmCode = new CodeFrm(Types.TablesNames.CDAttach) { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CDAttach.png"], 32, false) };
                FrmCode.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbFellowshipTBLEdaraMandop_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                TBLEdaraMandopFrm Data = new TBLEdaraMandopFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["TBLEdaraMandop.png"], 32, false) };
                Data.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbFellowshipTBLNkapaMandop_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                TBLNkapaMandopFrm Data = new TBLNkapaMandopFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["TBLEdaraMandop.png"], 32, false) };
                Data.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbFellowshipTBLSheekWared_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                TBLSheekWaredFrm Data = new TBLSheekWaredFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["TBLSheekWared.png"], 32, false) };
                Data.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbFellowshipTblMember_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                TblMemberFrm Data = new TblMemberFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["TblMember.png"], 32, false) };
                Data.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbFellowshipTblSarf_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                TblSarfFrm Data = new TblSarfFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["TblSarf.png"], 32, false) };
                Data.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbFellowshipTblHafzaEstlam_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                TBLHafzaTasleemFrm Data = new TBLHafzaTasleemFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["TblHafzaEstlam.png"], 32, false) };
                Data.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbFellowshipTblMemberAttach_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                TblMemberAttachFrm Data = new TblMemberAttachFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["CDAttach.png"], 32, false) };
                Data.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbFellowshipImport_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Data.ImportFrm Data = new Data.ImportFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["ImportData32.png"], 32, false) };
                Data.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbFellowshipDeleteTblAllData_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                DeleteTblAllDataFrm Data = new DeleteTblAllDataFrm() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["Delete01_32.png"], 32, false) };
                Data.Show();
            }));
            SplashScreenManager.CloseForm();
        }        
        private void mbFellowshipQry001_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry.Qry001 Data = new Qry.Qry001() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["Qry.png"], 32, false) };
                Data.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbFellowshipQry002_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry.Qry002 Data = new Qry.Qry002() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["Qry.png"], 32, false) };
                Data.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbFellowshipQry003_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry.Qry003 Data = new Qry.Qry003() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["Qry.png"], 32, false) };
                Data.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbFellowshipQry004_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry.Qry004 Data = new Qry.Qry004() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["Qry.png"], 32, false) };
                Data.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        private void mbFellowshipQry005_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                Qry.Qry005 Data = new Qry.Qry005() { MdiParent = this, Icon = FXFW.SqlDB.MakeIcon(imageCollection32.Images["Qry.png"], 32, false) };
                Data.Show();
            }));
            SplashScreenManager.CloseForm();
        }
        #endregion


    }

}