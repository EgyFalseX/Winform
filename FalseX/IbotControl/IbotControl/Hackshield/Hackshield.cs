using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Drawing;

namespace IbotControl.Hackshield
{
    class HackshieldServer : IDisposable
    {
        # region Dispose
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                ClientStyleChanged = null; ReceivedStatus = null;
                try
                {
                    if (HSProcess != null)
                    {
                        if (!HSProcess.HasExited)
                            KillProcessTree(HSProcess);
                        HSProcess.OutputDataReceived -= process_OutputDataReceived;
                        HSProcess.Dispose();
                        HSProcess = null;
                    }
                } catch{ }
                try
                {
                    if (launcherProcess != null)
                    {
                        if (!launcherProcess.HasExited)
                        {
                            KillProcessTree(launcherProcess);
                            launcherProcess.Dispose();
                        }
                        launcherProcess = null;
                    }
                } catch { }
                KillAllJavaProcess();
                CloseClientWindow(Sro_ClientHandle);
                KillAllSilkroadLauncher();
                List<IntPtr> wHnds = GetAllSroClientHandle();
                foreach (IntPtr wHnd in wHnds)
                    CloseClientWindow(wHnd);
            }
        }
        public static void KillProcessTree(Process root)
        {
            if (root != null)
            {
                var list = new List<Process>();
                GetProcessAndChildren(Process.GetProcesses(), root, list, 1);

                foreach (Process p in list)
                {
                    try
                    {
                        p.Kill();
                    }
                    catch (Exception ex)
                    {
                        //Log error?
                    }
                }
            }
        }
        private static void GetProcessAndChildren(Process[] plist, Process parent, List<Process> output, int indent)
         {
             try
             {
                 foreach (Process p in plist)
                 {
                     if (parent == null)
                         continue;
                     if (GetParentProcessId(p) == parent.Id)
                         GetProcessAndChildren(plist, p, output, indent + 1);
                 }
                 output.Add(parent);
             } catch { }
         }
        private static int GetParentProcessId(Process p)
         {
             int parentId = 0;
             try
             {
                 ManagementObject mo = new ManagementObject("win32_process.handle='" + p.Id + "'");
                 mo.Get();
                 parentId = Convert.ToInt32(mo["ParentProcessId"]);
             }
             catch (Exception ex)
             {
                 Console.WriteLine(ex.ToString());
                 parentId = 0;
             }
             return parentId;
         }

        private void KillProcessAndChildren_NOTINUSE(int pid)
         {
             using (var searcher = new ManagementObjectSearcher("Select * From Win32_Process Where ParentProcessID=" + pid))
             using (ManagementObjectCollection moc = searcher.Get())
             {
                 foreach (ManagementObject mo in moc)
                 {
                     KillProcessAndChildren_NOTINUSE(Convert.ToInt32(mo["ProcessID"]));
                 }
                 try
                 {
                     Process proc = Process.GetProcessById(pid);
                     proc.Kill();
                 }
                 catch (ArgumentException)
                 { /* process already exited */ }
             }
         }
        ~HackshieldServer()
        {
            Dispose(false);
        }
        # endregion

        RichTextBox rtb;
        private bool launcherStarted = false;
        private IntPtr launcherHandle = IntPtr.Zero;
        private IntPtr StartButtonHandle = IntPtr.Zero;
        public IntPtr Sro_ClientHandle = IntPtr.Zero;
        public Process launcherProcess = null;
        private System.Threading.Timer SilkroadLauncherReadyTimout;
        public event HSTypes.SroClientStyleEventhandler ClientStyleChanged;
        public event HSTypes.ReceivedStatusEventhandler ReceivedStatus;
        private string Ip = string.Empty;
        private string Port = string.Empty;

        public HackshieldServer(RichTextBox logProvider)
        {
            rtb = logProvider;
        }

        private void GetStartButtonHandle()
        {
            StartButtonHandle = Win32.GetDlgItem(launcherHandle, 0x000003E8);
            if (StartButtonHandle == IntPtr.Zero)
            {
                System.Threading.Thread.Sleep(5000);
                GetStartButtonHandle();
            }
        }
        private bool SearchByTitle(IntPtr hWnd, IntPtr lParam, string compareTitle, ref IntPtr outWhnd)
        {
            int size = Win32.GetWindowTextLength(hWnd);

            if (size++ > 0)
            {
                StringBuilder sb = new StringBuilder(size);
                Win32.GetWindowText(hWnd, sb, size);
                if (sb.ToString() == compareTitle)
                {
                    outWhnd = hWnd;
                    return false;
                }
                else
                    return true;
            }
            else
                return true; 
        }
        public void StartHackshield(string ip, string port)
        {
            Ip = ip; Port = port;
            Process process = new Process();
            process.EnableRaisingEvents = false;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.WorkingDirectory = Properties.Settings.Default.SroPath;
            process.StartInfo.FileName = @"java.exe";
            process.StartInfo.Arguments = string.Format("-jar Hackshield.jar {0} {1}", Ip, Port);            
            process.OutputDataReceived += process_OutputDataReceived;
            process.Start();
            process.BeginOutputReadLine();
            HSProcess = process;
            

        }
        public Process HSProcess { get; set; }
        void process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            try
            {
                HSTypes.HSLogTypes typ = HSTypes.GetLogType(e.Data);
                AddEvent(typ, e.Data);
            }
            catch 
            { }
        }
        List<HSTypes.HSLogTypes> Events = new List<HSTypes.HSLogTypes>();
        public void AddEvent(HSTypes.HSLogTypes typ, string text)
        {
            Events.Add(typ);
            WriteLog(typ, text);
            Application.DoEvents();
            hsReceivedDataAnalysis(typ);
        }
        private void WriteLog(HSTypes.HSLogTypes typ, string text)
        {
            text = string.Format("[{0}] {1}.", DateTime.Now.ToLongTimeString(), text);

            Color color = Color.DarkGray;
            switch (typ)
            {
                case HSTypes.HSLogTypes.ClientAccepted:
                case HSTypes.HSLogTypes.SilkroadLauncherIsReady:
                    color = Color.Green;
                    break;
                case HSTypes.HSLogTypes.Clientdisconnected:
                case HSTypes.HSLogTypes.CriticalError:
                case HSTypes.HSLogTypes.ERROR:
                case HSTypes.HSLogTypes.ERRORHSData:
                case HSTypes.HSLogTypes.ERRORRestartHS:
                    color = Color.Red;
                    break;
                case HSTypes.HSLogTypes.IPHS:
                case HSTypes.HSLogTypes.WaitingForHSClient:
                    color = Color.Lime;
                    break;
            }
            
            MethodInvoker action = delegate
            {
                if (text == null)
                    return;
                int length = rtb.TextLength;  // at end of text
                rtb.AppendText(text + Environment.NewLine);
                rtb.SelectionStart = length;
                rtb.SelectionLength = text.Length;
                rtb.SelectionColor = color;
                rtb.SelectionLength = 0;
                rtb.ScrollToCaret();
            };
            try { rtb.Invoke(action); } catch { }
           
        }

        //Main Process
        private void hsReceivedDataAnalysis(HSTypes.HSLogTypes typ)
        {
            switch (typ)
            {
                case HSTypes.HSLogTypes.IPHS:
                        System.Threading.Thread.Sleep(3000);
                        //SilkroadLauncherReadyTimout = new System.Threading.Timer(_ => SilkroadLauncherReadyTimout_Tick(), null, 1000 * 60 * 20, System.Threading.Timeout.Infinite);
                        StartLauncher();
                    break;
                case HSTypes.HSLogTypes.WaitingForSroClient:
                    break;
                case HSTypes.HSLogTypes.ClientAccepted:
                    try
                    {
                        launcherStarted = true;
                        launcherHandle = Win32.FindWindow(null, HSTypes.LauncherTitle);
                        //Win32.ShowWindowAsync(launcherHandle, Win32.WindowShowStyle.Hide);
                    } catch{}
                    break;
                case HSTypes.HSLogTypes.ConnectingToServer:
                    break;
                case HSTypes.HSLogTypes.InitializingPleaseWait:
                    break;
                case HSTypes.HSLogTypes.SilkroadLauncherIsReady:
                    try
                    {
                        System.Threading.Thread.Sleep(5000);
                        GetStartButtonHandle();
                        Win32.SendMessage(StartButtonHandle, Win32.BM_CLICK, 0, 0);
                    }
                    catch { }
                    break;
                case HSTypes.HSLogTypes.Clientdisconnected:
                    break;
                case HSTypes.HSLogTypes.CriticalError:
                    Dispose();
                    StartHackshield(Ip, Port);
                    break;
                case HSTypes.HSLogTypes.SROClientIsNowReady:
                    break;
                case HSTypes.HSLogTypes.StartingHSServerListener:
                    break;
                case HSTypes.HSLogTypes.WaitingForHSClient:
                    SilkroadLauncherReadyTimout.Dispose();
                    launcherStarted = false;
                    if (Visable)
                        ResizeHideClient();
                    break;
                case HSTypes.HSLogTypes.ERROR:
                case HSTypes.HSLogTypes.ERRORHSData:
                case HSTypes.HSLogTypes.ERRORRestartHS:
                    Restart();
                    break;
                case HSTypes.HSLogTypes.Unknown:
                    break;
            }
            if (ReceivedStatus != null)
                ReceivedStatus(this, typ);
        }

        private void StartLauncher()
        {
            SilkroadLauncherReadyTimout = new System.Threading.Timer(_ => SilkroadLauncherReadyTimout_Tick(), null, 1000 * 60 * 15, System.Threading.Timeout.Infinite);
            if (launcherProcess != null)
            {
                if (!launcherProcess.HasExited)
                    launcherProcess.Kill();
                launcherProcess.Dispose();
                launcherProcess = null;
            }
            launcherProcess = new Process();
            launcherProcess.StartInfo.WorkingDirectory = Properties.Settings.Default.SroPath;
            launcherProcess.StartInfo.FileName = Properties.Settings.Default.SroPath + "\\silkroad.exe";
            launcherProcess.Start();
        }
        void SilkroadLauncherReadyTimout_Tick()
        {
            SilkroadLauncherReadyTimout.Dispose();
            Restart();
        }
        public void Restart()
        {
            Dispose();
            StartHackshield(Ip, Port);
        }
        private void KillAllJavaProcess()
        {
            foreach (Process item in Process.GetProcessesByName("Java"))
            {
                if (!item.HasExited)
                {
                    try
                    { item.Kill(); }
                    catch { }
                }
            }
        }
        private void KillAllSilkroadLauncher()
        {
            foreach (Process item in Process.GetProcesses())
            {
                if (item.ProcessName == "silkroad")
                {
                    try
                    { item.Kill(); }
                    catch { }
                }
            }
        }

        #region Sro Client
        public void SroClientStyle(Win32.WindowShowStyle style)
        {
            if (Sro_ClientHandle == IntPtr.Zero)
                return;
            Win32.ShowWindowAsync(Sro_ClientHandle, style);
            if (ClientStyleChanged != null)
                ClientStyleChanged(style);
        }
        private IntPtr GetSroClientHandle(Process process)
        {
            IntPtr wHnd = IntPtr.Zero;
            var list = new List<Process>();
            GetProcessAndChildren(Process.GetProcesses(), process, list, 1);
            foreach (Process p in list)
            {
                try
                {
                    wHnd = FindWindowInProcess(p, "SRO_CLIENT");
                    if (wHnd != IntPtr.Zero)
                        break;
                } catch {}
            }
            return wHnd;
        }
        private List<IntPtr> GetAllSroClientHandle()
        {
            List<IntPtr> lst = new List<IntPtr>();
            foreach (Process p in Process.GetProcessesByName("SRO_CLIENT"))
            {
                try
                {
                    IntPtr wHnd = FindWindowInProcess(p, "SRO_CLIENT");
                    if (wHnd != IntPtr.Zero)
                        lst.Add(wHnd);
                } catch { }
            }
            return lst;
            //Sro_ClientHandle = IntPtr.Zero;
            //var list = new List<Process>();
            //GetProcessAndChildren(Process.GetProcesses(), launcherProcess, list, 1);
            //foreach (Process p in list)
            //{
            //    //if (p.HasExited)
            //    //    continue;
            //    Sro_ClientHandle = FindWindowInProcess(p, "SRO_CLIENT");
            //    if (Sro_ClientHandle != IntPtr.Zero)
            //        break;
            //}
        }
        
        private IntPtr FindWindowInProcess(Process process, string compareTitle)
        {
            IntPtr windowHandle = IntPtr.Zero;
            foreach (ProcessThread t in process.Threads)
            {
                Win32.EnumThreadWindows(t.Id, (hWnd, lParam) =>
                {
                    StringBuilder str = new StringBuilder(15);
                    Win32.SendMessage(hWnd, (uint)Win32.WM_GETTEXT, 99, str);
                    if (str.ToString() == compareTitle)
                    {
                        windowHandle = hWnd;
                        return false;
                    }
                    else
                        return true;
                }, IntPtr.Zero);
                if (windowHandle != IntPtr.Zero)
                    break;
            }

            return windowHandle;
        }
        public void CloseClientWindow(IntPtr wHnd)
        {
            //const int WM_SYSCOMMAND = 0x0112;
            //const int SC_CLOSE = 0xF060;
            try
            {
                if (wHnd == IntPtr.Zero)
                    return;
                Win32.SendMessage(wHnd, Win32.WM_DESTROY, 0, 0);
                if (!Win32.GetOSFriendlyName().Contains("XP"))
                    CloseClientWindowDialog();
            } catch {}

            //IntPtr hWnd = Win32.OpenProcess(Win32.ProcessAccessFlags.All, false, Process.GetProcessesByName("sro_client")[0].Id);
            //Win32.TerminateProcess(hWnd, 0);
            //Win32.CloseHandle(hWnd);

            //uint ProcessId;
            //Win32.GetWindowThreadProcessId(wHnd, out ProcessId);
            //if (ProcessId != 0)
            //{
            //    try
            //    {
            //        Process pro = Process.GetProcessById(Convert.ToInt32(ProcessId));
            //        Win32.TerminateProcess(pro.Handle, 61234);
            //        foreach (System.Diagnostics.ProcessThread thrd in pro.Threads)
            //        {
            //            IntPtr ptrThread = Win32.OpenThread(1, false, (uint)thrd.Id);
            //            Win32.TerminateThread(ptrThread, 1);
                        
            //        }
            //        //pro.Kill();
            //        //KillProcessTree(pro);
            //        //Process.GetProcessById(Convert.ToInt32(ProcessId)).Kill();
            //    }
            //    catch (System.ComponentModel.Win32Exception e)
            //    {
            //        Console.WriteLine("The process is terminating or could not be terminated.");
            //    }
            //    catch (InvalidOperationException e)
            //    {
            //        Console.WriteLine("The process has already exited.");
            //    }
            //    catch (Exception e)  // some other exception
            //    {
            //        Console.WriteLine("{0} Exception caught.", e);
            //    }
            //}

        }
        public void CloseClientWindowDialog()
        {
            try
            {
                IntPtr dlg = Win32.FindWindow("#32770", "sro_client.exe");
                while (dlg == IntPtr.Zero)
                {
                    dlg = Win32.FindWindow("#32770", "sro_client.exe");
                    System.Threading.Thread.Sleep(500);
                }
                while (dlg != IntPtr.Zero)
                {
                    Win32.SendMessage(dlg, Win32.WM_CLOSE, 0, 0);
                    dlg = Win32.FindWindow("#32770", "sro_client.exe");
                    System.Threading.Thread.Sleep(500);
                }
            } catch{}
        }
        private void ResizeHideClient()
        {
            Sro_ClientHandle = GetSroClientHandle(launcherProcess);
            SroClientStyle(Win32.WindowShowStyle.ShowNormal);
            System.Threading.Thread.Sleep(1000);

            Win32.SetForegroundWindow(Sro_ClientHandle);
            System.Threading.Thread.Sleep(1000);

            ResizeClient(100, 100);
            System.Threading.Thread.Sleep(1000);

            Win32.PostMessage(Sro_ClientHandle, Win32.WM_KEYDOWN, Win32.VK_RETURN, 0); Win32.PostMessage(Sro_ClientHandle, Win32.WM_KEYUP, Win32.VK_RETURN, 0);
            System.Threading.Thread.Sleep(1000);     
                   
            SroClientStyle(Win32.WindowShowStyle.Hide);
        }
        public void ResizeClient(int x, int y)
        {
            Win32.SetWindowPos(Sro_ClientHandle, IntPtr.Zero, 5, 5, x, y, Win32.SetWindowPosFlags.DoNotActivate);
        }
        public bool Visable
        {
            get
            {
                Sro_ClientHandle = GetSroClientHandle(launcherProcess);
                if (Sro_ClientHandle == IntPtr.Zero)
                    return false;
                else
                    return Win32.IsWindowVisible(Sro_ClientHandle.ToInt32()); 
            }
            set
            {
                if (value)
                    SroClientStyle(Win32.WindowShowStyle.Show);
                else
                    SroClientStyle(Win32.WindowShowStyle.Hide);
            }
        }

        #endregion

    }
}
