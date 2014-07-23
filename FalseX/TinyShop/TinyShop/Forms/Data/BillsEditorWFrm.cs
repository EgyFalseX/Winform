using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System.Runtime.Serialization;
using TinyShop.dbTools;

namespace TinyShop.Forms.Data
{
    public partial class BillsEditorWFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.dsTinyData.BillsRow _row;

        public BillsEditorWFrm(DataSources.dsTinyData.BillsRow row)
        {
            InitializeComponent();
            _row = row;

            // TODO: This line of code loads data into the 'dsTinyData.BillTypes' table. You can move, or remove it, as needed.
            this.billTypesTableAdapter.Fill(this.dsTinyData.BillTypes);

            if (_row.BillTypeID == 0)
                LUEBillTypeID.Enabled = true;
            else
            {
                LUEBillTypeID.EditValue = _row.BillTypeID;
                LUEBillTypeID.Enabled = false;
                LUEBillTypeID_EditValueChanged(LUEBillTypeID, new EventArgs());
            }
        }
        private void LoadBinding()
        {
            if (!_row.IsNull("BillID"))
                this.billDetailsTableAdapter.FillByBillID(this.dsTinyData.BillDetails, _row.BillID);
            else
                _row.BillID = -1;
            if (!_row.IsNull("BillTypeID"))
                LUEBillTypeID.EditValue = _row.BillTypeID;
            if (!_row.IsNull("BillNo"))
                tbBillNo.EditValue = _row.BillNo;
            if (!_row.IsNull("BillName"))
                tbBillName.EditValue = _row.BillName;
            if (!_row.IsNull("BillDate"))
                deBillDate.EditValue = _row.BillDate;
            if (!_row.IsNull("PersonID"))
                luePersonID.EditValue = _row.PersonID;
            if (!_row.IsNull("Info"))
                tbInfo.EditValue = _row.Info;
        }
        private bool ToStorage()
        {
            bool ReturnMe = false;
            switch (_row.BillTypeID)
            {
                	case (int)misc.BillType.Tawreed:
                        ReturnMe =  true;
                		break;
                    case (int)misc.BillType.Baye3:
                        ReturnMe =  false;
                		break;
                    case (int)misc.BillType.Mortaga3:
                        ReturnMe =  true;
                		break;
                    case (int)misc.BillType.Hawaleek:
                        ReturnMe = false;
                		break;
            }
            return ReturnMe;
        }
        private void ProductsEditorWFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsTinyData.BillProductsInfo' table. You can move, or remove it, as needed.
            this.billProductsInfoTableAdapter.Fill(this.dsTinyData.BillProductsInfo);
            LoadBinding();
            DevExpress.XtraGrid.Localization.GridLocalizer.Active = new Misc.misc.MyLocalizer();
            luePersonID_EditValueChanged(luePersonID, new EventArgs());
            xtraTabControl1.Focus(); TBBarcode.Focus();
        }
        private void LUEBillTypeID_EditValueChanged(object sender, EventArgs e)
        {
            if (LUEBillTypeID.EditValue == null)
                return;

            switch ((int)LUEBillTypeID.EditValue)
            {
                case (int)misc.BillType.Baye3:
                    luePersonID.Properties.DisplayMember = "CustomerName";
                    luePersonID.Properties.ValueMember = "CustomerID";
                    luePersonID.Properties.Columns.Clear();
                    luePersonID.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerName", "الاسم") { Alignment = DevExpress.Utils.HorzAlignment.Center });
                    luePersonID.Properties.DataSource = customersBindingSource;
                    // TODO: This line of code loads data into the 'dsTinyData.Customers' table. You can move, or remove it, as needed.
                    this.customersTableAdapter.Fill(this.dsTinyData.Customers);
                    break;
                case (int)misc.BillType.Hawaleek:
                    break;
                case (int)misc.BillType.Mortaga3:
                    break;
                case (int)misc.BillType.Tawreed:
                    luePersonID.Properties.DisplayMember = "supplierName";
                    luePersonID.Properties.ValueMember = "SupplierID";
                    luePersonID.Properties.Columns.Clear();
                    luePersonID.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("supplierName", "الاسم") { Alignment = DevExpress.Utils.HorzAlignment.Center });
                    luePersonID.Properties.DataSource = suppliersBindingSource;
                    // TODO: This line of code loads data into the 'dsTinyData.Suppliers' table. You can move, or remove it, as needed.
                    this.suppliersTableAdapter.Fill(this.dsTinyData.Suppliers);
                    break;
                default:
                    break;
            }
        }
        private void tmrNewRow_Tick(object sender, EventArgs e)
        {
            gridViewData.AddNewRow();
            tmrNewRow.Stop();
        }
        private void gridViewData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                if (gridViewData.FocusedColumn.FieldName == "UnitPrice")
                {
                    e.Handled = true;
                    gridViewData.CloseEditor();
                    gridViewData.UpdateCurrentRow();
                    tmrNewRow.Start();
                }
            }
        }
        private void luePersonID_EditValueChanged(object sender, EventArgs e)
        {
            if (luePersonID.EditValue != null)
                tbBillName.Text = luePersonID.Text;
        }
        private void repositoryItemGridLookUpEditProductID_EditValueChanged(object sender, EventArgs e)
        {
            GridLookUpEdit editor = (GridLookUpEdit)sender;
            if (editor.EditValue == null)
                return;

            DataSources.dsTinyData.BillProductsInfoRow cellRow = (DataSources.dsTinyData.BillProductsInfoRow)((DataRowView)editor.Properties.GetRowByKeyValue(editor.EditValue)).Row;
            GridView GV = (GridView)gridControlData.MainView;
            DataSources.dsTinyData.BillDetailsRow row = (DataSources.dsTinyData.BillDetailsRow)GV.GetFocusedDataRow();
            if (row.IsQuantityNull())
                row.Quantity = 1;
            switch (_row.BillTypeID)
            {
                case (int)misc.BillType.Tawreed:
                    row.UnitPrice = cellRow.BuyPrice;
                    break;
                case (int)misc.BillType.Baye3:
                    row.UnitPrice = cellRow.SellPrice;
                    break;
                case (int)misc.BillType.Mortaga3:
                    row.UnitPrice = cellRow.SellPrice;
                    break;
                case (int)misc.BillType.Hawaleek:
                    row.UnitPrice = cellRow.BuyPrice;
                    break;
            }
        }
        private void gridViewData_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            DataSources.dsTinyData.BillDetailsRow row = (DataSources.dsTinyData.BillDetailsRow)((DataRowView)e.Row).Row;
            DataSources.dsTinyData.BillProductsInfoRow cellRow = (DataSources.dsTinyData.BillProductsInfoRow)dsTinyData.BillProductsInfo.Rows[repositoryItemGridLookUpEditProductID.GetIndexByKeyValue(row.ProductID)];
            if (row.Quantity > cellRow.ItemCount && ToStorage() == false)
            {
                e.ErrorText = Properties.Resources.ProductInsufficient;
                e.Valid = false;
                return;
            }
            
            for (int i = 0; i < dsTinyData.BillDetails.Rows.Count; i++)
            {
                if (gridViewData.GetDataSourceRowIndex(e.RowHandle) == i)
                    continue;
                DataSources.dsTinyData.BillDetailsRow item = (DataSources.dsTinyData.BillDetailsRow)dsTinyData.BillDetails.Rows[i];
                if (item.RowState == DataRowState.Deleted)
                    continue;
                if (item.ProductID == row.ProductID)
                {
                    e.ErrorText = Properties.Resources.BillItemDuplicate;
                    e.Valid = false;
                    return;
                }
            }
        }
        private void LUEItemName_EditValueChanged(object sender, EventArgs e)
        {
            if (LUEItemName.EditValue == null)
            {
                return;
            }
            DataSources.dsTinyData.BillProductsInfoRow row = (DataSources.dsTinyData.BillProductsInfoRow)((DataRowView)LUEItemName.GetSelectedDataRow()).Row;
            tbQuiName.EditValue = 1;
            switch (_row.BillTypeID)
            {
                case (int)misc.BillType.Tawreed:
                    tbPriceName.EditValue = row.BuyPrice;
                    break;
                case (int)misc.BillType.Baye3:
                    tbPriceName.EditValue = row.SellPrice;
                    break;
                case (int)misc.BillType.Mortaga3:
                    tbPriceName.EditValue = row.SellPrice;
                    break;
                case (int)misc.BillType.Hawaleek:
                    tbPriceName.EditValue = row.BuyPrice;
                    break;
            }
        }
        private void TBBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (TBBarcode.EditValue == null)
                return;
            if (e.KeyCode != Keys.Enter)
                return;
            try
            {
                DataSources.dsTinyData ds = new DataSources.dsTinyData();
                billProductsInfoTableAdapter.FillByProductNumber(ds.BillProductsInfo, TBBarcode.EditValue.ToString());
                if (ds.BillProductsInfo.Count == 0)
                {
                    tbMsg.EditValue = Properties.Resources.ProductNotFound;
                    TBBarcode.Text = string.Empty;
                    TBBarcode.Focus();
                    return;
                }
                DataSources.dsTinyData.BillProductsInfoRow row = (DataSources.dsTinyData.BillProductsInfoRow)ds.BillProductsInfo.Rows[0];
                tbQuiNumber.EditValue = 1;
                switch (_row.BillTypeID)
                {
                    case (int)misc.BillType.Tawreed:
                    case (int)misc.BillType.Hawaleek:
                        tbPriceNumber.EditValue = row.BuyPrice;
                        break;
                    case (int)misc.BillType.Baye3:
                    case (int)misc.BillType.Mortaga3:
                        tbPriceNumber.EditValue = row.SellPrice;
                        break;
                }
                btnAddProductNumber_Click(btnAddProductNumber, EventArgs.Empty);
            }
            catch { }

            TBBarcode.Text = string.Empty;
            TBBarcode.Focus();
        }
        
        private void btnAddProductName_Click(object sender, EventArgs e)
        {
            tbMsg.EditValue = null;
            if (LUEItemName.EditValue == null || tbQuiName.EditValue == null || tbPriceName.EditValue == null)//check if informations aren't complate
            {
                tbMsg.EditValue = Properties.Resources.BillItemInfoNotComplate;
                return;
            }

            DataSources.dsTinyData.BillDetailsRow NewItem = dsTinyData.BillDetails.NewBillDetailsRow();
            NewItem.ProductID = Convert.ToInt32(LUEItemName.EditValue);
            NewItem.UnitPrice = Convert.ToDouble(tbPriceName.EditValue);
            NewItem.Quantity = Convert.ToInt32(tbQuiName.EditValue);

            //DataSources.dsTinyData.BillProductsInfoRow row = (DataSources.dsTinyData.BillProductsInfoRow)((DataRowView)LUEItemName.GetSelectedDataRow()).Row;

            if (Convert.ToInt32(tbQuiName.EditValue) > NewItem.BillProductsInfoRow.ItemCount && ToStorage() == false)//check if item count avilable
            {
                tbMsg.EditValue = Properties.Resources.ProductInsufficient;
                return;
            }
            for (int i = 0; i < dsTinyData.BillDetails.Rows.Count; i++)//check if item already exists
            {
                DataSources.dsTinyData.BillDetailsRow item = (DataSources.dsTinyData.BillDetailsRow)dsTinyData.BillDetails.Rows[i];
                if (item.RowState == DataRowState.Deleted)
                    continue;
                if (item.ProductID == NewItem.ProductID)
                {
                    tbMsg.EditValue = Properties.Resources.BillItemDuplicate;
                    return;
                }
            }

            dsTinyData.BillDetails.AddBillDetailsRow(NewItem);
            LUEItemName.Focus();
        }
        private void btnAddProductNumber_Click(object sender, EventArgs e)
        {
            tbMsg.EditValue = null;
            if (TBBarcode.EditValue == null || tbQuiNumber.EditValue == null || tbPriceNumber.EditValue == null)//check if informations aren't complate
            {
                tbMsg.EditValue = Properties.Resources.BillItemInfoNotComplate;
                return;
            }

            DataSources.dsTinyData ds = new DataSources.dsTinyData();
            billProductsInfoTableAdapter.FillByProductNumber(ds.BillProductsInfo, TBBarcode.EditValue.ToString());
            DataSources.dsTinyData.BillProductsInfoRow row = (DataSources.dsTinyData.BillProductsInfoRow)ds.BillProductsInfo.Rows[0];

            DataSources.dsTinyData.BillDetailsRow NewItem = dsTinyData.BillDetails.NewBillDetailsRow();
            NewItem.ProductID = row.ProductID;
            NewItem.UnitPrice = Convert.ToDouble(tbPriceNumber.EditValue);
            NewItem.Quantity = Convert.ToInt32(tbQuiNumber.EditValue);

            if (Convert.ToInt32(tbQuiNumber.EditValue) > NewItem.BillProductsInfoRow.ItemCount && ToStorage() == false)//check if item count avilable
            {
                tbMsg.EditValue = Properties.Resources.ProductInsufficient;
                return;
            }
            for (int i = 0; i < dsTinyData.BillDetails.Rows.Count; i++)//check if item already exists
            {
                DataSources.dsTinyData.BillDetailsRow item = (DataSources.dsTinyData.BillDetailsRow)dsTinyData.BillDetails.Rows[i];
                if (item.RowState == DataRowState.Deleted)
                    continue;
                if (item.ProductID == NewItem.ProductID)
                {
                    tbMsg.EditValue = Properties.Resources.BillItemDuplicate;
                    return;
                }
            }
            dsTinyData.BillDetails.AddBillDetailsRow(NewItem);
            TBBarcode.Focus();
        }
        private void gridViewData_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
            return;
            // Initialization 
            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Start)
                e.TotalValue = 0;
            // Finalization 
            if (e.SummaryProcess == DevExpress.Data.CustomSummaryProcess.Finalize) 
            {
                double BillTotalPrice = 0;
                foreach (DataSources.dsTinyData.BillDetailsRow item in dsTinyData.BillDetails.Rows)
                {
                    if (item.RowState == DataRowState.Deleted)
                        continue;
                    if (item.IsUnitPriceNull() || item.IsQuantityNull())
                        continue;
                    BillTotalPrice += item.UnitPrice * item.Quantity;
                }
                e.TotalValue = BillTotalPrice;
            }
        }
        private void repositoryItemButtonEditDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            tbMsg.EditValue = null;
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            GridView GV = (GridView)gridControlData.MainView;
            TinyShop.DataSources.dsTinyData.BillDetailsRow row = (TinyShop.DataSources.dsTinyData.BillDetailsRow)GV.GetFocusedDataRow();
            gridViewData.DeleteRow(GV.FocusedRowHandle);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (LUEBillTypeID.EditValue != null)
                _row.BillTypeID = Convert.ToInt32(LUEBillTypeID.EditValue);
            if (tbBillNo.EditValue != null)
                _row.BillNo = Convert.ToString(tbBillNo.EditValue);
            if (tbBillName.EditValue != null)
                _row.BillName = Convert.ToString(tbBillName.EditValue);
            if (deBillDate.EditValue != null)
                _row.BillDate = Convert.ToDateTime(deBillDate.EditValue);
            if (luePersonID.EditValue != null)
                _row.PersonID = Convert.ToInt32(luePersonID.EditValue);
            if (tbInfo.EditValue != null)
                _row.Info = Convert.ToString(tbInfo.EditValue);
            _row.UserID = Program.UserData.UserID;

            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
        
    }
}