using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace Members
{
    public partial class XRep10 : DevExpress.XtraReports.UI.XtraReport
    {
        public XRep10(DataSources.Linq.vTBLMembersPlusShadetKed row)
        {
            InitializeComponent();
            appOptionsTableAdapter.Fill(dsTeachersUnionQuery1.AppOptions);
            DataSources.dsTeachersUnionTableAdapters.TBLMembersTableAdapter adp = new DataSources.dsTeachersUnionTableAdapters.TBLMembersTableAdapter();

            lblName.Text = row.MemberName;
            lblJobtitle.Text = row.Jobtitle;
            lblSyndicate.Text = row.Syndicate;
            lblKideNumber.Text = row.KideNumber.ToString();
            lblDate.Text = DateTime.Now.ToShortDateString();

        }

    }
}
