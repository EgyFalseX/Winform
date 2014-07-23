using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DatabaseImageEditor
{
    static class Program
    {
        public static string FilesPath = Application.StartupPath + "\\Files\\";
        public static readonly string DBPath = Application.StartupPath + "\\DBPath";
        public static string SqlConStr = string.Empty;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            LoadSqlDBPath();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static bool LoadSqlDBPath()
        {
            try
            {
                if (!File.Exists(DBPath))// Check If DBPass is Exists
                {
                    return false;
                }
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                string[] ConfigArr = Bytes2String(File.ReadAllBytes(DBPath)).Split(Convert.ToChar("|"));
                SqlConStr = ConfigArr[0];
                return true;
            }
            catch
            {
                if (File.Exists(DBPath))
                    File.Delete(DBPath);
                return false;
            }
        }
        /// <summary>
        /// Converts an image into an icon.
        /// </summary>
        /// <param name="img">The image that shall become an icon</param>
        /// <param name="size">The width and height of the icon. Standard
        /// sizes are 16x16, 32x32, 48x48, 64x64.</param>
        /// <param name="keepAspectRatio">Whether the image should be squashed into a
        /// square or whether whitespace should be put around it.</param>
        /// <returns>An icon!!</returns>
        public static System.Drawing.Icon MakeIcon(System.Drawing.Image img, int size, bool keepAspectRatio)
        {
            System.Drawing.Bitmap square = new System.Drawing.Bitmap(size, size); // create new bitmap
            System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(square); // allow drawing to it

            int x, y, w, h; // dimensions for new image

            if (!keepAspectRatio || img.Height == img.Width)
            {
                // just fill the square
                x = y = 0; // set x and y to 0
                w = h = size; // set width and height to size
            }
            else
            {
                // work out the aspect ratio
                float r = (float)img.Width / (float)img.Height;

                // set dimensions accordingly to fit inside size^2 square
                if (r > 1)
                { // w is bigger, so divide h by r
                    w = size;
                    h = (int)((float)size / r);
                    x = 0; y = (size - h) / 2; // center the image
                }
                else
                { // h is bigger, so multiply w by r
                    w = (int)((float)size * r);
                    h = size;
                    y = 0; x = (size - w) / 2; // center the image
                }
            }

            // make the image shrink nicely by using HighQualityBicubic mode
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            g.DrawImage(img, x, y, w, h); // draw image with specified dimensions
            g.Flush(); // make sure all drawing operations complete before we get the icon

            // following line would work directly on any image, but then
            // it wouldn't look as nice.
            return System.Drawing.Icon.FromHandle(square.GetHicon());
        }
        public static byte[] Strin2Bytes(string Text)
        {
            string hex = string.Empty;
            foreach (char c in Text)
            {
                int tmp = c;
                hex += String.Format("{0:x2}", (uint)Convert.ToUInt32(tmp.ToString()));
            }

            return Encoding.Default.GetBytes(hex);
            //return Encoding.Default.GetBytes(Text);
        }
        public static string Bytes2String(byte[] Bytez)
        {
            string ConvThis = System.Text.Encoding.ASCII.GetString(Bytez);
            byte[] raw = new byte[ConvThis.Length / 2];
            for (int i = 0; i < raw.Length; i++)
            {
                raw[i] = Convert.ToByte(ConvThis.Substring(i * 2, 2), 16);
            }
            return System.Text.Encoding.ASCII.GetString(raw);
        }
        public static bool IsNullOrEmpty(object obj)
        {
            if (obj == null)
                return true;

            if (obj.ToString() == string.Empty)
                return true;
            else
                return false;
        }
    }
}
