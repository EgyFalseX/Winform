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

namespace NestleMenu.Forms.Code
{
    public partial class AreaEditorWFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.dsNU.AreaRow _row;
        public AreaEditorWFrm(DataSources.dsNU.AreaRow row)
        {
            InitializeComponent();
            _row = row;
            areaBindingSource.DataSource = _row;
            AreaNameTextEdit.DataBindings.Add(new Binding("EditValue", _row, "AreaName", true));
        }
        private void AreaEditorWFrm_Load(object sender, EventArgs e)
        {
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dxValidationProviderEditor.Validate())
                DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}