using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Data.SqlClient;

namespace ChangeTargatedName
{
    public partial class ChangeTrgatedNameFrm : Form
    {
        #region -   Variables   -
        string coStr = string.Empty;
        #endregion
        #region -   Functions   -
        public static void PrepareReg()
        {
            RegistryKey RegKey = Registry.LocalMachine.OpenSubKey("SOFTWARE", true);
            string[] arr;
            arr = Registry.LocalMachine.OpenSubKey("SOFTWARE").GetSubKeyNames();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == "EYTAP")
                {
                    return;
                }
            }
            RegKey.CreateSubKey("EYTAP");
        }
        public static string GetRegValue(string ValueName)
        {
            PrepareReg();
            string ReturnMe = string.Empty;
            string[] arr = Registry.LocalMachine.OpenSubKey("SOFTWARE\\EYTAP", false).GetValueNames();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == ValueName)
                {
                    ReturnMe = (string)Registry.LocalMachine.OpenSubKey("SOFTWARE\\EYTAP", false).GetValue(ValueName);
                    break;
                }
            }
            return ReturnMe;
        }
        public ChangeTrgatedNameFrm()
        {
            InitializeComponent();
        }
        #endregion
        #region -   Event Handlers   -
        private void ChangeTrgatedNameFrm_Load(object sender, EventArgs e)
        {
            coStr = GetRegValue("SQLStringEYTAP");
            if (coStr == string.Empty)
            {
                MessageBox.Show("Connection didnt saved in this computer", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnChange.Enabled = false;
            }
            try
            {
                using (SqlConnection con = new SqlConnection(coStr))
                {
                    con.Open();
                    con.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.Number.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                BtnChange.Enabled = false;
            }


        }
        private void BtnChange_Click(object sender, EventArgs e)
        {
            PB.Value = 0;
            if (TxtFrom.Text.Length == 0 || TxtTo.Text.Length == 0 )
            {
                MessageBox.Show("Please Enter Text");
                return;
            }
            SqlDataAdapter da = new SqlDataAdapter("Select TargetedId, TargetedName, FirstName, MiddleName, FamilyName From ActivityTargeted", new SqlConnection(coStr));
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("There is no Targated", "Table Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            BtnChange.Enabled = false;
            TxtFrom.Enabled = false;
            TxtTo.Enabled = false;
            SqlConnection con = new SqlConnection(coStr);
            SqlCommand cmd = new SqlCommand("", con);
            string TargetedName = string.Empty;
            try
            {
                con.Open();
                PB.Maximum = dt.Rows.Count;
                foreach (DataRow row in dt.Rows)
                {
                    PB.Value++;
                    Application.DoEvents();
                    if (row["FirstName"].ToString() == TxtFrom.Text)
                    {
                        TargetedName = String.Format("{0} {1} {2}", TxtTo.Text, row["MiddleName"], row["FamilyName"]);
                        cmd.CommandText = string.Format(@"UPDATE ActivityTargeted SET FirstName = N'{0}', MiddleName = N'{1}', FamilyName = N'{2}', TargetedName = N'{3}'
                                WHERE TargetedId = {4}", TxtTo.Text, row["MiddleName"], row["FamilyName"], TargetedName, row["TargetedId"]);
                        cmd.ExecuteNonQuery();
                    }
                    if (row["MiddleName"].ToString() == TxtFrom.Text)
                    {
                        TargetedName = String.Format("{0} {1} {2}", row["FirstName"], TxtTo.Text, row["FamilyName"]);
                        cmd.CommandText = string.Format(@"UPDATE ActivityTargeted SET FirstName = N'{0}', MiddleName = N'{1}', FamilyName = N'{2}', TargetedName = N'{3}'
                                WHERE TargetedId = {4}", row["FirstName"], TxtTo.Text, row["FamilyName"], TargetedName, row["TargetedId"]);
                        cmd.ExecuteNonQuery();
                    }
                    if (row["FamilyName"].ToString() == TxtFrom.Text)
                    {
                        TargetedName = String.Format("{0} {1} {2}", row["FirstName"], row["MiddleName"], TxtTo.Text);
                        cmd.CommandText = string.Format(@"UPDATE ActivityTargeted SET FirstName = N'{0}', MiddleName = N'{1}', FamilyName = N'{2}', TargetedName = N'{3}'
                                WHERE TargetedId = {4}", row["FirstName"], row["MiddleName"], TxtTo.Text, TargetedName, row["TargetedId"]);
                        cmd.ExecuteNonQuery();
                    }
                }
                cmd.CommandText = string.Format("Update CDPeopleName Set PeopleName = N'{0}' Where PeopleName = N'{1}'", TxtTo.Text, TxtFrom.Text);
                cmd.ExecuteNonQuery();

                DataTable pplName = new DataTable();
                da.SelectCommand.CommandText = string.Format(@"Select PeopleNameId From CDPeopleName Where PeopleName = N'{0}'", TxtTo.Text);
                da.Fill(pplName);
                for (int i = 0; i < pplName.Rows.Count - 1; i++)
                {
                    cmd.CommandText = @"Delete From CDPeopleName Where PeopleNameId = " + pplName.Rows[i]["PeopleNameId"];
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Changing Complate", "Done ..!", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.Number.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
            PB.Value = 0;
            BtnChange.Enabled = true;
            TxtFrom.Enabled = true;
            TxtTo.Enabled = true;
        }
        private void BtnRemoveAll_Click(object sender, EventArgs e)
        {
            BtnChange.Enabled = false;
            BtnRemoveAll.Enabled = false;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select PeopleNameId, PeopleName From CDPeopleName", new SqlConnection(coStr));
            da.Fill(dt);
            PB.Maximum = dt.Rows.Count;
            PB.Value = 0;
            SqlConnection con = new SqlConnection(coStr);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                con.Open();
                foreach (DataRow row in dt.Rows)
                {
                    cmd.CommandText = string.Format(@"Delete From CDPeopleName Where PeopleNameId <> {0} And PeopleName = N'{1}'", row["PeopleNameId"], row["PeopleName"]);
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        con.Close();
                        BtnRemoveAll_Click(sender, e);
                        return;
                    }
                    PB.Value++;
                    Application.DoEvents();
                }
                MessageBox.Show("Removing Complate", "Done ..!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.Number.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
            PB.Value = 0;
            BtnChange.Enabled = true;
            BtnRemoveAll.Enabled = true;
        }
        #endregion
    }
}
