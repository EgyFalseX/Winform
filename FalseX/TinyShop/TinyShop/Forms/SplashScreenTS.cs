using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;

namespace TinyShop.Forms
{
    public partial class SplashScreenTS : SplashScreen
    {
        public SplashScreenTS()
        {
            InitializeComponent();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            Close();
        }
    }
}