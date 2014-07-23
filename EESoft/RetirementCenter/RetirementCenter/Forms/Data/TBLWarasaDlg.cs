using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;

namespace RetirementCenter.Forms.Data
{
    public partial class TBLWarasaDlg : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        private int MaxDofatSarfId = (int)new DataSources.dsQueriesTableAdapters.TBLDofatSarfTableAdapter().MaxId();
        public enum OpenReason
        {
            Edit,
            Remark
        }
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext();

        DataSources.dsRetirementCenter.TBLWarasaDataTable _TBLWarasa;
        DataSources.dsRetirementCenter.TBLNoSarfWarsaDataTable _TBLNoSarfWarsa;
        DataSources.dsRetirementCenter.TBLEdafatWarsaDataTable _TBLEdafatWarsa;

        #endregion
        #region -   Functions   -
        public TBLWarasaDlg(DataSources.dsRetirementCenter.TBLWarasaDataTable TBLWarasa, DataSources.dsRetirementCenter.TBLNoSarfWarsaDataTable TBLNoSarfWarsa,
            DataSources.dsRetirementCenter.TBLEdafatWarsaDataTable TBLEdafatWarsa, OpenReason openReason)
        {
            InitializeComponent();

            LSMSCDWarasaType.QueryableSource = new DataSources.Linq.dsTeachersUnionViewsDataContext().CDWarasaTypes;
            LSMSCDMashHala.QueryableSource = dsLinq.CDMashHalas;
            LSMSTBLDofatSarf.QueryableSource = dsLinq.TBLDofatSarfs;
            LSMSCDSyndicate.QueryableSource = dsLinq.CDSyndicates;
            LSMSCDSubCommitte.QueryableSource = dsLinq.CDSubCommittes;
            LSMSTBLWarasa.QueryableSource =

            LSMSTBLWarasa.QueryableSource = from q in dsLinq.vTBLWarasas where q.MMashatId == TBLWarasa[0].MMashatId select q;
            _TBLWarasa = TBLWarasa;
            _TBLNoSarfWarsa = TBLNoSarfWarsa;
            _TBLEdafatWarsa = TBLEdafatWarsa;

            switch (openReason)
            {
                case  OpenReason.Remark:
                    gcCommands.Visible = false;
                    tabMain.PageVisible = false;
                    tabExtra.PageVisible = false;
                    tabSarfExpetion.PageVisible = false;
                    tabResarf.PageVisible = false;
                    LSMSUsers.QueryableSource = dsLinq.Users;
                    ReloadRemark();
                    return;
                case OpenReason.Edit:
                    tabRemark.PageVisible = false;
                    break;
            }

            tbpersonName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", _TBLWarasa, "personName", true));
            lueWarasaTypeId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", _TBLWarasa, "WarasaTypeId", true));
            tbpersonNID.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", _TBLWarasa, "personNID", true));
            depersonbirth.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", _TBLWarasa, "personbirth", true));
            tbpersonmobile.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", _TBLWarasa, "personmobile", true));
            tbpersonAddres.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", _TBLWarasa, "personAddres", true));
            ceyasref.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", _TBLWarasa, "yasref", true));
            LUESyndicateId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", _TBLWarasa, "SyndicateId", true));
            LUESubCommitteId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", _TBLWarasa, "SubCommitteId", true));
            ceresponsiblesarf.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", _TBLWarasa, "responsiblesarf", true));
            LUEresponsiblesarfId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", _TBLWarasa, "responsiblesarfId", true));

            cewcompletesarf.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", _TBLWarasa, "wcompletesarf", true));
            tbwmony.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", _TBLWarasa, "wmony", true));
            tbwestktaat.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", _TBLWarasa, "westktaat", true));
            tbwelrasm.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", _TBLWarasa, "welrasm", true));


            luesarfTypeId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", _TBLEdafatWarsa, "sarfTypeId", true));
            tbestktaa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", _TBLEdafatWarsa, "estktaa", true));
            lueDofatSarfId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", _TBLEdafatWarsa, "DofatSarfId", true));
            dedatesarf.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", _TBLEdafatWarsa, "datesarf", true));

            if (_TBLEdafatWarsa.Count > 0)
                ceEnableEdafat.Checked = true;

            if (_TBLWarasa[0].RowState == DataRowState.Added)
            {
                tabResarf.PageVisible = false;
                tabSarfExpetion.PageVisible = false;
            }
            else
            {
                this.tBLReSarfWarasaTableAdapter.FillBy(this.dsRetirementCenter.TBLReSarfWarasa, _TBLWarasa[0].PersonId);
                if ((bool)SQLProvider.adpQry.TBLMashat_GetSarfExpetion(_TBLWarasa[0].MMashatId))
                    this.tBLSarfExpetionTableAdapter.FillByPersonId(this.dsRetirementCenter.TBLSarfExpetion, _TBLWarasa[0].PersonId);
                else
                    tabSarfExpetion.PageVisible = false;
            }

        }
        private void ReloadRemark()
        {
            // TODO: This line of code loads data into the 'dsRetirementCenter.TBLWarasaremarks' table. You can move, or remove it, as needed.
            this.tBLWarasaremarksTableAdapter.FillByPersonId(this.dsRetirementCenter.TBLWarasaremarks, _TBLWarasa[0].PersonId);
        }
        #endregion
        #region - Event Handlers -
        private void TBLWarasaDlg_Load(object sender, EventArgs e)
        {
        }
        private void ceyasref_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if ((bool)_TBLWarasa.Rows[0]["yasref", DataRowVersion.Current] == ceyasref.Checked)
                {
                    _TBLNoSarfWarsa.Clear();
                    return;
                }
            }
            catch { return; }
            
            if (ceyasref.Checked)
            {
                if (_TBLWarasa.Rows[0].RowState == DataRowState.Added)
                    return;
            }
            DataSources.dsRetirementCenter.TBLNoSarfWarsaRow row = _TBLNoSarfWarsa.NewTBLNoSarfWarsaRow();
            row.PersonId = -1; row.datehala = DateTime.Now; row.halarem = string.Empty; row.yasref = ceyasref.Checked;
            TBLNoSarfWarsaDlg dlg = new TBLNoSarfWarsaDlg(row);

            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                _TBLNoSarfWarsa.AddTBLNoSarfWarsaRow(row);
            else
                ceyasref.Checked = !ceyasref.Checked;
        }
        private void ceEnableEdafat_CheckedChanged(object sender, EventArgs e)
        {
            if (!ceEnableEdafat.Checked)
            {
                pnlEdafat.Enabled = false;
                //lueDofatSarfId.EditValue = null;
                //luesarfTypeId.EditValue = null;
                //tbestktaa.EditValue = 0;
                //_TBLEdafatWarsa.Clear();
            }
            else
            {
                pnlEdafat.Enabled = true;

                if (_TBLEdafatWarsa.Count == 0)// if nothing then create new
                {
                    DataSources.dsRetirementCenter.TBLEdafatWarsaRow row = _TBLEdafatWarsa.NewTBLEdafatWarsaRow();
                    row.estktaa = 0; row.userin = Program.UserInfo.UserId; row.datein = SQLProvider.ServerDateTime();
                    row.sarfTypeId = 2;
                    row.PersonId = Convert.ToInt32(_TBLWarasa[0].PersonId);
                    row.EndEdit();
                    _TBLEdafatWarsa.AddTBLEdafatWarsaRow(row);
                }
                lueDofatSarfId.Focus();
                if (FXFW.SqlDB.IsNullOrEmpty(lueDofatSarfId.EditValue))
                    lueDofatSarfId.EditValue = MaxDofatSarfId;
            }
        }
        private void ceresponsiblesarf_CheckedChanged(object sender, EventArgs e)
        {
            LUEresponsiblesarfId.Enabled = !ceresponsiblesarf.Checked;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!dxValidationProviderMain.Validate())
                return;
            if (ceEnableEdafat.Checked)
            {
                if (!dxValidationProviderEdafat.Validate())
                    return;
            }
            _TBLWarasa[0].EndEdit();
            
            if (_TBLWarasa.Rows[0].RowState == DataRowState.Added)
            {
                ((DataSources.dsRetirementCenter.TBLWarasaRow)_TBLWarasa.Rows[0]).PersonId = (int)SQLProvider.adpQry.TBLWarasaNewId();
            }
            else
            {
                //check if user remove responsiblesarf from this person and this person is responsiblesarf to other
                if ((_TBLWarasa[0]["responsiblesarf", DataRowVersion.Current].ToString() != _TBLWarasa[0]["responsiblesarf", DataRowVersion.Original].ToString()) && !_TBLWarasa[0].responsiblesarf)
                {
                    if (SQLProvider.adpQry.TBLWarasaPersonResponsibleSarfCount(_TBLWarasa[0].PersonId) > 0)
                    {
                        Program.ShowMsg("لا يمكن ازالة مسؤل الصرف عن هذا الوريث لانه مسئول صرف عن اخرين" + Environment.NewLine +
                        "قم بأزالة مسئوليته عن الاخرين ثم عاود التعديل", true, this, true);
                        return;
                    }    
                }
                
            }
            if (ceresponsiblesarf.Checked)
                ((DataSources.dsRetirementCenter.TBLWarasaRow)_TBLWarasa.Rows[0]).responsiblesarfId = ((DataSources.dsRetirementCenter.TBLWarasaRow)_TBLWarasa.Rows[0]).PersonId;

            if (tbpersonNID.EditValue != null && tbpersonNID.EditValue.ToString() != string.Empty)
            {
                if ((int)SQLProvider.adpQry.ExistsNID(tbpersonNID.EditValue.ToString(), -100, ((DataSources.dsRetirementCenter.TBLWarasaRow)_TBLWarasa.Rows[0]).PersonId) > 0)
                {
                    Program.ShowMsg("الرقم القومي موجود مسبقا", true, this, true);
                    return;
                }
            }
            DataSources.dsRetirementCenter.TBLWarasaRow myrow = (DataSources.dsRetirementCenter.TBLWarasaRow)_TBLWarasa.Rows[0];
            if (!myrow.IspersonNIDNull() && myrow.personNID != string.Empty)
            {
                try
                {
                    myrow.personbirth = Convert.ToDateTime(Misc.Misc.IDExtraction(myrow.personNID)[1]);
                }
                catch (Exception ex)
                {
                    Program.ShowMsg("خطاء في الرقم القومي" + Environment.NewLine + ex.Message, true, this, true);
                    Program.Logger.LogThis("خطاء في الرقم القومي" + Environment.NewLine + ex.Message, Text, FXFW.Logger.OpType.fail, null, null, this);
                    return;
                }
            }

            foreach (DataSources.dsRetirementCenter.TBLNoSarfWarsaRow row in _TBLNoSarfWarsa.Rows)
            {
                row.PersonId = ((DataSources.dsRetirementCenter.TBLWarasaRow)_TBLWarasa.Rows[0]).PersonId;
            }
            if (ceEnableEdafat.Checked)
            {
                foreach (DataSources.dsRetirementCenter.TBLEdafatWarsaRow row in _TBLEdafatWarsa.Rows)
                {
                    row.PersonId = ((DataSources.dsRetirementCenter.TBLWarasaRow)_TBLWarasa.Rows[0]).PersonId;
                }
            }
            else
                _TBLEdafatWarsa.Clear();
            
           
            DialogResult = System.Windows.Forms.DialogResult.OK;

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
        private void LUESyndicateId_EditValueChanged(object sender, EventArgs e)
        {
            if (LUESyndicateId.EditValue == null || LUESyndicateId.EditValue.ToString() == string.Empty)
            {
                return;
            }
            LUESubCommitteId.Properties.DataSource = from q in dsLinq.CDSubCommittes where q.SyndicateId == Convert.ToInt32(LUESyndicateId.EditValue) select q;
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataSources.dsRetirementCenter.TBLWarasaRow rowWarasa = _TBLWarasa[0];
            DataSources.dsRetirementCenter.TBLWarasaremarksRow row = (DataSources.dsRetirementCenter.TBLWarasaremarksRow)((DataRowView)
            gridViewRemarks.GetRow(gridViewRemarks.FocusedRowHandle)).Row;
            try
            {
                if (row.RowState != DataRowState.Detached && row.RowState != DataRowState.Added)
                {
                    Program.ShowMsg("لا يمكن تعديل", true, this, true);
                    Program.Logger.LogThis("لا يمكن تعديل", Text, FXFW.Logger.OpType.fail, null, null, this);
                    return;
                }
                row.rwid = (int)SQLProvider.adpQry.TBLWarasaremarksNewId();
                row.PersonId = rowWarasa.PersonId;
                row.datein = SQLProvider.ServerDateTime();
                row.userin = Program.UserInfo.UserId;

                tBLWarasaremarksBindingSource.EndEdit();
                tBLWarasaremarksTableAdapter.Update(row);
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
        private void gridViewResarf_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataSources.dsRetirementCenter.TBLReSarfWarasaRow row = (DataSources.dsRetirementCenter.TBLReSarfWarasaRow)((DataRowView)
                gridViewResarf.GetRow(e.RowHandle)).Row;
            row.PersonId = _TBLWarasa[0].PersonId;
            row.userin = Program.UserInfo.UserId;
            row.datein = SQLProvider.ServerDateTime();
            row.reestktaa = 0;
        }
        private void repositoryItemButtonEditResarfSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataSources.dsRetirementCenter.TBLReSarfWarasaRow row = (DataSources.dsRetirementCenter.TBLReSarfWarasaRow)((DataRowView)
           gridViewResarf.GetRow(gridViewResarf.FocusedRowHandle)).Row;
            try
            {
                tBLReSarfWarasaBindingSource.EndEdit();
                tBLReSarfWarasaTableAdapter.Update(row);
                Program.ShowMsg("تم تعديل بيانات اعادة الصرف", false, this, true);
                Program.Logger.LogThis("تم اضافة بيانات اعادة الصرف", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void repositoryItemButtonEditResarfDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataSources.dsRetirementCenter.TBLReSarfWarasaRow row = (DataSources.dsRetirementCenter.TBLReSarfWarasaRow)((DataRowView)
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
                tBLReSarfWarasaBindingSource.EndEdit();
                tBLReSarfWarasaTableAdapter.Delete(_TBLWarasa[0].PersonId, row.DofatSarfId);
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
        private void gridViewTBLSarfExpetion_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataSources.dsRetirementCenter.TBLSarfExpetionRow row = (DataSources.dsRetirementCenter.TBLSarfExpetionRow)((DataRowView)
                gridViewTBLSarfExpetion.GetRow(e.RowHandle)).Row;
            row.PersonId = _TBLWarasa[0].PersonId;
            row.userin = Program.UserInfo.UserId;
            row.datein = SQLProvider.ServerDateTime();
        }
        private void repositoryItemButtonEditSarfExpetionSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataSources.dsRetirementCenter.TBLSarfExpetionRow row = (DataSources.dsRetirementCenter.TBLSarfExpetionRow)((DataRowView)
          gridViewTBLSarfExpetion.GetRow(gridViewTBLSarfExpetion.FocusedRowHandle)).Row;
            try
            {
                tBLSarfExpetionBindingSource.EndEdit();
                tBLSarfExpetionTableAdapter.Update(row);
                Program.ShowMsg("تم تعديل بيانات الاستثناء", false, this, true);
                Program.Logger.LogThis("تم اضافة بيانات الاستثناء", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void repositoryItemButtonEditSarfExpetionDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataSources.dsRetirementCenter.TBLSarfExpetionRow row = (DataSources.dsRetirementCenter.TBLSarfExpetionRow)((DataRowView)
           gridViewTBLSarfExpetion.GetRow(gridViewTBLSarfExpetion.FocusedRowHandle)).Row;
            try
            {
                if (row.RowState == DataRowState.Detached)
                {
                    gridViewTBLSarfExpetion.DeleteRow(gridViewTBLSarfExpetion.FocusedRowHandle);
                    return;
                }
                if (msgDlg.Show("هل انت متأكد؟", msgDlg.msgButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                    return;
                tBLSarfExpetionBindingSource.EndEdit();
                tBLSarfExpetionTableAdapter.Delete(row.DofatSarfId, _TBLWarasa[0].PersonId);
                gridViewTBLSarfExpetion.DeleteRow(gridViewTBLSarfExpetion.FocusedRowHandle);
                Program.ShowMsg("تم حذف بيانات الاستثناء", false, this, true);
                Program.Logger.LogThis("تم حذف بيانات الاستثناء", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void cewcompletesarf_CheckedChanged(object sender, EventArgs e)
        {
            pnlPrivateSarf.Enabled = !cewcompletesarf.Checked;
        }

        #endregion

    }
}