using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using FXFW;
using System.IO;
using DevExpress.XtraGrid.Views.Grid;

namespace Members
{
    public partial class TBLMandoopFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Functions   -
        public TBLMandoopFrm()
        {
            InitializeComponent();
        }
        private void ActiveKeyDownEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyData != Keys.F5 && e.KeyData != Keys.F6 && e.KeyData != Keys.F10 && e.KeyData != Keys.F8)
                return;
            switch (e.KeyData)
            {
                case Keys.F1:
                    break;
                case Keys.F5:
                    ((DataTable)gridControlData.DataSource).Rows.Add(((DataTable)gridControlData.DataSource).NewRow());
                    break;
                case Keys.F6:
                    repositoryItemButtonEditSave_ButtonClick(repositoryItemButtonEditSave, new DevExpress.XtraEditors.Controls.ButtonPressedEventArgs(new DevExpress.XtraEditors.Controls.EditorButton()));
                    break;
                case Keys.F8:
                    repositoryItemButtonEditDel_ButtonClick(repositoryItemButtonEditDel, new DevExpress.XtraEditors.Controls.ButtonPressedEventArgs(new DevExpress.XtraEditors.Controls.EditorButton()));
                    break;
                case Keys.F10:
                    repositoryItemButtonEditSave_ButtonClick(repositoryItemButtonEditSave, new DevExpress.XtraEditors.Controls.ButtonPressedEventArgs(new DevExpress.XtraEditors.Controls.EditorButton()));
                    break;
                default:
                    break;
            }
        }
        private void ActivePriv()
        {
            return;//ActivePrivReady
            bool Selecting = false, Inserting = false, Updateing = false, Deleting = false;
            SQLProvider.GetFormPriv(this.Name, ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
            gridControlData.Visible = Selecting;
            if (Inserting || Updateing)
                repositoryItemButtonEditSave.Buttons[0].Visible = true;
            else
                repositoryItemButtonEditSave.Buttons[0].Visible = false;
            repositoryItemButtonEditDel.Buttons[0].Visible = Deleting;
        }
        #endregion
        #region - Event Handlers -
        private void TBLMandoopFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsTeachersUnion.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.dsTeachersUnion.Users);
            // TODO: This line of code loads data into the 'dsTeachersUnion.CDSyndicate' table. You can move, or remove it, as needed.
            this.cDSyndicateTableAdapter.Fill(this.dsTeachersUnion.CDSyndicate);
            // TODO: This line of code loads data into the 'dsTeachersUnion.TBLMandoop' table. You can move, or remove it, as needed.
            this.tBLMandoopTableAdapter.Fill(this.dsTeachersUnion.TBLMandoop);
            if (!Directory.Exists(Program.MandoopImgPath))
                MessageBox.Show("مسار صور المندوبين لم يعد بعد", "تحزير", MessageBoxButtons.OK ,MessageBoxIcon.Error);
            ActivePriv();
        }
        private void gridViewData_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataSources.dsTeachersUnion.TBLMandoopRow row = (DataSources.dsTeachersUnion.TBLMandoopRow)gridViewData.GetDataRow(e.RowHandle);
            row.MandoopId = -1;
            row.datein = SQLProvider.GetServerDateTime();
            row.userin = Program.UserInfo.UserId;
            row.active = true;
        }
        private void repositoryItemButtonEditMandoopImg_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataRow row = gridViewData.GetFocusedDataRow();

            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis)
            {
                if (ofd.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                    return;
                string filename = string.Format("{0}{1}{2}{3}{4}{5}{6}.jpg", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, DateTime.Now.Millisecond);
                File.Copy(ofd.FileName, Program.MandoopImgPath + filename, true);
                row["MandoopImg"] = filename;
            }
            else
            {
                if (File.Exists(Program.MandoopImgPath + row["MandoopImg"]))
                {
                    ImgViewerFrm frm = new ImgViewerFrm();
                    frm.Img.ImageLocation = Program.MandoopImgPath + row["MandoopImg"];
                    frm.ShowDialog();
                }
                else
                    MessageBox.Show("الملف غير موجود", "ملف مفقود", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }       
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView GV = (GridView)gridControlData.MainView;
            DataSources.dsTeachersUnion.TBLMandoopRow row = (DataSources.dsTeachersUnion.TBLMandoopRow)GV.GetFocusedDataRow();
            try
            {
                if (row.RowState == DataRowState.Detached)
                {
                    row.MandoopId = (int)tBLMandoopTableAdapter.ScalarQueryNewID();
                }
                tBLMandoopBindingSource.EndEdit();
                tBLMandoopTableAdapter.Update(row);
                dsTeachersUnion.TBLMandoop.AcceptChanges();
                Program.ShowMsg("تم الحفظ", false, this);
                Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void repositoryItemButtonEditDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            GridView GV = (GridView)gridControlData.MainView;
            DataSources.dsTeachersUnion.TBLMandoopRow row = (DataSources.dsTeachersUnion.TBLMandoopRow)GV.GetFocusedDataRow();
            if (row.RowState == DataRowState.Detached)
                return;
            try
            {
                tBLMandoopTableAdapter.Delete(row.MandoopId);
                if (File.Exists(Program.MandoopImgPath + row.MandoopImg))
                    File.Delete(Program.MandoopImgPath + row.MandoopImg);
                gridViewData.DeleteRow(GV.FocusedRowHandle);
                Program.ShowMsg("تم الحذف", false, this);
                Program.Logger.LogThis("تم الحذف", Text, FXFW.Logger.OpType.success, null, null, this);
                
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        #endregion

    }
}