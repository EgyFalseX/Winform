using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace SchoolWeeklyPeriods
{
    public partial class TBLAhteatyFrm : DevExpress.XtraEditors.XtraForm
    {
           
        #region -   Variables   -
        
        #endregion
        #region -   Functions   -
        public TBLAhteatyFrm()
        {
            InitializeComponent();
        }
        private void LoadDefaultData()
        {
            repositoryItemGridLookUpEditEmp.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT EmpID, 
            ISNULL(EMP_FIRST_NAME, '') + ' ' + ISNULL(EMP_FATHER_NAME, '') + ' ' + ISNULL(EMP_FAM_NAME, '') + ' ' + ISNULL(EMP_FOURTH_NAME, '') AS emp_name
            FROM TBL_Emp");
            repositoryItemGridLookUpEditEmp.DisplayMember = "emp_name";
            repositoryItemGridLookUpEditEmp.ValueMember = "EmpID";

            repositoryItemGridLookUpEditalsofof_code.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT alsofof_code, alsofof_name, alsofof_name_e From CDAlsofof");
            repositoryItemGridLookUpEditalsofof_code.DisplayMember = "alsofof_name";
            repositoryItemGridLookUpEditalsofof_code.ValueMember = "alsofof_code";

            repositoryItemGridLookUpEditfasl_code.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT fasl_code, fasl_name, fasl_name_e From CDEFasl");
            repositoryItemGridLookUpEditfasl_code.DisplayMember = "fasl_name";
            repositoryItemGridLookUpEditfasl_code.ValueMember = "fasl_code";

            repositoryItemGridLookUpEditSubjectId.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT SubjectId, Subject, Subject_e From CD_Subject");
            repositoryItemGridLookUpEditSubjectId.DisplayMember = "Subject";
            repositoryItemGridLookUpEditSubjectId.ValueMember = "SubjectId";

            repositoryItemGridLookUpEditdaycode.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT daycode, dayname, dayname_e From CDDayname");
            repositoryItemGridLookUpEditdaycode.DisplayMember = "dayname";
            repositoryItemGridLookUpEditdaycode.ValueMember = "daycode";

            repositoryItemGridLookUpEdithasa_code.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT hasa_code, hasa_name, hasa_name_e From CDAlhasas");
            repositoryItemGridLookUpEdithasa_code.DisplayMember = "hasa_name";
            repositoryItemGridLookUpEdithasa_code.ValueMember = "hasa_code";
        }
        private void LoadData()
        {
            gridControlData.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT asase_code, EmpabsentID, agaza_st_date, daycode, hasa_code, alsofof_code, fasl_code, SubjectId, EmpahtyatyId,
            asase_code AS org_asase_code, EmpabsentID AS org_EmpabsentID, agaza_st_date AS org_agaza_st_date, daycode AS org_daycode, hasa_code AS org_hasa_code, alsofof_code AS org_alsofof_code, 
            fasl_code AS org_fasl_code, SubjectId AS org_SubjectId, EmpahtyatyId AS org_EmpahtyatyId
            FROM TBLAhteaty");
        }
        private int DateNumber(int DayNo)
        {
            switch (DayNo)
            {
                case 0:
                    return 2;
                case 1:
                    return 3;
                case 2:
                    return 4;
                case 3:
                    return 5;
                case 4:
                    return 6;
                case 5:
                    return 7;
                case 6:
                    return 1;
                default:
                    return -1;
            }
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
            bool Selecting = false, Inserting = false, Updateing = false, Deleting = false;
            FXFW.SqlDB.GetFormPriv("Time" + Name.Replace("Frm", ""), ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
            gridControlData.Visible = Selecting;
            if (Inserting || Updateing)
                repositoryItemButtonEditSave.Buttons[0].Enabled = true;
            else
                repositoryItemButtonEditSave.Buttons[0].Enabled = false;
            repositoryItemButtonEditDel.Buttons[0].Enabled = Deleting;
            btnMAdd.Enabled = Inserting;
        }
        #endregion
        #region -   Event Handlers   -
        private void TBLAhteatyFrm_Load(object sender, EventArgs e)
        {
            
            ActivePriv();
            LoadDefaultData();
        }
       
        #region -   Auto Tab   -
        private void deDate_EditValueChanged(object sender, EventArgs e)
        {
            LUEEmpAbs.EditValue = null;
            //LUEEmpRes.EditValue = null;

            LUEEmpAbs.Properties.DataSource = FXFW.SqlDB.LoadDataTable(string.Format(@"SELECT EmpID,
            (Select ISNULL(EMP_FIRST_NAME, '') + ' ' + ISNULL(EMP_FATHER_NAME, '') + ' ' + ISNULL(EMP_FAM_NAME, '') + ' ' + ISNULL(EMP_FOURTH_NAME, '') From TBL_Emp Where EmpID = EMP_agazat.EmpID) AS emp_name
            FROM EMP_agazat WHERE (agaza_st_date = CONVERT(datetime, '{0}', 103))", FXFW.SqlDB.ConvertToDateDMY(deDate.DateTime.ToShortDateString())));
            LUEEmpAbs.Properties.DisplayMember = "emp_name";
            LUEEmpAbs.Properties.ValueMember = "EmpID";

//            LUEEmpRes.Properties.DataSource = FXFW.SqlDB.LoadDataTable(string.Format(@"SELECT EmpID, 
//            ISNULL(EMP_FIRST_NAME, '') + ' ' + ISNULL(EMP_FATHER_NAME, '') + ' ' + ISNULL(EMP_FAM_NAME, '') + ' ' + ISNULL(EMP_FOURTH_NAME, '') AS emp_name FROM TBL_Emp 
//            Where NOT Exists(Select EmpID From EMP_agazat Where EmpID = TBL_Emp.EmpID AND agaza_st_date = CONVERT(datetime, '{0}', 103))", FXFW.SqlDB.ConvertToDateDMY(deDate.DateTime.ToShortDateString())));
//            LUEEmpRes.Properties.DisplayMember = "emp_name";
//            LUEEmpRes.Properties.ValueMember = "EmpID";

        }
        private void LUEEmpAbs_EditValueChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (!FXFW.SqlDB.IsNullOrEmpty(LUEEmpAbs.EditValue))
            {
                dt = FXFW.SqlDB.LoadDataTable(string.Format(@"SELECT 
                (Select ISNULL(EMP_FIRST_NAME, '') + ' ' + ISNULL(EMP_FATHER_NAME, '') + ' ' + ISNULL(EMP_FAM_NAME, '') + ' ' + ISNULL(EMP_FOURTH_NAME, '') From TBL_Emp Where EmpID = gdw.TBLTimeTable.EmpID) AS emp_name,
                (SELECT [dayname] FROM CDDayname WHERE daycode = gdw.TBLTimeTable.daycode) AS [dayname],
                (SELECT hasa_name FROM CDAlhasas WHERE hasa_code = gdw.TBLTimeTable.hasa_code) AS hasa_name,
                (SELECT alsofof_name FROM CDAlsofof WHERE alsofof_code = gdw.TBLTimeTable.alsofof_code) AS alsofof_name,
                (SELECT fasl_name FROM CDEFasl WHERE fasl_code = gdw.TBLTimeTable.fasl_code) AS fasl_name,
                (SELECT [Subject] FROM CD_Subject WHERE SubjectId = gdw.TBLTimeTable.SubjectId) AS [Subject],
                (SELECT place FROM gdw.CDPlace WHERE placecd = gdw.TBLTimeTable.placecd) AS place
                 FROM gdw.TBLTimeTable
                 WHERE gdw.TBLTimeTable.EmpID = {0} AND asase_code = {1} AND gdw.TBLTimeTable.daycode = {2}", LUEEmpAbs.EditValue, FXFW.SqlDB.asase_code, DateNumber((int)deDate.DateTime.DayOfWeek)));
            }

            gridControlViewer.DataSource = dt;

            // TODO: This line of code loads data into the 'dsSchoolQuery.TBL_Emp' table. You can move, or remove it, as needed.
            this.tBL_EmpTableAdapter.FillByFreeAhtiatyEmpInDate(this.dsSchoolQuery.TBL_Emp, deDate.DateTime, Convert.ToInt32(FXFW.SqlDB.asase_code), Convert.ToInt32(LUEEmpAbs.EditValue));
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (FXFW.SqlDB.IsNullOrEmpty(LUEEmpAbs.EditValue) || FXFW.SqlDB.IsNullOrEmpty(LUEEmpRes.EditValue) || FXFW.SqlDB.IsNullOrEmpty(deDate.EditValue))
            {
                Program.ShowMsg("البيانات غير مكتمله", true, this);
                Program.Logger.LogThis("البيانات غير مكتمله", Text, FXFW.Logger.OpType.information, null, null, this);
                return;
            }
            DataTable dt = FXFW.SqlDB.LoadDataTable(string.Format(@"SELECT EmpID, daycode, hasa_code, alsofof_code, fasl_code, SubjectId, placecd From gdw.TBLTimeTable Where 
            gdw.TBLTimeTable.EmpID = {0} AND asase_code = {1} AND gdw.TBLTimeTable.daycode = {2}", LUEEmpAbs.EditValue, FXFW.SqlDB.asase_code, DateNumber((int)deDate.DateTime.DayOfWeek)));

            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            SqlTransaction trn = null;
            try
            {
                con.Open();
                cmd.CommandText = @"INSERT INTO dbo.TBLAhteaty
                                    ( asase_code ,
                                      EmpabsentID ,
                                      agaza_st_date ,
                                      daycode ,
                                      hasa_code ,
                                      alsofof_code ,
                                      fasl_code ,
                                      SubjectId ,
                                      EmpahtyatyId
                                    )
                            VALUES  ( @asase_code , -- asase_code - tinyint
                                      @EmpabsentID , -- EmpabsentID - int
                                      @agaza_st_date , -- agaza_st_date - date
                                      @daycode , -- daycode - int
                                      @hasa_code , -- hasa_code - int
                                      @alsofof_code , -- alsofof_code - tinyint
                                      @fasl_code , -- fasl_code - tinyint
                                      @SubjectId , -- SubjectId - smallint
                                      @EmpahtyatyId  -- EmpahtyatyId - int
                                    )";
                cmd.Parameters.Add(new SqlParameter("@asase_code", SqlDbType.TinyInt) { Value = FXFW.SqlDB.asase_code });
                cmd.Parameters.Add(new SqlParameter("@EmpabsentID", SqlDbType.Int) { Value = LUEEmpAbs.EditValue });
                cmd.Parameters.Add(new SqlParameter("@agaza_st_date", SqlDbType.Date) { Value = deDate.DateTime });
                cmd.Parameters.Add(new SqlParameter("@daycode", SqlDbType.Int) { Value = DateNumber((int)deDate.DateTime.DayOfWeek) });
                cmd.Parameters.Add(new SqlParameter("@hasa_code", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@alsofof_code", SqlDbType.TinyInt));
                cmd.Parameters.Add(new SqlParameter("@fasl_code", SqlDbType.TinyInt));
                cmd.Parameters.Add(new SqlParameter("@SubjectId", SqlDbType.SmallInt));
                cmd.Parameters.Add(new SqlParameter("@EmpahtyatyId", SqlDbType.Int) { Value = LUEEmpRes.EditValue });

                trn = con.BeginTransaction(); cmd.Transaction = trn;

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cmd.Parameters["@hasa_code"].Value = dt.Rows[i]["hasa_code"].ToString();
                    cmd.Parameters["@alsofof_code"].Value = dt.Rows[i]["alsofof_code"].ToString();
                    cmd.Parameters["@fasl_code"].Value = dt.Rows[i]["fasl_code"].ToString();
                    cmd.Parameters["@SubjectId"].Value = dt.Rows[i]["SubjectId"].ToString();
                    cmd.ExecuteNonQuery();
                }
                trn.Commit();
                LUEEmpRes.EditValue = null;
                Program.ShowMsg("تم الحفظ", false, this);
                Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (SqlException ex)
            {
                trn.Rollback();
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
            con.Close();
        }
        #endregion
        #region -   Manual Tab   -
        private void deMDate_EditValueChanged(object sender, EventArgs e)
        {
            LUEMEmpAbs.EditValue = null;
            LUEMPeriod.EditValue = null;
            LUEMEmpRes.EditValue = null;

            LUEMEmpAbs.Properties.DataSource = FXFW.SqlDB.LoadDataTable(string.Format(@"SELECT EmpID,
            (Select ISNULL(EMP_FIRST_NAME, '') + ' ' + ISNULL(EMP_FATHER_NAME, '') + ' ' + ISNULL(EMP_FAM_NAME, '') + ' ' + ISNULL(EMP_FOURTH_NAME, '') From TBL_Emp Where EmpID = EMP_agazat.EmpID) AS emp_name
            FROM EMP_agazat WHERE (agaza_st_date = CONVERT(datetime, '{0}', 103))", FXFW.SqlDB.ConvertToDateDMY(deMDate.DateTime.ToShortDateString())));
            LUEMEmpAbs.Properties.DisplayMember = "emp_name";
            LUEMEmpAbs.Properties.ValueMember = "EmpID";
            
        }
        private void LUEMEmpAbs_EditValueChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (FXFW.SqlDB.IsNullOrEmpty(LUEMEmpAbs.EditValue) || FXFW.SqlDB.IsNullOrEmpty(deMDate.EditValue))
            {
                LUEMPeriod.Properties.DataSource = dt;
                return;
            }
            dt = FXFW.SqlDB.LoadDataTable(string.Format(@"SELECT asase_code, daycode, hasa_code, alsofof_code, fasl_code, SubjectId, placecd, 
                (SELECT [dayname] FROM CDDayname WHERE daycode = gdw.TBLTimeTable.daycode) + ' / ' + (SELECT hasa_name FROM CDAlhasas WHERE hasa_code = gdw.TBLTimeTable.hasa_code) AS details, 
                (SELECT [dayname] FROM CDDayname WHERE daycode = gdw.TBLTimeTable.daycode) AS [dayname],
                (SELECT hasa_name FROM CDAlhasas WHERE hasa_code = gdw.TBLTimeTable.hasa_code) AS hasa_name,
                (SELECT alsofof_name FROM CDAlsofof WHERE alsofof_code = gdw.TBLTimeTable.alsofof_code) AS alsofof_name,
                (SELECT fasl_name FROM CDEFasl WHERE fasl_code = gdw.TBLTimeTable.fasl_code) AS fasl_name,
                (SELECT [Subject] FROM CD_Subject WHERE SubjectId = gdw.TBLTimeTable.SubjectId) AS [Subject],
                (SELECT place FROM gdw.CDPlace WHERE placecd = gdw.TBLTimeTable.placecd) AS place
                FROM gdw.TBLTimeTable
                WHERE gdw.TBLTimeTable.EmpID = {0} AND asase_code = {1} AND gdw.TBLTimeTable.daycode = {2} AND 
                NOT EXISTS(SELECT * FROM dbo.TBLAhteaty WHERE asase_code = gdw.TBLTimeTable.asase_code AND EmpabsentID = gdw.TBLTimeTable.EmpID AND 
				daycode = gdw.TBLTimeTable.daycode AND hasa_code = gdw.TBLTimeTable.hasa_code AND alsofof_code = gdw.TBLTimeTable.alsofof_code AND 
                fasl_code = gdw.TBLTimeTable.fasl_code AND agaza_st_date = CONVERT(DATETIME, '{3}', 103))",
                LUEMEmpAbs.EditValue, FXFW.SqlDB.asase_code, DateNumber((int)deMDate.DateTime.DayOfWeek), FXFW.SqlDB.ConvertToDateDMY(deMDate.DateTime.ToShortDateString())));

            LUEMPeriod.Properties.DataSource = dt;
            LUEMPeriod.Properties.DisplayMember = "details";
            LUEMPeriod.Properties.ValueMember = "hasa_code";
        }
        private void LUEMPeriod_EditValueChanged(object sender, EventArgs e)
        {
            if (FXFW.SqlDB.IsNullOrEmpty(LUEMPeriod.EditValue) || FXFW.SqlDB.IsNullOrEmpty(deMDate.EditValue))
                return;
            DataRow row = ((DataTable)LUEMPeriod.Properties.DataSource).Rows[LUEMPeriod.ItemIndex];
            LUEMEmpRes.Properties.DataSource = FXFW.SqlDB.LoadDataTable(string.Format(@"SELECT EmpID, 
            ISNULL(EMP_FIRST_NAME, '') + ' ' + ISNULL(EMP_FATHER_NAME, '') + ' ' + ISNULL(EMP_FAM_NAME, '') + ' ' + ISNULL(EMP_FOURTH_NAME, '') AS emp_name
            FROM TBL_Emp
            WHERE NOT EXISTS(SELECT EmpID FROM gdw.TBLTimeTable WHERE EmpID = dbo.TBL_Emp.EmpID AND daycode = {0} AND hasa_code = {1} AND alsofof_code = {2} AND fasl_code = {3} AND asase_code = {4}) AND
            NOT EXISTS(SELECT EmpID FROM dbo.TBLAhteaty WHERE EmpabsentID = dbo.TBL_Emp.EmpID AND daycode = {0} AND hasa_code = {1} AND alsofof_code = {2} AND fasl_code = {3} AND asase_code = {4} AND agaza_st_date = CONVERT(DATETIME, '{5}', 103))",
            row["daycode"].ToString(), row["hasa_code"].ToString(), row["alsofof_code"].ToString(), row["fasl_code"].ToString(), row["asase_code"].ToString(), FXFW.SqlDB.ConvertToDateDMY(deMDate.DateTime.ToShortDateString())));
            LUEMEmpRes.Properties.DisplayMember = "emp_name";
            LUEMEmpRes.Properties.ValueMember = "EmpID";
        }
        private void btnMAdd_Click(object sender, EventArgs e)
        {
            if (FXFW.SqlDB.IsNullOrEmpty(deMDate.EditValue) || FXFW.SqlDB.IsNullOrEmpty(LUEMEmpAbs.EditValue) || FXFW.SqlDB.IsNullOrEmpty(LUEMPeriod.EditValue) || FXFW.SqlDB.IsNullOrEmpty(LUEMEmpRes.EditValue))
                return;

            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            DataRow row = ((DataTable)LUEMPeriod.Properties.DataSource).Rows[LUEMPeriod.ItemIndex];
            try
            {
                cmd.Parameters.Add(new SqlParameter("@asase_code", SqlDbType.TinyInt) { Value = row["asase_code"].ToString() });
                cmd.Parameters.Add(new SqlParameter("@EmpabsentID", SqlDbType.Int) { Value = LUEMEmpAbs.EditValue });
                cmd.Parameters.Add(new SqlParameter("@agaza_st_date", SqlDbType.Date) { Value = deMDate.EditValue });
                cmd.Parameters.Add(new SqlParameter("@daycode", SqlDbType.Int) { Value = row["daycode"].ToString() });
                cmd.Parameters.Add(new SqlParameter("@hasa_code", SqlDbType.Int) { Value = row["hasa_code"].ToString() });
                cmd.Parameters.Add(new SqlParameter("@alsofof_code", SqlDbType.TinyInt) { Value = row["alsofof_code"].ToString() });
                cmd.Parameters.Add(new SqlParameter("@fasl_code", SqlDbType.TinyInt) { Value = row["fasl_code"].ToString() });
                cmd.Parameters.Add(new SqlParameter("@SubjectId", SqlDbType.SmallInt) { Value = row["SubjectId"].ToString() });
                cmd.Parameters.Add(new SqlParameter("@EmpahtyatyId", SqlDbType.Int) { Value = LUEMEmpRes.EditValue });
                cmd.CommandText = @"INSERT INTO dbo.TBLAhteaty
                                    ( asase_code ,
                                      EmpabsentID ,
                                      agaza_st_date ,
                                      daycode ,
                                      hasa_code ,
                                      alsofof_code ,
                                      fasl_code ,
                                      SubjectId ,
                                      EmpahtyatyId
                                    )
                            VALUES  ( @asase_code , -- asase_code - tinyint
                                      @EmpabsentID , -- EmpabsentID - int
                                      @agaza_st_date , -- agaza_st_date - date
                                      @daycode , -- daycode - int
                                      @hasa_code , -- hasa_code - int
                                      @alsofof_code , -- alsofof_code - tinyint
                                      @fasl_code , -- fasl_code - tinyint
                                      @SubjectId , -- SubjectId - smallint
                                      @EmpahtyatyId  -- EmpahtyatyId - int
                                    )";
                con.Open();
                cmd.ExecuteNonQuery();
                Program.ShowMsg("تم الحفظ", false, this);
                Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
                LUEMEmpRes.EditValue = null;
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
            con.Close();
        }
        #endregion
        #region -   Edit Tab   -
        private void xtraTabControlMain_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            LoadData();
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            DataRow rowData = gridViewData.GetFocusedDataRow();

            try
            {

                cmd.Parameters.Add(new SqlParameter("@asase_code", SqlDbType.TinyInt) { Value = FXFW.SqlDB.asase_code });
                cmd.Parameters.Add(new SqlParameter("@EmpabsentID", SqlDbType.Int) { Value = rowData["EmpabsentID"].ToString() });
                cmd.Parameters.Add(new SqlParameter("@agaza_st_date", SqlDbType.Date) { Value = rowData["agaza_st_date"].ToString() });
                cmd.Parameters.Add(new SqlParameter("@daycode", SqlDbType.Int) { Value = rowData["daycode"].ToString() });
                cmd.Parameters.Add(new SqlParameter("@hasa_code", SqlDbType.Int) { Value = rowData["hasa_code"].ToString() });
                cmd.Parameters.Add(new SqlParameter("@alsofof_code", SqlDbType.TinyInt) { Value = rowData["alsofof_code"].ToString() });
                cmd.Parameters.Add(new SqlParameter("@fasl_code", SqlDbType.TinyInt) { Value = rowData["fasl_code"].ToString() });
                cmd.Parameters.Add(new SqlParameter("@SubjectId", SqlDbType.SmallInt) { Value = rowData["SubjectId"].ToString() });
                cmd.Parameters.Add(new SqlParameter("@EmpahtyatyId", SqlDbType.Int) { Value = rowData["EmpahtyatyId"].ToString() });
                if (rowData["org_asase_code"].ToString() == string.Empty)
                {
                    cmd.CommandText = @"INSERT INTO dbo.TBLAhteaty
                                    ( asase_code ,
                                      EmpabsentID ,
                                      agaza_st_date ,
                                      daycode ,
                                      hasa_code ,
                                      alsofof_code ,
                                      fasl_code ,
                                      SubjectId ,
                                      EmpahtyatyId
                                    )
                            VALUES  ( @asase_code , -- asase_code - tinyint
                                      @EmpabsentID , -- EmpabsentID - int
                                      @agaza_st_date , -- agaza_st_date - date
                                      @daycode , -- daycode - int
                                      @hasa_code , -- hasa_code - int
                                      @alsofof_code , -- alsofof_code - tinyint
                                      @fasl_code , -- fasl_code - tinyint
                                      @SubjectId , -- SubjectId - smallint
                                      @EmpahtyatyId  -- EmpahtyatyId - int
                                    )";
                }
                else
                {
                    cmd.CommandText = @"UPDATE TBLAhteaty SET asase_code = @asase_code, EmpabsentID = @EmpabsentID, agaza_st_date = @agaza_st_date, daycode = @daycode, hasa_code = @hasa_code,
                    alsofof_code = @alsofof_code, fasl_code = @fasl_code, SubjectId = @SubjectId, EmpahtyatyId = @EmpahtyatyId WHERE 
                    asase_code = @org_asase_code AND EmpabsentID = @org_EmpabsentID AND agaza_st_date = @org_agaza_st_date AND daycode = @org_daycode AND hasa_code = @org_hasa_code AND
                    alsofof_code = @org_alsofof_code AND fasl_code = @org_fasl_code AND SubjectId = @org_SubjectId AND EmpahtyatyId = @org_EmpahtyatyId";
                    cmd.Parameters.Add(new SqlParameter("@org_asase_code", SqlDbType.TinyInt) { Value = rowData["org_asase_code"].ToString() });
                    cmd.Parameters.Add(new SqlParameter("@org_EmpabsentID", SqlDbType.Int) { Value = rowData["org_EmpabsentID"].ToString() });
                    cmd.Parameters.Add(new SqlParameter("@org_agaza_st_date", SqlDbType.Date) { Value = rowData["org_agaza_st_date"].ToString() });
                    cmd.Parameters.Add(new SqlParameter("@org_daycode", SqlDbType.Int) { Value = rowData["org_daycode"].ToString() });
                    cmd.Parameters.Add(new SqlParameter("@org_hasa_code", SqlDbType.Int) { Value = rowData["org_hasa_code"].ToString() });
                    cmd.Parameters.Add(new SqlParameter("@org_alsofof_code", SqlDbType.TinyInt) { Value = rowData["org_alsofof_code"].ToString() });
                    cmd.Parameters.Add(new SqlParameter("@org_fasl_code", SqlDbType.TinyInt) { Value = rowData["org_fasl_code"].ToString() });
                    cmd.Parameters.Add(new SqlParameter("@org_SubjectId", SqlDbType.SmallInt) { Value = rowData["org_SubjectId"].ToString() });
                    cmd.Parameters.Add(new SqlParameter("@org_EmpahtyatyId", SqlDbType.Int) { Value = rowData["org_EmpahtyatyId"].ToString() });
                }

                con.Open();
                cmd.ExecuteNonQuery();
                Program.ShowMsg("تم الحفظ", false, this);
                Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
            con.Close();
        }
        private void repositoryItemButtonEditDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            DataRow rowData = gridViewData.GetFocusedDataRow();

            try
            {

                if (rowData["org_asase_code"].ToString() == string.Empty)
                {
                    LoadData();
                    return;
                }
                else
                {
                    cmd.CommandText = @"DELETE FROM TBLAhteaty WHERE 
                    asase_code = @org_asase_code AND EmpabsentID = @org_EmpabsentID AND agaza_st_date = @org_agaza_st_date AND daycode = @org_daycode AND hasa_code = @org_hasa_code AND
                    alsofof_code = @org_alsofof_code AND fasl_code = @org_fasl_code AND SubjectId = @org_SubjectId AND EmpahtyatyId = @org_EmpahtyatyId";
                    cmd.Parameters.Add(new SqlParameter("@org_asase_code", SqlDbType.TinyInt) { Value = rowData["org_asase_code"].ToString() });
                    cmd.Parameters.Add(new SqlParameter("@org_EmpabsentID", SqlDbType.Int) { Value = rowData["org_EmpabsentID"].ToString() });
                    cmd.Parameters.Add(new SqlParameter("@org_agaza_st_date", SqlDbType.Date) { Value = rowData["org_agaza_st_date"].ToString() });
                    cmd.Parameters.Add(new SqlParameter("@org_daycode", SqlDbType.Int) { Value = rowData["org_daycode"].ToString() });
                    cmd.Parameters.Add(new SqlParameter("@org_hasa_code", SqlDbType.Int) { Value = rowData["org_hasa_code"].ToString() });
                    cmd.Parameters.Add(new SqlParameter("@org_alsofof_code", SqlDbType.TinyInt) { Value = rowData["org_alsofof_code"].ToString() });
                    cmd.Parameters.Add(new SqlParameter("@org_fasl_code", SqlDbType.TinyInt) { Value = rowData["org_fasl_code"].ToString() });
                    cmd.Parameters.Add(new SqlParameter("@org_SubjectId", SqlDbType.SmallInt) { Value = rowData["org_SubjectId"].ToString() });
                    cmd.Parameters.Add(new SqlParameter("@org_EmpahtyatyId", SqlDbType.Int) { Value = rowData["org_EmpahtyatyId"].ToString() });
                }

                con.Open();
                cmd.ExecuteNonQuery();
                Program.ShowMsg("تم الحفظ", false, this);
                Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
                LoadData();
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
            con.Close();
        }
        #endregion
        #endregion

    }
}