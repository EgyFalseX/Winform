using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;

namespace DataCenterNetworkService
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
                this.BtnApply = new System.Windows.Forms.Button();
                this.CBAutoStart = new System.Windows.Forms.CheckBox();
                this.SuspendLayout();
                // 
                // BtnApply
                // 
                this.BtnApply.Location = new System.Drawing.Point(59, 40);
                this.BtnApply.Name = "BtnApply";
                this.BtnApply.Size = new System.Drawing.Size(73, 23);
                this.BtnApply.TabIndex = 0;
                this.BtnApply.Text = "Apply";
                this.BtnApply.UseVisualStyleBackColor = true;
                this.BtnApply.Click += new System.EventHandler(this.BtnApply_Click);
                // 
                // CBAutoStart
                // 
                this.CBAutoStart.AutoSize = true;
                this.CBAutoStart.Location = new System.Drawing.Point(59, 14);
                this.CBAutoStart.Name = "CBAutoStart";
                this.CBAutoStart.Size = new System.Drawing.Size(70, 17);
                this.CBAutoStart.TabIndex = 1;
                this.CBAutoStart.Text = "AutoStart";
                this.CBAutoStart.UseVisualStyleBackColor = true;
                // 
                // OptionsFrm
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.BackColor = System.Drawing.Color.White;
                this.ClientSize = new System.Drawing.Size(190, 77);
                this.Controls.Add(this.CBAutoStart);
                this.Controls.Add(this.BtnApply);
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
                this.Name = "OptionsFrm";
                this.ShowIcon = false;
                this.ShowInTaskbar = false;
                this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
                this.Text = "  Options";
                this.Load += new System.EventHandler(this.OptionsFrm_Load);
                this.ResumeLayout(false);
                this.PerformLayout();

		}
		internal System.Windows.Forms.Button BtnApply;
		internal System.Windows.Forms.CheckBox CBAutoStart;
	}
	
}
