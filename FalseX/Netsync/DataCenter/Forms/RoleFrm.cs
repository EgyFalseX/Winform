using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DataCenter.Managers;

namespace DataCenter.Forms
{
    public partial class RoleFrm : DevExpress.XtraEditors.XtraForm
    {

        public RoleFrm()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            // TODO: This line of code loads data into the 'dsDataCenter.Roles' table. You can move, or remove it, as needed.
            this.rolesTableAdapter.Fill(this.dsDataCenter.Roles);
        }
        private void FileTypeFrm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void gridViewData_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            DataRowView DRV = (DataRowView)e.Row;
            if (e.ErrorText.Contains("id"))
            {
                e.ErrorText = "";
                return;
            }
        }
        private void gridViewData_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DataSources.dsDataCenter.RolesRow row = (DataSources.dsDataCenter.RolesRow)gridViewData.GetDataRow(e.RowHandle);
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView GV = (GridView)gridControlData.MainView;
            DataSources.dsDataCenter.RolesRow row = (DataSources.dsDataCenter.RolesRow)GV.GetFocusedDataRow();
            try
            {
                row.RoleID = (int)AppManager.defaultInstance.adpQry.ScalarQueryRolesNewId();
                rolesBindingSource.EndEdit();
                rolesTableAdapter.Update(row);
                dsDataCenter.Roles.AcceptChanges();
                DataCenterX.LogMessage("تم تعديل المجموعات", typeof(RoleFrm), nsLib.Utilities.Types.MessageType.Success, null, true);
                LoadData();
            }
            catch (SqlException ex)
            {
                DataCenterX.LogMessage("لم يتم تعديل المجموعات", typeof(RoleFrm), nsLib.Utilities.Types.MessageType.Error, ex, true);
            }
        }
        private void repositoryItemButtonEditDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            GridView GV = (GridView)gridControlData.MainView;
            DataSources.dsDataCenter.RolesRow row = (DataSources.dsDataCenter.RolesRow)GV.GetFocusedDataRow();
            try
            {
                rolesTableAdapter.Delete(row.RoleID);
                gridViewData.DeleteRow(gridViewData.FocusedRowHandle);
                LoadData();
                DataCenterX.LogMessage("تم حذف المجموعة", typeof(RoleFrm), nsLib.Utilities.Types.MessageType.Success, null, true);
            }
            catch (SqlException ex)
            {
                DataCenterX.LogMessage("لم يتم حذف المجموعة", typeof(RoleFrm), nsLib.Utilities.Types.MessageType.Error, ex, true);
            }
        }
        
    }
}
