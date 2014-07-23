using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;

namespace NestleICSales.Forms.Main
{
    public partial class SplashScreenFrm : SplashScreen
    {
        public SplashScreenFrm()
        {
            InitializeComponent();
            ApplicationNameLable.Text = Application.ProductName;
        }
        #region Overrides
        public override void ProcessCommand(Enum cmd, object arg)
        {
            System.Threading.ThreadPool.QueueUserWorkItem((o) =>
            {
                try
                {
                    this.Invoke(new MethodInvoker(() =>
                    {
                        base.ProcessCommand(cmd, arg);
                        switch ((SplashScreenCommand)cmd)
                        {
                            case SplashScreenCommand.SetState:
                                lblState.Text = arg.ToString();
                                break;
                            default:
                                break;
                        }
                    }));
                }
                catch 
                {
                    
                }
                
            });
        }
        #endregion
        public enum SplashScreenCommand
        {
            SetState,
        }
    }
}