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

namespace Synricate
{
    public partial class TBLMeetingFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Functions   -
        public TBLMeetingFrm()
        {
            InitializeComponent();
        }
        private void LoadDefaultData(CodeFrm.TableNames SelectedTable)
        {
            switch (SelectedTable)
            {
                case CodeFrm.TableNames.All:
                    //CDSubCommitte
                    LUESubCommitteId.Properties.DataSource = SQLProvider.SelectCDSubCommitte();
                    //CDSCommitte
                    LUELagnaNoaeaId.Properties.DataSource = SQLProvider.SelectCDSCommitte();
                    //TBLSCommitteMember
                    if (FXFW.SqlDB.IsNullOrEmpty(LUETBLMeeting.EditValue))
                        repositoryItemGridLookUpEditMemberId.DataSource = new DataTable();
                    else
                    {
                        DataRowView row = (DataRowView)LUETBLMeeting.GetSelectedDataRow();
                        repositoryItemGridLookUpEditMemberId.DataSource = SQLProvider.SelectTBLSCommitteMember(row["LagnaNoaeaId"], row["SubCommitteId"]);
                    }
                    //CDMetingState
                    repositoryItemGridLookUpEditMetingStateId.DataSource = SQLProvider.SelectCDMetingState();
                    break;
                case CodeFrm.TableNames.CDSubCommitte:
                    //CDSubCommitte
                    LUESubCommitteId.Properties.DataSource = SQLProvider.SelectCDSubCommitte();
                    break;
                case CodeFrm.TableNames.CDSCommitte:
                    //CDSCommitte
                    LUELagnaNoaeaId.Properties.DataSource = SQLProvider.SelectCDSCommitte();
                    break;
                case CodeFrm.TableNames.TBLSCommitteMember:
                    //TBLSCommitteMember
                    if (FXFW.SqlDB.IsNullOrEmpty(LUETBLMeeting.EditValue))
                        repositoryItemGridLookUpEditMemberId.DataSource = new DataTable();
                    else
                    {
                        DataRowView row = (DataRowView)LUETBLMeeting.GetSelectedDataRow();
                        repositoryItemGridLookUpEditMemberId.DataSource = SQLProvider.SelectTBLSCommitteMember(row["LagnaNoaeaId"], row["SubCommitteId"]);
                    }
                    break;
                case CodeFrm.TableNames.CDMetingState:
                    //CDMetingState
                    repositoryItemGridLookUpEditMetingStateId.DataSource = SQLProvider.SelectCDMetingState();
                    break;
                default:
                    break;
            }
        }
        private void LoadData()
        {
            LUETBLMeeting.Properties.DataSource = SQLProvider.SelectTBLMeeting();
        }
        private void LoadGridEx()
        {
            if (FXFW.SqlDB.IsNullOrEmpty(LUETBLMeeting.EditValue))
                gridControlData1.DataSource = SQLProvider.SelectTBLMeetingMember();
            else
                gridControlData1.DataSource = SQLProvider.SelectTBLMeetingMember(LUETBLMeeting.EditValue);

            if (FXFW.SqlDB.IsNullOrEmpty(LUETBLMeeting.EditValue))
                gridControlData2.DataSource = null;
            else
                gridControlData2.DataSource = SQLProvider.SelectTBLmdescion(LUETBLMeeting.EditValue);
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
        private void ActiveKeyDownEventGrid1(object sender, KeyEventArgs e)
        {
            if (e.KeyData != Keys.F5 && e.KeyData != Keys.F6 && e.KeyData != Keys.F10 && e.KeyData != Keys.F8)
                return;
            switch (e.KeyData)
            {
                case Keys.F1:
                    break;
                case Keys.F5:
                    ((DataTable)gridControlData1.DataSource).Rows.Add(((DataTable)gridControlData1.DataSource).NewRow());
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
        private void ActiveKeyDownEventGrid2(object sender, KeyEventArgs e)
        {
            if (e.KeyData != Keys.F5 && e.KeyData != Keys.F6 && e.KeyData != Keys.F10 && e.KeyData != Keys.F8)
                return;
            switch (e.KeyData)
            {
                case Keys.F1:
                    break;
                case Keys.F5:
                    ((DataTable)gridControlData2.DataSource).Rows.Add(((DataTable)gridControlData2.DataSource).NewRow());
                    break;
                case Keys.F6:
                    repositoryItemButtonEditSave2_ButtonClick(repositoryItemButtonEditSave, new DevExpress.XtraEditors.Controls.ButtonPressedEventArgs(new DevExpress.XtraEditors.Controls.EditorButton()));
                    break;
                case Keys.F8:
                    repositoryItemButtonEditDel2_ButtonClick(repositoryItemButtonEditDel, new DevExpress.XtraEditors.Controls.ButtonPressedEventArgs(new DevExpress.XtraEditors.Controls.EditorButton()));
                    break;
                case Keys.F10:
                    repositoryItemButtonEditSave2_ButtonClick(repositoryItemButtonEditSave, new DevExpress.XtraEditors.Controls.ButtonPressedEventArgs(new DevExpress.XtraEditors.Controls.EditorButton()));
                    break;
                default:
                    break;
            }
        }
        private void ActivePriv()
        {
            return;
            bool Selecting = false, Inserting = false, Updateing = false, Deleting = false;
            FXFW.SqlDB.GetFormPriv("Retirement" + Name.Replace("Frm", ""), ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
            xtraTabControlMain.Visible = Selecting;
            btnNew.Visible = Inserting;
            btnUpdate.Visible = Updateing;
            btnDelete.Visible = Deleting;
            if (Inserting || Updateing)
            {
                //repositoryItemButtonEditCDRelativeCodeSave.Buttons[0].Enabled = true;
                //repositoryItemButtonEditrem_sudSave.Buttons[0].Enabled = true;
            }
            else
            {
                //repositoryItemButtonEditCDRelativeCodeSave.Buttons[0].Enabled = false;
                //repositoryItemButtonEditrem_sudSave.Buttons[0].Enabled = false;
            }
            if (Deleting)
            {
                //repositoryItemButtonEditCDRelativeCodeDel.Buttons[0].Enabled = true;
                //repositoryItemButtonEditrem_sudDel.Buttons[0].Enabled = true;
            }
            else
            {
                //repositoryItemButtonEditCDRelativeCodeDel.Buttons[0].Enabled = false;
                //repositoryItemButtonEditrem_sudDel.Buttons[0].Enabled = false;
            }
        }
        #endregion
        #region - Event Handlers -
        private void TBLMeetingFrm_Load(object sender, EventArgs e)
        {
            ActivePriv();
            LoadDefaultData(CodeFrm.TableNames.All);
            LoadData();
        }
        private void LUETBLMeeting_EditValueChanged(object sender, EventArgs e)
        {
            if (LUETBLMeeting.EditValue == null)
            {
                btnNew_Click(btnNew, new EventArgs());
                btnUpdate.Enabled = false;
                btnSave.Enabled = false;
                return;
            }
            if (LUETBLMeeting.ItemIndex == -1)
            {
                btnNew_Click(btnNew, new EventArgs());
                btnUpdate.Enabled = false;
                btnSave.Enabled = false;
                return;
            }
            LoadDefaultData(CodeFrm.TableNames.TBLSCommitteMember);// Load Members Depand on Meeting


            DataRow row = ((DataTable)LUETBLMeeting.Properties.DataSource).Rows[LUETBLMeeting.ItemIndex];


            DEMDate.EditValue = row["MDate"];
            TEMTime.EditValue = row["MTime"];
            LUESubCommitteId.EditValue = row["SubCommitteId"];
            LUELagnaNoaeaId.EditValue = row["LagnaNoaeaId"];
            tbfilepath.Text = row["filepath"].ToString();
            

            LoadGridEx();

            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
            xtraTabPageBEradat.PageVisible = true;
            xtraTabPageMasrofat.PageVisible = true;
            //refresh data inside controls
            for (int i = 0; i < xtraTabControlMain.TabPages.Count; i++)
                xtraTabControlMain.SelectedTabPageIndex = i;
            xtraTabControlMain.SelectedTabPageIndex = 0;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            DEMDate.EditValue = null;
            TEMTime.EditValue = null;
            LUESubCommitteId.EditValue = null;
            LUELagnaNoaeaId.EditValue = null;
            tbfilepath.Text = string.Empty;
           
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            xtraTabPageBEradat.PageVisible = false;
            xtraTabPageMasrofat.PageVisible = false;
        }
        private void LUESubCommitteId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDSubCommitte);
            FrmCode.ShowDialog();
            LoadDefaultData(CodeFrm.TableNames.CDSubCommitte);
        }
        private void LUELagnaNoaeaId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDSCommitte);
            FrmCode.ShowDialog();
            LoadDefaultData(CodeFrm.TableNames.CDSCommitte);
        }
        private void tbfilepath_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.OK)
            {
                if (File.Exists(Program.FilesPath + tbfilepath.Text))
                    System.Diagnostics.Process.Start(Program.FilesPath + tbfilepath.Text);
                return;
            }

            OpenFileDialog OFD = new OpenFileDialog();
            if (OFD.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                return;
            string FileName = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString()
                + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + OFD.SafeFileName;
            if (File.Exists(OFD.FileName))
            {
                File.Copy(OFD.FileName, Program.FilesPath + FileName);

                tbfilepath.Text = FileName;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SQLProvider.InsertTBLMeeting(DEMDate.EditValue, TEMTime.EditValue, LUESubCommitteId.EditValue, LUELagnaNoaeaId.EditValue, tbfilepath.Text);
                Program.ShowMsg("تم الاضافه", false, this);
                Program.Logger.LogThis("تم الاضافه", Text, FXFW.Logger.OpType.success, null, null, this);
                LoadData();
                LoadGridEx();
                LUETBLMeeting.ItemIndex = LUETBLMeeting.Properties.DropDownRows;
                xtraTabPageBEradat.PageVisible = true;
                xtraTabPageMasrofat.PageVisible = true;
                xtraTabControlMain.SelectedTabPage = xtraTabPageBEradat;
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (FXFW.SqlDB.IsNullOrEmpty(LUETBLMeeting.EditValue))
                return;
            try
            {
                SQLProvider.UpdateTBLMeeting(LUETBLMeeting.EditValue, DEMDate.EditValue, TEMTime.EditValue, LUESubCommitteId.EditValue, LUELagnaNoaeaId.EditValue, tbfilepath.Text);
                Program.ShowMsg("تم الاضافه", false, this);
                Program.ShowMsg("تم التعديل", false, this);
                Program.Logger.LogThis("تم التعديل", Text, FXFW.Logger.OpType.success, null, null, this);
                LoadData();
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (LUETBLMeeting.EditValue == null)
                return;
            if (LUETBLMeeting.ItemIndex == -1)
                return;
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            try
            {
                SQLProvider.DeleteTBLMeeting(LUETBLMeeting.EditValue);
                Program.ShowMsg("تم الحذف", false, this);
                Program.Logger.LogThis("تم الحذف", Text, FXFW.Logger.OpType.success, null, null, this);
                LoadData();
                btnNew_Click(btnNew, new EventArgs());
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                DataRow row = gridViewData1.GetFocusedDataRow();
                if (row["org_MemberId"].ToString() == string.Empty)
                {
                    SQLProvider.InsertTBLMeetingMember(LUETBLMeeting.EditValue, row["MemberId"], row["MetingStateId"], row["HodorTime"], row["Mrem"]);
                }
                else
                {
                    SQLProvider.UpdateTBLMeetingMember(LUETBLMeeting.EditValue, row["MemberId"], row["MetingStateId"], row["HodorTime"], row["Mrem"],
                        LUETBLMeeting.EditValue, row["org_MemberId"]);
                }
                LoadGridEx();
                Program.ShowMsg("تم التعديل", false, this);
                Program.Logger.LogThis("تم التعديل", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void repositoryItemButtonEditDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            try
            {
                DataRow row = gridViewData1.GetFocusedDataRow();
                if (row["org_MemberId"].ToString() != string.Empty)
                    SQLProvider.DeleteTBLMeetingMember(row["org_MId"], row["org_MemberId"]);
                LoadGridEx();
                Program.ShowMsg("تم الحذف", false, this);
                Program.Logger.LogThis("تم الحذف", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void repositoryItemButtonEditSave2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                DataRow row = gridViewData2.GetFocusedDataRow();
                if (row["org_MId"].ToString() == string.Empty)
                {
                    SQLProvider.InsertTBLmdescion(LUETBLMeeting.EditValue, row["MdescNu"], row["Mdesc"], row["MFollow"]);
                }
                else
                {
                    SQLProvider.UpdateTBLmdescion(row["org_MId"], row["MdescNu"], row["Mdesc"], row["MFollow"], row["org_MId"], row["org_MdescNu"]);
                }
                LoadGridEx();
                Program.ShowMsg("تم التعديل", false, this);
                Program.Logger.LogThis("تم التعديل", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void repositoryItemButtonEditDel2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            try
            {
                DataRow row = gridViewData2.GetFocusedDataRow();
                if (row["org_MId"].ToString() != string.Empty)
                    SQLProvider.DeleteTBLmdescion(row["org_MId"], row["org_MdescNu"]);
                LoadGridEx();
                Program.ShowMsg("تم الحذف", false, this);
                Program.Logger.LogThis("تم الحذف", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        #endregion         #region -   Variables   -
        
    }
}

