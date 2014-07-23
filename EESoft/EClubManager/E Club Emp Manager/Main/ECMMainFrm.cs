using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace E_Club_Emp_Manager
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
            //Forms
            Program.MC.FrmSQLConnection = new SQLConnectionFrm();
            Program.MC.FrmAddEmpAttachment = new AddEmpAttachmentFrm();
            Program.MC.FrmAddEmployee = new AddEmployeeFrm();
            Program.MC.FrmAddQualification = new AddQualificationFrm();
            Program.MC.FrmEditorInsurance = new EditorInsuranceFrm();
            Program.MC.FrmDataAgazat = new DataAgazatFrm();
            //Forms Code
            Program.MC.FrmEditorCountry = new EditorCountryFrm();
            Program.MC.FrmEditorEmpState = new EditorEmpStateFrm();
            Program.MC.FrmEditorNationality = new EditorNationalityFrm();
            Program.MC.FrmEditorDepartment = new EditorDepartmentFrm();
            Program.MC.FrmEditorDgrees = new EditorDgreesFrm();
            Program.MC.FrmEditorEducation = new EditorEducationFrm();
            Program.MC.FrmEditorJobDescription = new EditorJobDescriptionFrm();
            Program.MC.FrmEditorJob = new EditorJobFrm();
            Program.MC.FrmEditorMilitaryType = new EditorMilitaryTypeFrm();
            Program.MC.FrmEditorQualification = new EditorQualificationFrm();
            Program.MC.FrmEditorSpecification = new EditorSpecificationFrm();
            Program.MC.FrmEditorTrainingProg = new EditorTrainingProgFrm();
            Program.MC.FrmEditorTraininPlace = new EditorTraininPlaceFrm();
            Program.MC.FrmEditorUniversity = new EditorUniversityFrm();
            Program.MC.FrmEditorAgazatType = new EditorAgazatTypeFrm();
            Program.MC.FrmEditorEznType = new EditorEznTypeFrm();
            Program.MC.FrmDataSalary = new DataSalaryFrm();
            //Forms Queries
            Program.MC.FrmQryEmployee = new QryEmployeeFrm();
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
            Program.MC.ReportURL = MCls.GetRegValue(MCls.RegKeyValues.ReportUrl.ToString());
            Program.MC.ReportPath = MCls.GetRegValue(MCls.RegKeyValues.ReportPath.ToString());
            if (Program.MC.SQLConStrMalafat == string.Empty || Program.MC.ReportURL == string.Empty || Program.MC.ReportPath == string.Empty)
            {
                Program.MC.FrmSQLConnection = new SQLConnectionFrm();
                Program.MC.FrmSQLConnection.FullConString = Program.MC.SQLConStrMalafat;
                Program.MC.FrmSQLConnection.DatabaseName = "MALAFAT";
                Program.MC.FrmSQLConnection.RegKeyName = MCls.RegKeyValues.SQLStringMalafat.ToString();
                Program.MC.FrmSQLConnection.OFDInitialDirectory = "C:\\ECM\\Database";
                Program.MC.FrmSQLConnection.ShowDialog();
                Application.Exit();
            }
            Program.MC.AttachDefaultPath = MCls.GetAttachDefaultPath();// Load Attach Default Path
            Program.MC.LoadUserInfo();// Load User Information -- Temp --
        }
        private void restConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.MC.SQLConStrMalafat = string.Empty;
            MCls.ResetConnection();
            SQLConnectionFrm FrmSQLConnection = new SQLConnectionFrm();
            FrmSQLConnection.ShowDialog();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("E-E-Soft Co. \n  Test Version ...");
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
        private void countryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.MC.FrmEditorCountry.IsDisposed)
            {
                Program.MC.FrmEditorCountry = new EditorCountryFrm();
                Program.MC.FrmEditorCountry.MdiParent = this;
                Program.MC.FrmEditorCountry.Show();
            }
            else
            {
                if (Program.MC.FrmEditorCountry.Visible)
                {
                    Program.MC.FrmEditorCountry.WindowState = FormWindowState.Normal;
                    Program.MC.FrmEditorCountry.Focus();
                }
                else
                {
                    Program.MC.FrmEditorCountry.MdiParent = this;
                    Program.MC.FrmEditorCountry.Show();
                }
            }
        }
        private void empStateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.MC.FrmEditorEmpState.IsDisposed)
            {
                Program.MC.FrmEditorEmpState = new EditorEmpStateFrm();
                Program.MC.FrmEditorEmpState.MdiParent = this;
                Program.MC.FrmEditorEmpState.Show();
            }
            else
            {
                if (Program.MC.FrmEditorEmpState.Visible)
                {
                    Program.MC.FrmEditorEmpState.WindowState = FormWindowState.Normal;
                    Program.MC.FrmEditorEmpState.Focus();
                }
                else
                {
                    Program.MC.FrmEditorEmpState.MdiParent = this;
                    Program.MC.FrmEditorEmpState.Show();
                }
            }
        }
        private void nationaltityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.MC.FrmEditorNationality.IsDisposed)
            {
                Program.MC.FrmEditorNationality = new EditorNationalityFrm();
                Program.MC.FrmEditorNationality.MdiParent = this;
                Program.MC.FrmEditorNationality.Show();
            }
            else
            {
                if (Program.MC.FrmEditorNationality.Visible)
                {
                    Program.MC.FrmEditorNationality.WindowState = FormWindowState.Normal;
                    Program.MC.FrmEditorNationality.Focus();
                }
                else
                {
                    Program.MC.FrmEditorNationality.MdiParent = this;
                    Program.MC.FrmEditorNationality.Show();
                }
            }
        }
        private void empEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.MC.FrmAddEmployee.IsDisposed)
            {
                Program.MC.FrmAddEmployee = new AddEmployeeFrm();
                Program.MC.FrmAddEmployee.MdiParent = this;
                Program.MC.FrmAddEmployee.Show();
            }
            else
            {
                if (Program.MC.FrmAddEmployee.Visible)
                {
                    Program.MC.FrmAddEmployee.WindowState = FormWindowState.Normal;
                    Program.MC.FrmAddEmployee.Focus();
                }
                else
                {
                    Program.MC.FrmAddEmployee.MdiParent = this;
                    Program.MC.FrmAddEmployee.Show();
                }
            }
        }
        private void attachEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.MC.FrmAddEmpAttachment.IsDisposed)
            {
                Program.MC.FrmAddEmpAttachment = new AddEmpAttachmentFrm();
                Program.MC.FrmAddEmpAttachment.MdiParent = this;
                Program.MC.FrmAddEmpAttachment.Show();
            }
            else
            {
                if (Program.MC.FrmAddEmpAttachment.Visible)
                {
                    Program.MC.FrmAddEmpAttachment.WindowState = FormWindowState.Normal;
                    Program.MC.FrmAddEmpAttachment.Focus();
                }
                else
                {
                    Program.MC.FrmAddEmpAttachment.MdiParent = this;
                    Program.MC.FrmAddEmpAttachment.Show();
                }
            }
        }
        private void quaEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.MC.FrmAddQualification.IsDisposed)
            {
                Program.MC.FrmAddQualification = new AddQualificationFrm();
                Program.MC.FrmAddQualification.MdiParent = this;
                Program.MC.FrmAddQualification.Show();
            }
            else
            {
                if (Program.MC.FrmAddQualification.Visible)
                {
                    Program.MC.FrmAddQualification.WindowState = FormWindowState.Normal;
                    Program.MC.FrmAddQualification.Focus();
                }
                else
                {
                    Program.MC.FrmAddQualification.MdiParent = this;
                    Program.MC.FrmAddQualification.Show();
                }
            }
        }
        private void insuranceEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.MC.FrmEditorInsurance.IsDisposed)
            {
                Program.MC.FrmEditorInsurance = new EditorInsuranceFrm();
                Program.MC.FrmEditorInsurance.MdiParent = this;
                Program.MC.FrmEditorInsurance.Show();
            }
            else
            {
                if (Program.MC.FrmEditorInsurance.Visible)
                {
                    Program.MC.FrmEditorInsurance.WindowState = FormWindowState.Normal;
                    Program.MC.FrmEditorInsurance.Focus();
                }
                else
                {
                    Program.MC.FrmEditorInsurance.MdiParent = this;
                    Program.MC.FrmEditorInsurance.Show();
                }
            }
        }
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.MC.FrmEditorDepartment.IsDisposed)
            {
                Program.MC.FrmEditorDepartment = new EditorDepartmentFrm();
                Program.MC.FrmEditorDepartment.MdiParent = this;
                Program.MC.FrmEditorDepartment.Show();
            }
            else
            {
                if (Program.MC.FrmEditorDepartment.Visible)
                {
                    Program.MC.FrmEditorDepartment.WindowState = FormWindowState.Normal;
                    Program.MC.FrmEditorDepartment.Focus();
                }
                else
                {
                    Program.MC.FrmEditorDepartment.MdiParent = this;
                    Program.MC.FrmEditorDepartment.Show();
                }
            }
        }
        private void educationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.MC.FrmEditorEducation.IsDisposed)
            {
                Program.MC.FrmEditorEducation = new EditorEducationFrm();
                Program.MC.FrmEditorEducation.MdiParent = this;
                Program.MC.FrmEditorEducation.Show();
            }
            else
            {
                if (Program.MC.FrmEditorEducation.Visible)
                {
                    Program.MC.FrmEditorEducation.WindowState = FormWindowState.Normal;
                    Program.MC.FrmEditorEducation.Focus();
                }
                else
                {
                    Program.MC.FrmEditorEducation.MdiParent = this;
                    Program.MC.FrmEditorEducation.Show();
                }
            }
        }
        private void jobFrmToolStripMenuItem_Click(object sender, EventArgs e)
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
        private void jobDescriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.MC.FrmEditorJobDescription.IsDisposed)
            {
                Program.MC.FrmEditorJobDescription = new EditorJobDescriptionFrm();
                Program.MC.FrmEditorJobDescription.MdiParent = this;
                Program.MC.FrmEditorJobDescription.Show();
            }
            else
            {
                if (Program.MC.FrmEditorJobDescription.Visible)
                {
                    Program.MC.FrmEditorJobDescription.WindowState = FormWindowState.Normal;
                    Program.MC.FrmEditorJobDescription.Focus();
                }
                else
                {
                    Program.MC.FrmEditorJobDescription.MdiParent = this;
                    Program.MC.FrmEditorJobDescription.Show();
                }
            }
        }
        private void militaryTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.MC.FrmEditorMilitaryType.IsDisposed)
            {
                Program.MC.FrmEditorMilitaryType = new EditorMilitaryTypeFrm();
                Program.MC.FrmEditorMilitaryType.MdiParent = this;
                Program.MC.FrmEditorMilitaryType.Show();
            }
            else
            {
                if (Program.MC.FrmEditorMilitaryType.Visible)
                {
                    Program.MC.FrmEditorMilitaryType.WindowState = FormWindowState.Normal;
                    Program.MC.FrmEditorMilitaryType.Focus();
                }
                else
                {
                    Program.MC.FrmEditorMilitaryType.MdiParent = this;
                    Program.MC.FrmEditorMilitaryType.Show();
                }
            }
        }
        private void qualificationToolStripMenuItem_Click(object sender, EventArgs e)
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
        private void specificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.MC.FrmEditorSpecification.IsDisposed)
            {
                Program.MC.FrmEditorSpecification = new EditorSpecificationFrm();
                Program.MC.FrmEditorSpecification.MdiParent = this;
                Program.MC.FrmEditorSpecification.Show();
            }
            else
            {
                if (Program.MC.FrmEditorSpecification.Visible)
                {
                    Program.MC.FrmEditorSpecification.WindowState = FormWindowState.Normal;
                    Program.MC.FrmEditorSpecification.Focus();
                }
                else
                {
                    Program.MC.FrmEditorSpecification.MdiParent = this;
                    Program.MC.FrmEditorSpecification.Show();
                }
            }
        }
        private void trainingProgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.MC.FrmEditorTrainingProg.IsDisposed)
            {
                Program.MC.FrmEditorTrainingProg = new EditorTrainingProgFrm();
                Program.MC.FrmEditorTrainingProg.MdiParent = this;
                Program.MC.FrmEditorTrainingProg.Show();
            }
            else
            {
                if (Program.MC.FrmEditorTrainingProg.Visible)
                {
                    Program.MC.FrmEditorTrainingProg.WindowState = FormWindowState.Normal;
                    Program.MC.FrmEditorTrainingProg.Focus();
                }
                else
                {
                    Program.MC.FrmEditorTrainingProg.MdiParent = this;
                    Program.MC.FrmEditorTrainingProg.Show();
                }
            }
        }
        private void traininPlaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.MC.FrmEditorTraininPlace.IsDisposed)
            {
                Program.MC.FrmEditorTraininPlace = new EditorTraininPlaceFrm();
                Program.MC.FrmEditorTraininPlace.MdiParent = this;
                Program.MC.FrmEditorTraininPlace.Show();
            }
            else
            {
                if (Program.MC.FrmEditorTraininPlace.Visible)
                {
                    Program.MC.FrmEditorTraininPlace.WindowState = FormWindowState.Normal;
                    Program.MC.FrmEditorTraininPlace.Focus();
                }
                else
                {
                    Program.MC.FrmEditorTraininPlace.MdiParent = this;
                    Program.MC.FrmEditorTraininPlace.Show();
                }
            }
        }
        private void universityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.MC.FrmEditorUniversity.IsDisposed)
            {
                Program.MC.FrmEditorUniversity = new EditorUniversityFrm();
                Program.MC.FrmEditorUniversity.MdiParent = this;
                Program.MC.FrmEditorUniversity.Show();
            }
            else
            {
                if (Program.MC.FrmEditorUniversity.Visible)
                {
                    Program.MC.FrmEditorUniversity.WindowState = FormWindowState.Normal;
                    Program.MC.FrmEditorUniversity.Focus();
                }
                else
                {
                    Program.MC.FrmEditorUniversity.MdiParent = this;
                    Program.MC.FrmEditorUniversity.Show();
                }
            }
        }
        private void dgreeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.MC.FrmEditorDgrees.IsDisposed)
            {
                Program.MC.FrmEditorDgrees = new EditorDgreesFrm();
                Program.MC.FrmEditorDgrees.MdiParent = this;
                Program.MC.FrmEditorDgrees.Show();
            }
            else
            {
                if (Program.MC.FrmEditorDgrees.Visible)
                {
                    Program.MC.FrmEditorDgrees.WindowState = FormWindowState.Normal;
                    Program.MC.FrmEditorDgrees.Focus();
                }
                else
                {
                    Program.MC.FrmEditorDgrees.MdiParent = this;
                    Program.MC.FrmEditorDgrees.Show();
                }
            }
        }
        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.MC.FrmQryEmployee.IsDisposed)
            {
                Program.MC.FrmQryEmployee = new QryEmployeeFrm();
                Program.MC.FrmQryEmployee.MdiParent = this;
                Program.MC.FrmQryEmployee.Show();
            }
            else
            {
                if (Program.MC.FrmQryEmployee.Visible)
                {
                    Program.MC.FrmQryEmployee.WindowState = FormWindowState.Normal;
                    Program.MC.FrmQryEmployee.Focus();
                }
                else
                {
                    Program.MC.FrmQryEmployee.MdiParent = this;
                    Program.MC.FrmQryEmployee.Show();
                }
            }
        }
        private void agazaTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.MC.FrmEditorAgazatType.IsDisposed)
            {
                Program.MC.FrmEditorAgazatType = new EditorAgazatTypeFrm();
                Program.MC.FrmEditorAgazatType.MdiParent = this;
                Program.MC.FrmEditorAgazatType.Show();
            }
            else
            {
                if (Program.MC.FrmEditorAgazatType.Visible)
                {
                    Program.MC.FrmEditorAgazatType.WindowState = FormWindowState.Normal;
                    Program.MC.FrmEditorAgazatType.Focus();
                }
                else
                {
                    Program.MC.FrmEditorAgazatType.MdiParent = this;
                    Program.MC.FrmEditorAgazatType.Show();
                }
            }
        }
        private void eznTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.MC.FrmEditorEznType.IsDisposed)
            {
                Program.MC.FrmEditorEznType = new EditorEznTypeFrm();
                Program.MC.FrmEditorEznType.MdiParent = this;
                Program.MC.FrmEditorEznType.Show();
            }
            else
            {
                if (Program.MC.FrmEditorEznType.Visible)
                {
                    Program.MC.FrmEditorEznType.WindowState = FormWindowState.Normal;
                    Program.MC.FrmEditorEznType.Focus();
                }
                else
                {
                    Program.MC.FrmEditorEznType.MdiParent = this;
                    Program.MC.FrmEditorEznType.Show();
                }
            }
        }
        private void agazatEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.MC.FrmDataAgazat.IsDisposed)
            {
                Program.MC.FrmDataAgazat = new DataAgazatFrm();
                Program.MC.FrmDataAgazat.MdiParent = this;
                Program.MC.FrmDataAgazat.Show();
            }
            else
            {
                if (Program.MC.FrmDataAgazat.Visible)
                {
                    Program.MC.FrmDataAgazat.WindowState = FormWindowState.Normal;
                    Program.MC.FrmDataAgazat.Focus();
                }
                else
                {
                    Program.MC.FrmDataAgazat.MdiParent = this;
                    Program.MC.FrmDataAgazat.Show();
                }
            }
        }
        private void repempBasicdataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RepGeneralFrm FrmRepGeneral = new RepGeneralFrm();
            FrmRepGeneral.MdiParent = this;
            Program.MC.RepTy = MCls.ReportType.emp_Basicdata;
            FrmRepGeneral.Show();
        }
        private void repEmpjobdesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RepGeneralFrm FrmRepGeneral = new RepGeneralFrm();
            FrmRepGeneral.MdiParent = this;
            Program.MC.RepTy = MCls.ReportType.Emp_job_des;
            FrmRepGeneral.Show();
        }
        private void repjobstatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RepGeneralFrm FrmRepGeneral = new RepGeneralFrm();
            FrmRepGeneral.MdiParent = this;
            Program.MC.RepTy = MCls.ReportType.job_status;
            FrmRepGeneral.Show();
        }
        private void repmoaahalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RepGeneralFrm FrmRepGeneral = new RepGeneralFrm();
            FrmRepGeneral.MdiParent = this;
            Program.MC.RepTy = MCls.ReportType.moaahal;
            FrmRepGeneral.Show();
        }
        private void repmohealToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RepGeneralFrm FrmRepGeneral = new RepGeneralFrm();
            FrmRepGeneral.MdiParent = this;
            Program.MC.RepTy = MCls.ReportType.moheal;
            FrmRepGeneral.Show();
        }
        private void reptameennoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RepGeneralFrm FrmRepGeneral = new RepGeneralFrm();
            FrmRepGeneral.MdiParent = this;
            Program.MC.RepTy = MCls.ReportType.tameen_no;
            FrmRepGeneral.Show();
        }
        private void dataSalaryFrmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.MC.FrmDataSalary.IsDisposed)
            {
                Program.MC.FrmDataSalary = new DataSalaryFrm();
                Program.MC.FrmDataSalary.MdiParent = this;
                Program.MC.FrmDataSalary.Show();
            }
            else
            {
                if (Program.MC.FrmDataSalary.Visible)
                {
                    Program.MC.FrmDataSalary.WindowState = FormWindowState.Normal;
                    Program.MC.FrmDataSalary.Focus();
                }
                else
                {
                    Program.MC.FrmDataSalary.MdiParent = this;
                    Program.MC.FrmDataSalary.Show();
                }
            }
        }
        #endregion
    }
}
