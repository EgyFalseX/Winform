using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Imaging;
using DevExpress.XtraExport;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.DXErrorProvider;

namespace Members
{
    public partial class TBLMembersFast2Frm : DevExpress.XtraEditors.XtraForm
    {
        
        OpenFileDialog openFile = new OpenFileDialog();
        #region -   Functions   -
        public TBLMembersFast2Frm()
        {
            InitializeComponent();
        }
        private void LoadDefaultData(CodeFrm.TableNames SelectedTable)
        {
            switch (SelectedTable)
            {
                case CodeFrm.TableNames.All:
               
                    //CDSyndicate
                    LUESyndicateId.Properties.DataSource = SQLProvider.SelectCDSyndicate();
                    LUESyndicateId.Properties.DisplayMember = "Syndicate";
                    LUESyndicateId.Properties.ValueMember = "SyndicateId";
                    //CDSubCommitte
                    LUESubCommitteId.Properties.DataSource = SQLProvider.SelectCDSubCommitte();
                    LUESubCommitteId.Properties.DisplayMember = "SubCommitte";
                    LUESubCommitteId.Properties.ValueMember = "SubCommitteId";
                    //CDJobtitle
                    LUEJobtitleID.Properties.DataSource = SQLProvider.SelectCDJobtitle();
                    LUEJobtitleID.Properties.DisplayMember = "Jobtitle";
                    LUEJobtitleID.Properties.ValueMember = "JobtitleID";
                    break;
                case CodeFrm.TableNames.CDSyndicate:
                    //CDSyndicate
                    LUESyndicateId.Properties.DataSource = SQLProvider.SelectCDSyndicate();
                    LUESyndicateId.Properties.DisplayMember = "Syndicate";
                    LUESyndicateId.Properties.ValueMember = "SyndicateId";
                    break;
                case CodeFrm.TableNames.CDSubCommitte:
                    //CDSubCommitte
                    LUESubCommitteId.Properties.DataSource = SQLProvider.SelectCDSubCommitte();
                    LUESubCommitteId.Properties.DisplayMember = "SubCommitte";
                    LUESubCommitteId.Properties.ValueMember = "SubCommitteId";
                    break;
                case CodeFrm.TableNames.CDJobtitle:
                    //CDJobtitle
                    LUEJobtitleID.Properties.DataSource = SQLProvider.SelectCDJobtitle();
                    LUEJobtitleID.Properties.DisplayMember = "Jobtitle";
                    LUEJobtitleID.Properties.ValueMember = "JobtitleID";
                    break;
                default:
                    break;
            }
        }
        private string GetNewFolderPath_Deleted()
        {
            string outStr = string.Empty;
            //Directory.GetFiles(Program.imgPath);
            //for (int i = 0; i < int.MaxValue; i++)
            //{
            //    string FolderName = string.Empty;
            //    if (i.ToString().Length == 1)
            //        FolderName = "00" + i;
            //    else if (i.ToString().Length == 2)
            //        FolderName = "0" + i;
            //    if (!Directory.Exists(Program.imgPath + FolderName))
            //        Directory.CreateDirectory(Program.imgPath + FolderName);
            //    if (Directory.GetFiles(Program.imgPath + FolderName).Length >= 5000)
            //        continue;
            //    outStr = FolderName + "\\";
            //    break;
            //}
            return outStr;
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
            btnUpdate.Visible = Updateing;
            btnDelete.Visible = Deleting;
            repositoryItemButtonEditRemarkDel.Buttons[0].Visible = Deleting;
            if (!Inserting)
                gridViewRemark.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
            if (Program.UserInfo.IsAdmin)
                xtraTabPageAdmin.PageVisible = true;
            
        }
        #endregion
        #region - Event Handlers -
        private void TBL_EmpFrm_Load(object sender, EventArgs e)
        {
            sessionData.ConnectionString = Properties.Settings.Default.TeachersUnionConnectionString;
            // TODO: This line of code loads data into the 'dsTeachersUnionQuery.ReceiptsList' table. You can move, or remove it, as needed.
            this.receiptsListTableAdapter.Fill(this.dsTeachersUnionQuery.ReceiptsList);
            cDSyndicateTableAdapter.Fill(dsTeachersUnion.CDSyndicate);
            // TODO: This line of code loads data into the 'dsTeachersUnion.CDCardtype' table. You can move, or remove it, as needed.
            this.cDCardtypeTableAdapter.Fill(this.dsTeachersUnion.CDCardtype);
            ActivePriv();
            LoadDefaultData(CodeFrm.TableNames.All);
            //LoadData();
            this.Disposed += TBLMembersFast2Frm_Disposed;

            CustomValidationRule lengthValidationRule = new CustomValidationRule();
            lengthValidationRule.ErrorText = "يجب ادخال 14 رقم";
            lengthValidationRule.ErrorType = ErrorType.Warning;
            dxValidationProviderMain.SetValidationRule(tbMemberNId, lengthValidationRule);
            tbesalno.LostFocus += tbesalno_LostFocus;
            tbKideNumber.LostFocus += tbKideNumber_LostFocus;
        }

        private void LUEEmp_EditValueChanged(object sender, EventArgs e)
        {
            if (LUEEmp.EditValue == null)
            {
                btnNew_Click(btnNew, new EventArgs());
                btnUpdate.Enabled = false;
                btnSave.Enabled = false;
                btnDelete.Enabled = false;
                xtraTabPageRemarks.PageVisible = false;
                return;
            }
            DataSources.dsTeachersUnion.TBLMembersRow row = (DataSources.dsTeachersUnion.TBLMembersRow)tblMembersTableAdapter.GetDataByMemberId(Convert.ToInt32(LUEEmp.EditValue)).Rows[0];

            if (!row.IsNull("fawry"))
                cefawry.EditValue = row.fawry;
            else
                cefawry.Checked = false;

            if (!row.IsNull("MemberName"))
                tbMemberName.EditValue = row.MemberName;
            else
                tbMemberName.EditValue = string.Empty;
            if (!row.IsNull("JobtitleID"))
                LUEJobtitleID.EditValue = row.JobtitleID;
            else
                LUEJobtitleID.EditValue = null;
            if (!row.IsNull("KideNumber"))
                tbKideNumber.EditValue = row.KideNumber;
            else
                tbKideNumber.EditValue = string.Empty;
            if (!row.IsNull("SyndicateId"))
                LUESyndicateId.EditValue = row.SyndicateId;
            else
                LUESyndicateId.EditValue = null;
            LUESyndicateId_EditValueChanged(LUESyndicateId, new EventArgs());
            if (!row.IsNull("SubCommitteId"))
                LUESubCommitteId.EditValue = row.SubCommitteId;
            else
                LUESubCommitteId.EditValue = null;

            if (!row.IsNull("MemberNId"))
                tbMemberNId.EditValue = row.MemberNId;
            else
                tbMemberNId.EditValue = null;

            if (!row.IsNull("MemberMobil"))
                tbMemberMobil.EditValue = row.MemberMobil.ToString();
            else
                tbMemberMobil.EditValue = null;
           
            if (!row.IsNull("esalno"))
                tbesalno.EditValue = row.esalno;
            else
                tbesalno.EditValue = string.Empty;
            if (!row.IsNull("cardtype"))
                tbtype.EditValue = row.cardtype;
            else
                tbtype.EditValue = (int)Program.cardtype.دائمة;
            if (!row.IsNull("dateend"))
                dedateend.EditValue = row.dateend;
            else
                dedateend.EditValue = null;

            xtraTabPageInstallment.PageVisible = false;
            if (!row.IsNull("Installment"))
            {
                ceInstallment.EditValue = row.Installment;
                if (row.Installment)
                {
                    xtraTabPageInstallment.PageVisible = true;
                    tblAksatTableAdapter.FillByMemberId(dsTeachersUnion.TBLAksat ,Convert.ToInt32(LUEEmp.EditValue));
                    if (dsTeachersUnion.TBLAksat.Rows.Count != 0)
                    {
                        if (!dsTeachersUnion.TBLAksat[0].IsNull("kestenddate"))
                            dekestenddate.EditValue = dsTeachersUnion.TBLAksat[0].kestenddate;
                        else
                            dekestenddate.EditValue = null;
                        if (!dsTeachersUnion.TBLAksat[0].IsNull("mostahk"))
                            tbmostahk.EditValue = dsTeachersUnion.TBLAksat[0].mostahk;
                        else
                            tbmostahk.EditValue = null;
                        if (!dsTeachersUnion.TBLAksat[0].IsNull("madfoaa"))
                            tbmadfoaa.EditValue = dsTeachersUnion.TBLAksat[0].madfoaa;
                        else
                            tbmadfoaa.EditValue = null;
                        if (!dsTeachersUnion.TBLAksat[0].IsNull("esalno"))
                            tbesalnoIns.EditValue = dsTeachersUnion.TBLAksat[0].esalno;
                        else
                            tbesalnoIns.EditValue = null;
                        if (!dsTeachersUnion.TBLAksat[0].IsNull("esaldate"))
                            deesaldate.EditValue = dsTeachersUnion.TBLAksat[0].esaldate;
                        else
                            deesaldate.EditValue = null;
                    }
                    else
                    {
                        dekestenddate.EditValue = null;
                        tbmostahk.EditValue = null;
                        tbmadfoaa.EditValue = null;
                        tbesalnoIns.EditValue = null;
                        deesaldate.EditValue = null;
                    }
                }
                
            }
            else
                ceInstallment.EditValue = false;
            if (!row.IsNull("Img"))
            {
                if (File.Exists(row.img))
                {
                    peImg.EditValue = System.IO.File.ReadAllBytes(row.img);
                    peImg.FileName = row.img;
                }
                else
                    peImg.EditValue = null;
            }
            else
                peImg.EditValue = null;

            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;

            // TODO: This line of code loads data into the 'dsTeachersUnion.TBLMemberRemark' table. You can move, or remove it, as needed.
            this.tBLMemberRemarkTableAdapter.FillByMemberId(this.dsTeachersUnion.TBLMemberRemark, Convert.ToInt32(LUEEmp.EditValue));
            xtraTabPageRemarks.PageVisible = true;

            if (Program.UserInfo.IsAdmin)
            {
                xtraTabPageAdmin.PageVisible = Program.UserInfo.IsAdmin;
                if (row.IsNull("UnMember"))
                {
                    cbUnMember.Checked = false;
                }
                else
                {
                    cbUnMember.Checked = row.UnMember;
                }
            }
            
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            LUEEmp.EditValue = null;

            dsServerMembers.Session.DropIdentityMap();
            dsServerMembers.Reload();

            cefawry.Checked = false;
            tbMemberName.Text = string.Empty;
            LUEJobtitleID.EditValue = null;
            tbKideNumber.Text = string.Empty;
            //LUESyndicateId.EditValue = null;
            LUESubCommitteId.EditValue = null;
            tbMemberNId.Text = string.Empty;
            tbtype.ItemIndex = 0;
            dedateend.EditValue = null;
            ceInstallment.EditValue = false;
            tbMemberMobil.EditValue = string.Empty;

            peImg.Image = null;
            peImg.EditValue = null;

            dekestenddate.EditValue = null;
            tbmostahk.EditValue = null;
            tbmadfoaa.EditValue = null;
            tbesalnoIns.EditValue = null;
            deesaldate.EditValue = null;

            tbesalno_LostFocus(tbesalno, EventArgs.Empty);

            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            xtraTabPageRemarks.PageVisible = false;
            xtraTabPageInstallment.PageVisible = false;
            xtraTabPageAdmin.PageVisible = false;

            tbMemberName.Focus();
        }
        private void LUECDJobtitle_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDJobtitle);
            FrmCode.ShowDialog();
            LoadDefaultData(CodeFrm.TableNames.CDJobtitle);
        }
        private void LUEMemberBPlace_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDBirthPlace);
            FrmCode.ShowDialog();
            LoadDefaultData(CodeFrm.TableNames.CDBirthPlace);
        }
        private void LUEMemberaddresGov_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDGov);
            FrmCode.ShowDialog();
            LoadDefaultData(CodeFrm.TableNames.CDGov);
        }
        private void LUEMemberaddresMarkez_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDModerea);
            FrmCode.ShowDialog();
            LoadDefaultData(CodeFrm.TableNames.CDModerea);
        }
        private void LUEMemberqualId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDQualification);
            FrmCode.ShowDialog();
            LoadDefaultData(CodeFrm.TableNames.CDQualification);
        }
        private void LUEMemberSpecialization_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDSpecialization);
            FrmCode.ShowDialog();
            LoadDefaultData(CodeFrm.TableNames.CDSpecialization);
        }
        private void LUEMemberFirestJop_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDJop);
            FrmCode.ShowDialog();
            LoadDefaultData(CodeFrm.TableNames.CDJop);
        }
        private void LUESyndicateId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDSyndicate);
            FrmCode.ShowDialog();
            LoadDefaultData(CodeFrm.TableNames.CDSyndicate);
        }
        private void LUESubCommitteId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDSubCommitte);
            FrmCode.ShowDialog();
            LoadDefaultData(CodeFrm.TableNames.CDSubCommitte);
        }
        private void ceInstallment_CheckedChanged(object sender, EventArgs e)
        {
            xtraTabPageInstallment.PageVisible = ceInstallment.Checked;
        }
        private void btnImage_Click(object sender, EventArgs e)
        {
            try
            {
                if (!FXFW.SqlDB.IsNullOrEmpty(LUEEmp.EditValue))
                {
                    DataRow row = ((DataRowView)LUEEmp.GetSelectedDataRow()).Row;
                    openFile.Filter = string.Format("{0}{1}|*{1}", row["KideNumber"], Program.imgExt);
                }
                if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    PasteImage(peImg, Image.FromFile(openFile.FileName));
            }
            catch
            { }
        }
        private void PasteImage(PictureEdit pe, Image im)
        {
            if ((pe.EditValue is Image) || pe.Properties.PictureStoreMode == PictureStoreMode.Image)
                pe.EditValue = im;
            else
                pe.EditValue = DevExpress.XtraExport.ByteImageConverter.ToByteArray(im, System.Drawing.Imaging.ImageFormat.Bmp);
        }
        private void peImg_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            //const int ImgWidth = 54;
            //const int ImgHeight = 54;
            ImageFormat ImgFormat = ImageFormat.Bmp;
            const int ImgMaxSize = 200 * 1024;

            if (e.NewValue == null) return;

            try
            {
                byte[] data = (byte[])e.NewValue;
                if (data.Length > ImgMaxSize)
                {
                    e.Cancel = true;
                    return;
                }
                MemoryStream stream = new MemoryStream();
                stream.Write(data, 0, data.Length);
                stream.Position = 0;
                Image img = Image.FromStream(stream);
                if (img != null)
                {
                    if (/*img.Width != ImgWidth || img.Height != ImgHeight ||*/ !img.RawFormat.Equals(ImgFormat))
                    {
                        e.Cancel = true;
                        return;
                    }
                }
            }
            finally
            {
                if (e.Cancel)
                {
                    string msg = "حجم الصوره يجب ان يكون اصغر من 200 كيلوبايت " + "\n او نوع الصوره ليس" + "\n Bmp";
                    MessageBox.Show(msg, "صوره خاطئه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            MessageBox.Show(peImg.FileName);
        }
        private void LUESyndicateId_EditValueChanged(object sender, EventArgs e)
        {
            LUESubCommitteId.Properties.DataSource = SQLProvider.SelectCDSubCommitte(LUESyndicateId.EditValue);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (FXFW.SqlDB.IsNullOrEmpty(tbesalno.EditValue))
            {
                Program.Logger.LogThis("يجب ادخال رقم ايصال", Text, FXFW.Logger.OpType.fail, null, null, this);
                return;
            }
            if (dxValidationProviderMain.Validate() == false)
                return;
            if (ceInstallment.Checked)
            {
                if (dxValidationProviderInstallment.Validate() == false)
                    return;
            }
            try
            {
                string img = Program.imgPath + tbKideNumber.EditValue + Program.imgExt;
                if (!FXFW.SqlDB.IsNullOrEmpty(peImg.EditValue))
                {
                    if (File.Exists(img))
                        File.Delete(img);
                    peImg.Image.Save(img, ImageFormat.Jpeg);
                }
                else
                    img = string.Empty;
                dsTeachersUnion.TBLMembers.Clear();
                DataSources.dsTeachersUnion.TBLMembersRow row = dsTeachersUnion.TBLMembers.NewTBLMembersRow();
                Update(row);
                if (row.RowState == DataRowState.Detached)
                {
                    row.MemberId = -100;
                }
                if (!row.IsesalnoNull())
                {
                    if (Convert.ToInt32(SQLProvider.adpQry.eslanoRemains(row.esalno)) - 1 < 0)
                    {
                        Program.Logger.LogThis("هذا الايصال تم ادخال كل اعضائة", Text, FXFW.Logger.OpType.fail, null, null, this);
                        return;
                    }
                }
                if (Misc.Misc.CalcAge(row.BirthDate) >= 45 && row.NewMember)
                {
                    //Program.Logger.LogThis("لا يجب ادخال عضو اكبر من 45 سنة", Text, FXFW.Logger.OpType.fail, null, null, this);
                    if (MessageBox.Show("هذا العضو اكبر من 45 سنه هل ترغب في حفظ العضو كعضو قديم؟", "عضو جديد غير لائق", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                        return;
                    else
                        row.NewMember = false;
                }
                
                dsTeachersUnion.TBLMembers.AddTBLMembersRow(row);
                dsTeachersUnion.TBLMembers.EndInit();
                tblMembersTableAdapter.Update(dsTeachersUnion.TBLMembers);
                dsTeachersUnion.TBLMembers.AcceptChanges();
                row.MemberId = (int)tblMembersTableAdapter.ScalarQueryKideNumberByMemberId(row.KideNumber);// get the new memberid
                //Update Member Aksat
                if (row.Installment)
                    UpdateAksat(row.MemberId);

                Program.ShowMsg("تم الاضافه", false, this);
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
            if (FXFW.SqlDB.IsNullOrEmpty(tbesalno.EditValue))
            {
                Program.Logger.LogThis("يجب ادخال رقم ايصال", Text, FXFW.Logger.OpType.fail, null, null, this);
                return;
            }
            if (FXFW.SqlDB.IsNullOrEmpty(LUEEmp.EditValue))
                return;
            DataSources.dsTeachersUnionTableAdapters.TBLPrintCardTableAdapter adpPrint = new DataSources.dsTeachersUnionTableAdapters.TBLPrintCardTableAdapter();
           
            if (adpPrint.ScalarQueryMemberExists(Convert.ToInt32(LUEEmp.EditValue)).ToString() == "1")
            {
                DataSources.dsTeachersUnionTableAdapters.UserRolesTableAdapter adpRole = new DataSources.dsTeachersUnionTableAdapters.UserRolesTableAdapter();
                
                if (!Program.UserInfo.IsAdmin)
                {
                    MessageBox.Show("التعديل مغلق حيث تم طبع كارنية بالبيانات الحالبة", "لم يتم العملية", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            try
            {
                string img = Program.imgPath + tbKideNumber.EditValue + Program.imgExt;
                if (!FXFW.SqlDB.IsNullOrEmpty(peImg.EditValue))
                {
                    if (File.Exists(img))
                        File.Delete(img);
                    peImg.Image.Save(img, ImageFormat.Jpeg);
                }
                DataSources.dsTeachersUnion.TBLMembersRow row = (DataSources.dsTeachersUnion.TBLMembersRow)tblMembersTableAdapter.GetDataByMemberId(Convert.ToInt32(LUEEmp.EditValue)).Rows[0];
                Update(row);
                row.MemberId = Convert.ToInt32(LUEEmp.EditValue);
                Update(row);
                
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
                //if (Misc.Misc.CalcAge(row.BirthDate) >= 45 && row.NewMember)
                //{
                //    Program.Logger.LogThis("لا يجب ادخال عضو اكبر من 45 سنة", Text, FXFW.Logger.OpType.fail, null, null, this);
                //    return;
                //}
                tblMembersTableAdapter.Update((DataSources.dsTeachersUnion.TBLMembersDataTable)row.Table);

                //Update Member Aksat
                if (row.Installment && row.RowState != DataRowState.Detached)
                    UpdateAksat(row.MemberId);

                //Update Member Remarks
                tBLMemberRemarkTableAdapter.Update(dsTeachersUnion.TBLMemberRemark);
                Program.ShowMsg("تم الاضافه", false, this);
                Program.ShowMsg("تم التعديل", false, this);
                //Program.Logger.LogThis("تم التعديل", Text, FXFW.Logger.OpType.success, null, null, this);

                btnNew_Click(btnNew, new EventArgs());
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (LUEEmp.EditValue == null)
                return;
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            try
            {
                tblMembersTableAdapter.Delete(Convert.ToInt32(LUEEmp.EditValue));
                if (File.Exists(peImg.FileName))
                    File.Delete(peImg.FileName);
                Program.ShowMsg("تم الحذف", false, this);
                Program.Logger.LogThis("تم الحذف", Text, FXFW.Logger.OpType.success, null, null, this);
                btnNew_Click(btnNew, new EventArgs());
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        void TBLMembersFast2Frm_Disposed(object sender, EventArgs e)
        {
            //if (LUEEmp.Properties.DataSource.GetType() == typeof(DataTable))
            //{
            //    ((DataTable)LUEEmp.Properties.DataSource).Rows.Clear();
            //    ((DataTable)LUEEmp.Properties.DataSource).Dispose();
            //}
            GC.Collect();
        }
        private void gridViewRemark_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataSources.dsTeachersUnion.TBLMemberRemarkRow row = (DataSources.dsTeachersUnion.TBLMemberRemarkRow)gridViewRemark.GetDataRow(e.RowHandle);
            row.MemberId = Convert.ToInt32(LUEEmp.EditValue);
             object id = dsTeachersUnion.TBLMemberRemark.Compute("Max(remarkid) + 1", "");
             if (id == DBNull.Value)
                 id = 1;
             row.remarkid = Convert.ToInt64(id);
            row.datein = SQLProvider.GetServerDateTime();
            row.userin = Program.UserInfo.UserId;
        }
        private void repositoryItemButtonEditRemarkDel_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            //DataSources.dsTeachersUnion.TBLMemberRemarkRow row = (DataSources.dsTeachersUnion.TBLMemberRemarkRow)gridViewRemark.GetDataRow(gridViewRemark.FocusedRowHandle);
            //dsTeachersUnion.TBLMemberRemark.RemoveTBLMemberRemarkRow(row);
            gridViewRemark.DeleteRow(gridViewRemark.FocusedRowHandle);
        }
        private void Update(DataSources.dsTeachersUnion.TBLMembersRow row)
        {
            if (tbMemberName.EditValue != null)
                row.MemberName = tbMemberName.EditValue.ToString();
            else
                row.MemberName = string.Empty;
            if (tbKideNumber.EditValue != null)
                row.KideNumber = Convert.ToInt32(tbKideNumber.EditValue);
            if (LUESyndicateId.EditValue != null)
                row.SyndicateId = Convert.ToInt32(LUESyndicateId.EditValue);
            if (LUESubCommitteId.EditValue != null)
                row.SubCommitteId = Convert.ToInt32(LUESubCommitteId.EditValue);
            else
                row.SetSubCommitteIdNull();
            row.img = Program.imgPath + tbKideNumber.EditValue + Program.imgExt;
            if (LUEJobtitleID.EditValue != null)
                row.JobtitleID = Convert.ToInt32(LUEJobtitleID.EditValue);
            else
                row.SetJobtitleIDNull();
            if (!FXFW.SqlDB.IsNullOrEmpty(tbesalno.EditValue))
                row.esalno = Convert.ToInt32(tbesalno.EditValue);
            else
                row.SetesalnoNull();
            if (tbtype.EditValue != null)
                row.cardtype = Convert.ToByte(tbtype.EditValue);
            else
                row.SetcardtypeNull();
            if (dedateend.EditValue != null)
                row.dateend = Convert.ToDateTime(dedateend.EditValue);
            else
                row.SetdateendNull();

            if (ceInstallment.EditValue != null)
                row.Installment = ceInstallment.Checked;
            else
                row.SetInstallmentNull();

            row.fawry = cefawry.Checked;

            if (tbMemberMobil.EditValue != null)
                row.MemberMobil = tbMemberMobil.EditValue.ToString();
            else
                row.MemberMobil = string.Empty;

            if (tbMemberNId.EditValue != null)
            {
                row.MemberNId = tbMemberNId.EditValue.ToString();
                List<object> ID = Misc.Misc.IDExtraction(tbMemberNId.EditValue.ToString());
                if (ID.Count == 3)
                {
                    row.MemberGender = Convert.ToByte(ID[0]);
                    row.BirthDate = Convert.ToDateTime(ID[1]);
                    //row.MemberaddresGov = Convert.ToByte(ID[2]);
                }
            }

            if (row.RowState == DataRowState.Detached)
            {
                row.RandomCard = new Random().Next(100, 999).ToString();
                row.MemberShipNumber = (int)tblMembersTableAdapter.ScalarQueryNewMemberShipNumber();
                row.NewMember = true;
            }
            else
            {
                if (row.IsMemberShipNumberNull())
                    row.MemberShipNumber = (int)tblMembersTableAdapter.ScalarQueryNewMemberShipNumber();

                if (cemEdited.Checked == true)
                {
                    row.mEdited = true;
                    row.userEdit = row.userin;
                }
            }
            row.userin = Program.UserInfo.UserId;

        }
        private void UpdateAksat(int MemberId)
        {
            try
            {
                tblAksatTableAdapter.FillByMemberId(dsTeachersUnion.TBLAksat, MemberId);
                DataSources.dsTeachersUnion.TBLAksatRow rowSub;
                if (dsTeachersUnion.TBLAksat.Rows.Count == 0)
                {
                    rowSub = dsTeachersUnion.TBLAksat.NewTBLAksatRow();
                    rowSub.MemberId = MemberId;
                }
                else
                {
                    rowSub = dsTeachersUnion.TBLAksat[0];
                    rowSub.MemberId = MemberId;
                }

                if (!FXFW.SqlDB.IsNullOrEmpty(dekestenddate.EditValue))
                    rowSub.kestenddate = dekestenddate.DateTime;
                if (!FXFW.SqlDB.IsNullOrEmpty(tbmostahk.EditValue))
                    rowSub.mostahk = Convert.ToInt32(tbmostahk.EditValue);
                if (!FXFW.SqlDB.IsNullOrEmpty(tbmadfoaa.EditValue))
                    rowSub.madfoaa = Convert.ToInt32(tbmadfoaa.EditValue);
                if (!FXFW.SqlDB.IsNullOrEmpty(tbesalnoIns.EditValue))
                    rowSub.esalno = tbesalnoIns.EditValue.ToString();
                if (!FXFW.SqlDB.IsNullOrEmpty(deesaldate.EditValue))
                    rowSub.esaldate = deesaldate.DateTime;

                rowSub.userin = Program.UserInfo.UserId;
                rowSub.datein = SQLProvider.GetServerDateTime();
                if (rowSub.RowState == DataRowState.Detached)
                    dsTeachersUnion.TBLAksat.AddTBLAksatRow(rowSub);

                tblAksatTableAdapter.Update(dsTeachersUnion.TBLAksat);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
            
        }
        private void tbKideNumber_EditValueChanged(object sender, EventArgs e)
        {
            if (openFile.FileName == string.Empty || !btnSave.Enabled || tbKideNumber.EditValue == string.Empty)
                return;
            string FolderPath = Path.GetDirectoryName(openFile.FileName);
            string FileName = FolderPath + "\\" + tbKideNumber.EditValue + Program.imgExt;
            if (File.Exists(FileName))
            {
                peImg.Image = Image.FromFile(FileName);
            }
            else
            {
                peImg.EditValue = null;
            }
        }
        private void tbesalno_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            switch (e.Button.Kind)
            {
                case  ButtonPredefines.Plus:
                    ReceiptsFrm frm = new ReceiptsFrm();
                    frm.ShowDialog();
                    this.receiptsListTableAdapter.Fill(this.dsTeachersUnionQuery.ReceiptsList);        
                    break;
            }
        }
        private void tbesalno_LostFocus(object sender, EventArgs e)
        {
            if (FXFW.SqlDB.IsNullOrEmpty(tbesalno.EditValue))
                return;
            if (tbesalno.GetSelectedDataRow() == null)
            {
                Program.Logger.LogThis("ايصال غير مدرج", Text, FXFW.Logger.OpType.fail, null, null, this);
                tbesalno.EditValue = null;
                return;
            }
            //DataSources.dsTeachersUnionQuery.ReceiptsListRow row = (DataSources.dsTeachersUnionQuery.ReceiptsListRow)((DataRowView)tbesalno.GetSelectedDataRow()).Row;
            //int esalnoCount = (int)tblMembersTableAdapter.ScalarQueryesalnoCount(row.ReceiptNo);
            //if (row.CardsCount <= esalnoCount)
            //{
            //    tbesalno.EditValue = null;
            //    Program.Logger.LogThis("تم استيفاء عدد هذا الايصال", Text, FXFW.Logger.OpType.fail, null, null, this);
            //}
        }
        void tbKideNumber_LostFocus(object sender, EventArgs e)
        {
            if (FXFW.SqlDB.IsNullOrEmpty(tbKideNumber.EditValue))
                return;
            if (LUEEmp.EditValue == null)
            {
                if (tblMembersTableAdapter.ScalarQueryExistsKideNumber(Convert.ToInt32(tbKideNumber.EditValue)) > 0)
                    Program.Logger.LogThis("رقم القيد موجود مسبقا", Text, FXFW.Logger.OpType.fail, null, null, this);
            }
            else
            {
                if (tblMembersTableAdapter.ScalarQueryExistsKideNumber_MemberId(Convert.ToInt32(tbKideNumber.EditValue), Convert.ToInt32(LUEEmp.EditValue)) > 0)
                    Program.Logger.LogThis("رقم القيد موجود مسبقا", Text, FXFW.Logger.OpType.fail, null, null, this);
            }
           
        }
        private void cbUnMember_Click(object sender, EventArgs e)
        {
            if (FXFW.SqlDB.IsNullOrEmpty(LUEEmp.EditValue))
                return;
            string msg = string.Empty;
            if (cbUnMember.Checked)
                msg = "هل ترغب في تفعيل العضو؟";
            else
                msg = "هل ترغب في ايقاف العضو؟";
            cbUnMember.Checked = !cbUnMember.Checked;
            if (MessageBox.Show(msg, "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
            {
                cbUnMember.Checked = !cbUnMember.Checked;
                return;
            }
            if (FXFW.SqlDB.IsNullOrEmpty(LUEEmp.EditValue))
                return;

            tblMembersTableAdapter.UpdateQueryUnMember(cbUnMember.Checked, Convert.ToInt32(LUEEmp.EditValue));
            LUEEmp_EditValueChanged(LUEEmp, EventArgs.Empty);
        }
        private void cbUnMember_CheckedChanged(object sender, EventArgs e)
        {
            if (cbUnMember.Checked)
                cbUnMember.Text = "تفعيل العضو";
            else
                cbUnMember.Text = "ايقاف العضو";
        }

        #endregion
    }
   
    // Represents a custom validation rule.
    public class CustomValidationRule : ValidationRule
    {
        public override bool Validate(Control control, object value)
        {
            bool valid = false;
            if (value != null)
            {
                if (value.ToString() != string.Empty && value.ToString().Length == 14)
                {
                    valid = true;
                }
            }
            return valid;
        }
    }

}