using System;
using System.Net.Sockets;
using System.Text;

namespace Aqserver
{
    public class Pcs
    {
        public  Socket csoket { get; set; }
        public  string pcname { get; set; }
        public  int  Pcnum { get; set; }
        public  int status { get; set; }
        public  string Account { get; set; }
        public  string startTime { get; set; }
        public  string UsedTime { get; set; }
        public  string remainning { get; set; }
       
       
        
        public  void receve (byte[] buff)
        {
            int rec = 0;
            rec = BitConverter.ToInt32(buff, 0);
            try
            {
                if (rec == 1) // Pcid PcStatuse PcName
                {
                    RecevePCstatus(buff);
                }
                else if (rec == 2) // Timer status timervalue remaining time
                {
                    receveTimeStatus(Pcnum, buff);
                }
                else if (rec == 3) //screenshot
                {

                }
                else if (rec == 4) //videoscreen 
                {

                }
                else if (rec == 5) //account login
                {

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                
            }

           
           
        }
        public  void RecevePCstatus ( byte[] buffer)
        {
            Pcnum = BitConverter.ToInt32(buffer, 4);
            status = BitConverter.ToInt32(buffer, 8);
            int pcnamelenght = BitConverter.ToInt32(buffer, 12);
            pcname = Encoding.ASCII.GetString(buffer, 16,pcnamelenght);
            
            
        }
        public  void receveTimeStatus(int pcnum, byte [] buffer)
        { 
            
            int usedtimelength = BitConverter.ToInt32(buffer, 8);
            int remaininglength= BitConverter.ToInt32(buffer, 12);
            int starttimelength= BitConverter.ToInt32(buffer, 16);
            UsedTime = Encoding.ASCII.GetString(buffer,20,usedtimelength);
            remainning = Encoding.ASCII.GetString(buffer,usedtimelength+20,remaininglength);
            startTime= Encoding.ASCII.GetString(buffer, usedtimelength +remaininglength+ 20, starttimelength);

        }
        public void socket(Socket socket)
        {

            csoket = socket;
        }
       
        public void sendComms(int PcNum,int CommandType)
        {



        }
        public void send(byte[] buff,Socket socket)
        {
            socket.Send(buff);






        }
      
    

    }
}
