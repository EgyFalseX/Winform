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
using System.Data.OleDb;
using GM.Managers;

namespace GM.Forms.Code
{
    public partial class BillEditorWFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.dsGM.BillRow _row = null;
        public BillEditorWFrm()
        {
            InitializeComponent();

            _row = dsGM.Bill.NewBillRow();
            DateTime NOW = DataManager.defaultInstance.ServerDatetime;
            _row.BillId = 0; _row.EmployeeId = 0; _row.PlumberId = 0; _row.TraderId = 0; _row.CardValue = 0; _row.BillDate = NOW;
            _row.userin = UserManager.defaultInstance.UserInfo.UserId; _row.datein = NOW;
            dsGM.Bill.AddBillRow(_row);
        }
        public BillEditorWFrm(int BillId)
        {
            InitializeComponent();
            //DataSources.dsGM.BillRow
            //_row = billTableAdapter.GetDataByBillId(BillId)[0];
            billTableAdapter.FillByBillId(dsGM.Bill, BillId);
            _row = dsGM.Bill[0];
            DateTime NOW = DataManager.defaultInstance.ServerDatetime;
            _row.userin = UserManager.defaultInstance.UserInfo.UserId; _row.datein = NOW;
        }
        private void LoadData()
        {
            // TODO: This line of code loads data into the 'dsGM.Item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.dsGM.Item);
            // TODO: This line of code loads data into the 'dsGM.Trader' table. You can move, or remove it, as needed.
            this.traderTableAdapter.Fill(this.dsGM.Trader);
            // TODO: This line of code loads data into the 'dsGM.Plumber' table. You can move, or remove it, as needed.
            this.plumberTableAdapter.Fill(this.dsGM.Plumber);
            // TODO: This line of code loads data into the 'dsGM.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.dsGM.Employee);

            BillIdTextEdit.DataBindings.Add(new Binding("EditValue", _row, "BillId", true));
            BillEndIdTextEdit.DataBindings.Add(new Binding("EditValue", _row, "BillEndId", true));
            BillDateDateEdit.DataBindings.Add(new Binding("EditValue", _row, "BillDate", true));
            EmployeeIdTextEdit.DataBindings.Add(new Binding("EditValue", _row, "EmployeeId", true));
            guaranteeIdSpinEdit.DataBindings.Add(new Binding("EditValue", _row, "guaranteeId", true));
            PlumberIdTextEdit.DataBindings.Add(new Binding("EditValue", _row, "PlumberId", true));
            TraderIdTextEdit.DataBindings.Add(new Binding("EditValue", _row, "TraderId", true));
            OwnerNameTextEdit.DataBindings.Add(new Binding("EditValue", _row, "OwnerName", true));
            OwnerAddressTextEdit.DataBindings.Add(new Binding("EditValue", _row, "OwnerAddress", true));
            OwnerPhoneTextEdit.DataBindings.Add(new Binding("EditValue", _row, "OwnerPhone", true));
            CardValueTextEdit.DataBindings.Add(new Binding("EditValue", _row, "CardValue", true));
            NotesTextEdit.DataBindings.Add(new Binding("EditValue", _row, "Notes", true));

            billDetailsTableAdapter.FillByBillId(dsGM.BillDetails, _row.BillId);
        }
        private void Frm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void BillEditorWFrm_Shown(object sender, EventArgs e)
        {
            BillIdTextEdit.Focus();
            EmployeeIdTextEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            PlumberIdTextEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            TraderIdTextEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
        }
        private void repositoryItemTextEditQuin_EditValueChanged(object sender, EventArgs e)
        {
            TextEdit te = (TextEdit)sender;
            DataSources.dsGM.BillDetailsRow row = (DataSources.dsGM.BillDetailsRow)((DataRowView)gridViewMain.GetRow(gridViewMain.FocusedRowHandle)).Row;
            if (row.IsItemIdNull())
            {
                row.Point = 0;
                return;
            }
            int Quin = Convert.ToInt32(te.EditValue);
            int ItemPoint = (int)itemTableAdapter.GetItemPoint(row.ItemId);
            row.Point = Quin * ItemPoint; 
        }
        private void repositoryItemGridLookUpEditItemId_EditValueChanged(object sender, EventArgs e)
        {
            GridLookUpEdit lue = (GridLookUpEdit)sender;
            DataSources.dsGM.BillDetailsRow row = (DataSources.dsGM.BillDetailsRow)((DataRowView)gridViewMain.GetRow(gridViewMain.FocusedRowHandle)).Row;
            if (row.IsItemIdNull())
            { return; }
            string str = itemTableAdapter.GetItemName(row.ItemId);
            gridViewMain.SetRowCellValue(gridViewMain.FocusedRowHandle, gcItemName, str);
        }
        private void gridViewMain_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataSources.dsGM.BillDetailsRow row = (DataSources.dsGM.BillDetailsRow)((DataRowView)gridViewMain.GetRow(e.RowHandle)).Row;
            row.BillId = _row.BillId;
            row.BillDetailsId = new Random().Next(999);
        }
        private void wizardControl1_FinishClick(object sender, CancelEventArgs e)
        {
            if (!ValidateAll())
            {
                e.Cancel = true;
                return;
            }
            try
            {
                int BillDetailsId = (int)billDetailsTableAdapter.NewId();
                _row.EndEdit();
                foreach (DataSources.dsGM.BillDetailsRow rowContain in dsGM.BillDetails)
                {
                    if (rowContain.RowState == DataRowState.Detached || rowContain.RowState == DataRowState.Added)
                        rowContain.BillDetailsId = BillDetailsId;
                    rowContain.BillId = _row.BillId;
                    rowContain.userin = _row.userin; rowContain.datein = _row.datein;
                    rowContain.EndEdit();
                    BillDetailsId++;
                }

                billTableAdapter.Update(_row);
                billDetailsTableAdapter.Update(dsGM.BillDetails);
            }
            catch (OleDbException ex)
            {
                msgDlg.Show(ex.Message, msgDlg.msgButtons.Close);
                e.Cancel = true;
            }
        }
        private void repositoryItemButtonEditDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            gridViewMain.DeleteRow(gridViewMain.FocusedRowHandle);
        }
        private void wizardControlMain_CancelClick(object sender, CancelEventArgs e)
        {
            ceAutoOpen.Checked = false;
        }
        private void gridViewMain_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            DataSources.dsGM.BillDetailsRow row = (DataSources.dsGM.BillDetailsRow)((DataRowView)e.Row).Row;
            if (row.ItemRow != null)
            {
                e.Value = row.ItemRow.ItemName;
            }
        }
        bool ValidateAll()
        {
            if (BillIdTextEdit.EditValue.ToString() != string.Empty && BillEndIdTextEdit.EditValue.ToString() != string.Empty)
            {
                if (Convert.ToInt32(BillIdTextEdit.EditValue) >= Convert.ToInt32(BillEndIdTextEdit.EditValue))
                {
                    msgDlg.Show("[Bill End Id] is Wrong", msgDlg.msgButtons.Close);
                    return false;
                }
            }

            return true;
        }

    }
}