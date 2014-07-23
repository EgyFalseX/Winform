using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace Fellowship
{
    public partial class TBLHafzaTasleemWFrm : DevExpress.XtraEditors.XtraForm
    {

        DataSources.DSFellowship.TblHafzaEstlamRow _row;
        public TBLHafzaTasleemWFrm()
        {
            InitializeComponent();
        }
        public TBLHafzaTasleemWFrm(DataSources.DSFellowship.TblHafzaEstlamRow row)
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
            if (!_row.IsNull("hclose"))
            {
                cehclose.EditValue = _row.hclose;
                if (_row.hclose == true)
                    btnSave.Enabled = false;
            }
        }
        private void FormWFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSFellowship.TblHafzaEstlamDetails' table. You can move, or remove it, as needed.
            this.tblHafzaEstlamDetailsTableAdapter.Fill(this.dSFellowship.TblHafzaEstlamDetails);
            // TODO: This line of code loads data into the 'dSFellowship.TBLNkapaMandop' table. You can move, or remove it, as needed.
            this.tBLNkapaMandopTableAdapter.Fill(this.dSFellowship.TBLNkapaMandop);
            // TODO: This line of code loads data into the 'dSFellowship.CDSyndicate' table. You can move, or remove it, as needed.
            this.cDSyndicateTableAdapter.Fill(this.dSFellowship.CDSyndicate);

            if (_row.RowState == DataRowState.Detached)
                xtraTabPageDetails.PageVisible = false;
            else
            {
                // TODO: This line of code loads data into the 'dSFellowshipQuery.TblMember' table. You can move, or remove it, as needed.
                this.tblMemberTableAdapter.Fill(this.dSFellowshipQuery.TblMember);
                this.tblHafzaEstlamDetailsTableAdapter.FillByHafzaId(this.dSFellowship.TblHafzaEstlamDetails, _row.HafzaId);
            }
            

            if (!_row.IshcloseNull() && _row.hclose)
            {
                cehclose.Enabled = false;
                gridViewData.OptionsBehavior.Editable = false;
                gridViewData.OptionsBehavior.ReadOnly = true;
                gridViewData.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                btnAddSelected.Enabled = false;
            }
            if (!_row.IshcloseNull() && _row.ISMandoop)
                lueHafzaperson.Enabled = true;
            else
                lueHafzaperson.Enabled = false;
            LoadBinding();
        }
        private void ceISMandoop_CheckedChanged(object sender, EventArgs e)
        {
            lueHafzaperson.Enabled = ceISMandoop.Checked;
        }
        private void lueHafzaperson_QueryPopUp(object sender, CancelEventArgs e)
        {
            //if (lueSyndicateId.EditValue == null)
            //    tBLMandoopBindingSource.Filter = "";
            //else
            //    tBLMandoopBindingSource.Filter = "SyndicateId=" + lueSyndicateId.EditValue;
        }
        private void lueHafzaperson_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)
            {
                //if (lueHafzaperson.EditValue == null)
                //    return;
                //DataSources.DSFellowship.TBLNkapaMandopRow row = (DataSources.DSFellowship.TBLNkapaMandopRow)((DataRowView)lueHafzaperson.GetSelectedDataRow()).Row;
                //if (row.IsNull("MandoopImg"))
                //{
                //    MessageBox.Show("لا يوجد صورة", "بيانات غير مكتمله", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    return;
                //}
                //if (System.IO.File.Exists(Program.MandoopImgPath + row.MandoopImg))
                //{
                //    ImgViewerFrm frm = new ImgViewerFrm();
                //    frm.Img.ImageLocation = Program.MandoopImgPath + row.MandoopImg;
                //    frm.ShowDialog();
                //}
                //else
                //    MessageBox.Show("الملف غير موجود", "ملف مفقود", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void gridViewTBLHafzaTasleem_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DataSources.DSFellowship.TblHafzaEstlamDetailsRow row = (DataSources.DSFellowship.TblHafzaEstlamDetailsRow)gridViewData.GetDataRow(e.RowHandle);
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
           
            if (cehclose.EditValue != null)
                _row.hclose = Convert.ToBoolean(cehclose.EditValue);
            _row.userin = Program.UserInfo.UserId;
            
            if (_row.RowState != DataRowState.Detached)
                tblHafzaEstlamDetailsTableAdapter.Update(dSFellowship.TblHafzaEstlamDetails);
            
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
                DataSources.DSFellowshipQuery.TblMemberRow row = (DataSources.DSFellowshipQuery.TblMemberRow)gridViewOptions.GetDataRow(i);
                if (!row.Selected)
                    continue;
                try
                {
                    DataSources.DSFellowship.TblHafzaEstlamDetailsRow newRow = dSFellowship.TblHafzaEstlamDetails.NewTblHafzaEstlamDetailsRow();
                    newRow.HafzaId = _row.HafzaId; newRow.MemberID = row.MemberID;
                    dSFellowship.TblHafzaEstlamDetails.AddTblHafzaEstlamDetailsRow(newRow);
                }
                catch
                {
                    //MessageBox.Show(ex.Message);
                }
            }
        }

    }
}