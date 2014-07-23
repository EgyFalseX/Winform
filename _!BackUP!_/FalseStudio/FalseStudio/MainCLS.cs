using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Reflection;
using System.IO;
namespace FalseStudio
{
    public static class MainCLS
    {
        public struct PluginsSTR
        {
            public string Name;
            public string version;
            public string CreationTime;
            public string Size;
            public string Owner;
            public bool Started;
            public Assembly Assemblyer;
            public PluginsInfoSTR PluginInfo;
        }
        public struct PluginsInfoSTR
        {
            public MethodInfo Start;
            public MethodInfo Stop;
            public MethodInfo ShowOptions;
            public object PluginClassInstance;
        }
        public static System.ComponentModel.IContainer componentz = new System.ComponentModel.Container();
        public static NotifyIcon TrayIcon = new NotifyIcon();
        public static ContextMenuStrip CMenuStrip = new ContextMenuStrip();
        public static OptionsFRM FRMOptions = new OptionsFRM();
        public static FSPluginsFRM FRMPlugins = new FSPluginsFRM();
        public static PluginsSTR[] Plugins;
        public static void Initialize()
        {
         CMenuStrip = new ContextMenuStrip(componentz);
         TrayIcon = new System.Windows.Forms.NotifyIcon(componentz);
         TrayIcon.Icon = new System.Drawing.Icon(Application.StartupPath + @"\FalseStudio.ico");
         TrayIcon.Text="This is False Studio Main Class";
         TrayIcon.Visible=true;
         TrayIcon.ContextMenuStrip = CMenuStrip;
         CMenuStrip.Items.Add("Plugins").Click += new EventHandler(FalseStudioOPlugins);
         CMenuStrip.Items.Add("Options").Click += new EventHandler(FalseStudioOptions);
         CMenuStrip.Items.Add("Exit").Click += new EventHandler(FalseStudioExit);
         CMenuStrip.Items.Add("None");
         CMenuStrip.SuspendLayout();
         GetAllPlugins();
        }
        public static void FalseStudioExit(object sender, EventArgs e)

        {
         Application.Exit();

        }
        public static void FalseStudioOptions(object sender, EventArgs e)
     
        {
         if (FRMOptions.Visible == true)
         {FRMOptions.Focus();} else {
             FRMOptions = new OptionsFRM();
             FRMOptions.Show(); }
        }
        public static void FalseStudioOPlugins(object sender, EventArgs e)
        {

            if (FRMPlugins.Visible == true)
            { FRMPlugins.Focus(); }
            else
            {
                FRMPlugins = new FSPluginsFRM();
                FRMPlugins.Show();
            }
        }
        public static void GetAllPlugins()
        {
         DirectoryInfo di = new DirectoryInfo(Application.StartupPath + @"\Plugins");
         foreach (FileInfo fi in di.GetFiles("*.dll"))
         {
             if (Plugins != null)
             {
                 PluginsSTR[] NewArr = new PluginsSTR[Plugins.Length + 1];
                 Array.Copy(Plugins, NewArr, Plugins.Length);
                 Plugins = NewArr;
          
             } else { Plugins = new PluginsSTR[1]; }
             Plugins[Plugins.Length -1].Name = fi.Name;
             Plugins[Plugins.Length -1].CreationTime = fi.CreationTime.ToString();
             Plugins[Plugins.Length -1].Size = fi.Length.ToString();
             Plugins[Plugins.Length - 1].Assemblyer = Assembly.LoadFile(fi.FullName);
             Plugins[Plugins.Length - 1].PluginInfo.PluginClassInstance = Plugins[Plugins.Length - 1].Assemblyer.CreateInstance("FSPluginnamespace.FSPluginClass");
             Plugins[Plugins.Length - 1].PluginInfo.Start = Plugins[Plugins.Length - 1].PluginInfo.PluginClassInstance.GetType().GetMethod("StartPlugin");
             Plugins[Plugins.Length - 1].PluginInfo.Stop = Plugins[Plugins.Length - 1].PluginInfo.PluginClassInstance.GetType().GetMethod("StopPlugin");
             Plugins[Plugins.Length - 1].PluginInfo.ShowOptions = Plugins[Plugins.Length - 1].PluginInfo.PluginClassInstance.GetType().GetMethod("ShowOptions");
             Plugins[Plugins.Length - 1].version = Plugins[Plugins.Length - 1].PluginInfo.PluginClassInstance.GetType().GetMethod("GetVersion").Invoke(Plugins[Plugins.Length - 1].PluginInfo.PluginClassInstance, null).ToString();
             Plugins[Plugins.Length - 1].Owner = Plugins[Plugins.Length - 1].PluginInfo.PluginClassInstance.GetType().GetMethod("GetOwner").Invoke(Plugins[Plugins.Length - 1].PluginInfo.PluginClassInstance, null).ToString();
         }
         //this is the show options method.
         //Plugins[0].PluginInfo.ShowOptions.Invoke(Plugins[0].PluginInfo.PluginClassInstance, null); 
            //MessageBox.Show("All Plugins Successfully Loaded");
            FRMPlugins.Show();

        }
    }
}   