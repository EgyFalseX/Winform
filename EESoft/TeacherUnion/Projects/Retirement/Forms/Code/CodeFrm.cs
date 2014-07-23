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

namespace Retirement
{
    public partial class CodeFrm : XtraForm
    {
        #region -   Variables   -
        public enum TableNames : byte
        {
            All,
            CDGov,
            CDMarkez,
            CDSyndicate,
            CDSubCommitte,
            CDWarasaType,
            CDMashHala
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
                case TableNames.CDGov:
                    gridControlCode.MainView = gridViewCDGov;
                    LoadData(TableNames.CDGov);
                    Text += " المحافظات";
                    break;
                case TableNames.CDMarkez:
                    gridControlCode.MainView = gridViewCDMarkez;
                     LoadData(TableNames.CDMarkez);
                     Text += " المراكز";
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
                case TableNames.CDWarasaType:
                    gridControlCode.MainView = gridViewCDWarasaType;
                    LoadData(TableNames.CDWarasaType);
                    Text += " الورثة";
                    break;
                case TableNames.CDMashHala:
                    gridControlCode.MainView = gridViewCDMashHala;
                    LoadData(TableNames.CDMashHala);
                    Text += " حالة العضو";
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
                case TableNames.CDGov:
                    dt = SQLProvider.SelectCDGov();
                    break;
                case TableNames.CDMarkez:
                    dt = SQLProvider.SelectCDMarkez();
                    repositoryItemGridLookUpEditGovId.DataSource = SQLProvider.SelectCDGov(); 
                    break;
                case TableNames.CDSyndicate:
                    dt = SQLProvider.SelectCDSyndicate();
                    break;
                case TableNames.CDSubCommitte:
                    dt = SQLProvider.SelectCDSubCommitte();
                    repositoryItemGridLookUpEditSyndicateId.DataSource = SQLProvider.SelectCDSyndicate(); 
                    break;
                case TableNames.CDWarasaType:
                    dt = SQLProvider.SelectCDWarasaType();
                    break;
                case TableNames.CDMashHala:
                    dt = SQLProvider.SelectCDMashHala();
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
            FXFW.SqlDB.GetFormPriv("Retirement" + ViewName, ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
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
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                switch (gridControlCode.MainView.Name)
                {
                    case "gridViewCDGov":
                        DataRow rowgridViewCDGov = gridViewCDGov.GetFocusedDataRow();
                        if (rowgridViewCDGov["GovId"].ToString() == string.Empty)
                            SQLProvider.InsertCDGov(rowgridViewCDGov["GOV"].ToString());
                        else
                            SQLProvider.UpdateCDGov(rowgridViewCDGov["GovId"].ToString(), rowgridViewCDGov["GOV"].ToString());
                        break;
                    case "gridViewCDMarkez":
                        DataRow rowgridViewCDMarkez = gridViewCDMarkez.GetFocusedDataRow();
                        if (rowgridViewCDMarkez["MarkezId"].ToString() == string.Empty)
                            SQLProvider.InsertCDMarkez(rowgridViewCDMarkez["Markez"].ToString(), rowgridViewCDMarkez["GovId"].ToString());
                        else
                            SQLProvider.UpdateCDMarkez(rowgridViewCDMarkez["MarkezId"].ToString(), rowgridViewCDMarkez["Markez"].ToString(), rowgridViewCDMarkez["GovId"].ToString());
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
                    case "gridViewCDWarasaType":
                        DataRow rowgridViewCDWarasaType = gridViewCDWarasaType.GetFocusedDataRow();
                        if (rowgridViewCDWarasaType["WarasaTypeId"].ToString() == string.Empty)
                            SQLProvider.InsertCDWarasaType(rowgridViewCDWarasaType["WarasaType"].ToString(), rowgridViewCDWarasaType["feasarf"].ToString());
                        else
                            SQLProvider.UpdateCDWarasaType(rowgridViewCDWarasaType["WarasaTypeId"].ToString(), rowgridViewCDWarasaType["WarasaType"].ToString(), rowgridViewCDWarasaType["feasarf"].ToString());
                        break;
                    case "gridViewCDMashHala":
                        DataRow rowgridViewCDMashHala = gridViewCDMashHala.GetFocusedDataRow();
                        if (rowgridViewCDMashHala["MashHalaId"].ToString() == string.Empty)
                            SQLProvider.InsertCDMashHala(rowgridViewCDMashHala["MashHala"].ToString(), rowgridViewCDMashHala["feasarfa"].ToString());
                        else
                            SQLProvider.UpdateCDMashHala(rowgridViewCDMashHala["MashHalaId"].ToString(), rowgridViewCDMashHala["MashHala"].ToString(), rowgridViewCDMashHala["feasarfa"].ToString());
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
                    case "gridViewCDGov":
                        DataRow rowgridViewCDGov = gridViewCDGov.GetFocusedDataRow();
                        if (rowgridViewCDGov["GovId"].ToString() != string.Empty)
                            SQLProvider.DeleteCDGov(rowgridViewCDGov["GovId"].ToString());
                        break;
                    case "gridViewCDMarkez":
                        DataRow rowgridViewCDMarkez = gridViewCDMarkez.GetFocusedDataRow();
                        if (rowgridViewCDMarkez["MarkezId"].ToString() != string.Empty)
                            SQLProvider.DeleteCDMarkez(rowgridViewCDMarkez["MarkezId"].ToString());
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
                    case "gridViewCDWarasaType":
                        DataRow rowgridViewCDWarasaType = gridViewCDWarasaType.GetFocusedDataRow();
                        if (rowgridViewCDWarasaType["WarasaTypeId"].ToString() != string.Empty)
                            SQLProvider.DeleteCDWarasaType(rowgridViewCDWarasaType["WarasaTypeId"].ToString());
                        break;

                    case "gridViewCDMashHala":
                        DataRow rowgridViewCDMashHala = gridViewCDMashHala.GetFocusedDataRow();
                        if (rowgridViewCDMashHala["MashHalaId"].ToString() != string.Empty)
                            SQLProvider.DeleteCDMashHala(rowgridViewCDMashHala["MashHalaId"].ToString());
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