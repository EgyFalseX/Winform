using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace schoolStore
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
            YearTbl = FXFW.SqlDB.LoadDataTable("SELECT YearID, YearName, YStartDate, YEndDate FROM CDYeras");
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
            ReturnMe= Program.DeleteRow("CDYeras", "YearID", LUEYear.EditValue.ToString());
            if (ReturnMe)
            {
                LoadData();
                MessageBox.Show("تم حذف السنه","تمت العمليه",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string YStartDate = "NULL";
            string YEndDate = "NULL";
            if (DEStart.EditValue != null)
            {
                YStartDate = "'" + FXFW.SqlDB.ConvertToDateDMY(DEStart.EditValue.ToString()) + "'";
            }
            if (DEEnd.EditValue != null)
            {
                YEndDate = "'" + FXFW.SqlDB.ConvertToDateDMY(DEEnd.EditValue.ToString()) + "'";
            }
            SqlConnection Con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand Cmd = new SqlCommand("Set DateFormat dmy INSERT INTO CDYeras (YearID, YearName, YStartDate, YEndDate) VALUES (" + Program.GetNewID("CDYeras", "YearID").ToString() + ", '" + TxtNewYear.Text.Trim() + "', " + YStartDate + ", " + YEndDate + ")", Con);
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