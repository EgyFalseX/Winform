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
    public partial class AreaEditorWFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.dsGM.AreaRow _row;
        public AreaEditorWFrm(DataSources.dsGM.AreaRow row)
        {
            InitializeComponent();
            _row = row;

            DataBindingSource.DataSource = _row;
            AreaNameTextEdit.DataBindings.Add(new Binding("EditValue", _row, "AreaName", true));
            GovIdGridLookUpEdit.DataBindings.Add(new Binding("EditValue", _row, "GovId", true));
        }
        private void Frm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsGM.Gov' table. You can move, or remove it, as needed.
            this.govTableAdapter.Fill(this.dsGM.Gov);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dxValidationProviderEditor.Validate())
                DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
