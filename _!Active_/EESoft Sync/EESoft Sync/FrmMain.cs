using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EESoft_Sync
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (Program.MCLass.UpdateObjects == null)
            {
                Program.MCLass.UpdateObjects = new MainClass.UpdateObjectSTR[1];
            }
            Program.MCLass.FillUpdatingList(Program.MCLass.ConnectionStringClients, Program.MCLass.ConnectionStringServer, Program.MCLass.UpdateObjects[Program.MCLass.UpdateObjects.Length -1]);
        }
    }
}
