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
    public partial class XRep02 : DevExpress.XtraReports.UI.XtraReport
    {
        public XRep02()
        {
            InitializeComponent();
        }
        private void XRep02_ParametersRequestValueChanged(object sender, ParametersRequestValueChangedEventArgs e)
        {
            
        }
        private void XRep01_ParametersRequestSubmit(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            if (Parameters["pramGovId"].Value == DBNull.Value || Parameters["pramAreaId"].Value == DBNull.Value || Parameters["pramFrom"].Value == DBNull.Value || Parameters["pramTo"].Value == DBNull.Value)
            {
                return;
            }
            int GovId = Convert.ToInt32(Parameters["pramGovId"].Value);
            int AreaId = Convert.ToInt32(Parameters["pramAreaId"].Value);
            DateTime from = Convert.ToDateTime(Parameters["pramFrom"].Value);
            DateTime to = Convert.ToDateTime(Parameters["pramTo"].Value);

            report02TableAdapter.Fill(dsQry.Report02, from, to, AreaId);

            foreach (ParameterInfo pram in e.ParametersInformation)
            {
                if (pram.Parameter.Name == "pramGovId")
                {
                    lblGov.Text = ((LookUpEdit)pram.Editor).Text;
                    continue;
                }
                if (pram.Parameter.Name == "pramAreaId")
                {
                    lblArea.Text = ((LookUpEdit)pram.Editor).Text;
                    continue;
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
        private void XRep02_ParametersRequestBeforeShow(object sender, ParametersRequestEventArgs e)
        {
            foreach (ParameterInfo pram in e.ParametersInformation)
            {
                if (pram.Parameter.Name == "pramGovId")
                {
                    LookUpEdit lue = (LookUpEdit)pram.Editor;
                    
                    lue.Properties.DataSource = dsGM.Gov;
                    lue.Properties.DisplayMember = "GovName";
                    lue.Properties.ValueMember = "GovId";
                    lue.Properties.Columns.Add(new LookUpColumnInfo("GovName", 0, "أسم المحافظة"));
                    lue.Properties.BestFit();
                    lue.Properties.NullText = string.Empty;
                    lue.Properties.TextEditStyle = TextEditStyles.Standard;
                    lue.EditValueChanged += lue_EditValueChanged;
                    continue;
                }
                if (pram.Parameter.Name == "pramAreaId")
                {
                    LookUpEdit lue = (LookUpEdit)pram.Editor;

                    lue.Properties.DataSource = dsGM.Area;
                    lue.Properties.DisplayMember = "AreaName";
                    lue.Properties.ValueMember = "AreaId";
                    lue.Properties.Columns.Add(new LookUpColumnInfo("AreaName", 0, "أسم المنطقة"));
                    lue.Properties.BestFit();
                    lue.Properties.NullText = string.Empty;
                    lue.Properties.TextEditStyle = TextEditStyles.Standard;
                    //lue.EditValueChanged += lue_EditValueChanged;
                    continue;
                }
            }
        }
        void lue_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit lue = (LookUpEdit)sender;
            if (lue.EditValue == null)
            {
                return;
            }
            //if (e.ChangedParameterInfo.Parameter == pramAreaId)
            //{
            //    if (e.ChangedParameterInfo.Parameter.Value == null)
            //        return;
                areaTableAdapter.FillByGovId(dsGM.Area, Convert.ToInt32(lue.EditValue));
            }
        }

    
}
