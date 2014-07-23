using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace E_Club_Att_Manager
{
    public partial class DemoManagerFrm : DevExpress.XtraEditors.XtraForm
    {
        public DemoManagerFrm()
        {
            InitializeComponent();
        }
        private void BtnShitEditor_Click(object sender, EventArgs e)
        {
            EditorShiftFrm frm = new EditorShiftFrm();
            frm.ShowDialog();
        }
        private void BtnHarakaTypeEditor_Click(object sender, EventArgs e)
        {
            EditorHarakaTypeFrm frm = new EditorHarakaTypeFrm();
            frm.ShowDialog();
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            AttUserMainFrm frm = new AttUserMainFrm();
            frm.ShowDialog();
        }
        private void BtnQryEmpAtt_Click(object sender, EventArgs e)
        {
            QryEmpAttFrm frm = new QryEmpAttFrm();
            frm.ShowDialog();
        }
        private void BtnQryEmpInfo_Click(object sender, EventArgs e)
        {
            QryEmpInfoFrm frm = new QryEmpInfoFrm();
            frm.ShowDialog();
        }
        private void BtnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}