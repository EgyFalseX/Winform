using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;

namespace DataCenter_Server
{
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class WizradFrm : System.Windows.Forms.Form
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
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
			{
                this.components = new System.ComponentModel.Container();
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WizradFrm));
                this.TxtName = new System.Windows.Forms.TextBox();
                this.Label2 = new System.Windows.Forms.Label();
                this.BtnAdd = new System.Windows.Forms.Button();
                this.BtnCancel = new System.Windows.Forms.Button();
                this.NewProjectImageList = new System.Windows.Forms.ImageList(this.components);
                this.SuspendLayout();
                // 
                // TxtName
                // 
                this.TxtName.Location = new System.Drawing.Point(31, 12);
                this.TxtName.MaxLength = 20;
                this.TxtName.Name = "TxtName";
                this.TxtName.Size = new System.Drawing.Size(156, 20);
                this.TxtName.TabIndex = 2;
                this.TxtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
                // 
                // Label2
                // 
                this.Label2.AutoSize = true;
                this.Label2.BackColor = System.Drawing.Color.Transparent;
                this.Label2.ForeColor = System.Drawing.Color.Black;
                this.Label2.Location = new System.Drawing.Point(193, 15);
                this.Label2.Name = "Label2";
                this.Label2.Size = new System.Drawing.Size(30, 13);
                this.Label2.TabIndex = 3;
                this.Label2.Text = "الاسم";
                this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                // 
                // BtnAdd
                // 
                this.BtnAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.BtnAdd.Enabled = false;
                this.BtnAdd.Location = new System.Drawing.Point(112, 38);
                this.BtnAdd.Name = "BtnAdd";
                this.BtnAdd.Size = new System.Drawing.Size(75, 23);
                this.BtnAdd.TabIndex = 3;
                this.BtnAdd.Text = "اضافه";
                this.BtnAdd.UseVisualStyleBackColor = true;
                this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
                // 
                // BtnCancel
                // 
                this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.BtnCancel.Location = new System.Drawing.Point(31, 38);
                this.BtnCancel.Name = "BtnCancel";
                this.BtnCancel.Size = new System.Drawing.Size(75, 23);
                this.BtnCancel.TabIndex = 4;
                this.BtnCancel.Text = "اغلاق";
                this.BtnCancel.UseVisualStyleBackColor = true;
                this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
                // 
                // NewProjectImageList
                // 
                this.NewProjectImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("NewProjectImageList.ImageStream")));
                this.NewProjectImageList.TransparentColor = System.Drawing.Color.Transparent;
                this.NewProjectImageList.Images.SetKeyName(0, "FoldersIcon.ico");
                // 
                // WizradFrm
                // 
                this.AcceptButton = this.BtnAdd;
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.BackgroundImage = global::My.Resources.Resources.WizradFrm;
                this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                this.CancelButton = this.BtnCancel;
                this.ClientSize = new System.Drawing.Size(254, 71);
                this.Controls.Add(this.BtnCancel);
                this.Controls.Add(this.BtnAdd);
                this.Controls.Add(this.Label2);
                this.Controls.Add(this.TxtName);
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
                this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
                this.Name = "WizradFrm";
                this.ShowIcon = false;
                this.ShowInTaskbar = false;
                this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                this.Text = "رئيسي";
                this.ResumeLayout(false);
                this.PerformLayout();

            }
        internal System.Windows.Forms.TextBox TxtName;
		internal System.Windows.Forms.Button BtnAdd;
        internal System.Windows.Forms.Button BtnCancel;
        internal System.Windows.Forms.ImageList NewProjectImageList;
        private System.ComponentModel.IContainer components;
        private Label Label2;
	}
	
}
