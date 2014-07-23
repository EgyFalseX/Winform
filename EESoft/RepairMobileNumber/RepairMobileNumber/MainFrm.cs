using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace RepairMobileNumber
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            ThreadPool.QueueUserWorkItem((o) =>
            {
                this.Invoke(new MethodInvoker(() =>
                {
                    tabControlMain.Enabled = false;
                    lblState.Text = "Load Data From Database";
                    this.mobileDataTableAdapter.Fill(this.dsMobile.MobileData);
                    lblState.Text = "Ready";
                    tabControlMain.Enabled = true;
                }));
            });
        }
        private void MainFrm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnRepairMobile_Click(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem((o) =>
            {
                
                this.Invoke(new MethodInvoker(() =>
                {
                    tabControlMain.Enabled = false;
                    pb.Maximum = dsMobile.MobileData.Count;
                    pb.Value = 0;
                    pb.Visible = true;
                }));
                
                try
                {
                    for (int i = 0; i < dsMobile.MobileData.Count; i++)
                    {
                        this.Invoke(new MethodInvoker(() =>
                        {
                            pb.Value = Convert.ToInt32(pb.Value) + 1;
                            int pers = Convert.ToInt32((Convert.ToDouble(pb.Value) / Convert.ToDouble(pb.Maximum)) * 100);
                            lblState.Text = string.Format("{0}% Repair Mobile Numbers", pers);
                        }));
                        
                        dsMobile.MobileData[i].Mobile = GetNumberOnly(dsMobile.MobileData[i].Mobile);
                        dsMobile.MobileData[i].Mobile = RepairMobileLength(dsMobile.MobileData[i].Mobile);
                        dsMobile.MobileData[i].EndEdit();
                        //mobileDataTableAdapter.UpdateMobile(Mobile, row.id);
                        //Application.DoEvents();
                        if (i % 1000 == 0)
                        {
                            //this.Invoke(new MethodInvoker(() =>
                            //{
                            //    lblState.Text = "Saving ...";
                            //}));
                            mobileDataTableAdapter.Update(dsMobile.MobileData);
                            dsMobile.MobileData.AcceptChanges();
                        }
                    }
                    mobileDataTableAdapter.Update(dsMobile.MobileData);
                   
                    
                    //foreach (dsMobile.MobileDataRow row in dsMobile.MobileData)
                    //{
                    //    pb.Value = Convert.ToInt32(pb.Value) + 1;
                    //    row.Mobile = GetNumberOnly(row.Mobile);
                    //    row.Mobile = RepairMobileLength(row.Mobile);
                    //    row.EndEdit();
                    //    //mobileDataTableAdapter.UpdateMobile(Mobile, row.id);
                    //    Application.DoEvents();
                    //}
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                this.Invoke(new MethodInvoker(() =>
                {
                    pb.Value = 0;
                    pb.Visible = true;
                    lblState.Text = "Ready";
                    tabControlMain.Enabled = true;
                    pb.Visible = false;
                }));
                
                LoadData();
                MessageBox.Show("Repair Done ...", "Finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
            });
        }
        string GetNumberOnly(string txt)
        {
            string output = string.Empty;
            foreach (char chr in txt)
            {
                if (Char.IsNumber(chr))
                    output = output + chr;
            }
            return output;
        }
        string RepairMobileLength(string txt)
        {
            string output = string.Empty;
            if (txt.Length != 10)
                return txt;
            string startTxt = txt.Substring(0, 3);
            string endTxt = txt.Substring(3);
            switch (startTxt)
            {
                case "010":
                    output = "0100" + endTxt;
                    break;
                case "011":
                    output = "0111" + endTxt;
                    break;
                case "012":
                    output = "0122" + endTxt;
                    break;
            }
            return output;
        }
    }
}
