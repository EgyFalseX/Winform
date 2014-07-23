using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using System.Windows.Forms;


namespace Members
{
    public partial class XRepMemCard : DevExpress.XtraReports.UI.XtraReport
    {
        public XRepMemCard()
        {
            InitializeComponent();
        }
        private void CustomFont()
        {
            Font customFont = Members.Misc.Misc.LoadCustomFont(Properties.Resources.SULTAN_BOOLD);
            xrTable3.Font = customFont;
            xrTable2.Font = customFont;
            xrTable1.Font = customFont;
            xrTable4.Font = customFont;
            xrTable5.Font = customFont;
            xrTable6.Font = customFont;
            xrTable7.Font = customFont;
        }
        public void LoadDataSource(DataTable dt, bool Repley)
        {
            //if (MessageBox.Show("هل تريد استخدام نوع كتابة خاص؟", "Font Selection",  MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            //    CustomFont();

            this.FilterString = "[checkforprint] = True";
            this.DataAdapter = null; this.DataMember = string.Empty;
            this.DataSource = dt;
            xrPBImg.DataBindings.Add("ImageUrl", this.DataSource, "img");
            lblRepley.Visible = Repley;
        }

    }
}
