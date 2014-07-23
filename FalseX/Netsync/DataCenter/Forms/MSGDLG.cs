using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DataCenter.Forms
{
    public partial class MSGDLG : DevExpress.XtraEditors.XtraForm
    {
        private Color SuccessColor = Color.Green;
        private Color FailColor = Color.Red;
        private Color InfoColor = Color.Black;
        private Color DebugColor = Color.Blue;

        public MSGDLG(string msg, nsLib.Utilities.Types.MessageType typ, Exception ex = null)
        {
            InitializeComponent();
            tbMSG.Text = msg;
            if (ex != null)
                tbDetails.EditValue = ex.StackTrace;
            else
                tbDetails.Visible = false;
            switch (typ)
            {
                case nsLib.Utilities.Types.MessageType.Success:
                    pb.Image = Properties.Resources.MSG_Success;
                    tbMSG.ForeColor = SuccessColor;
                    break;
                case nsLib.Utilities.Types.MessageType.Error:
                    pb.Image = Properties.Resources.MSG_Error;
                    tbMSG.ForeColor = FailColor;
                    break;
                case nsLib.Utilities.Types.MessageType.Info:
                    pb.Image = Properties.Resources.MSG_Information;
                    tbMSG.ForeColor = InfoColor;
                    break;
                case nsLib.Utilities.Types.MessageType.Debug:
                    pb.Image = Properties.Resources.MSG_Information;
                    tbMSG.ForeColor = DebugColor;
                    break;
                case nsLib.Utilities.Types.MessageType.Fatal:
                    pb.Image = Properties.Resources.MSG_Error;
                    tbMSG.ForeColor = FailColor;
                    break;
                case nsLib.Utilities.Types.MessageType.Warn:
                    pb.Image = Properties.Resources.MSG_Warnning;
                    tbMSG.ForeColor = InfoColor;
                    break;
                default:
                    break;
            }
        }

        private void MSGDLG_Load(object sender, EventArgs e)
        {

        }
    }
}