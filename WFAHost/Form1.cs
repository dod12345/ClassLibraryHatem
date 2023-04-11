using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
namespace WFAHost
{
    public partial class Form1 : Form
    {
        private ServiceHost host;
        public Form1()
        {
            InitializeComponent();
            host = new ServiceHost(typeof(ClassLibraryHatem.WCFHatem));
            host.Open();
            button1.Enabled = false;
            button2.Enabled = true;
            label1.Text = "Service Started";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            host = new ServiceHost(typeof(ClassLibraryHatem.WCFHatem));
            host.Open();
            button1.Enabled = false;
            button2.Enabled = true;
            label1.Text = "Service Started";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            host.Close();
            button1.Enabled = true;
            button2.Enabled = false;
            label1.Text = "Service Stopped";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            host.Close();
            button1.Enabled = true;
            button2.Enabled = false;

        }
    }
}
