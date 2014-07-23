using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace RetirementCenter
{
    public class MyPictureEdit : PictureEdit
    {
        PictureMenu menu;
        private string fFileName;
        public string FileName
        {
            get { return fFileName; }
            set { fFileName = value; }
        }

        public MyPictureEdit() : base() { }
        protected override PictureMenu Menu
        {
            get
            {
                if (menu == null) menu = new MyPictureMenu(this);
                return menu;
            }
        }
    }
}
