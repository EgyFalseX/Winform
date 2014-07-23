using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using FXFW;
using System.IO;

namespace Members
{
    public partial class TBLManualArsheefFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Functions   -
        public TBLManualArsheefFrm()
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
                    ((DataTable)gridControlData.DataSource).Rows.Add(((DataTable)gridControlData.DataSource).NewRow());
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
            if (Inserting || Updateing)
                repositoryItemButtonEditSave.Buttons[0].Visible = true;
            else
                repositoryItemButtonEditSave.Buttons[0].Visible = false;
            repositoryItemButtonEditDel.Buttons[0].Visible = Deleting;
        }
        #endregion
        #region - Event Handlers -
        private void TBLMandoopFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsTeachersUnion.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.dsTeachersUnion.Users);
            // TODO: This line of code loads data into the 'dsTeachersUnion.TBLManualArsheef' table. You can move, or remove it, as needed.
            this.tBLManualArsheefTableAdapter.Fill(this.dsTeachersUnion.TBLManualArsheef);
            ActivePriv();
        }
        private void gridViewData_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataSources.dsTeachersUnion.TBLManualArsheefRow row = (DataSources.dsTeachersUnion.TBLManualArsheefRow)gridViewData.GetDataRow(e.RowHandle);
            row.KartonaNo = (int)tBLManualArsheefTableAdapter.ScalarQueryNewID();
        }
        private void repositoryItemButtonEditEditDetails_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataSources.dsTeachersUnion.TBLManualArsheefRow row = (DataSources.dsTeachersUnion.TBLManualArsheefRow)gridViewData.GetFocusedDataRow();
            if (row.RowState == DataRowState.Detached)
            {
                MessageBox.Show("يجب الحفظ قبل الانتقال اللي التفاصيل", "تحزير", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            TBLManualArsheefDetailsFrm frm = new TBLManualArsheefDetailsFrm(row.KartonaNo);
            frm.ShowDialog();
        }       
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataSources.dsTeachersUnion.TBLManualArsheefRow row = (DataSources.dsTeachersUnion.TBLManualArsheefRow)gridViewData.GetFocusedDataRow();
            try
            {
                tBLManualArsheefBindingSource.EndEdit();
                tBLManualArsheefTableAdapter.Update(row);
                dsTeachersUnion.TBLManualArsheef.AcceptChanges();
                Program.ShowMsg("تم الحفظ", false, this);
                Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void repositoryItemButtonEditDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataSources.dsTeachersUnion.TBLManualArsheefRow row = (DataSources.dsTeachersUnion.TBLManualArsheefRow)gridViewData.GetFocusedDataRow();
            if (row.RowState == DataRowState.Detached)
                return;
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            tBLManualArsheefTableAdapter.Delete(row.KartonaNo);
            gridViewData.DeleteRow(gridViewData.FocusedRowHandle);
            Program.ShowMsg("تم الحذف", false, this);
            Program.Logger.LogThis("تم الحذف", Text, FXFW.Logger.OpType.success, null, null, this);
        }
        #endregion

    }
}