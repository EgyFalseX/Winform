using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FalseStudio
{
    public partial class FSPluginsFRM : Form
    {
        public FSPluginsFRM()
        {
            InitializeComponent();
        }

        private void FSPluginsFRM_Load(object sender, EventArgs e)
        {
            CBPlugins.Items.Clear();
            for (int i = 0; i < MainCLS.Plugins.Length; i++)
            {
                CBPlugins.Items.Add(MainCLS.Plugins[i].Name);
            }
            if (CBPlugins.Items.Count != 0)
            {
                CBPlugins.SelectedIndex = 0;
                LBLPlugins.Text = MainCLS.Plugins.Length.ToString();
                LBLStarted.Text = "0";
                LBLStoped.Text = "0";
                for (int i = 0; i < MainCLS.Plugins.Length; i++)
                {
                    if (MainCLS.Plugins[i].Started)
                    { LBLStarted.Text = (Convert.ToInt16(LBLStarted.Text) + 1).ToString(); }

                    else { LBLStoped.Text = (Convert.ToInt16(LBLStoped.Text) + 1).ToString(); }
                }

                //put for to loop on who many plugins we have.
                
            }
            else
            {
                ResetForm();
            }
        }

        private void CBPlugins_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBPlugins.SelectedIndex >= 0)
            {
                if (MainCLS.Plugins[CBPlugins.SelectedIndex].Started)
                {
                    BtnStart.Enabled = false;
                    BtnStop.Enabled = true;
                }
                else
                {
                    BtnStart.Enabled = true;
                    BtnStop.Enabled = false;
                }
                BtnOptions.Enabled = true;
                LBLVersion.Text = MainCLS.Plugins[CBPlugins.SelectedIndex].version;
                LBLOwner.Text = MainCLS.Plugins[CBPlugins.SelectedIndex].Owner;
                LBLDate.Text = MainCLS.Plugins[CBPlugins.SelectedIndex].CreationTime;
            } else {
               ResetForm();
            }
        }

        private void ResetForm()
        {
               
            BtnStopAll.Enabled = false;
            BtnStart.Enabled = false;
            BtnStop.Enabled = false;
            BtnOptions.Enabled = false;
            LBLVersion.Text = "0.0.0.0";
            LBLOwner.Text = "None";
            LBLDate.Text = "00/00/00";
            LBLPlugins.Text = "00";
            LBLStarted.Text = "00";
            LBLStoped.Text = "00";
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            
            MainCLS.Plugins[CBPlugins.SelectedIndex].PluginInfo.Start.Invoke(MainCLS.Plugins[CBPlugins.SelectedIndex].PluginInfo.PluginClassInstance, null);
            MainCLS.Plugins[CBPlugins.SelectedIndex].Started = true;
            BtnStart.Enabled = false;
            BtnStop.Enabled = true;
            LBLStarted.Text = (Convert.ToInt16(LBLStarted.Text) + 1).ToString();
            if (Convert.ToInt16(LBLStoped.Text) > 0)
            {
                LBLStoped.Text = (Convert.ToInt16(LBLStoped.Text) - 1).ToString();
            }
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            MainCLS.Plugins[CBPlugins.SelectedIndex].PluginInfo.Stop.Invoke(MainCLS.Plugins[CBPlugins.SelectedIndex].PluginInfo.PluginClassInstance, null);
            MainCLS.Plugins[CBPlugins.SelectedIndex].Started = false;
            BtnStart.Enabled = true;
            BtnStop.Enabled = false;
            LBLStoped.Text = (Convert.ToInt16(LBLStoped.Text) + 1).ToString();
            if (Convert.ToInt16(LBLStarted.Text) > 0)
            {
                LBLStarted.Text = (Convert.ToInt16(LBLStarted.Text) - 1).ToString();
            }
        }

        private void BtnOptions_Click(object sender, EventArgs e)
        {
            MainCLS.Plugins[CBPlugins.SelectedIndex].PluginInfo.ShowOptions.Invoke(MainCLS.Plugins[CBPlugins.SelectedIndex].PluginInfo.PluginClassInstance, null);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
