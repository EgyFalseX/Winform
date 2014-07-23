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
    public partial class MenuSizeEditorWFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.dsNU.MenuSizeRow _row;
        public MenuSizeEditorWFrm(DataSources.dsNU.MenuSizeRow row)
        {
            InitializeComponent();
            _row = row;
            menuSizeBindingSource.DataSource = _row;
            MenuSizeNameTextEdit.DataBindings.Add(new Binding("EditValue", _row, "MenuSizeName", true));
            MenuSizeLogoPictureEdit.DataBindings.Add(new Binding("EditValue", _row, "MenuSizeLogo", true));
            MenuSizeDescriptionMemoExEdit.DataBindings.Add(new Binding("EditValue", _row, "MenuSizeDescription", true));
            DisabledCheckEdit.DataBindings.Add(new Binding("EditValue", _row, "Disabled", true));
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