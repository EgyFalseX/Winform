using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace FileCopy
{
    public partial class FileCopyFrm : Form
    {
        string ServerPathDaccount = @"\\server\data\مجمع\daccountall\Daccount.mdb";
        string LocalPathDaccount = @"D:\eschool\data\مجمع\daccountall\Daccount.mdb";
        string ServerPathdataschool = @"\\server\data\مجمع\DSTUDENTALL\dataschool.mdb";
        string LocalPathdataschool = @"D:\eschool\data\مجمع\DSTUDENTALL\dataschool.mdb";
        public FileCopyFrm()
        {
            InitializeComponent();
        }

        private void btnDownloadDaccount_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزير", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
                return;
            if (!File.Exists(ServerPathDaccount))
            {
                MessageBox.Show("الملف مفقود", "الملف مفقود", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                File.Copy(ServerPathDaccount, LocalPathDaccount, true);
                MessageBox.Show("تم نقل الملف", "تمت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnUploadDaccount_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزير", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
                return;
            if (!File.Exists(LocalPathDaccount))
            {
                MessageBox.Show("الملف مفقود", "الملف مفقود", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                File.Copy(LocalPathDaccount, ServerPathDaccount, true);
                MessageBox.Show("تم نقل الملف", "تمت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDownloadDaccountdataschool_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزير", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
                return;
            if (!File.Exists(ServerPathdataschool))
            {
                MessageBox.Show("الملف مفقود", "الملف مفقود", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                File.Copy(ServerPathdataschool, LocalPathdataschool, true);
                MessageBox.Show("تم نقل الملف", "تمت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnUploadDaccountdataschool_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزير", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
                return;
            if (!File.Exists(LocalPathdataschool))
            {
                MessageBox.Show("الملف مفقود", "الملف مفقود", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                File.Copy(LocalPathdataschool, ServerPathdataschool, true);
                MessageBox.Show("تم نقل الملف", "تمت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
