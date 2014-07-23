using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace StAccount
{
    public partial class TBLMothsleatFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        DataTable tblStudent = new DataTable();
        DataTable tblCD_KastSaf = new DataTable();
        DataTable tbl_Basic = new DataTable();
        DataTable tbl_Additional = new DataTable();
        #endregion
        #region -   Functions   -
        public TBLMothsleatFrm()
        {
            InitializeComponent();
        }
        private void LoadDefaultData()
        {
            tblStudent = FXFW.SqlDB.LoadDataTable(@"Select stu_code, asase_code, alsofof_code, fasl_code,
            (SELECT FIRST_NAME + ' ' + FATHER_NAME + ' ' + GF_NAME + ' ' + FAMILY_NAME AS stu_name From stu.TBLstudent Where stu_code = stu.student_t.stu_code) AS stu_name,
            (Select alsofof_name From CDAlsofof Where alsofof_code = stu.student_t.alsofof_code) AS alsofof_name,
            (Select fasl_name From CDEFasl Where fasl_code = stu.student_t.fasl_code) AS fasl_name,
            (Select DiscountsId From TBL_DiscountSt Where asase_code = stu.student_t.asase_code And stu_code = stu.student_t.stu_code) AS DiscountsId,
            (Select DiscountMony From TBL_DiscountSt Where asase_code = stu.student_t.asase_code And stu_code = stu.student_t.stu_code) AS DiscountMony,
            (Select Discounts From CD_Discounts Where DiscountsId = (Select DiscountsId From TBL_DiscountSt Where asase_code = stu.student_t.asase_code And stu_code = stu.student_t.stu_code)) AS Discounts
            From stu.student_t
            Where asase_code = " + FXFW.SqlDB.asase_code);
            slueStudent.Properties.DataSource = tblStudent;
        }
        private void LoadCD_KastSaf()
        {
            if (FXFW.SqlDB.IsNullOrEmpty(slueStudent.EditValue))
                tblCD_KastSaf = new DataTable();
            else
            {
                tblCD_KastSaf = FXFW.SqlDB.LoadDataTable(@"Select KastNoId, KastSafMony,
                (Select KastName From CD_KastNo Where KastNoId = CD_KastSaf.KastNoId) AS KastName
                From CD_KastSaf Where alsofof_code = " + slueStudent.EditValue);
            }
            slueKastNoId.EditValue = null;
            slueKastNoId.Properties.DataSource = tblCD_KastSaf;
        }
        private void ShowInfo()
        {
            //student selected
            if (FXFW.SqlDB.IsNullOrEmpty(slueStudent.EditValue))
            {
                lblStuInfoSaf.Text = "-";
                lblStuInfoDisType.Text = "-";
                lblStuInfoFasl.Text = "-";
                lblStuInfoDisMount.Text = "-";
                slueKastNoId.EditValue = null;

                lblBasicTotal.Text = "-";
                lblBasicDone.Text = "-";
                lblBasicDis.Text = "-";
                lblBasicBack.Text = "-";
                lblBasicRest.Text = "-";

                lblAddTotal.Text = "-";
                lblAddDone.Text = "-";
                lblAddDis.Text = "-";
                lblAddBack.Text = "-";
                lblAddRest.Text = "-";
            }
            else
            {
                DataRow row = slueStudent.Properties.View.GetFocusedDataRow();
                lblStuInfoSaf.Text = row["alsofof_name"].ToString();
                lblStuInfoDisType.Text = row["Discounts"].ToString();
                lblStuInfoFasl.Text = row["fasl_name"].ToString();
                lblStuInfoDisMount.Text = row["DiscountMony"].ToString();

                lblKastInfoMount.Text = row["alsofof_name"].ToString();
                //get Basic/Add summary
                DataTable tblCD_PayMonyBasic = FXFW.SqlDB.LoadDataTable(string.Format(@"Select 
                (Select ISNULL(Sum(PayMony), 0) From CD_PayMony Where asase_code = {0} And alsofof_code = {1} And Exists 
                (Select PayTypeId From CD_PayType Where Additional = 'false' And PayTypeId = (Select PayTypeId From CD_PayTypeDetiel Where PayTypeDetielId = CD_PayMony.PayTypeDetielId And PayTypeId = CD_PayType.PayTypeId))) AS [BasicTotal],

                (SELECT ISNULL(SUM(MMony), 0) AS MMony FROM TBLMothsleat WHERE (asase_code = {0}) AND (stu_code = {2}) And Exists 
                (Select PayTypeId From CD_PayType Where Additional = 'false' And PayTypeId = (Select PayTypeId From CD_PayTypeDetiel Where PayTypeDetielId = TBLMothsleat.PayTypeDetielId And PayTypeId = CD_PayType.PayTypeId))) AS [BasicDone],
                
                (SELECT ISNULL(SUM(MKasm), 0) AS MKasm FROM TBLMothsleat WHERE (asase_code = {0}) AND (stu_code = {2}) And Exists 
                (Select PayTypeId From CD_PayType Where Additional = 'false' And PayTypeId = (Select PayTypeId From CD_PayTypeDetiel Where PayTypeDetielId = TBLMothsleat.PayTypeDetielId And PayTypeId = CD_PayType.PayTypeId))) AS [BasicDis],
                
                (Select ISNULL(Sum(estrdadmony), 0) From TBLMothsleat Where asase_code = {0} AND stu_code = {2} AND  Exists 
                (Select PayTypeId From CD_PayType Where Additional = 'false' And PayTypeId = (Select PayTypeId From CD_PayTypeDetiel Where PayTypeDetielId = TBLMothsleat.PayTypeDetielId And PayTypeId = CD_PayType.PayTypeId))) AS [BasicBack],

                (Select ISNULL(Sum(edafymony), 0) From TBLSelectSTEdafy Where asase_code = {0} And stu_code = {2}) AS [AddTotal],

                (SELECT ISNULL(SUM(MMony), 0) AS MMony FROM TBLMothsleat WHERE (asase_code = {0}) AND (stu_code = {2}) And Exists 
                (Select PayTypeId From CD_PayType Where Additional = 'true' And PayTypeId = (Select PayTypeId From CD_PayTypeDetiel Where PayTypeDetielId = TBLMothsleat.PayTypeDetielId And PayTypeId = CD_PayType.PayTypeId))) AS [AddDone],
                
                (SELECT ISNULL(SUM(MKasm), 0) AS MKasm FROM TBLMothsleat WHERE (asase_code = {0}) AND (stu_code = {2}) And Exists 
                (Select PayTypeId From CD_PayType Where Additional = 'true' And PayTypeId = (Select PayTypeId From CD_PayTypeDetiel Where PayTypeDetielId = TBLMothsleat.PayTypeDetielId And PayTypeId = CD_PayType.PayTypeId))) AS [AddDis],
                
                (Select ISNULL(Sum(estrdadmony), 0) From TBLMothsleat Where asase_code = {0} AND stu_code = {2} AND  Exists 
                (Select PayTypeId From CD_PayType Where Additional = 'true' And PayTypeId = (Select PayTypeId From CD_PayTypeDetiel Where PayTypeDetielId = TBLMothsleat.PayTypeDetielId And PayTypeId = CD_PayType.PayTypeId))) AS [AddBack]
                ", FXFW.SqlDB.asase_code, row["alsofof_code"], slueStudent.EditValue));

                lblBasicTotal.Text = tblCD_PayMonyBasic.Rows[0]["BasicTotal"].ToString();
                lblBasicDone.Text = tblCD_PayMonyBasic.Rows[0]["BasicDone"].ToString();
                lblBasicDis.Text = tblCD_PayMonyBasic.Rows[0]["BasicDis"].ToString();
                lblBasicBack.Text = tblCD_PayMonyBasic.Rows[0]["BasicBack"].ToString();
                lblBasicRest.Text = (Convert.ToDecimal(tblCD_PayMonyBasic.Rows[0]["BasicTotal"]) + Convert.ToDecimal(tblCD_PayMonyBasic.Rows[0]["BasicBack"]) - Convert.ToDecimal(tblCD_PayMonyBasic.Rows[0]["BasicDone"]) - Convert.ToDecimal(tblCD_PayMonyBasic.Rows[0]["BasicDis"])).ToString();

                lblAddTotal.Text = tblCD_PayMonyBasic.Rows[0]["AddTotal"].ToString();
                lblAddDone.Text = tblCD_PayMonyBasic.Rows[0]["AddDone"].ToString();
                lblAddDis.Text = tblCD_PayMonyBasic.Rows[0]["AddDis"].ToString();
                lblAddBack.Text = tblCD_PayMonyBasic.Rows[0]["AddBack"].ToString();
                lblAddRest.Text = (Convert.ToDecimal(tblCD_PayMonyBasic.Rows[0]["AddTotal"]) + Convert.ToDecimal(tblCD_PayMonyBasic.Rows[0]["AddBack"]) - Convert.ToDecimal(tblCD_PayMonyBasic.Rows[0]["AddDone"]) - Convert.ToDecimal(tblCD_PayMonyBasic.Rows[0]["AddDis"])).ToString();
            }
            //Premium selected
            if (FXFW.SqlDB.IsNullOrEmpty(slueKastNoId.EditValue))
                lblKastInfoMount.Text = "-";
            else
            {
                //Get Premium Amount
                DataRow row = slueKastNoId.Properties.View.GetFocusedDataRow();
                lblKastInfoMount.Text = row["KastSafMony"].ToString();
                
            }
        }
        private void LoadBasic()
        {
            DataRow rowStudnt = slueStudent.Properties.View.GetFocusedDataRow();
            tbl_Basic = FXFW.SqlDB.LoadDataTable(string.Format(@"SELECT KastNoId, PayTypeDetielId, Awlawea,
            (SELECT PayTypeDetiel FROM CD_PayTypeDetiel WHERE PayTypeDetielId = CD_KastBnood.PayTypeDetielId) AS PayTypeDetiel,
            (SELECT PayMony FROM CD_PayMony WHERE alsofof_code = {0} AND asase_code = {1} AND PayTypeDetielId = CD_KastBnood.PayTypeDetielId) AS PayMony,
            (SELECT ISNULL(MAX(EsalNo) + 1, 1) FROM TBLMothsleat WHERE asase_code = {1} AND PayTypeDetielId = CD_KastBnood.PayTypeDetielId) AS EsalNo,
            (SELECT ISNULL(SUM(DiscountMony), 0) FROM TBL_DiscountSt WHERE asase_code = {1} AND stu_code = {3} AND EXISTS 
            (SELECT DiscountsId FROM CD_Discounts WHERE DiscountsId = TBL_DiscountSt.DiscountsId AND PayTypeDetielId = CD_KastBnood.PayTypeDetielId)) AS DiscountMony,
            (SELECT DiscountsId FROM TBL_DiscountSt WHERE asase_code = {1} AND stu_code = {3} AND EXISTS 
            (SELECT DiscountsId FROM CD_Discounts WHERE DiscountsId = TBL_DiscountSt.DiscountsId AND PayTypeDetielId = CD_KastBnood.PayTypeDetielId)) AS DiscountsId,
            (SELECT ISNULL(SUM(MMony), 0) FROM TBLMothsleat WHERE asase_code = {1} And stu_code = {3} AND PayTypeDetielId = CD_KastBnood.PayTypeDetielId) AS Paid,
            (SELECT ISNULL(SUM(MKasm), 0) FROM TBLMothsleat WHERE asase_code = {1} And stu_code = {3} AND PayTypeDetielId = CD_KastBnood.PayTypeDetielId) AS PaidDiscount,
            '0' Payment, '0' AS PaymentDiscount
            FROM CD_KastBnood
            WHERE KastNoId = {2} AND EXISTS(SELECT PayTypeId FROM CD_PayType WHERE Additional = 'false' AND 
            PayTypeId = (SELECT PayTypeId FROM CD_PayTypeDetiel WHERE PayTypeId = CD_PayType.PayTypeId AND PayTypeDetielId = CD_KastBnood.PayTypeDetielId)) AND
            (SELECT PayMony FROM CD_PayMony WHERE alsofof_code = {0} AND asase_code = {1} AND PayTypeDetielId = CD_KastBnood.PayTypeDetielId) > 
            ((SELECT ISNULL(SUM(MMony), 0) FROM TBLMothsleat WHERE asase_code = {1} And stu_code = {3} AND PayTypeDetielId = CD_KastBnood.PayTypeDetielId) + 
            (SELECT ISNULL(SUM(MKasm), 0) FROM TBLMothsleat WHERE asase_code = {1} And stu_code = {3} AND PayTypeDetielId = CD_KastBnood.PayTypeDetielId))
            ORDER BY Awlawea", rowStudnt["alsofof_code"], rowStudnt["asase_code"], slueKastNoId.EditValue, rowStudnt["stu_code"]));
            gridControlBasic.DataSource = tbl_Basic;
        }
        private void LoadAdditional()
        {
            DataRow rowStudnt = slueStudent.Properties.View.GetFocusedDataRow();
            tbl_Additional = FXFW.SqlDB.LoadDataTable(string.Format(@"SELECT asase_code, stu_code, PayTypeDetielId, edafymony AS PayMony,
            (SELECT PayTypeDetiel FROM CD_PayTypeDetiel WHERE PayTypeDetielId = TBLSelectSTEdafy.PayTypeDetielId) AS PayTypeDetiel,
            (SELECT ISNULL(MAX(EsalNo) + 1, 1) FROM TBLMothsleat WHERE asase_code = {0} AND PayTypeDetielId = TBLSelectSTEdafy.PayTypeDetielId) AS EsalNo,
            (SELECT ISNULL(SUM(DiscountMony), 0) FROM TBL_DiscountSt WHERE asase_code = {0} AND stu_code = {1} AND EXISTS 
            (SELECT DiscountsId FROM CD_Discounts WHERE DiscountsId = TBL_DiscountSt.DiscountsId AND PayTypeDetielId = TBLSelectSTEdafy.PayTypeDetielId)) AS DiscountMony,
            (SELECT DiscountsId FROM TBL_DiscountSt WHERE asase_code = {0} AND stu_code = {1} AND EXISTS 
            (SELECT DiscountsId FROM CD_Discounts WHERE DiscountsId = TBL_DiscountSt.DiscountsId AND PayTypeDetielId = TBLSelectSTEdafy.PayTypeDetielId)) AS DiscountsId,
            (SELECT ISNULL(SUM(MMony), 0) FROM TBLMothsleat WHERE asase_code = {0} And stu_code = {1} AND PayTypeDetielId = TBLSelectSTEdafy.PayTypeDetielId) AS Paid,
            (SELECT ISNULL(SUM(MKasm), 0) FROM TBLMothsleat WHERE asase_code = {0} And stu_code = {1} AND PayTypeDetielId = TBLSelectSTEdafy.PayTypeDetielId) AS PaidDiscount,
            '0' Payment, '0' AS PaymentDiscount
            FROM TBLSelectSTEdafy WHERE asase_code = {0} AND stu_code = {1} And
            edafymony > 
            ((SELECT ISNULL(SUM(MMony), 0) FROM TBLMothsleat WHERE asase_code = {0} And stu_code = {1} AND PayTypeDetielId = TBLSelectSTEdafy.PayTypeDetielId) + 
            (SELECT ISNULL(SUM(MKasm), 0) FROM TBLMothsleat WHERE asase_code = {0} And stu_code = {1} AND PayTypeDetielId = TBLSelectSTEdafy.PayTypeDetielId))
            ", rowStudnt["asase_code"], rowStudnt["stu_code"]));
            gridControlAdditional.DataSource = tbl_Additional;
        }
        private void LoadHis(bool Additional)
        {
            DataRow rowStudnt = slueStudent.Properties.View.GetFocusedDataRow();
            DataTable dt = FXFW.SqlDB.LoadDataTable(string.Format(@"SELECT MID, asase_code, PayTypeDetielId, EsalNo, MMony, DiscountsId, MKasm, DateTasel, KastNoId, datein,
            (Select PayTypeDetiel From  CD_PayTypeDetiel Where PayTypeDetielId = TBLMothsleat.PayTypeDetielId) AS PayTypeDetiel,
            (Select Discounts From  CD_Discounts Where DiscountsId = TBLMothsleat.DiscountsId) AS Discounts,
            (Select KastName From  CD_KastNo Where KastNoId = TBLMothsleat.KastNoId) AS KastName
            FROM TBLMothsleat WHERE asase_code = {0} AND stu_code = {1} AND EXISTS(SELECT PayTypeId FROM CD_PayType WHERE Additional = '{2}' AND 
            PayTypeId = (SELECT PayTypeId FROM CD_PayTypeDetiel WHERE PayTypeId = CD_PayType.PayTypeId AND PayTypeDetielId = TBLMothsleat.PayTypeDetielId))"
            , rowStudnt["asase_code"], rowStudnt["stu_code"], Additional));
            if (Additional)
            {
                gridControlAdditionalHis.DataSource = dt;
                gridViewAdditionalHis.BestFitColumns();
            }
            else
            {
                gridControlBasicHis.DataSource = dt;
                gridViewBasicHis.BestFitColumns();
            }
        }
        private void SplitBasicAdditionalGrids( DataTable dt)
        {
            decimal Payment = Convert.ToDecimal(tbPayment.EditValue);
            foreach (DataRow row in dt.Rows)
            {
                if (Payment == 0)
                {
                    row["Payment"] = 0;
                    continue;
                }
                decimal PayMony = Convert.ToDecimal(row["PayMony"]);
                decimal DiscountMony = Convert.ToDecimal(row["DiscountMony"]);
                decimal Paid = Convert.ToDecimal(row["Paid"]);
                decimal PaidDiscount = Convert.ToDecimal(row["PaidDiscount"]);
                decimal ShouldPay = PayMony + PaidDiscount - Paid - DiscountMony;

                decimal PaymentDiscount = Convert.ToDecimal(row["PaymentDiscount"]);
                if (Payment >= ShouldPay)
                {
                    row["Payment"] = ShouldPay;// should save to TBLMothsleat.MMony
                    Payment -= ShouldPay;
                }
                else
                {
                    row["Payment"] = Payment;
                    Payment = 0;
                }
                row["PaymentDiscount"] = DiscountMony - PaidDiscount;// should save to TBLMothsleat.MKasm
            }
            if (Payment > 0)
            {
                Program.ShowMsg("القيمه اكبر من قيمة القسط", true, this);
                Program.Logger.LogThis("القيمه اكبر من قيمة القسط", Text, FXFW.Logger.OpType.information, null, null, this);
                tbPayment.EditValue = "0"; gridControlBasic.Focus(); tbPayment.Focus();
            }
        }
        private void Saving(DataTable dt)
        {
            if (FXFW.SqlDB.IsNullOrEmpty(deDateTasel.EditValue))
            {
                Program.ShowMsg("من فضلك ادخل تاريخ التحصيل", true, this);
                Program.Logger.LogThis("من فضلك ادخل تاريخ التحصيل", Text, FXFW.Logger.OpType.information, null, null, this);
                return;
            }
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            SqlTransaction trn = null;
            string asase_code = slueStudent.Properties.View.GetFocusedDataRow()["asase_code"].ToString();
            cmd.CommandText = @"INSERT INTO	dbo.TBLMothsleat
                                            ( MID ,
                                              asase_code,
                                              PayTypeDetielId ,
                                              EsalNo ,
                                              stu_code ,
                                              MMony ,
                                              DiscountsId ,
                                              MKasm ,
                                              DateTasel ,
                                              KastNoId ,
                                              datein ,
                                              userin
                                            )
                                    VALUES  ( (Select ISNULL(MAX(MID) + 1, 1) From TBLMothsleat) , -- MID - int
                                              @asase_code , -- asase_code - int
                                              @PayTypeDetielId , -- PayTypeDetielId - int
                                              @EsalNo , -- EsalNo - int
                                              @stu_code , -- stu_code - int
                                              @MMony , -- MMony - float
                                              @DiscountsId , -- DiscountsId - tinyint
                                              @MKasm , -- MKasm - float
                                              @DateTasel , -- DateTasel - date
                                              @KastNoId , -- KastNoId - tinyint
                                              GETDATE() , -- datein - datetime
                                              @userin  -- userin - int
                                            )";
            cmd.Parameters.Add(new SqlParameter("@asase_code", SqlDbType.Int) { Value = asase_code });
            cmd.Parameters.Add(new SqlParameter("@PayTypeDetielId", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@EsalNo", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@stu_code", SqlDbType.Int) { Value = slueStudent.EditValue });
            cmd.Parameters.Add(new SqlParameter("@MMony", SqlDbType.Float));
            cmd.Parameters.Add(new SqlParameter("@DiscountsId", SqlDbType.TinyInt));
            cmd.Parameters.Add(new SqlParameter("@MKasm", SqlDbType.Float));
            if (FXFW.SqlDB.IsNullOrEmpty(deDateTasel.EditValue))
                cmd.Parameters.Add(new SqlParameter("@DateTasel", SqlDbType.Date) { Value = DBNull.Value });
            else
                cmd.Parameters.Add(new SqlParameter("@DateTasel", SqlDbType.Date) { Value = deDateTasel.DateTime.Date });
            cmd.Parameters.Add(new SqlParameter("@KastNoId", SqlDbType.TinyInt) { Value = slueKastNoId.EditValue });
            cmd.Parameters.Add(new SqlParameter("@userin", SqlDbType.Int) { Value = FXFW.SqlDB.UserInfo.UserID });
            try
            {
                con.Open();
                trn = con.BeginTransaction();
                cmd.Transaction = trn;
                foreach (DataRow row in dt.Rows)
                {
                    if (row["Payment"].ToString() == "0")
                        continue;
                    cmd.Parameters["@PayTypeDetielId"].Value = row["PayTypeDetielId"];
                    cmd.Parameters["@EsalNo"].Value = row["EsalNo"];
                    cmd.Parameters["@MMony"].Value = row["Payment"];
                    cmd.Parameters["@DiscountsId"].Value = row["DiscountsId"];
                    cmd.Parameters["@MKasm"].Value = row["PaymentDiscount"];
                    //cmd.Parameters["@KastNoId"].Value = row["KastNoId"];
                    cmd.ExecuteNonQuery();
                }
                trn.Commit();
                Program.ShowMsg("تم الحفظ", false, this);
                Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
                tbPayment.EditValue = "0";
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
            con.Close();
            slueKastNoId_EditValueChanged(slueKastNoId, new EventArgs());
        }
        private void LoadEditGrid()
        {
            gridControlData.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT [MID], asase_code, PayTypeDetielId, EsalNo, stu_code, MMony, DiscountsId, MKasm, DateTasel, KastNoId, 
            estrdadmony, estrdaddate, datein, userin FROM TBLMothsleat");
            repositoryItemGridLookUpEditPayTypeDetielId.DataSource = FXFW.SqlDB.LoadDataTable(@"Select PayTypeDetielId, PayTypeDetiel,
                    (Select Additional From CD_PayType Where PayTypeId = CD_PayTypeDetiel.PayTypeId) AS Additional
                    From CD_PayTypeDetiel");
            repositoryItemGridLookUpEditPayTypeDetielId.DisplayMember = "PayTypeDetiel";
            repositoryItemGridLookUpEditPayTypeDetielId.ValueMember = "PayTypeDetielId";

            repositoryItemGridLookUpEditstu_code.DataSource = FXFW.SqlDB.LoadDataTable(@"Select stu_code, 
                    (SELECT FIRST_NAME + ' ' + FATHER_NAME + ' ' + GF_NAME + ' ' + FAMILY_NAME AS stu_name From stu.TBLstudent Where stu_code = stu.student_t.stu_code) AS stu_name,
                    (Select alsofof_name From CDAlsofof Where alsofof_code = stu.student_t.alsofof_code) AS alsofof_name,
                    (Select fasl_name From CDEFasl Where fasl_code = stu.student_t.fasl_code) AS fasl_name,
                    (Select DiscountsId From TBL_DiscountSt Where asase_code = stu.student_t.asase_code And stu_code = stu.student_t.stu_code) AS DiscountsId,
                    (Select DiscountMony From TBL_DiscountSt Where asase_code = stu.student_t.asase_code And stu_code = stu.student_t.stu_code) AS DiscountMony,
                    (Select Discounts From CD_Discounts Where DiscountsId = (Select DiscountsId From TBL_DiscountSt Where asase_code = stu.student_t.asase_code And stu_code = stu.student_t.stu_code)) AS Discounts
                    From stu.student_t
                    Where asase_code = " + FXFW.SqlDB.asase_code);
            repositoryItemGridLookUpEditstu_code.DisplayMember = "stu_name";
            repositoryItemGridLookUpEditstu_code.ValueMember = "stu_code";

            repositoryItemGridLookUpEditDiscountsId.DataSource = FXFW.SqlDB.LoadDataTable(@"Select DiscountsId, Discounts From CD_Discounts");
            repositoryItemGridLookUpEditDiscountsId.DisplayMember = "Discounts";
            repositoryItemGridLookUpEditDiscountsId.ValueMember = "DiscountsId";

            repositoryItemGridLookUpEditKastNoId.DataSource = FXFW.SqlDB.LoadDataTable(@"Select KastNoId, KastName From CD_KastNo");
            repositoryItemGridLookUpEditKastNoId.DisplayMember = "KastName";
            repositoryItemGridLookUpEditKastNoId.ValueMember = "KastNoId";

            gridViewData.BestFitColumns();
        }
        #endregion
        #region -   Event Handlers   -
        private void TBLMothsleatFrm_Load(object sender, EventArgs e)
        {
            LoadDefaultData();
        }
        private void slueStudent_EditValueChanged(object sender, EventArgs e)
        {
            LoadCD_KastSaf();
            ShowInfo();
            if (FXFW.SqlDB.IsNullOrEmpty(slueStudent.EditValue))
            {
                gcStuInfo.Visible = false;
                gcKast.Visible = false;
                gcKastInfo.Visible = false;
                gcBasic.Visible = false;
                gcAdditional.Visible = false;
                xtraTabControlAdd.Visible = false;
                gcPayment.Visible = false;
            }
            else
            {
                gcStuInfo.Visible = true;
                gcKast.Visible = true;
                gcKastInfo.Visible = true;
                gcBasic.Visible = true;
                gcAdditional.Visible = true;


                if (FXFW.SqlDB.IsNullOrEmpty(slueKastNoId.EditValue))
                {
                    xtraTabControlAdd.Visible = false;
                    gcPayment.Visible = false;
                }
                else
                {
                    xtraTabControlAdd.Visible = true;
                    gcPayment.Visible = true;
                }
            }
        }
        private void slueKastNoId_EditValueChanged(object sender, EventArgs e)
        {
            ShowInfo();
            if (!FXFW.SqlDB.IsNullOrEmpty(slueKastNoId.EditValue))
            {
                LoadBasic();// Load Basic Grid
                LoadAdditional();// Load Additional Grid
                LoadHis(false); // Load Basic History Grid
                LoadHis(true); // Load Additional History Grid
                xtraTabControlAdd.Visible = true;
                gcPayment.Visible = true;
            }
            else
            {
                xtraTabControlAdd.Visible = false;
                gcPayment.Visible = false;
            }
            
        }
        private void tbPayment_EditValueChanged(object sender, EventArgs e)
        {
            if (FXFW.SqlDB.IsNullOrEmpty(tbPayment.EditValue))
                tbPayment.EditValue = "0";
            switch (xtraTabControlAdd.SelectedTabPage.Name)
            {
                case "xtraTabPageBasic":
                    SplitBasicAdditionalGrids(tbl_Basic);// Split money inside the basic gird
                    break;
                case "xtraTabPageAdditional":
                    SplitBasicAdditionalGrids(tbl_Additional);// Split money inside the basic gird
                    break;
                case "xtraTabPageBasicHis":
                    break;
                case "xtraTabPageAdditionalHis":
                    break;
                default:
                    break;
            }

        }
        private void btnBasicSave_Click(object sender, EventArgs e)
        {
            Saving(tbl_Basic);
        }
        private void btnAdditionalSave_Click(object sender, EventArgs e)
        {
            Saving(tbl_Additional);
        }
        private void xtraTabControlMain_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            switch (xtraTabControlMain.SelectedTabPage.Name)
            {
                case "xtraTabPageAdd":
                    slueStudent.EditValue = null;
                    break;
                case "xtraTabPageEdit":
                    LoadEditGrid();
                    break;
                default:
                    break;
            }
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            DataRow row = gridViewData.GetFocusedDataRow();
            if (FXFW.SqlDB.IsNullOrEmpty(row["PayTypeDetielId"]) || FXFW.SqlDB.IsNullOrEmpty(row["EsalNo"]) || FXFW.SqlDB.IsNullOrEmpty(row["stu_code"]) || FXFW.SqlDB.IsNullOrEmpty(row["MMony"]) || FXFW.SqlDB.IsNullOrEmpty(row["DateTasel"]) || FXFW.SqlDB.IsNullOrEmpty(row["KastNoId"]))
            {
                Program.ShowMsg("من فضلك ادخل بند التحصيل و رقم الايصال و الطالب و المبلغ و وتاريخ التحصيل و القسط", true, this);
                Program.Logger.LogThis("من فضلك ادخل بند التحصيل و رقم الايصال و الطالب و المبلغ و وتاريخ التحصيل و القسط", Text, FXFW.Logger.OpType.information, null, null, this);
                return;
            }
            try
            {
                if (FXFW.SqlDB.IsNullOrEmpty(row["MID"]))
                {
                    cmd.CommandText = @"INSERT INTO	dbo.TBLMothsleat
                                                ( MID ,
                                                  asase_code,
                                                  PayTypeDetielId ,
                                                  EsalNo ,
                                                  stu_code ,
                                                  MMony ,
                                                  DiscountsId ,
                                                  MKasm ,
                                                  DateTasel ,
                                                  KastNoId ,
                                                  datein ,
                                                  userin ,
                                                  estrdadmony ,
                                                  estrdaddate
                                                )
                                        VALUES  ( (Select ISNULL(MAX(MID) + 1, 1) From TBLMothsleat) , -- MID - int
                                                  @asase_code , -- asase_code - int
                                                  @PayTypeDetielId , -- PayTypeDetielId - int
                                                  @EsalNo , -- EsalNo - int
                                                  @stu_code , -- stu_code - int
                                                  @MMony , -- MMony - float
                                                  @DiscountsId , -- DiscountsId - tinyint
                                                  @MKasm , -- MKasm - float
                                                  @DateTasel , -- DateTasel - date
                                                  @KastNoId , -- KastNoId - tinyint
                                                  GETDATE() , -- datein - datetime
                                                  @userin ,  -- userin - int
                                                  @estrdadmony , -- estrdadmony - float
                                                  @estrdaddate -- estrdaddate - datetime
                                                )";
                }
                else
                {
                    cmd.CommandText = @"Update TBLMothsleat SET asase_code = @asase_code, PayTypeDetielId = @PayTypeDetielId, EsalNo = @EsalNo, stu_code = @stu_code, MMony = @MMony, 
                    DiscountsId = @DiscountsId, MKasm = @MKasm, DateTasel = @DateTasel, KastNoId = @KastNoId, datein = GETDATE(), userin = @userin, estrdadmony = @estrdadmony, estrdaddate = @estrdaddate
                    WHERE MID = @MID";
                    cmd.Parameters.Add(new SqlParameter("@MID", SqlDbType.Int) { Value = row["MID"] });
                }
                cmd.Parameters.Add(new SqlParameter("@asase_code", SqlDbType.Int) { Value = FXFW.SqlDB.asase_code });
                cmd.Parameters.Add(new SqlParameter("@PayTypeDetielId", SqlDbType.Int) { Value = row["PayTypeDetielId"] });
                cmd.Parameters.Add(new SqlParameter("@EsalNo", SqlDbType.Int) { Value = row["EsalNo"] });
                cmd.Parameters.Add(new SqlParameter("@stu_code", SqlDbType.Int) { Value = row["stu_code"] });
                cmd.Parameters.Add(new SqlParameter("@MMony", SqlDbType.Float) { Value = row["MMony"] });
                if (FXFW.SqlDB.IsNullOrEmpty(row["DiscountsId"]))
                    cmd.Parameters.Add(new SqlParameter("@DiscountsId", SqlDbType.TinyInt) { Value = DBNull.Value });
                else
                    cmd.Parameters.Add(new SqlParameter("@DiscountsId", SqlDbType.TinyInt) { Value = row["DiscountsId"] });

                if (FXFW.SqlDB.IsNullOrEmpty(row["MKasm"]))
                    cmd.Parameters.Add(new SqlParameter("@MKasm", SqlDbType.Float) { Value = DBNull.Value });
                else
                    cmd.Parameters.Add(new SqlParameter("@MKasm", SqlDbType.Float) { Value = row["MKasm"] });
                cmd.Parameters.Add(new SqlParameter("@DateTasel", SqlDbType.Date) { Value = row["DateTasel"] });
                cmd.Parameters.Add(new SqlParameter("@KastNoId", SqlDbType.TinyInt) { Value = row["KastNoId"] });
                cmd.Parameters.Add(new SqlParameter("@userin", SqlDbType.Int) { Value = FXFW.SqlDB.UserInfo.UserID });
                if (FXFW.SqlDB.IsNullOrEmpty(row["estrdadmony"]))
                    cmd.Parameters.Add(new SqlParameter("@estrdadmony", SqlDbType.TinyInt) { Value = "0" });
                else
                    cmd.Parameters.Add(new SqlParameter("@estrdadmony", SqlDbType.Float) { Value = row["estrdadmony"] });

                if (FXFW.SqlDB.IsNullOrEmpty(row["estrdaddate"]))
                    cmd.Parameters.Add(new SqlParameter("@estrdaddate", SqlDbType.Date) { Value = DBNull.Value });
                else
                    cmd.Parameters.Add(new SqlParameter("@estrdaddate", SqlDbType.Date) { Value = row["estrdaddate"] });

                con.Open();
                cmd.ExecuteNonQuery();
                Program.ShowMsg("تم الحفظ", false, this);
                Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
                LoadEditGrid();
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
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            DataRow row = gridViewData.GetFocusedDataRow();
            if (row["MID"].ToString() == string.Empty)
            {
                LoadEditGrid();
                return;
            }
            try
            {
                cmd.CommandText = string.Format(@"Delete From TBLMothsleat Where MID = {0}", row["MID"]);
                con.Open();
                cmd.ExecuteNonQuery();
                Program.ShowMsg("تم الحذف", false, this);
                Program.Logger.LogThis("تم الحذف", Text, FXFW.Logger.OpType.success, null, null, this);
                LoadEditGrid();
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