using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting.BarCode;

namespace schoolStore
{
    public partial class QryBarcodeFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Functions   -
        private int GetWidth()
        {
            int ReturnMe = 0;
            if (cbW.Checked)
                ReturnMe = Convert.ToInt32(FXFW.SqlDB.ConvertStringToInt(tbW.Text));
            else
                ReturnMe = (11 * lueItems.EditValue.ToString().Length) + 90;
            //(11 * lueItems.EditValue.ToString().Length) + 66
            return ReturnMe;
        }
        private int GetHeight()
        {
            int ReturnMe = 0;
            if (cbH.Checked)
                ReturnMe = Convert.ToInt32(FXFW.SqlDB.ConvertStringToInt(tbH.Text));
            else
                ReturnMe = 50;
            return ReturnMe;
        }
        public QryBarcodeFrm()
        {
            InitializeComponent();
        }
        private void LoadDefaultData()
        {
            lueItems.Properties.DataSource = FXFW.SqlDB.LoadDataTable(@"Select SanfID, SanfName, Sanfbarcode, ModelNo, 
            (Select Category From CDCategories Where CategoryId = CDASNAF.CategoryId) AS Category,
             (Select priceout From TblPricelistdetailes Where SanfID = CDASNAF.SanfID) AS priceout
            From CDASNAF");
            lueItems.Properties.DisplayMember = "SanfName";
            lueItems.Properties.ValueMember = "Sanfbarcode";

            cbCode128Charset.Properties.Items.Add(Code128Charset.CharsetA);
            cbCode128Charset.Properties.Items.Add(Code128Charset.CharsetAuto);
            cbCode128Charset.Properties.Items.Add(Code128Charset.CharsetB);
            cbCode128Charset.Properties.Items.Add(Code128Charset.CharsetC);
            cbCode128Charset.SelectedIndex = 0;


        }
        #endregion
        #region -   Event Handlers   -
        private void QryBarcodeFrm_Load(object sender, EventArgs e)
        {
            LoadDefaultData();
        }
        private void lueItems_EditValueChanged(object sender, EventArgs e)
        {
            if (lueItems.EditValue == null)
                btnPreview.Enabled = false;
            else
                btnPreview.Enabled = true;
        }
        private void cbH_CheckedChanged(object sender, EventArgs e)
        {
            if (cbH.Checked)
                tbH.Enabled = true;
            else
                tbH.Enabled = false;
        }
        private void cbW_CheckedChanged(object sender, EventArgs e)
        {
            if (cbW.Checked)
                tbW.Enabled = true;
            else
                tbW.Enabled = false;
        }
        private void btnPreview_Click(object sender, EventArgs e)
        {
            using (XRepBarCode report = new XRepBarCode())
            {
                //report.xrBarCodeItem.Text = lueItems.EditValue.ToString();
                if (tbCount.Text == string.Empty)
                    report.LoadDataSource(LoadbarcodeTable(1));
                else
                    report.LoadDataSource(LoadbarcodeTable(Convert.ToInt32(tbCount.Text)));
                report.xrBarCodeItem.ShowText = cbShowText.Checked;
                ((Code128Generator)report.xrBarCodeItem.Symbology).CharacterSet = (Code128Charset)cbCode128Charset.SelectedIndex;
                report.xrBarCodeItem.AutoModule = cbAutoModule.Checked;
                report.xrBarCodeItem.Width = GetWidth();
                report.xrBarCodeItem.Height = GetHeight();
                report.ShowPreviewDialog();
            }
        }
        private DataTable LoadbarcodeTable(int barcodeCount)
        {
            DataTable dt = new DataTable();
            DataRow row = ((DataTable)lueItems.Properties.DataSource).Rows[lueItems.ItemIndex];
            dt.Columns.Add("Sanfbarcode");
            dt.Columns.Add("ModelNo");
            dt.Columns.Add("priceout");
            for (int i = 0; i < barcodeCount; i++)
            {
                DataRow NRow = dt.NewRow();
                NRow["Sanfbarcode"] = row["Sanfbarcode"];
                NRow["ModelNo"] = "الموديل: " + row["ModelNo"];
                NRow["priceout"] = "السعر: " + row["priceout"];
                dt.Rows.Add(NRow);
            }
            return dt;
        }
        #endregion
    }
}