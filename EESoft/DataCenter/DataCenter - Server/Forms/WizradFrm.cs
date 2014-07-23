using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;
using System.IO;

namespace DataCenter_Server
{
	public partial class WizradFrm
	{
		public WizradFrm()
		{
			InitializeComponent();
		}
		private short Int1;
		public void WizradFrm_FormClosing(object sender, FormClosingEventArgs e)
		{
			MainModule.FrmMainForm = new MainForm();
			MainModule.FrmMainForm.Show();
        }
		public void BtnCancel_Click(Object sender, EventArgs e)
		{
			this.Close();
		}
		public void TxtName_TextChanged(Object sender, EventArgs e)
		{
			if (TxtName.Text.Trim().Length > 0)
				BtnAdd.Enabled = true;
			else
				BtnAdd.Enabled = false;
            TextBox TB = (TextBox)sender;
            for (Int1 = 0; Int1 <= TB.Text.Trim().Length - 1; Int1++)
			{
                if (!char.IsLetterOrDigit(TB.Text.Trim(), Int1) && TB.Text[Int1].ToString() != "_" && TB.Text[Int1].ToString() != " ")
                {
                    TB.Text = "";
                    //Prepare the Error MSG
                    MainModule.MsgBox_("ãä ÝÖáß ÇÏÎá ÍÑæÝ æ ÇÑÞÇã", 98, 23, false, this);
                    break;
                }
			}
		}
		public void BtnAdd_Click(Object sender, EventArgs e)
		{
			if (Interaction.MsgBox("هل انت متأكد؟", MsgBoxStyle.YesNo, "انشـــــــــاء") == MsgBoxResult.No)
				return;
            string NewFolderErrorResult = MainModule.FunLib.InsertNewFolder(TxtName.Text.Trim(), TxtName.Text.Trim(), DateTime.Now.Date.ToString(), MainModule.AdminID, "", "0");
            if (NewFolderErrorResult != null)
            {
                Directory.CreateDirectory(String.Format("{0}\\{1}", MainModule.ProjectsPath, TxtName.Text.Trim()));
                Close();
            }
		}
		public void TxtLocation_TextChanged(Object sender, EventArgs e)
		{
			if (TxtName.Text.Trim().Length > 0)
				BtnAdd.Enabled = true;
			else
				BtnAdd.Enabled = false;
		}
	}
}
