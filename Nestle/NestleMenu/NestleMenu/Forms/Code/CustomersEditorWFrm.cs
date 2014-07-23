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
    public partial class CustomersEditorWFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.dsNU.CustomersRow _row;
        public CustomersEditorWFrm(DataSources.dsNU.CustomersRow row)
        {
            InitializeComponent();
            _row = row;
            customersBindingSource.DataSource = _row;
            CustomerNameTextEdit.DataBindings.Add(new Binding("EditValue", _row, "CustomerName", true));
            CustomerPhoneTextEdit.DataBindings.Add(new Binding("EditValue", _row, "CustomerPhone", true));
            CustomerMobileTextEdit.DataBindings.Add(new Binding("EditValue", _row, "CustomerMobile", true));
            CustomerEmailTextEdit.DataBindings.Add(new Binding("EditValue", _row, "CustomerEmail", true));
            CustomerLogoPictureEdit.DataBindings.Add(new Binding("EditValue", _row, "CustomerLogo", true));
        }
        private void JobEditorWFrm_Load(object sender, EventArgs e)
        {
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dxValidationProviderEditor.Validate())
                DialogResult = System.Windows.Forms.DialogResult.OK;
        }

    }
}