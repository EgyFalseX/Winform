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
    public partial class ProductBaseEditorWFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.dsNU.ProductBaseRow _row;
        public ProductBaseEditorWFrm(DataSources.dsNU.ProductBaseRow row)
        {
            InitializeComponent();
            _row = row;
            productBaseBindingSource.DataSource = _row;
            ProductBaseNameTextEdit.DataBindings.Add(new Binding("EditValue", _row, "ProductBaseName", true));
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