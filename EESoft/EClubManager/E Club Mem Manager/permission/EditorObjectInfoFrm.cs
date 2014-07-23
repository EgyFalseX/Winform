using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace E_Club_Mem_Manager
{
    public partial class EditorObjectInfoFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        DataTable ItemsTbl = new DataTable("Items");
        DataTable MenuTbl = new DataTable("Menus");
        DataTable MenuElementTbl = new DataTable("MenuElements");
        #endregion
        #region -   Functions   -
        private void LoadData()
        {
            ItemsTbl = new DataTable("Items");
            ItemsTbl = Program.MC.LoadDataTable("SELECT ObjectId, ObjectName, ObjectTypeId, NAME, descreption_object FROM TBL_Objects", Program.MC.SQLConStrMembers);
            LUEItems.Properties.DataSource = ItemsTbl;
            LUEItems.Properties.DisplayMember = "ObjectName";
            LUEItems.Properties.ValueMember = "ObjectId";
            
            MenuTbl = new DataTable("Menus");
            MenuTbl = Program.MC.LoadDataTable("Select ObjectTypeId, ObjectTypeName From CD_ObjectType", Program.MC.SQLConStrMembers);
            LUEEditMenu.Properties.DataSource = MenuTbl;
            LUEEditMenu.Properties.DisplayMember = "ObjectTypeName";
            LUEEditMenu.Properties.ValueMember = "ObjectTypeId";

            LUEAddMenu.Properties.DataSource = MenuTbl;
            LUEAddMenu.Properties.DisplayMember = "ObjectTypeName";
            LUEAddMenu.Properties.ValueMember = "ObjectTypeId";

            LoadGetMenuItem();
            LUEEditCodeName.Properties.DataSource = MenuElementTbl;
            LUEEditCodeName.Properties.DisplayMember = "menutext";
            LUEEditCodeName.Properties.ValueMember = "menuname";
            
        }
        private void LoadGetMenuItem()
        {
            //mainrow["menuname"] = item.Name;
            //mainrow["menutext"] = item.Text;

            //fileMenu items
            MenuElementTbl.Rows.Add("fileMenu", "ملـــف");
            MenuElementTbl.Rows.Add("restConnectionToolStripMenuItem", "ألغاء اتصال قاعدة البيانات");
            //CodeMenu items
            MenuElementTbl.Rows.Add("CodeMenu", "اكواد");
            //dataToolStripMenuItem items
            MenuElementTbl.Rows.Add("dataToolStripMenuItem", "ادخال بيانات");
            MenuElementTbl.Rows.Add("editorMembersToolStripMenuItem", "الاعضاء");
            MenuElementTbl.Rows.Add("editorMembershipToolStripMenuItem", "العضويات");
            MenuElementTbl.Rows.Add("editorDependentToolStripMenuItem", "المرافقون");
            MenuElementTbl.Rows.Add("editorAttachmentToolStripMenuItem", "المرفقات");
            MenuElementTbl.Rows.Add("cardsToolStripMenuItem", "الكرنيهات");
            //queryToolStripMenuItem items
            MenuElementTbl.Rows.Add("queryToolStripMenuItem", "استعلامــات");
            MenuElementTbl.Rows.Add("memberToolStripMenuItem", "استعلامات الاعضــاء");
            //printingToolStripMenuItem items
            MenuElementTbl.Rows.Add("printingToolStripMenuItem", "طبــاعة تقاريــر");
            //permissionToolStripMenuItem items
            MenuElementTbl.Rows.Add("permissionToolStripMenuItem", "صلاحيــــات");
            MenuElementTbl.Rows.Add("editorObjectTypeToolStripMenuItem", "اسمــاء القوائم");
            MenuElementTbl.Rows.Add("editorObjectInfoToolStripMenuItem", "العناصر");
            MenuElementTbl.Rows.Add("editorUserToolStripMenuItem", "المستخدمين");
            MenuElementTbl.Rows.Add("editorRoleToolStripMenuItem", "الصلاحيات");
            MenuElementTbl.Rows.Add("editorUserInRoleToolStripMenuItem", "صلاحيات المستخدمين");
            MenuElementTbl.Rows.Add("editorRoleContiansToolStripMenuItem", "قدرات الصلاحيات");
            //toolsMenu items
            MenuElementTbl.Rows.Add("toolsMenu", "ادوات");
            MenuElementTbl.Rows.Add("optionsToolStripMenuItem", "اختيارات");
        }
        public EditorObjectInfoFrm()
        {
            InitializeComponent();
        }
        #endregion
        #region -   Event Handlers   -
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل ترغب في الاستمرار؟", "تأكــــيد", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }
            using (SqlConnection Con = new SqlConnection(Program.MC.SQLConStrMembers))
            {
                SqlCommand Cmd = new SqlCommand(String.Format("DELETE FROM CD_job WHERE (job_id = {0})", LUEItems.EditValue), Con);
                try
                {
                    Con.Open();
                    Cmd.ExecuteNonQuery();
                    LoadData();
                    LUEItems.ItemIndex = -1;
                    MessageBox.Show("تم الحـــذف ", "حـــــذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection Con = new SqlConnection(Program.MC.SQLConStrMembers))
            {
                //SqlCommand Cmd = new SqlCommand(String.Format("INSERT INTO CD_job  (job) VALUES (N'{0}')", TxtNewItem.Text.Trim()), Con);
                try
                {
                    Con.Open();
                    //Cmd.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("تم الاضــــافه", "اضافــــه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection Con = new SqlConnection(Program.MC.SQLConStrMembers))
            {
                SqlCommand Cmd = new SqlCommand(String.Format("UPDATE CD_job SET job = N'{0}' WHERE (job_id = {1})", TxtEditItem.Text.Trim(), LUEItems.EditValue), Con);
                try
                {
                    Con.Open();
                    Cmd.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("تم التعــــديل ", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void TxtNewItem_EditValueChanged(object sender, EventArgs e)
        {
            //if (TxtNewItem.Text.Trim().Length > 0)
            //    BtnAdd.Enabled = true;
            //else
            //    BtnAdd.Enabled = false;
        }
        private void TxtEditItem_EditValueChanged(object sender, EventArgs e)
        {
            if (TxtEditItem.Text.Trim().Length > 0 && LUEItems.ItemIndex > -1)
                BtnUpdate.Enabled = true;
            else
                BtnUpdate.Enabled = false;
        }
        private void LUEItems_EditValueChanged(object sender, EventArgs e)
        {
            if (LUEItems.ItemIndex > -1)
            {
                TxtEditItem.Text = LUEItems.Text;
                BtnUpdate.Enabled = true;
                BtnDelete.Enabled = true;
            }
            else
            {
                TxtEditItem.Text = string.Empty;
                BtnUpdate.Enabled = false;
                BtnDelete.Enabled = false;
            }
        }
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void EditorObjectInfoFrm_Load(object sender, EventArgs e)
        {
            MenuElementTbl.Columns.Add("menuname");
            MenuElementTbl.Columns.Add("menutext");
            LoadData();
        }
        #endregion
    }
}