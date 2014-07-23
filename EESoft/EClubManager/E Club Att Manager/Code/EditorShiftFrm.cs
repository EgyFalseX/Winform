using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace E_Club_Att_Manager
{
    public partial class EditorShiftFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        DataTable ShiftTbl = new DataTable("Shift");
        #endregion
        #region -   Functions   -
        private void LoadData()
        {
            ShiftTbl = new DataTable("Shift");
            ShiftTbl = Program.MC.LoadDataTableMalafat("SELECT shift_code, shift, shift_Start, shift_End FROM CDATT_sheft");
            LUEShift.Properties.DataSource = ShiftTbl;
            LUEShift.Properties.DisplayMember = "shift";
            LUEShift.Properties.ValueMember = "shift_code";
        }
        public EditorShiftFrm()
        {
            InitializeComponent();
        }
        #endregion
        #region -   Event Handlers   -
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل ترغب في الاستمرار؟", "تأكــــيد", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }
            using (SqlConnection Con = new SqlConnection(Program.MC.SQLConStrMalafat))
            {
                SqlCommand Cmd = new SqlCommand(String.Format("DELETE FROM CDATT_sheft WHERE (shift_code = {0})", LUEShift.EditValue), Con);
                try
                {
                    Con.Open();
                    Cmd.ExecuteNonQuery();
                    LoadData();
                    LUEShift.ItemIndex = -1;
                    MessageBox.Show("تم الحـــذف ", "حـــــذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection Con = new SqlConnection(Program.MC.SQLConStrMalafat))
            {
                string starttime = "'" + TEStartAdd.Time.ToLongTimeString() + "'";
                string endtime = "'" + TEEndAdd.Time.ToLongTimeString() + "'";
                SqlCommand Cmd = new SqlCommand(String.Format("INSERT INTO CDATT_sheft (shift_code, shift, shift_Start, shift_End) VALUES ({0},N'{1}',{2},{3})", MCls.GetNewIDMalafat("CDATT_sheft", "shift_code"), TxtNewShift.Text.Trim(), starttime, endtime), Con);
                try
                {
                    Con.Open();
                    Cmd.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("تم الاضــــافه", "اضافــــه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string starttime = "'" + TEStartEdit.Time.ToLongTimeString() + "'";
            string endtime = "'" + TEEndEdit.Time.ToLongTimeString() + "'";
            using (SqlConnection Con = new SqlConnection(Program.MC.SQLConStrMalafat))
            {
                SqlCommand Cmd = new SqlCommand(String.Format("UPDATE CDATT_sheft SET shift = N'{0}', shift_Start = {1}, shift_End = {2} WHERE (shift_code = {3})", TxtEditShift.Text.Trim(), starttime, endtime, LUEShift.EditValue), Con);
                try
                {
                    Con.Open();
                    Cmd.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("تم التعــــديل ", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void TxtNewShift_EditValueChanged(object sender, EventArgs e)
        {
            if (TxtNewShift.Text.Trim().Length > 0)
                BtnAdd.Enabled = true;
            else
                BtnAdd.Enabled = false;
        }
        private void TxtEditShift_EditValueChanged(object sender, EventArgs e)
        {
            if (TxtEditShift.Text.Trim().Length > 0 && LUEShift.ItemIndex > -1)
                BtnUpdate.Enabled = true;
            else
                BtnUpdate.Enabled = false;
        }
        private void LUEShift_EditValueChanged(object sender, EventArgs e)
        {
            if (LUEShift.ItemIndex > -1)
            {
                TxtEditShift.Text = LUEShift.Text;
                TEStartEdit.Time = (DateTime)ShiftTbl.Rows[LUEShift.ItemIndex]["shift_Start"];
                TEEndEdit.Time = (DateTime)ShiftTbl.Rows[LUEShift.ItemIndex]["shift_End"];
                BtnUpdate.Enabled = true;
                BtnDelete.Enabled = true;
            }
            else
            {
                TxtEditShift.Text = string.Empty;
                BtnUpdate.Enabled = false;
                BtnDelete.Enabled = false;
            }
        }
        private void EditorShiftFrm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        #endregion
    }
}