using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace RetirementCenter.Forms.Data
{
    public partial class TBLNoSarfDetelsDlg : DevExpress.XtraEditors.XtraForm
    {
        DataSources.dsRetirementCenter.TBLNoSarfDetelsRow _row;
        

        public TBLNoSarfDetelsDlg(DataSources.dsRetirementCenter.TBLNoSarfDetelsRow row)
        {
            InitializeComponent();
            _row = row;

            dedatehala.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", _row, "datehala", true));
            tbhalarem.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", _row, "halarem", true));
        }
        private void TBLNoSarfDetelsDlg_Load(object sender, EventArgs e)
        {
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!dxValidationProviderMain.Validate())
                return;

            _row.datein = SQLProvider.ServerDateTime();
            _row.userin = Program.UserInfo.UserId;
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
        
    }
}