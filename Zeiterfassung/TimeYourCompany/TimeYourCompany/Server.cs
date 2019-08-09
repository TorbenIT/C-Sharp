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
using System.IO;

namespace TimeYourCompany
{
    public partial class Server : Form
    {
        private TcpClient client;
        public StreamReader str;
        public StreamWriter stw;
        public string receive;
        public String text_to_send;

        private Login fh;

        public Server(Login aufrufer)
        {
            fh = aufrufer;
            InitializeComponent();

            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName()); // meine eigene IP bekommen
            foreach (IPAddress address in localIP)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                    {
                    txtServerIP.Text = address.ToString();
                    }
                }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            TcpListener listener = new TcpListener(IPAddress.Any, int.Parse(txtServerPort.Text));
            listener.Start();
            client = listener.AcceptTcpClient();
            str = new StreamReader(client.GetStream());
            stw = new StreamWriter(client.GetStream());
            stw.AutoFlush = true;

            backgroundWorker1.RunWorkerAsync(); // start receiving data im Hintergrund
            backgroundWorker2.WorkerSupportsCancellation = true; // Fähigkeit zu canceln
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        { // receive data
            while (client.Connected)
            {
                try
                {
                    receive = str.ReadLine();
                    this.txtAnzeige.Invoke(new MethodInvoker(delegate () { txtAnzeige.AppendText ( "You : " + receive + "\n"); }));
                    receive = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message.ToString());
                }
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        { // send data
            if (client.Connected)
            {
                stw.WriteLine(text_to_send);
                this.txtAnzeige.Invoke(new MethodInvoker(delegate () { txtAnzeige.AppendText("Me : " + text_to_send + "\n"); }));
            }
            else
            {
                MessageBox.Show("Send failed!");
            }
            backgroundWorker2.CancelAsync();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            client = new TcpClient();
            IPEndPoint IP_End = new IPEndPoint(IPAddress.Parse(txtClientIP.Text), int.Parse(txtClientPort.Text));

            try
            {
                client.Connect(IP_End);
                if (client.Connected)
                {
                    txtAnzeige.AppendText("Connected to Server" + "\n");
                    stw = new StreamWriter(client.GetStream());
                    str = new StreamReader(client.GetStream());
                    stw.AutoFlush = true;

                    backgroundWorker1.RunWorkerAsync(); // start receiving data im Hintergrund
                    backgroundWorker2.WorkerSupportsCancellation = true; // Fähigkeit zu canceln
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                text_to_send = textBox1.Text;
                backgroundWorker2.RunWorkerAsync();

            }
            textBox1.Text = "";
        }
    }
}
