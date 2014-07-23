using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using DevExpress.XtraSplashScreen;

namespace RetirementCenter
{
    public partial class ImportFromAccessFrm : DevExpress.XtraEditors.XtraForm
    {
        public ImportFromAccessFrm()
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

            replyTableAdapter.Fill(dsdatam.reply);
            lblCounter.Text = dsdatam.reply.Count.ToString();

            tblmemberTableAdapter.FillBymnidNotNull(dsWebData.tblmember);
            lblWebMemberCounter.Text = dsWebData.tblmember.Count.ToString();

            tblwarasasonTableAdapter.FillBysonnidNotNull(dsWebData.tblwarasason);
            lblWebWarasaCounter.Text = dsWebData.tblwarasason.Count.ToString();

            accsessTableAdapter.Fill(dsdatam.accsess);
            lblAccessCount.Text = dsdatam.accsess.Count.ToString();

        }
        private void ceWarasa_CheckedChanged(object sender, EventArgs e)
        {
            if (!ceWarasa.Checked)
                ceWarasaExtra.Enabled = ceWarasaExtra.Checked = ceWarasa.Checked;
            else
                ceWarasaExtra.Enabled = ceWarasa.Checked;
        }
        private void btnImport_Click(object sender, EventArgs e)
        {
            if (msgDlg.Show("هل انت متأكد؟", msgDlg.msgButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                return;
            System.Threading.ThreadPool.QueueUserWorkItem((o) =>
            {
                btnImport.Invoke(new MethodInvoker(() =>
                {
                    btnImport.Enabled = false;
                    btnUpdate.Enabled = false;
                }));
                pbc.Invoke(new MethodInvoker(() =>
                {
                    pbc.Properties.Maximum = dsdatam.reply.Count;
                    pbc.EditValue = 0;
                }));
                try
                {
                    int DofatSarfId = (int)SQLProvider.adpQry.LatestDofatSarfId();

                    foreach (DataSources.dsdatam.replyRow item in dsdatam.reply.Rows)
                    {
                        DataSources.dsRetirementCenter.TBLMashatRow row = (DataSources.dsRetirementCenter.TBLMashatRow)dsRetirementCenter.TBLMashat.NewTBLMashatRow();
                        row.MMashatId = (int)SQLProvider.adpQry.MemberNewId();
                        row.MMashatName = item.reply_name;
                        if (!item.Isرقم_الصرفNull())
                            row.sarfnumber = item.رقم_الصرف;
                        row.SyndicateId = item.الفرعية;
                        if (!item.IstypeeNull())
                            row.MashHalaId = Convert.ToByte(item.typee);
                        if (!item.IsاللجنةNull())
                            row.SubCommitteId = item.اللجنة;
                        row.datein = SQLProvider.ServerDateTime();
                        row.userin = Program.UserInfo.UserId;
                        if (!item.IsadddresNull())
                            row.MMashataddres = item.adddres;
                        if (!item.IsfiledateNull())
                            row.WorkeEndDate = item.filedate;
                        if (!item.IskedNull())
                            row.KideNumber = item.ked;
                        row.yasref = true;
                        row.SarfExpetion = false;
                        row.mcompletesarf = true;
                        row.meshtrakat = 0; row.mestktaat = 0; row.melrasm = 0; row.mmony = 0;
                        tblMashatTablebindingSource.EndEdit();
                        dsRetirementCenter.TBLMashat.AddTBLMashatRow(row);
                        tblMashatTableAdapter.Update(row);
                        dsRetirementCenter.TBLMashat.AcceptChanges();
                        if (!item.IsملاحظاتNull())
                            tblmRemarksTableAdapter.Insert(row.MMashatId, item.ملاحظات, row.datein, row.userin);
                        
                        //Import Edafat
                        if (ceExtra.Checked)
                        {
                            double estktaa = 0;
                            if (!item.IsadddresNull())
                                estktaa = item.estktaa;

                            tblEdafatTableAdapter.Insert(row.MMashatId, DofatSarfId, (byte)Misc.Types.CDsarfType.A3da2
                                , estktaa, SQLProvider.ServerDateTime(), Program.UserInfo.UserId);
                        }

                        //Import Warasa
                        if (ceWarasa.Checked)
                        {
                            foreach (DataSources.dsdatam.reply_wRow replyW in reply_wTableAdapter.GetDataByt1(item.t1))
                            {
                                string[] names = replyW.w_name.Split('/');
                                foreach (string name in names)
                                {
                                    int PersonId = (int)SQLProvider.adpQry.TBLWarasaNewId();
                                    tblWarasaTableAdapter.Insert(PersonId, row.MMashatId, replyW.WarasaType, name.Trim(), string.Empty, null, string.Empty,
                                        string.Empty, true, Program.UserInfo.UserId, SQLProvider.ServerDateTime(), item.الفرعية, item.اللجنة, false, PersonId, 0, true, 0, 0);
                                    if (ceWarasaExtra.Checked)
                                    {
                                        tblEdafatWarsaTableAdapter.Insert(PersonId, DofatSarfId, (byte)Misc.Types.CDMashHala.Warasa, replyW.estktaa, 
                                            SQLProvider.ServerDateTime(), Program.UserInfo.UserId, replyW.filedate);
                                    }
                                }
                            }
                        }

                        pbc.Invoke(new MethodInvoker(() =>
                        {
                            pbc.EditValue = Convert.ToInt32(pbc.EditValue) + 1;
                        }));
                    }
                    Program.ShowMsg("تم الاستيراد ", false, this, true);
                    Program.Logger.LogThis("تم الاستيراد ", Text, FXFW.Logger.OpType.success, null, null, this);
                }
                catch (Exception ex)
                {
                    this.ParentForm.Invoke(new MethodInvoker(() =>
                    {
                        Program.ShowMsg(Misc.Misc.ExceptionMessage(ex), true, this, true);
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
                    btnUpdate.Enabled = true;
                }));
            });
            
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (msgDlg.Show("هل انت متأكد؟", msgDlg.msgButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                return;
            System.Threading.ThreadPool.QueueUserWorkItem((o) =>
            {
                btnImport.Invoke(new MethodInvoker(() =>
                {
                    btnImport.Enabled = false;
                    btnUpdate.Enabled = false;
                }));
                pbc.Invoke(new MethodInvoker(() =>
                {
                    pbc.Properties.Maximum = dsWebData.tblmember.Count;
                    pbc.EditValue = 0;
                }));
                try
                {
                    
                    string msg = string.Empty;
                    foreach (DataSources.dsWebData.tblmemberRow item in dsWebData.tblmember.Rows)
                    {
                        if (ceUpdateNIDMember.Checked)
                        {
                            if ((int)SQLProvider.adpQry.ExistsNID(item.mnid, item.memberid, item.memberid) > 0)
                            {
                                msg += item.mnid + Environment.NewLine;
                                continue;
                            }
                            tblMashatTableAdapter.UpdateQueryMMashatNIdWhereIsNull(item.mnid, item.memberid);
                        }
                        pbc.Invoke(new MethodInvoker(() =>
                        {
                            pbc.EditValue = Convert.ToInt32(pbc.EditValue) + 1;
                        }));
                    }
                    pbc.Invoke(new MethodInvoker(() =>
                    {
                        pbc.Properties.Maximum = dsWebData.tblwarasason.Count;
                        pbc.EditValue = 0;
                    }));

                    foreach (DataSources.dsWebData.tblwarasasonRow item in dsWebData.tblwarasason.Rows)
                    {
                        if (ceUpdateNIDWarasa.Checked)
                        {
                            if ((int)SQLProvider.adpQry.ExistsNID(item.sonnid, item.memberid, item.memberid) > 0)
                            {
                                msg += item.sonnid + Environment.NewLine;
                                continue;
                            }
                            tblWarasaTableAdapter.UpdateQuerypersonNIDWhereIsNull(item.sonnid, item.sonid);
                        }
                        pbc.Invoke(new MethodInvoker(() =>
                        {
                            pbc.EditValue = Convert.ToInt32(pbc.EditValue) + 1;
                        }));
                    }
                    Program.ShowMsg("تم التحديث", false, this, true);
                    if (msg != string.Empty)
                    {
                        msgDlg.Show("الارقام التاليه موجوده مسبقا:" + Environment.NewLine + msg, msgDlg.msgButtons.Close);
                    }
                }
                catch (Exception ex)
                {
                    this.ParentForm.Invoke(new MethodInvoker(() =>
                    {
                        Program.ShowMsg(Misc.Misc.ExceptionMessage(ex), true, this, true);
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
                    btnUpdate.Enabled = true;
                }));
            });
        }
        private void btnImportAccess_Click(object sender, EventArgs e)
        {
            if (!ceImportAccsess.Checked)
            {
                return;
            }

             if (msgDlg.Show("هل انت متأكد؟", msgDlg.msgButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                return;
            System.Threading.ThreadPool.QueueUserWorkItem((o) =>
            {
                btnImportAccess.Invoke(new MethodInvoker(() =>
                {
                    btnImportAccess.Enabled = false;
                }));
                pbc.Invoke(new MethodInvoker(() =>
                {
                    pbc.Properties.Maximum = dsdatam.accsess.Count;
                    pbc.EditValue = 0;
                }));
                try
                {
                    foreach (DataSources.dsdatam.accsessRow item in dsdatam.accsess.Rows)
                    {
                        DataSources.dsRetirementCenter.FromAccessRow row = (DataSources.dsRetirementCenter.FromAccessRow)dsRetirementCenter.FromAccess.NewFromAccessRow();
                        row.MashHalaId = Convert.ToByte(item.maashhala);
                        row.SyndicateId = item.syndicate;
                        row.SubCommitteId = item.lagna;
                        row.sarfnumber = item.sarffnomber;
                        row.accsessmony = item.amony;
                        dsRetirementCenter.FromAccess.AddFromAccessRow(row);
                        pbc.Invoke(new MethodInvoker(() =>
                        {
                            pbc.EditValue = (int)pbc.EditValue + 1;
                        }));
                    }
                    
                    SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
                    this.Invoke(new MethodInvoker(() =>
                    {
                        fromAccessTableAdapter.Update(dsRetirementCenter.FromAccess);
                        Program.ShowMsg("تم الاستيراد", false, this, true);
                        Program.Logger.LogThis("تم الاستيراد", Text, FXFW.Logger.OpType.success, null, null, this);
                    }));
                    SplashScreenManager.CloseForm();
                }
                catch (Exception ex)
                {
                    this.ParentForm.Invoke(new MethodInvoker(() =>
                    {
                        Program.ShowMsg(Misc.Misc.ExceptionMessage(ex), true, this, true);
                        Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, ex, null, this);
                    }));
                }
                pbc.Invoke(new MethodInvoker(() =>
                {
                    pbc.EditValue = 0;
                }));
                btnImport.Invoke(new MethodInvoker(() =>
                {
                    btnImportAccess.Enabled = false;
                }));
            });

        }
        
    }
}