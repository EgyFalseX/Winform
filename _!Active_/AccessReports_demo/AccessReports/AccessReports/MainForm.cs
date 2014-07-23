using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MsAccess = Microsoft.Office.Interop.Access;

namespace AccessReports {
	/// <summary>
	/// This is the main user interface for the application.
	/// </summary>
	/// <revisionHistory>
	/// 20071212	mcarey		file created
	/// </revisionHistory>
	/// <copyright>
	/// Copyright (c) 2007 Michael Carey.  All rights reserved.
	/// </copyright>
	public partial class MainForm : Form {
        public MainForm() {
			InitializeComponent();

			Text = Application.ProductName;
		}
		#region Form Events
		private void buttonBrowse_Click(object sender, EventArgs e) {
			CmdBrowse();
		}
        private void BtnView_Click(object sender, EventArgs e)
        {
            CmdView();
        }
		private void buttonPrint_Click(object sender, EventArgs e) {
			CmdPrint();
		}
		private void buttonSave_Click(object sender, EventArgs e) {
			CmdSave();
		}
		private void buttonExit_Click(object sender, EventArgs e) {
			CmdExit();
		}
		private void listBoxReports_SelectedIndexChanged(object sender, EventArgs e) {
			ActionEnableCheck();
		}
		private void textBoxAccess_TextChanged(object sender, EventArgs e) {
			ActionEnableCheck();
		}
		#endregion Form Events
		#region Actions
		/// <summary>
		/// Checks to see if the Print and Save buttons should be enabled.
		/// </summary>
		private void ActionEnableCheck() {
			string fileName = textBoxAccess.Text.Trim();
			string report = "";

			if (listBoxReports.SelectedItems.Count > 0 && fileName.Length > 0) {
				if (System.IO.File.Exists(fileName)) {
                    BtnView.Enabled = true;
                    buttonPrint.Enabled = true;
					buttonSave.Enabled = true;
					return;
				}
			}
            BtnView.Enabled = false;
			buttonPrint.Enabled = false;
			buttonSave.Enabled = false;
		}
		#endregion Actions
		#region Commands
		/// <summary>
		/// Browses for the access database file.
		/// </summary>
		private void CmdBrowse() {
			string fileName = textBoxAccess.Text.Trim();
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.Filter = "Microsoft Access (*.mdb)|*.mdb";
			if (fileName.Length > 0) {
				dlg.FileName = fileName;
			}
			if (dlg.ShowDialog() == DialogResult.Cancel) {
				return;
			}
			textBoxAccess.Text = dlg.FileName;
			// we have a valid file name so we now need to
			// populate the list box with available reports
			listBoxReports.Items.Clear();
            
			// create an application object.
			MsAccess.Application app = new MsAccess.Application();
			// open the access database file.
			app.OpenCurrentDatabase(dlg.FileName, false, "");
			string sql = "SELECT [Name] FROM MSysObjects WHERE Type = -32764";
            DAO.Database db = (DAO.Database)app.CurrentDb();
			// query the database for all the reports.  all this data is
			// contained in the MSysObejcts table which is invisible through
			// the table listing in access.
            DAO.Recordset rs = db.OpenRecordset(sql, Type.Missing, Type.Missing, Type.Missing);
			// go through and add all the reports to the list box.
			while (!rs.EOF) {
				listBoxReports.Items.Add(rs.Fields[0].Value);
				rs.MoveNext();
			}

			// clean up
			rs.Close();
			rs = null;
			db.Close();
			db = null;
			app.CloseCurrentDatabase();
			app = null;
		}
		/// <summary>
		/// Exits the application.
		/// </summary>
		private void CmdExit() {
			Close();
			Application.Exit();
		}
		/// <summary>
		/// Prints the selected report
		/// </summary>
		private void CmdPrint() {
			string report = listBoxReports.SelectedItem.ToString();

			Cursor = Cursors.WaitCursor;

			// create an application object.
			MsAccess.Application app = new MsAccess.Application();
			// open the access database file.
			app.OpenCurrentDatabase(textBoxAccess.Text.Trim(), false, "");
			app.Visible = false;
			// open the report
			app.DoCmd.OpenReport(report, Microsoft.Office.Interop.Access.AcView.acViewPreview, Type.Missing, Type.Missing, MsAccess.AcWindowMode.acWindowNormal, Type.Missing);
			// print the report to the default printer.
			app.DoCmd.PrintOut(MsAccess.AcPrintRange.acPrintAll, Type.Missing, Type.Missing, MsAccess.AcPrintQuality.acHigh, Type.Missing, Type.Missing);
			// cleanup
			app.CloseCurrentDatabase();
			app = null;
			Cursor = Cursors.Default;
		}
		/// <summary>
		/// Saves the selected report to html in the same
		/// directory as the access file.
		/// </summary>
		private void CmdSave() {
			string report = listBoxReports.SelectedItem.ToString();

			// get the file name
			string[] arr = textBoxAccess.Text.Trim().Split(new char[] { '\\' });
			string fileName = "";
			for (int i = 0; i < arr.Length - 1; i++) {
				if (fileName.Length > 0) {
					fileName += "\\";
				}
				fileName += arr[i];
			}
			fileName += "\\" + report + ".html";

			Cursor = Cursors.WaitCursor;

			// create an application object.
			MsAccess.Application app = new MsAccess.Application();
			// open the access database file.
			app.OpenCurrentDatabase(textBoxAccess.Text.Trim(), false, "");
			app.Visible = false;
			// open the report
			app.DoCmd.OpenReport(report, Microsoft.Office.Interop.Access.AcView.acViewPreview, Type.Missing, Type.Missing, MsAccess.AcWindowMode.acWindowNormal, Type.Missing);
			// export the report to an HTML file
			app.DoCmd.OutputTo(MsAccess.AcOutputObjectType.acOutputReport, report, "HTML (*.html)", fileName, Type.Missing, Type.Missing, Type.Missing);
			// cleanup
			app.CloseCurrentDatabase();
			app = null;

			Cursor = Cursors.Default;
		}
        /// <summary>
        /// View the selected report
        /// </summary>
        private void CmdView()
        {
            string report = listBoxReports.SelectedItem.ToString();
            // create an application object.
            MsAccess.Application app = new MsAccess.Application();
            // open the access database file.
            app.OpenCurrentDatabase(textBoxAccess.Text.Trim(), false, "");
            //app.Visible = false;
            app.Visible = true;
            // open the report
            app.DoCmd.OpenReport(report, Microsoft.Office.Interop.Access.AcView.acViewPreview, Type.Missing, Type.Missing, MsAccess.AcWindowMode.acWindowNormal, Type.Missing);
            // print the report to the default printer.
            return;
        }
		#endregion Commands
	}
}