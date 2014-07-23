using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace E_Club_Att_Manager
{
    public partial class QryEmpAttFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        DataTable TblEmpAtt = new DataTable("FalseX2010-11");
        #endregion
        #region -   Functions   -
        public QryEmpAttFrm()
        {
            InitializeComponent();
        }
        private void LoadGridTbl()
        {
            TblEmpAtt = new DataTable("FalseX2010-11");
            TblEmpAtt = Program.MC.LoadDataTable(@"SELECT EmpHarakaID, EmpID, harka_date, c_emp_harka_type, shift_code, harka_time, adafetime,  gasmtime, time_mokarara,
                                                (SELECT shift FROM CDATT_sheft WHERE shift_code = ATT_empharaka.shift_code) AS shift,
                                                (SELECT emp_harka_type FROM CDATT_harka_type WHERE c_emp_harka_type = ATT_empharaka.c_emp_harka_type) AS emp_harka_type,
                                                (SELECT EmpNationalID FROM Emp_Master WHERE EmpID = ATT_empharaka.EmpID) AS EmpNationalID,
                                                (SELECT Emp_Full_Name FROM Emp_Master WHERE EmpID = ATT_empharaka.EmpID) AS Emp_Full_Name,
                                                (SELECT job FROM CD_job WHERE job_id = (Select job_id From Emp_Master Where EmpID = ATT_empharaka.EmpID)) AS job,
                                                (SELECT JOB_STATUS_NAME FROM CDR_JOB_STATUS WHERE JOB_STATUS_ID = (Select JOB_STATUS_ID From Emp_Master Where EmpID = ATT_empharaka.EmpID)) AS JOB_STATUS_NAME,
                                                (SELECT Emp_Address FROM Emp_Master WHERE EmpID = ATT_empharaka.EmpID) AS Emp_Address,
                                                (SELECT PHONE_NO FROM Emp_Master WHERE EmpID = ATT_empharaka.EmpID) AS PHONE_NO,
                                                (SELECT MOBILE_NO FROM Emp_Master WHERE EmpID = ATT_empharaka.EmpID) AS MOBILE_NO,
                                                (SELECT Job_DisName FROM CD_Job_Dis WHERE Job_Dis_ID = (Select Job_Dis_ID From Emp_Master Where EmpID = ATT_empharaka.EmpID)) AS Job_DisName,
                                                (SELECT EmpPic FROM Emp_Master WHERE EmpID = ATT_empharaka.EmpID) AS EmpPic,
                                                (SELECT hedor_time_Start FROM ATT_Company_Emp WHERE EmpID = ATT_empharaka.EmpID And shift_code = ATT_empharaka.shift_code) AS hedor_time_Start,
                                                (SELECT hedor_time_End FROM ATT_Company_Emp WHERE EmpID = ATT_empharaka.EmpID And shift_code = ATT_empharaka.shift_code) AS hedor_time_End,
                                                (SELECT enseraf_time_Start FROM ATT_Company_Emp WHERE EmpID = ATT_empharaka.EmpID And shift_code = ATT_empharaka.shift_code) AS enseraf_time_Start,
                                                (SELECT enseraf_time_End FROM ATT_Company_Emp WHERE EmpID = ATT_empharaka.EmpID And shift_code = ATT_empharaka.shift_code) AS enseraf_time_End
                                                FROM ATT_empharaka", "");
            gridControlEmpAtt.DataSource = TblEmpAtt;
            gridViewEmpAtt.BestFitColumns();
        }
        #endregion
        #region -   Event Handlers   -
        private void QryPartnerStaffFrm_Load(object sender, EventArgs e)
        {
            LoadGridTbl();
        }
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadGridTbl();
        }
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridControlEmpAtt.ShowPrintPreview();
        }
        private void cardViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridControlEmpAtt.MainView = cardViewEmpAtt;
        }
        private void gridViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridControlEmpAtt.MainView = gridViewEmpAtt;
        }
        #endregion
    }
}