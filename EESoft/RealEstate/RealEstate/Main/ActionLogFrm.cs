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
    public partial class ActionLogFrm : DevExpress.XtraEditors.XtraForm
    {
        public ActionLogFrm()
        {
            InitializeComponent();
        }
        private void ActionLogFrm_Load(object sender, EventArgs e)
        {
            TxtLog.Text = MyCL.ActionLog;
        }
    }
}