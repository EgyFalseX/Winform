using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.IO;

namespace E_Club_Mem_Manager
{
    public partial class AddMemAttachmentFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        DataTable AttachType = new DataTable("AttachType");
        DataTable Members_Tbl = new DataTable("Members");
        #endregion
        #region -   Functions   -

        private string SaveFile(string SrcFilePath, string TrgPath, string MemberID, string AttachID)
        {
            string TrgFilePath = string.Empty;
            char[] splitter  = {'.'};
            string[] ExtArr = SrcFilePath.Split(splitter);
            if (ExtArr.Length > 1)
                TrgFilePath = String.Format("{0}{1}-{2}.{3}", TrgPath, MemberID, AttachID, ExtArr[ExtArr.Length - 1]);
            else
                TrgFilePath = String.Format("{0}{1}-{2}", TrgPath, MemberID, AttachID);
            if (File.Exists(SrcFilePath))
                File.Copy(SrcFilePath,TrgFilePath,true);
            return TrgFilePath;
        }
        private void LoadData()
        {
            Members_Tbl = new DataTable("Members");
            AttachType = new DataTable("AttachType");
            //SELECT AttachID, AttachName FROM CD_AttachmentType
            string CmdStr = "SELECT mem_ID, mem_name";
            using (SqlDataAdapter DA = new SqlDataAdapter("SELECT AttachID, AttachName FROM CD_AttachmentType", Program.MC.SQLConStrMembers))
            {
                try
                {
                    DA.Fill(AttachType);
                    foreach (DataRow DRAttachType in AttachType.Rows)
                    {
                        DevExpress.XtraGrid.Columns.GridColumn AttachTypeColumn = new DevExpress.XtraGrid.Columns.GridColumn();
                        AttachTypeColumn.Name = DRAttachType["AttachName"].ToString();
                        AttachTypeColumn.Caption = DRAttachType["AttachName"].ToString();
                        AttachTypeColumn.FieldName = DRAttachType["AttachName"].ToString();
                        AttachTypeColumn.Tag = DRAttachType["AttachID"].ToString();
                        AttachTypeColumn.Visible = true;
                        AttachTypeColumn.VisibleIndex = 1;
                        GridViewMembers.Columns.Add(AttachTypeColumn);
                        CmdStr = String.Format("{0},'{1}' AS [{2}_{1}], (SELECT AttachPath FROM TBL_Attachment WHERE (mem_ID = TBL_members.mem_ID) AND (AttachID = {1})) AS [{2}] ", CmdStr, DRAttachType["AttachID"], DRAttachType["AttachName"]);
                    }
                    CmdStr = CmdStr + ", (Select COUNT(*) From TBL_Attachment Where mem_ID = TBL_members.mem_ID) AS AttachCount FROM TBL_members";
                    DA.SelectCommand.CommandText = CmdStr;
                    DA.Fill(Members_Tbl);
                    GridController.DataSource = Members_Tbl;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public AddMemAttachmentFrm()
        {
            InitializeComponent();
        }
        #endregion
        #region -   Event Handlers   -
        private void GridViewMembers_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (MessageBox.Show("هل ترغب في حزف الملف", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    //delete Cell Data from DB
                    using (SqlConnection Con = new SqlConnection(Program.MC.SQLConStrMembers))
                    {
                        SqlCommand Cmd = new SqlCommand(String.Format("DELETE FROM TBL_Attachment WHERE (mem_ID = {0}) AND (AttachID = {1})", Members_Tbl.Rows[e.RowHandle]["mem_ID"], e.Column.Tag), Con);
                        try
                        {
                            Con.Open();
                            Cmd.ExecuteNonQuery();
                            if (File.Exists(e.CellValue.ToString()))
                            {
                                File.Delete(e.CellValue.ToString());
                                Members_Tbl.Rows[e.RowHandle]["AttachCount"] = Convert.ToInt16(Members_Tbl.Rows[e.RowHandle]["AttachCount"]) - 1;
                                Members_Tbl.Rows[e.RowHandle][e.Column.FieldName] = string.Empty;
                            }
                            MessageBox.Show("تم خذف الملف", "خذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "خطــــــأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                }
                return;
            }
            if (e.RowHandle == -1)
            {
                return;
            }
            switch (e.Column.Name)
            {
                case "GridColumnID":
                    return;
                case "GridColumnName":
                    return;
                case "GridColumnCount":
                    return;
            }
            OpenFileDialog OFD = new OpenFileDialog { Filter = "(*.*)All Files | *.*", CheckFileExists = true, CheckPathExists = true, DereferenceLinks = true, Title = "اختار " + e.Column.Name };
            if (OFD.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
            {
                
                return;
            }
            string TrgFilePath = SaveFile(OFD.FileName, Program.MC.AttachDefaultPath, Members_Tbl.Rows[e.RowHandle]["mem_ID"].ToString(), e.Column.Tag.ToString());
            if (TrgFilePath == string.Empty)
            {
                return;
            }
            using (SqlConnection Con = new SqlConnection(Program.MC.SQLConStrMembers))
            {
                string CmdStr = string.Empty;
                int IsItInsertion = 0;
                if (e.CellValue.ToString() == string.Empty)
                {
                    CmdStr = String.Format("INSERT INTO TBL_Attachment (mem_ID, AttachID, AttachPath) VALUES ({0}, {1}, N'{2}')", Members_Tbl.Rows[e.RowHandle]["mem_ID"], e.Column.Tag, TrgFilePath);
                    IsItInsertion = 1;
                }
                else
                    CmdStr = String.Format("UPDATE TBL_Attachment SET AttachPath = N'{0}' WHERE (mem_ID = {1}) AND (AttachID = {2})", TrgFilePath, Members_Tbl.Rows[e.RowHandle]["mem_ID"], e.Column.Tag);
                SqlCommand Cmd = new SqlCommand(CmdStr, Con);
                try
                {
                    Con.Open();
                    Cmd.ExecuteNonQuery();
                    Members_Tbl.Rows[e.RowHandle][e.Column.FieldName] = TrgFilePath;
                    Members_Tbl.Rows[e.RowHandle]["AttachCount"] = Convert.ToInt16(Members_Tbl.Rows[e.RowHandle]["AttachCount"]) + IsItInsertion;
                    GridController.DataSource = Members_Tbl;
                    MessageBox.Show("تم تعديل الملف", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "خطــــــأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }
        private void AddAttachmentFrm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        #endregion
    }
}