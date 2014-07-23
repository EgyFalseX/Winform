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
    public partial class JobEditorWFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.dsNU.JobRow _row;
        public JobEditorWFrm(DataSources.dsNU.JobRow row)
        {
            InitializeComponent();
            _row = row;
            jobBindingSource.DataSource = _row;
            JobNameTextEdit.DataBindings.Add(new Binding("EditValue", _row, "JobName", true));
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