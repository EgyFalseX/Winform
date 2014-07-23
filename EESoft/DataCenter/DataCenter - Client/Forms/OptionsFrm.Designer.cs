using System.Diagnostics;
using System;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using Microsoft.VisualBasic;
using System.Data;
using System.Collections.Generic;

namespace DataCenter_Client
{
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class OptionsFrm : System.Windows.Forms.Form
		{
		
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]protected override void Dispose(bool disposing)
			{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}
		
		//Required by the Windows Form Designer
		private System.ComponentModel.Container components = null;
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
			{
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsFrm));
                this.TabControl1 = new System.Windows.Forms.TabControl();
                this.ClientOptionTabPage = new System.Windows.Forms.TabPage();
                this.BtnClose2 = new System.Windows.Forms.Button();
                this.BtnSaveClientOptions = new System.Windows.Forms.Button();
                this.TxtPasswordCon = new System.Windows.Forms.TextBox();
                this.TxtPassword = new System.Windows.Forms.TextBox();
                this.Label5 = new System.Windows.Forms.Label();
                this.Label4 = new System.Windows.Forms.Label();
                this.TabControl1.SuspendLayout();
                this.ClientOptionTabPage.SuspendLayout();
                this.SuspendLayout();
                // 
                // TabControl1
                // 
                this.TabControl1.Controls.Add(this.ClientOptionTabPage);
                this.TabControl1.Location = new System.Drawing.Point(12, 12);
                this.TabControl1.Name = "TabControl1";
                this.TabControl1.SelectedIndex = 0;
                this.TabControl1.Size = new System.Drawing.Size(444, 204);
                this.TabControl1.TabIndex = 0;
                // 
                // ClientOptionTabPage
                // 
                this.ClientOptionTabPage.Controls.Add(this.BtnClose2);
                this.ClientOptionTabPage.Controls.Add(this.BtnSaveClientOptions);
                this.ClientOptionTabPage.Controls.Add(this.TxtPasswordCon);
                this.ClientOptionTabPage.Controls.Add(this.TxtPassword);
                this.ClientOptionTabPage.Controls.Add(this.Label5);
                this.ClientOptionTabPage.Controls.Add(this.Label4);
                this.ClientOptionTabPage.Location = new System.Drawing.Point(4, 22);
                this.ClientOptionTabPage.Name = "ClientOptionTabPage";
                this.ClientOptionTabPage.Padding = new System.Windows.Forms.Padding(3);
                this.ClientOptionTabPage.Size = new System.Drawing.Size(436, 178);
                this.ClientOptionTabPage.TabIndex = 1;
                this.ClientOptionTabPage.Text = "خيارات المستخدم";
                this.ClientOptionTabPage.UseVisualStyleBackColor = true;
                // 
                // BtnClose2
                // 
                this.BtnClose2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.BtnClose2.Location = new System.Drawing.Point(274, 89);
                this.BtnClose2.Name = "BtnClose2";
                this.BtnClose2.Size = new System.Drawing.Size(53, 23);
                this.BtnClose2.TabIndex = 4;
                this.BtnClose2.Text = "اغلاق";
                this.BtnClose2.UseVisualStyleBackColor = true;
                // 
                // BtnSaveClientOptions
                // 
                this.BtnSaveClientOptions.Location = new System.Drawing.Point(109, 89);
                this.BtnSaveClientOptions.Name = "BtnSaveClientOptions";
                this.BtnSaveClientOptions.Size = new System.Drawing.Size(159, 23);
                this.BtnSaveClientOptions.TabIndex = 3;
                this.BtnSaveClientOptions.Text = "حفظ";
                this.BtnSaveClientOptions.UseVisualStyleBackColor = true;
                this.BtnSaveClientOptions.Click += new System.EventHandler(this.BtnSaveClientOptions_Click);
                // 
                // TxtPasswordCon
                // 
                this.TxtPasswordCon.Location = new System.Drawing.Point(109, 63);
                this.TxtPasswordCon.MaxLength = 8;
                this.TxtPasswordCon.Name = "TxtPasswordCon";
                this.TxtPasswordCon.PasswordChar = '*';
                this.TxtPasswordCon.Size = new System.Drawing.Size(134, 20);
                this.TxtPasswordCon.TabIndex = 2;
                this.TxtPasswordCon.TextChanged += new System.EventHandler(this.TxtPassword_TextChanged);
                // 
                // TxtPassword
                // 
                this.TxtPassword.Location = new System.Drawing.Point(109, 33);
                this.TxtPassword.MaxLength = 15;
                this.TxtPassword.Name = "TxtPassword";
                this.TxtPassword.PasswordChar = '*';
                this.TxtPassword.Size = new System.Drawing.Size(134, 20);
                this.TxtPassword.TabIndex = 1;
                this.TxtPassword.TextChanged += new System.EventHandler(this.TxtPassword_TextChanged);
                // 
                // Label5
                // 
                this.Label5.AutoSize = true;
                this.Label5.Location = new System.Drawing.Point(249, 66);
                this.Label5.Name = "Label5";
                this.Label5.Size = new System.Drawing.Size(85, 13);
                this.Label5.TabIndex = 15;
                this.Label5.Text = "اعادة كلمة المرور";
                // 
                // Label4
                // 
                this.Label4.AutoSize = true;
                this.Label4.Location = new System.Drawing.Point(270, 36);
                this.Label4.Name = "Label4";
                this.Label4.Size = new System.Drawing.Size(57, 13);
                this.Label4.TabIndex = 15;
                this.Label4.Text = "كلمة المرور";
                // 
                // OptionsFrm
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.BackgroundImage = global::My.Resources.Resources.OptionsFrm;
                this.ClientSize = new System.Drawing.Size(468, 238);
                this.Controls.Add(this.TabControl1);
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
                this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
                this.Name = "OptionsFrm";
                this.ShowInTaskbar = false;
                this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                this.Text = "الخيارات";
                this.TabControl1.ResumeLayout(false);
                this.ClientOptionTabPage.ResumeLayout(false);
                this.ClientOptionTabPage.PerformLayout();
                this.ResumeLayout(false);

		}
		internal System.Windows.Forms.TabControl TabControl1;
		internal System.Windows.Forms.TabPage ClientOptionTabPage;
		internal System.Windows.Forms.TextBox TxtPasswordCon;
		internal System.Windows.Forms.TextBox TxtPassword;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Button BtnClose2;
		internal System.Windows.Forms.Button BtnSaveClientOptions;
	}
	
}
