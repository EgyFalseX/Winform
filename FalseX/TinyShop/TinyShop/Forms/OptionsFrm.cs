using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;

namespace TinyShop.Forms
{
    public partial class OptionsFrm : DevExpress.XtraEditors.XtraForm
    {
        public OptionsFrm()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            string msgWarning = "سوف يتم الغاء القاعدة الحالة وانشاء قاعدة جديدة فارغه" + Environment.NewLine;
            msgWarning += "هل ترغب في الاستمرار؟";
            if ( MessageBox.Show(msgWarning, "تحزير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.No)
                return;
            try
            {
                if (File.Exists(Program.dbSourcePath))
                {
                    File.Copy(Program.dbSourcePath, Program.dbCurrentPath, true);
                    MessageBox.Show("تم انشاء قاعدة جديدة و جاهزة للاستخدام", "تمت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("لم نتمكن من انشاء قاعدة جديدة", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                return;
            try
            {
                if (File.Exists(Program.dbCurrentPath))
                {
                    File.Copy(Program.dbCurrentPath, ofd.FileName, true);
                    MessageBox.Show("تم توريد قاعدة البيانات", "تمت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("لم نتمكن من حفظ نسخة قاعدة جديدة", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnImport_Click(object sender, EventArgs e)
        {
            string msgWarning = "سوف يتم الغاء القاعدة الحالة وتغيرها بقاعدة سابقة" + Environment.NewLine;
            msgWarning += "هل ترغب في الاستمرار؟";
            if (MessageBox.Show(msgWarning, "تحزير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.No)
                return;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                return;
            try
            {
                if (File.Exists(Program.dbCurrentPath))
                {
                    File.Copy(ofd.FileName, Program.dbCurrentPath, true);
                    MessageBox.Show("تم استيراد قاعدة البيانات", "تمت العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                    MessageBox.Show("لم نتمكن من استيراد قاعدة البيانات", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}