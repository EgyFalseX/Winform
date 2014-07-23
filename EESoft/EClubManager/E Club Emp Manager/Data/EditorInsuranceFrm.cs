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
    public partial class EditorInsuranceFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Functions   -
        private void LoadData()
        {
            InsuranceTbl = new DataTable("Insurance");
            InsuranceTbl = Program.MC.LoadDataTable("SELECT EmpID, Emp_Full_Name, tameen_no, tameen_date1, betaka_tameen FROM Emp_Master", Program.MC.SQLConStrMalafat);
            GridControlInsurance.DataSource = InsuranceTbl;
        }
        public EditorInsuranceFrm()
        {
            InitializeComponent();
        }
        #endregion
        #region -   Variables   -
        DataTable InsuranceTbl = new DataTable("Insurance");
        bool TextChanded = false;
        string TextOld = string.Empty;
        string TextNew = string.Empty;
        #endregion
        #region -   Event Handlers   -

        private void repositoryItemTextEdit1_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            TextChanded = true;
            TextNew = e.NewValue.ToString();
        }
        private void repositoryItemTextEdit1_Leave(object sender, EventArgs e)
        {
            if (TextChanded)
            {
                TextChanded = false;
                if (MessageBox.Show("هل ترغب في الاستمرار في تغير هذا الرقم","تعديـــــــل",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                {
                    LoadData();
                    TextNew = string.Empty;
                    return;
                }
                int[] eshta = GridViewInsurance.GetSelectedRows();
                string EmpID = InsuranceTbl.Rows[eshta[0]]["EmpID"].ToString();

                string tameen_no;
                if (TextNew == string.Empty)
                    tameen_no = "NULL";
                else
                    tameen_no = String.Format("N'{0}'", TextNew);
                using (SqlConnection Con = new SqlConnection(Program.MC.SQLConStrMalafat))
                {
                    SqlCommand Cmd = new SqlCommand(String.Format("UPDATE Emp_Master SET tameen_no = {0} WHERE (EmpID = {1})",tameen_no,EmpID), Con);
                    try
                    {
                        Con.Open();
                        Cmd.ExecuteNonQuery();
                        LoadData();
                        MessageBox.Show("تم تعديل التاريخ", "تم التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    Con.Close();
                }
                TextNew = string.Empty;
            }
        }
        private void repositoryItemDateEdit1_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (MessageBox.Show("هل ترغب في الاستمرار في تغير هذا التاريخ","تعديـــــــل",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
            DateEdit DE = (DateEdit)sender;
            
            int[] eshta = GridViewInsurance.GetSelectedRows();
            string EmpID = InsuranceTbl.Rows[eshta[0]]["EmpID"].ToString();
            string tameen_date1;
            if (e.NewValue == null)
                tameen_date1 = "NULL";
            else
                tameen_date1 = String.Format("Convert(Datetime, '{0}', 103)", e.NewValue.ToString());

            using (SqlConnection Con = new SqlConnection(Program.MC.SQLConStrMalafat))
            {
                SqlCommand Cmd = new SqlCommand(String.Format("UPDATE Emp_Master SET tameen_date1 = {0} WHERE (EmpID = {1})", tameen_date1, EmpID), Con);
                try
                {
                    Con.Open();
                    Cmd.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("تم تعديل التاريخ", "تم التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Con.Close();
            }
        }
        private void EditorInsuranceFrm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        #endregion
    }
}