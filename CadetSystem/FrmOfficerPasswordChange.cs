using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadetSystem
{
    public partial class FrmOfficerPasswordChange : Form
    {
        Officer oofficer;
        public FrmOfficerPasswordChange(Officer officer)
        {
            oofficer = officer;
            InitializeComponent();
        }

        private void pbclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblprofile_Click(object sender, EventArgs e)
        {
            FrmOfficerprofile pro = new FrmOfficerprofile(oofficer);
            pro.Show();
            this.Close();
        }

        private void pbprofile_Click(object sender, EventArgs e)
        {
            FrmOfficerprofile pro = new FrmOfficerprofile(oofficer);
            pro.Show();
            this.Close();
        }

        private void lblattendance_Click(object sender, EventArgs e)
        {
            FrmOfficerAttendance att = new FrmOfficerAttendance(oofficer);
            att.Show();
            this.Close();
        }

        private void pbattendance_Click(object sender, EventArgs e)
        {
            FrmOfficerAttendance att = new FrmOfficerAttendance(oofficer);
            att.Show();
            this.Close();
        }

        private void lbloccurrence_Click(object sender, EventArgs e)
        {
            FrmOfficerOccurrence occ = new FrmOfficerOccurrence(oofficer);
            occ.Show();
            this.Close();
        }

        private void pboccurrence_Click(object sender, EventArgs e)
        {
            FrmOfficerOccurrence occ = new FrmOfficerOccurrence(oofficer);
            occ.Show();
            this.Close();
        }

        private void lblrollcall_Click(object sender, EventArgs e)
        {
            FrmOfficerRollcall roll = new FrmOfficerRollcall(oofficer);
            roll.Show();
            this.Close();
        }

        private void pbrollcall_Click(object sender, EventArgs e)
        {
            FrmOfficerRollcall roll = new FrmOfficerRollcall(oofficer);
            roll.Show();
            this.Close();
        }

        private void lblmeals_Click(object sender, EventArgs e)
        {
            FrmOfficerMeals mls = new FrmOfficerMeals(oofficer);
            mls.Show();
            this.Close();
        }

        private void pbmeals_Click(object sender, EventArgs e)
        {
            FrmOfficerMeals mls = new FrmOfficerMeals(oofficer);
            mls.Show();
            this.Close();
        }

        private void lblreports_Click(object sender, EventArgs e)
        {
            FrmOfficerReports rpt = new FrmOfficerReports(oofficer);
            rpt.Show();
            this.Close();
        }

        private void pbreports_Click(object sender, EventArgs e)
        {
            FrmOfficerReports rpt = new FrmOfficerReports(oofficer);
            rpt.Show();
            this.Close();
        }

        private void lblannouncements_Click(object sender, EventArgs e)
        {
            FrmOfficerAnnouncements ann = new FrmOfficerAnnouncements(oofficer);
            ann.Show();
            this.Close();
        }

        private void lbllogout_Click(object sender, EventArgs e)
        {
            FrmLogin log = new FrmLogin();
            log.Show();
            this.Close();
        }

        private void pblogout_Click(object sender, EventArgs e)
        {
            FrmLogin log = new FrmLogin();
            log.Show();
            this.Close();
        }

        private void lblhome_Click(object sender, EventArgs e)
        {
            FrmOfficerHome off = new FrmOfficerHome(oofficer);
            off.Show();
            this.Close();
        }

        private void pbhome_Click(object sender, EventArgs e)
        {
            FrmOfficerHome off = new FrmOfficerHome(oofficer);
            off.Show();
            this.Close();
        }

        private void lblparade_Click(object sender, EventArgs e)
        {
            FrmOfficerParadestate prd = new FrmOfficerParadestate(oofficer);
            prd.Show();
            this.Close();
        }

        private void pbparade_Click(object sender, EventArgs e)
        {
            FrmOfficerParadestate prd = new FrmOfficerParadestate(oofficer);
            prd.Show();
            this.Close();
        }

        private void FrmOfficerPasswordChange_Load(object sender, EventArgs e)
        {
            lbllogger.Text = oofficer.Name;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtold.Text == "")
                {
                    MessageBox.Show("Enter Current Password");

                }
                else if (txtold.Text == oofficer.Password)
                {
                    if (txtnew.Text == "")
                    {
                        MessageBox.Show("Enter New Password");

                    }
                    else if (txtconfirm.Text == "")
                    {
                        MessageBox.Show("Enter Confirmation Password");
                    }
                    else if ((txtnew.Text == txtconfirm.Text))
                    {

                        SqlCommand sqlcmd = new SqlCommand();
                        string query = "update KDUusers SET Userpassword = @Userpassword where Name = @Name";

                        DataAccessLayer.AddParameters(sqlcmd, "@Name", SqlDbType.NVarChar, oofficer.Name);
                        DataAccessLayer.AddParameters(sqlcmd, "@Userpassword", SqlDbType.NVarChar, txtconfirm.Text);

                        DataAccessLayer.ExecuteNonQuery(query, sqlcmd);

                        MessageBox.Show("Password changed");
                    }
                    else
                    {
                        MessageBox.Show("Confirmation Password does not match with the New Password");
                    }
                }
                else
                {
                    MessageBox.Show("Old Password is Wrong");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

            txtconfirm.Clear();
            txtnew.Clear();
            txtold.Clear();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblcadet_Click(object sender, EventArgs e)
        {
            FrmOfficerCadetView cdtvw = new FrmOfficerCadetView(oofficer);
            cdtvw.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmOfficerCadetView cdtvw = new FrmOfficerCadetView(oofficer);
            cdtvw.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmOfficerAnnouncements ann = new FrmOfficerAnnouncements(oofficer);
            ann.Show();
            this.Close();
        }
    }
}

            
    

