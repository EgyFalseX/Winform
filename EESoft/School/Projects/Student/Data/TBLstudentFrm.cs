using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace Student
{
    public partial class TBLstudentFrm : DevExpress.XtraEditors.XtraForm
    {
        
        #region -   Variables   -
        enum TabbleName
        {
            All,
            TBLSCHOOL,
            CDAlnoa,
            CDDyana,
            CDnationalty,
            CDGov,
            CDHealth_office,
            CDMantaka,
            CDEqamaType,
            CDQualification, 
            CDJop,
            CDSaltalkaraba,
            CDRelativeCode,
            CDEFasl,
            CDHaletalked,
            CDLogatcode
        }
        #endregion
        #region -   Functions   -
        public TBLstudentFrm()
        {
            InitializeComponent();
        }
        private void LoadDefaultData(TabbleName SelectedTable)
        {
            switch (SelectedTable)
            {
                case TabbleName.All:
                    //TBLSCHOOL
                    LUESPOS.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"Select SPOS, SCHOOL, SCHOOl_e, marhala_code From TBLSCHOOL");
                    LUESPOS.Properties.DisplayMember = "SCHOOL";
                    LUESPOS.Properties.ValueMember = "SPOS";
                    //CDAlnoa
                    LUEcode_alnoa.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT code_alnoa, name_alnoa, name_alnoa_e FROM CDAlnoa");
                    LUEcode_alnoa.Properties.DisplayMember = "name_alnoa";
                    LUEcode_alnoa.Properties.ValueMember = "code_alnoa";
                    //CDDyana
                    LUEdyana_code.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT dyana_code, dyana_name, dyana_name_e FROM CDDyana");
                    LUEdyana_code.Properties.DisplayMember = "dyana_name";
                    LUEdyana_code.Properties.ValueMember = "dyana_code";
                    //CDnationalty
                    LUEnational_code.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT nationaltyId, nationaltyname, nationaltyname_e FROM CDnationalty");
                    LUEnational_code.Properties.DisplayMember = "nationaltyname";
                    LUEnational_code.Properties.ValueMember = "nationaltyId";
                    //CDGov
                    LUEmohaftha_elmelad.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT GOV_CD, GOV, GOVe FROM CDGov");
                    LUEmohaftha_elmelad.Properties.DisplayMember = "GOV";
                    LUEmohaftha_elmelad.Properties.ValueMember = "GOV_CD";
                    //HE_CODE
                    LUEHE_CODE.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT HE_CODE, HE_DESC, HE_DESC_e FROM CDHealth_office");
                    LUEHE_CODE.Properties.DisplayMember = "HE_DESC";
                    LUEHE_CODE.Properties.ValueMember = "HE_CODE";
                    //CDMantaka
                    LUEmantaka.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT mantaka_code, mantaka_name, mantaka_name_e FROM CDMantaka");
                    LUEmantaka.Properties.DisplayMember = "mantaka_name";
                    LUEmantaka.Properties.ValueMember = "mantaka_code";
                    //CDEqamaType
                    LUEEqamaID.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT EqamaID, EqamaName, EqamaNameE FROM CDEqamaType");
                    LUEEqamaID.Properties.DisplayMember = "EqamaName";
                    LUEEqamaID.Properties.ValueMember = "EqamaID";
                    //CDQualification
                    LUEfatherqualId.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT qualId, qualName, qualName_e FROM CDQualification");
                    LUEfatherqualId.Properties.DisplayMember = "qualName";
                    LUEfatherqualId.Properties.ValueMember = "qualId";
                    LUEmotherqualId.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT qualId, qualName, qualName_e FROM CDQualification");
                    LUEmotherqualId.Properties.DisplayMember = "qualName";
                    LUEmotherqualId.Properties.ValueMember = "qualId";
                    //CDJop
                    LUEfatherjob.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT jop_code, jop_name, jop_name_e FROM CDJop");
                    LUEfatherjob.Properties.DisplayMember = "jop_name";
                    LUEfatherjob.Properties.ValueMember = "jop_code";
                    LUEmotherjob.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT jop_code, jop_name, jop_name_e FROM CDJop");
                    LUEmotherjob.Properties.DisplayMember = "jop_name";
                    LUEmotherjob.Properties.ValueMember = "jop_code";
                    LUEwaleaalkamrjob.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT jop_code, jop_name, jop_name_e FROM CDJop");
                    LUEwaleaalkamrjob.Properties.DisplayMember = "jop_name";
                    LUEwaleaalkamrjob.Properties.ValueMember = "jop_code";
                    //CDSaltalkaraba
                    LUEsaltalkarba_code.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT saltalkarba_code, saltalkaraba_name FROM CDSaltalkaraba");
                    LUEsaltalkarba_code.Properties.DisplayMember = "saltalkaraba_name";
                    LUEsaltalkarba_code.Properties.ValueMember = "saltalkarba_code";
                    GLUEselaFamily.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT saltalkarba_code, saltalkaraba_name FROM CDSaltalkaraba");
                    GLUEselaFamily.Properties.DisplayMember = "saltalkaraba_name";
                    GLUEselaFamily.Properties.ValueMember = "saltalkarba_code";
                    //CDRelativeCode
                    repositoryItemGridLookUpEditRelativeCode.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT RelativeCode, RelativeName, RelativeNamee FROM CDRelativeCode");
                    repositoryItemGridLookUpEditRelativeCode.DisplayMember = "RelativeName";
                    repositoryItemGridLookUpEditRelativeCode.ValueMember = "RelativeCode";
                    //CDEFasl
                    LUEfasl_code.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT fasl_code, fasl_name, fasl_name_e FROM CDEFasl");
                    LUEfasl_code.Properties.DisplayMember = "fasl_name";
                    LUEfasl_code.Properties.ValueMember = "fasl_code";
                    //CDHaletalked
                    LUEhaletalked_code.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT haletalked_code, haletalked_name, haletalked_name_e FROM CDHaletalked");
                    LUEhaletalked_code.Properties.DisplayMember = "haletalked_name";
                    LUEhaletalked_code.Properties.ValueMember = "haletalked_code";
                    //CDLogatcode
                    LUEloga_code1.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT loga_code, loga_name, loga_name_e FROM CDLogatcode");
                    LUEloga_code1.Properties.DisplayMember = "loga_name";
                    LUEloga_code1.Properties.ValueMember = "loga_code";
                    LUEloga_code2.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT loga_code, loga_name, loga_name_e FROM CDLogatcode");
                    LUEloga_code2.Properties.DisplayMember = "loga_name";
                    LUEloga_code2.Properties.ValueMember = "loga_code";
                    break;
                case TabbleName.TBLSCHOOL:
                    //TBLSCHOOL
                    LUESPOS.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"Select SPOS, SCHOOL, SCHOOl_e, marhala_code From TBLSCHOOL");
                    LUESPOS.Properties.DisplayMember = "SCHOOL";
                    LUESPOS.Properties.ValueMember = "SPOS";
                    break;
                case TabbleName.CDAlnoa:
                    //CDAlnoa
                    LUEcode_alnoa.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT code_alnoa, name_alnoa, name_alnoa_e FROM CDAlnoa");
                    LUEcode_alnoa.Properties.DisplayMember = "name_alnoa";
                    LUEcode_alnoa.Properties.ValueMember = "code_alnoa";
                    break;
                case TabbleName.CDDyana:
                    //CDDyana
                    LUEdyana_code.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT dyana_code, dyana_name, dyana_name_e FROM CDDyana");
                    LUEdyana_code.Properties.DisplayMember = "dyana_name";
                    LUEdyana_code.Properties.ValueMember = "dyana_code";
                    break;
                case TabbleName.CDnationalty:
                    //CDnationalty
                    LUEnational_code.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT nationaltyId, nationaltyname, nationaltyname_e FROM CDnationalty");
                    LUEnational_code.Properties.DisplayMember = "nationaltyname";
                    LUEnational_code.Properties.ValueMember = "nationaltyId";
                    break;
                case TabbleName.CDGov:
                    //CDGov
                    LUEmohaftha_elmelad.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT GOV_CD, GOV, GOVe FROM CDGov");
                    LUEmohaftha_elmelad.Properties.DisplayMember = "GOV";
                    LUEmohaftha_elmelad.Properties.ValueMember = "GOV_CD";
                    break;
                case TabbleName.CDHealth_office:
                    //HE_CODE
                    LUEHE_CODE.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT HE_CODE, HE_DESC, HE_DESC_e FROM CDHealth_office");
                    LUEHE_CODE.Properties.DisplayMember = "HE_DESC";
                    LUEHE_CODE.Properties.ValueMember = "HE_CODE";
                    break;
                case TabbleName.CDMantaka:
                    //CDMantaka
                    LUEmantaka.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT mantaka_code, mantaka_name, mantaka_name_e FROM CDMantaka");
                    LUEmantaka.Properties.DisplayMember = "mantaka_name";
                    LUEmantaka.Properties.ValueMember = "mantaka_code";
                    break;
                case TabbleName.CDEqamaType:
                    //CDEqamaType
                    LUEEqamaID.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT EqamaID, EqamaName, EqamaNameE FROM CDEqamaType");
                    LUEEqamaID.Properties.DisplayMember = "EqamaName";
                    LUEEqamaID.Properties.ValueMember = "EqamaID";
                    break;
                case TabbleName.CDQualification:
                    //CDQualification
                    LUEfatherqualId.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT qualId, qualName, qualName_e FROM CDQualification");
                    LUEfatherqualId.Properties.DisplayMember = "qualName";
                    LUEfatherqualId.Properties.ValueMember = "qualId";
                    LUEmotherqualId.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT qualId, qualName, qualName_e FROM CDQualification");
                    LUEmotherqualId.Properties.DisplayMember = "qualName";
                    LUEmotherqualId.Properties.ValueMember = "qualId";
                    break;
                case TabbleName.CDJop:
                    //CDJop
                    LUEfatherjob.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT jop_code, jop_name, jop_name_e FROM CDJop");
                    LUEfatherjob.Properties.DisplayMember = "jop_name";
                    LUEfatherjob.Properties.ValueMember = "jop_code";
                    LUEmotherjob.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT jop_code, jop_name, jop_name_e FROM CDJop");
                    LUEmotherjob.Properties.DisplayMember = "jop_name";
                    LUEmotherjob.Properties.ValueMember = "jop_code";
                    LUEwaleaalkamrjob.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT jop_code, jop_name, jop_name_e FROM CDJop");
                    LUEwaleaalkamrjob.Properties.DisplayMember = "jop_name";
                    LUEwaleaalkamrjob.Properties.ValueMember = "jop_code";
                    break;
                case TabbleName.CDSaltalkaraba:
                    //CDSaltalkaraba
                    LUEsaltalkarba_code.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT saltalkarba_code, saltalkaraba_name FROM CDSaltalkaraba");
                    LUEsaltalkarba_code.Properties.DisplayMember = "saltalkaraba_name";
                    LUEsaltalkarba_code.Properties.ValueMember = "saltalkarba_code";
                    GLUEselaFamily.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT saltalkarba_code, saltalkaraba_name FROM CDSaltalkaraba");
                    GLUEselaFamily.Properties.DisplayMember = "saltalkaraba_name";
                    GLUEselaFamily.Properties.ValueMember = "saltalkarba_code";
                    break;
                case TabbleName.CDRelativeCode:
                    //CDSaltalkaraba
                    repositoryItemGridLookUpEditRelativeCode.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT RelativeCode, RelativeName, RelativeNamee FROM CDRelativeCode");
                    repositoryItemGridLookUpEditRelativeCode.DisplayMember = "RelativeName";
                    repositoryItemGridLookUpEditRelativeCode.ValueMember = "RelativeCode";    
                    break;
                case TabbleName.CDEFasl:
                     //CDEFasl
                    LUEfasl_code.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT fasl_code, fasl_name, fasl_name_e FROM CDEFasl");
                    LUEfasl_code.Properties.DisplayMember = "fasl_name";
                    LUEfasl_code.Properties.ValueMember = "fasl_code";
                    break;
                case TabbleName.CDHaletalked:
                    //CDHaletalked
                    LUEhaletalked_code.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT haletalked_code, haletalked_name, haletalked_name_e FROM CDHaletalked");
                    LUEhaletalked_code.Properties.DisplayMember = "haletalked_name";
                    LUEhaletalked_code.Properties.ValueMember = "haletalked_code";
                    break;
                case TabbleName.CDLogatcode:
                    //CDLogatcode
                    LUEloga_code1.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT loga_code, loga_name, loga_name_e FROM CDLogatcode");
                    LUEloga_code1.Properties.DisplayMember = "loga_name";
                    LUEloga_code1.Properties.ValueMember = "loga_code";
                    LUEloga_code2.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT loga_code, loga_name, loga_name_e FROM CDLogatcode");
                    LUEloga_code2.Properties.DisplayMember = "loga_name";
                    LUEloga_code2.Properties.ValueMember = "loga_code";
                    break;
                default:
                    break;
            }
            

        }
        private void loadData()
        {
            DataTable stu = FXFW.SqlDB.LoadDataTable(@"SELECT stu_code, FIRST_NAME + ' ' + FATHER_NAME + ' ' + GF_NAME + ' ' + FAMILY_NAME AS Stu_Name, 
            FIRST_NAME, FATHER_NAME, GF_NAME, FAMILY_NAME, FIRST_NAME_e, FATHER_NAME_e, GF_NAME_e, FAMILY_NAME_e, parthplace_code, mohaftha_elmelad, Parthday,
            stu_qawme, date_segl_alwaga, kyd_no, HE_CODE, mantaka, [Addres], code_alnoa, dyana_code, national_code, SPOS,
            EqamaID, date_end, Fathername, fatherqualId, fatherjob, father_elnashat, fatheraddres, mather_name, motherqualId, motherjob, no_ekhwa, stu_tarteep, 
            walealkmrname, saltalkarba_code, waleaalkamrjob, waleaalkamraddres, waleaalkamr_phone, waleaalkamr_tel_work, waleaalkamr_mobile, mother_mobile, 
            elram_elbarede, stu_tel, user_name, pass, email, familyFriend, familyFriendTel, selaFamily, first_alaltahak_date, pic FROM stu.TBLstudent");
            //Students
            LUEStudents.Properties.DataSource = stu;
            LUEStudents.Properties.DisplayMember = "Stu_Name";
            LUEStudents.Properties.ValueMember = "stu_code";
            //parthplace_code From TBLstudent as (AutoComplate)
            DataTable dt = FXFW.SqlDB.LoadDataTable(@"Select DISTINCT parthplace_code From stu.TBLstudent");
            foreach (DataRow item in dt.Rows)
                cbparthplace_code.Properties.Items.Add(item["parthplace_code"]);
        }
        private void loadstu_Relative()
        {
            DataTable stu = FXFW.SqlDB.LoadDataTable(@"SELECT stu_code, FIRST_NAME + ' ' + FATHER_NAME + ' ' + GF_NAME + ' ' + FAMILY_NAME AS Stu_Name, 
            FIRST_NAME, FATHER_NAME, GF_NAME, FAMILY_NAME, FIRST_NAME_e, FATHER_NAME_e, GF_NAME_e, FAMILY_NAME_e, parthplace_code, mohaftha_elmelad, Parthday,
            stu_qawme, date_segl_alwaga, kyd_no, HE_CODE, mantaka, [Addres], code_alnoa, dyana_code, national_code, SPOS,
            EqamaID, date_end, Fathername, fatherqualId, fatherjob, father_elnashat, fatheraddres, mather_name, motherqualId, motherjob, no_ekhwa, stu_tarteep, 
            walealkmrname, saltalkarba_code, waleaalkamrjob, waleaalkamraddres, waleaalkamr_phone, waleaalkamr_tel_work, waleaalkamr_mobile, mother_mobile, 
            elram_elbarede, stu_tel, user_name, pass, email, familyFriend, familyFriendTel, selaFamily, first_alaltahak_date FROM stu.TBLstudent
            Where stu_code <> " + LUEStudents.EditValue);
            //stu_Relative
            repositoryItemGridLookUpEditstu_Relative.DataSource = stu;
            repositoryItemGridLookUpEditstu_Relative.DisplayMember = "Stu_Name";
            repositoryItemGridLookUpEditstu_Relative.ValueMember = "stu_code";
        }
        private void prepareData(ref string FIRST_NAME, ref string FATHER_NAME, ref string GF_NAME, ref string FAMILY_NAME, ref string FIRST_NAME_e,ref string FATHER_NAME_e, 
        ref string GF_NAME_e, ref string FAMILY_NAME_e, ref string parthplace_code, ref string mohaftha_elmelad, ref string Parthday, ref string stu_qawme, ref string date_segl_alwaga, 
        ref string kyd_no, ref string HE_CODE, ref string mantaka, ref string Addres, ref string code_alnoa, ref string dyana_code, ref string national_code, ref string SPOS, 
        ref string EqamaID, ref string date_end, ref string Fathername, ref string fatherqualId, ref string fatherjob, ref string father_elnashat, ref string fatheraddres, 
        ref string mather_name, ref string motherqualId, ref string motherjob, ref string no_ekhwa, ref string stu_tarteep, ref string walealkmrname, ref string saltalkarba_code, ref string waleaalkamrjob, ref string waleaalkamraddres,
        ref string waleaalkamr_phone, ref string waleaalkamr_tel_work, ref string waleaalkamr_mobile, ref string mother_mobile, ref string elram_elbarede, ref string stu_tel, ref string user_name,
        ref string pass, ref string email, ref string familyFriend, ref string familyFriendTel, ref string selaFamily, ref string first_alaltahak_date)
        {
            //FIRST_NAME
            if (TxtFIRST_NAME.Text == string.Empty)
                FIRST_NAME = "NULL";
            else
                FIRST_NAME = string.Format("N'{0}'", TxtFIRST_NAME.Text);
            //FATHER_NAME
            if (TxtFATHER_NAME.Text == string.Empty)
                FATHER_NAME = "NULL";
            else
                FATHER_NAME = string.Format("N'{0}'", TxtFATHER_NAME.Text);
            //GF_NAME
            if (TxtGF_NAME.Text == string.Empty)
                GF_NAME = "NULL";
            else
                GF_NAME = string.Format("N'{0}'", TxtGF_NAME.Text);
            //FAMILY_NAME
            if (TxtFAMILY_NAME.Text == string.Empty)
                FAMILY_NAME = "NULL";
            else
                FAMILY_NAME = string.Format("N'{0}'", TxtFAMILY_NAME.Text);
            //FIRST_NAME_e
            if (TxtFIRST_NAME_e.Text == string.Empty)
                FIRST_NAME_e = "NULL";
            else
                FIRST_NAME_e = string.Format("N'{0}'", TxtFIRST_NAME_e.Text);
            //FATHER_NAME_e
            if (TxtFATHER_NAME_e.Text == string.Empty)
                FATHER_NAME_e = "NULL";
            else
                FATHER_NAME_e = string.Format("N'{0}'", TxtFATHER_NAME_e.Text);
           //GF_NAME_e
            if (TxtGF_NAME_e.Text == string.Empty)
                GF_NAME_e = "NULL";
            else
                GF_NAME_e = string.Format("N'{0}'", TxtGF_NAME_e.Text);
            //FAMILY_NAME_e
            if (TxtFAMILY_NAME_e.Text == string.Empty)
                FAMILY_NAME_e = "NULL";
            else
                FAMILY_NAME_e = string.Format("N'{0}'", TxtFAMILY_NAME_e.Text);
            //parthplace_code
            if (cbparthplace_code.Text == string.Empty)
                parthplace_code = "NULL";
            else
                parthplace_code = string.Format("N'{0}'", cbparthplace_code.Text);
            //mohaftha_elmelad
            
            if (LUEmohaftha_elmelad.ItemIndex < 0)
                mohaftha_elmelad = "NULL";
            else
                mohaftha_elmelad = LUEmohaftha_elmelad.EditValue.ToString();
           //Parthday
            if (DEParthday.Text == string.Empty)
                Parthday = "NULL";
            else
                Parthday = string.Format("Convert(datetime, '{0}', 103)", DEParthday.Text);
            //stu_qawme
            if (Txtstu_qawme.Text == string.Empty)
                stu_qawme = "NULL";
            else
                stu_qawme = string.Format("N'{0}'", Txtstu_qawme.Text);
            //date_segl_alwaga
            if (DEdate_segl_alwaga.Text == string.Empty)
                date_segl_alwaga = "NULL";
            else
                date_segl_alwaga = string.Format("Convert(datetime, '{0}', 103)", DEdate_segl_alwaga.Text);
            //kyd_no
            if (Txtkyd_no.Text == string.Empty)
                kyd_no = "NULL";
            else
                kyd_no = Txtkyd_no.Text;
            //HE_CODE
            if (LUEHE_CODE.ItemIndex < 0)
                HE_CODE = "NULL";
            else
                HE_CODE = LUEHE_CODE.EditValue.ToString();
            //mantaka
            if (LUEmantaka.ItemIndex < 0)
                mantaka = "NULL";
            else
                mantaka = LUEmantaka.EditValue.ToString();
            //Addres
            if (TxtAddres.Text == string.Empty)
                Addres = "NULL";
            else
                Addres = string.Format("N'{0}'", TxtAddres.Text);
            //code_alnoa
            if (LUEcode_alnoa.ItemIndex < 0)
                code_alnoa = "NULL";
            else
                code_alnoa = LUEcode_alnoa.EditValue.ToString();
            //dyana_code
            if (LUEdyana_code.ItemIndex < 0)
                dyana_code = "NULL";
            else
                dyana_code = LUEdyana_code.EditValue.ToString();
            //national_code
            if (LUEnational_code.ItemIndex < 0)
                national_code = "NULL";
            else
                national_code = LUEnational_code.EditValue.ToString();
            //SPOS
            if (LUESPOS.ItemIndex < 0)
                SPOS = "NULL";
            else
                SPOS = LUESPOS.EditValue.ToString();
            //EqamaID
            if (LUEEqamaID.ItemIndex < 0)
                EqamaID = "NULL";
            else
                EqamaID = LUEEqamaID.EditValue.ToString();
            //date_end
            if (DEdate_end.Text == string.Empty)
                date_end = "NULL";
            else
                date_end = string.Format("Convert(datetime, '{0}', 103)", DEdate_end.Text);
            //Fathername
            if (TxtFathername.Text == string.Empty)
                Fathername = "NULL";
            else
                Fathername = string.Format("N'{0}'", TxtFathername.Text);
            //fatherqualId
            if (LUEfatherqualId.ItemIndex < 0)
                fatherqualId = "NULL";
            else
                fatherqualId = LUEfatherqualId.EditValue.ToString();
            //fatherjob
            if (LUEfatherjob.ItemIndex < 0)
                fatherjob = "NULL";
            else
                fatherjob = LUEfatherjob.EditValue.ToString();
            //father_elnashat
            if (Txtfather_elnashat.Text == string.Empty)
                father_elnashat = "NULL";
            else
                father_elnashat = string.Format("N'{0}'", Txtfather_elnashat.Text);
            //fatheraddres
            if (Txtfatheraddres.Text == string.Empty)
                fatheraddres = "NULL";
            else
                fatheraddres = string.Format("N'{0}'", Txtfatheraddres.Text);
            //mather_name
            if (Txtmather_name.Text == string.Empty)
                mather_name = "NULL";
            else
                mather_name = string.Format("N'{0}'", Txtmather_name.Text);
            //motherqualId
            if (LUEmotherqualId.ItemIndex < 0)
                motherqualId = "NULL";
            else
                motherqualId = LUEmotherqualId.EditValue.ToString();
            //motherjob
            if (LUEmotherjob.ItemIndex < 0)
                motherjob = "NULL";
            else
                motherjob = LUEmotherjob.EditValue.ToString();
            //no_ekhwa
            if (Txtno_ekhwa.Text == string.Empty)
                no_ekhwa = "NULL";
            else
                no_ekhwa = string.Format("N'{0}'", Txtno_ekhwa.Text);
            //stu_tarteep
            if (Txtstu_tarteep.Text == string.Empty)
                stu_tarteep = "NULL";
            else
                stu_tarteep = string.Format("N'{0}'", Txtstu_tarteep.Text);
            //walealkmrname
             if (Txtwalealkmrname.Text == string.Empty)
                walealkmrname = "NULL";
            else
                walealkmrname = string.Format("N'{0}'", Txtwalealkmrname.Text);
            //saltalkarba_code
             if (LUEsaltalkarba_code.ItemIndex < 0)
                saltalkarba_code = "NULL";
            else
                saltalkarba_code = LUEsaltalkarba_code.EditValue.ToString();
            //waleaalkamrjob
             if (LUEwaleaalkamrjob.ItemIndex < 0)
                waleaalkamrjob = "NULL";
            else
                waleaalkamrjob = LUEwaleaalkamrjob.EditValue.ToString();
            //waleaalkamraddres
            if (Txtwaleaalkamraddres.Text == string.Empty)
                waleaalkamraddres = "NULL";
            else
                waleaalkamraddres = string.Format("N'{0}'", Txtwaleaalkamraddres.Text);
            //waleaalkamr_phone
            if (Txtwaleaalkamr_phone.Text == string.Empty)
                waleaalkamr_phone = "NULL";
            else
                waleaalkamr_phone = string.Format("N'{0}'", Txtwaleaalkamr_phone.Text);
            //waleaalkamr_tel_work
            if (Txtwaleaalkamr_tel_work.Text == string.Empty)
                waleaalkamr_tel_work = "NULL";
            else
                waleaalkamr_tel_work = string.Format("N'{0}'", Txtwaleaalkamr_tel_work.Text);
            //Txtwaleaalkamr_mobile
            if (Txtwaleaalkamr_mobile.Text == string.Empty)
                waleaalkamr_mobile = "NULL";
            else
                waleaalkamr_mobile = string.Format("N'{0}'", Txtwaleaalkamr_mobile.Text);
            //Txtmother_mobile
            if (Txtmother_mobile.Text == string.Empty)
                mother_mobile = "NULL";
            else
                mother_mobile = string.Format("N'{0}'", Txtmother_mobile.Text);
            //Txtelram_elbarede
            if (Txtelram_elbarede.Text == string.Empty)
                elram_elbarede = "NULL";
            else
                elram_elbarede = string.Format("N'{0}'", Txtelram_elbarede.Text);
            //Txtstu_tel
            if (Txtstu_tel.Text == string.Empty)
                stu_tel = "NULL";
            else
                stu_tel = string.Format("N'{0}'", Txtstu_tel.Text);
            //Txtuser_name
            if (Txtuser_name.Text == string.Empty)
                user_name = "NULL";
            else
                user_name = string.Format("N'{0}'", Txtuser_name.Text);
            //Txtpass
            if (Txtpass.Text == string.Empty)
                pass = "NULL";
            else
                pass = string.Format("N'{0}'", Txtpass.Text);
            //Txtemail
            if (Txtemail.Text == string.Empty)
                email = "NULL";
            else
                email = string.Format("N'{0}'", Txtemail.Text);
            //TxtfamilyFriend
            if (TxtfamilyFriend.Text == string.Empty)
                familyFriend = "NULL";
            else
                familyFriend = string.Format("N'{0}'", TxtfamilyFriend.Text);
            //TxtfamilyFriendTel
            if (TxtfamilyFriendTel.Text == string.Empty)
                familyFriendTel = "NULL";
            else
                familyFriendTel = string.Format("N'{0}'", TxtfamilyFriendTel.Text);
            //motherjob
            if (GLUEselaFamily.EditValue != null)
            {
                if (GLUEselaFamily.EditValue.ToString() != string.Empty)
                    selaFamily = GLUEselaFamily.EditValue.ToString();
                else
                 selaFamily = "NULL";       
            }
            else
                selaFamily = "NULL";
            //Parthday
            if (DEfirst_alaltahak_date.Text == string.Empty)
                first_alaltahak_date = "NULL";
            else
                first_alaltahak_date = string.Format("Convert(datetime, '{0}', 103)", DEfirst_alaltahak_date.Text);
        }
        private void LoadRelatives()
        {
            gridControlCDRelativeCode.DataSource = FXFW.SqlDB.LoadDataTable(@"Select stu_code, stu_Relative, RelativeCode, stu_code AS stu_code_SRC, stu_Relative AS stu_Relative_SRC 
            From stu.Relatives Where stu_code = " + LUEStudents.EditValue);
        }
        private void rem_sud()
        {
            gridControlrem_sud.DataSource = FXFW.SqlDB.LoadDataTable(@"Select stu_code, [DATE], rem, stu_code AS stu_code_SRC, [DATE] AS DATE_SRC, rem AS rem_SRC
            From stu.rem_sud Where stu_code = " + LUEStudents.EditValue);
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
            FXFW.SqlDB.GetFormPriv("Stu" + Name.Replace("Frm", ""), ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
            xtraTabControlMain.Visible = Selecting;
            btnNew.Visible = Inserting;
            btnUpdate.Visible = Updateing;
            btnDelete.Visible = Deleting;
            if (Inserting || Updateing)
            {
                repositoryItemButtonEditCDRelativeCodeSave.Buttons[0].Enabled = true;
                repositoryItemButtonEditrem_sudSave.Buttons[0].Enabled = true;
            }
            else
            {
                repositoryItemButtonEditCDRelativeCodeSave.Buttons[0].Enabled = false;
                repositoryItemButtonEditrem_sudSave.Buttons[0].Enabled = false;
            }
            if (Deleting)
            {
                repositoryItemButtonEditCDRelativeCodeDel.Buttons[0].Enabled = true;
                repositoryItemButtonEditrem_sudDel.Buttons[0].Enabled = true;
            }
            else
            {
                repositoryItemButtonEditCDRelativeCodeDel.Buttons[0].Enabled = false;
                repositoryItemButtonEditrem_sudDel.Buttons[0].Enabled = false;
            }
        }
        #endregion
        #region - Event Handlers -
        private void TBLstudentFrm_Load(object sender, EventArgs e)
        {
            ActivePriv();
            LoadDefaultData(TabbleName.All);
            loadData();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            TxtFIRST_NAME.Text = string.Empty;
            TxtFATHER_NAME.Text = string.Empty;
            TxtGF_NAME.Text = string.Empty;
            TxtFAMILY_NAME.Text = string.Empty;
            TxtFIRST_NAME_e.Text = string.Empty;
            TxtFATHER_NAME_e.Text = string.Empty;
            TxtGF_NAME_e.Text = string.Empty;
            TxtFAMILY_NAME_e.Text = string.Empty;
            cbparthplace_code.Text = string.Empty;
            LUEmohaftha_elmelad.EditValue = null;
            DEParthday.EditValue = null;
            Txtstu_qawme.Text = string.Empty;
            DEdate_segl_alwaga.EditValue = null;
            Txtkyd_no.Text = string.Empty;
            LUEHE_CODE.EditValue = null;
            LUEmantaka.EditValue = null;
            TxtAddres.Text = string.Empty;
            LUEcode_alnoa.EditValue = null;
            LUEdyana_code.ItemIndex = 0;
            LUEnational_code.ItemIndex = 0;
            Txtstu_code.Text = FXFW.SqlDB.GetNewID("stu.TBLstudent", "stu_code");// new student id
            LUESPOS.EditValue = null;
            LUEEqamaID.EditValue = null;
            DEdate_end.EditValue = null;
            LUEfatherqualId.EditValue = null;
            LUEfatherjob.EditValue = null;
            Txtfather_elnashat.Text = string.Empty;
            Txtfatheraddres.Text = string.Empty;
            Txtmather_name.Text = string.Empty;
            LUEmotherqualId.EditValue = null;
            LUEmotherjob.EditValue = null;
            Txtno_ekhwa.Text = string.Empty;
            Txtstu_tarteep.Text = string.Empty;
            Txtwalealkmrname.Text = string.Empty;
            LUEsaltalkarba_code.EditValue = null;
            LUEwaleaalkamrjob.EditValue = null;
            Txtwaleaalkamraddres.Text = string.Empty;

            Txtwaleaalkamr_phone.Text = string.Empty;
            Txtwaleaalkamr_tel_work.Text = string.Empty;
            Txtwaleaalkamr_mobile.Text = string.Empty;
            Txtmother_mobile.Text = string.Empty;
            Txtelram_elbarede.Text = string.Empty;
            Txtstu_tel.Text = string.Empty;
            Txtuser_name.Text = string.Empty;
            Txtpass.Text = string.Empty;
            Txtemail.Text = string.Empty;
            TxtfamilyFriend.Text = string.Empty;
            TxtfamilyFriendTel.Text = string.Empty;
            GLUEselaFamily.EditValue = null;
            DEfirst_alaltahak_date.EditValue = null;

            LUEalsofof_code.EditValue = null; LUEalsofof_code.Enabled = true;
            LUEfasl_code.EditValue = null;
            LUEhaletalked_code.EditValue = null;
            LUEloga_code1.EditValue = null;
            LUEloga_code2.EditValue = null;

            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            xtraTabPageBrothers.PageVisible = false;
            xtraTabPageNote.PageVisible = false;

            PBImage.ImageLocation = string.Empty; PBImage.Image = null;
        }
        private void LUEStudents_EditValueChanged(object sender, EventArgs e)
        {
            if (LUEStudents.EditValue == null)
            {
                btnNew_Click(btnNew, new EventArgs());
                btnUpdate.Enabled = false;
                btnSave.Enabled = false;
                return;
            }
            if (LUEStudents.ItemIndex == -1)
            {
                btnNew_Click(btnNew, new EventArgs());
                btnUpdate.Enabled = false;
                btnSave.Enabled = false;
                return;
            }

            DataRow row = ((DataTable)LUEStudents.Properties.DataSource).Rows[LUEStudents.ItemIndex];

            TxtFIRST_NAME.Text = row["FIRST_NAME"].ToString();
            TxtFATHER_NAME.Text = row["FATHER_NAME"].ToString();
            TxtGF_NAME.Text = row["GF_NAME"].ToString();
            TxtFAMILY_NAME.Text = row["FAMILY_NAME"].ToString();
            TxtFIRST_NAME_e.Text = row["FIRST_NAME_e"].ToString();
            TxtFATHER_NAME_e.Text = row["FATHER_NAME_e"].ToString();
            TxtGF_NAME_e.Text = row["GF_NAME_e"].ToString();
            TxtFAMILY_NAME_e.Text = row["FAMILY_NAME_e"].ToString();
            cbparthplace_code.Text = row["parthplace_code"].ToString();
            LUEmohaftha_elmelad.EditValue = row["mohaftha_elmelad"];
            DEParthday.EditValue = row["Parthday"];
            Txtstu_qawme.Text = row["stu_qawme"].ToString();
            DEdate_segl_alwaga.EditValue = row["date_segl_alwaga"];
            Txtkyd_no.Text = row["kyd_no"].ToString();
            LUEHE_CODE.EditValue = row["HE_CODE"];
            LUEmantaka.EditValue = row["mantaka"];
            TxtAddres.Text = row["Addres"].ToString();
            LUEcode_alnoa.EditValue = row["code_alnoa"];
            LUEdyana_code.EditValue = row["dyana_code"];
            LUEnational_code.EditValue = row["national_code"];
            Txtstu_code.Text = row["stu_code"].ToString();
            LUESPOS.EditValue = row["SPOS"];
            LUEEqamaID.EditValue = row["EqamaID"];
            DEdate_end.EditValue = row["date_end"];
            LUEfatherqualId.EditValue = row["fatherqualId"];
            LUEfatherjob.EditValue = row["fatherjob"];
            Txtfather_elnashat.Text = row["father_elnashat"].ToString();
            Txtfatheraddres.Text = row["fatheraddres"].ToString();
            Txtmather_name.Text = row["mather_name"].ToString();
            LUEmotherqualId.EditValue = row["motherqualId"];
            LUEmotherjob.EditValue = row["motherjob"];
            Txtno_ekhwa.Text = row["no_ekhwa"].ToString();
            Txtstu_tarteep.Text = row["stu_tarteep"].ToString();
            Txtwalealkmrname.Text = row["walealkmrname"].ToString();
            LUEsaltalkarba_code.EditValue = row["saltalkarba_code"];
            LUEwaleaalkamrjob.EditValue = row["waleaalkamrjob"];
            Txtwaleaalkamraddres.Text = row["waleaalkamraddres"].ToString();

            Txtwaleaalkamr_phone.Text = row["waleaalkamr_phone"].ToString();
            Txtwaleaalkamr_tel_work.Text = row["waleaalkamr_tel_work"].ToString();
            Txtwaleaalkamr_mobile.Text = row["waleaalkamr_mobile"].ToString();
            Txtmother_mobile.Text = row["mother_mobile"].ToString();
            Txtelram_elbarede.Text = row["elram_elbarede"].ToString();
            Txtstu_tel.Text = row["stu_tel"].ToString();
            Txtuser_name.Text = row["user_name"].ToString();
            Txtpass.Text = row["pass"].ToString();
            Txtemail.Text = row["email"].ToString();
            TxtfamilyFriend.Text = row["familyFriend"].ToString();
            TxtfamilyFriendTel.Text = row["familyFriendTel"].ToString();
            GLUEselaFamily.EditValue = row["selaFamily"];
            DEfirst_alaltahak_date.EditValue = row["first_alaltahak_date"];

            // Load Pic
            if (DBNull.Value != row["pic"])
            {
                System.IO.MemoryStream stream = new System.IO.MemoryStream();
                byte[] MemPic = (byte[])row["pic"];
                System.IO.MemoryStream ms = new System.IO.MemoryStream(MemPic);
                PBImage.Image = Image.FromStream(ms);
            }
            else
                PBImage.Image = null;
            
            //load info from other tablee (student_t)
            using (DataTable dtalsofof_code = FXFW.SqlDB.LoadDataTable(string.Format(@"Select alsofof_code, fasl_code From stu.student_t Where asase_code = {0} And stu_code = {1}", FXFW.SqlDB.asase_code, LUEStudents.EditValue)))
            {
                if (dtalsofof_code.Rows.Count > 0)
                {
                    LUEalsofof_code.EditValue = dtalsofof_code.Rows[0]["alsofof_code"];
                    LUEfasl_code.EditValue = dtalsofof_code.Rows[0]["fasl_code"];
                    //LUEalsofof_code.Enabled = false;
                    //LUEfasl_code.Enabled = false;
                }
                else
                {
                    LUEalsofof_code.EditValue = null;
                    LUEfasl_code.EditValue = null;
                }
            }
            //load info from other tablee (stu_haletalked)
            using (DataTable dthaletalked_code = FXFW.SqlDB.LoadDataTable(string.Format(@"Select haletalked_code From stu.stu_haletalked Where stu_code = {0} And asase_code = {1}", LUEStudents.EditValue, FXFW.SqlDB.asase_code)))
            {
                if (dthaletalked_code.Rows.Count > 0)
                    LUEhaletalked_code.EditValue = dthaletalked_code.Rows[0]["haletalked_code"];
                else
                    LUEhaletalked_code.EditValue = null;
            }
            //load info from other tablee (stu_logatcode)
            using (DataTable dtloga_code = FXFW.SqlDB.LoadDataTable(string.Format(@"Select loga_code1, loga_code2 From stu.stu_logatcode Where asase_code = {0} And stu_code = {1}", FXFW.SqlDB.asase_code, LUEStudents.EditValue)))
            {
                if (dtloga_code.Rows.Count > 0)
                {
                    LUEloga_code1.EditValue = dtloga_code.Rows[0]["loga_code1"];
                    LUEloga_code2.EditValue = dtloga_code.Rows[0]["loga_code2"];
                }
                else
                {
                    LUEloga_code1.EditValue = null;
                    LUEloga_code2.EditValue = null;
                }
            }

            loadstu_Relative();
            LoadRelatives();
            rem_sud();

            btnUpdate.Enabled = true;
            btnSave.Enabled = false;
            xtraTabPageBrothers.PageVisible = true;
            xtraTabPageNote.PageVisible = true;
            //refresh data inside controls
            for (int i = 0; i < xtraTabControlMain.TabPages.Count; i++)
                xtraTabControlMain.SelectedTabPageIndex = i;
            xtraTabControlMain.SelectedTabPageIndex = 0;
           
        }
        private void LUEmohaftha_elmelad_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.GridViewNames.CDGov);
            FrmCode.ShowDialog();
            LoadDefaultData(TabbleName.CDGov);
        }
        private void LUEHE_CODE_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.GridViewNames.CDHealth_office);
            FrmCode.ShowDialog();
            LoadDefaultData(TabbleName.CDHealth_office);
        }
        private void LUEmantaka_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.GridViewNames.CDMantaka);

            FrmCode.ShowDialog();
            LoadDefaultData(TabbleName.CDMantaka);
        }
        private void LUEnational_code_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.GridViewNames.CDnationalty);
            FrmCode.ShowDialog();
            LoadDefaultData(TabbleName.CDnationalty);
        }
        private void LUEEqamaID_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.GridViewNames.CDEqamaType);
            FrmCode.ShowDialog();
            LoadDefaultData(TabbleName.CDEqamaType);
        }
        private void qualId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.GridViewNames.CDQualification);
            FrmCode.ShowDialog();
            LoadDefaultData(TabbleName.CDQualification);
        }
        private void job_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.GridViewNames.CDJop);
            FrmCode.ShowDialog();
            LoadDefaultData(TabbleName.CDJop);
        }
        private void LUEsaltalkarba_code_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.GridViewNames.CDSaltalkaraba);
            FrmCode.ShowDialog();
            LoadDefaultData(TabbleName.CDSaltalkaraba);
        }
        private void LUEalsofof_code_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.GridViewNames.CDAlsofof);
            FrmCode.ShowDialog();
            LUEStudents_EditValueChanged(LUEStudents, new EventArgs());
        }
        private void LUEfasl_code_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.GridViewNames.CDEFasl);
            FrmCode.ShowDialog();
            LoadDefaultData(TabbleName.CDEFasl);
        }
        private void LUEhaletalked_code_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.GridViewNames.CDHaletalked);
            FrmCode.ShowDialog();
            LoadDefaultData(TabbleName.CDHaletalked);
        }
        private void LUEloga_code_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.GridViewNames.CDLogatcode);
            FrmCode.ShowDialog();
            LoadDefaultData(TabbleName.CDLogatcode);
        }
        private void repositoryItemGridLookUpEditRelativeCode_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.GridViewNames.CDRelativeCode);
            FrmCode.ShowDialog();
            LoadDefaultData(TabbleName.CDRelativeCode);
        }
        private void Txtstu_qawme_EditValueChanged(object sender, EventArgs e)
        {
            if (Txtstu_qawme.Text.Length < 14)
                return;
            float Type = FXFW.SqlDB.ConvertStringToInt(Txtstu_qawme.Text.Substring(12, 1));
            if ((Type % 2) == 0)
                LUEcode_alnoa.ItemIndex = 1;//female
            else
                LUEcode_alnoa.ItemIndex = 0;//male
            string birthdate = string.Empty;
            //get birth day
            birthdate = Txtstu_qawme.Text.Substring(5, 2) + "/";
            birthdate += Txtstu_qawme.Text.Substring(3, 2) + "/";
            if (Txtstu_qawme.Text.Substring(0, 1) == "2")
                birthdate += "19" + Txtstu_qawme.Text.Substring(1, 2);
            else
                birthdate += "20" + Txtstu_qawme.Text.Substring(1, 2);
            DEParthday.Text = birthdate;
            DEParthday.EditValue = DEParthday.DateTime;
            //get the birth state
            try
            { LUEmohaftha_elmelad.EditValue = Txtstu_qawme.Text.Substring(7, 2); }
            catch {}
            
        }
        private void DEdate_segl_alwaga_EditValueChanged(object sender, EventArgs e)
        {
            //date_segl_alwaga must b big than Parthday
            if (DEdate_segl_alwaga.Text == string.Empty || DEParthday.Text == string.Empty)
                return;
            if (DEdate_segl_alwaga.DateTime < DEParthday.DateTime)
            {
                Program.ShowMsg("يجب ان يكون تاريخ القيد اكبر من تاريخ الميلاد", true, this);
                DEdate_segl_alwaga.EditValue = null;
                DEParthday.EditValue = null;
            }
        }
        private void LUEnational_code_EditValueChanged(object sender, EventArgs e)
        {
            //LUEnational_code is it "1" mean its an egyptain so LUEEqamaID = "1" other mean LUEEqamaID = "2"
            if (LUEnational_code.EditValue.ToString() == "1")
            {
                LUEEqamaID.EditValue = "1";
            }
            else
            {
                LUEEqamaID.EditValue = "2";
            }
        }
        private void LUEEqamaID_EditValueChanged(object sender, EventArgs e)
        {
            //EqamaID must b != 1 to Enable Its Date
            if (LUEEqamaID.EditValue == null)
            {
                DEdate_end.Enabled = false;
                DEdate_end.EditValue = null;
                return;
            }
            if (LUEEqamaID.EditValue.ToString() != "1")
                DEdate_end.Enabled = true;
            else
            {
                DEdate_end.Enabled = false;
                DEdate_end.EditValue = null;
            }
        }
        private void TxtAddres_EditValueChanged(object sender, EventArgs e)
        {
            //Father Address (Must)= Student Address
            Txtfatheraddres.Text = TxtAddres.Text;
            // walie el2amr Address
            Txtwaleaalkamraddres.Text = Txtfatheraddres.Text;
        }
        private void TxtNameAr_EditValueChanged(object sender, EventArgs e)
        {
            //Student
            TxtFullNameAr.Text = string.Format("{0} {1} {2} {3}", TxtFIRST_NAME.Text, TxtFATHER_NAME.Text, TxtGF_NAME.Text, TxtFAMILY_NAME.Text);
            TxtFullNameAr.Text = TxtFullNameAr.Text.Trim();
            //Father
            TxtFathername.Text = string.Format("{0} {1} {2}", TxtFATHER_NAME.Text, TxtGF_NAME.Text, TxtFAMILY_NAME.Text);
            TxtFathername.Text = TxtFathername.Text.Trim();
            // walie el2amr
            Txtwalealkmrname.Text = TxtFathername.Text;
        }
        private void TxtNameEn_EditValueChanged(object sender, EventArgs e)
        {
            TxtFullNameEn.Text = string.Format("{0} {1} {2} {3}", TxtFIRST_NAME_e.Text, TxtFATHER_NAME_e.Text, TxtGF_NAME_e.Text, TxtFAMILY_NAME_e.Text);
            TxtFullNameEn.Text = TxtFullNameEn.Text.Trim();
        }
        private void LUEfatherjob_EditValueChanged(object sender, EventArgs e)
        {
            LUEwaleaalkamrjob.EditValue = LUEfatherjob.EditValue;
        }
        private void LUESPOS_EditValueChanged(object sender, EventArgs e)
        {
            //get all alsofo related to school marhala
            DataTable dt = new DataTable();
            if (LUESPOS.EditValue != null)
                dt = FXFW.SqlDB.LoadDataTable(@"Select alsofof_code, alsofof_name, alsofof_name_e From CDAlsofof Where marhala_code = " + LUESPOS.EditValue);

            LUEalsofof_code.Properties.DataSource = dt;
            LUEalsofof_code.Properties.DisplayMember = "alsofof_name";
            LUEalsofof_code.Properties.ValueMember = "alsofof_code";

        }
        private void BtnLoadImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            if (OFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                PBImage.ImageLocation = OFD.FileName;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (LUEalsofof_code.EditValue == null || LUEfasl_code.EditValue == null || LUEhaletalked_code.EditValue == null || LUEloga_code1.EditValue == null || LUEloga_code2.EditValue == null)
            {
                Program.ShowMsg("يجب مليء الفصل و الصف و حالة القيد واللغات", true, this);
                return;
            }
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            string FIRST_NAME = string.Empty;
            string FATHER_NAME = string.Empty;
            string GF_NAME = string.Empty;
            string FAMILY_NAME = string.Empty;
            string FIRST_NAME_e = string.Empty;
            string FATHER_NAME_e = string.Empty;
            string GF_NAME_e = string.Empty;
            string FAMILY_NAME_e = string.Empty;
            string parthplace_code = string.Empty;
            string mohaftha_elmelad = string.Empty;
            string Parthday = string.Empty;
            string stu_qawme = string.Empty;
            string date_segl_alwaga = string.Empty;
            string kyd_no = string.Empty;
            string HE_CODE = string.Empty;
            string mantaka = string.Empty;
            string Addres = string.Empty;
            string code_alnoa = string.Empty;
            string dyana_code = string.Empty;
            string national_code = string.Empty;
            string SPOS = string.Empty;
            string EqamaID = string.Empty;
            string date_end = string.Empty;

            string Fathername = string.Empty;
            string fatherqualId = string.Empty;
            string fatherjob = string.Empty;
            string father_elnashat = string.Empty;
            string fatheraddres = string.Empty;
            string mather_name = string.Empty;
            string motherqualId = string.Empty;
            string motherjob = string.Empty;
            string no_ekhwa = string.Empty;
            string stu_tarteep = string.Empty;
            string walealkmrname = string.Empty;
            string saltalkarba_code = string.Empty;
            string waleaalkamrjob = string.Empty;
            string waleaalkamraddres = string.Empty;

            string waleaalkamr_phone = string.Empty;
            string waleaalkamr_tel_work = string.Empty;
            string waleaalkamr_mobile = string.Empty;
            string mother_mobile = string.Empty;
            string elram_elbarede = string.Empty;
            string stu_tel = string.Empty;
            string user_name = string.Empty;
            string pass = string.Empty;
            string email = string.Empty;
            string familyFriend = string.Empty;
            string familyFriendTel = string.Empty;
            string selaFamily = string.Empty;
            string first_alaltahak_date = string.Empty;
            
            byte[] MemPic = null;
            
            prepareData(ref FIRST_NAME,ref FATHER_NAME,ref GF_NAME,ref FAMILY_NAME,ref FIRST_NAME_e,ref FATHER_NAME_e,ref GF_NAME_e,ref FAMILY_NAME_e,ref parthplace_code,
            ref mohaftha_elmelad,ref Parthday,ref stu_qawme,ref date_segl_alwaga,ref kyd_no,ref HE_CODE,ref mantaka,ref Addres,ref code_alnoa,ref dyana_code,ref national_code,
            ref SPOS,ref EqamaID,ref date_end,ref Fathername,ref fatherqualId,ref fatherjob,ref father_elnashat,ref fatheraddres,ref mather_name,ref motherqualId,ref motherjob,
            ref no_ekhwa,ref stu_tarteep,ref walealkmrname,ref saltalkarba_code,ref waleaalkamrjob, ref waleaalkamraddres, ref waleaalkamr_phone, ref waleaalkamr_tel_work,
            ref waleaalkamr_mobile, ref mother_mobile, ref elram_elbarede, ref stu_tel, ref user_name, ref pass, ref email, ref familyFriend, ref familyFriendTel, ref selaFamily, ref first_alaltahak_date);

            string stu_code = FXFW.SqlDB.GetNewID("stu.TBLstudent", "stu_code");
            try
            {
                con.Open();
                cmd.CommandText = string.Format(@"Insert Into stu.TBLstudent (stu_code, FIRST_NAME, FATHER_NAME, GF_NAME, FAMILY_NAME, FIRST_NAME_e, FATHER_NAME_e, GF_NAME_e, FAMILY_NAME_e, 
                parthplace_code, mohaftha_elmelad, Parthday, stu_qawme, date_segl_alwaga, kyd_no, HE_CODE, mantaka, [Addres], code_alnoa, dyana_code, national_code, SPOS, EqamaID, date_end, 
                Fathername, fatherqualId, fatherjob, father_elnashat, fatheraddres, mather_name, motherqualId, motherjob, no_ekhwa, stu_tarteep, walealkmrname, saltalkarba_code, waleaalkamrjob, 
                waleaalkamraddres, waleaalkamr_phone, waleaalkamr_tel_work, waleaalkamr_mobile, mother_mobile, elram_elbarede, stu_tel, user_name, pass, email, familyFriend, familyFriendTel, 
                selaFamily, first_alaltahak_date, datein, pic) 
                VALUES  ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}, {14}, {15}, {16}, {17}, {18}, {19}, {20}, {21}, {22}, {23}, 
                {24}, {25}, {26}, {27}, {28}, {29}, {30}, {31}, {32}, {33}, {34}, {35}, {36}, {37}, {38}, {39}, {40}, {41}, {42}, {43}, {44}, {45}, {46}, {47}, {48}, {49}, {50}, GETDATE(), @MemPic)", stu_code, FIRST_NAME, 
                FATHER_NAME, GF_NAME, FAMILY_NAME, FIRST_NAME_e, FATHER_NAME_e, GF_NAME_e, FAMILY_NAME_e, parthplace_code, mohaftha_elmelad, Parthday, stu_qawme, date_segl_alwaga, kyd_no, HE_CODE,
                mantaka, Addres, code_alnoa, dyana_code, national_code, SPOS, EqamaID, date_end, Fathername, fatherqualId, fatherjob, father_elnashat, fatheraddres, mather_name, motherqualId, motherjob,
                no_ekhwa, stu_tarteep, walealkmrname, saltalkarba_code, waleaalkamrjob, waleaalkamraddres, waleaalkamr_phone, waleaalkamr_tel_work, waleaalkamr_mobile, mother_mobile, elram_elbarede,
                stu_tel, user_name, pass, email, familyFriend, familyFriendTel, selaFamily, first_alaltahak_date);
                
                if (PBImage.ImageLocation != string.Empty)
                {
                    MemPic = System.IO.File.ReadAllBytes(PBImage.ImageLocation);
                    cmd.Parameters.AddWithValue("@MemPic", MemPic);
                }
                else
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    global::Student.Properties.Resources.NoImg.Save(ms, global::Student.Properties.Resources.NoImg.RawFormat);
                    MemPic = ms.GetBuffer();
                    cmd.Parameters.AddWithValue("@MemPic", MemPic);
                }
                
                cmd.ExecuteNonQuery();
                Program.ShowMsg("تم حفظ الطالب", false, this);
                Program.Logger.LogThis("تم حفظ الطالب", Text, FXFW.Logger.OpType.success, null, null, this);
                if (LUEalsofof_code.EditValue != null || LUEfasl_code.EditValue != null)
                {
                    cmd.CommandText = string.Format(@"Insert Into stu.student_t (stu_code, asase_code, alsofof_code, fasl_code, datein, userin) VALUES ({0}, {1}, {2}, {3}, GETdate(), {4})",
                    stu_code, FXFW.SqlDB.asase_code, LUEalsofof_code.EditValue, LUEfasl_code.EditValue, FXFW.SqlDB.UserInfo.UserID);
                    cmd.ExecuteNonQuery();
                    Program.ShowMsg("تم حفظ الصف و الفصل للطالب", false, this);
                    Program.Logger.LogThis("تم حفظ الصف و الفصل للطالب", Text, FXFW.Logger.OpType.success, null, null, this);
                }
                if (LUEhaletalked_code.EditValue != null)
                {
                    cmd.CommandText = string.Format(@"Insert Into stu.stu_haletalked (stu_code, asase_code, haletalked_code) VALUES ({0}, {1}, {2})", stu_code, FXFW.SqlDB.asase_code, LUEhaletalked_code.EditValue);
                    cmd.ExecuteNonQuery();
                    Program.ShowMsg("تم حفظ حالة قيد الطالب", false, this);
                    Program.Logger.LogThis("تم حفظ حالة قيد الطالب", Text, FXFW.Logger.OpType.success, null, null, this);
                }
                if (LUEloga_code1.EditValue != null || LUEloga_code2.EditValue != null)
                {
                    cmd.CommandText = string.Format(@"Insert Into stu.stu_logatcode (stu_code, asase_code, loga_code1, loga_code2) VALUES ({0}, {1}, {2}, {3})", 
                    stu_code, FXFW.SqlDB.asase_code, LUEloga_code1.EditValue, LUEloga_code2.EditValue);
                    cmd.ExecuteNonQuery();
                    Program.ShowMsg("تم حفظ لغات الطالب", false, this);
                    Program.Logger.LogThis("تم حفظ لغات الطالب", Text, FXFW.Logger.OpType.success, null, null, this);
                }
                loadData();
                btnNew_Click(btnNew, new EventArgs());
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            //Tab1
            string FIRST_NAME = string.Empty;
            string FATHER_NAME = string.Empty;
            string GF_NAME = string.Empty;
            string FAMILY_NAME = string.Empty;
            string FIRST_NAME_e = string.Empty;
            string FATHER_NAME_e = string.Empty;
            string GF_NAME_e = string.Empty;
            string FAMILY_NAME_e = string.Empty;
            string parthplace_code = string.Empty;
            string mohaftha_elmelad = string.Empty;
            string Parthday = string.Empty;
            string stu_qawme = string.Empty;
            string date_segl_alwaga = string.Empty;
            string kyd_no = string.Empty;
            string HE_CODE = string.Empty;
            string mantaka = string.Empty;
            string Addres = string.Empty;
            string code_alnoa = string.Empty;
            string dyana_code = string.Empty;
            string national_code = string.Empty;
            string SPOS = string.Empty;
            string EqamaID = string.Empty;
            string date_end = string.Empty;
            //Tab2
            string Fathername = string.Empty;
            string fatherqualId = string.Empty;
            string fatherjob = string.Empty;
            string father_elnashat = string.Empty;
            string fatheraddres = string.Empty;
            string mather_name = string.Empty;
            string motherqualId = string.Empty;
            string motherjob = string.Empty;
            string no_ekhwa = string.Empty;
            string stu_tarteep = string.Empty;
            string walealkmrname = string.Empty;
            string saltalkarba_code = string.Empty;
            string waleaalkamrjob = string.Empty;
            string waleaalkamraddres = string.Empty;
            //Tab3
            string waleaalkamr_phone = string.Empty;
            string waleaalkamr_tel_work = string.Empty;
            string waleaalkamr_mobile = string.Empty;
            string mother_mobile = string.Empty;
            string elram_elbarede = string.Empty;
            string stu_tel = string.Empty;
            string user_name = string.Empty;
            string pass = string.Empty;
            string email = string.Empty;
            string familyFriend = string.Empty;
            string familyFriendTel = string.Empty;
            string selaFamily = string.Empty;
            string first_alaltahak_date = string.Empty;

            byte[] MemPic = null;

            prepareData(ref FIRST_NAME, ref FATHER_NAME, ref GF_NAME, ref FAMILY_NAME, ref FIRST_NAME_e, ref FATHER_NAME_e, ref GF_NAME_e, ref FAMILY_NAME_e, ref parthplace_code,
            ref mohaftha_elmelad, ref Parthday, ref stu_qawme, ref date_segl_alwaga, ref kyd_no, ref HE_CODE, ref mantaka, ref Addres, ref code_alnoa, ref dyana_code, ref national_code,
            ref SPOS, ref EqamaID, ref date_end, ref Fathername, ref fatherqualId, ref fatherjob, ref father_elnashat, ref fatheraddres, ref mather_name, ref motherqualId, ref motherjob,
            ref no_ekhwa, ref stu_tarteep, ref walealkmrname, ref saltalkarba_code, ref waleaalkamrjob, ref waleaalkamraddres, ref waleaalkamr_phone, ref waleaalkamr_tel_work,
            ref waleaalkamr_mobile, ref mother_mobile, ref elram_elbarede, ref stu_tel, ref user_name, ref pass, ref email, ref familyFriend, ref familyFriendTel, ref selaFamily, ref first_alaltahak_date);

            try
            {
                con.Open();
                cmd.CommandText = string.Format(@"Update stu.TBLstudent Set FIRST_NAME = {0}, FATHER_NAME = {1}, GF_NAME = {2}, FAMILY_NAME = {3}, FIRST_NAME_e = {4}, FATHER_NAME_e = {5}, GF_NAME_e = {6}, FAMILY_NAME_e = {7}, 
                parthplace_code = {8}, mohaftha_elmelad = {9}, Parthday = {10}, stu_qawme = {11}, date_segl_alwaga = {12}, kyd_no = {13}, HE_CODE = {14}, mantaka = {15}, [Addres] = {16}, code_alnoa = {17}, dyana_code = {18}, 
                national_code = {19}, SPOS = {20}, EqamaID = {21}, date_end = {22}, Fathername = {23}, fatherqualId = {24}, fatherjob = {25}, father_elnashat = {26}, fatheraddres = {27}, mather_name = {28}, motherqualId = {29},
                motherjob = {30}, no_ekhwa = {31}, stu_tarteep = {32}, walealkmrname = {33}, saltalkarba_code = {34}, waleaalkamrjob = {35}, waleaalkamraddres = {36}, waleaalkamr_phone = {37}, waleaalkamr_tel_work = {38}, 
                waleaalkamr_mobile = {39},  mother_mobile = {40}, elram_elbarede = {41}, stu_tel = {42}, user_name = {43}, pass = {44}, email = {45}, familyFriend = {46}, familyFriendTel = {47}, selaFamily  = {48}, first_alaltahak_date = {49},
                datein = GETDATE(), pic = @MemPic Where stu_code = {50}",
                FIRST_NAME, FATHER_NAME, GF_NAME, FAMILY_NAME, FIRST_NAME_e, FATHER_NAME_e, GF_NAME_e, FAMILY_NAME_e, parthplace_code, mohaftha_elmelad, Parthday,
                stu_qawme, date_segl_alwaga, kyd_no, HE_CODE, mantaka, Addres, code_alnoa, dyana_code, national_code, SPOS, EqamaID, date_end, Fathername, fatherqualId, 
                fatherjob, father_elnashat, fatheraddres, mather_name, motherqualId, motherjob, no_ekhwa, stu_tarteep, walealkmrname, saltalkarba_code, waleaalkamrjob,
                waleaalkamraddres, waleaalkamr_phone, waleaalkamr_tel_work, waleaalkamr_mobile, mother_mobile, elram_elbarede, stu_tel, user_name, pass, email, familyFriend,
                familyFriendTel, selaFamily, first_alaltahak_date, LUEStudents.EditValue);

                if (PBImage.ImageLocation != string.Empty)
                {
                    MemPic = System.IO.File.ReadAllBytes(PBImage.ImageLocation);
                    cmd.Parameters.AddWithValue("@MemPic", MemPic);
                }
                else
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    global::Student.Properties.Resources.NoImg.Save(ms, global::Student.Properties.Resources.NoImg.RawFormat);
                    MemPic = ms.GetBuffer();
                    cmd.Parameters.AddWithValue("@MemPic", MemPic);
                }

                cmd.ExecuteNonQuery();

                Program.ShowMsg("تم تعديل الطالب", false, this);
                Program.Logger.LogThis("تم تعديل الطالب", Text, FXFW.Logger.OpType.success, null, null, this);
                //update for this data disabled
//                if (LUEalsofof_code.EditValue != null || LUEfasl_code.EditValue != null)
//                {
//                    cmd.CommandText = string.Format(@"IF NOT EXISTS(Select * From stu.student_t Where stu_code = {0} And asase_code = {1} And alsofof_code = {2})
//                    Insert Into stu.student_t (stu_code, asase_code, alsofof_code, fasl_code, datein, userin) VALUES ({0}, {1}, {2}, {3}, GETdate(), {4})",
//                    LUEStudents.EditValue, FXFW.SqlDB.asase_code, LUEalsofof_code.EditValue, LUEfasl_code.EditValue, FXFW.SqlDB.UserInfo.UserID);
//                    cmd.ExecuteNonQuery();
//                    Program.ShowMsg("تم تعديل الصف و الفصل للطالب", false, this);
//                    //(disable update)
//                    //else
//                    //Update stu.student_t Set alsofof_code = {2}, fasl_code = {3}, datein = GETDATE(), userin = {4} Where stu_code = {0} And asase_code = {1} And alsofof_code = {2}
//                }
//                if (LUEhaletalked_code.EditValue != null)
//                {
//                    cmd.CommandText = string.Format(@"IF NOT EXISTS(Select * From stu.stu_haletalked Where stu_code = {0} And asase_code = {1})
//                    Insert Into stu.stu_haletalked (stu_code, asase_code, haletalked_code) VALUES ({0}, {1}, {2})
//                    else
//                    Update stu.stu_haletalked Set haletalked_code = {2} Where stu_code = {0} And asase_code = {1}", LUEStudents.EditValue, FXFW.SqlDB.asase_code, LUEhaletalked_code.EditValue);
//                    cmd.ExecuteNonQuery();
//                    Program.ShowMsg("تم تعديل حالة قيد الطالب", false, this);
//                }
//                if (LUEloga_code1.EditValue != null || LUEloga_code2.EditValue != null)
//                {
//                    cmd.CommandText = string.Format(@"IF NOT EXISTS(Select * From stu.stu_logatcode Where stu_code = {0} And asase_code = {1})
//                    Insert Into stu.stu_logatcode (stu_code, asase_code, loga_code1, loga_code2) VALUES ({0}, {1}, {2}, {3})
//                    else
//                    Update stu.stu_logatcode Set loga_code1 = {2}, loga_code3 = {3} Where stu_code = {0} And asase_code = {1}",
//                    LUEStudents.EditValue, FXFW.SqlDB.asase_code, LUEloga_code1.EditValue, LUEloga_code2.EditValue);
//                    cmd.ExecuteNonQuery();
//                    Program.ShowMsg("تم تعديل لغات الطالب", false, this);
//                }
                loadData();
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (LUEStudents.EditValue == null)
                return;
            if (LUEStudents.ItemIndex == -1)
                return;
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                cmd.CommandText = @"Delete From stu.TBLstudent Where stu_code = " + LUEStudents.EditValue;
                con.Open();
                cmd.ExecuteNonQuery();
                Program.ShowMsg("تم الحذف", false, this);
                Program.Logger.LogThis("تم الحذف", Text, FXFW.Logger.OpType.success, null, null, this);
                loadData();
                btnNew_Click(btnNew, new EventArgs());
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void repositoryItemButtonEditCDRelativeCodeSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            DataRow row = gridViewCDRelativeCode.GetFocusedDataRow();
            try
            {
                if (row["stu_code_SRC"].ToString() == string.Empty)
                {
                    cmd.CommandText = string.Format(@"Insert Into stu.Relatives (stu_code, stu_Relative, RelativeCode) VALUES ({0}, {1}, {2})", 
                    LUEStudents.EditValue, row["stu_Relative"], row["RelativeCode"]);
                }
                else
                {
                    cmd.CommandText = string.Format(@"Update stu.Relatives Set stu_code = {0}, stu_Relative = {1}, RelativeCode = {2} Where stu_code = {3} And stu_Relative = {4}",
                    row["stu_code"], row["stu_Relative"], row["RelativeCode"], row["stu_code_SRC"], row["stu_Relative_SRC"]);
                }
                con.Open();
                cmd.ExecuteNonQuery();
                Program.ShowMsg("تم التعديل", false, this);
                Program.Logger.LogThis("تم التعديل", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
            con.Close();
            LoadRelatives();
        }
        private void repositoryItemButtonEditCDRelativeCodeDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
           
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            DataRow row = gridViewCDRelativeCode.GetFocusedDataRow();
            if (row["stu_code_SRC"].ToString() != string.Empty)
                return;
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            try
            {
                cmd.CommandText = string.Format(@"Delete From stu.Relatives Where stu_code = {0} And stu_Relative = {1}",
                row["stu_code_SRC"], row["stu_Relative_SRC"]);
                con.Open();
                cmd.ExecuteNonQuery();
                Program.ShowMsg("تم الحذف", false, this);
                Program.Logger.LogThis("تم الحذف", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
            con.Close();
            LoadRelatives();
        }
        private void repositoryItemButtonEditrem_sudSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            DataRow row = gridViewrem_sud.GetFocusedDataRow();
            string Date;
            if (row["Date"].ToString() == string.Empty)
                Date = "NULL";
            else
                Date = string.Format("Convert(Datetime, '{0}', 103)", FXFW.SqlDB.ConvertToDateDMY(row["Date"].ToString()));
            try
            {
                if (row["stu_code_SRC"].ToString() == string.Empty)
                {
                    cmd.CommandText = string.Format(@"Insert Into stu.rem_sud (stu_code, [DATE], rem) VALUES ({0}, {1}, N'{2}')",
                    LUEStudents.EditValue, Date, row["rem"]);

                }
                else
                {
                    cmd.CommandText = string.Format(@"Update stu.rem_sud Set stu_code = {0}, [DATE] = {1}, rem = N'{2}' Where stu_code = {3} And [DATE] = {4}, And rem = N'{5}'",
                    row["stu_code_SRC"], Date, row["rem"], row["stu_code_SRC"], row["Date_SRC"], row["rem_SRC"]);
                }
                con.Open();
                cmd.ExecuteNonQuery();
                Program.ShowMsg("تم التعديل", false, this);
                Program.Logger.LogThis("تم التعديل", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
            con.Close();
            rem_sud();
        }
        private void repositoryItemButtonEditrem_sudDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            DataRow row = gridViewrem_sud.GetFocusedDataRow();
            if (row["stu_code_SRC"].ToString() != string.Empty)
                return;
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            string Date;
            if (row["Date_SRC"].ToString() == string.Empty)
                Date = "NULL";
            else
                Date = string.Format("Convert(Datetime, '{0}', 103)", FXFW.SqlDB.ConvertToDateDMY(row["Date_SRC"].ToString()));
            try
            {
                cmd.CommandText = string.Format(@"Delete From stu.rem_sud Where stu_code = {0} And DATE = {1} And rem = N'{2}'",
                row["stu_code_SRC"], Date, row["rem_SRC"]);
                con.Open();
                cmd.ExecuteNonQuery();
                Program.ShowMsg("تم الحذف", false, this);
                Program.Logger.LogThis("تم الحذف", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
            con.Close();
            rem_sud();
        }

        #endregion

    }
}