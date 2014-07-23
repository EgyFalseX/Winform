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
using DevExpress.XtraGrid.Views.Grid;

namespace Retirement
{
    public partial class TBLDofatdeatilesFrm : DevExpress.XtraEditors.XtraForm
    {
        public int _DofatSarfId = 0;
        #region -   Functions   -
        public TBLDofatdeatilesFrm(int DofatSarfId)
        {
            _DofatSarfId = DofatSarfId;
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
            return;
            bool Selecting = false, Inserting = false, Updateing = false, Deleting = false;
            SqlDB.GetFormPriv("Retirement" + Name.Replace("Frm", ""), ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
            gridControlData.Visible = Selecting;
            if (Inserting || Updateing)
                repositoryItemButtonEditSave.Buttons[0].Enabled = true;
            else
                repositoryItemButtonEditSave.Buttons[0].Enabled = false;
            repositoryItemButtonEditDel.Buttons[0].Enabled = Deleting;
        }
        #endregion
        #region - Event Handlers -
        private void TBLDofatdeatilesFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsTeachersUnion.TBLMashat' table. You can move, or remove it, as needed.
            this.tBLMashatTableAdapter.Fill(this.dsTeachersUnion.TBLMashat);
            // TODO: This line of code loads data into the 'dsTeachersUnion.TBLDofatdeatiles' table. You can move, or remove it, as needed.
            this.tBLDofatdeatilesTableAdapter.FillByDofatSarfId(this.dsTeachersUnion.TBLDofatdeatiles, _DofatSarfId);
            ActivePriv();
        }
        private void btnAddAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            DataSources.dsTeachersUnionTableAdapters.TBLMashatTableAdapter adp = new DataSources.dsTeachersUnionTableAdapters.TBLMashatTableAdapter();
            adp.Fill(dsTeachersUnion.TBLMashat);
            int Changes = 0;
            foreach (DataSources.dsTeachersUnion.TBLMashatRow item in dsTeachersUnion.TBLMashat.Rows)
            {
                if (tBLDofatdeatilesTableAdapter.ScalarQueryExists(_DofatSarfId, item.MMashatId) == 1)
                    continue;
                tBLDofatdeatilesTableAdapter.Insert(_DofatSarfId, item.MMashatId, item.sarfnumber,
                    Convert.ToDouble(tbmonthlyretrment.EditValue), Convert.ToDouble(tbtotalmonthlyretrment.EditValue),
                    Convert.ToDouble(tbeshtrakat.EditValue), Convert.ToDouble(tbrasm.EditValue), 
                    Convert.ToDouble(tbestbad.EditValue), Convert.ToDouble(tbaksat.EditValue));
                Changes++;
            }
            Program.ShowMsg("تم اضافة " + Changes.ToString(), false, this);
            Program.Logger.LogThis("تم اضافة " + Changes.ToString(), Text, FXFW.Logger.OpType.success, null, null, this);
            this.tBLDofatdeatilesTableAdapter.FillByDofatSarfId(this.dsTeachersUnion.TBLDofatdeatiles, _DofatSarfId);                
        }
        private void gridViewData_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            GridView GV = (GridView)gridControlData.MainView;

            DataSources.dsTeachersUnion.TBLDofatdeatilesRow row = (DataSources.dsTeachersUnion.TBLDofatdeatilesRow)GV.GetDataRow(e.RowHandle);
            row.DofatSarfId = _DofatSarfId;

        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView GV = (GridView)gridControlData.MainView;
            DataSources.dsTeachersUnion.TBLDofatdeatilesRow row = (DataSources.dsTeachersUnion.TBLDofatdeatilesRow)GV.GetFocusedDataRow();
            try
            {
                tBLDofatdeatilesBindingSource.EndEdit();
                tBLDofatdeatilesTableAdapter.Update(row);
                dsTeachersUnion.TBLDofatdeatiles.AcceptChanges();
                Program.ShowMsg("تم الحفظ", false, this);
                Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void repositoryItemButtonEditDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
             GridView GV = (GridView)gridControlData.MainView;
            DataSources.dsTeachersUnion.TBLDofatdeatilesRow row = (DataSources.dsTeachersUnion.TBLDofatdeatilesRow)GV.GetFocusedDataRow();
            try
            {
                if (row.RowState == DataRowState.Detached)
                    dsTeachersUnion.TBLDofatdeatiles.RejectChanges();
                else
                    tBLDofatdeatilesTableAdapter.Delete(row.DofatSarfId, row.MMashatId);
                dsTeachersUnion.TBLDofatdeatiles.AcceptChanges();
                Program.ShowMsg("تم الحذف", false, this);
                Program.Logger.LogThis("تم الحذف", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
           
        #endregion

    }
}