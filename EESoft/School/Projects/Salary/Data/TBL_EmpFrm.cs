using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace Salary
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
                    LUEBIRTH_GOV.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT GOV_CD, GOV, GOVe FROM CDGov");
                    LUEBIRTH_GOV.Properties.DisplayMember = "GOV";
                    LUEBIRTH_GOV.Properties.ValueMember = "GOV_CD";
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
                    LUEEmpJobId.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT EmpJobId, EmpJobName, EmpJobName_e FROM CD_EmpJob");
                    LUEEmpJobId.Properties.DisplayMember = "EmpJobName";
                    LUEEmpJobId.Properties.ValueMember = "EmpJobId";
                    //CD_JobDescription
                    LUEJobDescriptionId.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT JobDescriptionId, JobDescription, JobDescription_e FROM CD_JobDescription");
                    LUEJobDescriptionId.Properties.DisplayMember = "JobDescription";
                    LUEJobDescriptionId.Properties.ValueMember = "JobDescriptionId";
                    //CD_Department
                    LUEDepartmentId.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT DepartmentId, Department, Department_e FROM CD_Department");
                    LUEDepartmentId.Properties.DisplayMember = "Department";
                    LUEDepartmentId.Properties.ValueMember = "DepartmentId";
                    //CDMarahel
                    LUEmarhala_code.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT marhala_code, marhala_name, marhala_name_e FROM CDMarahel");
                    LUEmarhala_code.Properties.DisplayMember = "marhala_name";
                    LUEmarhala_code.Properties.ValueMember = "marhala_code";
                    //CD_Subject
                    LUESubjectId.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT SubjectId, Subject, Subject_e FROM CD_Subject");
                    LUESubjectId.Properties.DisplayMember = "Subject";
                    LUESubjectId.Properties.ValueMember = "SubjectId";
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
                    LUEBIRTH_GOV.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT GOV_CD, GOV, GOVe FROM CDGov");
                    LUEBIRTH_GOV.Properties.DisplayMember = "GOV";
                    LUEBIRTH_GOV.Properties.ValueMember = "GOV_CD";
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
                    LUEEmpJobId.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT EmpJobId, EmpJobName, EmpJobName_e FROM CD_EmpJob");
                    LUEEmpJobId.Properties.DisplayMember = "EmpJobName";
                    LUEEmpJobId.Properties.ValueMember = "EmpJobId";
                    break;
                case TableName.CD_JobDescription:
                    //CD_JobDescription
                    LUEJobDescriptionId.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT JobDescriptionId, JobDescription, JobDescription_e FROM CD_JobDescription");
                    LUEJobDescriptionId.Properties.DisplayMember = "JobDescription";
                    LUEJobDescriptionId.Properties.ValueMember = "JobDescriptionId";
                    break;
                case TableName.CD_Department:
                    //CD_Department
                    LUEDepartmentId.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT DepartmentId, Department, Department_e FROM CD_Department");
                    LUEDepartmentId.Properties.DisplayMember = "Department";
                    LUEDepartmentId.Properties.ValueMember = "DepartmentId";
                    break;
                case TableName.CDMarahel:
                    //CDMarahel
                    LUEmarhala_code.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT marhala_code, marhala_name, marhala_name_e FROM CDMarahel");
                    LUEmarhala_code.Properties.DisplayMember = "marhala_name";
                    LUEmarhala_code.Properties.ValueMember = "marhala_code";
                    break;
                case TableName.CD_Subject:
                    //CD_Subject
                    LUESubjectId.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT SubjectId, Subject, Subject_e FROM CD_Subject");
                    LUESubjectId.Properties.DisplayMember = "Subject";
                    LUESubjectId.Properties.ValueMember = "SubjectId";
                    break;
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
            marhala_code, EmpNationalID, EMP_FIRST_NAME, EMP_FATHER_NAME, EMP_FAM_NAME, EMP_FOURTH_NAME, nationaltyId, dyana_code, 
            MaritalStatusId, SubjectId, DepartmentId, EmpJobId, BIRTH_DATE, GENDER_ID, BIRTH_GOV, JOB_STATUS_ID, BIRTH_PLACE, Emp_Address, PHONE_NO, 
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
            FXFW.SqlDB.GetFormPriv("Salary" + Name.Replace("Frm", ""), ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
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
            LUEmarhala_code.EditValue = row["marhala_code"];
            LUESubjectId.EditValue = row["SubjectId"];
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
            CEnoview.Checked = (bool)row["noview"]; ;
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
            LUEmarhala_code.EditValue = null;
            LUESubjectId.EditValue = null;
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
            //if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
            //    return;
            //CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CD_EmpJob);
            //FrmCode.ShowDialog();
            //LoadDefaultData(TableName.CD_EmpJob);
        }
        private void LUEJobDescriptionId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
            //    return;
            //CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CD_JobDescription);
            //FrmCode.ShowDialog();
            //LoadDefaultData(TableName.CD_JobDescription);
        }
        private void LUEDepartmentId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
            //    return;
            //CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CD_Department);
            //FrmCode.ShowDialog();
            //LoadDefaultData(TableName.CD_Department);
        }
        private void LUESubjectId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
            //    return;
            //CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CD_Subject);
            //FrmCode.ShowDialog();
            //LoadDefaultData(TableName.CD_Subject);
        }
        private void LUEqualId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
            //    return;
            //CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDQualification);
            //FrmCode.ShowDialog();
            //LoadDefaultData(TableName.CDQualification);
        }
        private void LUESpecializationId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
            //    return;
            //CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CD_Specialization);
            //FrmCode.ShowDialog();
            //LoadDefaultData(TableName.CD_Specialization);
        }
        private void LUEQualifiedPlaceId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
            //    return;
            //CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CD_QualifiedPlace);
            //FrmCode.ShowDialog();
            //LoadDefaultData(TableName.CD_QualifiedPlace);
        }
        private void LUEJOB_STATUS_ID_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
            //    return;
            //CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CD_EmpState);
            //FrmCode.ShowDialog();
            //LoadDefaultData(TableName.CD_EmpState);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            cmd.Parameters.Add(new SqlParameter("@EMP_FIRST_NAME", SqlDbType.NVarChar) { Value = TxtEMP_FIRST_NAME.Text });
            cmd.Parameters.Add(new SqlParameter("@EMP_FATHER_NAME", SqlDbType.NVarChar) { Value = TxtEMP_FATHER_NAME.Text });
            cmd.Parameters.Add(new SqlParameter("@EMP_FAM_NAME", SqlDbType.NVarChar) { Value = TxtEMP_FAM_NAME.Text });
            cmd.Parameters.Add(new SqlParameter("@EMP_FOURTH_NAME", SqlDbType.NVarChar) { Value = TxtEMP_FOURTH_NAME.Text });
            cmd.Parameters.Add(new SqlParameter("@EmpNationalID", SqlDbType.NVarChar) { Value = TxtEmpNationalID.Text });
            cmd.Parameters.Add(new SqlParameter("@BIRTH_GOV", SqlDbType.TinyInt) { Value = LUEBIRTH_GOV.EditValue });
            cmd.Parameters.Add(new SqlParameter("@BIRTH_DATE", SqlDbType.Date) { Value = DEBIRTH_DATE.EditValue });
            cmd.Parameters.Add(new SqlParameter("@BIRTH_PLACE", SqlDbType.NVarChar) { Value = cbBIRTH_PLACE.Text });
            cmd.Parameters.Add(new SqlParameter("@nationaltyId", SqlDbType.TinyInt) { Value = LUEnationaltyId.EditValue });
            cmd.Parameters.Add(new SqlParameter("@GENDER_ID", SqlDbType.TinyInt) { Value = LUEGENDER_ID.EditValue });
            cmd.Parameters.Add(new SqlParameter("@MaritalStatusId", SqlDbType.TinyInt) { Value = LUEMaritalStatusId.EditValue });
            cmd.Parameters.Add(new SqlParameter("@dyana_code", SqlDbType.TinyInt) { Value = LUEdyana_code.EditValue });
            /////////////////////////////
            cmd.Parameters.Add(new SqlParameter("@Emp_Address", SqlDbType.NVarChar) { Value = TxtEmp_Address.Text });
            cmd.Parameters.Add(new SqlParameter("@PHONE_NO", SqlDbType.NVarChar) { Value = TxtPHONE_NO.Text });
            cmd.Parameters.Add(new SqlParameter("@MOBILE_NO", SqlDbType.NVarChar) { Value = TxtMOBILE_NO.Text });
            //////////////////////////////
            cmd.Parameters.Add(new SqlParameter("@EmpJobId", SqlDbType.Int) { Value = LUEEmpJobId.EditValue });
            cmd.Parameters.Add(new SqlParameter("@JOB_STATUS_ID", SqlDbType.TinyInt) { Value = LUEJOB_STATUS_ID.EditValue });
            cmd.Parameters.Add(new SqlParameter("@JobDescriptionId", SqlDbType.SmallInt) { Value = LUEJobDescriptionId.EditValue });
            cmd.Parameters.Add(new SqlParameter("@DepartmentId", SqlDbType.TinyInt) { Value = LUEDepartmentId.EditValue });
            cmd.Parameters.Add(new SqlParameter("@marhala_code", SqlDbType.TinyInt) { Value = LUEmarhala_code.EditValue });
            cmd.Parameters.Add(new SqlParameter("@SubjectId", SqlDbType.SmallInt) { Value = LUESubjectId.EditValue });
            cmd.Parameters.Add(new SqlParameter("@Work_Start_Date", SqlDbType.Date) { Value = DEWork_Start_Date.EditValue });
            cmd.Parameters.Add(new SqlParameter("@End_Work_Date", SqlDbType.Date) { Value = DEEnd_Work_Date.EditValue });
            cmd.Parameters.Add(new SqlParameter("@qualId", SqlDbType.Int) { Value = LUEqualId.EditValue });
            cmd.Parameters.Add(new SqlParameter("@SpecializationId", SqlDbType.Int) { Value = LUESpecializationId.EditValue });
            cmd.Parameters.Add(new SqlParameter("@QualifiedPlaceId", SqlDbType.Int) { Value = LUEQualifiedPlaceId.EditValue });
            cmd.Parameters.Add(new SqlParameter("@Moaahel_Date", SqlDbType.NVarChar) { Value = TxtMoaahel_Date.Text });
            /////////////////////////////////////
            cmd.Parameters.Add(new SqlParameter("@tameen_no", SqlDbType.NVarChar) { Value = Txttameen_no.Text });
            cmd.Parameters.Add(new SqlParameter("@tameen_date1", SqlDbType.Date) { Value = DEtameen_date1.EditValue });
            cmd.Parameters.Add(new SqlParameter("@betaka_tameen", SqlDbType.NVarChar) { Value = Txtbetaka_tameen.Text });
            cmd.Parameters.Add(new SqlParameter("@orderreport", SqlDbType.Int) { Value = Txtorderreport.Text });
            cmd.Parameters.Add(new SqlParameter("@noview", SqlDbType.Bit) { Value = CEnoview.Checked });
            foreach (SqlParameter item in cmd.Parameters)
            {
                if (FXFW.SqlDB.IsNullOrEmpty(item.Value))
                {
                    item.Value = DBNull.Value;
                }

            }
            byte[] EMPPIC = null;
            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO TBL_Emp (EmpID, marhala_code, EmpNationalID, EMP_FIRST_NAME, EMP_FATHER_NAME, EMP_FAM_NAME, EMP_FOURTH_NAME, 
                nationaltyId, dyana_code, MaritalStatusId, SubjectId, DepartmentId, EmpJobId, BIRTH_DATE, GENDER_ID, BIRTH_GOV, JOB_STATUS_ID, BIRTH_PLACE, Emp_Address, PHONE_NO, 
                MOBILE_NO, JobDescriptionId, Work_Start_Date, End_Work_Date, qualId, SpecializationId, QualifiedPlaceId, Moaahel_Date, tameen_no, tameen_date1, 
                betaka_tameen, noview, orderreport, EMPPIC)
                VALUES ((SELECT ISNULL(MAX(EmpID) + 1, 1) FROM TBL_Emp), @marhala_code, @EmpNationalID, @EMP_FIRST_NAME, @EMP_FATHER_NAME, @EMP_FAM_NAME, @EMP_FOURTH_NAME, 
                @nationaltyId, @dyana_code, @MaritalStatusId, @SubjectId, @DepartmentId, @EmpJobId, @BIRTH_DATE, @GENDER_ID, @BIRTH_GOV, @JOB_STATUS_ID, @BIRTH_PLACE, @Emp_Address, @PHONE_NO, 
                @MOBILE_NO, @JobDescriptionId, @Work_Start_Date, @End_Work_Date, @qualId, @SpecializationId, @QualifiedPlaceId, @Moaahel_Date, @tameen_no, @tameen_date1, 
                @betaka_tameen, @noview, @orderreport, @EMPPIC)";
                if (PBImage.Image != null)
                {
                    EMPPIC = System.IO.File.ReadAllBytes(PBImage.ImageLocation);
                    cmd.Parameters.AddWithValue("@EMPPIC", EMPPIC);
                }
                else
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    global::Salary.Properties.Resources.NoImg.Save(ms, global::Salary.Properties.Resources.NoImg.RawFormat);
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

            cmd.Parameters.Add(new SqlParameter("@EMP_FIRST_NAME", SqlDbType.NVarChar) { Value = TxtEMP_FIRST_NAME.Text });
            cmd.Parameters.Add(new SqlParameter("@EMP_FATHER_NAME", SqlDbType.NVarChar) { Value = TxtEMP_FATHER_NAME.Text });
            cmd.Parameters.Add(new SqlParameter("@EMP_FAM_NAME", SqlDbType.NVarChar) { Value = TxtEMP_FAM_NAME.Text });
            cmd.Parameters.Add(new SqlParameter("@EMP_FOURTH_NAME", SqlDbType.NVarChar) { Value = TxtEMP_FOURTH_NAME.Text });
            cmd.Parameters.Add(new SqlParameter("@EmpNationalID", SqlDbType.NVarChar) { Value = TxtEmpNationalID.Text });
            cmd.Parameters.Add(new SqlParameter("@BIRTH_GOV", SqlDbType.TinyInt) { Value = LUEBIRTH_GOV.EditValue });
            cmd.Parameters.Add(new SqlParameter("@BIRTH_DATE", SqlDbType.Date) { Value = DEBIRTH_DATE.EditValue });
            cmd.Parameters.Add(new SqlParameter("@BIRTH_PLACE", SqlDbType.NVarChar) { Value = cbBIRTH_PLACE.Text });
            cmd.Parameters.Add(new SqlParameter("@nationaltyId", SqlDbType.TinyInt) { Value = LUEnationaltyId.EditValue });
            cmd.Parameters.Add(new SqlParameter("@GENDER_ID", SqlDbType.TinyInt) { Value = LUEGENDER_ID.EditValue });
            cmd.Parameters.Add(new SqlParameter("@MaritalStatusId", SqlDbType.TinyInt) { Value = LUEMaritalStatusId.EditValue });
            cmd.Parameters.Add(new SqlParameter("@dyana_code", SqlDbType.TinyInt) { Value = LUEdyana_code.EditValue });
            /////////////////////////////
            cmd.Parameters.Add(new SqlParameter("@Emp_Address", SqlDbType.NVarChar) { Value = TxtEmp_Address.Text });
            cmd.Parameters.Add(new SqlParameter("@PHONE_NO", SqlDbType.NVarChar) { Value = TxtPHONE_NO.Text });
            cmd.Parameters.Add(new SqlParameter("@MOBILE_NO", SqlDbType.NVarChar) { Value = TxtMOBILE_NO.Text });
            //////////////////////////////
            cmd.Parameters.Add(new SqlParameter("@EmpJobId", SqlDbType.Int) { Value = LUEEmpJobId.EditValue });
            cmd.Parameters.Add(new SqlParameter("@JOB_STATUS_ID", SqlDbType.TinyInt) { Value = LUEJOB_STATUS_ID.EditValue });
            cmd.Parameters.Add(new SqlParameter("@JobDescriptionId", SqlDbType.SmallInt) { Value = LUEJobDescriptionId.EditValue });
            cmd.Parameters.Add(new SqlParameter("@DepartmentId", SqlDbType.TinyInt) { Value = LUEDepartmentId.EditValue });
            cmd.Parameters.Add(new SqlParameter("@marhala_code", SqlDbType.TinyInt) { Value = LUEmarhala_code.EditValue });
            cmd.Parameters.Add(new SqlParameter("@SubjectId", SqlDbType.SmallInt) { Value = LUESubjectId.EditValue });
            cmd.Parameters.Add(new SqlParameter("@Work_Start_Date", SqlDbType.Date) { Value = DEWork_Start_Date.EditValue });
            cmd.Parameters.Add(new SqlParameter("@End_Work_Date", SqlDbType.Date) { Value = DEEnd_Work_Date.EditValue });
            cmd.Parameters.Add(new SqlParameter("@qualId", SqlDbType.Int) { Value = LUEqualId.EditValue });
            cmd.Parameters.Add(new SqlParameter("@SpecializationId", SqlDbType.Int) { Value = LUESpecializationId.EditValue });
            cmd.Parameters.Add(new SqlParameter("@QualifiedPlaceId", SqlDbType.Int) { Value = LUEQualifiedPlaceId.EditValue });
            cmd.Parameters.Add(new SqlParameter("@Moaahel_Date", SqlDbType.NVarChar) { Value = TxtMoaahel_Date.Text });
            /////////////////////////////////////
            cmd.Parameters.Add(new SqlParameter("@tameen_no", SqlDbType.NVarChar) { Value = Txttameen_no.Text });
            cmd.Parameters.Add(new SqlParameter("@tameen_date1", SqlDbType.Date) { Value = DEtameen_date1.EditValue });
            cmd.Parameters.Add(new SqlParameter("@betaka_tameen", SqlDbType.NVarChar) { Value = Txtbetaka_tameen.Text });
            cmd.Parameters.Add(new SqlParameter("@orderreport", SqlDbType.Int) { Value = Txtorderreport.Text });
            cmd.Parameters.Add(new SqlParameter("@noview", SqlDbType.Bit) { Value = CEnoview.Checked });
            foreach (SqlParameter item in cmd.Parameters)
            {
                if (FXFW.SqlDB.IsNullOrEmpty(item.Value))
                {
                    item.Value = DBNull.Value;
                }

            }

            byte[] EMPPIC = null;

            try
            {
                con.Open();
                cmd.CommandText = @"Update TBL_Emp Set marhala_code= @marhala_code, EmpNationalID= @EmpNationalID, EMP_FIRST_NAME= @EMP_FIRST_NAME, EMP_FATHER_NAME= @EMP_FATHER_NAME, EMP_FAM_NAME = @EMP_FAM_NAME, EMP_FOURTH_NAME = @EMP_FOURTH_NAME, 
                nationaltyId = @nationaltyId, dyana_code = @dyana_code, MaritalStatusId = @MaritalStatusId, SubjectId = @SubjectId, DepartmentId = @DepartmentId, EmpJobId = @EmpJobId, BIRTH_DATE = @BIRTH_DATE, GENDER_ID = @GENDER_ID, BIRTH_GOV = @BIRTH_GOV, 
                JOB_STATUS_ID = @JOB_STATUS_ID, BIRTH_PLACE = @BIRTH_PLACE, Emp_Address = @Emp_Address, PHONE_NO = @PHONE_NO, 
                MOBILE_NO = @MOBILE_NO, JobDescriptionId = @JobDescriptionId, Work_Start_Date = @Work_Start_Date, End_Work_Date = @End_Work_Date, qualId = @qualId, SpecializationId = @SpecializationId, QualifiedPlaceId = @QualifiedPlaceId, Moaahel_Date = @Moaahel_Date, tameen_no = @tameen_no, tameen_date1 = @tameen_date1, 
                betaka_tameen = @betaka_tameen, noview = @noview, orderreport = @orderreport, EMPPIC = @EMPPIC Where EmpID = @EmpID";

                cmd.Parameters.Add(new SqlParameter("@EmpID", SqlDbType.Int) { Value = LUEEmp.EditValue });
                
                //EMPPIC = (byte[])((DataTable)LUEEmp.Properties.DataSource).Rows[LUEEmp.ItemIndex]["EMPPIC"];
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

