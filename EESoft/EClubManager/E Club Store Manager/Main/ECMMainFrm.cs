using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace E_Club_Store_Manager
{
    public partial class ECMMainFrm : Form
    {
        #region -   Functions   -
        public ECMMainFrm()
        {
            InitializeComponent();
        }
        #endregion
        #region -   Event Handlers   -
        public void RebuildForms()
        {
            Program.MC.FrmEditorYear = new EditorYearFrm();
            Program.MC.FrmEditorAccountNature = new EditorAccountNatureFrm();
            Program.MC.FrmEditorSalesUnit = new EditorSalesUnitFrm();
            Program.MC.FrmEditorStore = new EditorStoreFrm();
            Program.MC.FrmEditorBank = new EditorBankFrm();
            Program.MC.FrmEditorCustomer = new EditorCustomerFrm();
            Program.MC.FrmEditorCategories = new EditorCategoriesFrm();
            Program.MC.FrmEditorSuppliers = new EditorSuppliersFrm();
            Program.MC.FrmEditorCompanies = new EditorCompaniesFrm();
            Program.MC.FrmDataAsnaf = new DataAsnafFrm();
            Program.MC.FrmDataBill = new DataBillFrm();
            Program.MC.FrmEditorBillPayTypes = new EditorBillPayTypesFrm();
            Program.MC.FrmEditorJob = new EditorJobFrm();
            Program.MC.FrmDataEmp = new DataEmpFrm();
            Program.MC.FrmDataSellBill = new DataSellBillFrm();
            //Queries
            
        }
        private void ECMMainFrm_Load(object sender, EventArgs e)
        {
            RebuildForms();
            //Program.MC.FrmSplash = new SplashFrm();
            //Program.MC.FrmSplash.ShowDialog();
            this.IsMdiContainer = true;
            // Load Data From Registry
            Program.MC.SQLConStrG_Accounts = MCls.GetRegValue(MCls.RegKeyValues.SQLStringG_Accounts.ToString());
            Program.MC.ReportURL = MCls.GetRegValue(MCls.RegKeyValues.ReportUrl.ToString());
            Program.MC.ReportPath = MCls.GetRegValue(MCls.RegKeyValues.ReportPath.ToString());
            if (Program.MC.SQLConStrG_Accounts == string.Empty || Program.MC.ReportURL == string.Empty || Program.MC.ReportPath == string.Empty)
            {
                Program.MC.FrmSQLConnection = new SQLConnectionFrm();
                Program.MC.FrmSQLConnection.FullConString = Program.MC.SQLConStrG_Accounts;
                Program.MC.FrmSQLConnection.DatabaseName = "G_Accounts";
                Program.MC.FrmSQLConnection.RegKeyName = MCls.RegKeyValues.SQLStringG_Accounts.ToString();
                Program.MC.FrmSQLConnection.OFDInitialDirectory = "C:\\ECM\\Database";
                Program.MC.FrmSQLConnection.ShowDialog();
                Application.Exit();
            }
        }
        private void ECMMainFrm_Activated(object sender, EventArgs e)
        {
            if (Program.MC.UserInfo.UserID == null)
            {
                LoginFrm Log = new LoginFrm();
                Log.ShowDialog();
            }
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
            if (MessageBox.Show("Are You Sure ..!", "Restart Confirmation..", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
            {
                MCls.ResetConnection();
                Application.Restart();
            }
        }
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void editorMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void editorMembershipToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void editorDependentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void editorAttachmentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void cardsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("E-E-Soft Co. \n  Test Version ...");
        }
        private void accountsTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void constraintsDailyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void editorYearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.MC.FrmEditorYear.IsDisposed)
            {
                Program.MC.FrmEditorYear = new EditorYearFrm();
                Program.MC.FrmEditorYear.MdiParent = this;
                Program.MC.FrmEditorYear.Show();
            }
            else
            {
                if (Program.MC.FrmEditorYear.Visible)
                {
                    Program.MC.FrmEditorYear.WindowState = FormWindowState.Normal;
                    Program.MC.FrmEditorYear.Focus();
                }
                else
                {
                    Program.MC.FrmEditorYear.MdiParent = this;
                    Program.MC.FrmEditorYear.Show();
                }
            }
        }
        private void editorAccountNatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.MC.FrmEditorAccountNature.IsDisposed)
            {
                Program.MC.FrmEditorAccountNature = new EditorAccountNatureFrm();
                Program.MC.FrmEditorAccountNature.MdiParent = this;
                Program.MC.FrmEditorAccountNature.Show();
            }
            else
            {
                if (Program.MC.FrmEditorAccountNature.Visible)
                {
                    Program.MC.FrmEditorAccountNature.WindowState = FormWindowState.Normal;
                    Program.MC.FrmEditorAccountNature.Focus();
                }
                else
                {
                    Program.MC.FrmEditorAccountNature.MdiParent = this;
                    Program.MC.FrmEditorAccountNature.Show();
                }
            }
        }
        private void EditorsalesUnitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.MC.FrmEditorSalesUnit.IsDisposed)
            {
                Program.MC.FrmEditorSalesUnit = new EditorSalesUnitFrm();
                Program.MC.FrmEditorSalesUnit.MdiParent = this;
                Program.MC.FrmEditorSalesUnit.Show();
            }
            else
            {
                if (Program.MC.FrmEditorSalesUnit.Visible)
                {
                    Program.MC.FrmEditorSalesUnit.WindowState = FormWindowState.Normal;
                    Program.MC.FrmEditorSalesUnit.Focus();
                }
                else
                {
                    Program.MC.FrmEditorSalesUnit.MdiParent = this;
                    Program.MC.FrmEditorSalesUnit.Show();
                }
            }
        }
        private void editorStoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.MC.FrmEditorStore.IsDisposed)
            {
                Program.MC.FrmEditorStore = new EditorStoreFrm();
                Program.MC.FrmEditorStore.MdiParent = this;
                Program.MC.FrmEditorStore.Show();
            }
            else
            {
                if (Program.MC.FrmEditorStore.Visible)
                {
                    Program.MC.FrmEditorStore.WindowState = FormWindowState.Normal;
                    Program.MC.FrmEditorStore.Focus();
                }
                else
                {
                    Program.MC.FrmEditorStore.MdiParent = this;
                    Program.MC.FrmEditorStore.Show();
                }
            }
        }
        private void banksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.MC.FrmEditorBank.IsDisposed)
            {
                Program.MC.FrmEditorBank = new EditorBankFrm();
                Program.MC.FrmEditorBank.MdiParent = this;
                Program.MC.FrmEditorBank.Show();
            }
            else
            {
                if (Program.MC.FrmEditorBank.Visible)
                {
                    Program.MC.FrmEditorBank.WindowState = FormWindowState.Normal;
                    Program.MC.FrmEditorBank.Focus();
                }
                else
                {
                    Program.MC.FrmEditorBank.MdiParent = this;
                    Program.MC.FrmEditorBank.Show();
                }
            }
        }
        private void editorCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.MC.FrmEditorCustomer.IsDisposed)
            {
                Program.MC.FrmEditorCustomer = new EditorCustomerFrm();
                Program.MC.FrmEditorCustomer.MdiParent = this;
                Program.MC.FrmEditorCustomer.Show();
            }
            else
            {
                if (Program.MC.FrmEditorCustomer.Visible)
                {
                    Program.MC.FrmEditorCustomer.WindowState = FormWindowState.Normal;
                    Program.MC.FrmEditorCustomer.Focus();
                }
                else
                {
                    Program.MC.FrmEditorCustomer.MdiParent = this;
                    Program.MC.FrmEditorCustomer.Show();
                }
            }
        }
        private void editorCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.MC.FrmEditorCategories.IsDisposed)
            {
                Program.MC.FrmEditorCategories = new EditorCategoriesFrm();
                Program.MC.FrmEditorCategories.MdiParent = this;
                Program.MC.FrmEditorCategories.Show();
            }
            else
            {
                if (Program.MC.FrmEditorCategories.Visible)
                {
                    Program.MC.FrmEditorCategories.WindowState = FormWindowState.Normal;
                    Program.MC.FrmEditorCategories.Focus();
                }
                else
                {
                    Program.MC.FrmEditorCategories.MdiParent = this;
                    Program.MC.FrmEditorCategories.Show();
                }
            }
        }
        private void editorSuppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.MC.FrmEditorSuppliers.IsDisposed)
            {
                Program.MC.FrmEditorSuppliers = new EditorSuppliersFrm();
                Program.MC.FrmEditorSuppliers.MdiParent = this;
                Program.MC.FrmEditorSuppliers.Show();
            }
            else
            {
                if (Program.MC.FrmEditorSuppliers.Visible)
                {
                    Program.MC.FrmEditorSuppliers.WindowState = FormWindowState.Normal;
                    Program.MC.FrmEditorSuppliers.Focus();
                }
                else
                {
                    Program.MC.FrmEditorSuppliers.MdiParent = this;
                    Program.MC.FrmEditorSuppliers.Show();
                }
            }
        }
        private void EditorCompaniesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.MC.FrmEditorCompanies.IsDisposed)
            {
                Program.MC.FrmEditorCompanies = new EditorCompaniesFrm();
                Program.MC.FrmEditorCompanies.MdiParent = this;
                Program.MC.FrmEditorCompanies.Show();
            }
            else
            {
                if (Program.MC.FrmEditorCompanies.Visible)
                {
                    Program.MC.FrmEditorCompanies.WindowState = FormWindowState.Normal;
                    Program.MC.FrmEditorCompanies.Focus();
                }
                else
                {
                    Program.MC.FrmEditorCompanies.MdiParent = this;
                    Program.MC.FrmEditorCompanies.Show();
                }
            }
        }
        private void dataAsnafToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.MC.FrmDataAsnaf.IsDisposed)
            {
                Program.MC.FrmDataAsnaf = new DataAsnafFrm();
                Program.MC.FrmDataAsnaf.MdiParent = this;
                Program.MC.FrmDataAsnaf.Show();
            }
            else
            {
                if (Program.MC.FrmDataAsnaf.Visible)
                {
                    Program.MC.FrmDataAsnaf.WindowState = FormWindowState.Normal;
                    Program.MC.FrmDataAsnaf.Focus();
                }
                else
                {
                    Program.MC.FrmDataAsnaf.MdiParent = this;
                    Program.MC.FrmDataAsnaf.Show();
                }
            }
        }
        private void dataBuyBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.MC.FrmDataBill.IsDisposed)
            {
                Program.MC.FrmDataBill = new DataBillFrm();
                Program.MC.FrmDataBill.MdiParent = this;
                Program.MC.FrmDataBill.Show();
            }
            else
            {
                if (Program.MC.FrmDataBill.Visible)
                {
                    Program.MC.FrmDataBill.WindowState = FormWindowState.Normal;
                    Program.MC.FrmDataBill.Focus();
                }
                else
                {
                    Program.MC.FrmDataBill.MdiParent = this;
                    Program.MC.FrmDataBill.Show();
                }
            }
        }
        private void billPayTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.MC.FrmEditorBillPayTypes.IsDisposed)
            {
                Program.MC.FrmEditorBillPayTypes = new EditorBillPayTypesFrm();
                Program.MC.FrmEditorBillPayTypes.MdiParent = this;
                Program.MC.FrmEditorBillPayTypes.Show();
            }
            else
            {
                if (Program.MC.FrmEditorBillPayTypes.Visible)
                {
                    Program.MC.FrmEditorBillPayTypes.WindowState = FormWindowState.Normal;
                    Program.MC.FrmEditorBillPayTypes.Focus();
                }
                else
                {
                    Program.MC.FrmEditorBillPayTypes.MdiParent = this;
                    Program.MC.FrmEditorBillPayTypes.Show();
                }
            }
        }
        private void editJobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.MC.FrmEditorJob.IsDisposed)
            {
                Program.MC.FrmEditorJob = new EditorJobFrm();
                Program.MC.FrmEditorJob.MdiParent = this;
                Program.MC.FrmEditorJob.Show();
            }
            else
            {
                if (Program.MC.FrmEditorJob.Visible)
                {
                    Program.MC.FrmEditorJob.WindowState = FormWindowState.Normal;
                    Program.MC.FrmEditorJob.Focus();
                }
                else
                {
                    Program.MC.FrmEditorJob.MdiParent = this;
                    Program.MC.FrmEditorJob.Show();
                }
            }
        }
        private void editEmpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.MC.FrmDataEmp.IsDisposed)
            {
                Program.MC.FrmDataEmp = new DataEmpFrm();
                Program.MC.FrmDataEmp.MdiParent = this;
                Program.MC.FrmDataEmp.Show();
            }
            else
            {
                if (Program.MC.FrmDataEmp.Visible)
                {
                    Program.MC.FrmDataEmp.WindowState = FormWindowState.Normal;
                    Program.MC.FrmDataEmp.Focus();
                }
                else
                {
                    Program.MC.FrmDataEmp.MdiParent = this;
                    Program.MC.FrmDataEmp.Show();
                }
            }
        }
        private void sellBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.MC.FrmDataSellBill.IsDisposed)
            {
                Program.MC.FrmDataSellBill = new DataSellBillFrm();
                Program.MC.FrmDataSellBill.MdiParent = this;
                Program.MC.FrmDataSellBill.Show();
            }
            else
            {
                if (Program.MC.FrmDataSellBill.Visible)
                {
                    Program.MC.FrmDataSellBill.WindowState = FormWindowState.Normal;
                    Program.MC.FrmDataSellBill.Focus();
                }
                else
                {
                    Program.MC.FrmDataSellBill.MdiParent = this;
                    Program.MC.FrmDataSellBill.Show();
                }
            }
        }
        #endregion
    }
}