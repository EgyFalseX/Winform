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
    public partial class UsersFrm : DevExpress.XtraEditors.XtraForm
    {
        public UsersFrm()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            // TODO: This line of code loads data into the 'dsDataCenter.UserLevel' table. You can move, or remove it, as needed.
            this.userLevelTableAdapter.Fill(this.dsDataCenter.UserLevel);
        }
        private void FileTypeFrm_Load(object sender, EventArgs e)
        {
            LoadData();
            // TODO: This line of code loads data into the 'dsDataCenter.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.dsDataCenter.Users);
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
            DataSources.dsDataCenter.UsersRow row = (DataSources.dsDataCenter.UsersRow)gridViewData.GetDataRow(e.RowHandle);
            row.UserLevelId = (int)nsLib.Utilities.Types.UserLevelType.User;
            row.IsActive = true;
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView GV = (GridView)gridControlData.MainView;
            DataSources.dsDataCenter.UsersRow row = (DataSources.dsDataCenter.UsersRow)GV.GetFocusedDataRow();
            try
            {
                row.UserID = (int)AppManager.defaultInstance.adpQry.ScalarQueryUsersNewId();

                usersBindingSource.EndEdit();
                usersTableAdapter.Update(row);
                dsDataCenter.Users.AcceptChanges();
                DataCenterX.LogMessage("تم تعديل المستخدمين", typeof(UsersFrm), nsLib.Utilities.Types.MessageType.Success, null, true);
                LoadData();
            }
            catch (SqlException ex)
            {
                DataCenterX.LogMessage("لم يتم تعديل المستخدمين", typeof(UsersFrm), nsLib.Utilities.Types.MessageType.Error, ex, true);
            }
        }
        private void repositoryItemButtonEditDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            GridView GV = (GridView)gridControlData.MainView;
            DataSources.dsDataCenter.UsersRow row = (DataSources.dsDataCenter.UsersRow)GV.GetFocusedDataRow();
            try
            {
                usersTableAdapter.Delete(row.UserID);
                gridViewData.DeleteRow(gridViewData.FocusedRowHandle);
                LoadData();
                DataCenterX.LogMessage("تم حذف المستخدم", typeof(UsersFrm), nsLib.Utilities.Types.MessageType.Success, null, true);
            }
            catch (SqlException ex)
            {
                DataCenterX.LogMessage("لم يتم حذف المستخدم", typeof(UsersFrm), nsLib.Utilities.Types.MessageType.Error, ex, true);
            }
        }
        
    }
}
