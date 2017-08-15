using GpsSimulator.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GpsSimulator
{
    public partial class Form1 : Form
    {
        private  int portNum = Settings.Default.Portnumber;
        NetworkStream ns;
        System.Net.Sockets.TcpClient clientSocket;
        private  string hostName = Settings.Default.Hostname;
        string[] locations;
        private Thread thread = null;

        public Form1()
        {
            InitializeComponent();
            this.status.ForeColor = Color.DarkRed;
            this.status.Text = "Disconnected";
            this.label6.Text = Settings.Default.IMEI;
            string content = File.ReadAllText(@"location_data.txt");
            locations = content.Split(','); 

        }

        private void strt_bt_Click(object sender, EventArgs e)
        {        
            clientSocket=new System.Net.Sockets.TcpClient();
            clientSocket.Connect(hostName, portNum);
            ns = clientSocket.GetStream();
            byte[] outStream = System.Text.Encoding.ASCII.GetBytes("78780d010"+Settings.Default.IMEI+"000285680d0a");
            ns.Write(outStream, 0, outStream.Length);
            ns.Flush();
            byte[] inStream = new byte[10025];
            ns.Read(inStream, 0, (int)clientSocket.ReceiveBufferSize);
            if (inStream != null)
            {
                this.status.ForeColor = Color.Green;
                this.status.Text = "Connection successful.";
                thread = new Thread(new ThreadStart(send_location));
                thread.Start();
            }
        }


        private void stop_bt_Click(object sender, EventArgs e)
        {
            clientSocket.Close();
            thread.Abort();
            this.status.ForeColor = Color.DarkRed;
            this.status.Text = "Disconnected";
        }

        private void send_location()
        {
            foreach (string l in locations)
            {
                byte[] outStream = System.Text.Encoding.ASCII.GetBytes(l);
                ns.Write(outStream, 0, outStream.Length);
                ns.Flush();
                Thread.Sleep(10000);
            }
        }

        private void setting_bt_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        //private string hex_to_bin(string str)
        //{
        //    string binarystring = String.Join(String.Empty,
        //     str.Select(
        //        c => Convert.ToString(Convert.ToInt32(c.ToString(), 16), 2).PadLeft(4, '0')
        //        )
        //    );
        //    return binarystring;
        //}
    }
}
