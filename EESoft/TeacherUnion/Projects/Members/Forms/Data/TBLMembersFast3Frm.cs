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
    public partial class TBLMembersFast3Frm : DevExpress.XtraEditors.XtraForm
    {

        public TBLMembersFast3Frm()
        {
            InitializeComponent();
        }
        private void ActivePriv()
        {
            return;//ActivePrivReady
            bool Selecting = false, Inserting = false, Updateing = false, Deleting = false;
            SQLProvider.GetFormPriv(this.Name, ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
            gridControlData.Visible = Selecting;
            repositoryItemButtonEditEdit.Buttons[0].Visible = Updateing;
        }
        private void TBLMembersFast3Frm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsTeachersUnion.CDSubCommitte' table. You can move, or remove it, as needed.
            this.cDSubCommitteTableAdapter.Fill(this.dsTeachersUnion.CDSubCommitte);
            // TODO: This line of code loads data into the 'dsTeachersUnion.CDSyndicate' table. You can move, or remove it, as needed.
            this.cDSyndicateTableAdapter.Fill(this.dsTeachersUnion.CDSyndicate);
            
            ActivePriv();
        }
        private void repositoryItemButtonEditEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView GV = (GridView)gridControlData.MainView;
            DataSources.dsTeachersUnion.TBLMembersMobileEditRow row = (DataSources.dsTeachersUnion.TBLMembersMobileEditRow)GV.GetFocusedDataRow();
            tBLMembersMobileEditBindingSource.EndEdit();
            
            try
            {
                tBLMembersMobileEditTableAdapter.UpdateMobile(row.MemberMobil, row.MemberId);
                dsTeachersUnion.TBLMembersMobileEdit.AcceptChanges();
                Program.ShowMsg("تم الحفظ", false, this);
                Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (Exception ex)
            {
                Program.ShowMsg(Misc.Misc.ExceptionMessage(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, ex, null, this);
            }
        }
        private void GLUESyndicateId_EditValueChanged(object sender, EventArgs e)
        {
            if (GLUESyndicateId.EditValue == null || GLUESyndicateId.EditValue.ToString() == string.Empty)
            {
                return;
            }
            // TODO: This line of code loads data into the 'dsTeachersUnion.TBLMembersMobileEdit' table. You can move, or remove it, as needed.
            this.tBLMembersMobileEditTableAdapter.Fill(this.dsTeachersUnion.TBLMembersMobileEdit, Convert.ToInt32(GLUESyndicateId.EditValue));
        }

        private void tbKidNumber_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (tbKidNumber.EditValue == null || tbKidNumber.EditValue.ToString() == string.Empty)
            {
                return;
            }
            // TODO: This line of code loads data into the 'dsTeachersUnion.TBLMembersMobileEdit' table. You can move, or remove it, as needed.
            this.tBLMembersMobileEditTableAdapter.FillByKideNumber(this.dsTeachersUnion.TBLMembersMobileEdit, Convert.ToInt32(tbKidNumber.EditValue));
        }

    }
}