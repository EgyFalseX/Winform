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
    public partial class ConstraintsDailyFrm : DevExpress.XtraEditors.XtraForm
    {
        DataTable YearsTbl = new DataTable("YearsTable");
        DataTable ConsDetials = new DataTable("FalseX");
        DataTable ConsDelDetials = new DataTable("FalseX");
        DataTable ConsTbl = new DataTable("ConsTable");
        public ConstraintsDailyFrm()
        {
            InitializeComponent();
        }
        private void ConstraintsDailyFrm_Load(object sender, EventArgs e)
        {
            ConsDetials.Columns.Add("Madeen",typeof(int));
            ConsDetials.Columns.Add("Daien", typeof(int));
            ConsDetials.Columns.Add("AccountName");
            ConsDetials.Columns.Add("Accountid");
            ConsDetials.Columns.Add("MostandNo");
            ConsDetials.Columns.Add("kieddes");
            LoadDefaultData();
            LoadAllCons();
        }
        private void LoadAllCons()
        {
            ConsTbl = new DataTable("ConsTable");
            ConsTbl = FXFW.SqlDB.LoadDataTable("SELECT TRANSID, (Select YearName From CDYeras Where YearID = TBLTRANSACTION.YearID) As YearName, KIEDNO, KIEDDAFTRYNO, KIEDDATE, KIEDDESC FROM TBLTRANSACTION");
            LUEDelCons.Properties.DataSource = ConsTbl;
            LUEDelCons.Properties.DisplayMember = "KIEDNO";
            LUEDelCons.Properties.ValueMember = "TRANSID";
        }
        private void LoadDelConDetail(string TRANSID)
        {
            ConsDelDetials = new DataTable("FalseX");
            ConsDelDetials = FXFW.SqlDB.LoadDataTable("SELECT TRANSID, TNO, AccountId, (Select AccountDes From TBL_Accountes Where AccountId = TBLTRAANSDETAILS.AccountId) As AccountDes , Madeen, Daien, MostandNo, kieddes FROM TBLTRAANSDETAILS Where (TRANSID = " + TRANSID + ")");
            GCDelCons.DataSource = ConsDelDetials;
        }
        private void LoadDefaultData()
        {
            YearsTbl = new DataTable("YearsTable");
            YearsTbl = FXFW.SqlDB.LoadDataTable("SELECT YearID, YearName FROM CDYeras");
            LUEYear.Properties.DataSource = YearsTbl;
            LUEYear.Properties.DisplayMember = "YearName";
            LUEYear.Properties.ValueMember = "YearID";
        }
        private void CalcCons()
        {
            LblMadeen.Text = Convert.ToString(ConsDetials.Compute("Sum(Madeen)", ""));
            LblDa2n.Text = Convert.ToString(ConsDetials.Compute("Sum(Daien)", ""));
            if (LblMadeen.Text.Trim().Length == 0)
            {
                LblMadeen.Text = "0";
            }
            if (LblDa2n.Text.Trim().Length == 0)
            {
                LblDa2n.Text = "0";
            }
            if (Convert.ToInt64(LblMadeen.Text) == Convert.ToInt64(LblDa2n.Text))
            {
                LlState.Text = "القيد متوازن";
                LlState.ForeColor = Color.Green;
                if (LblMadeen.Text != "0" && LblDa2n.Text != "0")
                    BtnSave.Enabled = true;
                else
                    BtnSave.Enabled = false;
            }
            else
            {
                LlState.Text = "القيد غير متوازن";
                LlState.ForeColor = Color.Red;
                BtnSave.Enabled = false;
            }
            //GCDetials.navi
        }
        private void BtnDetails_Click(object sender, EventArgs e)
        {
            if (TxtGeneralConstraintNo.Text.Trim().Length == 0 || LUEYear.ItemIndex == -1)
            {
                MessageBox.Show("يجب ادخال رقم القيد و كود السنه", "معلومات غير كامله", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            TxtBillNumber.Text = TxtGeneralBillNumber.Text.Trim();
            MemoTxtDes.Text = MemoTxtGeneralDes.Text.Trim();
            GCGeneralCons.Enabled = false;
            GroupControlAdding.Enabled = true;
            GroupControlDetials.Enabled = true;
        }
        private void BtnLoadAccNames_Click(object sender, EventArgs e)
        {
            AccTypesDlgFrm AccWin = new AccTypesDlgFrm();
            AccWin.ShowDialog(this);
            if(AccWin.AccountName == string.Empty)
            {
                TxtAccName.Text = string.Empty;
                TxtAccName.Tag = string.Empty;
            }
            else
            {
                TxtAccName.Text = AccWin.AccountName;
                TxtAccName.Tag = AccWin.AccountID;
            }
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            DataRow row = ConsDetials.NewRow();
            if (CBEConsTypes.SelectedIndex == 0)
            {
                row["Madeen"] = FXFW.SqlDB.ConvertStringToInt(TxtConsValue.Text.Trim());
                row["Daien"] = "0";
            }
            else
            {
                row["Madeen"] = "0";
                row["Daien"] = FXFW.SqlDB.ConvertStringToInt(TxtConsValue.Text.Trim());
            }
            row["AccountName"] = TxtAccName.Text.ToString();
            row["Accountid"] = TxtAccName.Tag.ToString();
            row["MostandNo"] = TxtBillNumber.Text.Trim();
            row["kieddes"] = MemoTxtDes.Text.Trim();
            ConsDetials.Rows.Add(row);
            GCDetials.DataSource = ConsDetials;
            CalcCons();
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlTransaction Trn = null;
            SqlCommand Cmd = new SqlCommand("", Con);
            try 
            {
                Con.Open();
                Trn = Con.BeginTransaction();
                Cmd.Transaction = Trn;
                string TRANSID = "NULL", YearID = "NULL", KIEDNO = "NULL", KIEDDAFTRYNO = "NULL", KIEDDATE = "NULL", KIEDDESC = "NULL", trhel = "NULL";
                if (ConsDetials.Rows.Count > 0)
                {
                    TRANSID = Program.GetNewID("TBLTRANSACTION","TRANSID");
                    if (LUEYear.EditValue != DBNull.Value)//كود السنه
                        YearID = LUEYear.EditValue.ToString();
                    if (TxtGeneralConstraintNo.Text.Trim().Length > 0)//رقم القيد
                        KIEDNO = TxtGeneralConstraintNo.Text.Trim();
                    if (TxtGeneralBillNumber.Text.Trim().Length > 0)//الرقم الدفتري
                        KIEDDAFTRYNO = TxtGeneralBillNumber.Text.Trim();
                    if (DEDate.EditValue != null)//التاريخ
                        KIEDDATE = "'" + FXFW.SqlDB.ConvertToDateDMY(DEDate.EditValue.ToString()) + "'";
                    if (MemoTxtGeneralDes.Text.Trim().Length > 0)//وصف القيد
                    KIEDDESC = "N'" + MemoTxtGeneralDes.Text.Trim() + "'";
                    if (CBRelay.Checked)//يتم ترحيله
                        trhel = "1";
                    else
                        trhel = "0";
                    Cmd.CommandText = "Set Dateformat dmy INSERT INTO TBLTRANSACTION  (TRANSID, YearID, KIEDNO, KIEDDAFTRYNO, KIEDDATE, KIEDDESC, trhel) VALUES (" + TRANSID + ", " + YearID + ", " + KIEDNO + ", " + KIEDDAFTRYNO + ", " + KIEDDATE + ", " + KIEDDESC + ", " + trhel + ")";
                    Cmd.ExecuteNonQuery();
                }
                else
                    MessageBox.Show("يجب ادخال قيود قبل الحفظ","بيانات غير كامله",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                int TNO = 0;
                foreach (DataRow row in ConsDetials.Rows)
                {
                    string AccountId = "NULL", Madeen = "NULL", Daien = "NULL", MostandNo = "NULL", kieddes = "NULL";
                    TNO ++;
                    if (row["Madeen"].ToString() != string.Empty)
                        Madeen = row["Madeen"].ToString();
                    if (row["Daien"].ToString() != string.Empty)
                        Daien = row["Daien"].ToString();
                    if ((string)row["Accountid"] != string.Empty)
                        AccountId = row["Accountid"].ToString();
                    if ((string)row["MostandNo"] != string.Empty)
                        MostandNo = "N'" + row["MostandNo"].ToString() + "'";
                    if ((string)row["kieddes"] != string.Empty)
                        kieddes = "N'" + row["kieddes"].ToString() + "'";
                    Cmd.CommandText = "Set Dateformat dmy INSERT INTO TBLTRAANSDETAILS (TRANSID, TNO, AccountId, Madeen, Daien, MostandNo, kieddes) VALUES (" + TRANSID + ", " + TNO + ", " + AccountId + ", " + Madeen + ", " + Daien + ", " + MostandNo + ", " + kieddes + ")";
                    Cmd.ExecuteNonQuery();
                }
                Trn.Commit();
                MessageBox.Show("تم حفـــظ القيــد", "تمت العمليه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ConsDetials.Rows.Clear();
                GCDetials.DataSource = ConsDetials;
                GroupControlDetials.Enabled = false;
                GroupControlAdding.Enabled = false;
                GCGeneralCons.Enabled = true;
                LUEYear.Focus();
            }
            catch (SqlException ex)
            {
                Trn.Rollback();
                MessageBox.Show(ex.Message,ex.ErrorCode.ToString());
            }
            Con.Close();
        }
        private void gridView1_RowCountChanged(object sender, EventArgs e)
        {
            CalcCons();
        }
        private void LUEDelCons_EditValueChanged(object sender, EventArgs e)
        {
            if (LUEDelCons.ItemIndex != -1)
            {
                BtnDelCon.Enabled = true;
                //Load Contains
                LoadDelConDetail(LUEDelCons.EditValue.ToString());
            }
            else
            {
                BtnDelCon.Enabled = false;
                ConsDelDetials = new DataTable("FalseX");
                GCDelCons.DataSource = ConsDelDetials;

            }
        }
        private void BtnDelCon_Click(object sender, EventArgs e)
        {
            SqlTransaction Trn = null;
            SqlConnection Con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            try
            {
                Con.Open();
                Trn = Con.BeginTransaction();
                SqlCommand Cmd = new SqlCommand("DELETE FROM TBLTRAANSDETAILS WHERE (TRANSID = " + LUEDelCons.EditValue.ToString() + ")", Con, Trn);
                Cmd.ExecuteNonQuery();
                Cmd.CommandText = "DELETE FROM TBLTRANSACTION WHERE (TRANSID = " + LUEDelCons.EditValue.ToString() + ")";
                Cmd.ExecuteNonQuery();
                Trn.Commit();
                LoadAllCons();
                LUEDelCons_EditValueChanged(LUEDelCons, new EventArgs());
                MessageBox.Show("تم حذف القيــــد","تمت العمليه",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                Trn.Rollback();
                MessageBox.Show(ex.Message,ex.ErrorCode.ToString());
            }
            Con.Close();
        }
    }
}