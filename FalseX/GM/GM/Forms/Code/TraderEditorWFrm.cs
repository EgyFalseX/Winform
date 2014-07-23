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
    public partial class TraderEditorWFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.dsGM.TraderRow _row;
        public TraderEditorWFrm(DataSources.dsGM.TraderRow row)
        {
            InitializeComponent();
            _row = row;

            DataBindingSource.DataSource = _row;

            TraderNameTextEdit.DataBindings.Add(new Binding("EditValue", _row, "TraderName", true));
            TraderSiteNameTextEdit.DataBindings.Add(new Binding("EditValue", _row, "TraderSiteName", true));
            TraderPhoneTextEdit.DataBindings.Add(new Binding("EditValue", _row, "TraderPhone", true));
            TraderMobileTextEdit.DataBindings.Add(new Binding("EditValue", _row, "TraderMobile", true));
            TraderAddressTextEdit.DataBindings.Add(new Binding("EditValue", _row, "TraderAddress", true));

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