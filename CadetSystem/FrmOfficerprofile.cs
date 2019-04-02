using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadetSystem
{
    public partial class FrmOfficerprofile : Form
    {
        Officer oofficer;
        public FrmOfficerprofile(Officer officer)
        {
            oofficer = officer;
            InitializeComponent();
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

        private void FrmOfficerprofile_Load(object sender, EventArgs e)
        {
            lbllogger.Text = oofficer.Name;

            try
            {

                string query = @"SELECT u.Name,u.Birthday,u.NICno,u.Contactno,u.Hometown,u.Emailaddress,u.Emergencycontactname,
                    u.Emergencycontacttelephoneno,g.Gendertype,n.Nationality,r.Religion,i.Userphoto FROM KDUofficerinfo i,KDUusers u,KDUgenders g,KDUnationality n,KDUreligion r where Name = @Name and u.GenderId=g.Id and u.NationalityId=n.Id and u.ReligionId=r.Id ";

                SqlCommand sqlcmd = new SqlCommand();
                
                DataAccessLayer.AddParameters(sqlcmd, "@Name", SqlDbType.NVarChar,oofficer.Name);
                DataTable dt = DataAccessLayer.ExecuteQuery(query, sqlcmd);


                lblnamee.Text = dt.Rows[0]["Name"].ToString();
                lblhometownn.Text = dt.Rows[0]["Hometown"].ToString();
                lblbdayy.Text = Convert.ToDateTime(dt.Rows[0]["Birthday"]).ToString("yyyy-MM-dd");
                lblgenderr.Text = dt.Rows[0]["Gendertype"].ToString();
                lblnicc.Text = dt.Rows[0]["NICno"].ToString();
                lblnationalityy.Text = dt.Rows[0]["Nationality"].ToString();
                lblreligionn.Text = dt.Rows[0]["Religion"].ToString();
                lbltpp.Text = dt.Rows[0]["Contactno"].ToString();
                lblemaill.Text = dt.Rows[0]["Emailaddress"].ToString();
                lblemenamee.Text = dt.Rows[0]["Emergencycontactname"].ToString();
                lblemetpp.Text = dt.Rows[0]["Emergencycontacttelephoneno"].ToString();

                var pic = Convert.FromBase64String(dt.Rows[0]["Userphoto"].ToString());
                using (MemoryStream ms = new MemoryStream(pic))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                }



                lblnamee.Visible = true;
                lblhometownn.Visible = true;
                lblbdayy.Visible = true;
                lblgenderr.Visible = true;
                lblnicc.Visible = true;
                lblnationalityy.Visible = true;
                lblreligionn.Visible = true;
                lbltpp.Visible = true;
                lblemaill.Visible = true;
                lblemenamee.Visible = true;
                lblemetpp.Visible = true;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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

        private void pbclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbpasschange_Click(object sender, EventArgs e)
        {
            FrmOfficerPasswordChange pass = new FrmOfficerPasswordChange(oofficer);
            pass.Show();
            this.Close();

        }

        private void lblcadet_Click(object sender, EventArgs e)
        {
            FrmOfficerCadetView cdtvw = new FrmOfficerCadetView(oofficer);
            cdtvw.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
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
