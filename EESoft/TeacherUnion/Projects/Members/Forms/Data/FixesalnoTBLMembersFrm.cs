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
    public partial class FixesalnoTBLMembersFrm : DevExpress.XtraEditors.XtraForm
    {
        public FixesalnoTBLMembersFrm()
        {
            InitializeComponent();
        }
        private void ActivePriv()
        {
            bool Selecting = false, Inserting = false, Updateing = false, Deleting = false;
            SQLProvider.GetFormPriv(this.Name, ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
            gridControlData.Visible = Selecting;
            btnSearch.Visible = Selecting; btnUpdate.Visible = Updateing;
        }
        private void FixesalnoTBLMembersFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsTeachersUnion.CDSyndicate' table. You can move, or remove it, as needed.
            this.cDSyndicateTableAdapter.Fill(this.dsTeachersUnion.CDSyndicate);
            ActivePriv();
        }
        private void lueSyndicateId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (lueSyndicateId.EditValue == null || FXFW.SqlDB.IsNullOrEmpty(lueSyndicateId.EditValue))
                return;
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.OK)
                return;
            // TODO: This line of code loads data into the 'dsTeachersUnionQuery.FixesalnoTBLMembers' table. You can move, or remove it, as needed.
            this.fixesalnoTBLMembersTableAdapter.FillBySyndicateId(this.dsTeachersUnionQuery.FixesalnoTBLMembers, Convert.ToInt32(lueSyndicateId.EditValue));
        }
        private void tbtbesalnoSearch_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (tbtbesalnoSearch.EditValue == null || FXFW.SqlDB.IsNullOrEmpty(tbtbesalnoSearch.EditValue))
                return;
            // TODO: This line of code loads data into the 'dsTeachersUnionQuery.FixesalnoTBLMembers' table. You can move, or remove it, as needed.
            this.fixesalnoTBLMembersTableAdapter.FillByesalno(this.dsTeachersUnionQuery.FixesalnoTBLMembers, Convert.ToInt32(tbtbesalnoSearch.EditValue));
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tbtbesalnoSearch.EditValue == null || FXFW.SqlDB.IsNullOrEmpty(tbtbesalnoSearch.EditValue) || lueSyndicateId.EditValue == null || FXFW.SqlDB.IsNullOrEmpty(lueSyndicateId.EditValue))
                return;
            // TODO: This line of code loads data into the 'dsTeachersUnionQuery.FixesalnoTBLMembers' table. You can move, or remove it, as needed.
            this.fixesalnoTBLMembersTableAdapter.FillBySyndicateId_esalno(this.dsTeachersUnionQuery.FixesalnoTBLMembers, Convert.ToInt32(lueSyndicateId.EditValue), Convert.ToInt32(tbtbesalnoSearch.EditValue));
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbtbesalnoUpdate.EditValue == null || FXFW.SqlDB.IsNullOrEmpty(tbtbesalnoUpdate.EditValue))
                return;

            if (MessageBox.Show("هل انت متأكد؟", "تعديل", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            DataSources.dsTeachersUnionTableAdapters.TBLMembersTableAdapter adp = new DataSources.dsTeachersUnionTableAdapters.TBLMembersTableAdapter();
            foreach (DataSources.dsTeachersUnionQuery.FixesalnoTBLMembersRow member in dsTeachersUnionQuery.FixesalnoTBLMembers)
            {
                adp.UpdateQueryesalno(Convert.ToInt32(tbtbesalnoUpdate.EditValue), member.MemberId);     
            }
            Program.ShowMsg("تم التعديل", false, this);
            Program.Logger.LogThis("تم التعديل", Text, FXFW.Logger.OpType.success, null, null, this);
            btnSearch_Click(btnSearch, EventArgs.Empty);
        }
    }
}
