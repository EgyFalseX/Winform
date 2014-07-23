using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace E_Club_Sub_Manager
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
            Text = String.Format("{0} {1}", Program.MC.RepTy, Text);
            RVGeneral.ServerReport.ReportPath = Program.MC.ReportPath + Program.MC.RepTy.ToString();
            RVGeneral.ServerReport.ReportServerUrl = new Uri(Program.MC.ReportURL, UriKind.Absolute);
            RVGeneral.RefreshReport();
        }
    }
}