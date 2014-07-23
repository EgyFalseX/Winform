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
using DevExpress.Xpo.Metadata;
using DevExpress.XtraSplashScreen;

namespace NICSQLTools.Forms.Data
{
    public partial class ProductEditorFrm : DevExpress.XtraEditors.XtraForm
    {
        #region - Var -
        
        #endregion
        #region - Fun -
        public ProductEditorFrm()
        {
            InitializeComponent();
            
        }
        void LoadData()
        {
            SplashScreenManager.ShowForm(typeof(WaitWindowFrm));
            System.Threading.ThreadPool.QueueUserWorkItem((o) => 
            {
                this.Invoke(new MethodInvoker(() => {
                    XPSCS.Session.ConnectionString = Properties.Settings.Default.IC_DBConnectionString;
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
            if (MsgDlg.Show("Are You Sure ?", MsgDlg.MessageType.Question) == System.Windows.Forms.DialogResult.No)
                return;

            DevExpress.Xpo.AsyncCommitCallback CommitCallBack = new DevExpress.Xpo.AsyncCommitCallback((o) =>
            {
                SplashScreenManager.CloseForm();
                if (o == null)
                    MsgDlg.ShowAlert("Data Saved ...", MsgDlg.MessageType.Success, this);
                else
                    MsgDlg.ShowAlert("Saving Failed ..." + Environment.NewLine + o.Message, MsgDlg.MessageType.Error, this);
            });

            SplashScreenManager.ShowForm(typeof(WaitWindowFrm)); SplashScreenManager.Default.SetWaitFormDescription("Saving ...");
            UOW.CommitTransactionAsync(CommitCallBack);
        }
        private void bbiExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Check whether the GridControl can be previewed.
            if (!gridControlMain.IsPrintingAvailable)
            {
                MsgDlg.Show("The 'DevExpress.XtraPrinting' library is not found", MsgDlg.MessageType.Warn);
                return;
            }
            // Open the Preview window.
            gridControlMain.ShowRibbonPrintPreview();
        }
        #endregion

    }
        
} 
