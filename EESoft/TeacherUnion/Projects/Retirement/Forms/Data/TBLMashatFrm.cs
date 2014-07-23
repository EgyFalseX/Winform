using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace Retirement
{
    public partial class TBLMashatFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Functions   -
        public TBLMashatFrm()
        {
            InitializeComponent();
        }
        private void LoadDefaultData(CodeFrm.TableNames SelectedTable)
        {
            switch (SelectedTable)
            {
                case CodeFrm.TableNames.CDGov:
                    //CDGov
                    LUEMMashataddresGov.Properties.DataSource = SQLProvider.SelectCDGov();
                    LUEMMashataddresGov.Properties.DisplayMember = "GOV";
                    LUEMMashataddresGov.Properties.ValueMember = "GovId";
                    break;
                case CodeFrm.TableNames.CDMarkez:
                    //CDMarkez
                    LUEMMashataddresMarkez.Properties.DataSource = SQLProvider.SelectCDMarkez();
                    LUEMMashataddresMarkez.Properties.DisplayMember = "Markez";
                    LUEMMashataddresMarkez.Properties.ValueMember = "MarkezId";
                    break;
                case CodeFrm.TableNames.CDSubCommitte:
                    //CDSubCommitte
                    LUESubCommitteId.Properties.DataSource = SQLProvider.SelectCDSubCommitte();
                    LUESubCommitteId.Properties.DisplayMember = "SubCommitte";
                    LUESubCommitteId.Properties.ValueMember = "SubCommitteId";
                    break;
                case CodeFrm.TableNames.CDSyndicate:
                    //CDSyndicate
                    LUESyndicateId.Properties.DataSource = SQLProvider.SelectCDSyndicate();
                    LUESyndicateId.Properties.DisplayMember = "Syndicate";
                    LUESyndicateId.Properties.ValueMember = "SyndicateId";
                    repositoryItemGridLookUpEditSyndicateId.DataSource = SQLProvider.SelectCDSyndicate();
                    repositoryItemGridLookUpEditSyndicateId.DisplayMember = "Syndicate";
                    repositoryItemGridLookUpEditSyndicateId.ValueMember = "SyndicateId";
                    break;
                case CodeFrm.TableNames.CDMashHala:
                    //CDMashHala
                    LUEMashHalaId.Properties.DataSource = SQLProvider.SelectCDMashHala();
                    LUEMashHalaId.Properties.DisplayMember = "MashHala";
                    LUEMashHalaId.Properties.ValueMember = "MashHalaId";
                    repositoryItemGridLookUpEditSarfHalaId.DataSource = SQLProvider.SelectCDMashHala();
                    repositoryItemGridLookUpEditSarfHalaId.DisplayMember = "MashHala";
                    repositoryItemGridLookUpEditSarfHalaId.ValueMember = "MashHalaId";
                    break;
                case CodeFrm.TableNames.CDWarasaType:
                    //CDMashHala
                    repositoryItemGridLookUpEditWarasaTypeId.DataSource = SQLProvider.SelectCDWarasaType();
                    repositoryItemGridLookUpEditWarasaTypeId.DisplayMember = "WarasaType";
                    repositoryItemGridLookUpEditWarasaTypeId.ValueMember = "WarasaTypeId";
                    break;
                case CodeFrm.TableNames.All:
                    //CDGender
                    LUEMMashatGender.Properties.DataSource = SQLProvider.SelectCDGender();
                    LUEMMashatGender.Properties.DisplayMember = "Gender";
                    LUEMMashatGender.Properties.ValueMember = "GenderId";    
                    //CDGov
                    LUEMMashataddresGov.Properties.DataSource = SQLProvider.SelectCDGov();
                    LUEMMashataddresGov.Properties.DisplayMember = "GOV";
                    LUEMMashataddresGov.Properties.ValueMember = "GovId";
                    //CDMarkez
                    LUEMMashataddresMarkez.Properties.DataSource = SQLProvider.SelectCDMarkez();
                    LUEMMashataddresMarkez.Properties.DisplayMember = "Markez";
                    LUEMMashataddresMarkez.Properties.ValueMember = "MarkezId";
                    //CDSubCommitte
                    LUESubCommitteId.Properties.DataSource = SQLProvider.SelectCDSubCommitte();
                    LUESubCommitteId.Properties.DisplayMember = "SubCommitte";
                    LUESubCommitteId.Properties.ValueMember = "SubCommitteId";
                    repositoryItemGridLookUpEditSubCommitteId.DataSource = SQLProvider.SelectCDSubCommitte();
                    repositoryItemGridLookUpEditSubCommitteId.DisplayMember = "SubCommitte";
                    repositoryItemGridLookUpEditSubCommitteId.ValueMember = "SubCommitteId";
                    //CDSyndicate
                    LUESyndicateId.Properties.DataSource = SQLProvider.SelectCDSyndicate();
                    LUESyndicateId.Properties.DisplayMember = "Syndicate";
                    LUESyndicateId.Properties.ValueMember = "SyndicateId";
                    repositoryItemGridLookUpEditSyndicateId.DataSource = SQLProvider.SelectCDSyndicate();
                    repositoryItemGridLookUpEditSyndicateId.DisplayMember = "Syndicate";
                    repositoryItemGridLookUpEditSyndicateId.ValueMember = "SyndicateId";
                    //CDMashHala
                    LUEMashHalaId.Properties.DataSource = SQLProvider.SelectCDMashHala();
                    LUEMashHalaId.Properties.DisplayMember = "MashHala";
                    LUEMashHalaId.Properties.ValueMember = "MashHalaId";
                    repositoryItemGridLookUpEditSarfHalaId.DataSource = SQLProvider.SelectCDMashHala();
                    repositoryItemGridLookUpEditSarfHalaId.DisplayMember = "MashHala";
                    repositoryItemGridLookUpEditSarfHalaId.ValueMember = "MashHalaId";
                    //CDWarasaType
                    repositoryItemGridLookUpEditWarasaTypeId.DataSource = SQLProvider.SelectCDWarasaType();
                    repositoryItemGridLookUpEditWarasaTypeId.DisplayMember = "WarasaType";
                    repositoryItemGridLookUpEditWarasaTypeId.ValueMember = "WarasaTypeId";
                    break;
                default:
                    break;
            }
        }
        private void LoadData()
        {
            LUEEmp.Properties.DataSource = SQLProvider.SelectTBLMashatList();
        }
        private void LoadGrid()
        {
            if (FXFW.SqlDB.IsNullOrEmpty(LUEEmp.EditValue))
                gridControlData.DataSource = SQLProvider.SelectTBLWarasa(null);
            else
                gridControlData.DataSource = SQLProvider.SelectTBLWarasa(LUEEmp.EditValue);
            
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
        private void ActiveKeyDownEventGrid(object sender, KeyEventArgs e)
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
        private void TBL_EmpFrm_Load(object sender, EventArgs e)
        {
            ActivePriv();
            LoadDefaultData(CodeFrm.TableNames.All);
            LoadData();
        }
        private void TxtEmpNationalID_EditValueChanged(object sender, EventArgs e)
        {
            if (tbMMashatNId.Text.Length < 14)
            {
                if (tbMMashatNId.Text == string.Empty)
                {
                    DEBirthDate.EditValue = null;
                    LUEMMashataddresGov.EditValue = null;
                    LUEMMashatGender.EditValue = null;
                }
                return;
            }
            float Type = FXFW.SqlDB.ConvertStringToInt(tbMMashatNId.Text.Substring(12, 1));
            if ((Type % 2) == 0)
                LUEMMashatGender.ItemIndex = 1;//female
            else
                LUEMMashatGender.ItemIndex = 0;//male
            string birthdate = string.Empty;
            //get birth day
            birthdate = tbMMashatNId.Text.Substring(5, 2) + "/";
            birthdate += tbMMashatNId.Text.Substring(3, 2) + "/";
            if (tbMMashatNId.Text.Substring(0, 1) == "2")
                birthdate += "19" + tbMMashatNId.Text.Substring(1, 2);
            else
                birthdate += "20" + tbMMashatNId.Text.Substring(1, 2);
            DEBirthDate.Text = birthdate;
            DEBirthDate.EditValue = DEBirthDate.DateTime;
            //get the birth state
            try
            { LUEMMashataddresGov.EditValue = tbMMashatNId.Text.Substring(7, 2); }
            catch (Exception ex)
            { Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, ex, null, this); }
        }
        private void LUEEmp_EditValueChanged(object sender, EventArgs e)
        {
            if (LUEEmp.EditValue == null)
            {
                btnNew_Click(btnNew, new EventArgs());
                btnUpdate.Enabled = false;
                btnSave.Enabled = false;
                return;
            }
            if (FXFW.SqlDB.IsNullOrEmpty(LUEEmp.EditValue))
            {
                btnNew_Click(btnNew, new EventArgs());
                btnUpdate.Enabled = false;
                btnSave.Enabled = false;
                return;
            }

            DataRow row = ((DataRowView)LUEEmp.GetSelectedDataRow()).Row;
            tbMMashatName.Text = row["MMashatName"].ToString();
            tbMMashatNId.Text = row["MMashatNId"].ToString();
            LUEMMashatGender.EditValue = row["MMashatGender"];
            DEBirthDate.EditValue = row["BirthDate"];
            //
            LUEMMashataddresGov.EditValue = row["MMashataddresGov"];
            LUEMMashataddresMarkez.EditValue = row["MMashataddresMarkez"];
            tbMMashataddres.Text = row["MMashataddres"].ToString();
            tbMMashatPhone.Text = row["MMashatPhone"].ToString();
            tbMMashatMobil.Text = row["MMashatMobil"].ToString();
            tbMMashatMail.Text = row["MMashatMail"].ToString();
            //
            DEWorkeEndDate.EditValue = row["WorkeEndDate"];
            tbKideNumber.Text = row["KideNumber"].ToString();
            DEZmalaEshtrakDate.EditValue = row["ZmalaEshtrakDate"];
            LUESyndicateId.EditValue = row["SyndicateId"];
            tbMemberShipNumber.Text = row["MemberShipNumber"].ToString();
            LUESubCommitteId.EditValue = row["SubCommitteId"];
            LUEMashHalaId.EditValue = row["MashHalaId"];
            tbsarfnumber.Text = row["sarfnumber"].ToString();

            LoadGrid();

            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
            xtraTabPageOther.PageVisible = true;
            //refresh data inside controls
            for (int i = 0; i < xtraTabControlMain.TabPages.Count; i++)
                xtraTabControlMain.SelectedTabPageIndex = i;
            xtraTabControlMain.SelectedTabPageIndex = 0;

            if (row["MashHalaId"].ToString() == "1")
            {
                xtraTabPageOther.PageVisible = false;
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            tbMMashatName.Text = string.Empty;
            tbMMashatNId.Text = string.Empty;
            LUEMMashatGender.EditValue = null;
            DEBirthDate.EditValue = null;
            //
            LUEMMashataddresGov.EditValue = null;
            LUEMMashataddresMarkez.EditValue = null;
            tbMMashataddres.Text = string.Empty;
            tbMMashatPhone.Text = string.Empty;
            tbMMashatMobil.Text = string.Empty;
            tbMMashatMail.Text = string.Empty;
            //
            DEWorkeEndDate.EditValue = null;
            tbKideNumber.Text = string.Empty;
            DEZmalaEshtrakDate.EditValue = null;
            LUESyndicateId.EditValue = null;
            tbMemberShipNumber.Text = string.Empty;
            LUESubCommitteId.EditValue = null;
            LUEMashHalaId.EditValue = null;
            tbsarfnumber.Text = string.Empty;

            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            xtraTabPageOther.PageVisible = false;
        }
        private void LUEMMashataddresGov_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDGov);
            FrmCode.ShowDialog();
            LoadDefaultData(CodeFrm.TableNames.CDGov);
        }
        private void LUEMMashataddresMarkez_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDMarkez);
            FrmCode.ShowDialog();
            LoadDefaultData(CodeFrm.TableNames.CDMarkez);
        }
        private void LUESyndicateId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDSyndicate);
            FrmCode.ShowDialog();
            LoadDefaultData(CodeFrm.TableNames.CDSyndicate);
        }
        private void LUESubCommitteId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDSubCommitte);
            FrmCode.ShowDialog();
            LoadDefaultData(CodeFrm.TableNames.CDSubCommitte);
        }
        private void LUEMashHalaId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDMashHala);
            FrmCode.ShowDialog();
            LoadDefaultData(CodeFrm.TableNames.CDMashHala);
        }
        private void repositoryItemGridLookUpEditWarasaTypeId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDWarasaType);
            FrmCode.ShowDialog();
            LoadDefaultData(CodeFrm.TableNames.CDWarasaType);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbsarfnumber.Text == string.Empty || tbMMashatName.Text == string.Empty)
            {
                Program.ShowMsg("من فضلك ادخل الاسم و رقم الصرف", true, this);
                return;
            }
            try
            {

                SQLProvider.InsertTBLMashat(tbMMashatNId.EditValue, tbMMashatName.EditValue, DEBirthDate.EditValue, LUEMMashatGender.EditValue, LUEMMashataddresGov.EditValue,
                    LUEMMashataddresMarkez.EditValue, tbMMashataddres.EditValue, tbMMashatPhone.EditValue, tbMMashatMobil.EditValue, tbMMashatMail.EditValue, DEWorkeEndDate.EditValue, tbKideNumber.EditValue, DEZmalaEshtrakDate.EditValue,
                    LUESyndicateId.EditValue, LUESubCommitteId.EditValue, tbMemberShipNumber.EditValue, LUEMashHalaId.EditValue, tbsarfnumber.EditValue);
                Program.ShowMsg("تم الاضافه", false, this);
                Program.Logger.LogThis("تم الاضافه", Text, FXFW.Logger.OpType.success, null, null, this);
                LoadData();
                LoadGrid();

                DataTable dt = (DataTable)LUEEmp.Properties.DataSource;
                DataRow row = dt.Rows[dt.Rows.Count - 1];
                LUEEmp.EditValue = row["MMashatId"];
                //LUEEmp.Properties.LinkCount
                
                xtraTabPageOther.PageVisible = true;
                xtraTabControlMain.SelectedTabPage = xtraTabPageOther;
                //btnNew_Click(btnNew, new EventArgs());
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (FXFW.SqlDB.IsNullOrEmpty(LUEEmp.EditValue))
                return;
            try
            {
                SQLProvider.UpdateTBLMashat(LUEEmp.EditValue, tbMMashatNId.EditValue, tbMMashatName.EditValue, DEBirthDate.EditValue, LUEMMashatGender.EditValue, LUEMMashataddresGov.EditValue,
                    LUEMMashataddresMarkez.EditValue, tbMMashataddres.EditValue, tbMMashatPhone.EditValue, tbMMashatMobil.EditValue, tbMMashatMail.EditValue, DEWorkeEndDate.EditValue, tbKideNumber.EditValue, DEZmalaEshtrakDate.EditValue,
                    LUESyndicateId.EditValue, LUESubCommitteId.EditValue, tbMemberShipNumber.EditValue, LUEMashHalaId.EditValue, tbsarfnumber.EditValue);
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
            if (LUEEmp.EditValue == null)
                return;
            if (FXFW.SqlDB.IsNullOrEmpty(LUEEmp.EditValue))
                return;
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            try
            {
                SQLProvider.DeleteTBLMashat(LUEEmp.EditValue.ToString());
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
                DataRow row = gridViewData.GetFocusedDataRow();
                if (row["org_PersonId"].ToString() == string.Empty)
                {
                    SQLProvider.InsertTBLWarasa(LUEEmp.EditValue, row["WarasaTypeId"].ToString(), 
                        row["personName"].ToString(), row["personAddres"].ToString(), row["SyndicateId"].ToString(), row["SubCommitteId"].ToString(), 
                        row["personphone"].ToString(), row["personmobile"].ToString(), row["personbirth"].ToString(), row["SarfHalaId"].ToString(), 
                        row["personrem"].ToString());
                }
                else
                {
                    SQLProvider.UpdateTBLWarasa(row["PersonId"].ToString(), row["MMashatId"].ToString(), row["WarasaTypeId"].ToString(),
                        row["personName"].ToString(), row["personAddres"].ToString(), row["SyndicateId"].ToString(), row["SubCommitteId"].ToString(),
                        row["personphone"].ToString(), row["personmobile"].ToString(), row["personbirth"].ToString(), row["SarfHalaId"].ToString(),
                        row["personrem"].ToString(), row["org_PersonId"].ToString(), row["org_MMashatId"].ToString());
                }
                LoadGrid();
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
                DataRow row = gridViewData.GetFocusedDataRow();
                if (row["org_PersonId"].ToString() != string.Empty)
                    SQLProvider.DeleteTBLWarasa(row["org_PersonId"].ToString(), row["org_MMashatId"].ToString());
                LoadGrid();
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

