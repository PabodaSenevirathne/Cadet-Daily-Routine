namespace CadetSystem
{
    partial class FrmAdminPasswordReset
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
            this.gbpasschange = new System.Windows.Forms.GroupBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtconfirm = new System.Windows.Forms.TextBox();
            this.txtnew = new System.Windows.Forms.TextBox();
            this.txtold = new System.Windows.Forms.TextBox();
            this.lblconfirm = new System.Windows.Forms.Label();
            this.lblnewpass = new System.Windows.Forms.Label();
            this.lbloldpass = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbclose)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbaddofficer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbaddcadet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pblogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbprofile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbhome)).BeginInit();
            this.gbpasschange.SuspendLayout();
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
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(0, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 625);
            this.panel1.TabIndex = 16;
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
            this.lbladdofficer.Size = new System.Drawing.Size(166, 36);
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
            this.lblprofile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(99)))), ((int)(((byte)(182)))));
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
            this.lblhome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(129)))), ((int)(((byte)(198)))));
            this.lblhome.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhome.ForeColor = System.Drawing.Color.White;
            this.lblhome.Location = new System.Drawing.Point(70, 50);
            this.lblhome.Name = "lblhome";
            this.lblhome.Size = new System.Drawing.Size(94, 35);
            this.lblhome.TabIndex = 10;
            this.lblhome.Text = "Home";
            this.lblhome.Click += new System.EventHandler(this.lblhome_Click);
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
            this.pbprofile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(99)))), ((int)(((byte)(182)))));
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
            this.panel3.Size = new System.Drawing.Size(250, 3);
            this.panel3.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(99)))), ((int)(((byte)(182)))));
            this.panel5.Location = new System.Drawing.Point(0, 92);
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
            this.panel4.TabIndex = 17;
            // 
            // gbpasschange
            // 
            this.gbpasschange.Controls.Add(this.btnsave);
            this.gbpasschange.Controls.Add(this.txtconfirm);
            this.gbpasschange.Controls.Add(this.txtnew);
            this.gbpasschange.Controls.Add(this.txtold);
            this.gbpasschange.Controls.Add(this.lblconfirm);
            this.gbpasschange.Controls.Add(this.lblnewpass);
            this.gbpasschange.Controls.Add(this.lbloldpass);
            this.gbpasschange.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbpasschange.Location = new System.Drawing.Point(330, 100);
            this.gbpasschange.Name = "gbpasschange";
            this.gbpasschange.Size = new System.Drawing.Size(940, 575);
            this.gbpasschange.TabIndex = 18;
            this.gbpasschange.TabStop = false;
            this.gbpasschange.Text = "Password Change";
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(129)))), ((int)(((byte)(198)))));
            this.btnsave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsave.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(542, 347);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(105, 40);
            this.btnsave.TabIndex = 29;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtconfirm
            // 
            this.txtconfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtconfirm.Location = new System.Drawing.Point(470, 275);
            this.txtconfirm.Name = "txtconfirm";
            this.txtconfirm.Size = new System.Drawing.Size(177, 30);
            this.txtconfirm.TabIndex = 5;
            // 
            // txtnew
            // 
            this.txtnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtnew.Location = new System.Drawing.Point(470, 225);
            this.txtnew.Name = "txtnew";
            this.txtnew.Size = new System.Drawing.Size(177, 30);
            this.txtnew.TabIndex = 4;
            // 
            // txtold
            // 
            this.txtold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtold.Location = new System.Drawing.Point(470, 175);
            this.txtold.Name = "txtold";
            this.txtold.Size = new System.Drawing.Size(177, 30);
            this.txtold.TabIndex = 3;
            // 
            // lblconfirm
            // 
            this.lblconfirm.AutoSize = true;
            this.lblconfirm.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconfirm.Location = new System.Drawing.Point(175, 275);
            this.lblconfirm.Name = "lblconfirm";
            this.lblconfirm.Size = new System.Drawing.Size(274, 25);
            this.lblconfirm.TabIndex = 2;
            this.lblconfirm.Text = "Confirm New Password";
            // 
            // lblnewpass
            // 
            this.lblnewpass.AutoSize = true;
            this.lblnewpass.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnewpass.Location = new System.Drawing.Point(175, 225);
            this.lblnewpass.Name = "lblnewpass";
            this.lblnewpass.Size = new System.Drawing.Size(179, 25);
            this.lblnewpass.TabIndex = 1;
            this.lblnewpass.Text = "New Password";
            // 
            // lbloldpass
            // 
            this.lbloldpass.AutoSize = true;
            this.lbloldpass.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloldpass.Location = new System.Drawing.Point(175, 175);
            this.lbloldpass.Name = "lbloldpass";
            this.lbloldpass.Size = new System.Drawing.Size(167, 25);
            this.lbloldpass.TabIndex = 0;
            this.lbloldpass.Text = "Old Password";
            // 
            // FrmAdminPasswordReset
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(196)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(1298, 698);
            this.ControlBox = false;
            this.Controls.Add(this.gbpasschange);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmAdminPasswordReset";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmAdminPasswordReset_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbclose)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbaddofficer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbaddcadet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pblogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbprofile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbhome)).EndInit();
            this.gbpasschange.ResumeLayout(false);
            this.gbpasschange.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbllogger;
        private System.Windows.Forms.PictureBox pbclose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbaddofficer;
        private System.Windows.Forms.PictureBox pbaddcadet;
        private System.Windows.Forms.Label lbladdofficer;
        private System.Windows.Forms.Label lbladdcadet;
        private System.Windows.Forms.Label lbllogout;
        private System.Windows.Forms.Label lblprofile;
        private System.Windows.Forms.Label lblhome;
        private System.Windows.Forms.PictureBox pblogout;
        private System.Windows.Forms.PictureBox pbprofile;
        private System.Windows.Forms.PictureBox pbhome;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox gbpasschange;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtconfirm;
        private System.Windows.Forms.TextBox txtnew;
        private System.Windows.Forms.TextBox txtold;
        private System.Windows.Forms.Label lblconfirm;
        private System.Windows.Forms.Label lblnewpass;
        private System.Windows.Forms.Label lbloldpass;
    }
}