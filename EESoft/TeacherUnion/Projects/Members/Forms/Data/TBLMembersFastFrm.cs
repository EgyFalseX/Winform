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
using System.Drawing.Imaging;
using System.IO;
using DevExpress.XtraEditors.Repository;

namespace Members
{
    public partial class TBLMembersFastFrm : DevExpress.XtraEditors.XtraForm
    {

        #region -   Functions   -
        
        public TBLMembersFastFrm()
        {
            InitializeComponent();
        }
        private void LoadDefaultData()
        {
            //CDSyndicate
            repositoryItemGridLookUpEditSyndicateId.DataSource = SQLProvider.SelectCDSyndicate();
            repositoryItemGridLookUpEditSyndicateId.DisplayMember = "Syndicate";
            repositoryItemGridLookUpEditSyndicateId.ValueMember = "SyndicateId";
            //CDSubCommitte
            repositoryItemGridLookUpEditSubCommitteId.DataSource = SQLProvider.SelectCDSubCommitte();
            repositoryItemGridLookUpEditSubCommitteId.DisplayMember = "SubCommitte";
            repositoryItemGridLookUpEditSubCommitteId.ValueMember = "SubCommitteId";
            //CDJobtitle
            repositoryItemGridLookUpEditJobtitleID.DataSource = SQLProvider.SelectCDJobtitle();
            repositoryItemGridLookUpEditJobtitleID.DisplayMember = "Jobtitle";
            repositoryItemGridLookUpEditJobtitleID.ValueMember = "JobtitleID";
        }
        private void LoadGrid()
        {
            gridControlData.DataSource = SQLProvider.SelectTBLMembersFast();
        }
        private string GetNewFolderPath_Delete()
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
            return;//ActivePrivReady
            bool Selecting = false, Inserting = false, Updateing = false, Deleting = false;
            SQLProvider.GetFormPriv(this.Name, ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
            gridControlData.Visible = Selecting;
            if (Inserting || Updateing)
                repositoryItemButtonEditSave.Buttons[0].Visible = true;
            else
                repositoryItemButtonEditSave.Buttons[0].Visible = false;
            repositoryItemButtonEditDel.Buttons[0].Visible = Deleting;
        }
        #endregion
        #region - Event Handlers -
        private void TBLMembersFastFrm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("تم ايقاف هذا النموزج");
            Close();

            ActivePriv();
            LoadDefaultData();
            LoadGrid();
            this.Disposed += TBLMembersFastFrm_Disposed;
        }
        void TBLMembersFastFrm_Disposed(object sender, EventArgs e)
        {
            if (gridControlData.DataSource.GetType() == typeof(DataTable))
            {
                ((DataTable)gridControlData.DataSource).Rows.Clear();
                ((DataTable)gridControlData.DataSource).Dispose();
            }
            GC.Collect();
        }
        private void repositoryItemGridLookUpEditJobtitleID_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            CodeFrm FrmCode = new CodeFrm(CodeFrm.TableNames.CDJobtitle);
            FrmCode.ShowDialog();
            LoadDefaultData();
        }
        private void repositoryItemPictureEditimg_Click(object sender, EventArgs e)
        {
            DataRow row = gridViewData.GetFocusedDataRow();
            if (!FXFW.SqlDB.IsNullOrEmpty(row["MemberId"]))
            {
                if (!FXFW.SqlDB.IsNullOrEmpty(row["Img"]))
                {
                    if (File.Exists(row["Img"].ToString()))
                    {
                        row["ImgData"] = File.ReadAllBytes(row["Img"].ToString());
                    }
                    gridViewData.RefreshRow(gridViewData.FocusedRowHandle);
                }
            }
        }
        private void repositoryItemPictureEditimg_DoubleClick(object sender, EventArgs e)
        {
            PictureEdit PE = (PictureEdit)sender;
            PE.LoadImage();
        }
        private void repositoryItemPictureEditimg_KeyDown(object sender, KeyEventArgs e)
        {
            PictureEdit PE = (PictureEdit)sender;
            DataRow row = gridViewData.GetFocusedDataRow();
            if (e.KeyCode == Keys.Enter)
                PE.LoadImage();
            else if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                    return;
                SQLProvider.UpdateTBLMembersImg(row["MemberId"], DBNull.Value);
                row["Img"] = DBNull.Value;
                PE.EditValue = null;
                Program.ShowMsg("تم الحذف", false, this);
                Program.Logger.LogThis("تم الحذف", Text, FXFW.Logger.OpType.success, null, null, this);
            }
        }
        private void repositoryItemPictureEditimg_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            DataRow row = gridViewData.GetFocusedDataRow();
            if (FXFW.SqlDB.IsNullOrEmpty(row["KideNumber"]))
            {
                MessageBox.Show("من فضلك ادخل رقم القيد قبل اختيار الصوره");
                return;
            }
            //const int ImgWidth = 54;
            //const int ImgHeight = 54;
            ImageFormat ImgFormat = ImageFormat.Jpeg;
            const int ImgMaxSize = 100 * 1024;

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

                    //if (File.Exists(Program.imgPath + row["KideNumber"] + ".jpg"))
                    //    File.Delete(Program.imgPath + row["KideNumber"] + ".jpg");

                    //img.Save(Program.imgPath + row["KideNumber"] + ".jpg", ImageFormat.Jpeg);
                }
            }
            finally
            {
                
                row["Img"] = Program.imgPath + row["KideNumber"] + Program.imgExt;
                if (e.Cancel)
                {
                    string msg = "حجم الصوره يجب ان يكون اصغر من 100 كيلوبايت " + "\n او نوع الصوره ليس" + "\n jpg";
                    MessageBox.Show(msg);
                }
            }
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataRow row = gridViewData.GetFocusedDataRow();
            if (FXFW.SqlDB.IsNullOrEmpty(row["KideNumber"]))
            {
                MessageBox.Show("يجب ادخال رقم القيد");
                return;
            }

            try
            {
                string Img = Program.imgPath + row["KideNumber"].ToString() + Program.imgExt;
                if (row["MemberId"].ToString() == string.Empty)
                {
                    if (!FXFW.SqlDB.IsNullOrEmpty(row["ImgData"]))
                    {
                        WriteToFile(Img, (byte[])row["ImgData"]);
                    }
                    else
                        Img = string.Empty;
                    row["MemberId"] = SQLProvider.InsertTBLMembers(row["MemberName"], row["SyndicateId"], row["SubCommitteId"], row["KideNumber"],
                        row["JobtitleID"], Img);
                }
                else
                {
                    if (!FXFW.SqlDB.IsNullOrEmpty(row["ImgData"]))
                    {
                        WriteToFile(Img, (byte[])row["ImgData"]);
                    }
                    else if (FXFW.SqlDB.IsNullOrEmpty(row["Img"]))
                        Img = string.Empty;

                    SQLProvider.UpdateTBLMembers(row["MemberId"], row["MemberName"], row["SyndicateId"], row["SubCommitteId"], row["KideNumber"],
                        row["JobtitleID"], Img);
                }
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
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            DataRow row = gridViewData.GetFocusedDataRow();
            if (row["MemberId"].ToString() == string.Empty)
            {
                LoadGrid();
                return;
            }
            try
            {
                SQLProvider.DeleteTBLMembers(row["MemberId"].ToString());
                if (File.Exists(row["img"].ToString()))
                    File.Delete(row["img"].ToString());

                Program.ShowMsg("تم الحذف", false, this);
                Program.Logger.LogThis("تم الحذف", Text, FXFW.Logger.OpType.success, null, null, this);
                gridViewData.DeleteRow(gridViewData.FocusedRowHandle);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(SqlDB.CheckExp(ex), true, this, true);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void WriteToFile(string FileName, byte[] byt)
        {
            if (File.Exists(FileName))
            {
                File.Delete(FileName);
            }
            File.WriteAllBytes(FileName, byt);
        }
        #endregion

    }
}