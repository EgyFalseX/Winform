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
    public partial class TBLPrintCardReFrm : DevExpress.XtraEditors.XtraForm
    {
        
        #region -   Functions   -
        public TBLPrintCardReFrm()
        {
            InitializeComponent();
        }
        private void LoadDefaultData()
        {
            lueSyndicateId.Properties.DataSource = SQLProvider.SelectCDSyndicate();
            lueSyndicateId.Properties.DisplayMember = "Syndicate";
            lueSyndicateId.Properties.ValueMember = "SyndicateId";
        }
        private void AssignBarcode()
        {
            for (int i = dsTeachersUnion.RePrintCards.Rows.Count - 1; i > -1; i--)
            {
                //Generat Barcode
                DataSources.dsTeachersUnion.RePrintCardsRow row = (DataSources.dsTeachersUnion.RePrintCardsRow)dsTeachersUnion.RePrintCards.Rows[i];
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
            tbesalno.Visible = Selecting;
            tbKideNumber.Visible = Selecting;
            //btnSearch.Visible = Selecting;
            btnPrint.Visible = Inserting;
        }
        #endregion
        #region - Event Handlers -
        private void TBLPrintCardFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsTeachersUnion.RePrintCards' table. You can move, or remove it, as needed.
            //this.rePrintCardsTableAdapter.Fill(this.dsTeachersUnion.RePrintCards);
            ActivePriv();
            LoadDefaultData();
            AssignBarcode();
            //this.Disposed += TBLPrintCardFrm_Disposed;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            
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
                DataSources.dsTeachersUnion.RePrintCardsRow row = (DataSources.dsTeachersUnion.RePrintCardsRow)gridViewData.GetDataRow(i);
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
                DataSources.dsTeachersUnion.RePrintCardsRow row = (DataSources.dsTeachersUnion.RePrintCardsRow)gridViewData.GetDataRow(i);
                if (row.checkforprint == true && row.IsesalnoNull())
                {
                    Program.ShowMsg("يجب ادخال رقم الايصال لكل كارت", false, this);
                    return;
                }
            }
            //prepare print report to show
            XRepMemCard report = new XRepMemCard();
            report.LoadDataSource(dsTeachersUnion.RePrintCards, true);
            Misc.Misc.ShowPrintPreview(report, true);

            if (MessageBox.Show("هل ترغب في الحفظ؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            try
            {
                DataSources.dsTeachersUnionTableAdapters.TBLReplyPrintTableAdapter adp = new DataSources.dsTeachersUnionTableAdapters.TBLReplyPrintTableAdapter();
                for (int i = 0; i < dsTeachersUnion.RePrintCards.Rows.Count; i++)
                {
                    DataSources.dsTeachersUnion.RePrintCardsRow row = (DataSources.dsTeachersUnion.RePrintCardsRow)dsTeachersUnion.RePrintCards.Rows[i];
                    DataSources.dsTeachersUnion.TBLReplyPrintRow NewRow = dsTeachersUnion.TBLReplyPrint.NewTBLReplyPrintRow();
                    if (!row.checkforprint)
                        continue;
                    NewRow.MemberId = row.MemberId;
                    NewRow.printdate = SQLProvider.GetServerDateTime();
                    NewRow.userin = Program.UserInfo.UserId;
                    dsTeachersUnion.TBLReplyPrint.AddTBLReplyPrintRow(NewRow);
                }
                adp.Update(dsTeachersUnion.TBLReplyPrint);
                Program.ShowMsg("تم الحفظ", false, this);
                Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
                Close();
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
        private void lueSyndicateId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }
            lueSyndicateId_ButtonClick(lueSyndicateId,
                new DevExpress.XtraEditors.Controls.ButtonPressedEventArgs
                    (new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK)
                    ));
        }
        private void lueSyndicateId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.OK)
                return;
            if (lueSyndicateId.EditValue == null)
                rePrintCardsTableAdapter.Fill(dsTeachersUnion.RePrintCards);
            else
                rePrintCardsTableAdapter.FillBySyndicateId(dsTeachersUnion.RePrintCards, Convert.ToInt32(lueSyndicateId.EditValue));
            AssignBarcode();
        }
        private void tbesalno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }
            tbesalno_ButtonClick(tbesalno,
                new DevExpress.XtraEditors.Controls.ButtonPressedEventArgs
                    (new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK)
                    ));
        }
        private void tbesalno_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.OK)
                return;
            if (tbesalno.EditValue == null)
                return;
            else
                rePrintCardsTableAdapter.FillByesalno(dsTeachersUnion.RePrintCards, Convert.ToInt32(tbesalno.EditValue));
            AssignBarcode();

        }
        private void tbKideNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }
            tbKideNumber_ButtonClick(tbesalno,
                new DevExpress.XtraEditors.Controls.ButtonPressedEventArgs
                    (new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK)
                    ));
        }
        private void tbKideNumber_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.OK)
                return;
            if (tbKideNumber.EditValue == null)
                return;                
            else
                rePrintCardsTableAdapter.FillByKideNumber(dsTeachersUnion.RePrintCards, Convert.ToInt32(tbKideNumber.EditValue));
            AssignBarcode();
        }

        #endregion
     
    }
}