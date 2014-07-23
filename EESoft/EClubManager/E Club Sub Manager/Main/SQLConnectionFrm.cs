using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace E_Club_Sub_Manager
{
    public partial class SQLConnectionFrm : Form
    {
        public string FullConString, DatabaseName, RegKeyName, OFDInitialDirectory;

        public SQLConnectionFrm()
        {
            InitializeComponent();
        }

        private void SQLConnectionFrm_Load(object sender, EventArgs e)
        {
            sqlConnectionUC.FullConString = FullConString;
            sqlConnectionUC.DatabaseName = DatabaseName;
            sqlConnectionUC.RegKeyName = RegKeyName;
            sqlConnectionUC.OFDInitialDirectory = OFDInitialDirectory;
            this.Text += " " + sqlConnectionUC.DatabaseName;
        }
    }
}
