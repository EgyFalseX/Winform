using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections;
using System.Data.SqlClient;


namespace SchoolWeeklyPeriods
{
    public partial class QryWeekTeacherTableFrm : DevExpress.XtraEditors.XtraForm
    {
              
        #region -   Variables   -
        private DataTable dtData = new DataTable();
        
        private Bitmap memoryImage;
        #endregion
        #region -   Functions   -
        public QryWeekTeacherTableFrm()
        {
            InitializeComponent();
        }
        [System.Runtime.InteropServices.DllImportAttribute("gdi32.dll")]
        private static extern int BitBlt(
          IntPtr hdcDest,     // handle to destination DC (device context)
          int nXDest,         // x-coord of destination upper-left corner
          int nYDest,         // y-coord of destination upper-left corner
          int nWidth,         // width of destination rectangle
          int nHeight,        // height of destination rectangle
          IntPtr hdcSrc,      // handle to source DC
          int nXSrc,          // x-coordinate of source upper-left corner
          int nYSrc,          // y-coordinate of source upper-left corner
          Int32 dwRop  // raster operation code
          );
        private void DeleteHolydayCells()
        {
            DataTable dt = FXFW.SqlDB.LoadDataTable(@"SELECT daycode FROM gdw.CD_HesaTime GROUP BY daycode");// Days available for Emp

            for (int i = gcTable.Controls.Count - 1; i >= 0; i--)
            {
                if (gcTable.Controls[i].GetType() != typeof(GroupControl))
                    continue;
                GroupControl gd = (GroupControl)gcTable.Controls[i];
                string[] Args = gd.Text.Split(Convert.ToChar(";"));
                int daycode = Convert.ToInt32(Args[0]);

                bool IsHolyday = true;
                foreach (DataRow row in dt.Rows)
                {
                    if ((int)row["daycode"] == daycode)
                    {
                        IsHolyday = false;
                        break;
                    }
                }
                if (IsHolyday)
                    gcTable.Controls.Remove(gd);
            }
        }
        private void LoadDefaultData()
        {
            LUEEmp.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT EmpID, 
            ISNULL(EMP_FIRST_NAME, '') + ' ' + ISNULL(EMP_FATHER_NAME, '') + ' ' + ISNULL(EMP_FAM_NAME, '') + ' ' + ISNULL(EMP_FOURTH_NAME, '') AS emp_name
            FROM TBL_Emp");
            LUEEmp.Properties.DisplayMember = "emp_name";
            LUEEmp.Properties.ValueMember = "EmpID";

        }
        private DataTable LoadData(object EmpID)
        {
            return FXFW.SqlDB.LoadDataTable(string.Format(@"SELECT asase_code, EmpID, daycode, hasa_code, alsofof_code, fasl_code, SubjectId, placecd, 
            (Select ISNULL(EMP_FIRST_NAME, '') + ' ' + ISNULL(EMP_FATHER_NAME, '') + ' ' + ISNULL(EMP_FAM_NAME, '') + ' ' + ISNULL(EMP_FOURTH_NAME, '') FROM TBL_Emp WHERE EmpID = gdw.TBLTimeTable.EmpID) AS emp_name,
            (select Subject from CD_Subject where SubjectId = gdw.TBLTimeTable.SubjectId) AS Subject,
            (Select Shortly From CDAlsofof Where alsofof_code = gdw.TBLTimeTable.alsofof_code) AS ShortlySaf,
            (Select Shortly From CDEFasl Where fasl_code = gdw.TBLTimeTable.fasl_code) AS ShortlyFasl
            FROM gdw.TBLTimeTable
            WHERE (asase_code = {0}) AND (EmpID = {1})", FXFW.SqlDB.asase_code, EmpID));
        }
        private DataTable LoadData(object alsofof_code, object fasl_code)
        {
            return FXFW.SqlDB.LoadDataTable(string.Format(@"SELECT asase_code, EmpID, daycode, hasa_code, alsofof_code, fasl_code, SubjectId, placecd, 
            (Select ISNULL(EMP_FIRST_NAME, '') + ' ' + ISNULL(EMP_FATHER_NAME, '') + ' ' + ISNULL(EMP_FAM_NAME, '') + ' ' + ISNULL(EMP_FOURTH_NAME, '') FROM TBL_Emp WHERE EmpID = gdw.TBLTimeTable.EmpID) AS emp_name,
            (select Subject from CD_Subject where SubjectId = gdw.TBLTimeTable.SubjectId) AS Subject,
            (Select Shortly From CDAlsofof Where alsofof_code = gdw.TBLTimeTable.alsofof_code) AS ShortlySaf,
            (Select Shortly From CDEFasl Where fasl_code = gdw.TBLTimeTable.fasl_code) AS ShortlyFasl
            FROM gdw.TBLTimeTable
            WHERE asase_code = {0} AND alsofof_code = {1}  AND fasl_code = {2}", FXFW.SqlDB.asase_code, alsofof_code, fasl_code));
        }
        private void ClearCells()
        {
            for (int i = 0; i < gcTable.Controls.Count; i++)
            {
                if (gcTable.Controls[i].GetType() != typeof(GroupControl))
                    continue;
                GroupControl gc = (GroupControl)gcTable.Controls[i];
                LabelControl Fasl = (LabelControl)gcTable.Controls[i].Controls[0];
                LabelControl Subject = (LabelControl)gcTable.Controls[i].Controls[1];

                gc.Tag = null;
                Fasl.Text = "-";
                Fasl.Tag = string.Empty;
                Fasl.BackColor = Color.White;
                Subject.Text = "-";
                //Subject.Tag = string.Empty;
                Subject.BackColor = Color.White;
            }
        }
        private void FillCells(DataTable dt)
        {
            ClearCells();
            for (int i = 0; i < gcTable.Controls.Count; i++)
            {
                if (gcTable.Controls[i].GetType() != typeof(GroupControl))
                    continue;
                GroupControl gd = (GroupControl)gcTable.Controls[i];

                string[] Args = gd.Text.Split(Convert.ToChar(";"));

                int daycode = Convert.ToInt32(Args[0]);
                int hasa_code = Convert.ToInt32(Args[1]);

                LabelControl Fasl = (LabelControl)gd.Controls[0];
                LabelControl Subject = (LabelControl)gd.Controls[1];

                FillCell(dt, ref gd, ref Fasl, ref Subject, daycode, hasa_code);

                //Set the color
                Color SelectedColor = new Color();
                if (Subject.Text.Contains("//"))
                    SelectedColor = Color.Red;
                else if (Subject.Text == "-")
                    SelectedColor = colorEEmpty.Color;
                else if (Subject.Text != "-")
                {
                    if (i == 0)
                        SelectedColor = Color.White;
                    else
                    {
                        //check if previews cell have the same subject
                        if (gcTable.Controls[i - 1].GetType() == typeof(GroupControl))
                        {
                            LabelControl PrevSubject = (LabelControl)gcTable.Controls[i - 1].Controls[1];
                            if (Subject.Text == PrevSubject.Text)
                            {
                                SelectedColor = colorEDouble.Color;
                                ((LabelControl)PrevSubject).BackColor = colorEDouble.Color;
                            }
                        }
                    }
                }
                Subject.BackColor = SelectedColor;
            }
        }
        private void FillCell(DataTable dt, ref GroupControl gc, ref LabelControl Fasl, ref LabelControl Subject, int daycode, int hasa_code)
        {
            int repeted = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if ((int)dt.Rows[i]["daycode"] == daycode && (int)dt.Rows[i]["hasa_code"] == hasa_code)
                {
                    Subject.Text = dt.Rows[i]["Subject"].ToString();
                    //Subject.Tag = dt.Rows[i]["SubjectId"].ToString();

                    gc.Tag = dt.Rows[i];

                    if (repeted == 0)
                    {
                        Fasl.Text = String.Format("{0} - {1}", dt.Rows[i]["ShortlySaf"], dt.Rows[i]["ShortlyFasl"]);
                        Fasl.Tag = dt.Rows[i]["fasl_code"].ToString();
                        repeted++;
                    }
                    else
                    {
                        Fasl.Text += " // " + String.Format("{0} - {1}", dt.Rows[i]["ShortlySaf"], dt.Rows[i]["ShortlyFasl"]);
                        Fasl.Tag += ";" + dt.Rows[i]["fasl_code"];
                    }
                }
            }
        }
        private List<GroupControl> GetFreeDropCells(string alsofof_code, string fasl_code, string daycode, string hasa_code)
        {
            List<GroupControl> ReturnMe = new List<GroupControl>();

            //Restracted and busy cells
            DataTable dt = FXFW.SqlDB.LoadDataTable(string.Format(@"SELECT asase_code, EmpID, daycode, hasa_code, alsofof_code, fasl_code, SubjectId, placecd
            FROM gdw.TBLTimeTable WHERE
            asase_code = {0} AND alsofof_code = {1} AND fasl_code = {2} AND (EXISTS (
            SELECT EmpID FROM gdw.TBLTimeTable AS tbl WHERE 
            asase_code = gdw.TBLTimeTable.asase_code AND EmpID = gdw.TBLTimeTable.EmpID AND daycode = {3} AND hasa_code = {4} ) OR EXISTS
            (SELECT EmpID FROM dbo.TBLTeacherNoDays WHERE EmpID = gdw.TBLTimeTable.EmpID AND daycode = {3} AND hasa_code = {4} ))"
                , FXFW.SqlDB.asase_code, alsofof_code, fasl_code, daycode, hasa_code));
            for (int i = 0; i < gcTable.Controls.Count; i++)
            {
                if (gcTable.Controls[i].GetType() != typeof(GroupControl))
                    continue;
                GroupControl gc = (GroupControl)gcTable.Controls[i];
                LabelControl faslLbl = (LabelControl)gc.Controls[0];
                
                string[] Args = gc.Text.Split(Convert.ToChar(";"));
                string day = Args[0];
                string Period = Args[1];
                
                if (faslLbl.Tag.ToString().Contains(";") || gc.Tag != null)
                {
                    gc.Visible = false;
                    ReturnMe.Add(gc);
                    continue;
                }

                foreach (DataRow row in dt.Rows)
                {
                    if (row["daycode"].ToString() == day && row["hasa_code"].ToString() == Period)
                    {
                        gc.Visible = false;
                        ReturnMe.Add(gc);
                        break;
                    }
                }
            }
            //Holyday cells
            DataTable dtHoleyday = FXFW.SqlDB.LoadDataTable(string.Format(@"SELECT EmpID, daycode, hasa_code FROM dbo.TBLTeacherNoDays WHERE EmpID = {0}", LUEEmp.EditValue));
            for (int i = 0; i < gcTable.Controls.Count; i++)
            {
                if (gcTable.Controls[i].GetType() != typeof(GroupControl))
                    continue;
                GroupControl gc = (GroupControl)gcTable.Controls[i];
                string[] Args = gc.Text.Split(Convert.ToChar(";"));
                string day = Args[0];
                string Period = Args[1];
                foreach (DataRow row in dtHoleyday.Rows)
                {
                    if (row["daycode"].ToString() == day && row["hasa_code"].ToString() == Period)
                    {
                        gc.Visible = false;
                        ReturnMe.Add(gc);
                        break;
                    }
                }
            }

            return ReturnMe;
        }
        private void CaptureScreen()
        {
            Graphics mygraphics = CreateGraphics();
            Size s = Size;
            memoryImage = new Bitmap(s.Width, s.Height, mygraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            IntPtr dc1 = mygraphics.GetHdc();
            IntPtr dc2 = memoryGraphics.GetHdc();
            BitBlt(dc2, 0, 0, ClientRectangle.Width, ClientRectangle.Height, dc1, 0, 0, 13369376);
            mygraphics.ReleaseHdc(dc1);
            memoryGraphics.ReleaseHdc(dc2);
        }
        
        #endregion
        #region -   Event Handlers   -
        private void WeekTeacherTableFrm_Load(object sender, EventArgs e)
        {
            DeleteHolydayCells();
            LoadDefaultData();
        }
        private void LUEEmp_EditValueChanged(object sender, EventArgs e)
        {
            //ClearCells();
            if (FXFW.SqlDB.IsNullOrEmpty(LUEEmp.EditValue))
                return;

            dtData = LoadData(LUEEmp.EditValue);

            lblPeriodCount.Text = "عدد الحصص :  " + dtData.Rows.Count;

            FillCells(dtData);
        }
        private void printDocument_PrintPage(Object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            gcOptions.Visible = false;

            using (System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument())
            {
                printDocument.PrintPage += printDocument_PrintPage;
                printDocument.DefaultPageSettings.Landscape = true;
                printDocument.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("FalseX", 500, 1000);
                //Resize
                Size = new Size(974, 507);
                CaptureScreen();
                try
                {
                    //printDocument.Print();
                    PrintPreviewDialog PPdlg = new PrintPreviewDialog() { Document = printDocument };
                    PPdlg.Show();
                }
                catch (Exception ex)
                {
                    Program.ShowMsg(ex.Message, true, this);
                    Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, ex, null, this);
                }
            }
            Size = new Size(974, 589);
            gcOptions.Visible = true;
        }

        private void groupControl_MouseDown(object sender, MouseEventArgs e)
        {
            GroupControl gc = (GroupControl)sender;
            if (gc.Tag == null)//Cell is empty
                return;
            if (gc.Controls[0].Tag.ToString().Contains(";"))// Cell Have 2 Fasl
                return;

            DataRow row = (DataRow)gc.Tag;
            string day = row["daycode"].ToString();
            string Period = row["hasa_code"].ToString();
            string Fasl = row["fasl_code"].ToString();
            string alsofof_code = row["alsofof_code"].ToString();

            //Hide Unneeded Cells
            List<GroupControl> InVisableCells = GetFreeDropCells(alsofof_code, Fasl, day, Period);// make not needed cells invisable
            gc.Visible = false;

            //Show Drop Cells Contains depend on Drag Data
            DataTable dt = LoadData(alsofof_code, (string)Fasl);
            FillCells(dt);

            gc.DoDragDrop(row, DragDropEffects.Copy | DragDropEffects.Move);

            gcTable.Text = "جدول الحصص";

            foreach (GroupControl item in InVisableCells)// return back invisable cells to be visable again
                item.Visible = true;
            gc.Visible = true;
            FillCells(dtData);
        }
        private void groupControl_DragEnter(object sender, DragEventArgs e)
        {
            GroupControl gc = (GroupControl)sender;
            gc.Size = new Size(gc.Size.Width + gc.Size.Width * 15 / 100, gc.Size.Height + gc.Size.Height * 15 / 100);

            if (gc.Tag == null)
            {
                e.Effect = DragDropEffects.Move;
                gcTable.Text = string.Empty;
                return;
            }
            if (gc.Controls[0].Tag.ToString().Contains(";"))
            {
                e.Effect = DragDropEffects.None;
                return;
            }

            DataRow MyRow = (DataRow)gc.Tag;

            if (e.Data.GetDataPresent(typeof(DataRow)))
            {
                DataRow DropRow = (DataRow)e.Data.GetData(typeof(DataRow));
                if (MyRow["asase_code"] != DropRow["asase_code"] || MyRow["EmpID"] != DropRow["EmpID"] || MyRow["daycode"] != DropRow["daycode"] || MyRow["hasa_code"] != DropRow["hasa_code"])
                {
                    gcTable.Text = MyRow["emp_name"].ToString();
                    e.Effect = DragDropEffects.Move;
                    return;
                }
            }
            gcTable.Text = string.Empty;
            e.Effect = DragDropEffects.None;
        }
        private void groupControl_DragLeave(object sender, EventArgs e)
        {
            GroupControl gc = (GroupControl)sender;
            gc.Size = new Size(gc.Size.Width - gc.Size.Width * 15 / 100, gc.Size.Height - gc.Size.Height * 15 / 100);
            gcTable.Text = string.Empty;
        }
        private void groupControl_DragDrop(object sender, DragEventArgs e)
        {
            GroupControl gc = (GroupControl)sender;
            gc.Size = new Size(gc.Size.Width - gc.Size.Width * 15 / 100, gc.Size.Height - gc.Size.Height * 15 / 100);
            if (!e.Data.GetDataPresent(typeof(DataRow)))
                return;
            DataRow SourceRow = (DataRow)e.Data.GetData(typeof(DataRow));
            DataRow TargetRow;
            if (gc.Tag != null)
                TargetRow = (DataRow)gc.Tag;
            else
                TargetRow = null;

            if (MessageBox.Show("هل انت متأكد؟", "تحزير", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;

            //MessageBox.Show(String.Format("day {0}{1}Period {2}", gc.Text.Split(Convert.ToChar(";"))[0], Environment.NewLine, gc.Text.Split(Convert.ToChar(";"))[1]));
            if (ReplacePeriod(SourceRow, TargetRow, gc.Text.Split(Convert.ToChar(";"))[0], gc.Text.Split(Convert.ToChar(";"))[1]))
                dtData = LoadData(LUEEmp.EditValue);
            else
                MessageBox.Show("لم يتم الانتقال", "خطـــــــــاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private bool ReplacePeriod(DataRow Period1, DataRow Period2 = null, string daycode = "", string hasa_code = "")
        {
            bool ReturnMe = false;
            using (SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr))
            {
                SqlCommand cmd = new SqlCommand("", con);
                SqlTransaction trn = null;
                try
                {
                    con.Open();
                    trn = con.BeginTransaction();
                    cmd.Transaction = trn;
                    // Delete Period 1
                    cmd.CommandText = @"DELETE FROM gdw.TBLTimeTable WHERE asase_code = @asase_code AND EmpID = @EmpID AND daycode = @daycode AND hasa_code = @hasa_code";
                    cmd.Parameters.Add(new SqlParameter("@asase_code", SqlDbType.TinyInt) { Value = Period1["asase_code"] });
                    cmd.Parameters.Add(new SqlParameter("@EmpID", SqlDbType.Int) { Value = Period1["EmpID"] });
                    cmd.Parameters.Add(new SqlParameter("@daycode", SqlDbType.Int) { Value = Period1["daycode"] });
                    cmd.Parameters.Add(new SqlParameter("@hasa_code", SqlDbType.Int) { Value = Period1["hasa_code"] });
                    cmd.ExecuteNonQuery();

                    // Delete Period 2
                    if (Period2 != null)
                    {
                        cmd.Parameters["@asase_code"].Value = Period2["asase_code"];
                        cmd.Parameters["@EmpID"].Value = Period2["EmpID"];
                        cmd.Parameters["@daycode"].Value = Period2["daycode"];
                        cmd.Parameters["@hasa_code"].Value = Period2["hasa_code"];
                        cmd.ExecuteNonQuery(); // Delete Period 2
                    }

                    // Save Period 1
                    cmd.CommandText = @"INSERT INTO gdw.TBLTimeTable (asase_code, EmpID, alsofof_code, fasl_code, SubjectId, daycode, hasa_code, placecd)
                                        VALUES (@asase_code, @EmpID, @alsofof_code, @fasl_code, @SubjectId, @daycode, @hasa_code, @placecd)";
                    cmd.Parameters["@asase_code"].Value = Period1["asase_code"];
                    cmd.Parameters["@EmpID"].Value = Period1["EmpID"];
                    if (Period2 != null)
                    {
                        cmd.Parameters["@daycode"].Value = Period2["daycode"];
                        cmd.Parameters["@hasa_code"].Value = Period2["hasa_code"];
                    }
                    else
                    {
                        cmd.Parameters["@daycode"].Value = daycode;
                        cmd.Parameters["@hasa_code"].Value = hasa_code;
                    }
                    cmd.Parameters.Add(new SqlParameter("@alsofof_code", SqlDbType.TinyInt) { Value = Period1["alsofof_code"] });
                    cmd.Parameters.Add(new SqlParameter("@fasl_code", SqlDbType.TinyInt) { Value = Period1["fasl_code"] });
                    cmd.Parameters.Add(new SqlParameter("@SubjectId", SqlDbType.SmallInt) { Value = Period1["SubjectId"] });
                    cmd.Parameters.Add(new SqlParameter("@placecd", SqlDbType.TinyInt) { Value = Period1["placecd"] });
                    cmd.ExecuteNonQuery();

                    // Save Period 2
                    if (Period2 != null)
                    {
                        cmd.Parameters["@asase_code"].Value = Period2["asase_code"];
                        cmd.Parameters["@EmpID"].Value = Period2["EmpID"];
                        cmd.Parameters["@daycode"].Value = Period1["daycode"];
                        cmd.Parameters["@hasa_code"].Value = Period1["hasa_code"];
                        cmd.Parameters["@alsofof_code"].Value = Period2["alsofof_code"];
                        cmd.Parameters["@fasl_code"].Value = Period2["fasl_code"];
                        cmd.Parameters["@SubjectId"].Value = Period2["SubjectId"];
                        cmd.Parameters["@placecd"].Value = Period2["placecd"];
                        cmd.ExecuteNonQuery();
                    }
                    trn.Commit();
                    ReturnMe = true;
                }
                catch (SqlException ex)
                {
                    trn.Rollback();
                    Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                    Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
                }
                con.Close();
            }
            return ReturnMe;
        }
        
        #endregion
    }
}
