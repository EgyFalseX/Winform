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
    public partial class TblEstateFrm : XtraForm
    {
        #region -   Variables   -
        DataTable GridTable = new DataTable("FalseX2011-07");
        #endregion
        #region -   Functions   -
        public TblEstateFrm()
        {
            InitializeComponent();
        }
        public void LoadDefaultData()
        {
            LoadOwner();
            LoadArea();
            DataTable TypeEstateId = MyCL.LoadDataTable("Select TypeEstateId, TypeEstate From CdTypeEstate");
            LUEAddTypeEstateId.Properties.DataSource = TypeEstateId;
            LUEAddTypeEstateId.Properties.ValueMember = "TypeEstateId";
            LUEAddTypeEstateId.Properties.DisplayMember = "TypeEstate";
            LUEEditTypeEstateId.Properties.DataSource = TypeEstateId;
            LUEEditTypeEstateId.Properties.ValueMember = "TypeEstateId";
            LUEEditTypeEstateId.Properties.DisplayMember = "TypeEstate";

            DataTable EstateCaseId = MyCL.LoadDataTable("Select EstateCaseId, EstateCase From CdEstateCase");
            LUEAddEstateCaseId.Properties.DataSource = EstateCaseId;
            LUEAddEstateCaseId.Properties.ValueMember = "EstateCaseId";
            LUEAddEstateCaseId.Properties.DisplayMember = "EstateCase";
            LUEEditEstateCaseId.Properties.DataSource = EstateCaseId;
            LUEEditEstateCaseId.Properties.ValueMember = "EstateCaseId";
            LUEEditEstateCaseId.Properties.DisplayMember = "EstateCase";
            DataTable showId = MyCL.LoadDataTable("Select showId, show From cdshow");
            LUEAddshowId.Properties.DataSource = showId;
            LUEAddshowId.Properties.ValueMember = "showId";
            LUEAddshowId.Properties.DisplayMember = "show";
            LUEEditshowId.Properties.DataSource = showId;
            LUEEditshowId.Properties.ValueMember = "showId";
            LUEEditshowId.Properties.DisplayMember = "show";
        }
        private void LoadOwner()
        {
            DataTable OwnerId = MyCL.LoadDataTable("Select OwnerId, Owner From TblOwner");
            LUEAddOwnerId.Properties.DataSource = OwnerId;
            LUEAddOwnerId.Properties.ValueMember = "OwnerId";
            LUEAddOwnerId.Properties.DisplayMember = "Owner";
            LUEEditOwnerId.Properties.DataSource = OwnerId;
            LUEEditOwnerId.Properties.ValueMember = "OwnerId";
            LUEEditOwnerId.Properties.DisplayMember = "Owner";
        }
        private void LoadArea()
        {
            DataTable CdAreaId = MyCL.LoadDataTable("Select CdAreaId, CdArea From CdArea");
            LUEAddCdAreaId.Properties.DataSource = CdAreaId;
            LUEAddCdAreaId.Properties.ValueMember = "CdAreaId";
            LUEAddCdAreaId.Properties.DisplayMember = "CdArea";
            LUEEditCdAreaId.Properties.DataSource = CdAreaId;
            LUEEditCdAreaId.Properties.ValueMember = "CdAreaId";
            LUEEditCdAreaId.Properties.DisplayMember = "CdArea";
        }
        public void LoadData()
        {
            GridTable = new DataTable("FalseX2011-07");
            GridTable = MyCL.LoadDataTable(@"SELECT EstateId, showId, OwnerId, sakfrom, sakno, Format(sakdate, 'dd/mm/yyyy') AS sakdate, TypeEstateId, EstateCaseId, EstateAge, CdAreaId,
            EstateAdderss, StreetNo, HadShmal, Tallshmal, HadGanob, TallGanob, Hadshark, Tallshark, Hadghrab, Tallghrab, Aera, Metrprice, AllPrice, remark, imagepath1, imagepath2,
            datein, (Select Owner From TblOwner Where OwnerId = TblEstate.OwnerId) & ' / ' & (Select TypeEstate From CdTypeEstate Where TypeEstateId = TblEstate.TypeEstateId) & ' / ' & Aera AS Details, userin FROM TblEstate");
            LUEEstateId.Properties.DataSource = GridTable;
            LUEEstateId.Properties.DisplayMember = "Details";
            LUEEstateId.Properties.ValueMember = "EstateId";
        }

#endregion
        #region -   Event Handlers   -
        private void FrmCdBankAccount_Load(object sender, EventArgs e)
        {
            LoadDefaultData();
            LoadData();
        }
        private void LUEAddOwnerId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            Form Frm = (Form)ParentForm;
            TblOwnerFrm Owner = new TblOwnerFrm();
            Frm.Opacity = 0.3;
            Owner.ShowDialog(Frm);
            Frm.Opacity = 1;
            LoadOwner();
        }
        private void LUEAddCdAreaId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
                return;
            Form Frm = (Form)ParentForm;
            CdAreaFrm Area = new CdAreaFrm();
            Frm.Opacity = 0.3;
            Area.ShowDialog(Frm);
            Frm.Opacity = 1;
            LoadArea();
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(MyCL.AccConStr);
            OleDbCommand cmd = new OleDbCommand("", con);
            string OwnerId;
            if (LUEAddOwnerId.EditValue != null)
                OwnerId = LUEAddOwnerId.EditValue.ToString();
            else
                OwnerId = "NULL";
            string TypeEstateId;
            if (LUEAddTypeEstateId.EditValue != null)
                TypeEstateId = LUEAddTypeEstateId.EditValue.ToString();
            else
                TypeEstateId = "NULL";
            string EstateCaseId;
            if (LUEAddEstateCaseId.EditValue != null)
                EstateCaseId = LUEAddEstateCaseId.EditValue.ToString();
            else
                EstateCaseId = "NULL";
            string CdAreaId;
            if (LUEAddCdAreaId.EditValue != null)
                CdAreaId = LUEAddCdAreaId.EditValue.ToString();
            else
                CdAreaId = "NULL";
            string sakdate;
            if (DEAddsakdate.EditValue != null)
                sakdate = String.Format("Format('{0}', 'dd/mm/yyyy')", DEAddsakdate.Text);
            else
                sakdate = "NULL";
            string EstateAge;
            if (TxtAddEstateAge.Text != string.Empty)
                EstateAge = TxtAddEstateAge.Text;
            else
                EstateAge = "0";
            string StreetNo;
            if (TxtAddStreetNo.Text != string.Empty)
                StreetNo = TxtAddStreetNo.Text;
            else
                StreetNo = "0";
            string Tallshmal;
            if (TxtAddTallshmal.Text != string.Empty)
                Tallshmal = TxtAddTallshmal.Text;
            else
                Tallshmal = "0";
            string TallGanob;
            if (TxtAddTallGanob.Text != string.Empty)
                TallGanob = TxtAddTallGanob.Text;
            else
                TallGanob = "0";
            string Tallshark;
            if (TxtAddTallshark.Text != string.Empty)
                Tallshark = TxtAddTallshark.Text;
            else
                Tallshark = "0";
            string Tallghrab;
            if (TxtAddTallghrab.Text != string.Empty)
                Tallghrab = TxtAddTallghrab.Text;
            else
                Tallghrab = "0";
            string Aera;
            if (TxtAddAera.Text != string.Empty)
                Aera = TxtAddAera.Text;
            else
                Aera = "0";
            string Metrprice;
            if (TxtAddMetrprice.Text != string.Empty)
                Metrprice = TxtAddMetrprice.Text;
            else
                Metrprice = "0";
            string AllPrice;
            if (TxtAddAllPrice.Text != string.Empty)
                AllPrice = TxtAddAllPrice.Text;
            else
                AllPrice = "0";
            string showId;
            if (LUEAddshowId.EditValue != null)
                showId = LUEAddshowId.EditValue.ToString();
            else
                showId = "NULL";
            try
            {
                string NewID = MyCL.GetNewID("TblEstate", "EstateId");
                cmd.CommandText = string.Format(@"INSERT INTO TblEstate (EstateId, OwnerId, sakfrom, sakno, sakdate, TypeEstateId, EstateCaseId, EstateAge, CdAreaId, EstateAdderss, StreetNo, HadShmal, Tallshmal, HadGanob, 
                    TallGanob, Hadshark, Tallshark, Hadghrab, Tallghrab, Aera, Metrprice, AllPrice, remark, imagepath1, imagepath2, datein, userin, showId) VALUES        
                    ({0}, {1}, '{2}', '{3}', {4}, {5}, {6}, {7}, {8}, '{9}', {10}, '{11}', {12}, '{13}', {14}, '{15}', {16}, '{17}', {18}, {19}, {20}, {21}, '{22}', '{23}', '{24}', NOW(), {25}, {26})", NewID, OwnerId, MyCL.CleanSQLValue(TxtAddsakfrom.Text),
                MyCL.CleanSQLValue(TxtAddsakno.Text), sakdate, TypeEstateId, EstateCaseId, EstateAge, CdAreaId, MyCL.CleanSQLValue(TxtAddEstateAdderss.Text), StreetNo, MyCL.CleanSQLValue(TxtAddHadShmal.Text), Tallshmal,
                MyCL.CleanSQLValue(TxtAddHadGanob.Text), TallGanob, MyCL.CleanSQLValue(TxtAddHadshark.Text), Tallshark, MyCL.CleanSQLValue(TxtAddHadghrab.Text), Tallghrab, Aera, Metrprice, AllPrice, MyCL.CleanSQLValue(TxtAddremark.Text),
                MyCL.CleanSQLValue(ImgAddimagepath1.Text), MyCL.CleanSQLValue(ImgAddimagepath2.Text), MyCL.UserInfo.UserID, showId);
                con.Open();
                cmd.ExecuteNonQuery();
                MyCL.ShowMsg("تم الحفظ", false, this);
                BtnClear_Click(BtnClear, new EventArgs());
            }
            catch (OleDbException ex)
            {
                MyCL.ShowMsg(ex.Message, true, this);
            }
            con.Close();
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            LUEAddOwnerId.EditValue = null;
            TxtAddsakfrom.Text = string.Empty;
            TxtAddsakno.Text = string.Empty;
            DEAddsakdate.EditValue = null;
            LUEAddTypeEstateId.EditValue = null;
            LUEAddEstateCaseId.EditValue = null;
            TxtAddEstateAge.Text = string.Empty;
            LUEAddCdAreaId.EditValue = null;
            TxtAddEstateAdderss.Text = string.Empty;
            TxtAddStreetNo.Text = string.Empty;
            TxtAddremark.Text = string.Empty;
            TxtAddHadShmal.Text = string.Empty;
            TxtAddTallshmal.Text = string.Empty;
            TxtAddHadGanob.Text = string.Empty;
            TxtAddTallGanob.Text = string.Empty;
            TxtAddHadshark.Text = string.Empty;
            TxtAddTallshark.Text = string.Empty;
            TxtAddHadghrab.Text = string.Empty;
            TxtAddTallghrab.Text = string.Empty;
            TxtAddAera.Text = string.Empty;
            ImgAddimagepath1.Text = string.Empty;
            ImgAddimagepath2.Text = string.Empty;
            TxtAddMetrprice.Text = string.Empty;
            TxtAddAllPrice.Text = string.Empty;
            LUEAddOwnerId.Focus();
        }
        private void ImgAddimagepath1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
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
                ImgAddimagepath1.Text = NewFileName;
            }
            else
            {
                using (ImgViewerFrm Frm = new ImgViewerFrm())
                {
                    if (File.Exists(MyCL.PicPath + ImgAddimagepath1.Text))
                        Frm.Img.Image = Image.FromFile(MyCL.PicPath + ImgAddimagepath1.Text);
                    Frm.ShowDialog();
                }
            }
        }
        private void ImgAddimagepath2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
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
                ImgAddimagepath2.Text = NewFileName;
            }
            else
            {
                using (ImgViewerFrm Frm = new ImgViewerFrm())
                {
                    if (File.Exists(MyCL.PicPath + ImgAddimagepath2.Text))
                        Frm.Img.Image = Image.FromFile(MyCL.PicPath + ImgAddimagepath2.Text);
                    Frm.ShowDialog();
                }
            }
        }
        private void xtraTabControlMain_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (e.Page == xtraTabPageEdit)
                LoadData();
        }
        private void LUEEstateId_EditValueChanged(object sender, EventArgs e)
        {
            if (LUEEstateId.EditValue == null)
                return;
            DataRow row = GridTable.Rows[LUEEstateId.ItemIndex];
            LUEEditOwnerId.EditValue = row["OwnerId"];
            TxtEditsakfrom.Text = row["sakfrom"].ToString();
            TxtEditsakno.Text = row["sakno"].ToString();
            DEEditsakdate.EditValue = row["sakdate"];
            LUEEditTypeEstateId.EditValue = row["TypeEstateId"];
            LUEEditEstateCaseId.EditValue = row["EstateCaseId"];
            TxtEditEstateAge.Text = row["EstateAge"].ToString();
            LUEEditCdAreaId.EditValue = row["CdAreaId"];
            TxtEditEstateAdderss.Text = row["EstateAdderss"].ToString();
            TxtEditStreetNo.Text = row["StreetNo"].ToString();
            TxtEditremark.Text = row["remark"].ToString();
            TxtEditHadShmal.Text = row["HadShmal"].ToString();
            TxtEditTallshmal.Text = row["Tallshmal"].ToString();
            TxtEditHadGanob.Text = row["HadGanob"].ToString();
            TxtEditTallGanob.Text = row["TallGanob"].ToString();
            TxtEditHadshark.Text = row["Hadshark"].ToString();
            TxtEditTallshark.Text = row["Tallshark"].ToString();
            TxtEditHadghrab.Text = row["Hadghrab"].ToString();
            TxtEditTallghrab.Text = row["Tallghrab"].ToString();
            TxtEditAera.Text = row["Aera"].ToString();
            ImgEditimagepath1.Text = row["imagepath1"].ToString();
            ImgEditimagepath2.Text = row["imagepath2"].ToString();
            TxtEditMetrprice.Text = row["Metrprice"].ToString();
            TxtEditAllPrice.Text = row["AllPrice"].ToString();
            LUEEditshowId.EditValue = row["showId"];
        }
        private void LUEEstateId_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)
                return;
            if (MessageBox.Show("هل انت متأكد؟", "تحزيــــر", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            OleDbConnection con = new OleDbConnection(MyCL.AccConStr);
            OleDbCommand cmd = new OleDbCommand("", con);
            try
            {
                cmd.CommandText = @"Delete From TblEstate Where EstateId = " + LUEEstateId.EditValue;
                con.Open();
                cmd.ExecuteNonQuery();
                MyCL.ShowMsg("تم الحذف", false, this);
            }
            catch (OleDbException ex)
            {
                MyCL.ShowMsg(ex.Message, true, this);
            }
            con.Close();
            LoadData();
        }
        private void ImgEditimagepath1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
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
                ImgEditimagepath1.Text = NewFileName;
            }
            else
            {
                using (ImgViewerFrm Frm = new ImgViewerFrm())
                {
                    if (File.Exists(MyCL.PicPath + ImgEditimagepath1.Text))
                        Frm.Img.Image = Image.FromFile(MyCL.PicPath + ImgEditimagepath1.Text);
                    Frm.ShowDialog();
                }
            }
        }
        private void ImgEditimagepath2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
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
                ImgEditimagepath2.Text = NewFileName;
            }
            else
            {
                using (ImgViewerFrm Frm = new ImgViewerFrm())
                {
                    if (File.Exists(MyCL.PicPath + ImgEditimagepath2.Text))
                        Frm.Img.Image = Image.FromFile(MyCL.PicPath + ImgEditimagepath2.Text);
                    Frm.ShowDialog();
                }
            }
        }
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (LUEEstateId.EditValue == null)
                return;
            if (MessageBox.Show("هل انت متأكد؟", "تحزيــــر", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            OleDbConnection con = new OleDbConnection(MyCL.AccConStr);
            OleDbCommand cmd = new OleDbCommand("", con);
            string OwnerId;
            if (LUEEditOwnerId.EditValue != null)
                OwnerId = LUEEditOwnerId.EditValue.ToString();
            else
                OwnerId = "NULL";
            string TypeEstateId;
            if (LUEEditTypeEstateId.EditValue != null)
                TypeEstateId = LUEEditTypeEstateId.EditValue.ToString();
            else
                TypeEstateId = "NULL";
            string EstateCaseId;
            if (LUEEditEstateCaseId.EditValue != null)
                EstateCaseId = LUEEditEstateCaseId.EditValue.ToString();
            else
                EstateCaseId = "NULL";
            string CdAreaId;
            if (LUEEditCdAreaId.EditValue != null)
                CdAreaId = LUEEditCdAreaId.EditValue.ToString();
            else
                CdAreaId = "NULL";
            string sakdate;
            if (DEEditsakdate.EditValue != null)
                sakdate = String.Format("Format('{0}', 'dd/mm/yyyy')", DEEditsakdate.Text);
            else
                sakdate = "NULL";
            string EstateAge;
            if (TxtEditEstateAge.Text != string.Empty)
                EstateAge = TxtEditEstateAge.Text;
            else
                EstateAge = "0";
            string StreetNo;
            if (TxtEditStreetNo.Text != string.Empty)
                StreetNo = TxtEditStreetNo.Text;
            else
                StreetNo = "0";
            string Tallshmal;
            if (TxtEditTallshmal.Text != string.Empty)
                Tallshmal = TxtEditTallshmal.Text;
            else
                Tallshmal = "0";
            string TallGanob;
            if (TxtEditTallGanob.Text != string.Empty)
                TallGanob = TxtEditTallGanob.Text;
            else
                TallGanob = "0";
            string Tallshark;
            if (TxtEditTallshark.Text != string.Empty)
                Tallshark = TxtEditTallshark.Text;
            else
                Tallshark = "0";
            string Tallghrab;
            if (TxtEditTallghrab.Text != string.Empty)
                Tallghrab = TxtEditTallghrab.Text;
            else
                Tallghrab = "0";
            string Aera;
            if (TxtEditAera.Text != string.Empty)
                Aera = TxtEditAera.Text;
            else
                Aera = "0";
            string Metrprice;
            if (TxtEditMetrprice.Text != string.Empty)
                Metrprice = TxtEditMetrprice.Text;
            else
                Metrprice = "0";
            string AllPrice;
            if (TxtEditAllPrice.Text != string.Empty)
                AllPrice = TxtEditAllPrice.Text;
            else
                AllPrice = "0";
            string showId;
            if (LUEEditshowId.EditValue != null)
                showId = LUEEditshowId.EditValue.ToString();
            else
                showId = "NULL";
            try
            {
                cmd.CommandText = string.Format(@"UPDATE TblEstate SET OwnerId = {0}, sakfrom = '{1}', sakno = '{2}', sakdate = {3}, TypeEstateId = {4}, EstateCaseId = {5}, EstateAge = {6}, CdAreaId = {7}, EstateAdderss = '{8}', StreetNo = {9}, 
                HadShmal = '{10}', Tallshmal = {11}, HadGanob = '{12}', TallGanob = {13}, Hadshark = '{14}', Tallshark = {15}, Hadghrab = '{16}', Tallghrab = {17}, Aera = {18}, Metrprice = {19}, AllPrice = {20},  remark = '{21}', imagepath1 = '{22}', imagepath2 = '{23}', datein = NOW(), 
                userin = {24}, showId = {25} WHERE (TblEstate.EstateId = {26})", OwnerId, MyCL.CleanSQLValue(TxtEditsakfrom.Text),
                MyCL.CleanSQLValue(TxtEditsakno.Text), sakdate, TypeEstateId, EstateCaseId, EstateAge, CdAreaId, MyCL.CleanSQLValue(TxtEditEstateAdderss.Text), StreetNo, MyCL.CleanSQLValue(TxtEditHadShmal.Text), Tallshmal,
                MyCL.CleanSQLValue(TxtEditHadGanob.Text), TallGanob, MyCL.CleanSQLValue(TxtEditHadshark.Text), Tallshark, MyCL.CleanSQLValue(TxtEditHadghrab.Text), Tallghrab, Aera, Metrprice, AllPrice, MyCL.CleanSQLValue(TxtEditremark.Text),
                MyCL.CleanSQLValue(ImgEditimagepath1.Text), MyCL.CleanSQLValue(ImgEditimagepath2.Text), MyCL.UserInfo.UserID, showId, LUEEstateId.EditValue);
                con.Open();
                cmd.ExecuteNonQuery();
                MyCL.ShowMsg("تم التعديل", false, this);
                LoadData();
            }
            catch (OleDbException ex)
            {
                MyCL.ShowMsg(ex.Message, true, this);
            }
            con.Close();
        }
        #endregion

    }
}
