using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using TinyShop.dbTools;

namespace TinyShop.Forms.Data
{
    public partial class BillsEditorFrm : DevExpress.XtraEditors.XtraForm
    {
        public int _BillTypeID { get; set; }

        public BillsEditorFrm(int BillTypeID)
        {
            InitializeComponent();
            _BillTypeID = BillTypeID;
        }
        private void TitleChanger()
        {
            switch (_BillTypeID)
            {
                case (int)misc.BillType.Tawreed:
                    Text = "فواتير المشتريات";
                    break;
                case (int)misc.BillType.Baye3:
                    Text = "فواتير المبيعات";
                    break;
                case (int)misc.BillType.Mortaga3:
                    Text = "فواتير المرتجع";
                    break;
                case (int)misc.BillType.Hawaleek:
                    Text = "فواتير الهوالك";
                    break;
            }
           
        }
        private void BillsEditorFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsTinyData.Suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.dsTinyData.Suppliers);
            // TODO: This line of code loads data into the 'dsTinyData.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.dsTinyData.Customers);
            // TODO: This line of code loads data into the 'dsTinyData.BillTypes' table. You can move, or remove it, as needed.
            this.billTypesTableAdapter.Fill(this.dsTinyData.BillTypes);

            // TODO: This line of code loads data into the 'dsTinyData.Bills' table. You can move, or remove it, as needed.
            if (_BillTypeID != 0)
                this.billsTableAdapter.FillByBillTypeID(this.dsTinyData.Bills, _BillTypeID);
            else
                this.billsTableAdapter.Fill(this.dsTinyData.Bills);
            
            TitleChanger();
        }
        private void ActiveKeyDownEvent(object sender, KeyEventArgs e)
        {
            return;

            if (e.KeyData != Keys.F5 && e.KeyData != Keys.F6 && e.KeyData != Keys.F10 && e.KeyData != Keys.F8)
                return;
            switch (e.KeyData)
            {
                case Keys.F1:
                    break;
                case Keys.F5:
                    customersBindingSource.AddNew();
                    break;
                case Keys.F6:
                    repositoryItemButtonEditEdit_ButtonClick(repositoryItemButtonEditEdit, new DevExpress.XtraEditors.Controls.ButtonPressedEventArgs(new DevExpress.XtraEditors.Controls.EditorButton()));
                    break;
                case Keys.F8:
                    repositoryItemButtonEditDel_ButtonClick(repositoryItemButtonEditDel, new DevExpress.XtraEditors.Controls.ButtonPressedEventArgs(new DevExpress.XtraEditors.Controls.EditorButton()));
                    break;
                case Keys.F10:
                    repositoryItemButtonEditEdit_ButtonClick(repositoryItemButtonEditEdit, new DevExpress.XtraEditors.Controls.ButtonPressedEventArgs(new DevExpress.XtraEditors.Controls.EditorButton()));
                    break;
                default:
                    break;
            }
        }
        private void gridViewData_CustomRowCellEdit(object sender, CustomRowCellEditEventArgs e)
        {
            if (e.Column != colPersonID)
                return;

            GridView GV = (GridView)gridControlData.MainView;
            TinyShop.DataSources.dsTinyData.BillsRow row = (TinyShop.DataSources.dsTinyData.BillsRow)GV.GetFocusedDataRow();
            if (row == null)
                return;
            switch (row.BillTypeID)
            {
                case (int)misc.BillType.Baye3:
                    e.RepositoryItem = repositoryItemGridLookUpEditPersonIDCustomer;
                    break;
                case (int)misc.BillType.Hawaleek:
                    break;
                case (int)misc.BillType.Mortaga3:
                    break;
                case (int)misc.BillType.Tawreed:
                    e.RepositoryItem = repositoryItemGridLookUpEditPersonIDSuppllier;
                    break;
                default:
                    break;
            }
        }
        private void gridViewData_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            DataRowView DRV = (DataRowView)e.Row;
            if (e.ErrorText.Contains("BillID"))
            {
                //e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
                DRV["BillID"] = "-1";
                return;
            }
        }
       
        private void repositoryItemButtonEditEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView GV = (GridView)gridControlData.MainView;
            TinyShop.DataSources.dsTinyData.BillsRow row = (TinyShop.DataSources.dsTinyData.BillsRow)GV.GetFocusedDataRow();
            Update(row);
        }
        private void repositoryItemButtonEditDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView GV = (GridView)gridControlData.MainView;
            TinyShop.DataSources.dsTinyData.BillsRow row = (TinyShop.DataSources.dsTinyData.BillsRow)GV.GetFocusedDataRow();

            if (row.RowState == DataRowState.Detached)
                return;

            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            try
            {
                billsTableAdapter.Delete(row.BillID);
                gridViewData.DeleteRow(GV.FocusedRowHandle);

                Program.ShowMsg("تم الحفظ", false, this);
            }
            catch (Exception ex)
            {
                Program.ShowMsg(ex.Message, true, this);
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            TinyShop.DataSources.dsTinyData.BillsRow row = dsTinyData.Bills.NewBillsRow();
            row.BillNo = billsTableAdapter.ScalarQueryNewBillNo().ToString();
            Update(row);
        }
        private void Update(DataSources.dsTinyData.BillsRow row)
        {
            if (row.RowState == DataRowState.Detached)
                row.BillTypeID = _BillTypeID;

            BillsEditorWFrm frm = new BillsEditorWFrm(row);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                    return;

            try
            {
                if (row.RowState == DataRowState.Detached)
                {
                    row.BillID = Convert.ToInt32(misc.GetNewID(misc.DBTablesNames.Bills));
                    dsTinyData.Bills.AddBillsRow(row);
                }
                billsBindingSource.EndEdit();
                billsTableAdapter.Update(row);
                dsTinyData.Bills.AcceptChanges();

                for (int i = 0; i < frm.dsTinyData.BillDetails.Rows.Count; i++)
                {
                    DataSources.dsTinyData.BillDetailsRow R = (DataSources.dsTinyData.BillDetailsRow)frm.dsTinyData.BillDetails.Rows[i];
                    if (R.RowState == DataRowState.Deleted)
                        continue;
                    R.BillID = row.BillID;
                }
                frm.billDetailsBindingSource.EndEdit();
                frm.billDetailsTableAdapter.Update(frm.dsTinyData.BillDetails);
                frm.dsTinyData.BillDetails.AcceptChanges();

                Program.ShowMsg("تم الحفظ", false, this);
            }
            catch (Exception ex)
            {
                Program.ShowMsg(ex.Message, true, this);
            }
        }

    }
}                                                                  