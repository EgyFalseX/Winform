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

namespace E_Club_Emp_Manager
{
    public partial class AddEmpAttachmentFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        DataTable AttachType = new DataTable("AttachType");
        DataTable Employee_Tbl = new DataTable("Employees");
        #endregion
        #region -   Functions   -

        private string SaveFile(string SrcFilePath, string TrgPath, string EmployeeID, string AttachID)
        {
            string TrgFilePath = string.Empty;
            char[] splitter = { '.' };
            string[] ExtArr = SrcFilePath.Split(splitter);
            if (ExtArr.Length > 1)
                TrgFilePath = String.Format("{0}{1}-{2}.{3}", TrgPath, EmployeeID, AttachID, ExtArr[ExtArr.Length - 1]);
            else
                TrgFilePath = String.Format("{0}{1}-{2}", TrgPath, EmployeeID, AttachID);
            if (File.Exists(SrcFilePath))
            {
                try { File.Copy(SrcFilePath, TrgFilePath, true); }
                catch (Exception ex) { MessageBox.Show("لا يوجد مجلد المرفقات" + "\n" + ex.Message);
                return string.Empty; ;
                }
            }
            return TrgFilePath;
        }
        private void LoadData()
        {
            Employee_Tbl = new DataTable("Employees");
            AttachType = new DataTable("AttachType");
            string CmdStr = "SELECT EmpID, Emp_Full_Name";
            using (SqlDataAdapter DA = new SqlDataAdapter("SELECT AttachID, AttachName FROM CD_AttachmentType", Program.MC.SQLConStrMalafat))
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
                        GridViewEmployees.Columns.Add(AttachTypeColumn);
                        CmdStr = String.Format("{0},'{1}' AS [{2}_{1}], (SELECT AttachPath FROM TBL_Attachment WHERE (EmpID = Emp_Master.EmpID) AND (AttachID = {1})) AS [{2}] ", CmdStr, DRAttachType["AttachID"], DRAttachType["AttachName"]);
                    }
                    CmdStr = CmdStr + ", (Select COUNT(*) From TBL_Attachment Where EmpID = Emp_Master.EmpID) AS AttachCount FROM Emp_Master";
                    DA.SelectCommand.CommandText = CmdStr;
                    DA.Fill(Employee_Tbl);
                    GridController.DataSource = Employee_Tbl;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public AddEmpAttachmentFrm()
        {
            InitializeComponent();
        }
        #endregion
        #region -   Event Handlers   -

        private void GridViewEmployees_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (MessageBox.Show("هل ترغب في حزف الملف", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    //delete Cell Data from DB
                    using (SqlConnection Con = new SqlConnection(Program.MC.SQLConStrMalafat))
                    {
                        SqlCommand Cmd = new SqlCommand(String.Format("DELETE FROM TBL_Attachment WHERE (EmpID = {0}) AND (AttachID = {1})", Employee_Tbl.Rows[e.RowHandle]["EmpID"], e.Column.Tag), Con);
                        try
                        {
                            Con.Open();
                            Cmd.ExecuteNonQuery();
                            if (File.Exists(e.CellValue.ToString()))
                            {
                                File.Delete(e.CellValue.ToString());
                                Employee_Tbl.Rows[e.RowHandle]["AttachCount"] = Convert.ToInt16(Employee_Tbl.Rows[e.RowHandle]["AttachCount"]) - 1;
                                Employee_Tbl.Rows[e.RowHandle][e.Column.FieldName] = string.Empty;
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
            string TrgFilePath = SaveFile(OFD.FileName, Program.MC.AttachDefaultPath, Employee_Tbl.Rows[e.RowHandle]["EmpID"].ToString(), e.Column.Tag.ToString());
            if (TrgFilePath == string.Empty)
            {
                return;
            }
            using (SqlConnection Con = new SqlConnection(Program.MC.SQLConStrMalafat))
            {
                string CmdStr = string.Empty;
                int IsItInsertion = 0;
                if (e.CellValue.ToString() == string.Empty)
                {
                    CmdStr = String.Format("INSERT INTO TBL_Attachment (EmpID, AttachID, AttachPath) VALUES ({0}, {1}, N'{2}')", Employee_Tbl.Rows[e.RowHandle]["EmpID"], e.Column.Tag, TrgFilePath);
                    IsItInsertion = 1;
                }
                else
                    CmdStr = String.Format("UPDATE TBL_Attachment SET AttachPath = N'{0}' WHERE (EmpID = {1}) AND (AttachID = {2})", TrgFilePath, Employee_Tbl.Rows[e.RowHandle]["EmpID"], e.Column.Tag);
                SqlCommand Cmd = new SqlCommand(CmdStr, Con);
                try
                {
                    Con.Open();
                    Cmd.ExecuteNonQuery();
                    Employee_Tbl.Rows[e.RowHandle][e.Column.FieldName] = TrgFilePath;
                    Employee_Tbl.Rows[e.RowHandle]["AttachCount"] = Convert.ToInt16(Employee_Tbl.Rows[e.RowHandle]["AttachCount"]) + IsItInsertion;
                    GridController.DataSource = Employee_Tbl;
                    MessageBox.Show("تم تعديل الملف", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "خطــــــأ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }
        private void AddEmpAttachmentFrm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        #endregion
    }
}