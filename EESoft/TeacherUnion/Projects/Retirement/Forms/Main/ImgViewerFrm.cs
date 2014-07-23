using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Retirement
{
    public partial class ImgViewerFrm : DevExpress.XtraEditors.XtraForm
    {
        public ImgViewerFrm()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}