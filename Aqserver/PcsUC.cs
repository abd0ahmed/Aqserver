using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Net.Sockets;




namespace Aqserver
{
    public partial class PcsUC : UserControl
    {
        public PcsUC(int _status,int _Pcnum,string _starttime,string _Remainning,string _Account,string _UsedTime,Socket socket)
        {
            InitializeComponent();
            Status = _status;
            PcNum = _Pcnum;
            starttime = _starttime;
            remainning = _Remainning;
            Account = _Account;
             this.Name = PcNum.ToString();
            PicStatus.Image =StatusIamge(_status);
            UsedTimetxt.Text = "usedTime";
            PCnumtxt.Text = ( _Pcnum).ToString();
            startTimetxt.Text = "StartTime";
            RemainningTxt.Text = "Remaining";
            Acconttxt.Text = "Account";
            this.bunifuSeparator1.LineColor = Color.Gray;




        }
        public  Image StatusIamge(int __Status)
        {

            
            if (__Status ==6)
            {

                img = new Bitmap((Bitmap)(Properties.Resources.Timebused));

            }
           else if (__Status == 2)
            {
              
                img = new Bitmap((Bitmap)(Properties.Resources.AdminLogin));

            }
            else if (__Status == 3)
            {

                img = new Bitmap((Bitmap)(Properties.Resources.Opentime));

            }
            else if (__Status == 4)
            {

                img = new Bitmap((Bitmap)(Properties.Resources.AccountLogin));

            }
            else if (__Status == 1)
            {
                
                img = new Bitmap((Bitmap)(Properties.Resources.Idel));

            }
            else if (__Status == 7)
            {

                img = new Bitmap((Bitmap)(Properties.Resources._5Min));
            }
            else if (__Status == 5)
            {

                img = new Bitmap((Bitmap)(Properties.Resources.Timed));

            }
            

            return img;
            
        }

        public int Status;
        public int PcNum;
        public string starttime;
        public string Account;
        public string remainning;
        public Image img;
        public Socket Socket;
       
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           

        }
        public void UpdateGrid(int _status,string _pcname ,int _Pcnum, string _starttime, string _Remainning, string _Account, string _UsedTime,Socket socket)
        {
            Invoke((Action)delegate
            {
                Status = _status;
                PcNum = _Pcnum;
                starttime = _starttime;
                remainning = _Remainning;
                Account = _Account;
                PicStatus.Image = StatusIamge(_status);
                UsedTimetxt.Text = _UsedTime;
                PCnumtxt.Text = (_Pcnum).ToString();
                startTimetxt.Text = _starttime;
                RemainningTxt.Text = _Remainning;
                Acconttxt.Text = _Account;
                Socket = socket;
                Invalidate();
            });
            
        }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            this.bunifuSeparator1.LineColor = Color.SeaGreen;
            this.Invalidate();
        }

        private void Panel1_MouseCaptureChanged(object sender, EventArgs e)
        {
           
            

            
            
            
        }

        private void tsmiNewOpenSession_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            this.bunifuSeparator1.LineColor = Color.SeaGreen;
            this.Invalidate();
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            this.bunifuSeparator1.LineColor = Color.Gray;
            this.Invalidate();
        }

        private void PicStatus_MouseHover(object sender, EventArgs e)
        {
            this.bunifuSeparator1.LineColor = Color.SeaGreen;
            this.Invalidate();
        }

        private void PicStatus_MouseLeave(object sender, EventArgs e)
        {
            this.bunifuSeparator1.LineColor = Color.Gray;
            this.Invalidate();
        }

        private void PCnumtxt_MouseHover(object sender, EventArgs e)
        {
            this.bunifuSeparator1.LineColor = Color.SeaGreen;
            this.Invalidate();
        }

        private void PCnumtxt_MouseLeave(object sender, EventArgs e)
        {
            this.bunifuSeparator1.LineColor = Color.Gray;
            this.Invalidate();
        }

        private void Acconttxt_MouseHover(object sender, EventArgs e)
        {

        }

        private void Acconttxt_MouseLeave(object sender, EventArgs e)
        {
            this.bunifuSeparator1.LineColor = Color.Gray;
            this.Invalidate();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            this.bunifuSeparator1.LineColor = Color.SeaGreen;
            this.Invalidate();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.bunifuSeparator1.LineColor = Color.SeaGreen;
            this.Invalidate();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            this.bunifuSeparator1.LineColor = Color.SeaGreen;
            this.Invalidate();
        }

        private void contextMenuStrip1_Closing(object sender, ToolStripDropDownClosingEventArgs e)
        {
            this.bunifuSeparator1.LineColor = Color.Gray;
            this.Invalidate();
        }
    }
}
