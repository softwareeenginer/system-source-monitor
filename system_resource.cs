using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace OperatingSystemProject
{
    public partial class system_resource : Form
    {
        private void system_resource_Load(object sender, EventArgs e)
        {

        }
        private System.Timers.Timer _timer;
        public system_resource()
        {
            InitializeComponent();
            _timer = new System.Timers.Timer();
            _timer.Interval = 3000;
            _timer.Elapsed += OntimedEvent;
            _timer.AutoReset = true;
            bool startflag = false;
        }

        private void OntimedEvent(object sender, ElapsedEventArgs e)
        {
            int cpuValue = GetCpuValue();
            int memoryValeu = GetMemValue();

            if (progressBar_cpu.InvokeRequired)
            {
                progressBar_cpu.Invoke(new Action(() => progressBar_cpu.Value = cpuValue));
            }
            else
            {
                progressBar_cpu.Value = cpuValue;
            }

            if (lbl_cpu.InvokeRequired)
            {
                lbl_cpu.Invoke(new Action(() => lbl_cpu.Text = cpuValue.ToString() + "%"));
            }
            else
            {
                lbl_cpu.Text = cpuValue.ToString() + "%";
            }


            if (progressBar_ram.InvokeRequired)
            {
                progressBar_ram.Invoke(new Action(() => progressBar_ram.Value = memoryValeu));
            }
            else
            {
                progressBar_ram.Value = memoryValeu;
            }

            if (lbl_ram.InvokeRequired)
            {
                lbl_ram.Invoke(new Action(() => lbl_ram.Text = memoryValeu.ToString() + "%"));
            }
            else
            {
                lbl_ram.Text = memoryValeu.ToString() + "%";
            }
        }
        private int GetCpuValue()
        {
            var CpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            CpuCounter.NextValue();
            System.Threading.Thread.Sleep(1000);
            int returnValue = (int)CpuCounter.NextValue();
            return returnValue; ;

        }
        // Memory değerini al
        private int GetMemValue()
        {
            var MemCounter = new PerformanceCounter("Memory", "% Committed Bytes in Use");
            int returnValue = (int)MemCounter.NextValue();
            return returnValue;
        }

        bool startflag = false;
        private void btn_startAndStop_Click(object sender, EventArgs e)
        {
            
            if (startflag == false)
            {
                startflag = true;
                _timer.Enabled = true;
                btn_startAndStop.Text = "Stop ";
            }
            else
            {
                startflag = false;
                _timer.Enabled = false;
                btn_startAndStop.Text = "Start";
            }
        }

        private void islemlerListele()
        {
            Process[] Bellek = Process.GetProcesses();

            foreach (Process islem in Bellek)
            {
                lstbox_islemler.Items.Add(islem.ProcessName);

            }
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            lstbox_islemler.Items.Clear();
            islemlerListele();
        }
    }
}
