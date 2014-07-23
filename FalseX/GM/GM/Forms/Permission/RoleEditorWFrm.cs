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
    public partial class RoleEditorWFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.dsGM.RoleRow _row;
        public RoleEditorWFrm(DataSources.dsGM.RoleRow row)
        {
            InitializeComponent();
            _row = row;

            DataBindingSource.DataSource = _row;
            RoleNameTextEdit.DataBindings.Add(new Binding("EditValue", _row, "RoleName", true));
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
