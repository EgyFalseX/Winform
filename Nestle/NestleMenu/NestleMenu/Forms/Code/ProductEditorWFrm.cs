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
    public partial class ProductEditorWFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.dsNU.ProductRow _row;
        public ProductEditorWFrm(DataSources.dsNU.ProductRow row)
        {
            InitializeComponent();
            this.productBaseTableAdapter.Fill(this.dsNU.ProductBase);
            _row = row;
            productBindingSource.DataSource = _row;
            ProductNameTextEdit.DataBindings.Add(new Binding("EditValue", _row, "ProductName", true));
            ProductBaseIdGridLookUpEdit.DataBindings.Add(new Binding("EditValue", _row, "ProductBaseId", true));
            DescriptionMemoEdit.DataBindings.Add(new Binding("EditValue", _row, "Description", true));
            DisabledCheckEdit.DataBindings.Add(new Binding("EditValue", _row, "Disabled", true));
            ProductImagePictureEdit.DataBindings.Add(new Binding("EditValue", _row, "ProductImage", true));

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