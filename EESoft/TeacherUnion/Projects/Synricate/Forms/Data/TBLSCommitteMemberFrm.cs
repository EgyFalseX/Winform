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

namespace Synricate
{
    public partial class TBLSCommitteMemberFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Functions   -
        public TBLSCommitteMemberFrm()
        {
            InitializeComponent();
        }
        private void LoadDefaultData(CodeFrm.TableNames TableName)
        {
            switch (TableName)
            {
                case CodeFrm.TableNames.All:
                    repositoryItemGridLookUpEditMemberId.DataSource = SQLProvider.SelectTBLMember();
                    repositoryItemGridLookUpEditLagnaNoaeaId.DataSource = SQLProvider.SelectCDSCommitte();
                    repositoryItemGridLookUpEditSubCommitteId.DataSource = SQLProvider.SelectCDSubCommitte();
                    repositoryItemGridLookUpEditCommittejopId.DataSource = SQLProvider.SelectCDCommitteJop();
                    break;
                case CodeFrm.TableNames.TBLMember:
                    repositoryItemGridLookUpEditMemberId.DataSource = SQLProvider.SelectTBLMember();
                    break;
                case CodeFrm.TableNames.CDSCommitte:
                    repositoryItemGridLookUpEditLagnaNoaeaId.DataSource = SQLProvider.SelectCDSCommitte();
                    break;
                case CodeFrm.TableNames.CDSubCommitte:
                    repositoryItemGridLookUpEditSubCommitteId.DataSource = SQLProvider.SelectCDSubCommitte();
                    break;
                case CodeFrm.TableNames.CDCommitteJop:
                    repositoryItemGridLookUpEditCommittejopId.DataSource = SQLProvider.SelectCDCommitteJop();
                    break;
                default:
                    break;
            }
        }
        private void LoadGrid()
        {
            gridControlData.DataSource = SQLProvider.SelectTBLSCommitteMember();
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
            SqlDB.GetFormPriv("Booking" + Name.Replace("Frm", ""), ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
            gridControlData.Visible = Selecting;
            if (Inserting || Updateing)
                repositoryItemButtonEditSave.Buttons[0].Enabled = true;
            else
                repositoryItemButtonEditSave.Buttons[0].Enabled = false;
            repositoryItemButtonEditDel.Buttons[0].Enabled = Deleting;
        }
#endregion
        #region - Event Handlers -
        private void TBLSCommitteMemberFrm_Load(object sender, EventArgs e)
        {
            ActivePriv();
            LoadDefaultData(CodeFrm.TableNames.All);
            LoadGrid();
        }
        private void repositoryItemGridLookUpEditMemberId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            using (TBLMemberFrm FrmTBLMember = new TBLMemberFrm())
            {
                FrmTBLMember.ShowDialog();
            }
            LoadDefaultData(CodeFrm.TableNames.TBLMember);
        }
        private void repositoryItemGridLookUpEditLagnaNoaeaId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            using (CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDSCommitte))
            {
                FrmCode.ShowDialog();
            }
            LoadDefaultData(CodeFrm.TableNames.CDSCommitte);
        }
        private void repositoryItemGridLookUpEditSubCommitteId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            using (CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDSubCommitte))
            {
                FrmCode.ShowDialog();
            }
            LoadDefaultData(CodeFrm.TableNames.CDSubCommitte);
        }
        private void repositoryItemGridLookUpEditCommittejopId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            using (CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDCommitteJop))
            {
                FrmCode.ShowDialog();
            }
            LoadDefaultData(CodeFrm.TableNames.CDCommitteJop);
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataRow row = gridViewData.GetFocusedDataRow();

            try
            {
                if (row["org_MemberId"].ToString() == string.Empty)
                    SQLProvider.InsertTBLSCommitteMember(row["MemberId"], row["LagnaNoaeaId"], row["SubCommitteId"], row["CommittejopId"], row["workstartdate"],
                        row["workenddate"]);
                else
                    SQLProvider.UpdateTBLSCommitteMember(row["MemberId"], row["LagnaNoaeaId"], row["SubCommitteId"], row["CommittejopId"], row["workstartdate"],
                        row["workenddate"], row["org_MemberId"], row["org_LagnaNoaeaId"], row["org_SubCommitteId"]);
                Program.ShowMsg("تم الحفظ", false, this);
                Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
                LoadGrid();
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
            DataRow row = gridViewData.GetFocusedDataRow();
            if (row["org_MemberId"].ToString() == string.Empty)
            {
                LoadGrid();
                return;
            }
            try
            {
                SQLProvider.DeleteTBLSCommitteMember(row["org_MemberId"], row["org_LagnaNoaeaId"], row["org_SubCommitteId"]);
                Program.ShowMsg("تم الحذف", false, this);
                Program.Logger.LogThis("تم الحذف", Text, FXFW.Logger.OpType.success, null, null, this);
                LoadGrid();
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