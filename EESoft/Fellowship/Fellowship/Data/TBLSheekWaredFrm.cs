
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using FXFW;
using DevExpress.XtraGrid.Views.Grid;

namespace Fellowship
{
    public partial class TBLSheekWaredFrm : XtraForm
    {

        #region -   Functions   -
        public TBLSheekWaredFrm()
        {
            InitializeComponent();
        }
        private void LoadDefaultData(Types.TablesNames TableName)
        {
            switch (TableName)
            {
                case Types.TablesNames.CDSyndicate:
                    cDSyndicateTableAdapter.Fill(dSFellowship.CDSyndicate);
                    break;
                case Types.TablesNames.CDEDARET:
                    cDEDARETTableAdapter.Fill(dSFellowship.CDEDARET);
                    break;
                case Types.TablesNames.TBLEdaraMandop:
                    tBLEdaraMandopTableAdapter.Fill(dSFellowship.TBLEdaraMandop);
                    break;
                case Types.TablesNames.TBLNkapaMandop:
                    tBLNkapaMandopTableAdapter.Fill(dSFellowship.TBLNkapaMandop);
                    break;
                case Types.TablesNames.All:
                    cDSyndicateTableAdapter.Fill(dSFellowship.CDSyndicate);
                    cDEDARETTableAdapter.Fill(dSFellowship.CDEDARET);
                    tBLEdaraMandopTableAdapter.Fill(dSFellowship.TBLEdaraMandop);
                    tBLNkapaMandopTableAdapter.Fill(dSFellowship.TBLNkapaMandop);                    
                    break;
                default:
                    break;
            }
        }
        private void LoadGrid()
        {
            tBLSheekWaredTableAdapter.Fill(dSFellowship.TBLSheekWared);
        }
        private void ActiveKeyDownEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyData != Keys.F5 && e.KeyData != Keys.F6 && e.KeyData != Keys.F10 && e.KeyData != Keys.F8)
                return;
            switch (e.KeyData)
            {
                case Keys.F1:
                    break;
                case Keys.F5:
                    btnNew_Click(btnNew, new EventArgs());
                    break;
                case Keys.F6:
                    repositoryItemButtonEditSave_ButtonClick(repositoryItemButtonEditSave, new DevExpress.XtraEditors.Controls.ButtonPressedEventArgs(new DevExpress.XtraEditors.Controls.EditorButton()));
                    break;
                case Keys.F8:
                    repositoryItemButtonEditDel_ButtonClick(repositoryItemButtonEditDel, new DevExpress.XtraEditors.Controls.ButtonPressedEventArgs(new DevExpress.XtraEditors.Controls.EditorButton()));
                    break;
                case Keys.F10:
                    repositoryItemButtonEditSave_ButtonClick(repositoryItemButtonEditSave, new DevExpress.XtraEditors.Controls.ButtonPressedEventArgs(new DevExpress.XtraEditors.Controls.EditorButton()));
                    break;
                default:
                    break;
            }
        }
        private void ActivePriv()
        {
            return;
            bool Selecting = false, Inserting = false, Updateing = false, Deleting = false;
            SqlDB.GetFormPriv("Fellowship" + Name.Replace("Frm", ""), ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
            gridControlData.Visible = Selecting;
            if (Inserting || Updateing)
                repositoryItemButtonEditSave.Buttons[0].Enabled = true;
            else
                repositoryItemButtonEditSave.Buttons[0].Enabled = false;
            repositoryItemButtonEditDel.Buttons[0].Enabled = Deleting;
        }
#endregion
        #region - Event Handlers -
        private void stu_nashatFrm_Load(object sender, EventArgs e)
        {
            ActivePriv();
            LoadDefaultData(Types.TablesNames.All);
            LoadGrid();
        }
        private void repositoryItemGridLookUpEditEdaraId_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DataSources.DSFellowship.CDEDARETDataTable dt = new DataSources.DSFellowship.CDEDARETDataTable();

            GridView GV = (GridView)gridControlData.MainView;
            Fellowship.DataSources.DSFellowship.TBLSheekWaredRow row = (Fellowship.DataSources.DSFellowship.TBLSheekWaredRow)GV.GetFocusedDataRow();

            if (row == null || row.IsNull("SyndicateId"))
            {
                dt = cDEDARETTableAdapter.GetData();
            }
            else
            {
                dt = cDEDARETTableAdapter.GetDataBy(row.SyndicateId);
            }

            GridLookUpEdit lue = (GridLookUpEdit)sender;
            lue.Properties.DataSource = dt;
            lue.Properties.DisplayMember = "EDARET";
            lue.Properties.ValueMember = "EdaraId";
        }
        private void repositoryItemGridLookUpEditSyndicateId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
            {
                using (CodeFrm Code = new CodeFrm(Types.TablesNames.CDSyndicate))
                {
                    Code.ShowDialog();
                }
                LoadDefaultData(Types.TablesNames.CDSyndicate);
            }
        }
        private void repositoryItemGridLookUpEditEdaraId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
            {
                using (CodeFrm Code = new CodeFrm(Types.TablesNames.CDEDARET))
                {
                    Code.ShowDialog();
                }
                LoadDefaultData(Types.TablesNames.CDEDARET);
            }
        }
        private void repositoryItemGridLookUpEditEdaraMandopId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
            {
                using (TBLEdaraMandopFrm Code = new TBLEdaraMandopFrm())
                {
                    Code.ShowDialog();
                }
                LoadDefaultData(Types.TablesNames.TBLEdaraMandop);
            }
        }
        private void repositoryItemGridLookUpEditnkapaMandopId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
            {
                using (TBLNkapaMandopFrm Code = new TBLNkapaMandopFrm())
                {
                    Code.ShowDialog();
                }
                LoadDefaultData(Types.TablesNames.TBLNkapaMandop);
            }
        }
        private void gridViewData_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            DataRowView DRV = (DataRowView)e.Row;
            //Fellowship.DataSources.DSFellowship.TBLSheekWaredRow row = (Fellowship.DataSources.DSFellowship.TBLSheekWaredRow)DRV.Row;

            if (e.ErrorText.Contains("SyndicateId"))
            {
                e.ErrorText = "من فضلك بجب ادخال الفرعيه";
                return;
            }
            if (e.ErrorText.Contains("EdaraId"))
            {
                e.ErrorText = "من فضلك بجب ادخال الادارة";
                return;
            }
            if (e.ErrorText.Contains("EdaraMandopId"))
            {
                e.ErrorText = "من فضلك بجب ادخال مندوب الادارة";
                return;
            }
            if (e.ErrorText.Contains("nkapaMandopId"))
            {
                e.ErrorText = "من فضلك بجب ادخال مندوب النقابة";
                return;
            }
            if (e.ErrorText.Contains("SheekWaredId"))
            {
                //e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
                DRV["SheekWaredId"] = "-1";
                return;
            }

        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView GV = (GridView)gridControlData.MainView;
            Fellowship.DataSources.DSFellowship.TBLSheekWaredRow row = (Fellowship.DataSources.DSFellowship.TBLSheekWaredRow)GV.GetFocusedDataRow();
            Update(row, false);
        }
        private void repositoryItemButtonEditDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView GV = (GridView)gridControlData.MainView;
            Fellowship.DataSources.DSFellowship.TBLSheekWaredRow row = (Fellowship.DataSources.DSFellowship.TBLSheekWaredRow)GV.GetFocusedDataRow();

            if (row.RowState == DataRowState.Detached)
                return;

            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            try
            {
                tBLSheekWaredTableAdapter.Delete(row.SheekWaredId);
                gridViewData.DeleteRow(GV.FocusedRowHandle);
                
                Program.ShowMsg("تم الحذف", false, this);
                Program.Logger.LogThis("تم الحذف", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (Exception ex)
            {
                Program.ShowMsg(Misc.Misc.ExceptionMessage(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, ex, null, this);
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            DataSources.DSFellowship.TBLSheekWaredRow row = dSFellowship.TBLSheekWared.NewTBLSheekWaredRow();
            Update(row, false);
        }
        private void Update(DataSources.DSFellowship.TBLSheekWaredRow row, bool MonthTabFocus)
        {
            bool openMonth = false;
            using (TBLSheekWaredWFrm frm = new TBLSheekWaredWFrm(row, MonthTabFocus))
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                    return;
                try
                {
                    if (row.RowState == DataRowState.Detached)
                    {
                        row.SheekWaredId = Convert.ToInt64(SqlDB.GetNewID("TBLSheekWared", "SheekWaredId"));
                        dSFellowship.TBLSheekWared.AddTBLSheekWaredRow(row);
                        openMonth = true;
                    }
                    tBLSheekWaredBindingSource.EndEdit();
                    tBLSheekWaredTableAdapter.Update(row);
                    dSFellowship.TBLSheekWared.AcceptChanges();
                    frm.tBLSheekMonthBindingSource.EndEdit();
                    frm.tBLSheekMonthTableAdapter.Update(frm.dSFellowship.TBLSheekMonth);
                    frm.dSFellowship.TBLSheekMonth.AcceptChanges();
                    Program.ShowMsg("تم الحفظ", false, this);
                    Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
                }
                catch (Exception ex)
                {
                    Program.ShowMsg(Misc.Misc.ExceptionMessage(ex), true, this);
                    Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, ex, null, this);
                }
            }
            if (openMonth)
            {
                Update(row, true);
            }
        }

#endregion

    }
}