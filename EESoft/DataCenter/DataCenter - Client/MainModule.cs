using System.Diagnostics;
using System;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using Microsoft.VisualBasic;
using System.Data;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using FunctionLib;

namespace DataCenter_Client
{
	sealed class MainModule
	{
		//Dll Defenation
		public static NetworkFunction NWLib = new NetworkFunction();
		public static DataCenterClientLib FunLib = new DataCenterClientLib();
		//Forms Defenation
		public static MSGBOXFrm FrmMSG;
		public static SQLConnectionFrm FrmSQLConnection = new SQLConnectionFrm();
		public static SplashScreen SC = new SplashScreen();
		public static LoginForm FrmLogin = new LoginForm();
		public static MainWindowFrm FrmMainWindow = new MainWindowFrm();
		public static ObjectPropertyFrm FrmObjectProperty = new ObjectPropertyFrm();
		public static TransferFrm FrmTransfer = new TransferFrm();
		public static LockedFilesFrm FrmLockedFiles = new LockedFilesFrm();
		public static OptionsFrm FrmOptions = new OptionsFrm();
        public static StuObjectPropertyFrm FrmStuObjectProperty = new StuObjectPropertyFrm();
		//Options
		public static string ProjectsPath;
		public static string RelatedFiles;
		public static string IconPath = Application.StartupPath + "\\Temp\\Icons\\";
		public static string REQPort;
		public static string ServerIP;
		public static int DefaultFileSize = 50; //I didnt call it
		public static string DeletedFilesPath; //With the \
        public static string StudentFilesPath;
        public static string EmpFilesPath;
		//Vars
		private static string ErrorProvider = null;
		public static DataCenterClientLib.PrivateFoldersPrvType AllFoldersWithPrv;
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
			public string FileIndex;
            public string FileName;
			public string FolderIndex;
            public string FolderPath;
			public ObjectType ObjecyType;
		}
		public static ObjectProperty PropertyObjectInfo = new ObjectProperty();
		
		//Functions
		public static void MsgBox_(string MSG, short x, short y, bool Complate, Form SenderForm)
		{
			if (Complate == true)
			{
				SenderForm.Opacity = 0.3;
				FrmMSG = new MSGBOXFrm(MSG);
				FrmMSG.LBLMSG.Location = new Point(x, y);
				FrmMSG.BtnOk.BackColor = Color.GreenYellow;
				FrmMSG.Panel.BackColor = Color.Green;
				//FrmMSG.BackgroundImage = Global.DataCenter_Client.My.Resources.Resources.Complated
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
				//FrmMSG.BackgroundImage = Global.DataCenter_Client.My.Resources.Resources.Error_
				FrmMSG.ShowDialog(SenderForm);
				SenderForm.Opacity = 1;
			}
		}
        static public void Main()
        {
            //Get Connection string from reg
            string Str = "";
            if (FunLib.GetRegValue(ref Str, (DataCenterClientLib.RegKeyValues)DataCenterServerLib.RegKeyValues.SQLString) == true)
            {
                MCls.SQLConStr = Str;
                FunLib.SQLCon.ConnectionString = Str;
                FunLib.SqlStr = Str;
                //Get option vars
                ErrorProvider = null;
                string NotNeeedOptions = string.Empty;
                ErrorProvider = FunLib.GetServerOption(ref NotNeeedOptions, ref ProjectsPath, ref RelatedFiles, ref DeletedFilesPath, ref ServerIP, ref REQPort, ref StudentFilesPath, ref EmpFilesPath); //Loading Options
                if (ErrorProvider != null)
                {
                    MCls.msg("لم نتمكن من تشغيل البرنامج", true, "خطاء في خيارات البرنامج", StartUpFrm.Default);
                    if (Interaction.MsgBox(String.Format("ربما هناك خطاء في الاتصال{0}هل ترغب في الغاء بيانات الاتصال؟", Constants.vbNewLine), MsgBoxStyle.YesNo, "Warning") == MsgBoxResult.Yes)
                        FunLib.ResetConnection();
                    Process.GetCurrentProcess().Kill();
                }
                if (ProjectsPath == "" || REQPort == "" || ServerIP == "" || DeletedFilesPath == "" || StudentFilesPath == "" || EmpFilesPath == "")
                {
                    MCls.msg("البرنامج غير جاهز للاستخدام", true, "لم يتم وضع خيارات البرنامج", StartUpFrm.Default);
                    Process.GetCurrentProcess().Kill();
                }
                FrmLogin.ShowDialog();
            }
            else
            {
                //StartNewConnection:
                FrmSQLConnection.DatabaseName = "DataCenter";
                FrmSQLConnection.RegKeyName = MCls.RegKeyValues.SQLString.ToString();
                FrmSQLConnection.FullConString = MCls.SQLConStr;
                FrmSQLConnection.Show();
            }
        }
        public static string CreateFile(string IP_Address, int RPort, string OrgFilePath, string ServerPath, string FileName, string FileType, ref string NewFilePath)
        {
            string FullString;
            byte[] Buffers = new byte[4097];
            Socket Sok = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            int Created;
            try
            {
                FileStream FileSRM = new FileStream(OrgFilePath, FileMode.Open, FileAccess.Read);
                FullString = String.Format("{0}{1}/{2}/{3}/{4}", (int)NetworkFunction.Commands.CreateFile, ServerPath, FileName, FileType, FileSRM.Length);

                FrmObjectProperty.NewFileProgressBar.Value = 0;
                FrmObjectProperty.NewFileProgressBar.Maximum = (int)(FileSRM.Length);
                Buffers = Encoding.Default.GetBytes(FullString);
                Sok.Connect(IP_Address, RPort);
                if (Sok.Connected == true)
                {
                    Sok.Send(Buffers, FullString.Length, SocketFlags.None);
                    Sok.Receive(Buffers, 1, SocketFlags.None);
                    Created = System.Convert.ToInt32(Conversion.Val(Buffers[0]));
                    if (Created == 1)
                    {
                        Buffers = new byte[4097];
                        do
                        {
                            Created = FileSRM.Read(Buffers, 0, 4096);
                            if (Created > 0)
                            {
                                Sok.Send(Buffers, Created, SocketFlags.None);
                                FrmObjectProperty.NewFileProgressBar.Value += Created;
                                FrmObjectProperty.Text = "New File Properties  " + System.Convert.ToInt32((FrmObjectProperty.NewFileProgressBar.Value / FrmObjectProperty.NewFileProgressBar.Maximum) * 100) + " %";
                            }
                            else
                            {
                                break;
                            }
                            Application.DoEvents();
                        } while (true);
                        Created = Sok.Receive(Buffers, 4096, SocketFlags.None);
                        NewFilePath = Encoding.Default.GetString(Buffers, 0, Created);
                        FrmObjectProperty.Text = "New File Properties";
                        FrmObjectProperty.NewFileProgressBar.Value = 0;
                        FrmObjectProperty.NewFileProgressBar.Maximum = 0;
                    }
                    else
                    {

                        Sok.Close();
                        Sok = null;
                        return "Can\'t create file or sever is out of space";
                    }
                }
                else
                {
                    return "No Connection available";
                }
            }
            catch (Exception ex)
            {
                try
                {

                    Sok.Close();
                }
                catch
                {
                }
                return ex.Message;
            }
            try
            {

                Sok.Close();
            }
            catch
            {
            }
            return null;
        }
		
	}
}
