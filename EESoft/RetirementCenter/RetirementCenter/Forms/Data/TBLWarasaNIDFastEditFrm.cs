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
    public partial class TBLWarasaNIDFastEditFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext();

        public TBLWarasaNIDFastEditFrm()
        {
            InitializeComponent();

            LSMSCDSyndicate.QueryableSource = dsLinq.CDSyndicates;
            LSMSCDSubCommitte.QueryableSource = dsLinq.CDSubCommittes;
            LSMSCDWarasaType.QueryableSource = dsLinq.CDWarasaTypes;
            LSMSUsers.QueryableSource = dsLinq.Users;

            if (Program.UserInfo.IsAdmin)
                this.tBLWarasaFastEditTableAdapter.Fill(this.dsRetirementCenter.TBLWarasaFastEdit);
            else
                this.tBLWarasaFastEditTableAdapter.FillBySyndicateId(this.dsRetirementCenter.TBLWarasaFastEdit, Program.UserInfo.UserId);
        }
        private void TBLWarasaNIDFastEditFrm_Load(object sender, EventArgs e)
        {
            
        }
        private void repositoryItemTextEditpersonNID_Validating(object sender, CancelEventArgs e)
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
            DataSources.dsRetirementCenter.TBLWarasaFastEditRow row =
                (DataSources.dsRetirementCenter.TBLWarasaFastEditRow)((DataRowView)gridViewData.GetRow(gridViewData.FocusedRowHandle)).Row;
            try
            {
                row.datein = SQLProvider.ServerDateTime();
                row.userin = Program.UserInfo.UserId;
                if (!row.IspersonNIDNull() && row.personNID != string.Empty)
                {
                    if ((int)SQLProvider.adpQry.ExistsNID(row.personNID, -100, row.PersonId) > 0)
                    {
                        Program.ShowMsg("الرقم القومي موجود مسبقا", true, this, true);
                        return;
                    }
                }
                tBLWarasaFastEditBindingSource.EndEdit();
                if (row.IspersonNIDNull() || row.personNID == string.Empty)
                    tblWarasaTableAdapter.UpdateQueryFastEdit(null, Program.UserInfo.UserId, SQLProvider.ServerDateTime(), row.WarasaTypeId, row.SubCommitteIdW, row.PersonId);
                else
                    tblWarasaTableAdapter.UpdateQueryFastEdit(row.personNID, Program.UserInfo.UserId, SQLProvider.ServerDateTime(), row.WarasaTypeId, row.SubCommitteIdW, row.PersonId);
                
                Program.ShowMsg("تم التعديل", false, this, true);
                Program.Logger.LogThis("تم التعديل", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void repositoryItemGridLookUpEditSubCommitteIdW_Enter(object sender, EventArgs e)
        {
            DataSources.dsRetirementCenter.TBLWarasaFastEditRow row =
                (DataSources.dsRetirementCenter.TBLWarasaFastEditRow)((DataRowView)gridViewData.GetRow(gridViewData.FocusedRowHandle)).Row;
            if (row.IsNull("SyndicateIdW"))
                return;
            GridLookUpEdit lue = (GridLookUpEdit)sender;
            lue.Properties.DataSource = from q in dsLinq.CDSubCommittes where q.SyndicateId == row.SyndicateIdW select q;
        }

    }
}