using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using NestleICSales.Utilities;
using DevExpress.Xpo.Metadata;
using DevExpress.XtraSplashScreen;

namespace NestleICSales.Forms.Data
{
    public partial class CustomerEditorFrm : DevExpress.XtraEditors.XtraForm
    {
        #region - Var -
        DataSources.Linq.dsLinqDataContext dsLinq = new DataSources.Linq.dsLinqDataContext();
        #endregion
        #region - Fun -
        public CustomerEditorFrm()
        {
            InitializeComponent();
            
        }
        void LoadData()
        {
            SplashScreenManager.ShowForm(typeof(WaitWindowFrm));
            System.Threading.ThreadPool.QueueUserWorkItem((o) => 
            {
                LSMSCustHierLevel6Id.QueryableSource = from q in dsLinq.vQryCustHierLevels select q;
                LSMSSubchannelId.QueryableSource = from q in dsLinq.Subchannels select q;
                LSMSCustomerTypeId.QueryableSource = from q in dsLinq.CustomerTypes select q;
                LSMSCustomerType2Id.QueryableSource = from q in dsLinq.CustomerType2s select q;
                LSMSCustomerGroupId.QueryableSource = from q in dsLinq.CustomerGroups select q;
                LSMSCityId.QueryableSource = from q in dsLinq.Cities select q;
                gridControlMain.Invoke(new MethodInvoker(() => {
                    gridControlMain.DataSource = XPSCS;
                    gridViewMain.BestFitColumns();
                }));
                SplashScreenManager.CloseForm();
            });
        }
        #endregion
        #region -  EventWhnd - 
        private void Frm_Load(object sender, EventArgs e)
        {
        }
        private void CustomerEditorFrm_Shown(object sender, EventArgs e)
        {
            LoadData();
        }
        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MsgDlg.Show("Are You Sure ?", Types.MessageType.Question) == System.Windows.Forms.DialogResult.No)
                return;

            DevExpress.Xpo.AsyncCommitCallback CommitCallBack = new DevExpress.Xpo.AsyncCommitCallback((o) =>
            {
                SplashScreenManager.CloseForm();
                if (o == null)
                    MsgDlg.ShowAlert("Data Saved ...", Types.MessageType.Success, this);
                else
                    MsgDlg.ShowAlert("Saving Failed ..." + Environment.NewLine + o.Message, Types.MessageType.Error, this);
            });

            SplashScreenManager.ShowForm(typeof(WaitWindowFrm)); SplashScreenManager.Default.SetWaitFormDescription("Saving ...");
            UOW.CommitTransactionAsync(CommitCallBack);
        }
        private void bbiExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Check whether the GridControl can be previewed.
            if (!gridControlMain.IsPrintingAvailable)
            {
                MsgDlg.Show("The 'DevExpress.XtraPrinting' library is not found", Types.MessageType.Warn);
                return;
            }
            // Open the Preview window.
            gridControlMain.ShowRibbonPrintPreview();
        }
        #endregion

    }
        
} 
