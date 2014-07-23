using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace schoolStore
{
    public partial class ImportStudentFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        string constr = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source= ";
        #endregion
        #region -   Functions   -
        public ImportStudentFrm()
        {
            InitializeComponent();
        }
        private void ShowDBInfo(string dbPath)
        {
            string connectionstring = String.Format("{0}\"{1}\"", constr, dbPath);
            using (OleDbDataAdapter da = new OleDbDataAdapter(@"SELECT COUNT(*) AS studentcount, (select max(asase_code) from student_t) AS maxcode FROM student_t Where asase_code = (select max(asase_code) from student_t)", connectionstring))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    lblcode.Text = dt.Rows[0]["maxcode"].ToString();
                    lblCount.Text = dt.Rows[0]["studentcount"].ToString();
                }
                else
                {
                    lblcode.Text = string.Empty;
                    lblCount.Text = "0";
                }
            }
        }
        private void ImportData(string dbPath)
        {
            string connectionstring = String.Format("{0}\"{1}\"", constr, dbPath);
            OleDbDataAdapter da = new OleDbDataAdapter(@"", connectionstring);
            da.SelectCommand.CommandText = @"SELECT stu_code, asase_code, alsofof_code, fasl_code,
            (Select stu_name from student where stu_code = student_t.stu_code) as stu_name,
            (Select waleaalkamr_mobile from student where stu_code = student_t.stu_code) as waleaalkamr_mobile
            FROM student_t
            Where asase_code = (select max(asase_code) from student_t)";
            DataTable dt = new System.Data.DataTable();
            try
            {
                da.Fill(dt);
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            SqlTransaction trn = null;
            cmd.CommandText = @"IF NOT EXISTS(SELECT stu_code FROM student WHERE stu_code = @org_stu_code)
                                INSERT INTO dbo.student
                                ( stu_code ,
                                  asase_code ,
                                  stu_name ,
                                  alsofof_code ,
                                  fasl_code ,
                                  waleaalkamr_mobile ,
                                  entrystore ,
                                  editstore
                                )
                        VALUES  ( @stu_code , -- stu_code - int
                                  @asase_code , -- asase_code - int
                                  @stu_name , -- stu_name - nvarchar(50)
                                  @alsofof_code , -- alsofof_code - int
                                  @fasl_code , -- fasl_code - int
                                  @waleaalkamr_mobile , -- waleaalkamr_mobile - nvarchar(50)
                                  @entrystore , -- entrystore - bit
                                  @editstore  -- editstore - bit 
                                )";
            cmd.Parameters.Add("@org_stu_code", System.Data.SqlDbType.Int);
            cmd.Parameters.Add("@stu_code", System.Data.SqlDbType.Int);
            cmd.Parameters.Add("@asase_code", System.Data.SqlDbType.Int);
            cmd.Parameters.Add("@stu_name", System.Data.SqlDbType.NVarChar);
            cmd.Parameters.Add("@alsofof_code", System.Data.SqlDbType.Int);
            cmd.Parameters.Add("@fasl_code", System.Data.SqlDbType.Int);
            cmd.Parameters.Add("@waleaalkamr_mobile", System.Data.SqlDbType.NVarChar);
            cmd.Parameters.Add("@entrystore", System.Data.SqlDbType.Bit);
            cmd.Parameters.Add("@editstore", System.Data.SqlDbType.Bit);
            try
            {
                con.Open();
                trn = con.BeginTransaction();
                cmd.Transaction = trn;
                pbc.Properties.Maximum = dt.Rows.Count;
                pbc.Properties.Minimum = 0;
                foreach (DataRow row in dt.Rows)
                {
                    cmd.Parameters["@org_stu_code"].Value = row["stu_code"].ToString();

                    cmd.Parameters["@stu_name"].Value = row["stu_name"].ToString();
                    cmd.Parameters["@waleaalkamr_mobile"].Value = row["waleaalkamr_mobile"].ToString();
                    cmd.Parameters["@entrystore"].Value = false;
                    cmd.Parameters["@editstore"].Value = false;

                    if (row["stu_code"].ToString() == string.Empty)
                        cmd.Parameters["@stu_code"].Value = DBNull.Value;
                    else
                        cmd.Parameters["@stu_code"].Value = row["stu_code"].ToString();
                    if (row["asase_code"].ToString() == string.Empty)
                        cmd.Parameters["@asase_code"].Value = DBNull.Value;
                    else
                        cmd.Parameters["@asase_code"].Value = row["asase_code"].ToString();
                    if (row["alsofof_code"].ToString() == string.Empty)
                        cmd.Parameters["@alsofof_code"].Value = DBNull.Value;
                    else
                        cmd.Parameters["@alsofof_code"].Value = row["alsofof_code"].ToString();
                    if (row["fasl_code"].ToString() == string.Empty)
                        cmd.Parameters["@fasl_code"].Value = DBNull.Value;
                    else
                        cmd.Parameters["@fasl_code"].Value = row["fasl_code"].ToString();
                    
                    cmd.ExecuteNonQuery();
                    pbc.EditValue = (int)pbc.EditValue + 1;
                    Application.DoEvents();
                }
                trn.Commit();
                MessageBox.Show("تم الاستيراد", "معلومات", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                trn.Rollback();
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
            pbc.EditValue = 0;
            
        }
        #endregion
        #region -   Event Handlers   -
        private void tbselectdb_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            openFileDialogDB.Filter = "Access database file (*.mdb)|*.mdb|All Files(*.*)|*.*";
            if (openFileDialogDB.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                return;
            ShowDBInfo(openFileDialogDB.FileName);
            tbselectdb.Text = openFileDialogDB.FileName;
        }
        private void btnimport_Click(object sender, EventArgs e)
        {
            if (openFileDialogDB.FileName == string.Empty)
            {
                MessageBox.Show("من فضلك اختار قاعدة بيانات", "معلومات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!System.IO.File.Exists(openFileDialogDB.FileName))
            {
                MessageBox.Show("قاعدة بيانات غير موجوده", "معلومات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            gcmain.Enabled = false;
            btnimport.Enabled = false;
            ImportData(openFileDialogDB.FileName);
            gcmain.Enabled = true;
            btnimport.Enabled = true;
        }
        #endregion
    }
}