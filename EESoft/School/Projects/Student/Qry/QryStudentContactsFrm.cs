using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;

namespace Student
{
    public partial class QryStudentContactsFrm : DevExpress.XtraEditors.XtraForm
    {
        public QryStudentContactsFrm()
        {
            InitializeComponent();
        }
        private void ActivePriv()
        {
            bool Selecting = false, Inserting = false, Updateing = false, Deleting = false;
            FXFW.SqlDB.GetFormPriv("Stu" + Name.Replace("Frm", ""), ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
            if (Inserting || Updateing || Selecting || Deleting)
                gridControlQry.Visible = true;
            else
                gridControlQry.Visible = false;
        }
        private void QryStudentContactsFrm_Load(object sender, EventArgs e)
        {
            ActivePriv();
            gridControlQry.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT        stu_code,
            (Select alsofof_name From CDAlsofof Where alsofof_code = stu.student_t.alsofof_code) AS alsofof_name,
            (Select fasl_name From CDEFasl Where fasl_code = stu.student_t.fasl_code) AS fasl_name,
            (Select FIRST_NAME + ' ' + FATHER_NAME + ' ' + GF_NAME + ' ' + FAMILY_NAME From stu.TBLstudent  Where  stu_code = stu.student_t.stu_code) AS Stu_Name,
            (Select mantaka_name From CDMantaka Where mantaka_code = (Select mantaka From stu.TBLstudent Where stu_code = stu.student_t.stu_code)) AS mantaka_name,
            (Select addres From stu.TBLstudent Where stu_code = stu.student_t.stu_code) AS addres,
            (Select waleaalkamr_phone From stu.TBLstudent Where stu_code = stu.student_t.stu_code) AS waleaalkamr_phone,
            (Select waleaalkamr_mobile From stu.TBLstudent Where stu_code = stu.student_t.stu_code) AS waleaalkamr_mobile,
            (Select mother_mobile From stu.TBLstudent Where stu_code = stu.student_t.stu_code) AS mother_mobile
            FROM            stu.student_t
            WHERE        asase_code = " + FXFW.SqlDB.asase_code);
        }
    }
}