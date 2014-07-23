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

namespace DataCenter.Forms
{
    public partial class FileTypeFrm : DevExpress.XtraEditors.XtraForm
    {
        public FileTypeFrm()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            // TODO: This line of code loads data into the 'dsDataCenter.Types' table. You can move, or remove it, as needed.
            this.typesTableAdapter.Fill(this.dsDataCenter.Types);
        }
        byte[] resizeImage(byte[] byt)
        { 
            System.IO.MemoryStream ms = new System.IO.MemoryStream(byt);
            System.IO.MemoryStream Newms = new System.IO.MemoryStream();
            Image img = Image.FromStream(ms).GetThumbnailImage(32, 32, null, IntPtr.Zero);
            img.Save(Newms, System.Drawing.Imaging.ImageFormat.Png);
            return Newms.ToArray();
        }
        private void FileTypeFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsDataCenter.AssociationApp' table. You can move, or remove it, as needed.
            this.associationAppTableAdapter.Fill(this.dsDataCenter.AssociationApp);
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
            DataSources.dsDataCenter.TypesRow row = (DataSources.dsDataCenter.TypesRow)gridViewData.GetDataRow(e.RowHandle);
            row.active = true; row.AssociationId = 0; 
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            
            GridView GV = (GridView)gridControlData.MainView;
            DataSources.dsDataCenter.TypesRow row = (DataSources.dsDataCenter.TypesRow)GV.GetFocusedDataRow();
            try
            {
                if (!row.IsTypeIconDataNull())
                    row.TypeIconData = resizeImage(row.TypeIconData);

                typesBindingSource.EndEdit();
                typesTableAdapter.Update(row);
                dsDataCenter.Types.AcceptChanges();
                DataCenterX.LogMessage("تم تعدبل الانواع", typeof(FileTypeFrm), nsLib.Utilities.Types.MessageType.Success, null, true);
                LoadData();
            }
            catch (SqlException ex)
            {
                DataCenterX.LogMessage("لم يتم تعدبل الانواع", typeof(FileTypeFrm), nsLib.Utilities.Types.MessageType.Error, ex, true);
            }
        }
        private void repositoryItemButtonEditDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            GridView GV = (GridView)gridControlData.MainView;
            DataSources.dsDataCenter.TypesRow row = (DataSources.dsDataCenter.TypesRow)GV.GetFocusedDataRow();
            try
            {
                row.active = false;
                typesBindingSource.EndEdit();
                typesTableAdapter.Update(row);
                dsDataCenter.Types.AcceptChanges();
                LoadData();
                DataCenterX.LogMessage("تم حذف النوع", typeof(FileTypeFrm), nsLib.Utilities.Types.MessageType.Success, null, true);
            }
            catch (SqlException ex)
            {
                DataCenterX.LogMessage("لم يتم حذف النوع", typeof(FileTypeFrm), nsLib.Utilities.Types.MessageType.Error, ex, true);
            }
        }
        
    }
}