using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System.IO;

namespace Members.Forms.Data
{
    public partial class TBLAksatDetailesFrm : DevExpress.XtraEditors.XtraForm
    {

        DataSources.dsTeachersUnion.TBLAksatRow _row;
        public TBLAksatDetailesFrm(DataSources.dsTeachersUnion.TBLAksatRow row)
        {
            InitializeComponent();
            _row = row;
        }
        private void ActivePriv()
        {
            return;//ActivePrivReady
            bool Selecting = false, Inserting = false, Updateing = false, Deleting = false;
            SQLProvider.GetFormPriv(this.Name, ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
            gridControlData.Visible = Selecting;
            //LUEHafza.Visible = Selecting;
            //repositoryItemButtonEditEdit.Buttons[0].Visible = Updateing;
        }
        private void TBLHafzawebFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsTeachersUnion.TBLAksatDetailes' table. You can move, or remove it, as needed.
            this.tBLAksatDetailesTableAdapter.FillByMemberId(this.dsTeachersUnion.TBLAksatDetailes, _row.MemberId);
            ActivePriv();
        }
        private void gridViewData_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            GridView GV = (GridView)gridControlData.MainView;
            DataSources.dsTeachersUnion.TBLAksatDetailesRow row = (DataSources.dsTeachersUnion.TBLAksatDetailesRow)GV.GetDataRow(e.RowHandle);
            row.MemberId = _row.MemberId;
        }
        private void gridViewData_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            e.Valid = true;
        }
        private void gridControlData_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView GV = (GridView)gridControlData.MainView;
            DataSources.dsTeachersUnion.TBLAksatDetailesRow row = (DataSources.dsTeachersUnion.TBLAksatDetailesRow)GV.GetFocusedDataRow();
            try
            {
                row.datein = SQLProvider.GetServerDateTime();
                row.userin = Program.UserInfo.UserId;
                tBLAksatDetailesBindingSource.EndEdit();
                tBLAksatDetailesTableAdapter.Update(row);
                dsTeachersUnion.TBLAksat.AcceptChanges();
                Program.ShowMsg("تم الحفظ", false, this);
                Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (Exception ex)
            {
                Program.ShowMsg(Misc.Misc.ExceptionMessage(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, ex, null, this);
            }
        }
        private void repositoryItemButtonEditDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            
            GridView GV = (GridView)gridControlData.MainView;
            DataSources.dsTeachersUnion.TBLAksatDetailesRow row = (DataSources.dsTeachersUnion.TBLAksatDetailesRow)GV.GetFocusedDataRow();
            try
            {
                if (row.RowState == DataRowState.Detached)
                    return;
                if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                    return;
                tBLAksatDetailesBindingSource.EndEdit();
                tBLAksatDetailesTableAdapter.Delete(row.MemberId, row.datesadad);
                dsTeachersUnion.TBLAksatDetailes.AcceptChanges();
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

    }
}
