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
using DevExpress.XtraBars;
using System.Collections;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraEditors;


namespace Training_Center
{
    public partial class FrmMain : XtraForm
    {
        #region -   Variables   -
        //private BarItemLink[] MenuItemZ = null;
        #endregion
        #region -   Functions   -
        public FrmMain()
        {
            InitializeComponent();
            barManager.ForceInitialize();
            SkinHelper.InitSkinPopupMenu(mPaintStyle);
        }
        public void RebuildForms()
        {
            //Main
            Program.MCL.FrmActionLog = new ActionLogFrm();
            //Codes
            Program.MCL.FrmCdBankAccount = new CdBankAccountFrm();
            Program.MCL.FrmCDCertificates = new CDCertificatesFrm();
            Program.MCL.FrmCDCourseType = new CDCourseTypeFrm();
            Program.MCL.FrmCdjob = new CdjobFrm();
            Program.MCL.FrmCDknow = new CDknowFrm();
            Program.MCL.FrmCdLab = new CdLabFrm();
            Program.MCL.FrmCDMembershipType = new CDMembershipTypeFrm();
            Program.MCL.FrmCdNationality = new CdNationalityFrm();
            Program.MCL.FrmCdPlace = new CdPlaceFrm();
            Program.MCL.FrmCDReservationWay = new CDReservationWayFrm();
            Program.MCL.FrmCDTrainingBag = new CDTrainingBagFrm();
            //Permission
            Program.MCL.FrmEditorRole = new EditorRoleFrm();
            Program.MCL.FrmEditorRoleMenu = new EditorRoleMenuFrm();
            Program.MCL.FrmEditorUser = new EditorUserFrm();
            Program.MCL.FrmEditorUserInRole = new EditorUserInRoleFrm();
            //Data
            Program.MCL.FrmTBLCourses = new TBLCoursesFrm();
            Program.MCL.FrmTBLCourseAgenda = new TBLCourseAgendaFrm();
            Program.MCL.FrmTBLReservation = new TBLReservationFrm();
            Program.MCL.FrmTBLTrainee = new TBLTraineeFrm();
            Program.MCL.FrmTBLTrainers = new TBLTrainersFrm();
            Program.MCL.FrmTBLCourseCertificates = new TBLCourseCertificatesFrm();
            Program.MCL.FrmTBLTraineeCertificates = new TBLTraineeCertificatesFrm();
            Program.MCL.FrmTBLPartners = new TBLPartnersFrm();
            Program.MCL.FrmTBLTrainersBag = new TBLTrainersBagFrm();
            Program.MCL.FrmTBLTrainersCoursesOut = new TBLTrainersCoursesOutFrm();
            Program.MCL.FrmTBLMemberShip = new TBLMemberShipFrm();
            Program.MCL.FrmTBLWebTrainee = new TBLWebTraineeFrm();
            Program.MCL.FrmTBLAccounts = new TBLAccountsFrm();
            Program.MCL.FrmTblAlkazna = new TblAlkaznaFrm();
            Program.MCL.FrmTBLWebReservation = new TBLWebReservationFrm();
            //Imports
            Program.MCL.FrmDBImport = new DBImportFrm();
        }
        private void EnableMenuItem()
        {
            //LoadReportsMenu(); //
            DataTable ActiveMenu = MyCL.LoadDataTable(String.Format(@"SELECT RoleDetial.MenuItemName FROM UserRoles INNER JOIN RoleDetial ON UserRoles.RoleId = RoleDetial.RoleID
            WHERE (UserRoles.UserId = {0})", MyCL.UserInfo.UserID));
            foreach (DataRow row in ActiveMenu.Rows)
            {
                foreach (BarItem item in barManager.Items)
                {
                    if (item.Name == row["MenuItemName"].ToString())
                    {
                        item.Visibility = BarItemVisibility.Always;
                        break;
                    }
                    
                }
            }
        }
        private void LoadReportsMenu()
        {
            int x = 0;
            foreach (MyCL.ReportTypeStr item in MyCL.RepTyps)
            {
                BarLargeButtonItem BI = new BarLargeButtonItem() { Name = item.RepName, Caption = item.RepCaption, Tag = x.ToString(), Id = 101 + x};
                BI.ItemClick += mbTest_ItemClick;
                x ++;
                barManager.Items.Add(BI);
                //mReports.LinksPersistInfo.AddRange(new LinkPersistInfo[] { new LinkPersistInfo(BI) });
            }
        }
        private void LoadCReports()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("RepCaption");
            dt.Columns.Add("CRReport");
            for (int i = 0; i < MyCL.crRep.Length; i++)
            {
                DataRow row = dt.NewRow();
                row["RepCaption"] = MyCL.crRep[i].RepCaption;
                row["CRReport"] = i;
                dt.Rows.Add(row);
            }
            repositoryItemLookUpEditCRRep.DataSource = dt;
            repositoryItemLookUpEditCRRep.DisplayMember = "RepCaption";
            repositoryItemLookUpEditCRRep.ValueMember = "CRReport";
            
        }
#endregion
        #region -   Event Handlers   -
        private void FrmMain_Load(object sender, EventArgs e)
        {
            using (SplashFrm SC = new SplashFrm())// Show Splash Screen..
                SC.ShowDialog();
            using (LoginFrm FrmLogin = new LoginFrm())// Show Login Screen..
                FrmLogin.ShowDialog();
            RebuildForms();
            EnableMenuItem();
            LoadCReports();// Load Struc CReports Into LUE;


            //Program.MCL.FrmTBLCourseAgenda = new TBLCourseAgendaFrm();
            //Program.MCL.FrmTBLCourseAgenda.MdiParent = this;
            //Program.MCL.FrmTBLCourseAgenda.Show();
        }
        private void mCascade_ItemClick(object sender, ItemClickEventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }
        private void mTileVertical_ItemClick(object sender, ItemClickEventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
        private void mTileHorizontal_ItemClick(object sender, ItemClickEventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }
        private void mCloseAll_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        private void mbDBChange_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("åá ÇäÊ ãÊÃßÏ¿","ÊÍÒíÜÜÜÜÜÑ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            if (System.IO.File.Exists(MyCL.DBPath))
            {
                System.IO.File.Delete(MyCL.DBPath);
                Application.Restart();
            }
        }
        private void mbExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }
        private void repositoryItemLookUpEditCRRep_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.OK)
                return;
            RepCRGeneralFrm RepForm = new RepCRGeneralFrm();
            if (mbReports.EditValue == null)
                return;
            
            CrystalDecisions.Shared.TableLogOnInfos crtableLogoninfos = new CrystalDecisions.Shared.TableLogOnInfos();
            CrystalDecisions.Shared.TableLogOnInfo crtableLogoninfo = new CrystalDecisions.Shared.TableLogOnInfo();
            CrystalDecisions.Shared.ConnectionInfo crConnectionInfo = new CrystalDecisions.Shared.ConnectionInfo();
            CrystalDecisions.CrystalReports.Engine.Tables CrTables = MyCL.crRep[Convert.ToInt16(mbReports.EditValue)].CRReport.Database.Tables;
            System.Data.SqlClient.SqlConnectionStringBuilder ConString = new System.Data.SqlClient.SqlConnectionStringBuilder(MyCL.SqlConStr);
            crConnectionInfo.ServerName = ConString.DataSource;
            crConnectionInfo.DatabaseName = "AATSdata";
            crConnectionInfo.UserID = ConString.UserID;
            crConnectionInfo.Password = ConString.Password;
            MyCL.crRep[Convert.ToInt16(mbReports.EditValue)].CRReport.DataSourceConnections[0].SetConnection(ConString.DataSource, "AATSdata", ConString.UserID, ConString.Password);
            MyCL.crRep[Convert.ToInt16(mbReports.EditValue)].CRReport.SetDatabaseLogon(ConString.UserID, ConString.Password, ConString.DataSource, "AATSdata", true);

            foreach (CrystalDecisions.Shared.IConnectionInfo info in MyCL.crRep[Convert.ToInt16(mbReports.EditValue)].CRReport.DataSourceConnections)
            {
                info.SetConnection(ConString.DataSource, "AATSdata", ConString.UserID, ConString.Password);
            }
            foreach (CrystalDecisions.CrystalReports.Engine.ReportDocument sub in MyCL.crRep[Convert.ToInt16(mbReports.EditValue)].CRReport.Subreports)
            {
                foreach (CrystalDecisions.Shared.IConnectionInfo info in sub.DataSourceConnections)
                {
                    info.SetConnection(ConString.DataSource, "AATSdata", ConString.UserID, ConString.Password);
                }
            }

            foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
            {
                crtableLogoninfo = CrTable.LogOnInfo;
                crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                CrTable.ApplyLogOnInfo(crtableLogoninfo);
            }

            RepForm.CRViewer.ReportSource = MyCL.crRep[Convert.ToInt16(mbReports.EditValue)].CRReport;
            RepForm.CRViewer.Refresh();
            RepForm.ReportName = MyCL.crRep[Convert.ToInt16(mbReports.EditValue)].RepCaption;
            RepForm.MdiParent = this;
            RepForm.Show();



            return;
            //Assign ConnectionString to Report
            //System.Data.SqlClient.SqlConnectionStringBuilder ConString = new System.Data.SqlClient.SqlConnectionStringBuilder(MyCL.SqlConStr);
            MyCL.crRep[Convert.ToInt16(mbReports.EditValue)].CRReport.DataSourceConnections[0].SetConnection(ConString.DataSource, ConString.InitialCatalog, ConString.UserID, ConString.Password);
            MyCL.crRep[Convert.ToInt16(mbReports.EditValue)].CRReport.SetDatabaseLogon(ConString.UserID, ConString.Password, ConString.DataSource, ConString.InitialCatalog, true);
            
            MessageBox.Show(MyCL.crRep[Convert.ToInt16(mbReports.EditValue)].CRReport.DataSourceConnections[0].ServerName);
            MessageBox.Show(MyCL.crRep[Convert.ToInt16(mbReports.EditValue)].CRReport.DataSourceConnections[0].DatabaseName);
            MessageBox.Show(MyCL.crRep[Convert.ToInt16(mbReports.EditValue)].CRReport.DataSourceConnections[0].UserID);
            MessageBox.Show(MyCL.crRep[Convert.ToInt16(mbReports.EditValue)].CRReport.DataSourceConnections[0].Password.ToString());
            //Assign Report to Viewer
            RepForm.CRViewer.ReportSource = MyCL.crRep[Convert.ToInt16(mbReports.EditValue)].CRReport;
            RepForm.ReportName = MyCL.crRep[Convert.ToInt16(mbReports.EditValue)].RepCaption;
            RepForm.MdiParent = this;
            RepForm.Show();
        }
        private void sItem_ItemDoubleClick(object sender, ItemClickEventArgs e)
        {
            if (Program.MCL.FrmActionLog.IsDisposed)
            {
                Program.MCL.FrmActionLog = new ActionLogFrm();
                Program.MCL.FrmActionLog.MdiParent = this;
                Program.MCL.FrmActionLog.Show();
            }
            else
            {
                if (Program.MCL.FrmActionLog.Visible)
                {
                    Program.MCL.FrmActionLog.WindowState = FormWindowState.Normal;
                    Program.MCL.FrmActionLog.Focus();
                }
                else
                {
                    Program.MCL.FrmActionLog.MdiParent = this;
                    Program.MCL.FrmActionLog.Show();
                }
            }
        }
        private void mbCdBankAccount_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.MCL.FrmCdBankAccount.IsDisposed)
            {
                Program.MCL.FrmCdBankAccount = new CdBankAccountFrm();
                Program.MCL.FrmCdBankAccount.MdiParent = this;
                Program.MCL.FrmCdBankAccount.Show();
            }
            else
            {
                if (Program.MCL.FrmCdBankAccount.Visible)
                {
                    Program.MCL.FrmCdBankAccount.WindowState = FormWindowState.Normal;
                    Program.MCL.FrmCdBankAccount.Focus();
                }
                else
                {
                    Program.MCL.FrmCdBankAccount.MdiParent = this;
                    Program.MCL.FrmCdBankAccount.Show();
                }
            }
        }
        private void mbCDCertificates_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.MCL.FrmCDCertificates.IsDisposed)
            {
                Program.MCL.FrmCDCertificates = new CDCertificatesFrm();
                Program.MCL.FrmCDCertificates.MdiParent = this;
                Program.MCL.FrmCDCertificates.Show();
            }
            else
            {
                if (Program.MCL.FrmCDCertificates.Visible)
                {
                    Program.MCL.FrmCDCertificates.WindowState = FormWindowState.Normal;
                    Program.MCL.FrmCDCertificates.Focus();
                }
                else
                {
                    Program.MCL.FrmCDCertificates.MdiParent = this;
                    Program.MCL.FrmCDCertificates.Show();
                }
            }
        }
        private void mbCDCourseType_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.MCL.FrmCDCourseType.IsDisposed)
            {
                Program.MCL.FrmCDCourseType = new CDCourseTypeFrm();
                Program.MCL.FrmCDCourseType.MdiParent = this;
                Program.MCL.FrmCDCourseType.Show();
            }
            else
            {
                if (Program.MCL.FrmCDCourseType.Visible)
                {
                    Program.MCL.FrmCDCourseType.WindowState = FormWindowState.Normal;
                    Program.MCL.FrmCDCourseType.Focus();
                }
                else
                {
                    Program.MCL.FrmCDCourseType.MdiParent = this;
                    Program.MCL.FrmCDCourseType.Show();
                }
            }
        }
        private void mbCdjob_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.MCL.FrmCdjob.IsDisposed)
            {
                Program.MCL.FrmCdjob = new CdjobFrm();
                Program.MCL.FrmCdjob.MdiParent = this;
                Program.MCL.FrmCdjob.Show();
            }
            else
            {
                if (Program.MCL.FrmCdjob.Visible)
                {
                    Program.MCL.FrmCdjob.WindowState = FormWindowState.Normal;
                    Program.MCL.FrmCdjob.Focus();
                }
                else
                {
                    Program.MCL.FrmCdjob.MdiParent = this;
                    Program.MCL.FrmCdjob.Show();
                }
            }
        }
        private void mbCDknow_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.MCL.FrmCDknow.IsDisposed)
            {
                Program.MCL.FrmCDknow = new CDknowFrm();
                Program.MCL.FrmCDknow.MdiParent = this;
                Program.MCL.FrmCDknow.Show();
            }
            else
            {
                if (Program.MCL.FrmCDknow.Visible)
                {
                    Program.MCL.FrmCDknow.WindowState = FormWindowState.Normal;
                    Program.MCL.FrmCDknow.Focus();
                }
                else
                {
                    Program.MCL.FrmCDknow.MdiParent = this;
                    Program.MCL.FrmCDknow.Show();
                }
            }
        }
        private void mbCdLab_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.MCL.FrmCdLab.IsDisposed)
            {
                Program.MCL.FrmCdLab = new CdLabFrm();
                Program.MCL.FrmCdLab.MdiParent = this;
                Program.MCL.FrmCdLab.Show();
            }
            else
            {
                if (Program.MCL.FrmCdLab.Visible)
                {
                    Program.MCL.FrmCdLab.WindowState = FormWindowState.Normal;
                    Program.MCL.FrmCdLab.Focus();
                }
                else
                {
                    Program.MCL.FrmCdLab.MdiParent = this;
                    Program.MCL.FrmCdLab.Show();
                }
            }
        }
        private void mbCDMembershipType_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.MCL.FrmCDMembershipType.IsDisposed)
            {
                Program.MCL.FrmCDMembershipType = new CDMembershipTypeFrm();
                Program.MCL.FrmCDMembershipType.MdiParent = this;
                Program.MCL.FrmCDMembershipType.Show();
            }
            else
            {
                if (Program.MCL.FrmCDMembershipType.Visible)
                {
                    Program.MCL.FrmCDMembershipType.WindowState = FormWindowState.Normal;
                    Program.MCL.FrmCDMembershipType.Focus();
                }
                else
                {
                    Program.MCL.FrmCDMembershipType.MdiParent = this;
                    Program.MCL.FrmCDMembershipType.Show();
                }
            }
        }
        private void mbCdNationality_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.MCL.FrmCdNationality.IsDisposed)
            {
                Program.MCL.FrmCdNationality = new CdNationalityFrm();
                Program.MCL.FrmCdNationality.MdiParent = this;
                Program.MCL.FrmCdNationality.Show();
            }
            else
            {
                if (Program.MCL.FrmCdNationality.Visible)
                {
                    Program.MCL.FrmCdNationality.WindowState = FormWindowState.Normal;
                    Program.MCL.FrmCdNationality.Focus();
                }
                else
                {
                    Program.MCL.FrmCdNationality.MdiParent = this;
                    Program.MCL.FrmCdNationality.Show();
                }
            }
        }
        private void mbCdPlace_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.MCL.FrmCdPlace.IsDisposed)
            {
                Program.MCL.FrmCdPlace = new CdPlaceFrm();
                Program.MCL.FrmCdPlace.MdiParent = this;
                Program.MCL.FrmCdPlace.Show();
            }
            else
            {
                if (Program.MCL.FrmCdPlace.Visible)
                {
                    Program.MCL.FrmCdPlace.WindowState = FormWindowState.Normal;
                    Program.MCL.FrmCdPlace.Focus();
                }
                else
                {
                    Program.MCL.FrmCdPlace.MdiParent = this;
                    Program.MCL.FrmCdPlace.Show();
                }
            }
        }
        private void mbCDReservationWay_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.MCL.FrmCDReservationWay.IsDisposed)
            {
                Program.MCL.FrmCDReservationWay = new CDReservationWayFrm();
                Program.MCL.FrmCDReservationWay.MdiParent = this;
                Program.MCL.FrmCDReservationWay.Show();
            }
            else
            {
                if (Program.MCL.FrmCDReservationWay.Visible)
                {
                    Program.MCL.FrmCDReservationWay.WindowState = FormWindowState.Normal;
                    Program.MCL.FrmCDReservationWay.Focus();
                }
                else
                {
                    Program.MCL.FrmCDReservationWay.MdiParent = this;
                    Program.MCL.FrmCDReservationWay.Show();
                }
            }
        }
        private void mbCDTrainingBag_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.MCL.FrmCDTrainingBag.IsDisposed)
            {
                Program.MCL.FrmCDTrainingBag = new CDTrainingBagFrm();
                Program.MCL.FrmCDTrainingBag.MdiParent = this;
                Program.MCL.FrmCDTrainingBag.Show();
            }
            else
            {
                if (Program.MCL.FrmCDTrainingBag.Visible)
                {
                    Program.MCL.FrmCDTrainingBag.WindowState = FormWindowState.Normal;
                    Program.MCL.FrmCDTrainingBag.Focus();
                }
                else
                {
                    Program.MCL.FrmCDTrainingBag.MdiParent = this;
                    Program.MCL.FrmCDTrainingBag.Show();
                }
            }
        }
        private void mbUsers_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.MCL.FrmEditorUser.IsDisposed)
            {
                Program.MCL.FrmEditorUser = new EditorUserFrm();
                Program.MCL.FrmEditorUser.MdiParent = this;
                Program.MCL.FrmEditorUser.Show();
            }
            else
            {
                if (Program.MCL.FrmEditorUser.Visible)
                {
                    Program.MCL.FrmEditorUser.WindowState = FormWindowState.Normal;
                    Program.MCL.FrmEditorUser.Focus();
                }
                else
                {
                    Program.MCL.FrmEditorUser.MdiParent = this;
                    Program.MCL.FrmEditorUser.Show();
                }
            }
        }
        private void mbRoles_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.MCL.FrmEditorRole.IsDisposed)
            {
                Program.MCL.FrmEditorRole = new EditorRoleFrm();
                Program.MCL.FrmEditorRole.MdiParent = this;
                Program.MCL.FrmEditorRole.Show();
            }
            else
            {
                if (Program.MCL.FrmEditorRole.Visible)
                {
                    Program.MCL.FrmEditorRole.WindowState = FormWindowState.Normal;
                    Program.MCL.FrmEditorRole.Focus();
                }
                else
                {
                    Program.MCL.FrmEditorRole.MdiParent = this;
                    Program.MCL.FrmEditorRole.Show();
                }
            }
        }
        private void mbRoleDetial_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.MCL.FrmEditorRoleMenu.IsDisposed)
            {
                Program.MCL.FrmEditorRoleMenu = new EditorRoleMenuFrm();
                //Program.MCL.FrmEditorRoleMenu.MdiParent = this;
                Program.MCL.FrmEditorRoleMenu.ShowDialog();
            }
            else
            {
                if (Program.MCL.FrmEditorRoleMenu.Visible)
                {
                    Program.MCL.FrmEditorRoleMenu.WindowState = FormWindowState.Normal;
                    Program.MCL.FrmEditorRoleMenu.Focus();
                }
                else
                {
                    //Program.MCL.FrmEditorRoleMenu.MdiParent = this;
                    Program.MCL.FrmEditorRoleMenu.ShowDialog();
                }
            }
        }
        private void mbUserRoles_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.MCL.FrmEditorUserInRole.IsDisposed)
            {
                Program.MCL.FrmEditorUserInRole = new EditorUserInRoleFrm();
                Program.MCL.FrmEditorUserInRole.MdiParent = this;
                Program.MCL.FrmEditorUserInRole.Show();
            }
            else
            {
                if (Program.MCL.FrmEditorUserInRole.Visible)
                {
                    Program.MCL.FrmEditorUserInRole.WindowState = FormWindowState.Normal;
                    Program.MCL.FrmEditorUserInRole.Focus();
                }
                else
                {
                    Program.MCL.FrmEditorUserInRole.MdiParent = this;
                    Program.MCL.FrmEditorUserInRole.Show();
                }
            }
        }
        private void mbTest_ItemClick(object sender, ItemClickEventArgs e)
        {
            RepGeneralFrm RepFrm = new RepGeneralFrm { MdiParent = this };
            MyCL.RepTy = MyCL.ReportType.None;
            RepFrm.Show();
        }
        private void mbTBLCourses_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.MCL.FrmTBLCourses.IsDisposed)
            {
                Program.MCL.FrmTBLCourses = new TBLCoursesFrm();
                Program.MCL.FrmTBLCourses.MdiParent = this;
                Program.MCL.FrmTBLCourses.Show();
            }
            else
            {
                if (Program.MCL.FrmTBLCourses.Visible)
                {
                    Program.MCL.FrmTBLCourses.WindowState = FormWindowState.Normal;
                    Program.MCL.FrmTBLCourses.Focus();
                }
                else
                {
                    Program.MCL.FrmTBLCourses.MdiParent = this;
                    Program.MCL.FrmTBLCourses.Show();
                }
            }
        }
        private void mbTBLCourseAgenda_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.MCL.FrmTBLCourseAgenda.IsDisposed)
            {
                Program.MCL.FrmTBLCourseAgenda = new TBLCourseAgendaFrm();
                Program.MCL.FrmTBLCourseAgenda.MdiParent = this;
                Program.MCL.FrmTBLCourseAgenda.Show();
            }
            else
            {
                if (Program.MCL.FrmTBLCourseAgenda.Visible)
                {
                    Program.MCL.FrmTBLCourseAgenda.WindowState = FormWindowState.Normal;
                    Program.MCL.FrmTBLCourseAgenda.Focus();
                }
                else
                {
                    Program.MCL.FrmTBLCourseAgenda.MdiParent = this;
                    Program.MCL.FrmTBLCourseAgenda.Show();
                }
            }
        }
        private void mbTBLReservation_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.MCL.FrmTBLReservation.IsDisposed)
            {
                Program.MCL.FrmTBLReservation = new TBLReservationFrm();
                Program.MCL.FrmTBLReservation.MdiParent = this;
                Program.MCL.FrmTBLReservation.Show();
            }
            else
            {
                if (Program.MCL.FrmTBLReservation.Visible)
                {
                    Program.MCL.FrmTBLReservation.WindowState = FormWindowState.Normal;
                    Program.MCL.FrmTBLReservation.Focus();
                }
                else
                {
                    Program.MCL.FrmTBLReservation.MdiParent = this;
                    Program.MCL.FrmTBLReservation.Show();
                }
            }
        }
        private void mbTBLTrainee_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.MCL.FrmTBLTrainee.IsDisposed)
            {
                Program.MCL.FrmTBLTrainee = new TBLTraineeFrm();
                Program.MCL.FrmTBLTrainee.MdiParent = this;
                Program.MCL.FrmTBLTrainee.Show();
            }
            else
            {
                if (Program.MCL.FrmTBLTrainee.Visible)
                {
                    Program.MCL.FrmTBLTrainee.WindowState = FormWindowState.Normal;
                    Program.MCL.FrmTBLTrainee.Focus();
                }
                else
                {
                    Program.MCL.FrmTBLTrainee.MdiParent = this;
                    Program.MCL.FrmTBLTrainee.Show();
                }
            }
        }
        private void mbTBLCourseCertificates_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.MCL.FrmTBLCourseCertificates.IsDisposed)
            {
                Program.MCL.FrmTBLCourseCertificates = new TBLCourseCertificatesFrm();
                Program.MCL.FrmTBLCourseCertificates.MdiParent = this;
                Program.MCL.FrmTBLCourseCertificates.Show();
            }
            else
            {
                if (Program.MCL.FrmTBLCourseCertificates.Visible)
                {
                    Program.MCL.FrmTBLCourseCertificates.WindowState = FormWindowState.Normal;
                    Program.MCL.FrmTBLCourseCertificates.Focus();
                }
                else
                {
                    Program.MCL.FrmTBLCourseCertificates.MdiParent = this;
                    Program.MCL.FrmTBLCourseCertificates.Show();
                }
            }
        }
        private void mbTBLTrainers_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.MCL.FrmTBLTrainers.IsDisposed)
            {
                Program.MCL.FrmTBLTrainers = new TBLTrainersFrm();
                Program.MCL.FrmTBLTrainers.MdiParent = this;
                Program.MCL.FrmTBLTrainers.Show();
            }
            else
            {
                if (Program.MCL.FrmTBLTrainers.Visible)
                {
                    Program.MCL.FrmTBLTrainers.WindowState = FormWindowState.Normal;
                    Program.MCL.FrmTBLTrainers.Focus();
                }
                else
                {
                    Program.MCL.FrmTBLTrainers.MdiParent = this;
                    Program.MCL.FrmTBLTrainers.Show();
                }
            }
        }
        private void mbTBLTraineeCertificates_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.MCL.FrmTBLTraineeCertificates.IsDisposed)
            {
                Program.MCL.FrmTBLTraineeCertificates = new TBLTraineeCertificatesFrm();
                Program.MCL.FrmTBLTraineeCertificates.MdiParent = this;
                Program.MCL.FrmTBLTraineeCertificates.Show();
            }
            else
            {
                if (Program.MCL.FrmTBLTraineeCertificates.Visible)
                {
                    Program.MCL.FrmTBLTraineeCertificates.WindowState = FormWindowState.Normal;
                    Program.MCL.FrmTBLTraineeCertificates.Focus();
                }
                else
                {
                    Program.MCL.FrmTBLTraineeCertificates.MdiParent = this;
                    Program.MCL.FrmTBLTraineeCertificates.Show();
                }
            }
        }
        private void mbTBLPartners_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.MCL.FrmTBLPartners.IsDisposed)
            {
                Program.MCL.FrmTBLPartners = new TBLPartnersFrm();
                Program.MCL.FrmTBLPartners.MdiParent = this;
                Program.MCL.FrmTBLPartners.Show();
            }
            else
            {
                if (Program.MCL.FrmTBLPartners.Visible)
                {
                    Program.MCL.FrmTBLPartners.WindowState = FormWindowState.Normal;
                    Program.MCL.FrmTBLPartners.Focus();
                }
                else
                {
                    Program.MCL.FrmTBLPartners.MdiParent = this;
                    Program.MCL.FrmTBLPartners.Show();
                }
            }
        }
        private void mbTBLTrainersBag_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.MCL.FrmTBLTrainersBag.IsDisposed)
            {
                Program.MCL.FrmTBLTrainersBag = new TBLTrainersBagFrm();
                Program.MCL.FrmTBLTrainersBag.MdiParent = this;
                Program.MCL.FrmTBLTrainersBag.Show();
            }
            else
            {
                if (Program.MCL.FrmTBLTrainersBag.Visible)
                {
                    Program.MCL.FrmTBLTrainersBag.WindowState = FormWindowState.Normal;
                    Program.MCL.FrmTBLTrainersBag.Focus();
                }
                else
                {
                    Program.MCL.FrmTBLTrainersBag.MdiParent = this;
                    Program.MCL.FrmTBLTrainersBag.Show();
                }
            }
        }
        private void mbTBLTrainersCoursesOut_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.MCL.FrmTBLTrainersCoursesOut.IsDisposed)
            {
                Program.MCL.FrmTBLTrainersCoursesOut = new TBLTrainersCoursesOutFrm();
                Program.MCL.FrmTBLTrainersCoursesOut.MdiParent = this;
                Program.MCL.FrmTBLTrainersCoursesOut.Show();
            }
            else
            {
                if (Program.MCL.FrmTBLTrainersCoursesOut.Visible)
                {
                    Program.MCL.FrmTBLTrainersCoursesOut.WindowState = FormWindowState.Normal;
                    Program.MCL.FrmTBLTrainersCoursesOut.Focus();
                }
                else
                {
                    Program.MCL.FrmTBLTrainersCoursesOut.MdiParent = this;
                    Program.MCL.FrmTBLTrainersCoursesOut.Show();
                }
            }
        }
        private void mbTBLMemberShip_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.MCL.FrmTBLMemberShip.IsDisposed)
            {
                Program.MCL.FrmTBLMemberShip = new TBLMemberShipFrm();
                Program.MCL.FrmTBLMemberShip.MdiParent = this;
                Program.MCL.FrmTBLMemberShip.Show();
            }
            else
            {
                if (Program.MCL.FrmTBLMemberShip.Visible)
                {
                    Program.MCL.FrmTBLMemberShip.WindowState = FormWindowState.Normal;
                    Program.MCL.FrmTBLMemberShip.Focus();
                }
                else
                {
                    Program.MCL.FrmTBLMemberShip.MdiParent = this;
                    Program.MCL.FrmTBLMemberShip.Show();
                }
            }
        }
        private void mbTBLWebTrainee_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.MCL.FrmTBLWebTrainee.IsDisposed)
            {
                Program.MCL.FrmTBLWebTrainee = new TBLWebTraineeFrm();
                Program.MCL.FrmTBLWebTrainee.MdiParent = this;
                Program.MCL.FrmTBLWebTrainee.Show();
            }
            else
            {
                if (Program.MCL.FrmTBLWebTrainee.Visible)
                {
                    Program.MCL.FrmTBLWebTrainee.WindowState = FormWindowState.Normal;
                    Program.MCL.FrmTBLWebTrainee.Focus();
                }
                else
                {
                    Program.MCL.FrmTBLWebTrainee.MdiParent = this;
                    Program.MCL.FrmTBLWebTrainee.Show();
                }
            }
        }
        private void mbTBLAccounts_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.MCL.FrmTBLAccounts.IsDisposed)
            {
                Program.MCL.FrmTBLAccounts = new TBLAccountsFrm();
                Program.MCL.FrmTBLAccounts.MdiParent = this;
                Program.MCL.FrmTBLAccounts.Show();
            }
            else
            {
                if (Program.MCL.FrmTBLAccounts.Visible)
                {
                    Program.MCL.FrmTBLAccounts.WindowState = FormWindowState.Normal;
                    Program.MCL.FrmTBLAccounts.Focus();
                }
                else
                {
                    Program.MCL.FrmTBLAccounts.MdiParent = this;
                    Program.MCL.FrmTBLAccounts.Show();
                }
            }
        }
        private void mbTblAlkazna_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.MCL.FrmTblAlkazna.IsDisposed)
            {
                Program.MCL.FrmTblAlkazna = new TblAlkaznaFrm();
                Program.MCL.FrmTblAlkazna.MdiParent = this;
                Program.MCL.FrmTblAlkazna.Show();
            }
            else
            {
                if (Program.MCL.FrmTblAlkazna.Visible)
                {
                    Program.MCL.FrmTblAlkazna.WindowState = FormWindowState.Normal;
                    Program.MCL.FrmTblAlkazna.Focus();
                }
                else
                {
                    Program.MCL.FrmTblAlkazna.MdiParent = this;
                    Program.MCL.FrmTblAlkazna.Show();
                }
            }
        }
        private void mbImportTBLTrainee_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.MCL.FrmDBImport.IsDisposed)
            {
                Program.MCL.FrmDBImport = new DBImportFrm();
                Program.MCL.FrmDBImport.xTabC.TabPages.Clear();
                Program.MCL.FrmDBImport.xTabC.TabPages.Add(Program.MCL.FrmDBImport.xtraTabPageImport);
                Program.MCL.FrmDBImport.MdiParent = this;
                Program.MCL.FrmDBImport.Show();
            }
            else
            {
                if (Program.MCL.FrmDBImport.Visible)
                {
                    Program.MCL.FrmDBImport.xTabC.TabPages.Clear();
                    Program.MCL.FrmDBImport.xTabC.TabPages.Add(Program.MCL.FrmDBImport.xtraTabPageImport);

                    Program.MCL.FrmDBImport.WindowState = FormWindowState.Normal;
                    Program.MCL.FrmDBImport.Focus();
                }
                else
                {
                    Program.MCL.FrmDBImport.xTabC.TabPages.Clear();
                    Program.MCL.FrmDBImport.xTabC.TabPages.Add(Program.MCL.FrmDBImport.xtraTabPageImport);

                    Program.MCL.FrmDBImport.MdiParent = this;
                    Program.MCL.FrmDBImport.Show();
                }
            }
        }
        private void mbImportTBLWebReservation_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.MCL.FrmDBImport.IsDisposed)
            {
                Program.MCL.FrmDBImport = new DBImportFrm();
                Program.MCL.FrmDBImport.xTabC.TabPages.Clear();
                Program.MCL.FrmDBImport.xTabC.TabPages.Add(Program.MCL.FrmDBImport.xtraTabPageExport);
                Program.MCL.FrmDBImport.MdiParent = this;
                Program.MCL.FrmDBImport.Show();
            }
            else
            {
                if (Program.MCL.FrmDBImport.Visible)
                {
                    Program.MCL.FrmDBImport.xTabC.TabPages.Clear();
                    Program.MCL.FrmDBImport.xTabC.TabPages.Add(Program.MCL.FrmDBImport.xtraTabPageExport);

                    Program.MCL.FrmDBImport.WindowState = FormWindowState.Normal;
                    Program.MCL.FrmDBImport.Focus();
                }
                else
                {
                    Program.MCL.FrmDBImport.xTabC.TabPages.Clear();
                    Program.MCL.FrmDBImport.xTabC.TabPages.Add(Program.MCL.FrmDBImport.xtraTabPageExport);

                    Program.MCL.FrmDBImport.MdiParent = this;
                    Program.MCL.FrmDBImport.Show();
                }
            }
        }
        private void mbTBLWebReservationFrm_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.MCL.FrmTBLWebReservation.IsDisposed)
            {
                Program.MCL.FrmTBLWebReservation = new TBLWebReservationFrm();
                Program.MCL.FrmTBLWebReservation.MdiParent = this;
                Program.MCL.FrmTBLWebReservation.Show();
            }
            else
            {
                if (Program.MCL.FrmTBLWebReservation.Visible)
                {
                    Program.MCL.FrmTBLWebReservation.WindowState = FormWindowState.Normal;
                    Program.MCL.FrmTBLWebReservation.Focus();
                }
                else
                {
                    Program.MCL.FrmTBLWebReservation.MdiParent = this;
                    Program.MCL.FrmTBLWebReservation.Show();
                }
            }
        }
#endregion

    }
}