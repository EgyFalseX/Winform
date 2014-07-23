using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using TinyShop.dbTools;

namespace TinyShop.Forms.Basic
{
    public partial class SuppliersEditorFrm : DevExpress.XtraEditors.XtraForm
    {
        public SuppliersEditorFrm()
        {
            InitializeComponent();
        }

        private void CustomersEditorFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsTinyData.Suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.dsTinyData.Suppliers);
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
                    suppliersBindingSource.AddNew();
                    break;
                case Keys.F6:
                    repositoryItemButtonEditEdit_ButtonClick(repositoryItemButtonEditEdit, new DevExpress.XtraEditors.Controls.ButtonPressedEventArgs(new DevExpress.XtraEditors.Controls.EditorButton()));
                    break;
                case Keys.F8:
                    repositoryItemButtonEditDel_ButtonClick(repositoryItemButtonEditDel, new DevExpress.XtraEditors.Controls.ButtonPressedEventArgs(new DevExpress.XtraEditors.Controls.EditorButton()));
                    break;
                case Keys.F10:
                    repositoryItemButtonEditEdit_ButtonClick(repositoryItemButtonEditEdit, new DevExpress.XtraEditors.Controls.ButtonPressedEventArgs(new DevExpress.XtraEditors.Controls.EditorButton()));
                    break;
                default:
                    break;
            }
        }
        private void gridViewData_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            DataRowView DRV = (DataRowView)e.Row;
            if (e.ErrorText.Contains("SupplierID"))
            {
                //e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
                DRV["SupplierID"] = "-1";
                return;
            }
        }
        private void repositoryItemButtonEditEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView GV = (GridView)gridControlData.MainView;
            TinyShop.DataSources.dsTinyData.SuppliersRow row = (TinyShop.DataSources.dsTinyData.SuppliersRow)GV.GetFocusedDataRow();
            Update(row);
        }
        private void repositoryItemButtonEditDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView GV = (GridView)gridControlData.MainView;
            TinyShop.DataSources.dsTinyData.SuppliersRow row = (TinyShop.DataSources.dsTinyData.SuppliersRow)GV.GetFocusedDataRow();

            if (row.RowState == DataRowState.Detached)
                return;

            if (MessageBox.Show("Â· «‰  „ √ﬂœø", " Õ“Ì— ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            try
            {
                suppliersTableAdapter.Delete(row.SupplierID);
                gridViewData.DeleteRow(GV.FocusedRowHandle);

                Program.ShowMsg(" „ «·Õ–›", false, this);
            }
            catch (Exception ex)
            {
                Program.ShowMsg(ex.Message, true, this);
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            TinyShop.DataSources.dsTinyData.SuppliersRow row = dsTinyData.Suppliers.NewSuppliersRow();
            Update(row);
        }
        private void Update(DataSources.dsTinyData.SuppliersRow row)
        {
            using (SuppliersEditorWFrm frm = new SuppliersEditorWFrm(row))
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                    return;
            }
            try
            {
                if (row.RowState == DataRowState.Detached)
                {
                    row.SupplierID = Convert.ToInt32(misc.GetNewID(misc.DBTablesNames.Suppliers));
                    dsTinyData.Suppliers.AddSuppliersRow(row);
                }
                suppliersBindingSource.EndEdit();
                suppliersTableAdapter.Update(row);
                dsTinyData.Suppliers.AcceptChanges();

                Program.ShowMsg(" „ «·Õ›Ÿ", false, this);
            }
            catch (Exception ex)
            {
                Program.ShowMsg(ex.Message, true, this);
            }
        }
    }
}                                                                                                                    