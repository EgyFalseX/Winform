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
    public partial class BranchEditorWFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.dsNU.BranchRow _row;
        public BranchEditorWFrm(DataSources.dsNU.BranchRow row)
        {
            InitializeComponent();
            _row = row;
            // TODO: This line of code loads data into the 'dsNU.Job' table. You can move, or remove it, as needed.
            this.jobTableAdapter.Fill(this.dsNU.Job);
            // TODO: This line of code loads data into the 'dsNU.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.dsNU.Employee);
            // TODO: This line of code loads data into the 'dsNU.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.dsNU.Customers);

            branchBindingSource.DataSource = _row;
            BranchNameTextEdit.DataBindings.Add(new Binding("EditValue", _row, "BranchName", true));
            CustomerIdLookUpEdit.DataBindings.Add(new Binding("EditValue", _row, "CustomerId", true));
            SupervisorIdLookUpEdit.DataBindings.Add(new Binding("EditValue", _row, "SupervisorId", true));
            BranchAddressTextEdit.DataBindings.Add(new Binding("EditValue", _row, "BranchAddress", true));
            BranchPhoneTextEdit.DataBindings.Add(new Binding("EditValue", _row, "BranchPhone", true));
            BranchMobileTextEdit.DataBindings.Add(new Binding("EditValue", _row, "BranchMobile", true));
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