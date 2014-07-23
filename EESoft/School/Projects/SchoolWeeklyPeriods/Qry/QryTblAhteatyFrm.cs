using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SchoolWeeklyPeriods
{
    public partial class QryTblAhteatyFrm : DevExpress.XtraEditors.XtraForm
    {
        
        #region -   Variables   -

        #endregion
        #region -   Functions   -
        public QryTblAhteatyFrm()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            DataTable dt = FXFW.SqlDB.LoadDataTable(@"SELECT agaza_st_date,
            (Select ISNULL(EMP_FIRST_NAME, '') + ' ' + ISNULL(EMP_FATHER_NAME, '') + ' ' + ISNULL(EMP_FAM_NAME, '') + ' ' + ISNULL(EMP_FOURTH_NAME, '') From TBL_Emp Where EmpID = TBLAhteaty.EmpabsentID) AS emp_nameAbs,
            (Select ISNULL(EMP_FIRST_NAME, '') + ' ' + ISNULL(EMP_FATHER_NAME, '') + ' ' + ISNULL(EMP_FAM_NAME, '') + ' ' + ISNULL(EMP_FOURTH_NAME, '') From TBL_Emp Where EmpID = TBLAhteaty.EmpahtyatyId) AS emp_nameRes,
            (SELECT [dayname] FROM CDDayname WHERE daycode = TBLAhteaty.daycode) AS [dayname],
            (SELECT hasa_name FROM CDAlhasas WHERE hasa_code = TBLAhteaty.hasa_code) AS hasa_name,
            (SELECT alsofof_name FROM CDAlsofof WHERE alsofof_code = TBLAhteaty.alsofof_code) AS alsofof_name,
            (SELECT fasl_name FROM CDEFasl WHERE fasl_code = TBLAhteaty.fasl_code) AS fasl_name,
            (SELECT [Subject] FROM CD_Subject WHERE SubjectId = TBLAhteaty.SubjectId) AS [Subject]
            FROM TBLAhteaty
            WHERE asase_code = " + FXFW.SqlDB.asase_code);
            gridControlData.DataSource = dt;
        }
        #endregion
        #region -   Event Handlers   -
        private void QryTblAhteatyFrm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        #endregion

    }
}