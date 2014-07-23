using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace FSPluginnamespace
{
    public partial class OptionsFRM : Form
    {
        public OptionsFRM()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbProcessName.Text == string.Empty || cbPriority.SelectedIndex == -1)
            {
                MessageBox.Show("Please Enter A Name And Select A Priority...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //ListViewItem LVI = new ListViewItem(tbProcessName.Text);
            //LVI.SubItems[0].Text = cbPriority.SelectedText;
            ListViewItem LVI = new ListViewItem("AAA");
            LVI.SubItems[0].Text = "BBB";
            MyList.Items.Add(LVI);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MyList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please Select An Item To Delete It...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MyList.SelectedItems[0].Remove();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                mytimer.Interval = Convert.ToInt32(tbTime.Text) * 1000;
                mytimer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            mytimer.Stop();
        }
        private void mytimer_Tick(object sender, EventArgs e)
        {
            foreach (ListViewItem item in MyList.Items)
            {
                string Msg = SetPriority(item.Text, item.SubItems[0].Text);
                if (Msg != string.Empty)
                    tbLog.Text += Environment.NewLine + Msg;
            }
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private string SetPriority(string ProcessName, string PriorityName)
        {
            string returnMe = string.Empty;

            Process[] Pros = Process.GetProcessesByName("ProcessName");

            for (int i = 0; i < Pros.Length; i++)
            {
                switch (PriorityName)
                {
                    case "RealTime":
                        Pros[i].PriorityClass = ProcessPriorityClass.RealTime;
                        break;
                    case "High":
                        Pros[i].PriorityClass = ProcessPriorityClass.High;
                        break;
                    case "Above Normal":
                        Pros[i].PriorityClass = ProcessPriorityClass.AboveNormal;
                        break;
                    case "Normal":
                        Pros[i].PriorityClass = ProcessPriorityClass.Normal;
                        break;
                    case "Below Normal":
                        Pros[i].PriorityClass = ProcessPriorityClass.BelowNormal;
                        break;
                    case "Low":
                        Pros[i].PriorityClass = ProcessPriorityClass.Idle;
                        break;
                }
            }
            

            return returnMe;
        }
    }
}
