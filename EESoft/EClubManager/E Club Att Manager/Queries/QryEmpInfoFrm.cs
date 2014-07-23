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

namespace E_Club_Att_Manager
{
    public partial class QryEmpInfoFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        DataTable EmpInfo = new DataTable("FalseX2010-11");
        #endregion
        #region -   Functions   -
        public QryEmpInfoFrm()
        {
            InitializeComponent();
        }
        private void GetEmpInfo()
        {
            EmpInfo = new DataTable("FalseX2010-08");
            if (TxtNo.Text.Trim().Length == 0)
                return;
            EmpInfo = Program.MC.LoadDataTableMalafat(@"SELECT EmpID, EmpNationalID,
                                                        (SELECT job FROM CD_job WHERE (job_id = Emp_Master.job_id)) AS job,
                                                        (SELECT gender_name FROM CD_gender Where gender_ID = Emp_Master.GENDER_ID) AS gender_name,
                                                        (SELECT JOB_STATUS_NAME FROM CDR_JOB_STATUS Where JOB_STATUS_ID =  Emp_Master.JOB_STATUS_ID) AS JOB_STATUS_NAME,
                                                        (SELECT GOV_NAME FROM CDR_GOV Where GOV_ID = Emp_Master.BIRTH_GOV) AS GOV_NAME,
                                                        (SELECT JOB_STATUS_NAME FROM CDR_JOB_STATUS Where JOB_STATUS_ID = Emp_Master.Job_Dis_ID) AS JOB_STATUS_NAME,
                                                        (SELECT University_Name FROM CD_University Where University_ID = Emp_Master.University_ID) AS University_Name,
                                                        (SELECT Religion FROM CD_Religion Where Religion_id = Emp_Master.Religion_id) AS Religion,
                                                        (SELECT Social FROM CD_Social Where Social_id = Emp_Master.Social_id) AS Social,
                                                        (SELECT tagned FROM CD_tagneed Where tagned_id = Emp_Master.tagned_id) AS tagned,
                                                        (SELECT Moaahel_Name FROM CD_Moaahel Where Moaahel_ID = Emp_Master.Moaahel_ID) AS Moaahel_Name,
                                                        (SELECT Nationality FROM CD_Nationality Where Nationality_id = Emp_Master.Nationality_id) AS Nationality,
                                                        (SELECT SPECIFICATION_NAME FROM CDR_SPECIFICATION Where SPECIFICATION_ID = Emp_Master.SPECIFICATION_ID) AS SPECIFICATION_NAME,
                                                        BIRTH_DATE, BIRTH_PLACE, Emp_Address, PHONE_NO, MOBILE_NO, AddingDate, tameen_no, tameen_date1, tameen_date2, Work_Start_Date, 
                                                        Ac_Start_Date, Moaahel_Date, Emp_Full_Name, EmpPic FROM Emp_Master WHERE (EmpID = " + TxtNo.Text.Trim() + ")");
            if (EmpInfo.Rows.Count != 0)
            {
                TxtEmp_Full_Name.Text = EmpInfo.Rows[0]["Emp_Full_Name"].ToString();
                TxtEmpNationalID.Text = EmpInfo.Rows[0]["EmpNationalID"].ToString();
                TxtEmpNationalID.Text = EmpInfo.Rows[0]["Emp_Full_Name"].ToString();
                TxtJob.Text = EmpInfo.Rows[0]["Job"].ToString();
                TxtGOV_NAME.Text = EmpInfo.Rows[0]["GOV_NAME"].ToString();
                TxtJOB_STATUS_NAME.Text = EmpInfo.Rows[0]["JOB_STATUS_NAME"].ToString();
                TxtReligion.Text = EmpInfo.Rows[0]["Religion"].ToString();
                TxtSocial.Text = EmpInfo.Rows[0]["Social"].ToString();
                Txttagned.Text = EmpInfo.Rows[0]["tagned"].ToString();
                TxtNationality.Text = EmpInfo.Rows[0]["Nationality"].ToString();
                TxtBIRTH_DATE.Text = EmpInfo.Rows[0]["BIRTH_DATE"].ToString();
                TxtBIRTH_PLACE.Text = EmpInfo.Rows[0]["BIRTH_PLACE"].ToString();
                TxtEmp_Address.Text = EmpInfo.Rows[0]["Emp_Address"].ToString();
                TxtPHONE_NO.Text = EmpInfo.Rows[0]["PHONE_NO"].ToString();
                TxtMOBILE_NO.Text = EmpInfo.Rows[0]["MOBILE_NO"].ToString();
                Txttameen_no.Text = EmpInfo.Rows[0]["tameen_no"].ToString();
                Txttameen_date1.Text = EmpInfo.Rows[0]["tameen_date1"].ToString();
                Txttameen_date2.Text = EmpInfo.Rows[0]["tameen_date2"].ToString();
                TxtWork_Start_Date.Text = EmpInfo.Rows[0]["Work_Start_Date"].ToString();
                TxtAc_Start_Date.Text = EmpInfo.Rows[0]["Ac_Start_Date"].ToString();
                TxtMoaahel_Name.Text = EmpInfo.Rows[0]["Moaahel_Name"].ToString();
                TxtSPECIFICATION_NAME.Text = EmpInfo.Rows[0]["SPECIFICATION_NAME"].ToString();
                TxtUniversity_Name.Text = EmpInfo.Rows[0]["University_Name"].ToString();
                TxtMoaahel_Date.Text = EmpInfo.Rows[0]["Moaahel_Date"].ToString();
                if (File.Exists(EmpInfo.Rows[0]["EmpPic"].ToString()))
                    Pic.Image = Image.FromFile(EmpInfo.Rows[0]["EmpPic"].ToString());
                else
                    Pic.Image = null;
            }
            else
            {
                ClearForm();
            }
            Application.DoEvents();
            System.Threading.Thread.Sleep(1000);
            TxtNo.Text = string.Empty;
            TxtNo.Focus();
        }
        private void ClearForm()
        {
            TxtEmp_Full_Name.Text = string.Empty;
            TxtEmpNationalID.Text = string.Empty;
            TxtEmpNationalID.Text = string.Empty;
            TxtJob.Text = string.Empty;
            TxtGOV_NAME.Text = string.Empty;
            TxtJOB_STATUS_NAME.Text = string.Empty;
            TxtReligion.Text = string.Empty;
            TxtSocial.Text = string.Empty;
            Txttagned.Text = string.Empty;
            TxtNationality.Text = string.Empty;
            TxtBIRTH_DATE.Text = string.Empty;
            TxtBIRTH_PLACE.Text = string.Empty;
            TxtEmp_Address.Text = string.Empty;
            TxtPHONE_NO.Text = string.Empty;
            TxtMOBILE_NO.Text = string.Empty;
            Txttameen_no.Text = string.Empty;
            Txttameen_date1.Text = string.Empty;
            Txttameen_date2.Text = string.Empty;
            TxtWork_Start_Date.Text = string.Empty;
            TxtAc_Start_Date.Text = string.Empty;
            TxtMoaahel_Name.Text = string.Empty;
            TxtSPECIFICATION_NAME.Text = string.Empty;
            TxtUniversity_Name.Text = string.Empty;
            TxtMoaahel_Date.Text = string.Empty;
            Pic.Image = null;
        }
        #endregion
        #region -   Event Handlers   -
        private void AttUserMainFrm_Load(object sender, EventArgs e)
        {
            TxtNo.Focus();
        }
        private void TxtNo_EditValueChanged(object sender, EventArgs e)
        {
            if (TxtNo.Text.Trim().Length == 0)
                return;
            TxtNo.Visible = false;
            GetEmpInfo();
            TxtNo.Text = string.Empty;
            if (EmpInfo.Rows.Count == 0)//If Emp Not Exit
            {
                TxtState.Text = "تم رفــــــض البطاقة";
                TxtState.ForeColor = Color.Red;
            }
            else
            {
                TxtState.Text = "تم قبـــــــول البطاقة";
                TxtState.ForeColor = Color.Lime;
            }

            TxtNo.Visible = true;
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}