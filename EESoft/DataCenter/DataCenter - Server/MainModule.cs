using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System;
using FunctionLib;
using System.IO;
using System.Data.SqlClient;

namespace DataCenter_Server
{
	sealed class MainModule
	{
		//Dll Defenation
		public static FunctionLib.DataCenterServerLib FunLib = new FunctionLib.DataCenterServerLib();
		//Forms Defenation
        public static SQLConnectionFrm FrmSQLConnection = new SQLConnectionFrm();
		public static SplashScreen SC = new SplashScreen();
		public static LoginForm FrmLogin = new LoginForm();
		public static MSGBOXFrm FrmMSG;
		public static FilesCheckerFrm FrmFilesChecker = new FilesCheckerFrm();
		public static MainForm FrmMainForm = new MainForm();
		public static ObjectPropertyFrm FrmObjectProperty = new ObjectPropertyFrm();
		public static PrivilegesFrm FrmPrivileges = new PrivilegesFrm();
		public static UsersPrivilegesFrm FrmUsersPrivileges = new UsersPrivilegesFrm();
		public static EditUsersFrm FrmUsers = new EditUsersFrm();
		public static DisactivatedUsersFrm FrmDisactivatedUsers = new DisactivatedUsersFrm();
		public static WizradFrm FrmWizrad = new WizradFrm();
		public static OptionsFrm FrmOptions = new OptionsFrm();
		public static NewFileTypesFrm FrmNewFileTypes = new NewFileTypesFrm();
		public static EditFileTypesFrm FrmEditFileTypes = new EditFileTypesFrm();
		public static LockedFilesFrm FrmLockedFiles = new LockedFilesFrm();
        public static StuFileTypeFrm FrmStuFileType = new StuFileTypeFrm();
        public static StuObjectPropertyFrm FrmStuObjectProperty = new StuObjectPropertyFrm();
		
		//Options
		public static string AdminID = "0001";
		public static string DefaultUserPassword; //= "123456"
		public static string ProjectsPath; //= "D:\MDC\Projects\"
		//public static string RelatedFiles; //= "D:\MDC\Related Files\"
		public static string ServerPort;
		public static string ServerIP;
		public static string DeletedFilesPath;
        public static string StudentFilesPath;
        public static string EmpFilesPath;
		//Vars
		private static string ErrorProvider = null;
		//Structures
		public enum ObjectType
		{
			Project,
			File,
			NewFolder,
			ExistedFolder
		}
		public struct ObjectProperty
		{
			public short FileIndex;
			public string FolderIndex;
			public ObjectType ObjecyType;
		}
		public static ObjectProperty PropertyObjectInfo = new ObjectProperty();
		//public static FunctionLib.DataCenterServerLib.ProjectInfo ProjectInfoSTR;
		static public void Main()
		{
            MainModule.SC = new SplashScreen();
            MainModule.SC.ShowDialog();
            // Load Data From Registry
            //FunctionLib.
            MCls.SQLConStr = MCls.GetRegValue(MCls.RegKeyValues.SQLString.ToString());
            FunLib.SQLCon = new SqlConnection(MCls.SQLConStr);
            FunLib.SQLCmd = new SqlCommand("", FunLib.SQLCon);
            Program.MC.ReportURL = MCls.GetRegValue(MCls.RegKeyValues.ReportUrl.ToString());
            Program.MC.ReportPath = MCls.GetRegValue(MCls.RegKeyValues.ReportPath.ToString());
            Program.MC.DataChacked = MCls.GetRegValue(MCls.RegKeyValues.DataChacked.ToString());
            Program.MC.DeletedFilesPath = MCls.GetRegValue(MCls.RegKeyValues.DeletedFilesPath.ToString());
            Program.MC.GeneralPort = MCls.GetRegValue(MCls.RegKeyValues.GeneralPort.ToString());
            Program.MC.ServerIP = MCls.GetRegValue(MCls.RegKeyValues.ServerIP.ToString());
            if (MCls.SQLConStr == string.Empty || Program.MC.ReportURL == string.Empty || Program.MC.ReportPath == string.Empty)
            {
                MainModule.FrmSQLConnection = new SQLConnectionFrm();
                MainModule.FrmSQLConnection.FullConString = MCls.SQLConStr;
                MainModule.FrmSQLConnection.DatabaseName = "DataCenter";
                MainModule.FrmSQLConnection.RegKeyName = MCls.RegKeyValues.SQLString.ToString();

                try
                {
                    Directory.CreateDirectory(@"D:\DataCenter\Database\");
                    if (File.Exists(Application.StartupPath + @"\DataBase\DataCenter.mdf") && !File.Exists(@"D:\DataCenter\Database\DataCenter.mdf"))
                        File.Copy(Application.StartupPath + @"\DataBase\DataCenter.mdf", @"D:\DataCenter\Database\DataCenter.mdf", false);
                    if (File.Exists(Application.StartupPath + @"\DataBase\DataCenter_log.ldf") && !File.Exists(@"D:\DataCenter\Database\DataCenter_log.ldf"))
                        File.Copy(Application.StartupPath + @"\DataBase\DataCenter_log.ldf", @"D:\DataCenter\Database\DataCenter_log.ldf", false);
                }
                catch { }
                MainModule.FrmSQLConnection.ShowDialog();
                Process.GetCurrentProcess().Kill();
            }
            // Load User Information
            ErrorProvider = null;
            string RelatedFiles = string.Empty;
            ErrorProvider = FunLib.GetServerOption(ref DefaultUserPassword, ref ProjectsPath, ref RelatedFiles, ref DeletedFilesPath, ref ServerIP, ref ServerPort, ref StudentFilesPath, ref EmpFilesPath);
            if (ErrorProvider != null)
            {
                MsgBox_("Can't start the application ' option error '", 20, 23, false, StartUpFrm.Default);
                if (Interaction.MsgBox(String.Format("Maybe its error in connection{0}(Reset connection)Are you sure ?", Constants.vbNewLine), MsgBoxStyle.YesNo, "Warning") == MsgBoxResult.Yes)
                    MCls.ResetConnection();
                Process.GetCurrentProcess().Kill();
            }
            MainModule.FrmLogin = new LoginForm();
            if (MainModule.FrmLogin.ShowDialog() == DialogResult.OK)
            {
                Program.MC.DataChacked = MCls.GetRegValue(MCls.RegKeyValues.DataChacked.ToString());
                if (Program.MC.DataChacked == string.Empty)
                    FrmFilesChecker.Show();
            }
		}
		public static void MsgBox_(string MSG, short x, short y, bool Complate, Form SenderForm)
		{
			if (Complate == true)
			{
				SenderForm.Opacity = 0.3;
				FrmMSG = new MSGBOXFrm(MSG);
				FrmMSG.LBLMSG.Location = new Point(x, y);
				FrmMSG.BtnOk.BackColor = Color.GreenYellow;
				FrmMSG.Panel.BackColor = Color.Green;
				//FrmMSG.BackgroundImage = Global.DataCenter_Server.My.Resources.Resources.Complated
				FrmMSG.ShowDialog(SenderForm);
				SenderForm.Opacity = 1;
			}
			else
			{
				SenderForm.Opacity = 0.3;
				FrmMSG = new MSGBOXFrm(MSG);
				FrmMSG.LBLMSG.Location = new Point(y, y);
				FrmMSG.BtnOk.BackColor = Color.Red;
				FrmMSG.Panel.BackColor = Color.Red;
				//FrmMSG.BackgroundImage = Global.DataCenter_Server.My.Resources.Resources._Error
				FrmMSG.ShowDialog(SenderForm);
				SenderForm.Opacity = 1;
			}
		}

	}
}
