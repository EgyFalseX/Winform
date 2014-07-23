using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Imaging;

namespace DatabaseImageEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program.SqlConStr);
            SqlCommand Selectcmd = new SqlCommand("", con);
            SqlDataReader dr;
            try
            {
                con.Open();
                Selectcmd.CommandText = string.Format(@"SELECT COUNT(*) FROM {0}", tbTable.Text);
                object count = Selectcmd.ExecuteScalar();

                if (!Program.IsNullOrEmpty(count))
                {
                    lblRows.Text = count.ToString();
                    pb.Maximum = (int)count;
                    pb.Minimum = 0;
                    groupBoxProgress.Visible = true;
                    btnSave.Enabled = false;
                }

                Selectcmd.CommandText = string.Format(@"SELECT {0}, {1}, {2} FROM {3}", tbColumn.Text, tbPK.Text, tbFileName.Text, tbTable.Text);

                dr = Selectcmd.ExecuteReader();
                
                while (dr.Read())
                {
                    pb.Value++;
                    Application.DoEvents();
                    if (!Program.IsNullOrEmpty(dr.GetValue(0)))
                    {
                        byte[] byt = (byte[])dr.GetValue(0);
                        MemoryStream stm = new MemoryStream(byt, 0, byt.Length);
                        Image img = Image.FromStream(stm, true);
                        img.Save(String.Format("{0}\\{1}.Jpg", lblPath.Text, dr.GetValue(2)), ImageFormat.Jpeg);
                    }
                }
                MessageBox.Show("Done ...!", "Complate", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            con.Dispose();

            pb.Minimum = 0;
            groupBoxProgress.Visible = false;
            btnSave.Enabled = true;
            
        }

        private byte[] ConvertThis(byte[] byt, int w, int h)
        {
            MemoryStream stm = new MemoryStream(byt, 0 , byt.Length);
            Image img = Image.FromStream(stm, true);

            Image myimg = img.GetThumbnailImage(w, h, null, IntPtr.Zero);
            
            MemoryStream ms = new MemoryStream();
            img.Save(ms, ImageFormat.Jpeg);
            return ms.GetBuffer();
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
            {
                btnSave.Visible = false;
                return;
            }
            lblPath.Text = fbd.SelectedPath;
            btnSave.Visible = true;
        }
    }
}
