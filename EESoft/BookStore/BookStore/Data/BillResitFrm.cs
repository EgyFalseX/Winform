using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace BookStore
{
    public partial class BillResitFrm : DevExpress.XtraEditors.XtraForm
    {
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
        private Bitmap memoryImage;
        public BillResitFrm(string StoreTrID, string StoreTrIDDAY, string StoreTrIDTYPE, string StoreTrDate, string PERSONID, string Total, string Payed)
        {
            InitializeComponent();
            DataTable dt = FXFW.SqlDB.LoadDataTable("SELECT Company FROM CDCompany");
            if (dt.Rows.Count > 0)
                LblCompany.Text = dt.Rows[0]["Company"].ToString();
            else
                LblCompany.Text = string.Empty;
            LblStoreTrIDDAY.Text = StoreTrIDDAY;
            LblStoreTrIDTYPE.Text = StoreTrIDTYPE;
            LblStoreTrDate.Text = StoreTrDate;
            LblPERSONID.Text = PERSONID;
            LblTotal.Text = Total;
            LblPayed.Text = Payed;
            DGVItems.DataSource = FXFW.SqlDB.LoadDataTable(@"Select Price, (Select SanfName From CDASNAF Where SanfID = StoreTransactionDetailes.SanfID) AS SanfName 
            From StoreTransactionDetailes Where StoreTrID = " + StoreTrID);
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
        private void BillResitFrm_Load(object sender, EventArgs e)
        {
            TmrPrint.Start();
        }
        private void printDocument_PrintPage(System.Object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 284, 471);
        }
        private void TmrPrint_Tick(object sender, EventArgs e)
        {
            pnlPrint.Visible = false;
            TmrPrint.Enabled = false;

            using (System.Drawing.Printing.PrintDocument printDocument = new System.Drawing.Printing.PrintDocument())
            {
                printDocument.PrintPage += printDocument_PrintPage;
                CaptureScreen();
                try
                { 
                    
                    PrintDialog dlg = new PrintDialog();
                    dlg.Document = printDocument;
                    dlg.PrinterSettings.Copies = 3;
                    if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        printDocument.PrinterSettings = dlg.PrinterSettings;
                        printDocument.Print();
                    }
                    else
                    {
                        pnlPrint.Visible = true;
                        return;
                    }
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,MessageBoxIcon.Error); }
            }
            Close();
            pnlPrint.Visible = true;
            
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            TmrPrint.Start();
        }
    }
}