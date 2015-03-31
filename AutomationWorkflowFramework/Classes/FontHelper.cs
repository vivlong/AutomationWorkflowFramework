using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace DeveloperTools.Classes
{
    class FontHelper
    {
        public static Font SetFormFontByUsingMemoryFont()
        {
            PrivateFontCollection p_Font = new PrivateFontCollection();
            byte[] b_Font = new byte[DeveloperTools.Properties.Resources.DroidSans.Length];
            IntPtr MeAdd = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(byte)) * b_Font.Length);
            Marshal.Copy(DeveloperTools.Properties.Resources.DroidSans, 0, MeAdd, DeveloperTools.Properties.Resources.DroidSans.Length);
            p_Font.AddMemoryFont(MeAdd, b_Font.Length);
            return new Font(p_Font.Families[0], 10, FontStyle.Regular);
        }
    }
}
