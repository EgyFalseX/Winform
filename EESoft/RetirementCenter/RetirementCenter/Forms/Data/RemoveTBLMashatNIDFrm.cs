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
using System.Data.SqlClient;

namespace RetirementCenter
{
    public partial class RemoveTBLMashatNIDFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Functions   -
        public RemoveTBLMashatNIDFrm()
        {
            InitializeComponent();
        }
        void LoadDataSource()
        { // TODO: This line of code loads data into the 'dsRetirementCenter.RemoveTBLMashatNID' table. You can move, or remove it, as needed.
            this.removeTBLMashatNIDTableAdapter.Fill(this.dsRetirementCenter.RemoveTBLMashatNID);
        }
        #endregion
        #region -   Event Handlers   -
        private void Qry06Frm_Load(object sender, EventArgs e)
        {
            LoadDataSource();
            gridViewData.BestFitColumns();
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
        private void repositoryItemButtonEditDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataSources.dsRetirementCenter.RemoveTBLMashatNIDRow row = (DataSources.dsRetirementCenter.RemoveTBLMashatNIDRow)((DataRowView)
            gridViewData.GetRow(gridViewData.FocusedRowHandle)).Row;
            try
            {
                if (msgDlg.Show("هل انت متأكد؟", msgDlg.msgButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                    return;
                removeTBLMashatNIDTableAdapter.RemoveNID(row.MMashatId);
                row.SetMMashatNIdNull();
                Program.ShowMsg("تم حذف بيانات الرقم القومي", false, this, true);
                Program.Logger.LogThis("تم حذف بيانات الرقم القومي", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        #endregion

    }
}