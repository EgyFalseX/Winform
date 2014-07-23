using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.Reflection;
using System.Linq;
using DataCenter.Managers;

namespace DataCenter.Forms
{
    public partial class AppRoleFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        #endregion
        #region -   Functions   -
       
        private void DisableMenu()
        {
            for (int menuIndex = 0; menuIndex < ribbonControl.Items.Count; menuIndex++)
            {
                ribbonControl.Items[menuIndex].ImageIndex = -1; ribbonControl.Items[menuIndex].LargeImageIndex = -1;
            }
        }
        private void PrepareMenu()
        {
          
            for (int menuIndex = 0; menuIndex < ribbonControl.Items.Count; menuIndex++)
            {
                ribbonControl.Items[menuIndex].Tag = ribbonControl.Items[menuIndex].ImageIndex;
                ribbonControl.Items[menuIndex].ItemDoubleClick += Item_ItemDoubleClick;

                if (ribbonControl.Items[menuIndex].GetType() == typeof(DevExpress.XtraBars.BarSubItem))
                {
                    for (int i = 0; i < ((DevExpress.XtraBars.BarSubItem)ribbonControl.Items[menuIndex]).ItemLinks.Count; i++)
                        ((DevExpress.XtraBars.BarSubItem)ribbonControl.Items[menuIndex]).ItemLinks[i].Item.ItemClick += Item_ItemDoubleClick;
                }
                for (int i = 0; i < appMenu.ItemLinks.Count; i++)
                {
                    appMenu.ItemLinks[i].Item.ItemClick += Item_ItemDoubleClick;
                }
            }
            DisableMenu();
        }
        private void FillAppRole()
        {
            DisableMenu();
            for (int menuIndex = 0; menuIndex < ribbonControl.Items.Count; menuIndex++)
            {
                for (int rowIndex = 0; rowIndex < dsDataCenter.AppRole.Rows.Count; rowIndex++)
                {
                    DataSources.dsDataCenter.AppRoleRow row = (DataSources.dsDataCenter.AppRoleRow)dsDataCenter.AppRole.Rows[rowIndex];
                    if (ribbonControl.Items[menuIndex].Name == row.MenuItemName)
                    {
                        ribbonControl.Items[menuIndex].ImageIndex = (int)ribbonControl.Items[menuIndex].Tag;
                        ribbonControl.Items[menuIndex].LargeImageIndex = (int)ribbonControl.Items[menuIndex].Tag;
                        
                    }
                }
            }
        }
        public AppRoleFrm()
        {
            InitializeComponent();
        }
        private void ActivePriv()
        {
            bool Selecting = false, Inserting = false, Updateing = false, Deleting = false;
            DataManager.defaultInstance.GetFormPriv(UserManager.defaultInstance.UserInfo.UserID, this.Name, 
                ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
            LUEItems.Visible = Selecting;
            if (Inserting || Updateing || Deleting)
                ribbonControl.Visible = true;
            else
                ribbonControl.Visible = false;
        }
        #endregion
        #region -   Event Handlers   -
        private void EditorJobFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsDataCenter.Roles' table. You can move, or remove it, as needed.
            this.rolesTableAdapter.Fill(this.dsDataCenter.Roles);
            PrepareMenu();
            ActivePriv();
        }
        private void LUEItems_EditValueChanged(object sender, EventArgs e)
        {
            if (LUEItems.EditValue == null)
                return;
            appRoleTableAdapter.FillByRoleID(dsDataCenter.AppRole, Convert.ToInt32(LUEItems.EditValue));
            FillAppRole();
        }
        private void Item_ItemDoubleClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            appRoleTableAdapter.InsertQueryInsertOrDelete(Convert.ToInt32(LUEItems.EditValue), e.Item.Name, 
                CESelect.Checked, CEInsert.Checked, CEUpdate.Checked, CEDelete.Checked);
            if (e.Item.ImageIndex == -1)
            {
                e.Item.ImageIndex = (int)e.Item.Tag;
                e.Item.LargeImageIndex = (int)e.Item.Tag;
            }
            else
            {
                e.Item.ImageIndex = -1;
                e.Item.LargeImageIndex = -1;
            }
        }
        #endregion

    }
}