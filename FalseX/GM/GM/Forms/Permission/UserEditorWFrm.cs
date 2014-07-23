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
    public partial class UserEditorWFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.dsGM.UserRow _row;
        public UserEditorWFrm(DataSources.dsGM.UserRow row)
        {
            InitializeComponent();
            _row = row;

            DataBindingSource.DataSource = _row;
            UserNameTextEdit.DataBindings.Add(new Binding("EditValue", _row, "UserName", true));
            UserPassTextEdit.DataBindings.Add(new Binding("EditValue", _row, "UserPass", true));
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
