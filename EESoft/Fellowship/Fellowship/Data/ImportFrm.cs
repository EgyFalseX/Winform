using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace Fellowship.Data
{
    public partial class ImportFrm : DevExpress.XtraEditors.XtraForm
    {
        public ImportFrm()
        {
            InitializeComponent();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            dsFellowship.TblAllData.Clear();
            try
            {
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.Abort)
                    return;
                //string constr = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0}", ofd.FileName);
                string constr = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Persist Security Info=True", ofd.FileName);
                //Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Persist Security Info=True"
                DataSources.DSFellowshipTableAdapters.TblAllDataTableAdapter adp = new DataSources.DSFellowshipTableAdapters.TblAllDataTableAdapter();
                DateTime datein = (DateTime)new DataSources.DSFellowshipQueryTableAdapters.QueriesTableAdapter().ServerDatetime();
                OleDbDataAdapter adpAccess = new OleDbDataAdapter("SELECT * FROM zdata", constr);
                DataTable dt = new DataTable();

                int edaraid = 0;
                byte govid = 0;
                adpAccess.SelectCommand.CommandText = "SELECT max(zdata.govid) as govid, max(zdata.edaraid) as edaraid FROM zdata";
                adpAccess.Fill(dt);
                govid = Convert.ToByte(dt.Rows[0]["govid"]); edaraid = Convert.ToInt32(dt.Rows[0]["edaraid"]);

                adpAccess.SelectCommand.CommandText = "SELECT * FROM zdata";
                adpAccess.Fill(dt);
                int index = 0;
                pbc.EditValue = index;
                pbc.Properties.Maximum = dt.Rows.Count;
                int Id = (int)adp.NewId();
                foreach (DataRow row in dt.Rows)
                {
                    index++; pbc.EditValue = index;
                    if (row["NAME"].ToString() == string.Empty || row["bdate"].ToString() == string.Empty || row["taeendate"].ToString() == string.Empty || row["salary"].ToString() == string.Empty || row["govid"].ToString() == string.Empty || row["edaraid"].ToString() == string.Empty)
                        continue;
                    DataSources.DSFellowship.TblAllDataRow mem = dsFellowship.TblAllData.NewTblAllDataRow();
                    mem.memberid = Id + index;
                    mem.membernid = row["membernid"].ToString();
                    mem.MNAME = row["NAME"].ToString();
                    if (row["bdate"].ToString() != string.Empty)
                        mem.bdate = Convert.ToDateTime(row["bdate"]);
                    if (row["schoolcode"].ToString() != string.Empty)
                        mem.schoolcode = Convert.ToInt32(row["schoolcode"]);
                    if (row["taeendate"].ToString() != string.Empty)
                        mem.taeendate = Convert.ToDateTime(row["taeendate"]);
                    if (row["salary"].ToString() != string.Empty)
                        mem.salary = Convert.ToDouble(row["salary"]);
                    if (row["govid"].ToString() != string.Empty)
                    {
                        if (row["govid"].ToString() == "0")
                            mem.govid = govid;
                        else
                            mem.govid = Convert.ToByte(row["govid"]);
                    }
                    if (row["edaraid"].ToString() != string.Empty)
                    {
                        if (row["edaraid"].ToString() == "0")
                            mem.edaraid = edaraid;
                        else
                            mem.edaraid = Convert.ToInt32(row["edaraid"]);
                    }
                    mem.mobil = row["mobil"].ToString();
                    mem.address = row["address"].ToString();
                    if (row["moahedcode"].ToString() != string.Empty)
                        mem.moahedcode = Convert.ToInt32(row["moahedcode"]);
                    if (row["moaheldate"].ToString() != string.Empty)
                        mem.moaheldate = Convert.ToDateTime(row["moaheldate"]);
                    if (row["jobcode"].ToString() != string.Empty)
                        mem.jobcode = Convert.ToInt32(row["jobcode"]);
                    mem.rema = row["rema"].ToString();
                    mem.datein = datein;
                    mem.userin = Program.UserInfo.UserId;

                    dsFellowship.TblAllData.AddTblAllDataRow(mem);
                }

                SqlConnection con = new SqlConnection(Properties.Settings.Default.FellowshipConnectionString);
                SqlCommand cmd = new SqlCommand("", con);
                con.Open();
                UpdateMembers(cmd, dsFellowship.TblAllData);
                con.Close();
                dsFellowship.TblMember.Clear();
                dt.Clear(); dt.Dispose();

                pbc.EditValue = 0;
                Program.ShowMsg("تم الحفظ", false, this);
                Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(Misc.Misc.ExceptionMessage(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, ex, null, this);
            }
            
        }
        public bool UpdateMembers(SqlCommand cmd, DataSources.DSFellowship.TblAllDataDataTable BulkTable)
        {
            bool outPut = false;
            DateTime dtStart = DateTime.Now;
            string BulkTableName = string.Format("TblAllData{0}{1}{2}{3}{4}{5}{6}", dtStart.Year, dtStart.Month, dtStart.Day, dtStart.Hour, dtStart.Minute, dtStart.Second, dtStart.Millisecond);
            cmd.CommandText = string.Format(@"SELECT * INTO {0} FROM TblAllData WHERE 1 = 0;", BulkTableName);
            cmd.ExecuteNonQuery();

            try
            {
                SqlBulkCopy bulkCopy = new SqlBulkCopy(cmd.Connection);
                bulkCopy.ColumnMappings.Clear();
                bulkCopy.ColumnMappings.Add("memberid", "memberid"); bulkCopy.ColumnMappings.Add("membernid", "membernid");
                bulkCopy.ColumnMappings.Add("MNAME", "MNAME"); bulkCopy.ColumnMappings.Add("bdate", "bdate");
                bulkCopy.ColumnMappings.Add("schoolcode", "schoolcode"); bulkCopy.ColumnMappings.Add("taeendate", "taeendate");
                bulkCopy.ColumnMappings.Add("salary", "salary"); bulkCopy.ColumnMappings.Add("govid", "govid");
                bulkCopy.ColumnMappings.Add("edaraid", "edaraid"); bulkCopy.ColumnMappings.Add("mobil", "mobil");
                bulkCopy.ColumnMappings.Add("address", "address"); bulkCopy.ColumnMappings.Add("moahedcode", "moahedcode");
                bulkCopy.ColumnMappings.Add("moaheldate", "moaheldate"); bulkCopy.ColumnMappings.Add("jobcode", "jobcode");
                bulkCopy.ColumnMappings.Add("rema", "rema");
                bulkCopy.ColumnMappings.Add("userin", "userin"); bulkCopy.ColumnMappings.Add("datein", "datein");

                bulkCopy.DestinationTableName = BulkTableName;
                bulkCopy.BatchSize = BulkTable.Count;
                bulkCopy.WriteToServer(BulkTable);

                cmd.CommandText = string.Format(@"INSERT INTO [dbo].[TblAllData]
                SELECT * FROM {0}", BulkTableName);
//                cmd.CommandText = string.Format(@"merge into TblAllData as Target 
//                using {0} as Source on Target.memberid = Source.memberid when matched then 
//                update set 
//                Target.membernid = Source.membernid,
//                Target.MNAME = Source.MNAME,
//                Target.bdate = Source.bdate,
//                Target.schoolcode = Source.schoolcode,
//                Target.taeendate = Source.taeendate,
//                Target.salary = Source.salary,
//                Target.govid = Source.govid,
//                Target.edaraid = Source.edaraid,
//                Target.mobil = Source.mobil,
//                Target.address = Source.address,
//                Target.moahedcode = Source.moahedcode,
//                Target.moaheldate = Source.moaheldate,
//                Target.jobcode = Source.jobcode,
//                Target.rema = Source.rema,
//                Target.userin = Source.userin,
//                Target.datein = Source.datein
//                when not matched then 
//                insert (MemberID, membernid, MNAME,bdate,schoolcode,taeendate,salary,govid,edaraid,mobil,address,moahedcode,moaheldate,jobcode,rema, userin, datein) values 
//                (Source.MemberID, Source.membernid, Source.MNAME,Source.bdate,Source.schoolcode,Source.taeendate,Source.salary,Source.govid,Source.edaraid,Source.mobil,Source.address,
//                Source.moahedcode,Source.moaheldate,Source.jobcode,Source.rema, Source.userin, Source.datein);", BulkTableName);
                cmd.ExecuteNonQuery();
                cmd.CommandText = string.Format(@"DROP TABLE {0}", BulkTableName);
                cmd.ExecuteNonQuery();
                outPut = true;
            }
            catch (SqlException ex)
            {
                Program.ShowMsg(Misc.Misc.ExceptionMessage(ex), true, this);
                Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, ex, null, this);
            }
            return outPut;
        }

    }
}