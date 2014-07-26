using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System.Linq;

namespace RetirementCenter
{
    public partial class TBLProofDocWFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.dsRetirementCenter.TBLProofDocRow _row;
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext();
        bool _Insert, _Update, _Delete;
        public TBLProofDocWFrm()
        {
            InitializeComponent();
        }
        public TBLProofDocWFrm(DataSources.dsRetirementCenter.TBLProofDocRow row, bool insert, bool update, bool delete)
        {
            InitializeComponent();
            _row = row;
            _Insert = insert;
            _Update = update;
            _Delete = delete;
            
        }
        private void ActivePriv()
        {
        }
        private void LoadBinding()
        {
            if (!_row.IsMMashatIdNull())
            {
                lueMMashatId.EditValue = _row.MMashatId;
                ceYasref.EditValue = tblMashatTableAdapter.GetDataByMMashatId(_row.MMashatId)[0].yasref;
            }
            if (!_row.IsDocDateNull())
            {
                deDocDate.EditValue = _row.DocDate;
            }
            if (!_row.IsmemoNull())
            {
                tbmemo.EditValue = _row.memo;
            }
        }
        
        private void FormWFrm_Load(object sender, EventArgs e)
        {
            ActivePriv();
            System.Threading.ThreadPool.QueueUserWorkItem((o) => 
            {
                this.Invoke(new MethodInvoker(() => {
                    LSMSMMashatId.QueryableSource = dsLinq.vTBLMashats;
                }));
                
            });
            LoadBinding();
        }
        private void lueMMashatId_EditValueChanged(object sender, EventArgs e)
        {
            if (lueMMashatId.EditValue == null || lueMMashatId.EditValue.ToString() == string.Empty)
            {
                return;
            }
            ceYasref.EditValue = tblMashatTableAdapter.GetDataByMMashatId(Convert.ToInt32(lueMMashatId.EditValue))[0].yasref;
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;

            if (!FXFW.SqlDB.IsNullOrEmpty(lueMMashatId.EditValue))
                _row.MMashatId = Convert.ToInt32(lueMMashatId.EditValue);
            if (!FXFW.SqlDB.IsNullOrEmpty(deDocDate.EditValue))
                _row.DocDate = Convert.ToDateTime(deDocDate.EditValue);
            if (!FXFW.SqlDB.IsNullOrEmpty(tbmemo.EditValue))
                _row.memo = tbmemo.EditValue.ToString();
            _row.datein = SQLProvider.ServerDateTime();
            _row.userin = Program.UserInfo.UserId;



            DataSources.dsRetirementCenter.TBLMashatRow Mainrow = tblMashatTableAdapter.GetDataByMMashatId(Convert.ToInt32(lueMMashatId.EditValue))[0];

            if (Mainrow.yasref == ceYasref.Checked)
                return;
            if (msgDlg.Show("سوف يتم تعديل حقل يصرف لهذا العضو طبقا لاختيارك" + Environment.NewLine + "هل ترغب في ذلك؟", msgDlg.msgButtons.YesNo) != System.Windows.Forms.DialogResult.Yes)
                return;

            //Update Yasref for selected Member
            DataSources.dsRetirementCenter.TBLNoSarfDetelsRow rowNoSarfDetels = dsRetirementCenter.TBLNoSarfDetels.NewTBLNoSarfDetelsRow();
            rowNoSarfDetels.MMashatId = _row.MMashatId; rowNoSarfDetels.datehala = deDocDate.DateTime; rowNoSarfDetels.halarem = tbmemo.EditValue.ToString();
            rowNoSarfDetels.userin = _row.userin; rowNoSarfDetels.datein = _row.datein; rowNoSarfDetels.yasref = ceYasref.Checked;

            DataSources.dsRetirementCenterTableAdapters.TBLNoSarfDetelsTableAdapter adp = new DataSources.dsRetirementCenterTableAdapters.TBLNoSarfDetelsTableAdapter();
            dsRetirementCenter.TBLNoSarfDetels.AddTBLNoSarfDetelsRow(rowNoSarfDetels);
            adp.Update(dsRetirementCenter.TBLNoSarfDetels);

            tblMashatTableAdapter.UpdateQueryYasref(ceYasref.Checked, _row.datein, _row.userin, _row.MMashatId);

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
       
    }
}
