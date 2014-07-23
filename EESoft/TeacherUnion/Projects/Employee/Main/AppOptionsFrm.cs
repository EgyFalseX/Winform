using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace Employee
{
    public partial class AppOptionsFrm : DevExpress.XtraEditors.XtraForm
    {

        #region -   Variables   -

#endregion
        #region -   Functions   -
        public AppOptionsFrm()
        {
            InitializeComponent();
        }
     
        #endregion
        #region - Event Handlers -
        private void AppOptionsFrm_Load(object sender, EventArgs e)
        {
            DataRow row = FXFW.SqlDB.LoadDataTable("Select SchoolLogo From AppOptions Where OpCodeID = 1").Rows[0];
            // Load Pic
            if (DBNull.Value != row["SchoolLogo"])
            {
                System.IO.MemoryStream stream = new System.IO.MemoryStream();
                byte[] MemPic = (byte[])row["SchoolLogo"];
                System.IO.MemoryStream ms = new System.IO.MemoryStream(MemPic);
                PBImage.Image = Image.FromStream(ms);
            }
            else
                PBImage.Image = null;
        }
        private void BtnChangePic_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            if (OFD.ShowDialog() == System.Windows.Forms.DialogResult.No)
                return;
            PBImage.ImageLocation = OFD.FileName;

            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                cmd.CommandText = @"Update AppOptions Set SchoolLogo = @SchoolLogo Where OpCodeID = 1";
                byte[] SchoolLogo = null;
                if (PBImage.ImageLocation != string.Empty)
                {
                    SchoolLogo = System.IO.File.ReadAllBytes(PBImage.ImageLocation);
                    cmd.Parameters.AddWithValue("@SchoolLogo", SchoolLogo);
                }
                else
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    global::Employee.Properties.Resources.NoImg.Save(ms, global::Employee.Properties.Resources.NoImg.RawFormat);
                    SchoolLogo = ms.GetBuffer();
                    cmd.Parameters.AddWithValue("@SchoolLogo", SchoolLogo);
                }
                con.Open();
                cmd.ExecuteNonQuery();
                Program.ShowMsg("تم حفظ الصوره", false, this);
                Program.Logger.LogThis("تم حفظ الصوره", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
            con.Close();
        }
        private void BtnDBMange_Click(object sender, EventArgs e)
        {
            DatabaseManagerFrm FrmDatabaseManager = new DatabaseManagerFrm();
            FrmDatabaseManager.ShowDialog();
        }
        #endregion         #region -   Variables   -

        

    }
}