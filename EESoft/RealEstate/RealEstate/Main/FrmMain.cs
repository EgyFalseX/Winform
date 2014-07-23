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

namespace RealEstate
{
    
    public partial class FrmMain : XtraForm
    {
        #region -   Variables   -
        #endregion
        #region -   Functions   -
        public FrmMain()
        {
            InitializeComponent();
            InitSkinGallery();
            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(rgbiSkins, true, true);
            rgbiSkins.GalleryItemClick += rgbiSkins_GalleryItemClick;
        }
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }
        public void RebuildForms()
        { 
            //Main
            Program.MCL.FrmActionLog = new ActionLogFrm();
            //Codes
            Program.MCL.FrmBasicData = new BasicDataFrm();
            Program.MCL.FrmCdArea = new CdAreaFrm();
            Program.MCL.FrmCdEstateCase = new CdEstateCaseFrm();
            Program.MCL.FrmCdperiod = new CdperiodFrm();
            Program.MCL.FrmCdTypeEstate = new CdTypeEstateFrm();
            Program.MCL.FrmActionLog = new ActionLogFrm();
            Program.MCL.Frmcdnationalty = new cdnationaltyFrm();
            //Data
            Program.MCL.FrmTblOwner = new TblOwnerFrm();
            Program.MCL.FrmTblEstate = new TblEstateFrm();
            Program.MCL.FrmBuyContract = new BuyContractFrm();
            //Qry
            Program.MCL.FrmQryTblEstate = new QryTblEstateFrm();
        }
        private UserSettings LoadSettings(string fileName)
        {
            UserSettings us = null;
            BinaryFormatter binFormat = new BinaryFormatter();
            Stream fStream = new FileStream(fileName, FileMode.Open);
            try { us = binFormat.Deserialize(fStream) as UserSettings; }
            finally { fStream.Close(); }
            return us;
        }
        private void SaveSettings(UserSettings us)
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            using (Stream fStream = new FileStream(MyCL.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                binFormat.Serialize(fStream, us);
                fStream.Close();
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
            IsMdiContainer = true;
            using (SplashFrm SC = new SplashFrm())// Show Splash Screen..
                SC.ShowDialog();
            using (LoginFrm FrmLogin = new LoginFrm())// Show Login Screen..
                FrmLogin.ShowDialog();
            RebuildForms();
            if (File.Exists(MyCL.FileName))
                UserLookAndFeel.Default.SetSkinStyle(LoadSettings(MyCL.FileName).SkinName);
            LoadCReports();// Load Struc CReports Into LUE;
            //EnableMenuItem();
        }
        void rgbiSkins_GalleryItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e)
        {
            UserSettings us = new UserSettings();
            us.SkinName = UserLookAndFeel.Default.ActiveSkinName;
            SaveSettings(us);
        }
        private void mbDBChange_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("åá ÇäÊ ãÊÃßÏ¿", "ÊÍÒíÜÜÜÜÜÑ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            if (File.Exists(MyCL.DBPath))
            {
                File.Delete(MyCL.DBPath);
                Application.Restart();
            }
        }
        private void siInfo_ItemDoubleClick(object sender, ItemClickEventArgs e)
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
        private void mbBasicData_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.MCL.FrmBasicData.IsDisposed)
            {
                Program.MCL.FrmBasicData = new BasicDataFrm();
                Program.MCL.FrmBasicData.MdiParent = this;
                Program.MCL.FrmBasicData.Show();
            }
            else
            {
                if (Program.MCL.FrmBasicData.Visible)
                {
                    Program.MCL.FrmBasicData.WindowState = FormWindowState.Normal;
                    Program.MCL.FrmBasicData.Focus();
                }
                else
                {
                    Program.MCL.FrmBasicData.MdiParent = this;
                    Program.MCL.FrmBasicData.Show();
                }
            }
        }
        private void mbCdTypeEstate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.MCL.FrmCdTypeEstate.IsDisposed)
            {
                Program.MCL.FrmCdTypeEstate = new CdTypeEstateFrm();
                Program.MCL.FrmCdTypeEstate.MdiParent = this;
                Program.MCL.FrmCdTypeEstate.Show();
            }
            else
            {
                if (Program.MCL.FrmCdTypeEstate.Visible)
                {
                    Program.MCL.FrmCdTypeEstate.WindowState = FormWindowState.Normal;
                    Program.MCL.FrmCdTypeEstate.Focus();
                }
                else
                {
                    Program.MCL.FrmCdTypeEstate.MdiParent = this;
                    Program.MCL.FrmCdTypeEstate.Show();
                }
            }
        }
        private void mbCdperiod_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.MCL.FrmCdperiod.IsDisposed)
            {
                Program.MCL.FrmCdperiod = new CdperiodFrm();
                Program.MCL.FrmCdperiod.MdiParent = this;
                Program.MCL.FrmCdperiod.Show();
            }
            else
            {
                if (Program.MCL.FrmCdperiod.Visible)
                {
                    Program.MCL.FrmCdperiod.WindowState = FormWindowState.Normal;
                    Program.MCL.FrmCdperiod.Focus();
                }
                else
                {
                    Program.MCL.FrmCdperiod.MdiParent = this;
                    Program.MCL.FrmCdperiod.Show();
                }
            }
        }
        private void mbCdArea_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.MCL.FrmCdArea.IsDisposed)
            {
                Program.MCL.FrmCdArea = new CdAreaFrm();
                Program.MCL.FrmCdArea.MdiParent = this;
                Program.MCL.FrmCdArea.Show();
            }
            else
            {
                if (Program.MCL.FrmCdArea.Visible)
                {
                    Program.MCL.FrmCdArea.WindowState = FormWindowState.Normal;
                    Program.MCL.FrmCdArea.Focus();
                }
                else
                {
                    Program.MCL.FrmCdArea.MdiParent = this;
                    Program.MCL.FrmCdArea.Show();
                }
            }
        }
        private void mbCdEstateCase_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.MCL.FrmCdEstateCase.IsDisposed)
            {
                Program.MCL.FrmCdEstateCase = new CdEstateCaseFrm();
                Program.MCL.FrmCdEstateCase.MdiParent = this;
                Program.MCL.FrmCdEstateCase.Show();
            }
            else
            {
                if (Program.MCL.FrmCdEstateCase.Visible)
                {
                    Program.MCL.FrmCdEstateCase.WindowState = FormWindowState.Normal;
                    Program.MCL.FrmCdEstateCase.Focus();
                }
                else
                {
                    Program.MCL.FrmCdEstateCase.MdiParent = this;
                    Program.MCL.FrmCdEstateCase.Show();
                }
            }
        }
        private void mbTblOwner_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.MCL.FrmTblOwner.IsDisposed)
            {
                Program.MCL.FrmTblOwner = new TblOwnerFrm();
                Program.MCL.FrmTblOwner.MdiParent = this;
                Program.MCL.FrmTblOwner.Show();
            }
            else
            {
                if (Program.MCL.FrmTblOwner.Visible)
                {
                    Program.MCL.FrmTblOwner.WindowState = FormWindowState.Normal;
                    Program.MCL.FrmTblOwner.Focus();
                }
                else
                {
                    Program.MCL.FrmTblOwner.MdiParent = this;
                    Program.MCL.FrmTblOwner.Show();
                }
            }
        }
        private void mbTblEstate_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.MCL.FrmTblEstate.IsDisposed)
            {
                Program.MCL.FrmTblEstate = new TblEstateFrm();
                Program.MCL.FrmTblEstate.MdiParent = this;
                Program.MCL.FrmTblEstate.Show();
            }
            else
            {
                if (Program.MCL.FrmTblEstate.Visible)
                {
                    Program.MCL.FrmTblEstate.WindowState = FormWindowState.Normal;
                    Program.MCL.FrmTblEstate.Focus();
                }
                else
                {
                    Program.MCL.FrmTblEstate.MdiParent = this;
                    Program.MCL.FrmTblEstate.Show();
                }
            }
        }
        private void mbcdnationalty_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.MCL.Frmcdnationalty.IsDisposed)
            {
                Program.MCL.Frmcdnationalty = new cdnationaltyFrm();
                Program.MCL.Frmcdnationalty.MdiParent = this;
                Program.MCL.Frmcdnationalty.Show();
            }
            else
            {
                if (Program.MCL.Frmcdnationalty.Visible)
                {
                    Program.MCL.Frmcdnationalty.WindowState = FormWindowState.Normal;
                    Program.MCL.Frmcdnationalty.Focus();
                }
                else
                {
                    Program.MCL.Frmcdnationalty.MdiParent = this;
                    Program.MCL.Frmcdnationalty.Show();
                }
            }
        }
        private void mbBuyContract_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.MCL.FrmBuyContract.IsDisposed)
            {
                Program.MCL.FrmBuyContract = new BuyContractFrm();
                Program.MCL.FrmBuyContract.MdiParent = this;
                Program.MCL.FrmBuyContract.Show();
            }
            else
            {
                if (Program.MCL.FrmBuyContract.Visible)
                {
                    Program.MCL.FrmBuyContract.WindowState = FormWindowState.Normal;
                    Program.MCL.FrmBuyContract.Focus();
                }
                else
                {
                    Program.MCL.FrmBuyContract.MdiParent = this;
                    Program.MCL.FrmBuyContract.Show();
                }
            }
        }
        private void QryTblEstate_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.MCL.FrmQryTblEstate.IsDisposed)
            {
                Program.MCL.FrmQryTblEstate = new QryTblEstateFrm();
                Program.MCL.FrmQryTblEstate.MdiParent = this;
                Program.MCL.FrmQryTblEstate.Show();
            }
            else
            {
                if (Program.MCL.FrmQryTblEstate.Visible)
                {
                    Program.MCL.FrmQryTblEstate.WindowState = FormWindowState.Normal;
                    Program.MCL.FrmQryTblEstate.Focus();
                }
                else
                {
                    Program.MCL.FrmQryTblEstate.MdiParent = this;
                    Program.MCL.FrmQryTblEstate.Show();
                }
            }
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
            System.Data.OleDb.OleDbConnectionStringBuilder ConString = new System.Data.OleDb.OleDbConnectionStringBuilder(MyCL.AccConStr);
            crConnectionInfo.ServerName = ConString.DataSource;
            crConnectionInfo.DatabaseName = ConString.FileName;
            //crConnectionInfo.UserID = ConString.UserID;
            //crConnectionInfo.Password = ConString.Password;
            MyCL.crRep[Convert.ToInt16(mbReports.EditValue)].CRReport.DataSourceConnections[0].SetConnection(ConString.DataSource, ConString.FileName, string.Empty, string.Empty);
            MyCL.crRep[Convert.ToInt16(mbReports.EditValue)].CRReport.SetDatabaseLogon(string.Empty, string.Empty, ConString.DataSource, ConString.FileName, true);

            foreach (CrystalDecisions.Shared.IConnectionInfo info in MyCL.crRep[Convert.ToInt16(mbReports.EditValue)].CRReport.DataSourceConnections)
            {
                info.SetConnection(ConString.DataSource, ConString.FileName, string.Empty, string.Empty);
            }
            foreach (CrystalDecisions.CrystalReports.Engine.ReportDocument sub in MyCL.crRep[Convert.ToInt16(mbReports.EditValue)].CRReport.Subreports)
            {
                foreach (CrystalDecisions.Shared.IConnectionInfo info in sub.DataSourceConnections)
                {
                    info.SetConnection(ConString.DataSource, ConString.FileName, string.Empty, string.Empty);
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
        }
        #endregion

        

    }


    [Serializable]
    public class UserSettings
    {
        public string SkinName;
    }
}