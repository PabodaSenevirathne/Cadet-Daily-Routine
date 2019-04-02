namespace CadetSystem
{
    partial class FrmOfficerOccurrence
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbllogger = new System.Windows.Forms.Label();
            this.pbclose = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblcadet = new System.Windows.Forms.Label();
            this.lblannouncements = new System.Windows.Forms.Label();
            this.lblreports = new System.Windows.Forms.Label();
            this.pbreports = new System.Windows.Forms.PictureBox();
            this.lbllogout = new System.Windows.Forms.Label();
            this.lblmeals = new System.Windows.Forms.Label();
            this.lblrollcall = new System.Windows.Forms.Label();
            this.lbloccurrence = new System.Windows.Forms.Label();
            this.lblattendance = new System.Windows.Forms.Label();
            this.lblparade = new System.Windows.Forms.Label();
            this.lblprofile = new System.Windows.Forms.Label();
            this.lblhome = new System.Windows.Forms.Label();
            this.pblogout = new System.Windows.Forms.PictureBox();
            this.pbmeals = new System.Windows.Forms.PictureBox();
            this.pbrollcall = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pboccurrence = new System.Windows.Forms.PictureBox();
            this.pbattendance = new System.Windows.Forms.PictureBox();
            this.pbparade = new System.Windows.Forms.PictureBox();
            this.pbprofile = new System.Windows.Forms.PictureBox();
            this.pbhome = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtpmeals = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblsubdate = new System.Windows.Forms.Label();
            this.lblsubname = new System.Windows.Forms.Label();
            this.lblsubon = new System.Windows.Forms.Label();
            this.lblsubby = new System.Windows.Forms.Label();
            this.btnview = new System.Windows.Forms.Button();
            this.cmbintake = new System.Windows.Forms.ComboBox();
            this.lblintake = new System.Windows.Forms.Label();
            this.dgoccurrence = new System.Windows.Forms.DataGridView();
            this.dtpoccurrence = new System.Windows.Forms.DateTimePicker();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbclose)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbreports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pblogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmeals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbrollcall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboccurrence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbattendance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbparade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbprofile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbhome)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgoccurrence)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(129)))), ((int)(((byte)(198)))));
            this.panel2.Controls.Add(this.lbllogger);
            this.panel2.Controls.Add(this.pbclose);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1300, 75);
            this.panel2.TabIndex = 12;
            // 
            // lbllogger
            // 
            this.lbllogger.AutoSize = true;
            this.lbllogger.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold);
            this.lbllogger.ForeColor = System.Drawing.Color.White;
            this.lbllogger.Location = new System.Drawing.Point(20, 25);
            this.lbllogger.Name = "lbllogger";
            this.lbllogger.Size = new System.Drawing.Size(90, 29);
            this.lbllogger.TabIndex = 13;
            this.lbllogger.Text = "Name";
            // 
            // pbclose
            // 
            this.pbclose.BackColor = System.Drawing.Color.Red;
            this.pbclose.Image = global::CadetSystem.Properties.Resources.imgclose;
            this.pbclose.Location = new System.Drawing.Point(1270, 5);
            this.pbclose.Name = "pbclose";
            this.pbclose.Size = new System.Drawing.Size(24, 24);
            this.pbclose.TabIndex = 11;
            this.pbclose.TabStop = false;
            this.pbclose.Click += new System.EventHandler(this.pbclose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(129)))), ((int)(((byte)(198)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblcadet);
            this.panel1.Controls.Add(this.lblannouncements);
            this.panel1.Controls.Add(this.lblreports);
            this.panel1.Controls.Add(this.pbreports);
            this.panel1.Controls.Add(this.lbllogout);
            this.panel1.Controls.Add(this.lblmeals);
            this.panel1.Controls.Add(this.lblrollcall);
            this.panel1.Controls.Add(this.lbloccurrence);
            this.panel1.Controls.Add(this.lblattendance);
            this.panel1.Controls.Add(this.lblparade);
            this.panel1.Controls.Add(this.lblprofile);
            this.panel1.Controls.Add(this.lblhome);
            this.panel1.Controls.Add(this.pblogout);
            this.panel1.Controls.Add(this.pbmeals);
            this.panel1.Controls.Add(this.pbrollcall);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pboccurrence);
            this.panel1.Controls.Add(this.pbattendance);
            this.panel1.Controls.Add(this.pbparade);
            this.panel1.Controls.Add(this.pbprofile);
            this.panel1.Controls.Add(this.pbhome);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(0, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 625);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CadetSystem.Properties.Resources.message_icon_2152;
            this.pictureBox2.Location = new System.Drawing.Point(25, 450);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CadetSystem.Properties.Resources.profile_icon_small;
            this.pictureBox1.Location = new System.Drawing.Point(25, 400);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblcadet
            // 
            this.lblcadet.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblcadet.ForeColor = System.Drawing.Color.White;
            this.lblcadet.Location = new System.Drawing.Point(70, 400);
            this.lblcadet.Name = "lblcadet";
            this.lblcadet.Size = new System.Drawing.Size(188, 35);
            this.lblcadet.TabIndex = 25;
            this.lblcadet.Text = "Cadet Details";
            this.lblcadet.Click += new System.EventHandler(this.lblcadet_Click);
            // 
            // lblannouncements
            // 
            this.lblannouncements.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblannouncements.ForeColor = System.Drawing.Color.White;
            this.lblannouncements.Location = new System.Drawing.Point(70, 450);
            this.lblannouncements.Name = "lblannouncements";
            this.lblannouncements.Size = new System.Drawing.Size(227, 38);
            this.lblannouncements.TabIndex = 24;
            this.lblannouncements.Text = "Announcements";
            this.lblannouncements.Click += new System.EventHandler(this.lblannouncements_Click);
            // 
            // lblreports
            // 
            this.lblreports.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblreports.ForeColor = System.Drawing.Color.White;
            this.lblreports.Location = new System.Drawing.Point(118, 563);
            this.lblreports.Name = "lblreports";
            this.lblreports.Size = new System.Drawing.Size(127, 37);
            this.lblreports.TabIndex = 22;
            this.lblreports.Text = "Reports";
            this.lblreports.Visible = false;
            this.lblreports.Click += new System.EventHandler(this.lblreports_Click);
            // 
            // pbreports
            // 
            this.pbreports.Image = global::CadetSystem.Properties.Resources.task_report_disabled;
            this.pbreports.Location = new System.Drawing.Point(41, 563);
            this.pbreports.Name = "pbreports";
            this.pbreports.Size = new System.Drawing.Size(32, 32);
            this.pbreports.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbreports.TabIndex = 21;
            this.pbreports.TabStop = false;
            this.pbreports.Visible = false;
            this.pbreports.Click += new System.EventHandler(this.pbreports_Click);
            // 
            // lbllogout
            // 
            this.lbllogout.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold);
            this.lbllogout.ForeColor = System.Drawing.Color.White;
            this.lbllogout.Location = new System.Drawing.Point(70, 500);
            this.lbllogout.Name = "lbllogout";
            this.lbllogout.Size = new System.Drawing.Size(127, 40);
            this.lbllogout.TabIndex = 17;
            this.lbllogout.Text = "Logout";
            this.lbllogout.Click += new System.EventHandler(this.lbllogout_Click);
            // 
            // lblmeals
            // 
            this.lblmeals.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblmeals.ForeColor = System.Drawing.Color.White;
            this.lblmeals.Location = new System.Drawing.Point(70, 350);
            this.lblmeals.Name = "lblmeals";
            this.lblmeals.Size = new System.Drawing.Size(106, 37);
            this.lblmeals.TabIndex = 16;
            this.lblmeals.Text = "Meals";
            this.lblmeals.Click += new System.EventHandler(this.lblmeals_Click);
            // 
            // lblrollcall
            // 
            this.lblrollcall.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblrollcall.ForeColor = System.Drawing.Color.White;
            this.lblrollcall.Location = new System.Drawing.Point(70, 300);
            this.lblrollcall.Name = "lblrollcall";
            this.lblrollcall.Size = new System.Drawing.Size(127, 32);
            this.lblrollcall.TabIndex = 15;
            this.lblrollcall.Text = "Roll Call";
            this.lblrollcall.Click += new System.EventHandler(this.lblrollcall_Click);
            // 
            // lbloccurrence
            // 
            this.lbloccurrence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(99)))), ((int)(((byte)(182)))));
            this.lbloccurrence.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold);
            this.lbloccurrence.ForeColor = System.Drawing.Color.White;
            this.lbloccurrence.Location = new System.Drawing.Point(70, 250);
            this.lbloccurrence.Name = "lbloccurrence";
            this.lbloccurrence.Size = new System.Drawing.Size(175, 34);
            this.lbloccurrence.TabIndex = 14;
            this.lbloccurrence.Text = "Occurrence";
            // 
            // lblattendance
            // 
            this.lblattendance.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblattendance.ForeColor = System.Drawing.Color.White;
            this.lblattendance.Location = new System.Drawing.Point(70, 200);
            this.lblattendance.Name = "lblattendance";
            this.lblattendance.Size = new System.Drawing.Size(175, 33);
            this.lblattendance.TabIndex = 13;
            this.lblattendance.Text = "Attendance";
            this.lblattendance.Click += new System.EventHandler(this.lblattendance_Click);
            // 
            // lblparade
            // 
            this.lblparade.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblparade.ForeColor = System.Drawing.Color.White;
            this.lblparade.Location = new System.Drawing.Point(70, 150);
            this.lblparade.Name = "lblparade";
            this.lblparade.Size = new System.Drawing.Size(194, 35);
            this.lblparade.TabIndex = 12;
            this.lblparade.Text = "Perade State";
            this.lblparade.Click += new System.EventHandler(this.lblparade_Click);
            // 
            // lblprofile
            // 
            this.lblprofile.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblprofile.ForeColor = System.Drawing.Color.White;
            this.lblprofile.Location = new System.Drawing.Point(70, 100);
            this.lblprofile.Name = "lblprofile";
            this.lblprofile.Size = new System.Drawing.Size(113, 38);
            this.lblprofile.TabIndex = 11;
            this.lblprofile.Text = "Profile";
            this.lblprofile.Click += new System.EventHandler(this.lblprofile_Click);
            // 
            // lblhome
            // 
            this.lblhome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(129)))), ((int)(((byte)(198)))));
            this.lblhome.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblhome.ForeColor = System.Drawing.Color.White;
            this.lblhome.Location = new System.Drawing.Point(70, 50);
            this.lblhome.Name = "lblhome";
            this.lblhome.Size = new System.Drawing.Size(91, 36);
            this.lblhome.TabIndex = 10;
            this.lblhome.Text = "Home";
            this.lblhome.Click += new System.EventHandler(this.lblhome_Click);
            // 
            // pblogout
            // 
            this.pblogout.Image = global::CadetSystem.Properties.Resources.sidebarlogout;
            this.pblogout.Location = new System.Drawing.Point(25, 500);
            this.pblogout.Name = "pblogout";
            this.pblogout.Size = new System.Drawing.Size(32, 32);
            this.pblogout.TabIndex = 9;
            this.pblogout.TabStop = false;
            this.pblogout.Click += new System.EventHandler(this.pblogout_Click);
            // 
            // pbmeals
            // 
            this.pbmeals.Image = global::CadetSystem.Properties.Resources.sidebarmeals;
            this.pbmeals.Location = new System.Drawing.Point(25, 350);
            this.pbmeals.Name = "pbmeals";
            this.pbmeals.Size = new System.Drawing.Size(32, 32);
            this.pbmeals.TabIndex = 8;
            this.pbmeals.TabStop = false;
            this.pbmeals.Click += new System.EventHandler(this.pbmeals_Click);
            // 
            // pbrollcall
            // 
            this.pbrollcall.Image = global::CadetSystem.Properties.Resources.sidebarrollcall;
            this.pbrollcall.Location = new System.Drawing.Point(25, 300);
            this.pbrollcall.Name = "pbrollcall";
            this.pbrollcall.Size = new System.Drawing.Size(32, 32);
            this.pbrollcall.TabIndex = 7;
            this.pbrollcall.TabStop = false;
            this.pbrollcall.Click += new System.EventHandler(this.pbrollcall_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(25, 300);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(32, 32);
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            // 
            // pboccurrence
            // 
            this.pboccurrence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(99)))), ((int)(((byte)(182)))));
            this.pboccurrence.Image = global::CadetSystem.Properties.Resources.sidebaroccurrence;
            this.pboccurrence.Location = new System.Drawing.Point(25, 250);
            this.pboccurrence.Name = "pboccurrence";
            this.pboccurrence.Size = new System.Drawing.Size(32, 32);
            this.pboccurrence.TabIndex = 5;
            this.pboccurrence.TabStop = false;
            // 
            // pbattendance
            // 
            this.pbattendance.Image = global::CadetSystem.Properties.Resources.sidebarattendance;
            this.pbattendance.Location = new System.Drawing.Point(25, 200);
            this.pbattendance.Name = "pbattendance";
            this.pbattendance.Size = new System.Drawing.Size(32, 32);
            this.pbattendance.TabIndex = 4;
            this.pbattendance.TabStop = false;
            this.pbattendance.Click += new System.EventHandler(this.pbattendance_Click);
            // 
            // pbparade
            // 
            this.pbparade.Image = global::CadetSystem.Properties.Resources.sidebarperadestate;
            this.pbparade.Location = new System.Drawing.Point(25, 150);
            this.pbparade.Name = "pbparade";
            this.pbparade.Size = new System.Drawing.Size(32, 32);
            this.pbparade.TabIndex = 3;
            this.pbparade.TabStop = false;
            this.pbparade.Click += new System.EventHandler(this.pbparade_Click);
            // 
            // pbprofile
            // 
            this.pbprofile.Image = global::CadetSystem.Properties.Resources.sidebarprofile;
            this.pbprofile.Location = new System.Drawing.Point(25, 100);
            this.pbprofile.Name = "pbprofile";
            this.pbprofile.Size = new System.Drawing.Size(32, 32);
            this.pbprofile.TabIndex = 2;
            this.pbprofile.TabStop = false;
            this.pbprofile.Click += new System.EventHandler(this.pbprofile_Click);
            // 
            // pbhome
            // 
            this.pbhome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(129)))), ((int)(((byte)(198)))));
            this.pbhome.Image = global::CadetSystem.Properties.Resources.sidebarhome;
            this.pbhome.Location = new System.Drawing.Point(25, 50);
            this.pbhome.Name = "pbhome";
            this.pbhome.Size = new System.Drawing.Size(32, 32);
            this.pbhome.TabIndex = 1;
            this.pbhome.TabStop = false;
            this.pbhome.Click += new System.EventHandler(this.pbhome_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 3);
            this.panel3.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(99)))), ((int)(((byte)(182)))));
            this.panel5.Location = new System.Drawing.Point(0, 242);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(300, 48);
            this.panel5.TabIndex = 18;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(300, 75);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1050, 3);
            this.panel4.TabIndex = 14;
            // 
            // dtpmeals
            // 
            this.dtpmeals.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpmeals.Location = new System.Drawing.Point(497, 336);
            this.dtpmeals.Name = "dtpmeals";
            this.dtpmeals.Size = new System.Drawing.Size(305, 27);
            this.dtpmeals.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblsubdate);
            this.groupBox1.Controls.Add(this.lblsubname);
            this.groupBox1.Controls.Add(this.lblsubon);
            this.groupBox1.Controls.Add(this.lblsubby);
            this.groupBox1.Controls.Add(this.btnview);
            this.groupBox1.Controls.Add(this.cmbintake);
            this.groupBox1.Controls.Add(this.lblintake);
            this.groupBox1.Controls.Add(this.dgoccurrence);
            this.groupBox1.Controls.Add(this.dtpoccurrence);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(330, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(940, 575);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Occurrence";
            // 
            // lblsubdate
            // 
            this.lblsubdate.AutoSize = true;
            this.lblsubdate.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubdate.Location = new System.Drawing.Point(235, 542);
            this.lblsubdate.Name = "lblsubdate";
            this.lblsubdate.Size = new System.Drawing.Size(67, 20);
            this.lblsubdate.TabIndex = 56;
            this.lblsubdate.Text = "label4";
            this.lblsubdate.Visible = false;
            // 
            // lblsubname
            // 
            this.lblsubname.AutoSize = true;
            this.lblsubname.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubname.Location = new System.Drawing.Point(235, 502);
            this.lblsubname.Name = "lblsubname";
            this.lblsubname.Size = new System.Drawing.Size(67, 20);
            this.lblsubname.TabIndex = 53;
            this.lblsubname.Text = "label4";
            this.lblsubname.Visible = false;
            // 
            // lblsubon
            // 
            this.lblsubon.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblsubon.Location = new System.Drawing.Point(65, 540);
            this.lblsubon.Name = "lblsubon";
            this.lblsubon.Size = new System.Drawing.Size(176, 26);
            this.lblsubon.TabIndex = 55;
            this.lblsubon.Text = "Submitted On ";
            // 
            // lblsubby
            // 
            this.lblsubby.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubby.Location = new System.Drawing.Point(65, 500);
            this.lblsubby.Name = "lblsubby";
            this.lblsubby.Size = new System.Drawing.Size(162, 26);
            this.lblsubby.TabIndex = 54;
            this.lblsubby.Text = "Submitted By ";
            // 
            // btnview
            // 
            this.btnview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(129)))), ((int)(((byte)(198)))));
            this.btnview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnview.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.btnview.Location = new System.Drawing.Point(820, 530);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(105, 40);
            this.btnview.TabIndex = 52;
            this.btnview.Text = "View";
            this.btnview.UseVisualStyleBackColor = false;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // cmbintake
            // 
            this.cmbintake.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbintake.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.cmbintake.FormattingEnabled = true;
            this.cmbintake.Location = new System.Drawing.Point(380, 22);
            this.cmbintake.Name = "cmbintake";
            this.cmbintake.Size = new System.Drawing.Size(117, 33);
            this.cmbintake.TabIndex = 51;
            // 
            // lblintake
            // 
            this.lblintake.AutoSize = true;
            this.lblintake.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblintake.Location = new System.Drawing.Point(270, 25);
            this.lblintake.Name = "lblintake";
            this.lblintake.Size = new System.Drawing.Size(100, 25);
            this.lblintake.TabIndex = 50;
            this.lblintake.Text = "Intake :";
            // 
            // dgoccurrence
            // 
            this.dgoccurrence.AllowUserToAddRows = false;
            this.dgoccurrence.AllowUserToDeleteRows = false;
            this.dgoccurrence.AllowUserToResizeColumns = false;
            this.dgoccurrence.AllowUserToResizeRows = false;
            this.dgoccurrence.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgoccurrence.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgoccurrence.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.dgoccurrence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgoccurrence.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgoccurrence.Location = new System.Drawing.Point(60, 85);
            this.dgoccurrence.Name = "dgoccurrence";
            this.dgoccurrence.ReadOnly = true;
            this.dgoccurrence.RowTemplate.Height = 24;
            this.dgoccurrence.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgoccurrence.Size = new System.Drawing.Size(820, 374);
            this.dgoccurrence.TabIndex = 15;
            // 
            // dtpoccurrence
            // 
            this.dtpoccurrence.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpoccurrence.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpoccurrence.Location = new System.Drawing.Point(615, 25);
            this.dtpoccurrence.Name = "dtpoccurrence";
            this.dtpoccurrence.Size = new System.Drawing.Size(305, 27);
            this.dtpoccurrence.TabIndex = 14;
            // 
            // FrmOfficerOccurrence
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(196)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1298, 698);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpmeals);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmOfficerOccurrence";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmOfficerOccurrence_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbclose)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbreports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pblogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmeals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbrollcall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboccurrence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbattendance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbparade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbprofile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbhome)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgoccurrence)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbllogger;
        private System.Windows.Forms.PictureBox pbclose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblreports;
        private System.Windows.Forms.PictureBox pbreports;
        private System.Windows.Forms.Label lbllogout;
        private System.Windows.Forms.Label lblmeals;
        private System.Windows.Forms.Label lblrollcall;
        private System.Windows.Forms.Label lbloccurrence;
        private System.Windows.Forms.Label lblattendance;
        private System.Windows.Forms.Label lblparade;
        private System.Windows.Forms.Label lblprofile;
        private System.Windows.Forms.Label lblhome;
        private System.Windows.Forms.PictureBox pblogout;
        private System.Windows.Forms.PictureBox pbmeals;
        private System.Windows.Forms.PictureBox pbrollcall;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pboccurrence;
        private System.Windows.Forms.PictureBox pbattendance;
        private System.Windows.Forms.PictureBox pbparade;
        private System.Windows.Forms.PictureBox pbprofile;
        private System.Windows.Forms.PictureBox pbhome;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblannouncements;
        private System.Windows.Forms.DateTimePicker dtpmeals;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpoccurrence;
        private System.Windows.Forms.DataGridView dgoccurrence;
        private System.Windows.Forms.ComboBox cmbintake;
        private System.Windows.Forms.Label lblintake;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.Label lblsubdate;
        private System.Windows.Forms.Label lblsubname;
        private System.Windows.Forms.Label lblsubon;
        private System.Windows.Forms.Label lblsubby;
        private System.Windows.Forms.Label lblcadet;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}