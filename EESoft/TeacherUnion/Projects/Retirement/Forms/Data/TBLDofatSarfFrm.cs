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
using DevExpress.XtraGrid.Views.Grid;

namespace Retirement
{
    public partial class TBLDofatSarfFrm : DevExpress.XtraEditors.XtraForm
    {
        
        #region -   Functions   -
        public TBLDofatSarfFrm()
        {
            InitializeComponent();
        }
        private void LoadGrid()
        {
            gridControlData.DataSource = SQLProvider.SelectTBLDofatSarf();
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
            return;
            bool Selecting = false, Inserting = false, Updateing = false, Deleting = false;
            SqlDB.GetFormPriv("Retirement" + Name.Replace("Frm", ""), ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
            gridControlData.Visible = Selecting;
            if (Inserting || Updateing)
                repositoryItemButtonEditSave.Buttons[0].Enabled = true;
            else
                repositoryItemButtonEditSave.Buttons[0].Enabled = false;
            repositoryItemButtonEditDel.Buttons[0].Enabled = Deleting;
        }
#endregion
        #region - Event Handlers -
        private void stu_nashatFrm_Load(object sender, EventArgs e)
        {
            ActivePriv();
            LoadGrid();
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataRow row = gridViewData.GetFocusedDataRow();

            try
            {
                if (row["DofatSarfId"].ToString() == string.Empty)
                    SQLProvider.InsertTBLDofatSarf(row["DofatSarf"].ToString(), row["DofatSarfDate"].ToString(), row["remd"].ToString());
                else
                    SQLProvider.UpdateTBLDofatSarf(row["DofatSarfId"].ToString(), row["DofatSarf"].ToString(), row["DofatSarfDate"].ToString(), row["remd"].ToString());
                Program.ShowMsg("تم الحفظ", false, this);
                Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
                LoadGrid();
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void repositoryItemButtonEditDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            DataRow row = gridViewData.GetFocusedDataRow();
            if (row["DofatSarfId"].ToString() == string.Empty)
            {
                LoadGrid();
                return;
            }
            try
            {
                SQLProvider.DeleteTBLDofatSarf(row["DofatSarfId"].ToString());
                Program.ShowMsg("تم الحذف", false, this);
                Program.Logger.LogThis("تم الحذف", Text, FXFW.Logger.OpType.success, null, null, this);
                LoadGrid();
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void repositoryItemButtonEditDetails_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataRow row = gridViewData.GetFocusedDataRow();
            if (row["DofatSarfId"].ToString() == string.Empty)
            {
                Program.ShowMsg("لا يمكن الدخول في التفاصيل في هذه الحالة", true, this);
                Program.Logger.LogThis("لا يمكن الدخول في التفاصيل في هذه الحالة", Text, FXFW.Logger.OpType.fail, null, null, this);
                return;
            }
            TBLDofatdeatilesFrm frm = new TBLDofatdeatilesFrm((int)row["DofatSarfId"]);
            frm.ShowDialog();
        }     
        #endregion

        
    }
}