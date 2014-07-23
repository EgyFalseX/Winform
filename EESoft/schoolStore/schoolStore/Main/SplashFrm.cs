using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using DevExpress.XtraEditors;

namespace schoolStore
{
    public partial class SplashFrm : DevExpress.XtraEditors.XtraForm
    {
        private Timer FadTMR = new Timer();
        private Timer CloseTMR = new Timer();
        int countdown = 0;
        public SplashFrm()
        {
            InitializeComponent();
            
        }
        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }
        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }
        private void SplashFrm_Load(object sender, EventArgs e)
        {
            this.LblProduct.Text = AssemblyProduct;
            this.LblVersion.Text = String.Format("Version {0}", AssemblyVersion);
            FadTMR.Interval = 30;
            this.FadTMR.Tick += new System.EventHandler(this.FadTmr_tick);
            FadTMR.Enabled = true;
            CloseTMR.Interval = 1000;
            this.CloseTMR.Tick += new System.EventHandler(this.CloseTmr_tick);
            CloseTMR.Enabled = true;
        }
        private void FadTmr_tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
                this.Opacity += 0.029;
            else
            {
                this.Opacity = 1;
                FadTMR.Enabled = false;
            }
        }
        private void CloseTmr_tick(object sender, EventArgs e)
        {
            if (countdown != 5)
                countdown++;
            else
                this.Close();
        }
        private void SplashFrm_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
        private void SplashFrm_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.Close();
        }
    }
}