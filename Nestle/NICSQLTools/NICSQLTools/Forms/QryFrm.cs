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
using DevExpress.XtraSplashScreen;

namespace NICSQLTools
{
    public partial class QryFrm : DevExpress.XtraEditors.XtraForm
    {
        public QryFrm()
        {
            InitializeComponent();
            unitOfWorkData.ConnectionString = Properties.Settings.Default.cfgConnectionString;
            xpCollectionData.Session = unitOfWorkData;
            
            unitOfWorkProcedures.ConnectionString = Properties.Settings.Default.cfgConnectionString;
            xpCollectionProcedures.Session = unitOfWorkProcedures;
        }
        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MsgDlg.Show("Are You Sure ?", MsgDlg.MessageType.Question) == System.Windows.Forms.DialogResult.No)
                return;
            splashScreenManagerForm.ShowWaitForm(); splashScreenManagerForm.SetWaitFormDescription("Saving ...");
            unitOfWorkData.CommitTransaction();
            
            splashScreenManagerForm.CloseWaitForm();
            MsgDlg.ShowAlert("Data Saved ...", MsgDlg.MessageType.Success, this);
        }
        private void bbiExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Check whether the GridControl can be previewed.
            if (!gridControlData.IsPrintingAvailable)
            {
                MsgDlg.Show("The 'DevExpress.XtraPrinting' library is not found", MsgDlg.MessageType.Warn);
                return;
            }
            // Open the Preview window.
            gridControlData.ShowRibbonPrintPreview();
        }
    }
}