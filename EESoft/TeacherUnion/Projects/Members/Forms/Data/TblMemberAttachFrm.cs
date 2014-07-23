using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraSplashScreen;

namespace Members
{
    public partial class TblMemberAttachFrm : DevExpress.XtraEditors.XtraForm
    {
        int MemberId = 0;
        string openfileDlgPath = string.Empty;
        public TblMemberAttachFrm()
        {
            InitializeComponent();
        }
        public TblMemberAttachFrm(int memberId)
        {
            InitializeComponent();
            MemberId = memberId;
        }
        private void PrepareImagelist()
        {
            repositoryItemImageComboBox1.SmallImages = imageCollection1;
            foreach (DataRow row in dsTeachersUnion.CDAttachmentType.Rows)
            {
                Byte[] image = row["AttachmentImg"] as Byte[];
                if (image == null)
                    return;
                MemoryStream imgStream = new MemoryStream(image);
                Image img = Image.FromStream(imgStream);
                imageCollection1.AddImage(img);
                repositoryItemImageComboBox1.Items.Add(new ImageComboBoxItem(Convert.ToString(row["AttachmentName"]), Convert.ToString(row["AttachmentTypeId"]), imageCollection1.Images.Count - 1));
            }
        }
        private void ActivePriv()
        {
            return;//ActivePrivReady
            bool Selecting = false, Inserting = false, Updateing = false, Deleting = false;
            SQLProvider.GetFormPriv(this.Name, ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
            gridControlData.Visible = Selecting;
            LUEMembers.Visible = Selecting;

            if (Inserting || Updateing)
                repositoryItemButtonEditEdit.Buttons[0].Visible = true;
            else
                repositoryItemButtonEditEdit.Buttons[0].Visible = false;
            repositoryItemButtonEditDel.Buttons[0].Visible = Deleting;
        }
        private void MemberAttachFrm_Load(object sender, EventArgs e)
        {
            ActivePriv();
            // TODO: This line of code loads data into the 'dsTeachersUnion.CDAttachmentType' table. You can move, or remove it, as needed.
            this.cDAttachmentTypeTableAdapter.Fill(this.dsTeachersUnion.CDAttachmentType);
            LSMSMembers.QueryableSource = new DataSources.Linq.dsTeachersUnionViewsDataContext().vTBLMembersPlusTblMemberAttaches;
            LUEMembers.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
            //PrepareImagelist();
            if (MemberId != 0)
            {
                LUEMembers.EditValue = MemberId;
                gcOptions.Enabled = false;
            }
        }
        private void btnPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                ofd.InitialDirectory = fbd.SelectedPath;
        }
        private void LUEMembers_EditValueChanged(object sender, EventArgs e)
        {
            peimg.EditValue = null;
            peimg.Refresh();

            SplashScreenManager.ShowForm(typeof(Forms.Main.WaitWindowFrm));
            try
            {
                this.Invoke(new MethodInvoker(() =>
                {
                    if (LUEMembers.EditValue == null)
                    {
                        lblesalno.Text = string.Empty;
                        lblKideNumber.Text = string.Empty;
                        lblSyndicate.Text = string.Empty;
                        return;
                    }
                    DataSources.Linq.vTBLMembersPlusTblMemberAttach row = (DataSources.Linq.vTBLMembersPlusTblMemberAttach)LUEMembers.GetSelectedDataRow();
                    if (row == null)
                    {
                        gcDetails.Enabled = false;
                        return;
                    }
                    else
                        gcDetails.Enabled = true;
                    Clipboard.SetText(row.KideNumber.ToString(), TextDataFormat.Text);

                    tblMemberAttachTableAdapter.FillByMemberId(dsTeachersUnion.TblMemberAttach, row.MemberId);

                    lblesalno.Text = row.esalno.ToString();
                    lblKideNumber.Text = row.KideNumber.ToString();
                    lblSyndicate.Text = row.Syndicate;

                    if (File.Exists(row.img))
                    {
                        using (MemoryStream ms = new MemoryStream(File.ReadAllBytes(row.img)))
                        {
                            peimg.Image = Image.FromStream(ms);
                        }
                    }


                }));
            }
            catch (Exception ex)
            {
                Program.ShowMsg(Misc.Misc.ExceptionMessage(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, ex, null, this);
            }
            SplashScreenManager.CloseForm();
        }
        private void gridViewData_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            DataRowView DRV = (DataRowView)e.Row;
            //Fellowship.DataSources.DSFellowship.TBLSheekWaredRow row = (Fellowship.DataSources.DSFellowship.TBLSheekWaredRow)DRV.Row;

            if (e.ErrorText.Contains("AttachName"))
            {
                e.ErrorText = "من فضلك بجب اختيار مرفق";
                return;
            }
            if (e.ErrorText.Contains("AttachId"))
            {
                //e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
                DRV["AttachId"] = "-1";
                return;
            }
        }
        private void repositoryItemPictureEditAttachName_Click(object sender, EventArgs e)
        {
            PictureEdit pb = (PictureEdit)sender;
            DataRow row = gridViewData.GetFocusedDataRow();
            if (row == null || row["AttachName"].ToString() == string.Empty)
                return;
            if (!File.Exists(row["AttachName"].ToString()))
                return;
            pb.Image = Image.FromFile(row["AttachName"].ToString());
        }
        private void repositoryItemButtonEditEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (LUEMembers.EditValue == null)
            {
                Program.ShowMsg("من فضلك اختر عضو", true, this);
                return;
            }
            DevExpress.XtraGrid.Views.Grid.GridView GV = (DevExpress.XtraGrid.Views.Grid.GridView)gridControlData.MainView;
            DataSources.dsTeachersUnion.TblMemberAttachRow row = (DataSources.dsTeachersUnion.TblMemberAttachRow)GV.GetFocusedDataRow();
            DataSources.Linq.vTBLMembersPlusTblMemberAttach member = (DataSources.Linq.vTBLMembersPlusTblMemberAttach)LUEMembers.GetSelectedDataRow();
            if (row == null)
                row = dsTeachersUnion.TblMemberAttach.NewTblMemberAttachRow();

            switch (e.Button.Kind)
            {
                case DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis:
                    if (row.IsAttachmentTypeIdNull())
                    {
                        Program.ShowMsg("من فضلك اختر نوع الملف اولا", true, this);
                        return;
                    }
                    //ofd.Filter = string.Format("{0}|*{0}*|All Files|*.*", member.KideNumber);
                    //ofd.FileOk += ofd_FileOk;
                    if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                        return;
                    if (row.RowState == DataRowState.Detached)
                    {
                        string Ext = cDAttachmentTypeTableAdapter.ScalarQueryAttachmentExt(row.AttachmentTypeId);
                        int counter = 0;
                        while (true)
                        {
                            counter++;
                            if (File.Exists(String.Format("{0}{1}-{2}.{3}", Program.attachPath, member.KideNumber, counter, Ext)))
                                continue;
                            File.Copy(ofd.FileName, String.Format("{0}{1}-{2}.{3}", Program.attachPath, member.KideNumber, counter, Ext));
                            row.AttachName = String.Format("{0}{1}-{2}.{3}", Program.attachPath, member.KideNumber, counter, Ext);
                            break;
                        }
                    }
                    else
                        File.Copy(ofd.FileName, row.AttachName, true);
                    Update(row, true);
                    break;
                case DevExpress.XtraEditors.Controls.ButtonPredefines.OK:
                    Update(row);
                    break;
                case DevExpress.XtraEditors.Controls.ButtonPredefines.Up:
                    if (File.Exists(row.AttachName))
                        System.Diagnostics.Process.Start(row.AttachName);
                    else
                        Program.ShowMsg("الملف غير موجود", true, this);
                    break;
                default:
                    break;
            }
        }
        private void repositoryItemButtonEditDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView GV = (DevExpress.XtraGrid.Views.Grid.GridView)gridControlData.MainView;
            DataSources.dsTeachersUnion.TblMemberAttachRow row = (DataSources.dsTeachersUnion.TblMemberAttachRow)GV.GetFocusedDataRow();

            if (row.RowState == DataRowState.Detached)
                return;

            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            try
            {
                tblMemberAttachTableAdapter.Delete(row.AttachId);
                if (File.Exists(row.AttachName))
                    File.Delete(row.AttachName);
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
        private void Update(DataSources.dsTeachersUnion.TblMemberAttachRow row, bool noDLG = false)
        {
            try
            {
                if (row.RowState == DataRowState.Detached)
                {
                    row.AttachId = Convert.ToInt32(FXFW.SqlDB.GetNewID("TblMemberAttach", "AttachId"));
                    row.MemberId = Convert.ToInt32(LUEMembers.EditValue);
                    dsTeachersUnion.TblMemberAttach.AddTblMemberAttachRow(row);
                }
                tblMemberAttachBindingSource.EndEdit();
                tblMemberAttachTableAdapter.Update(row);
                dsTeachersUnion.TblMemberAttach.AcceptChanges();

                Program.ShowMsg("تم الحفظ", false, this);
                if (!noDLG)
                    Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (Exception ex)
            {
                Program.ShowMsg(Misc.Misc.ExceptionMessage(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, ex, null, this);
            }
        }

        
    
    }
}