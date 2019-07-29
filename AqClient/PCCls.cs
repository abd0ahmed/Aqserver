using System;
using System.Net.Sockets;

namespace AqClient
{
    public static class PCCls
    {
        public static Socket ssoket { get; set; }
        public static string pcname { get; set; } = System.Windows.Forms.SystemInformation.ComputerName;
        public static int Pcnum { get; set; } = 1;
        public static int status { get; set; } = 1;
        public static string Account { get; set; } = string.Empty;
        public static string startTime { get; set; } = string.Empty;
        public static string UsedTime { get; set; } = string.Empty;
        public static string remainning { get; set; } = string.Empty;
        public static byte[] data { get; set; }
       
        

        public static void getPCInfo()
        {
            pcname = System.Windows.Forms.SystemInformation.ComputerName;
            Pcnum = 1;
            status = 1;



        }
         public static void receve (byte[] buff)
        {
            int commtype = 0;
            commtype = BitConverter.ToInt32(buff, 0);
            if (commtype==1)
            {

            }









        }





    }
}
