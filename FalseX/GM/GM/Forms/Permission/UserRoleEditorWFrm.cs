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
    public partial class UserRoleEditorWFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.dsGM.UserRoleRow _row;
        public UserRoleEditorWFrm(DataSources.dsGM.UserRoleRow row)
        {
            InitializeComponent();
            _row = row;

            DataBindingSource.DataSource = _row;
            RoleLUE.DataBindings.Add(new Binding("EditValue", _row, "Role", true));
        }
        private void Frm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsGM.Role' table. You can move, or remove it, as needed.
            this.roleTableAdapter.Fill(this.dsGM.Role);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dxValidationProviderEditor.Validate())
                DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
