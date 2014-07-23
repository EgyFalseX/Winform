using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace E_Club_Mem_Manager
{
    public partial class AddDependentFrm : Form
    {
        #region -   Variables   -
        DataTable MembersTable = new DataTable("Members");
        DataTable DependentsTable = new DataTable("Dependents");
        DataTable SelectedDepsTable = new DataTable("SelectedDeps");
        DataTable RelationTypesTable = new DataTable("RelationTypes");
        #endregion
        #region -   Functions   -
        public AddDependentFrm()
        {
            InitializeComponent();
        }
        private void LoadAllMembersAndRelationTypes()
        {
            MembersTable = new DataTable("Members");
            RelationTypesTable = new DataTable("RelationTypes");
            SqlDataAdapter DA = new SqlDataAdapter("", Program.MC.SQLConStrMembers);
            try
            {
                //Load All Members
                DA.SelectCommand.CommandText = "SELECT mem_ID, mem_name, Subscription_type_id FROM TBL_members WHERE (Subscription_type_id = 1) OR (Subscription_type_id = 2)";
                DA.Fill(MembersTable);
                CBMembers.DataSource = MembersTable;
                CBMembers.ValueMember = "mem_ID";
                CBMembers.DisplayMember = "mem_name";
                //Load Relation Types
                DA.SelectCommand.CommandText = "SELECT Kinship_id, Kinship FROM CD_kinship";
                DA.Fill(RelationTypesTable);
                CBRelationType.DataSource = RelationTypesTable;
                CBRelationType.ValueMember = "Kinship_id";
                CBRelationType.DisplayMember = "Kinship";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadMemberDeps(string MemberID)
        {
            SelectedDepsTable = new DataTable("SelectedDeps");
            DependentsTable = new DataTable("Dependents");
            SqlDataAdapter DA = new SqlDataAdapter("NULL@LOAD", Program.MC.SQLConStrMembers);
            try
            {
                //Load Select Dependents
                DA.SelectCommand.CommandText = String.Format("SELECT mem_ID_child, mem_ID_parent, (SELECT mem_name FROM TBL_members WHERE (mem_ID = TBL_Dependents.mem_ID_child)) AS child_name FROM TBL_Dependents WHERE (mem_ID_parent = {0}) AND (Still = 1)", MemberID);
                DA.Fill(SelectedDepsTable);
                LUESelected.Properties.DataSource = SelectedDepsTable;
                LUESelected.Properties.ValueMember = "mem_ID_child";
                LUESelected.Properties.DisplayMember = "child_name";
                //Load Not Select Dependents
                DA.SelectCommand.CommandText = "SELECT mem_ID, mem_name FROM TBL_members WHERE (Subscription_type_id = 3)";
                DA.Fill(DependentsTable);
                DataTable FixedDependents = new DataTable();
                FixedDependents.Rows.Clear();
                foreach (DataRow DRAll in DependentsTable.Rows)
                {
                    foreach (DataRow DRSelected in SelectedDepsTable.Rows)
                    {
                        if (DRAll[0].ToString() == DRSelected[0].ToString())
                        {
                            DRAll.Delete();
                            break;
                        }
                    }
                }
                CBRelatedmembers.DataSource = DependentsTable;
                CBRelatedmembers.ValueMember = "mem_ID";
                CBRelatedmembers.DisplayMember = "mem_name";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AddDependent(string Parent, string Child, string Relation)
        {
            SqlConnection Con = new SqlConnection(Program.MC.SQLConStrMembers);
            SqlCommand CMD = new SqlCommand("INSERT INTO TBL_Dependents (mem_ID_parent, mem_ID_child, Kinship_id) VALUES (" + Parent + ", " + Child + ", " + Relation + ")", Con);
            try
            {
                Con.Open();
                CMD.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Con.Close();
        }
        private void DelDependent(string Parent, string Child)
        {
            SqlConnection Con = new SqlConnection(Program.MC.SQLConStrMembers);
            SqlCommand CMD = new SqlCommand("DELETE FROM TBL_Dependents WHERE (mem_ID_parent = " + Parent + ") AND (mem_ID_child = " + Child + ")", Con);
            try
            {
                Con.Open();
                CMD.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Con.Close();
        }
        
#endregion
        #region -   Event Handlers   -
        private void AddDependentFrm_Load(object sender, EventArgs e)
        {
            LoadAllMembersAndRelationTypes();
        }
        private void CBMembers_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMemberDeps(MembersTable.Rows[CBMembers.SelectedIndex][0].ToString());
        }
        private void BtnAsdd_Click(object sender, EventArgs e)
        {
            if (CBRelatedmembers.SelectedIndex != -1)
            {
                string Parent = CBMembers.SelectedValue.ToString();
                string Child = CBRelatedmembers.SelectedValue.ToString();
                string Relation = CBRelationType.SelectedValue.ToString();
                AddDependent(Parent, Child, Relation);
                LoadMemberDeps(MembersTable.Rows[CBMembers.SelectedIndex][0].ToString());
            }
        }
        private void LUESelected_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind != DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)
                return;
            if (LUESelected.ItemIndex < 0)
                return;
            string Parent = CBMembers.SelectedValue.ToString();
            string Child = LUESelected.EditValue.ToString();
            DelDependent(Parent, Child);
            LoadMemberDeps(MembersTable.Rows[CBMembers.SelectedIndex][0].ToString());

        }
        #endregion

        

        
        
    }
}
