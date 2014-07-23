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
    public partial class TBLAksatWindowFrm : DevExpress.XtraEditors.XtraForm
    {

        public TBLAksatWindowFrm()
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
            // TODO: This line of code loads data into the 'dsTeachersUnion.TBLMembersList' table. You can move, or remove it, as needed.
            this.tBLMembersListTableAdapter.Fill(this.dsTeachersUnion.TBLMembersList);
            // TODO: This line of code loads data into the 'dsTeachersUnion.TBLAksat' table. You can move, or remove it, as needed.
            this.tBLAksatTableAdapter.Fill(this.dsTeachersUnion.TBLAksat);
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
        private void repositoryItemGridLookUpEditMemberId_EditValueChanged(object sender, EventArgs e)
        {
            GridLookUpEdit lue = (GridLookUpEdit)sender;
            if (FXFW.SqlDB.IsNullOrEmpty(lue.EditValue))
                return;
            GridView GV = (GridView)gridControlData.MainView;
            DataSources.dsTeachersUnion.TBLAksatRow row = (DataSources.dsTeachersUnion.TBLAksatRow)GV.GetFocusedDataRow();
            GridView SubGV = (GridView)lue.Properties.View;
            DataSources.dsTeachersUnion.TBLMembersListRow subRow = (DataSources.dsTeachersUnion.TBLMembersListRow)((DataRowView)lue.GetSelectedDataRow()).Row;
            row.KideNumber = subRow.KideNumber; row.Syndicate = subRow.Syndicate;
            
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView GV = (GridView)gridControlData.MainView;
            DataSources.dsTeachersUnion.TBLAksatRow row = (DataSources.dsTeachersUnion.TBLAksatRow)GV.GetFocusedDataRow();
            Update(row);
        }
        private void repositoryItemButtonEditDetails_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView GV = (GridView)gridControlData.MainView;
            DataSources.dsTeachersUnion.TBLAksatRow row = (DataSources.dsTeachersUnion.TBLAksatRow)GV.GetFocusedDataRow();
            if (row.RowState == DataRowState.Detached)
                return;

            TBLAksatDetailesFrm frm = new TBLAksatDetailesFrm(row);
            frm.ShowDialog();
        }
        private void repositoryItemButtonEditDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView GV = (GridView)gridControlData.MainView;
            DataSources.dsTeachersUnion.TBLAksatRow row = (DataSources.dsTeachersUnion.TBLAksatRow)GV.GetFocusedDataRow();
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            try
            {
                tBLAksatBindingSource.EndEdit();
                tBLAksatTableAdapter.Delete(row.MemberId);
                dsTeachersUnion.TBLAksat.AcceptChanges();
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
            DataSources.dsTeachersUnion.TBLAksatRow row = dsTeachersUnion.TBLAksat.NewTBLAksatRow();
            Update(row);
        }
        private void Update(DataSources.dsTeachersUnion.TBLAksatRow row)
        {
            using (TBLAksatWindowWFrm frm = new TBLAksatWindowWFrm(row))
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                    return;
            }
            try
            {
                if (row.RowState == DataRowState.Detached)
                {
                    dsTeachersUnion.TBLAksat.AddTBLAksatRow(row);
                }
                tBLAksatBindingSource.EndEdit();
                tBLAksatTableAdapter.Update(row);
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

       

    }
}
