using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DataCenter.Managers;

namespace DataCenter.Forms
{
    public partial class CategoryEditorDLG : DevExpress.XtraEditors.XtraForm
    {

        #region -   Variables   -
        DataSources.dsDataCenter.CategoryRow _row;
        DataSources.dsDataCenterTableAdapters.IconsTableAdapter adpIcon = new DataSources.dsDataCenterTableAdapters.IconsTableAdapter();
        #endregion
        #region -   Functions   -
        public CategoryEditorDLG(DataSources.dsDataCenter.CategoryRow row)
        {
            InitializeComponent();
            _row = row;
        }
        private void LoadIcon()
        {
             DataSources.dsDataCenter.IconsDataTable dtIcon = new DataSources.dsDataCenter.IconsDataTable();
            this.adpIcon.Fill(dtIcon);
            foreach (DataSources.dsDataCenter.IconsRow row in dtIcon.Rows)
            {
                if (row.IsIconDataNull())
                    return;
                MemoryStream imgStream = new MemoryStream(row.IconData);
                Image img = Image.FromStream(imgStream);
                imageCollectionIcon.AddImage(img);
                icbeIconId.Properties.Items.Add(new ImageComboBoxItem(row.IconName, row.IconId, imageCollectionIcon.Images.Count - 1));
            }
           
        }
        private void BindingsCollection()
        {
            DataSources.dsDataCenterTableAdapters.CategoryTableAdapter adpCat = new DataSources.dsDataCenterTableAdapters.CategoryTableAdapter();
           
            if (!_row.IsNull("CategoryName"))
                tbCategoryName.EditValue = _row.CategoryName;

            if (!_row.IsNull("CreateIn"))
                lblCreateIn.Text = _row.CreateIn.ToString();

            if (!_row.IsNull("ModifyIn"))
                lblModifyIn.Text = _row.ModifyIn.ToString();

            if (!_row.IsNull("UserIn"))
                lblUserIn.Text = new DataSources.dsDataCenterTableAdapters.UsersTableAdapter().ScalarQueryUserID(_row.UserIn);

            if (!_row.IsNull("ParentID"))
                lblParentName.Text = adpCat.ScalarQueryCategoryName(_row.ParentID);

            if (!_row.IsNull("Info"))
                tbInfo.EditValue = _row.Info;

            if (!_row.IsNull("IconId"))
                icbeIconId.EditValue = _row.IconId;


            if (_row.RowState != DataRowState.Detached)
            {
                lblCategoryCount.Text = adpCat.ScalarQueryCategoryCount(_row.CategoryId).ToString();
                lblItemCount.Text = adpCat.ScalarQueryItemCount(_row.CategoryId).ToString();
            }

        }
        #endregion
        #region - Event Handlers -
        private void CategoryEditorDLG_Load(object sender, EventArgs e)
        {
            LoadIcon();
            BindingsCollection();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;

            if (tbCategoryName.EditValue != null)
                _row.CategoryName = tbCategoryName.EditValue.ToString();
            
            _row.ModifyIn = AppManager.defaultInstance.ServerDateTime();

            if (_row.RowState == DataRowState.Detached)
            {
                _row.OwnerId = UserManager.defaultInstance.UserInfo.UserID;
                _row.CreateIn = _row.ModifyIn;
            }

            _row.UserIn = UserManager.defaultInstance.UserInfo.UserID;

            if (tbInfo.EditValue != null)
                _row.Info = tbInfo.EditValue.ToString();

            if (icbeIconId.EditValue != null)
                _row.IconId = Convert.ToInt32(icbeIconId.EditValue);

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
        #endregion

    }
}
