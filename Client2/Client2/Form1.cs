using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Client2
{
    public partial class Form1 : Form
    {
       //Client Side 
        TcpClient client;
        string sdata;
        byte[] bdata;
        int bcount;
        NetworkStream nstream;
        public Form1()
        {
            InitializeComponent();
           // MessageBox.Show("sfdddddddd");
        }




        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
           {
               client = new TcpClient("192.168.3", 1234);

                sdata = textBox1.Text;
                bcount = Encoding.ASCII.GetByteCount(sdata);
                bdata=new byte[bcount];
                bdata = Encoding.ASCII.GetBytes(sdata);

                nstream = client.GetStream();

                nstream.Write(bdata, 0, bdata.Length);
                nstream.Close();
                client.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Failed To connect");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
