using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.IO;

namespace E_Club_Mem_Manager
{
    public partial class QryMemInfoFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        DataTable MemInfo = new DataTable("FalseX2010-11");
        #endregion
        #region -   Functions   -
        public QryMemInfoFrm()
        {
            InitializeComponent();
        }
        private void GetEmpInfo()
        {
            MemInfo = new DataTable("FalseX2010-08");
            if (TxtNo.Text.Trim().Length == 0)
                return;
            MemInfo = Program.MC.LoadDataTableMem(@"SELECT (Select mem_name From TBL_members Where mem_ID = TBL_Membership.mem_ID) AS mem_name,
             (Select mem_mNUMBER From TBL_members Where mem_ID = TBL_Membership.mem_ID) AS mem_mNUMBER,
             (Select MemPic From TBL_members Where mem_ID = TBL_Membership.mem_ID) AS MemPic,
             (Select mem_parent From TBL_members Where mem_ID = TBL_Membership.mem_ID) AS mem_parent,
             (Select Subscription_type_id From TBL_members Where mem_ID = TBL_Membership.mem_ID) AS Subscription_type_id,
             (Select job From CD_job Where job_id = (Select mem_job From TBL_members Where mem_ID = TBL_Membership.mem_ID)) AS job,
             (Select mem_bdate From TBL_members Where mem_ID = TBL_Membership.mem_ID) AS mem_bdate,
             (Select membership_type From CD_membership_type Where membership_type_id = TBL_Membership.membership_type_id) AS membership_type,
             (Select asasename From Cd_asase Where asasecode = TBL_Membership.asasecode) AS asasename,
             membership_type_id, membership_start_date, membership_end_date
             FROM TBL_Membership Where mem_ID = " + TxtNo.Text.Trim() + " Order By asasecode DESC");
            if (MemInfo.Rows.Count != 0)
            {
                Txtmem_name.Text = MemInfo.Rows[0]["mem_name"].ToString();
                Txtmem_mNUMBER.Text = MemInfo.Rows[0]["mem_mNUMBER"].ToString();
                TxtJob.Text = MemInfo.Rows[0]["Job"].ToString();
                Txtmem_bdate.Text = MCls.ConvertToDateDMY(MemInfo.Rows[0]["mem_bdate"].ToString());
                Txtmembership_type.Text = MemInfo.Rows[0]["membership_type"].ToString();
                Txtasasename.Text = MemInfo.Rows[0]["asasename"].ToString();
                Txtmembership_start_date.Text =MCls.ConvertToDateDMY( MemInfo.Rows[0]["membership_start_date"].ToString());
                Txtmembership_end_date.Text = MCls.ConvertToDateDMY(MemInfo.Rows[0]["membership_end_date"].ToString());
                if (MemInfo.Rows[0]["MemPic"] != null)
                {
                    MemoryStream stream = new MemoryStream();
                    byte[] compLogo = (byte[])MemInfo.Rows[0]["MemPic"];
                    MemoryStream ms = new MemoryStream(compLogo);
                    MemPic.Image = Image.FromStream(ms);
                }
                if (MemInfo.Rows[0]["membership_type_id"].ToString() == Program.MC.SubScriptSingle.ToString())
                {
                    xTabPageParent.PageVisible = false;
                    xTabPageChild.PageVisible = false;
                }
                else if (MemInfo.Rows[0]["membership_type_id"].ToString() == Program.MC.SubScriptDepend.ToString() && MemInfo.Rows[0]["mem_parent"].ToString() != string.Empty)
                {
                    xTabPageParent.PageVisible = true;
                    xTabPageChild.PageVisible = false;
                    LoadParent(MemInfo.Rows[0]["mem_parent"].ToString());
                }
                else if (MemInfo.Rows[0]["membership_type_id"].ToString() == Program.MC.SubScriptFamily.ToString())
                {
                    LoadChild(TxtNo.Text.Trim());
                    xTabPageParent.PageVisible = false;
                    xTabPageChild.PageVisible = true;
                }
            }
            else
            {
                ClearForm();
            }
            Application.DoEvents();
            System.Threading.Thread.Sleep(1000);
            TxtNo.Text = string.Empty;
            TxtNo.Focus();
        }
        private void LoadParent(string mem_ID)
        {
            DataTable ParentMem = new DataTable("FalseX2010-11");
            ParentMem = Program.MC.LoadDataTableMem(@"SELECT mem_name, mem_mNUMBER, mem_NNumber, mem_bdate, tel_house, tel_mobile
                                                      FROM TBL_members Where mem_ID = " + mem_ID);
            if (ParentMem.Rows.Count != 0)
            {
                Txtmem_nameP.Text = ParentMem.Rows[0]["mem_name"].ToString();
                Txtmem_mNUMBERP.Text = ParentMem.Rows[0]["mem_mNUMBER"].ToString();
                Txtmem_NNumber.Text = ParentMem.Rows[0]["mem_NNumber"].ToString();
                Txtmem_bdateP.Text = MCls.ConvertToDateDMY(ParentMem.Rows[0]["mem_bdate"].ToString());
                Txttel_house.Text = ParentMem.Rows[0]["tel_house"].ToString();
                Txttel_mobile.Text = ParentMem.Rows[0]["tel_mobile"].ToString();
            }
            else
            {
                Txtmem_nameP.Text = string.Empty;
                Txtmem_mNUMBERP.Text = string.Empty;
                Txtmem_NNumber.Text = string.Empty;
                Txtmem_bdateP.Text = string.Empty;
                Txttel_house.Text = string.Empty;
                Txttel_mobile.Text = string.Empty;
            }

        }
        private void LoadChild(string mem_ID_parent)
        {
            DataTable ChildMem = new DataTable("FalseX2010-11");
            ChildMem = Program.MC.LoadDataTableMem(@"SELECT TBL_members.mem_name, TBL_members.mem_mNUMBER, CD_job.job, TBL_members.mem_bdate, CD_kinship.Kinship
                       FROM TBL_Dependents INNER JOIN TBL_members ON TBL_Dependents.Kinship_id = TBL_members.Kinship_id INNER JOIN
                       CD_kinship ON TBL_Dependents.Kinship_id = CD_kinship.Kinship_id INNER JOIN CD_job ON TBL_members.mem_job = CD_job.job_id
                       WHERE TBL_Dependents.mem_ID_parent = " + mem_ID_parent);
            gridControlChild.DataSource = ChildMem;
        }
        private void ClearForm()
        {
            Txtmem_name.Text = string.Empty;
            Txtmem_mNUMBER.Text = string.Empty;
            Txtmem_mNUMBER.Text = string.Empty;
            TxtJob.Text = string.Empty;
            Txtmem_bdate.Text = string.Empty;
            Txtmembership_type.Text = string.Empty;
            Txtasasename.Text = string.Empty;
            Txtmembership_start_date.Text = string.Empty;
            Txtmembership_end_date.Text = string.Empty;
            MemPic.Image = null;
        }
        #endregion
        #region -   Event Handlers   -
        private void AttUserMainFrm_Load(object sender, EventArgs e)
        {
            TxtNo.Focus();
        }
        private void TxtNo_EditValueChanged(object sender, EventArgs e)
        {
            if (TxtNo.Text.Trim().Length <= 1)
                return;
            TxtNo.Visible = false;
            GetEmpInfo();
            TxtNo.Text = string.Empty;
            if (MemInfo.Rows.Count == 0)//If Mem Not Exit
            {
                TxtState.Text = "تم رفــــــض البطاقة";
                TxtState.ForeColor = Color.Red;
            }
            else
            {
                TxtState.Text = "تم قبـــــــول البطاقة";
                TxtState.ForeColor = Color.Lime;
            }

            TxtNo.Visible = true;
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}