using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System.IO;


namespace Members.Forms.Data
{
    public partial class TBLHafzawebNoTarhelEditFrm : DevExpress.XtraEditors.XtraForm
    {
        public TBLHafzawebNoTarhelEditFrm()
        {
            InitializeComponent();
        }
        private void ActivePriv()
        {
            return;//ActivePrivReady
            bool Selecting = false, Inserting = false, Updateing = false, Deleting = false;
            SQLProvider.GetFormPriv(this.Name, ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
            gridControlData.Visible = Selecting;
            LUEHafza.Visible = Selecting;

            repositoryItemButtonEditEdit.Buttons[0].Visible = Updateing;
        }
        private void LoadData()
        {
            // TODO: This line of code loads data into the 'dsTeachersUnionList.CDQualtype' table. You can move, or remove it, as needed.
            this.cDQualtypeTableAdapter.Fill(this.dsTeachersUnionList.CDQualtype);
            // TODO: This line of code loads data into the 'dsTeachersUnionList.CDSubCommitte' table. You can move, or remove it, as needed.
            this.cDSubCommitteTableAdapter.Fill(this.dsTeachersUnionList.CDSubCommitte);
            // TODO: This line of code loads data into the 'dsTeachersUnionList.CDSyndicate' table. You can move, or remove it, as needed.
            this.cDSyndicateTableAdapter.Fill(this.dsTeachersUnionList.CDSyndicate);
            // TODO: This line of code loads data into the 'dsTeachersUnionList.TBLHafzawebList' table. You can move, or remove it, as needed.
            this.tBLHafzawebListTableAdapter.Fill(this.dsTeachersUnionList.TBLHafzawebList);
        }
        private void TBLHafzawebFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsTeachersUnionList.CDCardtype' table. You can move, or remove it, as needed.
            this.cDCardtypeTableAdapter.Fill(this.dsTeachersUnionList.CDCardtype);
            // TODO: This line of code loads data into the 'dsTeachersUnionList.CDJobtitle' table. You can move, or remove it, as needed.
            this.cDJobtitleTableAdapter.Fill(this.dsTeachersUnionList.CDJobtitle);

            ActivePriv();
            LoadData();
        }
        private void LUEHafza_EditValueChanged(object sender, EventArgs e)
        {
            if (LUEHafza.EditValue == null)
                return;
            tblMemberWebTableAdapter.FillByhafzaid(dsTeachersUnionList.TBLMemberWeb, Convert.ToDouble(LUEHafza.EditValue));
            tblAksatWEBTableAdapter.FillByhafzaid(dsTeachersUnionList.TBLAksatWEB, Convert.ToDouble(LUEHafza.EditValue));
        }
        private void repositoryItemButtonEditEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView GV = (GridView)gridControlData.MainView;
            DataSources.dsTeachersUnion.TBLMemberWebRow row = (DataSources.dsTeachersUnion.TBLMemberWebRow)GV.GetFocusedDataRow();
            if (!row.IsclosedNull() && row.closed && !Program.UserInfo.IsAdmin)
            {
                Program.ShowMsg("لا يمكن تعديل حقل مغلق", true, this);
                Program.Logger.LogThis("لا يمكن تعديل حقل مغلق", Text, FXFW.Logger.OpType.information, null, null, this);
                dsTeachersUnionList.TBLMemberWeb.RejectChanges();
                return;
            }
            tblMemberWebBindingSource.EndEdit();
            if (row.IsCardtypeIdNull() || (!row.rekeed && !row.estefaa))
            {
                Program.ShowMsg("بيانات فارغة يجب ادخالها", true, this);
                Program.Logger.LogThis("بيانات فارغة يجب ادخالها", Text, FXFW.Logger.OpType.information, null, null, this);
                return;
            }
            if (row.rekeed && row.estefaa)
            {
                Program.ShowMsg("لا يجب ان يكون العضو استيفاء ومراجعة قيد", true, this);
                Program.Logger.LogThis("لا يجب ان يكون العضو استيفاء ومراجعة قيد", Text, FXFW.Logger.OpType.information, null, null, this);
                return;
            }

            if (!row.IsesalnoNull())
            {
                if (row["esalno", DataRowVersion.Current].ToString() != row["esalno", DataRowVersion.Original].ToString())
                {
                    if (Convert.ToInt32(SQLProvider.adpQry.eslanoRemains(row.esalno)) - 1 < 0)
                    {
                        Program.Logger.LogThis("هذا الايصال تم ادخال كل اعضائة", Text, FXFW.Logger.OpType.fail, null, null, this);
                        return;
                    }
                }
            }
            if (!row.IsKideNumberNull() && row.KideNumber != 0)
            {
                if (row.estefaa)
                {
                    Program.Logger.LogThis("لا يمكن حفظ استيفاء ألا بعد حذف رقم القيد", Text, FXFW.Logger.OpType.fail, null, null, this);
                    return;
                }
                int KideNumber = row.KideNumber;
                DataSources.dsTeachersUnionTableAdapters.TBLMembersTableAdapter adpMem = new DataSources.dsTeachersUnionTableAdapters.TBLMembersTableAdapter();
                DataSources.dsTeachersUnionTableAdapters.TBLMemberWebTableAdapter adpMemWeb = new DataSources.dsTeachersUnionTableAdapters.TBLMemberWebTableAdapter();
                if (adpMem.ScalarQueryExistsKideNumber(KideNumber) != 0 || adpMemWeb.ScalarQueryExistsKideNumber(row.MemberId, KideNumber) != 0)
                {
                    Program.ShowMsg("رقم القيد موجود مسبقا", true, this);
                    Program.Logger.LogThis("رقم القيد موجود مسبقا", Text, FXFW.Logger.OpType.warning, null, null, this);
                    return;
                }
            }
            try
            {
                if (!row.IsInstallmentNull() && row.Installment)
                {
                    int index = CheckAksatRowExists(row.MemberId);
                    if (index == -1)
                    {
                        Program.Logger.LogThis("يجب مليء تفاصيل التقسيط", Text, FXFW.Logger.OpType.fail, null, null, this);
                        return;
                    }
                    DataSources.dsTeachersUnion.TBLAksatWEBRow KstRow = (DataSources.dsTeachersUnion.TBLAksatWEBRow)dsTeachersUnionList.TBLAksatWEB[index];
                    if (KstRow.IsNull("kestenddate") || KstRow.IsNull("mostahk") || KstRow.IsNull("madfoaa") || KstRow.IsNull("esalno") || KstRow.IsNull("esaldate"))
                    {
                        Program.Logger.LogThis("تفاصيل التقسيط غير مكتملة", Text, FXFW.Logger.OpType.fail, null, null, this);
                        return;
                    }
                }
                row.datein = SQLProvider.GetServerDateTime();
                row.userin = Program.UserInfo.UserId;
                tblMemberWebBindingSource.EndEdit();
                tblMemberWebTableAdapter.Update(row);
                dsTeachersUnionList.TBLMemberWeb.AcceptChanges();
                if (!row.IsInstallmentNull() && row.Installment)
                {
                    tblAksatWEBTableAdapter.Update(dsTeachersUnionList.TBLAksatWEB[CheckAksatRowExists(row.MemberId)]);
                    dsTeachersUnionList.TBLAksatWEB.AcceptChanges();
                }

                Program.ShowMsg("تم الحفظ", false, this);
                Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (Exception ex)
            {
                Program.ShowMsg(Misc.Misc.ExceptionMessage(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, ex, null, this);
            }
        }
        private void repositoryItemButtonEditPic_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView GV = (GridView)gridControlData.MainView;
            DataSources.dsTeachersUnion.TBLMemberWebRow row = (DataSources.dsTeachersUnion.TBLMemberWebRow)GV.GetFocusedDataRow();
            string imgFileName = tblMemberWebTableAdapter.ScalarQueryImagePath(row.MemberId);
            if (File.Exists(Program.imgPathWeb + imgFileName))
            {
                ImgViewerFrm frm = new ImgViewerFrm();
                frm.Img.ImageLocation = Program.imgPathWeb + imgFileName;
                frm.ShowDialog();
            }
            else
            {
                Program.ShowMsg("الملف غير موجود", true, this);
                Program.Logger.LogThis("الملف غير موجود", Text, FXFW.Logger.OpType.fail, null, null, this);
            }
        }
        private void repositoryItemButtonEditDetails_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView GV = (GridView)gridControlData.MainView;
            DataSources.dsTeachersUnion.TBLMemberWebRow row = (DataSources.dsTeachersUnion.TBLMemberWebRow)GV.GetFocusedDataRow();

            TBLHafzawebWFrm frm = new TBLHafzawebWFrm(row);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    tblMemberWebTableAdapter.Update(row);
                    dsTeachersUnionList.TBLMemberWeb.AcceptChanges();
                    LUEHafza_EditValueChanged(LUEHafza.EditValue, new EventArgs());
                    Program.ShowMsg("تم الحفظ", false, this);
                    Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
                }
                catch (Exception ex)
                {
                    Program.ShowMsg(Misc.Misc.ExceptionMessage(ex), true, this);
                    Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, ex, null, this);
                }

            }
            else
            {
                dsTeachersUnionList.TBLMemberWeb.RejectChanges();
            }
        }
        private void repositoryItemTextEditKideNumber_EditValueChanged(object sender, EventArgs e)
        {
            TextEdit te = (TextEdit)sender;
            GridView GV = (GridView)gridControlData.MainView;
            DataSources.dsTeachersUnion.TBLMemberWebRow row = (DataSources.dsTeachersUnion.TBLMemberWebRow)((GridView)gridControlData.MainView).GetFocusedDataRow();
            row.userked = Program.UserInfo.UserId;
            if (te.EditValue.ToString() == string.Empty)
                row.SetKideNumberNull();
        }
        private void gridViewData_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            GridView dv = (GridView)sender;
            if (dv.FocusedColumn.FieldName == "esalno" || dv.FocusedColumn.FieldName == "KideNumber")
            {
                if (FXFW.SqlDB.IsNullOrEmpty(e.Value))
                {
                    e.Value = DBNull.Value;
                    e.Valid = true;
                }
            }
        }
        private void gridControlData_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
        }
        private void repositoryItemButtonEditInstallment_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView GV = (GridView)gridControlData.MainView;
            DataSources.dsTeachersUnion.TBLMemberWebRow row = (DataSources.dsTeachersUnion.TBLMemberWebRow)GV.GetFocusedDataRow();
            if (row.IsInstallmentNull() || !row.Installment)
                return;

            TBLAksatWebWFrm frm;
            int index = CheckAksatRowExists(row.MemberId);
            if (index != -1)
            { 
                frm = new TBLAksatWebWFrm(dsTeachersUnionList.TBLAksatWEB[index]);
                frm.ShowDialog();
            }
            else
            {
                DataSources.dsTeachersUnion.TBLAksatWEBRow newRow = dsTeachersUnionList.TBLAksatWEB.NewTBLAksatWEBRow();
                newRow.MemberId = row.MemberId;
                frm = new TBLAksatWebWFrm(newRow);
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    dsTeachersUnionList.TBLAksatWEB.AddTBLAksatWEBRow(newRow);
            }
        }
        private int CheckAksatRowExists(int MemberId)
        {
            int ReturnMe = -1;
            for (int i = 0; i < dsTeachersUnionList.TBLAksatWEB.Count; i++)
            {
                if (dsTeachersUnionList.TBLAksatWEB[i].MemberId == MemberId)
                {
                    ReturnMe = i;
                    break;
                }
            }
            return ReturnMe;
        }
        private void gridViewData_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {

        }
        private void repositoryItemButtonEditDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView GV = (GridView)gridControlData.MainView;
            DataSources.dsTeachersUnion.TBLMemberWebRow row = (DataSources.dsTeachersUnion.TBLMemberWebRow)GV.GetFocusedDataRow();

            if (row.RowState == DataRowState.Detached)
                return;
            if (row.closed)
            {
                MessageBox.Show("لا يمكن حذف عضو تم اغلاقة", "تحزير ...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            try
            {
                tblMemberWebTableAdapter.Delete(row.MemberId);
                gridViewData.DeleteRow(GV.FocusedRowHandle);

                Program.ShowMsg("تم الحذف", false, this);
                Program.Logger.LogThis("تم الحذف", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (Exception ex)
            {
                Program.ShowMsg(Misc.Misc.ExceptionMessage(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, ex, null, this);
            }
        }
    }
}