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
    public partial class TBLMemberEsalatFrm : DevExpress.XtraEditors.XtraForm
    {
        public TBLMemberEsalatFrm()
        {
            InitializeComponent();
        }
        private void ActivePriv()
        {
            return;//ActivePrivReady
            bool Selecting = false, Inserting = false, Updateing = false, Deleting = false;
            SQLProvider.GetFormPriv(this.Name, ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
            gridControlData.Visible = Selecting;
            LUEMem.Visible = Selecting;

            repositoryItemButtonEditEdit.Buttons[0].Visible = Updateing;
        }
        private void TBLHafzawebFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsTeachersUnion.TBLMembersList' table. You can move, or remove it, as needed.
            this.tBLMembersListTableAdapter.Fill(this.dsTeachersUnion.TBLMembersList);
            ActivePriv();
        }
        private void LUEMem_EditValueChanged(object sender, EventArgs e)
        {
            if (LUEMem.EditValue == null)
                return;
            tBLMemberEsalatTableAdapter.FillByMemberId(dsTeachersUnion.TBLMemberEsalat, Convert.ToInt32(LUEMem.EditValue));

            lblesalno.Text = string.Empty;
            lblKideNumber.Text = string.Empty;
            lblSyndicate.Text = string.Empty;
            peimg.Image = null;
            DataSources.dsTeachersUnion.TBLMembersListRow row = (DataSources.dsTeachersUnion.TBLMembersListRow)
                tBLMembersListTableAdapter.GetDataByMemberId(Convert.ToInt32(LUEMem.EditValue)).Rows[0];
            if (!row.IsesalnoNull())
                lblesalno.Text = row.esalno.ToString();
            lblKideNumber.Text = row.KideNumber.ToString();
            if (!row.IsSyndicateNull())
                lblSyndicate.Text = row.Syndicate.ToString();
            if (File.Exists(row["img"].ToString()))
                peimg.Image = Image.FromFile(row["img"].ToString());
        }
        private void gridViewData_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            if (LUEMem.EditValue == null)
            {
                gridViewData.DeleteRow(e.RowHandle);
                return;
            }
            DataSources.dsTeachersUnion.TBLMemberEsalatRow row = (DataSources.dsTeachersUnion.TBLMemberEsalatRow)gridViewData.GetDataRow(e.RowHandle);
            row.MemberId = Convert.ToInt32(LUEMem.EditValue);
            row.datein = SQLProvider.GetServerDateTime();
            row.userin = Program.UserInfo.UserId;
        }
        private void repositoryItemButtonEditEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataSources.dsTeachersUnion.TBLMemberEsalatRow row = (DataSources.dsTeachersUnion.TBLMemberEsalatRow)gridViewData.GetFocusedDataRow();
            try
            {
                row.userin = Program.UserInfo.UserId;
                tBLMemberEsalatBindingSource.EndEdit();
                tBLMemberEsalatTableAdapter.Update(row);
                dsTeachersUnion.TBLMemberEsalat.AcceptChanges();
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
            DataSources.dsTeachersUnion.TBLMemberEsalatRow row = (DataSources.dsTeachersUnion.TBLMemberEsalatRow)gridViewData.GetFocusedDataRow();
            try
            {
                if (row.RowState == DataRowState.Detached)
                {
                    gridViewData.DeleteRow(gridViewData.FocusedRowHandle);
                    return;
                }

                if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                    return;
                tBLMemberEsalatBindingSource.EndEdit();
                tBLMemberEsalatTableAdapter.Delete(row.MemberId, row.esalno);
                gridViewData.DeleteRow(gridViewData.FocusedRowHandle);
                dsTeachersUnion.TBLMemberEsalat.AcceptChanges();
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