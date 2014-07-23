using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace Cards
{
    public partial class XRepCardBack : DevExpress.XtraReports.UI.XtraReport
    {
        public XRepCardBack(string Saf, string Fasl)
        {
            InitializeComponent();

            dATATableAdapter.Fill(dsCards1.DATA, Saf, Fasl);

            if (System.IO.File.Exists(Program.LogoPath))
            {
                xrPBLogo.ImageUrl = Program.LogoPath;
            }
        }
    }
}
