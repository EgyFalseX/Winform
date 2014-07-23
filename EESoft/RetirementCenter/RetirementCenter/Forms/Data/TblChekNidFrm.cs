using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace RetirementCenter.Forms.Data
{
    public partial class TblChekNidFrm : DevExpress.XtraEditors.XtraForm
    {
        public TblChekNidFrm()
        {
            InitializeComponent();
            unitOfWorkData.ConnectionString = Properties.Settings.Default.RetirementCenterConnectionString;
        }
        private void barLargeButtonItemSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            unitOfWorkData.CommitChanges();
            Program.ShowMsg("تم الحفظ", false, this, true);
        }
        private void gridViewData_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DateTime dt = SQLProvider.ServerDateTime();
            DevExpress.Xpo.Metadata.XPDataTableObject NewData = (DevExpress.Xpo.Metadata.XPDataTableObject)gridViewData.GetRow(e.RowHandle);
            NewData.SetMemberValue("datein", dt); NewData.SetMemberValue("userin", Program.UserInfo.UserId);
        }
        private void gridViewData_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            DateTime dt = SQLProvider.ServerDateTime();
            DevExpress.Xpo.Metadata.XPDataTableObject NewData = (DevExpress.Xpo.Metadata.XPDataTableObject)gridViewData.GetRow(e.RowHandle);
            NewData.SetMemberValue("datein", dt); NewData.SetMemberValue("userin", Program.UserInfo.UserId);
        }
    }
}