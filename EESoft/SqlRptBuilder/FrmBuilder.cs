using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SqlRptBuilder
{
    public partial class FrmBuilder : Form
    {
        #region -   Variables   -
        const string configFileName = "SQLReports.txt";
        const string confiRptFolder = "rdl";
        string WorkSpacePath = string.Empty;
        public static SQLReportsStr[] SQLRep;
        public struct SQLReportsStr
        {
            public string RepFileName;
            public string RepCaption;
            public string RepPosition;
        }
        #endregion
        #region -   Functions   -
        public FrmBuilder()
        {
            InitializeComponent();
            Size = new Size(269, 66);
        }
        private void FormClear()
        {
            TxtPath.Text = string.Empty;
            LblrdlPath.Text = string.Empty;
            TxtrdlName.Text = string.Empty;
            CBRpt.Text = "1";
            LVrpt.Items.Clear();
        }
        private void PrepareWorkSpace(string Path)
        {
            try
            {
                if (File.Exists(Path + configFileName) == false)
                    File.Create(Path + configFileName);
                else
                    LoadFromConfig(Path);

                if (!Directory.Exists(Path + confiRptFolder))
                    Directory.CreateDirectory(Path + confiRptFolder);
            }
            catch (Exception ex)
            { throw ex; }
        }
        private void LoadFromConfig(string Path)
        {
            LVrpt.Items.Clear();
            try
            {
                StreamReader sr = new StreamReader(Path + configFileName, Encoding.Default);
                //SQLRep = new SQLReportsStr[0];
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] Parts = line.Split(Convert.ToChar(";"));
                    //Array.Resize<SQLReportsStr>(ref SQLRep, SQLRep.Length + 1);
                    //SQLRep[SQLRep.Length - 1].RepPosition = Parts[0];
                    //SQLRep[SQLRep.Length - 1].RepFileName = Parts[1];
                    //SQLRep[SQLRep.Length - 1].RepCaption = Parts[2];
                    ListViewItem LVI = new ListViewItem(Parts);
                    LVrpt.Items.Add(LVI);
                }
                sr.Close(); sr.Dispose(); sr = null;
            }
            catch (Exception ex)
            { throw ex; }

        }
#endregion
        #region - Event Handlers -
        private void openLoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (FolderBrowserDialog FBD = new FolderBrowserDialog() { Description = "Select config's folder to open or save config files", ShowNewFolderButton = true })
                {
                    if (FBD.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                        return;
                    FormClear();
                    WorkSpacePath = FBD.SelectedPath + @"\";
                    PrepareWorkSpace(WorkSpacePath);
                    TxtPath.Text = WorkSpacePath + configFileName;
                    Size = new Size(269, 356);
                    PnlMain.Visible = true;
                    
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        private void BtnSelectRpt_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog OFD = new OpenFileDialog() { Title = "Select rdl file", Filter = "Sql Report File(*.rdl)|*.rdl|All Files(*.*)|*.*" })
            {
                if (OFD.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                    return;
                LblrdlPath.Text = OFD.FileName;
            }
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (LblrdlPath.Text == string.Empty || TxtrdlName.Text == string.Empty || CBRpt.Text == string.Empty)
            {
                MessageBox.Show("Information is not entered", "Missing Information..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!File.Exists(LblrdlPath.Text))
            {
                MessageBox.Show("rdl file not found ..", "Missing File..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            File.Copy(LblrdlPath.Text, String.Format(@"{0}{1}\{2}", WorkSpacePath, confiRptFolder, Path.GetFileName(LblrdlPath.Text)), true);

            ListViewItem LVI = new ListViewItem() { Text = CBRpt.Text };
            LVI.SubItems.Add(Path.GetFileName(LblrdlPath.Text));
            LVI.SubItems.Add(TxtrdlName.Text);
            LVrpt.Items.Add(LVI);
            TxtPath.Text = string.Empty;
            TxtrdlName.Text = string.Empty;
            CBRpt.Text = "1";
            BtnSelectRpt.Focus();

        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (LVrpt.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Please Select Item to remove ...", "Information...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string FileName = LVrpt.SelectedItems[0].SubItems[1].Text;
            if (File.Exists(WorkSpacePath + FileName))
                File.Delete(WorkSpacePath + FileName);
            LVrpt.SelectedItems[0].Remove();
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirmation ...", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.No)
                return;
            StreamWriter sw = new StreamWriter(WorkSpacePath + configFileName, false, Encoding.Default);
            foreach (ListViewItem item in LVrpt.Items)
            {
                string line = string.Format("{0};{1};{2}", item.Text, item.SubItems[1].Text, item.SubItems[2].Text);
                sw.WriteLine(line);
            }
            sw.Flush(); sw.Close(); sw.Dispose(); sw = null;
            MessageBox.Show("File Saved ...", "Operation Complated ..", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
        }
        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("E-E-Soft Report Builber", "About us ...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}
