using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace Student
{
    public partial class CD_AsaseFrm : DevExpress.XtraEditors.XtraForm
    {
        
        #region -   Variables   -
        
        #endregion
        #region -   Functions   -
        public CD_AsaseFrm()
        {
            InitializeComponent();
        }
        private void LoadDefaultData()
        {
            repositoryItemGridLookUpEditSPOS.DataSource = FXFW.SqlDB.LoadDataTable(@"if not exists(SELECT * FROM CDEDARET WHERE EPOS = 1)
            BEGIN
                INSERT INTO CDEDARET (EPOS, EDARET) VALUES (1, N'test')
                INSERT INTO TBLSCHOOL (markaz_code, whda_code, NOEDARET, marhala_code, SPOS, SCHOOL, worko, provet, moratabat, تطوير, تحسين, اعتماد, كير)
                VALUES (1, 1, 1, 1, 1, N'test', 1, 1, 1, 0, 0, 0, 0)
                SELECT SPOS, SCHOOL, SCHOOl_e FROM TBLSCHOOL
            END
            ELSE
            BEGIN
               SELECT SPOS, SCHOOL, SCHOOl_e FROM TBLSCHOOL
            END");
            repositoryItemGridLookUpEditSPOS.DisplayMember = "SCHOOL";
            repositoryItemGridLookUpEditSPOS.ValueMember = "SPOS";
        }
        private void LoadGrid()
        {
            gridControlData.DataSource = FXFW.SqlDB.LoadDataTable(@"SELECT asase_code, asase_year, SPOS FROM CD_Asase");
        }
        private void ActiveKeyDownEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyData != Keys.F5 && e.KeyData != Keys.F6 && e.KeyData != Keys.F10 && e.KeyData != Keys.F8)
                return;
            switch (e.KeyData)
            {
                case Keys.F1:
                    break;
                case Keys.F5:
                    ((DataTable)gridControlData.DataSource).Rows.Add(((DataTable)gridControlData.DataSource).NewRow());
                    break;
                case Keys.F6:
                    repositoryItemButtonEditSave_ButtonClick(repositoryItemButtonEditSave, new DevExpress.XtraEditors.Controls.ButtonPressedEventArgs(new DevExpress.XtraEditors.Controls.EditorButton()));
                    break;
                case Keys.F8:
                    repositoryItemButtonEditDel_ButtonClick(repositoryItemButtonEditDel, new DevExpress.XtraEditors.Controls.ButtonPressedEventArgs(new DevExpress.XtraEditors.Controls.EditorButton()));
                    break;
                case Keys.F10:
                    repositoryItemButtonEditSave_ButtonClick(repositoryItemButtonEditSave, new DevExpress.XtraEditors.Controls.ButtonPressedEventArgs(new DevExpress.XtraEditors.Controls.EditorButton()));
                    break;
                default:
                    break;
            }
        }
        private void ActivePriv()
        {
            bool Selecting = false, Inserting = false, Updateing = false, Deleting = false;
            FXFW.SqlDB.GetFormPriv("Stu" + Name.Replace("Frm", ""), ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);
            gridControlData.Visible = Selecting;
            if (Inserting || Updateing)
                repositoryItemButtonEditSave.Buttons[0].Enabled = true;
            else
                repositoryItemButtonEditSave.Buttons[0].Enabled = false;
            repositoryItemButtonEditDel.Buttons[0].Enabled = Deleting;
        }
#endregion
        #region - Event Handlers -
        private void CD_AsaseFrm_Load(object sender, EventArgs e)
        {
            LoadDefaultData();
            LoadGrid();
            ActivePriv();
        }
        private void repositoryItemButtonEditSave_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            DataRow row = gridViewCD_Asase.GetFocusedDataRow();
            string SPOS;
            if (row["SPOS"].ToString() == string.Empty)
                SPOS = "NULL";
            else
                SPOS = row["SPOS"].ToString();
            try
            {
                if (row["asase_code"].ToString() == string.Empty)
                {
                    cmd.CommandText = string.Format(@"Insert Into CD_Asase (asase_code, asase_year, SPOS) VALUES ((SELECT ISNULL(MAX(asase_code) + 1, 1) 
                    FROM CD_Asase), N'{0}', {1})", row["asase_year"], SPOS);
                }
                else
                {
                    cmd.CommandText = string.Format(@"Update CD_Asase Set asase_year = N'{0}', SPOS = {1} Where asase_code = {2}",
                    row["asase_year"], SPOS, row["asase_code"]);
                }
                con.Open();
                cmd.ExecuteNonQuery();
                Program.ShowMsg("تم الحفظ", false, this);
                Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
                LoadGrid();
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        private void repositoryItemButtonEditDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد؟", "تحزير ...", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            SqlConnection con = new SqlConnection(FXFW.SqlDB.SqlConStr);
            SqlCommand cmd = new SqlCommand("", con);
            DataRow row = gridViewCD_Asase.GetFocusedDataRow();
            if (row["asase_code"].ToString() == string.Empty)
            {
                LoadGrid();
                return;
            }
            try
            {
                cmd.CommandText = @"Delete From CD_Asase Where asase_code = " + row["asase_code"];
                con.Open();
                cmd.ExecuteNonQuery();
                Program.ShowMsg("تم الحذف", false, this);
                Program.Logger.LogThis("تم الحذف", Text, FXFW.Logger.OpType.success, null, null, this);
                LoadGrid();
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(FXFW.SqlDB.CheckExp(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, null, ex, this);
            }
        }
        #endregion
    }
}