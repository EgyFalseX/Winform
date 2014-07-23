using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;

namespace Members.Forms.Data
{
    public partial class ImportFromWebFrm : DevExpress.XtraEditors.XtraForm
    {
        public ImportFromWebFrm()
        {
            InitializeComponent();
        }
        private void ActivePriv()
        {
            return;//ActivePrivReady
            bool Selecting = false, Inserting = false, Updateing = false, Deleting = false;
            SQLProvider.GetFormPriv(this.Name, ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);

            if (Inserting || Updateing)
                btnImport.Visible = true;
            else
                btnImport.Visible = false;
        }
        private void ImportFromWebFrm_Load(object sender, EventArgs e)
        {
            ActivePriv();
            if (!File.Exists(Program.WebDB))
            {
                groupControlInfo.Text = "قاعدة البيانات غير موجودة";
                groupControlInfo.Enabled = false;
                groupControlOp.Enabled = false;
                return;
            }

            tblHafzawebTableAdapter.Fill(dsTeachersUnion.TBLHafzaweb);
            tblMemberWebTableAdapter.Fill(dsTeachersUnion.TBLMemberWeb);
            tbLmemberagazatWebTableAdapter.Fill(dsTeachersUnion.TBLmemberagazatWeb);

            hafzaTableAdapter.Fill(dsMemberCard.hafza);
            tblAllMemberTableAdapter.Fill(dsMemberCard.TBLAllMember);
            memberagazatTableAdapter.Fill(dsMemberCard.memberagazat);

            lblHafzaCounter.Text = dsMemberCard.hafza.Count.ToString();
            lblMemberCounter.Text = dsMemberCard.TBLAllMember.Count.ToString();
            lblagazatCounter.Text = dsMemberCard.memberagazat.Count.ToString();
        }
        private void btnImport_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            System.Threading.ThreadPool.QueueUserWorkItem((o) =>
            {
                btnImport.Invoke(new MethodInvoker(() =>
                {
                    btnImport.Enabled = false;
                }));
                pbc.Invoke(new MethodInvoker(() =>
                {
                    pbc.Properties.Maximum = dsMemberCard.hafza.Count + dsMemberCard.TBLAllMember.Count + dsMemberCard.memberagazat.Count;
                }));
                try
                {
                    int changes = 0;
                    DataSources.dsTeachersUnion dsExists = new DataSources.dsTeachersUnion();
                    DataSources.dsTeachersUnionTableAdapters.TBLMemberWebTableAdapter adpExistsmemeber = new DataSources.dsTeachersUnionTableAdapters.TBLMemberWebTableAdapter();
                    DataSources.dsTeachersUnionTableAdapters.TBLHafzawebTableAdapter adpExistshafza = new DataSources.dsTeachersUnionTableAdapters.TBLHafzawebTableAdapter();
                    DataSources.dsTeachersUnionTableAdapters.TBLmemberagazatWebTableAdapter adpExistsagaza = new DataSources.dsTeachersUnionTableAdapters.TBLmemberagazatWebTableAdapter();

                    for (int i = 0; i < dsMemberCard.TBLAllMember.Count; i++)
                    {
                        pbc.Invoke(new MethodInvoker(() => {
                            pbc.EditValue = Convert.ToInt32(pbc.EditValue) + 1;
                        }));
                        DataSources.dsMemberCard.TBLAllMemberRow AccessRow = (DataSources.dsMemberCard.TBLAllMemberRow)dsMemberCard.TBLAllMember.Rows[i];
                        DataSources.dsTeachersUnion.TBLMemberWebRow SqlRow = dsTeachersUnion.TBLMemberWeb.NewTBLMemberWebRow();
                        if ((int)adpExistsmemeber.ScalarQueryExistsID(AccessRow.MemberId) == 1)// check if exists
                            continue;

                        SqlRow.MemberId = AccessRow.MemberId;
                        SqlRow.membertypeid = AccessRow.membertypeid;
                        SqlRow.SyndicateId = AccessRow.SyndicateId;
                        SqlRow.SubCommitteId = AccessRow.SubCommitteId;
                        SqlRow.MemberName = AccessRow.MemberName;
                        SqlRow.BirthDate = AccessRow.BirthDate;
                        SqlRow.QualtypeId = AccessRow.QualtypeId;
                        SqlRow.JobtitleID = AccessRow.JobtitleID;
                        SqlRow.WorkeDate = AccessRow.WorkeDate;
                        SqlRow.kasmDate = AccessRow.kasmDate;
                        SqlRow.imagepath = AccessRow.imagepath;
                        SqlRow.datein = AccessRow.datein;
                        //SqlRow.closed = AccessRow.closed;
                        SqlRow.closed = false;
                        SqlRow.kednew = true;
                        SqlRow.rekeed = false;
                        SqlRow.estefaa = false;
                        SqlRow.userin = Program.UserInfo.UserId;
                        if (!AccessRow.IsmnidNull())
                        {
                            try
                            {
                                SqlRow.mnid = AccessRow.mnid;
                                List<object> ID = Misc.Misc.IDExtraction(SqlRow.mnid);
                                if (ID.Count == 3)
                                {
                                    SqlRow.BirthDate = Convert.ToDateTime(ID[1]);
                                    //row.MemberaddresGov = Convert.ToByte(ID[2]);
                                }
                            }
                            catch (Exception ex)
                            {
                                this.Invoke(new MethodInvoker(() =>
                                {
                                    Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, ex, null, this);
                                }));
                                continue;
                            }
                        }
                        dsTeachersUnion.TBLMemberWeb.AddTBLMemberWebRow(SqlRow);
                        changes++;
                        Application.DoEvents();
                    }
                    tblMemberWebTableAdapter.Update(dsTeachersUnion.TBLMemberWeb);
                    Application.DoEvents();

                    for (int i = 0; i < dsMemberCard.hafza.Count; i++)
                    {
                        pbc.Invoke(new MethodInvoker(() =>
                        {
                            pbc.EditValue = Convert.ToInt32(pbc.EditValue) + 1;
                        }));
                        DataSources.dsMemberCard.hafzaRow AccessRow = (DataSources.dsMemberCard.hafzaRow)dsMemberCard.hafza.Rows[i];
                        DataSources.dsTeachersUnion.TBLHafzawebRow SqlRow = dsTeachersUnion.TBLHafzaweb.NewTBLHafzawebRow();
                        if ((int)adpExistshafza.ScalarQueryExistsID(AccessRow.hafzaid, AccessRow.SyndicateId, AccessRow.MemberId) == 1)// check if exists
                            continue;

                        SqlRow.hafzaid = AccessRow.hafzaid;
                        SqlRow.SyndicateId = AccessRow.SyndicateId;
                        SqlRow.MemberId = AccessRow.MemberId;
                        SqlRow.hafzadate = AccessRow.hafzadate;
                        dsTeachersUnion.TBLHafzaweb.AddTBLHafzawebRow(SqlRow);
                        changes++;
                        Application.DoEvents();
                    }
                    tblHafzawebTableAdapter.Update(dsTeachersUnion.TBLHafzaweb);
                    Application.DoEvents();

                    for (int i = 0; i < dsMemberCard.memberagazat.Count; i++)
                    {
                        pbc.Invoke(new MethodInvoker(() =>
                        {
                            pbc.EditValue = Convert.ToInt32(pbc.EditValue) + 1;
                        }));
                        DataSources.dsMemberCard.memberagazatRow AccessRow = (DataSources.dsMemberCard.memberagazatRow)dsMemberCard.memberagazat.Rows[i];
                        DataSources.dsTeachersUnion.TBLmemberagazatWebRow SqlRow = dsTeachersUnion.TBLmemberagazatWeb.NewTBLmemberagazatWebRow();
                        if ((int)adpExistsagaza.ScalarQueryExistsID(AccessRow.MemberId, AccessRow.agazatypeId, AccessRow.datefrom.Date) > 0)// check if exists
                            continue;
                        foreach (DataSources.dsMemberCard.TBLAllMemberRow member in dsMemberCard.TBLAllMember.Rows)
                        {
                            if (member.MemberId == AccessRow.MemberId)
                            {

                                SqlRow.MemberId = AccessRow.MemberId;
                                SqlRow.agazatypeId = AccessRow.agazatypeId;
                                SqlRow.datefrom = AccessRow.datefrom;
                                SqlRow.dateto = AccessRow.dateto;
                                dsTeachersUnion.TBLmemberagazatWeb.AddTBLmemberagazatWebRow(SqlRow);
                                changes++;
                                Application.DoEvents();
                                break;
                            }
                        }
                    }
                    tbLmemberagazatWebTableAdapter.Update(dsTeachersUnion.TBLmemberagazatWeb);

                    this.Invoke(new MethodInvoker(() =>
                    {
                        Program.ShowMsg("تم استيراد " + changes.ToString(), false, this);
                        Program.Logger.LogThis("تم استيراد " + changes.ToString(), Text, FXFW.Logger.OpType.success, null, null, this);
                    }));
                  
                }
                catch (Exception ex)
                {
                    this.Invoke(new MethodInvoker(() =>
                    {
                        Program.ShowMsg(Misc.Misc.ExceptionMessage(ex), true, this);
                        Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, ex, null, this);
                    }));
                }
                pbc.Invoke(new MethodInvoker(() =>
                {
                    pbc.EditValue = 0;
                }));
                btnImport.Invoke(new MethodInvoker(() =>
                {
                    btnImport.Enabled = true;
                }));
            });
            
        }
    }
}