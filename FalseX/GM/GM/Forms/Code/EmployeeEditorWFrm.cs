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
    public partial class EmployeeEditorWFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.dsGM.EmployeeRow _row;
        public EmployeeEditorWFrm(DataSources.dsGM.EmployeeRow row)
        {
            InitializeComponent();
            _row = row;

            DataBindingSource.DataSource = _row;
            EmployeeNameTextEdit.DataBindings.Add(new Binding("EditValue", _row, "EmployeeName", true));
            EmployeePhoneTextEdit.DataBindings.Add(new Binding("EditValue", _row, "EmployeePhone", true));
            EmployeeAddressTextEdit.DataBindings.Add(new Binding("EditValue", _row, "EmployeeAddress", true));

            if (!_row.IsAreaIdNull())
            {
                GovIdGridLookUpEdit.EditValue = areaTableAdapter.GetGovId(row.AreaId);
            }
            AreaIdGridLookUpEdit.DataBindings.Add(new Binding("EditValue", _row, "AreaId", true));
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
        private void GovIdGridLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (GovIdGridLookUpEdit.EditValue == null)
                return;
            areaTableAdapter.FillByGovId(dsGM.Area, Convert.ToInt32(GovIdGridLookUpEdit.EditValue));
        }
    }
}