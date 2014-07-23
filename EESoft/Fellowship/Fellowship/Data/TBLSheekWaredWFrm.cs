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
    public partial class TBLSheekWaredWFrm : DevExpress.XtraEditors.XtraForm
    {
       
        DataSources.DSFellowship.TBLSheekWaredRow _row;
        bool _MonthTabFocus;

        public TBLSheekWaredWFrm()
        {
            InitializeComponent();
        }
        public TBLSheekWaredWFrm(DataSources.DSFellowship.TBLSheekWaredRow row , bool MonthTabFocus)
        {
            InitializeComponent();
            _row = row;
            _MonthTabFocus = MonthTabFocus;
        }
        private void LoadData()
        {
            // TODO: This line of code loads data into the 'dSFellowship.CDSyndicate' table. You can move, or remove it, as needed.
            this.cDSyndicateTableAdapter.Fill(this.dSFellowship.CDSyndicate);
            // TODO: This line of code loads data into the 'dSFellowship.CDEDARET' table. You can move, or remove it, as needed.
            this.cDEDARETTableAdapter.Fill(this.dSFellowship.CDEDARET);
            // TODO: This line of code loads data into the 'dSFellowship.TBLNkapaMandop' table. You can move, or remove it, as needed.
            this.tBLNkapaMandopTableAdapter.Fill(this.dSFellowship.TBLNkapaMandop);
            // TODO: This line of code loads data into the 'dSFellowship.TBLEdaraMandop' table. You can move, or remove it, as needed.
            this.tBLEdaraMandopTableAdapter.Fill(this.dSFellowship.TBLEdaraMandop);
            // TODO: This line of code loads data into the 'dSFellowship.TBLSheekMonth' table. You can move, or remove it, as needed.
            if (_row.RowState != DataRowState.Detached)
            {
                tBLSheekMonthTableAdapter.FillBySheekWaredId(dSFellowship.TBLSheekMonth, _row.SheekWaredId);
                xtpMonths.PageEnabled = true;
                if (_MonthTabFocus)
                    xtraTabControl1.SelectedTabPage = xtpMonths;
            }
            else
                xtpMonths.PageEnabled = false;
        }
        private void LoadBinding()
        {
            if (!_row.IsNull("SheekMony"))
                tbSheekMony.EditValue = _row.SheekMony;
            if (!_row.IsNull("SheekNo"))
                tbSheekNo.EditValue = _row.SheekNo;
            if (!_row.IsNull("SheekDate"))
                deSheekDate.EditValue = _row.SheekDate;
            if (!_row.IsNull("EdaraSarfDate"))
                deEdaraSarfDate.EditValue = _row.EdaraSarfDate;
            if (!_row.IsNull("NkapaSarfDate"))
                deNkapaSarfDate.EditValue = _row.NkapaSarfDate;
            if (!_row.IsNull("EdaraMandopId"))
                lueEdaraMandopId.EditValue = _row.EdaraMandopId;
            if (!_row.IsNull("nkapaMandopId"))
                luenkapaMandopId.EditValue = _row.nkapaMandopId;
            if (!_row.IsNull("SyndicateId"))
                lueSyndicateId.EditValue = _row.SyndicateId;
            if (!_row.IsNull("EdaraId"))
                lueEdaraId.EditValue = _row.EdaraId;
            
            //_row.SheekMony = _row.IsSheekMonyNull() ? new double() : _row.SheekMony;
            //_row.SheekNo = _row.IsSheekNoNull() ? string.Empty : _row.SheekNo;
            //_row.SheekDate = _row.IsSheekDateNull() ? new DateTime() : _row.SheekDate;
            //_row.SheekMonth = _row.IsSheekMonthNull() ? new byte() : _row.SheekMonth;
            //_row.EdaraSarfDate = _row.IsEdaraSarfDateNull() ? new DateTime() : _row.EdaraSarfDate;
            //_row.NkapaSarfDate = _row.IsNkapaSarfDateNull() ? new DateTime() : _row.NkapaSarfDate;
            //_row.EdaraMandopId = _row.IsNull("EdaraMandopId") ? new int() : _row.EdaraMandopId;
            //_row.nkapaMandopId = _row.IsNull("nkapaMandopId") ? new int() : _row.nkapaMandopId;
            //_row.SyndicateId = _row.IsNull("SyndicateId") ? new int() : _row.SyndicateId;
            //_row.EdaraId = _row.IsNull("EdaraId") ? new int() : _row.EdaraId;

            //tbSheekMony.DataBindings.Add("EditValue", _row, "SheekMony");
            //tbSheekNo.DataBindings.Add("EditValue", _row, "SheekNo");
            //deSheekDate.DataBindings.Add("EditValue", _row, "SheekDate");
            //lueSheekMonth.DataBindings.Add("EditValue", _row, "SheekMonth");
            //deEdaraSarfDate.DataBindings.Add("EditValue", _row, "EdaraSarfDate");
            //deNkapaSarfDate.DataBindings.Add("EditValue", _row, "NkapaSarfDate");
            //lueEdaraMandopId.DataBindings.Add("EditValue", _row, "EdaraMandopId");
            //luenkapaMandopId.DataBindings.Add("EditValue", _row, "nkapaMandopId");
            //lueSyndicateId.DataBindings.Add("EditValue", _row, "SyndicateId");
            //lueEdaraId.DataBindings.Add("EditValue", _row, "EdaraId");

            
        }
        private void TBLSheekWaredWFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSFellowship.CD_YEAR' table. You can move, or remove it, as needed.
            this.cD_YEARTableAdapter.Fill(this.dSFellowship.CD_YEAR);
            // TODO: This line of code loads data into the 'dSFellowship.CDMonth' table. You can move, or remove it, as needed.
            this.cDMonthTableAdapter.Fill(this.dSFellowship.CDMonth);
            // TODO: This line of code loads data into the 'dSFellowship.TBLSheekMonth' table. You can move, or remove it, as needed.
            this.tBLSheekMonthTableAdapter.Fill(this.dSFellowship.TBLSheekMonth);
            LoadData();
            LoadBinding();
        }
        private void lueSyndicateId_EditValueChanged(object sender, EventArgs e)
        {
            DataSources.DSFellowship.CDEDARETDataTable dt = new DataSources.DSFellowship.CDEDARETDataTable();

            if (lueSyndicateId.EditValue == null)
            {
                dt = cDEDARETTableAdapter.GetData();
            }
            else
            {
                dt = cDEDARETTableAdapter.GetDataBy((int)lueSyndicateId.EditValue);
            }

            lueEdaraId.Properties.DataSource = dt;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            //if (lueEdaraMandopId.EditValue == null || luenkapaMandopId.EditValue == null ||
            //    lueSyndicateId.EditValue == null ||lueSyndicateId.EditValue == null)
            //{
            //    Program.ShowMsg("البيانات غير مكتمله", true, this);
            //    return;
            //}

            DialogResult = System.Windows.Forms.DialogResult.OK;

            if (tbSheekMony.EditValue != null)
                _row.SheekMony = Convert.ToDouble(tbSheekMony.EditValue);
            if (tbSheekNo.EditValue != null)
                _row.SheekNo = tbSheekNo.EditValue.ToString();
            if (deSheekDate.EditValue != null)
                _row.SheekDate = Convert.ToDateTime(deSheekDate.EditValue);
            if (deEdaraSarfDate.EditValue != null)
                _row.EdaraSarfDate = Convert.ToDateTime(deEdaraSarfDate.EditValue);
            if (deNkapaSarfDate.EditValue != null)
                _row.NkapaSarfDate = Convert.ToDateTime(deNkapaSarfDate.EditValue);
            if (lueEdaraMandopId.EditValue != null)
                _row.EdaraMandopId = Convert.ToInt32(lueEdaraMandopId.EditValue);
            if (luenkapaMandopId.EditValue != null)
                _row.nkapaMandopId = Convert.ToInt32(luenkapaMandopId.EditValue);
            if (lueSyndicateId.EditValue != null)
                _row.SyndicateId = Convert.ToInt32(lueSyndicateId.EditValue);
            if (lueEdaraId.EditValue != null)
                _row.EdaraId = Convert.ToInt32(lueEdaraId.EditValue);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void gridViewData_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            GridView GV = (GridView)gridControlData.MainView;
            Fellowship.DataSources.DSFellowship.TBLSheekMonthRow row = (Fellowship.DataSources.DSFellowship.TBLSheekMonthRow)GV.GetDataRow(e.RowHandle);
            row.SheekWaredId = _row.SheekWaredId;
          
        }
        private void repositoryItemButtonEditDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            GridView GV = (GridView)gridControlData.MainView;
            dSFellowship.TBLSheekMonth.Rows[GV.GetFocusedDataSourceRowIndex()].Delete();
                       
        }

    }
}