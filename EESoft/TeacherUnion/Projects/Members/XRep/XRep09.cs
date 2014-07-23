using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace Members
{
    public partial class XRep09 : DevExpress.XtraReports.UI.XtraReport
    {
        public XRep09(DataSources.dsTeachersUnion.TBLSadadRow row)
        {
            InitializeComponent();
            appOptionsTableAdapter.Fill(dsTeachersUnionQuery1.AppOptions);
            DataSources.dsTeachersUnionTableAdapters.TBLMembersTableAdapter adp = new DataSources.dsTeachersUnionTableAdapters.TBLMembersTableAdapter();

            lblName.Text = adp.ScalarQueryGetMemberName(row.MemberId);
            lblKid.Text = adp.ScalarQueryGetKideNumber(row.MemberId).ToString();
            lblesalno.Text = row.esalno;
            lblesaldate.Text = row.esaldate.ToShortDateString();
            lblesalmony.Text = row.esalmony.ToString();
            lblfatrafrom.Text = row.fatrafrom.ToShortDateString();
            lblfatrato.Text = row.fatrato.ToShortDateString();
            lblDate.Text = DateTime.Now.ToShortDateString();

        }
        public XRep09(DataSources.dsTeachersUnion.TBLSadadWebRow row)
        {
            InitializeComponent();
            appOptionsTableAdapter.Fill(dsTeachersUnionQuery1.AppOptions);
            DataSources.dsTeachersUnionTableAdapters.TBLMembersTableAdapter adp = new DataSources.dsTeachersUnionTableAdapters.TBLMembersTableAdapter();

            lblName.Text = adp.ScalarQueryGetMemberName(row.MemberId);
            lblKid.Text = adp.ScalarQueryGetKideNumber(row.MemberId).ToString();
            lblesalno.Text = row.esalno;
            lblesaldate.Text = row.esaldate.ToShortDateString();
            lblesalmony.Text = row.esalmony.ToString();
            lblfatrafrom.Text = row.fatrafrom.ToShortDateString();
            lblfatrato.Text = row.fatrato.ToShortDateString();
            lblDate.Text = DateTime.Now.ToShortDateString();

        }
    }
}
