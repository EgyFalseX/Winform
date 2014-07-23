using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace ATCommands
{
    public static class msgbox
    {
        private static DevExpress.XtraBars.Alerter.AlertControl Alert = new DevExpress.XtraBars.Alerter.AlertControl() { AutoFormDelay = 4000 };
        private static FileStream fs = new FileStream(Application.StartupPath + @"\Log\" + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + 
            DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString() + ".log", FileMode.Create);
        public static void Show(string Msg, bool IsError, Form ThisForm, bool Popup = false)
        {
           //Msg.ToCharArray()
            byte[] byt = Encoding.UTF8.GetBytes(Msg + Environment.NewLine);
            fs.Write(byt, 0, byt.Length);
            fs.Flush();
            
            if (Popup)
            {
                DevExpress.XtraBars.Alerter.AlertInfo info = new DevExpress.XtraBars.Alerter.AlertInfo(Application.ProductName, Msg);
                if (IsError)
                    info.Image = Properties.Resources.error;
                else
                    info.Image = Properties.Resources.done;
                Alert.Show(ThisForm, info);
            }
        }
    }
}
