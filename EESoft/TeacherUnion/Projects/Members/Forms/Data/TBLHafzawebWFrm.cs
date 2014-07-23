using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using FXFW;

namespace Members
{
    public partial class TBLHafzawebWFrm : DevExpress.XtraEditors.XtraForm
    {
       
        DataSources.dsTeachersUnion.TBLMemberWebRow _row;
        int _KideNumber;
        bool ImageChanged = false;

        public TBLHafzawebWFrm()
        {
            InitializeComponent();
        }
        public TBLHafzawebWFrm(DataSources.dsTeachersUnion.TBLMemberWebRow row)
        {
            InitializeComponent();
            _row = row;
        }
        private void LoadBinding()
        {
            if (!_row.IsNull("SyndicateId"))
                lueSyndicateId.EditValue = _row.SyndicateId;
            if (!_row.IsNull("SubCommitteId"))
                lueSubCommitteId.EditValue = _row.SubCommitteId;
            if (!_row.IsNull("MemberName"))
                tbMemberName.EditValue = _row.MemberName;
            if (!_row.IsNull("BirthDate"))
                deBirthDate.EditValue = _row.BirthDate;
            if (!_row.IsNull("QualtypeId"))
                lueQualtypeId.EditValue = _row.QualtypeId;
            if (!_row.IsNull("JobtitleID"))
                lueJobtitleID.EditValue = _row.JobtitleID;
            if (!_row.IsNull("membertypeid"))
                luemembertypeid.EditValue = _row.membertypeid;
            if (!_row.IsNull("WorkeDate"))
                deWorkeDate.EditValue = _row.WorkeDate;
            if (!_row.IsNull("kasmDate"))
                dekasmDate.EditValue = _row.kasmDate;
            if (!_row.IsNull("closed"))
            {
                ceclosed.EditValue = _row.closed;
                if (_row.closed && !Program.UserInfo.IsAdmin)
                {
                    btnSave.Enabled = false;
                    btnSave.Visible = false;
                }
                if (_row.closed && Program.UserInfo.IsAdmin)
                {
                    ceclosed.Enabled = true;
                }
            }
            if (!_row.IsNull("estefaa"))
                ceestefaa.EditValue = _row.estefaa;
            if (!_row.IsNull("rekeed"))
                cerekeed.EditValue = _row.rekeed;
            //
            if (!_row.IsNull("estefareson"))
                tbestefareson.EditValue = _row.estefareson;
            if (!_row.IsNull("mnid"))
                tbmnid.EditValue = _row.mnid;
            if (!_row.IsNull("estefadate"))
                deestefadate.EditValue = _row.estefadate;
            if (!_row.IsNull("reternestefadate"))
                dereternestefadate.EditValue = _row.reternestefadate;
            if (!_row.IsNull("esalno"))
                tbesalno.EditValue = _row.esalno;
            if (!_row.IsNull("KideNumber"))
                tbKideNumber.EditValue = _row.KideNumber;
          
            if (!_row.IsNull("CardtypeId"))
            {
                if (_row.CardtypeId == 1)//دائم
                    radioGroupType.SelectedIndex = 0;
                else
                {
                    radioGroupType.SelectedIndex = 1;
                    if (!_row.IsNull("dateend"))
                        dedateend.EditValue = _row.dateend;
                    if (_row.IsNull("Installment"))
                        ceInstallment.Checked = false;
                    else
                        ceInstallment.Checked  = _row.Installment;
                }
            }
            else
            {
                radioGroupType.SelectedIndex = 0;
                _row.CardtypeId = 1;
            }
            if (!_row.IsNull("imagepath"))
            {
                string FilePath = Program.imgPathWeb + _row.imagepath;
                if (System.IO.File.Exists(FilePath))
                    peimagepath.Image = Image.FromFile(FilePath);
            }
            peimagepath.EditValueChanging += peimagepath_EditValueChanging;
        }
        private void FormWFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsTeachersUnion.CDGeha' table. You can move, or remove it, as needed.
            this.cDGehaTableAdapter.Fill(this.dsTeachersUnion.CDGeha);
            // TODO: This line of code loads data into the 'dsTeachersUnion.CDMemberSType' table. You can move, or remove it, as needed.
            this.cDMemberSTypeTableAdapter.Fill(this.dsTeachersUnion.CDMemberSType);
            // TODO: This line of code loads data into the 'dsTeachersUnion.TBLSadadWeb' table. You can move, or remove it, as needed.
            this.tBLSadadWebTableAdapter.FillByMemberId(this.dsTeachersUnion.TBLSadadWeb, _row.MemberId);
            // TODO: This line of code loads data into the 'dsTeachersUnion.TBLMemberHalaWeb' table. You can move, or remove it, as needed.
            this.tBLMemberHalaWebTableAdapter.FillByMemberId(this.dsTeachersUnion.TBLMemberHalaWeb, _row.MemberId);
            // TODO: This line of code loads data into the 'dsTeachersUnion.CDAgaza' table. You can move, or remove it, as needed.
            this.cDAgazaTableAdapter.Fill(this.dsTeachersUnion.CDAgaza);
            // TODO: This line of code loads data into the 'dsTeachersUnion.TBLmemberagazatWeb' table. You can move, or remove it, as needed.
            this.tBLmemberagazatWebTableAdapter.FillByMemberId(this.dsTeachersUnion.TBLmemberagazatWeb, _row.MemberId);
            // TODO: This line of code loads data into the 'dsTeachersUnion1.CDMembertype' table. You can move, or remove it, as needed.
            this.cDMembertypeTableAdapter.Fill(this.dsTeachersUnion1.CDMembertype);
            // TODO: This line of code loads data into the 'dsTeachersUnion.CDJobtitle' table. You can move, or remove it, as needed.
            this.cDJobtitleTableAdapter.Fill(this.dsTeachersUnion.CDJobtitle);
            // TODO: This line of code loads data into the 'dsTeachersUnion.CDQualtype' table. You can move, or remove it, as needed.
            this.cDQualtypeTableAdapter.Fill(this.dsTeachersUnion.CDQualtype);
            // TODO: This line of code loads data into the 'dsTeachersUnion.CDSyndicate' table. You can move, or remove it, as needed.
            this.cDSyndicateTableAdapter.Fill(this.dsTeachersUnion.CDSyndicate);
            LoadBinding();
            if (!_row.IsKideNumberNull())
                _KideNumber = _row.KideNumber;
        }
        private void lueSyndicateId_EditValueChanged(object sender, EventArgs e)
        {
            if (lueSyndicateId.EditValue == null)
            {
                return;
            }
            // TODO: This line of code loads data into the 'dsTeachersUnion.CDSubCommitte' table. You can move, or remove it, as needed.
            this.cDSubCommitteTableAdapter.FillBySyndicateId(this.dsTeachersUnion.CDSubCommitte, Convert.ToInt32(lueSyndicateId.EditValue));
        }
        private void tbKideNumber_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
            {
                e.Button.Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Close;
                tbKideNumber.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            }
            else
            {
                e.Button.Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Plus;
                tbKideNumber.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;

            }
        }
        private void radioGroupType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioGroupType.SelectedIndex == 0)
            {
                dedateend.Enabled = false;
                ceInstallment.Enabled = false;
            }
            else
            {
                dedateend.Enabled = true;
                ceInstallment.Enabled = true;
            }
        }
        private void cerekeed_ceestefaa_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckEdit)sender).Name == "cerekeed")
                ceestefaa.Checked = !cerekeed.Checked;
            else
                cerekeed.Checked = !ceestefaa.Checked;
        }
        private void peimagepath_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            ImageChanged = true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (radioGroupType.SelectedIndex == 1 && dedateend.EditValue == null)
            {
                Program.ShowMsg("يجب ادخال تاريخ انتهاء الؤقت", false, this, true);
                return;
            }
            if (ceestefaa.Checked && tbKideNumber.Text != string.Empty)
            {
                Program.Logger.LogThis("لا يمكن حفظ استيفاء ألا بعد حذف رقم القيد", Text, FXFW.Logger.OpType.fail, null, null, this);
                return;
            }
            if (_row.estefaa == true && !_row.IsKideNumberNull())
            {
                Program.Logger.LogThis("لا يمكن حفظ استيفاء ألا بعد حذف رقم القيد", Text, FXFW.Logger.OpType.success, null, null, this);
                return;
            }
            if (lueSyndicateId.EditValue != null)
                _row.SyndicateId = Convert.ToInt32(lueSyndicateId.EditValue);
            if (lueSubCommitteId.EditValue != null)
                _row.SubCommitteId = Convert.ToInt32(lueSubCommitteId.EditValue);
            if (tbMemberName.EditValue != null)
                _row.MemberName = Convert.ToString(tbMemberName.EditValue);
            if (deBirthDate.EditValue != null)
                _row.BirthDate = Convert.ToDateTime(deBirthDate.EditValue);
            if (lueQualtypeId.EditValue != null)
                _row.QualtypeId = Convert.ToByte(lueQualtypeId.EditValue);
            if (lueJobtitleID.EditValue != null)
                _row.JobtitleID = Convert.ToInt32(lueJobtitleID.EditValue);
            if (luemembertypeid.EditValue != null)
                _row.membertypeid = Convert.ToByte(luemembertypeid.EditValue);
            if (deWorkeDate.EditValue != null)
                _row.WorkeDate = Convert.ToDateTime(deWorkeDate.EditValue);
            if (dekasmDate.EditValue != null)
                 _row.kasmDate = Convert.ToDateTime(dekasmDate.EditValue);
            if (ceclosed.EditValue != null)
                _row.closed = Convert.ToBoolean(ceclosed.EditValue);
            if (ceestefaa.EditValue != null)
                _row.estefaa = Convert.ToBoolean(ceestefaa.EditValue);
            if (cerekeed.EditValue != null)
                _row.rekeed = Convert.ToBoolean(cerekeed.EditValue);

            //if (Misc.Misc.CalcAge(_row.BirthDate) >= 45 && _row.NewMember)
            //{
            //    //Program.Logger.LogThis("لا يجب ادخال عضو اكبر من 45 سنة", Text, FXFW.Logger.OpType.fail, null, null, this);
            //    if (MessageBox.Show("هذا العضو اكبر من 45 سنه هل ترغب في حفظ العضو كعضو قديم؟", "عضو جديد غير لائق", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
            //        return;
            //    else
            //        _row.NewMember = false;
            //}

            //
            if (tbestefareson.EditValue != null)
            {
                if (tbestefareson.EditValue.ToString() == string.Empty && FXFW.SqlDB.UserInfo.UserID != "1")
                    Program.Logger.LogThis("سوف يتم الحفظ لكن لن يتم مسح سبب الاستيفاء", Text, FXFW.Logger.OpType.success, null, null, this);
                else
                    _row.estefareson = Convert.ToString(tbestefareson.EditValue);
            }
            if (tbmnid.EditValue != null)
                _row.mnid = tbmnid.EditValue.ToString();
            if (deestefadate.EditValue != null)
                _row.estefadate = Convert.ToDateTime(deestefadate.EditValue);
            if (dereternestefadate.EditValue != null)
                _row.reternestefadate = Convert.ToDateTime(dereternestefadate.EditValue);
            if (tbesalno.EditValue != null && tbesalno.EditValue.ToString() != string.Empty)
                _row.esalno = Convert.ToInt32(tbesalno.EditValue);
            else
                _row.SetesalnoNull();
            if (tbKideNumber.EditValue != null && tbKideNumber.EditValue.ToString() != string.Empty)
            {
                int KideNumber = Convert.ToInt32(tbKideNumber.EditValue);
                DataSources.dsTeachersUnionTableAdapters.TBLMembersTableAdapter adpMem = new DataSources.dsTeachersUnionTableAdapters.TBLMembersTableAdapter();
                DataSources.dsTeachersUnionTableAdapters.TBLMemberWebTableAdapter adpMemWeb = new DataSources.dsTeachersUnionTableAdapters.TBLMemberWebTableAdapter();
                if (_row.RowState == DataRowState.Detached)
                {
                    if (adpMem.ScalarQueryExistsKideNumber(KideNumber) != 0 || adpMemWeb.ScalarQueryExistsKideNumber(_row.MemberId, KideNumber) != 0)
                    {
                        Program.ShowMsg("رقم القيد موجود مسبقا", true, this);
                        Program.Logger.LogThis("رقم القيد موجود مسبقا", Text, FXFW.Logger.OpType.warning, null, null, this);
                        return;
                    }
                }
                else
                {
                    int memberid = 0;
                    if (_row.closed)
                        memberid = (int)adpMem.ScalarQueryKideNumberByMemberId(_row.KideNumber);
                    if (adpMem.ScalarQueryExistsKideNumber_MemberId(KideNumber, memberid) != 0 || adpMemWeb.ScalarQueryExistsKideNumber(_row.MemberId, KideNumber) != 0)
                    {
                        Program.ShowMsg("رقم القيد موجود مسبقا", true, this);
                        Program.Logger.LogThis("رقم القيد موجود مسبقا", Text, FXFW.Logger.OpType.warning, null, null, this);
                        return;
                    }
                }
                
                _row.KideNumber = KideNumber;
            }
            else
                _row.SetKideNumberNull();

            if (radioGroupType.SelectedIndex == 0)
            {
                _row.CardtypeId = 1;
            }
            else if (radioGroupType.SelectedIndex == 1)
            {
                _row.CardtypeId = 2;
                _row.dateend = dedateend.DateTime;
                _row.Installment = ceInstallment.Checked;
            }
            if (ImageChanged)// if user pick another image
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                if (peimagepath.Image != null)
                {
                    peimagepath.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    peimagepath.Image.Dispose(); peimagepath.Image = null;
                }
                if (!_row.IsimagepathNull() && _row.imagepath != string.Empty)
                {
                    if (System.IO.File.Exists(Program.imgPathWeb + _row.imagepath))
                        System.IO.File.Delete(Program.imgPathWeb + _row.imagepath);
                }
                if (ms.Length > 0)
                {
                    string fileName = string.Format("{0}{1}{2}{3}{4}{5}{6}.jpg", DateTime.Now.Year, DateTime.Now.Month,
                        DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, DateTime.Now.Millisecond);
                    Image.FromStream(ms).Save(Program.imgPathWeb + fileName);
                    ms.Close();
                    _row.imagepath = fileName;
                }
            }

            if (tbKideNumber.Properties.Buttons[0].Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                _row.kednew = true;
            else
                _row.kednew = false;

            _row.userin = Program.UserInfo.UserId;
            _row.datein = SQLProvider.GetServerDateTime();

            if (!_row.IsKideNumberNull() && _KideNumber != _row.KideNumber)
                _row.userked = _row.userin;

            if (!_row.IsesalnoNull())
            {

                if (_row["esalno", DataRowVersion.Current].ToString() != _row["esalno", DataRowVersion.Original].ToString())
                {
                    if (Convert.ToInt32(SQLProvider.adpQry.eslanoRemains(_row.esalno)) - 1 < 0)
                    {
                        Program.Logger.LogThis("هذا الايصال تم ادخال كل اعضائة", Text, FXFW.Logger.OpType.fail, null, null, this);
                        return;
                    }
                }
            }

            DialogResult = System.Windows.Forms.DialogResult.OK;

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
        private void gridViewData_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DataSources.dsTeachersUnion.TBLmemberagazatWebRow row = (DataSources.dsTeachersUnion.TBLmemberagazatWebRow)gridViewData.GetDataRow(e.RowHandle);
            row.MemberId = _row.MemberId;
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataSources.dsTeachersUnion.TBLmemberagazatWebRow row = (DataSources.dsTeachersUnion.TBLmemberagazatWebRow)gridViewData.GetFocusedDataRow();
            try
            {
                tBLmemberagazatWebBindingSource.EndEdit();
                tBLmemberagazatWebTableAdapter.Update(row);
                dsTeachersUnion.TBLmemberagazatWeb.AcceptChanges();
                Program.ShowMsg("تم الحفظ", false, this);
                Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void repositoryItemButtonEditDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataSources.dsTeachersUnion.TBLmemberagazatWebRow row = (DataSources.dsTeachersUnion.TBLmemberagazatWebRow)gridViewData.GetFocusedDataRow();
            if (row.RowState == DataRowState.Detached)
                return;
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            tBLmemberagazatWebTableAdapter.Delete(row.MemberId, row.agazatypeId, row.datefrom);
            gridViewData.DeleteRow(gridViewData.FocusedRowHandle);
            Program.ShowMsg("تم الحذف", false, this);
            Program.Logger.LogThis("تم الحذف", Text, FXFW.Logger.OpType.success, null, null, this);
        }
        private void TBLHafzawebWFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (peimagepath.Image != null)
                peimagepath.Image.Dispose();
        }

        private void gridViewHala_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DataSources.dsTeachersUnion.TBLMemberHalaWebRow row = (DataSources.dsTeachersUnion.TBLMemberHalaWebRow)gridViewHala.GetDataRow(e.RowHandle);
            row.MemberId = _row.MemberId;
            row.userin = Program.UserInfo.UserId;
            row.datein = (DateTime)new DataSources.dsTeachersUnionQueryTableAdapters.ServerDateTimeTableAdapter().ScalarQueryServerDateTime();
        }
        private void repositoryItemButtonEditHalaSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView GV = (GridView)gridControlHala.MainView;
            DataSources.dsTeachersUnion.TBLMemberHalaWebRow row = (DataSources.dsTeachersUnion.TBLMemberHalaWebRow)GV.GetFocusedDataRow();
            try
            {
                tBLMemberHalaWebBindingSource.EndEdit();
                tBLMemberHalaWebTableAdapter.Update(row);
                dsTeachersUnion.TBLMemberHalaWeb.AcceptChanges();
                Program.ShowMsg("تم الحفظ", false, this);
                Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void repositoryItemButtonEditHalaDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            GridView GV = (GridView)gridControlHala.MainView;
            DataSources.dsTeachersUnion.TBLMemberHalaWebRow row = (DataSources.dsTeachersUnion.TBLMemberHalaWebRow)GV.GetFocusedDataRow();
            if (row.RowState == DataRowState.Detached)
                return;
            try
            {
                tBLMemberHalaWebTableAdapter.Delete(row.MemberId, row.MemberSTypeId, row.datefrom);
                gridViewHala.DeleteRow(GV.FocusedRowHandle);
                Program.ShowMsg("تم الحذف", false, this);
                Program.Logger.LogThis("تم الحذف", Text, FXFW.Logger.OpType.success, null, null, this);

            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }

        private void gridViewSadad_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DataSources.dsTeachersUnion.TBLSadadWebRow row = (DataSources.dsTeachersUnion.TBLSadadWebRow)gridViewSadad.GetDataRow(e.RowHandle);
            row.MemberId = _row.MemberId;
            row.userin = Program.UserInfo.UserId;
            row.datein = (DateTime)new DataSources.dsTeachersUnionQueryTableAdapters.ServerDateTimeTableAdapter().ScalarQueryServerDateTime();
        }
        private void repositoryItemButtonEditSadadSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView GV = (GridView)gridControlSadad.MainView;
            DataSources.dsTeachersUnion.TBLSadadWebRow row = (DataSources.dsTeachersUnion.TBLSadadWebRow)GV.GetFocusedDataRow();
            try
            {
                tBLSadadWebBindingSource.EndEdit();
                tBLSadadWebTableAdapter.Update(row);
                dsTeachersUnion.TBLSadadWeb.AcceptChanges();
                Program.ShowMsg("تم الحفظ", false, this);
                Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void repositoryItemButtonEditSadadDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            GridView GV = (GridView)gridControlSadad.MainView;
            DataSources.dsTeachersUnion.TBLSadadWebRow row = (DataSources.dsTeachersUnion.TBLSadadWebRow)GV.GetFocusedDataRow();
            if (row.RowState == DataRowState.Detached)
                return;
            try
            {
                tBLSadadWebTableAdapter.Delete(row.MemberId, row.esalno);
                gridViewSadad.DeleteRow(GV.FocusedRowHandle);
                Program.ShowMsg("تم الحذف", false, this);
                Program.Logger.LogThis("تم الحذف", Text, FXFW.Logger.OpType.success, null, null, this);

            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void repositoryItemButtonEditPrint_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView GV = (GridView)gridControlSadad.MainView;
            DataSources.dsTeachersUnion.TBLSadadWebRow row = (DataSources.dsTeachersUnion.TBLSadadWebRow)GV.GetFocusedDataRow();
            if (row.RowState == DataRowState.Detached)
                return;
            XRep09 FrmRep = new XRep09(row);
            Misc.Misc.ShowPrintPreview(FrmRep);
        }
        

    }
}