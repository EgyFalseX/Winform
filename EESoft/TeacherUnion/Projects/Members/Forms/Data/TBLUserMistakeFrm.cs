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
    public partial class TBLUserMistakeFrm : DevExpress.XtraEditors.XtraForm
    {

        public TBLUserMistakeFrm()
        {
            InitializeComponent();
        }
        private void ActivePriv()
        {
            return;//ActivePrivReady
            bool Selecting = false, Inserting = false, Updateing = false, Deleting = false;
            SQLProvider.GetFormPriv(this.Name, ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
            gridControlData.Visible = Selecting;
            repositoryItemButtonEditSave.Buttons[0].Visible = Updateing;
            repositoryItemButtonEditDelete.Buttons[0].Visible = Deleting;
        }
        private void TBLHafzawebFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsTeachersUnion.CDWorkType' table. You can move, or remove it, as needed.
            this.cDWorkTypeTableAdapter.Fill(this.dsTeachersUnion.CDWorkType);
            // TODO: This line of code loads data into the 'dsTeachersUnion.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.dsTeachersUnion.Users);
            // TODO: This line of code loads data into the 'dsTeachersUnion.TBLUserMistake' table. You can move, or remove it, as needed.
            this.tBLUserMistakeTableAdapter.Fill(this.dsTeachersUnion.TBLUserMistake);
            ActivePriv();
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
            DataSources.dsTeachersUnion.TBLUserMistakeRow row = (DataSources.dsTeachersUnion.TBLUserMistakeRow)GV.GetFocusedDataRow();
            Update(row);
        }
        private void repositoryItemButtonEditDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView GV = (GridView)gridControlData.MainView;
            DataSources.dsTeachersUnion.TBLUserMistakeRow row = (DataSources.dsTeachersUnion.TBLUserMistakeRow)GV.GetFocusedDataRow();
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            try
            {
                tBLUserMistakeBindingSource.EndEdit();
                tBLUserMistakeTableAdapter.Delete(row.mistakeid);
                dsTeachersUnion.TBLUserMistake.AcceptChanges();
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
            DataSources.dsTeachersUnion.TBLUserMistakeRow row = dsTeachersUnion.TBLUserMistake.NewTBLUserMistakeRow();
            Update(row);
        }
        private void Update(DataSources.dsTeachersUnion.TBLUserMistakeRow row)
        {
            using (TBLUserMistakeWFrm frm = new TBLUserMistakeWFrm(row))
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                    return;
            }
            try
            {
                if (row.RowState == DataRowState.Detached)
                {
                    row.mistakeid = (int)tBLUserMistakeTableAdapter.ScalarQueryNewID();
                    dsTeachersUnion.TBLUserMistake.AddTBLUserMistakeRow(row);
                }
                tBLUserMistakeBindingSource.EndEdit();
                tBLUserMistakeTableAdapter.Update(row);
                dsTeachersUnion.TBLUserMistake.AcceptChanges();

                Program.ShowMsg("تم الحفظ", false, this);
                Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (Exception ex)
            {
                Program.ShowMsg(Misc.Misc.ExceptionMessage(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, ex, null, this);
            }
        }

       

    }
}
