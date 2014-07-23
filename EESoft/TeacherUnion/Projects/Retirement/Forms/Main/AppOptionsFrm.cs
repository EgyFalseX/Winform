using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Retirement.Forms.Main
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
            DataSources.dsTeachersUnion.AppOptionsRow row = dsTeachersUnion.AppOptions[0];
            row.attachpath = beattachpath.EditValue.ToString();
            row.imgpath = beimgpath.EditValue.ToString();
            row.MandoopImgpath = beMandoopImgpath.EditValue.ToString();
            row.imgpathweb = beimgpathweb.EditValue.ToString();
            row.CompanyLogo = img;
            appOptionsBindingSource.EndEdit();
            appOptionsTableAdapter.Update(row);
            //appOptionsTableAdapter.Update(beimgpath.EditValue.ToString(), beattachpath.EditValue.ToString(),
            //    beMandoopImgpath.EditValue.ToString(), beimgpathweb.EditValue.ToString(), img);
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