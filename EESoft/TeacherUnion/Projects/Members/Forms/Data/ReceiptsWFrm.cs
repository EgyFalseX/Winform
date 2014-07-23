using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace Members
{
    public partial class ReceiptsWFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.dsTeachersUnion.ReceiptsRow _row;
        bool _Insert, _Update, _Delete;
        public ReceiptsWFrm()
        {
            InitializeComponent();
        }
        public ReceiptsWFrm(DataSources.dsTeachersUnion.ReceiptsRow row, bool insert, bool update, bool delete, bool FocusOnDetails = false)
        {
            InitializeComponent();
            _row = row;
            _Insert = insert;
            _Update = update;
            _Delete = delete;
            if (FocusOnDetails)
                xtraTabControl1.SelectedTabPage = xtraTabPageDetails;
        }
        private void ActivePriv()
        {
            if (_Insert)
                gridViewDetails.OptionsView.NewItemRowPosition = NewItemRowPosition.Top;
            else
                gridViewDetails.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            repositoryItemButtonEditSave.Buttons[0].Visible = _Update;
            repositoryItemButtonEditDelete.Buttons[0].Visible = _Delete;
        }
        private void LoadBinding()
        {
            if (!_row.IsNull("SyndicateId"))
                lueSyndicateId.EditValue = _row.SyndicateId;
            if (!_row.IsNull("ReceiptNo"))
                tbReceiptNo.EditValue = _row.ReceiptNo;
            if (!_row.IsNull("CardType"))
                ceCardType.EditValue = _row.CardType;
            if (!_row.IsNull("ReceiptName"))
                tbReceiptName.EditValue = _row.ReceiptName;
            if (!_row.IsNull("ReceiptAmount"))
                tbReceiptAmount.EditValue = _row.ReceiptAmount;
            if (!_row.IsNull("ReceiptDate"))
                deReceiptDate.EditValue = _row.ReceiptDate;
            if (!_row.IsNull("CardsCount"))
                tbCardsCount.EditValue = _row.CardsCount;

            EditValueChanging();
        }
        private void EditValueChanging()
        {
            lueSyndicateId.EditValueChanging += Control_EditValueChanging;
            tbReceiptNo.EditValueChanging += Control_EditValueChanging;
            tbReceiptAmount.EditValueChanging += Control_EditValueChanging;
            deReceiptDate.EditValueChanging += Control_EditValueChanging;
            tbReceiptName.EditValueChanging += Control_EditValueChanging;
            ceCardType.EditValueChanging += Control_EditValueChanging;

        }
        void Control_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (e.NewValue != e.OldValue && _row.RowState == DataRowState.Unchanged)
                _row.SetModified();
        }
        private void FormWFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsTeachersUnion.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.dsTeachersUnion.Users);
            ActivePriv();
            // TODO: This line of code loads data into the 'dsTeachersUnion.CDWorkType' table. You can move, or remove it, as needed.
            this.cDWorkTypeTableAdapter.Fill(this.dsTeachersUnion.CDWorkType);

            if (_row.RowState != DataRowState.Detached)
                this.tBLMazroofTableAdapter.FillByReceiptNo(this.dsTeachersUnion.TBLMazroof, _row.ReceiptNo);     
            else
                xtraTabPageDetails.PageVisible = false;
            cDSyndicateTableAdapter.Fill(dsTeachersUnion.CDSyndicate);
            LoadBinding();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_row.RowState != DataRowState.Modified && _row.RowState != DataRowState.Detached)
            {
                btnClose_Click(btnClose, EventArgs.Empty);
                return;
            }

            DialogResult = System.Windows.Forms.DialogResult.OK;

            if (lueSyndicateId.EditValue != null)
                _row.SyndicateId = Convert.ToInt32(lueSyndicateId.EditValue);
            if (tbReceiptNo.EditValue != null)
                _row.ReceiptNo = Convert.ToInt32(tbReceiptNo.EditValue);
            if (ceCardType.EditValue != null)
                _row.CardType = ceCardType.Checked;
            if (tbReceiptName.EditValue != null)
                _row.ReceiptName = tbReceiptName.EditValue.ToString();
            if (tbReceiptAmount.EditValue != null)
                _row.ReceiptAmount = Convert.ToDouble(tbReceiptAmount.EditValue);
            if (deReceiptDate.EditValue != null)
                _row.ReceiptDate = Convert.ToDateTime(deReceiptDate.EditValue);
            if (tbCardsCount.EditValue != null)
                _row.CardsCount = Convert.ToInt32(tbCardsCount.EditValue);
            _row.userin = Program.UserInfo.UserId;
            _row.datein = (DateTime)new DataSources.dsTeachersUnionQueryTableAdapters.ServerDateTimeTableAdapter().ScalarQueryServerDateTime();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
        private void tbReceiptAmount_EditValueChanged(object sender, EventArgs e)
        {
            if (tbReceiptAmount.EditValue == null)
            {
                tbCardsCount.EditValue = 0;
                return;
            }
            if (Convert.ToDouble(tbReceiptAmount.EditValue) < 0)
                tbCardsCount.EditValue = 0;
            tbCardsCount.EditValue = CardAmount(Convert.ToDouble(tbReceiptAmount.EditValue));
        }
        private int CardAmount(double cost)
        {
            if (ceCardType.Checked)
            {
                 return Convert.ToInt32(cost / Program.NormalCardCost);
            }
            else
            {
                return Convert.ToInt32(cost / Program.FastCardCost);
            }
        }
        private void ceCardType_CheckedChanged(object sender, EventArgs e)
        {
            tbReceiptAmount_EditValueChanged(tbReceiptAmount, EventArgs.Empty);
            if (ceCardType.Checked)
                ceCardType.Text = "نوع الكارنية عادي";
            else
                ceCardType.Text = "نوع الكارنية فوري";

        }
        private void gridViewDetails_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DataSources.dsTeachersUnion.TBLMazroofRow row = (DataSources.dsTeachersUnion.TBLMazroofRow)gridViewDetails.GetDataRow(e.RowHandle);
            row.ReceiptNo = _row.ReceiptNo;
            row.userwork = Program.UserInfo.UserId;
            row.datework = (DateTime)new DataSources.dsTeachersUnionQueryTableAdapters.ServerDateTimeTableAdapter().ScalarQueryServerDateTime();
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView GV = (GridView)gridControlDetails.MainView;
            DataSources.dsTeachersUnion.TBLMazroofRow row = (DataSources.dsTeachersUnion.TBLMazroofRow)GV.GetFocusedDataRow();
            try
            {
                tBLMazroofBindingSource.EndEdit();
                tBLMazroofTableAdapter.Update(row);
                dsTeachersUnion.TBLMazroof.AcceptChanges();
                Program.ShowMsg("تم الحفظ", false, this);
                Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void repositoryItemButtonEditDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            GridView GV = (GridView)gridControlDetails.MainView;
            DataSources.dsTeachersUnion.TBLMazroofRow row = (DataSources.dsTeachersUnion.TBLMazroofRow)GV.GetFocusedDataRow();
            if (row.RowState == DataRowState.Detached)
                return;
            try
            {
                tBLMazroofTableAdapter.Delete(row.ReceiptNo, row.mazroofno, row.WorkTypeId);
                gridViewDetails.DeleteRow(GV.FocusedRowHandle);
                Program.ShowMsg("تم الحذف", false, this);
                Program.Logger.LogThis("تم الحذف", Text, FXFW.Logger.OpType.success, null, null, this);

            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        
    }
}
