using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace schoolStore
{
    public partial class ItemAvailabilityFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
             
        #endregion
        #region -   Functions   -
        public ItemAvailabilityFrm()
        {
            InitializeComponent();
        }
        private void LoadGrid()
        {
            gridControlMain.DataSource = FXFW.SqlDB.LoadDataTable(@"Select SanfID, CategoryID, SanfName, Sanfbarcode,
            (Select Category From CDCategories Where CategoryId = CDASNAF.CategoryID) AS Category,
            Isnull((Select SUM(Quantity) From StoreTransactionDetailes Where harakatype = 4 And SanfID = CDASNAF.SanfID), 0) AS ComeIn,
            Isnull((Select SUM(Quantity) From StoreTransactionDetailes Where harakatype = 2 And SanfID = CDASNAF.SanfID), 0)  AS ComeOut,
            Isnull((Select SUM(Quantity) From StoreTransactionDetailes Where harakatype = 4 And SanfID = CDASNAF.SanfID), 0)
            -
            Isnull((Select SUM(Quantity) From StoreTransactionDetailes Where harakatype = 2 And SanfID = CDASNAF.SanfID), 0) AS Store
            From CDASNAF");
        }
        #endregion
        #region - Event Handlers -
        private void ItemAvailabilityFrm_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
        #endregion         #region -   Variables   -
    }
}