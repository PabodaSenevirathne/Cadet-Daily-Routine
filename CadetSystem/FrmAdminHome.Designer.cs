namespace CadetSystem
{
    partial class FrmAdminHome
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbaddofficer = new System.Windows.Forms.PictureBox();
            this.pbaddcadet = new System.Windows.Forms.PictureBox();
            this.lbladdofficer = new System.Windows.Forms.Label();
            this.lbladdcadet = new System.Windows.Forms.Label();
            this.lbllogout = new System.Windows.Forms.Label();
            this.lblprofile = new System.Windows.Forms.Label();
            this.lblhome = new System.Windows.Forms.Label();
            this.pblogout = new System.Windows.Forms.PictureBox();
            this.pbprofile = new System.Windows.Forms.PictureBox();
            this.pbhome = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbaddofficer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbaddcadet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pblogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbprofile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbhome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(129)))), ((int)(((byte)(198)))));
            this.panel2.Controls.Add(this.lbllogger);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1300, 75);
            this.panel2.TabIndex = 13;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(129)))), ((int)(((byte)(198)))));
            this.panel1.Controls.Add(this.pbaddofficer);
            this.panel1.Controls.Add(this.pbaddcadet);
            this.panel1.Controls.Add(this.lbladdofficer);
            this.panel1.Controls.Add(this.lbladdcadet);
            this.panel1.Controls.Add(this.lbllogout);
            this.panel1.Controls.Add(this.lblprofile);
            this.panel1.Controls.Add(this.lblhome);
            this.panel1.Controls.Add(this.pblogout);
            this.panel1.Controls.Add(this.pbprofile);
            this.panel1.Controls.Add(this.pbhome);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Location = new System.Drawing.Point(0, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 625);
            this.panel1.TabIndex = 14;
            // 
            // pbaddofficer
            // 
            this.pbaddofficer.Image = global::CadetSystem.Properties.Resources.Megaphone_Cadet_WHITE;
            this.pbaddofficer.Location = new System.Drawing.Point(25, 200);
            this.pbaddofficer.Name = "pbaddofficer";
            this.pbaddofficer.Size = new System.Drawing.Size(32, 32);
            this.pbaddofficer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbaddofficer.TabIndex = 22;
            this.pbaddofficer.TabStop = false;
            this.pbaddofficer.Click += new System.EventHandler(this.pbaddofficer_Click);
            // 
            // pbaddcadet
            // 
            this.pbaddcadet.Image = global::CadetSystem.Properties.Resources.Cadet_Salute_White;
            this.pbaddcadet.Location = new System.Drawing.Point(25, 150);
            this.pbaddcadet.Name = "pbaddcadet";
            this.pbaddcadet.Size = new System.Drawing.Size(32, 32);
            this.pbaddcadet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbaddcadet.TabIndex = 21;
            this.pbaddcadet.TabStop = false;
            this.pbaddcadet.Click += new System.EventHandler(this.pbaddcadet_Click);
            // 
            // lbladdofficer
            // 
            this.lbladdofficer.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdofficer.ForeColor = System.Drawing.Color.White;
            this.lbladdofficer.Location = new System.Drawing.Point(70, 200);
            this.lbladdofficer.Name = "lbladdofficer";
            this.lbladdofficer.Size = new System.Drawing.Size(163, 36);
            this.lbladdofficer.TabIndex = 20;
            this.lbladdofficer.Text = "Add Officer";
            this.lbladdofficer.Click += new System.EventHandler(this.lbladdofficer_Click);
            // 
            // lbladdcadet
            // 
            this.lbladdcadet.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdcadet.ForeColor = System.Drawing.Color.White;
            this.lbladdcadet.Location = new System.Drawing.Point(70, 150);
            this.lbladdcadet.Name = "lbladdcadet";
            this.lbladdcadet.Size = new System.Drawing.Size(147, 36);
            this.lbladdcadet.TabIndex = 19;
            this.lbladdcadet.Text = "Add Cadet";
            this.lbladdcadet.Click += new System.EventHandler(this.lbladdcadet_Click);
            // 
            // lbllogout
            // 
            this.lbllogout.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogout.ForeColor = System.Drawing.Color.White;
            this.lbllogout.Location = new System.Drawing.Point(70, 250);
            this.lbllogout.Name = "lbllogout";
            this.lbllogout.Size = new System.Drawing.Size(113, 36);
            this.lbllogout.TabIndex = 17;
            this.lbllogout.Text = "Logout";
            this.lbllogout.Click += new System.EventHandler(this.lbllogout_Click);
            // 
            // lblprofile
            // 
            this.lblprofile.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprofile.ForeColor = System.Drawing.Color.White;
            this.lblprofile.Location = new System.Drawing.Point(70, 100);
            this.lblprofile.Name = "lblprofile";
            this.lblprofile.Size = new System.Drawing.Size(113, 36);
            this.lblprofile.TabIndex = 11;
            this.lblprofile.Text = "Profile";
            this.lblprofile.Click += new System.EventHandler(this.lblprofile_Click);
            // 
            // lblhome
            // 
            this.lblhome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(99)))), ((int)(((byte)(182)))));
            this.lblhome.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhome.ForeColor = System.Drawing.Color.White;
            this.lblhome.Location = new System.Drawing.Point(70, 50);
            this.lblhome.Name = "lblhome";
            this.lblhome.Size = new System.Drawing.Size(94, 35);
            this.lblhome.TabIndex = 10;
            this.lblhome.Text = "Home";
            // 
            // pblogout
            // 
            this.pblogout.Image = global::CadetSystem.Properties.Resources.sidebarlogout;
            this.pblogout.Location = new System.Drawing.Point(25, 250);
            this.pblogout.Name = "pblogout";
            this.pblogout.Size = new System.Drawing.Size(32, 32);
            this.pblogout.TabIndex = 9;
            this.pblogout.TabStop = false;
            this.pblogout.Click += new System.EventHandler(this.pblogout_Click);
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
            this.pbhome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(99)))), ((int)(((byte)(182)))));
            this.pbhome.Image = global::CadetSystem.Properties.Resources.sidebarhome;
            this.pbhome.Location = new System.Drawing.Point(25, 50);
            this.pbhome.Name = "pbhome";
            this.pbhome.Size = new System.Drawing.Size(32, 32);
            this.pbhome.TabIndex = 1;
            this.pbhome.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 3);
            this.panel3.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(99)))), ((int)(((byte)(182)))));
            this.panel5.Location = new System.Drawing.Point(0, 42);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(300, 48);
            this.panel5.TabIndex = 18;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(250, 74);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1050, 3);
            this.panel4.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CadetSystem.Properties.Resources.Staff_4to1;
            this.pictureBox1.Location = new System.Drawing.Point(355, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(890, 540);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pbExit
            // 
            this.pbExit.BackColor = System.Drawing.Color.Red;
            this.pbExit.Image = global::CadetSystem.Properties.Resources.imgclose;
            this.pbExit.Location = new System.Drawing.Point(1270, 5);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(24, 24);
            this.pbExit.TabIndex = 12;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // FrmAdminHome
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(196)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1298, 698);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmAdminHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmAdminHome_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbaddofficer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbaddcadet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pblogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbprofile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbhome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbllogger;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbllogout;
        private System.Windows.Forms.Label lblprofile;
        private System.Windows.Forms.Label lblhome;
        private System.Windows.Forms.PictureBox pblogout;
        private System.Windows.Forms.PictureBox pbprofile;
        private System.Windows.Forms.PictureBox pbhome;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbladdofficer;
        private System.Windows.Forms.Label lbladdcadet;
        private System.Windows.Forms.PictureBox pbaddofficer;
        private System.Windows.Forms.PictureBox pbaddcadet;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}