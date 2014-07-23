using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DbSyc_Client
{
    public partial class DbSycMainFrm : Form
    {
        public DbSycMainFrm()
        {
            InitializeComponent();
        }
        private void LoadList()
        {
            foreach (FileInfo fInfo in DataManager.DefaultInstance.FilesInformation)
            {
                LV.Items.Add(fInfo.FilePath, fInfo.Filename, 0);
            }
        }
        private void DbSycMainFrm_Load(object sender, EventArgs e)
        {
            LoadList();
        }
        private void LV_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                btnDownload.Enabled = true;
                btnDelete.Enabled = true;
            }
            else
            {
                btnDownload.Enabled = false;
                btnDelete.Enabled = false;
            }
        }
        private void LV_DragEnter(object sender, DragEventArgs e)
        {
            Array data = ((IDataObject)e.Data).GetData("FileName") as Array;
            if (data == null)
                e.Effect = DragDropEffects.None;
            else
            {
                if (System.IO.File.Exists(data.GetValue(0).ToString()))
                    e.Effect = DragDropEffects.Copy;
            }
        }
        private void LV_DragDrop(object sender, DragEventArgs e)
        {
            Array data = ((IDataObject)e.Data).GetData("FileName") as Array;
            if (data == null || !System.IO.File.Exists(data.GetValue(0).ToString()))
                return;
            FileInfo info = new FileInfo(System.IO.Path.GetFileName(data.GetValue(0).ToString()), System.IO.Path.GetFullPath(data.GetValue(0).ToString()));
            DataManager.DefaultInstance.FilesInformation.Add(info);
            LV.Items.Add(info.FilePath, info.Filename, 0);
            DataManager.DefaultInstance.Save();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }
            FileInfo info = new FileInfo(ofd.SafeFileName, ofd.FileName);
            DataManager.DefaultInstance.FilesInformation.Add(info);
            LV.Items.Add(info.FilePath, info.Filename, 0);
            DataManager.DefaultInstance.Save();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (LV.SelectedItems.Count == 0)
            {
                msgDlg.Show("Please Select File To Delete");
                return;
            }
            if (msgDlg.Show("Are You Sure?", msgDlg.msgButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                return;

            DataManager.DefaultInstance.FilesInformation.RemoveAt(LV.SelectedIndices[0]);
            LV.Items.RemoveAt(LV.SelectedIndices[0]);
            DataManager.DefaultInstance.Save();
        }
        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (msgDlg.Show("Are You Sure?", msgDlg.msgButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                return;
            pb.Visible = true;
            pnlCommand.Enabled = false;

            FileInfo FInfo = DataManager.DefaultInstance.FilesInformation[LV.SelectedIndices[0]];

            UpdateInfo infoDownload = new UpdateInfo();
            infoDownload.AddItem(false); infoDownload.AddItem(false);
            infoDownload.AddItem(pb.Maximum); infoDownload.AddItem(pb.Value);
            infoDownload.OnItemChanged += infoDownload_OnItemChanged;

            try { dataSyc.C_ReciveFile(FInfo.FilePath, FInfo.FilePath, ref infoDownload); }
            catch (Exception ex) { msgDlg.Show(ex.Message); pb.Visible = false; pnlCommand.Enabled = true; }
        }
        void infoDownload_OnItemChanged(int index, object value)
        {
            switch (index)
            {
                case 0://Complate
                    this.Invoke(new MethodInvoker(() =>
                        {
                            pb.Visible = false;
                            pnlCommand.Enabled = true;
                            msgDlg.Show("Transfer Complated ...");
                        }));
                    break;
                case 1://Cancled
                    this.Invoke(new MethodInvoker(() =>
                    {
                        pb.Visible = false;
                        pnlCommand.Enabled = true;
                        msgDlg.Show("Transfer Canceled ...");

                    }));
                    break;
                case 2://Progress Max Value
                    pb.Invoke(new MethodInvoker(() => { pb.Maximum = Convert.ToInt32(value); }));
                    break;
                case 3://Progress Value
                    pb.Invoke(new MethodInvoker(() => { pb.Value = Convert.ToInt32(value); }));
                    break;
            }
        }
        
        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (msgDlg.Show("Are You Sure?", msgDlg.msgButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                return;
            
            pb.Visible = true;
            pnlCommand.Enabled = false;

            FileInfo FInfo = DataManager.DefaultInstance.FilesInformation[LV.SelectedIndices[0]];

            UpdateInfo infoUpload = new UpdateInfo();
            infoUpload.AddItem(false); infoUpload.AddItem(false);
            infoUpload.AddItem(pb.Maximum); infoUpload.AddItem(pb.Value);
            infoUpload.OnItemChanged += infoUpload_OnItemChanged;

            try { dataSyc.C_SendFile(FInfo.FilePath, FInfo.FilePath, ref infoUpload); }
            catch (Exception ex) { msgDlg.Show(ex.Message); pb.Visible = false; pnlCommand.Enabled = true; }
            
        }
        void infoUpload_OnItemChanged(int index, object value)
        {
            switch (index)
            {
                case 0://Complate
                    this.Invoke(new MethodInvoker(() =>
                    {
                        pb.Visible = false;
                        pnlCommand.Enabled = true;
                        msgDlg.Show("Transfer Complated ...");
                    }));
                    break;
                case 1://Cancled
                    this.Invoke(new MethodInvoker(() =>
                    {
                        pb.Visible = false;
                        pnlCommand.Enabled = true;
                        msgDlg.Show("Transfer Canceled ...");

                    }));
                    break;
                case 2://Progress Max Value
                    pb.Invoke(new MethodInvoker(() => { pb.Maximum = Convert.ToInt32(value); }));
                    break;
                case 3://Progress Value
                    pb.Invoke(new MethodInvoker(() => { pb.Value = Convert.ToInt32(value); }));
                    break;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnOption_Click(object sender, EventArgs e)
        {
            OptionsFrm frm = new OptionsFrm();
            frm.ShowDialog();
        }
    
    }
}
