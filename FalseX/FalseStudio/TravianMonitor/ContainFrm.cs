using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FSPluginnamespace
{
    public partial class ContainFrm : Form
    {
        public int AccIndex;
        int NeededWood;
        int NeededMud;
        int NeededIron;
        int NeededWheat;
        float WoodMins;
        float MudMins;
        float IronMins;
        float WheatMins;
        float TaskMins = 0;
        public ContainFrm()
        {
            InitializeComponent();
        }
        private void ContainFrm_Load(object sender, EventArgs e)
        {
            //Loading From Struc
            TxtWC.Text = FSPluginnamespace.FSPluginClass.Elements[AccIndex].Wood.Count.ToString();
            TxtWH.Text = FSPluginnamespace.FSPluginClass.Elements[AccIndex].Wood.Percent.ToString();
            TxtWB.Text = FSPluginnamespace.FSPluginClass.Elements[AccIndex].Wood.WillB.ToString();

            TxtMC.Text = FSPluginnamespace.FSPluginClass.Elements[AccIndex].Mud.Count.ToString();
            TxtMH.Text = FSPluginnamespace.FSPluginClass.Elements[AccIndex].Mud.Percent.ToString();
            TxtMB.Text = FSPluginnamespace.FSPluginClass.Elements[AccIndex].Mud.WillB.ToString();

            TxtIC.Text = FSPluginnamespace.FSPluginClass.Elements[AccIndex].Iron.Count.ToString();
            TxtIH.Text = FSPluginnamespace.FSPluginClass.Elements[AccIndex].Iron.Percent.ToString();
            TxtIB.Text = FSPluginnamespace.FSPluginClass.Elements[AccIndex].Iron.WillB.ToString();

            TxtWHC.Text = FSPluginnamespace.FSPluginClass.Elements[AccIndex].Wheat.Count.ToString();
            TxtWHH.Text = FSPluginnamespace.FSPluginClass.Elements[AccIndex].Wheat.Percent.ToString();
            TxtWHB.Text = FSPluginnamespace.FSPluginClass.Elements[AccIndex].Wheat.WillB.ToString();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            FSPluginnamespace.FSPluginClass.Elements[AccIndex] = new FSPluginnamespace.FSPluginClass.Element();
            //Save Wood
            FSPluginnamespace.FSPluginClass.Elements[AccIndex].Wood.Count = int.Parse(TxtWC.Text);
            FSPluginnamespace.FSPluginClass.Elements[AccIndex].Wood.Percent = int.Parse(TxtWH.Text);
            FSPluginnamespace.FSPluginClass.Elements[AccIndex].Wood.WillB = int.Parse(TxtWB.Text);
            //Save Mud
            FSPluginnamespace.FSPluginClass.Elements[AccIndex].Mud.Count = int.Parse(TxtMC.Text);
            FSPluginnamespace.FSPluginClass.Elements[AccIndex].Mud.Percent = int.Parse(TxtMH.Text);
            FSPluginnamespace.FSPluginClass.Elements[AccIndex].Mud.WillB = int.Parse(TxtMB.Text);
            //Save Iron
            FSPluginnamespace.FSPluginClass.Elements[AccIndex].Iron.Count = int.Parse(TxtIC.Text);
            FSPluginnamespace.FSPluginClass.Elements[AccIndex].Iron.Percent = int.Parse(TxtIH.Text);
            FSPluginnamespace.FSPluginClass.Elements[AccIndex].Iron.WillB = int.Parse(TxtIB.Text);
            //Save Wheat
            FSPluginnamespace.FSPluginClass.Elements[AccIndex].Wheat.Count = int.Parse(TxtWHC.Text);
            FSPluginnamespace.FSPluginClass.Elements[AccIndex].Wheat.Percent = int.Parse(TxtWHH.Text);
            FSPluginnamespace.FSPluginClass.Elements[AccIndex].Wheat.WillB = int.Parse(TxtWHB.Text);
            // Calc needed Elements
            NeededWood = int.Parse(TxtWB.Text) - int.Parse(TxtWC.Text);
            NeededMud = int.Parse(TxtMB.Text) - int.Parse(TxtMC.Text);
            NeededIron = int.Parse(TxtIB.Text) - int.Parse(TxtIC.Text);
            NeededWheat = int.Parse(TxtWHB.Text) - int.Parse(TxtWHC.Text);
            //Calc Elements Per Mins * NeededElements = Mins needed to complate the task
            WoodMins =NeededWood / (float.Parse(TxtWH.Text) / 60);
            MudMins = NeededMud / (float.Parse(TxtMH.Text) / 60);
            IronMins = NeededIron / (float.Parse(TxtIH.Text) / 60);
            WheatMins = NeededWheat / (float.Parse(TxtWHH.Text) / 60);
            // Get Highest Mins
            if (TaskMins <= WoodMins)
            { 
                TaskMins = WoodMins;
            }
            if (TaskMins <= MudMins)
            {
                TaskMins = MudMins;
            }
            if (TaskMins <= IronMins)
            {
                TaskMins = IronMins;
            }
            if (TaskMins <= WheatMins)
            {
                TaskMins = WheatMins;
            }
            //Save Highest Mins to struc
            FSPluginnamespace.FSPluginClass.Elements[AccIndex].TaskMins = TaskMins;
            this.Close();
        }


    }
}
