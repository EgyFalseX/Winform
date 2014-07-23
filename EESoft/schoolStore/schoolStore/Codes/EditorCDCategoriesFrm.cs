using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress;
using DevExpress.XtraTreeList.Nodes;
using System.Data.SqlClient;


namespace schoolStore
{
    public partial class EditorCDCategoriesFrm : DevExpress.XtraEditors.XtraForm
    {
        public EditorCDCategoriesFrm()
        {
            InitializeComponent();
        }
        private void LoadCats()
        {
            DataTable TblCDCategories = new DataTable("FX2011-05");
            TblCDCategories = FXFW.SqlDB.LoadDataTable(@"Select CategoryId, parentID, Category From CDCategories");
            TLCat.DataSource = TblCDCategories;
            TLCat.KeyFieldName = "CategoryId";
        }
        private void EditorCDCategoriesFrm_Load(object sender, EventArgs e)
        {
            LoadCats();
        }
        private void repositoryItemButtonEditCategory_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (TLCat.Selection.Count == 0)// No Selected Cat
                return;
            TLCat.Update();
            this.Focus();
            TLCat.Focus();
            if (TLCat.Selection[0].GetValue(treeListColumnCategory).ToString() == string.Empty)// Cat Name is not set
            {
                Program.msg("من فضلك ادخل اسم للتصنيف", true, "", this);
                return;
            }
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                if (TLCat.Selection[0].GetValue(treeListColumnCategoryId).ToString() == string.Empty)
                {
                    string parentID;
                    if (TLCat.Selection[0].ParentNode != null)
                        parentID = TLCat.Selection[0].ParentNode.GetValue(treeListColumnCategoryId).ToString();
                    else
                        parentID = "0";
                    cmd.CommandText = string.Format(@"Insert Into CDCategories (CategoryId, parentID, Category, UserIn, TimeIn) VALUES 
                    ((Select Isnull(Max(CategoryId) + 1, 1) From CDCategories), {0}, N'{1}', {2}, GETDATE())", parentID, 
                    TLCat.Selection[0].GetValue(treeListColumnCategory), FXFW.SqlDB.UserInfo.UserID);
                }
                else
                {
                    if (MessageBox.Show("هل انت متأكد؟", "تحزيــــــر", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                        return;
                    cmd.CommandText = string.Format(@"Update CDCategories Set Category = N'{0}', UserIn = {1}, TimeIn = GETDATE() Where CategoryId = {2}",
                        TLCat.Selection[0].GetValue(treeListColumnCategory), FXFW.SqlDB.UserInfo.UserID, TLCat.Selection[0].GetValue(treeListColumnCategoryId));
                }
                con.Open();
                cmd.ExecuteNonQuery();
                LoadCats();
            }
            catch (SqlException ex)
            {
                Program.msg(FXFW.SqlDB.CheckExp(ex), true, ex.Number.ToString(), this);
            }
            con.Close();

        }
        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TLCat.Selection.Count == 0)
            { 
                TreeListNode NewNode = TLCat.AppendNode(new object[] { "تصنيف جديد", string.Empty, string.Empty},
                    -1, 0, 0, -1);
                TLCat.Selection.Add(NewNode);
            }
            else
            {
                TreeListNode NewNode = TLCat.AppendNode(new object[] { "تصنيف جديد", string.Empty, string.Empty },
                    TLCat.Selection[0].Id, 0, 0, -1);
                TLCat.Selection.Add(NewNode);
            }
        }
        private void deleteItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TLCat.Selection.Count == 0)
                return;
            if (MessageBox.Show("هل انت متأكد؟","تحزيــــــر", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;

            if (TLCat.Selection[0].GetValue(treeListColumnCategoryId).ToString() == string.Empty)
            {
                TLCat.DeleteSelectedNodes();
                return;
            }
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                con.Open();
                cmd.CommandText = "Delete From CDCategories Where CategoryId = " + TLCat.Selection[0].GetValue(treeListColumnCategoryId);
                cmd.ExecuteNonQuery();
                LoadCats();
            }
            catch (SqlException ex)
            {
                Program.msg(FXFW.SqlDB.CheckExp(ex), true, ex.Number.ToString(), this);
            }
            con.Close();
        }
        private void newRootToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TLCat.Selection.Clear();
            addNewToolStripMenuItem_Click(addNewToolStripMenuItem, new EventArgs());
        }
    }
}