using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System.Threading;

namespace Members
{
    public partial class TBLHafzaTasleemWFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.dsTeachersUnion.TBLHafzaTasleemRow _row;
        public TBLHafzaTasleemWFrm()
        {
            InitializeComponent();
        }
        public TBLHafzaTasleemWFrm(DataSources.dsTeachersUnion.TBLHafzaTasleemRow row)
        {
            InitializeComponent();
            _row = row;
        }
        private void LoadBinding()
        {
            if (!_row.IsNull("HafzaDate"))
                deHafzaDate.EditValue = _row.HafzaDate;
            if (!_row.IsNull("SyndicateId"))
                lueSyndicateId.EditValue = _row.SyndicateId;
            if (!_row.IsNull("ISMandoop"))
                ceISMandoop.EditValue = _row.ISMandoop;
            if (!_row.IsNull("Hafzaperson"))
                lueHafzaperson.EditValue = _row.Hafzaperson;
            if (!_row.IsNull("HafzapersonText"))
                tbHafzapersonText.EditValue = _row.HafzapersonText;
            if (!_row.IsNull("HafzaRemark"))
                tbHafzaRemark.EditValue = _row.HafzaRemark;
            if (!_row.IsNull("hclose"))
            {
                cehclose.EditValue = _row.hclose;
                if (_row.hclose == true)
                    btnSave.Enabled = false;
            }
        }
        private void FormWFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsTeachersUnion.TBLMandoop' table. You can move, or remove it, as needed.
            this.tBLMandoopTableAdapter.FillByactive(this.dsTeachersUnion.TBLMandoop, true);
            // TODO: This line of code loads data into the 'dsTeachersUnion.CDSyndicate' table. You can move, or remove it, as needed.
            this.cDSyndicateTableAdapter.Fill(this.dsTeachersUnion.CDSyndicate);
           
            if (_row.RowState == DataRowState.Detached)
                xtraTabPageDetails.PageVisible = false;
            else
                this.tBLHafzaTasleemDeyailsTableAdapter.FillByHafzaId(this.dsTeachersUnion.TBLHafzaTasleemDeyails, _row.HafzaId);
            
            if (!_row.IshcloseNull() && _row.hclose)
            {
                cehclose.Enabled = false;
                gridViewData.OptionsBehavior.Editable = false;
                gridViewData.OptionsBehavior.ReadOnly = true;
                gridViewData.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                btnAddSelected.Enabled = false;
            }
            if (!_row.IshcloseNull() && _row.ISMandoop)
                tbHafzapersonText.Enabled = false;
            else
                lueHafzaperson.Enabled = false;
            LoadBinding();
            
            
        }
        private void ceISMandoop_CheckedChanged(object sender, EventArgs e)
        {
            lueHafzaperson.Enabled = ceISMandoop.Checked;
            tbHafzapersonText.Enabled = !ceISMandoop.Checked;
        }
        private void xtraTabControlMain_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (e.Page != xtraTabPageDetails || dsTeachersUnion.TBLPrintCardList.Count != 0)
                return;
            if (_row.RowState != DataRowState.Detached)
            {
                ThreadPool.QueueUserWorkItem((o) =>
                {
                    DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
                    this.gridControlData.Invoke(new MethodInvoker(() =>
                    {
                        this.tBLPrintCardListTableAdapter.Fill(this.dsTeachersUnion.TBLPrintCardList);
                        if (!_row.IsHafzaRemarkNull())
                            gridViewOptions.ActiveFilterString = string.Format("esalno = '{0}'", _row.HafzaRemark);
                    }));
                    DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm();
                });
                //if (!_row.IsHafzaRemarkNull() && _row.HafzaRemark != string.Empty)
                //    this.tBLPrintCardListTableAdapter.FillByesalno(this.dsTeachersUnion.TBLPrintCardList, Convert.ToInt32(_row.HafzaRemark));
                //else
                //    this.tBLPrintCardListTableAdapter.Fill(this.dsTeachersUnion.TBLPrintCardList);
            }
        }
        private void lueHafzaperson_QueryPopUp(object sender, CancelEventArgs e)
        {
            if (lueSyndicateId.EditValue == null)
                tBLMandoopBindingSource.Filter = "";
            else
                tBLMandoopBindingSource.Filter = "SyndicateId=" + lueSyndicateId.EditValue;
        }
        private void lueHafzaperson_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)
            {
                if (lueHafzaperson.EditValue == null)
                    return;
                DataSources.dsTeachersUnion.TBLMandoopRow row = (DataSources.dsTeachersUnion.TBLMandoopRow)((DataRowView)lueHafzaperson.GetSelectedDataRow()).Row;
                if (row.IsNull("MandoopImg"))
                {
                    MessageBox.Show("لا يوجد صورة", "بيانات غير مكتمله", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (System.IO.File.Exists(Program.MandoopImgPath + row.MandoopImg))
                {
                    ImgViewerFrm frm = new ImgViewerFrm();
                    frm.Img.ImageLocation = Program.MandoopImgPath + row.MandoopImg;
                    frm.ShowDialog();
                }
                else
                    MessageBox.Show("الملف غير موجود", "ملف مفقود", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void gridViewTBLHafzaTasleem_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DataSources.dsTeachersUnion.TBLHafzaTasleemDeyailsRow row = (DataSources.dsTeachersUnion.TBLHafzaTasleemDeyailsRow)gridViewData.GetDataRow(e.RowHandle);
            row.HafzaId = _row.HafzaId;
        }
        private void repositoryItemButtonEditDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            gridViewData.DeleteRow(gridViewData.FocusedRowHandle);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
            

            if (deHafzaDate.EditValue != null)
                _row.HafzaDate = Convert.ToDateTime(deHafzaDate.EditValue);
            if (lueSyndicateId.EditValue != null)
                _row.SyndicateId = Convert.ToInt32(lueSyndicateId.EditValue);
            if (ceISMandoop.EditValue != null)
                _row.ISMandoop = Convert.ToBoolean(ceISMandoop.EditValue);
            if (lueHafzaperson.EditValue != null)
                _row.Hafzaperson = Convert.ToInt32(lueHafzaperson.EditValue);
            if (tbHafzapersonText.EditValue != null)
                _row.HafzapersonText = tbHafzapersonText.EditValue.ToString();
            if (tbHafzaRemark.EditValue != null)
                _row.HafzaRemark = tbHafzaRemark.EditValue.ToString();
            if (cehclose.EditValue != null)
                _row.hclose = Convert.ToBoolean(cehclose.EditValue);
            _row.userin = Program.UserInfo.UserId;
            
            if (_row.RowState != DataRowState.Detached)
                tBLHafzaTasleemDeyailsTableAdapter.Update(dsTeachersUnion.TBLHafzaTasleemDeyails);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void ceAll_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < gridViewOptions.RowCount; i++)
            {
                gridViewOptions.SetRowCellValue(i, gcSelected, ceAll.Checked);
            }
        }
        private void btnAddSelected_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gridViewOptions.RowCount; i++)
            {
                DataSources.dsTeachersUnion.TBLPrintCardListRow row = (DataSources.dsTeachersUnion.TBLPrintCardListRow)gridViewOptions.GetDataRow(i);
                if (!row.Selected)
                    continue;
                try
                {
                    DataSources.dsTeachersUnion.TBLHafzaTasleemDeyailsRow newRow = dsTeachersUnion.TBLHafzaTasleemDeyails.NewTBLHafzaTasleemDeyailsRow();
                    newRow.HafzaId = _row.HafzaId; newRow.MemberId = row.MemberId;
                    dsTeachersUnion.TBLHafzaTasleemDeyails.AddTBLHafzaTasleemDeyailsRow(newRow);
                }
                catch
                {
                    //MessageBox.Show(ex.Message);
                }
            }
        }

        

    }
}