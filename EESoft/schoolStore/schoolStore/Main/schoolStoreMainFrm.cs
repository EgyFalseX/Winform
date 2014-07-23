using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using DevExpress.LookAndFeel;

namespace schoolStore
{
    public partial class schoolStoreMainFrm : Form
    {
        #region -   Variables   -

        ImportStudentFrm FrmImportStudent;
        //Codes
        AccTreeOptionsFrm FrmAccTreeOptions;
        EditorYearFrm FrmEditorYear;
        EditorAccountNatureFrm FrmEditorAccountNature;
        EditorSalesUnitFrm FrmEditorSalesUnit;
        EditorStoreFrm FrmEditorStore;
        EditorBankFrm FrmEditorBank;
        EditorCustomerFrm FrmEditorCustomer;
        EditorCDCategoriesFrm FrmEditorCDCategories;
        EditorSuppliersFrm FrmEditorSuppliers;
        EditorCompaniesFrm FrmEditorCompanies;
        EditorBillPayTypesFrm FrmEditorBillPayTypes;
        EditorJobFrm FrmEditorJob;
        EditorCDASNAFFrm FrmEditorCDASNAF;
        CD_AsaseFrm FrmCD_Asase;
        //Data
        AccTypesDlgFrm FrmAccTypesDlg;
        AccTypesFrm FrmAccTypes;
        ConstraintsDailyFrm FrmConstraintsDaily;
        DataEmpFrm FrmDataEmp;
        DataBillFrm FrmDataBill;
        DataSellBillFrm FrmDataSellBill;
        DataSellBillBarCodeFrm FrmDataSellBillBarCode;
        DataTblPricelistsFrm FrmDataTblPricelists;
        studentFrm Frmstudent;
        DataSellStuBillBarCodeFrm FrmDataSellStuBillBarCode;
        DataTBLGardFrm FrmDataTBLGard;
        DataReturnSellStuBillFrm FrmDataReturnSellStuBill;
        DataReturnbuyBillFrm FrmDataReturnbuyBill;
        //Queries
        QrysellsFrm FrmQrysells;
        QryBuysFrm FrmQryBuys;
        ItemAvailabilityFrm FrmItemAvailability;
        QryBarcodeFrm FrmQryBarcode;
        //Roles
        EditorRoleFrm FrmEditorRole;
        EditorRoleMenuFrm FrmEditorRoleMenu;
        EditorUserFrm FrmEditorUser;
        EditorUserInRoleFrm FrmEditorUserInRole;
        //Tools
        SkinsFrm FrmSkins = new SkinsFrm();


        DataTable ActiveMenu = new DataTable("FalseX2010-11");
        private ToolStripMenuItem[] MenuItemZ = null;

        #endregion
        #region -   Functions   -
        public schoolStoreMainFrm()
        {
            InitializeComponent();
        }
        private static FXFW.UserSkinSettings LoadSettings(string fileName)
        {
            FXFW.UserSkinSettings us = null;
            BinaryFormatter binFormat = new BinaryFormatter();
            System.IO.Stream fStream = new System.IO.FileStream(fileName, System.IO.FileMode.Open);
            try { us = binFormat.Deserialize(fStream) as FXFW.UserSkinSettings; }
            finally { fStream.Close(); }
            return us;
        }
        public void RebuildForms()
        {
            FrmImportStudent = new ImportStudentFrm();
            //Codes
            FrmAccTreeOptions = new AccTreeOptionsFrm();
            FrmEditorYear = new EditorYearFrm();
            FrmEditorAccountNature = new EditorAccountNatureFrm();
            FrmEditorSalesUnit = new EditorSalesUnitFrm();
            FrmEditorStore = new EditorStoreFrm();
            FrmEditorBank = new EditorBankFrm();
            FrmEditorCustomer = new EditorCustomerFrm();
            FrmEditorCDCategories = new EditorCDCategoriesFrm();
            FrmEditorSuppliers = new EditorSuppliersFrm();
            FrmEditorCompanies = new EditorCompaniesFrm();
            FrmEditorBillPayTypes = new EditorBillPayTypesFrm();
            FrmEditorJob = new EditorJobFrm();
            FrmEditorCDASNAF = new EditorCDASNAFFrm();
            FrmCD_Asase = new CD_AsaseFrm();
            //Data
            FrmAccTypesDlg = new AccTypesDlgFrm();
            FrmAccTypes = new AccTypesFrm();
            FrmConstraintsDaily = new ConstraintsDailyFrm();
            FrmDataEmp = new DataEmpFrm();
            FrmDataBill = new DataBillFrm();
            FrmDataSellBill = new DataSellBillFrm();
            FrmDataSellBillBarCode = new DataSellBillBarCodeFrm();
            FrmDataTblPricelists = new DataTblPricelistsFrm();
            Frmstudent = new studentFrm();
            FrmDataSellStuBillBarCode = new DataSellStuBillBarCodeFrm();
            FrmDataTBLGard = new DataTBLGardFrm();
            FrmDataReturnSellStuBill = new DataReturnSellStuBillFrm();
            FrmDataReturnbuyBill = new DataReturnbuyBillFrm();
            //Queries
            FrmQrysells = new QrysellsFrm();
            FrmQryBuys = new QryBuysFrm();
            FrmItemAvailability = new ItemAvailabilityFrm();
            FrmQryBarcode = new QryBarcodeFrm();
            //Roles
            FrmEditorRole = new EditorRoleFrm();
            FrmEditorRoleMenu = new EditorRoleMenuFrm();
            FrmEditorUser = new EditorUserFrm();
            FrmEditorUserInRole = new EditorUserInRoleFrm();
            //Tools
            FrmSkins = new SkinsFrm();
          
        
        }
        private void LoadMenuItem()
        {
            foreach (ToolStripMenuItem item in menuStrip.Items)
                GetSubMenuItem(item);
        }
        private void GetSubMenuItem(ToolStripMenuItem MItem)
        {
            foreach (ToolStripMenuItem item in MItem.DropDownItems)
            {
                if (MenuItemZ == null)
                {
                    MenuItemZ = new ToolStripMenuItem[1];
                }
                else
                {
                    ToolStripMenuItem[] tempItemList = new ToolStripMenuItem[MenuItemZ.Length + 1];
                    MenuItemZ.CopyTo(tempItemList, 0);
                    MenuItemZ = tempItemList;
                }
                MenuItemZ[MenuItemZ.Length - 1] = item;

                if (item.DropDownItems != null)
                {
                    GetSubMenuItem(item);
                }
            }
        }
        private void EnableMenuItem()
        {
            LoadMenuItem();
            ActiveMenu = new DataTable("FalseX2010-11");
            ActiveMenu = FXFW.SqlDB.LoadDataTable("SELECT RoleDetial.MenuItemName FROM UserRoles INNER JOIN RoleDetial ON UserRoles.RoleId = RoleDetial.RoleID WHERE (UserRoles.UserId = N'" + FXFW.SqlDB.UserInfo.UserID + "')");
            foreach (DataRow row in ActiveMenu.Rows)
            {
                foreach (ToolStripMenuItem item in MenuItemZ)
                {
                    if (item.Name == row["MenuItemName"].ToString())
                    {
                        item.Visible = true;// Make Menu Item Visible
                        break;
                    }
                }
            }
        }
        private void LoadSQLReports()
        {
            try
            {
                if (FXFW.SqlDB.SQLRep == null)
                    return;
                for (int i = 0; i < FXFW.SqlDB.SQLRep.Length; i++)
                {
                    ToolStripMenuItem TSMI = new ToolStripMenuItem();
                    TSMI.Name = FXFW.SqlDB.SQLRep[i].RepFileName.Replace(".rdl", "");
                    TSMI.Text = FXFW.SqlDB.SQLRep[i].RepCaption;
                    TSMI.ImageIndex = 0;
                    TSMI.Tag = i;
                    TSMI.Image = global::schoolStore.Properties.Resources.Report;
                    TSMI.Visible = false;

                    ((ToolStripMenuItem)printingToolStripMenuItem.DropDownItems[Convert.ToInt16(FXFW.SqlDB.SQLRep[i].RepPosition)]).DropDownItems.Add(TSMI);
                    TSMI.Click += TSMI_Click;
                }
            }
            catch (Exception ex)
            {
                Program.msg(ex.Message, true, "", this);
            }
        }
        private void LoadUserPriv(string RoleID)
        {
            ////Hide All Tools
            //foreach (DevExpress.XtraNavBar.NavBarItem item in navBarControlCode.Items)
            //    item.Visible = false;
            //foreach (DevExpress.XtraNavBar.NavBarItem item in navBarControlData.Items)
            //    item.Visible = false;
            //foreach (DevExpress.XtraNavBar.NavBarItem item in navBarControlPriv.Items)
            //    item.Visible = false;
            //foreach (DevExpress.XtraNavBar.NavBarItem item in navBarControlQry.Items)
            //    item.Visible = false;
            //foreach (DevExpress.XtraNavBar.NavBarItem item in navBarControlReport.Items)
            //    item.Visible = false;

            //RoleDetialsTbl = FXFW.SqlDB.LoadDataTable("SELECT RoleDetial.MenuItemName FROM UserRoles INNER JOIN RoleDetial ON UserRoles.RoleId = RoleDetial.RoleID WHERE UserRoles.UserId = " + FXFW.SqlDB.UserInfo.UserID);

            //foreach (DataRow row in RoleDetialsTbl.Rows)
            //{
            //    foreach (NavBarItem item in navBarControlCode.Items)//code
            //    {
            //        if (item.Name.Replace("navBarItem", "") == row["MenuItemName"].ToString())
            //        {
            //            item.Visible = true;
            //            goto nextOne;
            //        }
            //    }
            //    foreach (NavBarItem item in navBarControlData.Items)//data
            //    {
            //        if (item.Name.Replace("navBarItem", "") == row["MenuItemName"].ToString())
            //        {
            //            item.Visible = true;
            //            goto nextOne;
            //        }
            //    }
            //    foreach (NavBarItem item in navBarControlPriv.Items)//priv
            //    {
            //        if (item.Name.Replace("navBarItem", "") == row["MenuItemName"].ToString())
            //        {
            //            item.Visible = true;
            //            goto nextOne;
            //        }
            //    }
            //    foreach (NavBarItem item in navBarControlQry.Items)//qry
            //    {
            //        if (item.Name.Replace("navBarItem", "") == row["MenuItemName"].ToString())
            //        {
            //            item.Visible = true;
            //            goto nextOne;
            //        }
            //    }
            //    foreach (NavBarItem item in navBarControlReport.Items)//report
            //    {
            //        if (item.Name.Replace("navBarItem", "") == row["MenuItemName"].ToString())
            //        {
            //            item.Visible = true;
            //            goto nextOne;
            //        }
            //    }
            //nextOne:
            //    ;
            //    //continue;
            //}
        }
        #endregion
        #region - Event Handlers -
        private void ECMMainFrm_Load(object sender, EventArgs e)
        {
            
            if (System.IO.File.Exists(FXFW.SqlDB.StyleSettingsPath))
                UserLookAndFeel.Default.SetSkinStyle(LoadSettings(FXFW.SqlDB.StyleSettingsPath).SkinName);

            //Load Reports from file and create its item in the interface
            LoadSQLReports();
            this.IsMdiContainer = true;
            // Show Splash Screen..
            using (SplashFrm SC = new SplashFrm())
                SC.ShowDialog();
            // Show Login Screen..
            using (LoginFrm FrmLogin = new LoginFrm())
                FrmLogin.ShowDialog();
            //Get ready all forms
            RebuildForms();
            // Load And Enable User Priv
            //LoadUserPriv(FXFW.SqlDB.UserInfo.UserID);
            EnableMenuItem();
        }
        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }
        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }
        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }
        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        private void restConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزيـــــر", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            if (System.IO.File.Exists(FXFW.SqlDB.DBPath))
            {
                System.IO.File.Delete(FXFW.SqlDB.DBPath);
                Application.Restart();
            }
        }
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("E-E-Soft Co. \n  Test Version ...");
        }
        private void accountsTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (FrmAccTypes.IsDisposed)
            {
                FrmAccTypes = new AccTypesFrm();
                FrmAccTypes.MdiParent = this;
                FrmAccTypes.Show();
            }
            else
            {
                if (FrmAccTypes.Visible)
                {
                    FrmAccTypes.WindowState = FormWindowState.Normal;
                    FrmAccTypes.Focus();
                }
                else
                {
                    FrmAccTypes.MdiParent = this;
                    FrmAccTypes.Show();
                }
            }
            FrmAccTypes.Icon = FXFW.SqlDB.MakeIcon(global::schoolStore.Properties.Resources.accountsTypes, 16, false);
        }
        private void constraintsDailyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmConstraintsDaily.IsDisposed)
            {
                FrmConstraintsDaily = new ConstraintsDailyFrm();
                FrmConstraintsDaily.MdiParent = this;
                FrmConstraintsDaily.Show();
            }
            else
            {
                if (FrmConstraintsDaily.Visible)
                {
                    FrmConstraintsDaily.WindowState = FormWindowState.Normal;
                    FrmConstraintsDaily.Focus();
                }
                else
                {
                    FrmConstraintsDaily.MdiParent = this;
                    FrmConstraintsDaily.Show();
                }
            }
            FrmConstraintsDaily.Icon = FXFW.SqlDB.MakeIcon(global::schoolStore.Properties.Resources.constraintsDaily, 16, false);
        }
        private void editorYearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmEditorYear.IsDisposed)
            {
                FrmEditorYear = new EditorYearFrm();
                FrmEditorYear.MdiParent = this;
                FrmEditorYear.Show();
            }
            else
            {
                if (FrmEditorYear.Visible)
                {
                    FrmEditorYear.WindowState = FormWindowState.Normal;
                    FrmEditorYear.Focus();
                }
                else
                {
                    FrmEditorYear.MdiParent = this;
                    FrmEditorYear.Show();
                }
            }
            FrmEditorYear.Icon = FXFW.SqlDB.MakeIcon(global::schoolStore.Properties.Resources.editorYear, 16, false);
        }
        private void editorAccountNatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmEditorAccountNature.IsDisposed)
            {
                FrmEditorAccountNature = new EditorAccountNatureFrm();
                FrmEditorAccountNature.MdiParent = this;
                FrmEditorAccountNature.Show();
            }
            else
            {
                if (FrmEditorAccountNature.Visible)
                {
                    FrmEditorAccountNature.WindowState = FormWindowState.Normal;
                    FrmEditorAccountNature.Focus();
                }
                else
                {
                    FrmEditorAccountNature.MdiParent = this;
                    FrmEditorAccountNature.Show();
                }
            }
            FrmEditorAccountNature.Icon = FXFW.SqlDB.MakeIcon(global::schoolStore.Properties.Resources.editorAccountNature, 16, false);
        }
        private void EditorsalesUnitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmEditorSalesUnit.IsDisposed)
            {
                FrmEditorSalesUnit = new EditorSalesUnitFrm();
                FrmEditorSalesUnit.MdiParent = this;
                FrmEditorSalesUnit.Show();
            }
            else
            {
                if (FrmEditorSalesUnit.Visible)
                {
                    FrmEditorSalesUnit.WindowState = FormWindowState.Normal;
                    FrmEditorSalesUnit.Focus();
                }
                else
                {
                    FrmEditorSalesUnit.MdiParent = this;
                    FrmEditorSalesUnit.Show();
                }
            }
            FrmEditorSalesUnit.Icon = FXFW.SqlDB.MakeIcon(global::schoolStore.Properties.Resources.EditorsalesUnit, 16, false);
        }
        private void editorStoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmEditorStore.IsDisposed)
            {
                FrmEditorStore = new EditorStoreFrm();
                FrmEditorStore.MdiParent = this;
                FrmEditorStore.Show();
            }
            else
            {
                if (FrmEditorStore.Visible)
                {
                    FrmEditorStore.WindowState = FormWindowState.Normal;
                    FrmEditorStore.Focus();
                }
                else
                {
                    FrmEditorStore.MdiParent = this;
                    FrmEditorStore.Show();
                }
            }
            FrmEditorStore.Icon = FXFW.SqlDB.MakeIcon(global::schoolStore.Properties.Resources.editorStore, 16, false);
        }
        private void banksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmEditorBank.IsDisposed)
            {
                FrmEditorBank = new EditorBankFrm();
                FrmEditorBank.MdiParent = this;
                FrmEditorBank.Show();
            }
            else
            {
                if (FrmEditorBank.Visible)
                {
                    FrmEditorBank.WindowState = FormWindowState.Normal;
                    FrmEditorBank.Focus();
                }
                else
                {
                    FrmEditorBank.MdiParent = this;
                    FrmEditorBank.Show();
                }
            }
            FrmEditorBank.Icon = FXFW.SqlDB.MakeIcon(global::schoolStore.Properties.Resources.banks, 16, false);
        }
        private void editorCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmEditorCustomer.IsDisposed)
            {
                FrmEditorCustomer = new EditorCustomerFrm();
                FrmEditorCustomer.MdiParent = this;
                FrmEditorCustomer.Show();
            }
            else
            {
                if (FrmEditorCustomer.Visible)
                {
                    FrmEditorCustomer.WindowState = FormWindowState.Normal;
                    FrmEditorCustomer.Focus();
                }
                else
                {
                    FrmEditorCustomer.MdiParent = this;
                    FrmEditorCustomer.Show();
                }
            }
            FrmEditorCustomer.Icon = FXFW.SqlDB.MakeIcon(global::schoolStore.Properties.Resources.editorCustomer, 16, false);
        }
        private void editorCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmEditorCDCategories.IsDisposed)
            {
                FrmEditorCDCategories = new EditorCDCategoriesFrm();
                FrmEditorCDCategories.MdiParent = this;
                FrmEditorCDCategories.Show();
            }
            else
            {
                if (FrmEditorCDCategories.Visible)
                {
                    FrmEditorCDCategories.WindowState = FormWindowState.Normal;
                    FrmEditorCDCategories.Focus();
                }
                else
                {
                    FrmEditorCDCategories.MdiParent = this;
                    FrmEditorCDCategories.Show();
                }
            }
            FrmEditorStore.Icon = FXFW.SqlDB.MakeIcon(global::schoolStore.Properties.Resources.editorCDCategories, 16, false);
        }
        private void editorSuppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmEditorSuppliers.IsDisposed)
            {
                FrmEditorSuppliers = new EditorSuppliersFrm();
                FrmEditorSuppliers.MdiParent = this;
                FrmEditorSuppliers.Show();
            }
            else
            {
                if (FrmEditorSuppliers.Visible)
                {
                    FrmEditorSuppliers.WindowState = FormWindowState.Normal;
                    FrmEditorSuppliers.Focus();
                }
                else
                {
                    FrmEditorSuppliers.MdiParent = this;
                    FrmEditorSuppliers.Show();
                }
            }
            FrmEditorSuppliers.Icon = FXFW.SqlDB.MakeIcon(global::schoolStore.Properties.Resources.editorSuppliers, 16, false);
        }
        private void EditorCompaniesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmEditorCompanies.IsDisposed)
            {
                FrmEditorCompanies = new EditorCompaniesFrm();
                FrmEditorCompanies.MdiParent = this;
                FrmEditorCompanies.Show();
            }
            else
            {
                if (FrmEditorCompanies.Visible)
                {
                    FrmEditorCompanies.WindowState = FormWindowState.Normal;
                    FrmEditorCompanies.Focus();
                }
                else
                {
                    FrmEditorCompanies.MdiParent = this;
                    FrmEditorCompanies.Show();
                }
            }
            FrmEditorStore.Icon = FXFW.SqlDB.MakeIcon(global::schoolStore.Properties.Resources.EditorCompanies, 16, false);
        }
        private void billPayTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmEditorBillPayTypes.IsDisposed)
            {
                FrmEditorBillPayTypes = new EditorBillPayTypesFrm();
                FrmEditorBillPayTypes.MdiParent = this;
                FrmEditorBillPayTypes.Show();
            }
            else
            {
                if (FrmEditorBillPayTypes.Visible)
                {
                    FrmEditorBillPayTypes.WindowState = FormWindowState.Normal;
                    FrmEditorBillPayTypes.Focus();
                }
                else
                {
                    FrmEditorBillPayTypes.MdiParent = this;
                    FrmEditorBillPayTypes.Show();
                }
            }
            FrmEditorStore.Icon = FXFW.SqlDB.MakeIcon(global::schoolStore.Properties.Resources.billPayType, 16, false);
        }
        private void editJobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmEditorJob.IsDisposed)
            {
                FrmEditorJob = new EditorJobFrm();
                FrmEditorJob.MdiParent = this;
                FrmEditorJob.Show();
            }
            else
            {
                if (FrmEditorJob.Visible)
                {
                    FrmEditorJob.WindowState = FormWindowState.Normal;
                    FrmEditorJob.Focus();
                }
                else
                {
                    FrmEditorJob.MdiParent = this;
                    FrmEditorJob.Show();
                }
            }
            FrmEditorJob.Icon = FXFW.SqlDB.MakeIcon(global::schoolStore.Properties.Resources.editJobTool, 16, false);
        }
        private void editEmpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmDataEmp.IsDisposed)
            {
                FrmDataEmp = new DataEmpFrm();
                FrmDataEmp.MdiParent = this;
                FrmDataEmp.Show();
            }
            else
            {
                if (FrmDataEmp.Visible)
                {
                    FrmDataEmp.WindowState = FormWindowState.Normal;
                    FrmDataEmp.Focus();
                }
                else
                {
                    FrmDataEmp.MdiParent = this;
                    FrmDataEmp.Show();
                }
            }
            FrmDataEmp.Icon = FXFW.SqlDB.MakeIcon(global::schoolStore.Properties.Resources.editEmp, 16, false);
        }
        private void prmEditorRoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmEditorRole.IsDisposed)
            {
                FrmEditorRole = new EditorRoleFrm();
                FrmEditorRole.MdiParent = this;
                FrmEditorRole.Show();
            }
            else
            {
                if (FrmEditorRole.Visible)
                {
                    FrmEditorRole.WindowState = FormWindowState.Normal;
                    FrmEditorRole.Focus();
                }
                else
                {
                    FrmEditorRole.MdiParent = this;
                    FrmEditorRole.Show();
                }
            }
            FrmEditorRole.Icon = FXFW.SqlDB.MakeIcon(global::schoolStore.Properties.Resources.Roles, 16, false);
        }
        private void prmEditorRoleMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmEditorRoleMenu.IsDisposed)
            {
                FrmEditorRoleMenu = new EditorRoleMenuFrm();
                //FrmEditorRoleMenu.MdiParent = this;
                FrmEditorRoleMenu.Icon = FXFW.SqlDB.MakeIcon(global::schoolStore.Properties.Resources.RoleDetial, 16, false);
                FrmEditorRoleMenu.ShowDialog();
            }
            else
            {
                FrmEditorRoleMenu.Icon = FXFW.SqlDB.MakeIcon(global::schoolStore.Properties.Resources.RoleDetial, 16, false);
                if (FrmEditorRoleMenu.Visible)
                {
                    FrmEditorRoleMenu.WindowState = FormWindowState.Normal;
                    FrmEditorRoleMenu.Focus();
                }
                else
                {
                    //FrmEditorRoleMenu.MdiParent = this;
                    FrmEditorRoleMenu.ShowDialog();
                }
            }
            
        }
        private void PremEditorUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmEditorUser.IsDisposed)
            {
                FrmEditorUser = new EditorUserFrm();
                FrmEditorUser.MdiParent = this;
                FrmEditorUser.Show();
            }
            else
            {
                if (FrmEditorUser.Visible)
                {
                    FrmEditorUser.WindowState = FormWindowState.Normal;
                    FrmEditorUser.Focus();
                }
                else
                {
                    FrmEditorUser.MdiParent = this;
                    FrmEditorUser.Show();
                }
            }
            FrmEditorUser.Icon = FXFW.SqlDB.MakeIcon(global::schoolStore.Properties.Resources.Users, 16, false);
        }
        private void premEditorUserInRoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmEditorUserInRole.IsDisposed)
            {
                FrmEditorUserInRole = new EditorUserInRoleFrm();
                FrmEditorUserInRole.MdiParent = this;
                FrmEditorUserInRole.Show();
            }
            else
            {
                if (FrmEditorUserInRole.Visible)
                {
                    FrmEditorUserInRole.WindowState = FormWindowState.Normal;
                    FrmEditorUserInRole.Focus();
                }
                else
                {
                    FrmEditorUserInRole.MdiParent = this;
                    FrmEditorUserInRole.Show();
                }
            }
            FrmEditorUserInRole.Icon = FXFW.SqlDB.MakeIcon(global::schoolStore.Properties.Resources.UserRoles, 16, false);
        }
        private void dataAsnafFrmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmEditorCDASNAF.IsDisposed)
            {
                FrmEditorCDASNAF = new EditorCDASNAFFrm();
                FrmEditorCDASNAF.MdiParent = this;
                FrmEditorCDASNAF.Show();
            }
            else
            {
                if (FrmEditorCDASNAF.Visible)
                {
                    FrmEditorCDASNAF.WindowState = FormWindowState.Normal;
                    FrmEditorCDASNAF.Focus();
                }
                else
                {
                    FrmEditorCDASNAF.MdiParent = this;
                    FrmEditorCDASNAF.Show();
                }
            }
            FrmEditorCDASNAF.Icon = FXFW.SqlDB.MakeIcon(global::schoolStore.Properties.Resources.dataAsnafFrm, 16, false);
        }
        private void DataBillFrmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmDataBill.IsDisposed)
            {
                FrmDataBill = new DataBillFrm();
                FrmDataBill.MdiParent = this;
                FrmDataBill.Show();
            }
            else
            {
                if (FrmDataBill.Visible)
                {
                    FrmDataBill.WindowState = FormWindowState.Normal;
                    FrmDataBill.Focus();
                }
                else
                {
                    FrmDataBill.MdiParent = this;
                    FrmDataBill.Show();
                }
            }
            FrmDataBill.Icon = FXFW.SqlDB.MakeIcon(global::schoolStore.Properties.Resources.dataBillFrm, 16, false);
        }
        private void dataSellBillFrmToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (FrmDataSellBill.IsDisposed)
            {
                FrmDataSellBill = new DataSellBillFrm();
                FrmDataSellBill.MdiParent = this;
                FrmDataSellBill.Show();
            }
            else
            {
                if (FrmDataSellBill.Visible)
                {
                    FrmDataSellBill.WindowState = FormWindowState.Normal;
                    FrmDataSellBill.Focus();
                }
                else
                {
                    FrmDataSellBill.MdiParent = this;
                    FrmDataSellBill.Show();
                }
            }
        }
        private void DataSellBillBarCodeFrmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDataSellBillBarCode = new DataSellBillBarCodeFrm();
            FrmDataSellBillBarCode.MdiParent = this;
            FrmDataSellBillBarCode.Icon = FXFW.SqlDB.MakeIcon(global::schoolStore.Properties.Resources.DataSellBillBarCodeFrm, 16, false);
            FrmDataSellBillBarCode.Show();
        }
        private void dataTblPricelistsFrmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmDataTblPricelists.IsDisposed)
            {
                FrmDataTblPricelists = new DataTblPricelistsFrm();
                FrmDataTblPricelists.MdiParent = this;
                FrmDataTblPricelists.Show();
            }
            else
            {
                if (FrmDataTblPricelists.Visible)
                {
                    FrmDataTblPricelists.WindowState = FormWindowState.Normal;
                    FrmDataTblPricelists.Focus();
                }
                else
                {
                    FrmDataTblPricelists.MdiParent = this;
                    FrmDataTblPricelists.Show();
                }
            }
            FrmDataTblPricelists.Icon = FXFW.SqlDB.MakeIcon(global::schoolStore.Properties.Resources.dataTblPricelistsFrm, 16, false);
        }
        private void accTreeOptionsFrmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmAccTreeOptions.IsDisposed)
            {
                FrmAccTreeOptions = new AccTreeOptionsFrm();
                FrmAccTreeOptions.MdiParent = this;
                FrmAccTreeOptions.Show();
            }
            else
            {
                if (FrmAccTreeOptions.Visible)
                {
                    FrmAccTreeOptions.WindowState = FormWindowState.Normal;
                    FrmAccTreeOptions.Focus();
                }
                else
                {
                    FrmAccTreeOptions.MdiParent = this;
                    FrmAccTreeOptions.Show();
                }
            }
            FrmAccTreeOptions.Icon = FXFW.SqlDB.MakeIcon(global::schoolStore.Properties.Resources.accTreeOptionsFrm, 16, false);
        }
        private void qrysellsFrmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmQrysells.IsDisposed)
            {
                FrmQrysells = new QrysellsFrm();
                FrmQrysells.MdiParent = this;
                FrmQrysells.Show();
            }
            else
            {
                if (FrmQrysells.Visible)
                {
                    FrmQrysells.WindowState = FormWindowState.Normal;
                    FrmQrysells.Focus();
                }
                else
                {
                    FrmQrysells.MdiParent = this;
                    FrmQrysells.Show();
                }
            }
            FrmQrysells.Icon = FXFW.SqlDB.MakeIcon(global::schoolStore.Properties.Resources.Qry, 16, false);
        }
        private void qryQryBuysFrmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmQryBuys.IsDisposed)
            {
                FrmQryBuys = new QryBuysFrm();
                FrmQryBuys.MdiParent = this;
                FrmQryBuys.Show();
            }
            else
            {
                if (FrmQryBuys.Visible)
                {
                    FrmQryBuys.WindowState = FormWindowState.Normal;
                    FrmQryBuys.Focus();
                }
                else
                {
                    FrmQryBuys.MdiParent = this;
                    FrmQryBuys.Show();
                }
            }
            FrmQryBuys.Icon = FXFW.SqlDB.MakeIcon(global::schoolStore.Properties.Resources.Qry, 16, false);
        }
        private void qryItemAvailabilityFrmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmItemAvailability.IsDisposed)
            {
                FrmItemAvailability = new ItemAvailabilityFrm();
                FrmItemAvailability.MdiParent = this;
                FrmItemAvailability.Show();
            }
            else
            {
                if (FrmItemAvailability.Visible)
                {
                    FrmItemAvailability.WindowState = FormWindowState.Normal;
                    FrmItemAvailability.Focus();
                }
                else
                {
                    FrmItemAvailability.MdiParent = this;
                    FrmItemAvailability.Show();
                }
            }
            FrmItemAvailability.Icon = FXFW.SqlDB.MakeIcon(global::schoolStore.Properties.Resources.Qry, 16, false);
        }
        private void qryBarcodeFrmToolStripMenuItem_Click(object sender, EventArgs e)
        {
             if (FrmQryBarcode.IsDisposed)
            {
                FrmQryBarcode = new QryBarcodeFrm();
                FrmQryBarcode.MdiParent = this;
                FrmQryBarcode.Show();
            }
            else
            {
                if (FrmQryBarcode.Visible)
                {
                    FrmQryBarcode.WindowState = FormWindowState.Normal;
                    FrmQryBarcode.Focus();
                }
                else
                {
                    FrmQryBarcode.MdiParent = this;
                    FrmQryBarcode.Show();
                }
            }
            FrmQryBarcode.Icon = FXFW.SqlDB.MakeIcon(global::schoolStore.Properties.Resources.Qry, 16, false);
        }
        private void skinsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmSkins.IsDisposed)
            {
                FrmSkins = new SkinsFrm();
                FrmSkins.MdiParent = this;
                FrmSkins.Show();
            }
            else
            {
                if (FrmSkins.Visible)
                {
                    FrmSkins.WindowState = FormWindowState.Normal;
                    FrmSkins.Focus();
                }
                else
                {
                    FrmSkins.MdiParent = this;
                    FrmSkins.Show();
                }
            }
        }
        private void importStudentFrmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmImportStudent.IsDisposed)
            {
                FrmImportStudent = new ImportStudentFrm();
                FrmImportStudent.MdiParent = this;
                FrmImportStudent.Show();
            }
            else
            {
                if (FrmImportStudent.Visible)
                {
                    FrmImportStudent.WindowState = FormWindowState.Normal;
                    FrmImportStudent.Focus();
                }
                else
                {
                    FrmImportStudent.MdiParent = this;
                    FrmImportStudent.Show();
                }
            }
        }
        private void cDAsaseFrmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmCD_Asase.IsDisposed)
            {
                FrmCD_Asase = new CD_AsaseFrm();
                FrmCD_Asase.MdiParent = this;
                FrmCD_Asase.Show();
            }
            else
            {
                if (FrmCD_Asase.Visible)
                {
                    FrmCD_Asase.WindowState = FormWindowState.Normal;
                    FrmCD_Asase.Focus();
                }
                else
                {
                    FrmCD_Asase.MdiParent = this;
                    FrmCD_Asase.Show();
                }
            }
        }
        private void studentFrmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Frmstudent.IsDisposed)
            {
                Frmstudent = new studentFrm();
                Frmstudent.MdiParent = this;
                Frmstudent.Show();
            }
            else
            {
                if (Frmstudent.Visible)
                {
                    Frmstudent.WindowState = FormWindowState.Normal;
                    Frmstudent.Focus();
                }
                else
                {
                    Frmstudent.MdiParent = this;
                    Frmstudent.Show();
                }
            }
        }
        private void dataSellStuBillBarCodeFrmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmDataSellStuBillBarCode.IsDisposed)
            {
                FrmDataSellStuBillBarCode = new DataSellStuBillBarCodeFrm();
                FrmDataSellStuBillBarCode.MdiParent = this;
                FrmDataSellStuBillBarCode.Show();
            }
            else
            {
                if (FrmDataSellStuBillBarCode.Visible)
                {
                    FrmDataSellStuBillBarCode.WindowState = FormWindowState.Normal;
                    FrmDataSellStuBillBarCode.Focus();
                }
                else
                {
                    FrmDataSellStuBillBarCode.MdiParent = this;
                    FrmDataSellStuBillBarCode.Show();
                }
            }
        }
        private void dataTBLGardFrmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmDataTBLGard.IsDisposed)
            {
                FrmDataTBLGard = new  DataTBLGardFrm();
                FrmDataTBLGard.MdiParent = this;
                FrmDataTBLGard.Show();
            }
            else
            {
                if (FrmDataTBLGard.Visible)
                {
                    FrmDataTBLGard.WindowState = FormWindowState.Normal;
                    FrmDataTBLGard.Focus();
                }
                else
                {
                    FrmDataTBLGard.MdiParent = this;
                    FrmDataTBLGard.Show();
                }
            }
        }
        private void dataReturnSellStuBillFrmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmDataReturnSellStuBill.IsDisposed)
            {
                FrmDataReturnSellStuBill = new DataReturnSellStuBillFrm();
                FrmDataReturnSellStuBill.MdiParent = this;
                FrmDataReturnSellStuBill.Show();
            }
            else
            {
                if (FrmDataReturnSellStuBill.Visible)
                {
                    FrmDataReturnSellStuBill.WindowState = FormWindowState.Normal;
                    FrmDataReturnSellStuBill.Focus();
                }
                else
                {
                    FrmDataReturnSellStuBill.MdiParent = this;
                    FrmDataReturnSellStuBill.Show();
                }
            }
        }
        private void dataReturnbuyBillFrmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmDataReturnbuyBill.IsDisposed)
            {
                FrmDataReturnbuyBill = new DataReturnbuyBillFrm();
                FrmDataReturnbuyBill.MdiParent = this;
                FrmDataReturnbuyBill.Show();
            }
            else
            {
                if (FrmDataReturnbuyBill.Visible)
                {
                    FrmDataReturnbuyBill.WindowState = FormWindowState.Normal;
                    FrmDataReturnbuyBill.Focus();
                }
                else
                {
                    FrmDataReturnbuyBill.MdiParent = this;
                    FrmDataReturnbuyBill.Show();
                }
            }
        }
        private void deployRptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FXFW.SqlDB.ChangeSSRSAuthType())
                MessageBox.Show("لم يتم تعديل صلاحيات خادم التقارير ","",  MessageBoxButtons.OK, MessageBoxIcon.Information);
           
            FXFW.Settings rpt = new FXFW.Settings();
            string reportserver = FXFW.SqlDB.ReportURL.Replace("http://", "");
            reportserver = reportserver.Substring(0, reportserver.IndexOf("/"));
            string[] arr = FXFW.SqlDB.ReportURL.Split(Convert.ToChar("/"));
            rpt.GlobalSettings(reportserver, arr[arr.Length - 1]);
            System.Data.SqlClient.SqlConnectionStringBuilder constring = new System.Data.SqlClient.SqlConnectionStringBuilder(FXFW.SqlDB.SqlConStr);
            string constringpro = string.Format(@"data source={0};initial catalog={1}", constring.DataSource, constring.InitialCatalog);
            rpt.CreateDataSource("DataSourceschoolStore", true, true, "Data Sources", constringpro, FXFW.Settings.CredentialRetrievalValues.Store, false, constring.UserID, constring.Password);
            FXFW.Settings.Report[] reports = null;
            foreach (FXFW.SqlDB.SQLReportsStr item in FXFW.SqlDB.SQLRep)
            {
                if (reports == null)
                    Array.Resize<FXFW.Settings.Report>(ref reports, 1);
                else
                    Array.Resize<FXFW.Settings.Report>(ref reports, reports.Length + 1);

                reports[reports.Length - 1].Name = item.RepFileName.Replace(".rdl", "");
                reports[reports.Length - 1].FilePathValue = @"\rdl\" + item.RepFileName;
            }
            rpt.CreateReport("GroupDS", "DataSourceschoolStore", FXFW.SqlDB.ReportPath, 10080, reports);
            FXFW.SqlDB.DeploySSRSReports(rpt);
            
        }
        private void TSMI_Click(object sender, EventArgs e)
        {
            RepGeneralFrm FrmRepGeneral = new RepGeneralFrm();
            FrmRepGeneral.MdiParent = this;
            FrmRepGeneral.Icon = FXFW.SqlDB.MakeIcon(global::schoolStore.Properties.Resources.Report, 20, false);
            FrmRepGeneral.rptSelectedIndex = (int)((ToolStripMenuItem)sender).Tag;
            FrmRepGeneral.Show();
        }

        #endregion
        
    }
}