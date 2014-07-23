using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System;
using System.IO;

namespace DataCenter_Server
{
	public partial class FilesCheckerFrm
	{
		public FilesCheckerFrm()
		{
			InitializeComponent();
		}
		public ListViewItem[] LVI = new ListViewItem[1];
		public short ForInt;
		public bool AppCantExit;
        public void CBFilter_SelectedIndexChanged(Object sender, EventArgs e)
        {
            if (CBFilter.SelectedIndex == 0)
            {
                int i = LVFolderFile.CheckedItems.Count;
                for (i = LVFolderFile.CheckedItems.Count - 1; i >= 0; i--)
                    LVFolderFile.CheckedItems[i].Remove();
            }
        }
        public void Btnscan_Click(Object sender, EventArgs e)
        {
            Btnscan.Enabled = false;
            LVI = new ListViewItem[1];
            MainModule.FunLib.GetAllFolderFile(MainModule.ProjectsPath);
            if (MainModule.FunLib.FolderFileList.Length == 0)
                PBData.Maximum = 0;
            else
                PBData.Maximum = MainModule.FunLib.FolderFileList.Length - 1;

            LblTotal.Text = MainModule.FunLib.FolderFileList.Length.ToString();
            PBData.Value = 0;
            for (ForInt = 0; ForInt <= MainModule.FunLib.FolderFileList.Length - 1; ForInt++)
            {
                Application.DoEvents();
                LVI[ForInt] = new ListViewItem();
                PBData.Value = ForInt;
                if (ForInt != 0)
                    Lblpercent.Text = Convert.ToString(Convert.ToUInt64((ForInt / Conversion.Val(Convert.ToString(MainModule.FunLib.FolderFileList.Length - 1))) * 100));
                if (MainModule.FunLib.FolderFileList[ForInt].ID.Length > 0)
                {
                    if (MainModule.FunLib.FolderFileList[ForInt].type == FunctionLib.DataCenterServerLib.FolderAndFile.Folder)
                    {
                        if (Directory.Exists(MainModule.FunLib.FolderFileList[ForInt].FilePath))
                        {
                            MainModule.FunLib.FolderFileList[ForInt].Found = true;
                            LVI[ForInt].ForeColor = Color.Green;
                            LVI[ForInt].Checked = true;
                            Lblfound.Text = Convert.ToString((Conversion.Val(Lblfound.Text) + 1));
                        }
                        else
                        {
                            MainModule.FunLib.FolderFileList[ForInt].Found = false;
                            LVI[ForInt].ForeColor = Color.Red;
                            LblNotFound.Text = Convert.ToString((Conversion.Val(LblNotFound.Text) + 1));
                        }
                        LVI[ForInt].Text = (string)(MainModule.FunLib.FolderFileList[ForInt].type.ToString());
                        LVI[ForInt].SubItems.Add(MainModule.FunLib.FolderFileList[ForInt].FilePath);
                        LVI[ForInt].SubItems.Add(MainModule.FunLib.FolderFileList[ForInt].FileName);
                    }
                    else
                    {
                        if (File.Exists((string)(MainModule.FunLib.FolderFileList[ForInt].FilePath)))
                        {
                            MainModule.FunLib.FolderFileList[ForInt].Found = true;
                            LVI[ForInt].ForeColor = Color.Green;
                            LVI[ForInt].Checked = true;
                            Lblfound.Text = Convert.ToString((Conversion.Val(Lblfound.Text) + 1));
                        }
                        else
                        {
                            MainModule.FunLib.FolderFileList[ForInt].Found = false;
                            LVI[ForInt].ForeColor = Color.Red;
                            LblNotFound.Text = Convert.ToString((Conversion.Val(LblNotFound.Text) + 1));
                        }
                        LVI[ForInt].Text = (string)(MainModule.FunLib.FolderFileList[ForInt].type.ToString());
                        LVI[ForInt].SubItems.Add(MainModule.FunLib.FolderFileList[ForInt].FilePath);
                        LVI[ForInt].SubItems.Add(MainModule.FunLib.FolderFileList[ForInt].FileName);
                    }
                    Array.Resize(ref LVI, LVI.Length + 1);
                }
            }
            Array.Resize(ref LVI, LVI.Length - 2 + 1);
            LVFolderFile.Items.AddRange(LVI);
            Btnscan.Enabled = false;
            BtnStart.Enabled = true;
        }
        public void BtnStart_Click(Object sender, EventArgs e)
        {
            MainModule.FunLib.SetRegValue("Done", FunctionLib.DataCenterServerLib.RegKeyValues.DataChacked);
            MainModule.FrmMainForm = new MainForm();
            MainModule.FrmMainForm.Show();
            Hide();
        }
        public void FilesCheckerFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (AppCantExit == false)
                Application.Exit();
        }
	}
}
