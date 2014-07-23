using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace E_Club_Store_Manager
{
    public partial class EditorYearFrm : DevExpress.XtraEditors.XtraForm
    {
        DataTable YearTbl = new DataTable("");

        public EditorYearFrm()
        {
            InitializeComponent();
        }

        private void EditorYearFrm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            YearTbl = new DataTable("");
            YearTbl = Program.MC.LoadDataTable("SELECT YearID, YearName, YStartDate, YEndDate FROM CDYeras");
            LUEYear.Properties.DataSource = YearTbl;
            LUEYear.Properties.DisplayMember = "YearName";
            LUEYear.Properties.ValueMember = "YearID";
        }
        private void LUEYear_EditValueChanged(object sender, EventArgs e)
        {
            if (LUEYear.ItemIndex != -1)
                BtnDelete.Enabled = true;
            else
                BtnDelete.Enabled = false;
        }
        private void TxtNewYear_EditValueChanged(object sender, EventArgs e)
        {
            if (TxtNewYear.Text.Trim().Length == 0)
                BtnAdd.Enabled = false;
            else
                BtnAdd.Enabled = true;
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            bool ReturnMe = false;
            ReturnMe= MCls.DeleteRow("CDYeras", "YearID", LUEYear.EditValue.ToString());
            if (ReturnMe)
            {
                LoadData();
                MessageBox.Show("تم حذف السنه","تمت العمليه",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string YStartDate;
            string YEndDate;
            if (DEStart.EditValue != null)
                YStartDate = string.Format("Convert(Datetime, '{0}', 103)", DEStart.EditValue.ToString());
            else
                YStartDate = "NULL";
            if (DEEnd.EditValue != null)
                YEndDate = string.Format("Convert(Datetime, '{0}', 103)", DEEnd.EditValue.ToString());
            else
                YEndDate = "NULL";
            SqlConnection Con = new SqlConnection(Program.MC.SQLConStrG_Accounts);
            SqlCommand Cmd = new SqlCommand(String.Format("INSERT INTO CDYeras (YearID, YearName, YStartDate, YEndDate) VALUES ({0}, '{1}', {2}, {3})", MCls.GetNewID("CDYeras", "YearID"), TxtNewYear.Text.Trim(), YStartDate, YEndDate), Con);
            try
            {
                Con.Open();
                Cmd.ExecuteNonQuery();
                LoadData();
                MessageBox.Show("تم اضافه السنـــه", "تمت العمليه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.ErrorCode.ToString(),MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            Con.Close();
        }
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}