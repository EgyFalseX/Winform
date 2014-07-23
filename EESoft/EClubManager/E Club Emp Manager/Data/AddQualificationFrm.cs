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
    public partial class AddQualificationFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        DataTable DgreesTbl = new DataTable("Dgrees");
        DataTable SpecialtyTypesTBL = new DataTable("SpecialtyTypes");
        DataTable EmployeesTbl = new DataTable("Employees");
        DataTable QuaTbl = new DataTable("Qua");
        DataTable EmpDataTbl = new DataTable("EmpData");
        #endregion
        #region -   Functions   -
        private void LoadSpecialtyTypes(string Moaahel_ID)
        {
            //تخصص المؤهل
            SpecialtyTypesTBL = new DataTable("SpecialtyTypes");
            SpecialtyTypesTBL = Program.MC.LoadDataTable(String.Format("SELECT SPECIFICATION_ID, SPECIFICATION_NAME FROM CDR_SPECIFICATION WHERE (Moaahel_ID = {0})", Moaahel_ID), Program.MC.SQLConStrMalafat);
            LUESpec.Properties.DataSource = SpecialtyTypesTBL;
            LUESpec.Properties.DisplayMember = "SPECIFICATION_NAME";
            LUESpec.Properties.ValueMember = "SPECIFICATION_ID";
        }
        private void LoadData()
        {
            EmployeesTbl = new DataTable("Employees");
            QuaTbl = new DataTable("Qua");
            DgreesTbl = new DataTable("Dgrees");

            EmployeesTbl = Program.MC.LoadDataTable("SELECT EmpID, Emp_Full_Name FROM Emp_Master", Program.MC.SQLConStrMalafat);
            LUEEmployees.Properties.DataSource = EmployeesTbl;
            LUEEmployees.Properties.DisplayMember = "Emp_Full_Name";
            LUEEmployees.Properties.ValueMember = "EmpID";

            QuaTbl = Program.MC.LoadDataTable("SELECT Moaahel_ID, Moaahel_Name FROM CD_Moaahel", Program.MC.SQLConStrMalafat);
            LUEQua.Properties.DataSource = QuaTbl;
            LUEQua.Properties.DisplayMember = "Moaahel_Name";
            LUEQua.Properties.ValueMember = "Moaahel_ID";

            DgreesTbl = Program.MC.LoadDataTable("SELECT takdeer_code, takdeer_name FROM CD_Takdeer", Program.MC.SQLConStrMalafat);
            LUEDgree.Properties.DataSource = DgreesTbl;
            LUEDgree.Properties.DisplayMember = "takdeer_name";
            LUEDgree.Properties.ValueMember = "takdeer_code";
        }
        public AddQualificationFrm()
        {
            InitializeComponent();
        }
        private void LoadEmpQua()
        {
            EmpDataTbl = new DataTable("EmpData");
            if (LUEEmployees.ItemIndex > -1)
                EmpDataTbl = Program.MC.LoadDataTable(String.Format("SELECT Emp_ID, (SELECT Emp_Full_Name FROM Emp_Master WHERE (EmpID = Emp_Moaahel.Emp_ID)) AS Emp_Name, Moaahel_ID, (SELECT Moaahel_Name FROM CD_Moaahel WHERE (Moaahel_ID = Emp_Moaahel.Moaahel_ID)) AS Moaahel_Name, (SELECT SPECIFICATION_NAME FROM CDR_SPECIFICATION WHERE (SPECIFICATION_ID = Emp_Moaahel.SPECIFICATION_ID)) AS Spec_Name, Moaahel_Dat FROM Emp_Moaahel WHERE (Emp_ID = {0})", LUEEmployees.EditValue), Program.MC.SQLConStrMalafat);
            DGVAddQua.DataSource = EmpDataTbl;
        }
        #endregion
       #region -   Event Handlers   -

       private void DGVAddQua_CellContentClick(object sender, DataGridViewCellEventArgs e)
       {
           if (e.ColumnIndex == 0 && e.RowIndex > -1)
           {
               if (MessageBox.Show("هل تريد ان تحذف هذا المؤهل ؟","حــــذف",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
               {
                   string Emp_ID;
                   if (EmpDataTbl.Rows[e.RowIndex]["Emp_ID"].ToString() != string.Empty)
                       Emp_ID = EmpDataTbl.Rows[e.RowIndex]["Emp_ID"].ToString();
                   else
                       Emp_ID = "NULL";

                   
                   string Moaahel_ID;
                   if (EmpDataTbl.Rows[e.RowIndex]["Moaahel_ID"].ToString() != string.Empty)
                       Moaahel_ID = EmpDataTbl.Rows[e.RowIndex]["Moaahel_ID"].ToString();
                   else
                       Moaahel_ID = "NULL";

                   using (SqlConnection Con = new SqlConnection(Program.MC.SQLConStrMalafat))
                   {
                       SqlCommand Cmd = new SqlCommand(String.Format("DELETE FROM Emp_Moaahel WHERE (Emp_ID = {0}) AND (Moaahel_ID = {1})", Emp_ID, Moaahel_ID), Con);
                       try
                       {
                           Con.Open();
                           Cmd.ExecuteNonQuery();
                           LoadEmpQua();
                           MessageBox.Show("تم حـــذف المؤهل", "تم الحــذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       }
                       catch (Exception ex)
                       {
                           MessageBox.Show(ex.Message);
                       }
                       Con.Close();
                   }
               }
           }
       }
       private void BtnAddQua_Click(object sender, EventArgs e)
       {
            string Emp_ID;
            if (LUEEmployees.ItemIndex != -1)
                Emp_ID = LUEEmployees.EditValue.ToString();
            else
                Emp_ID = "NULL";

            string Moaahel_ID;
            if (LUEQua.ItemIndex != -1)
                Moaahel_ID = LUEQua.EditValue.ToString();
            else
                Moaahel_ID = "NULL";

            string SPECIFICATION_ID;
            if (LUESpec.ItemIndex != -1)
                SPECIFICATION_ID = LUESpec.EditValue.ToString();
            else
                SPECIFICATION_ID = "NULL";

            string takdeer_code;
            if (LUEDgree.ItemIndex != -1)
                takdeer_code = LUEDgree.EditValue.ToString();
            else
                takdeer_code = "NULL";

            string Moaahel_Dat;
            if (DEDate.Text.Trim().Length != 0)
                Moaahel_Dat = String.Format("Convert(Datetime, '{0}', 103)", DEDate.Text);
            else
                Moaahel_Dat = "NULL";

            using (SqlConnection Con = new SqlConnection(Program.MC.SQLConStrMalafat))
            {
                SqlCommand Cmd = new SqlCommand(string.Format("INSERT INTO Emp_Moaahel (Emp_ID, Moaahel_ID, SPECIFICATION_ID, Moaahel_Dat, takdeer_code) VALUES ({0}, {1}, {2}, {3}, {4})", Emp_ID, Moaahel_ID, SPECIFICATION_ID, Moaahel_Dat, takdeer_code), Con);
                try
                {
                    Con.Open();
                    Cmd.ExecuteNonQuery();
                    LUEEmployees.Focus();
                    LoadEmpQua();
                    MessageBox.Show("تم اضافــة المؤهل", "تم الاضافـــه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Con.Close();
            }
       }
       private void LUEEmployees_EditValueChanged(object sender, EventArgs e)
       {
           LoadEmpQua();
       }
       private void AddQualificationFrm_Load(object sender, EventArgs e)
       {
           LoadData();
       }
       private void LUEQua_EditValueChanged(object sender, EventArgs e)
        {
           {
                if (LUEQua.ItemIndex > -1)
                    LoadSpecialtyTypes(QuaTbl.Rows[LUEQua.ItemIndex]["Moaahel_ID"].ToString());
                else
                    LUEQua.ItemIndex = -1;
            }
        }
       #endregion
    }
}