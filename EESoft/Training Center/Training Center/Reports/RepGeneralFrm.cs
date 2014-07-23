﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Training_Center
{
    public partial class RepGeneralFrm : DevExpress.XtraEditors.XtraForm
    {
        //public string ReportName = string.Empty;
        public RepGeneralFrm()
        {
            InitializeComponent();
        }
        private void RepGeneralFrm_Load(object sender, EventArgs e)
        {
            Text = String.Format("{0} - {1}", MyCL.RepTy, Text);
            RVGeneral.ServerReport.ReportPath = MyCL.ReportPath + MyCL.RepTy.ToString();
            RVGeneral.ServerReport.ReportServerUrl = new Uri(MyCL.ReportURL, UriKind.Absolute);
            RVGeneral.RefreshReport();
        }
    }
}