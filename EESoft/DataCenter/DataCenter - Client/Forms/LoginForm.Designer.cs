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
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class LoginForm : System.Windows.Forms.Form
		{
		
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]protected override void Dispose(bool disposing)
			{
			if (disposing)
			{
				if (!(components == null))
				{
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		internal System.Windows.Forms.Label UsernameLabel;
		internal System.Windows.Forms.Label PasswordLabel;
		internal System.Windows.Forms.TextBox UsernameTextBox;
		internal System.Windows.Forms.TextBox PasswordTextBox;
		internal System.Windows.Forms.Button OK;
		internal System.Windows.Forms.Button Cancel;
		
		//Required by the Windows Form Designer
		private System.ComponentModel.Container components = null;
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
			{
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
                this.UsernameLabel = new System.Windows.Forms.Label();
                this.PasswordLabel = new System.Windows.Forms.Label();
                this.UsernameTextBox = new System.Windows.Forms.TextBox();
                this.PasswordTextBox = new System.Windows.Forms.TextBox();
                this.OK = new System.Windows.Forms.Button();
                this.Cancel = new System.Windows.Forms.Button();
                this.Btnresetconnection = new System.Windows.Forms.Button();
                this.SuspendLayout();
                // 
                // UsernameLabel
                // 
                this.UsernameLabel.BackColor = System.Drawing.Color.Transparent;
                this.UsernameLabel.Location = new System.Drawing.Point(172, 24);
                this.UsernameLabel.Name = "UsernameLabel";
                this.UsernameLabel.Size = new System.Drawing.Size(220, 23);
                this.UsernameLabel.TabIndex = 0;
                this.UsernameLabel.Text = "اسم المستخدم";
                this.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                // 
                // PasswordLabel
                // 
                this.PasswordLabel.BackColor = System.Drawing.Color.Transparent;
                this.PasswordLabel.Location = new System.Drawing.Point(172, 81);
                this.PasswordLabel.Name = "PasswordLabel";
                this.PasswordLabel.Size = new System.Drawing.Size(220, 23);
                this.PasswordLabel.TabIndex = 2;
                this.PasswordLabel.Text = "كلمة المرور";
                this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                // 
                // UsernameTextBox
                // 
                this.UsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.UsernameTextBox.Location = new System.Drawing.Point(174, 44);
                this.UsernameTextBox.Name = "UsernameTextBox";
                this.UsernameTextBox.Size = new System.Drawing.Size(220, 20);
                this.UsernameTextBox.TabIndex = 1;
                this.UsernameTextBox.Text = "admin";
                this.UsernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                // 
                // PasswordTextBox
                // 
                this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.PasswordTextBox.Location = new System.Drawing.Point(174, 101);
                this.PasswordTextBox.Name = "PasswordTextBox";
                this.PasswordTextBox.PasswordChar = '*';
                this.PasswordTextBox.Size = new System.Drawing.Size(220, 20);
                this.PasswordTextBox.TabIndex = 3;
                this.PasswordTextBox.Text = "admin";
                this.PasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                // 
                // OK
                // 
                this.OK.Location = new System.Drawing.Point(197, 161);
                this.OK.Name = "OK";
                this.OK.Size = new System.Drawing.Size(94, 23);
                this.OK.TabIndex = 4;
                this.OK.Text = "موافق";
                this.OK.Click += new System.EventHandler(this.OK_Click);
                // 
                // Cancel
                // 
                this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.Cancel.Location = new System.Drawing.Point(300, 161);
                this.Cancel.Name = "Cancel";
                this.Cancel.Size = new System.Drawing.Size(94, 23);
                this.Cancel.TabIndex = 5;
                this.Cancel.Text = "خروج";
                this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
                // 
                // Btnresetconnection
                // 
                this.Btnresetconnection.Location = new System.Drawing.Point(12, 161);
                this.Btnresetconnection.Name = "Btnresetconnection";
                this.Btnresetconnection.Size = new System.Drawing.Size(118, 23);
                this.Btnresetconnection.TabIndex = 6;
                this.Btnresetconnection.Text = "حذف تشكيلة الاتصال";
                this.Btnresetconnection.Click += new System.EventHandler(this.Btnresetconnection_Click);
                // 
                // LoginForm
                // 
                this.AcceptButton = this.OK;
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
                this.CancelButton = this.Cancel;
                this.ClientSize = new System.Drawing.Size(401, 192);
                this.Controls.Add(this.Cancel);
                this.Controls.Add(this.Btnresetconnection);
                this.Controls.Add(this.OK);
                this.Controls.Add(this.PasswordTextBox);
                this.Controls.Add(this.UsernameTextBox);
                this.Controls.Add(this.PasswordLabel);
                this.Controls.Add(this.UsernameLabel);
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
                this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
                this.MaximizeBox = false;
                this.MinimizeBox = false;
                this.Name = "LoginForm";
                this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
                this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                this.Text = "دخول المستخدمين";
                this.TopMost = true;
                this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
                this.ResumeLayout(false);
                this.PerformLayout();

		}
		internal System.Windows.Forms.Button Btnresetconnection;
		
	}
	
}
