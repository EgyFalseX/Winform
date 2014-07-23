﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student
{
    public partial class SQLConnectionFrm : Form
    {
        public string FullConString, DatabaseName, RegKeyName;

        public SQLConnectionFrm()
        {
            InitializeComponent();
        }
        private void SqlConnectionUC_Load(object sender, EventArgs e)
        {
            
            SqlConnectionUC.FullConString = FullConString;
            SqlConnectionUC.DatabaseName = DatabaseName;
            SqlConnectionUC.RegKeyName = RegKeyName;
        }
        private void SQLConnectionFrm_Load(object sender, EventArgs e)
        {
            Text += " " + SqlConnectionUC.DatabaseName;
        }
    }
}
