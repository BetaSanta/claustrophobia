using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.IO;

namespace claustrophobia
{
    static class LoadFonts
    {
        static public PrivateFontCollection font = new PrivateFontCollection();

        /// <summary>
        /// Загрузка шрифтов
        /// </summary>
        public static void LoadFont()
        {
            using (MemoryStream fontStream = new MemoryStream(Properties.Resources.london))
            {
                // create an unsafe memory block for the font data
                System.IntPtr data = Marshal.AllocCoTaskMem((int)fontStream.Length);
                // create a buffer to read in to
                byte[] fontdata = new byte[fontStream.Length];
                // read the font data from the resource
                fontStream.Read(fontdata, 0, (int)fontStream.Length);
                // copy the bytes to the unsafe memory block
                Marshal.Copy(fontdata, 0, data, (int)fontStream.Length);
                // pass the font to the font collection
                font.AddMemoryFont(data, (int)fontStream.Length);
                // close the resource stream
                fontStream.Close();
                // free the unsafe memory
                Marshal.FreeCoTaskMem(data);
            }
        }

        /// <summary>
        /// применение шрифтов к компонентам формы
        /// </summary>
        public static void loadFontsForForm(Label label, int size)
        {
            label.Font = new Font(font.Families[0], size);
            label.UseCompatibleTextRendering = true;
        }
    }
}
