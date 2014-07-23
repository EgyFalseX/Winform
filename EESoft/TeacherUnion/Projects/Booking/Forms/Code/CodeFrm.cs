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

namespace Booking
{
    public partial class CodeFrm : XtraForm
    {
        #region -   Variables   -
        public enum TableNames : byte
        {
            All,
            CDHall, 
            TBLWorker, 
            CDFatra,
            CDEradType,
            CDSyndicate,
            CDSubCommitte,
            CDMonsrefType,
            CDWarasaType,
            CDJop
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
                case TableNames.CDFatra:
                    gridControlCode.MainView = gridViewCDFatra;
                    LoadData(TableNames.CDFatra);
                    Text += " الفترات";
                    break;
                case TableNames.CDEradType:
                    gridControlCode.MainView = gridViewCDEradType;
                     LoadData(TableNames.CDEradType);
                     Text += " انواع الايرادات";
                    break;
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
                case TableNames.CDMonsrefType:
                    gridControlCode.MainView = gridViewCDMonsrefType;
                    LoadData(TableNames.CDMonsrefType);
                    Text += " انواع المصروفات";
                    break;
                case TableNames.CDJop:
                    gridControlCode.MainView = gridViewCDJop;
                    LoadData(TableNames.CDJop);
                    Text += " الوظائف";
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
                case TableNames.CDFatra:
                    dt = SQLProvider.SelectCDFatra();
                    break;
                case TableNames.CDEradType:
                    dt = SQLProvider.SelectCDEradType();
                    break;
                case TableNames.CDSyndicate:
                    dt = SQLProvider.SelectCDSyndicate();
                    break;
                case TableNames.CDSubCommitte:
                    dt = SQLProvider.SelectCDSubCommitte();
                    repositoryItemGridLookUpEditSyndicateId.DataSource = SQLProvider.SelectCDSyndicate(); 
                    break;
                case TableNames.CDMonsrefType:
                    dt = SQLProvider.SelectCDMonsrefType();
                    break;
                case TableNames.CDJop:
                    dt = SQLProvider.SelectCDJop();
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
            FXFW.SqlDB.GetFormPriv("Booking" + ViewName, ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
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
                    case "gridViewCDFatra":
                        DataRow rowgridViewCDFatra = gridViewCDFatra.GetFocusedDataRow();
                        if (rowgridViewCDFatra["FatraId"].ToString() == string.Empty)
                            SQLProvider.InsertCDFatra(rowgridViewCDFatra["Fatra"], rowgridViewCDFatra["ffrom"], rowgridViewCDFatra["fto"]);
                        else
                            SQLProvider.UpdateCDFatra(rowgridViewCDFatra["FatraId"], rowgridViewCDFatra["Fatra"], rowgridViewCDFatra["ffrom"], rowgridViewCDFatra["fto"]);
                        break;
                    case "gridViewCDEradType":
                        DataRow rowgridViewCDEradType = gridViewCDEradType.GetFocusedDataRow();
                        if (rowgridViewCDEradType["EradTypeId"].ToString() == string.Empty)
                            SQLProvider.InsertCDEradType(rowgridViewCDEradType["EradType"]);
                        else
                            SQLProvider.UpdateCDEradType(rowgridViewCDEradType["EradTypeId"], rowgridViewCDEradType["EradType"]);
                        break;
                    case "gridViewCDSyndicate":
                        DataRow rowgridViewCDSyndicate = gridViewCDSyndicate.GetFocusedDataRow();
                        if (rowgridViewCDSyndicate["SyndicateId"].ToString() == string.Empty)
                            SQLProvider.InsertCDSyndicate(rowgridViewCDSyndicate["Syndicate"].ToString());
                        else
                            SQLProvider.UpdateCDSyndicate(rowgridViewCDSyndicate["SyndicateId"].ToString(), rowgridViewCDSyndicate["Syndicate"].ToString());
                        break;
                    case "gridViewCDSubCommitte":
                        DataRow rowgridViewCDSubCommitte = gridViewCDSubCommitte.GetFocusedDataRow();
                        if (rowgridViewCDSubCommitte["SubCommitteId"].ToString() == string.Empty)
                            SQLProvider.InsertCDSubCommitte(rowgridViewCDSubCommitte["SubCommitte"].ToString(), rowgridViewCDSubCommitte["SyndicateId"].ToString());
                        else
                            SQLProvider.UpdateCDSubCommitte(rowgridViewCDSubCommitte["SubCommitteId"].ToString(), rowgridViewCDSubCommitte["SubCommitte"].ToString(), rowgridViewCDSubCommitte["SyndicateId"].ToString());
                        break;
                    case "gridViewCDMonsrefType":
                        DataRow rowgridViewCDMonsrefType = gridViewCDMonsrefType.GetFocusedDataRow();
                        if (rowgridViewCDMonsrefType["MonsrefTypeId"].ToString() == string.Empty)
                            SQLProvider.InsertCDMonsrefType(rowgridViewCDMonsrefType["MonsrefType"]);
                        else
                            SQLProvider.UpdateCDMonsrefType(rowgridViewCDMonsrefType["MonsrefTypeId"], rowgridViewCDMonsrefType["MonsrefType"]);
                        break;
                    case "gridViewCDJop":
                        DataRow rowgridViewCDJop = gridViewCDJop.GetFocusedDataRow();
                        if (rowgridViewCDJop["JopId"].ToString() == string.Empty)
                            SQLProvider.InsertCDJop(rowgridViewCDJop["Jop"]);
                        else
                            SQLProvider.UpdateCDJop(rowgridViewCDJop["JopId"].ToString(), rowgridViewCDJop["Jop"]);
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
                    case "gridViewCDFatra":
                        DataRow rowgridViewCDFatra = gridViewCDFatra.GetFocusedDataRow();
                        if (rowgridViewCDFatra["FatraId"].ToString() != string.Empty)
                            SQLProvider.DeleteCDFatra(rowgridViewCDFatra["FatraId"]);
                        break;
                    case "gridViewCDEradType":
                        DataRow rowgridViewCDEradType = gridViewCDEradType.GetFocusedDataRow();
                        if (rowgridViewCDEradType["EradTypeId"].ToString() != string.Empty)
                            SQLProvider.DeleteCDEradType(rowgridViewCDEradType["EradTypeId"].ToString());
                        break;
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
                    case "gridViewCDMonsrefType":
                        DataRow rowgridViewCDMonsrefType = gridViewCDMonsrefType.GetFocusedDataRow();
                        if (rowgridViewCDMonsrefType["MonsrefTypeId"].ToString() != string.Empty)
                            SQLProvider.DeleteCDMonsrefType(rowgridViewCDMonsrefType["MonsrefTypeId"]);
                        break;

                    case "gridViewCDJop":
                        DataRow rowgridViewCDJop = gridViewCDJop.GetFocusedDataRow();
                        if (rowgridViewCDJop["JopId"].ToString() != string.Empty)
                            SQLProvider.DeleteCDJop(rowgridViewCDJop["JopId"].ToString());
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