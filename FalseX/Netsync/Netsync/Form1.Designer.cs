namespace Netsync
{
    partial class Form1
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
            this.btnsendFile = new System.Windows.Forms.Button();
            this.btnsendFiles = new System.Windows.Forms.Button();
            this.pbSingleFile = new System.Windows.Forms.ProgressBar();
            this.pbMultiFilesS = new System.Windows.Forms.ProgressBar();
            this.pbMultiFileS = new System.Windows.Forms.ProgressBar();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnRecive = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnRecives = new System.Windows.Forms.Button();
            this.pbMultiFilesR = new System.Windows.Forms.ProgressBar();
            this.pbMultiFileR = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnsendFile
            // 
            this.btnsendFile.Enabled = false;
            this.btnsendFile.Location = new System.Drawing.Point(12, 77);
            this.btnsendFile.Name = "btnsendFile";
            this.btnsendFile.Size = new System.Drawing.Size(75, 23);
            this.btnsendFile.TabIndex = 0;
            this.btnsendFile.Text = "Send File";
            this.btnsendFile.UseVisualStyleBackColor = true;
            this.btnsendFile.Click += new System.EventHandler(this.btnsendFile_Click);
            // 
            // btnsendFiles
            // 
            this.btnsendFiles.Enabled = false;
            this.btnsendFiles.Location = new System.Drawing.Point(12, 135);
            this.btnsendFiles.Name = "btnsendFiles";
            this.btnsendFiles.Size = new System.Drawing.Size(75, 23);
            this.btnsendFiles.TabIndex = 0;
            this.btnsendFiles.Text = "Send Files";
            this.btnsendFiles.UseVisualStyleBackColor = true;
            this.btnsendFiles.Click += new System.EventHandler(this.btnsendFiles_Click);
            // 
            // pbSingleFile
            // 
            this.pbSingleFile.Location = new System.Drawing.Point(12, 106);
            this.pbSingleFile.Name = "pbSingleFile";
            this.pbSingleFile.Size = new System.Drawing.Size(260, 23);
            this.pbSingleFile.TabIndex = 1;
            // 
            // pbMultiFilesS
            // 
            this.pbMultiFilesS.Location = new System.Drawing.Point(12, 164);
            this.pbMultiFilesS.Name = "pbMultiFilesS";
            this.pbMultiFilesS.Size = new System.Drawing.Size(260, 23);
            this.pbMultiFilesS.TabIndex = 1;
            // 
            // pbMultiFileS
            // 
            this.pbMultiFileS.Location = new System.Drawing.Point(12, 193);
            this.pbMultiFileS.Name = "pbMultiFileS";
            this.pbMultiFileS.Size = new System.Drawing.Size(260, 23);
            this.pbMultiFileS.TabIndex = 1;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(12, 12);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnRecive
            // 
            this.btnRecive.Enabled = false;
            this.btnRecive.Location = new System.Drawing.Point(12, 222);
            this.btnRecive.Name = "btnRecive";
            this.btnRecive.Size = new System.Drawing.Size(75, 23);
            this.btnRecive.TabIndex = 0;
            this.btnRecive.Text = "Recive File";
            this.btnRecive.UseVisualStyleBackColor = true;
            this.btnRecive.Click += new System.EventHandler(this.btnRecive_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 251);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(260, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // btnRecives
            // 
            this.btnRecives.Enabled = false;
            this.btnRecives.Location = new System.Drawing.Point(12, 280);
            this.btnRecives.Name = "btnRecives";
            this.btnRecives.Size = new System.Drawing.Size(75, 23);
            this.btnRecives.TabIndex = 0;
            this.btnRecives.Text = "Recive Files";
            this.btnRecives.UseVisualStyleBackColor = true;
            this.btnRecives.Click += new System.EventHandler(this.btnRecives_Click);
            // 
            // pbMultiFilesR
            // 
            this.pbMultiFilesR.Location = new System.Drawing.Point(12, 309);
            this.pbMultiFilesR.Name = "pbMultiFilesR";
            this.pbMultiFilesR.Size = new System.Drawing.Size(260, 23);
            this.pbMultiFilesR.TabIndex = 1;
            // 
            // pbMultiFileR
            // 
            this.pbMultiFileR.Location = new System.Drawing.Point(12, 338);
            this.pbMultiFileR.Name = "pbMultiFileR";
            this.pbMultiFileR.Size = new System.Drawing.Size(260, 23);
            this.pbMultiFileR.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 455);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 490);
            this.Controls.Add(this.pbMultiFileR);
            this.Controls.Add(this.pbMultiFileS);
            this.Controls.Add(this.pbMultiFilesR);
            this.Controls.Add(this.pbMultiFilesS);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pbSingleFile);
            this.Controls.Add(this.btnRecives);
            this.Controls.Add(this.btnsendFiles);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnRecive);
            this.Controls.Add(this.btnsendFile);
            this.Name = "Form1";
            this.Text = "t e s t";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnsendFile;
        private System.Windows.Forms.Button btnsendFiles;
        private System.Windows.Forms.ProgressBar pbSingleFile;
        private System.Windows.Forms.ProgressBar pbMultiFilesS;
        private System.Windows.Forms.ProgressBar pbMultiFileS;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnRecive;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnRecives;
        private System.Windows.Forms.ProgressBar pbMultiFilesR;
        private System.Windows.Forms.ProgressBar pbMultiFileR;
        private System.Windows.Forms.Button button1;
    }
}