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
using FXFW;

namespace Members
{
    public partial class TBLMemberCardFrm : DevExpress.XtraEditors.XtraForm
    {
        
        #region -   Functions   -
        public TBLMemberCardFrm()
        {
            InitializeComponent();
        }
        private void LoadDefaultData(CodeFrm.TableNames SelectedTable)
        {
            switch (SelectedTable)
            {
                case CodeFrm.TableNames.All:
                    //TBL_Emp
                    repositoryItemGridLookUpEditEmpID.DataSource = SQLProvider.SelectTBL_Emp();
                    repositoryItemGridLookUpEditEmpID.DisplayMember = "Emp_Name";
                    repositoryItemGridLookUpEditEmpID.ValueMember = "EmpID";
                    //TBLHafza
                    repositoryItemGridLookUpEditHafzaId.DataSource = SQLProvider.SelectTBLHafza();
                    repositoryItemGridLookUpEditHafzaId.DisplayMember = "HafzaId";
                    repositoryItemGridLookUpEditHafzaId.ValueMember = "HafzaId";
                    //TBLMembers
                    DataTable TBLMembers = SQLProvider.SelectTBLMembersList();
                    repositoryItemGridLookUpEditMemberId.DataSource = TBLMembers;
                    repositoryItemGridLookUpEditMemberId.DisplayMember = "MemberName";
                    repositoryItemGridLookUpEditMemberId.ValueMember = "MemberId";

                    repositoryItemGridLookUpEditMemberId2.DataSource = TBLMembers;
                    repositoryItemGridLookUpEditMemberId2.DisplayMember = "MemberName";
                    repositoryItemGridLookUpEditMemberId2.ValueMember = "MemberId";
                    //CDEstefaaKed
                    repositoryItemGridLookUpEditEstefaaKedId.DataSource = SQLProvider.SelectCDEstefaaKed();
                    repositoryItemGridLookUpEditEstefaaKedId.DisplayMember = "EstefaaKed";
                    repositoryItemGridLookUpEditEstefaaKedId.ValueMember = "EstefaaKedId";
                    break;
                case CodeFrm.TableNames.CDEstefaaKed:
                    //CDEstefaaKed
                    repositoryItemGridLookUpEditEstefaaKedId.DataSource = SQLProvider.SelectCDEstefaaKed();
                    repositoryItemGridLookUpEditEstefaaKedId.DisplayMember = "EstefaaKed";
                    repositoryItemGridLookUpEditEstefaaKedId.ValueMember = "EstefaaKedId";
                    break;
                default:
                    break;
            }
        }
        private void LoadGrid()
        {
            gridControlData.DataSource = SQLProvider.SelectTBLMemberCard();
            gridControlDataEx.DataSource = SQLProvider.SelectTBLMemberEstefaa();
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
            return;//ActivePrivReady
            bool Selecting = false, Inserting = false, Updateing = false, Deleting = false;
            SQLProvider.GetFormPriv(this.Name, ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
            gridControlData.Visible = Selecting;

            if (Inserting || Updateing)
            {
                repositoryItemButtonEditSave.Buttons[0].Visible = true;
                repositoryItemButtonEditSaveEx.Buttons[0].Visible = true;
            }
            else
            {
                repositoryItemButtonEditSave.Buttons[0].Visible = false;
                repositoryItemButtonEditSaveEx.Buttons[0].Visible = false;
            }
            repositoryItemButtonEditDel.Buttons[0].Visible = Deleting;
            repositoryItemButtonEditDelEx.Buttons[0].Visible = Deleting;
        }
#endregion
        #region - Event Handlers -
        private void stu_nashatFrm_Load(object sender, EventArgs e)
        {
            ActivePriv();
            LoadDefaultData(CodeFrm.TableNames.All);
            LoadGrid();
        }
        private void repositoryItemGridLookUpEditHafzaId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            TBLPrintCardFrm Frm = new TBLPrintCardFrm();
            Frm.ShowDialog();
            LoadDefaultData(CodeFrm.TableNames.All);
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataRow row = gridViewData.GetFocusedDataRow();

            try
            {
                if (row["org_MemberId"].ToString() == string.Empty)
                    SQLProvider.InsertTBLMemberCard(row["MemberId"].ToString(), row["ComeDate"].ToString(), row["HafzaId"].ToString(), row["ReciveDate"].ToString(), row["reciveperson"].ToString(), row["emprecive"].ToString(), row["recive"].ToString());
                else
                    SQLProvider.UpdateTBLMemberCard(row["MemberId"].ToString(), row["ComeDate"].ToString(), row["HafzaId"].ToString(), row["ReciveDate"].ToString(), row["reciveperson"].ToString(), row["emprecive"].ToString(), row["recive"].ToString(), row["org_MemberId"].ToString());
                Program.ShowMsg("تم الحفظ", false, this);
                Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
                LoadGrid();
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(SqlDB.CheckExp(ex), true, this, true);
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
                SQLProvider.DeleteTBLMemberCard(row["org_MemberId"].ToString());
                Program.ShowMsg("تم الحذف", false, this);
                Program.Logger.LogThis("تم الحذف", Text, FXFW.Logger.OpType.success, null, null, this);
                LoadGrid();
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void repositoryItemGridLookUpEditEstefaaKedId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDEstefaaKed);
            FrmCode.ShowDialog();
            LoadDefaultData(CodeFrm.TableNames.CDEstefaaKed);
        }
        private void repositoryItemButtonEditpathattach_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataRow row = gridViewDataEx.GetFocusedDataRow();
            switch (e.Button.Kind)
            {

                case DevExpress.XtraEditors.Controls.ButtonPredefines.Down:
                    if (File.Exists(String.Format("{0}\\{1}", Program.FilesPath, row["pathattach"])))
                        System.Diagnostics.Process.Start(String.Format("{0}\\{1}", Program.FilesPath, row["pathattach"]));
                    break;
                case DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis:
                    OpenFileDialog OFD = new OpenFileDialog();

                    if (OFD.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                        return;
                    if (File.Exists(OFD.FileName))
                    {
                        string NewFileName = String.Format("{0}{1}{2}{3}{4}{5}{6}", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day,
                            DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, OFD.SafeFileName);
                        File.Copy(OFD.FileName, String.Format("{0}\\{1}", Program.FilesPath, NewFileName));//Copy File
                        row["pathattach"] = NewFileName;
                    }
                    break;
                case DevExpress.XtraEditors.Controls.ButtonPredefines.Delete:
                    if (MessageBox.Show("هل انت متأكد؟", "حذف ملف", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Cancel)
                        return;
                    if (File.Exists(String.Format("{0}\\{1}", Program.FilesPath, row["pathattach"])))
                        File.Delete(String.Format("{0}\\{1}", Program.FilesPath, row["pathattach"]));
                    row["pathattach"] = string.Empty;
                    break;
                default:
                    break;
            }


        }
        private void repositoryItemButtonEditSaveEx_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataRow row = gridViewDataEx.GetFocusedDataRow();

            try
            {
                if (row["org_MemberId"].ToString() == string.Empty)
                    SQLProvider.InsertTBLMemberEstefaa(row["MemberId"].ToString(), row["EstefaaKedId"].ToString(), row["EstefaaKedIdyn"].ToString(), row["pathattach"].ToString());
                else
                    SQLProvider.UpdateTBLMemberEstefaa(row["MemberId"].ToString(), row["EstefaaKedId"].ToString(), row["EstefaaKedIdyn"].ToString(), row["pathattach"].ToString(), row["org_MemberId"].ToString(), row["org_EstefaaKedId"].ToString());
                Program.ShowMsg("تم الحفظ", false, this);
                Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
                LoadGrid();
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void repositoryItemButtonEditDelEx_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            DataRow row = gridViewDataEx.GetFocusedDataRow();
            if (row["org_MemberId"].ToString() == string.Empty)
            {
                LoadGrid();
                return;
            }
            try
            {
                SQLProvider.DeleteTBLMemberEstefaa(row["org_MemberId"].ToString(), row["org_EstefaaKedId"].ToString());
                if (File.Exists(String.Format("{0}\\{1}", Program.FilesPath, row["pathattach"])))
                    File.Delete(String.Format("{0}\\{1}", Program.FilesPath, row["pathattach"]));
                Program.ShowMsg("تم الحذف", false, this);
                Program.Logger.LogThis("تم الحذف", Text, FXFW.Logger.OpType.success, null, null, this);
                LoadGrid();
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        #endregion

        
    }
}