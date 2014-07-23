
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;

namespace RetirementCenter
{
    public partial class TblMemberAmanatFrm : XtraForm
    {
        bool _Insert, _Update, _Delete;
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext();
        
        #region -   Functions   -
        public TblMemberAmanatFrm()
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
            bool Selecting = false, Inserting = false, Updateing = false, Deleting = false;
            SQLProvider.GetFormPriv(this.Name, ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
            gridControlData.Visible = Selecting;

            btnNew.Visible = Inserting;
            repositoryItemButtonEditSave.Buttons[0].Visible = Updateing;
            repositoryItemButtonEditDel.Buttons[0].Visible = Deleting;

            _Insert = Inserting; _Update = Updateing; _Delete = Deleting;
        }
        #endregion
        #region - Event Handlers -
        private void FormFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsRetirementCenter.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.dsRetirementCenter.Users);
            LSMSTBLMashat.QueryableSource = dsLinq.vTBLMashats;
            // TODO: This line of code loads data into the 'dsRetirementCenter.CdDofaatAmanat' table. You can move, or remove it, as needed.
            this.cdDofaatAmanatTableAdapter.Fill(this.dsRetirementCenter.CdDofaatAmanat);
            // TODO: This line of code loads data into the 'dsRetirementCenter.TblMemberAmanat' table. You can move, or remove it, as needed.
            this.tblMemberAmanatTableAdapter.Fill(this.dsRetirementCenter.TblMemberAmanat);
            ActivePriv();
        }
        private void gridViewData_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            DataRowView DRV = (DataRowView)e.Row;
            //Fellowship.DataSources.DSFellowship.TBLSheekWaredRow row = (Fellowship.DataSources.DSFellowship.TBLSheekWaredRow)DRV.Row;

            if (e.ErrorText.Contains("SyndicateId"))
            {
                e.ErrorText = "من فضلك بجب ادخال الفرعيه";
                return;
            }
            if (e.ErrorText.Contains("autoID"))
            {
                //e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
                DRV["autoID"] = "-1";
                return;
            }

        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView GV = (GridView)gridControlData.MainView;
            DataSources.dsRetirementCenter.TblMemberAmanatRow row = (DataSources.dsRetirementCenter.TblMemberAmanatRow)GV.GetFocusedDataRow();
            Update(row, false);
            
        }
        private void repositoryItemButtonEditDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView GV = (GridView)gridControlData.MainView;
            DataSources.dsRetirementCenter.TblMemberAmanatRow row = (DataSources.dsRetirementCenter.TblMemberAmanatRow)GV.GetFocusedDataRow();

            if (row.RowState == DataRowState.Detached)
                return;

            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            try
            {

                tblMemberAmanatTableAdapter.Delete(row.MMashatId, row.DofatSarfAId);
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
            DataSources.dsRetirementCenter.TblMemberAmanatRow row = dsRetirementCenter.TblMemberAmanat.NewTblMemberAmanatRow();
            Update(row, false);
        }
        private void Update(DataSources.dsRetirementCenter.TblMemberAmanatRow row, bool DetailsTabFocus)
        {
            TblMemberAmanatWFrm frm;
            if (DetailsTabFocus)
                frm = new TblMemberAmanatWFrm(row, _Insert, _Update, _Delete);
            else
                frm = new TblMemberAmanatWFrm(row, _Insert, _Update, _Delete);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                return;

            try
            {
                if (row.RowState == DataRowState.Detached)
                    dsRetirementCenter.TblMemberAmanat.AddTblMemberAmanatRow(row);
                tblMemberAmanatBindingSource.EndEdit();
                tblMemberAmanatTableAdapter.Update(row);
                dsRetirementCenter.TblMemberAmanat.AcceptChanges();
                Program.ShowMsg("تم الحفظ", false, this, true);
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