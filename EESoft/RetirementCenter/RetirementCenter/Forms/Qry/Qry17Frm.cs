using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;

namespace RetirementCenter
{
    public partial class Qry17Frm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext();
        #region -   Functions   -
        public Qry17Frm()
        {
            InitializeComponent();
        }
        #endregion
        #region -   Event Handlers   -
        private void Qry06Frm_Load(object sender, EventArgs e)
        {
            LSMSCDSyndicate.QueryableSource = dsLinq.CDSyndicates;
            LSMSCDSubCommitte.QueryableSource = dsLinq.CDSubCommittes;
            //gridViewData.BestFitColumns();

        }
        private void Qry17Frm_Shown(object sender, EventArgs e)
        {
            System.Threading.ThreadPool.QueueUserWorkItem((o) => 
            {
                gridControlData.Invoke(new EventHandler((oo, ee) => 
                {
                    SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
                    gridControlData.DataSource = SQLProvider.PersonNameCounter();
                    SplashScreenManager.CloseForm();
                }));
            });
        }
        private void btnPrintExport_Click(object sender, EventArgs e)
        {
            // Check whether the GridControl can be previewed.
            if (!gridControlData.IsPrintingAvailable)
            {
                msgDlg.Show("The 'DevExpress.XtraPrinting' library is not found");
                return;
            }

            // Open the Preview window.
            gridControlData.ShowRibbonPrintPreview();
        }
        private void repositoryItemButtonEditEditor_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataRow row = ((DataRowView)gridViewData.GetRow(gridViewData.FocusedRowHandle)).Row;
            TBLMashatFrm frm = new TBLMashatFrm(Convert.ToInt32(row["MMashatId"]), TBLMashatFrm.TabInfo.WarasaInfo);
            frm.WindowState = FormWindowState.Normal;
            frm.Show();
        }
        #endregion

        

    }
}
