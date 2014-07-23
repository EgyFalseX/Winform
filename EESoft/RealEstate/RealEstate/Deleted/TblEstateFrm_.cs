using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.OleDb;
using System.IO;

namespace RealEstate
{
    public partial class TblEstateFrm_ : XtraForm
    {
        #region -   Variables   -
        DataTable GridTable = new DataTable("FalseX2011-07");
        #endregion
        #region -   Functions   -
        public TblEstateFrm_()
        {
            InitializeComponent();
        }
        public void LoadDefaultData()
        {
            LoadOwner();
            repositoryItemGridLookUpEditTypeEstateId.DataSource = MyCL.LoadDataTable("Select TypeEstateId, TypeEstate From CdTypeEstate");
            repositoryItemGridLookUpEditTypeEstateId.ValueMember = "TypeEstateId";
            repositoryItemGridLookUpEditTypeEstateId.DisplayMember = "TypeEstate";

            repositoryItemGridLookUpEditEstateCaseId.DataSource = MyCL.LoadDataTable("Select EstateCaseId, EstateCase From CdEstateCase");
            repositoryItemGridLookUpEditEstateCaseId.ValueMember = "EstateCaseId";
            repositoryItemGridLookUpEditEstateCaseId.DisplayMember = "EstateCase";

            repositoryItemGridLookUpEditCdAreaId.DataSource = MyCL.LoadDataTable("Select CdAreaId, CdArea From CdArea");
            repositoryItemGridLookUpEditCdAreaId.ValueMember = "CdAreaId";
            repositoryItemGridLookUpEditCdAreaId.DisplayMember = "CdArea";
        }
        private void LoadOwner()
        {
            repositoryItemGridLookUpEditOwnerId.DataSource = MyCL.LoadDataTable("Select OwnerId, Owner From TblOwner");
            repositoryItemGridLookUpEditOwnerId.ValueMember = "OwnerId";
            repositoryItemGridLookUpEditOwnerId.DisplayMember = "Owner";
        }
        public void LoadData()
        {
            GridTable = new DataTable("FalseX2011-07");
            GridTable = MyCL.LoadDataTable(@"SELECT EstateId, OwnerId, sakfrom, sakno, Format(sakdate, 'dd/mm/yyyy') AS sakdate, TypeEstateId, EstateCaseId, EstateAge, CdAreaId,
            EstateAdderss, StreetNo, HadShmal, Tallshmal, HadGanob, TallGanob, Hadshark, Tallshark, Hadghrab, Tallghrab, Aera, Metrprice, AllPrice, remark, imagepath1, imagepath2,
            datein, userin FROM TblEstate");
            gridControlMain.DataSource = GridTable;
            gridControlMain.RefreshDataSource();
        }

#endregion
        #region -   Event Handlers   -
        private void FrmCdBankAccount_Load(object sender, EventArgs e)
        {
            LoadDefaultData();
            LoadData();
        }
        private void repositoryItemGridLookUpEditOwnerId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            Form Frm = (Form)ParentForm;
            TblOwnerFrm Owner = new TblOwnerFrm();
            Frm.Opacity = 0.3;
            Owner.ShowDialog(Frm);
            Frm.Opacity = 1;
            LoadOwner();
            Owner.Dispose();
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزيــــر", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            DataRow Row = (DataRow)gridViewMain.GetFocusedDataRow();
            OleDbConnection con = new OleDbConnection(MyCL.AccConStr);
            OleDbCommand cmd = new OleDbCommand("", con);
            string OwnerId;
            if (Row["OwnerId"].ToString() != string.Empty)
                OwnerId = Row["OwnerId"].ToString();
            else
                OwnerId = "NULL";
            string TypeEstateId;
            if (Row["TypeEstateId"].ToString() != string.Empty)
                TypeEstateId = Row["TypeEstateId"].ToString();
            else
                TypeEstateId = "NULL";
            string EstateCaseId;
            if (Row["EstateCaseId"].ToString() != string.Empty)
                EstateCaseId = Row["EstateCaseId"].ToString();
            else
                EstateCaseId = "NULL";
            string CdAreaId;
            if (Row["CdAreaId"].ToString() != string.Empty)
                CdAreaId = Row["CdAreaId"].ToString();
            else
                CdAreaId = "NULL";
            string sakdate;
            if (Row["sakdate"].ToString() != string.Empty)
                sakdate = String.Format("Format('{0}', 'dd/mm/yyyy')", Row["sakdate"].ToString());
            else
                sakdate = "NULL";
            string EstateAge;
            if (Row["EstateAge"].ToString() != string.Empty)
                EstateAge = Row["EstateAge"].ToString();
            else
                EstateAge = "0";
            string StreetNo;
            if (Row["StreetNo"].ToString() != string.Empty)
                StreetNo = Row["StreetNo"].ToString();
            else
                StreetNo = "0";
            string Tallshmal;
            if (Row["Tallshmal"].ToString() != string.Empty)
                Tallshmal = Row["Tallshmal"].ToString();
            else
                Tallshmal = "0";
            string TallGanob;
            if (Row["TallGanob"].ToString() != string.Empty)
                TallGanob = Row["TallGanob"].ToString();
            else
                TallGanob = "0";
            string Tallshark;
            if (Row["Tallshark"].ToString() != string.Empty)
                Tallshark = Row["Tallshark"].ToString();
            else
                Tallshark = "0";
            string Tallghrab;
            if (Row["Tallghrab"].ToString() != string.Empty)
                Tallghrab = Row["Tallghrab"].ToString();
            else
                Tallghrab = "0";
            string Aera;
            if (Row["Aera"].ToString() != string.Empty)
                Aera = Row["Aera"].ToString();
            else
                Aera = "0";
            string Metrprice;
            if (Row["Metrprice"].ToString() != string.Empty)
                Metrprice = Row["Metrprice"].ToString();
            else
                Metrprice = "0";
            string AllPrice;
            if (Row["AllPrice"].ToString() != string.Empty)
                AllPrice = Row["AllPrice"].ToString();
            else
                AllPrice = "0";
            try
            {
                if (Row["EstateId"].ToString() == string.Empty)// Is Unsaved Row?
                {
                    string NewID = MyCL.GetNewID("TblEstate", "EstateId");
                    cmd.CommandText = string.Format(@"INSERT INTO TblEstate (EstateId, OwnerId, sakfrom, sakno, sakdate, TypeEstateId, EstateCaseId, EstateAge, CdAreaId, EstateAdderss, StreetNo, HadShmal, Tallshmal, HadGanob, 
                    TallGanob, Hadshark, Tallshark, Hadghrab, Tallghrab, Aera, Metrprice, AllPrice, remark, imagepath1, imagepath2, datein, userin) VALUES        
                    ({0}, {1}, '{2}', '{3}', {4}, {5}, {6}, {7}, {8}, '{9}', {10}, '{11}', {12}, '{13}', {14}, '{15}', {16}, '{17}', {18}, {19}, {20}, {21}, '{22}', '{23}', '{24}', NOW(), {25})", NewID, OwnerId, MyCL.CleanSQLValue(Row["sakfrom"].ToString()),
                    MyCL.CleanSQLValue(Row["sakno"].ToString()), sakdate, TypeEstateId, EstateCaseId, EstateAge, CdAreaId, MyCL.CleanSQLValue(Row["EstateAdderss"].ToString()), StreetNo, MyCL.CleanSQLValue(Row["HadShmal"].ToString()), Tallshmal,
                    MyCL.CleanSQLValue(Row["HadGanob"].ToString()), TallGanob, MyCL.CleanSQLValue(Row["Hadshark"].ToString()), Tallshark, MyCL.CleanSQLValue(Row["Hadghrab"].ToString()), Tallghrab, Aera, Metrprice, AllPrice, MyCL.CleanSQLValue(Row["remark"].ToString()),
                    MyCL.CleanSQLValue(Row["imagepath1"].ToString()), MyCL.CleanSQLValue(Row["imagepath2"].ToString()), MyCL.UserInfo.UserID);
                }
                else
                {
                    cmd.CommandText = string.Format(@"UPDATE TblEstate SET OwnerId = {0}, sakfrom = '{1}', sakno = '{2}', sakdate = {3}, TypeEstateId = {4}, EstateCaseId = {5}, EstateAge = {6}, CdAreaId = {7}, EstateAdderss = '{8}', StreetNo = {9}, 
                    HadShmal = '{10}', Tallshmal = {11}, HadGanob = '{12}', TallGanob = {13}, Hadshark = '{14}', Tallshark = {15}, Hadghrab = '{16}', Tallghrab = {17}, Aera = {18}, Metrprice = {19}, AllPrice = {20},  remark = '{21}', imagepath1 = '{22}', imagepath2 = '{23}', datein = NOW(), 
                    userin = {24} WHERE (TblEstate.EstateId = {25})", OwnerId, MyCL.CleanSQLValue(Row["sakfrom"].ToString()),
                    MyCL.CleanSQLValue(Row["sakno"].ToString()), sakdate, TypeEstateId, EstateCaseId, EstateAge, CdAreaId, MyCL.CleanSQLValue(Row["EstateAdderss"].ToString()), StreetNo, MyCL.CleanSQLValue(Row["HadShmal"].ToString()), Tallshmal,
                    MyCL.CleanSQLValue(Row["HadGanob"].ToString()), TallGanob, MyCL.CleanSQLValue(Row["Hadshark"].ToString()), Tallshark, MyCL.CleanSQLValue(Row["Hadghrab"].ToString()), Tallghrab, Aera, Metrprice, AllPrice, MyCL.CleanSQLValue(Row["remark"].ToString()),
                    MyCL.CleanSQLValue(Row["imagepath1"].ToString()), MyCL.CleanSQLValue(Row["imagepath2"].ToString()), MyCL.UserInfo.UserID, Row["EstateId"]);
                }
                con.Open();
                cmd.ExecuteNonQuery();
                MyCL.ShowMsg("تم الحفظ", false, this);
            }
            catch (OleDbException ex)
            {
                MyCL.ShowMsg(ex.Message , true, this);
            }
            con.Close();
            LoadData();
            
        }
        private void repositoryItemButtonEditDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزيــــر", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            DataRow Row = (DataRow)gridViewMain.GetFocusedDataRow();
            if (Row["EstateId"].ToString() == string.Empty)// Is Unsaved Row?
            {
                LoadData();
                return;
            }
            OleDbConnection con = new OleDbConnection(MyCL.AccConStr);
            OleDbCommand cmd = new OleDbCommand("", con);
            try
            {
                cmd.CommandText = @"Delete From TblEstate Where EstateId = " + Row["EstateId"];
                con.Open();
                cmd.ExecuteNonQuery();
                MyCL.ShowMsg("تم الحذف", false, this);
            }
            catch (OleDbException ex)
            {
                MyCL.ShowMsg(ex.Message , true, this);
            }
            con.Close();
            LoadData();
        }
        #endregion

        private void repositoryItemButtonEditimagepath1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ButtonEdit btn = (ButtonEdit)sender;
            DataRow Row = (DataRow)gridViewMain.GetFocusedDataRow();
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis)
            {
                OpenFileDialog dlg = new OpenFileDialog() { CheckFileExists = true, Filter = "Jpg Files|*.jpg|All Files(*)|*.*", Title = "اختار صوره" };
                if (dlg.ShowDialog() == DialogResult.Cancel)
                    return;
                try
                {
                    Image TmpImg = Image.FromFile(dlg.FileName);
                    TmpImg = null;
                }
                catch { return; }
                string NewFileName = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + dlg.SafeFileName;
                File.Copy(dlg.FileName, MyCL.PicPath + NewFileName);
                Row["imagepath1"] = NewFileName;
            }
            else
            {
                using (ImgViewerFrm Frm = new ImgViewerFrm())
                {
                    if (File.Exists(MyCL.PicPath + btn.EditValue))
                        Frm.Img.Image = Image.FromFile(MyCL.PicPath + btn.EditValue);
                    Frm.ShowDialog();
                }
            }
        }

        private void repositoryItemButtonEditimagepath2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ButtonEdit btn = (ButtonEdit)sender;
            DataRow Row = (DataRow)gridViewMain.GetFocusedDataRow();
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis)
            {
                OpenFileDialog dlg = new OpenFileDialog() { CheckFileExists = true, Filter = "Jpg Files|*.jpg|All Files(*)|*.*", Title = "اختار صوره" };
                if (dlg.ShowDialog() == DialogResult.Cancel)
                    return;
                try
                {
                    Image TmpImg = Image.FromFile(dlg.FileName);
                    TmpImg = null;
                }
                catch { return; }
                string NewFileName =DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + dlg.SafeFileName; 
                File.Copy(dlg.FileName, MyCL.PicPath + NewFileName);
                Row["imagepath2"] = NewFileName;
            }
            else
            {
                using (ImgViewerFrm Frm = new ImgViewerFrm())
                {
                    if (File.Exists(MyCL.PicPath + btn.EditValue))
                        Frm.Img.Image = Image.FromFile(MyCL.PicPath + btn.EditValue);
                    Frm.ShowDialog();
                }

            }
        }

        
    }
}