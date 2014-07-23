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
    public partial class TBLPlanFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Functions   -
        public TBLPlanFrm()
        {
            InitializeComponent();
        }
        private void LoadDefaultData(CodeFrm.TableNames SelectedTable)
        {
            switch (SelectedTable)
            {
                case CodeFrm.TableNames.All:
                    LUELagnaNoaeaId.Properties.DataSource = SQLProvider.SelectCDSCommitte();
                    LUESubCommitteId.Properties.DataSource = SQLProvider.SelectCDSubCommitte();
                    LUEyearId.Properties.DataSource = SQLProvider.SelectCDYear();
                    LUEmonthId.Properties.DataSource = SQLProvider.SelectCDMonth();
                    repositoryItemGridLookUpEditMemberId.DataSource = SQLProvider.SelectTBLMember();
                    break;
                case CodeFrm.TableNames.CDSCommitte:
                    LUELagnaNoaeaId.Properties.DataSource = SQLProvider.SelectCDSCommitte();
                    break;
                case CodeFrm.TableNames.CDSubCommitte:
                    LUESubCommitteId.Properties.DataSource = SQLProvider.SelectCDSubCommitte();
                    break;
                case CodeFrm.TableNames.CDYear:
                    LUEyearId.Properties.DataSource = SQLProvider.SelectCDYear();
                    break;
                case CodeFrm.TableNames.CDMonth:
                    LUEmonthId.Properties.DataSource = SQLProvider.SelectCDMonth();
                    break;
                default:
                    break;
            }
        }
        private void LoadData()
        {
            LUETBLPlan.Properties.DataSource = SQLProvider.SelectTBLPlan();
        }
        private void LoadGridEx()
        {
            if (FXFW.SqlDB.IsNullOrEmpty(LUETBLPlan.EditValue))
                gridControlData1.DataSource = null;
            else
                gridControlData1.DataSource = SQLProvider.SelectTBLPlandetials(LUETBLPlan.EditValue);
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
        private void TBLPlanFrm_Load(object sender, EventArgs e)
        {
            ActivePriv();
            LoadDefaultData(CodeFrm.TableNames.All);
            LoadData();
        }
        private void LUETBLPlan_EditValueChanged(object sender, EventArgs e)
        {
            if (LUETBLPlan.EditValue == null)
            {
                btnNew_Click(btnNew, new EventArgs());
                btnUpdate.Enabled = false;
                btnSave.Enabled = false;
                return;
            }
            if (LUETBLPlan.ItemIndex == -1)
            {
                btnNew_Click(btnNew, new EventArgs());
                btnUpdate.Enabled = false;
                btnSave.Enabled = false;
                return;
            }
            LoadDefaultData(CodeFrm.TableNames.TBLSCommitteMember);// Load Members Depand on Meeting


            DataRow row = ((DataTable)LUETBLPlan.Properties.DataSource).Rows[LUETBLPlan.ItemIndex];


            LUEyearId.EditValue = row["yearId"];
            LUEmonthId.EditValue = row["monthId"];
            LUESubCommitteId.EditValue = row["SubCommitteId"];
            LUELagnaNoaeaId.EditValue = row["LagnaNoaeaId"];

            LoadGridEx();

            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
            xtraTabPageEx1.PageVisible = true;
            //refresh data inside controls
            for (int i = 0; i < xtraTabControlMain.TabPages.Count; i++)
                xtraTabControlMain.SelectedTabPageIndex = i;
            xtraTabControlMain.SelectedTabPageIndex = 0;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            LUEyearId.EditValue = null;
            LUEmonthId.EditValue = null;
            LUESubCommitteId.EditValue = null;
            LUELagnaNoaeaId.EditValue = null;
           
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            xtraTabPageEx1.PageVisible = false;
            
        }
        private void LUEyearId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDYear);
            FrmCode.ShowDialog();
            LoadDefaultData(CodeFrm.TableNames.CDYear);
        }
        private void LUEmonthId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDMonth);
            FrmCode.ShowDialog();
            LoadDefaultData(CodeFrm.TableNames.CDMonth);
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
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SQLProvider.InsertTBLPlan(LUEyearId.EditValue, LUEmonthId.EditValue, LUESubCommitteId.EditValue, LUELagnaNoaeaId.EditValue);
                Program.ShowMsg("تم الاضافه", false, this);
                Program.Logger.LogThis("تم الاضافه", Text, FXFW.Logger.OpType.success, null, null, this);
                LoadData();
                LoadGridEx();
                LUETBLPlan.ItemIndex = LUETBLPlan.Properties.DropDownRows;
                xtraTabPageEx1.PageVisible = true;
                xtraTabControlMain.SelectedTabPage = xtraTabPageEx1;
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (FXFW.SqlDB.IsNullOrEmpty(LUETBLPlan.EditValue))
                return;
            try
            {
                SQLProvider.UpdateTBLPlan(LUETBLPlan.EditValue, LUEyearId.EditValue, LUEmonthId.EditValue, LUESubCommitteId.EditValue, LUELagnaNoaeaId.EditValue);
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
            if (LUETBLPlan.EditValue == null)
                return;
            if (LUETBLPlan.ItemIndex == -1)
                return;
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            try
            {
                SQLProvider.DeleteTBLPlan(LUETBLPlan.EditValue);
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
                if (row["org_plandetialId"].ToString() == string.Empty)
                {
                    SQLProvider.InsertTBLPlandetials(LUETBLPlan.EditValue, row["plandetialdate"], row["plandetial"], row["MemberId"], row["rem"], row["tam"],
                        row["PPERCENT"], row["DEF"]);
                }
                else
                {
                    SQLProvider.UpdateTBLPlandetials(row["plandetialId"], LUETBLPlan.EditValue, row["plandetialdate"], row["plandetial"], row["MemberId"], row["rem"], row["tam"],
                        row["PPERCENT"], row["DEF"], row["org_plandetialId"], row["org_planId"]);
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
                if (row["org_plandetialId"].ToString() != string.Empty)
                    SQLProvider.DeleteTBLPlandetials(row["org_plandetialId"], row["org_planId"]);
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

