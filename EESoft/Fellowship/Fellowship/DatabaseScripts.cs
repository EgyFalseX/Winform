using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Fellowship
{
    public static class DatabaseScripts
    {

        public static void FireScript()
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.FellowshipConnectionString);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                con.Open();

                if (CheckViewExists("vQry002"))
                {
                    cmd.CommandText = DropObject("vQry002");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = vQry002;
                cmd.ExecuteNonQuery();


            }
            catch (SqlException ex)
            {
                Program.Logger.LogThis(FXFW.SqlDB.CheckExp(ex), "Fire Scripting", FXFW.Logger.OpType.success, null, ex, null);
            }
            con.Close();
        }

        private static bool CheckViewExists(string viewName)
        {
            bool exist = false;
            SqlConnection con = new SqlConnection(Properties.Settings.Default.FellowshipConnectionString);
            SqlCommand cmd = new SqlCommand("", con);
            cmd.CommandText = string.Format(@"IF EXISTS(select * FROM sys.views where name = '{0}')
                                            SELECT 1
                                            ELSE
                                            SELECT 0", viewName);
            try
            {
                con.Open();
                if (cmd.ExecuteScalar().ToString() == "1")
                    exist = true;
                else
                    exist = false;
            }
            catch (SqlException ex)
            {
                Program.Logger.LogThis(FXFW.SqlDB.CheckExp(ex), "Fire Scripting", FXFW.Logger.OpType.success, null, ex, null);
            }
            con.Close();
            return exist;
        }
        private static string DropObject(string objName)
        {
            return string.Format(@"DROP VIEW [dbo].[{0}]", objName);
        }
        private static string vQry002
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[vQry002]
                AS
                SELECT        COUNT(dbo.TblAllData.memberid) AS MEM, dbo.TblAllData.schoolcode, dbo.TblAllData.govid, dbo.TblAllData.edaraid, dbo.TblAllData.moahedcode, dbo.TblAllData.jobcode, dbo.CDGov.GOV, dbo.CdEdara.Edara, 
                         dbo.CdMoahel.Moahel, dbo.school.School, dbo.CdJobId.Job
                FROM            dbo.TblAllData LEFT OUTER JOIN
                                         dbo.school ON dbo.TblAllData.schoolcode = dbo.school.code LEFT OUTER JOIN
                                         dbo.CdJobId ON dbo.TblAllData.jobcode = dbo.CdJobId.JobId LEFT OUTER JOIN
                                         dbo.CDGov ON dbo.TblAllData.govid = dbo.CDGov.GovId LEFT OUTER JOIN
                                         dbo.CdEdara ON dbo.TblAllData.edaraid = dbo.CdEdara.EdaraId LEFT OUTER JOIN
                                         dbo.CdMoahel ON dbo.TblAllData.moahedcode = dbo.CdMoahel.MoahelId
                GROUP BY dbo.TblAllData.schoolcode, dbo.TblAllData.govid, dbo.TblAllData.edaraid, dbo.TblAllData.moahedcode, dbo.TblAllData.jobcode, dbo.CDGov.GOV, dbo.CdEdara.Edara, dbo.CdMoahel.Moahel, dbo.school.School, 
                                         dbo.CdJobId.Job";
            }
        }

    }
}
