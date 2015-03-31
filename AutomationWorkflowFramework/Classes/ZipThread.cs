using System;
using System.Collections.Generic;
using System.Text;

namespace DeveloperTools.Classes
{
    class ZipThread : ThreadHelper
    {
        private string FoldeName;
        private string ZipName;
        public ZipThread(string FoldeName, string ZipName)  
        {
            this.FoldeName = FoldeName;
            this.ZipName = ZipName;  
        }

        override public void run()  
        {
            ZipHelper.ZipFileDirectory(FoldeName, ZipName); 
        } 
    }
}
