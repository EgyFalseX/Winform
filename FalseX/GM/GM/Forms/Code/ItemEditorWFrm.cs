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
    public partial class ItemEditorWFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.dsGM.ItemRow _row;
        public ItemEditorWFrm(DataSources.dsGM.ItemRow row)
        {
            InitializeComponent();
            _row = row;

            DataBindingSource.DataSource = _row;
            ItemNameTextEdit.DataBindings.Add(new Binding("EditValue", _row, "ItemName", true));
            ItemPointTextEdit.DataBindings.Add(new Binding("EditValue", _row, "ItemPoint", true));
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