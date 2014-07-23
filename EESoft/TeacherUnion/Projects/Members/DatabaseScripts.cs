using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Members
{
    public static class DatabaseScripts
    {

        public static void FireScript()
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.TeachersUnionConnectionString);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                con.Open();

                cmd.CommandText = UpdateNULLRandomCard;
                cmd.ExecuteNonQuery();

                cmd.CommandText = UpdateNULLuserin;
                cmd.ExecuteNonQuery();

                if (!CheckViewExists("vTBLPrintCard"))
                {
                    cmd.CommandText = vTBLPrintCard;
                    cmd.ExecuteNonQuery();
                }
                if (!CheckViewExists("vTBLMembersPlusTBLMemberHala"))
                {
                    cmd.CommandText = vTBLMembersPlusTBLMemberHala;
                    cmd.ExecuteNonQuery();
                }
                if (!CheckViewExists("vTBLMembersPlusShadetKed"))
                {
                    cmd.CommandText = vTBLMembersPlusShadetKed;
                    cmd.ExecuteNonQuery();
                }
                if (!CheckViewExists("vTBLMembersPlusTblMemberAttach"))
                {
                    cmd.CommandText = vTBLMembersPlusTblMemberAttach;
                    cmd.ExecuteNonQuery();
                }
                if (CheckViewExists("vTBLMembersQry05"))
                {
                    cmd.CommandText = DropView("vTBLMembersQry05");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = vTBLMembersQry05;
                cmd.ExecuteNonQuery();

                if (!CheckViewExists("vTBLMazroofPlusReceiptsQry29"))
                {
                    cmd.CommandText = vTBLMazroofPlusReceiptsQry29;
                    cmd.ExecuteNonQuery();
                }
                if (!CheckViewExists("vTBLMandoop"))
                {
                    cmd.CommandText = vTBLMandoop;
                    cmd.ExecuteNonQuery();
                }
                if (!CheckViewExists("vTBLAksatDetailes"))
                {
                    cmd.CommandText = vTBLAksatDetailes;
                    cmd.ExecuteNonQuery();
                }

                cmd.CommandText = DropSP("SPro_0001");
                cmd.ExecuteNonQuery();
                cmd.CommandText = SPro_0001;
                cmd.ExecuteNonQuery();

                if (!CheckViewExists("vQry33"))
                {
                    cmd.CommandText = vQry33;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Program.Logger.LogThis(FXFW.SqlDB.CheckExp(ex), "Fire Scripting", FXFW.Logger.OpType.success, null, ex, null);
            }
            con.Close();
        }

        public static bool CheckViewExists(string viewName)
        {
            bool exist = false;
            SqlConnection con = new SqlConnection(Properties.Settings.Default.TeachersUnionConnectionString);
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
        private static string DropView(string objName)
        {
            return string.Format(@"DROP VIEW [dbo].[{0}]", objName);
        }
        private static string DropSP(string objName)
        {
            return string.Format(@"IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[{0}]') AND type in (N'P', N'PC'))
                DROP PROCEDURE [dbo].[{0}]", objName);
        }
        public static string vTBLPrintCard
        {
            get
            {
                return @"CREATE VIEW [dbo].[vTBLPrintCard]
                AS
                SELECT [MemberId],[printed], [printdate], 
                (SELECT [MemberName] FROM [TBLMembers] WHERE [MemberId] = TBLPrintCard.MemberId) AS MemberName,
                (SELECT esalno FROM [TBLMembers] WHERE [MemberId] = TBLPrintCard.MemberId) AS esalno,
                (SELECT SyndicateId FROM [TBLMembers] WHERE [MemberId] = TBLPrintCard.MemberId) AS SyndicateId
                FROM [TBLPrintCard]";
            }
        }

        public static string vTBLMembersPlusTBLMemberHala
        {
            get
            {
                return @"CREATE VIEW [dbo].[vTBLMembersPlusTBLMemberHala]
                AS
                SELECT MemberId, MemberName, KideNumber, esalno,
                (SELECT Syndicate FROM CDSyndicate WHERE SyndicateId = TBLMembers.SyndicateId) AS Syndicate,
                (SELECT MemberSTypeName FROM CDMemberSType WHERE MemberSTypeId = 
	                (SELECT MemberSTypeId FROM TBLMemberHala WHERE MemberId = TBLMembers.MemberId AND datefrom =
		                (SELECT MAX(datefrom) FROM TBLMemberHala WHERE MemberId = TBLMembers.MemberId)
	                )
                ) AS MemberSTypeName
                    FROM TBLMembers";
            }
        }

        public static string vTBLMembersPlusShadetKed
        {
            get
            {
                return @"CREATE VIEW [dbo].[vTBLMembersPlusShadetKed]
                AS
                SELECT        dbo.TBLMembers.MemberId, dbo.TBLMembers.MemberName, dbo.CDSyndicate.Syndicate, dbo.CDSubCommitte.SubCommitte, dbo.TBLMembers.esalno, 
                            dbo.TBLMembers.KideNumber, dbo.CDJobtitle.Jobtitle, dbo.TBLMembers.ShadetKed, dbo.TBLMembers.MemberNId
                FROM            dbo.TBLMembers LEFT OUTER JOIN
                             dbo.CDJobtitle ON dbo.TBLMembers.JobtitleID = dbo.CDJobtitle.JobtitleID LEFT OUTER JOIN
                            dbo.CDSubCommitte ON dbo.TBLMembers.SubCommitteId = dbo.CDSubCommitte.SubCommitteId LEFT OUTER JOIN
                           dbo.CDSyndicate ON dbo.TBLMembers.SyndicateId = dbo.CDSyndicate.SyndicateId";
            }
        }

        public static string vTBLMembersPlusTblMemberAttach
        {
            get
            {
                return @"CREATE VIEW [dbo].[vTBLMembersPlusTblMemberAttach]
                AS
                SELECT MemberId, MemberName, KideNumber, esalno, img, 
                (SELECT Syndicate FROM CDSyndicate WHERE SyndicateId = TBLMembers.SyndicateId) AS Syndicate,
                (SELECT COUNT(MemberId) FROM TblMemberAttach WHERE MemberId = TBLMembers.MemberId) AS AttachCount
                FROM TBLMembers";
            }
        }

        public static string vTBLMembersQry05
        {
            get
            {
                return @"CREATE VIEW [dbo].[vTBLMembersQry05]
                AS
                SELECT        TBLMembers.MemberId, TBLMembers.MemberName, TBLMembers.KideNumber, TBLMembers.trheelprog, TBLMembers.SyndicateId, 
                         TBLMembers.SubCommitteId, TBLMembers.MemberShipNumber, TBLMembers.RandomCard,
                             (SELECT        SubCommitte
                                FROM            CDSubCommitte
                                WHERE        (SubCommitteId = TBLMembers.SubCommitteId)) AS SubCommitte,
                             (SELECT        Syndicate
                                FROM            CDSyndicate
                                WHERE        (SyndicateId = TBLMembers.SyndicateId)) AS Syndicate, TBLMembers.datein,
                             (SELECT        RealName
                                FROM            Users
                                WHERE        (UserID = TBLMembers.userin)) AS RealName, TBLMembers.esalno, CAST(NULL AS BINARY) AS Img,
                             (SELECT        RealName
                                FROM            Users AS Users_1
                                WHERE        (UserID = TBLPrintCard.userin)) AS RealNamePrint, TBLMembers.fawry, TBLPrintCard.printed, TBLPrintCard.printdate, TBLMembers.mEdited, 
                         TBLMembers.userEdit, Users_2.RealName AS EditUserName
                FROM TBLMembers LEFT OUTER JOIN
                         Users AS Users_2 ON TBLMembers.userEdit = Users_2.UserID LEFT OUTER JOIN
                         TBLPrintCard ON TBLMembers.MemberId = TBLPrintCard.MemberId";
//                return @"CREATE VIEW [dbo].[vTBLMembersQry05]
//                AS
//                SELECT        TBLMembers.MemberId, TBLMembers.MemberName, TBLMembers.KideNumber, TBLMembers.trheelprog, TBLMembers.SyndicateId, 
//                         TBLMembers.SubCommitteId, TBLMembers.MemberShipNumber, TBLMembers.RandomCard,
//                             (SELECT        SubCommitte
//                                FROM            CDSubCommitte
//                                WHERE        (SubCommitteId = TBLMembers.SubCommitteId)) AS SubCommitte,
//                             (SELECT        Syndicate
//                                FROM            CDSyndicate
//                                WHERE        (SyndicateId = TBLMembers.SyndicateId)) AS Syndicate,
//                             (SELECT        Sector
//                                FROM            CDSyndicate AS CDSyndicate_1
//                                WHERE        (SyndicateId = TBLMembers.SyndicateId)) AS Sector, TBLMembers.datein,
//                             (SELECT        RealName
//                                FROM            Users
//                                WHERE        (UserID = TBLMembers.userin)) AS RealName, TBLMembers.esalno, CAST(NULL AS BINARY) AS Img,
//                             (SELECT        RealName
//                                FROM            Users AS Users_1
//                                WHERE        (UserID = TBLPrintCard.userin)) AS RealNamePrint, TBLMembers.fawry, TBLPrintCard.printed, TBLPrintCard.printdate, TBLMembers.mEdited, 
//                         TBLMembers.userEdit, Users_2.RealName AS EditUserName, TBLHafzaTasleem.HafzaDate, TBLHafzaTasleem.ISMandoop, 
//                         TBLHafzaTasleem.Hafzaperson, TBLMandoop.MandoopName
//                FROM            TBLHafzaTasleemDeyails LEFT OUTER JOIN
//                         TBLMandoop RIGHT OUTER JOIN
//                         TBLHafzaTasleem ON TBLMandoop.MandoopId = TBLHafzaTasleem.Hafzaperson ON 
//                         TBLHafzaTasleemDeyails.HafzaId = TBLHafzaTasleem.HafzaId RIGHT OUTER JOIN
//                         TBLMembers ON TBLHafzaTasleemDeyails.MemberId = TBLMembers.MemberId LEFT OUTER JOIN
//                         Users AS Users_2 ON TBLMembers.userEdit = Users_2.UserID LEFT OUTER JOIN
//                         TBLPrintCard ON TBLMembers.MemberId = TBLPrintCard.MemberId";
            }
        }

        public static string vTBLMazroofPlusReceiptsQry29
        {
            get
            {
                return @"CREATE VIEW [dbo].[vTBLMazroofPlusReceiptsQry29]
                AS
                SELECT        dbo.TBLMazroof.ReceiptNo, dbo.TBLMazroof.mazroofno, dbo.TBLMazroof.WorkTypeId, dbo.TBLMazroof.workcount, dbo.TBLMazroof.workrem, 
                         dbo.TBLMazroof.userwork, dbo.TBLMazroof.datework, dbo.Receipts.ReceiptDate, dbo.Receipts.CardsCount, dbo.CDSyndicate.Syndicate, 
                         dbo.CDCardtype.Cardtype, dbo.Receipts.ReceiptAmount, dbo.CDWorkType.WorkType, dbo.Users.RealName
                FROM            dbo.CDWorkType RIGHT OUTER JOIN
                         dbo.TBLMazroof ON dbo.CDWorkType.WorkTypeId = dbo.TBLMazroof.WorkTypeId LEFT OUTER JOIN
                         dbo.CDCardtype RIGHT OUTER JOIN
                         dbo.Receipts ON dbo.CDCardtype.CardtypeId = dbo.Receipts.CardType LEFT OUTER JOIN
                         dbo.CDSyndicate ON dbo.Receipts.SyndicateId = dbo.CDSyndicate.SyndicateId ON dbo.TBLMazroof.ReceiptNo = dbo.Receipts.ReceiptNo LEFT OUTER JOIN
                         dbo.Users ON dbo.TBLMazroof.userwork = dbo.Users.UserID";
            }
        }

        public static string vTBLMandoop
        {
            get
            {
                return @"CREATE VIEW [dbo].[vTBLMandoop]
                AS
                SELECT dbo.TBLMandoop.MandoopId, dbo.TBLMandoop.MandoopName, dbo.TBLMandoop.MandoopNID, dbo.TBLMandoop.MandoopJOB, 
                dbo.TBLMandoop.MandoopMOBIL, dbo.TBLMandoop.MandoopEMAIL, dbo.TBLMandoop.SyndicateId, dbo.TBLMandoop.userin, dbo.TBLMandoop.datein, 
                dbo.TBLMandoop.MandoopImg, dbo.TBLMandoop.active, dbo.CDSyndicate.Syndicate, dbo.Users.RealName
                FROM dbo.TBLMandoop LEFT OUTER JOIN
                dbo.CDSyndicate ON dbo.TBLMandoop.SyndicateId = dbo.CDSyndicate.SyndicateId LEFT OUTER JOIN
                dbo.Users ON dbo.TBLMandoop.userin = dbo.Users.UserID";
            }
        }

        public static string vTBLAksatDetailes
        {
            get
            {
                return @"CREATE VIEW [dbo].[vTBLAksatDetailes]
                AS
                SELECT        dbo.TBLAksatDetailes.MemberId, dbo.TBLAksatDetailes.datesadad, dbo.TBLAksatDetailes.sdadmony, dbo.TBLAksatDetailes.datein, 
                dbo.TBLAksatDetailes.userin, dbo.TBLAksat.kestenddate, dbo.TBLAksat.mostahk, dbo.TBLAksat.madfoaa, dbo.TBLAksat.esalno, dbo.TBLAksat.esaldate, 
                dbo.Users.RealName, dbo.CDSyndicate.Syndicate, dbo.CDSubCommitte.SubCommitte, dbo.TBLMembers.MemberName, dbo.TBLMembers.KideNumber, 
                dbo.CDCardtype.Cardtype, dbo.TBLMembers.Installment, dbo.TBLMembers.fawry, dbo.TBLMembers.SyndicateId, dbo.TBLMembers.SubCommitteId
                FROM            dbo.TBLMembers LEFT OUTER JOIN
                dbo.CDCardtype ON dbo.TBLMembers.cardtype = dbo.CDCardtype.CardtypeId LEFT OUTER JOIN
                dbo.CDSubCommitte ON dbo.TBLMembers.SubCommitteId = dbo.CDSubCommitte.SubCommitteId LEFT OUTER JOIN
                dbo.CDSyndicate ON dbo.TBLMembers.SyndicateId = dbo.CDSyndicate.SyndicateId RIGHT OUTER JOIN
                dbo.TBLAksat ON dbo.TBLMembers.MemberId = dbo.TBLAksat.MemberId RIGHT OUTER JOIN
                dbo.TBLAksatDetailes LEFT OUTER JOIN
                dbo.Users ON dbo.TBLAksatDetailes.userin = dbo.Users.UserID ON dbo.TBLAksat.MemberId = dbo.TBLAksatDetailes.MemberId";
            }
        }

        public static string UpdateNULLRandomCard
        {
            get
            {
                return @"update TBLMembers set RandomCard = 123 where RandomCard is null";
            }
        }

        public static string UpdateNULLuserin
        {
            get
            {
                return @"update TBLMembers set userin = 1 where userin is null";
            }
        }

        public static string SPro_0001
        {
            get
            {
                return @"
                -- =============================================
                -- Author:		<Author,,Name>
                -- Create date: <Create Date,,>
                -- Description:	<Creating memory table to search fast with criteria 'Sector',,>
                -- =============================================
                CREATE PROCEDURE [dbo].[SPro_0001]
	                -- Add the parameters for the stored procedure here
	                --@Sector tinyint
	
                AS
                BEGIN
	                -- SET NOCOUNT ON added to prevent extra result sets from
	                -- interfering with SELECT statements.
	                SET NOCOUNT ON;

                    -- Insert statements for procedure here
	                DECLARE @TempTable table (MemberId int, MemberName NVARCHAR(MAX), KideNumber NVARCHAR(MAX), MemberShipNumber NVARCHAR(MAX), esalno NVARCHAR(MAX), HafzaId INT, ISMandoop BIT, Hafzaperson INT, HafzapersonText NVARCHAR(MAX),
	                MandoopName NVARCHAR(MAX), Syndicate NVARCHAR(MAX), Sector TINYINT, SubCommitte NVARCHAR(MAX))


                INSERT INTO @TempTable
                SELECT        TBLMembers.MemberId, TBLMembers.MemberName, TBLMembers.KideNumber, TBLMembers.MemberShipNumber, TBLMembers.esalno, 
                                         TBLHafzaTasleemDeyails.HafzaId, TBLHafzaTasleem.ISMandoop, TBLHafzaTasleem.Hafzaperson, TBLHafzaTasleem.HafzapersonText, 
                                         TBLMandoop.MandoopName, CDSyndicate.Syndicate, CDSyndicate.Sector, CDSubCommitte.SubCommitte
                FROM            TBLHafzaTasleem LEFT OUTER JOIN
                                         TBLMandoop ON TBLHafzaTasleem.Hafzaperson = TBLMandoop.MandoopId RIGHT OUTER JOIN
                                         TBLHafzaTasleemDeyails ON TBLHafzaTasleem.HafzaId = TBLHafzaTasleemDeyails.HafzaId RIGHT OUTER JOIN
                                         CDSubCommitte RIGHT OUTER JOIN
                                         TBLMembers ON CDSubCommitte.SubCommitteId = TBLMembers.SubCommitteId LEFT OUTER JOIN
                                         CDSyndicate ON TBLMembers.SyndicateId = CDSyndicate.SyndicateId ON TBLHafzaTasleemDeyails.MemberId = TBLMembers.MemberId
                SELECT * FROM @TempTable --WHERE Sector = @Sector
                --DELETE TempTable
	
                END
                ";
            }
        }

        public static string vQry33
        {
            get
            {
                return @"CREATE VIEW [dbo].[vQry33]
                AS
                SELECT        dbo.TBLMazroof.ReceiptNo, dbo.TBLMazroof.mazroofno, dbo.TBLMazroof.WorkTypeId, dbo.TBLMazroof.workcount, dbo.TBLMazroof.workrem, dbo.TBLMazroof.userwork, dbo.TBLMazroof.datework, 
                         dbo.CDWorkType.WorkType, dbo.Receipts.ReceiptDate, dbo.Users.RealName
                FROM            dbo.TBLMazroof INNER JOIN
                         dbo.CDWorkType ON dbo.TBLMazroof.WorkTypeId = dbo.CDWorkType.WorkTypeId LEFT OUTER JOIN
                         dbo.Users ON dbo.TBLMazroof.userwork = dbo.Users.UserID LEFT OUTER JOIN
                         dbo.Receipts ON dbo.TBLMazroof.ReceiptNo = dbo.Receipts.ReceiptNo";
            }
        }


    }


}
