using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;
using System.IO;
using System.Data;
using FunctionLib;

namespace DataCenter_Server
{
	public partial class EditFileTypesFrm
	{
		public EditFileTypesFrm()
		{
			InitializeComponent();
		}
        private string ErrorProvider;
		//private int Int1;
        //private bool IconPathChaned;
        private bool MadeChanges;
        DataTable TypesTB = new DataTable();
        private void LoadTypes()
        {
            TypesTB = MCls.LoadDataTable("Select TypeID, TypeName, TypeDic, TypeExt, TypeIconData From FileType", "");
            CBTypes.DataSource = TypesTB;
            CBTypes.DisplayMember = "TypeName";
            CBTypes.ValueMember = "TypeID";
        }
        public void EditFileTypesFrm_Load(Object sender, EventArgs e)
        {
            LoadTypes();
            if (TypesTB.Rows.Count == 0)
            {
                MCls.msg("لا يوجد انواع", true, "", this);
                return;
            }
        }
        public void EditFileTypesFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MadeChanges == true)
            {
                MainModule.FrmMainForm.AppCantExit = true;
                MainModule.FrmMainForm.Close();
                MainModule.FrmMainForm = new MainForm();
                MainModule.FrmMainForm.Show();
            }
        }
        public void CBTypes_SelectedIndexChanged(Object sender, EventArgs e)
        {
            if (CBTypes.SelectedIndex != -1)
            {
                TxtName.Text = TypesTB.Rows[CBTypes.SelectedIndex]["TypeName"].ToString();
                TxtDes.Text = TypesTB.Rows[CBTypes.SelectedIndex]["TypeDic"].ToString();
                TxtExt.Text = TypesTB.Rows[CBTypes.SelectedIndex]["TypeExt"].ToString();
                LblIconPath.Text = "لا يوجد";
                BtnSave.Enabled = true;
                BtnDelete.Enabled = true;
            }
            else
            {
                BtnSave.Enabled = false;
                BtnDelete.Enabled = false;
            }
        }
        public void BtnIcon_Click(Object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog() { Filter = "All Files (*.*)|*.*", CheckFileExists = true, CheckPathExists = true };
            FileInfo FileInf;
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                FileInf = new FileInfo(OFD.FileName);
                if ((int)(FileInf.Length / 1048576) >= 1)
                    MainModule.MsgBox_("الملف اكبر من 1 ميجا", 95, 23, false, this);
                else
                {
                    LblIconPath.Text = OFD.FileName;
                }
            }
            else
            {
                LblIconPath.Text = "لا يوجد";
            }
        }
        public void BtnClose_Click(Object sender, EventArgs e)
        {
            Close();
        }
        public void BtnSave_Click(Object sender, EventArgs e)
        {
            if (CBTypes.SelectedIndex == -1)
                return;
            if (TypesTB.Rows[CBTypes.SelectedIndex]["TypeID"].ToString() == "1")
            {
                MainModule.MsgBox_("لا يمكن تعديل هذا النوع" + " (MDC) ", 63, 23, false, this);
                return;
            }
            string Result = string.Empty;
            if (LblIconPath.Text != "لا يوجد")
                Result = MainModule.FunLib.UpdateFileType(MainModule.FunLib.AllFilesType[CBTypes.SelectedIndex].TypeID, TxtName.Text.Trim(), File.ReadAllBytes(LblIconPath.Text), TxtDes.Text.Trim(), TxtExt.Text.Trim());
            else
                Result = MainModule.FunLib.UpdateFileType(MainModule.FunLib.AllFilesType[CBTypes.SelectedIndex].TypeID, TxtName.Text.Trim(), new byte[0], TxtDes.Text.Trim(), TxtExt.Text.Trim());
            MadeChanges = true;
            if (Result == null)
            {
                //rebuild the FileType array
                MainModule.FrmMainForm.LoadGeneralIcons();
                MainModule.FrmMainForm.LoadFoldersRoot();
                MainModule.FrmMainForm.RelaodFilesInListView();
                MainModule.MsgBox_("تم التعديل", 134, 23, true, this);
                LoadTypes();
                TxtName.Focus();
            }
            else
                MainModule.MsgBox_(Result, 0, 23, false, this);
        }
        public void BtnDelete_Click(Object sender, EventArgs e)
        {
            if (Interaction.MsgBox("هل انت متأكد؟", MsgBoxStyle.YesNo, "تحزير") == MsgBoxResult.No)
                return;
            if (TypesTB.Rows[CBTypes.SelectedIndex]["TypeID"].ToString() == "1")
            {
                MainModule.MsgBox_("لا يمكن حذف هذا النوع" + " (MDC) ", 63, 23, false, this);
                return;
            }
            MadeChanges = true;
            ErrorProvider = null;
            ErrorProvider = MainModule.FunLib.DeleteFileType(TypesTB.Rows[CBTypes.SelectedIndex]["TypeID"].ToString());
            if (ErrorProvider == null)
            {
                if (LblIconPath.Text != "")
                {
                    if (File.Exists(LblIconPath.Text))
                        File.Delete(LblIconPath.Text);
                }
                TxtDes.Clear();
                TxtExt.Clear();
                TxtName.Clear();
                LblIconPath.Text = "لا يوجد";
                MainModule.FrmMainForm.LoadGeneralIcons();
                MainModule.FrmMainForm.LoadFoldersRoot();
                MainModule.FrmMainForm.RelaodFilesInListView();
                MainModule.MsgBox_("تم الحذف", 138, 23, true, this);
                LoadTypes();
            }
            else
                MainModule.MsgBox_(ErrorProvider, 0, 23, false, this);
        }
		}
	}
