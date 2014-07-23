using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using FunctionLib;
using System.IO;
using My.Resources;

namespace DataCenter_Server
{
    public partial class StuFileTypeFrm : Form
    {
        
        #region -   Variables   -
        DataTable FTypes = new DataTable();
        #endregion
        #region -   Functions   -
        public StuFileTypeFrm()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            FTypes = MCls.LoadDataTable("Select StuFileTypeID, StuFileTypeName, StuFileData From StuFileType", "");
            CBTypes.DataSource = FTypes;
            CBTypes.DisplayMember = "StuFileTypeName";
            CBTypes.ValueMember = "StuFileTypeID";
        }
        #endregion
        #region - Event Handlers-
        private void StuFileTypeFrm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void CBTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBTypes.SelectedIndex != -1)
            {
                TxtName.Text = FTypes.Rows[CBTypes.SelectedIndex]["StuFileTypeName"].ToString();
                MemoryStream stream = new MemoryStream();
                byte[] TypeIconData = (byte[])FTypes.Rows[CBTypes.SelectedIndex]["StuFileData"];
                MemoryStream ms = new MemoryStream(TypeIconData);
                pic.Image = Image.FromStream(ms);
            }
            else
            {
                TxtName.Text = string.Empty;
            }
        }
        private void BtnIcon_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog() { Filter = "All Files (*.*)|*.*", CheckFileExists = true, CheckPathExists = true };
            FileInfo FileInf;
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                FileInf = new FileInfo(OFD.FileName);
                if ((int)(FileInf.Length / 1048576) > 1)
                    MainModule.MsgBox_("الملف اكبر من 1 ميجا", 95, 23, false, this);
                else
                    pic.ImageLocation = OFD.FileName;
            }
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (TxtName.Text.Trim().Length == 0)
            {
                MCls.msg("من فضلك ادخل اسم", true, "", this);
                return;
            }
            SqlConnection con = new SqlConnection(MCls.SQLConStr);
            SqlCommand cmd = new SqlCommand("", con);
            byte[] StuFileData = null;
            string StuFileTypeID = MCls.GetNewID("StuFileType", "StuFileTypeID");
            try
            {
                cmd.CommandText = string.Format("Insert Into StuFileType (StuFileTypeID, StuFileTypeName, StuFileData) VALUES ({0}, N'{1}', @StuFileData)", StuFileTypeID, TxtName.Text.Trim());
                if (pic.ImageLocation != null)
                {
                    StuFileData = File.ReadAllBytes(pic.ImageLocation);
                    cmd.Parameters.AddWithValue("@StuFileData", StuFileData);
                }
                else
                {
                    MemoryStream ms = new MemoryStream();
                    Resources.Default_.Save(ms, Resources.Default_.RawFormat);
                    StuFileData = ms.GetBuffer();
                    ms.Close();
                    cmd.Parameters.AddWithValue("@StuFileData", StuFileData);
                }
                con.Open();
                cmd.ExecuteNonQuery();
                MCls.msg("تم الاضافه", false, "", this);
                TxtName.Clear();
                TxtName.Focus();
                LoadData();
            }
            catch (SqlException ex)
            {
                MCls.msg(MCls.CheckExp(ex), true, ex.Number.ToString(), this);
            }
            con.Close();
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (CBTypes.SelectedIndex == -1 || TxtName.Text.Trim().Length == 0)
            {
                MCls.msg("من فضلك ادخل اسم و اختار نوع", true, "", this);
                return;
            }
            SqlConnection con = new SqlConnection(MCls.SQLConStr);
            SqlCommand cmd = new SqlCommand("", con);
            byte[] StuFileData = null;
            string StuFileTypeID = MCls.GetNewID("StuFileType", "StuFileTypeID");
            try
            {
                if (pic.ImageLocation != null)
                {
                    cmd.CommandText = string.Format("Update StuFileType Set StuFileTypeName = N'{0}', StuFileData = @StuFileData Where StuFileTypeID = {1}", TxtName.Text.Trim(), FTypes.Rows[CBTypes.SelectedIndex]["StuFileTypeID"]);
                    StuFileData = File.ReadAllBytes(pic.ImageLocation);
                    cmd.Parameters.AddWithValue("@StuFileData", StuFileData);
                }
                else
                {
                    cmd.CommandText = string.Format("Update StuFileType Set StuFileTypeName = N'{0}' Where StuFileTypeID = {1}", TxtName.Text.Trim(), FTypes.Rows[CBTypes.SelectedIndex]["StuFileTypeID"]);
                }
                con.Open();
                cmd.ExecuteNonQuery();
                MCls.msg("تم التعديل", false, "", this);
                TxtName.Clear();
                TxtName.Focus();
                LoadData();
            }
            catch (SqlException ex)
            {
                MCls.msg(MCls.CheckExp(ex), true, ex.Number.ToString(), this);
            }
            con.Close();
        }
#endregion
        
    }
}
