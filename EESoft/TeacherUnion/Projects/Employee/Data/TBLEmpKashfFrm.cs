using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using FXFW;

namespace Employee
{
    public partial class TBLEmpKashfFrm : DevExpress.XtraEditors.XtraForm
    {
        
        #region -   Functions   -
        public TBLEmpKashfFrm()
        {
            InitializeComponent();
        }
        private void LoadDefaultData(CodeFrm.TableNames TableName)
        {
            switch (TableName)
            {
                case CodeFrm.TableNames.CDKashf:
                    repositoryItemGridLookUpEditEmpKashfId.DataSource = SQLProvider.SelectCDKashf();
                    repositoryItemGridLookUpEditEmpKashfId.DisplayMember = "EmpKashf";
                    repositoryItemGridLookUpEditEmpKashfId.ValueMember = "EmpKashfId";
                    break;
                case CodeFrm.TableNames.All:
                    //CDKashf
                    repositoryItemGridLookUpEditEmpKashfId.DataSource = SQLProvider.SelectCDKashf();
                    repositoryItemGridLookUpEditEmpKashfId.DisplayMember = "EmpKashf";
                    repositoryItemGridLookUpEditEmpKashfId.ValueMember = "EmpKashfId";
                    //TBL_Emp
                    repositoryItemGridLookUpEditEmpID.DataSource = SqlDB.LoadDataTable(@"SELECT EmpID, 
                    Isnull(EMP_FIRST_NAME, '') + ' ' + Isnull(EMP_FATHER_NAME, '') + ' ' + Isnull(EMP_FAM_NAME, '') + ' ' + Isnull(EMP_FOURTH_NAME, '') AS Emp_Name FROM TBL_Emp");
                    repositoryItemGridLookUpEditEmpID.DisplayMember = "Emp_Name";
                    repositoryItemGridLookUpEditEmpID.ValueMember = "EmpID";
                    break;
                default:
                    break;
            }
            
        }
        private void LoadGrid()
        {
            gridControlData.DataSource = SQLProvider.SelectTBLEmpKashf();
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
        private void TBLEmpKashfFrm_Load(object sender, EventArgs e)
        {
            //ActivePriv();
            LoadDefaultData(CodeFrm.TableNames.All);
            LoadGrid();
        }
        private void repositoryItemGridLookUpEditEmpKashfId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDKashf);
            FrmCode.ShowDialog();
            LoadDefaultData(CodeFrm.TableNames.CDKashf);
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataRow row = gridViewData.GetFocusedDataRow();
            try
            {
                if (row["org_EmpID"].ToString() == string.Empty)
                    SQLProvider.InsertTBLEmpKashf(row["EmpID"], row["EmpKashfId"]);
                else
                    SQLProvider.UpdateTBLEmpKashf(row["EmpID"], row["EmpKashfId"], row["org_EmpID"], row["org_EmpKashfId"]);
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
          
            DataRow row = gridViewData.GetFocusedDataRow();
            if (row["org_EmpID"].ToString() == string.Empty)
            {
                LoadGrid();
                return;
            }
            try
            {
                SQLProvider.DeleteTBLEmpKashf(row["org_EmpID"],row["org_EmpKashfId"]);
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