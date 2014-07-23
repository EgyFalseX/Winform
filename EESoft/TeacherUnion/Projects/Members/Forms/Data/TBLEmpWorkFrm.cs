
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;

namespace Members
{
    public partial class TBLEmpWorkFrm : XtraForm
    {

        #region -   Functions   -
        public TBLEmpWorkFrm()
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
            return;//ActivePrivReady
            bool Selecting = false, Inserting = false, Updateing = false, Deleting = false;
            SQLProvider.GetFormPriv(this.Name, ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
            gridControlData.Visible = Selecting;

            btnNew.Visible = Inserting;
            repositoryItemButtonEditSave.Buttons[0].Visible = Updateing;
            repositoryItemButtonEditDel.Buttons[0].Visible = Deleting;
        }
        #endregion
        #region - Event Handlers -
        private void FormFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsTeachersUnion.CDSyndicate' table. You can move, or remove it, as needed.
            this.cDSyndicateTableAdapter.Fill(this.dsTeachersUnion.CDSyndicate);
            // TODO: This line of code loads data into the 'dsTeachersUnion.CDWorkType' table. You can move, or remove it, as needed.
            this.cDWorkTypeTableAdapter.Fill(this.dsTeachersUnion.CDWorkType);
            // TODO: This line of code loads data into the 'dsTeachersUnion.TBLEmpWork' table. You can move, or remove it, as needed.
            this.tBLEmpWorkTableAdapter.FillByuserin(this.dsTeachersUnion.TBLEmpWork, Program.UserInfo.UserId);
            ActivePriv();
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView GV = (GridView)gridControlData.MainView;
            DataSources.dsTeachersUnion.TBLEmpWorkRow row = (DataSources.dsTeachersUnion.TBLEmpWorkRow)GV.GetFocusedDataRow();
            if (row.closed)
            {
                Program.Logger.LogThis("لا يمكن تعديل حقل مغلق", Text, FXFW.Logger.OpType.success, null, null, this);
                return;
            }
            Update(row);
        }
        private void repositoryItemButtonEditDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView GV = (GridView)gridControlData.MainView;
            DataSources.dsTeachersUnion.TBLEmpWorkRow row = (DataSources.dsTeachersUnion.TBLEmpWorkRow)GV.GetFocusedDataRow();

            if (row.RowState == DataRowState.Detached)
                return;

            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            try
            {
                tBLEmpWorkTableAdapter.Delete(row.wid);
                gridViewData.DeleteRow(GV.FocusedRowHandle);
                // TODO: This line of code loads data into the 'dsTeachersUnion.TBLEmpWork' table. You can move, or remove it, as needed.
                this.tBLEmpWorkTableAdapter.FillByuserin(this.dsTeachersUnion.TBLEmpWork, Program.UserInfo.UserId);
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
            DataSources.dsTeachersUnion.TBLEmpWorkRow row = dsTeachersUnion.TBLEmpWork.NewTBLEmpWorkRow();
            Update(row);
        }
        private void Update(DataSources.dsTeachersUnion.TBLEmpWorkRow row)
        {
            using (TBLEmpWorkWFrm frm = new TBLEmpWorkWFrm(row))
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                    return;
            }
            try
            {
                if (row.RowState == DataRowState.Detached)
                {
                    //row.workdate = new DateTime();// will not saved
                    row.timestart = new TimeSpan();// will not saved
                    row.timeend = new TimeSpan();// will not saved

                    dsTeachersUnion.TBLEmpWork.AddTBLEmpWorkRow(row);
                }
                tBLEmpWorkBindingSource.EndEdit();
                if (row.closed)
                    tBLEmpWorkTableAdapter.UpdateQueryClose(row.wid);
                else
                    tBLEmpWorkTableAdapter.Update(row);
                dsTeachersUnion.TBLEmpWork.AcceptChanges();
                // TODO: This line of code loads data into the 'dsTeachersUnion.TBLEmpWork' table. You can move, or remove it, as needed.
                this.tBLEmpWorkTableAdapter.FillByuserin(this.dsTeachersUnion.TBLEmpWork, Program.UserInfo.UserId);
                Program.ShowMsg("تم الحفظ", false, this);
                Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
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