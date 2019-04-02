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
using System.IO;

namespace CadetSystem
{
    public partial class FrmCadetProfile : Form
    {
        Ocadet cadet;
        public FrmCadetProfile(Ocadet ocadet)
        {
            cadet = ocadet;
            InitializeComponent();
        }

        private void pbclose_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void lblparade_Click(object sender, EventArgs e)
        {
            FrmCadetParadestate cdtprd = new FrmCadetParadestate(cadet);
            cdtprd.Show();
            this.Close();
        }

        private void pbparade_Click(object sender, EventArgs e)
        {
            FrmCadetParadestate cdtprd = new FrmCadetParadestate(cadet);
            cdtprd.Show();
            this.Close();
        }

        private void lblattendance_Click(object sender, EventArgs e)
        {
            FrmCadetAttendance cdtatt = new FrmCadetAttendance(cadet);
            cdtatt.Show();
            this.Close();
        }

        private void pbattendance_Click(object sender, EventArgs e)
        {
            FrmCadetAttendance cdtatt = new FrmCadetAttendance(cadet);
            cdtatt.Show();
            this.Close();
        }

        private void lbloccurrence_Click(object sender, EventArgs e)
        {
            FrmCadetOccurrence cdtocc = new FrmCadetOccurrence(cadet);
            cdtocc.Show();
            this.Close();
        }

        private void pboccurrence_Click(object sender, EventArgs e)
        {
            FrmCadetOccurrence cdtocc = new FrmCadetOccurrence(cadet);
            cdtocc.Show();
            this.Close();
        }

        private void lblrollcall_Click(object sender, EventArgs e)
        {
            FrmCadetRollcall cdtrol = new FrmCadetRollcall(cadet);
            cdtrol.Show();
            this.Close();
        }

        private void pbrollcall_Click(object sender, EventArgs e)
        {
            FrmCadetRollcall cdtrol = new FrmCadetRollcall(cadet);
            cdtrol.Show();
            this.Close();
        }

        private void lblmeals_Click(object sender, EventArgs e)
        {
            FrmCadetMeals cdtmeal = new FrmCadetMeals(cadet);
            cdtmeal.Show();
            this.Close();
        }

        private void pbmeals_Click(object sender, EventArgs e)
        {
            FrmCadetMeals cdtmeal = new FrmCadetMeals(cadet);
            cdtmeal.Show();
            this.Close();
        }

        private void pblogout_Click(object sender, EventArgs e)
        {
            FrmLogin log = new FrmLogin();
            log.Show();
            this.Close();
        }

        private void lbllogout_Click(object sender, EventArgs e)
        {
            FrmLogin log = new FrmLogin();
            log.Show();
            this.Close();
        }

        private void lblreports_Click(object sender, EventArgs e)
        {
            FrmCadetReports cdtrpt = new FrmCadetReports(cadet);
            cdtrpt.Show();
            this.Close();
        }

        private void pbreports_Click(object sender, EventArgs e)
        {
            FrmCadetReports cdtrpt = new FrmCadetReports(cadet);
            cdtrpt.Show();
            this.Close();
        }

        private void lblhome_Click(object sender, EventArgs e)
        {
            FrmCadetHome cdthme = new FrmCadetHome(cadet);
            cdthme.Show();
            this.Close();

        }

        private void pbhome_Click(object sender, EventArgs e)
        {
            FrmCadetHome cdthme = new FrmCadetHome(cadet);
            cdthme.Show();
            this.Close();
        }

        private void FrmCadetProfile_Load(object sender, EventArgs e)
        {
            lbllogger.Text = cadet.Name;
            try
            {

                string query = @"SELECT u.Name,u.Birthday,u.NICno,u.Contactno,u.Hometown,u.Emailaddress,u.Emergencycontactname,
                    u.Emergencycontacttelephoneno,g.Gendertype,n.Nationality,r.Religion, i.Userphoto FROM KDUusers u,KDUgenders g,KDUnationality n,KDUreligion r, KDUcadetinfo i where u.Id = @Id and u.GenderId=g.Id and u.NationalityId=n.Id and u.ReligionId=r.Id and i.Id = u.Id  ";

                SqlCommand sqlcmd = new SqlCommand();
                DataAccessLayer.AddParameters(sqlcmd, "@Id", SqlDbType.Int, cadet.Id);
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void pbpasschange_Click(object sender, EventArgs e)
        {
            FrmCadetPasswordChange pswd = new FrmCadetPasswordChange(cadet);
            pswd.Show();
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
