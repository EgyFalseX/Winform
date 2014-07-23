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

namespace ServiceQuery
{
    public partial class CodeFrm : XtraForm
    {
        #region -   Variables   -
        public bool ExitAfterSave = false;
        public enum TableNames : byte
        {
            All,
            CDEdara,
            CDserviceType,
            CDReply,
            CDSyndicate,
            CDSubCommitte,
            CDAttatech
            
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
                case TableNames.CDEdara:
                    gridControlCode.MainView = gridViewCDEdara;
                    LoadData(TableNames.CDEdara);
                    Text += " الادارات";
                    break;
                case TableNames.CDserviceType:
                    gridControlCode.MainView = gridViewCDserviceType;
                    LoadData(TableNames.CDserviceType);
                    Text += " انواع الخدمات";
                    break;
                case TableNames.CDReply:
                    gridControlCode.MainView = gridViewCDReply;
                    LoadData(TableNames.CDReply);
                    Text += " الرد";
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
                case TableNames.CDAttatech:
                    gridControlCode.MainView = gridViewCDAttatech;
                    LoadData(TableNames.CDAttatech);
                    Text += " المرفقات";
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
                case TableNames.CDEdara:
                    dt = SQLProvider.SelectCDEdara();
                    break;
                case TableNames.CDserviceType:
                    dt = SQLProvider.SelectCDserviceType();
                    break;
                case TableNames.CDReply:
                    dt = SQLProvider.SelectCDReply();
                    break;
                case TableNames.CDSyndicate:
                    dt = SQLProvider.SelectCDSyndicate();
                    break;
                case TableNames.CDSubCommitte:
                    dt = SQLProvider.SelectCDSubCommitte();
                    repositoryItemGridLookUpEditSyndicateId.DataSource = SQLProvider.SelectCDSyndicate(); 
                    break;
                case TableNames.CDAttatech:
                    dt = SQLProvider.SelectCDAttatech();
                    repositoryItemGridLookUpEditserviceTypeId.DataSource = SQLProvider.SelectCDserviceType();
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
            bool Selecting = false, Inserting = false, Updateing = false, Deleting = false;
            FXFW.SqlDB.GetFormPriv("ServiceQuery" + ViewName.ToString(), ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
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
            //ActivePriv();
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                switch (gridControlCode.MainView.Name)
                {
                    case "gridViewCDEdara":
                        DataRow rowgridViewCDEdara = gridViewCDEdara.GetFocusedDataRow();
                        if (rowgridViewCDEdara["EdaraId"].ToString() == string.Empty)
                            SQLProvider.InsertCDEdara(rowgridViewCDEdara["Edara"]);
                        else
                            SQLProvider.UpdateCDEdara(rowgridViewCDEdara["EdaraId"], rowgridViewCDEdara["Edara"]);
                        break;
                    case "gridViewCDserviceType":
                        DataRow rowgridViewCDserviceType = gridViewCDserviceType.GetFocusedDataRow();
                        if (rowgridViewCDserviceType["serviceTypeId"].ToString() == string.Empty)
                            SQLProvider.InsertCDserviceType(rowgridViewCDserviceType["servicesType"]);
                        else
                            SQLProvider.UpdateCDserviceType(rowgridViewCDserviceType["serviceTypeId"], rowgridViewCDserviceType["servicesType"]);
                        break;
                    case "gridViewCDReply":
                        DataRow rowgridViewCDReply = gridViewCDReply.GetFocusedDataRow();
                        if (rowgridViewCDReply["Replyid"].ToString() == string.Empty)
                            SQLProvider.InsertCDReply(rowgridViewCDReply["Reply"]);
                        else
                            SQLProvider.UpdateCDReply(rowgridViewCDReply["Replyid"], rowgridViewCDReply["Reply"]);
                        break;
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
                    case "gridViewCDAttatech":
                        DataRow rowgridViewCDAttatech = gridViewCDAttatech.GetFocusedDataRow();
                        if (rowgridViewCDAttatech["AttatechID"].ToString() == string.Empty)
                            SQLProvider.InsertCDAttatech(rowgridViewCDAttatech["Attatech"], rowgridViewCDAttatech["serviceTypeId"]);
                        else
                            SQLProvider.UpdateCDAttatech(rowgridViewCDAttatech["AttatechID"], rowgridViewCDAttatech["Attatech"], rowgridViewCDAttatech["serviceTypeId"]);
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
                    case "gridViewCDEdara":
                        DataRow rowgridViewCDEdara = gridViewCDEdara.GetFocusedDataRow();
                        if (rowgridViewCDEdara["EdaraId"].ToString() != string.Empty)
                            SQLProvider.DeleteCDEdara(rowgridViewCDEdara["EdaraId"]);
                        break;
                    case "gridViewCDserviceType":
                        DataRow rowgridViewCDserviceType = gridViewCDserviceType.GetFocusedDataRow();
                        if (rowgridViewCDserviceType["serviceTypeId"].ToString() != string.Empty)
                            SQLProvider.DeleteCDserviceType(rowgridViewCDserviceType["serviceTypeId"]);
                        break;
                    case "gridViewCDReply":
                        DataRow rowgridViewCDReply = gridViewCDReply.GetFocusedDataRow();
                        if (rowgridViewCDReply["Replyid"].ToString() != string.Empty)
                            SQLProvider.DeleteCDReply(rowgridViewCDReply["Replyid"]);
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
                    case "gridViewCDAttatech":
                        DataRow rowgridViewCDAttatech = gridViewCDAttatech.GetFocusedDataRow();
                        if (rowgridViewCDAttatech["AttatechID"].ToString() != string.Empty)
                            SQLProvider.DeleteCDAttatech(rowgridViewCDAttatech["AttatechID"]);
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