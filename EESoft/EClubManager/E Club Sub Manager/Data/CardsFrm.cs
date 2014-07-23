using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;


namespace E_Club_Sub_Manager
{
    public partial class CardsFrm : DevExpress.XtraEditors.XtraForm
    {
        DataTable MembersTbl = new DataTable("Members");
        DataTable YearTbl = new DataTable("Year");
        public CardsFrm()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            MembersTbl = new DataTable("Members");
            YearTbl = new DataTable("Year");
            using (SqlDataAdapter DA = new SqlDataAdapter("SELECT mem_ID, (SELECT mem_name FROM TBL_members WHERE (mem_ID = TBL_Membership.mem_ID)) AS MemberName, membership_type_id, (SELECT membership_type FROM CD_membership_type WHERE (membership_type_id = TBL_Membership.membership_type_id)) As MembershipTypeName, asasecode, (Select asasename From Cd_asase Where asasecode = TBL_Membership.asasecode) As AsaseName, membership_start_date, membership_end_date, print_date, delivery_date, receipt_NO, '0' AS CheckForPrint FROM TBL_Membership WHERE (card = 1)", Program.MC.SQLConStrMembers))
            {
                try
                {
                    //DA.Fill(MembersTbl);
                    //DGVCardsMembers.DataSource = MembersTbl;
                    DA.SelectCommand.CommandText = "SELECT asasecode, asasename FROM Cd_asase ORDER BY asasecode DESC";
                    DA.Fill(YearTbl);
                    LUEYear.Properties.DataSource = YearTbl;
                    LUEYear.Properties.DisplayMember = "asasename";
                    LUEYear.Properties.ValueMember = "asasecode";
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        private void CardsFrm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void dateEditPrint_EditValueChanged(object sender, EventArgs e)
        {
            MembersTbl.Rows[DGVCardsMembers.SelectedRows[0].Index]["print_date"] = dateEditPrint.DateTime.ToString();
        }
        private void dateEditTake_EditValueChanged(object sender, EventArgs e)
        {
            MembersTbl.Rows[DGVCardsMembers.SelectedRows[0].Index]["delivery_date"] = dateEditTake.DateTime.ToString();
        }
        private void DGVCardsMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Point xYz = DGVCardsMembers.PointToClient(Control.MousePosition);

            if (e.ColumnIndex == 9)
            {

                dateEditPrint.Location = xYz;
                dateEditPrint.Visible = true;
                dateEditTake.Visible = false;
                dateEditPrint.ShowPopup();
                return;
            } if (e.ColumnIndex == 10)
            {
                dateEditTake.Location = xYz;
                dateEditTake.Visible = true;
                dateEditPrint.Visible = false;
                dateEditTake.ShowPopup();
                return;
            }
            dateEditTake.Visible = false;
            dateEditPrint.Visible = false;

        }
        private void dateEdit_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            DateEdit MyDateEdit = (DateEdit)sender;
            MyDateEdit.Visible = false;
        }
        private void CBESearchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CBESearchType.SelectedIndex)
            {
                case 0:
                    TextEditSearch.Visible= true;
                    GroupControlDates.Visible = false;
                    TextEditSearch.Focus();
                    break;
                case 1:
                    TextEditSearch.Visible= false;
                    GroupControlDates.Visible = false;
                    break;
                case 2:
                    TextEditSearch.Visible= false;
                    GroupControlDates.Visible = false;
                    break;
                case 3:
                    GroupControlDates.Visible = true;
                    DateEditSearchFrom.Focus();
                    DateEditSearchFrom.ShowPopup();
                    break;
                case 4:
                    GroupControlDates.Visible = true;
                    DateEditSearchFrom.Focus();
                    DateEditSearchFrom.ShowPopup();
                    break;
            }
        }
        private void LUEYear_EditValueChanged(object sender, EventArgs e)
        {
            if (LUEYear.ItemIndex != -1)
            {
                GroupControlSearch.Visible = true;
            }
            else
            {
                GroupControlSearch.Visible = false;
            }
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            Size = new Size(935, 473);
            GroupControlResult.Visible = true;
            GroupControlPrint.Visible = true;
            MembersTbl = new DataTable("Members");
            string SelectedYear = LUEYear.EditValue.ToString();
            using (SqlDataAdapter DA = new SqlDataAdapter("", Program.MC.SQLConStrMembers))
            {
                switch (CBESearchType.SelectedIndex)
                {
                    case -1:
                        DGVCardsMembers.DataSource = MembersTbl;
                        return;
                    case 0://اسم العضو
                        DataTable MemberNoTbl = new DataTable("MemberNames");
                        DA.SelectCommand.CommandText = String.Format("SELECT mem_ID, mem_name FROM TBL_members WHERE (mem_name LIKE N'%{0}%')", TextEditSearch.Text.Trim());
                        int FillNo = DA.Fill(MemberNoTbl);
                        string CommandString = "SELECT mem_ID, (SELECT mem_name FROM TBL_members WHERE (mem_ID = TBL_Membership.mem_ID)) AS MemberName, membership_type_id, (SELECT membership_type FROM CD_membership_type WHERE (membership_type_id = TBL_Membership.membership_type_id)) As MembershipTypeName, asasecode, (Select asasename From Cd_asase Where asasecode = TBL_Membership.asasecode) As AsaseName, membership_start_date, membership_end_date, print_date, delivery_date, receipt_NO, '0' AS CheckForPrint FROM TBL_Membership WHERE ";
                        if (FillNo == 0)
                        {
                            DGVCardsMembers.DataSource = MembersTbl;
                            return;
                        }
                        for (int i = 0; i < FillNo; i++)
                        {
                            if (FillNo > i + 1)
                                CommandString = String.Format("{0}(asasecode = {1}) AND (card = 1) AND (mem_ID = {2})", CommandString, SelectedYear, MemberNoTbl.Rows[i]["mem_ID"]) + " OR ";
                            else
                                CommandString = String.Format("{0}(asasecode = {1}) AND (card = 1) AND (mem_ID = {2})", CommandString, SelectedYear, MemberNoTbl.Rows[i]["mem_ID"]);
                        }
                        DA.SelectCommand.CommandText = CommandString;
                        break;
                    case 1://ما تم طباعته
                        DA.SelectCommand.CommandText = String.Format("SELECT mem_ID, (SELECT mem_name FROM TBL_members WHERE (mem_ID = TBL_Membership.mem_ID)) AS MemberName, membership_type_id, (SELECT membership_type FROM CD_membership_type WHERE (membership_type_id = TBL_Membership.membership_type_id)) As MembershipTypeName, asasecode, (Select asasename From Cd_asase Where asasecode = TBL_Membership.asasecode) As AsaseName, membership_start_date, membership_end_date, print_date, delivery_date, receipt_NO, '0' AS CheckForPrint FROM TBL_Membership WHERE (asasecode = {0}) AND (card = 1) AND (print_date is not NULL)", SelectedYear);
                        break;
                    case 2://لم يتم طباعته
                        DA.SelectCommand.CommandText = String.Format("SELECT mem_ID, (SELECT mem_name FROM TBL_members WHERE (mem_ID = TBL_Membership.mem_ID)) AS MemberName, membership_type_id, (SELECT membership_type FROM CD_membership_type WHERE (membership_type_id = TBL_Membership.membership_type_id)) As MembershipTypeName, asasecode, (Select asasename From Cd_asase Where asasecode = TBL_Membership.asasecode) As AsaseName, membership_start_date, membership_end_date, print_date, delivery_date, receipt_NO, '0' AS CheckForPrint FROM TBL_Membership WHERE (asasecode = {0}) AND (card = 1) AND (print_date is NULL)", SelectedYear);
                        break;
                    case 3://تاريخ الاشتراك
                        string DateFrom;
                        string DateTo;
                        if (DateEditSearchFrom.EditValue != null)
                            DateFrom = String.Format("CONVERT(DATETIME, '{0}', 103)", DateEditSearchFrom.Text);
                        else
                            DateFrom = "NULL";
                        if (dateEditSearchTo.EditValue != null)
                            DateTo = String.Format("CONVERT(DATETIME, '{0}', 103)", dateEditSearchTo.Text);
                        else
                            DateTo = "NULL";
                        DA.SelectCommand.CommandText = String.Format("Set DateFormat DMY SELECT mem_ID, (SELECT mem_name FROM TBL_members WHERE (mem_ID = TBL_Membership.mem_ID)) AS MemberName, membership_type_id, (SELECT membership_type FROM CD_membership_type WHERE (membership_type_id = TBL_Membership.membership_type_id)) As MembershipTypeName, asasecode, (Select asasename From Cd_asase Where asasecode = TBL_Membership.asasecode) As AsaseName, membership_start_date, membership_end_date, print_date, delivery_date, receipt_NO, '0' AS CheckForPrint FROM TBL_Membership WHERE (asasecode = {0}) AND (card = 1) AND (membership_start_date BETWEEN {1} AND {2})", SelectedYear, DateFrom, DateTo);
                        break;
                    case 4://تاريخ الطباعه
                        string DateFrom2;
                        string DateTo2;
                        if (DateEditSearchFrom.EditValue != null)
                            DateFrom2 = String.Format("CONVERT(DATETIME, '{0}', 103)", DateEditSearchFrom.Text);
                        else
                            DateFrom2 = "NULL";
                        if (dateEditSearchTo.EditValue != null)
                            DateTo2 = String.Format("CONVERT(DATETIME, '{0}', 103)", dateEditSearchTo.Text);
                        else
                            DateTo2 = "NULL";
                        DA.SelectCommand.CommandText = String.Format("SELECT mem_ID, (SELECT mem_name FROM TBL_members WHERE (mem_ID = TBL_Membership.mem_ID)) AS MemberName, membership_type_id, (SELECT membership_type FROM CD_membership_type WHERE (membership_type_id = TBL_Membership.membership_type_id)) As MembershipTypeName, asasecode, (Select asasename From Cd_asase Where asasecode = TBL_Membership.asasecode) As AsaseName, membership_start_date, membership_end_date, print_date, delivery_date, receipt_NO, '0' AS CheckForPrint FROM TBL_Membership WHERE (asasecode = {0}) AND (card = 1) AND (print_date BETWEEN {1} AND {2})", SelectedYear, DateFrom2, DateTo2);
                        break;
                        
                }
                DA.Fill(MembersTbl);
                DGVCardsMembers.DataSource = MembersTbl;
            }
        }
        private void BtnPrint_Click(object sender, EventArgs e)
        {
            using (SqlConnection Con = new SqlConnection(Program.MC.SQLConStrMembers))
            {
                Con.Open();
                SqlTransaction Trs = Con.BeginTransaction();
                SqlCommand Cmd = new SqlCommand("", Con, Trs);
                try
                {
                    foreach (DataRow DR in MembersTbl.Rows)
                    {
                        string print_date = "NULL";
                        string delivery_date = "NULL";
                        string mem_ID = "NULL";
                        string membership_type_id = "NULL";
                        string asasecode = LUEYear.EditValue.ToString();
                        if (DR["CheckForPrint"].ToString() == "1")
                        {
                            membership_type_id = DR["membership_type_id"].ToString();
                            mem_ID = DR["mem_ID"].ToString();
                            asasecode = DR["asasecode"].ToString();
                            print_date = String.Format("CONVERT(DATETIME, '{0}', 103)", DateTime.Today.ToShortDateString());
                            if (DR["delivery_date"].ToString() != string.Empty)
                                delivery_date = String.Format("CONVERT(DATETIME, '{0}', 103)", DR["delivery_date"]);
                            
                            Cmd.CommandText = String.Format("UPDATE TBL_Membership SET print_date = '{0}', delivery_date = {1} WHERE (mem_ID = {2}) AND (membership_type_id = {3}) AND (asasecode = {4})", print_date, delivery_date, mem_ID, membership_type_id, asasecode);
                            Cmd.ExecuteNonQuery();
                        }
                    }
                    Trs.Commit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Trs.Rollback();
                }
                Con.Close();
            }
        }
        private void DGVCardsMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if ((bool)DGVCardsMembers.Rows[e.RowIndex].Cells[0].EditedFormattedValue)
                    MembersTbl.Rows[e.RowIndex]["CheckForPrint"] = "1";
                else
                    MembersTbl.Rows[e.RowIndex]["CheckForPrint"] = "0";
            }
            
        }
    }
}