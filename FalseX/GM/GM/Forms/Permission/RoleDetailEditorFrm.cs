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
    public partial class RoleDetailEditorFrm : DevExpress.XtraEditors.XtraForm
    {
        #region - Var -
        #endregion
        #region - Fun -
        public RoleDetailEditorFrm()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            this.roleTableAdapter.Fill(this.dsGM.Role);
        }
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
                //for (int i = 0; i < appMenu.ItemLinks.Count; i++)
                //{
                //    appMenu.ItemLinks[i].Item.ItemClick += Item_ItemDoubleClick;
                //}
            }
            DisableMenu();
        }
        private void FillRoleDetial()
        {
            DisableMenu();
            for (int menuIndex = 0; menuIndex < ribbonControl.Items.Count; menuIndex++)
            {
                for (int rowIndex = 0; rowIndex < dsGM.RoleDetail.Rows.Count; rowIndex++)
                {
                    DataSources.dsGM.RoleDetailRow row = (DataSources.dsGM.RoleDetailRow)dsGM.RoleDetail.Rows[rowIndex];
                    if (ribbonControl.Items[menuIndex].Name == row.RoleDetailName)
                    {
                        ribbonControl.Items[menuIndex].ImageIndex = (int)ribbonControl.Items[menuIndex].Tag;
                        ribbonControl.Items[menuIndex].LargeImageIndex = (int)ribbonControl.Items[menuIndex].Tag;
                    }
                }
            }
        }
        #endregion
        #region -  EventWhnd - 
        private void Frm_Load(object sender, EventArgs e)
        {
            LoadData();
            PrepareMenu();
            ribbonControl.Enabled = false;
        }
        private void bbiLueRole_EditValueChanged(object sender, EventArgs e)
        {
            if (bbiLueRole.EditValue == null)
                return;
            ribbonControl.Enabled = true;
            roleDetailTableAdapter.FillByRoleId(dsGM.RoleDetail, Convert.ToInt32(bbiLueRole.EditValue));
            FillRoleDetial();
        }
        private void Item_ItemDoubleClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int id = (int)roleDetailTableAdapter.NewId();
            roleDetailTableAdapter.Insert(id, Convert.ToInt32(bbiLueRole.EditValue), e.Item.Name);
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
