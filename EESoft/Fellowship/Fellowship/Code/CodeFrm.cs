using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using DevExpress.XtraEditors.Repository;
using Fellowship.Types;
using FXFW;
using DevExpress.XtraGrid.Views.Grid;

namespace Fellowship
{
    public partial class CodeFrm : XtraForm
    {
        #region -   Variables   -
        public bool ExitAfterSave = false;
        private readonly TablesNames ViewName;
        #endregion
        #region -   Functions   -
        public CodeFrm(TablesNames CodeName)
        {
            //cDSyndicateTableAdapter.Connection.ConnectionString = SqlDB.SqlConStr;
            //cDEDARETTableAdapter.Connection.ConnectionString = SqlDB.SqlConStr;
            //cDModereaTableAdapter.Connection.ConnectionString = SqlDB.SqlConStr;

            InitializeComponent();
            ViewName = CodeName;
            switch (CodeName)
            {
                case TablesNames.CDSyndicate:
                    gridControlCode.MainView = gridViewCDSyndicate;
                    cDSyndicateTableAdapter.Fill(dSFellowship.CDSyndicate);
                    gridControlCode.DataSource = cDSyndicateBindingSource;
                    Text += " النقابات الفرعية";
                    break;
                case TablesNames.CDEDARET:
                    cDModereaTableAdapter.Fill(dSFellowship.CDModerea);
                    cDSyndicateTableAdapter.Fill(dSFellowship.CDSyndicate);

                    gridControlCode.MainView = gridViewCDEDARET;
                    cDEDARETTableAdapter.Fill(dSFellowship.CDEDARET);
                    gridControlCode.DataSource = cDEDARETBindingSource;
                    Text += " الادارات";
                    break;
                case TablesNames.CDModerea:
                    gridControlCode.MainView = gridViewCDModerea;
                    cDModereaTableAdapter.Fill(dSFellowship.CDModerea);
                    gridControlCode.DataSource = cDModereaBindingSource;
                    Text += " المديريات";
                    break;
                case TablesNames.CDState:
                    gridControlCode.MainView = gridViewCDState;
                    cDStateTableAdapter.Fill(dSFellowship.CDState);
                    gridControlCode.DataSource = cDStateBindingSource;
                    Text += " الانواع";
                    break;
                case TablesNames.CDJob:
                    gridControlCode.MainView = gridViewCDJob;
                    cDJobTableAdapter.Fill(dSFellowship.CDJob);
                    gridControlCode.DataSource = cDJobBindingSource;
                    Text += " الوظائف";
                    break;
                case TablesNames.CDAttach:
                    gridControlCode.MainView = gridViewCDAttach;
                    cDAttachTableAdapter.Fill(dSFellowship.CDAttach);
                    gridControlCode.DataSource = cDAttachBindingSource;
                    Text += " المرفقات";
                    break;
                default:
                    break;
            }
            ((GridView)gridControlCode.MainView).BestFitColumns();
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
                    ((DataTable)gridControlCode.DataSource).Rows.Add(((DataTable)gridControlCode.DataSource).NewRow());
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
            bool Selecting = false, Inserting = false, Updateing = false, Deleting = false;
            FXFW.SqlDB.GetFormPriv("Fellowship" + ViewName.ToString(), ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
            gridControlCode.Visible = Selecting;
            if (Inserting || Updateing)
                repositoryItemButtonEditSave.Buttons[0].Enabled = true;
            else
                repositoryItemButtonEditSave.Buttons[0].Enabled = false;
            repositoryItemButtonEditDel.Buttons[0].Enabled = Deleting;
        }
        #endregion
        #region - Event Handlers -
        private void CodeFrm_Load(object sender, EventArgs e)
        {
           // ActivePriv();
        }
        private void gridViewX_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
            //DataRowView DRV = (DataRowView)e.Row;
            //if (e.ErrorText.Contains("nkapaMandopId"))
            //{
            //    DRV["nkapaMandopId"] = "-1";
            //    return;
            //}
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView GV =  (GridView)gridControlCode.MainView;
            try
            {
                switch (gridControlCode.MainView.Name)
                {
                    case "gridViewCDSyndicate":
                        Fellowship.DataSources.DSFellowship.CDSyndicateRow rowCDSyndicate = (Fellowship.DataSources.DSFellowship.CDSyndicateRow)GV.GetFocusedDataRow();
                        if (rowCDSyndicate.RowState == DataRowState.Detached)
                            rowCDSyndicate.SyndicateId = Convert.ToInt32(SqlDB.GetNewID("CDSyndicate", "SyndicateId"));
                        cDSyndicateBindingSource.EndEdit();
                        cDSyndicateTableAdapter.Update(rowCDSyndicate);
                        dSFellowship.CDSyndicate.AcceptChanges();
                        break;
                    case "gridViewCDEDARET":
                        Fellowship.DataSources.DSFellowship.CDEDARETRow rowCDEDARET = (Fellowship.DataSources.DSFellowship.CDEDARETRow)GV.GetFocusedDataRow();
                        if (rowCDEDARET.RowState == DataRowState.Detached)
                            rowCDEDARET.EdaraId = Convert.ToInt32(SqlDB.GetNewID("CDEDARET", "EdaraId"));
                        cDEDARETBindingSource.EndEdit();
                        cDEDARETTableAdapter.Update(rowCDEDARET);
                        dSFellowship.CDEDARET.AcceptChanges();
                        break;
                    case "gridViewCDModerea":
                        Fellowship.DataSources.DSFellowship.CDModereaRow rowCDModerea = (Fellowship.DataSources.DSFellowship.CDModereaRow)GV.GetFocusedDataRow();
                        if (rowCDModerea.RowState == DataRowState.Detached)
                            rowCDModerea.ModereaId = Convert.ToByte(SqlDB.GetNewID("CDModerea", "ModereaId"));
                        cDModereaBindingSource.EndEdit();
                        cDModereaTableAdapter.Update(rowCDModerea);
                        dSFellowship.CDModerea.AcceptChanges();
                        break;
                    case "gridViewCDState":
                        Fellowship.DataSources.DSFellowship.CDStateRow rowCDState = (Fellowship.DataSources.DSFellowship.CDStateRow)GV.GetFocusedDataRow();
                        if (rowCDState.RowState == DataRowState.Detached)
                            rowCDState.StateID = Convert.ToInt32(SqlDB.GetNewID("CDState", "StateID"));
                        cDStateBindingSource.EndEdit();
                        cDStateTableAdapter.Update(rowCDState);
                        dSFellowship.CDState.AcceptChanges();
                        break;
                    case "gridViewCDJob":
                        Fellowship.DataSources.DSFellowship.CDJobRow rowCDJob = (Fellowship.DataSources.DSFellowship.CDJobRow)GV.GetFocusedDataRow();
                        if (rowCDJob.RowState == DataRowState.Detached)
                            rowCDJob.JobtitleID = Convert.ToInt32(SqlDB.GetNewID("CDJob", "JobtitleID"));
                        cDJobBindingSource.EndEdit();
                        cDJobTableAdapter.Update(rowCDJob);
                        dSFellowship.CDJob.AcceptChanges();
                        break;
                    case "gridViewCDAttach":
                        Fellowship.DataSources.DSFellowship.CDAttachRow rowCDAttach = (Fellowship.DataSources.DSFellowship.CDAttachRow)GV.GetFocusedDataRow();
                        if (rowCDAttach.RowState == DataRowState.Detached)
                            rowCDAttach.AttachId = Convert.ToInt32(SqlDB.GetNewID("CDAttach", "AttachId"));
                        cDAttachBindingSource.EndEdit();
                        cDAttachTableAdapter.Update(rowCDAttach);
                        dSFellowship.CDAttach.AcceptChanges();
                        break;
                    default:
                        break;
                }
                Program.ShowMsg("تم الحفظ", false, this);
                Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (Exception ex)
            {
                Program.ShowMsg(Misc.Misc.ExceptionMessage(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, ex, null, this);
            }
        }
        private void repositoryItemButtonEditDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView GV = (GridView)gridControlCode.MainView;
            
            if (MessageBox.Show("هل انت متأكد؟","تحزير ...",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            try
            {
                switch (gridControlCode.MainView.Name)
                {
                    case "gridViewCDSyndicate":
                        Fellowship.DataSources.DSFellowship.CDSyndicateRow rowCDSyndicate = (Fellowship.DataSources.DSFellowship.CDSyndicateRow)GV.GetFocusedDataRow();
                        cDSyndicateTableAdapter.Delete(rowCDSyndicate.SyndicateId);                       
                        gridViewCDSyndicate.DeleteRow(GV.FocusedRowHandle);
                        break;
                    case "gridViewCDEDARET":
                        Fellowship.DataSources.DSFellowship.CDEDARETRow rowCDEDARET = (Fellowship.DataSources.DSFellowship.CDEDARETRow)GV.GetFocusedDataRow();
                        cDEDARETTableAdapter.Delete(rowCDEDARET.EdaraId);
                        gridViewCDEDARET.DeleteRow(GV.FocusedRowHandle);
                        break;
                    case "gridViewCDModerea":
                        Fellowship.DataSources.DSFellowship.CDModereaRow rowCDModerea = (Fellowship.DataSources.DSFellowship.CDModereaRow)GV.GetFocusedDataRow();
                        cDModereaTableAdapter.Delete(rowCDModerea.ModereaId);
                        gridViewCDModerea.DeleteRow(GV.FocusedRowHandle);
                        break;
                    case "gridViewCDState":
                        Fellowship.DataSources.DSFellowship.CDStateRow rowCDState = (Fellowship.DataSources.DSFellowship.CDStateRow)GV.GetFocusedDataRow();
                        cDStateTableAdapter.Delete(rowCDState.StateID);
                        gridViewCDState.DeleteRow(GV.FocusedRowHandle);
                        break;
                    case "gridViewCDJob":
                        Fellowship.DataSources.DSFellowship.CDJobRow rowCDJob = (Fellowship.DataSources.DSFellowship.CDJobRow)GV.GetFocusedDataRow();
                        cDJobTableAdapter.Delete(rowCDJob.JobtitleID);
                        gridViewCDJob.DeleteRow(GV.FocusedRowHandle);
                        break;
                    case "gridViewCDAttach":
                        Fellowship.DataSources.DSFellowship.CDAttachRow rowCDAttach = (Fellowship.DataSources.DSFellowship.CDAttachRow)GV.GetFocusedDataRow();
                        cDAttachTableAdapter.Delete(rowCDAttach.AttachId);
                        gridViewCDAttach.DeleteRow(GV.FocusedRowHandle);
                        break;
                    default:
                        break;
                }
                Program.ShowMsg("تم الحذف", false, this);
                Program.Logger.LogThis("تم الحذف", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (Exception ex)
            {
                Program.ShowMsg(Misc.Misc.ExceptionMessage(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, ex, null, this);
            }
        }
        private void gridControlCode_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            //if (e.Button.ButtonType == NavigatorButtonType.Append)
            //{
            //    if (gridControlCode.MainView == gridViewCD_HesaTime)
            //        rowgridViewCD_HesaTime = gridViewCD_HesaTime.GetFocusedDataRow();
            //}
        }

        #endregion

    }
}