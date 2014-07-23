using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraEditors;
using TinyShop.dbTools;
using TinyShop.Forms.Basic;
using TinyShop.Forms.Data;
using TinyShop.Forms.Query;
using TinyShop.Forms.Print;


namespace TinyShop.Forms
{
    public partial class MainFrm : XtraForm
    {
        public MainFrm()
        {
            InitializeComponent();
        }
        private void MainFrm_Load(object sender, EventArgs e)
        {
            //nothing
        }
        private void iExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }
        private void iAbout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string msg = "Programmed by Mohamed Aly Omer" + Environment.NewLine;
            msg += "01004558638 / mohamed.aly.omer@gmail.com";

            MessageBox.Show(msg, "About the software", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void itemProductsEditor_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ProductsEditorFrm frm = new ProductsEditorFrm() { MdiParent = this };
            frm.Show(); 
        }
        private void ItemCustomersEditor_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            CustomersEditorFrm frm = new CustomersEditorFrm() { MdiParent = this };
            frm.Show(); 
        }
        private void ItemSuppliersEditor_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SuppliersEditorFrm frm = new SuppliersEditorFrm() { MdiParent = this };
            frm.Show(); 
        }
        private void ItemBillsBaye3Editor_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            BillsEditorFrm frm = new BillsEditorFrm((int)misc.BillType.Baye3) { MdiParent = this };
            frm.Show(); 
        }
        private void ItemBillsTawreedEditor_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            BillsEditorFrm frm = new BillsEditorFrm((int)misc.BillType.Tawreed) { MdiParent = this };
            frm.Show(); 
        }
        private void ItemBillsMortaga3Editor_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            BillsEditorFrm frm = new BillsEditorFrm((int)misc.BillType.Mortaga3) { MdiParent = this };
            frm.Show();    
        }
        private void ItemBillsHawaleekEditor_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            BillsEditorFrm frm = new BillsEditorFrm((int)misc.BillType.Hawaleek) { MdiParent = this };
            frm.Show(); 
        }
        private void ItemQryBills_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            QryBillsFrm frm = new QryBillsFrm() { MdiParent = this };
            frm.Show();
        }
        private void ItemQryBillsDetails_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            QryBillsDetailsFrm frm = new QryBillsDetailsFrm() { MdiParent = this };
            frm.Show();
        }
        private void ItemPrintBarcode_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            PrintBarcodeFrm frm = new PrintBarcodeFrm() { MdiParent = this };
            frm.Show();
        }
        private void ItemOptions_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            OptionsFrm frm = new OptionsFrm() { MdiParent = this };
            frm.Show();
        }

    }
}