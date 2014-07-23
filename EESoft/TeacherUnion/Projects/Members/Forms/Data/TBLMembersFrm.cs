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
using DevExpress.XtraEditors.Controls;
using System.Reflection;

namespace Members
{
    public partial class TBLMembersFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Functions   -
        public TBLMembersFrm()
        {
            InitializeComponent();
        }
        private void LoadDefaultData(CodeFrm.TableNames SelectedTable)
        {
            switch (SelectedTable)
            {
                case CodeFrm.TableNames.All:
                    //CDBirthPlace
                    LUEMemberBPlace.Properties.DataSource = SQLProvider.SelectCDBirthPlace();
                    LUEMemberBPlace.Properties.DisplayMember = "BPlace";
                    LUEMemberBPlace.Properties.ValueMember = "PlaceId";
                    //CDGender
                    LUEMemberGender.Properties.DataSource = SQLProvider.SelectCDGender();
                    LUEMemberGender.Properties.DisplayMember = "Gender";
                    LUEMemberGender.Properties.ValueMember = "GenderId";
                    //CDReligon
                    LUEMemberReligon.Properties.DataSource = SQLProvider.SelectCDReligon();
                    LUEMemberReligon.Properties.DisplayMember = "Religon";
                    LUEMemberReligon.Properties.ValueMember = "ReligonId";
                    //CDGov
                    LUEMemberaddresGov.Properties.DataSource = SQLProvider.SelectCDGov();
                    LUEMemberaddresGov.Properties.DisplayMember = "GOV";
                    LUEMemberaddresGov.Properties.ValueMember = "GovId";
                    //CDMarkez
                    LUEMemberaddresMarkez.Properties.DataSource = SQLProvider.SelectCDMarkez();
                    LUEMemberaddresMarkez.Properties.DisplayMember = "Markez";
                    LUEMemberaddresMarkez.Properties.ValueMember = "MarkezId";
                    //CDQualification
                    LUEMemberqualId.Properties.DataSource = SQLProvider.SelectCDQualification();
                    LUEMemberqualId.Properties.DisplayMember = "qualName";
                    LUEMemberqualId.Properties.ValueMember = "qualId";
                    //CDSpecialization
                    LUEMemberSpecialization.Properties.DataSource = SQLProvider.SelectCDSpecialization();
                    LUEMemberSpecialization.Properties.DisplayMember = "SpecializationName";
                    LUEMemberSpecialization.Properties.ValueMember = "SpecializationId";
                    //CDJop
                    LUEMemberFirestJop.Properties.DataSource = SQLProvider.SelectCDJop();
                    LUEMemberFirestJop.Properties.DisplayMember = "jopName";
                    LUEMemberFirestJop.Properties.ValueMember = "jopId";
                    //CDSyndicate
                    LUESyndicateId.Properties.DataSource = SQLProvider.SelectCDSyndicate();
                    LUESyndicateId.Properties.DisplayMember = "Syndicate";
                    LUESyndicateId.Properties.ValueMember = "SyndicateId";
                    //CDSubCommitte
                    LUESubCommitteId.Properties.DataSource = SQLProvider.SelectCDSubCommitte();
                    LUESubCommitteId.Properties.DisplayMember = "SubCommitte";
                    LUESubCommitteId.Properties.ValueMember = "SubCommitteId";
                    //CDGehaType
                    repositoryItemGridLookUpEditGehaTypeId.DataSource = SQLProvider.SelectCDGehaType();
                    //CDGeha
                    repositoryItemGridLookUpEditGehaId.DataSource = SQLProvider.SelectCDGeha();
                    //CDModerea
                    repositoryItemGridLookUpEditModereaId.DataSource = SQLProvider.SelectCDModerea();
                    //CDEDARET
                    repositoryItemGridLookUpEditEdaraId.DataSource = SQLProvider.SelectCDEDARET();
                    //CDJop
                    repositoryItemGridLookUpEditMemberCurrentJop.DataSource = SQLProvider.SelectCDJop();
                    //CDJobDescription
                    repositoryItemGridLookUpEditJobDescriptionId.DataSource = SQLProvider.SelectCDJobDescription();
                    //CDJobtitle
                    LUEJobtitleID.Properties.DataSource = SQLProvider.SelectCDJobtitle();
                    LUEJobtitleID.Properties.DisplayMember = "Jobtitle";
                    LUEJobtitleID.Properties.ValueMember = "JobtitleID";
                    break;
                case CodeFrm.TableNames.CDBirthPlace:
                    //CDBirthPlace
                    LUEMemberBPlace.Properties.DataSource = SQLProvider.SelectCDBirthPlace();
                    LUEMemberBPlace.Properties.DisplayMember = "BPlace";
                    LUEMemberBPlace.Properties.ValueMember = "PlaceId";
                    break;
                case CodeFrm.TableNames.CDGov:
                    //CDGov
                    LUEMemberaddresGov.Properties.DataSource = SQLProvider.SelectCDGov();
                    LUEMemberaddresGov.Properties.DisplayMember = "GOV";
                    LUEMemberaddresGov.Properties.ValueMember = "GovId";
                    break;
                case CodeFrm.TableNames.CDMarkez:
                    //CDMarkez
                    LUEMemberaddresMarkez.Properties.DataSource = SQLProvider.SelectCDMarkez();
                    LUEMemberaddresMarkez.Properties.DisplayMember = "Markez";
                    LUEMemberaddresMarkez.Properties.ValueMember = "MarkezId";
                    break;
                case CodeFrm.TableNames.CDQualification:
                    //CDQualification
                    LUEMemberqualId.Properties.DataSource = SQLProvider.SelectCDQualification();
                    LUEMemberqualId.Properties.DisplayMember = "qualName";
                    LUEMemberqualId.Properties.ValueMember = "qualId";
                    break;
                case CodeFrm.TableNames.CDSpecialization:
                    //CDSpecialization
                    LUEMemberSpecialization.Properties.DataSource = SQLProvider.SelectCDSpecialization();
                    LUEMemberSpecialization.Properties.DisplayMember = "SpecializationName";
                    LUEMemberSpecialization.Properties.ValueMember = "SpecializationId";
                    break;
                case CodeFrm.TableNames.CDJop:
                    //CDJop
                    LUEMemberFirestJop.Properties.DataSource = SQLProvider.SelectCDJop();
                    LUEMemberFirestJop.Properties.DisplayMember = "jopName";
                    LUEMemberFirestJop.Properties.ValueMember = "jopId";
                    repositoryItemGridLookUpEditMemberCurrentJop.DataSource = SQLProvider.SelectCDJop();
                    break;
                case CodeFrm.TableNames.CDSyndicate:
                    //CDSyndicate
                    LUESyndicateId.Properties.DataSource = SQLProvider.SelectCDSyndicate();
                    LUESyndicateId.Properties.DisplayMember = "Syndicate";
                    LUESyndicateId.Properties.ValueMember = "SyndicateId";
                    break;
                case CodeFrm.TableNames.CDSubCommitte:
                    //CDSubCommitte
                    LUESubCommitteId.Properties.DataSource = SQLProvider.SelectCDSubCommitte();
                    LUESubCommitteId.Properties.DisplayMember = "SubCommitte";
                    LUESubCommitteId.Properties.ValueMember = "SubCommitteId";
                    break;
                case CodeFrm.TableNames.CDGehaType:
                    //CDGehaType
                    repositoryItemGridLookUpEditGehaTypeId.DataSource = SQLProvider.SelectCDGehaType();
                    break;
                case CodeFrm.TableNames.CDGeha:
                    //CDGeha
                    repositoryItemGridLookUpEditGehaId.DataSource = SQLProvider.SelectCDGeha();
                    break;
                case CodeFrm.TableNames.CDModerea:
                    //CDModerea
                    repositoryItemGridLookUpEditModereaId.DataSource = SQLProvider.SelectCDModerea();
                    break;
                case CodeFrm.TableNames.CDEDARET:
                    //CDEDARET
                    repositoryItemGridLookUpEditEdaraId.DataSource = SQLProvider.SelectCDEDARET();
                    break;
                case CodeFrm.TableNames.CDJobDescription:
                    //CDJobDescription
                    repositoryItemGridLookUpEditJobDescriptionId.DataSource = SQLProvider.SelectCDJobDescription();
                    break;
                case CodeFrm.TableNames.CDJobtitle:
                    //CDJobtitle
                    LUEJobtitleID.Properties.DataSource = SQLProvider.SelectCDJobtitle();
                    LUEJobtitleID.Properties.DisplayMember = "Jobtitle";
                    LUEJobtitleID.Properties.ValueMember = "JobtitleID";
                    break;
                default:
                    break;
            }
        }
        private void LoadData()
        {
            LUEEmp.Properties.DataSource = SQLProvider.SelectTBLMembers();
        }
        private void LoadGrid()
        {
            if (FXFW.SqlDB.IsNullOrEmpty(LUEEmp.EditValue))
                gridControlData.DataSource = SQLProvider.SelectTBLMemberWork(0);
            else
                gridControlData.DataSource = SQLProvider.SelectTBLMemberWork(LUEEmp.EditValue);
            
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
            return;//ActivePrivReady
            bool Selecting = false, Inserting = false, Updateing = false, Deleting = false;
            SQLProvider.GetFormPriv(this.Name, ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
            LUEEmp.Visible = Selecting;
            btnNew.Visible = Inserting; btnSave.Visible = Inserting;
            btnUpdate.Visible = Inserting;
            btnDelete.Visible = Inserting;
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
            if (tbMemberNId.Text.Length < 14)
            {
                if (tbMemberNId.Text == string.Empty)
                {
                    DEBirthDate.EditValue = null;
                    LUEMemberaddresGov.EditValue = null;
                    LUEMemberGender.EditValue = null;
                }
                return;
            }
            float Type = FXFW.SqlDB.ConvertStringToInt(tbMemberNId.Text.Substring(12, 1));
            if ((Type % 2) == 0)
                LUEMemberGender.ItemIndex = 1;//female
            else
                LUEMemberGender.ItemIndex = 0;//male
            string birthdate = string.Empty;
            //get birth day
            birthdate = tbMemberNId.Text.Substring(5, 2) + "/";
            birthdate += tbMemberNId.Text.Substring(3, 2) + "/";
            if (tbMemberNId.Text.Substring(0, 1) == "2")
                birthdate += "19" + tbMemberNId.Text.Substring(1, 2);
            else
                birthdate += "20" + tbMemberNId.Text.Substring(1, 2);
            DEBirthDate.Text = birthdate;
            DEBirthDate.EditValue = DEBirthDate.DateTime;
            //get the birth state
            try
            { LUEMemberaddresGov.EditValue = tbMemberNId.Text.Substring(7, 2); }
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
                btnDelete.Enabled = false;
                return;
            }
            
            //if (LUEEmp.ItemIndex == -1)
            //{
            //    btnNew_Click(btnNew, new EventArgs());
            //    btnUpdate.Enabled = false;
            //    btnSave.Enabled = false;
            //    btnDelete.Enabled = false;
            //    return;
            //}

           //DataRow row = ((DataTable)LUEEmp.Properties.DataSource).Rows[LUEEmp.ItemIndex];
            DataRow row = ((DataRowView)LUEEmp.GetSelectedDataRow()).Row;

            tbMemberName.Text = row["MemberName"].ToString();
            tbMemberNId.Text = row["MemberNId"].ToString();
            LUEMemberBPlace.EditValue = row["MemberBPlace"];
            DEBirthDate.EditValue = row["BirthDate"];
            LUEMemberReligon.EditValue = row["MemberReligon"];
            LUEMemberGender.EditValue = row["MemberGender"];
            ceInstallment.EditValue = row["Installment"];
            //
            LUEMemberaddresGov.EditValue = row["MemberaddresGov"];
            LUEMemberaddresMarkez.EditValue = row["MemberaddresMarkez"];
            tbMemberaddres.Text = row["Memberaddres"].ToString();
            tbMemberPhone.Text = row["MemberPhone"].ToString();
            tbMemberMobil.Text = row["MemberMobil"].ToString();
            tbMemberWorkPhone.Text = row["MemberWorkPhone"].ToString();
            tbMemberMail.Text = row["MemberMail"].ToString();
            //
            LUEMemberqualId.EditValue = row["MemberqualId"];
            LUEMemberSpecialization.EditValue = row["MemberSpecialization"];
            DEqualDate.EditValue = row["qualDate"];
            DEWorkeDate.EditValue = row["WorkeDate"];
            LUEMemberFirestJop.EditValue = row["MemberFirestJop"];
            LUEJobtitleID.EditValue = row["JobtitleID"];
            //
            tbKideNumber.Text = row["KideNumber"].ToString();
            DEZmalaEshtrakDate.EditValue = row["ZmalaEshtrakDate"];
            LUESyndicateId.EditValue = row["SyndicateId"];

            LUESyndicateId_EditValueChanged(LUESyndicateId, new EventArgs());

            LUESubCommitteId.EditValue = row["SubCommitteId"];
            tbMemberShipNumber.Text = row["MemberShipNumber"].ToString();

            //if (row["Img"] != DBNull.Value)
            //    peImg.EditValue = row["Img"];
            //else
            //    peImg.EditValue = null;
            
            if (row["Img"] != DBNull.Value)
            {
                if (File.Exists(Program.imgPath + row["Img"] + ".jpg"))
                {
                    peImg.EditValue = System.IO.File.ReadAllBytes(Program.imgPath + row["Img"] + ".jpg");
                    peImg.FileName = Program.imgPath + row["Img"] + ".jpg";
                }
                else
                    peImg.EditValue = null;    
            }
            else
                peImg.EditValue = null;

            LoadGrid();

            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            xtraTabPageOther.PageVisible = true;
            //refresh data inside controls
            for (int i = 0; i < xtraTabControlMain.TabPages.Count; i++)
                xtraTabControlMain.SelectedTabPageIndex = i;
            xtraTabControlMain.SelectedTabPageIndex = 0;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            tbMemberName.Text = string.Empty;
            tbMemberNId.Text = string.Empty;
            LUEMemberBPlace.EditValue = null;
            DEBirthDate.EditValue = null;
            LUEMemberReligon.EditValue = null;
            LUEMemberGender.EditValue = null;
            ceInstallment.EditValue = null;
            //
            LUEMemberaddresGov.EditValue = null;
            LUEMemberaddresMarkez.EditValue = null;
            tbMemberaddres.Text = string.Empty;
            tbMemberPhone.Text = string.Empty;
            tbMemberMobil.Text = string.Empty;
            tbMemberWorkPhone.Text = string.Empty;
            tbMemberMail.Text = string.Empty;
            //
            LUEMemberqualId.EditValue = null;
            LUEMemberSpecialization.EditValue = null;
            DEqualDate.EditValue = null;
            DEWorkeDate.EditValue = null;
            LUEMemberFirestJop.EditValue = null;
            LUEJobtitleID.EditValue= null;
            //
            tbKideNumber.Text = string.Empty;
            DEZmalaEshtrakDate.EditValue = null;
            LUESyndicateId.EditValue = null;
            LUESubCommitteId.EditValue = null;
            tbMemberShipNumber.Text = string.Empty;

            peImg.EditValue = null;
            
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            xtraTabPageOther.PageVisible = false;
        }
        private void LUECDJobtitle_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDJobtitle);
            FrmCode.ShowDialog();
            LoadDefaultData(CodeFrm.TableNames.CDJobtitle);
        }
        private void LUEMemberBPlace_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDBirthPlace);
            FrmCode.ShowDialog();
            LoadDefaultData(CodeFrm.TableNames.CDBirthPlace);
        }
        private void LUEMemberaddresGov_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDGov);
            FrmCode.ShowDialog();
            LoadDefaultData(CodeFrm.TableNames.CDGov);
        }
        private void LUEMemberaddresMarkez_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDModerea);
            FrmCode.ShowDialog();
            LoadDefaultData(CodeFrm.TableNames.CDModerea);
        }
        private void LUEMemberqualId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDQualification);
            FrmCode.ShowDialog();
            LoadDefaultData(CodeFrm.TableNames.CDQualification);
        }
        private void LUEMemberSpecialization_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDSpecialization);
            FrmCode.ShowDialog();
            LoadDefaultData(CodeFrm.TableNames.CDSpecialization);
        }
        private void LUEMemberFirestJop_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDJop);
            FrmCode.ShowDialog();
            LoadDefaultData(CodeFrm.TableNames.CDJop);
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
        private void repositoryItemGridLookUpEditGehaTypeId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDGehaType);
            FrmCode.ShowDialog();
            LoadDefaultData(CodeFrm.TableNames.CDGehaType);
        }
        private void repositoryItemGridLookUpEditGehaId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDGeha);
            FrmCode.ShowDialog();
            LoadDefaultData(CodeFrm.TableNames.CDGeha);
        }
        private void repositoryItemGridLookUpEditModereaId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDModerea);
            FrmCode.ShowDialog();
            LoadDefaultData(CodeFrm.TableNames.CDModerea);
        }
        private void repositoryItemGridLookUpEditEdaraId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDEDARET);
            FrmCode.ShowDialog();
            LoadDefaultData(CodeFrm.TableNames.CDEDARET);
        }
        private void repositoryItemGridLookUpEditMemberCurrentJop_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDJop);
            FrmCode.ShowDialog();
            LoadDefaultData(CodeFrm.TableNames.CDJop);
        }
        private void repositoryItemGridLookUpEditJobDescriptionId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDJobDescription);
            FrmCode.ShowDialog();
            LoadDefaultData(CodeFrm.TableNames.CDJobDescription);
        }
        private void peImg_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            //const int ImgWidth = 54;
            //const int ImgHeight = 54;
            ImageFormat ImgFormat = ImageFormat.Jpeg;
            const int ImgMaxSize = 100 * 1024;

            if (e.NewValue == null) return;

            try
            {
                byte[] data = (byte[])e.NewValue;
                if (data.Length > ImgMaxSize)
                {
                    e.Cancel = true;
                    return;
                }
                MemoryStream stream = new MemoryStream();
                stream.Write(data, 0, data.Length);
                stream.Position = 0;
                Image img = Image.FromStream(stream);
                if (img != null)
                {
                    if (/*img.Width != ImgWidth || img.Height != ImgHeight ||*/ !img.RawFormat.Equals(ImgFormat))
                    {
                        e.Cancel = true;
                        return;
                    }
                }
            }
            finally
            {
                if (e.Cancel)
                {
                    string msg = "حجم الصوره يجب ان يكون اصغر من 100 كيلوبايت " + "\n او نوع الصوره ليس" + "\n jpg";
                    MessageBox.Show(msg);
                }
            }
        }
        private void LUESyndicateId_EditValueChanged(object sender, EventArgs e)
        {
            LUESubCommitteId.Properties.DataSource = SQLProvider.SelectCDSubCommitte(LUESyndicateId.EditValue);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!FXFW.SqlDB.IsNullOrEmpty(peImg.EditValue))
                {
                    string ImgPathString = Program.imgPath + tbKideNumber.EditValue + ".jpg";
                    if (File.Exists(ImgPathString))
                        File.Delete(ImgPathString);
                    peImg.Image.Save(ImgPathString, ImageFormat.Jpeg);
                }
                SQLProvider.InsertTBLMembers(tbMemberNId.Text, tbMemberName.Text, DEBirthDate.EditValue, LUEMemberBPlace.EditValue, LUEMemberGender.EditValue,
                    LUEMemberReligon.EditValue, LUEMemberqualId.EditValue, LUEMemberSpecialization.EditValue, DEqualDate.EditValue, LUEMemberaddresGov.EditValue, LUEMemberaddresMarkez.EditValue, tbMemberaddres.Text, tbMemberPhone.Text, tbMemberMobil.Text, tbMemberWorkPhone.Text, tbMemberMail.Text,
                    DEWorkeDate.EditValue, tbKideNumber.EditValue, LUEMemberFirestJop.EditValue, DEZmalaEshtrakDate.EditValue, LUESyndicateId.EditValue,
                    LUESubCommitteId.EditValue, tbKideNumber.EditValue, LUEJobtitleID.EditValue, 0, 1, null, ceInstallment.EditValue);
                Program.ShowMsg("تم الاضافه", false, this);
                Program.Logger.LogThis("تم الاضافه", Text, FXFW.Logger.OpType.success, null, null, this);
                LoadData();
                LoadGrid();
                //LUEEmp.ItemIndex = LUEEmp.Properties.DropDownRows;
                //xtraTabPageOther.PageVisible = true;
                //xtraTabControlMain.SelectedTabPage = xtraTabPageOther;
                btnNew_Click(btnNew, new EventArgs());
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
            try
            {
                if (!FXFW.SqlDB.IsNullOrEmpty(peImg.EditValue))
                {
                    string ImgPathString = Program.imgPath + tbKideNumber.EditValue + ".jpg";
                    if (File.Exists(ImgPathString))
                        File.Delete(ImgPathString);
                    peImg.Image.Save(ImgPathString, ImageFormat.Jpeg);
                }
                string img = string.Empty;
                if (!FXFW.SqlDB.IsNullOrEmpty(peImg.EditValue))
                    img = tbKideNumber.Text;
                SQLProvider.UpdateTBLMembers(LUEEmp.EditValue ,tbMemberNId.Text, tbMemberName.Text, DEBirthDate.EditValue, LUEMemberBPlace.EditValue, LUEMemberGender.EditValue,
              LUEMemberReligon.EditValue, LUEMemberqualId.EditValue, LUEMemberSpecialization.EditValue, DEqualDate.EditValue, LUEMemberaddresGov.EditValue, LUEMemberaddresMarkez.EditValue, tbMemberaddres.Text, tbMemberPhone.Text, tbMemberMobil.Text, tbMemberWorkPhone.Text, tbMemberMail.Text,
              DEWorkeDate.EditValue, tbKideNumber.EditValue, LUEMemberFirestJop.EditValue, DEZmalaEshtrakDate.EditValue, LUESyndicateId.EditValue,
              LUESubCommitteId.EditValue, tbMemberShipNumber.Text, tbKideNumber.EditValue, LUEJobtitleID.EditValue, 0, 1, null, ceInstallment.EditValue);
                Program.ShowMsg("تم الاضافه", false, this);
                Program.ShowMsg("تم التعديل", false, this);
                Program.Logger.LogThis("تم التعديل", Text, FXFW.Logger.OpType.success, null, null, this);
                LoadData();
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (LUEEmp.EditValue == null)
                return;
            //if (LUEEmp.ItemIndex == -1)
            //    return;
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            try
            {
                SQLProvider.DeleteTBLMembers(LUEEmp.EditValue.ToString());
                if (File.Exists(peImg.FileName))
                    File.Delete(peImg.FileName);

                Program.ShowMsg("تم الحذف", false, this);
                Program.Logger.LogThis("تم الحذف", Text, FXFW.Logger.OpType.success, null, null, this);
                LoadData();
                btnNew_Click(btnNew, new EventArgs());
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                DataRow row = gridViewData.GetFocusedDataRow();
                if (row["org_MemberId"].ToString() == string.Empty)
                    SQLProvider.InsertTBLMemberWork(LUEEmp.EditValue.ToString(), row["GehaId"].ToString(), row["GehaTypeId"].ToString(), row["MemberCurrentJop"].ToString(), row["EdaraId"].ToString(), row["ModereaId"].ToString(), row["JobDescriptionId"].ToString());
                else
                    SQLProvider.UpdateTBLMemberWork(LUEEmp.EditValue.ToString(), row["GehaId"].ToString(), row["GehaTypeId"].ToString(), row["MemberCurrentJop"].ToString(), row["EdaraId"].ToString(), row["ModereaId"].ToString(), row["JobDescriptionId"].ToString(), row["org_MemberId"].ToString(), row["org_GehaId"].ToString());
                LoadGrid();
                Program.ShowMsg("تم التعديل", false, this);
                Program.Logger.LogThis("تم التعديل", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this, true);
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
                if (row["org_MemberId"].ToString() != string.Empty)
                    SQLProvider.DeleteTBLMemberWork(row["org_MemberId"].ToString(), row["org_GehaId"].ToString());
                LoadGrid();
                Program.ShowMsg("تم الحذف", false, this);
                Program.Logger.LogThis("تم الحذف", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        #endregion         #region -   Variables   -

    }

    
}

