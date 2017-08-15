using GpsSimulator.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GpsSimulator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = Settings.Default.Hostname;
            textBox2.Text = Convert.ToString(Settings.Default.Portnumber);
            textBox3.Text = Settings.Default.IMEI;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Settings.Default.Hostname = textBox1.Text;
            Settings.Default.Portnumber = Convert.ToInt32(textBox2.Text);
            Settings.Default.IMEI = textBox3.Text;
            Settings.Default.Save();
            MessageBox.Show("Settings saved successfully !");
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
