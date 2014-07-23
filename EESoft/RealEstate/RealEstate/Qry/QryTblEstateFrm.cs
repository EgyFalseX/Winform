using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;

namespace RealEstate
{
    public partial class QryTblEstateFrm : DevExpress.XtraEditors.XtraForm
    {
        public QryTblEstateFrm()
        {
            InitializeComponent();
        }
        private void QryTblEstateFrm_Load(object sender, EventArgs e)
        {
            gridControlQry.DataSource = MyCL.LoadDataTable(@"SELECT EstateId, 
            (Select show From cdshow Where showId = TblEstate.showId) AS show, 
            (Select Owner From TblOwner Where OwnerId = TblEstate.OwnerId) AS Owner, 
            sakfrom, sakno, Format(sakdate, 'dd/mm/yyyy') AS sakdate, 
            (Select TypeEstate From CdTypeEstate Where TypeEstateId = TblEstate.TypeEstateId) AS TypeEstate, 
            (Select EstateCase From CdEstateCase Where EstateCaseId = TblEstate.EstateCaseId) AS EstateCase, 
            (Select CdArea From CdArea Where CdAreaId = TblEstate.CdAreaId ) AS CdArea,
            EstateAge, EstateAdderss, StreetNo, HadShmal, Tallshmal, HadGanob, TallGanob, Hadshark, Tallshark, Hadghrab, Tallghrab, Aera, Metrprice, AllPrice, remark, imagepath1, imagepath2, datein, 
            userin AS UserName
            FROM TblEstate");

        }
        private void repositoryItemButtonEditimagepath1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ButtonEdit btn = (ButtonEdit)sender;
            DataRow Row = (DataRow)gridViewQry.GetFocusedDataRow();

            using (ImgViewerFrm Frm = new ImgViewerFrm())
            {
                if (File.Exists(MyCL.PicPath + btn.EditValue))
                    Frm.Img.Image = Image.FromFile(MyCL.PicPath + btn.EditValue);
                Frm.ShowDialog();
            }
        }
        private void repositoryItemButtonEditimagepath2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ButtonEdit btn = (ButtonEdit)sender;
            DataRow Row = (DataRow)gridViewQry.GetFocusedDataRow();

            using (ImgViewerFrm Frm = new ImgViewerFrm())
            {
                if (File.Exists(MyCL.PicPath + btn.EditValue))
                    Frm.Img.Image = Image.FromFile(MyCL.PicPath + btn.EditValue);
                Frm.ShowDialog();
            }
        }
    }
}