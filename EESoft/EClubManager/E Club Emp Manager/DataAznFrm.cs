using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace E_Club_Emp_Manager
{
    public partial class DataAznFrm : DevExpress.XtraEditors.XtraForm
    {
        DataTable EmpTbl = new DataTable("False2010-09");
        DataTable EznTypeTbl = new DataTable("False2010-09");
        DataTable EzoonTbl = new DataTable("False2010-09");
        public DataAznFrm()
        {
            InitializeComponent();
        }
        private void LoadDefaultData()
        {
            EmpTbl = new DataTable("False2010-09");
            EmpTbl = Program.MC.LoadDataTable("Select EmpID, Emp_Full_Name, PHONE_NO, MOBILE_NO, (Select job From CD_job Where job_id = Emp_Master.job_id) As job From Emp_Master", Program.MC.SQLConStrMalafat);
            LUEEmp.Properties.DataSource = EmpTbl;
            LUEEmp.Properties.ValueMember = "EmpID";
            LUEEmp.Properties.DisplayMember = "Emp_Full_Name";

            EznTypeTbl = new DataTable("False2010-09");
            EznTypeTbl = Program.MC.LoadDataTable("SELECT ezn_type_code, ezn_type_name FROM CDEMP_ezntype", Program.MC.SQLConStrMalafat);
            LUEEznType.Properties.DataSource = EznTypeTbl;
            LUEEznType.Properties.ValueMember = "ezn_type_code";
            LUEEznType.Properties.DisplayMember = "ezn_type_name";
        }
        private void LoadData()
        {
            EzoonTbl = new DataTable("False2010-09");
            EzoonTbl = Program.MC.LoadDataTable("SELECT EmpID, (Select Emp_Full_Name From Emp_Master Where EmpID = EMP_agazat.EmpID) AS Emp_Full_Name, (Select ezn_type_name From CDEMP_ezntype Where ezn_type_code =  EMP_ezn.ezn_type_code) AS ezn_type_name, ezn_date, ezn_time_start, ezn_time_end, ezn_place From  EMP_ezn", Program.MC.SQLConStrMalafat);
            gridControlAzn.DataSource = EzoonTbl;
        }
        private void ClearForm()
        {
            LUEEmp.EditValue = null;
            LUEEznType.EditValue = null;
            DEDate.EditValue = null;
            TECStart.EditValue = null;
            TECEnd.EditValue = null;
            MemoTxt.Text = string.Empty;
        }
        private void DataAznFrm_Load(object sender, EventArgs e)
        {
            LoadDefaultData();
            LoadData();
        }
        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (e.Page == xtraTabPageEditing)
                LoadData();
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {

        }
        private void repositoryItemButtonEditDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gridViewAzn.SelectedRowsCount == 0)
                return;
            if (MessageBox.Show("هل ترغب في الاستمرار؟", "تأكــــيد", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;

        }

    }
}
