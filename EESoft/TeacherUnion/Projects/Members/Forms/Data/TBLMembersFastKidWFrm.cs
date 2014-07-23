using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace Members
{
    public partial class TBLMembersFastKidWFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.dsTeachersUnion.TBLMembersRow _row;
        bool _Insert, _Update, _Delete;
        public TBLMembersFastKidWFrm()
        {
            InitializeComponent();
        }
        public TBLMembersFastKidWFrm(DataSources.dsTeachersUnion.TBLMembersRow row, bool insert, bool update, bool delete, bool FocusOnDetails = false)
        {
            InitializeComponent();
            _row = row;
            _Insert = insert;
            _Update = update;
            _Delete = delete;
            if (FocusOnDetails)
                xtraTabControl1.SelectedTabPage = xtraTabPageDetails;
        }
        private void ActivePriv()
        {
            if (_Insert)
                gridViewDetails.OptionsView.NewItemRowPosition = NewItemRowPosition.Top;
            else
                gridViewDetails.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            repositoryItemButtonEditSave.Buttons[0].Visible = _Update;
            repositoryItemButtonEditDelete.Buttons[0].Visible = _Delete;
        }
        private void LoadBinding()
        {
            if (!_row.IsNull("MemberName"))
                tbMemberName.EditValue = _row.MemberName;
            if (!_row.IsNull("KideNumber"))
                tbKideNumber.EditValue = _row.KideNumber;
            if (!_row.IsNull("SyndicateId"))
                lueSyndicateId.EditValue = _row.SyndicateId;

            //lueSyndicateId_EditValueChanged(lueSyndicateId, EventArgs.Empty);

            if (!_row.IsNull("SubCommitteId"))
                lueSubCommitteId.EditValue = _row.SubCommitteId;
            
        }
        private void ShowMemberSTypeName()
        {
            if (_row.RowState != DataRowState.Detached)
                lblMemberSTypeName.Text = tBLMemberHalaTableAdapter.ScalarQueryLastMemberSTypeName(_row.MemberId);
        }
        private void CheckIfMemberCardPrinted()
        {
            if (_row.RowState == DataRowState.Detached)
                return;
            DataSources.dsTeachersUnionTableAdapters.TBLPrintCardListTableAdapter adp = new DataSources.dsTeachersUnionTableAdapters.TBLPrintCardListTableAdapter();
            if (adp.ScalarQueryExistMemberId(_row.MemberId) == 1 && !Program.UserInfo.IsAdmin)
            {
                btnSave.Visible = false;
                btnSave.Enabled = false;
            }
        }
        private void FormWFrm_Load(object sender, EventArgs e)
        {
          
            // TODO: This line of code loads data into the 'dsTeachersUnion.CDMemberSType' table. You can move, or remove it, as needed.
            this.cDMemberSTypeTableAdapter.Fill(this.dsTeachersUnion.CDMemberSType);
            this.cDGehaTableAdapter.Fill(this.dsTeachersUnion.CDGeha);
            cDSyndicateTableAdapter.Fill(dsTeachersUnion.CDSyndicate);

            if (_row.RowState != DataRowState.Detached)
            {
                this.tBLMemberHalaTableAdapter.FillByMemberId(this.dsTeachersUnion.TBLMemberHala, _row.MemberId);
                this.tBLSadadTableAdapter.FillByMemberId(this.dsTeachersUnion.TBLSadad, _row.MemberId);
                xtraTabPageDetails.PageVisible = true;
                xtraTabPageSadad.PageVisible = true;

                CheckIfMemberCardPrinted();
            }
            else
            {
                xtraTabPageDetails.PageVisible = false;
                xtraTabPageSadad.PageVisible = false;
            }
           
            ActivePriv();
            //if (_row.RowState != DataRowState.Detached)
            //    this.tBLMazroofTableAdapter.FillByReceiptNo(this.dsTeachersUnion.TBLMazroof, _row.ReceiptNo);     
            //else
            //    xtraTabPageDetails.PageVisible = false;
            LoadBinding();
            ShowMemberSTypeName();
        }
        private void lueSyndicateId_EditValueChanged(object sender, EventArgs e)
        {
            if (!FXFW.SqlDB.IsNullOrEmpty(lueSyndicateId.EditValue))
                this.cDSubCommitteTableAdapter.FillBySyndicateId(this.dsTeachersUnion.CDSubCommitte, Convert.ToInt32(lueSyndicateId.EditValue));
        }
        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (e.Page == xtpGeneral)
            {
                ShowMemberSTypeName();
            }
        }
        private void repositoryItemGridLookUpEditgehaid_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm frm = new CodeFrm(CodeFrm.TableNames.CDGeha);
            frm.ShowDialog();
            this.cDGehaTableAdapter.Fill(this.dsTeachersUnion.CDGeha);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (_row.RowState == DataRowState.Detached)
            {
                if (new DataSources.dsTeachersUnionTableAdapters.TBLMembersTableAdapter().ScalarQueryExistsKideNumber(Convert.ToInt32(tbKideNumber.EditValue)) != 0)
                {
                    Program.ShowMsg("رقم القيد موجود مسبقا", true, this);
                    Program.Logger.LogThis("رقم القيد موجود مسبقا", Text, FXFW.Logger.OpType.fail, null, null, this);
                    return;
                }
            }
            else
            {
                if (new DataSources.dsTeachersUnionTableAdapters.TBLMembersTableAdapter().ScalarQueryExistsKideNumber_MemberId(Convert.ToInt32(tbKideNumber.EditValue), _row.MemberId) != 0)
                {
                    Program.ShowMsg("رقم القيد موجود مسبقا", true, this);
                    Program.Logger.LogThis("رقم القيد موجود مسبقا", Text, FXFW.Logger.OpType.fail, null, null, this);
                    return;
                }
            }

            DialogResult = System.Windows.Forms.DialogResult.OK;

            if (tbMemberName.EditValue != null)
                _row.MemberName = tbMemberName.EditValue.ToString();
            if (tbKideNumber.EditValue != null)
                _row.KideNumber = Convert.ToInt32(tbKideNumber.EditValue);
            if (lueSyndicateId.EditValue != null)
                _row.SyndicateId = Convert.ToInt32(lueSyndicateId.EditValue);
            if (lueSubCommitteId.EditValue != null)
                _row.SubCommitteId = Convert.ToInt32(lueSubCommitteId.EditValue);

            _row.img = Program.imgPath + tbKideNumber.EditValue + Program.imgExt;
            _row.RandomCard = new Random().Next(100, 999).ToString();
            _row.MemberShipNumber = (int)(new DataSources.dsTeachersUnionTableAdapters.TBLMembersTableAdapter().ScalarQueryNewMemberShipNumber());

            _row.userin = Program.UserInfo.UserId;
            _row.datein = (DateTime)new DataSources.dsTeachersUnionQueryTableAdapters.ServerDateTimeTableAdapter().ScalarQueryServerDateTime();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
      
        private void gridViewDetails_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DataSources.dsTeachersUnion.TBLMemberHalaRow row = (DataSources.dsTeachersUnion.TBLMemberHalaRow)gridViewDetails.GetDataRow(e.RowHandle);
            row.MemberId = _row.MemberId;
            row.userin = Program.UserInfo.UserId;
            row.datein = (DateTime)new DataSources.dsTeachersUnionQueryTableAdapters.ServerDateTimeTableAdapter().ScalarQueryServerDateTime();
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView GV = (GridView)gridControlDetails.MainView;
            DataSources.dsTeachersUnion.TBLMemberHalaRow row = (DataSources.dsTeachersUnion.TBLMemberHalaRow)GV.GetFocusedDataRow();
            try
            {
                tBLMemberHalaBindingSource.EndEdit();
                tBLMemberHalaTableAdapter.Update(row);
                dsTeachersUnion.TBLMemberHala.AcceptChanges();
                Program.ShowMsg("تم الحفظ", false, this);
                Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void repositoryItemButtonEditDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            GridView GV = (GridView)gridControlDetails.MainView;
            DataSources.dsTeachersUnion.TBLMemberHalaRow row = (DataSources.dsTeachersUnion.TBLMemberHalaRow)GV.GetFocusedDataRow();
            if (row.RowState == DataRowState.Detached)
                return;
            try
            {
                tBLMemberHalaTableAdapter.Delete(row.MemberId, row.MemberSTypeId, row.datefrom);
                gridViewDetails.DeleteRow(GV.FocusedRowHandle);
                Program.ShowMsg("تم الحذف", false, this);
                Program.Logger.LogThis("تم الحذف", Text, FXFW.Logger.OpType.success, null, null, this);

            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
       
        private void gridViewSadad_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DataSources.dsTeachersUnion.TBLSadadRow row = (DataSources.dsTeachersUnion.TBLSadadRow)gridViewSadad.GetDataRow(e.RowHandle);
            row.MemberId = _row.MemberId;
            row.userin = Program.UserInfo.UserId;
            row.datein = (DateTime)new DataSources.dsTeachersUnionQueryTableAdapters.ServerDateTimeTableAdapter().ScalarQueryServerDateTime();
       
        }
        private void repositoryItemButtonEditSadadSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView GV = (GridView)gridControlSadad.MainView;
            DataSources.dsTeachersUnion.TBLSadadRow row = (DataSources.dsTeachersUnion.TBLSadadRow)GV.GetFocusedDataRow();
            try
            {
                tBLSadadBindingSource.EndEdit();
                tBLSadadTableAdapter.Update(row);
                dsTeachersUnion.TBLSadad.AcceptChanges();
                Program.ShowMsg("تم الحفظ", false, this);
                Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void repositoryItemButtonEditSadadDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            GridView GV = (GridView)gridControlSadad.MainView;
            DataSources.dsTeachersUnion.TBLSadadRow row = (DataSources.dsTeachersUnion.TBLSadadRow)GV.GetFocusedDataRow();
            if (row.RowState == DataRowState.Detached)
                return;
            try
            {
                tBLSadadTableAdapter.Delete(row.MemberId, row.esalno);
                gridViewSadad.DeleteRow(GV.FocusedRowHandle);
                Program.ShowMsg("تم الحذف", false, this);
                Program.Logger.LogThis("تم الحذف", Text, FXFW.Logger.OpType.success, null, null, this);

            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void repositoryItemButtonEditPrint_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView GV = (GridView)gridControlSadad.MainView;
            DataSources.dsTeachersUnion.TBLSadadRow row = (DataSources.dsTeachersUnion.TBLSadadRow)GV.GetFocusedDataRow();
            if (row.RowState == DataRowState.Detached)
                return;
            XRep09 FrmRep = new XRep09(row);
            Misc.Misc.ShowPrintPreview(FrmRep);
        }
        
    }
}
