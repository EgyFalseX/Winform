using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Xpo.Metadata;

namespace NestleMenu.Forms.Data
{
    public partial class MenuOrderEditorFrm : DevExpress.XtraEditors.XtraForm
    {
        #region - Var -
        #endregion
        #region - Fun -
        public MenuOrderEditorFrm()
        {
            InitializeComponent();
            sessionData.ConnectionString = Properties.Settings.Default.NestleMenuConnectionString;
        }
        void LoadData()
        {
            //sessionData.DropIdentityMap();
            //sessionData.get
            dsXPData.Session.DropIdentityMap();
            dsXPData.Reload();
            gridViewMain.BestFitColumns();
        }
        void LoadDefaultData()
        {
            // TODO: This line of code loads data into the 'dsNU.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.dsNU.Employee);
            // TODO: This line of code loads data into the 'dsNU.MenuTheme' table. You can move, or remove it, as needed.
            this.menuThemeTableAdapter.Fill(this.dsNU.MenuTheme);
            // TODO: This line of code loads data into the 'dsNU.MenuSize' table. You can move, or remove it, as needed.
            this.menuSizeTableAdapter.Fill(this.dsNU.MenuSize);
            // TODO: This line of code loads data into the 'dsNU.Branch' table. You can move, or remove it, as needed.
            //this.branchTableAdapter.Fill(this.dsNU.Branch);
        }
        #endregion
        #region -  EventWhnd - 
        private void JobEditorFrm_Load(object sender, EventArgs e)
        {
            LoadDefaultData();
            LoadData();
        }
        private void bbiNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                MenuOrderWiz frm = new MenuOrderWiz(-1);
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                    return;
                LoadData();
                NU.LogMessage("New Menu Order Added ...", this, Utilities.Types.MessageType.Success, Utilities.Types.MessagePopupType.Alert);
            }
            catch (Exception ex)
            {
                NU.LogMessage(ex.Message, this, Utilities.Types.MessageType.Error, Utilities.Types.MessagePopupType.Message, ex);
            }
        }
        private void repositoryItemButtonEditEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                XPDataTableObject row = gridViewMain.GetRow(gridViewMain.FocusedRowHandle) as XPDataTableObject;
                int ID = (int)row.GetMemberValue("MenuOrderId");

                MenuOrderWiz frm = new MenuOrderWiz(ID);
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                    return;
                LoadData();
                NU.LogMessage("Menu Order Changed ...", this, Utilities.Types.MessageType.Success, Utilities.Types.MessagePopupType.Alert);
            }
            catch (Exception ex)
            {
                NU.LogMessage(ex.Message, this, Utilities.Types.MessageType.Error, Utilities.Types.MessagePopupType.Message, ex);
            }
        }
        private void repositoryItemButtonEditDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (msgDlg.Show("Are You Sure?", msgDlg.msgButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                return;
            try
            {
                 XPDataTableObject row = gridViewMain.GetRow(gridViewMain.FocusedRowHandle) as XPDataTableObject;
                int ID = (int)row.GetMemberValue("MenuOrderId");
                menuOrderTableAdapter.Delete(ID);
                gridViewMain.DeleteRow(gridViewMain.FocusedRowHandle);
                NU.LogMessage("Menu Order Deleted ...", this, Utilities.Types.MessageType.Success, Utilities.Types.MessagePopupType.Alert);
            }
            catch (Exception ex)
            {
                NU.LogMessage(ex.Message, this, Utilities.Types.MessageType.Error, Utilities.Types.MessagePopupType.Message, ex);
            }
        }
        private void bbiExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Check whether the GridControl can be previewed.
            if (!gridControlMain.IsPrintingAvailable)
            {
                NU.LogMessage("The 'DevExpress.XtraPrinting' library is not found", this, Utilities.Types.MessageType.Error, Utilities.Types.MessagePopupType.Message);
                return;
            }
            // Open the Preview window.
            gridControlMain.ShowRibbonPrintPreview();
        }
        #endregion
    }
}
