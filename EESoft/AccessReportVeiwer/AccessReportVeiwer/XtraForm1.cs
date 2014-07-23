using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace AccessReportVeiwer
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1()
        {
            InitializeComponent();
        }

        private void btnprev_Click(object sender, EventArgs e)
        {
            XtraReport1 x = new XtraReport1();
            x.ShowPreview();
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            XtraReport1 x = new XtraReport1();
            x.Print();
        }
    }
}