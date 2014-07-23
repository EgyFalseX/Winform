using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Imaging;
using DevExpress.XtraExport;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;

namespace Members
{
    public partial class TBLMemberOldFrm : DevExpress.XtraEditors.XtraForm
    {

        #region -   Functions   -
        public TBLMemberOldFrm()
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
                    FindCtr(this, "new");
                    break;
                case Keys.F6:
                    FindCtr(this, "save");
                    break;
                case Keys.F8:
                    FindCtr(this, "delete");
                    break;
                case Keys.F10:
                    FindCtr(this, "update");
                    break;
                default:
                    break;
            }

        }
        private static void FindCtr(Control MyControls, string tag)
        {
            foreach (Control ctr in MyControls.Controls)
            {
                if (ctr.HasChildren == true)
                {
                    FindCtr(ctr, tag);
                    continue;
                }
                if (ctr is SimpleButton)
                {
                    if (((SimpleButton)ctr).Tag.ToString() == tag)
                        ((SimpleButton)ctr).PerformClick();
                }
            }
        }
        private void ActivePriv()
        {
            //return;//ActivePrivReady
            bool Selecting = false, Inserting = false, Updateing = false, Deleting = false;
            SQLProvider.GetFormPriv(this.Name, ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
            LUEEmp.Visible = Selecting;
            btnNew.Visible = Inserting; btnSave.Visible = Inserting;
            btnUpdate.Visible = Updateing;
            btnDelete.Visible = Deleting;
        }
        #endregion
        #region - Event Handlers -
        private void TBL_EmpFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsTeachersUnion.CDSyndicate' table. You can move, or remove it, as needed.
            this.cDSyndicateTableAdapter.Fill(this.dsTeachersUnion.CDSyndicate);
            // TODO: This line of code loads data into the 'dsTeachersUnion.TBLMemberOld' table. You can move, or remove it, as needed.
            this.tBLMemberOldTableAdapter.Fill(this.dsTeachersUnion.TBLMemberOld);
            ActivePriv();
            this.Disposed += TBLMembersFast2Frm_Disposed;
        }
        private void LUEEmp_EditValueChanged(object sender, EventArgs e)
        {
            if (LUEEmp.EditValue == null)
            {
                btnNew_Click(btnNew, EventArgs.Empty);
                btnUpdate.Enabled = false;
                btnSave.Enabled = false;
                btnDelete.Enabled = false;
                return;
            }

            DataSources.dsTeachersUnion.TBLMemberOldRow row = (DataSources.dsTeachersUnion.TBLMemberOldRow)((DataRowView)LUEEmp.GetSelectedDataRow()).Row;

            //tbMemberName.DataBindings.Clear(); tbMemberName.DataBindings.Add("EditValue", row, "MemberName", true, DataSourceUpdateMode.OnPropertyChanged, DBNull.Value);
            //tbesalno.DataBindings.Clear(); tbesalno.DataBindings.Add("EditValue", row, "esalno", true, DataSourceUpdateMode.OnPropertyChanged, DBNull.Value);
            //tbKideNumber.DataBindings.Clear(); tbKideNumber.DataBindings.Add("EditValue", row, "KideNumber", true, DataSourceUpdateMode.OnPropertyChanged, DBNull.Value);
            //LUESyndicateId.DataBindings.Clear(); LUESyndicateId.DataBindings.Add("EditValue", row, "SyndicateId", true, DataSourceUpdateMode.OnPropertyChanged, DBNull.Value);
            //LUESubCommitteId.DataBindings.Clear(); LUESubCommitteId.DataBindings.Add("EditValue", row, "SubCommitteId", true, DataSourceUpdateMode.OnPropertyChanged, DBNull.Value);


            tbMemberName.EditValue = row.MemberName;
            tbKideNumber.EditValue = row.KideNumber;
            tbesalno.EditValue = row.esalno;
            LUESyndicateId.EditValue = row.SyndicateId;
            LUESyndicateId_EditValueChanged(LUESyndicateId, new EventArgs());
            if (row.IsSubCommitteIdNull())
                LUESubCommitteId.EditValue = null;
            else
                LUESubCommitteId.EditValue = row.SubCommitteId;

            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;

        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            LUEEmp.EditValue = null;

            tbMemberName.EditValue = string.Empty;
            tbKideNumber.EditValue = string.Empty;
            tbesalno.EditValue = 1000;
            LUESyndicateId.EditValue = null;
            LUESubCommitteId.EditValue = null;

            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            tbMemberName.Focus();
        }
        private void LUESyndicateId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDSyndicate);
            FrmCode.ShowDialog();
            //Load
        }
        private void LUESubCommitteId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDSubCommitte);
            FrmCode.ShowDialog();
            //Load
        }
        private void LUESyndicateId_EditValueChanged(object sender, EventArgs e)
        {
            if (LUESyndicateId.EditValue == null || LUESyndicateId.EditValue.ToString() == string.Empty)
                return;
            // TODO: This line of code loads data into the 'dsTeachersUnion.CDSubCommitte' table. You can move, or remove it, as needed.
            this.cDSubCommitteTableAdapter.FillBySyndicateId(this.dsTeachersUnion.CDSubCommitte, Convert.ToInt32(LUESyndicateId.EditValue));
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbMemberName.EditValue == null || tbMemberName.EditValue.ToString() == string.Empty ||
                LUESyndicateId.EditValue == null || LUESyndicateId.EditValue.ToString() == string.Empty ||
                tbKideNumber.EditValue == null || tbKideNumber.EditValue.ToString() == string.Empty ||
                tbesalno.EditValue == null || tbesalno.EditValue.ToString() == string.Empty)
            {
                Program.ShowMsg("بيانات غير مكتملة", true, this, true);
                return;
            }

            int KideNumber = Convert.ToInt32(tbKideNumber.EditValue);

            DataSources.dsTeachersUnionTableAdapters.TBLMembersTableAdapter adpMem = new DataSources.dsTeachersUnionTableAdapters.TBLMembersTableAdapter();
            DataSources.dsTeachersUnionTableAdapters.TBLMemberWebTableAdapter adpMemWeb = new DataSources.dsTeachersUnionTableAdapters.TBLMemberWebTableAdapter();
            if ((int)adpMem.ScalarQueryExistsKideNumber(KideNumber) != 0 ||
                (int)adpMemWeb.ScalarQueryExistsKideNumber(0, KideNumber) != 0 ||
                (int)tBLMemberOldTableAdapter.ScalarQueryExistsKideNumber(0, KideNumber) != 0)
            {
                Program.ShowMsg("رقم القيد موجود مسبقا", true, this, true);
                return;
            }

            DataSources.dsTeachersUnion.TBLMemberOldRow row = dsTeachersUnion.TBLMemberOld.NewTBLMemberOldRow();
            row.MemberoldId = (int)tBLMemberOldTableAdapter.ScalarQueryNewID();
            row.userin = Program.UserInfo.UserId;
            row.datein = SQLProvider.GetServerDateTime();
            row.MemberName = tbMemberName.EditValue.ToString();
            row.SyndicateId = Convert.ToInt32(LUESyndicateId.EditValue);
            if (LUESubCommitteId.EditValue != null && LUESubCommitteId.EditValue.ToString() != string.Empty)
                row.SubCommitteId = Convert.ToInt32(LUESubCommitteId.EditValue);
            row.KideNumber = KideNumber;
            row.esalno = Convert.ToInt32(tbesalno.EditValue);
            try
            {
                dsTeachersUnion.TBLMemberOld.AddTBLMemberOldRow(row);
                tBLMemberOldTableAdapter.Update(row);
                Program.ShowMsg("تم الاضافه", false, this);
                btnNew_Click(btnNew, EventArgs.Empty);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (FXFW.SqlDB.IsNullOrEmpty(LUEEmp.EditValue))
                return;
            if (tbMemberName.EditValue == null || tbMemberName.EditValue.ToString() == string.Empty ||
                LUESyndicateId.EditValue == null || LUESyndicateId.EditValue.ToString() == string.Empty ||
                tbKideNumber.EditValue == null || tbKideNumber.EditValue.ToString() == string.Empty ||
                tbesalno.EditValue == null || tbesalno.EditValue.ToString() == string.Empty)
            {
                Program.ShowMsg("بيانات غير مكتملة", true, this, true);
                return;
            }
            DataSources.dsTeachersUnion.TBLMemberOldRow row = (DataSources.dsTeachersUnion.TBLMemberOldRow)((DataRowView)LUEEmp.GetSelectedDataRow()).Row;

            int KideNumber = Convert.ToInt32(tbKideNumber.EditValue);

            DataSources.dsTeachersUnionTableAdapters.TBLMembersTableAdapter adpMem = new DataSources.dsTeachersUnionTableAdapters.TBLMembersTableAdapter();
            DataSources.dsTeachersUnionTableAdapters.TBLMemberWebTableAdapter adpMemWeb = new DataSources.dsTeachersUnionTableAdapters.TBLMemberWebTableAdapter();
            if ((int)adpMem.ScalarQueryExistsKideNumber(KideNumber) != 0 ||
                (int)adpMemWeb.ScalarQueryExistsKideNumber(0, KideNumber) != 0 ||
                (int)tBLMemberOldTableAdapter.ScalarQueryExistsKideNumber(row.MemberoldId, KideNumber) != 0)
            {
                Program.ShowMsg("رقم القيد موجود مسبقا", true, this, true);
                return;
            }

            try
            {
                row.userin = Program.UserInfo.UserId;
                row.MemberName = tbMemberName.EditValue.ToString();
                row.SyndicateId = Convert.ToInt32(LUESyndicateId.EditValue);
                if (LUESubCommitteId.EditValue != null && LUESubCommitteId.EditValue.ToString() != string.Empty)
                    row.SubCommitteId = Convert.ToInt32(LUESubCommitteId.EditValue);
                row.KideNumber = KideNumber;
                row.esalno = Convert.ToInt32(tbesalno.EditValue);

                tBLMemberOldBindingSource.EndEdit();
                tBLMemberOldTableAdapter.Update(row);
                dsTeachersUnion.TBLMemberOld.AcceptChanges();
               
                Program.ShowMsg("تم التعديل", false, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (LUEEmp.EditValue == null || LUEEmp.EditValue.ToString() == string.Empty)
                return;
            
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            DataSources.dsTeachersUnion.TBLMemberOldRow row = (DataSources.dsTeachersUnion.TBLMemberOldRow)((DataRowView)LUEEmp.GetSelectedDataRow()).Row;
            if (row.RowState == DataRowState.Detached)
            {
                tBLMemberOldTableAdapter.Fill(dsTeachersUnion.TBLMemberOld);
                return;
            }
            try
            {
                tBLMemberOldTableAdapter.Delete(row.MemberoldId);
                Program.ShowMsg("تم الحذف", false, this);
                btnNew_Click(btnNew, EventArgs.Empty);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        void TBLMembersFast2Frm_Disposed(object sender, EventArgs e)
        {
            //if (LUEEmp.Properties.DataSource.GetType() == typeof(DataTable))
            //{
            //    ((DataTable)LUEEmp.Properties.DataSource).Rows.Clear();
            //    ((DataTable)LUEEmp.Properties.DataSource).Dispose();
            //}
            GC.Collect();
        }
        #endregion

    }
}

