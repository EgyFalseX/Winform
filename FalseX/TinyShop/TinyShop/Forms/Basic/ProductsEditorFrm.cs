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
    public partial class ProductsEditorFrm : DevExpress.XtraEditors.XtraForm
    {
        public ProductsEditorFrm()
        {
            InitializeComponent();
        }

        private void ProductsEditorFrm_Load(object sender, EventArgs e)
        {
            productsTableAdapter.Fill(dsTinyData.Products);
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
                    productsBindingSource.AddNew();
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
            if (e.ErrorText.Contains("ProductID"))
            {
                //e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
                DRV["ProductID"] = "-1";
                return;
            }
        }
        private void repositoryItemButtonEditEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView GV = (GridView)gridControlData.MainView;
            TinyShop.DataSources.dsTinyData.ProductsRow row = (TinyShop.DataSources.dsTinyData.ProductsRow)GV.GetFocusedDataRow();
            Update(row);
        }
        private void repositoryItemButtonEditDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView GV = (GridView)gridControlData.MainView;
            TinyShop.DataSources.dsTinyData.ProductsRow row = (TinyShop.DataSources.dsTinyData.ProductsRow)GV.GetFocusedDataRow();

            if (row.RowState == DataRowState.Detached)
                return;

            if (MessageBox.Show("Â· «‰  „ √ﬂœø", " Õ“Ì— ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            try
            {
                productsTableAdapter.Delete(row.ProductID);
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
            TinyShop.DataSources.dsTinyData.ProductsRow row = dsTinyData.Products.NewProductsRow();
            Update(row);
        }
        private void Update(DataSources.dsTinyData.ProductsRow row)
        {
            using (ProductsEditorWFrm frm = new ProductsEditorWFrm(row))
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                    return;
            }
            try
            {
                if (row.RowState == DataRowState.Detached)
                {
                    row.ProductID = Convert.ToInt32(misc.GetNewID(misc.DBTablesNames.Products));
                    dsTinyData.Products.AddProductsRow(row);
                }
                productsBindingSource.EndEdit();
                productsTableAdapter.Update(row);
                dsTinyData.Products.AcceptChanges();

                Program.ShowMsg(" „ «·Õ›Ÿ", false, this);
            }
            catch (Exception ex)
            {
                Program.ShowMsg(ex.Message, true, this);
            }
        }
    }
}                                                                                                                    