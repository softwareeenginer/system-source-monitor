using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperatingSystemProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //RAM bilgilerini txt_ram textboxuna yazdırıyoruz.
        private void btn_ram_Click(object sender, EventArgs e)
        {
            //Bilgileri textboxtta üst üste yazdırmamak için her tıkta textbox içeriğini temizliyoruz. 
            txt_ram.Clear();
            try
            {                
                ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_PhysicalMemory");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    txt_ram.Text += string.Format("Manufacturer: {0}\r\n", queryObj["Manufacturer"]);
                    txt_ram.Text += string.Format("Capacity: {0} ", queryObj["Capacity"]);
                    txt_ram.Text += string.Format("Speed: {0} MHz ", queryObj["Speed"]);
                    txt_ram.Text += string.Format("TotalWidth: {0}\r\n", queryObj["TotalWidth"]);
                }
            }
            catch (ManagementException ex)
            {
                MessageBox.Show("An error occurred while querying for WMI data: " + ex.Message);
            }
            btn_ram.FlatStyle = FlatStyle.Flat;
        }

        //İşlemci bilgilerini txt_cpu textboxuna yazdırıyoruz.
        private void btn_cpu_Click(object sender, EventArgs e)
        {
            //Bilgileri textboxtta üst üste yazdırmamak için her tıkta textbox içeriğini temizliyoruz. 
            txt_cpu.Clear();
            try
            {
                ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_Processor");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    txt_cpu.Text += string.Format("Name: {0} \r\n", queryObj["Name"]);
                    txt_cpu.Text += string.Format("AddressWidth: {0} Bit" + Environment.NewLine, queryObj["AddressWidth"]);
                }
            }
            catch (ManagementException ex)
            {
                MessageBox.Show("An error occurred while querying for WMI data: " + ex.Message);
            }
        }           

        //HDD bilgilerini txt_hdd textboxuna yazdırıyoruz.
        private void btn_hdd_Click(object sender, EventArgs e)
        {
            //Bilgileri textboxtta üst üste yazdırmamak için her tıkta textbox içeriğini temizliyoruz. 
            txt_hdd.Clear();
            try
            {
                ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_LogicalDisk");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    if (queryObj["Size"] != null)
                    {
                        txt_hdd.Text += string.Format("Name: {0} ", queryObj["Name"]);
                        txt_hdd.Text += string.Format("FileSystem: {0}\r\n", queryObj["FileSystem"]);
                        txt_hdd.Text += string.Format("FreeSpace: {0} ", queryObj["FreeSpace"]);
                        txt_hdd.Text += string.Format("Size: {0}\r\n", queryObj["Size"]);
                    }
                }
            }
            catch (ManagementException ex)
            {
                MessageBox.Show("An error occurred while querying for WMI data: " + ex.Message);
            }
        }

        //Bilgisayar bilgilerini txt_pcInfo textboxuna yazdırıyoruz.
        private void btn_pcInfo_Click(object sender, EventArgs e)
        {
            //Bilgileri textboxtta üst üste yazdırmamak için her tıkta textbox içeriğini temizliyoruz. 
            txt_pcInfo.Clear();
            try
            {
                ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_ComputerSystem");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    txt_pcInfo.Text += string.Format("Model: {0}\r\n", queryObj["Model"]);
                    txt_pcInfo.Text += string.Format("Name : {0}\r\n", queryObj["Name"]);
                    txt_pcInfo.Text += string.Format("TotalPhysicalMemory: {0}", queryObj["TotalPhysicalMemory"]);
                }
            }
            catch (ManagementException ex)
            {
                MessageBox.Show("An error occurred while querying for WMI data: " + ex.Message);               
            }
        }

        private void btn_systemResource_Click(object sender, EventArgs e)
        {
            system_resource system_Resource = new system_resource();
            system_Resource.Show();
        }        
    }
}