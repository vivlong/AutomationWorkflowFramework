﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.IO;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;

namespace AWF.Classes
{
    public static class Modfunction
    {
        //[DllImport("shell32.dll", EntryPoint = "ShellExecuteA")]
        //public static extern int ShellExecute(int hwnd, String lpOperation, String lpFile, String lpParameters, String lpDirectory, int nShowCmd);
        
        [DllImport("user32.dll", EntryPoint = "FindWindow", CharSet = CharSet.Auto)]
        private extern static IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int PostMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);
        public const int WM_CLOSE = 0x10;

        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        
        public static string baseDPath = "";
        public static string currentIP = "";
        public static DateTime datetime_today;
        //
        public static string computer_name = "";
        public static string system_type = "";
        public static string hd_id = "";
        //Win32_Processor
        public static string cpu_Version = "";
        public static string cpu_AddressWidth = "";
        public static string cpu_Name = "";
        public static string cpu_Manufacturer = "";
        public static string cpu_ProcessorId = "";
        public static string cpu_ProcessorType = "";
        public static string cpu_MaxClockSpeed = "";
        public static string cpu_CurrentClockSpeed = "";
        public static string cpu_Description = "";
        public static string cpu_Family = "";
        public static string cpu_L2CacheSize = "";
        public static string cpu_L2CacheSpeed = "";
        public static string cpu_L3CacheSize = "";
        public static string cpu_L3CacheSpeed = "";
        public static string cpu_NumberOfCores = "";
        public static string cpu_NumberOfLogicalProcessors = "";
        //Win32_BaseBoard
        public static string basebord_Name = "";
        public static string basebord_Manufacturer = "";
        public static string basebord_Product = "";
        public static string basebord_SerialNumber = "";
        public static string basebord_Version = "";
        //Win32_PhysicalMemory
        public static string PhysicalMemory_Capacity = "";
        public static string PhysicalMemory_Description = "";
        public static string PhysicalMemory_DataWidth = "";
        public static string PhysicalMemory_FormFactor = "";
        public static string PhysicalMemory_Manufacturer = "";
        public static string PhysicalMemory_MemoryType = "";
        public static string PhysicalMemory_PartNumber = "";
        public static string PhysicalMemory_SerialNumber = "";
        public static string PhysicalMemory_Speed = "";
        public static string PhysicalMemory_TotalWidth = "";
        public static string PhysicalMemory_TypeDetail = "";
        public static long PhysicalMemory_Capacity_Total = 0;
        //Win32_BIOS
        public static string BIOS_BIOSVersion = "";
        public static string BIOS_Caption = "";
        public static string BIOS_Description = "";
        public static string BIOS_Manufacturer = "";
        public static string BIOS_Name = "";
        public static string BIOS_ReleaseDate = "";
        public static string BIOS_SerialNumber = "";
        public static string BIOS_SMBIOSBIOSVersion = "";
        public static string BIOS_SoftwareElementID = "";
        public static string BIOS_TargetOperatingSystem = "";
        public static string BIOS_Version = "";

        public static string CSHORT_DATE_PATTERN = "dd-MM-yy";
        public static string CLONG_DATE_PATTERN = "dd-MMM-yy";
        public static string CSHORT_LDATE_PATTERN = "dd-MM-yyyy";
        public static string CSHORT_LDATE_PATTERNMask = "00-00-0000";
        public static string CSHORT_DATETIME_PATTERNMask = "00-00-0000 00:00";
        public static string CLONG_LDATE_PATTERN = "dd-MMM-yyyy";
        public static string CLONG_LDATETIMESS_PATTERN = "dd-MMM-yyyy HH:mm:ss";
        public static string CUSEDATABASE_LDATE_PATTERN = "yyyy-MM-dd";
        public static string CUSEDATABASE_DATETIME_PATTERN = "yyyy-MM-dd HH:mm";
        public static string CUSEDATABASE_DATETIMESS_PATTERN = "yyyy-MM-dd HH:mm:ss";
        public static string CSHORT_DATETIME_PATTERN = "dd-MM-yy HH:mm";
        public static string CLONG_DATETIME_PATTERN = "dd-MMM-yy HH:mm";
        public static string CLONG_DATETIMESS_PATTERN = "dd-MMM-yy HH:mm:ss";
        public static string CSHORT_LDATETIME_PATTERN = "dd-MM-yyyy HH:mm";
        public static string CLONG_LDATETIME_PATTERN = "dd-MMM-yyyy HH:mm";
        public static string CSHORT_TIME_PATTERN = "HH:mm";
        public static string CLONG_TIME_PATTERN = "HH:mm";
        public static string CNULL_DATE_PATTERN = "dd/MM/yyyy";
        public static string CNULL_SHORTDATE_PATTERN = "dd/MM/yy";
        public static string CNULL_DATE = "31/12/1899";
        public static string CNULL_DATE1 = "31-12-1899";
        public static string CBLANK_TIME = "  :  ";
        public static string CBLANK_DATE = "  -  -";
        public static string CMONTH_FORMAT = "0000/00";
        public static string CBLANK_MONTH = "    /  ";
        public static string CSHORT_DATE_FORMAT = "##-##-##";
        public static string CLONG_DATE_FORMAT = "00->L<LL-00";
        public static string CSHORT_DATETIME_FORMAT = "00-00-00 00:00";
        public static string CLONG_DATETIME_FORMAT = "00->L<LL-00 00:00";
        public static object CheckNull(object varResult)
        {
            object CheckNull =  "";                                                     											
            if(varResult == null)
            {
                CheckNull = "";
            }
            else
            {
                CheckNull = varResult.ToString();
            }
            return CheckNull;
        }

        public static object CheckNull(object varResult, short DataType)
        {
            //DataType 0 = String                                                                           												
            //DataType 1 = Numeric                                                                           												
            //DataType 2 = Datetime
            if(DataType==2){
                if(System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern.IndexOf("MM")<= 0){
                    string[] str = System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern.Split('/');
                    if(str.Length == 3){
                         for(Int16 intI = 0; intI<=str.Length - 1;intI++){
                            if(str[intI].IndexOf("M") > 0){                                
                                str[intI] = "12";
                            }
                            else if(str[intI].IndexOf("d") > 0){
                                str[intI] = "31";
                            }
                            else if(str[intI].IndexOf("y") > 0){
                                str[intI] = "1899";
                            }
                         }
                        CNULL_DATE = str[0] + "/" + str[1] + "/" + str[2];
                        CNULL_DATE1 = str[0] + "-" + str[1] + "-" + str[2];
                    }
                }
            }
            object CheckNull = null;     
            int outResult;      
            DateTime outDtResult;                                    											
            if(varResult == null)
            {
                switch (DataType) {
                    case 1:
                        CheckNull = 0;
                        break;
                    case 2:
                        CheckNull = Convert.ToDateTime(CNULL_DATE);
                        break;
                    case 0:
                        CheckNull = "";
                        break;
                    default:                                                                  												
                        switch(varResult.GetType().Name){
                            case "String":
                            case "Char":
                                CheckNull = "";
                                break;
                            case "Int16":
                            case "Int32":
                            case "Int64":
                            case "Decimal":
                            case "Double":
                            case "Single":
                                CheckNull = 0;
                                break;
                            case "Datetime":
                                CheckNull = Convert.ToDateTime(CNULL_DATE);
                                break;
                            default: 
                                CheckNull = "";
                                break;
                        }
                        break;
                }
            }
            else
            {
                switch (DataType){
                    case 1:
                        int I;
                        if(int.TryParse(varResult.ToString(),out outResult)){
                            if(varResult.GetType().Name == "String" || varResult.GetType().Name == "Char") {
                                CheckNull = varResult.ToString();
                            }
                            else{
                                CheckNull = varResult;
                            }
                        }
                        else{
                            CheckNull = 0;
                        }
                        break;
                    case 2:
                        if(varResult.GetType().Name == "String"){
                            varResult = varResult.ToString().Replace("  :", "");
                        }
                        if (DateTime.TryParse(varResult.ToString(), out outDtResult))
                        {
                            if(varResult.GetType().Name == "String"){
                                CheckNull = Convert.ToDateTime(varResult);
                            }
                            else{
                                CheckNull = varResult;
                            }
                        }
                        else{
                            CheckNull = Convert.ToDateTime(CNULL_DATE);
                        }
                        break;
                    case 0:
                        CheckNull = varResult.ToString();
                        break;
                    default:                                                                          												
                        switch(varResult.GetType().Name){
                            case "String":
                            case "Char":
                                CheckNull = varResult;
                                break;
                            case "Int16":
                            case "Int32":
                            case "Int64":
                            case "Decimal":
                            case "Double":
                            case "Single":
                                if(int.TryParse(varResult.ToString(),out outResult)){
                                    CheckNull = varResult;
                                }
                                else{
                                    CheckNull = 0;
                                }
                                break;
                            case "Datetime":
                                string strDate = varResult.ToString();
                                strDate = strDate.Replace("  :", "00:00");
                                if(DateTime.TryParse(strDate,out outDtResult)){
                                    CheckNull = strDate;
                                }
                                else{
                                    CheckNull =  Convert.ToDateTime(CNULL_DATE);
                                }
                                break;
                            default:
                                CheckNull = "";
                                break;
                        }
                        break;
                }
            }
            return CheckNull;
        }

        public static void KillMessageBox(string strWindowName)
        {
            IntPtr ptr = FindWindow(null, strWindowName);
            if (ptr != IntPtr.Zero)
            {
                PostMessage(ptr, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
            }
        }

        public static void DeleteFilesAndFolders(string strTargetPath)
        {
            try
            {
                if (strTargetPath[strTargetPath.Length - 1] != Path.DirectorySeparatorChar)
                {
                    strTargetPath += Path.DirectorySeparatorChar;
                }
                string[] filelist = Directory.GetFileSystemEntries(strTargetPath);
                foreach (string file in filelist)
                {
                    if (Directory.Exists(file))
                    {
                        DeleteFilesAndFolders(strTargetPath + Path.GetFileName(file));
                    }
                    else
                    {
                        File.Delete(strTargetPath + Path.GetFileName(file));
                    }
                }
                Directory.Delete(strTargetPath, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public static void copyFilesAndFolders(string update_publish_path, string filepath)
        {
            string[] files = Directory.GetFiles(filepath);
            foreach (string file in files)
            {
                string name = Path.GetFileName(file);
                string dest = Path.Combine(update_publish_path, name);
                File.Move(file, dest);
            }
            string[] folders = Directory.GetDirectories(filepath);
            foreach (string folder in folders)
            {
                string n = folder.Substring(folder.LastIndexOf("\\") + 1);
                if (n != "crystalreports" && n != "mdac28" && n != "dotnetfx" && n != "sysfreightupdate")
                {
                    Directory.Move(folder, update_publish_path + "\\" + n);
                }
            }
        }

        public static void Get_Win32_Processor()
        {
            try
            {
                ManagementClass mc = new ManagementClass("Win32_Processor");
                ManagementObjectCollection moc = mc.GetInstances();
                foreach (ManagementObject mo in moc)
                {
                    cpu_Version = Modfunction.CheckNull(mo.Properties["Version"].Value).ToString();
                    cpu_AddressWidth = Modfunction.CheckNull(mo.Properties["AddressWidth"].Value).ToString();
                    cpu_Name = Modfunction.CheckNull(mo.Properties["Name"].Value).ToString();// Intel(R) Core(TM) i5-3210M CPU @ 2.50GHz
                    cpu_Manufacturer = Modfunction.CheckNull(mo.Properties["Manufacturer"].Value).ToString(); // GenuineIntel
                    cpu_ProcessorId = Modfunction.CheckNull(mo.Properties["ProcessorId"].Value).ToString(); // BFEBFBFF000306A9
                    cpu_ProcessorType = Modfunction.CheckNull(mo.Properties["ProcessorType"].Value).ToString(); // Central Processor
                    cpu_MaxClockSpeed = Modfunction.CheckNull(mo.Properties["MaxClockSpeed"].Value).ToString(); // 2501 MegaHertz
                    cpu_CurrentClockSpeed = Modfunction.CheckNull(mo.Properties["CurrentClockSpeed"].Value).ToString();// 2501 MegaHertz
                    cpu_Description = Modfunction.CheckNull(mo.Properties["Description"].Value).ToString();// Intel64 Family 6 Model 58 Stepping 9
                    cpu_Family = Modfunction.CheckNull(mo.Properties["Family"].Value).ToString();// 198
                    cpu_L2CacheSize = Modfunction.CheckNull(mo.Properties["L2CacheSize"].Value).ToString();// 256 Kilobytes
                    cpu_L2CacheSpeed = Modfunction.CheckNull(mo.Properties["L2CacheSpeed"].Value).ToString();//null MegaHertz
                    cpu_L3CacheSize = Modfunction.CheckNull(mo.Properties["L3CacheSize"].Value).ToString();// 3072 Kilobytes (Windows Server 2003 and Windows XP:  This property is not available.)
                    cpu_L3CacheSpeed = Modfunction.CheckNull(mo.Properties["L3CacheSpeed"].Value).ToString();//null MegaHertz (Windows Server 2003 and Windows XP:  This property is not available.)
                    cpu_NumberOfCores = Modfunction.CheckNull(mo.Properties["NumberOfCores"].Value).ToString();// 2
                    cpu_NumberOfLogicalProcessors = Modfunction.CheckNull(mo.Properties["NumberOfLogicalProcessors"].Value).ToString();// 4

                }
            }
            catch (Exception ex)
            {
                Log.Debug(ex.Message.ToString(), ex);
            }
            finally { }
        }

        public static void Get_Win32_BaseBoard()
        {
            try
            {
                using (ManagementClass mc = new ManagementClass("Win32_BaseBoard"))
                {
                    ManagementObjectCollection moc = mc.GetInstances();
                    foreach (ManagementObject mo in moc)
                    {
                        basebord_Name = Modfunction.CheckNull(mo.Properties["Name"].Value).ToString();// "Base Board"
                        basebord_Manufacturer = Modfunction.CheckNull(mo.Properties["Manufacturer"].Value).ToString(); // "Acer"
                        basebord_Product = Modfunction.CheckNull(mo.Properties["Product"].Value).ToString(); // "VA50_HC_CR"
                        basebord_SerialNumber = Modfunction.CheckNull(mo.Properties["SerialNumber"].Value).ToString(); // "NBY111100122826DFA3400"
                        basebord_Version = Modfunction.CheckNull(mo.Properties["Version"].Value).ToString(); // "Type2 - Board Version"
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Debug(ex.Message.ToString(), ex);
            }
            finally { }
        }

        public static void Get_Win32_PhysicalMemory()
        {
            try
            {
                ManagementClass mc = new ManagementClass("Win32_PhysicalMemory");
                ManagementObjectCollection moc = mc.GetInstances();
                foreach (ManagementObject mo in moc)
                {
                    PhysicalMemory_Capacity = Modfunction.CheckNull(mo.Properties["Capacity"].Value).ToString();// 4294967296 Kilobytes
                    PhysicalMemory_Description = Modfunction.CheckNull(mo.Properties["Description"].Value).ToString(); // "Physical Memory"
                    PhysicalMemory_DataWidth = Modfunction.CheckNull(mo.Properties["DataWidth"].Value).ToString(); // 64
                    PhysicalMemory_FormFactor = Modfunction.CheckNull(mo.Properties["FormFactor"].Value).ToString(); // 8 - DIMM
                    PhysicalMemory_Manufacturer = Modfunction.CheckNull(mo.Properties["Manufacturer"].Value).ToString(); // "Kingston"
                    PhysicalMemory_MemoryType = Modfunction.CheckNull(mo.Properties["MemoryType"].Value).ToString(); // 0 - Unknown
                    PhysicalMemory_PartNumber = Modfunction.CheckNull(mo.Properties["PartNumber"].Value).ToString(); // "9905428-073.A00LF "
                    PhysicalMemory_SerialNumber = Modfunction.CheckNull(mo.Properties["SerialNumber"].Value).ToString(); // "CD04E88A"
                    PhysicalMemory_Speed = Modfunction.CheckNull(mo.Properties["Speed"].Value).ToString(); // 666 - nanoseconds
                    PhysicalMemory_TotalWidth = Modfunction.CheckNull(mo.Properties["TotalWidth"].Value).ToString(); // 64
                    PhysicalMemory_TypeDetail = Modfunction.CheckNull(mo.Properties["TypeDetail"].Value).ToString(); // 128 - Synchronous
                    PhysicalMemory_Capacity_Total += long.Parse(PhysicalMemory_Capacity, System.Globalization.NumberFormatInfo.InvariantInfo);
                }
            }
            catch (Exception ex)
            {
                Log.Debug(ex.Message.ToString(), ex);
            }
            finally { }
        }

        public static void Get_Win32_BIOS()
        {
            try
            {
                using (ManagementClass mc = new ManagementClass("Win32_BIOS"))
                {
                    ManagementObjectCollection moc = mc.GetInstances();
                    foreach (ManagementObject mo in moc)
                    {
                        BIOS_BIOSVersion = Modfunction.CheckNull(mo.Properties["BIOSVersion"].Value).ToString();// "InsydeH2O Version 03.71.48V1.07" Array
                        BIOS_Caption = Modfunction.CheckNull(mo.Properties["Caption"].Value).ToString(); // "InsydeH2O Version 03.71.48V1.07"
                        BIOS_Description = Modfunction.CheckNull(mo.Properties["Description"].Value).ToString(); // "InsydeH2O Version 03.71.48V1.07"
                        BIOS_Manufacturer = Modfunction.CheckNull(mo.Properties["Manufacturer"].Value).ToString(); // "Acer"
                        BIOS_Name = Modfunction.CheckNull(mo.Properties["Name"].Value).ToString(); // "InsydeH2O Version 03.71.48V1.07"
                        BIOS_ReleaseDate = Modfunction.CheckNull(mo.Properties["ReleaseDate"].Value).ToString(); // "20120511000000.000000+000"
                        BIOS_SerialNumber = Modfunction.CheckNull(mo.Properties["SerialNumber"].Value).ToString(); // "NXRZGSG00222809DEA3400"
                        BIOS_SMBIOSBIOSVersion = Modfunction.CheckNull(mo.Properties["SMBIOSBIOSVersion"].Value).ToString(); // "V1.07"
                        BIOS_SoftwareElementID = Modfunction.CheckNull(mo.Properties["SoftwareElementID"].Value).ToString(); // "InsydeH2O Version 03.71.48V1.07"
                        BIOS_TargetOperatingSystem = Modfunction.CheckNull(mo.Properties["TargetOperatingSystem"].Value).ToString(); // 0 - Unknown
                        BIOS_Version = Modfunction.CheckNull(mo.Properties["Version"].Value).ToString(); // "ACRSYS - 1"
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Debug(ex.Message.ToString(), ex);
            }
            finally { }
        }

        public static bool Get_IP_Address()
        {
            try
            {
                string machineName = Environment.MachineName;
                string hostName = Dns.GetHostName();
                IPHostEntry hostEntry = Dns.GetHostEntry(hostName);
                IPAddress[] addressList = hostEntry.AddressList;
                if (addressList.Length > 0)
                {
                    for (int i = 0; i <= (addressList.Length - 1); i++)
                    {
                        if (addressList[i].AddressFamily.ToString() == "InterNetwork" && addressList[i].ToString().IndexOf("192")==0)
                        {
                            currentIP = addressList[i].ToString();
                            if (currentIP == "192.168.0.236")
                            {
                                baseDPath = @"D:\";
                            }
                            else if (currentIP != "192.168.0.236" && currentIP != "0.0.0.0")
                            {
                                baseDPath = @"\\192.168.0.236\d\";
                            }
                            return true;
                        }
                    }
                    return false;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex) { throw ex; }
        }

        public static void Get_UTC_Datetime()
        {
            //string[,] timeserver = new string[14, 2];
            //int[] sort = new int[] { 3, 2, 4, 8, 9, 6, 11, 5, 10, 0, 1, 7, 12 };
            //timeserver[0, 0] = "time-a.nist.gov";
            //timeserver[0, 1] = "129.6.15.28";
            //timeserver[1, 0] = "time-b.nist.gov";
            //timeserver[1, 1] = "129.6.15.29";
            //timeserver[2, 0] = "time-a.timefreq.bldrdoc.gov";
            //timeserver[2, 1] = "132.163.4.101";
            //timeserver[3, 0] = "www.time.ac.cn";
            //timeserver[3, 1] = "www.time.ac.cn";
            //timeserver[4, 0] = "time-c.timefreq.bldrdoc.gov";
            //timeserver[4, 1] = "132.163.4.103";
            //timeserver[5, 0] = "utcnist.colorado.edu";
            //timeserver[5, 1] = "128.138.140.44";
            //timeserver[6, 0] = "time.nist.gov";
            //timeserver[6, 1] = "192.43.244.18";
            //timeserver[7, 0] = "time-nw.nist.gov";
            //timeserver[7, 1] = "131.107.1.10";
            //timeserver[8, 0] = "nist1.symmetricom.com";
            //timeserver[8, 1] = "69.25.96.13";
            //timeserver[9, 0] = "nist1-dc.glassey.com";
            //timeserver[9, 1] = "216.200.93.8";
            //timeserver[10, 0] = "nist1-ny.glassey.com";
            //timeserver[10, 1] = "208.184.49.9";
            //timeserver[11, 0] = "nist1-sj.glassey.com";
            //timeserver[11, 1] = "207.126.98.204";
            //timeserver[12, 0] = "nist1.aol-ca.truetime.com";
            //timeserver[12, 1] = "207.200.81.113";
            //timeserver[13, 0] = "nist1.aol-va.truetime.com";
            //timeserver[13, 1] = "64.236.96.53";
            //int portNum = 13;
            //string hostName;
            //byte[] bytes = new byte[1024];
            //int bytesRead = 0;
            //TcpClient client = new TcpClient();
            //int i = 0;
            //for (i = 0; i < 13; i++)
            //{
            //    hostName = timeserver[sort[i], 1];
            //    try
            //    {
            //        client.Connect(hostName, portNum);
            //        NetworkStream ns = client.GetStream();
            //        bytesRead = ns.Read(bytes, 0, bytes.Length);
            //        client.Close();
            //        break;
            //    }
            //    catch (System.Exception ex)
            //    {
            //        throw ex;
            //    }
            //}
            //char[] sp = new char[1];
            //sp[0] = ' ';
            //System.DateTime dt = new DateTime();
            //string str1 = System.Text.Encoding.ASCII.GetString(bytes, 0, bytesRead);
            //string[] s = str1.Split(sp);
            //dt = System.DateTime.Parse(s[1] + " " + s[2]);
            //dt = dt.AddHours(8);
            //datetime_today = dt;
            datetime_today = DateTime.Now;
            if (datetime_today.Year != 2015)
                datetime_today = datetime_today.AddYears(1);
        }

        public static bool pingIPAddress(string strIP)
        {
            bool blnPing = false;
            Ping pingSender = new Ping();
            PingReply reply = pingSender.Send(strIP, 60);
            if (reply.Status == IPStatus.Success)
            {
                blnPing = true;
            }
            return blnPing;
        }

    }
}
