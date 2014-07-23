using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System;
using FunctionLib;

namespace DataCenter_Server
{
	public partial class StartUpFrm
	{
		public StartUpFrm()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
		#region Default Instance
		
		private static StartUpFrm defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static StartUpFrm Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new StartUpFrm();
					defaultInstance.FormClosed += new FormClosedEventHandler(defaultInstance_FormClosed);
				}
				
				return defaultInstance;
			}
		}
		
		static void defaultInstance_FormClosed(object sender, FormClosedEventArgs e)
		{
			defaultInstance = null;
		}
		
		#endregion
		public void StartUpFrm_Load(System.Object sender, System.EventArgs e)
		{
			this.Visible = false;
			this.Hide();
            MainModule.Main();
		}
	}
	
}
