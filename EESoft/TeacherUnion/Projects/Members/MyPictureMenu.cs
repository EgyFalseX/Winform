using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace Members
{
    public class MyPictureMenu : PictureMenu
    {
        public MyPictureMenu(IPictureMenu menuControl) : base(menuControl) { }
        protected override void PasteImage(Image im)
        {
            FieldInfo fi = typeof(PictureMenu).GetField("openFile", BindingFlags.Instance | BindingFlags.NonPublic);
            if (fi == null) return;
            OpenFileDialog od = fi.GetValue(this) as OpenFileDialog;
            string fileName = od.FileName;
            MyPictureEdit pe = MenuControl as MyPictureEdit;
            if (pe != null) pe.FileName = fileName;
            base.PasteImage(im);
        }
    }
}
