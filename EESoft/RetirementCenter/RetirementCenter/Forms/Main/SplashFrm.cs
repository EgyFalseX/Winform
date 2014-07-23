using System;
using System.Windows.Forms;
using System.Reflection;

namespace RetirementCenter
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
        public string AssemblyCopyright
        {
            get
            {
                return ((AssemblyCopyrightAttribute)Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(AssemblyCopyrightAttribute), false)).Copyright;

            }

        }
        private void SplashFrm_Load(object sender, EventArgs e)
        {
            LblProduct.Text = AssemblyProduct;
            LblVersion.Text = String.Format("Version {0}", AssemblyVersion);
            LblCopyright.Text = AssemblyCopyright;
            FadTMR.Interval = 30;
            FadTMR.Tick += new EventHandler(FadTmr_tick);
            FadTMR.Enabled = true;
            CloseTMR.Interval = 1000;
            CloseTMR.Tick += new EventHandler(CloseTmr_tick);
            CloseTMR.Enabled = true;
        }
        private void FadTmr_tick(object sender, EventArgs e)
        {
            if (Opacity < 1)
                Opacity += 0.029;
            else
            {
                Opacity = 1;
                FadTMR.Enabled = false;
            }
        }
        private void CloseTmr_tick(object sender, EventArgs e)
        {
            if (countdown != 5)
                countdown++;
            else
                Close();
        }
        private void SplashFrm_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }
        private void SplashFrm_KeyPress(object sender, KeyPressEventArgs e)
        {
            Close();
        }

        private void SplashFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FadTMR.Stop();
            CloseTMR.Stop();
        }
    }
}