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
    public partial class EditorEmpStateFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        DataTable EmpStatesTbl = new DataTable("EmpStates");
        #endregion
        #region -   Functions   -
        private void LoadData()
        {
            EmpStatesTbl = new DataTable("EmpStates");
            EmpStatesTbl = Program.MC.LoadDataTable("SELECT JOB_STATUS_ID, JOB_STATUS_NAME FROM CDR_JOB_STATUS", Program.MC.SQLConStrMalafat);
            LUEEmpState.Properties.DataSource = EmpStatesTbl;
            LUEEmpState.Properties.DisplayMember = "JOB_STATUS_NAME";
            LUEEmpState.Properties.ValueMember = "JOB_STATUS_ID";
        }
        public EditorEmpStateFrm()
        {
            InitializeComponent();
        }
        #endregion
        #region -   Event Handlers   -
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل ترغب في الاستمرار؟", "تأكــــيد", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }
            using (SqlConnection Con = new SqlConnection(Program.MC.SQLConStrMalafat))
            {
                SqlCommand Cmd = new SqlCommand(String.Format("DELETE FROM CDR_JOB_STATUS WHERE (JOB_STATUS_ID = {0})", LUEEmpState.EditValue), Con);
                try
                {
                    Con.Open();
                    Cmd.ExecuteNonQuery();
                    LoadData();
                    LUEEmpState.ItemIndex = -1;
                    MessageBox.Show("تم الحـــذف ", "حـــــذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection Con = new SqlConnection(Program.MC.SQLConStrMalafat))
            {
                SqlCommand Cmd = new SqlCommand(String.Format("INSERT INTO CDR_JOB_STATUS  (JOB_STATUS_NAME) VALUES (N'{0}')", TxtNewEmpState.Text.Trim()), Con);
                try
                {
                    Con.Open();
                    Cmd.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("تم الاضــــافه", "اضافــــه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection Con = new SqlConnection(Program.MC.SQLConStrMalafat))
            {
                SqlCommand Cmd = new SqlCommand(String.Format("UPDATE CDR_JOB_STATUS SET JOB_STATUS_NAME = N'{0}' WHERE (JOB_STATUS_ID = {1})", TxtEditEmpState.Text.Trim(), LUEEmpState.EditValue), Con);
                try
                {
                    Con.Open();
                    Cmd.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("تم التعــــديل ", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void TxtNewEmpState_EditValueChanged(object sender, EventArgs e)
        {
            if (TxtNewEmpState.Text.Trim().Length > 0)
                BtnAdd.Enabled = true;
            else
                BtnAdd.Enabled = false;
        }
        private void TxtEditEmpState_EditValueChanged(object sender, EventArgs e)
        {
            if (TxtEditEmpState.Text.Trim().Length > 0 && LUEEmpState.ItemIndex > -1)
                BtnUpdate.Enabled = true;
            else
                BtnUpdate.Enabled = false;
        }
        private void LUEEmpState_EditValueChanged(object sender, EventArgs e)
        {
            if (LUEEmpState.ItemIndex > -1)
            {
                TxtEditEmpState.Text = LUEEmpState.Text;
                BtnUpdate.Enabled = true;
                BtnDelete.Enabled = true;
            }
            else
            {
                TxtEditEmpState.Text = string.Empty;
                BtnUpdate.Enabled = false;
                BtnDelete.Enabled = false;
            }
        }
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void EditorEmpStateFrm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        #endregion
    }
}