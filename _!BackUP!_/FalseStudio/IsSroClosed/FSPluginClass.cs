using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Media;

namespace FSPluginnamespace
{
    public class FSPluginClass
    {
        int SroHighest = 0;
        public Timer Tmr = new Timer();
        public void StartPlugin()
        {
            Tmr.Interval = 2000;
            Tmr.Tick += new EventHandler(Tmr_Tick);
            Tmr.Start();
        }
        public void StopPlugin()
        {
            Tmr.Stop();
        }
        public void ShowOptions()
        {
            MessageBox.Show("IsSroClosed Plugin Have No Options");
        }

        public string GetOwner()
        {
            return "FalseX";
        }

        public string GetVersion()
        {
            return Application.ProductVersion.ToString();
        }

        public void Tmr_Tick(object sender, EventArgs e)
        {
            int SroCount = 0;
            foreach (Process SroPro in Process.GetProcesses())
            {
                if (SroPro.ProcessName.ToLower() == "sro_client")
                {
                    SroCount++;

                }
            }
            System.Console.WriteLine("SroHighest = " + SroHighest + " / SroCount = " + SroCount);
            if (SroHighest > SroCount)
            {
                SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chimes.wav");
                simpleSound.Play();
            }
                SroHighest = SroCount;
        }

    }
}
