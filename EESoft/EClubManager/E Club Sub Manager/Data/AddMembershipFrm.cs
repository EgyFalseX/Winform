using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.Diagnostics;

namespace E_Club_Sub_Manager
{
    public partial class AddMembershipFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        DataTable Asase_Tbl = new DataTable("Asase");
        DataTable Members_Tbl = new DataTable("Members");
        DataTable TBL_Membership_Tbl = new DataTable("TBL_Membership");
        #endregion
        #region -   Functions   -
        public AddMembershipFrm()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            Asase_Tbl = new DataTable("Asase");
            Members_Tbl = new DataTable("Members");
            SqlDataAdapter DA = new SqlDataAdapter("SELECT membership_type_id, membership_type FROM CD_membership_type", Program.MC.SQLConStrMembers);
            try
            {

                DA.SelectCommand.CommandText = "SELECT asasecode, asasename FROM Cd_asase ORDER BY asasecode DESC";
                DA.Fill(Asase_Tbl);
                LUEAsase.Properties.DataSource = Asase_Tbl;
                LUEAsase.Properties.DisplayMember = "asasename";
                LUEAsase.Properties.ValueMember = "asasecode";
                LUEAsase.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
                LUEAsase.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;

                DA.SelectCommand.CommandText = "SELECT mem_ID, mem_name, Subscription_type_id FROM TBL_members WHERE (Subscription_type_id = 1) OR (Subscription_type_id = 2)";
                DA.Fill(Members_Tbl);
                LUEMembers.Properties.DataSource = Members_Tbl;
                LUEMembers.Properties.DisplayMember = "mem_name";
                LUEMembers.Properties.ValueMember = "mem_ID";
                LUEMembers.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
                LUEMembers.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
                //LUEMembers
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadAllMembership()
        {
            TBL_Membership_Tbl = Program.MC.LoadDataTable(@"SELECT mem_ID, (Select mem_name From TBL_members Where mem_ID = TBL_Membership.mem_ID) AS mem_name,
            membership_type_id, asasecode, CONVERT(nvarchar, membership_start_date, 103) AS membership_start_date, CONVERT(nvarchar, membership_end_date, 103) AS membership_end_date, CONVERT(nvarchar, print_date, 103) AS print_date, CONVERT(nvarchar, delivery_date, 103) AS delivery_date,
            card, receipt_NO, PaymentValue, CONVERT(nvarchar, PaymentDate, 103) AS PaymentDate  FROM  TBL_Membership", Program.MC.SQLConStrMembers);
            gridControlEdit.DataSource = TBL_Membership_Tbl;
        }
        private void ClearForm()
        {
            LUEAsase.EditValue = null;
            LUEMembers.EditValue = null;
            textEditReceipt.Text = string.Empty;
            dateEditStart.EditValue = null;
            dateEditEnd.EditValue = null;
            checkEditCard.Checked = false;
            TxtPayValue.Text = string.Empty;
            DEPayDate.EditValue = null;
        }
        #endregion
        #region -   Event Handlers   -
        
        private void AddMembershipFrm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (e.Page == xtraTabPageEdit)
                LoadAllMembership();
        }
        private void dateEditStart_EditValueChanged(object sender, EventArgs e)
        {
            dateEditEnd.DateTime = dateEditStart.DateTime.AddDays(364);
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (LUEMembers.ItemIndex == -1 || LUEAsase.ItemIndex == -1 || dateEditStart.EditValue == null)
            {
                MessageBox.Show("من فضلك قم بأدخال كلا من : اسم العضو - العام - نوع العضويه - تاريخ بداية الاشتراك", "بيانات خاليه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string MemberID = "NULL";
            string year = "NULL";
            string MembershipStartDate = "NULL";
            string MembershipEndDate = "NULL";
            string Card = "0";
            string ReceiptNo = "NULL";
            string PaymentValue = "NULL";
            string PaymentDate = "NULL";

            if (LUEMembers.ItemIndex != -1)
                MemberID = Members_Tbl.Rows[LUEMembers.ItemIndex][0].ToString();
            if (LUEAsase.ItemIndex != -1)
                year = Asase_Tbl.Rows[LUEAsase.ItemIndex][0].ToString();
            if (dateEditStart.EditValue != null)
                MembershipStartDate = String.Format("CONVERT(DATETIME, '{0}', 103)", dateEditStart.Text);
            if (dateEditEnd.EditValue != null)
                MembershipEndDate = String.Format("CONVERT(DATETIME, '{0}', 103)", dateEditEnd.Text);
            if (checkEditCard.Checked)
                Card = "1";
            if (textEditReceipt.Text.Trim().Length > 0)
                ReceiptNo = String.Format("N'{0}'", textEditReceipt.Text);
            if (TxtPayValue.EditValue != null)
                PaymentValue = TxtPayValue.EditValue.ToString();
            if (DEPayDate.EditValue != null)
                PaymentDate = String.Format("CONVERT(DATETIME, '{0}', 103)", DEPayDate.Text);
            string CommandString = String.Format(@"INSERT INTO TBL_Membership (mem_ID, membership_type_id, asasecode, membership_start_date, membership_end_date, card, receipt_NO, PaymentValue, PaymentDate, DateIn)
            VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, getdate())", MemberID, "1", year, MembershipStartDate, MembershipEndDate, Card, ReceiptNo, PaymentValue, PaymentDate);
            using (SqlConnection Con = new SqlConnection(Program.MC.SQLConStrMembers))
            {
                SqlCommand CMD = new SqlCommand(CommandString, Con);
                try
                {
                    Con.Open();
                    CMD.ExecuteNonQuery();
                    MessageBox.Show("تم تجديد العضويه", "تمت العمليه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Con.Close();
            }
        }
        private void repositoryItemButtonEditEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gridViewEdit.SelectedRowsCount == 0)
                return;
            if (MessageBox.Show("هل انت متأكد؟", "تأكــــيد", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            DataRow row = TBL_Membership_Tbl.Rows[gridViewEdit.GetFocusedDataSourceRowIndex()];
            string membership_start_date;
            string membership_end_date;
            string receipt_NO;
            string PaymentValue;
            string PaymentDate;
            if (row["membership_start_date"].ToString() != string.Empty)
                membership_start_date = String.Format("'{0}'", Convert.ToDateTime(row["membership_start_date"]).ToShortDateString());
            else
                membership_start_date = "NULL";
            if (row["membership_end_date"].ToString() != string.Empty)
                membership_end_date = String.Format("'{0}'", Convert.ToDateTime(row["membership_end_date"]).ToShortDateString());
            else
                membership_end_date = "NULL";
            if (row["receipt_NO"].ToString() != string.Empty)
                receipt_NO = String.Format("N'{0}'", row["receipt_NO"]);
            else
                receipt_NO = "NULL";
            if (row["PaymentValue"].ToString() != string.Empty)
                PaymentValue = row["PaymentValue"].ToString();
            else
                PaymentValue = "NULL";
            if (row["PaymentDate"].ToString() != string.Empty)
                PaymentDate = String.Format("'{0}'", Convert.ToDateTime(row["PaymentDate"]).ToShortDateString());
            else
                PaymentDate = "NULL";
            SqlConnection con = new SqlConnection(Program.MC.SQLConStrMembers);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                con.Open();
                cmd.CommandText = string.Format(@"Update TBL_Membership Set membership_start_date = {0}, membership_end_date = {1}, receipt_NO = {2}, PaymentValue = {3},
                PaymentDate = {4}, card = '{5}' Where mem_ID = {6} And asasecode = {7}", membership_start_date, membership_end_date, receipt_NO, PaymentValue, PaymentDate, row["card"], row["mem_ID"], row["asasecode"]);
                cmd.ExecuteNonQuery();
                LoadAllMembership();
                MessageBox.Show("تم التعديل", "تمت العمليه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.ErrorCode.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        private void repositoryItemButtonEditDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gridViewEdit.SelectedRowsCount == 0)
                return;
            if (MessageBox.Show("هل انت متأكد؟", "تأكــــيد", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            string mem_ID;
            string asasecode;
            if (TBL_Membership_Tbl.Rows[gridViewEdit.GetFocusedDataSourceRowIndex()]["mem_ID"] != null)
                mem_ID = TBL_Membership_Tbl.Rows[gridViewEdit.GetFocusedDataSourceRowIndex()]["mem_ID"].ToString();
            else
                mem_ID = "NULL";
            if (TBL_Membership_Tbl.Rows[gridViewEdit.GetFocusedDataSourceRowIndex()]["asasecode"] != null)
                asasecode = TBL_Membership_Tbl.Rows[gridViewEdit.GetFocusedDataSourceRowIndex()]["asasecode"].ToString();
            else
                asasecode = "NULL";
            SqlConnection con = new SqlConnection(Program.MC.SQLConStrMembers);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                con.Open();
                cmd.CommandText = string.Format("DELETE FROM TBL_Membership WHERE (mem_ID = {0}) AND (asasecode = {1})", mem_ID, asasecode);
                cmd.ExecuteNonQuery();
                LoadAllMembership();
                MessageBox.Show("تم الحذف", "تمت العمليه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.ErrorCode.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
#endregion

    }
}