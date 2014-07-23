using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Members.Forms.Main
{
    public partial class AppOptionsFrm : DevExpress.XtraEditors.XtraForm
    {

        public AppOptionsFrm()
        {
            InitializeComponent();
        }
        private void BindToControls()
        {
            appOptionsTableAdapter.Fill(dsTeachersUnion.AppOptions);
        }
        private void AppOptionsFrm_Load(object sender, EventArgs e)
        {
            BindToControls();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            byte[] img = null;
            if (peLogo.EditValue != null && peLogo.EditValue.ToString() != string.Empty)
            {
                img = (byte[])peLogo.EditValue;
            }
            appOptionsTableAdapter.Update(beimgpath.EditValue.ToString(), beattachpath.EditValue.ToString(),
                beMandoopImgpath.EditValue.ToString(), beimgpathweb.EditValue.ToString(), img, Program.NormalCardCost, Program.FastCardCost);
            Close();
            Program.ShowMsg("تم الحفظ", false, this);
            Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}