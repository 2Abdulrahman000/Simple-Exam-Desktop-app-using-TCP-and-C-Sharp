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

namespace Server2
{
    public partial class Form1 : Form
    {
        //Server Side
        //////////////////////////needs about recieve Questions//////////////////////////// 
        TcpListener listener;
        TcpClient client;
        NetworkStream nstream;
        byte[] bdata = new byte[1024];
        string sdata;

        //////////////////////////needs about add score for each correct Questions//////////////////////////// 
        int qrecv = 0;
        int score = 0;
        string[] canswer = {"Abdo","Egypt","Mit Ghmaer","21","Computer Science"};

        string[,] answers = { { "Abdo" , "Adel" , "Bahgt" ,"waleed"} , 
                              { "Sudan" , "Egypt" , "Italy" , "Brazil"} ,
                              { "Mit Ghmaer" , "Alex" , "Cairo" , "Minia" } ,
                              { "33" , "24" , "16" , "21"} ,
                              { "Computer Science" , "Medicine" ,"AI" ,"History"}
                            };

        //////////////////////////needs about Exam Time//////////////////////////// 
        int csec=0, sec=0, min=0;

        ////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////

        ////////////no work in this constructor//////////////
        public Form1()
        {
            InitializeComponent();
        }

        ////////////activate backgroundWorker for recieve text and timer exam//////////////
        private void Form1_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
            timer1.Start();
            btn_answer.Enabled = false;
            btn_answer.BackColor = Color.Teal;
        }

        ////////////reciive Questions operation in background//////////////
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            listener = new TcpListener(IPAddress.Any,1234);
            listener.Start();
            while (true)
            {
                client = listener.AcceptTcpClient();
                nstream = client.GetStream();
                nstream.Read(bdata,0,bdata.Length);
                int recv = 0;
                foreach (byte b in bdata)
                {
                    if (b != 0) recv++;
                }
                sdata = Encoding.ASCII.GetString(bdata, 0, recv);

                //prepare controls if Questions has sent
                label1.Invoke((MethodInvoker)delegate
                    {
                        label1.Text = sdata;
                        qrecv++;
                    }
                    );

                lb_nquestions.Invoke((MethodInvoker)delegate { lb_nquestions.Text = qrecv.ToString(); });

                btn_answer.Invoke((MethodInvoker)delegate
                {
                    btn_answer.Enabled = true;
                    btn_answer.BackColor = Color.Teal;
                });

                for (int i = 1; i < 6; i++)
                {
                    if (i == qrecv)
                    {
                        lb_ans1.Invoke((MethodInvoker)delegate { lb_ans1.Text = answers[i-1, 0]; });
                        lb_ans2.Invoke((MethodInvoker)delegate { lb_ans2.Text = answers[i-1, 1]; });
                        lb_ans3.Invoke((MethodInvoker)delegate { lb_ans3.Text = answers[i-1, 2]; });
                        lb_ans4.Invoke((MethodInvoker)delegate { lb_ans4.Text = answers[i-1, 3]; });
                    }
                }
            }

        }

        ////////////Check Correct Answer then add score////////////////
        private void btn_answer_Click(object sender, EventArgs e)
        {
            if (tb_answer.Text != ""){
                if (qrecv == 1 && tb_answer.Text == canswer[0]) score++;
                else if (qrecv == 2 && tb_answer.Text == canswer[1]) score++;
                else if (qrecv == 3 && tb_answer.Text == canswer[2]) score++;
                else if (qrecv == 4 && tb_answer.Text == canswer[3]) score++;
                else if (qrecv == 5 && tb_answer.Text == canswer[4]) score++;
                lb_score.Text = score.ToString();
            }

            else {
                MessageBox.Show("Empty Text !!!!");
            }
            btn_answer.Enabled = false;
            btn_answer.BackColor = Color.Red;
        }

        ////////////icrement minute and secound to create timer Exam and finish it in specified time////////////////
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (qrecv > 0)
            {
                csec++;
                if (csec >= 100)
                {
                    sec++;
                    csec = 0;
                    lb_sec.Text = sec.ToString();
                    if (sec >= 60)
                    {
                        min++;
                        sec = 0;
                        lb_min.Text = "0" + min.ToString();
                    }
                }
                // lb_sec.Text = string.Format("{0,00}", sec);
                //lb_min.Text = string.Format("{0,00}", min);
                // lb_min.Text="0"+min;  
            }
            if (min == 1)
            {
                timer1.Stop();
                lb_sec.Text = "00";
                MessageBox.Show("Your Degree is :"+score+"/5", "Exit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }



    }
}
