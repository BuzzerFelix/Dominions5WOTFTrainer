using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Memory;
using System.Windows.Forms;
using System.Diagnostics;

namespace Dominions5WOTFTrainer
{
    public partial class Dom5_Trainer : Form
    {
        public Mem dom5 = new Mem();
        public Dom5_Trainer()
        {
            InitializeComponent();
            dom5.GetThreads();
            dom5.OpenProcess(dom5.GetProcIdFromName("Dominions5"));
            if (dom5.OpenProcess(dom5.GetProcIdFromName("Dominions5")))
            {
                Trace.WriteLine("Dominions 5 is Found");
            }
            else
            {
                Trace.WriteLine("Dominions 5 is not Found");
                MessageBox.Show("Please Run Dominions 5 and try again run Trainer");
                Environment.Exit(0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = "Thank u for Choosing this Trainer, Made by BuzzerFelix";
            MessageBox.Show(text, "Dominions 5 WOTF Trainer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string dom5astral = "Dominions5.exe+1A67664";
            string astr = "Dominions5.exe+25D73DA";
            string dom5infastr = "20000";
            dom5.WriteMemory(dom5astral, "int", dom5infastr);
            dom5.WriteMemory(astr, "int", dom5infastr);
            dom5.ReadInt(dom5astral);
            dom5.ReadInt(astr);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dom5.CloseProcess();
            Environment.Exit(3432);
        }
    }
}
