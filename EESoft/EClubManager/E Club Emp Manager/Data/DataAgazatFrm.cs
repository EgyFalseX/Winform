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
    public partial class DataAgazatFrm : DevExpress.XtraEditors.XtraForm
    {
        DataTable EmpTbl = new DataTable("False2010-09");
        DataTable AgazaTypeTbl = new DataTable("False2010-09");
        DataTable AgazatTbl = new DataTable("False2010-09");
        public DataAgazatFrm()
        {
            InitializeComponent();
        }
        private void LoadDefaultData()
        {
            EmpTbl = new DataTable("False2010-09");
            EmpTbl = Program.MC.LoadDataTable("Select EmpID, Emp_Full_Name, PHONE_NO, MOBILE_NO, (Select job From CD_job Where job_id = Emp_Master.job_id) As job From Emp_Master", Program.MC.SQLConStrMalafat);
            LUEEmp.Properties.DataSource = EmpTbl;
            LUEEmp.Properties.ValueMember = "EmpID";
            LUEEmp.Properties.DisplayMember = "Emp_Full_Name";

            AgazaTypeTbl = new DataTable("False2010-09");
            AgazaTypeTbl = Program.MC.LoadDataTable("SELECT agaza_type_code, agaza_type_name FROM CDEMP_agazatype", Program.MC.SQLConStrMalafat);
            LUEAgazaType.Properties.DataSource = AgazaTypeTbl;
            LUEAgazaType.Properties.ValueMember = "agaza_type_code";
            LUEAgazaType.Properties.DisplayMember = "agaza_type_name";
        }
        private void LoadData()
        {
            AgazatTbl = new DataTable("False2010-09");
            AgazatTbl = Program.MC.LoadDataTable("SELECT EmpID, (Select Emp_Full_Name From Emp_Master Where EmpID = EMP_agazat.EmpID) AS Emp_Full_Name, (Select agaza_type_name From CDEMP_agazatype Where agaza_type_code =  EMP_agazat.agaza_type_code) AS agaza_type_name, agaza_st_date, agaza_end_date, agaza_MEMEO From  EMP_agazat", Program.MC.SQLConStrMalafat);
            gridControlAgaza.DataSource = AgazatTbl;
        }
        private void DataAgazatFrm_Load(object sender, EventArgs e)
        {
            LoadDefaultData();
            LoadData();
        }
        private void ClearForm()
        {
            LUEEmp.EditValue = null;
            LUEAgazaType.EditValue = null;
            DEStart.EditValue = null;
            DEEnd.EditValue = null;
            MemoTxt.Text = string.Empty;
        }
        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (e.Page == xtraTabPageEditing)
                LoadData();
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            string EmpID = "NULL", agaza_type_code = "NULL", agaza_st_date = "NULL", agaza_end_date = "NULL", agaza_MEMEO = "NULL";
            if (LUEEmp.ItemIndex != -1)
                EmpID = LUEEmp.EditValue.ToString();
            if (LUEAgazaType.ItemIndex != -1)
                agaza_type_code = LUEAgazaType.EditValue.ToString();
            if (DEStart.EditValue != null)
                agaza_st_date = String.Format("CONVERT(DATETIME, '{0}', 103)", DEStart.EditValue);
            if (DEEnd.EditValue != null)
                agaza_end_date = String.Format("CONVERT(DATETIME, '{0}', 103)", DEEnd.EditValue);
            if (MemoTxt.Text.Trim().Length != 0)
                agaza_MEMEO = String.Format("N'{0}'", MemoTxt.Text.Trim());
            SqlConnection con = new SqlConnection(Program.MC.SQLConStrMalafat);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                con.Open();
                cmd.CommandText = string.Format("INSERT INTO EMP_agazat (EmpID, agaza_type_code, agaza_st_date, agaza_end_date, agaza_MEMEO) VALUES ({0}, {1}, {2}, {3}, {4})", EmpID, agaza_type_code, agaza_st_date, agaza_end_date, agaza_MEMEO);
                cmd.ExecuteNonQuery();
                ClearForm();
                MessageBox.Show("تم اضافه الاجازه للموظف","تمت العمليه",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message,ex.ErrorCode.ToString(),MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            con.Close();
        }
        private void repositoryItemButtonEditDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gridViewAgaza.SelectedRowsCount == 0)
                return;
            if (MessageBox.Show("هل ترغب في الاستمرار؟", "تأكــــيد", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            string EmpID = "NULL", agaza_st_date = "NULL";
            if (AgazatTbl.Rows[gridViewAgaza.GetFocusedDataSourceRowIndex()]["EmpID"] != null)
                EmpID = AgazatTbl.Rows[gridViewAgaza.GetFocusedDataSourceRowIndex()]["EmpID"].ToString();
            if (AgazatTbl.Rows[gridViewAgaza.GetFocusedDataSourceRowIndex()]["agaza_st_date"] != null)
                agaza_st_date = String.Format("CONVERT(DATETIME, '{0}', 103)", AgazatTbl.Rows[gridViewAgaza.GetFocusedDataSourceRowIndex()]["agaza_st_date"]);
            SqlConnection con = new SqlConnection(Program.MC.SQLConStrMalafat);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                con.Open();
                cmd.CommandText = string.Format("DELETE FROM EMP_agazat WHERE (EmpID = {0}) AND (agaza_st_date = {1})", EmpID, agaza_st_date);
                cmd.ExecuteNonQuery();
                LoadData();
                MessageBox.Show("تم حذف الاجازه للموظف", "تمت العمليه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.ErrorCode.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
    }
}