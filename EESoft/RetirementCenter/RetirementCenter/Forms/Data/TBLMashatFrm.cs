using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Imaging;
using DevExpress.XtraExport;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.DXErrorProvider;
using RetirementCenter.Forms.Data;
using RetirementCenter.Misc;
using DevExpress.XtraEditors.Repository;
using DevExpress.Data.Linq;

namespace RetirementCenter
{
    public partial class TBLMashatFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext();
        object DefaultsarfTypeId = "1";
        private int MaxDofatSarfId = (int)new DataSources.dsQueriesTableAdapters.TBLDofatSarfTableAdapter().MaxId();
        public enum TabInfo
        {
            BasicInfo,
            SarfInfo,
            PrivateSartInfo,
            NotesInfo,
            SynChangeInfo,
            WarasaInfo,
            MemberWarasaChangeInfo,
            RepeateSarfInfo,
        }
        #region -   Functions   -
        public TBLMashatFrm()
        {
            InitializeComponent();
        }
        public TBLMashatFrm(int MMashatId, TabInfo tab)
        {
            InitializeComponent();
            LUEEmp.EditValue = MMashatId;
            switch (tab)
            {
                case TabInfo.WarasaInfo:
                    xtraTabControlMain.SelectedTabPage = xtraTabPageWarasa;
                    break;
            }
        }
        void LoadData()
        {
            if (Program.UserInfo.IsAdmin)
            {
                LSMSCDSyndicate.QueryableSource = dsLinq.CDSyndicates;
                LSMSDATA.QueryableSource = dsLinq.vTBLMashats;
            }
            else
            {
                LSMSCDSyndicate.QueryableSource = from q in dsLinq.CDSyndicates where Program.UserInfo.Syndicates.Contains(q.SyndicateId) select q;
                LSMSDATA.QueryableSource = from q in dsLinq.vTBLMashats where Program.UserInfo.Syndicates.Contains(q.SyndicateId) select q;
            }
            LUESyndicateId.Properties.BestFit();
            LUEEmp.Properties.View.BestFitColumns();
            LSMSCDMashHala.QueryableSource = dsLinq.CDMashHalas; LUEMashHalaId.Properties.BestFit();
            LSMSTBLDofatSarf.QueryableSource = dsLinq.TBLDofatSarfs; lueDofatSarfId.Properties.BestFit();
            LSMSCDsarfType.QueryableSource = dsLinq.CDsarfTypes; luesarfTypeId.Properties.BestFit();
            // TODO: This line of code loads data into the 'dsRetirementCenter.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.dsRetirementCenter.Users);
            // TODO: This line of code loads data into the 'dsQueries.CDEndwork' table. You can move, or remove it, as needed.
            this.cDEndworkTableAdapter.Fill(this.dsQueries.CDEndwork);

            LSMSCDSyndicateTransfer.QueryableSource = dsLinq.CDSyndicates;
            LSMSCDSubCommitteTransfer.QueryableSource = dsLinq.CDSubCommittes;
            LSMSCDWarasaType.QueryableSource = dsLinq.CDWarasaTypes;
        }
        void Reload()
        {
            LSMSDATA.Reload(); LUEEmp.Properties.View.BestFitColumns();
        }
        void ReloadRemark()
        {
            // TODO: This line of code loads data into the 'dsRetirementCenter.TBLMRemarks' table. You can move, or remove it, as needed.
            this.tBLMRemarksTableAdapter.FillByMMashatId(this.dsRetirementCenter.TBLMRemarks, Convert.ToInt32(LUEEmp.EditValue));
        }
        void ReloadSyndicateTransfer()
        {
            // TODO: This line of code loads data into the 'dsRetirementCenter.TBLSyndicateTransfer' table. You can move, or remove it, as needed.
            this.tBLSyndicateTransferTableAdapter.FillByMMashatId(this.dsRetirementCenter.TBLSyndicateTransfer, Convert.ToInt32(LUEEmp.EditValue));
        }
        void ReloadWarasa()
        {
            //LSMSTBLWarasa.QueryableSource = from q in dsLinq.vTBLWarasas where q.MMashatId == Convert.ToInt32(LUEEmp.EditValue) select q;
            tBLWarasaTableAdapter.FillByMMashatId(dsRetirementCenter.TBLWarasa, Convert.ToInt32(LUEEmp.EditValue));
            LSMSTBLWarasa.QueryableSource = from q in dsLinq.vTBLWarasas where q.MMashatId == Convert.ToInt32(LUEEmp.EditValue) select q;
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
                    FindCtr(this, "new");
                    break;
                case Keys.F6:
                    FindCtr(this, "save");
                    break;
                case Keys.F8:
                    FindCtr(this, "delete");
                    break;
                case Keys.F10:
                    FindCtr(this, "update");
                    break;
                default:
                    break;
            }

        }
        private static void FindCtr(Control MyControls, string tag)
        {
            foreach (Control ctr in MyControls.Controls)
            {
                if (ctr.HasChildren == true)
                {
                    FindCtr(ctr, tag);
                    continue;
                }
                if (ctr is SimpleButton)
                {
                    if (((SimpleButton)ctr).Tag.ToString() == tag && ((SimpleButton)ctr).Enabled && ((SimpleButton)ctr).Visible)
                        ((SimpleButton)ctr).PerformClick();
                }
            }
        }
        private void ActivePriv()
        {
            //return;//ActivePrivReady
            bool Selecting = false, Inserting = false, Updateing = false, Deleting = false;
            SQLProvider.GetFormPriv(this.Name, ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
            LUEEmp.Visible = Selecting;

            btnNew.Visible = Inserting; btnSave.Visible = Inserting;
            repositoryItemButtonEditSave.Buttons[0].Visible = Inserting;

            btnUpdate.Visible = Updateing;
            btnChangeHala.Visible = Updateing;
            repositoryItemButtonEditResarfSave.Buttons[0].Visible = Updateing;
            repositoryItemButtonEditWarasaQuickSave.Buttons[0].Visible = Updateing;
            repositoryItemButtonEditWarasaSarf.Buttons[0].Visible = Updateing;
            repositoryItemButtonEditTransferSave.Buttons[0].Visible = Updateing;

            btnDelete.Visible = Deleting;
            repositoryItemButtonEditResarfDel.Buttons[0].Visible = Deleting;
            repositoryItemButtonEditWarasaDel.Buttons[0].Visible = Deleting;

        }
        private bool DeathBefore2013(bool NewMem)
        {
            if (FXFW.SqlDB.IsNullOrEmpty(deWorkeEndDate.EditValue))
            {
                return false;
            }
            if (NewMem)
            {
                if (FXFW.SqlDB.IsNullOrEmpty(LUEMashHalaId.EditValue))
                    return false;
                if (Convert.ToInt32(LUEMashHalaId.EditValue) == (int)Program.CDMashHala.Warasa && deWorkeEndDate.DateTime.Year < 2013)
                    return true;
                else
                    return false;
            }
            else
            {
                return false;
            }
        }
        #endregion
        #region - Event Handlers -
        private void TBL_EmpFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsRetirementCenter.TBLReSarf' table. You can move, or remove it, as needed.
            this.tBLReSarfTableAdapter.Fill(this.dsRetirementCenter.TBLReSarf);
            ActivePriv();
            LoadData();
            CustomValidationRule lengthValidationRule = new CustomValidationRule();
            lengthValidationRule.ErrorText = "يجب ادخال 14 رقم";
            lengthValidationRule.ErrorType = ErrorType.Warning;
            dxValidationProviderMain.SetValidationRule(tbMMashatNId, lengthValidationRule);
        }
        private void LUEEmp_EditValueChanged(object sender, EventArgs e)
        {
            if (LUEEmp.EditValue == null)
            {
                btnNew_Click(btnNew, new EventArgs());
                btnUpdate.Enabled = false;
                btnSave.Enabled = false;
                btnDelete.Enabled = false;
                return;
            }
            LUESyndicateId.Enabled = false;
            LUESubCommitteId.Enabled = false;

            int MMashatId = Convert.ToInt32(LUEEmp.EditValue);
            tblMashatTableAdapter.FillByMMashatId(dsRetirementCenter.TBLMashat, MMashatId);
            DataSources.dsRetirementCenter.TBLMashatRow row = dsRetirementCenter.TBLMashat[0];
            
            gridControlTBLNoSarfDetels.DataSource = from q in dsLinq.TBLNoSarfDetels where q.MMashatId == MMashatId select q;
            LUEMashHalaId.Enabled = false;

            ReloadRemark();
            // TODO: This line of code loads data into the 'dsRetirementCenter.TBLEdafat' table. You can move, or remove it, as needed.
            this.tBLEdafatTableAdapter.FillByMMashatId(this.dsRetirementCenter.TBLEdafat, row.MMashatId);

            tBLReSarfTableAdapter.FillByMMashatId(dsRetirementCenter.TBLReSarf, row.MMashatId);

            ReloadSyndicateTransfer();
            ReloadWarasa();
            if (dsRetirementCenter.TBLEdafat.Count > 0)
                ceEnableEdafat.Checked = true;
            else
                ceEnableEdafat.Checked = false; 

            xtraTabControlMain.Enabled = gcCommands.Enabled = true;
            xtraTabPageRemarks.PageVisible = true;
            xtraTabPageSyndicateTransfer.PageVisible = true;
            

            LUEChangeHala.EditValue = row.MashHalaId;
            if (row.MashHalaId == (int)Misc.Types.CDMashHala.Warasa)
            {
                xtraTabPageWarasa.PageVisible = true;
                xtraTabPageChangeToWarasa.PageVisible = false;
                xtraTabPageReSarf.PageVisible = false;
                ceSarfExpetion.Enabled = true;
            }
            else
            {
                xtraTabPageWarasa.PageVisible = false;
                xtraTabPageChangeToWarasa.PageVisible = true;
                xtraTabPageReSarf.PageVisible = true;
                ceSarfExpetion.Enabled = false;
            }

            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            LUESyndicateId.Enabled = true;
            LUESubCommitteId.Enabled = true;
            LUEMashHalaId.Enabled = true;

            xtraTabControlMain.Enabled = gcCommands.Enabled = true;

            dsRetirementCenter.TBLMashat.Clear(); dsRetirementCenter.TBLMashat.AcceptChanges();
            DataSources.dsRetirementCenter.TBLMashatRow row = dsRetirementCenter.TBLMashat.NewTBLMashatRow();

            row.MMashatId = -1; row.MMashatName = string.Empty; row.SarfExpetion = false;
            //row.SyndicateId = Convert.ToInt32(LUESyndicateId.Properties.GetDataSourceValue("SyndicateId", 0));
            row.datein = SQLProvider.ServerDateTime(); row.userin = Program.UserInfo.UserId; row.yasref = true;
            row.mcompletesarf = true; row.melrasm = 0; row.meshtrakat = 0; row.mestktaat = 0; row.mmony = 0;
            dsRetirementCenter.TBLMashat.AddTBLMashatRow(row);

            gridControlTBLNoSarfDetels.DataSource = null;

            tbMMashatName.Focus();
            
            LUEEmp.EditValue = null;
            
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            xtraTabPageRemarks.PageVisible = false;
            xtraTabPageSyndicateTransfer.PageVisible = false;
            xtraTabPageWarasa.PageVisible = false;
            xtraTabPageChangeToWarasa.PageVisible = false;
            xtraTabPageReSarf.PageVisible = false;

            ceSarfExpetion.Checked = false;

            ceEnableEdafat.Checked = false;
            lueDofatSarfId.EditValue = null;
            luesarfTypeId.EditValue = DefaultsarfTypeId;
            tbestktaa.EditValue = 0;

            tbMMashatName.Focus();
        }
        private void LUESyndicateId_EditValueChanged(object sender, EventArgs e)
        {
            if (LUESyndicateId.EditValue != null && LUESyndicateId.EditValue.ToString() != string.Empty)
            {
                int id = Convert.ToInt32(LUESyndicateId.EditValue);
                var query = from q in dsLinq.CDSubCommittes where q.SyndicateId == id select q;
                LSMSCDSubCommitte.QueryableSource = query;
                LSMSCDSubCommitte.Reload();
            }
            
            LUESubCommitteId.Properties.BestFit();
        }
        private void ceyasref_CheckedChanged(object sender, EventArgs e)
        {
            if (dsRetirementCenter.TBLMashat.Count == 0)
            {
                return;
            }
            DataSources.dsRetirementCenter.TBLMashatRow Mainrow = dsRetirementCenter.TBLMashat[0];

            if ((bool)Mainrow["yasref", DataRowVersion.Current] == ceyasref.Checked)
            {
                dsRetirementCenter.TBLNoSarfDetels.Clear();
                return;
            }
            if (ceyasref.Checked)
            {
                if (Mainrow.RowState == DataRowState.Added)
                    return;
            }

            

            DataSources.dsRetirementCenter.TBLNoSarfDetelsRow row = dsRetirementCenter.TBLNoSarfDetels.NewTBLNoSarfDetelsRow();
            row.MMashatId = -1; row.datehala = DateTime.Now; row.halarem = string.Empty;
            TBLNoSarfDetelsDlg dlg = new TBLNoSarfDetelsDlg(row);

            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tblNoSarfDetelsTablebindingSource.EndEdit();
                row.yasref = ceyasref.Checked;
                dsRetirementCenter.TBLNoSarfDetels.AddTBLNoSarfDetelsRow(row);
            }
            else
                ceyasref.Checked = !ceyasref.Checked;
        }
        private void ceEnableEdafat_CheckedChanged(object sender, EventArgs e)
        {
            if (!ceEnableEdafat.Checked)
            {
                pnlEdafat.Enabled = false;
                lueDofatSarfId.EditValue = null;
                luesarfTypeId.EditValue = null;
                tbestktaa.EditValue = 0;
                dsRetirementCenter.TBLEdafat.Clear();
                return;
            }
            pnlEdafat.Enabled = true;

            if (dsRetirementCenter.TBLEdafat.Count == 0)// if nothing then create new
            {
                DataSources.dsRetirementCenter.TBLEdafatRow row = dsRetirementCenter.TBLEdafat.NewTBLEdafatRow();
                row.estktaa = 0; row.userin = Program.UserInfo.UserId; row.datein = SQLProvider.ServerDateTime();
                row.sarfTypeId = 1;
                row.MMashatId = Convert.ToInt32(LUEEmp.EditValue);
                dsRetirementCenter.TBLEdafat.AddTBLEdafatRow(row);
            }
            if (FXFW.SqlDB.IsNullOrEmpty(lueDofatSarfId.EditValue))
                lueDofatSarfId.EditValue = MaxDofatSarfId;
          
            lueDofatSarfId.Focus();
        }
        private void LUEMashHalaId_EditValueChanged(object sender, EventArgs e)
        {
            if (LUEMashHalaId.EditValue.ToString() == ((int)Misc.Types.CDMashHala.A3da2).ToString())
            {
                ceEnableEdafat.Enabled = true;
            }
            else
            {
                ceEnableEdafat.Enabled = false;
                ceEnableEdafat.Checked = false;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!dxValidationProviderMain.Validate(tbMMashatName) || !dxValidationProviderMain.Validate(LUESyndicateId) ||
                !dxValidationProviderMain.Validate(LUESubCommitteId) || !dxValidationProviderMain.Validate(tbsarfnumber) ||
                !dxValidationProviderMain.Validate(LUEMashHalaId))
                return;
            if ((tbMMashatNId.EditValue == null || tbMMashatNId.EditValue.ToString() == string.Empty) && !DeathBefore2013(true))
            {
                Program.ShowMsg("يجب ادخال الرقم القومي", true, this, true);
                return;
            }
            if (!dxValidationProviderMain.GetValidationRule(tbMMashatNId).Validate(tbMMashatNId, tbMMashatNId.EditValue))
            {
                Program.ShowMsg("يجب ادخال 14 رقم في الرقم القومي", true, this, true);
                return;
            }
            try
            {
                if (tbMMashatNId.EditValue != null && tbMMashatNId.EditValue.ToString() != string.Empty)
                {
                    if ((int)SQLProvider.adpQry.ExistsNID(tbMMashatNId.EditValue.ToString(), -100, -100) > 0)
                    {
                        Program.ShowMsg("الرقم القومي موجود مسبقا", true, this, true);
                        return;
                    }
                }
                
                DataSources.dsRetirementCenter.TBLMashatRow row = dsRetirementCenter.TBLMashat[0];

                if (row.RowState == DataRowState.Added)
                {
                    row.MMashatId = (int)SQLProvider.adpQry.MemberNewId();
                }
                if (!row.IsMMashatNIdNull() && row.MMashatNId != string.Empty)
                {
                    try
                    {
                        row.BirthDate = Convert.ToDateTime(Misc.Misc.IDExtraction(row.MMashatNId)[1]);
                    }
                    catch (Exception ex)
                    {
                        Program.ShowMsg("خطاء في الرقم القومي" + Environment.NewLine + ex.Message, true, this, true);
                        Program.Logger.LogThis("خطاء في الرقم القومي" + Environment.NewLine + ex.Message, Text, FXFW.Logger.OpType.fail, null, null, this);
                        return;
                    }
                    
                }

                row.datein = SQLProvider.ServerDateTime();
                row.userin = Program.UserInfo.UserId;
                tBLMashatTablebbindingSource.EndEdit();
                tblMashatTableAdapter.Update(dsRetirementCenter.TBLMashat);
              
                if (!row.yasref)
                {
                    dsRetirementCenter.TBLNoSarfDetels[0].MMashatId = row.MMashatId;
                    dsRetirementCenter.TBLNoSarfDetels[0].userin = Program.UserInfo.UserId;
                    dsRetirementCenter.TBLNoSarfDetels[0].datein = SQLProvider.ServerDateTime();
                    tblNoSarfDetelsTableAdapter.Update(dsRetirementCenter.TBLNoSarfDetels);
                }

                if (!SaveEdafat(row))
                    Program.Logger.LogThis("لم نتمكن من حفظ الاضافات", Text, FXFW.Logger.OpType.fail, null, null, this);

                Reload();
                Program.ShowMsg("تم الاضافة", false, this, true);
                btnNew_Click(btnNew, new EventArgs());
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (FXFW.SqlDB.IsNullOrEmpty(LUEEmp.EditValue))
                return;
            if (!dxValidationProviderMain.Validate(tbMMashatName) || !dxValidationProviderMain.Validate(LUESyndicateId) ||
                !dxValidationProviderMain.Validate(LUESubCommitteId) || !dxValidationProviderMain.Validate(tbsarfnumber) || 
                !dxValidationProviderMain.Validate(LUEMashHalaId))
                return;
            if (!dxValidationProviderMain.GetValidationRule(tbMMashatNId).Validate(tbMMashatNId, tbMMashatNId.EditValue))
            {
                Program.ShowMsg("يجب ادخال 14 رقم في الرقم القومي", true, this, true);
                return;
            }
            try
            {
                
                DataSources.dsRetirementCenter.TBLMashatRow row = dsRetirementCenter.TBLMashat[0];
                row.userin = Program.UserInfo.UserId;
                row.datein = SQLProvider.ServerDateTime();
                tBLMashatTablebbindingSource.EndEdit();
                if (!row.IsMMashatNIdNull())
                {
                    if (row["MMashatNId", DataRowVersion.Current].ToString() != row["MMashatNId", DataRowVersion.Original].ToString())
                    {
                        if (tbMMashatNId.EditValue != null && tbMMashatNId.EditValue.ToString() != string.Empty)
                        {
                            if ((int)SQLProvider.adpQry.ExistsNID(tbMMashatNId.EditValue.ToString(), Convert.ToInt32(LUEEmp.EditValue), -100) > 0)
                            {
                                Program.ShowMsg("الرقم القومي موجود مسبقا", true, this, true);
                                return;
                            }
                        }
                    }
                }
                
                //Update Warasa yasref
                if (((bool)row["yasref", DataRowVersion.Current] != (bool)row["yasref", DataRowVersion.Original]) && !row.yasref && row.MashHalaId == (int)Misc.Types.CDMashHala.Warasa)
                    tBLWarasaTableAdapter.UpdateQueryYasrefAllMemberWarasa(row.MMashatId);

                SaveEditAsLog(row);
                
                tblMashatTableAdapter.Update(dsRetirementCenter.TBLMashat);
                if (dsRetirementCenter.TBLNoSarfDetels.Count > 0)
                {
                    dsRetirementCenter.TBLNoSarfDetels[0].MMashatId = row.MMashatId;
                    dsRetirementCenter.TBLNoSarfDetels[0].userin = Program.UserInfo.UserId;
                    dsRetirementCenter.TBLNoSarfDetels[0].datein = SQLProvider.ServerDateTime();
                    tblNoSarfDetelsTableAdapter.Update(dsRetirementCenter.TBLNoSarfDetels);
                }

                if (!SaveEdafat(row))
                    Program.Logger.LogThis("لم نتمكن من حفظ الاضافات", Text, FXFW.Logger.OpType.fail, null, null, this);

                Program.ShowMsg("تم التعديل", false, this,true);
                Reload();
                btnNew_Click(btnNew, new EventArgs());
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void SaveEditAsLog(DataSources.dsRetirementCenter.TBLMashatRow row, bool Deleted = false)
        {
            row.EndEdit();
            if (Deleted)
            {
                tblMashatLOGTableAdapter.Insert(row.MMashatId, (byte)Types.TBLMashatLog.Delete,
                    (string)row["MMashatName", DataRowVersion.Original], (string)row["MMashatName", DataRowVersion.Current], row.userin, row.datein);
                return;
            }
            if ((string)row["MMashatName", DataRowVersion.Current] != (string)row["MMashatName", DataRowVersion.Original])
            {
                tblMashatLOGTableAdapter.Insert(row.MMashatId, (byte)Types.TBLMashatLog.EditName,
                    (string)row["MMashatName", DataRowVersion.Original], (string)row["MMashatName", DataRowVersion.Current], row.userin, row.datein);
            }
            if ((int)row["sarfnumber", DataRowVersion.Current] != (int)row["sarfnumber", DataRowVersion.Original])
            {
                tblMashatLOGTableAdapter.Insert(row.MMashatId, (byte)Types.TBLMashatLog.Editsarfnumber,
                   row["sarfnumber", DataRowVersion.Original].ToString(), row["sarfnumber", DataRowVersion.Current].ToString(), row.userin, row.datein);
            }
            if ((int)row["SyndicateId", DataRowVersion.Current] != (int)row["SyndicateId", DataRowVersion.Original])
            {
                tblMashatLOGTableAdapter.Insert(row.MMashatId, (byte)Types.TBLMashatLog.EditSyndicateId,
                    row["SyndicateId", DataRowVersion.Original].ToString(), row["SyndicateId", DataRowVersion.Current].ToString(), row.userin, row.datein);
            }
            if ((int)row["SubCommitteId", DataRowVersion.Current] != (int)row["SubCommitteId", DataRowVersion.Original])
            {
                tblMashatLOGTableAdapter.Insert(row.MMashatId, (byte)Types.TBLMashatLog.EditSubCommitteId,
                    row["SubCommitteId", DataRowVersion.Original].ToString(), row["SubCommitteId", DataRowVersion.Current].ToString(), row.userin, row.datein);
            }
        }
        private bool SaveEdafat(DataSources.dsRetirementCenter.TBLMashatRow row)
        {
            bool returnMe = false;
            if (dsRetirementCenter.TBLEdafat.Count == 0)
            {
                tBLEdafatTableAdapter.Delete(row.MMashatId);
                return true;
            }
            if (dxValidationProviderEdafat.Validate() == false)
                return returnMe;
            dsRetirementCenter.TBLEdafat[0].MMashatId = row.MMashatId;
            dsRetirementCenter.TBLEdafat[0].EndEdit();
            tBLEdafatTableAdapter.Update(dsRetirementCenter.TBLEdafat);
            return true;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (LUEEmp.EditValue == null)
                return;
            if (msgDlg.Show("هل انت متأكد؟", msgDlg.msgButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                return;
            try
            {
                int MMashatId = Convert.ToInt32(LUEEmp.EditValue);

                tblMashatTableAdapter.FillByMMashatId(dsRetirementCenter.TBLMashat, MMashatId);
                DataSources.dsRetirementCenter.TBLMashatRow row = dsRetirementCenter.TBLMashat[0];
                
                tblMashatTableAdapter.Delete(MMashatId);
                
                SaveEditAsLog(row, true);

                Program.ShowMsg("تم الحذف", false, this, true);
                Program.Logger.LogThis("تم الحذف", Text, FXFW.Logger.OpType.success, null, null, this);
                Reload();
                btnNew_Click(btnNew, new EventArgs());
                btnSave.Enabled = false;
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void gridViewRemarks_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataSources.dsRetirementCenter.TBLMRemarksRow row = (DataSources.dsRetirementCenter.TBLMRemarksRow)((DataRowView)
                gridViewRemarks.GetRow(e.RowHandle)).Row;
            row.MMashatId = Convert.ToInt32(LUEEmp.EditValue);
            row.userin = Program.UserInfo.UserId;
            row.datein = SQLProvider.ServerDateTime();
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            DataSources.dsRetirementCenter.TBLMRemarksRow row = (DataSources.dsRetirementCenter.TBLMRemarksRow)((DataRowView)
                gridViewRemarks.GetRow(gridViewRemarks.FocusedRowHandle)).Row;
            try
            {
                if (row.RowState != DataRowState.Detached && row.RowState != DataRowState.Added)
                {
                    Program.ShowMsg("لا يمكن تعديل", true, this, true);
                    Program.Logger.LogThis("لا يمكن تعديل", Text, FXFW.Logger.OpType.fail, null, null, this);
                    return;
                }
                tBLMRemarksBindingSource.EndEdit();
                tBLMRemarksTableAdapter.Update(row);
                ReloadRemark();
                Program.ShowMsg("تم اضافة الملاحظة", false, this, true);
                Program.Logger.LogThis("تم اضافة الملاحظة", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void gridViewSyndicateTransfer_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataSources.dsRetirementCenter.TBLSyndicateTransferRow row = (DataSources.dsRetirementCenter.TBLSyndicateTransferRow)((DataRowView)
                gridViewSyndicateTransfer.GetRow(e.RowHandle)).Row;
            row.MMashatId = Convert.ToInt32(LUEEmp.EditValue);
            row.userin = Program.UserInfo.UserId;
            row.datein = SQLProvider.ServerDateTime();

            RetirementCenter.DataSources.Linq.vTBLMashat Member = (RetirementCenter.DataSources.Linq.vTBLMashat)LUEEmp.GetSelectedDataRow();
            row.OldSyndicateId = Member.SyndicateId;
            if (Member.SubCommitteId != null)
                row.OldSubCommitteId = (int)Member.SubCommitteId;
        }
        private void repositoryItemGridLookUpEditSubCommitteId_Enter(object sender, EventArgs e)
        {
            DataSources.dsRetirementCenter.TBLSyndicateTransferRow row = (DataSources.dsRetirementCenter.TBLSyndicateTransferRow)((DataRowView)
                gridViewSyndicateTransfer.GetRow(gridViewSyndicateTransfer.FocusedRowHandle)).Row;

            LinqServerModeSource ds = new LinqServerModeSource();
            ds.ElementType = typeof(RetirementCenter.DataSources.Linq.CDSubCommitte); ds.KeyExpression = "[SubCommitteId]";

            GridLookUpEdit editor = (GridLookUpEdit)sender;
            if (row.IsNewSyndicateIdNull())
                ds.QueryableSource = null;
            else
                ds.QueryableSource = from q in dsLinq.CDSubCommittes where q.SyndicateId == row.NewSyndicateId select q;
            editor.Properties.DataSource = ds;
        }
        private void repositoryItemButtonEditTransferSave_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            DataSources.dsRetirementCenter.TBLSyndicateTransferRow row = (DataSources.dsRetirementCenter.TBLSyndicateTransferRow)((DataRowView)
               gridViewSyndicateTransfer.GetRow(gridViewSyndicateTransfer.FocusedRowHandle)).Row;
            try
            {
                if (row.IsTransferDateNull())
                {
                    Program.ShowMsg("يجب ادخال التاريخ", true, this, true);
                    return;
                }
                if (row.RowState != DataRowState.Detached && row.RowState != DataRowState.Added)
                {
                    Program.ShowMsg("لا يمكن تعديل", true, this, true);
                    Program.Logger.LogThis("لا يمكن تعديل", Text, FXFW.Logger.OpType.fail, null, null, this);
                    return;
                }
                tBLSyndicateTransferBindingSource.EndEdit();
                tBLSyndicateTransferTableAdapter.Update(row);

                tblMashatTableAdapter.UpdateQuerySyndicate_SubCommitte(row.NewSyndicateId, row.NewSubCommitteId, Convert.ToInt32(LUEEmp.EditValue));
                //Update All Warasa Syn/Sub
                tBLWarasaTableAdapter.UpdateQuerySynSubAllMemberWarasa(row.MMashatId, row.OldSyndicateId, row.OldSubCommitteId);
                ReloadWarasa();

                Reload();
                LUEEmp_EditValueChanged(LUEEmp, EventArgs.Empty);
                Program.ShowMsg("تم تعديل الفرعية و اللجنة", false, this, true);
                Program.Logger.LogThis("تم اضافة الفرعية و اللجنة", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void btnAddTBLWarasa_Click(object sender, EventArgs e)
        {
            dsRetirementCenter.TBLWarasa.Clear(); dsRetirementCenter.TBLNoSarfWarsa.Clear();
            dsRetirementCenter.TBLEdafatWarsa.Clear();

            DataSources.dsRetirementCenter.TBLWarasaRow row = dsRetirementCenter.TBLWarasa.NewTBLWarasaRow();
            row.PersonId = -1; row.MMashatId = Convert.ToInt32(LUEEmp.EditValue); row.personName = string.Empty;
            row.yasref = true; row.userin = Program.UserInfo.UserId; row.datein = SQLProvider.ServerDateTime();
            row.responsiblesarf = false; row.wcompletesarf = true; row.wmony = 0; row.westktaat = 0; row.welrasm = 0;
            dsRetirementCenter.TBLWarasa.AddTBLWarasaRow(row);
            //tblEdafatWarsaTableAdapter.FillByPersonId(dsRetirementCenter.TBLEdafatWarsa, -100);
            try
            {
                bool autoOpen = false; int? SyndicateId = null; int? SubCommitteId = null;
                if (e.GetAttachedProperty("auto") != null)
                    autoOpen = true;
                if (e.GetAttachedProperty("SyndicateId") != null)
                    SyndicateId = (int)e.GetAttachedProperty("SyndicateId");
                if (e.GetAttachedProperty("SubCommitteId") != null)
                    SubCommitteId = (int)e.GetAttachedProperty("SubCommitteId");
                if (UpdateTBLWarsa(dsRetirementCenter.TBLWarasa, dsRetirementCenter.TBLNoSarfWarsa, dsRetirementCenter.TBLEdafatWarsa,
                    ref autoOpen, SyndicateId, SubCommitteId))
                {
                    Program.ShowMsg("تم اضافة الورثة", false, this, true);
                    Program.Logger.LogThis("تم اضافة الورثة", Text, FXFW.Logger.OpType.success, null, null, this);
                }
                if (autoOpen)
                {
                    EventArgs arg = new EventArgs();
                    arg.SetAttachedProperty("auto", "true");
                    arg.SetAttachedProperty("SyndicateId", row.SyndicateId);
                    arg.SetAttachedProperty("SubCommitteId", row.SubCommitteId);
                    btnAddTBLWarasa_Click(btnAddTBLWarasa, arg);
                }
                ReloadWarasa();
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void repositoryItemButtonEditWarasaEdit_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            int PersonId = ((DataSources.dsRetirementCenter.TBLWarasaRow)((DataRowView)
             gridViewTBLWarasa.GetRow(gridViewTBLWarasa.FocusedRowHandle)).Row).PersonId;

            dsRetirementCenter.TBLWarasa.Clear(); dsRetirementCenter.TBLNoSarfWarsa.Clear();

            int MMashatId = Convert.ToInt32(LUEEmp.EditValue);

            tBLWarasaTableAdapter.FillByPersonId(dsRetirementCenter.TBLWarasa, PersonId);

            tblEdafatWarsaTableAdapter.FillByPersonId(dsRetirementCenter.TBLEdafatWarsa, PersonId);

            try
            {
                bool autoOpen = false;
                if (UpdateTBLWarsa(dsRetirementCenter.TBLWarasa, dsRetirementCenter.TBLNoSarfWarsa, dsRetirementCenter.TBLEdafatWarsa, ref autoOpen))
                {
                    Program.ShowMsg("تم تعديل الورثة", false, this, true);
                    Program.Logger.LogThis("تم تعديل الورثة", Text, FXFW.Logger.OpType.success, null, null, this);
                }
                ReloadWarasa();
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        bool UpdateTBLWarsa(DataSources.dsRetirementCenter.TBLWarasaDataTable TBLWarasa, DataSources.dsRetirementCenter.TBLNoSarfWarsaDataTable TBLNoSarfDetels,
            DataSources.dsRetirementCenter.TBLEdafatWarsaDataTable TBLEdafatWarsa, ref bool AutoOpen, int? SyndicateId = null, int? SubCommitteId = null)
        {
            TBLWarasaDlg dlg = new TBLWarasaDlg(TBLWarasa, TBLNoSarfDetels, TBLEdafatWarsa, TBLWarasaDlg.OpenReason.Edit);
            if (dsRetirementCenter.TBLWarasa[0].RowState == DataRowState.Added)
            {
                dlg.ceAutoOpen.Visible = true;
                dlg.ceAutoOpen.Checked = AutoOpen;
                if (SyndicateId != null)
                    dsRetirementCenter.TBLWarasa[0].SyndicateId = Convert.ToInt32(SyndicateId);
                if (SubCommitteId != null)
                    dsRetirementCenter.TBLWarasa[0].SubCommitteId = Convert.ToInt32(SubCommitteId);
            }
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                TBLWarasa[0].userin = Program.UserInfo.UserId;
                TBLWarasa[0].datein = SQLProvider.ServerDateTime();
                tBLWarasaBindingSource.EndEdit();
                tBLWarasaTableAdapter.Update(TBLWarasa);
                tblNoSarfWarsaTableAdapter.Update(TBLNoSarfDetels);
                if (TBLEdafatWarsa.Count > 0)
                {
                    tBLEdafatWarsaBindingSource.EndEdit();
                    tblEdafatWarsaTableAdapter.Update(TBLEdafatWarsa);
                }
                else
                    tblEdafatWarsaTableAdapter.Delete(TBLWarasa[0].PersonId);
                AutoOpen = dlg.ceAutoOpen.Checked;
                return true;
            }
            else
            {
                AutoOpen = false;
                return false;

            }
            
        }
        private void repositoryItemButtonEditWarasaQuickSave_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            DataSources.dsRetirementCenter.TBLWarasaRow row = (DataSources.dsRetirementCenter.TBLWarasaRow)((DataRowView)
               gridViewTBLWarasa.GetRow(gridViewTBLWarasa.FocusedRowHandle)).Row;
            try
            {
                if (!row.IspersonNIDNull() && row.personNID != string.Empty)
                {
                    if ((int)SQLProvider.adpQry.ExistsNID(row.personNID, -100, row.PersonId) > 0)
                    {
                        Program.ShowMsg("الرقم القومي موجود مسبقا", true, this, true);
                        return;
                    }
                }
                if (row.responsiblesarf)
                    row.responsiblesarfId = row.PersonId;
                tBLWarasaBindingSource.EndEdit();

                if ((row["responsiblesarf", DataRowVersion.Current].ToString() != row["responsiblesarf", DataRowVersion.Original].ToString()) && !row.responsiblesarf)
                {
                    if (SQLProvider.adpQry.TBLWarasaPersonResponsibleSarfCount(row.PersonId) > 0)
                    {
                        Program.ShowMsg("لا يمكن ازالة مسؤل الصرف عن هذا الوريث لانه مسئول صرف عن اخرين" + Environment.NewLine +
                        "قم بأزالة مسئوليته عن الاخرين ثم عاود التعديل", true, this, true);
                        return;
                    }
                }
                tBLWarasaTableAdapter.Update(row);
                LUEEmp_EditValueChanged(LUEEmp, EventArgs.Empty);
                Program.ShowMsg("تم تعديل بيانات الوريث", false, this, true);
                Program.Logger.LogThis("تم اضافة بيانات الوريث", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void repositoryItemButtonEditWarasaDel_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (msgDlg.Show("هل انت متأكد؟", msgDlg.msgButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                return;
            DataSources.dsRetirementCenter.TBLWarasaRow row = (DataSources.dsRetirementCenter.TBLWarasaRow)((DataRowView)
             gridViewTBLWarasa.GetRow(gridViewTBLWarasa.FocusedRowHandle)).Row;
            try
            {
                tBLWarasaTableAdapter.Delete(row.PersonId);
                Program.ShowMsg("تم حذف الورثة", false, this, true);
                Program.Logger.LogThis("تم حذف الورثة", Text, FXFW.Logger.OpType.success, null, null, this);
                
                ReloadWarasa();
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void repositoryItemButtonEditWarasaSarf_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            DataSources.dsRetirementCenter.TBLWarasaRow row = (DataSources.dsRetirementCenter.TBLWarasaRow)((DataRowView)
             gridViewTBLWarasa.GetRow(gridViewTBLWarasa.FocusedRowHandle)).Row;

            TBLNoSarfWarsaInfo info = new TBLNoSarfWarsaInfo(row.PersonId);
            info.ShowDialog();
        }
        private void repositoryItemButtonEditWarasaRemark_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            int PersonId = ((DataSources.dsRetirementCenter.TBLWarasaRow)((DataRowView)
            gridViewTBLWarasa.GetRow(gridViewTBLWarasa.FocusedRowHandle)).Row).PersonId;

            dsRetirementCenter.TBLWarasa.Clear(); dsRetirementCenter.TBLNoSarfWarsa.Clear();

            int MMashatId = Convert.ToInt32(LUEEmp.EditValue);

            tBLWarasaTableAdapter.FillByPersonId(dsRetirementCenter.TBLWarasa, PersonId);

            tblEdafatWarsaTableAdapter.FillByPersonId(dsRetirementCenter.TBLEdafatWarsa, PersonId);

            TBLWarasaDlg dlg = new TBLWarasaDlg(dsRetirementCenter.TBLWarasa, dsRetirementCenter.TBLNoSarfWarsa,
                dsRetirementCenter.TBLEdafatWarsa, TBLWarasaDlg.OpenReason.Remark);
            dlg.ShowDialog();

            ReloadWarasa();
        }
        private void btnChangeHala_Click(object sender, EventArgs e)
        {
            if ((byte)LUEMashHalaId.EditValue == (byte)LUEChangeHala.EditValue)
                return;
            if (msgDlg.Show("هل انت متأكد؟", msgDlg.msgButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                return;
            tblMashatTableAdapter.UpdateQueryMashHalaId(Convert.ToByte(LUEChangeHala.EditValue), Convert.ToInt32(LUEEmp.EditValue));
            if ((byte)LUEChangeHala.EditValue == (byte)Misc.Types.CDMashHala.A3da2)
                tBLMRemarksTableAdapter.Insert(Convert.ToInt32(LUEEmp.EditValue), "تغيير من ورثة الي اعضاء ", SQLProvider.ServerDateTime(), Program.UserInfo.UserId);
            else
                tBLMRemarksTableAdapter.Insert(Convert.ToInt32(LUEEmp.EditValue), "تغيير من اعضاء لورثة ", SQLProvider.ServerDateTime(), Program.UserInfo.UserId);
            LUEMashHalaId.EditValue = (byte)LUEChangeHala.EditValue;
            Program.ShowMsg("تم تعديل حالة العضو", false, this, true);
            btnNew_Click(btnNew, EventArgs.Empty);
        }
        private void gridViewResarf_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataSources.dsRetirementCenter.TBLReSarfRow row = (DataSources.dsRetirementCenter.TBLReSarfRow)((DataRowView)
              gridViewResarf.GetRow(e.RowHandle)).Row;
            row.MMashatId = Convert.ToInt32(LUEEmp.EditValue);
            row.userin = Program.UserInfo.UserId;
            row.datein = SQLProvider.ServerDateTime();
            row.reestktaa = 0;
        }
        private void repositoryItemButtonEditResarfSave_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            DataSources.dsRetirementCenter.TBLReSarfRow row = (DataSources.dsRetirementCenter.TBLReSarfRow)((DataRowView)
            gridViewResarf.GetRow(gridViewResarf.FocusedRowHandle)).Row;
            try
            {
                
                tBLReSarfBindingSource.EndEdit();
                tBLReSarfTableAdapter.Update(row);
                Program.ShowMsg("تم تعديل بيانات اعادة الصرف", false, this, true);
                Program.Logger.LogThis("تم اضافة بيانات اعادة الصرف", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void repositoryItemButtonEditResarfDel_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            DataSources.dsRetirementCenter.TBLReSarfRow row = (DataSources.dsRetirementCenter.TBLReSarfRow)((DataRowView)
            gridViewResarf.GetRow(gridViewResarf.FocusedRowHandle)).Row;
            try
            {
                if (row.RowState == DataRowState.Detached)
                {
                    gridViewResarf.DeleteRow(gridViewResarf.FocusedRowHandle);
                    return;
                }
                if (msgDlg.Show("هل انت متأكد؟", msgDlg.msgButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                    return;
                tBLReSarfBindingSource.EndEdit();
                tBLReSarfTableAdapter.Delete(row.MMashatId, row.DofatSarfId);
                gridViewResarf.DeleteRow(gridViewResarf.FocusedRowHandle);
                Program.ShowMsg("تم حذف بيانات اعادة الصرف", false, this, true);
                Program.Logger.LogThis("تم حذف بيانات اعادة الصرف", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void cemcompletesarf_CheckedChanged(object sender, EventArgs e)
        {
            pnlPrivateSarf.Enabled = !cemcompletesarf.Checked;
        }
        #endregion

    }
   
}
