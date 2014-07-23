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
using FXFW;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace Members
{
    public partial class TBLPrintCardFawryFrm : DevExpress.XtraEditors.XtraForm
    {
        
        #region -   Functions   -
        public TBLPrintCardFawryFrm()
        {
            InitializeComponent();
        }
        private void LoadDefaultData()
        {
            lueSyndicateId.Properties.DataSource = SQLProvider.SelectCDSyndicate();
            lueSyndicateId.Properties.DisplayMember = "Syndicate";
            lueSyndicateId.Properties.ValueMember = "SyndicateId";
            repositoryItemLookUpEditcardtype.DataSource = GenerateCardTypeTable();
            repositoryItemLookUpEditcardtype.DisplayMember = "name";
            repositoryItemLookUpEditcardtype.ValueMember = "id";
        }
        private void AssignBarcode()
        {
            for (int i = dsTeachersUnion.PrintCards.Rows.Count - 1; i > -1; i--)
            {
                //Generat Barcode
                DataSources.dsTeachersUnion.PrintCardsRow row = (DataSources.dsTeachersUnion.PrintCardsRow)dsTeachersUnion.PrintCards.Rows[i];
                row.Barcode = row.RandomCard;
                //SyndicateId
                if (row.IsSyndicateNull())
                    row.Barcode += "00";
                else if (row.SyndicateId.ToString().Length == 1)
                    row.Barcode += "0" + row.SyndicateId;
                else
                    row.Barcode += row.SyndicateId;
                //SubCommitteId
                if (row.IsSubCommitteIdNull())
                    row.Barcode += "00";
                else if (row.SubCommitteId.ToString().Length == 1)
                    row.Barcode += "0" + row.SubCommitteId;
                else
                    row.Barcode += row.SubCommitteId;
                //MemberId
                row.Barcode += row.MemberId.ToString();
            }
            //gridControlData.DataSource = dt;
        }
        private void ActiveKeyDownEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyData != Keys.F5 && e.KeyData != Keys.F6 && e.KeyData != Keys.F10 && e.KeyData != Keys.F8)
                return;
            switch (e.KeyData)
            {
                case Keys.F1:
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
            lueSyndicateId.Visible = Selecting;
            gridControlData.Visible = Selecting;
            btnSearch.Visible = Selecting;
            btnPrint.Visible = Inserting;
        }
        private DataTable GenerateCardTypeTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("id"));
            dt.Columns.Add(new DataColumn("name"));
            DataRow row1 = dt.NewRow(); row1["id"] = (int)Program.cardtype.دائمة; row1["name"] = Program.cardtype.دائمة.ToString(); dt.Rows.Add(row1);
            DataRow row2 = dt.NewRow(); row2["id"] = (int)Program.cardtype.مؤقتة; row2["name"] = Program.cardtype.مؤقتة.ToString(); dt.Rows.Add(row2);
            return dt;
        }

        #endregion
        #region - Event Handlers -
        private void TBLPrintCardFrm_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'dsTeachersUnion.PrintCards' table. You can move, or remove it, as needed.
            //this.printCardsTableAdapter.Fill(this.dsTeachersUnion.PrintCards);
            ActivePriv();
            LoadDefaultData();
            AssignBarcode();
            //this.Disposed += TBLPrintCardFrm_Disposed;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (lueSyndicateId.EditValue == null)
                printCardsTableAdapter.Fill(dsTeachersUnion.PrintCards);                
            else
                printCardsTableAdapter.FillBySyndicateId_fawry(dsTeachersUnion.PrintCards, Convert.ToInt32(lueSyndicateId.EditValue), true);
            AssignBarcode();
        }
        private void CEAll_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < gridViewData.RowCount; i++)
            {
                gridViewData.GetDataRow(gridViewData.GetVisibleRowHandle(i))["checkforprint"] = CEAll.Checked;
            }
        }
        private void btnChooseNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gridControlData.DataSource == null || btnChooseNo.Text == string.Empty)
                return;
            int counter = Convert.ToInt32(btnChooseNo.EditValue);

            for (int i = 0; i < gridViewData.DataRowCount; i++)
            {
                DataSources.dsTeachersUnion.PrintCardsRow row = (DataSources.dsTeachersUnion.PrintCardsRow)gridViewData.GetDataRow(i);
                if (i < counter)
                    row.checkforprint = true;
                else
                    row.checkforprint = false;
            }
            
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gridViewData.DataRowCount; i++)
            {
                DataSources.dsTeachersUnion.PrintCardsRow row = (DataSources.dsTeachersUnion.PrintCardsRow)gridViewData.GetDataRow(i);
                if (row.checkforprint == true && row.IsesalnoNull())
                {
                    Program.ShowMsg("يجب ادخال رقم الايصال لكل كارت", false, this);
                    return;
                }
            }
            //prepare print report to show
            XRepMemCard report = new XRepMemCard();
            report.LoadDataSource(dsTeachersUnion.PrintCards, false);
            Misc.Misc.ShowPrintPreview(report, true);
            
            if (MessageBox.Show("هل ترغب في الحفظ؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            try
            {
                for (int i = 0; i < dsTeachersUnion.PrintCards.Rows.Count; i++)
                {
                    DataSources.dsTeachersUnion.PrintCardsRow row = (DataSources.dsTeachersUnion.PrintCardsRow)dsTeachersUnion.PrintCards.Rows[i];
                    if (row.checkforprint == false)
                        row.Delete();
                }
                dsTeachersUnion.PrintCards.AcceptChanges();
                if (SQLProvider.InsertTBLPrintCard(dsTeachersUnion.PrintCards))
                {
                    Program.ShowMsg("تم الحفظ", false, this);
                    Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
                    this.printCardsTableAdapter.Fill(this.dsTeachersUnion.PrintCards);
                    AssignBarcode();
                }
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
            
        }
        void TBLPrintCardFrm_Disposed(object sender, EventArgs e)
        {
            return;
            if (gridControlData.DataSource.GetType() == typeof(DataTable))
            {
                ((DataTable)gridControlData.DataSource).Rows.Clear();
                ((DataTable)gridControlData.DataSource).Dispose();
            }
            GC.Collect();
        }

        #endregion
    }
}