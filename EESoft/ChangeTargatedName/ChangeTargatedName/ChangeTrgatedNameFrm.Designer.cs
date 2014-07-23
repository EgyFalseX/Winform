namespace ChangeTargatedName
{
    partial class ChangeTrgatedNameFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeTrgatedNameFrm));
            this.TxtFrom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtTo = new System.Windows.Forms.TextBox();
            this.BtnChange = new System.Windows.Forms.Button();
            this.PB = new System.Windows.Forms.ProgressBar();
            this.BtnRemoveAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtFrom
            // 
            this.TxtFrom.Location = new System.Drawing.Point(77, 12);
            this.TxtFrom.Name = "TxtFrom";
            this.TxtFrom.Size = new System.Drawing.Size(149, 20);
            this.TxtFrom.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "To";
            // 
            // TxtTo
            // 
            this.TxtTo.Location = new System.Drawing.Point(77, 38);
            this.TxtTo.Name = "TxtTo";
            this.TxtTo.Size = new System.Drawing.Size(149, 20);
            this.TxtTo.TabIndex = 2;
            // 
            // BtnChange
            // 
            this.BtnChange.Location = new System.Drawing.Point(77, 64);
            this.BtnChange.Name = "BtnChange";
            this.BtnChange.Size = new System.Drawing.Size(149, 23);
            this.BtnChange.TabIndex = 3;
            this.BtnChange.Text = "Change";
            this.BtnChange.UseVisualStyleBackColor = true;
            this.BtnChange.Click += new System.EventHandler(this.BtnChange_Click);
            // 
            // PB
            // 
            this.PB.Location = new System.Drawing.Point(77, 93);
            this.PB.Name = "PB";
            this.PB.Size = new System.Drawing.Size(149, 16);
            this.PB.Step = 1;
            this.PB.TabIndex = 4;
            // 
            // BtnRemoveAll
            // 
            this.BtnRemoveAll.Location = new System.Drawing.Point(77, 115);
            this.BtnRemoveAll.Name = "BtnRemoveAll";
            this.BtnRemoveAll.Size = new System.Drawing.Size(149, 23);
            this.BtnRemoveAll.TabIndex = 3;
            this.BtnRemoveAll.Text = "Remove Duplicate Names";
            this.BtnRemoveAll.UseVisualStyleBackColor = true;
            this.BtnRemoveAll.Click += new System.EventHandler(this.BtnRemoveAll_Click);
            // 
            // ChangeTrgatedNameFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 143);
            this.Controls.Add(this.PB);
            this.Controls.Add(this.BtnRemoveAll);
            this.Controls.Add(this.BtnChange);
            this.Controls.Add(this.TxtTo);
            this.Controls.Add(this.TxtFrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangeTrgatedNameFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Targated Name";
            this.Load += new System.EventHandler(this.ChangeTrgatedNameFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtTo;
        private System.Windows.Forms.Button BtnChange;
        private System.Windows.Forms.ProgressBar PB;
        private System.Windows.Forms.Button BtnRemoveAll;
    }
}

