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

namespace NestleMenu.Forms.Data
{
    public partial class MenuOrderWiz : DevExpress.XtraEditors.XtraForm
    {

        #region - Var -
        DataSources.dsNU.MenuOrderRow _MenuOrder;
        #endregion
        #region - Fun -
        public MenuOrderWiz(int MenuOrderId)
        {
            InitializeComponent();
            if (MenuOrderId == -1)
            {
                _MenuOrder = dsNU.MenuOrder.NewMenuOrderRow();
                _MenuOrder.MenuOrderId = MenuOrderId;
                _MenuOrder.MenuOrderDate = DateTime.Now;
                _MenuOrder.ShowLogo = false;
                _MenuOrder.OrderCount = 0;
                dsNU.MenuOrder.AddMenuOrderRow(_MenuOrder);
            }
            else
            {
                menuOrderTableAdapter.FillByMenuOrderId(dsNU.MenuOrder, MenuOrderId);
                _MenuOrder = dsNU.MenuOrder[0];
            }
            menuOrderContainTableAdapter.FillByMenuOrderId(dsNU.MenuOrderContain, MenuOrderId);
        }
        private void LoadDefaultData()
        {
            // TODO: This line of code loads data into the 'dsNU.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.dsNU.Customers);
            // TODO: This line of code loads data into the 'dsNU.Area' table. You can move, or remove it, as needed.
            this.areaTableAdapter.Fill(this.dsNU.Area);
            // TODO: This line of code loads data into the 'dsNU.Job' table. You can move, or remove it, as needed.
            this.jobTableAdapter.Fill(this.dsNU.Job);
            // TODO: This line of code loads data into the 'dsNU.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.dsNU.Employee);
            // TODO: This line of code loads data into the 'dsNU.MenuTheme' table. You can move, or remove it, as needed.
            this.menuThemeTableAdapter.FillByEnabled(this.dsNU.MenuTheme);
            // TODO: This line of code loads data into the 'dsNU.MenuSize' table. You can move, or remove it, as needed.
            this.menuSizeTableAdapter.FillByEnabled(this.dsNU.MenuSize);
            // TODO: This line of code loads data into the 'dsNU.Branch' table. You can move, or remove it, as needed.
            this.branchTableAdapter.Fill(this.dsNU.Branch);
            // TODO: This line of code loads data into the 'dsNU.ProductBase' table. You can move, or remove it, as needed.
            this.productBaseTableAdapter.Fill(this.dsNU.ProductBase);
            // TODO: This line of code loads data into the 'dsNU.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.FillByEnabled(this.dsNU.Product);

            //BranchIdLookUpEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.
        }
        #endregion
        #region - EventWhnd -
        private void MenuOrderWiz_Load(object sender, EventArgs e)
        {
            LoadDefaultData();
        }
        private void btnNewMenuOrderContains_Click(object sender, EventArgs e)
        {
            layoutViewContains.AddNewRow();
        }
        private void layoutViewContains_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataSources.dsNU.MenuOrderContainRow row = (DataSources.dsNU.MenuOrderContainRow)((DataRowView)layoutViewContains.GetRow(e.RowHandle)).Row;
            row.MenuOrderId = _MenuOrder.MenuOrderId;
            row.ContainId = -1;
            row.Price = 0;
            row.ShowPrice = false;
        }
        private void repositoryItemGridLookUpEditProductId_EditValueChanged(object sender, EventArgs e)
        {
            GridLookUpEdit lue = (GridLookUpEdit)sender;
            DataSources.dsNU.MenuOrderContainRow row = (DataSources.dsNU.MenuOrderContainRow)
                ((DataRowView)layoutViewContains.GetRow(layoutViewContains.FocusedRowHandle)).Row;
            row.EndEdit();
            if (lue.EditValue == null)
                return;
            row.ProductImage = productTableAdapter.GetProductImage(Convert.ToInt32(lue.EditValue));
        }
        private void wizardControlMain_SelectedPageChanging(object sender, DevExpress.XtraWizard.WizardPageChangingEventArgs e)
        {
            e.Cancel = !dxValidationProviderMain.Validate();
        }
        private void repositoryItemButtonEditDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //DataSources.dsNU.MenuOrderContainRow row = (DataSources.dsNU.MenuOrderContainRow)
            //  ((DataRowView)layoutViewContains.GetRow(layoutViewContains.FocusedRowHandle)).Row;
            //row.Delete();
            layoutViewContains.DeleteRow(layoutViewContains.FocusedRowHandle);
        }
        private void wizardControlMain_CancelClick(object sender, CancelEventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
        private void wizardControlMain_FinishClick(object sender, CancelEventArgs e)
        {
            int userin = Managers.UserManager.defaultInstance.UserInfo.UserId;
            DateTime datein = DateTime.Now;
            if (_MenuOrder.MenuOrderId == -1)
                _MenuOrder.MenuOrderId = (int)menuOrderTableAdapter.NewId();

            _MenuOrder.userin = userin;
            _MenuOrder.datein = datein;
            foreach (DataSources.dsNU.MenuOrderContainRow row in dsNU.MenuOrderContain)
            {
                if (row.RowState == DataRowState.Deleted || row.RowState == DataRowState.Unchanged)
                    continue;
                if (row.MenuOrderId == -1)
                    row.MenuOrderId = _MenuOrder.MenuOrderId;
                row.userin = userin;
                row.datetin = datein;
                //row.EndEdit();
                //menuOrderContainTableAdapter.Update(row);
            }
            _MenuOrder.EndEdit();
            try
            {
                menuOrderTableAdapter.Update(dsNU.MenuOrder);
                //menuOrderContainBindingSource.EndEdit();
                menuOrderContainTableAdapter.Update(dsNU.MenuOrderContain);
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            catch (Exception ex)
            {
                msgDlg.Show(ex.Message, msgDlg.msgButtons.Close);
            }
        }
        #endregion

    }
}