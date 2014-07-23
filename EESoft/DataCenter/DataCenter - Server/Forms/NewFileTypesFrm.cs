using System.Windows.Forms;
using Microsoft.VisualBasic;
using System;
using System.IO;
using FunctionLib;
using System.Data.SqlClient;
using My.Resources;

namespace DataCenter_Server
{
	public partial class NewFileTypesFrm
	{
		public NewFileTypesFrm()
		{
			InitializeComponent();
		}
		private bool MadeChanges;

        public void BtnIcon_Click(Object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            System.IO.FileInfo FileInf;
            OFD.Filter = "All Files (*.*)|*.*";
            OFD.CheckFileExists = true;
            OFD.CheckPathExists = true;
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                FileInf = new System.IO.FileInfo(OFD.FileName);
                if ((int)(FileInf.Length / 1048576) > 1)
                    MainModule.MsgBox_("الملف اكبر من 1 ميجا", 95, 23, false, this);
                else
                    LblIconPath.Text = OFD.FileName;
            }
            else
                LblIconPath.Text = "لايوجد";
        }
        public void BtnClose_Click(Object sender, EventArgs e)
        {
            Close();
        }
        public void TxtName_TextChanged(Object sender, EventArgs e)
        {
            if (TxtName.Text.Trim().Length > 0 && TxtExt.Text.Trim().Length > 0)
                BtnSave.Enabled = true;
            else
                BtnSave.Enabled = false;
        }
        public void TxtExt_TextChanged(Object sender, EventArgs e)
        {
            if (TxtName.Text.Trim().Length > 0 && TxtExt.Text.Trim().Length > 0)
                BtnSave.Enabled = true;
            else
                BtnSave.Enabled = false;
        }
        public void BtnSave_Click(Object sender, EventArgs e)
        {
            //Checking for icon path is selected or not
            if (TxtName.Text.Trim().Length == 0 || TxtDes.Text.Trim().Length == 0 || TxtExt.Text.Trim().Length == 0)
            {
                MCls.msg("من فضلك اكمل البيانات", true, "", this);
                return;
            }
            string Result = string.Empty;
            SqlConnection con = new SqlConnection(MCls.SQLConStr);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                string TypeID = MCls.GetNewID("FileType", "TypeID");
                byte[] TypeIconData = null;
                cmd.CommandText = string.Format("Insert Into FileType (TypeID, TypeName, TypeDic, TypeExt, TypeIconData) VALUES (N'{0}', N'{1}', N'{2}', N'{3}', @TypeIconData)",
                TypeID, TxtName.Text.Trim(), TxtDes.Text.Trim(), TxtExt.Text.Trim());
                if (LblIconPath.Text != "لايوجد")
                {
                    TypeIconData = File.ReadAllBytes(LblIconPath.Text);
                    cmd.Parameters.AddWithValue("@TypeIconData", TypeIconData);
                }
                else
                {
                    MemoryStream ms = new MemoryStream();
                    Resources.Default_.Save(ms, Resources.Default_.RawFormat);
                    TypeIconData = ms.GetBuffer();
                    cmd.Parameters.AddWithValue("@TypeIconData", TypeIconData);
                }
                
                con.Open();
                cmd.ExecuteNonQuery();
                MainModule.MsgBox_("تم الحفظ", 125, 23, true, this);
                TxtName.Clear();
                TxtExt.Clear();
                TxtDes.Clear();
                LblIconPath.Text = "لايوجد";
                MadeChanges = true;
                TxtName.Focus();
            }
            catch (SqlException ex)
            {
                MCls.msg(MCls.CheckExp(ex), true, ex.Number.ToString(), this);
            }
            con.Close();
            //MemoryStream stream = new MemoryStream();
            //byte[] MemPic = (byte[])row["MemPic"];
            //MemoryStream ms = new MemoryStream(MemPic);
            //PBMemPhotoEdit.Image = Image.FromStream(ms);
        }
        public void NewFileTypesFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MadeChanges == true)
            {
                MainModule.FrmMainForm.AppCantExit = true;
                MainModule.FrmMainForm.Close();
                MainModule.FrmMainForm = new MainForm();
                MainModule.FrmMainForm.Show();
            }
        }
    }
}
