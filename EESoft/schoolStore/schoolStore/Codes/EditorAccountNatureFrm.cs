using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace schoolStore
{
    public partial class EditorAccountNatureFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        DataTable NatureTypesTbl = new DataTable("NatureTypes");
        #endregion
        #region -   Functions   -
        private void LoadData()
        {
            NatureTypesTbl = new DataTable("NatureTypes");
            NatureTypesTbl = FXFW.SqlDB.LoadDataTable("SELECT AccNatueID, AccNatueName FROM CDAccountNature");
            LUENatureTypes.Properties.DataSource = NatureTypesTbl;
            LUENatureTypes.Properties.DisplayMember = "AccNatueName";
            LUENatureTypes.Properties.ValueMember = "AccNatueID";
        }
        public EditorAccountNatureFrm()
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
            using (SqlConnection Con = new SqlConnection(FXFW.SqlDB.SqlConStr))
            {
                SqlCommand Cmd = new SqlCommand(String.Format("DELETE FROM CDAccountNature WHERE (AccNatueID = {0})", LUENatureTypes.EditValue), Con);
                try
                {
                    Con.Open();
                    Cmd.ExecuteNonQuery();
                    LoadData();
                    LUENatureTypes.ItemIndex = -1;
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
            using (SqlConnection Con = new SqlConnection(FXFW.SqlDB.SqlConStr))
            {
                SqlCommand Cmd = new SqlCommand(String.Format("INSERT INTO CDAccountNature (AccNatueID,AccNatueName) VALUES (" + Program.GetNewID("CDAccountNature", "AccNatueID") + ",N'{0}')", TxtNewNatureTypes.Text.Trim()), Con);
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
            using (SqlConnection Con = new SqlConnection(FXFW.SqlDB.SqlConStr))
            {
                SqlCommand Cmd = new SqlCommand(String.Format("UPDATE CDAccountNature SET AccNatueName = N'{0}' WHERE (AccNatueID = {1})", TxtEditNatureType.Text.Trim(), LUENatureTypes.EditValue), Con);
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
        private void TxtNewNatureTypes_EditValueChanged(object sender, EventArgs e)
        {
            if (TxtNewNatureTypes.Text.Trim().Length > 0)
                BtnAdd.Enabled = true;
            else
                BtnAdd.Enabled = false;
        }
        private void TxtEditNatureType_EditValueChanged(object sender, EventArgs e)
        {
            if (TxtEditNatureType.Text.Trim().Length > 0 && LUENatureTypes.ItemIndex > -1)
                BtnUpdate.Enabled = true;
            else
                BtnUpdate.Enabled = false;
        }
        private void LUENatureTypes_EditValueChanged(object sender, EventArgs e)
        {
            if (LUENatureTypes.ItemIndex > -1)
            {
                TxtEditNatureType.Text = LUENatureTypes.Text;
                BtnUpdate.Enabled = true;
                BtnDelete.Enabled = true;
            }
            else
            {
                TxtEditNatureType.Text = string.Empty;
                BtnUpdate.Enabled = false;
                BtnDelete.Enabled = false;
            }
        }
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void EditorAccountNatureFrm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        #endregion
    }
}