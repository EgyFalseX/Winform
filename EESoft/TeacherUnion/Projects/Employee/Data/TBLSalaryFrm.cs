using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace Employee
{
    public partial class TBLSalaryFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        
        #endregion
        #region -   Functions   -
        public TBLSalaryFrm()
        {
            InitializeComponent();
        }
        private void LoadDefaultData()
        {
            //CDMonth
            LUEMonthes.Properties.DataSource = SQLProvider.SelectCDMonth();
            LUEMonthes.Properties.DisplayMember = "MonthName";
            LUEMonthes.Properties.ValueMember = "MonthId";
            repositoryItemGridLookUpEditMonthId.DataSource = SQLProvider.SelectCDMonth();
            repositoryItemGridLookUpEditMonthId.DisplayMember = "MonthName";
            repositoryItemGridLookUpEditMonthId.ValueMember = "MonthId";
            //TBL_Emp
            repositoryItemGridLookUpEditEmpID.DataSource = SQLProvider.SelectTBL_Emp();
            repositoryItemGridLookUpEditEmpID.DisplayMember = "Emp_Name";
            repositoryItemGridLookUpEditEmpID.ValueMember = "EmpID";
            //CD_AsaseSalary
            repositoryItemGridLookUpEditAsaseSalaryId.DataSource = SQLProvider.SelectCD_AsaseSalary();
            repositoryItemGridLookUpEditAsaseSalaryId.DisplayMember = "AsaseSalary";
            repositoryItemGridLookUpEditAsaseSalaryId.ValueMember = "AsaseSalaryId";

        }
        private void LoadData()
        {
            gridControlData.DataSource = SQLProvider.SelectTBLSalary();
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
            FXFW.SqlDB.GetFormPriv("Emp" + Name.Replace("Frm", ""), ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
            gridControlData.Visible = Selecting;
            if (Inserting || Updateing)
                repositoryItemButtonEditSave.Buttons[0].Enabled = true;
            else
                repositoryItemButtonEditSave.Buttons[0].Enabled = false;
            repositoryItemButtonEditDel.Buttons[0].Enabled = Deleting;
        }
        #endregion
        
        #region -   Event Handlers   -
        private void TBLSalaryFrm_Load(object sender, EventArgs e)
        {
            //ActivePriv();
            LoadDefaultData();
            LoadData();
        }
        private void LUEMonthes_EditValueChanged(object sender, EventArgs e)
        {

        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            if (FXFW.SqlDB.IsNullOrEmpty(LUEMonthes.EditValue) || FXFW.SqlDB.IsNullOrEmpty(SQLProvider.AsaseSalaryId))
            {
                Program.ShowMsg("من فضلك اختر شهر و سنه ماليه", true, this);
                return;
            }
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;

            DataTable dtEmp = SQLProvider.SelectTBL_Emp();
            foreach (DataRow row in dtEmp.Rows)
            {
                try
                {
                    SQLProvider.InsertTBLSalary(row["EmpID"], SQLProvider.AsaseSalaryId, LUEMonthes.EditValue,
                    0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
                }
                catch (SqlException ex)
                {
                    Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                    Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
                }
            }
            LoadData();
            Program.ShowMsg("تم الحفظ", false, this);
            Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (FXFW.SqlDB.IsNullOrEmpty(SQLProvider.AsaseSalaryId))
            {
                Program.ShowMsg("من فضلك اختر صنه ماليه", true, this);
                return;
            }
            DataRow row = gridViewData.GetFocusedDataRow();
            try
            {
                if (row["org_EmpID"].ToString() == string.Empty)
                {
                    SQLProvider.InsertTBLSalary(row["EmpID"], row["AsaseSalaryId"], row["MonthId"], row["orderreport"], row["asaseold"], row["alawaold"],
                        row["basicsalary"], row["esthkak26"], row["esthkak24"], row["alawa1"], row["alawa2"], row["alawa3"], row["alawa4"], row["alawa5"], row["agtmaia"],
                        row["edafia"], row["menha"], row["badalat"], row["sumethkak"], row["estktaa26"], row["estktaa24"], row["estktaa14"], row["estktaa11"],
                        row["solaf"], row["geza"], row["sumestktaa"], row["safy"]);
                }
                else
                {
                    SQLProvider.UpdateTBLSalary(row["EmpID"], row["AsaseSalaryId"], row["MonthId"], row["orderreport"], row["asaseold"], row["alawaold"],
                        row["basicsalary"], row["esthkak26"], row["esthkak24"], row["alawa1"], row["alawa2"], row["alawa3"], row["alawa4"], row["alawa5"], row["agtmaia"],
                        row["edafia"], row["menha"], row["badalat"], row["sumethkak"], row["estktaa26"], row["estktaa24"], row["estktaa14"], row["estktaa11"],
                        row["solaf"], row["geza"], row["sumestktaa"], row["safy"], row["org_EmpID"], row["org_AsaseSalaryId"], row["org_MonthId"]);
                }
                LoadData();
                Program.ShowMsg("تم الحفظ", false, this);
                Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void repositoryItemButtonEditDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;


            DataRow row = gridViewData.GetFocusedDataRow();
            try
            {
                if (row["org_EmpID"].ToString() != string.Empty)
                    SQLProvider.DeleteTBLSalary(row["org_EmpID"], row["org_AsaseSalaryId"], row["org_MonthId"]);
               
                LoadData();
                Program.ShowMsg("تم الحفظ", false, this);
                Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }

        #endregion
    }
}