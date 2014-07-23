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
    public partial class TBLPrintCard3Frm : DevExpress.XtraEditors.XtraForm
    {
        
        #region -   Functions   -
        public TBLPrintCard3Frm()
        {
            InitializeComponent();
        }
        private void LoadDefaultData()
        {
            lueSyndicateId.Properties.DataSource = SQLProvider.SelectCDSyndicate();
            lueSyndicateId.Properties.DisplayMember = "Syndicate";
            lueSyndicateId.Properties.ValueMember = "SyndicateId";
        }
        private void LoadGrid()
        {
            DataSources.dsTeachersUnion.PrintCardsDataTable dt = SQLProvider.SelectTBLPrintCard((int)Program.cardtype.مؤقتة, lueSyndicateId.EditValue, tbesalno.EditValue, true);
            for (int i = dt.Rows.Count - 1; i > -1; i--)
            {
                //Generat Barcode
                DataSources.dsTeachersUnion.PrintCardsRow row = (DataSources.dsTeachersUnion.PrintCardsRow)dt.Rows[i];
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

            gridControlData.DataSource = dt;

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
        #endregion
        #region - Event Handlers -
        private void TBLPrintCardFrm_Load(object sender, EventArgs e)
        {
            ActivePriv();
            LoadDefaultData();
            this.Disposed += TBLPrintCard2Frm_Disposed;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadGrid();
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
            DataTable dt = (DataTable)gridControlData.DataSource;
            int counter = Convert.ToInt32(btnChooseNo.EditValue);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (i < counter)
                    dt.Rows[i]["checkforprint"] = true;
                else
                    dt.Rows[i]["checkforprint"] = false;
            }
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)gridControlData.DataSource;
            if ((int)dt.Compute("Count(MemberId)", "checkforprint = 'True'") == 0)
            {
                Program.ShowMsg("يجب اختيار عضو واحد علي الاقل", true, this);
                Program.Logger.LogThis("يجب اختيار عضو واحد علي الاقل", Text, FXFW.Logger.OpType.warning, null, null, this);
                return;
            }
            
            for (int i = dt.Rows.Count - 1; i > -1; i--)
            {
                if ((string)dt.Rows[i]["checkforprint"] == "True" && FXFW.SqlDB.IsNullOrEmpty(dt.Rows[i]["esalno"]))
                {
                    Program.ShowMsg("يجب ادخال رقم الايصال لكل كارت", false, this);
                    return;
                }
            }
            //get all selected rows
            for (int i = dt.Rows.Count - 1; i > -1; i--)
            {
                if ((string)dt.Rows[i]["checkforprint"] != "True")
                {
                    dt.Rows.RemoveAt(i);
                }
                else
                {
                    if (!FXFW.SqlDB.IsNullOrEmpty(dt.Rows[i]["Img"]))
                    {
                        string FilePath = dt.Rows[i]["Img"].ToString();
                        if (File.Exists(FilePath))
                            dt.Rows[i]["ImgData"] = File.ReadAllBytes(FilePath);
                    }
                }
            }
            //prepare print report to show
            XRepMemCard2 report = new XRepMemCard2();
            report.LoadDataSource(dt);
            Misc.Misc.ShowPrintPreview(report);

            if (MessageBox.Show("هل ترغب في الحفظ؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            try
            {
                if (SQLProvider.InsertTBLPrintCard(dt))
                {
                    LoadGrid();
                    Program.ShowMsg("تم الحفظ", false, this);
                    Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
                }
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
            
        }
        void TBLPrintCard2Frm_Disposed(object sender, EventArgs e)
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