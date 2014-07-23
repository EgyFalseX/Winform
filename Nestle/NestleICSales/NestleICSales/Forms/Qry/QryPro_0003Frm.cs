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
using log4net;

namespace NestleICSales.Forms.Qry
{
    public partial class QryPro_0003Frm : DevExpress.XtraEditors.XtraForm
    {

        #region -   Variables   -
        private static readonly ILog Logger = log4net.LogManager.GetLogger(typeof(QryPro_0001AFrm));
        #endregion
        #region -   Functions   -
        public QryPro_0003Frm()
        {
            InitializeComponent();

            //Show current server week number
            bsiWeekNumber.Caption += (new DataSources.dsQryTableAdapters.QueriesTableAdapter().CurrentWeekNumber()).ToString();
        }
        void LoadData()
        {
            pro_0003TableAdapter.Fill(dsNMQry.Pro_0003, Convert.ToDateTime(bbiStartDate.EditValue));
            pivotGridControlMain.BestFit();
        }
        #endregion
        #region -   Event Handlers   -
        private void bbiGetData_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bbiStartDate.EditValue == null)
            {
                MsgDlg.Show("Please Select A Date", Utilities.Types.MessageType.Warn);
                return;
            }
            SplashScreenManager.ShowForm(typeof(WaitWindowFrm));
            this.Invoke(new MethodInvoker(() =>
            {
                LoadData();
            }));
            SplashScreenManager.CloseForm();
        }
        private void bbiExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Check whether the GridControl can be previewed.
            if (!pivotGridControlMain.IsPrintingAvailable)
            {
                MsgDlg.Show("The 'DevExpress.XtraPrinting' library is not found", Utilities.Types.MessageType.Warn);
                return;
            }
            // Open the Preview window.
            pivotGridControlMain.ShowRibbonPrintPreview();
        }
        #endregion



    }
}
