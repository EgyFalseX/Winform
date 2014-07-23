using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using log4net;
using DataCenter.Managers;

namespace DataCenter.Forms
{
    public partial class ImageViewerFrm : DevExpress.XtraEditors.XtraForm
    {

        private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(typeof(CategoryPermissionEditorDLG));
        DataSources.dsQueries.QryItemsRow _row;
        nsLib.Utilities.UpdateInfo notify;
        System.IO.MemoryStream ms;
        
        public ImageViewerFrm(DataSources.dsQueries.QryItemsRow row)
        {
            InitializeComponent();

            _row = row;
            notify = new nsLib.Utilities.UpdateInfo();
            notify.AddItem(false); notify.AddItem(false);
            notify.AddItem(pbc.Properties.Maximum); notify.AddItem(pbc.EditValue);
        }
        private void ImageViewerFrm_Load(object sender, EventArgs e)
        {
            LoadFile();
        }
        private void LoadFile()
        {
            notify.SetValue(0, false); notify.SetValue(1, false);
            ms = new System.IO.MemoryStream();
            notify.OnItemChanged += notifyDownload_OnItemChanged;
            DataCenterX.NSManager.C_ReciveFile(ms, AppManager.defaultInstance.GetServerOption(nsLib.Utilities.Types.ServerOptions.FilesPath) + _row.PhysicalName, ref notify);
        }
        void notifyDownload_OnItemChanged(int index, object value)
        {
            switch (index)
            {
                case 0://Complate
                    this.Invoke(new MethodInvoker(() =>
                    {
                        pbc.Visible = false;
                        if ((bool)value)
                            DataCenterX.LogMessage("تم تحميل الملف", typeof(ImageViewerFrm), nsLib.Utilities.Types.MessageType.Success);
                        else
                            DataCenterX.LogMessage("لم يتم تحميل الملف", typeof(ImageViewerFrm), nsLib.Utilities.Types.MessageType.Error, null, true);
                        ViewFile();
                    })
                   );
                    notify.OnItemChanged -= notifyDownload_OnItemChanged;
                    break;
                case 1://Cancel
                    if ((bool)value)
                    {
                        this.Invoke(new MethodInvoker(() =>
                        {
                            pbc.Visible = false;
                        }));
                    }
                    notify.OnItemChanged -= notifyDownload_OnItemChanged;
                    break;
                case 2://Progress Max Value
                    pbc.Invoke(new MethodInvoker(() => { pbc.Properties.Maximum = Convert.ToInt32(value); }));
                    break;
                case 3://Progress Value
                    pbc.Invoke(new MethodInvoker(() => { pbc.EditValue = Convert.ToInt32(value); }));
                    break;
            }
        }
        void ViewFile()
        {
            try
            {
                peImage.Image = Image.FromStream(ms);
            }
            catch (Exception ex)
            {
                DataCenterX.LogMessage("لم يتم عرض الملف", typeof(ImageViewerFrm), nsLib.Utilities.Types.MessageType.Error, ex, true);
            }
        }

        private void btnClip_Click(object sender, EventArgs e)
        {
            peImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Clip;
        }
        private void btnStretch_Click(object sender, EventArgs e)
        {
            peImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;

        }
        private void btnZoom_Click(object sender, EventArgs e)
        {
            peImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;

        }
        private void btnSqueeze_Click(object sender, EventArgs e)
        {
            peImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;

        }

    }
}