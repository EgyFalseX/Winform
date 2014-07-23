
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

namespace Fellowship
{
    public partial class TblMemberFrm : DevExpress.XtraEditors.XtraForm
    {
        
        #region -   Functions   -
        public TblMemberFrm()
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
                    tblMemberBindingSource.AddNew();
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
            SqlDB.GetFormPriv("Fellowship" + Name.Replace("Frm", ""), ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
            gridControlData.Visible = Selecting;
            if (Inserting || Updateing)
                repositoryItemButtonEditSave.Buttons[0].Enabled = true;
            else
                repositoryItemButtonEditSave.Buttons[0].Enabled = false;
            repositoryItemButtonEditDel.Buttons[0].Enabled = Deleting;
        }
        #endregion
        #region - Event Handlers -
        private void TblMemberFrm_Load(object sender, EventArgs e)
        {
            cDJobTableAdapter.Fill(dSFellowship.CDJob);
            cDEDARETTableAdapter.Fill(dSFellowship.CDEDARET);
            cDSyndicateTableAdapter.Fill(dSFellowship.CDSyndicate);
            cDStateTableAdapter.Fill(dSFellowship.CDState);
            usersTableAdapter.Fill(dSFellowship.Users);

            this.tblMemberTableAdapter.Fill(this.dSFellowship.TblMember);
            ActivePriv();
        }
        private void repositoryItemGridLookUpEditEdaraId_QueryPopUp(object sender, CancelEventArgs e)
        {
            DataSources.DSFellowship.CDEDARETDataTable dt = new DataSources.DSFellowship.CDEDARETDataTable();

            GridView GV = (GridView)gridControlData.MainView;
            Fellowship.DataSources.DSFellowship.TblMemberRow row = (Fellowship.DataSources.DSFellowship.TblMemberRow)GV.GetFocusedDataRow();

            if (row == null || row.IsSyndicateIdNull())
            {
                dt = cDEDARETTableAdapter.GetData();
            }
            else
            {
                dt = cDEDARETTableAdapter.GetDataBy(row.SyndicateId);
            }

            GridLookUpEdit lue = (GridLookUpEdit)sender;
            lue.Properties.DataSource = dt;
            lue.Properties.DisplayMember = "EDARET";
            lue.Properties.ValueMember = "EdaraId";
        }        
        private void repositoryItemGridLookUpEditEdaraId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
            {
                using (CodeFrm Code = new CodeFrm(Types.TablesNames.CDEDARET))
                {
                    Code.ShowDialog();
                }
                cDEDARETTableAdapter.Fill(dSFellowship.CDEDARET);
            }
        }
        private void repositoryItemGridLookUpEditSyndicateId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
            {
                using (CodeFrm Code = new CodeFrm(Types.TablesNames.CDSyndicate))
                {
                    Code.ShowDialog();
                }
                cDSyndicateTableAdapter.Fill(dSFellowship.CDSyndicate);
            }
        }
        private void repositoryItemGridLookUpEditStateID_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
            {
                using (CodeFrm Code = new CodeFrm(Types.TablesNames.CDState))
                {
                    Code.ShowDialog();
                }
                cDStateTableAdapter.Fill(dSFellowship.CDState);
            }
        }
        private void gridViewData_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            DataRowView DRV = (DataRowView)e.Row;
            if (e.ErrorText.Contains("MemberID"))
            {
                //e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
                DRV["MemberID"] = "-1";
                return;
            }
        }       
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView GV = (GridView)gridControlData.MainView;
            Fellowship.DataSources.DSFellowship.TblMemberRow row = (Fellowship.DataSources.DSFellowship.TblMemberRow)GV.GetFocusedDataRow();
            Update(row);
        }
        private void repositoryItemButtonEditDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView GV = (GridView)gridControlData.MainView;
            Fellowship.DataSources.DSFellowship.TblMemberRow row = (Fellowship.DataSources.DSFellowship.TblMemberRow)GV.GetFocusedDataRow();
            
            if (row.RowState == DataRowState.Detached)
                return;

            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            try
            {
                tblMemberTableAdapter.Delete(row.MemberID);
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
            DataSources.DSFellowship.TblMemberRow row = dSFellowship.TblMember.NewTblMemberRow();
            Update(row);
        }
        private void Update(DataSources.DSFellowship.TblMemberRow row)
        {
            using (TblMemberWFrm frm = new TblMemberWFrm(row))
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                    return;
            }
            try
            {
                if (row.RowState == DataRowState.Detached)
                {
                    row.MemberID = Convert.ToInt32(SqlDB.GetNewID("TblMember", "MemberID"));
                    dSFellowship.TblMember.AddTblMemberRow(row);
                }
                tblMemberBindingSource.EndEdit();
                tblMemberTableAdapter.Update(row);
                dSFellowship.TblMember.AcceptChanges();

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