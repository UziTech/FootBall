using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace FootBall
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		#region items
		private System.Windows.Forms.Label Home;
		private System.Windows.Forms.Label Visitor;
		private System.Windows.Forms.Label Down;
		private System.Windows.Forms.Label Yards;
		private System.Windows.Forms.Label Time;
		private System.Windows.Forms.Label At;
		private System.Windows.Forms.Label Hl;
		private System.Windows.Forms.Label Vl;
		private System.Windows.Forms.Label Dl;
		private System.Windows.Forms.Label Yl;
		private System.Windows.Forms.Label Tl;
		private System.Windows.Forms.Label Al;
		private System.Windows.Forms.Label Quarter;
		private System.Windows.Forms.Label Ql;
		private System.Windows.Forms.PictureBox Field;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuNG;
		private System.Windows.Forms.Label O;
		private System.Windows.Forms.PictureBox D1;
		private System.Windows.Forms.PictureBox D2;
		private System.Windows.Forms.PictureBox D3;
		private System.Windows.Forms.PictureBox D4;
		private System.Windows.Forms.PictureBox D5;
		private System.Windows.Forms.PictureBox D6;
		private System.Windows.Forms.MenuItem menuFile;
		private System.Windows.Forms.PictureBox EZ;
		private System.Windows.Forms.PictureBox SZ;
		private System.Windows.Forms.MenuItem HK;
		private System.Windows.Forms.MenuItem K;
		private System.Windows.Forms.MenuItem FG;
		private System.Windows.Forms.MenuItem P;
		private System.Windows.Forms.MenuItem H;
		private System.Timers.Timer timer1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem Hard;
		private System.Windows.Forms.MenuItem Med;
		private System.Windows.Forms.MenuItem Easy;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.Label hh;
		private System.Windows.Forms.Label hv;
		private System.Windows.Forms.Label vv;
        private System.Windows.Forms.Label vh;
        #endregion
        #region Windows Form Designer generated code
        private IContainer components;
		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Home = new System.Windows.Forms.Label();
            this.Visitor = new System.Windows.Forms.Label();
            this.Down = new System.Windows.Forms.Label();
            this.Yards = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.At = new System.Windows.Forms.Label();
            this.Hl = new System.Windows.Forms.Label();
            this.Vl = new System.Windows.Forms.Label();
            this.Dl = new System.Windows.Forms.Label();
            this.Yl = new System.Windows.Forms.Label();
            this.Tl = new System.Windows.Forms.Label();
            this.Al = new System.Windows.Forms.Label();
            this.Quarter = new System.Windows.Forms.Label();
            this.Ql = new System.Windows.Forms.Label();
            this.Field = new System.Windows.Forms.PictureBox();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuFile = new System.Windows.Forms.MenuItem();
            this.menuNG = new System.Windows.Forms.MenuItem();
            this.HK = new System.Windows.Forms.MenuItem();
            this.K = new System.Windows.Forms.MenuItem();
            this.FG = new System.Windows.Forms.MenuItem();
            this.P = new System.Windows.Forms.MenuItem();
            this.H = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.Hard = new System.Windows.Forms.MenuItem();
            this.Med = new System.Windows.Forms.MenuItem();
            this.Easy = new System.Windows.Forms.MenuItem();
            this.O = new System.Windows.Forms.Label();
            this.D1 = new System.Windows.Forms.PictureBox();
            this.D2 = new System.Windows.Forms.PictureBox();
            this.D3 = new System.Windows.Forms.PictureBox();
            this.D4 = new System.Windows.Forms.PictureBox();
            this.D5 = new System.Windows.Forms.PictureBox();
            this.D6 = new System.Windows.Forms.PictureBox();
            this.EZ = new System.Windows.Forms.PictureBox();
            this.SZ = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Timers.Timer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.hh = new System.Windows.Forms.Label();
            this.hv = new System.Windows.Forms.Label();
            this.vv = new System.Windows.Forms.Label();
            this.vh = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Field)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.D1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.D2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.D3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.D4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.D5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.D6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // Home
            // 
            this.Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Home.Location = new System.Drawing.Point(8, 16);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(37, 16);
            this.Home.TabIndex = 7;
            this.Home.Text = "Home";
            // 
            // Visitor
            // 
            this.Visitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Visitor.Location = new System.Drawing.Point(62, 16);
            this.Visitor.Name = "Visitor";
            this.Visitor.Size = new System.Drawing.Size(47, 17);
            this.Visitor.TabIndex = 7;
            this.Visitor.Text = "Visitor";
            // 
            // Down
            // 
            this.Down.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Down.Location = new System.Drawing.Point(118, 16);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(40, 17);
            this.Down.TabIndex = 8;
            this.Down.Text = "Down";
            // 
            // Yards
            // 
            this.Yards.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Yards.Location = new System.Drawing.Point(164, 16);
            this.Yards.Name = "Yards";
            this.Yards.Size = new System.Drawing.Size(75, 13);
            this.Yards.TabIndex = 9;
            this.Yards.Text = "Yards To Go";
            // 
            // Time
            // 
            this.Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.Location = new System.Drawing.Point(310, 16);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(39, 15);
            this.Time.TabIndex = 10;
            this.Time.Text = "Time";
            // 
            // At
            // 
            this.At.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.At.Location = new System.Drawing.Point(248, 16);
            this.At.Name = "At";
            this.At.Size = new System.Drawing.Size(49, 21);
            this.At.TabIndex = 11;
            this.At.Text = "At Yard";
            // 
            // Hl
            // 
            this.Hl.Location = new System.Drawing.Point(22, 37);
            this.Hl.Name = "Hl";
            this.Hl.Size = new System.Drawing.Size(29, 16);
            this.Hl.TabIndex = 12;
            this.Hl.Text = "0";
            // 
            // Vl
            // 
            this.Vl.Location = new System.Drawing.Point(75, 37);
            this.Vl.Name = "Vl";
            this.Vl.Size = new System.Drawing.Size(24, 16);
            this.Vl.TabIndex = 13;
            this.Vl.Text = "0";
            // 
            // Dl
            // 
            this.Dl.Location = new System.Drawing.Point(133, 37);
            this.Dl.Name = "Dl";
            this.Dl.Size = new System.Drawing.Size(11, 16);
            this.Dl.TabIndex = 14;
            this.Dl.Text = "1";
            // 
            // Yl
            // 
            this.Yl.Location = new System.Drawing.Point(192, 37);
            this.Yl.Name = "Yl";
            this.Yl.Size = new System.Drawing.Size(29, 16);
            this.Yl.TabIndex = 15;
            this.Yl.Text = "10";
            // 
            // Tl
            // 
            this.Tl.Location = new System.Drawing.Point(311, 37);
            this.Tl.Name = "Tl";
            this.Tl.Size = new System.Drawing.Size(34, 16);
            this.Tl.TabIndex = 16;
            this.Tl.Text = "15:00";
            // 
            // Al
            // 
            this.Al.Location = new System.Drawing.Point(258, 37);
            this.Al.Name = "Al";
            this.Al.Size = new System.Drawing.Size(24, 16);
            this.Al.TabIndex = 17;
            this.Al.Text = "80";
            // 
            // Quarter
            // 
            this.Quarter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quarter.Location = new System.Drawing.Point(361, 16);
            this.Quarter.Name = "Quarter";
            this.Quarter.Size = new System.Drawing.Size(53, 19);
            this.Quarter.TabIndex = 18;
            this.Quarter.Text = "Quarter";
            // 
            // Ql
            // 
            this.Ql.Location = new System.Drawing.Point(378, 37);
            this.Ql.Name = "Ql";
            this.Ql.Size = new System.Drawing.Size(14, 18);
            this.Ql.TabIndex = 19;
            this.Ql.Text = "1";
            // 
            // Field
            // 
            this.Field.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Field.BackgroundImage")));
            this.Field.Location = new System.Drawing.Point(40, 67);
            this.Field.Name = "Field";
            this.Field.Size = new System.Drawing.Size(348, 47);
            this.Field.TabIndex = 20;
            this.Field.TabStop = false;
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuFile,
            this.menuItem1});
            // 
            // menuFile
            // 
            this.menuFile.Index = 0;
            this.menuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuNG,
            this.HK,
            this.K,
            this.H});
            this.menuFile.Text = "File";
            // 
            // menuNG
            // 
            this.menuNG.Index = 0;
            this.menuNG.Shortcut = System.Windows.Forms.Shortcut.F2;
            this.menuNG.Text = "New Game";
            this.menuNG.Click += new System.EventHandler(this.menuNG_Click);
            // 
            // HK
            // 
            this.HK.Index = 1;
            this.HK.Shortcut = System.Windows.Forms.Shortcut.F3;
            this.HK.Text = "Hike";
            this.HK.Click += new System.EventHandler(this.HK_Click);
            // 
            // K
            // 
            this.K.Index = 2;
            this.K.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.FG,
            this.P});
            this.K.Text = "Kick";
            // 
            // FG
            // 
            this.FG.Index = 0;
            this.FG.Shortcut = System.Windows.Forms.Shortcut.F4;
            this.FG.Text = "Field Goal";
            this.FG.Click += new System.EventHandler(this.menuFG_Click);
            // 
            // P
            // 
            this.P.Index = 1;
            this.P.Shortcut = System.Windows.Forms.Shortcut.F5;
            this.P.Text = "Punt";
            this.P.Click += new System.EventHandler(this.menuP_Click);
            // 
            // H
            // 
            this.H.Index = 3;
            this.H.Shortcut = System.Windows.Forms.Shortcut.F1;
            this.H.Text = "Help";
            this.H.Click += new System.EventHandler(this.H_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 1;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Hard,
            this.Med,
            this.Easy});
            this.menuItem1.Text = "Difficulty";
            // 
            // Hard
            // 
            this.Hard.Index = 0;
            this.Hard.Text = "Hard";
            this.Hard.Click += new System.EventHandler(this.Hard_Click);
            // 
            // Med
            // 
            this.Med.Checked = true;
            this.Med.Index = 1;
            this.Med.Text = "Medium";
            this.Med.Click += new System.EventHandler(this.Med_Click);
            // 
            // Easy
            // 
            this.Easy.Index = 2;
            this.Easy.Text = "Easy";
            this.Easy.Click += new System.EventHandler(this.Easy_Click);
            // 
            // O
            // 
            this.O.BackColor = System.Drawing.Color.Red;
            this.O.Location = new System.Drawing.Point(50, 87);
            this.O.Name = "O";
            this.O.Size = new System.Drawing.Size(13, 7);
            this.O.TabIndex = 0;
            // 
            // D1
            // 
            this.D1.BackColor = System.Drawing.Color.Blue;
            this.D1.Location = new System.Drawing.Point(121, 72);
            this.D1.Name = "D1";
            this.D1.Size = new System.Drawing.Size(11, 5);
            this.D1.TabIndex = 30;
            this.D1.TabStop = false;
            // 
            // D2
            // 
            this.D2.BackColor = System.Drawing.Color.Blue;
            this.D2.Location = new System.Drawing.Point(121, 88);
            this.D2.Name = "D2";
            this.D2.Size = new System.Drawing.Size(11, 5);
            this.D2.TabIndex = 31;
            this.D2.TabStop = false;
            // 
            // D3
            // 
            this.D3.BackColor = System.Drawing.Color.Blue;
            this.D3.Location = new System.Drawing.Point(121, 104);
            this.D3.Name = "D3";
            this.D3.Size = new System.Drawing.Size(11, 5);
            this.D3.TabIndex = 32;
            this.D3.TabStop = false;
            // 
            // D4
            // 
            this.D4.BackColor = System.Drawing.Color.Blue;
            this.D4.Location = new System.Drawing.Point(226, 72);
            this.D4.Name = "D4";
            this.D4.Size = new System.Drawing.Size(11, 5);
            this.D4.TabIndex = 33;
            this.D4.TabStop = false;
            // 
            // D5
            // 
            this.D5.BackColor = System.Drawing.Color.Blue;
            this.D5.Location = new System.Drawing.Point(226, 104);
            this.D5.Name = "D5";
            this.D5.Size = new System.Drawing.Size(11, 5);
            this.D5.TabIndex = 34;
            this.D5.TabStop = false;
            // 
            // D6
            // 
            this.D6.BackColor = System.Drawing.Color.Blue;
            this.D6.Location = new System.Drawing.Point(331, 88);
            this.D6.Name = "D6";
            this.D6.Size = new System.Drawing.Size(11, 5);
            this.D6.TabIndex = 35;
            this.D6.TabStop = false;
            // 
            // EZ
            // 
            this.EZ.BackColor = System.Drawing.Color.Blue;
            this.EZ.Location = new System.Drawing.Point(353, 67);
            this.EZ.Name = "EZ";
            this.EZ.Size = new System.Drawing.Size(2, 47);
            this.EZ.TabIndex = 36;
            this.EZ.TabStop = false;
            this.EZ.Visible = false;
            // 
            // SZ
            // 
            this.SZ.BackColor = System.Drawing.Color.Red;
            this.SZ.Location = new System.Drawing.Point(73, 67);
            this.SZ.Name = "SZ";
            this.SZ.Size = new System.Drawing.Size(2, 47);
            this.SZ.TabIndex = 37;
            this.SZ.TabStop = false;
            this.SZ.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.SynchronizingObject = this;
            this.timer1.Elapsed += new System.Timers.ElapsedEventHandler(this.timer1_Elapsed);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox1.Location = new System.Drawing.Point(396, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(13, 3);
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox2.Location = new System.Drawing.Point(408, 96);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(13, 3);
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox3.Location = new System.Drawing.Point(407, 82);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(13, 3);
            this.pictureBox3.TabIndex = 40;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox4.Location = new System.Drawing.Point(407, 83);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(5, 16);
            this.pictureBox4.TabIndex = 41;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox5.Location = new System.Drawing.Point(19, 84);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(5, 16);
            this.pictureBox5.TabIndex = 45;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Visible = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox6.Location = new System.Drawing.Point(9, 83);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(13, 3);
            this.pictureBox6.TabIndex = 44;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Visible = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox7.Location = new System.Drawing.Point(10, 97);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(13, 3);
            this.pictureBox7.TabIndex = 43;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Visible = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox8.Location = new System.Drawing.Point(21, 91);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(13, 3);
            this.pictureBox8.TabIndex = 42;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Visible = false;
            // 
            // hh
            // 
            this.hh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hh.Image = ((System.Drawing.Image)(resources.GetObject("hh.Image")));
            this.hh.Location = new System.Drawing.Point(10, 70);
            this.hh.Name = "hh";
            this.hh.Size = new System.Drawing.Size(19, 39);
            this.hh.TabIndex = 46;
            // 
            // hv
            // 
            this.hv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hv.Image = ((System.Drawing.Image)(resources.GetObject("hv.Image")));
            this.hv.Location = new System.Drawing.Point(394, 71);
            this.hv.Name = "hv";
            this.hv.Size = new System.Drawing.Size(19, 39);
            this.hv.TabIndex = 47;
            this.hv.Visible = false;
            // 
            // vv
            // 
            this.vv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vv.Image = ((System.Drawing.Image)(resources.GetObject("vv.Image")));
            this.vv.Location = new System.Drawing.Point(395, 71);
            this.vv.Name = "vv";
            this.vv.Size = new System.Drawing.Size(19, 39);
            this.vv.TabIndex = 48;
            // 
            // vh
            // 
            this.vh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vh.Image = ((System.Drawing.Image)(resources.GetObject("vh.Image")));
            this.vh.Location = new System.Drawing.Point(10, 69);
            this.vh.Name = "vh";
            this.vh.Size = new System.Drawing.Size(19, 39);
            this.vh.TabIndex = 49;
            this.vh.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(429, 144);
            this.Controls.Add(this.vh);
            this.Controls.Add(this.vv);
            this.Controls.Add(this.hv);
            this.Controls.Add(this.hh);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SZ);
            this.Controls.Add(this.EZ);
            this.Controls.Add(this.D6);
            this.Controls.Add(this.D5);
            this.Controls.Add(this.D4);
            this.Controls.Add(this.D3);
            this.Controls.Add(this.D2);
            this.Controls.Add(this.D1);
            this.Controls.Add(this.O);
            this.Controls.Add(this.Field);
            this.Controls.Add(this.Quarter);
            this.Controls.Add(this.Al);
            this.Controls.Add(this.Tl);
            this.Controls.Add(this.Yl);
            this.Controls.Add(this.Dl);
            this.Controls.Add(this.Vl);
            this.Controls.Add(this.Hl);
            this.Controls.Add(this.At);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Yards);
            this.Controls.Add(this.Down);
            this.Controls.Add(this.Visitor);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.Ql);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "FootBall";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Field)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.D1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.D2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.D3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.D4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.D5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.D6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);

		}
		[STAThread]
			#endregion
		#region static void Main()
		static void Main() 
		{
			Application.Run(new Form1());
		}
		#endregion
		#region Global Variables
		int _num = 2;
		int _TM = 15;
		int _TS = 0;
		bool _Begin = true;
		bool _HomePlay = true;
		bool _Play = false;
		bool _Punt = false;
		bool _Fg = false;
		bool _made = false;
		int _Hl = 0;
		int _Vl = 0;
		int _Dl = 1;
		int _Yl = 70;
		int _Al = 80;
		int _temp = 0;
		int _Ql = 1;
		#endregion
		#region private void play()
		private void play()
		{
			Random randomClass = new Random();
			int rand = randomClass.Next(0,100);
			if (rand <= _num)
			{
				if (O.Left + 1 < D1.Left)
				{
					D1.Left -= 35;
					if (D1.Location == D2.Location || D1.Location == D3.Location || D1.Location == D4.Location || D1.Location == D5.Location || D1.Location == D6.Location)
					{
						D1.Left += 35;
					}
				}
				else if (O.Left + 1 > D1.Left)
				{
					D1.Left += 35;
					if (D1.Location == D2.Location || D1.Location == D3.Location || D1.Location == D4.Location || D1.Location == D5.Location || D1.Location == D6.Location)
					{
						D1.Left -= 35;
					}
				}
			}
			else if (rand <= _num * 2)
			{
				if (O.Top + 1 < D1.Top)
				{
					D1.Top -= 16;
					if (D1.Location == D2.Location || D1.Location == D3.Location || D1.Location == D4.Location || D1.Location == D5.Location || D1.Location == D6.Location)
					{
						D1.Top += 16;
					}
				}
				else if (O.Top + 1 > D1.Top)
				{
					D1.Top += 16;
					if (D1.Location == D2.Location || D1.Location == D3.Location || D1.Location == D4.Location || D1.Location == D5.Location || D1.Location == D6.Location)
					{
						D1.Top -= 16;
					}
				}
			}
			else if (rand <= _num * 3)
			{
				if (O.Left + 1 < D2.Left)
				{
					D2.Left -= 35;
					if (D2.Location == D1.Location || D2.Location == D3.Location || D2.Location == D4.Location || D2.Location == D5.Location || D2.Location == D6.Location)
					{
						D2.Left += 35;
					}
				}
				else if (O.Left + 1 > D2.Left)
				{
					D2.Left += 35;
					if (D2.Location == D1.Location || D2.Location == D3.Location || D2.Location == D4.Location || D2.Location == D5.Location || D2.Location == D6.Location)
					{
						D2.Left -= 35;
					}
				}
			}
			else if (rand <= _num * 4)
			{
				if (O.Top + 1 < D2.Top)
				{
					D2.Top -= 16;
					if (D2.Location == D1.Location || D2.Location == D3.Location || D2.Location == D4.Location || D2.Location == D5.Location || D2.Location == D6.Location)
					{
						D2.Top += 16;
					}
				}
				else if (O.Top + 1 > D2.Top)
				{
					D2.Top += 16;
					if (D2.Location == D1.Location || D2.Location == D3.Location || D2.Location == D4.Location || D2.Location == D5.Location || D2.Location == D6.Location)
					{
						D2.Top -= 16;
					}
				}
			}
			else if (rand <= _num * 5)
			{
				if (O.Left + 1 < D3.Left)
				{
					D3.Left -= 35;
					if (D3.Location == D1.Location || D3.Location == D2.Location || D3.Location == D4.Location || D3.Location == D5.Location || D3.Location == D6.Location)
					{
						D3.Left += 35;
					}
				}
				else if (O.Left + 1 > D3.Left)
				{
					D3.Left += 35;
					if (D3.Location == D1.Location || D3.Location == D2.Location || D3.Location == D4.Location || D3.Location == D5.Location || D3.Location == D6.Location)
					{
						D3.Left -= 35;
					}
				}
			}
			else if (rand <= _num * 6)
			{
				if (O.Top + 1 < D3.Top)
				{
					D3.Top -= 16;
					if (D3.Location == D1.Location || D3.Location == D2.Location || D3.Location == D4.Location || D3.Location == D5.Location || D3.Location == D6.Location)
					{
						D3.Top += 16;
					}
				}
				else if (O.Top + 1 > D3.Top)
				{
					D3.Top += 16;
					if (D3.Location == D1.Location || D3.Location == D2.Location || D3.Location == D4.Location || D3.Location == D5.Location || D3.Location == D6.Location)
					{
						D3.Top -= 16;
					}
				}
			}
			else if (rand <= _num * 7)
			{
				if (O.Left + 1 < D4.Left)
				{
					D4.Left -= 35;
					if (D4.Location == D1.Location || D4.Location == D2.Location || D4.Location == D3.Location || D4.Location == D5.Location || D4.Location == D6.Location)
					{
						D4.Left += 35;
					}
				}
				else if (O.Left + 1 > D4.Left)
				{
					D4.Left += 35;
					if (D4.Location == D1.Location || D4.Location == D2.Location || D4.Location == D3.Location || D4.Location == D5.Location || D4.Location == D6.Location)
					{
						D4.Left -= 35;
					}
				}
			}
			else if (rand <= _num * 8)
			{
				if (O.Top + 1 < D4.Top)
				{
					D4.Top -= 16;
					if (D4.Location == D1.Location || D4.Location == D2.Location || D4.Location == D3.Location || D4.Location == D5.Location || D4.Location == D6.Location)
					{
						D4.Top += 16;
					}
				}
				else if (O.Top + 1 > D4.Top)
				{
					D4.Top += 16;
					if (D4.Location == D1.Location || D4.Location == D2.Location || D4.Location == D3.Location || D4.Location == D5.Location || D4.Location == D6.Location)
					{
						D4.Top -= 16;
					}
				}
			}
			else if (rand <= _num * 9)
			{
				if (O.Left + 1 < D5.Left)
				{
					D5.Left -= 35;
					if (D5.Location == D1.Location || D5.Location == D2.Location || D5.Location == D3.Location || D5.Location == D4.Location || D5.Location == D6.Location)
					{
						D5.Left += 35;
					}
				}
				else if (O.Left + 1 > D5.Left)
				{
					D5.Left += 35;
					if (D5.Location == D1.Location || D5.Location == D2.Location || D5.Location == D3.Location || D5.Location == D4.Location || D5.Location == D6.Location)
					{
						D5.Left -= 35;
					}
				}
			}
			else if (rand <= _num * 10)
			{
				if (O.Top + 1 < D5.Top)
				{
					D5.Top -= 16;
					if (D5.Location == D1.Location || D5.Location == D2.Location || D5.Location == D3.Location || D5.Location == D4.Location || D5.Location == D6.Location)
					{
						D5.Top += 16;
					}
				}
				else if (O.Top + 1 > D5.Top)
				{
					D5.Top += 16;
					if (D5.Location == D1.Location || D5.Location == D2.Location || D5.Location == D3.Location || D5.Location == D4.Location || D5.Location == D6.Location)
					{
						D5.Top -= 16;
					}
				}
			}
			else if (rand <= _num * 11)
			{
				if (O.Left + 1 < D6.Left)
				{
					D6.Left -= 35;
					if (D6.Location == D1.Location || D6.Location == D2.Location || D6.Location == D3.Location || D6.Location == D4.Location || D6.Location == D5.Location)
					{
						D6.Left += 35;
					}
				}
				else if (O.Left + 1 > D6.Left)
				{
					D6.Left += 35;
					if (D6.Location == D1.Location || D6.Location == D2.Location || D6.Location == D3.Location || D6.Location == D4.Location || D6.Location == D5.Location)
					{
						D6.Left -= 35;
					}
				}
			}
			else if (rand <= _num * 12)
			{
				if (O.Top + 1 < D6.Top)
				{
					D6.Top -= 16;
					if (D6.Location == D1.Location || D6.Location == D2.Location || D6.Location == D3.Location || D6.Location == D4.Location || D6.Location == D5.Location)
					{
						D6.Top += 16;
					}
				}
				else if (O.Top + 1 > D6.Top)
				{
					D6.Top += 16;
					if (D6.Location == D1.Location || D6.Location == D2.Location || D6.Location == D3.Location || D6.Location == D4.Location || D6.Location == D5.Location)
					{
						D6.Top -= 16;
					}
				}
			}
			if (O.Left + 1 == D1.Left && O.Top + 1 == D1.Top || O.Left + 1 == D2.Left && O.Top + 1 == D2.Top || O.Left + 1 == D3.Left && O.Top + 1 == D3.Top || O.Left + 1 == D4.Left && O.Top + 1 == D4.Top || O.Left + 1 == D5.Left && O.Top + 1 == D5.Top || O.Left + 1 == D6.Left && O.Top + 1 == D6.Top)
			{
				_Play = false;
				if (_Al <= _Yl)
				{
					if (_Al > 0)
					{
						Yl.Text = "10";
						if (_Al < 10)
							Yl.Text = _Al.ToString();
						Dl.Text = "1";
					}
				}
				else if (_Dl < 4)
				{
					Dl.Text = (_Dl + 1).ToString();
				}
				else
				{
					Yl.Text = "10";
					if ((101 - _Al) < 10)
						Yl.Text = (101 - _Al).ToString();
					Dl.Text = "1";
					Al.Text = (101 - _Al).ToString();
					if (_HomePlay)
					{
						if (_Ql == 1 || _Ql == 4)
						{
							Home.ForeColor = System.Drawing.Color.Black;
							Visitor.ForeColor = System.Drawing.Color.Orange;
						}
						else
						{
							Home.ForeColor = System.Drawing.Color.Orange;
							Visitor.ForeColor = System.Drawing.Color.Black;
						}
					}
					else
					{
						if (_Ql == 1 || _Ql == 4)
						{
							Home.ForeColor = System.Drawing.Color.Orange;
							Visitor.ForeColor = System.Drawing.Color.Black;
						}
						else
						{
							Home.ForeColor = System.Drawing.Color.Black;
							Visitor.ForeColor = System.Drawing.Color.Orange;
						}
					}
				}
			}
			return;
		}
		#endregion
		#region private void reset()
		private void reset()
        {
            _num = 2;
            _TM = 15;
            _TS = 0;
            _Begin = true;
            _HomePlay = true;
            _Play = false;
            _Punt = false;
            _Fg = false;
            _made = false;
            _Hl = 0;
            _Vl = 0;
            _Dl = 1;
            _Yl = 70;
            _Al = 80;
            _temp = 0;
            _Ql = 1;
            EZ.Visible = false;
            SZ.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            hh.Visible = true;
            vv.Visible = true;
            hv.Visible = false;
            vh.Visible = false;
            D1.Visible = true;
            D2.Visible = true;
            D3.Visible = true;
            D4.Visible = true;
            D5.Visible = true;
            D6.Visible = true;
			_Hl = 0;
			Hl.Text = _Hl.ToString();
			_Vl = 0;
			Vl.Text = _Vl.ToString();
			_Dl = 1;
			Dl.Text = _Dl.ToString();
			_Yl = 70;
			_Al = 80;
			Yl.Text = (_Al - _Yl).ToString();
			Al.Text = _Al.ToString();
			_HomePlay = true;
			_TM = 15;
			_TS = 0;
			Tl.Text = _TM.ToString()+":";
			if (_TS < 10)
				Tl.Text += "0";
			Tl.Text += _TS.ToString();
			_Ql = 1;
			Ql.Text = _Ql.ToString();
			O.Left = 50;
			O.Top = 87;
			D1.Left = 121;
			D1.Top = 72;
			D2.Left = 121;
			D2.Top = 88;
			D3.Left = 121;
			D3.Top = 104;
			D4.Left = 226;
			D4.Top = 72;
			D5.Left = 226;
			D5.Top = 104;
			D6.Left = 331;
			D6.Top = 88;
			Home.ForeColor = System.Drawing.Color.Orange;
			Visitor.ForeColor = System.Drawing.Color.Black;
			if (_temp == -1)
			{
				if (_Hl > _Vl)
					System.Windows.Forms.MessageBox.Show("Home team wins!","Home Team Wins!");
				else if (_Vl > _Hl)
					System.Windows.Forms.MessageBox.Show("Visitor team wins!","Visitor Team Wins!");
				else
					System.Windows.Forms.MessageBox.Show("Tie Game!","Tie Game!");
			}
		}
		#endregion
		#region private void menuNG_Click(object sender, System.EventArgs e)
		private void menuNG_Click(object sender, System.EventArgs e)
		{
			reset();
		}
		#endregion
		#region private void H_Click(object sender, System.EventArgs e)
		private void H_Click(object sender, System.EventArgs e)
		{
			help();
		}
		#endregion
		#region private void help()
		private void help()
		{
			Help HelpDialog = new Help(); 
			HelpDialog.ShowDialog();
		}
		#endregion
		#region private void HK_Click(object sender, System.EventArgs e)
		private void HK_Click(object sender, System.EventArgs e)
		{
            if (!_Fg || !_Play)
                hike();
		}
		#endregion
		#region private void hike()
		private void hike()
		{
			if (_Fg)
			{
				FG_Kicked();
			}
			else if (!_Play && !_Punt)
			{
				if (((_HomePlay && (_Ql == 1 || _Ql == 4)) || (!_HomePlay && (_Ql == 2 || _Ql == 3))) && _Al < 11 && _Al > 0)
				{
					EZ.Left = (_Al - 1) * 35 + 73;
					EZ.Visible = true;
				}
				else if (((!_HomePlay && (_Ql == 1 || _Ql == 4)) || (_HomePlay && (_Ql == 2 || _Ql == 3))) && _Al < 11 && _Al > 0)
				{
					EZ.Left = (_Al - 9) * -35 + 73;
					EZ.Visible = true;
				}
				else
				{
					EZ.Visible = false;
					SZ.Visible = false;
				}
				if (_Al > 100)
				{
					_HomePlay = !_HomePlay;
					if (_HomePlay)
					{
						Home.ForeColor = System.Drawing.Color.Orange;
						Visitor.ForeColor = System.Drawing.Color.Black;
					}
					else
					{
						Home.ForeColor = System.Drawing.Color.Black;
						Visitor.ForeColor = System.Drawing.Color.Orange;
					}
					if (_HomePlay)
					{
						_Hl += 2;
					}
					else
					{
						_Vl += 2;
					}
					_Dl = 1;
					_Yl = 70;
					_Al = 80;
					EZ.Visible = false;
				}
				else if (_Al == 0)
				{
					if (_HomePlay)
						_Hl += 7;
					else
						_Vl += 7;
					_HomePlay = !_HomePlay;
					if (_HomePlay)
					{
						Home.ForeColor = System.Drawing.Color.Orange;
						Visitor.ForeColor = System.Drawing.Color.Black;
					}
					else
					{
						Home.ForeColor = System.Drawing.Color.Black;
						Visitor.ForeColor = System.Drawing.Color.Orange;
					}
					_Dl = 1;
					_Yl = 70;
					_Al = 80;
					EZ.Visible = false;
				}
				else if (_Al <= _Yl)
				{
					_Yl = _Al - 10;
					if (_Al < 10)
					{
						_Yl = 0;
					}
					_Dl = 1;
				}
				else if (_Dl == 4)
				{
					_HomePlay = !_HomePlay;
					_Dl = 1;
					_Al = 101 - _Al;
					_Yl = _Al - 10;
					if (_Al < 10)
					{
						_Yl = 0;
					}
					if (_HomePlay && _Al < 11 && _Al > 0)
					{
						if (_Ql == 1 || _Ql == 4)
							EZ.Left = (_Al - 1) * 35 + 73;
						else
							EZ.Left = (_Al - 9) * -35 + 73;
						EZ.Visible = true;
					}
					else if (!_HomePlay && _Al < 11 && _Al > 0)
					{
						if (_Ql == 1 || _Ql == 4)
							EZ.Left = (_Al - 9) * -35 + 73;
						else
							EZ.Left = (_Al - 1) * 35 + 73;
						EZ.Visible = true;
					}
					else
					{
						EZ.Visible = false;
						SZ.Visible = false;
					}
				}
				else
				{
					if (_Begin)
						_Begin = !_Begin;
					else
						_Dl++;
				}
				Hl.Text = _Hl.ToString();
				Vl.Text = _Vl.ToString();
				Dl.Text = _Dl.ToString();
				Yl.Text = (_Al - _Yl).ToString();
				Al.Text = _Al.ToString();
				Tl.Text = _TM.ToString()+":";
				if (_TS < 10)
					Tl.Text += "0";
				Tl.Text += _TS.ToString();
				Ql.Text = _Ql.ToString();
				if ((_HomePlay && (_Ql == 1 || _Ql == 4)) || (!_HomePlay && (_Ql == 2 || _Ql == 3)))
				{
					O.Left = 50;
					O.Top = 87;
					D1.Left = 121;
					D1.Top = 72;
					D2.Left = 121;
					D2.Top = 88;
					D3.Left = 121;
					D3.Top = 104;
					D4.Left = 226;
					D4.Top = 72;
					D5.Left = 226;
					D5.Top = 104;
					D6.Left = 331;
					D6.Top = 88;
				}
				else
				{
					O.Left = 365;
					O.Top = 87;
					D1.Left = 296;
					D1.Top = 72;
					D2.Left = 296;
					D2.Top = 88;
					D3.Left = 296;
					D3.Top = 104;
					D4.Left = 191;
					D4.Top = 72;
					D5.Left = 191;
					D5.Top = 104;
					D6.Left = 86;
					D6.Top = 88;
				}
				if (_Ql == 1 || _Ql == 4)
				{
					hh.Visible = true;
					vv.Visible = true;
					hv.Visible = false;
					vh.Visible = false;
				}
				else
				{
					hh.Visible = false;
					vv.Visible = false;
					hv.Visible = true;
					vh.Visible = true;
				}
				if (_TS == 0 && _TM == 0)
				{
					if (_Ql < 4)
					{
						_Ql++;
						_TM = 15;
						_Play = true;
					}
					else
					{
						_temp = -1;
						reset();
					}
					if (_Ql == 3)
					{
						_HomePlay = false;
						_Dl = 1;
						_Yl = 70;
						_Al = 80;
						_Play = true;
					}
				}
				else
					_Play = true;
				_temp = 0;
			}
		}
		#endregion
		#region private void Form1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		private void Form1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{

            if (e.KeyValue == 32 && !_Play && !_Punt)
                hike();
			if (!_Play && !_Punt && !_Fg)
			{
				if (e.KeyValue == 80)
					punt();
				else if (e.KeyValue == 72)
					help();
				else if (e.KeyValue == 70)
					fieldGoal();
				else if (e.KeyValue == 78)
					reset();
				else if (e.KeyValue == 49)
				{
					_num = 1;
					Hard.Checked = false;
					Med.Checked = false;
					Easy.Checked = true;
				}
				else if (e.KeyValue == 50)
				{
					_num = 3;
					Hard.Checked = false;
					Med.Checked = true;
					Easy.Checked = false;
				}
				else if (e.KeyValue == 51)
				{
					_num = 5;
					Hard.Checked = true;
					Med.Checked = false;
					Easy.Checked = false;
				}
			}
			if (_Play && !_Punt && !_Fg)
			{
				if (e.KeyValue == 37)//left
				{
					if (((_HomePlay && (_Ql == 1 || _Ql == 4)) || (!_HomePlay && (_Ql == 2 || _Ql == 3))) && _Al < 110)
					{
						if (O.Left == 50)
						{
							O.Left = 365;
							if (_Al > 89 && _Al < 101)
							{
								SZ.Left = (_Al - 91) * 35 + 73;
								SZ.Visible = true;
							}
							else
							{
								SZ.Visible = false;
								EZ.Visible = false;
							}
						}
						else
						{
							O.Left -= 35;
						}
						_Al++;
					}
					else if(((!_HomePlay && (_Ql == 1 || _Ql == 4)) || (_HomePlay && (_Ql == 2 || _Ql == 3))) && _Al > 0)
					{
						if (O.Left == 50)
						{
							O.Left = 365;
							if (_Al < 12)
							{
								EZ.Left = (_Al - 10) * -35 + 73;
								EZ.Visible = true;
							}
							else if(_Al > 100)
							{
								SZ.Left = (_Al - 110) * -35 + 73;
								SZ.Visible = true;
							}
							else
							{
								EZ.Visible = false;
								SZ.Visible = false;
							}
						}
						else
						{
							O.Left -= 35;
						}
						_Al--;
					}
					
				}
				else if (e.KeyValue == 38)//up
				{
					if (O.Top != 71)
					{
						O.Top -= 16;
					}
				}
				else if (e.KeyValue == 39)//right
				{
					if (((_HomePlay && (_Ql == 1 || _Ql == 4)) || (!_HomePlay && (_Ql == 2 || _Ql == 3))) && _Al > 0)
					{
						if (O.Left == 365)
						{
							O.Left = 50;
							if (_Al < 12)
							{
								EZ.Left = (_Al - 2) * 35 + 73;
								EZ.Visible = true;
							}
							else if(_Al > 100)
							{
								SZ.Left = (_Al - 102) * 35 + 73;
								SZ.Visible = true;
							}
							else
							{
								EZ.Visible = false;
								SZ.Visible = false;
							}
						}
						else
						{
							O.Left += 35;
						}
						_Al--;
					}
					else if (((!_HomePlay && (_Ql == 1 || _Ql == 4)) || (_HomePlay && (_Ql == 2 || _Ql == 3))) && _Al < 110)
					{
						if (O.Left == 365)
						{
							O.Left = 50;
							if (_Al > 89 && _Al < 101)
							{
								SZ.Left = (_Al - 99) * -35 + 73;
								SZ.Visible = true;
							}
							else
							{
								SZ.Visible = false;
								EZ.Visible = false;
							}
						}
						else
						{
							O.Left += 35;
						}
						_Al++;
					}
					
				}
				else if (e.KeyValue == 40)//down
				{
					if (O.Top != 103)
						O.Top += 16;
				}
				if (_Al >= _Yl)
				{
					Yl.Text = (_Al - _Yl).ToString();
				}
				Al.Text = _Al.ToString();
				if (_Al == 0 || O.Left + 1 == D1.Left && O.Top + 1 == D1.Top || O.Left + 1 == D2.Left && O.Top + 1 == D2.Top || O.Left + 1 == D3.Left && O.Top + 1 == D3.Top || O.Left + 1 == D4.Left && O.Top + 1 == D4.Top || O.Left + 1 == D5.Left && O.Top + 1 == D5.Top || O.Left + 1 == D6.Left && O.Top + 1 == D6.Top)
				{
					_Play = false;
					if (_Al <= _Yl)
					{
						if (_Al > 0)
						{
							Yl.Text = "10";
							if (_Al < 10)
								Yl.Text = _Al.ToString();
							Dl.Text = "1";
						}
						else
						{
							Al.Text = "80";
							Yl.Text = "10";
							Dl.Text = "1";
							if (_HomePlay)
							{
								Home.ForeColor = System.Drawing.Color.Black;
								Visitor.ForeColor = System.Drawing.Color.Orange;
								Hl.Text = (_Hl + 7).ToString();
							}
							else
							{
								Home.ForeColor = System.Drawing.Color.Orange;
								Visitor.ForeColor = System.Drawing.Color.Black;
								Vl.Text = (_Vl + 7).ToString();
							}
						}
					}
					else if (_Dl < 4)
					{
						Dl.Text = (_Dl + 1).ToString();
					}
					else
					{
						Yl.Text = "10";
						if ((101 - _Al) < 10)
							Yl.Text = (101 - _Al).ToString();
						Dl.Text = "1";
						Al.Text = (101 - _Al).ToString();
						if (_HomePlay)
						{
							Home.ForeColor = System.Drawing.Color.Black;
							Visitor.ForeColor = System.Drawing.Color.Orange;
						}
						else
						{
							Home.ForeColor = System.Drawing.Color.Orange;
							Visitor.ForeColor = System.Drawing.Color.Black;
						}
					}
				}
			}
		}
		#endregion
		#region private void menuFG_Click(object sender, System.EventArgs e)
		private void menuFG_Click(object sender, System.EventArgs e)
		{
			fieldGoal();
		}
		#endregion
		#region private void fieldGoal()
		private void fieldGoal()
		{
			if (!_Play && !_Punt && !_Fg && _Al != 0)
			{
				EZ.Visible = false;
				SZ.Visible = false;
				Random randomClass = new Random();
				int rand = randomClass.Next(0,100);
				if (_Al > 60)
				{
					if (rand < 1)
					{
						_made = true;
					}
				}
				else if (_Al > 50)
				{
					if (rand < 10)
					{
						_made = true;
					}
				}
				else if (_Al > 40)
				{
					if (rand < 30)
					{
						_made = true;
					}
				}
				else if (_Al > 30)
				{
					if (rand < 60)
					{
						_made = true;
					}
				}
				else if (_Al > 20)
				{
					if (rand < 80)
					{
						_made = true;
					}
				}
				else
				{
					if (rand < 95)
					{
						_made = true;
					}
				}
				D1.Visible = false;
				D2.Visible = false;
				D3.Visible = false;
				D4.Visible = false;
				D5.Visible = false;
				D6.Visible = false;
				if ((_HomePlay && (_Ql == 1 || _Ql == 4)) || (!_HomePlay && (_Ql == 2 || _Ql == 3)))
				{
					vv.Visible = false;
					hv.Visible = false;
					pictureBox1.Visible = true;
					pictureBox2.Visible = true;
					pictureBox3.Visible = true;
					pictureBox4.Visible = true;
				}
				else
				{
					vh.Visible = false;
					hh.Visible = false;
					pictureBox5.Visible = true;
					pictureBox6.Visible = true;
					pictureBox7.Visible = true;
					pictureBox8.Visible = true;
				}
				_temp = _Al;
				O.Top = 87;
				O.Left = ((!_HomePlay && (_Ql == 1 || _Ql == 4)) || (_HomePlay && (_Ql == 2 || _Ql == 3)))?(_Al % 10) * 35 + 50:(_Al % 10) * -35 + 365;
				_Fg = true;
                _Play = true;
			}
		}
		#endregion
		#region private void FG_Kicked()
		private void FG_Kicked()
		{
			_Fg = false;
			pictureBox1.Visible = false;
			pictureBox2.Visible = false;
			pictureBox3.Visible = false;
			pictureBox4.Visible = false;
			pictureBox5.Visible = false;
			pictureBox6.Visible = false;
			pictureBox7.Visible = false;
			pictureBox8.Visible = false;
			if (_Ql == 1 || _Ql == 4)
			{
				hh.Visible = true;
				vv.Visible = true;
			}
			else
			{
				hv.Visible = true;
				vh.Visible = true;
			}
			_HomePlay = !_HomePlay;
			if (_HomePlay)
			{
				Home.ForeColor = System.Drawing.Color.Orange;
				Visitor.ForeColor = System.Drawing.Color.Black;
			}
			else
			{
				Home.ForeColor = System.Drawing.Color.Black;
				Visitor.ForeColor = System.Drawing.Color.Orange;
			}
			_Dl = 1;
			if (_made)
			{
				if (_HomePlay)
				{
					_Vl += 3;
				}
				else
				{
					_Hl += 3;
				}
				Hl.Text = _Hl.ToString();
				Vl.Text = _Vl.ToString();
				_Yl = 70;
				_Al = 80;
			}
			else
			{
				_Al = 100 - _Al;
				_Yl = _Al - 10;
				if (_Al < 10)
				{
					_Yl = 0;
				}
			}
			D1.Visible = true;
			D2.Visible = true;
			D3.Visible = true;
			D4.Visible = true;
			D5.Visible = true;
			D6.Visible = true;
			Dl.Text = _Dl.ToString();
			Yl.Text = (_Al - _Yl).ToString();
			Al.Text = _Al.ToString();
			if ((_HomePlay && (_Ql == 1 || _Ql == 4)) || (!_HomePlay && (_Ql == 2 || _Ql == 3)))
			{
				O.Left = 50;
				O.Top = 87;
				D1.Left = 121;
				D1.Top = 72;
				D2.Left = 121;
				D2.Top = 88;
				D3.Left = 121;
				D3.Top = 104;
				D4.Left = 226;
				D4.Top = 72;
				D5.Left = 226;
				D5.Top = 104;
				D6.Left = 331;
				D6.Top = 88;
			}
			else
			{
				O.Left = 365;
				O.Top = 87;
				D1.Left = 296;
				D1.Top = 72;
				D2.Left = 296;
				D2.Top = 88;
				D3.Left = 296;
				D3.Top = 104;
				D4.Left = 191;
				D4.Top = 72;
				D5.Left = 191;
				D5.Top = 104;
				D6.Left = 86;
				D6.Top = 88;
			}
			_made = false;
			_Play = true;
		}
		#endregion
		#region private void menuP_Click(object sender, System.EventArgs e)
		private void menuP_Click(object sender, System.EventArgs e)
		{
			punt();
		}
		#endregion
		#region private void punt()
		private void punt()
		{
			if (!_Play && !_Punt && !_Fg && _Al != 0)
			{
				D1.Visible = false;
				D2.Visible = false;
				D3.Visible = false;
				D4.Visible = false;
				D5.Visible = false;
				D6.Visible = false;
				O.Top = 87;
				O.Left = ((!_HomePlay && (_Ql == 1 || _Ql == 4)) || (_HomePlay && (_Ql == 2 || _Ql == 3)))?(_Al % 10) * 35 + 50:(_Al % 10) * -35 + 365;
				_Punt = true;
			}
		}
		#endregion
		#region private void P_Click()
		private void P_Click()
		{
			_HomePlay = !_HomePlay;
			if (_HomePlay)
			{
				Home.ForeColor = System.Drawing.Color.Orange;
				Visitor.ForeColor = System.Drawing.Color.Black;
			}
			else
			{
				Home.ForeColor = System.Drawing.Color.Black;
				Visitor.ForeColor = System.Drawing.Color.Orange;
			}
			_Dl = 1;
			_Yl = 70;
			_Al = 80;
			Dl.Text = _Dl.ToString();
			Yl.Text = (_Al - _Yl).ToString();
			Al.Text = _Al.ToString();
			if ((_HomePlay && (_Ql == 1 || _Ql == 4)) || (!_HomePlay && (_Ql == 2 || _Ql == 3)))
			{
				O.Left = 50;
				O.Top = 87;
				D1.Left = 121;
				D1.Top = 72;
				D2.Left = 121;
				D2.Top = 88;
				D3.Left = 121;
				D3.Top = 104;
				D4.Left = 226;
				D4.Top = 72;
				D5.Left = 226;
				D5.Top = 104;
				D6.Left = 331;
				D6.Top = 88;
			}
			else
			{
				O.Left = 365;
				O.Top = 87;
				D1.Left = 296;
				D1.Top = 72;
				D2.Left = 296;
				D2.Top = 88;
				D3.Left = 296;
				D3.Top = 104;
				D4.Left = 191;
				D4.Top = 72;
				D5.Left = 191;
				D5.Top = 104;
				D6.Left = 86;
				D6.Top = 88;
			}
			_Punt = false;
			_Play = true;
			
		}
		#endregion
		#region private void timer1_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
		private void timer1_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
		{
			if (_Play && !_Fg)
			{
				if (_temp == 3)
				{
					if (_TS == 0)
					{
						if (_TM != 0)
						{
							_TM--;
							_TS = 59;
						}
					}
					else
					{
						_TS--;
					}
					Tl.Text = _TM.ToString() + ":";
					if (_TS < 10)
						Tl.Text += "0";
					Tl.Text += _TS.ToString();
					_temp = 0;
				}
				else
				{
					_temp++;
				}
				play();
			}
			if (_Punt)
			{
				if (_Al > 20)
				{
					_Al--;
					Al.Text = _Al.ToString();
					if ((_HomePlay && (_Ql == 1 || _Ql == 4)) || (!_HomePlay && (_Ql == 2 || _Ql == 3)))
					{
						if (O.Left == 365)
						{
							O.Left = 50;
						}
						else
						{
							O.Left += 35;
						}
					}
					else
					{
						if (O.Left == 50)
						{
							O.Left = 365;
						}
						else
						{
							O.Left -= 35;
						}
					}
				}
				else
				{
					D1.Visible = true;
					D2.Visible = true;
					D3.Visible = true;
					D4.Visible = true;
					D5.Visible = true;
					D6.Visible = true;
					P_Click();
				}
			}
			if (_Fg)
			{
				if (_temp > 1)
				{
					_temp--;
					Al.Text = _temp.ToString();
					if ((_HomePlay && (_Ql == 1 || _Ql == 4)) || (!_HomePlay && (_Ql == 2 || _Ql == 3)))
					{
						if (O.Left == 365)
						{
							O.Left = 50;
						}
						else
						{
							O.Left += 35;
						}
					}
					else
					{
						if (O.Left == 50)
						{
							O.Left = 365;
						}
						else
						{
							O.Left -= 35;
						}
					}
				}
				else if (_temp == 1)
				{
					_temp = 0;
					Al.Text = _temp.ToString();
					if (_made)
					{
						O.Left = ((_HomePlay && (_Ql == 1 || _Ql == 4)) || (!_HomePlay && (_Ql == 2 || _Ql == 3)))?365:50;
						if (_HomePlay)
						{
							Hl.Text = (_Hl + 3).ToString();
							Home.ForeColor = System.Drawing.Color.Black;
							Visitor.ForeColor = System.Drawing.Color.Orange;
						}
						else
						{
							Vl.Text = (_Vl + 3).ToString();
							Home.ForeColor = System.Drawing.Color.Orange;
							Visitor.ForeColor = System.Drawing.Color.Black;
						}
                        _Play = false;
					}
					else
					{
						Random rnd = new Random();
						int rand = rnd.Next(1,2);
						O.Top = (rand == 1)?72:102;
						O.Left = ((_HomePlay && (_Ql == 1 || _Ql == 4)) || (!_HomePlay && (_Ql == 2 || _Ql == 3)))?365:50;
                        _Play = false;
					}
				}
			}
		}
		#endregion
		#region private void Hard_Click(object sender, System.EventArgs e)
		private void Hard_Click(object sender, System.EventArgs e)
		{
			_num = 5;
			Hard.Checked = true;
			Med.Checked = false;
			Easy.Checked = false;
		}
		#endregion
		#region private void Med_Click(object sender, System.EventArgs e)
		private void Med_Click(object sender, System.EventArgs e)
		{
			_num = 3;
			Hard.Checked = false;
			Med.Checked = true;
			Easy.Checked = false;
		}
		#endregion
		#region private void Easy_Click(object sender, System.EventArgs e)
		private void Easy_Click(object sender, System.EventArgs e)
		{
			_num = 1;
			Hard.Checked = false;
			Med.Checked = false;
			Easy.Checked = true;
		}
		#endregion
		#region private void Form1_SizeChanged(object sender, System.EventArgs e)
		private void Form1_SizeChanged(object sender, System.EventArgs e)
		{
			this.Height = 199;
			this.Width = 437;
		}
		#endregion
	}
}
