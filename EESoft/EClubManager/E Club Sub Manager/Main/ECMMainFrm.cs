using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace E_Club_Sub_Manager
{
    public partial class ECMMainFrm : Form
    {
        #region -   Functions   -
        public ECMMainFrm()
        {
            InitializeComponent();
        }
        public void RebuildForms()
        {
            
            Program.MC.FrmAddMembership = new AddMembershipFrm();
            Program.MC.FrmCards = new CardsFrm();
            //Queries
            Program.MC.FrmQryMembership = new QryMembershipFrm();
            //Permission
            //Program.MC.FrmEditorRole = new EditorRoleFrm();
            //Program.MC.FrmEditorUser = new EditorUserFrm();
            //Program.MC.FrmEditorUserInRole = new EditorUserInRoleFrm();
            //Program.MC.FrmEditorRoleContians = new EditorRoleContiansFrm();
        }
        #endregion
        #region -   Event Handlers   -
        private void ECMMainFrm_Load(object sender, EventArgs e)
        {
            RebuildForms();
            //Program.MC.FrmSplash = new SplashFrm();
            //Program.MC.FrmSplash.ShowDialog();
            this.IsMdiContainer = true;
            // Load Data From Registry
            Program.MC.SQLConStrMalafat = MCls.GetRegValue(MCls.RegKeyValues.SQLStringMalafat.ToString());
            Program.MC.SQLConStrMembers = MCls.GetRegValue(MCls.RegKeyValues.SQLStringMember.ToString());
            Program.MC.ReportURL = MCls.GetRegValue(MCls.RegKeyValues.ReportUrl.ToString());
            Program.MC.ReportPath = MCls.GetRegValue(MCls.RegKeyValues.ReportPath.ToString());

            if (Program.MC.SQLConStrMalafat == string.Empty || Program.MC.ReportURL == string.Empty || Program.MC.ReportPath == string.Empty || Program.MC.SQLConStrMembers == string.Empty)
            {
                if (Program.MC.SQLConStrMalafat == string.Empty)
                {
                    //Save MALAFAT's DB Connection string
                    Program.MC.FrmSQLConnection = new SQLConnectionFrm();
                    Program.MC.FrmSQLConnection.FullConString = Program.MC.SQLConStrMalafat;
                    Program.MC.FrmSQLConnection.DatabaseName = "MALAFAT";
                    Program.MC.FrmSQLConnection.RegKeyName = MCls.RegKeyValues.SQLStringMalafat.ToString();
                    Program.MC.FrmSQLConnection.OFDInitialDirectory = "C:\\ECM\\Database";
                    Program.MC.FrmSQLConnection.ShowDialog();
                }
                if (Program.MC.SQLConStrMembers == string.Empty)
                {
                    //Save members's DB Connection string
                    Program.MC.FrmSQLConnection = new SQLConnectionFrm();
                    Program.MC.FrmSQLConnection.FullConString = Program.MC.SQLConStrMembers;
                    Program.MC.FrmSQLConnection.DatabaseName = "members";
                    Program.MC.FrmSQLConnection.RegKeyName = MCls.RegKeyValues.SQLStringMember.ToString();
                    Program.MC.FrmSQLConnection.OFDInitialDirectory = "C:\\ECM\\Database";
                    Program.MC.FrmSQLConnection.ShowDialog();
                }
                Application.Exit();
            }
            Program.MC.AttachDefaultPath = MCls.GetAttachDefaultPath();// Load Attach Default Path
            Program.MC.LoadUserInfo();// Load User Information -- Temp --
        }
        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }
        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }
        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }
        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        private void restConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.MC.SQLConStrMalafat = string.Empty;
            Program.MC.SQLConStrMembers = string.Empty;
            MCls.ResetConnection();
        }
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("E-E-Soft Co. \n  Test Version ...");
        }
        private void editorMembershipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.MC.FrmAddMembership.IsDisposed)
            {
                Program.MC.FrmAddMembership = new AddMembershipFrm();
                Program.MC.FrmAddMembership.MdiParent = this;
                Program.MC.FrmAddMembership.Show();
            }
            else
            {
                if (Program.MC.FrmAddMembership.Visible)
                {
                    Program.MC.FrmAddMembership.WindowState = FormWindowState.Normal;
                    Program.MC.FrmAddMembership.Focus();
                }
                else
                {
                    Program.MC.FrmAddMembership.MdiParent = this;
                    Program.MC.FrmAddMembership.Show();
                }
            }
        }
        private void cardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.MC.FrmCards.IsDisposed)
            {
                Program.MC.FrmCards = new CardsFrm();
                Program.MC.FrmCards.MdiParent = this;
                Program.MC.FrmCards.Show();
            }
            else
            {
                if (Program.MC.FrmCards.Visible)
                {
                    Program.MC.FrmCards.WindowState = FormWindowState.Normal;
                    Program.MC.FrmCards.Focus();
                }
                else
                {
                    Program.MC.FrmCards.MdiParent = this;
                    Program.MC.FrmCards.Show();
                }
            }
        }
        private void editorUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (Program.MC.FrmEditorUser.IsDisposed)
            //{
            //    Program.MC.FrmEditorUser = new EditorUserFrm();
            //    Program.MC.FrmEditorUser.MdiParent = this;
            //    Program.MC.FrmEditorUser.Show();
            //}
            //else
            //{
            //    if (Program.MC.FrmEditorUser.Visible)
            //    {
            //        Program.MC.FrmEditorUser.WindowState = FormWindowState.Normal;
            //        Program.MC.FrmEditorUser.Focus();
            //    }
            //    else
            //    {
            //        Program.MC.FrmEditorUser.MdiParent = this;
            //        Program.MC.FrmEditorUser.Show();
            //    }
            //}
        }
        private void editorUserInRoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (Program.MC.FrmEditorUserInRole.IsDisposed)
            //{
            //    Program.MC.FrmEditorUserInRole = new EditorUserInRoleFrm();
            //    Program.MC.FrmEditorUserInRole.MdiParent = this;
            //    Program.MC.FrmEditorUserInRole.Show();
            //}
            //else
            //{
            //    if (Program.MC.FrmEditorUserInRole.Visible)
            //    {
            //        Program.MC.FrmEditorUserInRole.WindowState = FormWindowState.Normal;
            //        Program.MC.FrmEditorUserInRole.Focus();
            //    }
            //    else
            //    {
            //        Program.MC.FrmEditorUserInRole.MdiParent = this;
            //        Program.MC.FrmEditorUserInRole.Show();
            //    }
            //}
        }
        private void editorRoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (Program.MC.FrmEditorRole.IsDisposed)
            //{
            //    Program.MC.FrmEditorRole = new EditorRoleFrm();
            //    Program.MC.FrmEditorRole.MdiParent = this;
            //    Program.MC.FrmEditorRole.Show();
            //}
            //else
            //{
            //    if (Program.MC.FrmEditorRole.Visible)
            //    {
            //        Program.MC.FrmEditorRole.WindowState = FormWindowState.Normal;
            //        Program.MC.FrmEditorRole.Focus();
            //    }
            //    else
            //    {
            //        Program.MC.FrmEditorRole.MdiParent = this;
            //        Program.MC.FrmEditorRole.Show();
            //    }
            //}
        }
        private void editorRoleContiansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (Program.MC.FrmEditorRoleContians.IsDisposed)
            //{
            //    Program.MC.FrmEditorRoleContians = new EditorRoleContiansFrm();
            //    Program.MC.FrmEditorRoleContians.MdiParent = this;
            //    Program.MC.FrmEditorRoleContians.Show();
            //}
            //else
            //{
            //    if (Program.MC.FrmEditorRoleContians.Visible)
            //    {
            //        Program.MC.FrmEditorRoleContians.WindowState = FormWindowState.Normal;
            //        Program.MC.FrmEditorRoleContians.Focus();
            //    }
            //    else
            //    {
            //        Program.MC.FrmEditorRoleContians.MdiParent = this;
            //        Program.MC.FrmEditorRoleContians.Show();
            //    }
            //}
        }
        private void qryMembershipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.MC.FrmQryMembership.IsDisposed)
            {
                Program.MC.FrmQryMembership = new QryMembershipFrm();
                Program.MC.FrmQryMembership.MdiParent = this;
                Program.MC.FrmQryMembership.Show();
            }
            else
            {
                if (Program.MC.FrmQryMembership.Visible)
                {
                    Program.MC.FrmQryMembership.WindowState = FormWindowState.Normal;
                    Program.MC.FrmQryMembership.Focus();
                }
                else
                {
                    Program.MC.FrmQryMembership.MdiParent = this;
                    Program.MC.FrmQryMembership.Show();
                }
            }
        }
        #region -   Reports Menu Events   -
        private void repPaymentdayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RepGeneralFrm FrmRepGeneral = new RepGeneralFrm { MdiParent = this };
            Program.MC.RepTy = MCls.ReportType.Paymentday;
            FrmRepGeneral.Show();
        }
        private void repPaymentpriodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RepGeneralFrm FrmRepGeneral = new RepGeneralFrm { MdiParent = this };
            Program.MC.RepTy = MCls.ReportType.Paymentpriod;
            FrmRepGeneral.Show();
        }
        private void repPaymentmemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RepGeneralFrm FrmRepGeneral = new RepGeneralFrm { MdiParent = this };
            Program.MC.RepTy = MCls.ReportType.Paymentmember;
            FrmRepGeneral.Show();
        }
        private void repPaymentpriodsumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RepGeneralFrm FrmRepGeneral = new RepGeneralFrm { MdiParent = this };
            Program.MC.RepTy = MCls.ReportType.Paymentpriodsum;
            FrmRepGeneral.Show();
        }
        private void repPaymentlateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RepGeneralFrm FrmRepGeneral = new RepGeneralFrm { MdiParent = this };
            Program.MC.RepTy = MCls.ReportType.Paymentlate;
            FrmRepGeneral.Show();
        }
        #endregion
        #endregion
        
    }
}