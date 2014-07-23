using System.Windows.Forms;
using Microsoft.VisualBasic;
using System;

namespace DataCenter_Server
{
	public partial class LockedFilesFrm
	{
		public LockedFilesFrm()
		{
			InitializeComponent();
		}
		private ListViewItem LVI;
		public short ForInt;
		private FunctionLib.DataCenterServerLib.LockedFilesSTR[] LockedFiles = new FunctionLib.DataCenterServerLib.LockedFilesSTR[0];
        private string ErrorproviderZ;
        public void LockedFilesFrm_Load(Object sender, EventArgs e)
        {
            LVFiles.Items.Clear();
            ErrorproviderZ = MainModule.FunLib.GetAllLockedFile(ref LockedFiles);
            if (ErrorproviderZ == null)
            {
                if (LockedFiles.Length > 0)
                {
                    for (ForInt = 0; ForInt <= LockedFiles.Length - 1; ForInt++)
                    {
                        LVI = new ListViewItem { Tag = LockedFiles[ForInt].FileID, Text = LockedFiles[ForInt].FileName };
                        LVI.SubItems.Add(LockedFiles[ForInt].FilePath);
                        LVI.SubItems.Add(LockedFiles[ForInt].UsrName);
                        LVFiles.Items.Add(LVI);
                    }
                }
                else
                {
                    MainModule.MsgBox_(ErrorproviderZ, 114, 23, false, this);
                    Close();
                }
            }
            else
            {
                MainModule.MsgBox_(ErrorproviderZ, 0, 23, false, this);
                Close();
            }
        }
        public void BtnApply_Click(Object sender, EventArgs e)
        {
            if (Interaction.MsgBox("هل انت متأكد؟", MsgBoxStyle.YesNo, null) == MsgBoxResult.No)
                return;
            for (ForInt = 0; ForInt <= LVFiles.CheckedItems.Count - 1; ForInt++)
            {
                ErrorproviderZ = null;
                ErrorproviderZ = MainModule.FunLib.UnLockFile((string)LVFiles.CheckedItems[ForInt].Tag);
                if (ErrorproviderZ != null)
                {
                    MainModule.MsgBox_(ErrorproviderZ, 0, (short)23, false, this);
                    Close();
                }
            }
            MainModule.MsgBox_("تم التفعيل", 131, 23, true, this);
            LockedFiles = new FunctionLib.DataCenterServerLib.LockedFilesSTR[0];
            ErrorproviderZ = null;
            LockedFilesFrm_Load(sender, e);
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
	}
}
