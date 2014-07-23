using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace WorkOverview
{
    public partial class FrmEditor : Form
    {
        DataTable DT = new DataTable("CubesTalbe");

        public FrmEditor()
        {
            InitializeComponent();
        }

        OpenFileDialog OFD = new OpenFileDialog();

        private void FrmEditor_Load(object sender, EventArgs e)
        {
            LoadCubes();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string DBImagePath = string.Empty;
            if (LblPath.Text.Length > 0)
            {
                if (File.Exists(LblPath.Text))
                {
                    DBImagePath = Application.StartupPath + "\\CubesImages\\" + OFD.SafeFileName;
                    File.Copy(LblPath.Text, DBImagePath);
                }
            }
            OleDbConnection Con = new OleDbConnection(MainClass.ConnectionString);
            OleDbCommand CMD = new OleDbCommand("INSERT INTO WorkCubes (WCName, WCImagePath, WCInfo) VALUES ('" + TxtName.Text.Trim() + "', '" + DBImagePath + "', '" + TxtInfo.Text.Trim() + "')", Con);
            try
            {
                Con.Open();
                
                CMD.ExecuteNonQuery();
                OFD.FileName = string.Empty;
                MessageBox.Show("Cube Added ...!", "Adding Complated", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error  ........",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            Con.Close();
            LoadCubes();
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            if (TxtName.TextLength == 0)
            {
                BtnSave.Enabled = false;
            }
            else
            {
                BtnSave.Enabled = true;
            }
        }
        private void BtnSelectImage_Click(object sender, EventArgs e)
        {
            OFD.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (OFD.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }
            else
            {
                LblPath.Text = OFD.FileName;
                PicCubeImage.Image = Image.FromFile(OFD.FileName);
            }
        }
        private void LoadCubes()
        {
            DT = new DataTable("CubesTalbe");
            OleDbDataAdapter DA = new OleDbDataAdapter("Select WorkCubeID, WCName, WCImagePath, WCInfo From WorkCubes", MainClass.ConnectionString);
            try
            {
                DA.Fill(DT);
                CBAllCubes.DataSource = DT;
                CBAllCubes.DisplayMember = "WCName";
                CBAllCubes.ValueMember = "WorkCubeID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error  ........", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CBAllCubes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBAllCubes.SelectedIndex == -1)
            {
                BtnDeleteCube.Enabled = false;
                BtnSaveChanges.Enabled = false;
                return;
            }
            TxtName.Text = DT.Rows[CBAllCubes.SelectedIndex][1].ToString();
            if (File.Exists(DT.Rows[CBAllCubes.SelectedIndex][2].ToString()))
            {
                PicCubeImage.Image = Image.FromFile(DT.Rows[CBAllCubes.SelectedIndex][2].ToString());    
            }
            TxtInfo.Text = DT.Rows[CBAllCubes.SelectedIndex][3].ToString();
            BtnDeleteCube.Enabled = true;
            BtnSaveChanges.Enabled = true;
            
        }
        private void BtnSaveChanges_Click(object sender, EventArgs e)
        {
            if (TxtName.Text.Length == 0)
            {
                MessageBox.Show("You must Type name for this Cube", "Error  ........", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            OleDbConnection Con = new OleDbConnection(MainClass.ConnectionString);
            OleDbCommand CMD = new OleDbCommand("UPDATE WorkCubes SET WCName = '" + TxtName.Text.Trim() + "', WCInfo = '' WHERE (WorkCubeID = " + CBAllCubes.SelectedValue.ToString() + ")", Con);
            if (LblPath.Text.Length  > 0)
            {
                string DBImagePath = string.Empty;
                if (File.Exists(LblPath.Text.Trim()))
                {
                    OFD.FileName = LblPath.Text.Trim();
                    
                    DBImagePath = Application.StartupPath + "\\CubesImages\\" + OFD.SafeFileName;
                    CMD.CommandText = "UPDATE WorkCubes SET WCName = '" + TxtName.Text.Trim() + "', WCImagePath = '" + DBImagePath + "', WCInfo = '" + TxtInfo.Text + "' WHERE (WorkCubeID = " + CBAllCubes.SelectedValue.ToString() + ")";
                }
            }
            try
            {
                Con.Open();
                CMD.ExecuteNonQuery();
                if (File.Exists(LblPath.Text.Trim()))
                {
                    File.Copy(LblPath.Text, Application.StartupPath + "\\CubesImages\\" + OFD.SafeFileName);// Copy New Image
                    PicCubeImage.Image = Image.FromFile(Application.StartupPath + "\\CubesImages\\" + OFD.SafeFileName);
                    if (File.Exists(DT.Rows[CBAllCubes.SelectedIndex][2].ToString()))
                    {
                        File.Delete(DT.Rows[CBAllCubes.SelectedIndex][2].ToString());// Delete Old Image
                    }
                }
                MessageBox.Show("Cube Updated ...!", "Updating Complated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error  ........", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CBAllCubes.SelectedIndex = -1;
            BtnDeleteCube.Enabled = false;
            BtnSaveChanges.Enabled = false;
            LoadCubes();
        }
        private void BtnDeleteCube_Click(object sender, EventArgs e)
        {
            OleDbConnection Con = new OleDbConnection(MainClass.ConnectionString);
            OleDbCommand CMD = new OleDbCommand("DELETE FROM WorkCubes WHERE (WorkCubeID = " + CBAllCubes.SelectedValue.ToString() + ")", Con);
            try
            {
                Con.Open();
                CMD.ExecuteNonQuery();
                if (File.Exists(DT.Rows[CBAllCubes.SelectedIndex][2].ToString()))
                {
                    PicCubeImage.Image = null;
                    File.Delete(DT.Rows[CBAllCubes.SelectedIndex][2].ToString());// Delete Image
                }
                MessageBox.Show("Cube Deleted ...!", "Deleting Complated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CBAllCubes.SelectedIndex = -1;
                BtnDeleteCube.Enabled = false;
                BtnSaveChanges.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error  ........", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Con.Close();
            LoadCubes();
            
            
        }
    }
}
