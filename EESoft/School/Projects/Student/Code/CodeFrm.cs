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

namespace Student
{
    public partial class CodeFrm : XtraForm
    {
        #region -   Variables   -
        public enum GridViewNames
        {
            CDMarahel,
            CDAlsofof,
            CDEFasl,
            CDAlokobat,
            CDColekeyat,
            CDDyana,
            cdEyab_code,
            CDGov,
            CDHaletalked,
            CDHealth_office,
            CDJop,
            CDLogatcode,
            CDEltataem_code,
            CDGamaat_alnashat,
            CDMantaka,
            CDMarakez,
            CDMawad,
            CDnationalty,
            CDQualification,
            CDEqamaType,
            CDSaltalkaraba,
            CDRelativeCode,
            CDTakasosat,
            CDAlanshata,
            AppOptions
        }
        private readonly GridViewNames ViewName;
        #endregion
        #region -   Functions   -
        public CodeFrm(GridViewNames CodeName)
        {
            InitializeComponent();
            ViewName = CodeName;
            switch (CodeName)
            {
                case GridViewNames.CDMarahel:
                    gridControlCode.MainView = gridViewCDMarahel;
                     LoadData(GridViewNames.CDMarahel);
                     Text += " المراحل";
                    break;
                case GridViewNames.CDAlsofof:
                    gridControlCode.MainView = gridViewCDAlsofof;
                    LoadData(GridViewNames.CDAlsofof);
                    Text += " الصفوف";
                    break;
                case GridViewNames.CDEFasl:
                    gridControlCode.MainView = gridViewCDEFasl;
                    LoadData(GridViewNames.CDEFasl);
                    Text += " الفصول";
                    break;
                case GridViewNames.CDAlokobat:
                    gridControlCode.MainView = gridViewCDAlokobat;
                    LoadData(GridViewNames.CDAlokobat);
                    Text += " العقوبات";
                    break;
                case GridViewNames.CDColekeyat:
                    gridControlCode.MainView = gridViewCDColekeyat;
                    LoadData(GridViewNames.CDColekeyat);
                    Text += " سلوكيات";
                    break;
                case GridViewNames.CDDyana:
                    gridControlCode.MainView = gridViewCDDyana;
                    LoadData(GridViewNames.CDDyana);
                    Text += " الديانه";
                    break;
                case GridViewNames.cdEyab_code:
                    gridControlCode.MainView = gridViewcdEyab_code;
                    LoadData(GridViewNames.cdEyab_code);
                    Text += " انواع الغياب";
                    break;
                case GridViewNames.CDGov:
                    gridControlCode.MainView = gridViewCDGov;
                    LoadData(GridViewNames.CDGov);
                    Text += " المحافظات";
                    break;
                case GridViewNames.CDHaletalked:
                    gridControlCode.MainView = gridViewCDHaletalked;
                    LoadData(GridViewNames.CDHaletalked);
                    Text += " القيود";
                    break;
                case GridViewNames.CDHealth_office:
                    gridControlCode.MainView = gridViewCDHealth_office;
                    LoadData(GridViewNames.CDHealth_office);
                    Text += " مكاتب الصحه";
                    break;
                case GridViewNames.CDJop:
                    gridControlCode.MainView = gridViewCDJop;
                    LoadData(GridViewNames.CDJop);
                    Text += " الوظائف";
                    break;
                case GridViewNames.CDLogatcode:
                    gridControlCode.MainView = gridViewCDLogatcode;
                    LoadData(GridViewNames.CDLogatcode);
                    Text += " اللغات";
                    break;
                case GridViewNames.CDEltataem_code:
                    gridControlCode.MainView = gridViewCDEltataem_code;
                    LoadData(GridViewNames.CDEltataem_code);
                    Text += " التطعيمات";
                    break;
                case GridViewNames.CDGamaat_alnashat:
                    gridControlCode.MainView = gridViewCDGamaat_alnashat;
                    LoadData(GridViewNames.CDGamaat_alnashat);
                    Text += " الجماعات";
                    break;
                case GridViewNames.CDMantaka:
                    gridControlCode.MainView = gridViewCDMantaka;
                    LoadData(GridViewNames.CDMantaka);
                    Text += " المناطق";
                    break;
                case GridViewNames.CDMarakez:
                    gridControlCode.MainView = gridViewCDMarakez;
                    LoadData(GridViewNames.CDMarakez);
                    Text += " المراكز";
                    break;
                case GridViewNames.CDMawad:
                    gridControlCode.MainView = advBandedGridViewCDMawad;
                    LoadData(GridViewNames.CDMawad);
                    Text += " المواد";
                    break;
                case GridViewNames.CDnationalty:
                    gridControlCode.MainView = gridViewCDnationalty;
                    LoadData(GridViewNames.CDnationalty);
                    Text += " المواد";
                    break;
                case GridViewNames.CDQualification:
                    gridControlCode.MainView = gridViewCDQualification;
                    LoadData(GridViewNames.CDQualification);
                    Text += " المؤهلات";
                    break;
                case GridViewNames.CDEqamaType:
                    gridControlCode.MainView = gridViewCDEqamaType;
                    LoadData(GridViewNames.CDEqamaType);
                    Text += " انواع الاقامه";
                    break;
                case GridViewNames.CDSaltalkaraba:
                    gridControlCode.MainView = gridViewCDSaltalkaraba;
                    LoadData(GridViewNames.CDSaltalkaraba);
                    Text += " انواع صلة القرابه";
                    break;
                case GridViewNames.CDRelativeCode:
                    gridControlCode.MainView = gridViewCDRelativeCode;
                    LoadData(GridViewNames.CDRelativeCode);
                    Text += " انواع الاخوه و الاقارب";
                    break;
                case GridViewNames.CDTakasosat:
                    gridControlCode.MainView = gridViewCDTakasosat;
                    LoadData(GridViewNames.CDTakasosat);
                    Text += " انواع التخصصات";
                    break;
                case GridViewNames.CDAlanshata:
                    gridControlCode.MainView = gridViewCDAlanshata;
                    LoadData(GridViewNames.CDAlanshata);
                    Text += " انواع الانشطه الرياضيه";
                    break;
                case GridViewNames.AppOptions:
                    gridControlCode.MainView = layoutViewAppOptions;
                    LoadData(GridViewNames.AppOptions);
                    Text += " خيارات البرنامج";
                    break;
                default:
                    break;
            }
        }
        private void LoadData(GridViewNames CodeName)
        {
            DataTable dt = new DataTable();
            switch (CodeName)
            {
                case GridViewNames.CDMarahel:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT marhala_code, marhala_name, marhala_name_e FROM CDMarahel");
                    break;
                case GridViewNames.CDAlsofof:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT alsofof_code, alsofof_name, marhala_code, alsofof_name_e, Shortly, Shortlye FROM CDAlsofof");
                    repositoryItemGridLookUpEditmarhala_code.DataSource = FXFW.SqlDB.LoadDataTable("Select marhala_code, marhala_name, marhala_name_e From CDMarahel");
                    break;
                case GridViewNames.CDEFasl:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT fasl_code, fasl_name, fasl_name_e FROM CDEFasl");
                    break;
                case GridViewNames.CDAlokobat:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT code_alokobat, name_alokobat, name_alokobat_e FROM CDAlokobat");
                    break;
                case GridViewNames.CDColekeyat:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT colekeyat_code, colekeyat_name, colekeyat_name_e FROM CDColekeyat");
                    break;
                case GridViewNames.CDDyana:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT dyana_code, dyana_name, dyana_name_e FROM CDDyana");
                    break;
                case GridViewNames.cdEyab_code:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT eyab_code, eyab_Name, eyab_Name_e FROM cdEyab_code");
                    break;
                case GridViewNames.CDGov:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT GOV_CD, GOV, GOVe FROM CDGov");
                    break;
                case GridViewNames.CDHaletalked:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT haletalked_code, haletalked_name, haletalked_name_e FROM CDHaletalked");
                    break;
                case GridViewNames.CDHealth_office:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT HE_CODE, HE_DESC, HE_DESC_e, GOV_CD FROM CDHealth_office");
                    repositoryItemGridLookUpEditGOV_CD.DataSource = FXFW.SqlDB.LoadDataTable("Select GOV_CD, GOV, GOVe From CDGov"); 
                    break;
                case GridViewNames.CDJop:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT jop_code, jop_name, jop_name_e FROM CDJop");
                    break;
                case GridViewNames.CDLogatcode:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT loga_code, loga_name, loga_name_e FROM CDLogatcode");
                    break;
                case GridViewNames.CDEltataem_code:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT code_eltataem, name_eltataem, name_eltataem_e FROM CDEltataem_code");
                    break;
                case GridViewNames.CDGamaat_alnashat:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT code_gamaat_alnashat, name_gamaat_alnashat, name_gamaat_alnashat_e FROM CDGamaat_alnashat");
                    break;
                case GridViewNames.CDMantaka:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT mantaka_code, GOV_CD, mantaka_name, mantaka_name_e FROM CDMantaka");
                    repositoryItemGridLookUpEditGOV_CD.DataSource = FXFW.SqlDB.LoadDataTable("Select GOV_CD, GOV, GOVe From CDGov"); 
                    break;
                case GridViewNames.CDMarakez:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT markaz_code, GOV_CD, markaz_name, markaz_name_e FROM CDMarakez");
                    repositoryItemGridLookUpEditGOV_CD.DataSource = FXFW.SqlDB.LoadDataTable("Select GOV_CD, GOV, GOVe From CDGov");
                    break;
                case GridViewNames.CDMawad:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT mawad_no, mowad_name, shortcut, mowad_name_e, shortcut_e, kg, prim, prp, sec, gadwal, exam FROM CDMawad");
                    break;
                case GridViewNames.CDnationalty:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT nationaltyId, nationaltyname, nationaltyname_e FROM CDnationalty");
                    break;
                case GridViewNames.CDQualification:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT qualId, qualName, qualName_e, trbawy FROM CDQualification");
                    break;
                case GridViewNames.CDEqamaType:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT EqamaID, EqamaName, EqamaNameE FROM CDEqamaType");
                    break;
                case GridViewNames.CDSaltalkaraba:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT saltalkarba_code, saltalkaraba_name FROM CDSaltalkaraba");
                    break;
                case GridViewNames.CDRelativeCode:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT RelativeCode, RelativeName, RelativeNamee FROM CDRelativeCode");
                    break;
                case GridViewNames.CDTakasosat:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT SPECIAL_CODE, SPECIAL_DESC, SPECIAL_DESCE, alsofof_code FROM CDTakasosat");
                    repositoryItemSearchLookUpEditalsofof_code.DataSource = FXFW.SqlDB.LoadDataTable(@"Select alsofof_code, alsofof_name, alsofof_name_e From CDAlsofof");
                    repositoryItemSearchLookUpEditalsofof_code.DisplayMember = "alsofof_name";
                    repositoryItemSearchLookUpEditalsofof_code.ValueMember = "alsofof_code";
                    break;
                case GridViewNames.CDAlanshata:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT code_alnashat, name_alnashat, name_alnashatE FROM CDAlanshata");
                    break;
                case GridViewNames.AppOptions:
                    dt = FXFW.SqlDB.LoadDataTable(@"SELECT OpCodeID, Writer, Dictated, Writer2, Dictated2, ApprovedBy, SchoolLogo FROM AppOptions");
                    break;
                default:
                    break;
            }
            gridControlCode.DataSource = dt;
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
            FXFW.SqlDB.GetFormPriv("Stu" + ViewName, ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
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
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                con.Open();
                switch (gridControlCode.MainView.Name)
                {
                    case "gridViewCDMarahel":
                        DataRow rowgridViewCDMarahel = gridViewCDMarahel.GetFocusedDataRow();
                        if (rowgridViewCDMarahel["marhala_code"].ToString() == string.Empty)
                        {
                            cmd.CommandText = string.Format(@"INSERT INTO CDMarahel (marhala_code, marhala_name, marhala_name_e)
                            VALUES ((SELECT ISNULL(MAX(marhala_code) + 1, 1) FROM CDMarahel), N'{0}', N'{1}')", rowgridViewCDMarahel["marhala_name"], rowgridViewCDMarahel["marhala_name_e"]);
                        }
                        else
                        {
                            cmd.CommandText = string.Format(@"UPDATE CDMarahel SET marhala_name = N'{0}', marhala_name_e = N'{1}' WHERE (marhala_code = {2})",
                            rowgridViewCDMarahel["marhala_name"], rowgridViewCDMarahel["marhala_name_e"], rowgridViewCDMarahel["marhala_code"]);
                        }
                        cmd.ExecuteNonQuery();
                        break;
                    case "gridViewCDAlsofof":
                        DataRow rowgridViewCDAlsofof = gridViewCDAlsofof.GetFocusedDataRow();
                        if (rowgridViewCDAlsofof["alsofof_code"].ToString() == string.Empty)
                        {
                            cmd.CommandText = string.Format(@"INSERT INTO CDAlsofof (alsofof_code, alsofof_name, alsofof_name_e, marhala_code, Shortly, Shortlye)
                            VALUES ((SELECT ISNULL(MAX(alsofof_code) + 1, 1) FROM CDAlsofof), N'{0}', N'{1}', {2}, N'{3}', N'{4}')", rowgridViewCDAlsofof["alsofof_name"],
                            rowgridViewCDAlsofof["alsofof_name_e"], rowgridViewCDAlsofof["marhala_code"], rowgridViewCDAlsofof["Shortly"], rowgridViewCDAlsofof["Shortlye"]);
                        }
                        else
                        {
                            cmd.CommandText = string.Format(@"UPDATE CDAlsofof SET alsofof_name = N'{0}', alsofof_name_e = N'{1}', marhala_code = {2},
                            Shortly = N'{3}', Shortlye = N'{4}' WHERE (alsofof_code = {5})",
                            rowgridViewCDAlsofof["alsofof_name"], rowgridViewCDAlsofof["alsofof_name_e"], rowgridViewCDAlsofof["marhala_code"], rowgridViewCDAlsofof["Shortly"],
                            rowgridViewCDAlsofof["Shortlye"], rowgridViewCDAlsofof["alsofof_code"]);
                        }
                        cmd.ExecuteNonQuery();
                        break;
                    case "gridViewCDEFasl":
                        DataRow rowggridViewCDEFasl = gridViewCDEFasl.GetFocusedDataRow();
                        if (rowggridViewCDEFasl["fasl_code"].ToString() == string.Empty)
                        {
                            cmd.CommandText = string.Format(@"INSERT INTO CDEFasl (fasl_code, fasl_name, fasl_name_e)
                            VALUES ((SELECT ISNULL(MAX(fasl_code) + 1, 1) FROM CDEFasl), N'{0}', N'{1}')", rowggridViewCDEFasl["fasl_name"], rowggridViewCDEFasl["fasl_name_e"]);
                        }
                        else
                        {
                            cmd.CommandText = string.Format(@"UPDATE CDEFasl SET fasl_name = N'{0}', fasl_name_e = N'{1}' WHERE (fasl_code = {2})",
                            rowggridViewCDEFasl["fasl_name"], rowggridViewCDEFasl["fasl_name_e"], rowggridViewCDEFasl["fasl_code"]);
                        }
                        cmd.ExecuteNonQuery();
                        break;
                    case "gridViewCDAlokobat":
                        DataRow rowgridViewCDAlokobat = gridViewCDAlokobat.GetFocusedDataRow();
                        if (rowgridViewCDAlokobat["code_alokobat"].ToString() == string.Empty)
                        {
                            cmd.CommandText = string.Format(@"INSERT INTO CDAlokobat (code_alokobat, name_alokobat, name_alokobat_e)
                            VALUES ((SELECT ISNULL(MAX(code_alokobat) + 1, 1) FROM CDAlokobat), N'{0}', N'{1}')", rowgridViewCDAlokobat["name_alokobat"], rowgridViewCDAlokobat["name_alokobat_e"]);
                        }
                        else
                        {
                            cmd.CommandText = string.Format(@"UPDATE CDAlokobat SET name_alokobat = N'{0}', name_alokobat_e = N'{1}' WHERE (code_alokobat = {2})",
                            rowgridViewCDAlokobat["name_alokobat"], rowgridViewCDAlokobat["name_alokobat_e"], rowgridViewCDAlokobat["code_alokobat"]);
                        }
                        cmd.ExecuteNonQuery();
                        break;
                    case "gridViewCDColekeyat":
                        DataRow rowgridViewCDColekeyat = gridViewCDColekeyat.GetFocusedDataRow();
                        if (rowgridViewCDColekeyat["colekeyat_code"].ToString() == string.Empty)
                        {
                            cmd.CommandText = string.Format(@"INSERT INTO CDColekeyat (colekeyat_code, colekeyat_name, colekeyat_name_e)
                            VALUES ((SELECT ISNULL(MAX(colekeyat_code) + 1, 1) FROM CDColekeyat), N'{0}', N'{1}')", rowgridViewCDColekeyat["colekeyat_name"], rowgridViewCDColekeyat["colekeyat_name_e"]);
                        }
                        else
                        {
                            cmd.CommandText = string.Format(@"UPDATE CDColekeyat SET colekeyat_name = N'{0}', colekeyat_name_e = N'{1}' WHERE (colekeyat_code = {2})",
                            rowgridViewCDColekeyat["colekeyat_name"], rowgridViewCDColekeyat["colekeyat_name_e"], rowgridViewCDColekeyat["colekeyat_code"]);
                        }
                        cmd.ExecuteNonQuery();
                        break;
                    case "gridViewCDDyana":
                        DataRow rowgridViewCDDyana = gridViewCDDyana.GetFocusedDataRow();
                        if (rowgridViewCDDyana["dyana_code"].ToString() == string.Empty)
                        {
                            cmd.CommandText = string.Format(@"INSERT INTO CDDyana (dyana_code, dyana_name, dyana_name_e)
                            VALUES ((SELECT ISNULL(MAX(dyana_code) + 1, 1) FROM CDDyana), N'{0}', N'{1}')", rowgridViewCDDyana["dyana_name"], rowgridViewCDDyana["dyana_name_e"]);
                        }
                        else
                        {
                            cmd.CommandText = string.Format(@"UPDATE CDDyana SET dyana_name = N'{0}', dyana_name_e = N'{1}' WHERE (dyana_code = {2})",
                            rowgridViewCDDyana["dyana_name"], rowgridViewCDDyana["dyana_name_e"], rowgridViewCDDyana["dyana_code"]);
                        }
                        cmd.ExecuteNonQuery();
                        break;
                    case "gridViewcdEyab_code":
                        DataRow rowgridViewcdEyab_code = gridViewcdEyab_code.GetFocusedDataRow();
                        if (rowgridViewcdEyab_code["eyab_code"].ToString() == string.Empty)
                        {
                            cmd.CommandText = string.Format(@"INSERT INTO cdEyab_code (eyab_code, eyab_Name, eyab_Name_e)
                            VALUES ((SELECT ISNULL(MAX(eyab_code) + 1, 1) FROM cdEyab_code), N'{0}', N'{1}')", rowgridViewcdEyab_code["eyab_Name"], rowgridViewcdEyab_code["eyab_Name_e"]);
                        }
                        else
                        {
                            cmd.CommandText = string.Format(@"UPDATE cdEyab_code SET eyab_Name = N'{0}', eyab_Name_e = N'{1}' WHERE (eyab_code = {2})",
                            rowgridViewcdEyab_code["eyab_Name"], rowgridViewcdEyab_code["eyab_Name_e"], rowgridViewcdEyab_code["eyab_code"]);
                        }
                        cmd.ExecuteNonQuery();
                        break;
                    case "gridViewCDGov":
                        DataRow rowgridViewCDGov = gridViewCDGov.GetFocusedDataRow();
                        if (rowgridViewCDGov["GOV_CD"].ToString() == string.Empty)
                        {
                            cmd.CommandText = string.Format(@"INSERT INTO CDGov (GOV_CD, GOV, GOVe)
                            VALUES ((SELECT ISNULL(MAX(GOV_CD) + 1, 1) FROM CDGov), N'{0}', N'{1}')", rowgridViewCDGov["GOV"], rowgridViewCDGov["GOVe"]);
                        }
                        else
                        {
                            cmd.CommandText = string.Format(@"UPDATE CDGov SET GOV = N'{0}', GOVe = N'{1}' WHERE (GOV_CD = {2})",
                            rowgridViewCDGov["GOV"], rowgridViewCDGov["GOVe"], rowgridViewCDGov["GOV_CD"]);
                        }
                        cmd.ExecuteNonQuery();
                        break;
                    case "gridViewCDHaletalked":
                        DataRow rowgridViewCDHaletalked = gridViewCDHaletalked.GetFocusedDataRow();
                        if (rowgridViewCDHaletalked["haletalked_code"].ToString() == string.Empty)
                        {
                            cmd.CommandText = string.Format(@"INSERT INTO CDHaletalked (haletalked_code, haletalked_name, haletalked_name_e)
                            VALUES ((SELECT ISNULL(MAX(haletalked_code) + 1, 1) FROM CDHaletalked), N'{0}', N'{1}')", rowgridViewCDHaletalked["haletalked_name"], rowgridViewCDHaletalked["haletalked_name_e"]);
                        }
                        else
                        {
                            cmd.CommandText = string.Format(@"UPDATE CDHaletalked SET haletalked_name = N'{0}', haletalked_name_e = N'{1}' WHERE (haletalked_code = {2})",
                            rowgridViewCDHaletalked["haletalked_name"], rowgridViewCDHaletalked["haletalked_name_e"], rowgridViewCDHaletalked["haletalked_code"]);
                        }
                        cmd.ExecuteNonQuery();
                        break;
                    case "gridViewCDHealth_office":
                        DataRow rowgridViewCDHealth_office = gridViewCDHealth_office.GetFocusedDataRow();
                        string GOV_CD;
                        if (rowgridViewCDHealth_office["GOV_CD"].ToString() == string.Empty)
                            GOV_CD = "NULL";
                        else
                            GOV_CD = rowgridViewCDHealth_office["GOV_CD"].ToString();
                        if (rowgridViewCDHealth_office["HE_CODE"].ToString() == string.Empty)
                        {
                            cmd.CommandText = string.Format(@"INSERT INTO CDHealth_office (HE_CODE, HE_DESC, HE_DESC_e, GOV_CD)
                            VALUES ((SELECT ISNULL(MAX(HE_CODE) + 1, 1) FROM CDHealth_office), N'{0}', N'{1}', {2})", rowgridViewCDHealth_office["HE_DESC"],
                            rowgridViewCDHealth_office["HE_DESC_e"], GOV_CD);
                        }
                        else
                        {
                            cmd.CommandText = string.Format(@"UPDATE CDHealth_office SET HE_DESC = N'{0}', HE_DESC_e = N'{1}', GOV_CD = {2} WHERE (HE_CODE = {3})",
                            rowgridViewCDHealth_office["HE_DESC"], rowgridViewCDHealth_office["HE_DESC_e"], GOV_CD, rowgridViewCDHealth_office["HE_CODE"]);
                        }
                        cmd.ExecuteNonQuery();
                        break;
                    case "gridViewCDJop":
                        DataRow rowgridViewCDJop = gridViewCDJop.GetFocusedDataRow();
                        if (rowgridViewCDJop["jop_code"].ToString() == string.Empty)
                        {
                            cmd.CommandText = string.Format(@"INSERT INTO CDJop (jop_code, jop_name, jop_name_e)
                            VALUES ((SELECT ISNULL(MAX(jop_code) + 1, 1) FROM CDJop), N'{0}', N'{1}')", rowgridViewCDJop["jop_name"], rowgridViewCDJop["jop_name_e"]);
                        }
                        else
                        {
                            cmd.CommandText = string.Format(@"UPDATE CDJop SET jop_name = N'{0}', jop_name_e = N'{1}' WHERE (jop_code = {2})",
                            rowgridViewCDJop["jop_name"], rowgridViewCDJop["jop_name_e"], rowgridViewCDJop["jop_code"]);
                        }
                        cmd.ExecuteNonQuery();
                        break;
                    case "gridViewCDLogatcode":
                        DataRow rowgridViewCDLogatcode = gridViewCDLogatcode.GetFocusedDataRow();
                        if (rowgridViewCDLogatcode["loga_code"].ToString() == string.Empty)
                        {
                            cmd.CommandText = string.Format(@"INSERT INTO CDLogatcode (loga_code, loga_name, loga_name_e)
                            VALUES ((SELECT ISNULL(MAX(loga_code) + 1, 1) FROM CDLogatcode), N'{0}', N'{1}')", rowgridViewCDLogatcode["loga_name"], rowgridViewCDLogatcode["loga_name_e"]);
                        }
                        else
                        {
                            cmd.CommandText = string.Format(@"UPDATE CDLogatcode SET loga_name = N'{0}', loga_name_e = N'{1}' WHERE (loga_code = {2})",
                            rowgridViewCDLogatcode["loga_name"], rowgridViewCDLogatcode["loga_name_e"], rowgridViewCDLogatcode["loga_code"]);
                        }
                        cmd.ExecuteNonQuery();
                        break;
                    case "gridViewCDEltataem_code":
                        DataRow rowgridViewCDEltataem_code = gridViewCDEltataem_code.GetFocusedDataRow();
                        if (rowgridViewCDEltataem_code["code_eltataem"].ToString() == string.Empty)
                        {
                            cmd.CommandText = string.Format(@"INSERT INTO CDEltataem_code (code_eltataem, name_eltataem, name_eltataem_e)
                            VALUES ((SELECT ISNULL(MAX(code_eltataem) + 1, 1) FROM CDEltataem_code), N'{0}', N'{1}')", rowgridViewCDEltataem_code["name_eltataem"], rowgridViewCDEltataem_code["name_eltataem_e"]);
                        }
                        else
                        {
                            cmd.CommandText = string.Format(@"UPDATE CDEltataem_code SET name_eltataem = N'{0}', name_eltataem_e = N'{1}' WHERE (code_eltataem = {2})",
                            rowgridViewCDEltataem_code["name_eltataem"], rowgridViewCDEltataem_code["name_eltataem_e"], rowgridViewCDEltataem_code["code_eltataem"]);
                        }
                        cmd.ExecuteNonQuery();
                        break;
                    case "gridViewCDGamaat_alnashat":
                        DataRow rowgridViewCDGamaat_alnashat = gridViewCDGamaat_alnashat.GetFocusedDataRow();
                        if (rowgridViewCDGamaat_alnashat["code_gamaat_alnashat"].ToString() == string.Empty)
                        {
                            cmd.CommandText = string.Format(@"INSERT INTO CDGamaat_alnashat (code_gamaat_alnashat, name_gamaat_alnashat, name_gamaat_alnashat_e)
                            VALUES ((SELECT ISNULL(MAX(code_gamaat_alnashat) + 1, 1) FROM CDGamaat_alnashat), N'{0}', N'{1}')", rowgridViewCDGamaat_alnashat["name_gamaat_alnashat"], rowgridViewCDGamaat_alnashat["name_gamaat_alnashat_e"]);
                        }
                        else
                        {
                            cmd.CommandText = string.Format(@"UPDATE CDGamaat_alnashat SET name_gamaat_alnashat = N'{0}', name_gamaat_alnashat_e = N'{1}' WHERE (code_gamaat_alnashat = {2})",
                            rowgridViewCDGamaat_alnashat["name_gamaat_alnashat"], rowgridViewCDGamaat_alnashat["name_gamaat_alnashat_e"], rowgridViewCDGamaat_alnashat["code_gamaat_alnashat"]);
                        }
                        cmd.ExecuteNonQuery();
                        break;
                    case "gridViewCDMantaka":
                        DataRow rowgridViewCDMantaka = gridViewCDMantaka.GetFocusedDataRow();
                        string GOV_CD2;
                        if (rowgridViewCDMantaka["GOV_CD"].ToString() == string.Empty)
                            GOV_CD2 = "NULL";
                        else
                            GOV_CD2 = rowgridViewCDMantaka["GOV_CD"].ToString();
                        if (rowgridViewCDMantaka["mantaka_code"].ToString() == string.Empty)
                        {
                            cmd.CommandText = string.Format(@"INSERT INTO CDMantaka (mantaka_code, mantaka_name, mantaka_name_e, GOV_CD)
                            VALUES ((SELECT ISNULL(MAX(mantaka_code) + 1, 1) FROM CDMantaka), N'{0}', N'{1}', {2})", rowgridViewCDMantaka["mantaka_name"],
                            rowgridViewCDMantaka["mantaka_name_e"], GOV_CD2);
                        }
                        else
                        {
                            cmd.CommandText = string.Format(@"UPDATE CDMantaka SET mantaka_name = N'{0}', mantaka_name_e = N'{1}', GOV_CD = {2} WHERE (mantaka_code = {3})",
                            rowgridViewCDMantaka["mantaka_name"], rowgridViewCDMantaka["mantaka_name_e"], GOV_CD2, rowgridViewCDMantaka["mantaka_code"]);
                        }
                        cmd.ExecuteNonQuery();
                        break;
                    case "gridViewCDMarakez":
                        DataRow rowgridViewCDMarakez = gridViewCDMarakez.GetFocusedDataRow();
                        string GOV_CD3;
                        if (rowgridViewCDMarakez["GOV_CD"].ToString() == string.Empty)
                            GOV_CD3 = "NULL";
                        else
                            GOV_CD3 = rowgridViewCDMarakez["GOV_CD"].ToString();
                        if (rowgridViewCDMarakez["markaz_code"].ToString() == string.Empty)
                        {
                            cmd.CommandText = string.Format(@"INSERT INTO CDMarakez (markaz_code, markaz_name, markaz_name_e, GOV_CD)
                            VALUES ((SELECT ISNULL(MAX(markaz_code) + 1, 1) FROM CDMarakez), N'{0}', N'{1}', {2})", rowgridViewCDMarakez["markaz_name"],
                            rowgridViewCDMarakez["markaz_name_e"], GOV_CD3);
                        }
                        else
                        {
                            cmd.CommandText = string.Format(@"UPDATE CDMarakez SET markaz_name = N'{0}', markaz_name_e = N'{1}', GOV_CD = {2} WHERE (markaz_code = {3})",
                            rowgridViewCDMarakez["markaz_name"], rowgridViewCDMarakez["markaz_name_e"], GOV_CD3, rowgridViewCDMarakez["markaz_code"]);
                        }
                        cmd.ExecuteNonQuery();
                        break;
                    case "advBandedGridViewCDMawad":
                        DataRow rowadvBandedGridViewCDMawad = advBandedGridViewCDMawad.GetFocusedDataRow();
                        if (rowadvBandedGridViewCDMawad["mawad_no"].ToString() == string.Empty)
                        {
                            cmd.CommandText = string.Format(@"INSERT INTO CDMawad (mawad_no, mowad_name, shortcut, mowad_name_e, shortcut_e, kg, prim, prp, sec, gadwal, exam)
                            VALUES ((SELECT ISNULL(MAX(mawad_no) + 1, 1) FROM CDMawad), N'{0}', N'{1}', N'{2}', N'{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}')", rowadvBandedGridViewCDMawad["mowad_name"],
                            rowadvBandedGridViewCDMawad["shortcut"], rowadvBandedGridViewCDMawad["mowad_name_e"], rowadvBandedGridViewCDMawad["shortcut_e"], rowadvBandedGridViewCDMawad["kg"],
                            rowadvBandedGridViewCDMawad["prim"], rowadvBandedGridViewCDMawad["prp"], rowadvBandedGridViewCDMawad["sec"], rowadvBandedGridViewCDMawad["gadwal"],
                            rowadvBandedGridViewCDMawad["exam"]);
                        }
                        else
                        {
                            cmd.CommandText = string.Format(@"UPDATE CDMawad SET mowad_name = N'{0}', shortcut = N'{1}', mowad_name_e = N'{2}', shortcut_e = N'{3}', 
                            kg = '{4}', prim = '{5}', prp = '{6}', sec = '{7}', gadwal = '{8}', exam = '{9}' WHERE (mawad_no = {10})",
                            rowadvBandedGridViewCDMawad["mowad_name"], rowadvBandedGridViewCDMawad["shortcut"], rowadvBandedGridViewCDMawad["mowad_name_e"], rowadvBandedGridViewCDMawad["shortcut_e"],
                            rowadvBandedGridViewCDMawad["kg"], rowadvBandedGridViewCDMawad["prim"], rowadvBandedGridViewCDMawad["prp"], rowadvBandedGridViewCDMawad["sec"], rowadvBandedGridViewCDMawad["gadwal"],
                            rowadvBandedGridViewCDMawad["exam"], rowadvBandedGridViewCDMawad["mawad_no"]);
                        }
                        cmd.ExecuteNonQuery();
                        break;
                    case "gridViewCDnationalty":
                        DataRow rowgridViewCDnationalty = gridViewCDnationalty.GetFocusedDataRow();
                        if (rowgridViewCDnationalty["nationaltyId"].ToString() == string.Empty)
                        {
                            cmd.CommandText = string.Format(@"INSERT INTO CDnationalty (nationaltyId, nationaltyname, nationaltyname_e)
                            VALUES ((SELECT ISNULL(MAX(nationaltyId) + 1, 1) FROM CDnationalty), N'{0}', N'{1}')", rowgridViewCDnationalty["nationaltyname"], rowgridViewCDnationalty["nationaltyname_e"]);
                        }
                        else
                        {
                            cmd.CommandText = string.Format(@"UPDATE CDnationalty SET nationaltyname = N'{0}', nationaltyname_e = N'{1}' WHERE (nationaltyId = {2})",
                            rowgridViewCDnationalty["nationaltyname"], rowgridViewCDnationalty["nationaltyname_e"], rowgridViewCDnationalty["nationaltyId"]);
                        }
                        cmd.ExecuteNonQuery();
                        break;
                    case "gridViewCDQualification":
                        DataRow rowgridViewCDQualification = gridViewCDQualification.GetFocusedDataRow();
                        if (rowgridViewCDQualification["qualId"].ToString() == string.Empty)
                        {
                            cmd.CommandText = string.Format(@"INSERT INTO CDQualification (qualId, qualName, qualName_e, trbawy)
                            VALUES ((SELECT ISNULL(MAX(qualId) + 1, 1) FROM CDQualification), N'{0}', N'{1}', '{2}')", rowgridViewCDQualification["qualName"],
                            rowgridViewCDQualification["qualName_e"], rowgridViewCDQualification["trbawy"]);
                        }
                        else
                        {
                            cmd.CommandText = string.Format(@"UPDATE CDQualification SET qualName = N'{0}', qualName_e = N'{1}', trbawy = '{2}' WHERE (qualId = {3})",
                            rowgridViewCDQualification["qualName"], rowgridViewCDQualification["qualName_e"], rowgridViewCDQualification["trbawy"], rowgridViewCDQualification["qualId"]);
                        }
                        cmd.ExecuteNonQuery();
                        break;
                    case "gridViewCDEqamaType":
                        DataRow rowgridViewCDEqamaType = gridViewCDEqamaType.GetFocusedDataRow();
                        if (rowgridViewCDEqamaType["EqamaID"].ToString() == string.Empty)
                        {
                            cmd.CommandText = string.Format(@"INSERT INTO CDEqamaType (EqamaID, EqamaName, EqamaNameE)
                            VALUES ((SELECT ISNULL(MAX(EqamaID) + 1, 1) FROM CDEqamaType), N'{0}', N'{1}')", rowgridViewCDEqamaType["EqamaName"],
                            rowgridViewCDEqamaType["EqamaNameE"]);
                        }
                        else
                        {
                            cmd.CommandText = string.Format(@"UPDATE CDEqamaType SET EqamaName = N'{0}', EqamaNameE = N'{1}' WHERE (EqamaID = {2})",
                            rowgridViewCDEqamaType["EqamaName"], rowgridViewCDEqamaType["EqamaNameE"], rowgridViewCDEqamaType["EqamaID"]);
                        }
                        cmd.ExecuteNonQuery();
                        break;
                    case "gridViewCDSaltalkaraba":
                        DataRow rowgridViewCDSaltalkaraba = gridViewCDSaltalkaraba.GetFocusedDataRow();
                        if (rowgridViewCDSaltalkaraba["saltalkarba_code"].ToString() == string.Empty)
                        {
                            cmd.CommandText = string.Format(@"INSERT INTO CDSaltalkaraba (saltalkarba_code, saltalkaraba_name)
                            VALUES ((SELECT ISNULL(MAX(saltalkarba_code) + 1, 1) FROM CDSaltalkaraba), N'{0}')", rowgridViewCDSaltalkaraba["saltalkaraba_name"]);
                        }
                        else
                        {
                            cmd.CommandText = string.Format(@"UPDATE CDSaltalkaraba SET saltalkaraba_name = N'{0}' WHERE (saltalkarba_code = {1})",
                            rowgridViewCDSaltalkaraba["saltalkaraba_name"], rowgridViewCDSaltalkaraba["saltalkarba_code"]);
                        }
                        cmd.ExecuteNonQuery();
                        break;
                    case "gridViewCDRelativeCode":
                        DataRow rowgridViewCDRelativeCode = gridViewCDRelativeCode.GetFocusedDataRow();
                        if (rowgridViewCDRelativeCode["RelativeCode"].ToString() == string.Empty)
                        {
                            cmd.CommandText = string.Format(@"INSERT INTO CDRelativeCode (RelativeCode, RelativeName, RelativeNamee)
                            VALUES ((SELECT ISNULL(MAX(RelativeCode) + 1, 1) FROM CDRelativeCode), N'{0}', N'{1}')",
                            rowgridViewCDRelativeCode["RelativeName"], rowgridViewCDRelativeCode["RelativeNamee"]);
                        }
                        else
                        {
                            cmd.CommandText = string.Format(@"UPDATE CDRelativeCode SET RelativeName = N'{0}', RelativeNamee = N'{1}' WHERE (RelativeCode = {2})",
                            rowgridViewCDRelativeCode["RelativeName"], rowgridViewCDRelativeCode["RelativeNamee"], rowgridViewCDRelativeCode["RelativeCode"]);
                        }
                        cmd.ExecuteNonQuery();
                        break;
                    case "gridViewCDTakasosat":
                        DataRow rowgridViewCDTakasosat= gridViewCDTakasosat.GetFocusedDataRow();
                        string alsofof_code;
                        if (rowgridViewCDTakasosat["alsofof_code"].ToString() == string.Empty)
                            alsofof_code = "NULL";
                        else
                            alsofof_code = rowgridViewCDTakasosat["alsofof_code"].ToString();

                        if (rowgridViewCDTakasosat["SPECIAL_CODE"].ToString() == string.Empty)
                        {
                            cmd.CommandText = string.Format(@"INSERT INTO CDTakasosat (SPECIAL_CODE, SPECIAL_DESC, SPECIAL_DESCE, alsofof_code)
                            VALUES ((SELECT ISNULL(MAX(SPECIAL_CODE) + 1, 1) FROM CDTakasosat), N'{0}', N'{1}', {2})",
                            rowgridViewCDTakasosat["SPECIAL_DESC"], rowgridViewCDTakasosat["SPECIAL_DESCE"], alsofof_code);
                        }
                        else
                        {
                            cmd.CommandText = string.Format(@"UPDATE CDTakasosat SET SPECIAL_DESC = N'{0}', SPECIAL_DESCE = N'{1}', alsofof_code = {2} WHERE (SPECIAL_CODE = {3})",
                            rowgridViewCDTakasosat["SPECIAL_DESC"], rowgridViewCDTakasosat["SPECIAL_DESCE"], alsofof_code, rowgridViewCDTakasosat["SPECIAL_CODE"]);
                        }
                        cmd.ExecuteNonQuery();
                        break;
                    case "gridViewCDAlanshata":
                        DataRow rowgridViewCDAlanshata = gridViewCDAlanshata.GetFocusedDataRow();
                        if (rowgridViewCDAlanshata["code_alnashat"].ToString() == string.Empty)
                        {
                            cmd.CommandText = string.Format(@"INSERT INTO CDAlanshata (code_alnashat, name_alnashat, name_alnashatE)
                            VALUES ((SELECT ISNULL(MAX(code_alnashat) + 1, 1) FROM CDAlanshata), N'{0}', N'{1}')",
                            rowgridViewCDAlanshata["name_alnashat"], rowgridViewCDAlanshata["name_alnashatE"]);
                        }
                        else
                        {
                            cmd.CommandText = string.Format(@"UPDATE CDAlanshata SET name_alnashat = N'{0}', name_alnashatE = N'{1}' WHERE (code_alnashat = {2})",
                            rowgridViewCDAlanshata["name_alnashat"], rowgridViewCDAlanshata["name_alnashatE"], rowgridViewCDAlanshata["code_alnashat"]);
                        }
                        cmd.ExecuteNonQuery();
                        break;
                    case "layoutViewAppOptions":
                        DataRow rowlayoutViewAppOptions = layoutViewAppOptions.GetFocusedDataRow();
                        if (rowlayoutViewAppOptions["OpCodeID"].ToString() == string.Empty)
                            break;
                        else
                        {
                            cmd.CommandText = string.Format(@"UPDATE AppOptions SET Writer = N'{0}', Dictated = N'{1}', Writer2 = N'{2}', Dictated2 = N'{3}', ApprovedBy = N'{4}', SchoolLogo = @SchoolLogo WHERE (OpCodeID = {5})",
                            rowlayoutViewAppOptions["Writer"], rowlayoutViewAppOptions["Dictated"], rowlayoutViewAppOptions["Writer2"], rowlayoutViewAppOptions["Dictated2"], rowlayoutViewAppOptions["ApprovedBy"], rowlayoutViewAppOptions["OpCodeID"]);
                        }
                        if (rowlayoutViewAppOptions["SchoolLogo"].ToString() != string.Empty)
                            cmd.Parameters.AddWithValue("@SchoolLogo", rowlayoutViewAppOptions["SchoolLogo"]);
                        else
                        {
                            System.IO.MemoryStream ms = new System.IO.MemoryStream();
                            global::Student.Properties.Resources.NoImg.Save(ms, global::Student.Properties.Resources.NoImg.RawFormat);
                            cmd.Parameters.AddWithValue("@SchoolLogo", ms.GetBuffer());
                        }
                        cmd.ExecuteNonQuery();
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
            con.Close();
            LoadData(ViewName);
        }
        private void repositoryItemButtonEditDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟","تحزير ...",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                con.Open();
                switch (gridControlCode.MainView.Name)
                {
                    case "gridViewCDMarahel":
                        DataRow rowgridViewCDMarahel = gridViewCDMarahel.GetFocusedDataRow();
                        if (rowgridViewCDMarahel["marhala_code"].ToString() != string.Empty)
                        {
                            cmd.CommandText = string.Format(@"DELETE FROM CDMarahel WHERE (marhala_code = {0})", rowgridViewCDMarahel["marhala_code"]);
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case "gridViewCDAlsofof":
                        DataRow rowgridViewCDAlsofof = gridViewCDAlsofof.GetFocusedDataRow();
                        if (rowgridViewCDAlsofof["alsofof_code"].ToString() != string.Empty)
                        {
                            cmd.CommandText = string.Format(@"DELETE FROM CDAlsofof WHERE (alsofof_code = {0})", rowgridViewCDAlsofof["alsofof_code"]);
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case "gridViewCDEFasl":
                        DataRow rowgridViewCDEFasl = gridViewCDEFasl.GetFocusedDataRow();
                        if (rowgridViewCDEFasl["fasl_code"].ToString() != string.Empty)
                        {
                            cmd.CommandText = string.Format(@"DELETE FROM CDEFasl WHERE (fasl_code = {0})", rowgridViewCDEFasl["fasl_code"]);
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case "gridViewCDAlokobat":
                        DataRow rowgridViewCDAlokobat = gridViewCDAlokobat.GetFocusedDataRow();
                        if (rowgridViewCDAlokobat["code_alokobat"].ToString() != string.Empty)
                        {
                            cmd.CommandText = string.Format(@"DELETE FROM CDAlokobat WHERE (code_alokobat = {0})", rowgridViewCDAlokobat["code_alokobat"]);
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case "gridViewCDColekeyat":
                        DataRow rowgridViewCDColekeyat = gridViewCDColekeyat.GetFocusedDataRow();
                        if (rowgridViewCDColekeyat["colekeyat_code"].ToString() != string.Empty)
                        {
                            cmd.CommandText = string.Format(@"DELETE FROM CDColekeyat WHERE (colekeyat_code = {0})", rowgridViewCDColekeyat["colekeyat_code"]);
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case "gridViewCDDyana":
                        DataRow rowgridViewCDDyana = gridViewCDDyana.GetFocusedDataRow();
                        if (rowgridViewCDDyana["dyana_code"].ToString() != string.Empty)
                        {
                            cmd.CommandText = string.Format(@"DELETE FROM CDDyana WHERE (dyana_code = {0})", rowgridViewCDDyana["dyana_code"]);
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case "gridViewcdEyab_code":
                        DataRow rowgridViewcdEyab_code = gridViewcdEyab_code.GetFocusedDataRow();
                        if (rowgridViewcdEyab_code["eyab_code"].ToString() != string.Empty)
                        {
                            cmd.CommandText = string.Format(@"DELETE FROM cdEyab_code WHERE (eyab_code = {0})", rowgridViewcdEyab_code["eyab_code"]);
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case "gridViewCDGov":
                        DataRow rowgridViewCDGov = gridViewCDGov.GetFocusedDataRow();
                        if (rowgridViewCDGov["GOV_CD"].ToString() != string.Empty)
                        {
                            cmd.CommandText = string.Format(@"DELETE FROM CDGov WHERE (GOV_CD = {0})", rowgridViewCDGov["GOV_CD"]);
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case "gridViewCDHaletalked":
                        DataRow rowgridViewCDHaletalked = gridViewCDHaletalked.GetFocusedDataRow();
                        if (rowgridViewCDHaletalked["haletalked_code"].ToString() != string.Empty)
                        {
                            cmd.CommandText = string.Format(@"DELETE FROM CDHaletalked WHERE (haletalked_code = {0})", rowgridViewCDHaletalked["haletalked_code"]);
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case "gridViewCDHealth_office":
                        DataRow rowgridViewCDHealth_office = gridViewCDHealth_office.GetFocusedDataRow();
                        if (rowgridViewCDHealth_office["HE_CODE"].ToString() != string.Empty)
                        {
                            cmd.CommandText = string.Format(@"DELETE FROM CDHealth_office WHERE (HE_CODE = {0})", rowgridViewCDHealth_office["HE_CODE"]);
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case "gridViewCDJop":
                        DataRow rowgridViewCDJop = gridViewCDJop.GetFocusedDataRow();
                        if (rowgridViewCDJop["jop_code"].ToString() != string.Empty)
                        {
                            cmd.CommandText = string.Format(@"DELETE FROM CDJop WHERE (jop_code = {0})", rowgridViewCDJop["jop_code"]);
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case "gridViewCDLogatcode":
                        DataRow rowgridViewCDLogatcode = gridViewCDLogatcode.GetFocusedDataRow();
                        if (rowgridViewCDLogatcode["loga_code"].ToString() != string.Empty)
                        {
                            cmd.CommandText = string.Format(@"DELETE FROM CDLogatcode WHERE (loga_code = {0})", rowgridViewCDLogatcode["loga_code"]);
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case "gridViewCDEltataem_code":
                        DataRow rowgridViewCDEltataem_code = gridViewCDEltataem_code.GetFocusedDataRow();
                        if (rowgridViewCDEltataem_code["code_eltataem"].ToString() != string.Empty)
                        {
                            cmd.CommandText = string.Format(@"DELETE FROM CDEltataem_code WHERE (code_eltataem = {0})", rowgridViewCDEltataem_code["code_eltataem"]);
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case "gridViewCDGamaat_alnashat":
                        DataRow rowgridViewCDGamaat_alnashat = gridViewCDGamaat_alnashat.GetFocusedDataRow();
                        if (rowgridViewCDGamaat_alnashat["code_gamaat_alnashat"].ToString() != string.Empty)
                        {
                            cmd.CommandText = string.Format(@"DELETE FROM CDGamaat_alnashat WHERE (code_gamaat_alnashat = {0})", rowgridViewCDGamaat_alnashat["code_gamaat_alnashat"]);
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case "gridViewCDMantaka":
                        DataRow rowgridViewCDMantaka = gridViewCDMantaka.GetFocusedDataRow();
                        if (rowgridViewCDMantaka["mantaka_code"].ToString() != string.Empty)
                        {
                            cmd.CommandText = string.Format(@"DELETE FROM CDMantaka WHERE (mantaka_code = {0})", rowgridViewCDMantaka["mantaka_code"]);
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case "gridViewCDMarakez":
                        DataRow rowgridViewCDMarakez = gridViewCDMarakez.GetFocusedDataRow();
                        if (rowgridViewCDMarakez["markaz_code"].ToString() != string.Empty)
                        {
                            cmd.CommandText = string.Format(@"DELETE FROM CDMarakez WHERE (markaz_code = {0})", rowgridViewCDMarakez["markaz_code"]);
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case "advBandedGridViewCDMawad":
                        DataRow rowadvBandedGridViewCDMawad = advBandedGridViewCDMawad.GetFocusedDataRow();
                        if (rowadvBandedGridViewCDMawad["mawad_no"].ToString() != string.Empty)
                        {
                            cmd.CommandText = string.Format(@"DELETE FROM CDMawad WHERE (mawad_no = {0})", rowadvBandedGridViewCDMawad["mawad_no"]);
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case "gridViewCDnationalty":
                        DataRow rowgridViewCDnationalty = gridViewCDnationalty.GetFocusedDataRow();
                        if (rowgridViewCDnationalty["nationaltyId"].ToString() != string.Empty)
                        {
                            cmd.CommandText = string.Format(@"DELETE FROM CDnationalty WHERE (nationaltyId = {0})", rowgridViewCDnationalty["nationaltyId"]);
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case "gridViewCDQualification":
                        DataRow rowgridViewCDQualification = gridViewCDQualification.GetFocusedDataRow();
                        if (rowgridViewCDQualification["qualId"].ToString() != string.Empty)
                        {
                            cmd.CommandText = string.Format(@"DELETE FROM CDQualification WHERE (qualId = {0})", rowgridViewCDQualification["qualId"]);
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case "gridViewCDEqamaType":
                        DataRow rowgridViewCDEqamaType = gridViewCDEqamaType.GetFocusedDataRow();
                        if (rowgridViewCDEqamaType["EqamaID"].ToString() != string.Empty)
                        {
                            cmd.CommandText = string.Format(@"DELETE FROM CDEqamaType WHERE (EqamaID = {0})", rowgridViewCDEqamaType["EqamaID"]);
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case "gridViewCDSaltalkaraba":
                        DataRow rowgridViewCDSaltalkaraba = gridViewCDSaltalkaraba.GetFocusedDataRow();
                        if (rowgridViewCDSaltalkaraba["saltalkarba_code"].ToString() != string.Empty)
                        {
                            cmd.CommandText = string.Format(@"DELETE FROM CDSaltalkaraba WHERE (saltalkarba_code = {0})", rowgridViewCDSaltalkaraba["saltalkarba_code"]);
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case "gridViewCDRelativeCode":
                        DataRow rowgridViewCDRelativeCode = gridViewCDRelativeCode.GetFocusedDataRow();
                        if (rowgridViewCDRelativeCode["RelativeCode"].ToString() != string.Empty)
                        {
                            cmd.CommandText = string.Format(@"DELETE FROM CDRelativeCode WHERE (RelativeCode = {0})", rowgridViewCDRelativeCode["RelativeCode"]);
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case "gridViewCDTakasosat":
                        DataRow rowgridViewCDTakasosat = gridViewCDTakasosat.GetFocusedDataRow();
                        if (rowgridViewCDTakasosat["SPECIAL_CODE"].ToString() != string.Empty)
                        {
                            cmd.CommandText = string.Format(@"DELETE FROM CDTakasosat WHERE (SPECIAL_CODE = {0})", rowgridViewCDTakasosat["SPECIAL_CODE"]);
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    case "gridViewCDAlanshata":
                        DataRow rowgridViewCDAlanshata = gridViewCDAlanshata.GetFocusedDataRow();
                        if (rowgridViewCDAlanshata["code_alnashat"].ToString() != string.Empty)
                        {
                            cmd.CommandText = string.Format(@"DELETE FROM CDAlanshata WHERE (code_alnashat = {0})", rowgridViewCDAlanshata["code_alnashat"]);
                            cmd.ExecuteNonQuery();
                        }
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
            con.Close();
            LoadData(ViewName);
        }
        #endregion

        
    }
}