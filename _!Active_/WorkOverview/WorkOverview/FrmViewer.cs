using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WorkOverview
{
    public partial class FrmViewer : Form
    {
        DataTable DT = new DataTable("CubesTalbe");

        public FrmViewer()
        {
            InitializeComponent();
        }

        private void FrmViewer_Load(object sender, EventArgs e)
        {
            LoadCubes();
        }

        private void BtnShowEditor_Click(object sender, EventArgs e)
        {
            if (MainClass.EditorFrm != null)
            {
                if (MainClass.EditorFrm.Visible == true)
                {
                    Pic1.Image = null;
                    MainClass.EditorFrm.Focus();
                    return;
                }
            }
            MainClass.EditorFrm = new FrmEditor();
            MainClass.EditorFrm.Show();
            
        }

        private void BtnReload_Click(object sender, EventArgs e)
        {
            LoadCubes();
        }

        private void LoadCubes()
        {
            DT = new DataTable("CubesTalbe");
            OleDbDataAdapter DA = new OleDbDataAdapter("Select WorkCubeID, WCName, WCImagePath, WCInfo From WorkCubes", MainClass.ConnectionString);
            try
            {
                DA.Fill(DT);
                LBCubes.DataSource = DT;
                LBCubes.DisplayMember = "WCName";
                LBCubes.ValueMember = "WorkCubeID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error  ........",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void LBCubes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LBCubes.SelectedIndex == -1)
            {
                return;
            }
            Pic1.Image = Image.FromFile(DT.Rows[LBCubes.SelectedIndex][2].ToString());
            TxtInfo.Text = DT.Rows[LBCubes.SelectedIndex][3].ToString();
        }
    }
}
