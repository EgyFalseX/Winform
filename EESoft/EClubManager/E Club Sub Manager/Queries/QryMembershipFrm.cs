using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace E_Club_Sub_Manager
{
    public partial class QryMembershipFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        DataTable GridTbl = new DataTable("FalseX2010-11");
        #endregion
        #region -   Functions   -
        public QryMembershipFrm()
        {
            InitializeComponent();
        }
        private void LoadGrid()
        {
            GridTbl = new DataTable("FalseX2010-11");
            GridTbl = Program.MC.LoadDataTableMem(@"SELECT TBL_members.mem_name, TBL_Membership.mem_ID, TBL_members.mem_mNUMBER, 
                                                    TBL_Membership.membership_start_date, TBL_Membership.membership_end_date, 
                                                    TBL_Membership.PaymentValue, (Select membership_type From CD_membership_type Where membership_type_id = TBL_Membership.membership_type_id) AS membership_type
                                                    FROM TBL_Membership INNER JOIN TBL_members ON TBL_Membership.mem_ID = TBL_members.mem_ID");
            gridControlMembership.DataSource = GridTbl;
        }
        #endregion
        #region -   Event Handlers   -
        private void QryMembershipFrm_Load(object sender, EventArgs e)
        {
            LoadGrid();
            gridViewMembership.BestFitColumns();
        }
        #endregion
    }
}