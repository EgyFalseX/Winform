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
    public partial class EmployeeEditorWFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.dsNU.EmployeeRow _row;
        public EmployeeEditorWFrm(DataSources.dsNU.EmployeeRow row)
        {
            InitializeComponent();
            // TODO: This line of code loads data into the 'dsNU.Area' table. You can move, or remove it, as needed.
            this.areaTableAdapter.Fill(this.dsNU.Area);
            // TODO: This line of code loads data into the 'dsNU.Job' table. You can move, or remove it, as needed.
            this.jobTableAdapter.Fill(this.dsNU.Job);
            _row = row;
            employeeBindingSource.DataSource = _row;
            EmployeeNameTextEdit.DataBindings.Add(new Binding("EditValue", _row, "EmployeeName", true));
            JobIdGridLookUpEdit.DataBindings.Add(new Binding("EditValue", _row, "JobId", true));
            AreaIdGridLookUpEdit.DataBindings.Add(new Binding("EditValue", _row, "AreaId", true));
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