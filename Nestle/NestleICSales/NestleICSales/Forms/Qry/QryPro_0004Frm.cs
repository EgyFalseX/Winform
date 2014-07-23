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
using DevExpress.XtraPivotGrid;

namespace NestleICSales.Forms.Qry
{
    public partial class QryPro_0004Frm : DevExpress.XtraEditors.XtraForm
    {

        #region -   Variables   -
        private static readonly ILog Logger = log4net.LogManager.GetLogger(typeof(QryPro_0001AFrm));
        #endregion
        #region -   Functions   -
        public QryPro_0004Frm()
        {
            InitializeComponent();
            DateTime now = Managers.DataManager.defaultInstance.GetServerDatetime;
            bbiStartDate.EditValue = new DateTime(now.Year, now.Month, 1);
            bbiEndDate.EditValue = now.Date;
        }
        void LoadData()
        {
            Managers.DataManager.SetAllCommandTimeouts(pro_0004TableAdapter, Managers.DataManager.ConnectionTimeout);
            pro_0004TableAdapter.Fill(dsNMQry.Pro_0004, Convert.ToDateTime(bbiStartDate.EditValue), Convert.ToDateTime(bbiEndDate.EditValue));
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
        private void pivotGridControlMain_CellDoubleClick(object sender, PivotCellEventArgs e)
        {
            Form form = new Form();
            form.Text = "Records";
            // Place a DataGrid control on the form.

            DevExpress.XtraGrid.GridControl grid = new DevExpress.XtraGrid.GridControl();

            DevExpress.XtraGrid.Views.Grid.GridView view = new DevExpress.XtraGrid.Views.Grid.GridView(); view.OptionsView.ColumnAutoWidth = false;
            grid.MainView = view;

            grid.Parent = form;
            grid.Dock = DockStyle.Fill;
            // Get the recrd set associated with the current cell and bind it to the grid.
            grid.DataSource = e.CreateDrillDownDataSource();
            form.Bounds = new Rectangle(100, 100, 500, 400);
            // Display the form.
            form.ShowDialog();
            form.Dispose();
        }
        private void pivotGridControlMain_CustomCellValue(object sender, PivotCellValueEventArgs e)
        {
            try
            {
                int CYear = 0;
                if (bbiStartDate.EditValue != null)
                    CYear = ((DateTime)bbiStartDate.EditValue).Year;

                if (e.DataField == calcCases)
                {
                    if (e.GetFieldValue(fieldYearNo) == null)
                        return;
                    if ((int)e.GetFieldValue(fieldYearNo) == CYear - 1)
                    {
                        if (e.Value == null || e.GetCellValue(8, e.RowIndex) == null || e.Value == "0" || e.GetCellValue(8, e.RowIndex) == "0")
                            return;
                        e.Value = (decimal)e.GetCellValue(0, e.RowIndex) / (decimal)e.GetCellValue(8, e.RowIndex);
                    }
                    else if ((int)e.GetFieldValue(fieldYearNo) == CYear)
                    {
                        if (e.Value == null || e.GetCellValue(0, e.RowIndex) == null || e.Value == "0" || e.GetCellValue(0, e.RowIndex) == "0")
                            return;
                        e.Value = (decimal)e.GetCellValue(8, e.RowIndex) / (decimal)e.GetCellValue(0, e.RowIndex);
                    }
                }
                else if (e.DataField == calcNPS)
                {
                    if (e.GetFieldValue(fieldYearNo) == null)
                        return;
                    if ((int)e.GetFieldValue(fieldYearNo) == CYear - 1)
                    {
                        if (e.Value == null || e.GetCellValue(10, e.RowIndex) == null || e.Value == "0" || e.GetCellValue(10, e.RowIndex) == "0")
                            return;
                        e.Value = (decimal)e.GetCellValue(2, e.RowIndex) / (decimal)e.GetCellValue(10, e.RowIndex);
                    }
                    else if ((int)e.GetFieldValue(fieldYearNo) == CYear)
                    {
                        if (e.Value == null || e.GetCellValue(2, e.RowIndex) == null || e.Value == "0" || e.GetCellValue(2, e.RowIndex) == "0")
                            return;
                        e.Value = (decimal)e.GetCellValue(10, e.RowIndex) / (decimal)e.GetCellValue(2, e.RowIndex);
                    }
                }
                else if (e.DataField == calcVolume)
                {
                    if (e.GetFieldValue(fieldYearNo) == null)
                        return;
                    if ((int)e.GetFieldValue(fieldYearNo) == CYear - 1)
                    {
                        if (e.Value == null || e.GetCellValue(12, e.RowIndex) == null || e.Value == "0" || e.GetCellValue(12, e.RowIndex) == "0")
                            return;
                        e.Value = (decimal)e.GetCellValue(4, e.RowIndex) / (decimal)e.GetCellValue(12, e.RowIndex);
                    }
                    else if ((int)e.GetFieldValue(fieldYearNo) == CYear)
                    {
                        if (e.Value == null || e.GetCellValue(4, e.RowIndex) == null || e.Value == "0" || e.GetCellValue(4, e.RowIndex) == "0")
                            return;
                        e.Value = (decimal)e.GetCellValue(12, e.RowIndex) / (decimal)e.GetCellValue(4, e.RowIndex);
                    }
                }
                else if (e.DataField == calcPPL)
                {
                    if (e.GetFieldValue(fieldYearNo) == null)
                        return;
                    if ((int)e.GetFieldValue(fieldYearNo) == CYear - 1)
                    {
                        if (e.Value == null || e.GetCellValue(14, e.RowIndex) == null || e.Value == "0" || e.GetCellValue(14, e.RowIndex) == "0")
                            return;
                        e.Value = (decimal)e.GetCellValue(6, e.RowIndex) / (decimal)e.GetCellValue(14, e.RowIndex);
                    }
                    else if ((int)e.GetFieldValue(fieldYearNo) == CYear)
                    {
                        if (e.Value == null || e.GetCellValue(6, e.RowIndex) == null || e.Value == "0" || e.GetCellValue(6, e.RowIndex) == "0")
                            return;
                        e.Value = (decimal)e.GetCellValue(14, e.RowIndex) / (decimal)e.GetCellValue(6, e.RowIndex);
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Debug(ex.Message, ex);
            }
        }

        #endregion

    }
}
