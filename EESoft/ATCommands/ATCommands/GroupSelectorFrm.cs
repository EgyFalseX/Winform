using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ATCommands
{
    public partial class GroupSelectorFrm : DevExpress.XtraEditors.XtraForm
    {
        public string GroupID = string.Empty;
        public GroupSelectorFrm()
        {
            InitializeComponent();
        }
        private void GroupSelectorFrm_Load(object sender, EventArgs e)
        {
            lueGroup.Properties.DataSource = MyCL.LoadDataTable(@"Select Groupid, GroupName From Groups");
            lueGroup.Properties.DisplayMember = "GroupName";
            lueGroup.Properties.ValueMember = "Groupid";
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (lueGroup.EditValue == null)
            {
                MessageBox.Show("من فضلك اختر مجموعه");
                return;
            }
            GroupID = lueGroup.EditValue.ToString();
            Close();
        }
    }
}