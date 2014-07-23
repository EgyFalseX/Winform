using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace E_Club_Emp_Manager
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
            this.Text = Program.MC.RepTy.ToString() + " " + this.Text;
            RVGeneral.ServerReport.ReportPath = Program.MC.ReportPath + Program.MC.RepTy.ToString();
            RVGeneral.ServerReport.ReportServerUrl = new System.Uri(Program.MC.ReportURL, System.UriKind.Absolute);
            this.RVGeneral.RefreshReport();
        }
    }
}