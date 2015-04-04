using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace AWF.Classes
{
    class FontHelper
    {

        private static PrivateFontCollection p_Font;
        public static Font SetFormFontByUsingMemoryFont()
        {
            p_Font = new PrivateFontCollection();
            //byte[] b_Font = AWF.Properties.Resources.DroidSans;
            //IntPtr MeAdd = Marshal.AllocHGlobal(b_Font.Length);
            //Marshal.Copy(b_Font, 0, MeAdd, b_Font.Length);
            //p_Font.AddMemoryFont(MeAdd, b_Font.Length);
            return new Font(p_Font.Families[0], 10, FontStyle.Regular);
        }
    }
}
