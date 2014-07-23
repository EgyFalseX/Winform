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
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;

namespace Members
{
    public partial class TBLHafzaTasleemFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Functions   -
        public TBLHafzaTasleemFrm()
        {
            InitializeComponent();
        }
        private void LoadDataSource()
        {
            // TODO: This line of code loads data into the 'dsTeachersUnion.TBLMandoop' table. You can move, or remove it, as needed.
            this.tBLMandoopTableAdapter.Fill(this.dsTeachersUnion.TBLMandoop);
            // TODO: This line of code loads data into the 'dsTeachersUnion.CDSyndicate' table. You can move, or remove it, as needed.
            this.cDSyndicateTableAdapter.Fill(this.dsTeachersUnion.CDSyndicate);
            // TODO: This line of code loads data into the 'dsTeachersUnion.TBLHafzaTasleem' table. You can move, or remove it, as needed.
            this.tBLHafzaTasleemTableAdapter.Fill(this.dsTeachersUnion.TBLHafzaTasleem);
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
                    (((DataSet)gridControlData.DataSource)).Tables[0].Rows.Add((((DataSet)gridControlData.DataSource)).Tables[0].NewRow());
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
        private void stu_nashatFrm_Load(object sender, EventArgs e)
        {
            ActivePriv();
            LoadDataSource();
        }
        private void gridViewTBLHafzaTasleem_InvalidRowException(object sender, InvalidRowExceptionEventArgs e)
        {
            DataRowView DRV = (DataRowView)e.Row;
            if (e.ErrorText.Contains("HafzaId"))
            {
                DRV["HafzaId"] = "-1";
                return;
            }
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView GV = (GridView)gridControlData.MainView;
            DataSources.dsTeachersUnion.TBLHafzaTasleemRow row = (DataSources.dsTeachersUnion.TBLHafzaTasleemRow)GV.GetFocusedDataRow();
            Update(row);
        }
        private void repositoryItemButtonEditDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView GV = (GridView)gridControlData.MainView;
            DataSources.dsTeachersUnion.TBLHafzaTasleemRow row = (DataSources.dsTeachersUnion.TBLHafzaTasleemRow)GV.GetFocusedDataRow();

            if (row.RowState == DataRowState.Detached)
                return;

            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            try
            {
                tBLHafzaTasleemTableAdapter.Delete(row.HafzaId);
                gridViewTBLHafzaTasleem.DeleteRow(GV.FocusedRowHandle);

                Program.ShowMsg("تم الحذف", false, this);
                Program.Logger.LogThis("تم الحذف", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (Exception ex)
            {
                Program.ShowMsg(Misc.Misc.ExceptionMessage(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, ex, null, this);
            }
        }
        private void repositoryItemButtonEditPrint_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataRow row = gridViewTBLHafzaTasleem.GetFocusedDataRow();
            try
            {
                if (row["HafzaId"].ToString() != string.Empty)
                {
                    XRep01 rep = new XRep01(row["HafzaId"]);
                    Misc.Misc.ShowPrintPreview(rep);
                }
            }
            catch (Exception ex)
            {
                Program.ShowMsg(ex.Message, true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, ex, null, this);
            }
        }
        private void repositoryItemButtonEditPrint_ButtonClick_1(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataRow row = gridViewTBLHafzaTasleem.GetFocusedDataRow();
            try
            {
                if (row["HafzaId"].ToString() != string.Empty)
                {
                    XRep01 rep = new XRep01(row["HafzaId"]);
                    // Create a Print Tool and show the Print Preview form. 
                    DevExpress.XtraReports.UI.ReportPrintTool printTool = new DevExpress.XtraReports.UI.ReportPrintTool(rep);
                    
                }
            }
            catch (Exception ex)
            {
                Program.ShowMsg(ex.Message, true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, ex, null, this);
            }
        }        
        private void btnNew_Click(object sender, EventArgs e)
        {
            DataSources.dsTeachersUnion.TBLHafzaTasleemRow row = dsTeachersUnion.TBLHafzaTasleem.NewTBLHafzaTasleemRow();
            row.HafzaDate = SQLProvider.GetServerDateTime();
            Update(row);
        }
        private void Update(DataSources.dsTeachersUnion.TBLHafzaTasleemRow row)
        {
            bool reOpen = false;
            using (TBLHafzaTasleemWFrm frm = new TBLHafzaTasleemWFrm(row))
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                    return;
            }
            try
            {
                if (row.RowState == DataRowState.Detached)
                {
                    row.HafzaId = (int)tBLHafzaTasleemTableAdapter.ScalarQueryNewID();
                    dsTeachersUnion.TBLHafzaTasleem.AddTBLHafzaTasleemRow(row);
                    reOpen = true;
                    tBLHafzaTasleemBindingSource.EndEdit();
                    tBLHafzaTasleemTableAdapter.Update(row);
                    dsTeachersUnion.TBLHafzaTasleem.AcceptChanges();
                }
                else
                {
                    tBLHafzaTasleemBindingSource.EndEdit();
                    tBLHafzaTasleemTableAdapter.Update(row);
                    dsTeachersUnion.TBLHafzaTasleem.AcceptChanges();
                    Program.ShowMsg("تم الحفظ", false, this);
                    Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
                }
            }
            catch (Exception ex)
            {
                Program.ShowMsg(Misc.Misc.ExceptionMessage(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, ex, null, this);
            }
            if (reOpen)
                Update(row);
        }
       
        #endregion
        
    }
}