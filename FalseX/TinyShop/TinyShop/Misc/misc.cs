using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace TinyShop.Misc
{
    class misc
    {
        public class MyLocalizer : DevExpress.XtraGrid.Localization.GridLocalizer
        {
            public override string GetLocalizedString(DevExpress.XtraGrid.Localization.GridStringId id)
            {
                if (id == DevExpress.XtraGrid.Localization.GridStringId.ColumnViewExceptionMessage)
                    return ", هل تريد تصحيح الخطاء؟";
                return base.GetLocalizedString(id);
            }
        }
        public static void LoadStartupArgs(string[] args)
        {
            //System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(System.Globalization.CultureInfo.CurrentCulture.Name);
            //System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(System.Globalization.CultureInfo.CurrentCulture.Name);
            try
            {
                foreach (string item in args)
                {
                    if (item.ToLower().StartsWith("lang="))// Language
                    {
                        // The following line provides localization for data formats. 
                        //System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(item.Substring(5));
                        // The following line provides localization for the application's user interface. 
                        System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(item.Substring(5));

                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message , ex.HelpLink, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            
        }
    }
}
