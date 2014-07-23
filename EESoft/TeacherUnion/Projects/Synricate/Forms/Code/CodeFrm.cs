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

namespace Synricate
{
    public partial class CodeFrm : XtraForm
    {
        #region -   Variables   -
        public enum TableNames : byte
        {
            All,
            CDSyndicate,
            CDSubCommitte,
            CDSCommitte,
            CDCommitteJop,
            CDJop,
            TBLMember,
            CDMetingState,
            TBLSCommitteMember,
            CDYear,
            CDMonth

        }
        private readonly TableNames ViewName;
        #endregion
        #region -   Functions   -
        public CodeFrm(TableNames CodeName)
        {
            InitializeComponent();
            ViewName = CodeName;
            switch (CodeName)
            {
                case TableNames.CDSyndicate:
                    gridControlCode.MainView = gridViewCDSyndicate;
                    LoadData(TableNames.CDSyndicate);
                    Text += " النقابات الفرعية";
                    break;
                case TableNames.CDSubCommitte:
                    gridControlCode.MainView = gridViewCDSubCommitte;
                    LoadData(TableNames.CDSubCommitte);
                    Text += " اللجان النقابية";
                    break;
                case TableNames.CDSCommitte:
                    gridControlCode.MainView = gridViewCDSCommitte;
                    LoadData(TableNames.CDSCommitte);
                    Text += " اللجان النوعية";
                    break;
                case TableNames.CDCommitteJop:
                    gridControlCode.MainView = gridViewCDCommitteJop;
                    LoadData(TableNames.CDCommitteJop);
                    Text += " الوظائف باللجان";
                    break;
                case TableNames.CDJop:
                    gridControlCode.MainView = gridViewCDJop;
                    LoadData(TableNames.CDJop);
                    Text += " الوظائف العامة";
                    break;
                case TableNames.CDYear:
                    gridControlCode.MainView = gridViewCDYear;
                    LoadData(TableNames.CDYear);
                    Text += " كود السنة";
                    break;
                case TableNames.CDMonth:
                    gridControlCode.MainView = gridViewCDMonth;
                    LoadData(TableNames.CDMonth);
                    Text += " الشهور";
                    break;
                default:
                    break;
            }
            
        }
        private void LoadData(TableNames CodeName)
        {
            DataTable dt = new DataTable();
            switch (CodeName)
            {
                case TableNames.CDSyndicate:
                    dt = SQLProvider.SelectCDSyndicate();
                    break;
                case TableNames.CDSubCommitte:
                    dt = SQLProvider.SelectCDSubCommitte();
                    repositoryItemGridLookUpEditSyndicateId.DataSource = SQLProvider.SelectCDSyndicate(); 
                    break;
                case TableNames.CDSCommitte:
                    dt = SQLProvider.SelectCDSCommitte();
                    break;
                case TableNames.CDCommitteJop:
                    dt = SQLProvider.SelectCDCommitteJop();
                    break;
                case TableNames.CDJop:
                    dt = SQLProvider.SelectCDJop();
                    break;
                case TableNames.CDYear:
                    dt = SQLProvider.SelectCDYear();
                    break;
                case TableNames.CDMonth:
                    dt = SQLProvider.SelectCDMonth();
                    break;
                default:
                    break;
            }
            gridControlCode.DataSource = dt;
            //gridViewCDMarahel.BestFitColumns()
            ((DevExpress.XtraGrid.Views.Grid.GridView)gridControlCode.MainView).BestFitColumns();
            
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
            return;
            bool Selecting = false, Inserting = false, Updateing = false, Deleting = false;
            FXFW.SqlDB.GetFormPriv("Synricate" + ViewName, ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
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
            ActivePriv();
            DataTable x = new DataTable();

        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                switch (gridControlCode.MainView.Name)
                {
                    case "gridViewCDSyndicate":
                        DataRow rowgridViewCDSyndicate = gridViewCDSyndicate.GetFocusedDataRow();
                        if (rowgridViewCDSyndicate["SyndicateId"].ToString() == string.Empty)
                            SQLProvider.InsertCDSyndicate(rowgridViewCDSyndicate["Syndicate"], rowgridViewCDSyndicate["saddress"],
                                rowgridViewCDSyndicate["sphone1"], rowgridViewCDSyndicate["sphone2"], rowgridViewCDSyndicate["smobil"],
                                rowgridViewCDSyndicate["sfax"], rowgridViewCDSyndicate["smail"], rowgridViewCDSyndicate["slogo"]);
                        else
                            SQLProvider.UpdateCDSyndicate(rowgridViewCDSyndicate["SyndicateId"], rowgridViewCDSyndicate["Syndicate"], 
                                rowgridViewCDSyndicate["saddress"], rowgridViewCDSyndicate["sphone1"], rowgridViewCDSyndicate["sphone2"], 
                                rowgridViewCDSyndicate["smobil"], rowgridViewCDSyndicate["sfax"], rowgridViewCDSyndicate["smail"], rowgridViewCDSyndicate["slogo"]);
                        break;
                    case "gridViewCDSubCommitte":
                        DataRow rowgridViewCDSubCommitte = gridViewCDSubCommitte.GetFocusedDataRow();
                        if (rowgridViewCDSubCommitte["SubCommitteId"].ToString() == string.Empty)
                            SQLProvider.InsertCDSubCommitte(rowgridViewCDSubCommitte["SubCommitte"], rowgridViewCDSubCommitte["SyndicateId"],
                                rowgridViewCDSubCommitte["saddress"], rowgridViewCDSubCommitte["sphone1"], rowgridViewCDSubCommitte["sphone2"],
                                rowgridViewCDSubCommitte["smobil"], rowgridViewCDSubCommitte["sfax"], rowgridViewCDSubCommitte["smail"],
                                rowgridViewCDSubCommitte["slogo"]);
                        else
                            SQLProvider.UpdateCDSubCommitte(rowgridViewCDSubCommitte["SubCommitteId"], rowgridViewCDSubCommitte["SubCommitte"], rowgridViewCDSubCommitte["SyndicateId"],
                                rowgridViewCDSubCommitte["saddress"], rowgridViewCDSubCommitte["sphone1"], rowgridViewCDSubCommitte["sphone2"],
                                rowgridViewCDSubCommitte["smobil"], rowgridViewCDSubCommitte["sfax"], rowgridViewCDSubCommitte["smail"],
                                rowgridViewCDSubCommitte["slogo"]);
                        break;
                    case "gridViewCDSCommitte":
                        DataRow rowgridViewCDSCommitte= gridViewCDSCommitte.GetFocusedDataRow();
                        if (rowgridViewCDSCommitte["LagnaNoaeaId"].ToString() == string.Empty)
                            SQLProvider.InsertCDSCommitte(rowgridViewCDSCommitte["LagnaNoaeaName"], rowgridViewCDSCommitte["LagnaDES"]);
                        else
                            SQLProvider.UpdateCDSCommitte(rowgridViewCDSCommitte["LagnaNoaeaId"], rowgridViewCDSCommitte["LagnaNoaeaName"],
                                rowgridViewCDSCommitte["LagnaDES"]);
                        break;
                    case "gridViewCDCommitteJop":
                        DataRow rowgridViewCDCommitteJop = gridViewCDCommitteJop.GetFocusedDataRow();
                        if (rowgridViewCDCommitteJop["CommittejopId"].ToString() == string.Empty)
                            SQLProvider.InsertCDCommitteJop(rowgridViewCDCommitteJop["CommittejopName"]);
                        else
                            SQLProvider.UpdateCDCommitteJop(rowgridViewCDCommitteJop["CommittejopId"], rowgridViewCDCommitteJop["CommittejopName"]);
                        break;
                    case "gridViewCDJop":
                        DataRow rowgridViewCDJop = gridViewCDJop.GetFocusedDataRow();
                        if (rowgridViewCDJop["jopId"].ToString() == string.Empty)
                            SQLProvider.InsertCDJop(rowgridViewCDJop["jopName"]);
                        else
                            SQLProvider.UpdateCDJop(rowgridViewCDJop["jopId"], rowgridViewCDJop["jopName"]);
                        break;
                    case "gridViewCDYear":
                        DataRow rowgridViewCDYear = gridViewCDYear.GetFocusedDataRow();
                        if (rowgridViewCDYear["YearId"].ToString() == string.Empty)
                            SQLProvider.InsertCDYear(rowgridViewCDYear["Year"]);
                        else
                            SQLProvider.UpdateCDYear(rowgridViewCDYear["YearId"], rowgridViewCDYear["Year"]);
                        break;
                    case "gridViewCDMonth":
                        DataRow rowgridViewCDMonth = gridViewCDMonth.GetFocusedDataRow();
                        if (rowgridViewCDMonth["MonthId"].ToString() == string.Empty)
                            SQLProvider.InsertCDMonth(rowgridViewCDMonth["Month"]);
                        else
                            SQLProvider.UpdateCDMonth(rowgridViewCDMonth["MonthId"], rowgridViewCDMonth["Month"]);
                        break;
                    default:
                        break;
                }
                Program.ShowMsg("تم الحفظ", false, this);
                Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
            LoadData(ViewName);
        }
        private void repositoryItemButtonEditDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟","تحزير ...",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            try
            {
                switch (gridControlCode.MainView.Name)
                {
                    case "gridViewCDSyndicate":
                        DataRow rowgridViewCDSyndicate = gridViewCDSyndicate.GetFocusedDataRow();
                        if (rowgridViewCDSyndicate["SyndicateId"].ToString() != string.Empty)
                            SQLProvider.DeleteCDSyndicate(rowgridViewCDSyndicate["SyndicateId"].ToString());
                        break;
                    case "gridViewCDSubCommitte":
                        DataRow rowgridViewCDSubCommitte = gridViewCDSubCommitte.GetFocusedDataRow();
                        if (rowgridViewCDSubCommitte["SubCommitteId"].ToString() != string.Empty)
                            SQLProvider.DeleteCDSubCommitte(rowgridViewCDSubCommitte["SubCommitteId"].ToString());
                        break;
                    case "gridViewCDSCommitte":
                        DataRow rowgridViewCDSCommitte = gridViewCDSCommitte.GetFocusedDataRow();
                        if (rowgridViewCDSCommitte["LagnaNoaeaId"].ToString() != string.Empty)
                            SQLProvider.DeleteCDSCommitte(rowgridViewCDSCommitte["LagnaNoaeaId"].ToString());
                        break;
                    case "gridViewCDCommitteJop":
                        DataRow rowgridViewCDCommitteJop = gridViewCDCommitteJop.GetFocusedDataRow();
                        if (rowgridViewCDCommitteJop["CommittejopId"].ToString() != string.Empty)
                            SQLProvider.DeleteCDCommitteJop(rowgridViewCDCommitteJop["CommittejopId"]);
                        break;
                    case "gridViewCDJop":
                        DataRow rowgridViewCDJop = gridViewCDJop.GetFocusedDataRow();
                        if (rowgridViewCDJop["jopId"].ToString() != string.Empty)
                            SQLProvider.DeleteCDJop(rowgridViewCDJop["jopId"]);
                        break;
                    case "gridViewCDYear":
                        DataRow rowgridViewCDYear = gridViewCDYear.GetFocusedDataRow();
                        if (rowgridViewCDYear["YearId"].ToString() != string.Empty)
                            SQLProvider.DeleteCDYear(rowgridViewCDYear["YearId"]);
                        break;
                    case "gridViewCDMonth":
                        DataRow rowgridViewCDMonth = gridViewCDMonth.GetFocusedDataRow();
                        if (rowgridViewCDMonth["MonthId"].ToString() != string.Empty)
                            SQLProvider.DeleteCDMonth(rowgridViewCDMonth["MonthId"]);
                        break;
                    default:
                        break;
                }
                Program.ShowMsg("تم الحذف", false, this);
                Program.Logger.LogThis("تم الحذف", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
            LoadData(ViewName);
        }
        #endregion
    }
}