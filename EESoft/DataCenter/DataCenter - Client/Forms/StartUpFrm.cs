using System;
using System.Windows.Forms;

namespace DataCenter_Client
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
                    defaultInstance.FormClosed += defaultInstance_FormClosed;
				}
				
				return defaultInstance;
			}
		}
		
		static void defaultInstance_FormClosed(object sender, FormClosedEventArgs e)
		{
			defaultInstance = null;
		}
		
		#endregion
        public void StartUpFrm_Load(Object sender, EventArgs e)
        {
            try
            {
                Visible = false;
                Hide();
                MainModule.Main();
            }
            catch (Exception ex)
            {
                MainModule.MsgBox_(ex.Message, 0, 23, false, this);
                Application.Exit();
            }
        }
	}
}
