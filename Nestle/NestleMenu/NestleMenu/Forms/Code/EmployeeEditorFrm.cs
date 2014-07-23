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

namespace NestleMenu.Forms.Code
{
    public partial class EmployeeEditorFrm : DevExpress.XtraEditors.XtraForm
    {
        #region - Var -
        #endregion
        #region - Fun -
        public EmployeeEditorFrm()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            // TODO: This line of code loads data into the 'dsNU.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.dsNU.Employee);
            gridViewMain.BestFitColumns();
        }
        void LoadDefaultData()
        {
            // TODO: This line of code loads data into the 'dsNU.Job' table. You can move, or remove it, as needed.
            this.jobTableAdapter.Fill(this.dsNU.Job);
            // TODO: This line of code loads data into the 'dsNU.Area' table. You can move, or remove it, as needed.
            this.areaTableAdapter.Fill(this.dsNU.Area);
        }
        #endregion
        #region -  EventWhnd - 
        private void AreaEditorFrm_Load(object sender, EventArgs e)
        {
            LoadDefaultData();
            LoadData();
        }
        private void bbiNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                DataSources.dsNU.EmployeeRow row = dsNU.Employee.NewEmployeeRow();
                row.EmployeeId = -1; row.JobId = -1; row.AreaId = -1;
                EmployeeEditorWFrm frm = new EmployeeEditorWFrm(row);
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                    return;
                row.EmployeeId = (int)employeeTableAdapter.NewId();
                dsNU.Employee.AddEmployeeRow(row);
                row.EndEdit();
                employeeTableAdapter.Update(row);
                NU.LogMessage("New Employee Added ...", this, Utilities.Types.MessageType.Success, Utilities.Types.MessagePopupType.Alert);
            }
            catch (Exception ex)
            {
                NU.LogMessage(ex.Message, this, Utilities.Types.MessageType.Error, Utilities.Types.MessagePopupType.Message, ex);
            }
        }
        private void repositoryItemButtonEditEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                DataSources.dsNU.EmployeeRow row = (DataSources.dsNU.EmployeeRow)((DataRowView)gridViewMain.GetRow(gridViewMain.FocusedRowHandle)).Row;
                EmployeeEditorWFrm frm = new EmployeeEditorWFrm(row);
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                    return;
                row.EndEdit();
                employeeTableAdapter.Update(row);
                NU.LogMessage("Employee Changed ...", this, Utilities.Types.MessageType.Success, Utilities.Types.MessagePopupType.Alert);
            }
            catch (Exception ex)
            {
                NU.LogMessage(ex.Message, this, Utilities.Types.MessageType.Error, Utilities.Types.MessagePopupType.Message, ex);
            }
        }
        private void repositoryItemButtonEditDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (msgDlg.Show("Are You Sure?", msgDlg.msgButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                return;
            try
            {
                DataSources.dsNU.EmployeeRow row = (DataSources.dsNU.EmployeeRow)((DataRowView)gridViewMain.GetRow(gridViewMain.FocusedRowHandle)).Row;
                if (row.RowState == DataRowState.Added || row.RowState == DataRowState.Detached)
                    return;
                employeeTableAdapter.Delete(row.EmployeeId);
                gridViewMain.DeleteRow(gridViewMain.FocusedRowHandle);
                NU.LogMessage("Employee Deleted ...", this, Utilities.Types.MessageType.Success, Utilities.Types.MessagePopupType.Alert);

            }
            catch (Exception ex)
            {
                NU.LogMessage(ex.Message, this, Utilities.Types.MessageType.Error, Utilities.Types.MessagePopupType.Message, ex);
            }
        }
        private void bbiExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Check whether the GridControl can be previewed.
            if (!gridControlMain.IsPrintingAvailable)
            {
                NU.LogMessage("The 'DevExpress.XtraPrinting' library is not found", this, Utilities.Types.MessageType.Error, Utilities.Types.MessagePopupType.Message);
                return;
            }
            // Open the Preview window.
            gridControlMain.ShowRibbonPrintPreview();
        }
        #endregion
    }
        
} 
