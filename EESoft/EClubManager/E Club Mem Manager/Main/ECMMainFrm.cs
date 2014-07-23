using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace E_Club_Mem_Manager
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
            Program.MC.FrmLogin = new LoginFrm();
            Program.MC.FrmAddDependent = new AddDependentFrm();
            Program.MC.FrmAddMemAttachment = new AddMemAttachmentFrm();
            Program.MC.FrmAddMembers = new AddMembersFrm();
            //Codes
            Program.MC.FrmEditorAsase = new EditorAsaseFrm();
            Program.MC.FrmEditorAttachmentType = new EditorAttachmentTypeFrm();
            Program.MC.FrmEditorGOV = new EditorGOVFrm();
            Program.MC.FrmEditorJob = new EditorJobFrm();
            Program.MC.FrmEditorMarkz = new EditorMarkzFrm();
            Program.MC.FrmEditorMembershipType = new EditorMembershipTypeFrm();
            Program.MC.FrmEditorQualification = new EditorQualificationFrm();
            Program.MC.FrmEditorSocial = new EditorSocialFrm();
            Program.MC.FrmEditorSubscriptionType = new EditorSubscriptionTypeFrm();
            Program.MC.FrmCD_FALLReason = new CD_FALLReasonFrm();
            Program.MC.FrmCD_kinship = new CD_kinshipFrm();
            //Queries
            Program.MC.FrmQryMember = new QryMemberFrm();
            Program.MC.FrmQryMemInfo = new QryMemInfoFrm();
            //Permission
            Program.MC.FrmEditorObjectType = new EditorObjectTypeFrm();
            Program.MC.FrmEditorRole = new EditorRoleFrm();
            Program.MC.FrmEditorUser = new EditorUserFrm();
            Program.MC.FrmEditorUserInRole = new EditorUserInRoleFrm();
            Program.MC.FrmEditorRoleContians = new EditorRoleContiansFrm();
            Program.MC.FrmEditorObjectInfo = new EditorObjectInfoFrm();
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
            Program.MC.FrmLogin.ShowDialog();
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
        private void editorMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.MC.FrmAddMembers.IsDisposed)
            {
                Program.MC.FrmAddMembers = new AddMembersFrm();
                Program.MC.FrmAddMembers.MdiParent = this;
                Program.MC.FrmAddMembers.Show();
            }
            else
            {
                if (Program.MC.FrmAddMembers.Visible)
                {
                    Program.MC.FrmAddMembers.WindowState = FormWindowState.Normal;
                    Program.MC.FrmAddMembers.Focus();
                }
                else
                {
                    Program.MC.FrmAddMembers.MdiParent = this;
                    Program.MC.FrmAddMembers.Show();
                }
            }
        }
        private void editorDependentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.MC.FrmAddDependent.IsDisposed)
            {
                Program.MC.FrmAddDependent = new AddDependentFrm();
                Program.MC.FrmAddDependent.MdiParent = this;
                Program.MC.FrmAddDependent.Show();
            }
            else
            {
                if (Program.MC.FrmAddDependent.Visible)
                {
                    Program.MC.FrmAddDependent.WindowState = FormWindowState.Normal;
                    Program.MC.FrmAddDependent.Focus();
                }
                else
                {
                    Program.MC.FrmAddDependent.MdiParent = this;
                    Program.MC.FrmAddDependent.Show();
                }
            }
        }
        private void editorAttachmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.MC.FrmAddMemAttachment.IsDisposed)
            {
                Program.MC.FrmAddMemAttachment = new AddMemAttachmentFrm();
                Program.MC.FrmAddMemAttachment.MdiParent = this;
                Program.MC.FrmAddMemAttachment.Show();
            }
            else
            {
                if (Program.MC.FrmAddMemAttachment.Visible)
                {
                    Program.MC.FrmAddMemAttachment.WindowState = FormWindowState.Normal;
                    Program.MC.FrmAddMemAttachment.Focus();
                }
                else
                {
                    Program.MC.FrmAddMemAttachment.MdiParent = this;
                    Program.MC.FrmAddMemAttachment.Show();
                }
            }
        }
        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.MC.FrmQryMember.IsDisposed)
            {
                Program.MC.FrmQryMember = new QryMemberFrm();
                Program.MC.FrmQryMember.MdiParent = this;
                Program.MC.FrmQryMember.Show();
            }
            else
            {
                if (Program.MC.FrmQryMember.Visible)
                {
                    Program.MC.FrmQryMember.WindowState = FormWindowState.Normal;
                    Program.MC.FrmQryMember.Focus();
                }
                else
                {
                    Program.MC.FrmQryMember.MdiParent = this;
                    Program.MC.FrmQryMember.Show();
                }
            }
        }
        private void editorUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.MC.FrmEditorUser.IsDisposed)
            {
                Program.MC.FrmEditorUser = new EditorUserFrm();
                Program.MC.FrmEditorUser.MdiParent = this;
                Program.MC.FrmEditorUser.Show();
            }
            else
            {
                if (Program.MC.FrmEditorUser.Visible)
                {
                    Program.MC.FrmEditorUser.WindowState = FormWindowState.Normal;
                    Program.MC.FrmEditorUser.Focus();
                }
                else
                {
                    Program.MC.FrmEditorUser.MdiParent = this;
                    Program.MC.FrmEditorUser.Show();
                }
            }
        }
        private void editorUserInRoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.MC.FrmEditorUserInRole.IsDisposed)
            {
                Program.MC.FrmEditorUserInRole = new EditorUserInRoleFrm();
                Program.MC.FrmEditorUserInRole.MdiParent = this;
                Program.MC.FrmEditorUserInRole.Show();
            }
            else
            {
                if (Program.MC.FrmEditorUserInRole.Visible)
                {
                    Program.MC.FrmEditorUserInRole.WindowState = FormWindowState.Normal;
                    Program.MC.FrmEditorUserInRole.Focus();
                }
                else
                {
                    Program.MC.FrmEditorUserInRole.MdiParent = this;
                    Program.MC.FrmEditorUserInRole.Show();
                }
            }
        }
        private void editorRoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.MC.FrmEditorRole.IsDisposed)
            {
                Program.MC.FrmEditorRole = new EditorRoleFrm();
                Program.MC.FrmEditorRole.MdiParent = this;
                Program.MC.FrmEditorRole.Show();
            }
            else
            {
                if (Program.MC.FrmEditorRole.Visible)
                {
                    Program.MC.FrmEditorRole.WindowState = FormWindowState.Normal;
                    Program.MC.FrmEditorRole.Focus();
                }
                else
                {
                    Program.MC.FrmEditorRole.MdiParent = this;
                    Program.MC.FrmEditorRole.Show();
                }
            }
        }
        private void editorObjectTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.MC.FrmEditorObjectType.IsDisposed)
            {
                Program.MC.FrmEditorObjectType = new EditorObjectTypeFrm();
                Program.MC.FrmEditorObjectType.MdiParent = this;
                Program.MC.FrmEditorObjectType.Show();
            }
            else
            {
                if (Program.MC.FrmEditorObjectType.Visible)
                {
                    Program.MC.FrmEditorObjectType.WindowState = FormWindowState.Normal;
                    Program.MC.FrmEditorObjectType.Focus();
                }
                else
                {
                    Program.MC.FrmEditorObjectType.MdiParent = this;
                    Program.MC.FrmEditorObjectType.Show();
                }
            }
        }
        private void editorRoleContiansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.MC.FrmEditorRoleContians.IsDisposed)
            {
                Program.MC.FrmEditorRoleContians = new EditorRoleContiansFrm();
                Program.MC.FrmEditorRoleContians.MdiParent = this;
                Program.MC.FrmEditorRoleContians.Show();
            }
            else
            {
                if (Program.MC.FrmEditorRoleContians.Visible)
                {
                    Program.MC.FrmEditorRoleContians.WindowState = FormWindowState.Normal;
                    Program.MC.FrmEditorRoleContians.Focus();
                }
                else
                {
                    Program.MC.FrmEditorRoleContians.MdiParent = this;
                    Program.MC.FrmEditorRoleContians.Show();
                }
            }
        }
        private void editorObjectInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.MC.FrmEditorObjectInfo.IsDisposed)
            {
                Program.MC.FrmEditorObjectInfo = new EditorObjectInfoFrm();
                Program.MC.FrmEditorObjectInfo.MdiParent = this;
                Program.MC.FrmEditorObjectInfo.Show();
            }
            else
            {
                if (Program.MC.FrmEditorObjectInfo.Visible)
                {
                    Program.MC.FrmEditorObjectInfo.WindowState = FormWindowState.Normal;
                    Program.MC.FrmEditorObjectInfo.Focus();
                }
                else
                {
                    Program.MC.FrmEditorObjectInfo.MdiParent = this;
                    Program.MC.FrmEditorObjectInfo.Show();
                }
            }
        }
        private void qryMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.MC.FrmQryMemInfo.IsDisposed)
            {
                Program.MC.FrmQryMemInfo = new QryMemInfoFrm();
                Program.MC.FrmQryMemInfo.MdiParent = this;
                Program.MC.FrmQryMemInfo.Show();
            }
            else
            {
                if (Program.MC.FrmQryMemInfo.Visible)
                {
                    Program.MC.FrmQryMemInfo.WindowState = FormWindowState.Normal;
                    Program.MC.FrmQryMemInfo.Focus();
                }
                else
                {
                    Program.MC.FrmQryMemInfo.MdiParent = this;
                    Program.MC.FrmQryMemInfo.Show();
                }
            }
        }
        private void editorAsaseFrmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.MC.FrmEditorAsase.IsDisposed)
            {
                Program.MC.FrmEditorAsase = new EditorAsaseFrm();
                Program.MC.FrmEditorAsase.MdiParent = this;
                Program.MC.FrmEditorAsase.Show();
            }
            else
            {
                if (Program.MC.FrmEditorAsase.Visible)
                {
                    Program.MC.FrmEditorAsase.WindowState = FormWindowState.Normal;
                    Program.MC.FrmEditorAsase.Focus();
                }
                else
                {
                    Program.MC.FrmEditorAsase.MdiParent = this;
                    Program.MC.FrmEditorAsase.Show();
                }
            }
        }
        private void editorAttachmentTypeFrmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.MC.FrmEditorAttachmentType.IsDisposed)
            {
                Program.MC.FrmEditorAttachmentType = new EditorAttachmentTypeFrm();
                Program.MC.FrmEditorAttachmentType.MdiParent = this;
                Program.MC.FrmEditorAttachmentType.Show();
            }
            else
            {
                if (Program.MC.FrmEditorAttachmentType.Visible)
                {
                    Program.MC.FrmEditorAttachmentType.WindowState = FormWindowState.Normal;
                    Program.MC.FrmEditorAttachmentType.Focus();
                }
                else
                {
                    Program.MC.FrmEditorAttachmentType.MdiParent = this;
                    Program.MC.FrmEditorAttachmentType.Show();
                }
            }
        }
        private void editorGOVFrmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.MC.FrmEditorGOV.IsDisposed)
            {
                Program.MC.FrmEditorGOV = new EditorGOVFrm();
                Program.MC.FrmEditorGOV.MdiParent = this;
                Program.MC.FrmEditorGOV.Show();
            }
            else
            {
                if (Program.MC.FrmEditorGOV.Visible)
                {
                    Program.MC.FrmEditorGOV.WindowState = FormWindowState.Normal;
                    Program.MC.FrmEditorGOV.Focus();
                }
                else
                {
                    Program.MC.FrmEditorGOV.MdiParent = this;
                    Program.MC.FrmEditorGOV.Show();
                }
            }
        }
        private void editorJobFrmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.MC.FrmEditorJob.IsDisposed)
            {
                Program.MC.FrmEditorJob = new EditorJobFrm();
                Program.MC.FrmEditorJob.MdiParent = this;
                Program.MC.FrmEditorJob.Show();
            }
            else
            {
                if (Program.MC.FrmEditorJob.Visible)
                {
                    Program.MC.FrmEditorJob.WindowState = FormWindowState.Normal;
                    Program.MC.FrmEditorJob.Focus();
                }
                else
                {
                    Program.MC.FrmEditorJob.MdiParent = this;
                    Program.MC.FrmEditorJob.Show();
                }
            }
        }
        private void editorMarkzFrmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.MC.FrmEditorMarkz.IsDisposed)
            {
                Program.MC.FrmEditorMarkz = new EditorMarkzFrm();
                Program.MC.FrmEditorMarkz.MdiParent = this;
                Program.MC.FrmEditorMarkz.Show();
            }
            else
            {
                if (Program.MC.FrmEditorMarkz.Visible)
                {
                    Program.MC.FrmEditorMarkz.WindowState = FormWindowState.Normal;
                    Program.MC.FrmEditorMarkz.Focus();
                }
                else
                {
                    Program.MC.FrmEditorMarkz.MdiParent = this;
                    Program.MC.FrmEditorMarkz.Show();
                }
            }
        }
        private void editorMembershipTypeFrmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.MC.FrmEditorMembershipType.IsDisposed)
            {
                Program.MC.FrmEditorMembershipType = new EditorMembershipTypeFrm();
                Program.MC.FrmEditorMembershipType.MdiParent = this;
                Program.MC.FrmEditorMembershipType.Show();
            }
            else
            {
                if (Program.MC.FrmEditorMembershipType.Visible)
                {
                    Program.MC.FrmEditorMembershipType.WindowState = FormWindowState.Normal;
                    Program.MC.FrmEditorMembershipType.Focus();
                }
                else
                {
                    Program.MC.FrmEditorMembershipType.MdiParent = this;
                    Program.MC.FrmEditorMembershipType.Show();
                }
            }
        }
        private void editorQualificationFrmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.MC.FrmEditorQualification.IsDisposed)
            {
                Program.MC.FrmEditorQualification = new EditorQualificationFrm();
                Program.MC.FrmEditorQualification.MdiParent = this;
                Program.MC.FrmEditorQualification.Show();
            }
            else
            {
                if (Program.MC.FrmEditorQualification.Visible)
                {
                    Program.MC.FrmEditorQualification.WindowState = FormWindowState.Normal;
                    Program.MC.FrmEditorQualification.Focus();
                }
                else
                {
                    Program.MC.FrmEditorQualification.MdiParent = this;
                    Program.MC.FrmEditorQualification.Show();
                }
            }
        }
        private void editorSocialFrmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.MC.FrmEditorSocial.IsDisposed)
            {
                Program.MC.FrmEditorSocial = new EditorSocialFrm();
                Program.MC.FrmEditorSocial.MdiParent = this;
                Program.MC.FrmEditorSocial.Show();
            }
            else
            {
                if (Program.MC.FrmEditorSocial.Visible)
                {
                    Program.MC.FrmEditorSocial.WindowState = FormWindowState.Normal;
                    Program.MC.FrmEditorSocial.Focus();
                }
                else
                {
                    Program.MC.FrmEditorSocial.MdiParent = this;
                    Program.MC.FrmEditorSocial.Show();
                }
            }
        }
        private void editorSubscriptionTypeFrmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.MC.FrmEditorSubscriptionType.IsDisposed)
            {
                Program.MC.FrmEditorSubscriptionType = new EditorSubscriptionTypeFrm();
                Program.MC.FrmEditorSubscriptionType.MdiParent = this;
                Program.MC.FrmEditorSubscriptionType.Show();
            }
            else
            {
                if (Program.MC.FrmEditorSubscriptionType.Visible)
                {
                    Program.MC.FrmEditorSubscriptionType.WindowState = FormWindowState.Normal;
                    Program.MC.FrmEditorSubscriptionType.Focus();
                }
                else
                {
                    Program.MC.FrmEditorSubscriptionType.MdiParent = this;
                    Program.MC.FrmEditorSubscriptionType.Show();
                }
            }
        }
        private void cDFALLReasonFrmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.MC.FrmCD_FALLReason.IsDisposed)
            {
                Program.MC.FrmCD_FALLReason = new CD_FALLReasonFrm();
                Program.MC.FrmCD_FALLReason.MdiParent = this;
                Program.MC.FrmCD_FALLReason.Show();
            }
            else
            {
                if (Program.MC.FrmCD_FALLReason.Visible)
                {
                    Program.MC.FrmCD_FALLReason.WindowState = FormWindowState.Normal;
                    Program.MC.FrmCD_FALLReason.Focus();
                }
                else
                {
                    Program.MC.FrmCD_FALLReason.MdiParent = this;
                    Program.MC.FrmCD_FALLReason.Show();
                }
            }
        }
        private void cDkinshipFrmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.MC.FrmCD_kinship.IsDisposed)
            {
                Program.MC.FrmCD_kinship = new CD_kinshipFrm();
                Program.MC.FrmCD_kinship.MdiParent = this;
                Program.MC.FrmCD_kinship.Show();
            }
            else
            {
                if (Program.MC.FrmCD_kinship.Visible)
                {
                    Program.MC.FrmCD_kinship.WindowState = FormWindowState.Normal;
                    Program.MC.FrmCD_kinship.Focus();
                }
                else
                {
                    Program.MC.FrmCD_kinship.MdiParent = this;
                    Program.MC.FrmCD_kinship.Show();
                }
            }
        }
        #region -   Reports Menu Events   -
        private void repmember1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RepGeneralFrm FrmRepGeneral = new RepGeneralFrm { MdiParent = this };
            Program.MC.RepTy = MCls.ReportType.member1;
            FrmRepGeneral.Show();
        }
        private void repGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RepGeneralFrm FrmRepGeneral = new RepGeneralFrm { MdiParent = this };
            Program.MC.RepTy = MCls.ReportType.General;
            FrmRepGeneral.Show();
        }
        private void repageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RepGeneralFrm FrmRepGeneral = new RepGeneralFrm { MdiParent = this };
            Program.MC.RepTy = MCls.ReportType.age;
            FrmRepGeneral.Show();
        }
        private void repmemberyearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RepGeneralFrm FrmRepGeneral = new RepGeneralFrm { MdiParent = this };
            Program.MC.RepTy = MCls.ReportType.memberyear;
            FrmRepGeneral.Show();
        }
        private void repmemberupdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RepGeneralFrm FrmRepGeneral = new RepGeneralFrm { MdiParent = this };
            Program.MC.RepTy = MCls.ReportType.memberupdate;
            FrmRepGeneral.Show();
        }
        #endregion
        #endregion

    }
}