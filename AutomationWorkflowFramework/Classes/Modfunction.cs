using System;
using System.Collections.Generic;
using System.Text;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace DeveloperTools.Classes
{
    class Modfunction
    {
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

        #region  判断一个窗体是否存在，不存在就显示，存在则不显示
        public static bool CheckForm(string FormName)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == FormName)
                {
                    if (form.WindowState == FormWindowState.Minimized)
                    {
                        form.WindowState = FormWindowState.Maximized;
                    }
                    form.Activate();
                    return true;
                }
            }
            return false;
        }
        #endregion

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
    }
}
