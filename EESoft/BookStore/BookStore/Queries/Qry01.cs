using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace BookStore
{
    public partial class Qry01 : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        DataTable TblSells = new DataTable("FalseX2010-11");
        #endregion
        #region -   Functions   -
        public Qry01()
        {
            InitializeComponent();
        }
        #endregion
        #region -   Event Handlers   -
        private void QryPartnerStaffFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBookStoreQueries.CDCategories' table. You can move, or remove it, as needed.
            this.cDCategoriesTableAdapter.FillByHasAsnaf(this.dsBookStoreQueries.CDCategories);
            // TODO: This line of code loads data into the 'dsBookStoreQueries.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.FillByasase_code_Detail1(this.dsBookStoreQueries.student, Program.asase_code);
        }
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //LoadGridTbl();
        }
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridControlMain.ShowPrintPreview();
        }
        private void cardViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridControlMain.MainView = cardViewSells;
        }
        private void gridViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridControlMain.MainView = gridViewMain;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (lueSanf.EditValue == null || lueStu.EditValue == null)
            {
                return;
            }
            qry01TableAdapter.Fill(dsBookStoreQueries.Qry01, Convert.ToInt32(lueSanf.EditValue), Convert.ToInt32(lueStu.EditValue));
        }
        #endregion

    }
}