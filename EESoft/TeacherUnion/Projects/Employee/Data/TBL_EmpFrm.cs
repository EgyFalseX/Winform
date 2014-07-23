using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace Employee
{
    public partial class TBL_EmpFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        enum TableName
        {
            All,
            CDGov,
            CDAlnoa,
            CDnationalty,
            CDDyana,
            CD_MaritalStatus,
            CD_EmpJob,
            CD_JobDescription,
            CD_Department,
            CDMarahel,
            CD_Subject,
            CDQualification,
            CD_Specialization,
            CD_QualifiedPlace,
            CD_EmpState
        }
        #endregion
        #region -   Functions   -
        public TBL_EmpFrm()
        {
            InitializeComponent();
        }
        private void LoadDefaultData(TableName SelectedTable)
        {
            switch (SelectedTable)
            {
                case TableName.All:
                    //CDGov
                    LUEBIRTH_GOV.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT GovId, GOV FROM CDGov");
                    LUEBIRTH_GOV.Properties.DisplayMember = "GOV";
                    LUEBIRTH_GOV.Properties.ValueMember = "GovId";
                    //CDAlnoa
                    LUEGENDER_ID.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT code_alnoa, name_alnoa, name_alnoa_e FROM CDAlnoa");
                    LUEGENDER_ID.Properties.DisplayMember = "name_alnoa";
                    LUEGENDER_ID.Properties.ValueMember = "code_alnoa";
                    //CDnationalty
                    LUEnationaltyId.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT nationaltyId, nationaltyname, nationaltyname_e FROM CDnationalty");
                    LUEnationaltyId.Properties.DisplayMember = "nationaltyname";
                    LUEnationaltyId.Properties.ValueMember = "nationaltyId";
                    //CDDyana
                    LUEdyana_code.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT dyana_code, dyana_name, dyana_name_e FROM CDDyana");
                    LUEdyana_code.Properties.DisplayMember = "dyana_name";
                    LUEdyana_code.Properties.ValueMember = "dyana_code";
                    //CD_MaritalStatus
                    LUEMaritalStatusId.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT MaritalStatusId, MaritalStatus, MaritalStatus_e FROM CD_MaritalStatus");
                    LUEMaritalStatusId.Properties.DisplayMember = "MaritalStatus";
                    LUEMaritalStatusId.Properties.ValueMember = "MaritalStatusId";
                    //CD_EmpJob
                    LUEEmpJobId.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT JobId, JobNAME FROM CD_EmpJop");
                    LUEEmpJobId.Properties.DisplayMember = "JobNAME";
                    LUEEmpJobId.Properties.ValueMember = "JobId";
                    //CD_JobDescription
                    LUEJobDescriptionId.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT JobDescriptionId, JobDescription FROM CD_JobDescription");
                    LUEJobDescriptionId.Properties.DisplayMember = "JobDescription";
                    LUEJobDescriptionId.Properties.ValueMember = "JobDescriptionId";
                    //CD_Department
                    LUEDepartmentId.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT DepartmentId, Department, Department_e FROM CD_Department");
                    LUEDepartmentId.Properties.DisplayMember = "Department";
                    LUEDepartmentId.Properties.ValueMember = "DepartmentId";
                    //CDMarahel
                    //LUEmarhala_code.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT marhala_code, marhala_name, marhala_name_e FROM CDMarahel");
                    //LUEmarhala_code.Properties.DisplayMember = "marhala_name";
                    //LUEmarhala_code.Properties.ValueMember = "marhala_code";
                    //CD_Subject
                    //LUESubjectId.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT SubjectId, Subject, Subject_e FROM CD_Subject");
                    //LUESubjectId.Properties.DisplayMember = "Subject";
                    //LUESubjectId.Properties.ValueMember = "SubjectId";
                    //CDQualification
                    LUEqualId.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT qualId, qualName, qualName_e FROM CDQualification");
                    LUEqualId.Properties.DisplayMember = "qualName";
                    LUEqualId.Properties.ValueMember = "qualId";
                    //CD_Specialization
                    LUESpecializationId.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT SpecializationId, SpecializationName, SpecializationName_e FROM CD_Specialization");
                    LUESpecializationId.Properties.DisplayMember = "SpecializationName";
                    LUESpecializationId.Properties.ValueMember = "SpecializationId";
                    //CD_QualifiedPlace
                    LUEQualifiedPlaceId.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT QualifiedPlaceId, QualifiedPlaceName, QualifiedPlaceName_e FROM CD_QualifiedPlace");
                    LUEQualifiedPlaceId.Properties.DisplayMember = "QualifiedPlaceName";
                    LUEQualifiedPlaceId.Properties.ValueMember = "QualifiedPlaceId";
                    //CD_EmpState
                    LUEJOB_STATUS_ID.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT EmpStateID, EmpStateName, EmpStateName_e FROM CD_EmpState");
                    LUEJOB_STATUS_ID.Properties.DisplayMember = "EmpStateName";
                    LUEJOB_STATUS_ID.Properties.ValueMember = "EmpStateID";
                    
                    break;
                case TableName.CDGov:
                    //CDGov
                    LUEBIRTH_GOV.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT GovId, GOV FROM CDGov");
                    LUEBIRTH_GOV.Properties.DisplayMember = "GOV";
                    LUEBIRTH_GOV.Properties.ValueMember = "GovId";
                    break;
                case TableName.CDAlnoa:
                    //CDAlnoa
                    LUEGENDER_ID.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT code_alnoa, name_alnoa, name_alnoa_e FROM CDAlnoa");
                    LUEGENDER_ID.Properties.DisplayMember = "name_alnoa";
                    LUEGENDER_ID.Properties.ValueMember = "code_alnoa";
                    break;
                case TableName.CDnationalty:
                    //CDnationalty
                    LUEnationaltyId.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT nationaltyId, nationaltyname, nationaltyname_e FROM CDnationalty");
                    LUEnationaltyId.Properties.DisplayMember = "nationaltyname";
                    LUEnationaltyId.Properties.ValueMember = "nationaltyId";
                    break;
                case TableName.CDDyana:
                    //CDDyana
                    LUEdyana_code.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT dyana_code, dyana_name, dyana_name_e FROM CDDyana");
                    LUEdyana_code.Properties.DisplayMember = "dyana_name";
                    LUEdyana_code.Properties.ValueMember = "dyana_code";
                    break;
                case TableName.CD_MaritalStatus:
                    //CD_MaritalStatus
                    LUEMaritalStatusId.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT MaritalStatusId, MaritalStatus, MaritalStatus_e FROM CD_MaritalStatus");
                    LUEMaritalStatusId.Properties.DisplayMember = "MaritalStatus";
                    LUEMaritalStatusId.Properties.ValueMember = "MaritalStatusId";
                    break;
                case TableName.CD_EmpJob:
                    //CD_EmpJob
                    LUEEmpJobId.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT JobId, JobNAME FROM CD_EmpJop");
                    LUEEmpJobId.Properties.DisplayMember = "JobNAME";
                    LUEEmpJobId.Properties.ValueMember = "JobId";
                    break;
                case TableName.CD_JobDescription:
                    //CD_JobDescription
                    LUEJobDescriptionId.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT JobDescriptionId, JobDescription FROM CD_JobDescription");
                    LUEJobDescriptionId.Properties.DisplayMember = "JobDescription";
                    LUEJobDescriptionId.Properties.ValueMember = "JobDescriptionId";
                    break;
                case TableName.CD_Department:
                    //CD_Department
                    LUEDepartmentId.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT DepartmentId, Department, Department_e FROM CD_Department");
                    LUEDepartmentId.Properties.DisplayMember = "Department";
                    LUEDepartmentId.Properties.ValueMember = "DepartmentId";
                    break;
                //case TableName.CDMarahel:
                //    //CDMarahel
                //    LUEmarhala_code.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT marhala_code, marhala_name, marhala_name_e FROM CDMarahel");
                //    LUEmarhala_code.Properties.DisplayMember = "marhala_name";
                //    LUEmarhala_code.Properties.ValueMember = "marhala_code";
                //    break;
                //case TableName.CD_Subject:
                //    //CD_Subject
                //    LUESubjectId.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT SubjectId, Subject, Subject_e FROM CD_Subject");
                //    LUESubjectId.Properties.DisplayMember = "Subject";
                //    LUESubjectId.Properties.ValueMember = "SubjectId";
                //    break;
                case TableName.CDQualification:
                    //CDQualification
                    LUEqualId.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT qualId, qualName, qualName_e FROM CDQualification");
                    LUEqualId.Properties.DisplayMember = "qualName";
                    LUEqualId.Properties.ValueMember = "qualId";
                    break;
                case TableName.CD_Specialization:
                    //CD_Specialization
                    LUESpecializationId.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT SpecializationId, SpecializationName, SpecializationName_e FROM CD_Specialization");
                    LUESpecializationId.Properties.DisplayMember = "SpecializationName";
                    LUESpecializationId.Properties.ValueMember = "SpecializationId";
                    break;
                case TableName.CD_QualifiedPlace:
                    //CD_QualifiedPlace
                    LUEQualifiedPlaceId.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT QualifiedPlaceId, QualifiedPlaceName, QualifiedPlaceName_e FROM CD_QualifiedPlace");
                    LUEQualifiedPlaceId.Properties.DisplayMember = "QualifiedPlaceName";
                    LUEQualifiedPlaceId.Properties.ValueMember = "QualifiedPlaceId";
                    break;
                case TableName.CD_EmpState:
                    //CD_EmpState
                    LUEJOB_STATUS_ID.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT EmpStateID, EmpStateName, EmpStateName_e FROM CD_EmpState");
                    LUEJOB_STATUS_ID.Properties.DisplayMember = "EmpStateName";
                    LUEJOB_STATUS_ID.Properties.ValueMember = "EmpStateID";
                    break;
                default:
                    break;
            }
        }
        private void LoadData()
        {
            DataTable Emp = FXFW.SqlDB.LoadDataTable(@"SELECT EmpID, Isnull(EMP_FIRST_NAME, '') + ' ' + Isnull(EMP_FATHER_NAME, '') + ' ' + Isnull(EMP_FAM_NAME, '') + ' ' + Isnull(EMP_FOURTH_NAME, '') AS Emp_Name,
            EmpNationalID, EMP_FIRST_NAME, EMP_FATHER_NAME, EMP_FAM_NAME, EMP_FOURTH_NAME, nationaltyId, dyana_code, 
            MaritalStatusId, DepartmentId, EmpJobId, BIRTH_DATE, GENDER_ID, BIRTH_GOV, JOB_STATUS_ID, BIRTH_PLACE, Emp_Address, PHONE_NO, 
            MOBILE_NO, JobDescriptionId, Work_Start_Date, End_Work_Date, qualId, SpecializationId, QualifiedPlaceId, Moaahel_Date, tagned_id, tameen_no, tameen_date1, 
            betaka_tameen, noview, orderreport, EMPPIC
            FROM TBL_Emp");
            LUEEmp.Properties.DataSource = Emp;
            //LUEEmp.Properties.DisplayMember = "Emp_Name";
            //LUEEmp.Properties.ValueMember = "EmpID";
            DataTable dt = FXFW.SqlDB.LoadDataTable(@"Select DISTINCT BIRTH_PLACE From TBL_Emp");
            foreach (DataRow item in dt.Rows)
                cbBIRTH_PLACE.Properties.Items.Add(item["BIRTH_PLACE"]);
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
            bool Selecting = false, Inserting = false, Updateing = false, Deleting = false;
            FXFW.SqlDB.GetFormPriv("Emp" + Name.Replace("Frm", ""), ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
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
            //ActivePriv();
            LoadDefaultData(TableName.All);
            LoadData();
        }
        private void TxtName_EditValueChanged(object sender, EventArgs e)
        {
            TxtFullNameAr.Text = string.Format("{0} {1} {2} {3}", TxtEMP_FIRST_NAME.Text, TxtEMP_FATHER_NAME.Text, TxtEMP_FAM_NAME.Text, TxtEMP_FOURTH_NAME.Text);
            TxtFullNameAr.Text = TxtFullNameAr.Text.Trim();
        }
        private void TxtEmpNationalID_EditValueChanged(object sender, EventArgs e)
        {
            if (TxtEmpNationalID.Text.Length < 14)
            {
                if (TxtEmpNationalID.Text == string.Empty)
                {
                    DEBIRTH_DATE.EditValue = null;
                    LUEBIRTH_GOV.EditValue = null;
                    LUEGENDER_ID.EditValue = null;
                }
                return;
            }
            float Type = FXFW.SqlDB.ConvertStringToInt(TxtEmpNationalID.Text.Substring(12, 1));
            if ((Type % 2) == 0)
                LUEGENDER_ID.ItemIndex = 1;//female
            else
                LUEGENDER_ID.ItemIndex = 0;//male
            string birthdate = string.Empty;
            //get birth day
            birthdate = TxtEmpNationalID.Text.Substring(5, 2) + "/";
            birthdate += TxtEmpNationalID.Text.Substring(3, 2) + "/";
            if (TxtEmpNationalID.Text.Substring(0, 1) == "2")
                birthdate += "19" + TxtEmpNationalID.Text.Substring(1, 2);
            else
                birthdate += "20" + TxtEmpNationalID.Text.Substring(1, 2);
            DEBIRTH_DATE.Text = birthdate;
            DEBIRTH_DATE.EditValue = DEBIRTH_DATE.DateTime;
            //get the birth state
            try
            { LUEBIRTH_GOV.EditValue = TxtEmpNationalID.Text.Substring(7, 2); }
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
            if (LUEEmp.ItemIndex == -1)
            {
                btnNew_Click(btnNew, new EventArgs());
                btnUpdate.Enabled = false;
                btnSave.Enabled = false;
                return;
            }

            DataRow row = ((DataTable)LUEEmp.Properties.DataSource).Rows[LUEEmp.ItemIndex];

            TxtEMP_FIRST_NAME.Text = row["EMP_FIRST_NAME"].ToString();
            TxtEMP_FATHER_NAME.Text = row["EMP_FATHER_NAME"].ToString();
            TxtEMP_FAM_NAME.Text = row["EMP_FAM_NAME"].ToString();
            TxtEMP_FOURTH_NAME.Text = row["EMP_FOURTH_NAME"].ToString();
            TxtEmpNationalID.Text = row["EmpNationalID"].ToString();
            LUEBIRTH_GOV.EditValue = row["BIRTH_GOV"];
            DEBIRTH_DATE.EditValue = row["BIRTH_DATE"];
            cbBIRTH_PLACE.EditValue = row["BIRTH_PLACE"].ToString();
            LUEnationaltyId.EditValue = row["nationaltyId"];
            LUEGENDER_ID.EditValue = row["GENDER_ID"];
            LUEMaritalStatusId.EditValue = row["MaritalStatusId"];
            LUEdyana_code.EditValue = row["dyana_code"];

            TxtEmp_Address.Text = row["Emp_Address"].ToString();
            TxtPHONE_NO.Text = row["PHONE_NO"].ToString();
            TxtMOBILE_NO.Text = row["MOBILE_NO"].ToString();

            LUEEmpJobId.EditValue = row["EmpJobId"];
            LUEJOB_STATUS_ID.EditValue = row["JOB_STATUS_ID"];
            LUEJobDescriptionId.EditValue = row["JobDescriptionId"];
            LUEDepartmentId.EditValue = row["DepartmentId"];
            DEWork_Start_Date.EditValue = row["Work_Start_Date"];
            DEEnd_Work_Date.EditValue = row["End_Work_Date"];
            LUEqualId.EditValue = row["qualId"];
            LUESpecializationId.EditValue = row["SpecializationId"];
            LUEQualifiedPlaceId.EditValue = row["QualifiedPlaceId"];
            TxtMoaahel_Date.EditValue = row["Moaahel_Date"].ToString();

            Txttameen_no.Text = row["tameen_no"].ToString();
            DEtameen_date1.EditValue = row["tameen_date1"];
            Txtbetaka_tameen.Text = row["betaka_tameen"].ToString();
            Txtorderreport.Text = row["orderreport"].ToString();
            if (FXFW.SqlDB.IsNullOrEmpty(row["noview"]))
                CEnoview.Checked = false;
            else
                CEnoview.Checked = (bool)row["noview"];
            // Load Pic
            if (DBNull.Value != row["EMPPIC"])
            {
                System.IO.MemoryStream stream = new System.IO.MemoryStream();
                byte[] MemPic = (byte[])row["EMPPIC"];
                System.IO.MemoryStream ms = new System.IO.MemoryStream(MemPic);
                PBImage.Image = Image.FromStream(ms);
            }
            else
                PBImage.Image = null;

            btnSave.Enabled = false;
            btnUpdate.Enabled = true;

            //refresh data inside controls
            for (int i = 0; i < xtraTabControlMain.TabPages.Count; i++)
                xtraTabControlMain.SelectedTabPageIndex = i;
            xtraTabControlMain.SelectedTabPageIndex = 0;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            TxtEMP_FIRST_NAME.Text = string.Empty;
            TxtEMP_FATHER_NAME.Text = string.Empty;
            TxtEMP_FAM_NAME.Text = string.Empty;
            TxtEMP_FOURTH_NAME.Text = string.Empty;
            TxtEmpNationalID.Text = string.Empty;
            LUEBIRTH_GOV.EditValue = null;
            DEBIRTH_DATE.EditValue = null;
            cbBIRTH_PLACE.EditValue = null;
            LUEnationaltyId.EditValue = null;
            LUEGENDER_ID.EditValue = null;
            LUEMaritalStatusId.EditValue = null;
            LUEdyana_code.EditValue = null;

            TxtEmp_Address.Text = string.Empty;
            TxtPHONE_NO.Text = string.Empty;
            TxtMOBILE_NO.Text = string.Empty;

            LUEEmpJobId.EditValue = null;
            LUEJOB_STATUS_ID.EditValue = null;
            LUEJobDescriptionId.EditValue = null;
            LUEDepartmentId.EditValue = null;
            DEWork_Start_Date.EditValue = null;
            DEEnd_Work_Date.EditValue = null;
            LUEqualId.EditValue = null;
            LUESpecializationId.EditValue = null;
            LUEQualifiedPlaceId.EditValue = null;
            TxtMoaahel_Date.EditValue = string.Empty;

            Txttameen_no.Text = string.Empty;
            DEtameen_date1.EditValue = null;
            Txtbetaka_tameen.Text = string.Empty;
            Txtorderreport.Text = string.Empty;
            CEnoview.Checked = false;
            PBImage.ImageLocation = string.Empty; PBImage.Image = null;

            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }
        private void BtnLoadImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            if (OFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                PBImage.ImageLocation = OFD.FileName;
        }
        private void LUEEmpJobId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CD_EmpJob);
            FrmCode.ShowDialog();
            LoadDefaultData(TableName.CD_EmpJob);
        }
        private void LUEJobDescriptionId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CD_JobDescription);
            FrmCode.ShowDialog();
            LoadDefaultData(TableName.CD_JobDescription);
        }
        private void LUEDepartmentId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CD_Department);
            FrmCode.ShowDialog();
            LoadDefaultData(TableName.CD_Department);
        }
        private void LUESubjectId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CD_Subject);
            FrmCode.ShowDialog();
            LoadDefaultData(TableName.CD_Subject);
        }
        private void LUEqualId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDQualification);
            FrmCode.ShowDialog();
            LoadDefaultData(TableName.CDQualification);
        }
        private void LUESpecializationId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CD_Specialization);
            FrmCode.ShowDialog();
            LoadDefaultData(TableName.CD_Specialization);
        }
        private void LUEQualifiedPlaceId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CD_QualifiedPlace);
            FrmCode.ShowDialog();
            LoadDefaultData(TableName.CD_QualifiedPlace);
        }
        private void LUEJOB_STATUS_ID_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CD_EmpState);
            FrmCode.ShowDialog();
            LoadDefaultData(TableName.CD_EmpState);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            string EMP_FIRST_NAME;
            if (TxtEMP_FIRST_NAME.Text != string.Empty)
                EMP_FIRST_NAME = String.Format("N'{0}'", TxtEMP_FIRST_NAME.Text);
            else
                EMP_FIRST_NAME = "N''";
            string EMP_FATHER_NAME;
            if (TxtEMP_FATHER_NAME.Text != string.Empty)
                EMP_FATHER_NAME = String.Format("N'{0}'", TxtEMP_FATHER_NAME.Text);
            else
                EMP_FATHER_NAME = "N''";
            string EMP_FAM_NAME;
            if (TxtEMP_FAM_NAME.Text != string.Empty)
                EMP_FAM_NAME = String.Format("N'{0}'", TxtEMP_FAM_NAME.Text);
            else
                EMP_FAM_NAME = "N''";
            string EMP_FOURTH_NAME;
            if (TxtEMP_FOURTH_NAME.Text != string.Empty)
                EMP_FOURTH_NAME = String.Format("N'{0}'", TxtEMP_FOURTH_NAME.Text);
            else
                EMP_FOURTH_NAME = "N''";
            string EmpNationalID;
            if (TxtEmpNationalID.Text != string.Empty)
                EmpNationalID = String.Format("N'{0}'", TxtEmpNationalID.Text);
            else
                EmpNationalID = "NULL";
            string BIRTH_GOV;
            if (LUEBIRTH_GOV.ItemIndex < 0)
                BIRTH_GOV = "NULL";
            else
                BIRTH_GOV = LUEBIRTH_GOV.EditValue.ToString();
            string BIRTH_DATE;
            if (DEBIRTH_DATE.Text == string.Empty)
                BIRTH_DATE = "NULL";
            else
                BIRTH_DATE = string.Format("Convert(datetime, '{0}', 103)", DEBIRTH_DATE.Text);
            string BIRTH_PLACE;
            if (cbBIRTH_PLACE.Text == string.Empty)
                BIRTH_PLACE = "NULL";
            else
                BIRTH_PLACE = string.Format("N'{0}'", cbBIRTH_PLACE.Text);
            string nationaltyId;
            if (LUEnationaltyId.ItemIndex < 0)
                nationaltyId = "NULL";
            else
                nationaltyId = LUEnationaltyId.EditValue.ToString();
            string GENDER_ID;
            if (LUEGENDER_ID.ItemIndex < 0)
                GENDER_ID = "NULL";
            else
                GENDER_ID = LUEGENDER_ID.EditValue.ToString();
            string MaritalStatusId;
            if (LUEMaritalStatusId.ItemIndex < 0)
                MaritalStatusId = "NULL";
            else
                MaritalStatusId = LUEMaritalStatusId.EditValue.ToString();
            string dyana_code;
            if (LUEdyana_code.ItemIndex < 0)
                dyana_code = "NULL";
            else
                dyana_code = LUEdyana_code.EditValue.ToString();
            /////////////////////////////
            string Emp_Address;
            if (TxtEmp_Address.Text != string.Empty)
                Emp_Address = String.Format("N'{0}'", TxtEmp_Address.Text);
            else
                Emp_Address = "NULL";
            string PHONE_NO;
            if (TxtPHONE_NO.Text != string.Empty)
                PHONE_NO = String.Format("N'{0}'", TxtPHONE_NO.Text);
            else
                PHONE_NO = "NULL";
            string MOBILE_NO;
            if (TxtMOBILE_NO.Text != string.Empty)
                MOBILE_NO = String.Format("N'{0}'", TxtMOBILE_NO.Text);
            else
                MOBILE_NO = "NULL";
            //////////////////////////////
            string EmpJobId;
            if (LUEEmpJobId.ItemIndex < 0)
                EmpJobId = "NULL";
            else
                EmpJobId = LUEEmpJobId.EditValue.ToString();
            string JOB_STATUS_ID;
            if (LUEJOB_STATUS_ID.ItemIndex < 0)
                JOB_STATUS_ID = "NULL";
            else
                JOB_STATUS_ID = LUEJOB_STATUS_ID.EditValue.ToString();
            string JobDescriptionId;
            if (LUEJobDescriptionId.ItemIndex < 0)
                JobDescriptionId = "NULL";
            else
                JobDescriptionId = LUEJobDescriptionId.EditValue.ToString();
            string DepartmentId;
            if (LUEDepartmentId.ItemIndex < 0)
                DepartmentId = "NULL";
            else
                DepartmentId = LUEDepartmentId.EditValue.ToString();
            //string marhala_code;
            //if (LUEmarhala_code.ItemIndex < 0)
            //    marhala_code = "NULL";
            //else
            //    marhala_code = LUEmarhala_code.EditValue.ToString();
            //string SubjectId;
            //if (LUESubjectId.ItemIndex < 0)
            //    SubjectId = "NULL";
            //else
            //    SubjectId = LUESubjectId.EditValue.ToString();
            string Work_Start_Date;
            if (DEWork_Start_Date.Text == string.Empty)
                Work_Start_Date = "NULL";
            else
                Work_Start_Date = string.Format("Convert(datetime, '{0}', 103)", DEWork_Start_Date.Text);
            string End_Work_Date;
            if (DEEnd_Work_Date.Text == string.Empty)
                End_Work_Date = "NULL";
            else
                End_Work_Date = string.Format("Convert(datetime, '{0}', 103)", DEEnd_Work_Date.Text);
            string qualId;
            if (LUEqualId.ItemIndex < 0)
                qualId = "NULL";
            else
                qualId = LUEqualId.EditValue.ToString();
            string SpecializationId;
            if (LUESpecializationId.ItemIndex < 0)
                SpecializationId = "NULL";
            else
                SpecializationId = LUESpecializationId.EditValue.ToString();
            string QualifiedPlaceId;
            if (LUEQualifiedPlaceId.ItemIndex < 0)
                QualifiedPlaceId = "NULL";
            else
                QualifiedPlaceId = LUEQualifiedPlaceId.EditValue.ToString();
            string Moaahel_Date;
            if (TxtMoaahel_Date.Text == string.Empty)
                Moaahel_Date = "Null";
            else
                Moaahel_Date = string.Format("N'{0}'", TxtMoaahel_Date.Text);
            /////////////////////////////////////
            string tameen_no;
            if (Txttameen_no.Text != string.Empty)
                tameen_no = String.Format("N'{0}'", Txttameen_no.Text);
            else
                tameen_no = "NULL";
            string tameen_date1;
            if (DEtameen_date1.Text == string.Empty)
                tameen_date1 = "NULL";
            else
                tameen_date1 = string.Format("Convert(datetime, '{0}', 103)", DEtameen_date1.Text);
            string betaka_tameen;
            if (Txtbetaka_tameen.Text != string.Empty)
                betaka_tameen = String.Format("N'{0}'", Txtbetaka_tameen.Text);
            else
                betaka_tameen = "NULL";
            string orderreport;
            if (Txtorderreport.Text != string.Empty)
                orderreport = String.Format("N'{0}'", Txtorderreport.Text);
            else
                orderreport = "0";
            string noview = String.Format("'{0}'", CEnoview.Checked);

            byte[] EMPPIC = null;

            try
            {
                con.Open();
                cmd.CommandText = string.Format(@"INSERT INTO TBL_Emp (EmpID, EmpNationalID, EMP_FIRST_NAME, EMP_FATHER_NAME, EMP_FAM_NAME, EMP_FOURTH_NAME, 
                nationaltyId, dyana_code, MaritalStatusId, DepartmentId, EmpJobId, BIRTH_DATE, GENDER_ID, BIRTH_GOV, JOB_STATUS_ID, BIRTH_PLACE, Emp_Address, PHONE_NO, 
                MOBILE_NO, JobDescriptionId, Work_Start_Date, End_Work_Date, qualId, SpecializationId, QualifiedPlaceId, Moaahel_Date, tameen_no, tameen_date1, 
                betaka_tameen, noview, orderreport, EMPPIC) VALUES ((SELECT ISNULL(MAX(EmpID) + 1, 1) FROM TBL_Emp), {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9},
                {10}, {11}, {12}, {13}, {14}, {15}, {16}, {17}, {18}, {19}, {20}, {21}, {22}, {23}, {24}, {25}, {26}, {27}, {28}, {29}, @EMPPIC)",
                EmpNationalID, EMP_FIRST_NAME, EMP_FATHER_NAME, EMP_FAM_NAME, EMP_FOURTH_NAME, nationaltyId, dyana_code, MaritalStatusId, DepartmentId,
                EmpJobId, BIRTH_DATE, GENDER_ID, BIRTH_GOV, JOB_STATUS_ID, BIRTH_PLACE, Emp_Address, PHONE_NO, MOBILE_NO, JobDescriptionId, Work_Start_Date, End_Work_Date, qualId,
                SpecializationId, QualifiedPlaceId, Moaahel_Date, tameen_no, tameen_date1, betaka_tameen, noview, orderreport);
                if (PBImage.Image != null)
                {
                    EMPPIC = System.IO.File.ReadAllBytes(PBImage.ImageLocation);
                    cmd.Parameters.AddWithValue("@EMPPIC", EMPPIC);
                }
                else
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    global::Employee.Properties.Resources.NoImg.Save(ms, global::Employee.Properties.Resources.NoImg.RawFormat);
                    EMPPIC = ms.GetBuffer();
                    cmd.Parameters.AddWithValue("@EMPPIC", EMPPIC);
                }

                cmd.ExecuteNonQuery();
                Program.ShowMsg("تم الاضافه", false, this);
                Program.Logger.LogThis("تم الاضافه", Text, FXFW.Logger.OpType.success, null, null, this);
                LoadData();
                btnNew_Click(btnNew, new EventArgs());
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
            con.Close();

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);

            string EMP_FIRST_NAME;
            if (TxtEMP_FIRST_NAME.Text != string.Empty)
                EMP_FIRST_NAME = String.Format("N'{0}'", TxtEMP_FIRST_NAME.Text);
            else
                EMP_FIRST_NAME = "N''";
            string EMP_FATHER_NAME;
            if (TxtEMP_FATHER_NAME.Text != string.Empty)
                EMP_FATHER_NAME = String.Format("N'{0}'", TxtEMP_FATHER_NAME.Text);
            else
                EMP_FATHER_NAME = "N''";
            string EMP_FAM_NAME;
            if (TxtEMP_FAM_NAME.Text != string.Empty)
                EMP_FAM_NAME = String.Format("N'{0}'", TxtEMP_FAM_NAME.Text);
            else
                EMP_FAM_NAME = "N''";
            string EMP_FOURTH_NAME;
            if (TxtEMP_FOURTH_NAME.Text != string.Empty)
                EMP_FOURTH_NAME = String.Format("N'{0}'", TxtEMP_FOURTH_NAME.Text);
            else
                EMP_FOURTH_NAME = "N''";
            string EmpNationalID;
            if (TxtEmpNationalID.Text != string.Empty)
                EmpNationalID = String.Format("N'{0}'", TxtEmpNationalID.Text);
            else
                EmpNationalID = "NULL";
            string BIRTH_GOV;
            if (LUEBIRTH_GOV.ItemIndex < 0)
                BIRTH_GOV = "NULL";
            else
                BIRTH_GOV = LUEBIRTH_GOV.EditValue.ToString();
            string BIRTH_DATE;
            if (DEBIRTH_DATE.Text == string.Empty)
                BIRTH_DATE = "NULL";
            else
                BIRTH_DATE = string.Format("Convert(datetime, '{0}', 103)", DEBIRTH_DATE.Text);
            string BIRTH_PLACE;
            if (cbBIRTH_PLACE.Text == string.Empty)
                BIRTH_PLACE = "NULL";
            else
                BIRTH_PLACE = string.Format("N'{0}'", cbBIRTH_PLACE.Text);
            string nationaltyId;
            if (LUEnationaltyId.ItemIndex < 0)
                nationaltyId = "NULL";
            else
                nationaltyId = LUEnationaltyId.EditValue.ToString();
            string GENDER_ID;
            if (LUEGENDER_ID.ItemIndex < 0)
                GENDER_ID = "NULL";
            else
                GENDER_ID = LUEGENDER_ID.EditValue.ToString();
            string MaritalStatusId;
            if (LUEMaritalStatusId.ItemIndex < 0)
                MaritalStatusId = "NULL";
            else
                MaritalStatusId = LUEMaritalStatusId.EditValue.ToString();
            string dyana_code;
            if (LUEdyana_code.ItemIndex < 0)
                dyana_code = "NULL";
            else
                dyana_code = LUEdyana_code.EditValue.ToString();
            /////////////////////////////
            string Emp_Address;
            if (TxtEmp_Address.Text != string.Empty)
                Emp_Address = String.Format("N'{0}'", TxtEmp_Address.Text);
            else
                Emp_Address = "NULL";
            string PHONE_NO;
            if (TxtPHONE_NO.Text != string.Empty)
                PHONE_NO = String.Format("N'{0}'", TxtPHONE_NO.Text);
            else
                PHONE_NO = "NULL";
            string MOBILE_NO;
            if (TxtMOBILE_NO.Text != string.Empty)
                MOBILE_NO = String.Format("N'{0}'", TxtMOBILE_NO.Text);
            else
                MOBILE_NO = "NULL";
            //////////////////////////////
            string EmpJobId;
            if (LUEEmpJobId.ItemIndex < 0)
                EmpJobId = "NULL";
            else
                EmpJobId = LUEEmpJobId.EditValue.ToString();
            string JOB_STATUS_ID;
            if (LUEJOB_STATUS_ID.ItemIndex < 0)
                JOB_STATUS_ID = "NULL";
            else
                JOB_STATUS_ID = LUEJOB_STATUS_ID.EditValue.ToString();
            string JobDescriptionId;
            if (LUEJobDescriptionId.ItemIndex < 0)
                JobDescriptionId = "NULL";
            else
                JobDescriptionId = LUEJobDescriptionId.EditValue.ToString();
            string DepartmentId;
            if (LUEDepartmentId.ItemIndex < 0)
                DepartmentId = "NULL";
            else
                DepartmentId = LUEDepartmentId.EditValue.ToString();
            //string marhala_code;
            //if (LUEmarhala_code.ItemIndex < 0)
            //    marhala_code = "NULL";
            //else
            //    marhala_code = LUEmarhala_code.EditValue.ToString();
            //string SubjectId;
            //if (LUESubjectId.ItemIndex < 0)
            //    SubjectId = "NULL";
            //else
            //    SubjectId = LUESubjectId.EditValue.ToString();
            string Work_Start_Date;
            if (DEWork_Start_Date.Text == string.Empty)
                Work_Start_Date = "NULL";
            else
                Work_Start_Date = string.Format("Convert(datetime, '{0}', 103)", DEWork_Start_Date.Text);
            string End_Work_Date;
            if (DEEnd_Work_Date.Text == string.Empty)
                End_Work_Date = "NULL";
            else
                End_Work_Date = string.Format("Convert(datetime, '{0}', 103)", DEEnd_Work_Date.Text);
            string qualId;
            if (LUEqualId.ItemIndex < 0)
                qualId = "NULL";
            else
                qualId = LUEqualId.EditValue.ToString();
            string SpecializationId;
            if (LUESpecializationId.ItemIndex < 0)
                SpecializationId = "NULL";
            else
                SpecializationId = LUESpecializationId.EditValue.ToString();
            string QualifiedPlaceId;
            if (LUEQualifiedPlaceId.ItemIndex < 0)
                QualifiedPlaceId = "NULL";
            else
                QualifiedPlaceId = LUEQualifiedPlaceId.EditValue.ToString();
            string Moaahel_Date;
            if (TxtMoaahel_Date.Text == string.Empty)
                Moaahel_Date = "NULL";
            else
                Moaahel_Date = string.Format("N'{0}'", TxtMoaahel_Date.Text);
            /////////////////////////////////////
            string tameen_no;
            if (Txttameen_no.Text != string.Empty)
                tameen_no = String.Format("N'{0}'", Txttameen_no.Text);
            else
                tameen_no = "NULL";
            string tameen_date1;
            if (DEtameen_date1.Text == string.Empty)
                tameen_date1 = "NULL";
            else
                tameen_date1 = string.Format("Convert(datetime, '{0}', 103)", DEtameen_date1.Text);
            string betaka_tameen;
            if (Txtbetaka_tameen.Text != string.Empty)
                betaka_tameen = String.Format("N'{0}'", Txtbetaka_tameen.Text);
            else
                betaka_tameen = "NULL";
            string orderreport;
            if (Txtorderreport.Text != string.Empty)
                orderreport = String.Format("N'{0}'", Txtorderreport.Text);
            else
                orderreport = "0";
            string noview = String.Format("'{0}'", CEnoview.Checked);

            byte[] EMPPIC = null;

            try
            {
                con.Open();
                cmd.CommandText = string.Format(@"Update TBL_Emp Set EmpNationalID= {0}, EMP_FIRST_NAME= {1}, EMP_FATHER_NAME= {2}, EMP_FAM_NAME = {3}, EMP_FOURTH_NAME = {4}, 
                nationaltyId = {5}, dyana_code = {6}, MaritalStatusId = {7}, DepartmentId = {8}, EmpJobId = {9}, BIRTH_DATE = {10}, GENDER_ID = {11}, BIRTH_GOV = {12}, JOB_STATUS_ID = {13}, BIRTH_PLACE = {14}, Emp_Address = {15}, PHONE_NO = {16}, 
                MOBILE_NO = {17}, JobDescriptionId = {18}, Work_Start_Date = {19}, End_Work_Date = {20}, qualId = {21}, SpecializationId = {22}, QualifiedPlaceId = {23}, Moaahel_Date = {24}, tameen_no = {25}, tameen_date1 = {26}, 
                betaka_tameen = {27}, noview = {28}, orderreport = {29}, EMPPIC = @EMPPIC Where EmpID = {30}",
                EmpNationalID, EMP_FIRST_NAME, EMP_FATHER_NAME, EMP_FAM_NAME, EMP_FOURTH_NAME, nationaltyId, dyana_code, MaritalStatusId, DepartmentId,
                EmpJobId, BIRTH_DATE, GENDER_ID, BIRTH_GOV, JOB_STATUS_ID, BIRTH_PLACE, Emp_Address, PHONE_NO, MOBILE_NO, JobDescriptionId, Work_Start_Date, End_Work_Date, qualId,
                SpecializationId, QualifiedPlaceId, Moaahel_Date, tameen_no, tameen_date1, betaka_tameen, noview, orderreport, LUEEmp.EditValue);

                if (FXFW.SqlDB.IsNullOrEmpty(PBImage.ImageLocation))
                    EMPPIC = (byte[])((DataTable)LUEEmp.Properties.DataSource).Rows[LUEEmp.ItemIndex]["EMPPIC"];    
                else
                    EMPPIC = System.IO.File.ReadAllBytes(PBImage.ImageLocation);
                
                cmd.Parameters.AddWithValue("@EMPPIC", EMPPIC);

                //if (PBImage.Image == null)
                //{
                //    EMPPIC = System.IO.File.ReadAllBytes(PBImage.ImageLocation);
                //    cmd.Parameters.AddWithValue("@EMPPIC", EMPPIC);
                //}
                //else
                //{
                //    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                //    if (DBNull.Value != ((DataTable)LUEEmp.Properties.DataSource).Rows[LUEEmp.ItemIndex]["EMPPIC"])
                //        EMPPIC = (byte[])((DataTable)LUEEmp.Properties.DataSource).Rows[LUEEmp.ItemIndex]["EMPPIC"];
                //    else
                //    {
                //        global::Employee.Properties.Resources.NoImg.Save(ms, global::Employee.Properties.Resources.NoImg.RawFormat);
                //        EMPPIC = ms.GetBuffer();
                //    }
                //    cmd.Parameters.AddWithValue("@EMPPIC", EMPPIC);
                //}

                cmd.ExecuteNonQuery();
                Program.ShowMsg("تم التعديل", false, this);
                Program.Logger.LogThis("تم التعديل", Text, FXFW.Logger.OpType.success, null, null, this);
                LoadData();
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
            con.Close();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (LUEEmp.EditValue == null)
                return;
            if (LUEEmp.ItemIndex == -1)
                return;
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                cmd.CommandText = @"Delete From TBL_Emp Where EmpID = " + LUEEmp.EditValue;
                con.Open();
                cmd.ExecuteNonQuery();
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
        #endregion         #region -   Variables   -
    }
}