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

namespace Members
{
    public partial class TBLManualArsheefDetailsFrm : DevExpress.XtraEditors.XtraForm
    {
        private int KartonaNo;
        #region -   Functions   -
        public TBLManualArsheefDetailsFrm(int kartonaNo)
        {
            InitializeComponent();
            KartonaNo = kartonaNo;
        }
        private void ActivePriv()
        {
            return;//ActivePrivReady
            bool Selecting = false, Inserting = false, Updateing = false, Deleting = false;
            SQLProvider.GetFormPriv(this.Name, ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
            gridControlData.Visible = Selecting;
            if (Inserting || Updateing)
                btnAdd.Visible = true;
            else
                btnAdd.Visible = false;
            repositoryItemButtonEditDel.Buttons[0].Visible = Deleting;
        }
        #endregion
        #region - Event Handlers -
        private void TBLMandoopFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsTeachersUnion.TBLPrintCardListGrouped' table. You can move, or remove it, as needed.
            this.tBLPrintCardListGroupedTableAdapter.Fill(this.dsTeachersUnion.TBLPrintCardListGrouped);
            // TODO: This line of code loads data into the 'dsTeachersUnion.TBLMembersList' table. You can move, or remove it, as needed.
            this.tBLMembersListTableAdapter.Fill(this.dsTeachersUnion.TBLMembersList);
            // TODO: This line of code loads data into the 'dsTeachersUnion.TBLManualArsheefDetails' table. You can move, or remove it, as needed.
            this.tBLManualArsheefDetailsTableAdapter.FillByKartonaNo(dsTeachersUnion.TBLManualArsheefDetails, KartonaNo);
            ActivePriv();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;

            DataSources.dsTeachersUnion.TBLPrintCardListGroupedRow row = (DataSources.dsTeachersUnion.TBLPrintCardListGroupedRow)((DataRowView)LUEEmp.GetSelectedDataRow()).Row;
            
            DataSources.dsTeachersUnion ds = new DataSources.dsTeachersUnion();
            DataSources.dsTeachersUnionTableAdapters.TBLPrintCardListTableAdapter adpLoad = new DataSources.dsTeachersUnionTableAdapters.TBLPrintCardListTableAdapter();
            adpLoad.FillByprintdate_esalno(ds.TBLPrintCardList, row.printdate, row.esalno);
            foreach (DataSources.dsTeachersUnion.TBLPrintCardListRow item in ds.TBLPrintCardList.Rows)
            {
                DataSources.dsTeachersUnion.TBLManualArsheefDetailsRow rowSave = dsTeachersUnion.TBLManualArsheefDetails.NewTBLManualArsheefDetailsRow();
                if (tBLManualArsheefDetailsTableAdapter.GetDataByMemberId(item.MemberId).Rows.Count == 0)
                    tBLManualArsheefDetailsTableAdapter.Insert(KartonaNo, item.MemberId, item.esalno, item.printdate);
            }
            tBLManualArsheefDetailsTableAdapter.FillByKartonaNo(dsTeachersUnion.TBLManualArsheefDetails, KartonaNo);

            Program.ShowMsg("تم الحفظ", false, this);
            Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
        }
        private void repositoryItemButtonEditDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataSources.dsTeachersUnion.TBLManualArsheefDetailsRow row = (DataSources.dsTeachersUnion.TBLManualArsheefDetailsRow)gridViewData.GetFocusedDataRow();
            
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            tBLManualArsheefDetailsTableAdapter.Delete(row.detailid);
            gridViewData.DeleteRow(gridViewData.FocusedRowHandle);
            Program.ShowMsg("تم الحذف", false, this);
            Program.Logger.LogThis("تم الحذف", Text, FXFW.Logger.OpType.success, null, null, this);
        }
        #endregion

    }
}