using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.IO;

namespace E_Club_Att_Manager
{
    public partial class AttUserMainFrm : DevExpress.XtraEditors.XtraForm
    {
        DataTable EmpInfo = new DataTable("FalseX2010-08");
        private string hedor_time_End = string.Empty;
        private string enseraf_time_Start = string.Empty;
        private string ShiftId = string.Empty;
        private MCls.HarakaTypeStr HarakaType;
        public AttUserMainFrm()
        {
            InitializeComponent();
        }
        private string GetShiftID()
        {
            SqlConnection Con = new SqlConnection(Program.MC.SQLConStrMalafat);
            string TheTime = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
            SqlCommand Cmd = new SqlCommand("SELECT shift, shift_code FROM CDATT_sheft WHERE (shift_Start < CONVERT(DATETIME, '" + TheTime + "', 108)) AND (shift_End > CONVERT(DATETIME, '" + TheTime + "', 108))", Con);
            SqlDataReader dr;
            string ReturnMe = string.Empty;
            try
            {
                Con.Open();
                dr = Cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    TxtShift.Text = dr.GetValue(0).ToString();
                    ReturnMe = dr.GetValue(1).ToString();
                    TxtShift.ForeColor = Color.Green;
                    TxtNo.Visible = true;
                }
                else
                {
                    TxtShift.Text = "لا يوجد فتره الان";
                    TxtShift.ForeColor = Color.Red;
                    TxtNo.Visible = false;
                }
            }
            catch (SqlException ex)
            {
                TxtShift.Text = ex.Message;
                TxtShift.ForeColor = Color.Red;
                TxtNo.Visible = false;
            }
            Con.Close();
            return ReturnMe;
        }
        private void GetEmpInfo()
        {
            EmpInfo = new DataTable("FalseX2010-08");
            if (TxtNo.Text.Trim().Length == 0)
                return;
            EmpInfo = Program.MC.LoadDataTableMalafat(@"SELECT EmpID, Emp_Full_Name, (SELECT job FROM CD_job WHERE (job_id = Emp_Master.job_id)) AS job, EmpPic
                                                        FROM Emp_Master WHERE (EmpID = " + TxtNo.Text.Trim() + ")");
            if (EmpInfo.Rows.Count != 0)
            {
                TxtState.Text = string.Empty;
                TxtState.Properties.Appearance.ForeColor = Color.Lime;
                TxtName.Text = EmpInfo.Rows[0]["Emp_Full_Name"].ToString();
                TxtJob.Text = EmpInfo.Rows[0]["job"].ToString();
                if (File.Exists(EmpInfo.Rows[0]["EmpPic"].ToString()))
                    Pic.Image = Image.FromFile(EmpInfo.Rows[0]["EmpPic"].ToString());
                else
                    Pic.Image = null;
                DataTable TempTbl = new DataTable();
                TempTbl = Program.MC.LoadDataTableMalafat("SELECT hedor_time_End, enseraf_time_Start FROM ATT_Company_Emp WHERE EmpID = " + TxtNo.Text.Trim());
                if (TempTbl.Rows.Count != 0)
                {
                    hedor_time_End = TempTbl.Rows[0]["hedor_time_End"].ToString();
                    enseraf_time_Start = TempTbl.Rows[0]["enseraf_time_Start"].ToString();
                }
                else
                {
                    hedor_time_End = string.Empty;
                    enseraf_time_Start = string.Empty;
                }
            }
            else
            {
                TxtState.Text = "رقم موظف مرفوض";
                TxtState.Properties.Appearance.ForeColor = Color.Red;
                hedor_time_End = string.Empty;
                enseraf_time_Start = string.Empty;
                TxtName.Text = string.Empty;
                TxtJob.Text = string.Empty;
                Pic.Image = null;
                hedor_time_End = string.Empty;
                enseraf_time_Start = string.Empty;
            }
            Application.DoEvents();
            System.Threading.Thread.Sleep(1000);
            TxtNo.Text = string.Empty;
        }
        private MCls.HarakaTypeStr GetHarakaType()
        {
            DataTable TempTbl = new DataTable();
            TempTbl = Program.MC.LoadDataTableMalafat("SELECT EmpID, shift_code FROM ATT_Company_Emp WHERE (EmpID = " + EmpInfo.Rows[0]["EmpID"].ToString() + ") AND (shift_code = " + ShiftId + ")");
            if (TempTbl.Rows.Count == 0)//if this emp assign to this shift
                return MCls.HarakaTypeStr.Refuse;

            TempTbl = new DataTable();
            string today = "CONVERT(DATETIME, '" + MCls.ConvertToDateDMY(DEDate.EditValue.ToString()) + "', 20)";
            TempTbl = Program.MC.LoadDataTableMalafat("SELECT TOP (1) c_emp_harka_type FROM ATT_empharaka WHERE (EmpID = " + EmpInfo.Rows[0]["EmpID"].ToString() + ") AND (shift_code = " + ShiftId + ") AND (harka_date = " + today + ") ORDER BY EmpHarakaID DESC");
            if (TempTbl.Rows.Count == 0)//if this emp have row b4 in this (shift + day)
                return MCls.HarakaTypeStr.Hedoor;
            int EmpHarkaType  = Convert.ToInt16(TempTbl.Rows[0]["c_emp_harka_type"]);
            switch (EmpHarkaType)
            {
                case (int)MCls.HarakaTypeStr.Hedoor:
                    if (enseraf_time_Start == string.Empty)
                        return MCls.HarakaTypeStr.Refuse;
                    else
                    {
                        DateTime enseraftime = Convert.ToDateTime(enseraf_time_Start);
                        if (enseraftime.Hour > DateTime.Now.Hour)
                            return MCls.HarakaTypeStr.Azzn;
                        else if (enseraftime.Hour == DateTime.Now.Hour)
                        {
                            if (enseraftime.Minute > DateTime.Now.Minute)
                                return MCls.HarakaTypeStr.Azzn;
                            else
                                return MCls.HarakaTypeStr.Inseraf;
                        }
                        else
                            return MCls.HarakaTypeStr.Inseraf;
                    }
                case (int)MCls.HarakaTypeStr.Inseraf:
                    return MCls.HarakaTypeStr.Refuse;

                case (int)MCls.HarakaTypeStr.Azzn:
                    return MCls.HarakaTypeStr.AzznBack;

                case (int)MCls.HarakaTypeStr.AzznBack:
                    DateTime inseraftime = Convert.ToDateTime(enseraf_time_Start);
                        if (inseraftime.Hour >= DateTime.Now.Hour)
                            return MCls.HarakaTypeStr.Azzn;
                        else if (inseraftime.Hour == DateTime.Now.Hour)
                        {
                            if (inseraftime.Minute > DateTime.Now.Minute)
                                return MCls.HarakaTypeStr.Azzn;
                            else
                                return MCls.HarakaTypeStr.Inseraf;
                        }
                        else
                            return MCls.HarakaTypeStr.Inseraf;
                default:
                    return MCls.HarakaTypeStr.Refuse;
            }
        }
        private void AttUserMainFrm_Load(object sender, EventArgs e)
        {
            DEDate.EditValue = DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year;
            TxtNo.Focus();
            TmrTheTime_Tick(TmrTheTime, new EventArgs());
            TmrTheShift_Tick(TmrTheShift, new EventArgs());
        }
        private void TmrTheTime_Tick(object sender, EventArgs e)
        {
            string TheTime = string.Empty;
            string DayName = string.Empty;
            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Friday:
                    DayName = "الجمعــه";
                    break;
                case DayOfWeek.Monday:
                    DayName = "الاثنيـــن";
                    break;
                case DayOfWeek.Saturday:
                    DayName = "السبـــت";
                    break;
                case DayOfWeek.Sunday:
                    DayName = "الاحـــد";
                    break;
                case DayOfWeek.Thursday:
                    DayName = "الخميــــس";
                    break;
                case DayOfWeek.Tuesday:
                    DayName = "الثلاثــاء";
                    break;
                case DayOfWeek.Wednesday:
                    DayName = "الاربعـــاء";
                    break;
                default:
                    break;
            }
            TheTime =DayName + " - " + DateTime.Now.ToShortTimeString();
            if (!DEDate.Focused)
                TxtNo.Focus();
            LblDate.Text = TheTime;
        }
        private void TmrTheShift_Tick(object sender, EventArgs e)
        {
            ShiftId = GetShiftID();
        }
        private void TxtNo_EditValueChanged(object sender, EventArgs e)
        {
            if (TxtNo.Text.Trim().Length == 0)
                return;
            TxtNo.Visible = false;
            GetEmpInfo();
            TxtNo.Text = string.Empty;
            if (EmpInfo.Rows.Count == 0)//if this emp assign to this shift
            {
                TxtState.Text = "تم رفــــــض البطاقة";
                TxtState.ForeColor = Color.Red;
                return;
            }
            HarakaType = GetHarakaType();
            SqlConnection con = new SqlConnection(Program.MC.SQLConStrMalafat);
            SqlCommand cmd = new SqlCommand("", con);
            string EmpID = EmpInfo.Rows[0]["EmpID"].ToString();
            string harka_date = "CONVERT(DATETIME, '" + MCls.ConvertToDateDMY(DEDate.EditValue.ToString()) + "', 20)";
            string c_emp_harka_type = "NULL";
            string shift_code = ShiftId;
            string harka_time = " CONVERT(DATETIME, '" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "', 108) ";
            string adafetime = "NULL", gasmtime = "NULL", time_mokarara;
            try
            {
                con.Open();
                switch (HarakaType)
                {
                    case MCls.HarakaTypeStr.Refuse:
                        TxtState.Text = "تم رفــــــض البطاقة";
                        TxtState.ForeColor = Color.Red;
                        break;
                    case MCls.HarakaTypeStr.Hedoor:
                        c_emp_harka_type = ((int)MCls.HarakaTypeStr.Hedoor).ToString();
                        TimeSpan HedorTime = Convert.ToDateTime(hedor_time_End).TimeOfDay;
                        time_mokarara = " CONVERT(DATETIME, '" + HedorTime.Hours + ":" + HedorTime.Minutes + ":" + HedorTime.Seconds + "', 108) ";
                        DateTime Hedor_Time = Convert.ToDateTime(hedor_time_End);
                        int hours = 0, minutes = 0;
                        if (DateTime.Now.Hour > Hedor_Time.Hour)
                            hours = DateTime.Now.Hour - Hedor_Time.Hour;
                        if (DateTime.Now.Minute > Hedor_Time.Minute)
                            minutes = DateTime.Now.Minute - Hedor_Time.Minute;
                        if (hours > 0 || minutes > 0)
                            gasmtime = " CONVERT(DATETIME, '" + hours + ":" + minutes + ":00" + "', 108) ";
                        cmd.CommandText = string.Format("INSERT INTO ATT_empharaka (EmpID, harka_date, c_emp_harka_type, shift_code, harka_time, adafetime, gasmtime, time_mokarara) VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", EmpID, harka_date, c_emp_harka_type, shift_code, harka_time, adafetime, gasmtime, time_mokarara);
                        cmd.ExecuteNonQuery();
                        TxtState.Text = "تسجيـــل حضــور";
                        TxtState.ForeColor = Color.Lime;
                        break;

                    case MCls.HarakaTypeStr.Inseraf:
                        c_emp_harka_type = ((int)MCls.HarakaTypeStr.Inseraf).ToString();
                        TimeSpan HedorTime1 = Convert.ToDateTime(hedor_time_End).TimeOfDay;
                        time_mokarara = " CONVERT(DATETIME, '" + HedorTime1.Hours + ":" + HedorTime1.Minutes + ":" + HedorTime1.Seconds + "', 108) ";
                        DateTime Inseraf_Time = Convert.ToDateTime(enseraf_time_Start);
                        int hours2 = 0, minutes2 = 0;
                        if (DateTime.Now.Hour > Inseraf_Time.Hour)
                            hours2 = DateTime.Now.Hour - Inseraf_Time.Hour;
                        if (DateTime.Now.Minute > Inseraf_Time.Minute)
                            minutes2 = DateTime.Now.Minute - Inseraf_Time.Minute;
                        if (hours2 > 0 || minutes2 > 0)
                            adafetime = " CONVERT(DATETIME, '" + hours2 + ":" + minutes2 + ":00" + "', 108) ";
                        cmd.CommandText = string.Format("INSERT INTO ATT_empharaka (EmpID, harka_date, c_emp_harka_type, shift_code, harka_time, adafetime, gasmtime, time_mokarara) VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", EmpID, harka_date, c_emp_harka_type, shift_code, harka_time, adafetime, gasmtime, time_mokarara);
                        cmd.ExecuteNonQuery();
                        TxtState.Text = "تسجيـــل انصــــراف";
                        TxtState.ForeColor = Color.Lime;
                        break;

                    case MCls.HarakaTypeStr.Azzn:
                        c_emp_harka_type = ((int)MCls.HarakaTypeStr.Azzn).ToString();
                        TimeSpan HedorTime2 = Convert.ToDateTime(hedor_time_End).TimeOfDay;
                        time_mokarara = " CONVERT(DATETIME, '" + HedorTime2.Hours + ":" + HedorTime2.Minutes + ":" + HedorTime2.Seconds + "', 108) ";
                        DateTime Ins_Time = Convert.ToDateTime(enseraf_time_Start);
                        int hours3 = 0, minutes3 = 0;
                        if (DateTime.Now.Hour < Ins_Time.Hour)
                            hours3 = Ins_Time.Hour - DateTime.Now.Hour;
                        if (DateTime.Now.Minute < Ins_Time.Minute)
                            minutes3 = Ins_Time.Minute - DateTime.Now.Minute;
                        if (hours3 > 0 || minutes3 > 0)
                            gasmtime = " CONVERT(DATETIME, '" + hours3 + ":" + minutes3 + ":00" + "', 108) ";
                        cmd.CommandText = string.Format("INSERT INTO ATT_empharaka (EmpID, harka_date, c_emp_harka_type, shift_code, harka_time, adafetime, gasmtime, time_mokarara) VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", EmpID, harka_date, c_emp_harka_type, shift_code, harka_time, adafetime, gasmtime, time_mokarara);
                        cmd.ExecuteNonQuery();
                        TxtState.Text = "تسجيـــل اذن";
                        TxtState.ForeColor = Color.Lime;
                        break;

                    case MCls.HarakaTypeStr.AzznBack:
                        c_emp_harka_type = ((int)MCls.HarakaTypeStr.AzznBack).ToString();
                        TimeSpan HedorTime3 = Convert.ToDateTime(hedor_time_End).TimeOfDay;
                        time_mokarara = " CONVERT(DATETIME, '" + HedorTime3.Hours + ":" + HedorTime3.Minutes + ":" + HedorTime3.Seconds + "', 108) ";
                        cmd.CommandText = string.Format("INSERT INTO ATT_empharaka (EmpID, harka_date, c_emp_harka_type, shift_code, harka_time, adafetime, gasmtime, time_mokarara) VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", EmpID, harka_date, c_emp_harka_type, shift_code, harka_time, adafetime, gasmtime, time_mokarara);
                        cmd.ExecuteNonQuery();
                        TxtState.Text = "تسجيـــل عوده من الاذن";
                        TxtState.ForeColor = Color.Lime;
                        break;

                    case MCls.HarakaTypeStr.Nothing:
                        TxtState.Text = "تم رفــــــض البطاقة";
                        TxtState.ForeColor = Color.Red;
                        break;

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message,ex.Number.ToString(),MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            con.Close();
            TxtNo.Visible = true;
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}