using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace GetFolderFilePaths
{
    public partial class MainFrm : Form
    {
        string RootFolder = @"C:\";
        string FilePath = string.Empty;
        List<string> FileNames = new List<string>();
        string SavingDir = Application.StartupPath + @"\Files\";
        public MainFrm()
        {
            InitializeComponent();
            if (!System.IO.Directory.Exists(SavingDir))
                System.IO.Directory.CreateDirectory(SavingDir);
        }
        private void btnPath_Click(object sender, EventArgs e)
        {
            fbd.SelectedPath = RootFolder;
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                return;
            RootFolder = fbd.SelectedPath;
            FilePath = fbd.SelectedPath;
            lblPath.Text = FilePath.Substring(FilePath.LastIndexOf('\\') + 1);
            gbCommand.Enabled = true;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dsFilePaths.FilePaths.Clear();
            GetFiles(FilePath, cbSubDir.Checked);
            //string FolderName = FilePath.Substring(FilePath.LastIndexOf('\\') + 1);
            //foreach (string item in FileNames)
            //{
            //    dsFilePaths.FilePathsRow row = dsFilePaths.FilePaths.NewFilePathsRow();
            //    row.FileName = item;
            //    row.FileNameAndEx = item.Split('.')[0];
            //    row.FolderName = FolderName;
            //    dsFilePaths.FilePaths.AddFilePathsRow(row);
            //}
            dgvData.DataSource = dsFilePaths.FilePaths;
        }
        void GetFiles(string DirPath, bool SubDir)
        {
            dsFilePaths.FilePaths.Clear();
            string FolderName = FilePath.Substring(FilePath.LastIndexOf('\\') + 1);

            string[] str;
            if (cbSubDir.Checked)
                str = Directory.GetFiles(DirPath, "*.*", SearchOption.AllDirectories);
            else
                str = Directory.GetFiles(DirPath, "*.*", SearchOption.TopDirectoryOnly);

            foreach (string path in str)
            {
                dsFilePaths.FilePathsRow row = dsFilePaths.FilePaths.NewFilePathsRow();
                row.FileName = Path.GetFileNameWithoutExtension(path);
                row.FileNameAndEx = Path.GetFileName(path);
                //string[] spt = path.Split('\\');
                //row.FolderName = spt[spt.Length - 2];

                row.FolderName = Path.GetDirectoryName(path);
                row.FolderPath = path;
                dsFilePaths.FilePaths.AddFilePathsRow(row);
                row.EndEdit();
            }
            //FileNames.AddRange(Directory.GetFiles(DirPath));
            //if (!SubDir)
            //    return;
            //foreach (string path in Directory.GetDirectories(DirPath))
            //    GetFiles(path, SubDir);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            gbMain.Enabled = false;
            gbCommand.Enabled = false;
            System.Threading.ThreadPool.QueueUserWorkItem((o) =>
            {
                try
                {
                    filePathsTableAdapter.Update(dsFilePaths);
                    foreach (dsFilePaths.FilePathsRow item in dsFilePaths.FilePaths.Rows)
                    {
                        if (cbCut.Checked)
                        {
                            if (filesNamesTableAdapter.ExistsFileName(item.FileNameAndEx) > 0)
                            {
                                try
                                {File.Move(item.FolderPath, SavingDir + item.FileNameAndEx);}
                                catch { }
                                
                            }
                        }
                        else
                            File.Copy(item.FolderPath, SavingDir + item.FileNameAndEx, true);
                    }
                    MessageBox.Show("Data Saved ...", "Complate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //dsFilePaths.FilePaths.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                this.Invoke(new MethodInvoker(() => {
                    gbMain.Enabled = true;
                    gbCommand.Enabled = true;
                }));
                
            });
            

            
        }
        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 4)
            {
                return;
            }
            try
            {
                System.Diagnostics.Process.Start("explorer.exe", @"/select, " + dsFilePaths.FilePaths[e.RowIndex].FolderPath);
            }
            catch 
            {
            }
        }
        private void btnLoadData_Click(object sender, EventArgs e)
        {
            dsFilePathsTableAdapters.FilePathsTableAdapter adp = new dsFilePathsTableAdapters.FilePathsTableAdapter();
            adp.Fill(dsFilePathsViewer.FilePaths);
            dgvViewer.DataSource = dsFilePathsViewer.FilePaths;
        }
        private void dgvViewer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 4 || dsFilePathsViewer.FilePaths.Count == 0)
            {
                return;
            }
            DataGridView view = (DataGridView)sender;
            //
            int a = dsFilePathsViewer.FilePaths[e.RowIndex].auto;
            var obj = view.Rows[e.RowIndex];
            //dgvData = new 
            try
            {
                //string fname = "\"" + dsFilePathsViewer.FilePaths[e.RowIndex].FolderName + @"\" + dsFilePathsViewer.FilePaths[e.RowIndex].FileNameAndEx + "\"";
                string fname = "\"" + view.Rows[e.RowIndex].Cells[3].Value + @"\" + view.Rows[e.RowIndex].Cells[2].Value + "\"";
                System.Diagnostics.Process.Start("explorer.exe", @"/select, " + fname);
            }
            catch 
            {
            }
        }

    }
}
