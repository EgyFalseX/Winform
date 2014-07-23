using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace E_Club_Att_Manager
{
    public partial class DataEmpAttTimeFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        DataTable EmpShiftsTbl = new DataTable("FalseX2010-08");
        DataTable EmpTbl = new DataTable("FalseX2010-08");
        DataTable ShiftTbl = new DataTable("FalseX2010-08");
        #endregion
        #region -   Functions   -
        public DataEmpAttTimeFrm()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            EmpTbl = new DataTable("FalseX2010-08");
            EmpTbl = Program.MC.LoadDataTableMalafat("SELECT EmpID, Emp_Full_Name,(Select job From CD_job Where job_id =  Emp_Master.job_id) AS job, PHONE_NO, MOBILE_NO FROM Emp_Master");
            LUEEmp.Properties.DataSource = EmpTbl;
            LUEEmp.Properties.DisplayMember = "Emp_Full_Name";
            LUEEmp.Properties.ValueMember = "EmpID";

            ShiftTbl = new DataTable("FalseX2010-08");
            ShiftTbl = Program.MC.LoadDataTableMalafat("SELECT shift_code, shift, shift_Start, shift_End FROM CDATT_sheft");
            LUEShift.Properties.DataSource = ShiftTbl;
            LUEShift.Properties.DisplayMember = "shift";
            LUEShift.Properties.ValueMember = "shift_code";

            EmpShiftsTbl = new DataTable("FalseX2010-08");
            EmpShiftsTbl = Program.MC.LoadDataTableMalafat("SELECT EmpID, shift_code, (SELECT shift FROM CDATT_sheft WHERE shift_code = ATT_Company_Emp.shift_code) AS shift, hedor_time_Start, hedor_time_End, enseraf_time_Start, enseraf_time_End FROM ATT_Company_Emp");
            gridControlEdit.DataSource = EmpShiftsTbl;
        }
        #endregion
        #region -   Event Handlers   -
        private void DataEmpAttTimeFrm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LUEEmp_EditValueChanged(object sender, EventArgs e)
        {
            if (LUEEmp.EditValue == null || LUEShift.EditValue == null)
                BtnSave.Enabled = false;
            else
                BtnSave.Enabled = true;
        }
        private void LUEShift_EditValueChanged(object sender, EventArgs e)
        {
            if (LUEEmp.EditValue == null || LUEShift.EditValue == null)
                BtnSave.Enabled = false;
            else
                BtnSave.Enabled = true;
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            string EmpID = LUEEmp.EditValue.ToString();
            string shift_code = LUEShift.EditValue.ToString();
            string hedor_time_Start = "'" + ((DateTime)TECStart.Time).TimeOfDay.ToString() + "'";
            string hedor_time_End = "'" + ((DateTime)TECEnd.Time).TimeOfDay.ToString() + "'";
            string enseraf_time_Start = "'" + ((DateTime)TEWStart.Time).TimeOfDay.ToString() + "'";
            string enseraf_time_End = "'" + ((DateTime)TEWEnd.Time).TimeOfDay.ToString() + "'";
            SqlConnection Con = new SqlConnection(Program.MC.SQLConStrMalafat);
            SqlCommand Cmd = new SqlCommand("", Con);
            try
            {
                Con.Open();
                Cmd.CommandText = string.Format("INSERT INTO ATT_Company_Emp (EmpID, shift_code, hedor_time_Start, hedor_time_End, enseraf_time_Start, enseraf_time_End) VALUES ({0}, {1}, {2}, {3}, {4}, {5})", EmpID, shift_code, hedor_time_Start, hedor_time_End, enseraf_time_Start, enseraf_time_End);
                Cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                    MessageBox.Show("تم ادخال هذا الموظف في هذه الفتره سابقا","بيانات مكرره",MessageBoxButtons.OK,MessageBoxIcon.Error);
                else
                    MessageBox.Show(ex.Message, "خطــــاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Con.Close();
            LoadData();
        }
        private void repositoryItemButtonEditDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل ترغب في الاستمرار؟", "تأكــــيد", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }
            using (SqlConnection Con = new SqlConnection(Program.MC.SQLConStrMalafat))
            {
                SqlCommand Cmd = new SqlCommand(String.Format("DELETE FROM ATT_Company_Emp WHERE (EmpID = {0} And shift_code = {1})", EmpShiftsTbl.Rows[gridViewEdit.GetFocusedDataSourceRowIndex()]["EmpID"].ToString(), EmpShiftsTbl.Rows[gridViewEdit.GetFocusedDataSourceRowIndex()]["shift_code"].ToString()), Con);
                try
                {
                    Con.Open();
                    Cmd.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("تم الحـــذف ", "حـــــذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion
    }
}