﻿using System;
using System.Collections.Generic;

using System.Text;
using System.Windows.Forms;
using System.Drawing;


namespace CenterBotControl
{
    class Log
    {

        public enum LogType
        {
            Info,
            Error,
            Stander,
            Debug
        }
        public enum LogLevel : int
        {
            Stander = 0,
            Debug = 1
        }
        public struct LogItem
        {
            public LogType LogType;
            public LogLevel LogLvl;
            public string LogText;
        }
        public struct LogProvider
        {
            public RichTextBox LogControl;
            public LogLevel LogLvl;
        }
        public List<LogProvider> OutPutUI = new List<LogProvider>();
        public List<LogItem> Logs = new List<LogItem>();
        public Color InfoColor = Color.Green;
        public Color ErrorColor = Color.Red;
        public Color StanderColor = Color.Gray;
        public Color DebugColor = Color.Blue;

        public void AddUI(RichTextBox ctl, LogLevel lvl)
        {
            OutPutUI.Add(new LogProvider() { LogControl = ctl, LogLvl = lvl });
        }
        public void RemoveUI(RichTextBox ctl, LogLevel lvl)
        {
            foreach (LogProvider item in OutPutUI)
            {
                if (item.LogControl == ctl && item.LogLvl == lvl)
                {
                    OutPutUI.Remove(item);
                    break;
                }
            }
        }
        public void AddLog(LogType typ, LogLevel lvl, string LogText)
        {
            string str = string.Format("[{0}] {1}.", DateTime.Now.ToLongTimeString(), LogText);
            Logs.Add(new LogItem() { LogType = typ, LogText = str });
            for (int i = 0; i < OutPutUI.Count; i++)
            {
                RichTextBox ctl = OutPutUI[i].LogControl;
                LogLevel ctllvl = OutPutUI[i].LogLvl;
                if (ctllvl < lvl)
                    continue;
                if (ctl.IsDisposed)
                {
                    OutPutUI.RemoveAt(i);
                    continue;
                }
                MethodInvoker action = delegate
                {
                    int length = ctl.TextLength + (str.Length - LogText.Length);  // at end of text
                    ctl.AppendText(str + Environment.NewLine);
                    ctl.SelectionStart = length - 1;
                    ctl.SelectionLength = LogText.Length;
                    switch (typ)
                    {
                        case LogType.Error:
                            ctl.SelectionColor = ErrorColor;
                            break;
                        case LogType.Info:
                            ctl.SelectionColor = InfoColor;
                            break;
                        case LogType.Debug:
                            ctl.SelectionColor = DebugColor;
                            break;
                        case LogType.Stander:
                            ctl.SelectionColor = StanderColor;
                            break;
                    }
                    ctl.SelectionLength = 0;
                    ctl.ScrollToCaret();
                };
                ctl.BeginInvoke(action);
                
            }
        }

    }
}
