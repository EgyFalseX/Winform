using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SqlInstaller
{
    public partial class FrmConfigFileCreator : Form
    {
       
        #region -   Variables   -
        string ConfigurationFile = string.Format(@"");
                #endregion
        #region -   Functions   -
        public FrmConfigFileCreator()
        {
            ConfigurationFile x = new SqlInstaller.ConfigurationFile();
            
            InitializeComponent();
        }
        private void Createcfg(string FilePath)
        {
            try
            {
                ConfigurationFile cfg = new ConfigurationFile();
                cfg.INSTANCEID = TxtINSTANCEID.Text;
                cfg.ACTION = TxtACTION.Text;
                cfg.HELP = CBHELP.Checked;
                cfg.INDICATEPROGRESS = CBINDICATEPROGRESS.Checked;
                cfg.QUIET = CBQUIET.Checked;
                cfg.QUIETSIMPLE = CBQUIETSIMPLE.Checked;
                cfg.X86 = CBX86.Checked;
                cfg.MEDIASOURCE = TxtMEDIASOURCE.Text;
                cfg.ERRORREPORTING = CBERRORREPORTING.Checked;
                cfg.INSTANCEDIR = TxtINSTANCEDIR.Text;
                cfg.SQMREPORTING = CBSQMREPORTING.Checked;
                cfg.INSTANCENAME = TxtINSTANCENAME.Text;
                cfg.AGTSVCACCOUNT = TxtAGTSVCACCOUNT.Text;
                cfg.AGTSVCSTARTUPTYPE = CBAGTSVCSTARTUPTYPE.Text;
                cfg.ISSVCSTARTUPTYPE = CBISSVCSTARTUPTYPE.Text;
                cfg.ISSVCACCOUNT = TxtISSVCACCOUNT.Text;
                cfg.ASSVCSTARTUPTYPE = CBASSVCSTARTUPTYPE.Text;
                cfg.ASCOLLATION = TxtASCOLLATION.Text;
                cfg.ASDATADIR = TxtASDATADIR.Text;
                cfg.ASLOGDIR = TxtASLOGDIR.Text;
                cfg.ASBACKUPDIR = TxtASBACKUPDIR.Text;
                cfg.ASTEMPDIR = TxtASTEMPDIR.Text;
                cfg.ASCONFIGDIR = TxtASCONFIGDIR.Text;
                cfg.ASPROVIDERMSOLAP = TxtASPROVIDERMSOLAP.Text;
                cfg.SQLSVCSTARTUPTYPE = CBSQLSVCSTARTUPTYPE.Text;
                cfg.FILESTREAMLEVEL = TxtFILESTREAMLEVEL.Text;
                cfg.ENABLERANU = CBENABLERANU.Checked;
                cfg.SQLCOLLATION = TxtSQLCOLLATION.Text;
                cfg.SQLSVCACCOUNT = TxtSQLSVCACCOUNT.Text;
                cfg.SQLSYSADMINACCOUNTS = TxtSQLSYSADMINACCOUNTS.Text;
                cfg.SECURITYMODE = TxtSECURITYMODE.Text;
                cfg.ADDCURRENTUSERASSQLADMIN = CBADDCURRENTUSERASSQLADMIN.Checked;
                cfg.TCPENABLED = TxtTCPENABLED.Text;
                cfg.NPENABLED = TxtNPENABLED.Text;
                cfg.BROWSERSVCSTARTUPTYPE = CBBROWSERSVCSTARTUPTYPE.Text;
                cfg.RSSVCACCOUNT = TxtRSSVCACCOUNT.Text;
                cfg.RSSVCSTARTUPTYPE = CBRSSVCSTARTUPTYPE.Text;
                cfg.RSINSTALLMODE = TxtRSINSTALLMODE.Text;

                cfg.CreateConfigFile(FilePath);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion
        #region - Event Handlers -
        private void BtnMEDIASOURCE_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog FBD = new FolderBrowserDialog() { Description = "Specifies the path to the installation", ShowNewFolderButton = true })
            {
                FBD.SelectedPath = TxtMEDIASOURCE.Text;
                if (FBD.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                    return;
                TxtMEDIASOURCE.Text = String.Format("{0}\\{1}{2}{3}", FBD.SelectedPath, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            }
        }
        private void BtnINSTANCEDIR_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog FBD = new FolderBrowserDialog() { Description = "Specify the root installation directory", ShowNewFolderButton = true })
            {
                FBD.SelectedPath = TxtINSTANCEDIR.Text;
                if (FBD.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                    return;
                TxtINSTANCEDIR.Text = String.Format("{0}\\", FBD.SelectedPath);
            }
        }
        private void BtnInstall_Click(object sender, EventArgs e)
        {
            PB.Value = 0;
            try
            {
                Createcfg(TxtMEDIASOURCE.Text);


            }
            catch (Exception ex)
            {
                RTBLog.AppendText("\n" + ex.Message);
            }
            
        }
#endregion         #region -   Variables   -
    }
}
