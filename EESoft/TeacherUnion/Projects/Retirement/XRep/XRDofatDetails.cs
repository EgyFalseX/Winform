using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.Parameters;

namespace Retirement.XRep
{
    public partial class XRDofatDetails : DevExpress.XtraReports.UI.XtraReport
    {
        public XRDofatDetails()
        {
            InitializeComponent();
            cdSyndicateTableAdapter.Fill(dsTeachersUnion1.CDSyndicate);
            //foreach (ParameterInfo info in Parameters)
            //{
                
            //}

            Prmyear.Value = DateTime.Now.Year;
        }
        private void XRDofatDetails_ParametersRequestBeforeShow(object sender, ParametersRequestEventArgs e)
        {
            DataSources.dsTeachersUnionTableAdapters.AppOptionsTableAdapter adpOptions = new DataSources.dsTeachersUnionTableAdapters.AppOptionsTableAdapter();
            adpOptions.Fill(dsTeachersUnion1.AppOptions);
            foreach (ParameterInfo info in e.ParametersInformation)
            {
                if (info.Parameter.Name == "PrmSyndicateId")
                {
                    ((LookUpEdit)info.Editor).EditValueChanged += lueSyndicateId_EditValueChanged;
                    ((LookUpEdit)info.Editor).Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                }
                if (info.Parameter.Name == "PrmSubCommitteId")
                {
                    ((LookUpEdit)info.Editor).Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
                }
            }
        }
        void lueSyndicateId_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit lue = (LookUpEdit)sender;
            cdSubCommitteTableAdapter.FillBySyndicateId(dsTeachersUnion1.CDSubCommitte, Convert.ToInt32(lue.EditValue));
        }
        private void XRDofatDetails_ParametersRequestSubmit(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            int SubCommitteId = 0;
              foreach (ParameterInfo info in e.ParametersInformation)
              {
                  if (info.Parameter.Name == "PrmSyndicateId")
                      xrLblSyndicate.Text = "النقابة الفرعية ب" + ((LookUpEdit)info.Editor).Properties.GetDisplayText(info.Parameter.Value);
                  if (info.Parameter.Name == "PrmSubCommitteId")
                  {
                      xrLblSubCommitteId.Text = ((LookUpEdit)info.Editor).Properties.GetDisplayText(info.Parameter.Value);
                      SubCommitteId = (int)info.Parameter.Value;
                  }
                  if (info.Parameter.Name == "Prmyear")
                      xrLblYear.Text = "لسنة " + info.Parameter.Value.ToString();
                  if (info.Parameter.Name == "PrmDofaa")
                      xrLblDofaa.Text = "عن الدفعة " + info.Parameter.Value.ToString();
              }
              repDofatDetailsTableAdapter.FillBySubCommitteId(dsTeachersUnion1.RepDofatDetails, SubCommitteId); 

        }
        private void XRDofatDetails_ParametersRequestValueChanged(object sender, DevExpress.XtraReports.Parameters.ParametersRequestValueChangedEventArgs e)
        {
            //foreach (ParameterInfo info in e.ParametersInformation)
            //{
            //    if (info.Parameter.Name == "PrmSyndicateId")
            //    { 
            //        cdSubCommitteTableAdapter.FillBySyndicateId(dsTeachersUnion1.CDSubCommitte, Convert.ToInt32(info.Parameter.Value));
            //    }
            //}
        }

        private void pageFooterBand1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //XRSummary.Running
            string x = string.Empty;
        }

        private void pageFooterBand1_AfterPrint(object sender, EventArgs e)
        {

        }

      

    }
}
