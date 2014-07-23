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
using System.Linq;
using DevExpress.XtraGrid;

namespace RetirementCenter
{
    public partial class TBLMemberSarfFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext();
        DataSources.dsRetirementCenterTableAdapters.TBLReSarfTableAdapter adpResarf = new DataSources.dsRetirementCenterTableAdapters.TBLReSarfTableAdapter();
        private int MaxDofatSarfId = (int)new DataSources.dsQueriesTableAdapters.TBLDofatSarfTableAdapter().MaxId();
        #region -   Functions   -
        public TBLMemberSarfFrm()
        {
            InitializeComponent();
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
            btnArc.Visible = Program.UserInfo.IsAdmin;

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
        private int TotalMonths(DateTime Bigdate, DateTime SmallDate)
        {
            int months = (Bigdate.Year * 12 + Bigdate.Month) - (SmallDate.Year * 12 + SmallDate.Month) + 1;
            if (SmallDate.Day != 1 && months > 0)
                months--;
            return months;
        }
        private void LoadTblMemberSarf()
        {
            if (LUETBLDofatSarf.EditValue != null && LUESyndicateId.EditValue != null)
                tblMemberSarfTableAdapter.FillByDofatSarfId_SyndicateId(dsRetirementCenter.TBLMemberSarf, Convert.ToInt32(LUETBLDofatSarf.EditValue), Convert.ToInt32(LUESyndicateId.EditValue)); 
        }
        #endregion
        #region - Event Handlers -
        private void TBLMemberSarfFrm_Load(object sender, EventArgs e)
        {
            ActivePriv();
            LSMSTBLDofatSarf.QueryableSource = from q in dsLinq.TBLDofatSarfs where q.dofclosed == false select q;
            if (Program.UserInfo.IsAdmin)
                LSMSCDSyndicate.QueryableSource = dsLinq.CDSyndicates;
            else
                LSMSCDSyndicate.QueryableSource = from q in dsLinq.CDSyndicates where Program.UserInfo.Syndicates.Contains(q.SyndicateId) select q;
            LSMSCDSubCommitte.QueryableSource = dsLinq.CDSubCommittes;

            if (FXFW.SqlDB.IsNullOrEmpty(LUETBLDofatSarf.EditValue))
                LUETBLDofatSarf.EditValue = MaxDofatSarfId;
        }
        private void btnAddAll_Click(object sender, EventArgs e)
        {
            if (LUETBLDofatSarf.EditValue ==  null || LUESyndicateId.EditValue == null)
            {
                Program.ShowMsg("من فضلك اختار الدفعة و الفرعية", true, this, true);
                return;
            }
            DataSources.Linq.TBLDofatSarf dofaa = (DataSources.Linq.TBLDofatSarf)LUETBLDofatSarf.GetSelectedDataRow();
            if ((bool)dofaa.dofclosed)
            {
                Program.ShowMsg("لا يمكن اعداد دفعة مغلقه", true, this, true);
                return;
            }
            if ((int)SQLProvider.adpQry.DofatSarfActivityClosed(Convert.ToInt32(LUESyndicateId.EditValue), dofaa.DofatSarfId, (byte)Misc.Types.CDMashHala.A3da2) > 0)
            {
                if (Program.UserInfo.IsAdmin)
                {
                    if (msgDlg.Show("تم اغلاق هذه الفرعية, هل ترغب في اعادة فتحها؟", msgDlg.msgButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                        return;
                    new DataSources.dsRetirementCenterTableAdapters.DofatSarfActivityTableAdapter().CloseUnCloseDofat(false, SQLProvider.ServerDateTime(), Program.UserInfo.UserId, Convert.ToInt32(LUESyndicateId.EditValue), dofaa.DofatSarfId, (byte)Misc.Types.CDMashHala.A3da2);

                    //if (msgDlg.Show("تم اعادة فتح الفرعية, هل ترغب في الاعداد؟", msgDlg.msgButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                    //    return;
                    //btnDelete_Click(btnDelete, EventArgs.Empty);
                    //return;
                }
                else
                {
                    Program.ShowMsg("تم اغلاق هذه الفرعية لا يمكن اعداد فرعية مغلقه", true, this, true);
                    return;
                }

            }

            if (msgDlg.Show("هل انت متأكد؟", msgDlg.msgButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                return;
            gcCommands.Enabled = false;
            pcProgress.Visible = true;
            dsRetirementCenter.TBLMemberSarf.Clear();

            tblEdafatCreatorTableAdapter.FillBySyndicateId(dsQueries.TBLEdafatCreator, dofaa.DofatSarfId, Convert.ToInt32(LUESyndicateId.EditValue));
            tblEdafatCreator2TableAdapter.FillBySyndicateId(dsQueries.TBLEdafatCreator2, Convert.ToInt32(LUESyndicateId.EditValue), dofaa.DofatSarfId);
            pbc.Properties.Maximum = dsQueries.TBLEdafatCreator.Count + dsQueries.TBLEdafatCreator2.Count;
            lblMax.Text = pbc.Properties.Maximum.ToString(); pbc.EditValue = 0; lblValue.Text = "0";
            DateTime serverdatetime = SQLProvider.ServerDateTime();
            foreach (DataSources.dsQueries.TBLEdafatCreatorRow row1 in dsQueries.TBLEdafatCreator.Rows)
            {
                DataSources.dsRetirementCenter.TBLMemberSarfRow record = dsRetirementCenter.TBLMemberSarf.NewTBLMemberSarfRow();
                record.DofatSarfId = dofaa.DofatSarfId;
                int months = TotalMonths(dofaa.DofatSarfDateto, row1.WorkeEndDate);
                if (months > 15)
                    months = 15;
                record.eshtrakmonth = row1.Eshtrak * months;
                record.estktaa = row1.estktaa;
                record.SyndicateId = row1.SyndicateId;
                record.SubCommitteId = row1.SubCommitteId;

                record.MMashatId = row1.MMashatId;
                record.monymonth = row1.feasarf * months;
                record.rsmmonth = row1.Rasm * months;
                record.sarf = true;
                record.Edafat = true;
                record.sarfdatefrom = row1.WorkeEndDate;
                record.sarfdateto = dofaa.DofatSarfDateto;
                record.datein = serverdatetime;
                record.userin = Program.UserInfo.UserId;
                record.sarfnumber = row1.sarfnumber;
                record.SarfTypeedadId = (int)Misc.Types.SarfTypeedadId.Unknown_1;
                dsRetirementCenter.TBLMemberSarf.AddTBLMemberSarfRow(record);
                try
                { tblMemberSarfTableAdapter.Update(record); }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627) MessageBox.Show(string.Format(@"رقم {0} موجود مسبقا", record.MMashatId)); else MessageBox.Show(ex.Message);
                }

                //Add Resarf
                adpResarf.FillByMMashatId_DofatSarfId(dsRetirementCenter.TBLReSarf, row1.MMashatId, dofaa.DofatSarfId);
                foreach (DataSources.dsRetirementCenter.TBLReSarfRow ResarfRow in dsRetirementCenter.TBLReSarf)
                {
                    DataSources.dsRetirementCenter.TBLMemberSarfRow Resarfrecord = dsRetirementCenter.TBLMemberSarf.NewTBLMemberSarfRow();
                    Resarfrecord.DofatSarfId = dofaa.DofatSarfId;
                    int ResarfManths = TotalMonths(ResarfRow.dateto, ResarfRow.datefrom);
                    if (ResarfManths > 15)
                        ResarfManths = 15;
                    Resarfrecord.eshtrakmonth = row1.Eshtrak * ResarfManths;
                    Resarfrecord.estktaa = ResarfRow.reestktaa;
                    Resarfrecord.MMashatId = ResarfRow.MMashatId;
                    Resarfrecord.monymonth = row1.feasarf * ResarfManths;
                    Resarfrecord.rsmmonth = row1.Rasm * ResarfManths;
                    Resarfrecord.sarf = true;
                    Resarfrecord.Edafat = true;

                    Resarfrecord.sarfdatefrom = ResarfRow.datefrom;
                    Resarfrecord.sarfdateto = ResarfRow.dateto;
                    Resarfrecord.datein = serverdatetime;
                    Resarfrecord.userin = Program.UserInfo.UserId;
                    Resarfrecord.SyndicateId = row1.SyndicateId;
                    Resarfrecord.SubCommitteId = row1.SubCommitteId;
                    Resarfrecord.sarfnumber = row1.sarfnumber;

                    Resarfrecord.SarfTypeedadId = (int)Misc.Types.SarfTypeedadId.Unknown_2;
                    dsRetirementCenter.TBLMemberSarf.AddTBLMemberSarfRow(Resarfrecord);
                    try
                    { tblMemberSarfTableAdapter.Update(Resarfrecord); }
                    catch (SqlException ex)
                    {
                        if (ex.Number == 2627) MessageBox.Show(string.Format(@"رقم {0} موجود مسبقا", record.MMashatId)); else MessageBox.Show(ex.Message);
                    }
                }

                pbc.EditValue = (int)pbc.EditValue + 1;
                lblValue.Text = pbc.EditValue.ToString();
                Application.DoEvents();
            }
            foreach (DataSources.dsQueries.TBLEdafatCreator2Row row2 in dsQueries.TBLEdafatCreator2.Rows)
            {
                DataSources.dsRetirementCenter.TBLMemberSarfRow record = dsRetirementCenter.TBLMemberSarf.NewTBLMemberSarfRow();
                record.DofatSarfId = dofaa.DofatSarfId;
                int months = TotalMonths(dofaa.DofatSarfDateto, dofaa.DofatSarfDatefrom);
                
                if (months > 15)
                    months = 15;
                
                record.MMashatId = row2.MMashatId;
                if (row2.mcompletesarf)
                {
                    record.estktaa = 0;
                    record.eshtrakmonth = row2.Eshtrak * months;
                    record.monymonth = row2.feasarf * months;
                    record.rsmmonth = row2.Rasm * months;
                }
                else
                {
                    record.estktaa = row2.mestktaat;
                    record.eshtrakmonth = row2.meshtrakat;
                    record.monymonth = row2.mmony;
                    record.rsmmonth = row2.melrasm;
                }
                
                record.sarf = true;
                record.Edafat = false;
                record.sarfdatefrom = dofaa.DofatSarfDatefrom;
                record.sarfdateto = dofaa.DofatSarfDateto;
                record.datein = serverdatetime;
                record.userin = Program.UserInfo.UserId;
                record.SyndicateId = row2.SyndicateId;
                record.SubCommitteId = row2.SubCommitteId;
                record.sarfnumber = row2.sarfnumber;
                record.SarfTypeedadId = (int)Misc.Types.SarfTypeedadId.Unknown_1;
                dsRetirementCenter.TBLMemberSarf.AddTBLMemberSarfRow(record);
                try
                { tblMemberSarfTableAdapter.Update(record); }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627) MessageBox.Show(string.Format(@"رقم {0} موجود مسبقا", record.MMashatId)); else MessageBox.Show(ex.Message);
                }

                //Add Resarf
                adpResarf.FillByMMashatId_DofatSarfId(dsRetirementCenter.TBLReSarf, row2.MMashatId, dofaa.DofatSarfId);
                foreach (DataSources.dsRetirementCenter.TBLReSarfRow ResarfRow in dsRetirementCenter.TBLReSarf)
                {
                    DataSources.dsRetirementCenter.TBLMemberSarfRow Resarfrecord = dsRetirementCenter.TBLMemberSarf.NewTBLMemberSarfRow();
                    Resarfrecord.DofatSarfId = dofaa.DofatSarfId;
                    int ResarfManths = TotalMonths(ResarfRow.dateto, ResarfRow.datefrom);
                    if (ResarfManths > 15)
                        ResarfManths = 15;
                    Resarfrecord.eshtrakmonth = row2.Eshtrak * ResarfManths;
                    Resarfrecord.estktaa = ResarfRow.reestktaa;
                    Resarfrecord.MMashatId = ResarfRow.MMashatId;
                    Resarfrecord.monymonth = row2.feasarf * ResarfManths;
                    Resarfrecord.rsmmonth = row2.Rasm * ResarfManths;
                    Resarfrecord.sarf = true;
                    Resarfrecord.Edafat = true;

                    Resarfrecord.sarfdatefrom = ResarfRow.datefrom;
                    Resarfrecord.sarfdateto = ResarfRow.dateto;
                    Resarfrecord.datein = serverdatetime;
                    Resarfrecord.userin = Program.UserInfo.UserId;

                    Resarfrecord.SyndicateId = row2.SyndicateId;
                    Resarfrecord.SubCommitteId = row2.SubCommitteId;
                    Resarfrecord.sarfnumber = row2.sarfnumber;

                    Resarfrecord.SarfTypeedadId = (int)Misc.Types.SarfTypeedadId.Unknown_2;
                    dsRetirementCenter.TBLMemberSarf.AddTBLMemberSarfRow(Resarfrecord);
                    try
                    { tblMemberSarfTableAdapter.Update(Resarfrecord); }
                    catch (SqlException ex)
                    {
                        if (ex.Number == 2627) MessageBox.Show(string.Format(@"رقم {0} موجود مسبقا", record.MMashatId)); else MessageBox.Show(ex.Message);
                    }
                }

                pbc.EditValue = (int)pbc.EditValue + 1;
                lblValue.Text = pbc.EditValue.ToString();
                Application.DoEvents();
            }
            //new DataSources.dsRetirementCenterTableAdapters.DofatSarfActivityTableAdapter().CloseUnCloseDofat(true, SQLProvider.ServerDateTime(), Program.UserInfo.UserId, Convert.ToInt32(LUESyndicateId.EditValue), dofaa.DofatSarfId, (byte)Misc.Types.CDMashHala.A3da2);
            pbc.EditValue = 0; pcProgress.Visible = false; lblValue.Text = "0"; gcCommands.Enabled = true;
            LoadTblMemberSarf();
            Program.ShowMsg("تم الاعـــــداد", false, this, true);
        }
        private void LUETBLDofatSarf_EditValueChanged(object sender, EventArgs e)
        {
            LoadTblMemberSarf();
        }
        private void LUESyndicateId_EditValueChanged(object sender, EventArgs e)
        {
            LoadTblMemberSarf();
        }
        private void gridViewData_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            //GridView GV = (GridView)gridControlData.MainView;

            //DataSources.dsTeachersUnion.TBLDofatdeatilesRow row = (DataSources.dsTeachersUnion.TBLDofatdeatilesRow)GV.GetDataRow(e.RowHandle);
            //row.DofatSarfId = _DofatSarfId;

        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (!Program.UserInfo.IsAdmin)
            {
                Program.ShowMsg("غير مسموح بالتعديل ...", true, this, true);
                return;
            }
            DataSources.dsRetirementCenter.TBLMemberSarfRow row =
               (DataSources.dsRetirementCenter.TBLMemberSarfRow)((DataRowView)gridViewData.GetRow(gridViewData.FocusedRowHandle)).Row;
            try
            {
                row.datein = SQLProvider.ServerDateTime();
                row.userin = Program.UserInfo.UserId;

                tBLMemberSarfBindingSource.EndEdit();
                tblMemberSarfTableAdapter.Update(row);

                Program.ShowMsg("تم التعديل", false, this, true);
                Program.Logger.LogThis("تم التعديل", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void repositoryItemButtonEditDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (!Program.UserInfo.IsAdmin)
            {
                Program.ShowMsg("غير مسموح بالتعديل ...", true, this, true);
                return;
            }
            if (msgDlg.Show("هل انت متأكد؟", msgDlg.msgButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                return;
            GridView GV = (GridView)gridControlData.MainView;
            //DataSources.dsRetirementCenter.TBLMemberSarfRow row = (DataSources.dsRetirementCenter.TBLMemberSarfRow)GV.GetFocusedDataRow();
            DataSources.dsRetirementCenter.TBLMemberSarfRow row =
               (DataSources.dsRetirementCenter.TBLMemberSarfRow)((DataRowView)gridViewData.GetRow(gridViewData.FocusedRowHandle)).Row;
            try
            {
                tblMemberSarfTableAdapter.DeleteQuery(row.MMashatId, row.DofatSarfId, row.SarfTypeedadId);
                dsRetirementCenter.TBLMemberSarf.AcceptChanges();
                GV.DeleteRow(GV.FocusedRowHandle);
                Program.ShowMsg("تم الحذف", false, this);
                Program.Logger.LogThis("تم الحذف", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (LUETBLDofatSarf.EditValue == null || LUESyndicateId.EditValue == null)
            {
                Program.ShowMsg("من فضلك اختار الدفعة و الفرعية", true, this, true);
                return;
            }
            DataSources.Linq.TBLDofatSarf dofaa = (DataSources.Linq.TBLDofatSarf)LUETBLDofatSarf.GetSelectedDataRow();
            if ((bool)dofaa.dofclosed)
            {
                Program.ShowMsg("لا يمكن حذف دفعة مغلقه", true, this, true);
                return;
            }
            if ((int)SQLProvider.adpQry.DofatSarfActivityClosed(Convert.ToInt32(LUESyndicateId.EditValue), dofaa.DofatSarfId, (byte)Misc.Types.CDMashHala.A3da2) > 0)
            {
                if (Program.UserInfo.IsAdmin)
                {
                    if (msgDlg.Show("تم اغلاق هذه الفرعية, هل ترغب في اعادة فتحها؟", msgDlg.msgButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                        return;
                    new DataSources.dsRetirementCenterTableAdapters.DofatSarfActivityTableAdapter().CloseUnCloseDofat(false, SQLProvider.ServerDateTime(), Program.UserInfo.UserId, Convert.ToInt32(LUESyndicateId.EditValue), dofaa.DofatSarfId, (byte)Misc.Types.CDMashHala.A3da2);

                    if (msgDlg.Show("تم اعادة فتح الفرعية, هل ترغب في الحذف؟", msgDlg.msgButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                        return;
                    btnDelete_Click(btnDelete, EventArgs.Empty);
                    return;
                }
                else
                {
                    Program.ShowMsg("تم اغلاق هذه الفرعية لا يمكن حذف فرعية مغلقه", true, this, true);
                    return;
                }
                
            }
            if (msgDlg.Show("هل انت متأكد؟", msgDlg.msgButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                return;
            tblMemberSarfTableAdapter.DeleteQueryByDofatSarfId_SyndicateId(Convert.ToInt32(LUETBLDofatSarf.EditValue), Convert.ToInt32(LUESyndicateId.EditValue));
            Program.ShowMsg("تم الحــــــذف", false, this, true);
            LoadTblMemberSarf();

        }
        private void btnArc_Click(object sender, EventArgs e)
        {
            if (msgDlg.Show("هل انت متأكد؟", msgDlg.msgButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                return;
            try
            {
                tblMemberSarfTableAdapter.InsertIntoTBLMemberSarf_arshef(Convert.ToInt32(LUETBLDofatSarf.EditValue), Convert.ToInt32(LUESyndicateId.EditValue));
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
            Program.ShowMsg("تم الاضافة للارشيف", false, this, true);
        }
        double summaryTotal = 0;
        private void gridViewData_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
            GridColumnSummaryItem item = e.Item as GridColumnSummaryItem;
            GridView view = sender as GridView;

            if (item.FieldName == "MMashatName")
            {
                switch (e.SummaryProcess)
                {
                    case DevExpress.Data.CustomSummaryProcess.Start:
                        summaryTotal = 0;
                        break;
                    case DevExpress.Data.CustomSummaryProcess.Calculate:
                        double plus = Convert.ToDouble(view.GetRowCellValue(e.RowHandle, "monymonth")) -
                            Convert.ToDouble(view.GetRowCellValue(e.RowHandle, "rsmmonth")) -
                            Convert.ToDouble(view.GetRowCellValue(e.RowHandle, "estktaa")) -
                            Convert.ToDouble(view.GetRowCellValue(e.RowHandle, "eshtrakmonth"));
                        summaryTotal += plus;
                        break;
                    case DevExpress.Data.CustomSummaryProcess.Finalize:
                        e.TotalValue = summaryTotal;
                        break;
                }
            }
        }

        #endregion

    }
}
