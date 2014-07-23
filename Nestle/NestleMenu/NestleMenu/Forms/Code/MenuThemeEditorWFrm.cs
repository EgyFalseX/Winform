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
    public partial class MenuThemeEditorWFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.dsNU.MenuThemeRow _row;
        public MenuThemeEditorWFrm(DataSources.dsNU.MenuThemeRow row)
        {
            InitializeComponent();
            _row = row;
            menuSizeBindingSource.DataSource = _row;
            MenuThemeNameTextEdit.DataBindings.Add(new Binding("EditValue", _row, "MenuThemeName", true));
            MenuThemeLogoPictureEdit.DataBindings.Add(new Binding("EditValue", _row, "MenuThemeLogo", true));
            MenuThemeDescriptionMemoExEdit.DataBindings.Add(new Binding("EditValue", _row, "MenuThemeDescription", true));
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