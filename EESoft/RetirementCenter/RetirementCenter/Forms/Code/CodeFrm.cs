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

namespace RetirementCenter
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
            CDBirthPlace,
            CDJop,
            CDJobDescription,
            CDGehaType,
            CDModerea,
            CDEDARET,
            CDGeha,
            CDQualification,
            CDSpecialization,
            CDEstefaaKed,
            CDJobtitle,
            CDAttachmentType,
            CDsarfType,
            TBLDofatSarf
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
                case TableNames.CDBirthPlace:
                    gridControlCode.MainView = gridViewCDBirthPlace;
                    LoadData(TableNames.CDBirthPlace);
                    Text += " محل الميلاد";
                    break;
                case TableNames.CDJop:
                    gridControlCode.MainView = gridViewCDJop;
                    LoadData(TableNames.CDJop);
                    Text += " الوظائف";
                    break;
                case TableNames.CDJobDescription:
                    gridControlCode.MainView = gridViewCDJobDescription;
                    LoadData(TableNames.CDJobDescription);
                    Text += " الوصف الوظيفي";
                    break;
                case TableNames.CDGehaType:
                    gridControlCode.MainView = gridViewCDGehaType;
                    LoadData(TableNames.CDGehaType);
                    Text += " جهات العمل";
                    break;
                case TableNames.CDModerea:
                    gridControlCode.MainView = gridViewCDModerea;
                    LoadData(TableNames.CDModerea);
                    Text += " المديريات";
                    break;
                case TableNames.CDEDARET:
                    gridControlCode.MainView = gridViewCDEDARET;
                    LoadData(TableNames.CDEDARET);
                    Text += " الادارات";
                    break;
                case TableNames.CDGeha:
                    gridControlCode.MainView = gridViewCDGeha;
                    LoadData(TableNames.CDGeha);
                    Text += " جهات العمل";
                    break;
                case TableNames.CDQualification:
                    gridControlCode.MainView = gridViewCDQualification;
                    LoadData(TableNames.CDQualification);
                    Text += " المؤهلات";
                    break;
                case TableNames.CDSpecialization:
                    gridControlCode.MainView = gridViewCDSpecialization;
                    LoadData(TableNames.CDSpecialization);
                    Text += " تخصص المؤهل";
                    break;
                case TableNames.CDEstefaaKed:
                    gridControlCode.MainView = gridViewCDEstefaaKed;
                    LoadData(TableNames.CDEstefaaKed);
                    Text += " استيفاء العضوية";
                    break;
                case TableNames.CDJobtitle:
                    gridControlCode.MainView = gridViewCDJobtitle;
                    gridControlCode.Enabled = false;
                    LoadData(TableNames.CDJobtitle);
                    Text += " وظائف الاعضاء";
                    break;
                case TableNames.CDAttachmentType:
                    gridControlCode.MainView = gridViewCDAttachmentType;
                    LoadData(TableNames.CDAttachmentType);
                    Text += " انواع المرفقات";
                    break;
                case TableNames.CDsarfType:
                    gridControlCode.MainView = gridViewCDsarfType;
                    LoadData(TableNames.CDsarfType);
                    Text += " فئات الصرف";
                    break;
                case TableNames.TBLDofatSarf:
                    gridControlCode.MainView = gridViewTBLDofatSarf;
                    LoadData(TableNames.TBLDofatSarf);
                    Text += " دفعات الصرف";
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
                case TableNames.CDBirthPlace:
                    dt = SQLProvider.SelectCDBirthPlace();
                    break;
                case TableNames.CDJop:
                    dt = SQLProvider.SelectCDJop();
                    break;
                case TableNames.CDJobDescription:
                    dt = SQLProvider.SelectCDJobDescription();
                    repositoryItemGridLookUpEditjopId.DataSource = SQLProvider.SelectCDJop(); 
                    break;
                case TableNames.CDGehaType:
                    dt = SQLProvider.SelectCDGehaType();
                    break;
                case TableNames.CDModerea:
                    dt = SQLProvider.SelectCDModerea();
                    repositoryItemGridLookUpEditGovId.DataSource = SQLProvider.SelectCDGov(); 
                    break;
                case TableNames.CDEDARET:
                    dt = SQLProvider.SelectCDEDARET();
                    repositoryItemGridLookUpEditModereaId.DataSource = SQLProvider.SelectCDModerea();
                    break;
                case TableNames.CDGeha:
                    dt = SQLProvider.SelectCDGeha();
                    repositoryItemGridLookUpEditGehaTypeID.DataSource = SQLProvider.SelectCDGehaType();
                    repositoryItemGridLookUpEditGovId.DataSource = SQLProvider.SelectCDGov();
                    repositoryItemGridLookUpEditModereaId.DataSource = SQLProvider.SelectCDModerea();
                    repositoryItemGridLookUpEditEdaraId.DataSource = SQLProvider.SelectCDEDARET();
                    break;
                case TableNames.CDQualification:
                    dt = SQLProvider.SelectCDQualification();
                    break;
                case TableNames.CDSpecialization:
                    dt = SQLProvider.SelectCDSpecialization();
                    repositoryItemGridLookUpEditqualId.DataSource = SQLProvider.SelectCDQualification();
                    break;
                case TableNames.CDEstefaaKed:
                    dt = SQLProvider.SelectCDEstefaaKed();
                    break;
                case TableNames.CDJobtitle:
                    dt = SQLProvider.SelectCDJobtitle();
                    break;
                case TableNames.CDAttachmentType:
                    dt = SQLProvider.SelectCDAttachmentType();
                    break;
                case TableNames.CDsarfType:
                    dt = SQLProvider.SelectCDsarfType();
                    repositoryItemGridLookUpEditMashHalaId.DataSource = SQLProvider.SelectCDMashHala();
                    break;
                case TableNames.TBLDofatSarf:
                    dt = SQLProvider.SelectTBLDofatSarf();
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
            return;//ActivePrivReady
            bool Selecting = false, Inserting = false, Updateing = false, Deleting = false;
            SQLProvider.GetFormPriv(ViewName.ToString(), ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
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
                    case "gridViewCDBirthPlace":
                        DataRow rowgridViewCDBirthPlace = gridViewCDBirthPlace.GetFocusedDataRow();
                        if (rowgridViewCDBirthPlace["PlaceId"].ToString() == string.Empty)
                            SQLProvider.InsertCDBirthPlace(rowgridViewCDBirthPlace["BPlace"].ToString());
                        else
                            SQLProvider.UpdateCDBirthPlace(rowgridViewCDBirthPlace["PlaceId"].ToString(), rowgridViewCDBirthPlace["BPlace"].ToString());
                        break;
                    case "gridViewCDJop":
                        DataRow rowgridViewCDJop = gridViewCDJop.GetFocusedDataRow();
                        if (rowgridViewCDJop["jopId"].ToString() == string.Empty)
                            SQLProvider.InsertCDJop(rowgridViewCDJop["jopName"].ToString());
                        else
                            SQLProvider.UpdateCDJop(rowgridViewCDJop["jopId"].ToString(), rowgridViewCDJop["jopName"].ToString());
                        break;
                    case "gridViewCDJobDescription":
                        DataRow rowgridViewCDJobDescription = gridViewCDJobDescription.GetFocusedDataRow();
                        if (rowgridViewCDJobDescription["JobDescriptionId"].ToString() == string.Empty)
                            SQLProvider.InsertCDJobDescription(rowgridViewCDJobDescription["JobDescription"].ToString(), rowgridViewCDJobDescription["jopId"].ToString());
                        else
                            SQLProvider.UpdateCDJobDescription(rowgridViewCDJobDescription["JobDescriptionId"].ToString(), rowgridViewCDJobDescription["JobDescription"].ToString(), rowgridViewCDJobDescription["jopId"].ToString());
                        break;
                    case "gridViewCDGehaType":
                        DataRow rowgridViewCDGehaType = gridViewCDGehaType.GetFocusedDataRow();
                        if (rowgridViewCDGehaType["GehaTypeId"].ToString() == string.Empty)
                            SQLProvider.InsertCDGehaType(rowgridViewCDGehaType["GehaType"].ToString());
                        else
                            SQLProvider.UpdateCDGehaType(rowgridViewCDGehaType["GehaTypeId"].ToString(), rowgridViewCDGehaType["GehaType"].ToString());
                        break;
                    case "gridViewCDModerea":
                        DataRow rowgridViewCDModerea = gridViewCDModerea.GetFocusedDataRow();
                        if (rowgridViewCDModerea["ModereaId"].ToString() == string.Empty)
                            SQLProvider.InsertCDModerea(rowgridViewCDModerea["Moderea"].ToString(), rowgridViewCDModerea["GovId"].ToString());
                        else
                            SQLProvider.UpdateCDModerea(rowgridViewCDModerea["ModereaId"].ToString(), rowgridViewCDModerea["Moderea"].ToString(), rowgridViewCDModerea["GovId"].ToString());
                        break;
                    case "gridViewCDEDARET":
                        DataRow rowgridViewCDEDARET = gridViewCDEDARET.GetFocusedDataRow();
                        if (rowgridViewCDEDARET["EdaraId"].ToString() == string.Empty)
                            SQLProvider.InsertCDEDARET(rowgridViewCDEDARET["EDARET"].ToString(), rowgridViewCDEDARET["ModereaId"].ToString());
                        else
                            SQLProvider.UpdateCDEDARET(rowgridViewCDEDARET["EdaraId"].ToString(), rowgridViewCDEDARET["EDARET"].ToString(), rowgridViewCDEDARET["ModereaId"].ToString());
                        break;
                    case "gridViewCDGeha":
                        DataRow rowgridViewCDGeha = gridViewCDGeha.GetFocusedDataRow();
                        if (rowgridViewCDGeha["GehaId"].ToString() == string.Empty)
                            SQLProvider.InsertCDGeha(rowgridViewCDGeha["GehaName"].ToString(), rowgridViewCDGeha["GehaTypeID"].ToString(), rowgridViewCDGeha["GovId"].ToString(), rowgridViewCDGeha["ModereaId"].ToString(), rowgridViewCDGeha["EdaraId"].ToString());
                        else
                            SQLProvider.UpdateCDGeha(rowgridViewCDGeha["GehaId"].ToString(), rowgridViewCDGeha["GehaName"].ToString(), rowgridViewCDGeha["GehaTypeID"].ToString(), rowgridViewCDGeha["GovId"].ToString(), rowgridViewCDGeha["ModereaId"].ToString(), rowgridViewCDGeha["EdaraId"].ToString());
                        break;
                    case "gridViewCDQualification":
                        DataRow rowgridViewCDQualification = gridViewCDQualification.GetFocusedDataRow();
                        if (rowgridViewCDQualification["qualId"].ToString() == string.Empty)
                            SQLProvider.InsertCDQualification(rowgridViewCDQualification["qualName"].ToString(), rowgridViewCDQualification["trbawy"].ToString());
                        else
                            SQLProvider.UpdateCDQualification(rowgridViewCDQualification["qualId"].ToString(), rowgridViewCDQualification["qualName"].ToString(), rowgridViewCDQualification["trbawy"].ToString());
                        break;
                    case "gridViewCDSpecialization":
                        DataRow rowgridViewCDSpecialization = gridViewCDSpecialization.GetFocusedDataRow();
                        if (rowgridViewCDSpecialization["SpecializationId"].ToString() == string.Empty)
                            SQLProvider.InsertCDSpecialization(rowgridViewCDSpecialization["SpecializationName"].ToString(), rowgridViewCDSpecialization["qualId"].ToString());
                        else
                            SQLProvider.UpdateCDSpecialization(rowgridViewCDSpecialization["SpecializationId"].ToString(), rowgridViewCDSpecialization["SpecializationName"].ToString(), rowgridViewCDSpecialization["qualId"].ToString());
                        break;
                    case "gridViewCDEstefaaKed":
                        DataRow rowgridViewCDEstefaaKed = gridViewCDEstefaaKed.GetFocusedDataRow();
                        if (rowgridViewCDEstefaaKed["EstefaaKedId"].ToString() == string.Empty)
                            SQLProvider.InsertCDEstefaaKed(rowgridViewCDEstefaaKed["EstefaaKed"].ToString());
                        else
                            SQLProvider.UpdateCDEstefaaKed(rowgridViewCDEstefaaKed["EstefaaKedId"].ToString(), rowgridViewCDEstefaaKed["EstefaaKed"].ToString());
                        break;
                    case "gridViewCDJobtitle":
                        DataRow rowgridViewCDJobtitle = gridViewCDJobtitle.GetFocusedDataRow();
                        if (rowgridViewCDJobtitle["JobtitleID"].ToString() == string.Empty)
                            SQLProvider.InsertCDJobtitle(rowgridViewCDJobtitle["Jobtitle"]);
                        else
                            SQLProvider.UpdateCDJobtitle(rowgridViewCDJobtitle["JobtitleID"], rowgridViewCDJobtitle["Jobtitle"]);
                        break;
                    case "gridViewCDAttachmentType":
                        DataRow rowgridViewCDAttachmentType = gridViewCDAttachmentType.GetFocusedDataRow();
                        if (rowgridViewCDAttachmentType["AttachmentTypeId"].ToString() == string.Empty)
                            SQLProvider.InsertCDAttachmentType(rowgridViewCDAttachmentType["AttachmentName"], rowgridViewCDAttachmentType["AttachmentExt"], rowgridViewCDAttachmentType["AttachmentImg"]);
                        else
                            SQLProvider.UpdateCDAttachmentType(rowgridViewCDAttachmentType["AttachmentTypeId"], rowgridViewCDAttachmentType["AttachmentName"], rowgridViewCDAttachmentType["AttachmentExt"], rowgridViewCDAttachmentType["AttachmentImg"]);
                        break;
                    case "gridViewCDsarfType":
                        DataRow rowgridViewCDsarfType = gridViewCDsarfType.GetFocusedDataRow();
                        if (rowgridViewCDsarfType["sarfTypeId"].ToString() == string.Empty)
                            SQLProvider.InsertCDsarfType(rowgridViewCDsarfType["MashHalaId"], rowgridViewCDsarfType["sarfType"], rowgridViewCDsarfType["feasarf"]);
                        else
                            SQLProvider.UpdateCDsarfType(rowgridViewCDsarfType["sarfTypeId"], rowgridViewCDsarfType["MashHalaId"], rowgridViewCDsarfType["sarfType"], rowgridViewCDsarfType["feasarf"]);
                        break;
                    case "gridViewTBLDofatSarf":
                        DataRow rowgridViewTBLDofatSarf = gridViewTBLDofatSarf.GetFocusedDataRow();
                        if (rowgridViewTBLDofatSarf["DofatSarfDateto"].ToString() != string.Empty)
                        {
                            DateTime dt = Convert.ToDateTime(rowgridViewTBLDofatSarf["DofatSarfDateto"]);
                            if (DateTime.DaysInMonth(dt.Year, dt.Month) != dt.Day)
                            {
                                Program.ShowMsg("يجب ان يكون اخر يوم في الشهر 'من تاريخ'", true, this, true);
                                return;
                            }
                        }
                        if (rowgridViewTBLDofatSarf["DofatSarfId"].ToString() == string.Empty)
                            SQLProvider.InsertTBLDofatSarf(rowgridViewTBLDofatSarf["DofatSarf"], rowgridViewTBLDofatSarf["DofatSarfDatefrom"],
                                rowgridViewTBLDofatSarf["DofatSarfDateto"], rowgridViewTBLDofatSarf["remd"], rowgridViewTBLDofatSarf["dofclosed"]);
                        else
                            SQLProvider.UpdateTBLDofatSarf(rowgridViewTBLDofatSarf["DofatSarfId"], rowgridViewTBLDofatSarf["DofatSarf"],
                                rowgridViewTBLDofatSarf["DofatSarfDatefrom"], rowgridViewTBLDofatSarf["DofatSarfDateto"], rowgridViewTBLDofatSarf["remd"], rowgridViewTBLDofatSarf["dofclosed"]);
                        break;
                    default:
                        break;
                }
                Program.ShowMsg("تم الحفظ", false, this, true);
                Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
            LoadData(ViewName);
        }
        private void repositoryItemButtonEditDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (msgDlg.Show("هل انت متأكد؟", msgDlg.msgButtons.YesNo) == System.Windows.Forms.DialogResult.No)
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
                    case "gridViewCDBirthPlace":
                        DataRow rowgridViewCDBirthPlace = gridViewCDBirthPlace.GetFocusedDataRow();
                        if (rowgridViewCDBirthPlace["PlaceId"].ToString() != string.Empty)
                            SQLProvider.DeleteCDBirthPlace(rowgridViewCDBirthPlace["PlaceId"].ToString());
                        break;
                    case "gridViewCDJop":
                        DataRow rowgridViewCDJop = gridViewCDJop.GetFocusedDataRow();
                        if (rowgridViewCDJop["jopId"].ToString() != string.Empty)
                            SQLProvider.DeleteCDJop(rowgridViewCDJop["jopId"].ToString());
                        break;
                    case "gridViewCDJobDescription":
                        DataRow rowgridViewCDJobDescription = gridViewCDJobDescription.GetFocusedDataRow();
                        if (rowgridViewCDJobDescription["JobDescriptionId"].ToString() != string.Empty)
                            SQLProvider.DeleteCDJobDescription(rowgridViewCDJobDescription["JobDescriptionId"].ToString());
                        break;
                    case "gridViewCDGehaType":
                        DataRow rowgridViewCDGehaType = gridViewCDGehaType.GetFocusedDataRow();
                        if (rowgridViewCDGehaType["GehaTypeId"].ToString() != string.Empty)
                            SQLProvider.DeleteCDGehaType(rowgridViewCDGehaType["GehaTypeId"].ToString());
                        break;
                    case "gridViewCDModerea":
                        DataRow rowgridViewCDModerea = gridViewCDModerea.GetFocusedDataRow();
                        if (rowgridViewCDModerea["ModereaId"].ToString() != string.Empty)
                            SQLProvider.DeleteCDModerea(rowgridViewCDModerea["ModereaId"].ToString());
                        break;
                    case "gridViewCDEDARET":
                        DataRow rowgridViewCDEDARET = gridViewCDEDARET.GetFocusedDataRow();
                        if (rowgridViewCDEDARET["EdaraId"].ToString() != string.Empty)
                            SQLProvider.DeleteCDEDARET(rowgridViewCDEDARET["EdaraId"].ToString());
                        break;
                    case "gridViewCDGeha":
                        DataRow rowgridViewCDGeha = gridViewCDGeha.GetFocusedDataRow();
                        if (rowgridViewCDGeha["GehaId"].ToString() != string.Empty)
                            SQLProvider.DeleteCDGeha(rowgridViewCDGeha["GehaId"].ToString());
                        break;
                    case "gridViewCDQualification":
                        DataRow rowgridViewCDQualification = gridViewCDQualification.GetFocusedDataRow();
                        if (rowgridViewCDQualification["qualId"].ToString() != string.Empty)
                            SQLProvider.DeleteCDQualification(rowgridViewCDQualification["qualId"].ToString());
                        break;
                    case "gridViewCDSpecialization":
                        DataRow rowgridViewCDSpecialization = gridViewCDSpecialization.GetFocusedDataRow();
                        if (rowgridViewCDSpecialization["SpecializationId"].ToString() != string.Empty)
                            SQLProvider.DeleteCDSpecialization(rowgridViewCDSpecialization["SpecializationId"].ToString());
                        break;
                    case "gridViewCDEstefaaKed":
                        DataRow rowgridViewCDEstefaaKed = gridViewCDEstefaaKed.GetFocusedDataRow();
                        if (rowgridViewCDEstefaaKed["EstefaaKedId"].ToString() != string.Empty)
                            SQLProvider.DeleteCDEstefaaKed(rowgridViewCDEstefaaKed["EstefaaKedId"].ToString());
                        break;
                    case "gridViewCDJobtitle":
                        DataRow rowgridViewCDJobtitle = gridViewCDJobtitle.GetFocusedDataRow();
                        if (rowgridViewCDJobtitle["JobtitleID"].ToString() != string.Empty)
                            SQLProvider.DeleteCDJobtitle(rowgridViewCDJobtitle["JobtitleID"]);
                        break;
                    case "gridViewCDsarfType":
                        DataRow rowgridViewCDsarfType = gridViewCDsarfType.GetFocusedDataRow();
                        if (rowgridViewCDsarfType["sarfTypeId"].ToString() != string.Empty)
                            SQLProvider.DeleteCDsarfType(rowgridViewCDsarfType["sarfTypeId"]);
                        break;
                    case "gridViewTBLDofatSarf":
                        DataRow rowgridViewTBLDofatSarf = gridViewTBLDofatSarf.GetFocusedDataRow();
                        if (rowgridViewTBLDofatSarf["DofatSarfId"].ToString() != string.Empty)
                            SQLProvider.DeleteTBLDofatSarf(rowgridViewTBLDofatSarf["DofatSarfId"]);
                        break;
                    default:
                        break;
                }
                Program.ShowMsg("تم الحذف", false, this, true);
                Program.Logger.LogThis("تم الحذف", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
            LoadData(ViewName);
        }
        #endregion
    }
}