using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Threading;

namespace Aqserver
{
    public partial class MainFrm : Form
    {
        public static List<Pcs> Clints = new List<Pcs>();
        public static Socket socket;
        private static Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        PcsUC uc;
        Pcs PC;
        private const int PORT = 100;
        private static byte[] buffer;
        public MainFrm()
        {
            InitializeComponent();
            Serupserver();
            
           
        }
       
 
        private void Serupserver()
        {
            serverSocket.Bind(new IPEndPoint(IPAddress.Any, PORT));
            serverSocket.Listen(30);
            serverSocket.BeginAccept(AcceptCallback, null);
        }
      
        private void AcceptCallback(IAsyncResult AR)
        {


            try
            {
                socket =  serverSocket.EndAccept(AR);
            }
            catch (ObjectDisposedException) // I cannot seem to avoid this (on exit when properly closing sockets)
            {
                return;
            }
            PC = new Pcs();
            PC.socket(socket);
            buffer = new byte[socket.ReceiveBufferSize];
            Thread t = new Thread(multithread);
            t.Start(PC.csoket);
            //socket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, ReceiveCallback, socket);
            
            serverSocket.BeginAccept(AcceptCallback, null);
        }
        private  void multithread(Object socket)
        {
            Socket csocket = (Socket)socket;


            csocket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, ReceiveCallback, socket);



        }
        private void ReceiveCallback(IAsyncResult AR)
        {
            Socket current = (Socket)AR.AsyncState;
            //PC = Clints.Find(i => i.csoket == current);     //to find sender in Clints list
           
            try
            {
                // Socket exception will raise here when client closes, as this sample does not
                // demonstrate graceful disconnects for the sake of simplicity.
                int received = 0;
                if (current!=null)
                {
                    received = current.EndReceive(AR);
                }
                else
                {
                    MessageBox.Show("Command Did not Sent Propely");
                }
                if (received == 0)
                {
                    return;
                }
              // Check if pc is In the Clints list Then Proceed
              checklist(buffer);
                // Start receiving data again.
                current.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, ReceiveCallback, null);
            }
            // Avoid Pokemon exception handling in cases like these.
            catch 
            {
                MessageBox.Show("Command Did not Sent Propely(catch)");
            }
           
        }
        private void SendCallback(IAsyncResult AR, Socket dist)
        {
            try
            {

                dist.EndSend(AR);
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

        private void ShowErrorDialog(string message)
        {
            MessageBox.Show(message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void checklist(byte[] buffer)
        {  // Deseralize Pc ID From Buffer
            int pcnum = BitConverter.ToInt32(buffer, 4);
            //initial A New PCs Object
            PC = new Pcs();
            
            // Check if Id is in List
            PC = Clints.Find(i => i.Pcnum == pcnum);
            // ID Is In List
            if (PC!=null)
            { 
                uc = FindControl(MainPanel, PC.Pcnum.ToString());
                PC.receve(buffer);
                uc.UpdateGrid(PC.status,PC.pcname ,PC.Pcnum, PC.startTime, PC.remainning, PC.Account, PC.UsedTime,PC.csoket);
              // Invoke((Action)delegate { MainPanel.Refresh(); });
            }
            // Id Is new ID
            else
            {
             PC = new Pcs();
                PC.receve(buffer);
                Clints.Add(PC);
                //Initial A new UserControl For The New Connected Pc
             uc = new PcsUC(PC.status, PC.Pcnum, null, null, null, null,PC.csoket);
             uc.Dock = DockStyle.Top;
                //Add Control To Panel
             Invoke((Action)delegate { MainPanel.Controls.Add(uc); });
            }
        }
       public  PcsUC FindControl(Panel parent, string name)
        {

            PcsUC found = parent.Controls.Find(name, false).First() as PcsUC;
            if (found != null) return found;
            else return null;  
        }     
    }
}
