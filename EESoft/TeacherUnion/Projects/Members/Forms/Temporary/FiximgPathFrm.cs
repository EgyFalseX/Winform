using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using System.Threading;

namespace Members.Forms.Temporary
{
    public partial class FiximgPathFrm : DevExpress.XtraEditors.XtraForm
    {

        string PathsFileName = Application.StartupPath + "\\SearchPaths";
        public FiximgPathFrm()
        {
            InitializeComponent();
        }
        private void FiximgPathFrm_Load(object sender, EventArgs e)
        {
            LoadPaths();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tbesalno.EditValue == null)
                return;
            try
            {
                pathFixTableAdapter.Fill(dsTeachersUnionQuery.PathFix, Convert.ToInt32(tbesalno.EditValue));
                for (int i = dsTeachersUnionQuery.PathFix.Count - 1; i >= 0; i--)
                {
                    if (File.Exists(dsTeachersUnionQuery.PathFix[i].img))
                        gridViewData.DeleteRow(gridViewData.GetRowHandle(i));
                }
            }
            catch (Exception ex)
            {
                Program.Logger.LogThis(ex.Message, Text, FXFW.Logger.OpType.success, ex, null, this);
            }
        }
        private void btnAddPath_Click(object sender, EventArgs e)
        {
            if (fbd.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }
            lbcPaths.Items.Add(fbd.SelectedPath);
            SavePaths();
        }
        private void btnDeletePath_Click(object sender, EventArgs e)
        {
            if (lbcPaths.SelectedIndex == -1)
            {
                return;
            }
            lbcPaths.Items.RemoveAt(lbcPaths.SelectedIndex);
            SavePaths();
        }
        private void btnFix_Click(object sender, EventArgs e)
        {
            foreach (DataSources.dsTeachersUnionQuery.PathFixRow row in dsTeachersUnionQuery.PathFix)
            {
                if (row.RowState == DataRowState.Deleted)
                    continue;
                foreach (string item in lbcPaths.Items)
                {
                    List<string> pathLst = new List<string>();
                    GetSubPath(item, ref pathLst);
                    try
                    {
                        foreach (string path in pathLst)
                        {
                            string FilePath = string.Format(@"{0}\{1}{2}", path, row.KideNumber, Program.imgExt);
                            if (File.Exists(FilePath))
                            {
                                File.Copy(FilePath, row.img);
                                break;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, ex, null, this);
                    }
                }
            }
            btnSearch.PerformClick();
            Program.ShowMsg("تم التعديل", false, this);
        }
        private void GetSubPath(string path, ref List<string> pathLst)
        {
            foreach (string item in Directory.GetDirectories(path))
            {
                pathLst.Add(item);
                GetSubPath(item, ref pathLst);

            }
        }
        private void LoadPaths()
        {
            lbcPaths.Items.Clear();
            if (!File.Exists(PathsFileName))
                File.Create(PathsFileName).Close();
            StreamReader sr = File.OpenText(PathsFileName);
            string[] str = sr.ReadToEnd().Split('\n');
            sr.Close();
            foreach (string item in str)
            {
                if (item.Length == 0)
                    continue;
                lbcPaths.Items.Add(item);
            }
        }
        private void SavePaths()
        {
            string AllText = string.Empty;
            foreach (string item in lbcPaths.Items)
            {
                AllText += item + '\n';
            }
            if (AllText.Length != 0)
                AllText = AllText.Substring(0, AllText.Length - 1);
            File.WriteAllText(PathsFileName, AllText);
        }

    }
}