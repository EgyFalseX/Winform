
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;

namespace Members
{
    public partial class ReceiptsFrm : XtraForm
    {
        bool _Insert, _Update, _Delete;
        
        #region -   Functions   -
        public ReceiptsFrm()
        {
            InitializeComponent();
        }
        private void ActiveKeyDownEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyData != Keys.F5 && e.KeyData != Keys.F6 && e.KeyData != Keys.F10 && e.KeyData != Keys.F8)
                return;
            switch (e.KeyData)
            {
                case Keys.F1:
                    break;
                case Keys.F5:
                    btnNew_Click(btnNew, new EventArgs());
                    break;
                case Keys.F6:
                    repositoryItemButtonEditSave_ButtonClick(repositoryItemButtonEditSave, new DevExpress.XtraEditors.Controls.ButtonPressedEventArgs(new DevExpress.XtraEditors.Controls.EditorButton()));
                    break;
                case Keys.F8:
                    repositoryItemButtonEditDel_ButtonClick(repositoryItemButtonEditDel, new DevExpress.XtraEditors.Controls.ButtonPressedEventArgs(new DevExpress.XtraEditors.Controls.EditorButton()));
                    break;
                case Keys.F10:
                    repositoryItemButtonEditSave_ButtonClick(repositoryItemButtonEditSave, new DevExpress.XtraEditors.Controls.ButtonPressedEventArgs(new DevExpress.XtraEditors.Controls.EditorButton()));
                    break;
                default:
                    break;
            }
        }
        private void ActivePriv()
        {
            bool Selecting = false, Inserting = false, Updateing = false, Deleting = false;
            SQLProvider.GetFormPriv(this.Name, ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
            gridControlData.Visible = Selecting;

            btnNew.Visible = Inserting;
            repositoryItemButtonEditSave.Buttons[0].Visible = Updateing;
            repositoryItemButtonEditDel.Buttons[0].Visible = Deleting;

            _Insert = Inserting; _Update = Updateing; _Delete = Deleting;
        }
        #endregion
        #region - Event Handlers -
        private void FormFrm_Load(object sender, EventArgs e)
        {
            ActivePriv();

            // TODO: This line of code loads data into the 'teachersUnionDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.dsTeachersUnion.Users);
            // TODO: This line of code loads data into the 'teachersUnionDataSet.CDSyndicate' table. You can move, or remove it, as needed.
            this.cDSyndicateTableAdapter.Fill(this.dsTeachersUnion.CDSyndicate);
            // TODO: This line of code loads data into the 'teachersUnionDataSet.Receipts' table. You can move, or remove it, as needed.
            this.receiptsTableAdapter.Fill(this.dsTeachersUnion.Receipts);
        }
        private void gridViewData_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            DataRowView DRV = (DataRowView)e.Row;
            //Fellowship.DataSources.DSFellowship.TBLSheekWaredRow row = (Fellowship.DataSources.DSFellowship.TBLSheekWaredRow)DRV.Row;

            if (e.ErrorText.Contains("SyndicateId"))
            {
                e.ErrorText = "من فضلك بجب ادخال الفرعيه";
                return;
            }
            if (e.ErrorText.Contains("autoID"))
            {
                //e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
                DRV["autoID"] = "-1";
                return;
            }

        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView GV = (GridView)gridControlData.MainView;
            DataSources.dsTeachersUnion.ReceiptsRow row = (DataSources.dsTeachersUnion.ReceiptsRow)GV.GetFocusedDataRow();
            Update(row, false);
            
        }
        private void repositoryItemButtonEditDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView GV = (GridView)gridControlData.MainView;
            DataSources.dsTeachersUnion.ReceiptsRow row = (DataSources.dsTeachersUnion.ReceiptsRow)GV.GetFocusedDataRow();

            if (row.RowState == DataRowState.Detached)
                return;

            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            try
            {
                receiptsTableAdapter.Delete(row.ReceiptNo);
                gridViewData.DeleteRow(GV.FocusedRowHandle);
                
                Program.ShowMsg("تم الحذف", false, this);
                Program.Logger.LogThis("تم الحذف", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (Exception ex)
            {
                Program.ShowMsg(Misc.Misc.ExceptionMessage(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, ex, null, this);
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            DataSources.dsTeachersUnion.ReceiptsRow row = dsTeachersUnion.Receipts.NewReceiptsRow();
            Update(row, false);
        }
        private void Update(DataSources.dsTeachersUnion.ReceiptsRow row, bool DetailsTabFocus)
        {
            ReceiptsWFrm frm;
            if (DetailsTabFocus)
                frm = new ReceiptsWFrm(row, _Insert, _Update, _Delete, true);
            else
                frm = new ReceiptsWFrm(row, _Insert, _Update, _Delete, false);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                return;

            try
            {
                if (row.RowState == DataRowState.Detached)
                {
                    dsTeachersUnion.Receipts.AddReceiptsRow(row);
                    receiptsBindingSource.EndEdit();
                    receiptsTableAdapter.Update(row);
                    dsTeachersUnion.Receipts.AcceptChanges();
                    row.SetModified();
                    Update(row, true);
                }
                else
                {
                    receiptsBindingSource.EndEdit();
                    receiptsTableAdapter.Update(row);
                    dsTeachersUnion.Receipts.AcceptChanges();
                    Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
                }
             
            }
            catch (Exception ex)
            {
                Program.ShowMsg(Misc.Misc.ExceptionMessage(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, ex, null, this);
            }
        }
        #endregion

    }
}