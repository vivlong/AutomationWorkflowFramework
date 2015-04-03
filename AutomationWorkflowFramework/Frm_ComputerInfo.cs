using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AWF
{
    public partial class Frm_ComputerInfo : Form
    {
        public Frm_ComputerInfo()
        {
            InitializeComponent();
        }

        private void Frm_ComputerInfo_Load(object sender, EventArgs e)
        {
            lbl_100_dis.Text = Classes.Modfunction.cpu_Name + " " + Classes.Modfunction.cpu_AddressWidth + "bit";
            lbl_110_dis.Text = Classes.Modfunction.BIOS_Name;
            lbl_120_dis.Text = (Classes.Modfunction.PhysicalMemory_Capacity_Total / (1024 * 1024 * 1024)).ToString(System.Globalization.NumberFormatInfo.InvariantInfo) + " GB";
            lbl_130_dis.Text = Classes.Modfunction.basebord_Manufacturer;
            lbl_140_dis.Text = Environment.MachineName;
        }
    }
}
