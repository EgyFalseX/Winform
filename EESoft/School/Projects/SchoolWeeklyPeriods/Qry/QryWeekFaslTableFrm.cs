using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections;

namespace SchoolWeeklyPeriods
{
    public partial class QryWeekFaslTableFrm : DevExpress.XtraEditors.XtraForm
    {
              
        #region -   Variables   -
        private DataTable dtData = new DataTable();
        private Bitmap memoryImage;
        #endregion
        #region -   Functions   -
        public QryWeekFaslTableFrm()
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
          System.Int32 dwRop  // raster operation code
          );
        private void LoadDefaultData()
        {
            LUESaf.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"Select alsofof_code, alsofof_name, alsofof_name_e From CDAlsofof");
            LUESaf.Properties.DisplayMember = "alsofof_name";
            LUESaf.Properties.ValueMember = "alsofof_code";

            LUEFasl.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"Select fasl_code, fasl_name, fasl_name_e From CDEFasl");
            LUEFasl.Properties.DisplayMember = "fasl_name";
            LUEFasl.Properties.ValueMember = "fasl_code";
        }
        private string SearchSub(string daycode, string hasa_code)
        {
            string ReturnMe = "-";
            for (int i = 0; i < dtData.Rows.Count; i++)
            {
                if (dtData.Rows[i]["daycode"].ToString() == daycode && dtData.Rows[i]["hasa_code"].ToString() == hasa_code)
                    ReturnMe = dtData.Rows[i]["Subject"].ToString();
            }
            return ReturnMe;
        }
        private System.Drawing.Color GetSubColor(string LableString)
        {
            System.Drawing.Color ReturnedColor = new Color();
            if (LableString == "-")
                ReturnedColor = colorEEmpty.Color;
            else
                ReturnedColor = System.Drawing.Color.White;
          
            return ReturnedColor;
        }
        private string SearchEmp(string daycode, string hasa_code)
        {
            string ReturnMe = "-";
            int repeted = 0;
            for (int i = 0; i < dtData.Rows.Count; i++)
            {
                if (dtData.Rows[i]["daycode"].ToString() == daycode && dtData.Rows[i]["hasa_code"].ToString() == hasa_code)
                {
                    if (repeted == 0)
                    {
                        ReturnMe = dtData.Rows[i]["emp_name"].ToString();
                        repeted++;
                    }
                    else
                    {
                        ReturnMe += " // " + dtData.Rows[i]["emp_name"].ToString();
                    }
                }
            }
            return ReturnMe;
        }
        private System.Drawing.Color GetEmpColor(string LableString, object PrivPeriod)
        {
            System.Drawing.Color ReturnedColor = new Color();

            if (LableString.Contains("//"))
            {
                ReturnedColor = System.Drawing.Color.Red;
                return ReturnedColor;
            }
            if (LableString == "-")
            {
                ReturnedColor = colorEEmpty.Color;
                return ReturnedColor;
            }
            if (LableString != "-")
            {
                if (PrivPeriod == null)
                    ReturnedColor = System.Drawing.Color.White;
                else if (((LabelControl)PrivPeriod).Text == LableString)
                {
                    ReturnedColor = colorEDouble.Color;
                    ((LabelControl)PrivPeriod).BackColor = colorEDouble.Color;
                }
            }

            return ReturnedColor;
        }

        private void ClearLables()
        {
            //السبت
            lbl11Sub.Text = "-";
            lbl12Sub.Text = "-";
            lbl13Sub.Text = "-";
            lbl14Sub.Text = "-";
            lbl15Sub.Text = "-";
            lbl16Sub.Text = "-";
            lbl17Sub.Text = "-";
            lbl18Sub.Text = "-";
            lbl19Sub.Text = "-";

            lbl11Emp.Text = "-";
            lbl12Emp.Text = "-";
            lbl13Emp.Text = "-";
            lbl14Emp.Text = "-";
            lbl15Emp.Text = "-";
            lbl16Emp.Text = "-";
            lbl17Emp.Text = "-";
            lbl18Emp.Text = "-";
            lbl19Emp.Text = "-";
            //الاحد
            lbl21Sub.Text = "-";
            lbl22Sub.Text = "-";
            lbl23Sub.Text = "-";
            lbl24Sub.Text = "-";
            lbl25Sub.Text = "-";
            lbl26Sub.Text = "-";
            lbl27Sub.Text = "-";
            lbl28Sub.Text = "-";
            lbl29Sub.Text = "-";

            lbl21Emp.Text = "-";
            lbl22Emp.Text = "-";
            lbl23Emp.Text = "-";
            lbl24Emp.Text = "-";
            lbl25Emp.Text = "-";
            lbl26Emp.Text = "-";
            lbl27Emp.Text = "-";
            lbl28Emp.Text = "-";
            lbl29Emp.Text = "-";
            //الاثنين
            lbl31Sub.Text = "-";
            lbl32Sub.Text = "-";
            lbl33Sub.Text = "-";
            lbl34Sub.Text = "-";
            lbl35Sub.Text = "-";
            lbl36Sub.Text = "-";
            lbl37Sub.Text = "-";
            lbl38Sub.Text = "-";
            lbl39Sub.Text = "-";

            lbl31Emp.Text = "-";
            lbl32Emp.Text = "-";
            lbl33Emp.Text = "-";
            lbl34Emp.Text = "-";
            lbl35Emp.Text = "-";
            lbl36Emp.Text = "-";
            lbl37Emp.Text = "-";
            lbl38Emp.Text = "-";
            lbl39Emp.Text = "-";
            //الثلاثاء
            lbl41Sub.Text = "-";
            lbl42Sub.Text = "-";
            lbl43Sub.Text = "-";
            lbl44Sub.Text = "-";
            lbl45Sub.Text = "-";
            lbl46Sub.Text = "-";
            lbl47Sub.Text = "-";
            lbl48Sub.Text = "-";
            lbl49Sub.Text = "-";

            lbl41Emp.Text = "-";
            lbl42Emp.Text = "-";
            lbl43Emp.Text = "-";
            lbl44Emp.Text = "-";
            lbl45Emp.Text = "-";
            lbl46Emp.Text = "-";
            lbl47Emp.Text = "-";
            lbl48Emp.Text = "-";
            lbl49Emp.Text = "-";
            //الاربعاء
            lbl51Sub.Text = "-";
            lbl52Sub.Text = "-";
            lbl53Sub.Text = "-";
            lbl54Sub.Text = "-";
            lbl55Sub.Text = "-";
            lbl56Sub.Text = "-";
            lbl57Sub.Text = "-";
            lbl58Sub.Text = "-";
            lbl59Sub.Text = "-";

            lbl51Emp.Text = "-";
            lbl52Emp.Text = "-";
            lbl53Emp.Text = "-";
            lbl54Emp.Text = "-";
            lbl55Emp.Text = "-";
            lbl56Emp.Text = "-";
            lbl57Emp.Text = "-";
            lbl58Emp.Text = "-";
            lbl59Emp.Text = "-";
            //الخميس
            lbl61Sub.Text = "-";
            lbl62Sub.Text = "-";
            lbl63Sub.Text = "-";
            lbl64Sub.Text = "-";
            lbl65Sub.Text = "-";
            lbl66Sub.Text = "-";
            lbl67Sub.Text = "-";
            lbl68Sub.Text = "-";
            lbl69Sub.Text = "-";

            lbl61Emp.Text = "-";
            lbl62Emp.Text = "-";
            lbl63Emp.Text = "-";
            lbl64Emp.Text = "-";
            lbl65Emp.Text = "-";
            lbl66Emp.Text = "-";
            lbl67Emp.Text = "-";
            lbl68Emp.Text = "-";
            lbl69Emp.Text = "-";
            //الجمعه
            lbl71Sub.Text = "-";
            lbl72Sub.Text = "-";
            lbl73Sub.Text = "-";
            lbl74Sub.Text = "-";
            lbl75Sub.Text = "-";
            lbl76Sub.Text = "-";
            lbl77Sub.Text = "-";
            lbl78Sub.Text = "-";
            lbl79Sub.Text = "-";

            lbl71Emp.Text = "-";
            lbl72Emp.Text = "-";
            lbl73Emp.Text = "-";
            lbl74Emp.Text = "-";
            lbl75Emp.Text = "-";
            lbl76Emp.Text = "-";
            lbl77Emp.Text = "-";
            lbl78Emp.Text = "-";
            lbl79Emp.Text = "-";
        }
        private void FillLables()
        {
            //السبت
            lbl11Sub.Text = SearchSub("1", "1"); lbl11Sub.BackColor = GetSubColor(lbl11Sub.Text);
            lbl12Sub.Text = SearchSub("1", "2"); lbl12Sub.BackColor = GetSubColor(lbl12Sub.Text);
            lbl13Sub.Text = SearchSub("1", "3"); lbl13Sub.BackColor = GetSubColor(lbl13Sub.Text);
            lbl14Sub.Text = SearchSub("1", "4"); lbl14Sub.BackColor = GetSubColor(lbl14Sub.Text);
            lbl15Sub.Text = SearchSub("1", "5"); lbl15Sub.BackColor = GetSubColor(lbl15Sub.Text);
            lbl16Sub.Text = SearchSub("1", "6"); lbl16Sub.BackColor = GetSubColor(lbl16Sub.Text);
            lbl17Sub.Text = SearchSub("1", "7"); lbl17Sub.BackColor = GetSubColor(lbl17Sub.Text);
            lbl18Sub.Text = SearchSub("1", "8"); lbl18Sub.BackColor = GetSubColor(lbl18Sub.Text);
            lbl19Sub.Text = SearchSub("1", "9"); lbl19Sub.BackColor = GetSubColor(lbl19Sub.Text);

            lbl11Emp.Text = SearchEmp("1", "1"); lbl11Emp.BackColor = GetEmpColor(lbl11Emp.Text, null);
            lbl12Emp.Text = SearchEmp("1", "2"); lbl12Emp.BackColor = GetEmpColor(lbl12Emp.Text, lbl11Emp);
            lbl13Emp.Text = SearchEmp("1", "3"); lbl13Emp.BackColor = GetEmpColor(lbl13Emp.Text, lbl12Emp);
            lbl14Emp.Text = SearchEmp("1", "4"); lbl14Emp.BackColor = GetEmpColor(lbl14Emp.Text, lbl13Emp);
            lbl15Emp.Text = SearchEmp("1", "5"); lbl15Emp.BackColor = GetEmpColor(lbl15Emp.Text, lbl14Emp);
            lbl16Emp.Text = SearchEmp("1", "6"); lbl16Emp.BackColor = GetEmpColor(lbl16Emp.Text, lbl15Emp);
            lbl17Emp.Text = SearchEmp("1", "7"); lbl17Emp.BackColor = GetEmpColor(lbl17Emp.Text, lbl16Emp);
            lbl18Emp.Text = SearchEmp("1", "8"); lbl18Emp.BackColor = GetEmpColor(lbl18Emp.Text, lbl17Emp);
            lbl19Emp.Text = SearchEmp("1", "9"); lbl19Emp.BackColor = GetEmpColor(lbl19Emp.Text, lbl18Emp);
            //الاحد
            lbl21Sub.Text = SearchSub("2", "1"); lbl21Sub.BackColor = GetSubColor(lbl21Sub.Text);
            lbl22Sub.Text = SearchSub("2", "2"); lbl22Sub.BackColor = GetSubColor(lbl22Sub.Text);
            lbl23Sub.Text = SearchSub("2", "3"); lbl23Sub.BackColor = GetSubColor(lbl23Sub.Text);
            lbl24Sub.Text = SearchSub("2", "4"); lbl24Sub.BackColor = GetSubColor(lbl24Sub.Text);
            lbl25Sub.Text = SearchSub("2", "5"); lbl25Sub.BackColor = GetSubColor(lbl25Sub.Text);
            lbl26Sub.Text = SearchSub("2", "6"); lbl26Sub.BackColor = GetSubColor(lbl26Sub.Text);
            lbl27Sub.Text = SearchSub("2", "7"); lbl27Sub.BackColor = GetSubColor(lbl27Sub.Text);
            lbl28Sub.Text = SearchSub("2", "8"); lbl28Sub.BackColor = GetSubColor(lbl28Sub.Text);
            lbl29Sub.Text = SearchSub("2", "9"); lbl29Sub.BackColor = GetSubColor(lbl29Sub.Text);

            lbl21Emp.Text = SearchEmp("2", "1"); lbl21Emp.BackColor = GetEmpColor(lbl21Emp.Text, null);
            lbl22Emp.Text = SearchEmp("2", "2"); lbl22Emp.BackColor = GetEmpColor(lbl22Emp.Text, lbl21Emp);
            lbl23Emp.Text = SearchEmp("2", "3"); lbl23Emp.BackColor = GetEmpColor(lbl23Emp.Text, lbl22Emp);
            lbl24Emp.Text = SearchEmp("2", "4"); lbl24Emp.BackColor = GetEmpColor(lbl24Emp.Text, lbl23Emp);
            lbl25Emp.Text = SearchEmp("2", "5"); lbl25Emp.BackColor = GetEmpColor(lbl25Emp.Text, lbl24Emp);
            lbl26Emp.Text = SearchEmp("2", "6"); lbl26Emp.BackColor = GetEmpColor(lbl26Emp.Text, lbl25Emp);
            lbl27Emp.Text = SearchEmp("2", "7"); lbl27Emp.BackColor = GetEmpColor(lbl27Emp.Text, lbl26Emp);
            lbl28Emp.Text = SearchEmp("2", "8"); lbl28Emp.BackColor = GetEmpColor(lbl28Emp.Text, lbl27Emp);
            lbl29Emp.Text = SearchEmp("2", "9"); lbl29Emp.BackColor = GetEmpColor(lbl29Emp.Text, lbl28Emp);
            //الاثنين
            lbl31Sub.Text = SearchSub("3", "1"); lbl31Sub.BackColor = GetSubColor(lbl31Sub.Text);
            lbl32Sub.Text = SearchSub("3", "2"); lbl32Sub.BackColor = GetSubColor(lbl32Sub.Text);
            lbl33Sub.Text = SearchSub("3", "3"); lbl33Sub.BackColor = GetSubColor(lbl33Sub.Text);
            lbl34Sub.Text = SearchSub("3", "4"); lbl34Sub.BackColor = GetSubColor(lbl34Sub.Text);
            lbl35Sub.Text = SearchSub("3", "5"); lbl35Sub.BackColor = GetSubColor(lbl35Sub.Text);
            lbl36Sub.Text = SearchSub("3", "6"); lbl36Sub.BackColor = GetSubColor(lbl36Sub.Text);
            lbl37Sub.Text = SearchSub("3", "7"); lbl37Sub.BackColor = GetSubColor(lbl37Sub.Text);
            lbl38Sub.Text = SearchSub("3", "8"); lbl38Sub.BackColor = GetSubColor(lbl38Sub.Text);
            lbl39Sub.Text = SearchSub("3", "9"); lbl39Sub.BackColor = GetSubColor(lbl39Sub.Text);

            lbl31Emp.Text = SearchEmp("3", "1"); lbl31Emp.BackColor = GetEmpColor(lbl31Emp.Text, null);
            lbl32Emp.Text = SearchEmp("3", "2"); lbl32Emp.BackColor = GetEmpColor(lbl32Emp.Text, lbl31Emp);
            lbl33Emp.Text = SearchEmp("3", "3"); lbl33Emp.BackColor = GetEmpColor(lbl33Emp.Text, lbl32Emp);
            lbl34Emp.Text = SearchEmp("3", "4"); lbl34Emp.BackColor = GetEmpColor(lbl34Emp.Text, lbl33Emp);
            lbl35Emp.Text = SearchEmp("3", "5"); lbl35Emp.BackColor = GetEmpColor(lbl35Emp.Text, lbl34Emp);
            lbl36Emp.Text = SearchEmp("3", "6"); lbl36Emp.BackColor = GetEmpColor(lbl36Emp.Text, lbl35Emp);
            lbl37Emp.Text = SearchEmp("3", "7"); lbl37Emp.BackColor = GetEmpColor(lbl37Emp.Text, lbl36Emp);
            lbl38Emp.Text = SearchEmp("3", "8"); lbl38Emp.BackColor = GetEmpColor(lbl38Emp.Text, lbl37Emp);
            lbl39Emp.Text = SearchEmp("3", "9"); lbl39Emp.BackColor = GetEmpColor(lbl39Emp.Text, lbl38Emp);
            //الثلاثاء
            lbl41Sub.Text = SearchSub("4", "1"); lbl41Sub.BackColor = GetSubColor(lbl41Sub.Text);
            lbl42Sub.Text = SearchSub("4", "2"); lbl42Sub.BackColor = GetSubColor(lbl42Sub.Text);
            lbl43Sub.Text = SearchSub("4", "3"); lbl43Sub.BackColor = GetSubColor(lbl43Sub.Text);
            lbl44Sub.Text = SearchSub("4", "4"); lbl44Sub.BackColor = GetSubColor(lbl44Sub.Text);
            lbl45Sub.Text = SearchSub("4", "5"); lbl45Sub.BackColor = GetSubColor(lbl45Sub.Text);
            lbl46Sub.Text = SearchSub("4", "6"); lbl46Sub.BackColor = GetSubColor(lbl46Sub.Text);
            lbl47Sub.Text = SearchSub("4", "7"); lbl47Sub.BackColor = GetSubColor(lbl47Sub.Text);
            lbl48Sub.Text = SearchSub("4", "8"); lbl48Sub.BackColor = GetSubColor(lbl48Sub.Text);
            lbl49Sub.Text = SearchSub("4", "9"); lbl49Sub.BackColor = GetSubColor(lbl49Sub.Text);

            lbl41Emp.Text = SearchEmp("4", "1"); lbl41Emp.BackColor = GetEmpColor(lbl41Emp.Text, null);
            lbl42Emp.Text = SearchEmp("4", "2"); lbl42Emp.BackColor = GetEmpColor(lbl42Emp.Text, lbl41Emp);
            lbl43Emp.Text = SearchEmp("4", "3"); lbl43Emp.BackColor = GetEmpColor(lbl43Emp.Text, lbl42Emp);
            lbl44Emp.Text = SearchEmp("4", "4"); lbl44Emp.BackColor = GetEmpColor(lbl44Emp.Text, lbl43Emp);
            lbl45Emp.Text = SearchEmp("4", "5"); lbl45Emp.BackColor = GetEmpColor(lbl45Emp.Text, lbl44Emp);
            lbl46Emp.Text = SearchEmp("4", "6"); lbl46Emp.BackColor = GetEmpColor(lbl46Emp.Text, lbl45Emp);
            lbl47Emp.Text = SearchEmp("4", "7"); lbl47Emp.BackColor = GetEmpColor(lbl47Emp.Text, lbl46Emp);
            lbl48Emp.Text = SearchEmp("4", "8"); lbl48Emp.BackColor = GetEmpColor(lbl48Emp.Text, lbl47Emp);
            lbl49Emp.Text = SearchEmp("4", "9"); lbl49Emp.BackColor = GetEmpColor(lbl49Emp.Text, lbl48Emp);
            //الاربعاء
            lbl51Sub.Text = SearchSub("5", "1"); lbl51Sub.BackColor = GetSubColor(lbl51Sub.Text);
            lbl52Sub.Text = SearchSub("5", "2"); lbl52Sub.BackColor = GetSubColor(lbl52Sub.Text);
            lbl53Sub.Text = SearchSub("5", "3"); lbl53Sub.BackColor = GetSubColor(lbl53Sub.Text);
            lbl54Sub.Text = SearchSub("5", "4"); lbl54Sub.BackColor = GetSubColor(lbl54Sub.Text);
            lbl55Sub.Text = SearchSub("5", "5"); lbl55Sub.BackColor = GetSubColor(lbl55Sub.Text);
            lbl56Sub.Text = SearchSub("5", "6"); lbl56Sub.BackColor = GetSubColor(lbl56Sub.Text);
            lbl57Sub.Text = SearchSub("5", "7"); lbl57Sub.BackColor = GetSubColor(lbl57Sub.Text);
            lbl58Sub.Text = SearchSub("5", "8"); lbl58Sub.BackColor = GetSubColor(lbl58Sub.Text);
            lbl59Sub.Text = SearchSub("5", "9"); lbl59Sub.BackColor = GetSubColor(lbl59Sub.Text);

            lbl51Emp.Text = SearchEmp("5", "1"); lbl51Emp.BackColor = GetEmpColor(lbl51Emp.Text, null);
            lbl52Emp.Text = SearchEmp("5", "2"); lbl52Emp.BackColor = GetEmpColor(lbl52Emp.Text, lbl51Emp);
            lbl53Emp.Text = SearchEmp("5", "3"); lbl53Emp.BackColor = GetEmpColor(lbl53Emp.Text, lbl52Emp);
            lbl54Emp.Text = SearchEmp("5", "4"); lbl54Emp.BackColor = GetEmpColor(lbl54Emp.Text, lbl53Emp);
            lbl55Emp.Text = SearchEmp("5", "5"); lbl55Emp.BackColor = GetEmpColor(lbl55Emp.Text, lbl54Emp);
            lbl56Emp.Text = SearchEmp("5", "6"); lbl56Emp.BackColor = GetEmpColor(lbl56Emp.Text, lbl55Emp);
            lbl57Emp.Text = SearchEmp("5", "7"); lbl57Emp.BackColor = GetEmpColor(lbl57Emp.Text, lbl56Emp);
            lbl58Emp.Text = SearchEmp("5", "8"); lbl58Emp.BackColor = GetEmpColor(lbl58Emp.Text, lbl57Emp);
            lbl59Emp.Text = SearchEmp("5", "9"); lbl59Emp.BackColor = GetEmpColor(lbl59Emp.Text, lbl58Emp);
            //الخميس
            lbl61Sub.Text = SearchSub("6", "1"); lbl61Sub.BackColor = GetSubColor(lbl61Sub.Text);
            lbl62Sub.Text = SearchSub("6", "2"); lbl62Sub.BackColor = GetSubColor(lbl62Sub.Text);
            lbl63Sub.Text = SearchSub("6", "3"); lbl63Sub.BackColor = GetSubColor(lbl63Sub.Text);
            lbl64Sub.Text = SearchSub("6", "4"); lbl64Sub.BackColor = GetSubColor(lbl64Sub.Text);
            lbl65Sub.Text = SearchSub("6", "5"); lbl65Sub.BackColor = GetSubColor(lbl65Sub.Text);
            lbl66Sub.Text = SearchSub("6", "6"); lbl66Sub.BackColor = GetSubColor(lbl66Sub.Text);
            lbl67Sub.Text = SearchSub("6", "7"); lbl67Sub.BackColor = GetSubColor(lbl67Sub.Text);
            lbl68Sub.Text = SearchSub("6", "8"); lbl68Sub.BackColor = GetSubColor(lbl68Sub.Text);
            lbl69Sub.Text = SearchSub("6", "9"); lbl69Sub.BackColor = GetSubColor(lbl69Sub.Text);

            lbl61Emp.Text = SearchEmp("6", "1"); lbl61Emp.BackColor = GetEmpColor(lbl61Emp.Text, null);
            lbl62Emp.Text = SearchEmp("6", "2"); lbl62Emp.BackColor = GetEmpColor(lbl62Emp.Text, lbl61Emp);
            lbl63Emp.Text = SearchEmp("6", "3"); lbl63Emp.BackColor = GetEmpColor(lbl63Emp.Text, lbl62Emp);
            lbl64Emp.Text = SearchEmp("6", "4"); lbl64Emp.BackColor = GetEmpColor(lbl64Emp.Text, lbl63Emp);
            lbl65Emp.Text = SearchEmp("6", "5"); lbl65Emp.BackColor = GetEmpColor(lbl65Emp.Text, lbl64Emp);
            lbl66Emp.Text = SearchEmp("6", "6"); lbl66Emp.BackColor = GetEmpColor(lbl66Emp.Text, lbl65Emp);
            lbl67Emp.Text = SearchEmp("6", "7"); lbl67Emp.BackColor = GetEmpColor(lbl67Emp.Text, lbl66Emp);
            lbl68Emp.Text = SearchEmp("6", "8"); lbl68Emp.BackColor = GetEmpColor(lbl68Emp.Text, lbl67Emp);
            lbl69Emp.Text = SearchEmp("6", "9"); lbl69Emp.BackColor = GetEmpColor(lbl69Emp.Text, lbl68Emp);
            //الجمعه
            lbl71Sub.Text = SearchSub("7", "1"); lbl71Sub.BackColor = GetSubColor(lbl71Sub.Text);
            lbl72Sub.Text = SearchSub("7", "2"); lbl72Sub.BackColor = GetSubColor(lbl72Sub.Text);
            lbl73Sub.Text = SearchSub("7", "3"); lbl73Sub.BackColor = GetSubColor(lbl73Sub.Text);
            lbl74Sub.Text = SearchSub("7", "4"); lbl74Sub.BackColor = GetSubColor(lbl74Sub.Text);
            lbl75Sub.Text = SearchSub("7", "5"); lbl75Sub.BackColor = GetSubColor(lbl75Sub.Text);
            lbl76Sub.Text = SearchSub("7", "6"); lbl76Sub.BackColor = GetSubColor(lbl76Sub.Text);
            lbl77Sub.Text = SearchSub("7", "7"); lbl77Sub.BackColor = GetSubColor(lbl77Sub.Text);
            lbl78Sub.Text = SearchSub("7", "8"); lbl78Sub.BackColor = GetSubColor(lbl78Sub.Text);
            lbl79Sub.Text = SearchSub("7", "9"); lbl79Sub.BackColor = GetSubColor(lbl79Sub.Text);

            lbl71Emp.Text = SearchEmp("7", "1"); lbl71Emp.BackColor = GetEmpColor(lbl71Emp.Text, null);
            lbl72Emp.Text = SearchEmp("7", "2"); lbl72Emp.BackColor = GetEmpColor(lbl72Emp.Text, lbl71Emp);
            lbl73Emp.Text = SearchEmp("7", "3"); lbl73Emp.BackColor = GetEmpColor(lbl73Emp.Text, lbl72Emp);
            lbl74Emp.Text = SearchEmp("7", "4"); lbl74Emp.BackColor = GetEmpColor(lbl74Emp.Text, lbl73Emp);
            lbl75Emp.Text = SearchEmp("7", "5"); lbl75Emp.BackColor = GetEmpColor(lbl75Emp.Text, lbl74Emp);
            lbl76Emp.Text = SearchEmp("7", "6"); lbl76Emp.BackColor = GetEmpColor(lbl76Emp.Text, lbl75Emp);
            lbl77Emp.Text = SearchEmp("7", "7"); lbl77Emp.BackColor = GetEmpColor(lbl77Emp.Text, lbl76Emp);
            lbl78Emp.Text = SearchEmp("7", "8"); lbl78Emp.BackColor = GetEmpColor(lbl78Emp.Text, lbl77Emp);
            lbl79Emp.Text = SearchEmp("7", "9"); lbl79Emp.BackColor = GetEmpColor(lbl79Emp.Text, lbl78Emp);
        }
        private void CaptureScreen()
        {
            Graphics mygraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, mygraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            IntPtr dc1 = mygraphics.GetHdc();
            IntPtr dc2 = memoryGraphics.GetHdc();
            BitBlt(dc2, 0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height, dc1, 0, 0, 13369376);
            mygraphics.ReleaseHdc(dc1);
            memoryGraphics.ReleaseHdc(dc2);
        }
        #endregion
        #region -   Event Handlers   -
        private void WeekTeacherTableFrm_Load(object sender, EventArgs e)
        {
            LoadDefaultData();
        }
        private void LUE_EditValueChanged(object sender, EventArgs e)
        {
            ClearLables();
            if (FXFW.SqlDB.IsNullOrEmpty(LUESaf.EditValue) || FXFW.SqlDB.IsNullOrEmpty(LUEFasl.EditValue))
                return;

            dtData = FXFW.SqlDB.LoadDataTable(string.Format(@"SELECT asase_code, daycode, hasa_code, alsofof_code, fasl_code, SubjectId,
            (select Subject from CD_Subject where SubjectId = gdw.TBLTimeTable.SubjectId) AS Subject,
            (Select ISNULL(EMP_FIRST_NAME, '') + ' ' + ISNULL(EMP_FATHER_NAME, '') + ' ' + ISNULL(EMP_FAM_NAME, '') + ' ' + ISNULL(EMP_FOURTH_NAME, '') From TBL_Emp Where EmpID = gdw.TBLTimeTable.EmpID) AS emp_name
            FROM gdw.TBLTimeTable
            WHERE (asase_code = {0}) AND (alsofof_code = {1}) AND (fasl_code = {2})", FXFW.SqlDB.asase_code, LUESaf.EditValue, LUEFasl.EditValue));

            lblPeriodCount.Text = "عدد الحصص :  " + dtData.Rows.Count;
            FillLables();
        }
        private void printDocument_PrintPage(System.Object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //e.PageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Fx", 1500, 1500);
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            gcOptions.Visible = false;

            using (System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument())
            {
                printDocument.PrintPage += printDocument_PrintPage;
                printDocument.DefaultPageSettings.Landscape = true;
                printDocument.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("FalseX", 500, 1165);
                //resize
                this.Size = new System.Drawing.Size(1126, 506);
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
            gcOptions.Visible = true;
            this.Size = new System.Drawing.Size(1126, 616);
        }
        #endregion

    }
}