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
    public partial class TBLHafzawebFrm : DevExpress.XtraEditors.XtraForm
    {
        public TBLHafzawebFrm()
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

            btnTarheal.Visible = Inserting;

            beesalno.Properties.Buttons[0].Visible = Updateing;
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
            // TODO: This line of code loads data into the 'dsTeachersUnionQuery.ReceiptsList' table. You can move, or remove it, as needed.
            this.receiptsListTableAdapter.Fill(this.dsTeachersUnionQuery.ReceiptsList);
            // TODO: This line of code loads data into the 'dsTeachersUnionList.CDCardtype' table. You can move, or remove it, as needed.
            this.cDCardtypeTableAdapter.Fill(this.dsTeachersUnionList.CDCardtype);
            ActivePriv();
            LoadData();
        }
        private void LUEHafza_EditValueChanged(object sender, EventArgs e)
        {
            if (LUEHafza.EditValue == null)
                return;
            tblMemberWebTableAdapter.FillByhafzaid(dsTeachersUnionList.TBLMemberWeb, Convert.ToDouble(LUEHafza.EditValue)); 
        }
        private void repositoryItemButtonEditEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GridView GV = (GridView)gridControlData.MainView;
            DataSources.dsTeachersUnion.TBLMemberWebRow Row = (DataSources.dsTeachersUnion.TBLMemberWebRow)GV.GetFocusedDataRow();

            TBLHafzawebWFrm frm = new TBLHafzawebWFrm(Row);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    Row.datein = SQLProvider.GetServerDateTime();
                    Row.userin = Program.UserInfo.UserId;
                    tblMemberWebTableAdapter.Update(Row);
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
        private void beesalno_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.OK)
                return;
            if (LUEHafza.EditValue == null)
                return;
            if (beesalno.GetSelectedDataRow() == null)
            {
                Program.Logger.LogThis("ايصال غير مدرج", Text, FXFW.Logger.OpType.fail, null, null, this);
                beesalno.EditValue = null;
                return;
            }
            
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            try
            {
                int esalno = Convert.ToInt32(beesalno.EditValue);
                int CardsCount = (int)new DataSources.dsTeachersUnionTableAdapters.ReceiptsTableAdapter().ScalarQueryCardsCount(esalno);
                int ReadyToTakeEsal = 0;
                foreach (DataSources.dsTeachersUnion.TBLMemberWebRow row in dsTeachersUnionList.TBLMemberWeb.Rows)
                {
                    if (!row.IsesalnoNull() && row.esalno == esalno)
                    {
                        ReadyToTakeEsal++;
                        continue;
                    }
                    if ((!row.IsrekeedNull() && row.rekeed) && (!row.IsestefaaNull() && !row.estefaa))
                    {
                        ReadyToTakeEsal++;
                    }
                }

                int NewToTakeEsal = 0;
                foreach (DataSources.dsTeachersUnion.TBLMemberWebRow row in dsTeachersUnionList.TBLMemberWeb.Rows)
                {
                    if (!row.IsesalnoNull() && row.esalno == esalno)
                        continue;
                    if ((!row.IsrekeedNull() && row.rekeed) && (!row.IsestefaaNull() && !row.estefaa) && row.closed == false)
                        NewToTakeEsal++;
                
                }
                if (Convert.ToInt32(SQLProvider.adpQry.eslanoRemains(Convert.ToInt32(beesalno.EditValue))) - NewToTakeEsal < 0)
                {
                    Program.ShowMsg("عدد المرحلين اكبر من عدد كارنيهات هذا اليصال", true, this);
                    Program.Logger.LogThis("عدد المرحلين اكبر من عدد كارنيهات هذا اليصال", Text, FXFW.Logger.OpType.fail, null, null, this);
                    return;
                }
                
                int closedNo = 0;
                foreach (DataSources.dsTeachersUnion.TBLMemberWebRow row in dsTeachersUnionList.TBLMemberWeb.Rows)
                {

                    if (row.IsesalnoNull() && 
                        (!row.IsrekeedNull() && row.rekeed) && 
                        (!row.IsestefaaNull() && !row.estefaa))
                    {
                        row.esalno = esalno;
                        tblMemberWebTableAdapter.UpdateQueryesalnoForMember(esalno, row.MemberId);
                        closedNo++;
                    }
                }
                tBLMemberWebBindingSource.EndEdit();
                dsTeachersUnionList.TBLMemberWeb.AcceptChanges();
                Program.ShowMsg("تم الحفظ " + closedNo.ToString(), false, this);
                Program.Logger.LogThis("تم الحفظ " + closedNo.ToString(), Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (Exception ex)
            {
                Program.ShowMsg(Misc.Misc.ExceptionMessage(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, ex, null, this);
            }
        }
        private void btnTarheal_Click(object sender, EventArgs e)
        {
            if (FXFW.SqlDB.IsNullOrEmpty(LUEHafza.EditValue))
                return;

            string msg = "سوف يتم ترحيل فقط من تحتوي بياناته علي " + Environment.NewLine;
            msg += "النقابة" + Environment.NewLine; msg += "اللجنة" + Environment.NewLine;
            msg += "الاسم" + Environment.NewLine; msg += "الوظيفة" + Environment.NewLine;
            msg += "رقم الايصال" + Environment.NewLine; msg += "الصورة" + Environment.NewLine;
            msg += "مراجعة قيد" + Environment.NewLine; msg += "رقم القيد" + Environment.NewLine;
            msg += "نوع العضوية" + Environment.NewLine; msg += "هل انت متأكد؟" + Environment.NewLine;
            if (MessageBox.Show(msg, "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;

            int savedMemberCount = 0;
            int savedAksatCount = 0;
            int savedHalaCount = 0;
            int savedSadadCount = 0;
            DataSources.dsTeachersUnion.TBLHafzawebListRow rowHafza = (DataSources.dsTeachersUnion.TBLHafzawebListRow)((DataRowView)LUEHafza.GetSelectedDataRow()).Row;

            tblMemberWebTableAdapter.FillByhafzaid(dsTeachersUnionList.TBLMemberWeb, Convert.ToDouble(LUEHafza.EditValue));
            DataSources.dsTeachersUnionTableAdapters.TBLMembersTableAdapter adp = new DataSources.dsTeachersUnionTableAdapters.TBLMembersTableAdapter();
            for (int i = 0; i < dsTeachersUnionList.TBLMemberWeb.Count; i++)
            {
                DataSources.dsTeachersUnion.TBLMemberWebRow webRow = (DataSources.dsTeachersUnion.TBLMemberWebRow)dsTeachersUnionList.TBLMemberWeb.Rows[i];
                DataSources.dsTeachersUnion.TBLMembersRow row = dsTeachersUnionList.TBLMembers.NewTBLMembersRow();

                if (!webRow.IsclosedNull() && webRow.closed == true)
                    continue;

                if (webRow.IsSyndicateIdNull() || webRow.IsSubCommitteIdNull() || webRow.IsJobtitleIDNull() || webRow.IsMemberNameNull() ||
                    webRow.IsimagepathNull() || webRow.imagepath == string.Empty || webRow.IsesalnoNull() || webRow.MemberName == string.Empty
                    || webRow.IsrekeedNull() || webRow.rekeed == false || webRow.IsKideNumberNull() || webRow.KideNumber == 0 || webRow.IsCardtypeIdNull())
                    continue;
                if (!webRow.IsestefaaNull() && webRow.estefaa)//estefaa should be 'false'
                    continue;
                if (!File.Exists(Program.imgPathWeb + webRow.imagepath))
                    continue;
                DataSources.dsTeachersUnionTableAdapters.TBLMembersTableAdapter adpMem = new DataSources.dsTeachersUnionTableAdapters.TBLMembersTableAdapter();
                DataSources.dsTeachersUnionTableAdapters.TBLMemberWebTableAdapter adpMemWeb = new DataSources.dsTeachersUnionTableAdapters.TBLMemberWebTableAdapter();
                if (adpMem.ScalarQueryExistsKideNumber(webRow.KideNumber) != 0)
                    continue;

                row.MemberId = 1;
                if (!webRow.IsSyndicateIdNull())
                    row.SyndicateId = webRow.SyndicateId;
                if (!webRow.IsSubCommitteIdNull())
                    row.SubCommitteId = webRow.SubCommitteId;
                if (!webRow.IsMemberNameNull())
                    row.MemberName = webRow.MemberName;
                if (!webRow.IsBirthDateNull())
                    row.BirthDate = webRow.BirthDate;
                //row.QualtypeId = webRow.QualtypeId;
                if (!webRow.IsJobtitleIDNull())
                    row.JobtitleID = webRow.JobtitleID;
                //row.membertypeid = webRow.membertypeid;
                if (!webRow.IsWorkeDateNull())
                    row.WorkeDate = webRow.WorkeDate;
                //row.kasmDate = webRow.kasmDate;
                //row.estefaa = webRow.estefaa;
                if (!webRow.IsesalnoNull())
                    row.esalno = webRow.esalno;
                row.RandomCard = new Random().Next(100, 999).ToString();
                //if (webRow.IsKideNumberNull() || webRow.KideNumber.ToString().Length == 0)
                //    row.KideNumber = (int)adp.ScalarQueryNewKideNumber();
                //else
                row.KideNumber = webRow.KideNumber;
                row.img = Program.imgPath + row.KideNumber + Program.imgExt;
                row.cardtype = webRow.CardtypeId;
                if (!webRow.IsdateendNull())
                    row.dateend = webRow.dateend;
                if (!webRow.IsInstallmentNull())
                    row.Installment = webRow.Installment;
                row.MemberShipNumber = (int)adp.ScalarQueryNewMemberShipNumber();
                row.userin = Program.UserInfo.UserId;
                row.datein = SQLProvider.GetServerDateTime();
                row.trheelprog = true;
                if (!webRow.IsmnidNull())
                {
                    row.MemberNId = webRow.mnid;
                    List<object> ID = Misc.Misc.IDExtraction(webRow.mnid);
                    if (ID.Count == 3)
                    {
                        row.MemberGender = Convert.ToByte(ID[0]);
                        row.BirthDate = Convert.ToDateTime(ID[1]);
                        //row.MemberaddresGov = Convert.ToByte(ID[2]);
                    }
                }
              
                dsTeachersUnionList.TBLMembers.AddTBLMembersRow(row);
                if (File.Exists(Program.imgPathWeb + webRow.imagepath))
                {
                    if (File.Exists(row.img))
                        File.Delete(row.img);
                    File.Move(Program.imgPathWeb + webRow.imagepath, row.img);
                }
                adp.Update(row);
                savedMemberCount++;
                row.MemberId = (int)adp.ScalarQueryKideNumberByMemberId(row.KideNumber);
                webRow.closed = true;
                tblMemberWebTableAdapter.Update(webRow);

                //Tarhel AksatWeb for member
                DataSources.dsTeachersUnionTableAdapters.TBLAksatWEBTableAdapter adpAksatWeb = new DataSources.dsTeachersUnionTableAdapters.TBLAksatWEBTableAdapter();
                adpAksatWeb.FillByMemberId(dsTeachersUnionList.TBLAksatWEB, webRow.MemberId);
                foreach (DataSources.dsTeachersUnion.TBLAksatWEBRow RowAksatWeb in dsTeachersUnionList.TBLAksatWEB.Rows)
                {
                    DataSources.dsTeachersUnion.TBLAksatRow RowAksat = dsTeachersUnionList.TBLAksat.NewTBLAksatRow();
                    RowAksat.MemberId = row.MemberId;
                    RowAksat.kestenddate = RowAksatWeb.kestenddate;
                    RowAksat.mostahk = RowAksatWeb.mostahk;
                    RowAksat.madfoaa = RowAksatWeb.madfoaa;
                    RowAksat.esalno = RowAksatWeb.esalno;
                    RowAksat.esaldate = RowAksatWeb.esaldate;
                    RowAksat.userin = Program.UserInfo.UserId;
                    RowAksat.datein = SQLProvider.GetServerDateTime();
                    dsTeachersUnionList.TBLAksat.AddTBLAksatRow(RowAksat);
                }
                DataSources.dsTeachersUnionTableAdapters.TBLAksatTableAdapter adpAksat = new DataSources.dsTeachersUnionTableAdapters.TBLAksatTableAdapter();
                savedAksatCount += adpAksat.Update(dsTeachersUnionList.TBLAksat);

                //Tarhel Hala for member
                DataSources.dsTeachersUnionTableAdapters.TBLMemberHalaTableAdapter adpHala = new DataSources.dsTeachersUnionTableAdapters.TBLMemberHalaTableAdapter();
                DataSources.dsTeachersUnionTableAdapters.TBLMemberHalaWebTableAdapter adpHalaWeb = new DataSources.dsTeachersUnionTableAdapters.TBLMemberHalaWebTableAdapter();
                adpHalaWeb.FillByMemberId(dsTeachersUnionList.TBLMemberHalaWeb, webRow.MemberId);
                foreach (DataSources.dsTeachersUnion.TBLMemberHalaWebRow RowHalaWeb in dsTeachersUnionList.TBLMemberHalaWeb.Rows)
                {
                    DataSources.dsTeachersUnion.TBLMemberHalaRow RowHala = dsTeachersUnionList.TBLMemberHala.NewTBLMemberHalaRow();
                    RowHala.MemberId = row.MemberId;
                    RowHala.MemberSTypeId = RowHalaWeb.MemberSTypeId;
                    if (!RowHalaWeb.IsgehaidNull())
                        RowHala.gehaid = RowHalaWeb.gehaid;
                    RowHala.datefrom = RowHalaWeb.datefrom;
                    if (!RowHalaWeb.IsdatetoNull())
                        RowHala.dateto = RowHalaWeb.dateto;
                    if (!RowHalaWeb.IsremararksNull())
                        RowHala.remararks = RowHalaWeb.remararks;
                    if (!RowHalaWeb.IsremararksNull())
                        RowHala.remararks = RowHalaWeb.remararks;
                    RowHala.userin = Program.UserInfo.UserId;
                    RowHala.datein = SQLProvider.GetServerDateTime();
                    dsTeachersUnionList.TBLMemberHala.AddTBLMemberHalaRow(RowHala);
                }
                savedHalaCount = +adpHala.Update(dsTeachersUnionList.TBLMemberHala);

                //Tarhel Sadad for member
                DataSources.dsTeachersUnionTableAdapters.TBLSadadTableAdapter adpSadad = new DataSources.dsTeachersUnionTableAdapters.TBLSadadTableAdapter();
                DataSources.dsTeachersUnionTableAdapters.TBLSadadWebTableAdapter adpSadadWeb = new DataSources.dsTeachersUnionTableAdapters.TBLSadadWebTableAdapter();
                adpSadadWeb.FillByMemberId(dsTeachersUnionList.TBLSadadWeb, webRow.MemberId);
                foreach (DataSources.dsTeachersUnion.TBLSadadWebRow RowSadadWeb in dsTeachersUnionList.TBLSadadWeb)
                {
                    DataSources.dsTeachersUnion.TBLSadadRow RowSadad = dsTeachersUnionList.TBLSadad.NewTBLSadadRow();
                    RowSadad.MemberId = row.MemberId;
                    RowSadad.esalno = RowSadadWeb.esalno;
                    RowSadad.esaldate = RowSadadWeb.esaldate;
                    RowSadad.esalmony = RowSadadWeb.esalmony;
                    RowSadad.fatrafrom = RowSadadWeb.fatrafrom;
                    RowSadad.fatrato = RowSadadWeb.fatrato;
                    if (!RowSadadWeb.IsesalremarkNull())
                        RowSadad.esalremark = RowSadadWeb.esalremark;
                    RowSadad.userin = Program.UserInfo.UserId;
                    RowSadad.datein = SQLProvider.GetServerDateTime();
                    dsTeachersUnionList.TBLSadad.AddTBLSadadRow(RowSadad);
                }
                savedSadadCount += adpSadad.Update(dsTeachersUnionList.TBLSadad);
            }
            string saveMsg = string.Format("تم ترحيل اعضاء عدد {0} عضو {1} تم ترحيل اقساط عدد {2} قسط {3} تم ترحيل حالات {4} حالة {5} تم ترحيل سداد عدد {6}",
                savedMemberCount, Environment.NewLine, savedAksatCount, Environment.NewLine, savedHalaCount, Environment.NewLine, savedSadadCount);
            Program.ShowMsg(saveMsg, false, this);
            Program.Logger.LogThis(saveMsg, Text, FXFW.Logger.OpType.success, null, null, this);
            LUEHafza_EditValueChanged(LUEHafza, new EventArgs());
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