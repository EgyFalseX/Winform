using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace GM.Forms.Code
{
    public partial class GovEditorWFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.dsGM.GovRow _row;
        public GovEditorWFrm(DataSources.dsGM.GovRow row)
        {
            InitializeComponent();
            _row = row;

            govBindingSource.DataSource = _row;
            GovNameTextEdit.DataBindings.Add(new Binding("EditValue", _row, "GovName", true));
        }
        private void Frm_Load(object sender, EventArgs e)
        {
            
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dxValidationProviderEditor.Validate())
                DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}