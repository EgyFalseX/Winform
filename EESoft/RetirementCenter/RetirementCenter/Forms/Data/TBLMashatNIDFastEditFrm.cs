using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;

namespace RetirementCenter.Forms.Data
{
    public partial class TBLMashatNIDFastEditFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext();
        
        public TBLMashatNIDFastEditFrm()
        {
            InitializeComponent();

            LSMSCDSyndicate.QueryableSource = dsLinq.CDSyndicates;
            LSMSCDSubCommitte.QueryableSource = dsLinq.CDSubCommittes;
            LSMSCDMashHala.QueryableSource = dsLinq.CDMashHalas;
            // TODO: This line of code loads data into the 'dsRetirementCenter.TBLMashatFastEdit' table. You can move, or remove it, as needed.
            if (Program.UserInfo.IsAdmin)
                this.tBLMashatFastEditTableAdapter.Fill(this.dsRetirementCenter.TBLMashatFastEdit);
            else
                this.tBLMashatFastEditTableAdapter.FillBySyndicateId(this.dsRetirementCenter.TBLMashatFastEdit, Program.UserInfo.UserId);
                
        }
        private void TBLMashatNIDFastEditFrm_Load(object sender, EventArgs e)
        {
        }
        private void repositoryItemCheckEdityasref_CheckedChanged(object sender, EventArgs e)
        {
            CheckEdit ce = (CheckEdit)sender;
            
            DataSources.dsRetirementCenter.TBLMashatFastEditRow row =
                (DataSources.dsRetirementCenter.TBLMashatFastEditRow)((DataRowView)gridViewData.GetRow(gridViewData.FocusedRowHandle)).Row;

            row.yasref = ce.Checked;
            tBLMashatFastEditBindingSource.EndEdit();

            if ((bool)row["yasref", DataRowVersion.Current] != (bool)row["yasref", DataRowVersion.Original])
            {
                TBLNoSarfWarsaDlg dlg = new TBLNoSarfWarsaDlg();
                if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    row.halarem = dlg.tbhalarem.EditValue.ToString();
                    row.datehala = dlg.dedatehala.DateTime;
                }
            }
        }
        private void repositoryItemTextEditMMashatNId_Validating(object sender, CancelEventArgs e)
        {
            TextEdit tb = (TextEdit)sender;
            if (tb.EditValue != null && tb.EditValue.ToString() != string.Empty)
            {
                if (tb.EditValue.ToString().Length < 14)
                    e.Cancel = true;
            }
        }
        private void repositoryItemButtonEditTransferSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataSources.dsRetirementCenter.TBLMashatFastEditRow row =
                (DataSources.dsRetirementCenter.TBLMashatFastEditRow)((DataRowView)gridViewData.GetRow(gridViewData.FocusedRowHandle)).Row;
            try
            {
                row.datein = SQLProvider.ServerDateTime();
                row.userin = Program.UserInfo.UserId;
                if (!row.IsMMashatNIdNull() && row.MMashatNId != string.Empty)
                {
                    if ((int)SQLProvider.adpQry.ExistsNID(row.MMashatNId, row.MMashatId, -100) > 0)
                    {
                        Program.ShowMsg("الرقم القومي موجود مسبقا", true, this, true);
                        return;
                    }
                }
                if ((bool)row["yasref", DataRowVersion.Current] != (bool)row["yasref", DataRowVersion.Original])
                    tblNoSarfDetelsTableAdapter.Insert(row.MMashatId, row.yasref, row.datehala, row.halarem, SQLProvider.ServerDateTime(), Program.UserInfo.UserId);
                tBLMashatFastEditBindingSource.EndEdit();
                if (!row.IsMMashatNIdNull() && row.MMashatNId != string.Empty)
                    tblMashatTableAdapter.UpdateQueryFastEdit(row.MMashatNId, SQLProvider.ServerDateTime(), Program.UserInfo.UserId, row.yasref, row.SubCommitteId, row.MMashatId);
                else
                    tblMashatTableAdapter.UpdateQueryFastEdit(null, SQLProvider.ServerDateTime(), Program.UserInfo.UserId, row.yasref, row.SubCommitteId, row.MMashatId);
                
                Program.ShowMsg("تم التعديل", false, this, true);
                Program.Logger.LogThis("تم التعديل", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }

        private void repositoryItemGridLookUpEditSubCommitteId_Enter(object sender, EventArgs e)
        {
            DataSources.dsRetirementCenter.TBLMashatFastEditRow row =
              (DataSources.dsRetirementCenter.TBLMashatFastEditRow)((DataRowView)gridViewData.GetRow(gridViewData.FocusedRowHandle)).Row;
            if (row.IsNull("SyndicateId"))
                return;
            GridLookUpEdit lue = (GridLookUpEdit)sender;
            lue.Properties.DataSource = from q in dsLinq.CDSubCommittes where q.SyndicateId == row.SyndicateId select q;
        }

    }
}