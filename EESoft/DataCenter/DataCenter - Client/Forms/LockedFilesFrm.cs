using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Data;
using System.Data.SqlClient;
using FunctionLib;

namespace DataCenter_Client
{
	public partial class LockedFilesFrm
	{
		public LockedFilesFrm()
		{
			InitializeComponent();
		}
		
		public short ForInt;
		private string ErrorproviderZ;
		bool ReloadFiles;
        DataTable LockedFilesTbl = new DataTable();
        public void LockedFilesFrm_Load(Object sender, EventArgs e)
        {
            LVFiles.Items.Clear();
            LockedFilesTbl = MCls.LoadDataTable(string.Format("Select FileID, FileName, FilePath From FileInfo Where InUseUserID = N'{0}' And InUse = 1", MainModule.FunLib.CUser.UID), "");
            if (LockedFilesTbl.Rows.Count == 0)
            {
                MainModule.MsgBox_("لا يوجد ملفات مغلقه", 114, 23, false, this);
                return;
            }
            foreach (DataRow row in LockedFilesTbl.Rows)
            {
                ListViewItem LVI = new ListViewItem {  Name = row["FileID"].ToString(), Text = row["FileName"].ToString() };
                LVI.SubItems.Add(row["FilePath"].ToString());
                LVFiles.Items.Add(LVI);
            }
        }
        public void BtnApply_Click(Object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزير", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;

            for (ForInt = 0; ForInt <= LVFiles.CheckedItems.Count - 1; ForInt++)
            {
                ErrorproviderZ = null;
                ErrorproviderZ = MainModule.FunLib.UnLockFile(LVFiles.CheckedItems[ForInt].Name);
                if (ErrorproviderZ != null)
                {
                    MCls.msg(ErrorproviderZ, true, "", this);
                    Close();
                }
            }
            MCls.msg("تم الفتح", false, "", this);
            ErrorproviderZ = null;
            LockedFilesFrm_Load(sender, e);
            ReloadFiles = true;
        }
        public void LVFiles_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (LVFiles.CheckedItems.Count == 0)
                BtnApply.Enabled = false;
            else
                BtnApply.Enabled = true;
        }
        public void CBSelectAll_CheckedChanged(Object sender, EventArgs e)
        {
            if (CBSelectAll.Checked == true)
            {
                CBSelectNone.Checked = false;
                for (ForInt = 0; ForInt <= LVFiles.Items.Count - 1; ForInt++)
                    LVFiles.Items[ForInt].Checked = true;
            }
        }
        public void CBSelectNone_CheckedChanged(Object sender, EventArgs e)
        {
            if (CBSelectNone.Checked == true)
            {
                CBSelectAll.Checked = false;
                for (ForInt = 0; ForInt <= LVFiles.Items.Count - 1; ForInt++)
                    LVFiles.Items[ForInt].Checked = false;
            }
        }
        public void LockedFilesFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ReloadFiles == true)
                MainModule.FrmMainWindow.RelaodFilesInListView();
        }
	}
}
