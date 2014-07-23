using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace E_Club_Emp_Manager
{
    public partial class DataSalaryFrm : DevExpress.XtraEditors.XtraForm
    {
        public DataSalaryFrm()
        {
            InitializeComponent();
        }
       
        private void DataSalaryFrm_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadGridData();
        }
        #region -   Variables   -
        DataTable Emp_MasterTBL = new DataTable("Emp_Master");
        DataTable YearTBL = new DataTable("CD_Year");
        DataTable MonthTBL = new DataTable("CD_Month");
        DataTable emp_salary = new DataTable("emp_salary");
        
        #endregion
        private void LoadData()
        {
            MonthTBL = new DataTable("CD_Month");
            YearTBL = new DataTable("CD_Year");
            Emp_MasterTBL = new DataTable("Emp_Master");
            

            using (SqlDataAdapter DA = new SqlDataAdapter("", Program.MC.SQLConStrMalafat))
            {
               
              
                //الموظفين
                Emp_MasterTBL = Program.MC.LoadDataTable("SELECT EmpID, Emp_Full_Name ,job_id,JOB_STATUS_ID FROM Emp_Master", Program.MC.SQLConStrMalafat);
                lookUpEmpName.Properties.DataSource = Emp_MasterTBL;
                lookUpEmpName.Properties.DisplayMember = "Emp_Full_Name";
                lookUpEmpName.Properties.ValueMember = "EmpID";
                
                //العام
                YearTBL = Program.MC.LoadDataTable("SELECT YearID, NameYear FROM CD_Year", Program.MC.SQLConStrMalafat);
                lookUpYear.Properties.DataSource = YearTBL;
                lookUpYear.Properties.DisplayMember = "NameYear";
                lookUpYear.Properties.ValueMember = "YearID";

                //الشهر
                MonthTBL = Program.MC.LoadDataTable("SELECT MonthID, Name_Month FROM CD_Month", Program.MC.SQLConStrMalafat);
                lookUpMonth.Properties.DataSource = MonthTBL;
                lookUpMonth.Properties.DisplayMember = "Name_Month";
                lookUpMonth.Properties.ValueMember = "MonthID";
            

                
            }
        }
        private void LoadGridData()
        {
            emp_salary = new DataTable("emp_salary");
            emp_salary = Program.MC.LoadDataTable("SELECT     Emp_Salary.EmpId, Emp_Master.Emp_Full_Name,Emp_Master.job_id,Emp_Master.JOB_STATUS_ID ,Emp_Salary.YearID, CD_Year.NameYear, Emp_Salary.MonthID, CD_Month.Name_Month,  Emp_Salary.job_id, CD_job.job, Emp_Salary.JOB_STATUS_ID, CDR_JOB_STATUS.JOB_STATUS_NAME, Emp_Salary.mosalsal,  Emp_Salary.SheetNum, Emp_Salary.Asasy, Emp_Salary.elawa1, Emp_Salary.elawa2, Emp_Salary.elawa3, Emp_Salary.elawa4, Emp_Salary.elawa5,  Emp_Salary.Est_24, Emp_Salary.Est_26, Emp_Salary.Est_1, Emp_Salary.men7a, Emp_Salary.Esq_26, Emp_Salary.Esq_14, Emp_Salary.Esq_24,  Emp_Salary.Esq_11, Emp_Salary.Esq_1, Emp_Salary.Esq_Damga, Emp_Salary.Esq_Soolaf, Emp_Salary.Esq_Gasaat, Emp_Salary.Esq_Esaba FROM         Emp_Master INNER JOIN Emp_Salary ON Emp_Master.EmpID = Emp_Salary.EmpId INNER JOIN CD_Month ON Emp_Salary.MonthID = CD_Month.MonthID INNER JOIN CD_Year ON Emp_Salary.YearID = CD_Year.YearID LEFT OUTER JOIN CDR_JOB_STATUS ON Emp_Salary.JOB_STATUS_ID = CDR_JOB_STATUS.JOB_STATUS_ID LEFT OUTER JOIN CD_job ON Emp_Salary.job_id = CD_job.job_id", Program.MC.SQLConStrMalafat);
            gridControl1.DataSource = emp_salary;
        }
        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.OK)
            {

            }
            else
            {

            }
        }
        private void labelControl13_Click(object sender, EventArgs e)
        {

        }
        private void labelControl12_Click(object sender, EventArgs e)
        {

        }
        private void labelControl11_Click(object sender, EventArgs e)
        {

        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            // MessageBox.Show( lookUpEmpName.EditValue.ToString());
            if (lookUpEmpName.EditValue != null || lookUpMonth.EditValue != null || lookUpYear.EditValue != null)
            {
                using (SqlConnection Con = new SqlConnection(Program.MC.SQLConStrMalafat))
                {
                    SqlCommand Cmd = new SqlCommand(String.Format("Set DateFormat DMY INSERT INTO Emp_Salary (EmpId, YearID, MonthID,  mosalsal, SheetNum, Asasy, elawa1, elawa2, elawa3, elawa4, elawa5, Est_24, Est_26, Est_1, men7a, Esq_26, Esq_14, Esq_24, Esq_11, Esq_1, Esq_Damga, Esq_Soolaf, Esq_Gasaat, Esq_Esaba, job_id, JOB_STATUS_ID) VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}, {14}, {15}, {16}, {17}, {18}, {19}, {20}, {21}, {22}, {23},{24},{25})", lookUpEmpName.EditValue.ToString(), lookUpYear.OldEditValue.ToString(), lookUpMonth.OldEditValue.ToString(), txt_mosalsal.Text, txt_SheetNum.Text, txt_asasy.Text, txt_elawa1.Text, txt_elawa2.Text, txt_elawa3.Text, txt_elawa4.Text, txt_elawa5.Text, txt_Est_24.Text, txt_Est_26.Text, txt_Est_1.Text, txt_men7a.Text, txt_Esq_26.Text, txt_Esq_14.Text, txt_Esq_24.Text, txt_Esq_11.Text, txt_Esq_1.Text, txt_Esq_Damga.Text, txt_Esq_Gasaat.Text, txt_Esq_Soolaf.Text, txt_Esq_Esaba.Text, Emp_MasterTBL.Rows[lookUpEmpName.ItemIndex]["job_id"].ToString(), Emp_MasterTBL.Rows[lookUpEmpName.ItemIndex]["JOB_STATUS_ID"].ToString()), Con);
                    try
                    {
                        Con.Open();
                        Cmd.ExecuteNonQuery();
                        BtnClear_Click(BtnClear, new EventArgs());
                        LoadGridData();
                        MCls.msg("تم الحفظ", false, "", this);
                    }
                    catch (SqlException ex)
                    {
                        MCls.msg(MCls.CheckExp(ex), true, ex.Number.ToString(), this);
                    }
                    Con.Close();
                }
            }
            else
            {
                MCls.msg("برجاء اكمال باقى الحقول", false, "", this);
            }
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
        
        }
        private void txt_elawa1_EditValueChanged(object sender, EventArgs e)
        {
            lblEstTotal.Text = (Convert.ToDouble(txt_elawa1.Text) + Convert.ToDouble(txt_asasy.Text) + Convert.ToDouble(txt_elawa2.Text) + Convert.ToDouble(txt_elawa3.Text) + Convert.ToDouble(txt_elawa4.Text) + Convert.ToDouble(txt_elawa5.Text) + Convert.ToDouble(txt_Est_1.Text) + Convert.ToDouble(txt_Est_24.Text) + Convert.ToDouble(txt_Est_26.Text) + Convert.ToDouble(txt_men7a.Text)).ToString();
            lblTotal.Text  = ( Convert.ToDouble(lblEstTotal.Text )- Convert.ToDouble(lblEsqTotal.Text)).ToString();
        }
        private void txt_Esq_26_EditValueChanged(object sender, EventArgs e)
        {
            lblEsqTotal.Text = (Convert.ToDouble(txt_Esq_1.Text) + Convert.ToDouble(txt_Esq_11.Text) + Convert.ToDouble(txt_Esq_14.Text) + Convert.ToDouble(txt_Esq_24.Text) + Convert.ToDouble(txt_Esq_26.Text) + Convert.ToDouble(txt_Esq_Damga.Text) + Convert.ToDouble(txt_Esq_Esaba.Text) + Convert.ToDouble(txt_Esq_Gasaat.Text) + Convert.ToDouble(txt_Esq_Soolaf.Text)).ToString();
            lblTotal.Text  = ( Convert.ToDouble(lblEstTotal.Text )- Convert.ToDouble(lblEsqTotal.Text)).ToString();
        }
        private void repositoryItemButtonEditUpdate_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل ترغب في الاستمرار؟", "تأكــــيد", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
                SqlConnection con = new SqlConnection(Program.MC.SQLConStrMalafat);
                SqlCommand cmd = new SqlCommand("", con);
                string mosalsal = "NULL", SheetNum = "NULL", Asasy = "NULL", elawa1 = "NULL", elawa2 = "NULL", elawa3 = "NULL", elawa4 = "NULL",
                    elawa5 = "NULL", Est_24 = "NULL", Est_26 = "NULL", Est_1 = "NULL", men7a = "NULL", Esq_26 = "NULL", Esq_14 = "NULL",
                    Esq_24 = "NULL", Esq_11 = "NULL", Esq_1 = "NULL", Esq_Damga = "NULL", Esq_Soolaf = "NULL", Esq_Gasaat = "NULL", Esq_Esaba = "NULL";
                if (emp_salary.Rows[gridView1.GetFocusedDataSourceRowIndex()]["mosalsal"].ToString() != string.Empty)
                    mosalsal = emp_salary.Rows[gridView1.GetFocusedDataSourceRowIndex()]["mosalsal"].ToString();
                if (emp_salary.Rows[gridView1.GetFocusedDataSourceRowIndex()]["SheetNum"].ToString() != string.Empty)
                    SheetNum = emp_salary.Rows[gridView1.GetFocusedDataSourceRowIndex()]["SheetNum"].ToString();
                if (emp_salary.Rows[gridView1.GetFocusedDataSourceRowIndex()]["Asasy"].ToString() != string.Empty)
                    Asasy = emp_salary.Rows[gridView1.GetFocusedDataSourceRowIndex()]["Asasy"].ToString();
                if (emp_salary.Rows[gridView1.GetFocusedDataSourceRowIndex()]["elawa1"].ToString() != string.Empty)
                    elawa1 = emp_salary.Rows[gridView1.GetFocusedDataSourceRowIndex()]["elawa1"].ToString();
                if (emp_salary.Rows[gridView1.GetFocusedDataSourceRowIndex()]["elawa2"].ToString() != string.Empty)
                    elawa2 = emp_salary.Rows[gridView1.GetFocusedDataSourceRowIndex()]["elawa2"].ToString();
                if (emp_salary.Rows[gridView1.GetFocusedDataSourceRowIndex()]["elawa3"].ToString() != string.Empty)
                    elawa3 = emp_salary.Rows[gridView1.GetFocusedDataSourceRowIndex()]["elawa3"].ToString();
                if (emp_salary.Rows[gridView1.GetFocusedDataSourceRowIndex()]["elawa4"].ToString() != string.Empty)
                    elawa4 = emp_salary.Rows[gridView1.GetFocusedDataSourceRowIndex()]["elawa4"].ToString();
                if (emp_salary.Rows[gridView1.GetFocusedDataSourceRowIndex()]["elawa5"].ToString() != string.Empty)
                    elawa5 = emp_salary.Rows[gridView1.GetFocusedDataSourceRowIndex()]["elawa5"].ToString();
                if (emp_salary.Rows[gridView1.GetFocusedDataSourceRowIndex()]["Est_24"].ToString() != string.Empty)
                    Est_24 = emp_salary.Rows[gridView1.GetFocusedDataSourceRowIndex()]["Est_24"].ToString();
                if (emp_salary.Rows[gridView1.GetFocusedDataSourceRowIndex()]["Est_26"].ToString() != string.Empty)
                    Est_26 = emp_salary.Rows[gridView1.GetFocusedDataSourceRowIndex()]["Est_26"].ToString();
                if (emp_salary.Rows[gridView1.GetFocusedDataSourceRowIndex()]["Est_1"].ToString() != string.Empty)
                    Est_1 = emp_salary.Rows[gridView1.GetFocusedDataSourceRowIndex()]["Est_1"].ToString();
                if (emp_salary.Rows[gridView1.GetFocusedDataSourceRowIndex()]["men7a"].ToString() != string.Empty)
                    men7a = emp_salary.Rows[gridView1.GetFocusedDataSourceRowIndex()]["men7a"].ToString();
                if (emp_salary.Rows[gridView1.GetFocusedDataSourceRowIndex()]["Esq_26"].ToString() != string.Empty)
                    Esq_26 = emp_salary.Rows[gridView1.GetFocusedDataSourceRowIndex()]["Esq_26"].ToString();
                if (emp_salary.Rows[gridView1.GetFocusedDataSourceRowIndex()]["Esq_14"].ToString() != string.Empty)
                    Esq_14 = emp_salary.Rows[gridView1.GetFocusedDataSourceRowIndex()]["Esq_14"].ToString();
                if (emp_salary.Rows[gridView1.GetFocusedDataSourceRowIndex()]["Esq_24"].ToString() != string.Empty)
                    Esq_24 = emp_salary.Rows[gridView1.GetFocusedDataSourceRowIndex()]["Esq_24"].ToString();
                if (emp_salary.Rows[gridView1.GetFocusedDataSourceRowIndex()]["Esq_11"].ToString() != string.Empty)
                    Esq_11 = emp_salary.Rows[gridView1.GetFocusedDataSourceRowIndex()]["Esq_11"].ToString();
                if (emp_salary.Rows[gridView1.GetFocusedDataSourceRowIndex()]["Esq_1"].ToString() != string.Empty)
                    Esq_1 = emp_salary.Rows[gridView1.GetFocusedDataSourceRowIndex()]["Esq_1"].ToString();
                if (emp_salary.Rows[gridView1.GetFocusedDataSourceRowIndex()]["Esq_Damga"].ToString() != string.Empty)
                    Esq_Damga = emp_salary.Rows[gridView1.GetFocusedDataSourceRowIndex()]["Esq_Damga"].ToString();
                if (emp_salary.Rows[gridView1.GetFocusedDataSourceRowIndex()]["Esq_Soolaf"].ToString() != string.Empty)
                    Esq_Soolaf = emp_salary.Rows[gridView1.GetFocusedDataSourceRowIndex()]["Esq_Soolaf"].ToString();
                if (emp_salary.Rows[gridView1.GetFocusedDataSourceRowIndex()]["Esq_Gasaat"].ToString() != string.Empty)
                    Esq_Gasaat = emp_salary.Rows[gridView1.GetFocusedDataSourceRowIndex()]["Esq_Gasaat"].ToString();
                if (emp_salary.Rows[gridView1.GetFocusedDataSourceRowIndex()]["Esq_Esaba"].ToString() != string.Empty)
                    Esq_Esaba = emp_salary.Rows[gridView1.GetFocusedDataSourceRowIndex()]["Esq_Esaba"].ToString();
                try
                {
                    con.Open();
                    cmd.CommandText = string.Format(@"UPDATE Emp_Salary
                    SET mosalsal = {0}, SheetNum = {1}, Asasy = {2}, elawa1 = {3}, elawa2 = {4}, elawa3 = {5}, elawa4 = {6}, elawa5 = {7}, Est_24 = {8}, Est_26 = {9}, Est_1 = {10}, men7a = {11}, Esq_26 = {12}, Esq_14 = {13}, 
                    Esq_24 = {14}, Esq_11 = {15}, Esq_1 = {16}, Esq_Damga = {17}, Esq_Soolaf = {18}, Esq_Gasaat = {19}, Esq_Esaba = {20}
                    WHERE (EmpId =  {21}) AND (YearID = {22}) AND (MonthID = {23})", mosalsal,SheetNum,Asasy,elawa1,elawa2,elawa3,elawa4,elawa5,Est_24,Est_26,Est_1,men7a,Esq_26,Esq_14
                    , Esq_24, Esq_11, Esq_1, Esq_Damga, Esq_Soolaf, Esq_Gasaat, Esq_Esaba, emp_salary.Rows[gridView1.GetFocusedDataSourceRowIndex()]["EmpId"].ToString(), emp_salary.Rows[gridView1.GetFocusedDataSourceRowIndex()]["YearID"].ToString(), emp_salary.Rows[gridView1.GetFocusedDataSourceRowIndex()]["MonthID"].ToString());
                    cmd.ExecuteNonQuery();
                    MCls.msg("تم التعديل", false, "", this);
                    LoadGridData();
                }
                catch (SqlException ex)
                {
                    MCls.msg(MCls.CheckExp(ex),true, ex.Number.ToString(), this);
                }
            con.Close();
        }
        private void repositoryItemButtonEditDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل ترغب في الاستمرار؟", "تأكــــيد", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            SqlConnection con = new SqlConnection(Program.MC.SQLConStrMalafat);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                con.Open();
                cmd.CommandText = string.Format(@"DELETE FROM Emp_Salary
                                   WHERE (EmpId = {0}) AND (YearID = {1}) AND (MonthID = {2})", emp_salary.Rows[gridView1.GetFocusedDataSourceRowIndex()]["EmpId"], emp_salary.Rows[gridView1.GetFocusedDataSourceRowIndex()]["YearID"], emp_salary.Rows[gridView1.GetFocusedDataSourceRowIndex()]["MonthID"]);
                cmd.ExecuteNonQuery();
                MCls.msg("تم الحذف", false, "", this);
                LoadGridData();
            }
            catch (SqlException ex)
            {
                MCls.msg(MCls.CheckExp(ex), true, ex.Number.ToString(), this);

            }
            con.Close();
            // put ur Delete command her
        }

        private void txt_asasy_EditValueChanged(object sender, EventArgs e)
        {
            lblEstTotal.Text = (Convert.ToDouble(txt_elawa1.Text) + Convert.ToDouble(txt_asasy.Text) + Convert.ToDouble(txt_elawa2.Text) + Convert.ToDouble(txt_elawa3.Text) + Convert.ToDouble(txt_elawa4.Text) + Convert.ToDouble(txt_elawa5.Text) + Convert.ToDouble(txt_Est_1.Text) + Convert.ToDouble(txt_Est_24.Text) + Convert.ToDouble(txt_Est_26.Text) + Convert.ToDouble(txt_men7a.Text)).ToString();
            lblTotal.Text = (Convert.ToDouble(lblEstTotal.Text) - Convert.ToDouble(lblEsqTotal.Text)).ToString();
        }

    }
}