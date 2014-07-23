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
    public partial class BranchEditorFrm : DevExpress.XtraEditors.XtraForm
    {
        #region - Var -
        #endregion
        #region - Fun -
        public BranchEditorFrm()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            // TODO: This line of code loads data into the 'dsNU.Branch' table. You can move, or remove it, as needed.
            this.branchTableAdapter.Fill(this.dsNU.Branch);
            gridViewMain.BestFitColumns();
        }
        void LoadDefaultDate()
        {
            // TODO: This line of code loads data into the 'dsNU.Job' table. You can move, or remove it, as needed.
            this.jobTableAdapter.Fill(this.dsNU.Job);
            // TODO: This line of code loads data into the 'dsNU.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.dsNU.Employee);
            // TODO: This line of code loads data into the 'dsNU.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.dsNU.Customers);
        }
        #endregion
        #region -  EventWhnd - 
        private void JobEditorFrm_Load(object sender, EventArgs e)
        {
            LoadDefaultDate();
            LoadData();
        }
        private void bbiNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                DataSources.dsNU.BranchRow row = dsNU.Branch.NewBranchRow();
                row.BranchId = -1; row.CustomerId = -1; row.SupervisorId = -1;
                BranchEditorWFrm frm = new BranchEditorWFrm(row);
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                    return;
                row.BranchId = (int)branchTableAdapter.NewId();
                dsNU.Branch.AddBranchRow(row);
                row.EndEdit();
                branchTableAdapter.Update(row);
                NU.LogMessage("New Branch Added ...", this, Utilities.Types.MessageType.Success, Utilities.Types.MessagePopupType.Alert);
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
                DataSources.dsNU.BranchRow row = (DataSources.dsNU.BranchRow)((DataRowView)gridViewMain.GetRow(gridViewMain.FocusedRowHandle)).Row;
                BranchEditorWFrm frm = new BranchEditorWFrm(row);
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                    return;
                row.EndEdit();
                branchTableAdapter.Update(row);
                NU.LogMessage("Branch Changed ...", this, Utilities.Types.MessageType.Success, Utilities.Types.MessagePopupType.Alert);
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
                DataSources.dsNU.BranchRow row = (DataSources.dsNU.BranchRow)((DataRowView)gridViewMain.GetRow(gridViewMain.FocusedRowHandle)).Row;
                if (row.RowState == DataRowState.Added || row.RowState == DataRowState.Detached)
                    return;
                branchTableAdapter.Delete(row.BranchId);
                gridViewMain.DeleteRow(gridViewMain.FocusedRowHandle);
                NU.LogMessage("Branch Deleted ...", this, Utilities.Types.MessageType.Success, Utilities.Types.MessagePopupType.Alert);

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
