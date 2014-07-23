using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace RealEstate
{
    public partial class RepCRGeneralFrm : DevExpress.XtraEditors.XtraForm
    {
        public string ReportName = string.Empty;
        public RepCRGeneralFrm()
        {
            InitializeComponent();
        }

        private void RepCRGeneralFrm_Load(object sender, EventArgs e)
        {
            Text = String.Format("{0} {1}", Text, ReportName);
        }
    }
}