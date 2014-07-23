using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data;
using System.ServiceProcess;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Runtime.InteropServices;//for the DllImport function



namespace IbotStarter
{
    [StructLayout(LayoutKind.Sequential)]
    public struct RECT
    {
        public int Left;
        public int Top;
        public int Right;
        public int Bottom;
    }
    
    public partial class FrmMain : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr FindWindow(string ClassName, string WindowName);
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);
        [DllImport("USER32.DLL")]
        public static extern int SendMessage(IntPtr hwnd, int msg, int character, IntPtr lpsText);
        [DllImport("user32.dll")]
        static extern bool GetClientRect(IntPtr hWnd, out RECT lpRect);

        //these are the internal messages used in C++ and in windows
        //they're already defined in some header files in C++ ".h" but because we are in .net environment
        //we need to define them here, you can pass the number to the API function directly, but this is better
        //for understanding
        private const int WM_CLOSE = 0x10;
        private const int WM_QUIT = 0x12;
        private const uint WM_MOUSEMOVE = 0x200;
        public const int WM_PAINT = 0xF;
        

        Process ibotF03;
        Process ibotF01;
        Timer Tmr = new Timer();


        public FrmMain()
        {
            InitializeComponent();
        }
        private static IntPtr GetNotifyWindow()
        {
            IntPtr shellTrayHwnd = FindWindow("Shell_TrayWnd", null);
            IntPtr trayNotifyHwnd = FindWindowEx(shellTrayHwnd, IntPtr.Zero, "TrayNotifyWnd", null);
            IntPtr sysPagerHwnd = FindWindowEx(trayNotifyHwnd, IntPtr.Zero, "SysPager", null);
            return FindWindowEx(sysPagerHwnd, IntPtr.Zero, "ToolbarWindow32", null);
        }
        private static void RefreshTaskbarNotificationArea()
        {
            IntPtr shellTrayHwnd = FindWindow("Shell_TrayWnd", null);
            IntPtr WndNotificationArea = GetNotifyWindow();
            //SendMessage(WndNotificationArea, WM_PAINT, 0, IntPtr.Zero);//repaint the window
            RECT rect;
            GetClientRect(WndNotificationArea, out rect);
            for (int x = 0; x < rect.Right; x += 15)
            {
                for (int y = 0; y < rect.Bottom; y += 15)
                {
                    SendMessage(WndNotificationArea, WM_MOUSEMOVE, 0, (y << 16) + x);
                }
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            ibotF03 = new Process();
            ibotF03.StartInfo = new ProcessStartInfo(Application.StartupPath + "\\iBot.exe", "SN:12 SU:false7 SP:123456 AS:FX01C AB:1 AC:20000 HI CL");
            ibotF01 = new Process();
            ibotF01.StartInfo = new ProcessStartInfo(Application.StartupPath + "\\iBot.exe", "SN:12 SU:false5 SP:123456 AS:FX01C AB:1 AC:20000 HI CL");
            Tmr.Interval = 25000;
            Tmr.Tick += Tmr_Tick;
            ibotF03.Start();
            ibotF01.Start();
            //if (MessageBox.Show("Start F03", "Starting ...", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            //{
                
            //}
            //if (MessageBox.Show("Start F01", "Starting ...", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            //{
                
            //}
            Tmr.Enabled = true;
            Visible = false;
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Tmr.Enabled = false;
            try
            {
                ibotF03.Kill();
                ibotF01.Kill();
                RefreshTaskbarNotificationArea();
            }
            catch
            {}
            Application.Exit();
        }
        private void Tmr_Tick(object sender, EventArgs e)
        {
            try
            {
                if (ibotF03.HasExited)
                {
                    ibotF03.Start();
                }
                else
                {
                    ibotF03.Kill();
                    RefreshTaskbarNotificationArea();
                    ibotF03.Start();
                }
            }
            catch (Exception ex)
            {
                if (ex.Message == "No process is associated with this object.")
                {
                    ibotF03.Start();
                }
            }
            try
            {
                if (ibotF01.HasExited)
                {
                    ibotF01.Start();
                }
                else
                {
                    ibotF01.Kill();
                    RefreshTaskbarNotificationArea();
                    ibotF01.Start();
                }
            }
            catch (Exception ex)
            {
                if (ex.Message == "No process is associated with this object.")
                {
                    ibotF01.Start();
                }
            }
            
        }
        private void notifyIconIbot_DoubleClick(object sender, EventArgs e)
        {
            if (Visible == true)
                Visible = false;
            else
                Visible = true;
        }

        
        

    }
}
