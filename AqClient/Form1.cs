using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace AqClient
{
    public partial class Form1 : Form
    {

      public  int ticks = 0;
       public int timeed = 3600;
        public int Order = 0;
        private Socket clientSocket;
        private byte[] buffer;

        EndPoint endPoint;
        public Form1()
            
        {
            InitializeComponent();
            
        }
        private void ConnectToServer()
        {
            
            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            int attempts = 0;

            while (!clientSocket.Connected)
            {

                try
                {
                    attempts++;
                    //label1.Text = ("Connection attempt " + attempts);
                    // Change IPAddress.Loopback to a remote IP to connect to a remote host.
                    clientSocket.Connect(IPAddress.Parse(textBoxAddress.Text), 100);
                }
                catch (Exception)
                {

                    Invoke((Action)delegate { label1.Text = ("Connection attempt " + attempts); }); 
                }
                       
                    
                    
               
            }
            Invoke((Action)delegate { label1.Text = ("Connected to server after  " + attempts+" attempts"); });

            //clientSocket.Listen(0);
          //  clientSocket.BeginAccept(AcceptCallback, null);
        }

        private void AcceptCallback(IAsyncResult ar)
        {
           
            try
            {
                
            }
            catch
            {
                return;
            }
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ticks++;
            if (ticks == timeed)
            {
                StopTimerTimed(1);
            }
            timeEst(1);
            label1.Text = PCCls.remainning+" "+PCCls.UsedTime +"  "+DateTime.Now.ToString(@"hh\:mm tt", CultureInfo.InvariantCulture);
           
           
        }

        public void multithread(object arg)
        {
            endPoint= new IPEndPoint(IPAddress.Parse(textBoxAddress.Text), 100);
            Socket socket = (Socket)arg;
            socket.BeginConnect(endPoint, ConnectCallback, null);
            byte[] buffer = sendcommands(int.Parse(txtCommtype.Text));
            socket.BeginSend(buffer, 0, buffer.Length, SocketFlags.None, SendCallback, null);
        }
       
        private void ReceiveCallback(IAsyncResult AR)
        {
            try
            {
                int received = clientSocket.EndReceive(AR);

                if (received == 0)
                {
                    return;
                }
                buffer = new byte[received];
                int CommType = BitConverter.ToInt32(buffer, 0);
                
               

                // Start receiving data again.
                clientSocket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, ReceiveCallback, null);
            }
            // Avoid Pokemon exception handling in cases like these.
            catch (SocketException ex)
            {
                ShowErrorDialog(ex.Message);
            }
            catch (ObjectDisposedException ex)
            {
                ShowErrorDialog(ex.Message);
            }
        }

        private void ConnectCallback(IAsyncResult AR)
        {
            try
            {
                clientSocket.EndConnect(AR);

                buffer = new byte[clientSocket.ReceiveBufferSize];
                clientSocket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, ReceiveCallback, null);
            }
            catch (SocketException ex)
            {
                ShowErrorDialog(ex.Message);
            }
            catch (ObjectDisposedException ex)
            {
                ShowErrorDialog(ex.Message);
            }
        }

        private void SendCallback(IAsyncResult AR)
        {
            try
            {
                clientSocket.EndSend(AR);
            }
            catch (SocketException ex)
            {
                ShowErrorDialog(ex.Message);
            }
            catch (ObjectDisposedException ex)
            {
                ShowErrorDialog(ex.Message);
            }
        }

        /// <summary>
        /// A thread safe way to enable the send button.
        /// </summary>




        private void buttonConnect_Click(object sender, EventArgs e)
        {

        }

        private void ClientForm_Load(object sender, EventArgs e)
        {

        }
        private static void ShowErrorDialog(string message)
        {
            MessageBox.Show(message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonSend_Click_1(object sender, EventArgs e)
        {
            try 
            {
                
                byte[] buffer = sendcommands(int.Parse(txtCommtype.Text));
                clientSocket.BeginSend(buffer, 0, buffer.Length, SocketFlags.None, SendCallback, null);
            }
            catch (SocketException ex)
            {
                ShowErrorDialog(ex.Message);
            }
            catch (ObjectDisposedException ex)
            {
                ShowErrorDialog(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                //clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //// Connect to the specified host.

                //clientSocket.BeginConnect(endPoint, ConnectCallback, null);
                ConnectToServer();


            }
            catch (SocketException ex)
            {
                label1.Text = "server Disconnected";
            }
            catch (ObjectDisposedException ex)
            {
                label1.Text = "server Disconnected";
            }
        }
       
        public byte[] sendcommands(int commandtype)
        {
            List<byte> byteList = new List<byte>();
            if (commandtype == 1)
            {
                byteList.AddRange(BitConverter.GetBytes(1));
                byteList.AddRange(BitConverter.GetBytes(int.Parse(txtPcnum.Text)));
                byteList.AddRange(BitConverter.GetBytes(int.Parse (txtstatus.Text)));
                byteList.AddRange(BitConverter.GetBytes(txtpcname.Text.Length));
                byteList.AddRange(Encoding.ASCII.GetBytes(txtpcname.Text));
            }
            else if (commandtype==2)
            {
                byteList.AddRange(BitConverter.GetBytes(2));
                byteList.AddRange(BitConverter.GetBytes(int.Parse(txtPcnum.Text)));
                byteList.AddRange(BitConverter.GetBytes(PCCls.UsedTime.Length));
                byteList.AddRange(BitConverter.GetBytes(PCCls.remainning.Length));
                byteList.AddRange(BitConverter.GetBytes(PCCls.startTime.Length));
                byteList.AddRange(Encoding.ASCII.GetBytes(PCCls.UsedTime));
                byteList.AddRange(Encoding.ASCII.GetBytes(PCCls.remainning));
                byteList.AddRange(Encoding.ASCII.GetBytes(PCCls.startTime));

            }
            else if (commandtype == 2) // 
            {

            }


                return byteList.ToArray();

        }
        public void StartTimerTimed(int time)
        {
            
            PCCls.startTime = (DateTime.Now.ToString(@"hh\:mm tt", CultureInfo.InvariantCulture)).ToString();
            timeed = time;
            timer1.Start();
        }
        public void StartTimeropen()
        {
            PCCls.startTime = (DateTime.Now.ToString(@"hh\:mm tt", CultureInfo.InvariantCulture)).ToString();
            timer1.Start();
            
            

        }
        public void PauseTimer()
        {

            timer1.Stop();
            PCCls.status = 6;
            
          

        }
        public void StopTimerTimed(int order)
        {
            if (order == 1)  //Timed
            {
                timer1.Stop();
            }
            else if (order==2) //Open
            {
                timer1.Stop();
            }
            else if (order==3) //Account
            {
                
                timer1.Stop();
            }


        }
        public void timeEst(int order)
        {
            
            if (order==1)
            {
                TimeSpan ts1 = TimeSpan.FromSeconds(ticks);
                TimeSpan ts2 = TimeSpan.FromSeconds(timeed);
                TimeSpan ts3 = ts2 - ts1;
                PCCls.UsedTime = ts1.ToString(@"hh\:mm\:ss");
                PCCls.remainning =  ts3.ToString(@"hh\:mm\:ss");
                
            }
            else if (order==2)
            {
                TimeSpan ts1 = TimeSpan.FromSeconds(ticks);
                PCCls.UsedTime = ts1.ToString(@"hh\:mm\:ss");
                PCCls.remainning = "00:00:00";


            }
           

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PauseTimer();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            endPoint = new IPEndPoint(IPAddress.Parse(textBoxAddress.Text), 100);
            Thread t = new Thread(ConnectToServer);
            t.Start();
            StartTimerTimed(3600);
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
