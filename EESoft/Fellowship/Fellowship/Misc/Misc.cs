using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fellowship.Misc
{
    public static class Misc
    {
        public static string ExceptionMessage(Exception ex)
        {
            string returnMe = string.Empty;
            switch (System.Runtime.InteropServices.Marshal.GetHRForException(ex))
            {
                case -2146232026://Column '' does not allow nulls.
                    returnMe = "بيانات رئيسيه فارغه. ارجو ادخال كل البيانات المطلوبه";
                    break;
                case -2147467262://Specified cast is not valid.
                    returnMe = "خطاء في تحويل الانواع. خطاء في طريقة ادخال تاريخ او رقم";
                    break;
                case -2147467261://Object reference not set to an instance of an object.
                    returnMe = "استخدام عنصر ليس له مرجع";
                    break;
                default:
                    break;
            }
            return returnMe;
        }
        public static void ShowPrintPreview(DevExpress.XtraReports.IReport report)
        {
            // Create a Print Tool and show the Print Preview form. 
            DevExpress.XtraReports.UI.ReportPrintTool printTool = new DevExpress.XtraReports.UI.ReportPrintTool(report);

            // Set watermark options.
            //printTool.PrintingSystem.Watermark.Image = Program.CompanyLogo;
            //printTool.PrintingSystem.Watermark.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            //printTool.PrintingSystem.Watermark.ImageTiling = false;
            //printTool.PrintingSystem.Watermark.ImageViewMode = DevExpress.XtraPrinting.Drawing.ImageViewMode.Stretch;
            //printTool.PrintingSystem.Watermark.ImageTransparency = 150;
            //printTool.PrintingSystem.Watermark.ShowBehind = false;
            //printTool.PrintingSystem.Watermark.PageRange = "1";
            printTool.ShowRibbonPreviewDialog();
        }
        public static List<object> IDExtraction(string ID)
        {
            List<object> outPut = new List<object>();

            float Type = FXFW.SqlDB.ConvertStringToInt(ID.ToString().Substring(12, 1));
            if ((Type % 2) == 0)
                outPut.Add(2);//female
            else
                outPut.Add(1);//male

            //get birth day
            int day = Convert.ToInt32(ID.ToString().Substring(5, 2));
            int month = Convert.ToInt32(ID.ToString().Substring(3, 2));
            int year = 0;
            if (ID.ToString().Substring(0, 1) == "2")
                year += Convert.ToInt32("19" + ID.ToString().Substring(1, 2));
            else
                year += Convert.ToInt32("20" + ID.ToString().Substring(1, 2));
            outPut.Add(new DateTime(year, month, day));

            //get the birth state
            outPut.Add(Convert.ToInt32(ID.ToString().Substring(7, 2)));

            return outPut;
        }
        public static int CalcAge(DateTime birthdate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthdate.Year;
            if (birthdate > today.AddYears(-age)) age--;
            return age;
        }

    }
}
