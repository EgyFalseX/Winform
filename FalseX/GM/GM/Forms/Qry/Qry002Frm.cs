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

namespace GM.Forms.Qry
{
    public partial class Qry002Frm : DevExpress.XtraEditors.XtraForm
    {
        #region - Var -
        private static readonly ILog Logger = log4net.LogManager.GetLogger(typeof(Qry002Frm));

        #endregion
        #region - Fun -
        public Qry002Frm()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            // TODO: This line of code loads data into the 'dsQry.GeneralQuery' table. You can move, or remove it, as needed.
            this.generalQueryTableAdapter.FillByBillDate(this.dsQry.GeneralQuery, Convert.ToDateTime(bbiStartDate.EditValue), Convert.ToDateTime(bbiEndDate.EditValue));
        }
        #endregion
        #region -  EventWhnd - 
        private void JobEditorFrm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void bbiGetData_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (bbiStartDate.EditValue == null || bbiStartDate.EditValue == null)
            //{
            //    msgDlg.Show("Please Select Start Date And End Date", msgDlg.msgButtons.Close);
            //    return;
            //}
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
            if (!gridControlMain.IsPrintingAvailable)
            {
                Glob.LogMessage("The 'DevExpress.XtraPrinting' library is not found", this, Utilities.Types.MessageType.Error, Utilities.Types.MessagePopupType.Message);
                return;
            }
            // Open the Preview window.
            gridControlMain.ShowRibbonPrintPreview();
        }
        #endregion

    }
}
