using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace GM.Reports
{
    public partial class XRep05 : DevExpress.XtraReports.UI.XtraReport
    {
        DataSources.dsGMTableAdapters.GovTableAdapter adpGov = new DataSources.dsGMTableAdapters.GovTableAdapter();
        DataSources.dsGMTableAdapters.AreaTableAdapter adpArea = new DataSources.dsGMTableAdapters.AreaTableAdapter();
        //DataSources.dsGMTableAdapters.PlumberTableAdapter adpPlumber = new DataSources.dsGMTableAdapters.PlumberTableAdapter();
        public XRep05()
        {
            InitializeComponent();

            adpGov.Fill(dsGM.Gov);
            adpArea.Fill(dsGM.Area);
            plumberTableAdapter.Fill(dsGM.Plumber);
            //sessionPlumber.ConnectionString = Properties.Settings.Default.GmKadryConnectionString;
            
        }
        private void XRep01_ParametersRequestSubmit(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            if (Parameters["pramPlumberId"].Value == DBNull.Value || Parameters["pramFrom"].Value == DBNull.Value || Parameters["pramTo"].Value == DBNull.Value)
            {
                return;
            }
            int PlumberId = Convert.ToInt32(Parameters["pramPlumberId"].Value);
            DateTime from = Convert.ToDateTime(Parameters["pramFrom"].Value);
            DateTime to = Convert.ToDateTime(Parameters["pramTo"].Value);

            report05TableAdapter.Fill(dsQry.Report05, PlumberId, from, to);

            foreach (ParameterInfo pram in e.ParametersInformation)
            {
                if (pram.Parameter.Name == "pramPlumberId")
                {
                    int id = (int)pram.Parameter.Value;

                    DataSources.dsGM.PlumberRow row = dsGM.Plumber.FindByPlumberId(id);
                    lblPlumberName.Text = row.PlumberName;
                    lblPlumberPhone.Text = row.PlumberPhone;
                    lblPlumberMobile.Text = row.PlumberMobile;
                    lblGovName.Text = row.AreaRow.GovRow.GovName;
                    lblAreaName.Text = row.AreaRow.AreaName;
                    lblPlumberAddress.Text = row.PlumberAddress;
                }
                if (pram.Parameter.Name == "pramFrom")
                {
                    lblFrom.Text = from.ToShortDateString();
                    continue;
                }
                if (pram.Parameter.Name == "pramTo")
                {
                    lblTo.Text = to.ToShortDateString();
                    continue;
                }
            }
        }

        private void XRep05_ParametersRequestBeforeShow(object sender, ParametersRequestEventArgs e)
        {
            foreach (ParameterInfo info in e.ParametersInformation)
            {
                if (info.Parameter.Name == "pramPlumberId")
                {

                    DevExpress.XtraEditors.SearchLookUpEdit LUE = new DevExpress.XtraEditors.SearchLookUpEdit();

                    //XPSCSPlumber = new DevExpress.Xpo.XPServerCollectionSource
                    LUE.Properties.DataSource = PlumberbindingSource;
                    

                    LUE.Properties.DisplayMember = "PlumberName";
                    LUE.Properties.ValueMember = "PlumberId";

                    //LUE.Properties.Columns.Add(new LookUpColumnInfo("PlumberName", 0, "اسم السباك"));
                    //LUE.Properties.BestFit();
                    //LUE.Properties.NullText = string.Empty;
                    //LUE.Properties.TextEditStyle = TextEditStyles.Standard;

                    DevExpress.XtraGrid.Columns.GridColumn gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
                    DevExpress.XtraGrid.Columns.GridColumn gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
                    DevExpress.XtraGrid.Columns.GridColumn gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
                    DevExpress.XtraGrid.Columns.GridColumn gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
                    gridColumn1.Caption = "الاسم";
                    gridColumn1.FieldName = "PlumberName";
                    gridColumn1.Name = "gridColumn1";
                    gridColumn1.Visible = true;
                    gridColumn1.VisibleIndex = 0;
                    gridColumn2.Caption = "تليفون";
                    gridColumn2.FieldName = "PlumberPhone";
                    gridColumn2.Name = "gridColumn2";
                    gridColumn2.Visible = true;
                    gridColumn2.VisibleIndex = 1;
                    gridColumn3.Caption = "موبيل";
                    gridColumn3.FieldName = "PlumberMobile";
                    gridColumn3.Name = "gridColumn3";
                    gridColumn3.Visible = true;
                    gridColumn3.VisibleIndex = 2;
                    gridColumn4.Caption = "الرقم القومي";
                    gridColumn4.FieldName = "NationalId";
                    gridColumn4.Name = "gridColumn4";
                    gridColumn4.Visible = true;
                    gridColumn4.VisibleIndex = 3;

                    DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
                    searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
                    gridColumn1,
                    gridColumn2,
                    gridColumn3,
                    gridColumn4});
                    searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
                    searchLookUpEdit1View.Name = "searchLookUpEdit1View";
                    searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
                    searchLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
                    searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;

                    LUE.Properties.View = searchLookUpEdit1View;
                    
                    

                    LUE.EditValue = "";
                    LUE.Name = "LUE";
                    LUE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
                    LUE.Properties.DisplayMember = "PlumberName";
                    LUE.Properties.NullText = "";
                    LUE.Properties.ValueMember = "PlumberId";
                    //this.LUE.Properties.View = this.searchLookUpEdit1View;
                    LUE.Size = new System.Drawing.Size(182, 20);
                    LUE.TabIndex = 0;

                    info.Editor = LUE;
                    info.Parameter.Value = DBNull.Value;


                    
                    continue;
                }
            }
        }

    }
}
