using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using log4net;
using log4net.Core;

namespace DataCenter.Forms
{
    public partial class DebugLogsFrm : DevExpress.XtraEditors.XtraForm
    {

        #region -   Variables   -
        private bool logWatching = true;
        private log4net.Appender.MemoryAppender logger;
        private Thread logWatcher;

        #endregion
        #region -   Functions   - 
        public DebugLogsFrm()
        {
            InitializeComponent();
            logger = new log4net.Appender.MemoryAppender();
            // Could use a fancier Configurator if you don't want to catch every message  
            log4net.Config.BasicConfigurator.Configure(logger);

            //var root = ((log4net.Repository.Hierarchy.Hierarchy)LogManager.GetRepository()).Root;
            //var attachable = root as IAppenderAttachable;
            //if (attachable != null)
            //    attachable.AddAppender(logger);

            // Since there are no events to catch on logging, we dedicate  
            // a thread to watching for logging events  
            logWatcher = new Thread(new ThreadStart(LogWatcher));
            logWatcher.Start(); 
        }
        #endregion
        #region - Event Handlers -
        protected override void SetVisibleCore(bool value)
        {
            if (!IsHandleCreated && value)
            {
                base.CreateHandle();
                if (true)
                {
                    value = true;// set false to invisible
                }
            }
            base.SetVisibleCore(value);
        }
        private void LogsFrm_Load(object sender, EventArgs e)
        {

        }
        private void LogsFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Gotta stop our logging thread  
            logWatching = false;
            logWatcher.Join();  
        }
        private void LogWatcher()
        {
            try
            {
                //this.Invoke(new MethodInvoker(() => { this.Text = "النتائج"; this.ResumeLayout(false); }));
                // we loop until the Form is closed  
                while (logWatching)
                {
                    LoggingEvent[] events = logger.GetEvents();
                    if (events != null && events.Length > 0)
                    {
                        // if there are events, we clear them from the logger,  
                        // since we're done with them  
                        logger.Clear();
                        foreach (LoggingEvent ev in events)
                        {
                            StringBuilder builder;
                            // the line we want to log  
                            string line = ev.LoggerName + ": " + ev.RenderedMessage + "\r\n";
                            // don't want to grow this log indefinetly, so limit to 100 lines  

                            this.Invoke(new MethodInvoker(() =>
                            {
                                if (mLog.Lines.Length > 99)
                                {
                                    builder = new StringBuilder(mLog.Text);
                                    // strip out a nice chunk from the beginning  
                                    builder.Remove(0, mLog.Text.IndexOf('\r', 3000) + 2);
                                    builder.Append(line);
                                    mLog.ResetText();
                                    // using AppendText since that makes sure the TextBox stays 
                                    // scrolled at the bottom 
                                    mLog.AppendText(builder.ToString());
                                }
                                else
                                    mLog.AppendText(line);
                            }));

                        }
                    }
                    // nap for a while, don't need the events on the millisecond.  
                    Thread.Sleep(500);
                }
            }
            catch { }
        }  
        #endregion
        
    }
}