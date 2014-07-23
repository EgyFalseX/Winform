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

namespace GM.Forms.Code
{
    public partial class UserRoleEditorFrm : DevExpress.XtraEditors.XtraForm
    {
        #region - Var -
        #endregion
        #region - Fun -
        public UserRoleEditorFrm()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            this.roleTableAdapter.Fill(this.dsGM.Role);
            this.userTableAdapter.Fill(this.dsGM.User);
            gridViewMain.BestFitColumns();
        }
        #endregion
        #region -  EventWhnd - 
        private void AreaEditorFrm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void bbiLueUser_EditValueChanged(object sender, EventArgs e)
        {
            if (bbiLueUser.EditValue == null)
                return;
            this.userRoleTableAdapter.FillByUser(this.dsGM.UserRole, Convert.ToInt32(bbiLueUser.EditValue));
            bbiNew.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
        }
        private void bbiNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                DataSources.dsGM.UserRoleRow row = dsGM.UserRole.NewUserRoleRow();
                row.Role = -1;
                UserRoleEditorWFrm frm = new UserRoleEditorWFrm(row);
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                    return;
                row.User = Convert.ToInt32(bbiLueUser.EditValue);
                dsGM.UserRole.AddUserRoleRow(row);
                row.EndEdit();
                userRoleTableAdapter.Update(row);
                Glob.LogMessage("تم اضافة الصلاحية ...", this, Utilities.Types.MessageType.Success, Utilities.Types.MessagePopupType.Alert);
            }
            catch (Exception ex)
            {
                Glob.LogMessage(ex.Message, this, Utilities.Types.MessageType.Error, Utilities.Types.MessagePopupType.Message, ex);
            }
        }
        private void repositoryItemButtonEditEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                DataSources.dsGM.UserRoleRow row = (DataSources.dsGM.UserRoleRow)((DataRowView)gridViewMain.GetRow(gridViewMain.FocusedRowHandle)).Row;
                UserRoleEditorWFrm frm = new UserRoleEditorWFrm(row);
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                    return;
                row.EndEdit();
                userRoleTableAdapter.Update(row);
                Glob.LogMessage("تم تعديل الصلاحية ...", this, Utilities.Types.MessageType.Success, Utilities.Types.MessagePopupType.Alert);
            }
            catch (Exception ex)
            {
                Glob.LogMessage(ex.Message, this, Utilities.Types.MessageType.Error, Utilities.Types.MessagePopupType.Message, ex);
            }
        }
        private void repositoryItemButtonEditDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (msgDlg.Show("هل انت متأكد؟", msgDlg.msgButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                return;
            try
            {
                DataSources.dsGM.UserRoleRow row = (DataSources.dsGM.UserRoleRow)((DataRowView)gridViewMain.GetRow(gridViewMain.FocusedRowHandle)).Row;
                if (row.RowState == DataRowState.Added || row.RowState == DataRowState.Detached)
                    return;
                userRoleTableAdapter.Delete(row.User, row.Role);
                gridViewMain.DeleteRow(gridViewMain.FocusedRowHandle);
                Glob.LogMessage("تم حذف الصلاحية ...", this, Utilities.Types.MessageType.Success, Utilities.Types.MessagePopupType.Alert);
            }
            catch (Exception ex)
            {
                Glob.LogMessage(ex.Message, this, Utilities.Types.MessageType.Error, Utilities.Types.MessagePopupType.Message, ex);
            }
        }
        private void bbiExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Check whether the GridControl can be previewed.
            if (!gridControlMain.IsPrintingAvailable)
            {
                Glob.LogMessage("The 'DevExpress.XtraPrinting' library is not found", this, Utilities.Types.MessageType.Error, Utilities.Types.MessagePopupType.Message);
                return;
            }
            // Open the Preview window.
            gridControlMain.ShowRibbonPrintPreview();
        }
        #endregion
        
    }
        
} 
