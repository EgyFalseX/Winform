using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using FXFW;

namespace Employee
{
    public partial class Emp_MoaahelFrm : DevExpress.XtraEditors.XtraForm
    {
        
        #region -   Variables   -
        
        #endregion
        #region -   Functions   -
        public Emp_MoaahelFrm()
        {
            InitializeComponent();
        }
        private void LoadDefaultData(CodeFrm.TableNames TableName)
        {
            switch (TableName)
            {
                case CodeFrm.TableNames.CDQualification:
                    repositoryItemGridLookUpEditMoaahel_ID.DataSource = SqlDB.LoadDataTable(@"SELECT qualId, qualName, qualName_e FROM CDQualification");
                    repositoryItemGridLookUpEditMoaahel_ID.DisplayMember = "qualName";
                    repositoryItemGridLookUpEditMoaahel_ID.ValueMember = "qualId";
                    break;
                case CodeFrm.TableNames.CD_Specialization:
                    repositoryItemGridLookUpEditSPECIFICATION_ID.DataSource = SqlDB.LoadDataTable(@"SELECT SpecializationId, SpecializationName, SpecializationName_e FROM CD_Specialization");
                    repositoryItemGridLookUpEditSPECIFICATION_ID.DisplayMember = "SpecializationName";
                    repositoryItemGridLookUpEditSPECIFICATION_ID.ValueMember = "SpecializationId";
                    break;
                case CodeFrm.TableNames.CD_QualifiedPlace:
                    repositoryItemGridLookUpEditQualifiedPlaceId.DataSource = SqlDB.LoadDataTable(@"SELECT QualifiedPlaceId, QualifiedPlaceName, QualifiedPlaceName_e FROM CD_QualifiedPlace");
                    repositoryItemGridLookUpEditQualifiedPlaceId.DisplayMember = "QualifiedPlaceName";
                    repositoryItemGridLookUpEditQualifiedPlaceId.ValueMember = "QualifiedPlaceId";
                    break;
                case CodeFrm.TableNames.CDTakdeer:
                    repositoryItemGridLookUpEditTakdeerId.DataSource = SqlDB.LoadDataTable(@"SELECT TakdeerId, TakdeerName, TakdeerName_e FROM CDTakdeer");
                    repositoryItemGridLookUpEditTakdeerId.DisplayMember = "TakdeerName";
                    repositoryItemGridLookUpEditTakdeerId.ValueMember = "TakdeerId";
                    break;
                case CodeFrm.TableNames.All:
                    //CDQualification
                    repositoryItemGridLookUpEditMoaahel_ID.DataSource = SqlDB.LoadDataTable(@"SELECT qualId, qualName, qualName_e FROM CDQualification");
                    repositoryItemGridLookUpEditMoaahel_ID.DisplayMember = "qualName";
                    repositoryItemGridLookUpEditMoaahel_ID.ValueMember = "qualId";
                    //CD_Specialization
                    repositoryItemGridLookUpEditSPECIFICATION_ID.DataSource = SqlDB.LoadDataTable(@"SELECT SpecializationId, SpecializationName, SpecializationName_e FROM CD_Specialization");
                    repositoryItemGridLookUpEditSPECIFICATION_ID.DisplayMember = "SpecializationName";
                    repositoryItemGridLookUpEditSPECIFICATION_ID.ValueMember = "SpecializationId";
                    //TBL_Emp
                    repositoryItemGridLookUpEditEmp_ID.DataSource = SqlDB.LoadDataTable(@"SELECT EmpID, Isnull(EMP_FIRST_NAME, '') + ' ' + Isnull(EMP_FATHER_NAME, '') + ' ' + Isnull(EMP_FAM_NAME, '') + ' ' + Isnull(EMP_FOURTH_NAME, '') AS Emp_Name FROM TBL_Emp");
                    repositoryItemGridLookUpEditEmp_ID.DisplayMember = "Emp_Name";
                    repositoryItemGridLookUpEditEmp_ID.ValueMember = "EmpID";
                    //CD_QualifiedPlace
                    repositoryItemGridLookUpEditQualifiedPlaceId.DataSource = SqlDB.LoadDataTable(@"SELECT QualifiedPlaceId, QualifiedPlaceName, QualifiedPlaceName_e FROM CD_QualifiedPlace");
                    repositoryItemGridLookUpEditQualifiedPlaceId.DisplayMember = "QualifiedPlaceName";
                    repositoryItemGridLookUpEditQualifiedPlaceId.ValueMember = "QualifiedPlaceId";
                    //CDTakdeer
                    repositoryItemGridLookUpEditTakdeerId.DataSource = SqlDB.LoadDataTable(@"SELECT TakdeerId, TakdeerName, TakdeerName_e FROM CDTakdeer");
                    repositoryItemGridLookUpEditTakdeerId.DisplayMember = "TakdeerName";
                    repositoryItemGridLookUpEditTakdeerId.ValueMember = "TakdeerId";
                    break;
                default:
                    break;
            }
            
        }
        private void LoadGrid()
        {
            gridControlData.DataSource = SqlDB.LoadDataTable(@"SELECT Emp_ID, Moaahel_ID, SPECIFICATION_ID, Moaahel_Dat, TakdeerId, QualifiedPlaceId, 
            Emp_ID AS Emp_ID_SRC, Moaahel_ID AS Moaahel_ID_SRC FROM Emp_Moaahel");
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
                    ((DataTable)gridControlData.DataSource).Rows.Add(((DataTable)gridControlData.DataSource).NewRow());
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
            SqlDB.GetFormPriv("Emp" + Name.Replace("Frm", ""), ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
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
            //ActivePriv();
            LoadDefaultData(CodeFrm.TableNames.All);
            LoadGrid();
        }
        private void repositoryItemGridLookUpEditMoaahel_ID_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDQualification);
            FrmCode.ShowDialog();
            LoadDefaultData(CodeFrm.TableNames.CDQualification);
        }
        private void repositoryItemGridLookUpEditSPECIFICATION_ID_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CD_Specialization);
            FrmCode.ShowDialog();
            LoadDefaultData(CodeFrm.TableNames.CD_Specialization);
        }
        private void repositoryItemGridLookUpEditTakdeerId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDTakdeer);
            FrmCode.ShowDialog();
            LoadDefaultData(CodeFrm.TableNames.CDTakdeer);
        }
        private void repositoryItemGridLookUpEditQualifiedPlaceId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CD_QualifiedPlace);
            FrmCode.ShowDialog();
            LoadDefaultData(CodeFrm.TableNames.CD_QualifiedPlace);
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SqlConnection con = new SqlConnection(SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            DataRow row = gridViewData.GetFocusedDataRow();
            string Emp_ID;
            if (row["Emp_ID"].ToString() == string.Empty)
                Emp_ID = "NULL";
            else
                Emp_ID = row["Emp_ID"].ToString();

            string Moaahel_ID;
            if (row["Moaahel_ID"].ToString() == string.Empty)
                Moaahel_ID = "NULL";
            else
                Moaahel_ID = row["Moaahel_ID"].ToString();

            string SPECIFICATION_ID;
            if (row["SPECIFICATION_ID"].ToString() == string.Empty)
                SPECIFICATION_ID = "NULL";
            else
                SPECIFICATION_ID = row["SPECIFICATION_ID"].ToString();

            string Moaahel_Dat;
            if (row["Moaahel_Dat"].ToString() == string.Empty)
                Moaahel_Dat = "NULL";
            else
                Moaahel_Dat = String.Format("N'{0}'", row["Moaahel_Dat"]);

            string TakdeerId;
            if (row["TakdeerId"].ToString() == string.Empty)
                TakdeerId = "NULL";
            else
                TakdeerId = row["TakdeerId"].ToString();

            string QualifiedPlaceId;
            if (row["QualifiedPlaceId"].ToString() == string.Empty)
                QualifiedPlaceId = "NULL";
            else
                QualifiedPlaceId = row["QualifiedPlaceId"].ToString();

            try
            {
                if (row["Emp_ID_SRC"].ToString() == string.Empty)
                {
                    cmd.CommandText = string.Format(@"INSERT INTO Emp_Moaahel (Emp_ID, Moaahel_ID, SPECIFICATION_ID, Moaahel_Dat, TakdeerId, QualifiedPlaceId)
                    VALUES ({0}, {1}, {2}, {3}, {4}, {5})", Emp_ID, Moaahel_ID, SPECIFICATION_ID, Moaahel_Dat, TakdeerId, QualifiedPlaceId);
                }
                else
                {
                    cmd.CommandText = string.Format(@"UPDATE Emp_Moaahel SET Emp_ID = {0}, Moaahel_ID = {1}, SPECIFICATION_ID = {2}, Moaahel_Dat = {3}, TakdeerId = {4}, QualifiedPlaceId = {5}
                    WHERE (Emp_ID = {6}) AND (Moaahel_ID = {7})", Emp_ID, Moaahel_ID, SPECIFICATION_ID, Moaahel_Dat, TakdeerId, QualifiedPlaceId, row["Emp_ID_SRC"], row["Moaahel_ID_SRC"]);
                }
                con.Open();
                cmd.ExecuteNonQuery();
                Program.ShowMsg("تم الحفظ", false, this);
                Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
                LoadGrid();
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void repositoryItemButtonEditDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            SqlConnection con = new SqlConnection(SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            DataRow row = gridViewData.GetFocusedDataRow();
            if (row["Emp_ID_SRC"].ToString() == string.Empty)
            {
                LoadGrid();
                return;
            }
            try
            {
                cmd.CommandText = string.Format(@"Delete From Emp_Moaahel Where Emp_ID = {0} And Moaahel_ID = {1}",
                row["Emp_ID_SRC"], row["Moaahel_ID_SRC"]);
                con.Open();
                cmd.ExecuteNonQuery();
                Program.ShowMsg("تم الحذف", false, this);
                Program.Logger.LogThis("تم الحذف", Text, FXFW.Logger.OpType.success, null, null, this);
                LoadGrid();
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        #endregion
        
    }
}