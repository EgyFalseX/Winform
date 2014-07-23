using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System.Windows.Forms;

namespace Members
{
    public partial class XRep07 : DevExpress.XtraReports.UI.XtraReport
    {
        public XRep07()
        {
            InitializeComponent();
         
            //Load Logo.
            DataSources.dsTeachersUnionQueryTableAdapters.AppOptionsTableAdapter adp = new DataSources.dsTeachersUnionQueryTableAdapters.AppOptionsTableAdapter();
            byte[] byt = adp.ScalarQueryLogo();
            if (byt != null && byt.Length != 0)
                xpbLogo.Image = Image.FromStream(new System.IO.MemoryStream(byt));
        }
        private void XRep07_ParametersRequestBeforeShow(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            foreach (ParameterInfo info in e.ParametersInformation)
            {
                if (info.Parameter.Name == "Pramhafzaid")
                {
                    //LookUpEdit LUE = new LookUpEdit();
                    //LUE.Properties.DataSource = SQLProvider.SelectCDSyndicate();
                    //LUE.Properties.DisplayMember = "Syndicate";
                    //LUE.Properties.ValueMember = "SyndicateId";
                    //LUE.Properties.Columns.Add(new LookUpColumnInfo("Syndicate", 0, "الاسم"));
                    //LUE.EditValueChanged += LUE_EditValueChanged;
                    //LUE.Properties.NullText = string.Empty;
                    //LUE.Properties.TextEditStyle = TextEditStyles.Standard;
                    //info.Editor = LUE;
                    //info.Parameter.Value = DBNull.Value;
                    continue;
                }
            }
        }
        private void XRep07_ParametersRequestSubmit(object sender, ParametersRequestEventArgs e)
        {
            if (e.ParametersInformation[0].Parameter.Value == null || e.ParametersInformation[1].Parameter.Value == null)
                return;
            xrtVarCell.DataBindings.Clear();
            rep07TableAdapter.FillByhafzaid(dsTeachersUnionQuery1.Rep07, Convert.ToDouble(e.ParametersInformation[0].Parameter.Value));

            //827
            
            if ((int)e.ParametersInformation[1].Parameter.Value == 1)
            {
                xrlFilterType.Text = "ما تم طباعتة";
                Report.FilterString = "printdate is not null";
               
                DetailGeneral.MultiColumn.ColumnCount = 2;
                xrTableHeader.Rows[0].Cells.Clear();
                xrTableHeader.Rows[0].Cells.Add(new XRTableCell() { Text = "اللجنه", TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight});
                xrTableHeader.Rows[0].Cells.Add(new XRTableCell() { Text = "الاسم", TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight });
                xrTableHeader.Rows[0].Cells.Add(new XRTableCell() { Text = "الرقم", TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight });              
                xrTableHeader.Rows[0].Cells.Add(new XRTableCell() { Text = "اللجنه", TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight });
                xrTableHeader.Rows[0].Cells.Add(new XRTableCell() { Text = "الاسم", TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight });
                xrTableHeader.Rows[0].Cells.Add(new XRTableCell() { Text = "الرقم", TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight });

                xrTableHeader.LocationF = new PointF(0, 0); xrTableHeader.WidthF = PageWidth;

                xrTableHeader.Rows[0].Cells[0].WidthF = 120;
                xrTableHeader.Rows[0].Cells[1].WidthF = 200;
                xrTableHeader.Rows[0].Cells[2].WidthF = 80;

                xrTableHeader.Rows[0].Cells[3].WidthF = 120;
                xrTableHeader.Rows[0].Cells[4].WidthF = 200;
                xrTableHeader.Rows[0].Cells[5].WidthF = 80;


                xrTableDetails.Rows[0].Cells[0].WidthF = 120;
                xrTableDetails.Rows[0].Cells[1].WidthF = 200;
                xrTableDetails.Rows[0].Cells[2].WidthF = 80;


                //foreach (XRTableCell cell in xrTableHeader.Rows[0].Cells)
                //    cell.WidthF = PageWidth / 6;
                //foreach (XRTableCell cell in xrTableDetails.Rows[0].Cells)
                //    cell.WidthF = PageWidth / 6;                    
                xrtVarCell.DataBindings.Add(new DevExpress.XtraReports.UI.XRBinding("Text", null, "Rep07.SubCommitte"));
            }
            else
            {
                xrlFilterType.Text = "ما لم يتم طباعتة";
                Report.FilterString = "estefaa = 'true'";

                DetailGeneral.MultiColumn.ColumnCount = 2;
                xrTableHeader.Rows[0].Cells.Clear();
                xrTableHeader.Rows[0].Cells.Add(new XRTableCell() { Text = "السبب", TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight });
                xrTableHeader.Rows[0].Cells.Add(new XRTableCell() { Text = "الاسم", TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight });
                xrTableHeader.Rows[0].Cells.Add(new XRTableCell() { Text = "الرقم", TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight });               
                xrTableHeader.Rows[0].Cells.Add(new XRTableCell() { Text = "السبب", TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight });
                xrTableHeader.Rows[0].Cells.Add(new XRTableCell() { Text = "الاسم", TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight });
                xrTableHeader.Rows[0].Cells.Add(new XRTableCell() { Text = "الرقم", TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight });

                xrTableHeader.LocationF = new PointF(0, 0); xrTableHeader.WidthF = PageWidth;

                xrTableHeader.Rows[0].Cells[0].WidthF = 170;
                xrTableHeader.Rows[0].Cells[1].WidthF = 170;
                xrTableHeader.Rows[0].Cells[2].WidthF = 60;

                xrTableHeader.Rows[0].Cells[3].WidthF = 170;
                xrTableHeader.Rows[0].Cells[4].WidthF = 170;
                xrTableHeader.Rows[0].Cells[5].WidthF = 60;


                xrTableDetails.Rows[0].Cells[0].WidthF = 170;
                xrTableDetails.Rows[0].Cells[1].WidthF = 170;
                xrTableDetails.Rows[0].Cells[2].WidthF = 60;


                //foreach (XRTableCell cell in xrTableHeader.Rows[0].Cells)
                //    cell.WidthF = PageWidth / 6;
                //foreach (XRTableCell cell in xrTableDetails.Rows[0].Cells)
                //    cell.WidthF = PageWidth / 6; 

                xrtVarCell.DataBindings.Add(new DevExpress.XtraReports.UI.XRBinding("Text", null, "Rep07.estefareson"));
            }
            ApplyFiltering();

            xrlTotal.Text = this.RowCount.ToString();
           
        }

    }
}
