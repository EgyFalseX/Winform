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
    public partial class studentFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Functions   -
        public studentFrm()
        {
            InitializeComponent();
        }
        private void LoadDefaultData()
        {
            repositoryItemGridLookUpEditasase_code.DataSource = FXFW.SqlDB.LoadDataTable(@"Select asase_code, asase_year From CD_Asase");
            repositoryItemGridLookUpEditasase_code.DisplayMember = "asase_year";
            repositoryItemGridLookUpEditasase_code.ValueMember = "asase_code";

            repositoryItemGridLookUpEditalsofof_code.DataSource = FXFW.SqlDB.LoadDataTable(@"Select alsofof_code, alsofof_name From CDAlsofof");
            repositoryItemGridLookUpEditalsofof_code.DisplayMember = "alsofof_name";
            repositoryItemGridLookUpEditalsofof_code.ValueMember = "alsofof_code";

            repositoryItemGridLookUpEditfasl_code.DataSource = FXFW.SqlDB.LoadDataTable(@"Select fasl_code, fasl_name From CDEFasl");
            repositoryItemGridLookUpEditfasl_code.DisplayMember = "fasl_name";
            repositoryItemGridLookUpEditfasl_code.ValueMember = "fasl_code";
        }
        private void LoadGrid()
        {
            gridControlData.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT stu_code, asase_code, stu_name, alsofof_code, fasl_code, waleaalkamr_mobile, entrystore, editstore, 
                                                              stu_code AS org_stu_code, asase_code AS org_asase_code FROM student");
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
#endregion
        #region - Event Handlers -
        private void stu_nashatFrm_Load(object sender, EventArgs e)
        {
            //ActivePriv();
            LoadDefaultData();
            LoadGrid();
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            DataRow row = gridViewData.GetFocusedDataRow();
            try
            {
                cmd.Parameters.Add("@stu_code", System.Data.SqlDbType.Int);
                cmd.Parameters.Add("@asase_code", System.Data.SqlDbType.Int);
                cmd.Parameters.Add("@stu_name", System.Data.SqlDbType.NVarChar);
                cmd.Parameters.Add("@alsofof_code", System.Data.SqlDbType.Int);
                cmd.Parameters.Add("@fasl_code", System.Data.SqlDbType.Int);
                cmd.Parameters.Add("@waleaalkamr_mobile", System.Data.SqlDbType.NVarChar);
                

                if (row["org_stu_code"].ToString() == string.Empty)
                {
                    cmd.CommandText = @"INSERT INTO dbo.student
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
                    if (row["stu_code"].ToString() == string.Empty)
                        cmd.Parameters["@stu_code"].Value = Program.GetNewID("student", "stu_code");
                    else
                        cmd.Parameters["@stu_code"].Value = row["stu_code"].ToString();
                    cmd.Parameters.Add("@entrystore", System.Data.SqlDbType.Bit);
                    cmd.Parameters.Add("@editstore", System.Data.SqlDbType.Bit);
                    cmd.Parameters["@entrystore"].Value = true;
                    cmd.Parameters["@editstore"].Value = false;
                }
                else
                {
                    cmd.CommandText = @"UPDATE student SET
			                                        stu_code = @stu_code,	-- stu_code - int
			                                        asase_code = @asase_code,	-- asase_code - int
			                                        stu_name = @stu_name,	-- stu_name - nvarchar(50)
			                                        alsofof_code = @alsofof_code,	-- alsofof_code - int
			                                        fasl_code = @fasl_code,	-- fasl_code - int
			                                        waleaalkamr_mobile = @waleaalkamr_mobile,	-- waleaalkamr_mobile - nvarchar(50)
			                                        editstore = @editstore	-- editstore - bit
                                        WHERE stu_code = @org_stu_code	-- @org_stu_code - int";
                    cmd.Parameters.Add("@org_stu_code", System.Data.SqlDbType.Int);
                    if (row["stu_code"].ToString() == string.Empty)
                        cmd.Parameters["@stu_code"].Value = row["stu_code"].ToString();
                    else
                        cmd.Parameters["@stu_code"].Value = row["stu_code"].ToString();
                    cmd.Parameters["@org_stu_code"].Value = row["org_stu_code"].ToString();
                    cmd.Parameters.Add("@editstore", System.Data.SqlDbType.Bit);
                    cmd.Parameters["@editstore"].Value = true;
                }
                cmd.Parameters["@stu_name"].Value = row["stu_name"].ToString();
                cmd.Parameters["@waleaalkamr_mobile"].Value = row["waleaalkamr_mobile"].ToString();
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

                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("تم الحفــــــــــظ", "تمت العمليه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGrid();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(FXFW.SqlDB.CheckExp(ex), "خطــــاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        private void repositoryItemButtonEditDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            DataRow row = gridViewData.GetFocusedDataRow();
            if (row["org_stu_code"].ToString() == string.Empty)
            {
                LoadGrid();
                return;
            }
            try
            {
                cmd.CommandText = string.Format(@"Delete From student Where stu_code = {0} And asase_code = {1}",
                row["org_stu_code"], row["org_asase_code"]);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("تم الحــــــــذف", "تمت العمليه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGrid();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(FXFW.SqlDB.CheckExp(ex), "خطــــاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

    }
}