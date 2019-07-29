namespace Aqserver
{
    partial class PcsUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PcsUC));
            this.RemainningTxt = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.startTimetxt = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.PCnumtxt = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiNewOpenSession = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewSession = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddtime = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConvertToUnlimited = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLimitTime = new System.Windows.Forms.ToolStripMenuItem();
            this.UsedTimetxt = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Acconttxt = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.PicStatus = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // RemainningTxt
            // 
            this.RemainningTxt.AutoSize = true;
            this.RemainningTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemainningTxt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.RemainningTxt.Location = new System.Drawing.Point(510, 34);
            this.RemainningTxt.Name = "RemainningTxt";
            this.RemainningTxt.Size = new System.Drawing.Size(101, 24);
            this.RemainningTxt.TabIndex = 0;
            this.RemainningTxt.Text = "Remaining";
            this.RemainningTxt.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.RemainningTxt.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            // 
            // startTimetxt
            // 
            this.startTimetxt.AutoSize = true;
            this.startTimetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTimetxt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.startTimetxt.Location = new System.Drawing.Point(356, 34);
            this.startTimetxt.Name = "startTimetxt";
            this.startTimetxt.Size = new System.Drawing.Size(89, 24);
            this.startTimetxt.TabIndex = 0;
            this.startTimetxt.Text = "StartTime";
            this.startTimetxt.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.startTimetxt.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            // 
            // PCnumtxt
            // 
            this.PCnumtxt.AutoSize = true;
            this.PCnumtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PCnumtxt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.PCnumtxt.Location = new System.Drawing.Point(129, 34);
            this.PCnumtxt.Name = "PCnumtxt";
            this.PCnumtxt.Size = new System.Drawing.Size(39, 24);
            this.PCnumtxt.TabIndex = 0;
            this.PCnumtxt.Text = "NO";
            this.PCnumtxt.MouseLeave += new System.EventHandler(this.PCnumtxt_MouseLeave);
            this.PCnumtxt.MouseHover += new System.EventHandler(this.PCnumtxt_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.ContextMenuStrip = this.contextMenuStrip1;
            this.panel1.Controls.Add(this.PCnumtxt);
            this.panel1.Controls.Add(this.UsedTimetxt);
            this.panel1.Controls.Add(this.RemainningTxt);
            this.panel1.Controls.Add(this.Acconttxt);
            this.panel1.Controls.Add(this.startTimetxt);
            this.panel1.Controls.Add(this.bunifuSeparator1);
            this.panel1.Controls.Add(this.PicStatus);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 79);
            this.panel1.TabIndex = 2;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            this.panel1.MouseCaptureChanged += new System.EventHandler(this.Panel1_MouseCaptureChanged);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.panel1.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNewOpenSession,
            this.tsmiNewSession,
            this.tsmiAddtime,
            this.tsmiConvertToUnlimited,
            this.tsmiLimitTime});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(164, 136);
            this.contextMenuStrip1.Closing += new System.Windows.Forms.ToolStripDropDownClosingEventHandler(this.contextMenuStrip1_Closing);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            this.contextMenuStrip1.MouseLeave += new System.EventHandler(this.PicStatus_MouseLeave);
            this.contextMenuStrip1.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            // 
            // tsmiNewOpenSession
            // 
            this.tsmiNewOpenSession.Name = "tsmiNewOpenSession";
            this.tsmiNewOpenSession.Size = new System.Drawing.Size(163, 22);
            this.tsmiNewOpenSession.Text = "New Open Session";
            this.tsmiNewOpenSession.Click += new System.EventHandler(this.tsmiNewOpenSession_Click);
            // 
            // tsmiNewSession
            // 
            this.tsmiNewSession.Name = "tsmiNewSession";
            this.tsmiNewSession.Size = new System.Drawing.Size(163, 22);
            this.tsmiNewSession.Text = "New Session";
            // 
            // tsmiAddtime
            // 
            this.tsmiAddtime.Name = "tsmiAddtime";
            this.tsmiAddtime.Size = new System.Drawing.Size(163, 22);
            this.tsmiAddtime.Text = "AddTime";
            // 
            // tsmiConvertToUnlimited
            // 
            this.tsmiConvertToUnlimited.Name = "tsmiConvertToUnlimited";
            this.tsmiConvertToUnlimited.Size = new System.Drawing.Size(163, 22);
            this.tsmiConvertToUnlimited.Text = "Convert To Unlimited";
            // 
            // tsmiLimitTime
            // 
            this.tsmiLimitTime.Name = "tsmiLimitTime";
            this.tsmiLimitTime.Size = new System.Drawing.Size(163, 22);
            this.tsmiLimitTime.Text = "Limit Time";
            // 
            // UsedTimetxt
            // 
            this.UsedTimetxt.AutoSize = true;
            this.UsedTimetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsedTimetxt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.UsedTimetxt.Location = new System.Drawing.Point(670, 34);
            this.UsedTimetxt.Name = "UsedTimetxt";
            this.UsedTimetxt.Size = new System.Drawing.Size(89, 24);
            this.UsedTimetxt.TabIndex = 0;
            this.UsedTimetxt.Text = "Usedtime";
            this.UsedTimetxt.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.UsedTimetxt.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            // 
            // Acconttxt
            // 
            this.Acconttxt.AutoSize = true;
            this.Acconttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Acconttxt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Acconttxt.Location = new System.Drawing.Point(218, 34);
            this.Acconttxt.Name = "Acconttxt";
            this.Acconttxt.Size = new System.Drawing.Size(80, 24);
            this.Acconttxt.TabIndex = 0;
            this.Acconttxt.Text = "Account";
            this.Acconttxt.MouseLeave += new System.EventHandler(this.Acconttxt_MouseLeave);
            this.Acconttxt.MouseHover += new System.EventHandler(this.Acconttxt_MouseHover);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(96, 46);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(694, 31);
            this.bunifuSeparator1.TabIndex = 1;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            this.bunifuSeparator1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.bunifuSeparator1.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            // 
            // PicStatus
            // 
            this.PicStatus.Dock = System.Windows.Forms.DockStyle.Left;
            this.PicStatus.Image = ((System.Drawing.Image)(resources.GetObject("PicStatus.Image")));
            this.PicStatus.Location = new System.Drawing.Point(0, 0);
            this.PicStatus.Name = "PicStatus";
            this.PicStatus.Size = new System.Drawing.Size(96, 77);
            this.PicStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PicStatus.TabIndex = 0;
            this.PicStatus.TabStop = false;
            this.PicStatus.MouseLeave += new System.EventHandler(this.PicStatus_MouseLeave);
            this.PicStatus.MouseHover += new System.EventHandler(this.PicStatus_MouseHover);
            // 
            // PcsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Name = "PcsUC";
            this.Size = new System.Drawing.Size(792, 83);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel PCnumtxt;
        private System.Windows.Forms.PictureBox PicStatus;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewOpenSession;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewSession;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddtime;
        private System.Windows.Forms.ToolStripMenuItem tsmiConvertToUnlimited;
        private System.Windows.Forms.ToolStripMenuItem tsmiLimitTime;
        public Bunifu.Framework.UI.BunifuCustomLabel RemainningTxt;
        public Bunifu.Framework.UI.BunifuCustomLabel startTimetxt;
        public System.Windows.Forms.Panel panel1;
        public Bunifu.Framework.UI.BunifuCustomLabel Acconttxt;
        public Bunifu.Framework.UI.BunifuCustomLabel UsedTimetxt;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
    }
}
