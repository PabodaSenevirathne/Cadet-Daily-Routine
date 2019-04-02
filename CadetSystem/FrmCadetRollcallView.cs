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
    public partial class FrmCadetRollcallView : Form
    {
        Ocadet cadet;
        public FrmCadetRollcallView(Ocadet ocadet)
        {
            cadet = ocadet;
            InitializeComponent();
        }

        private void FrmCadetRollcallView_Load(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT d.Absentname from KDUrollcalldetails d,KDUrollcall r where r.Id=d.RollcallId and r.Rollcalldate = @Rollcalldate";
                SqlCommand sqlcmd = new SqlCommand();
                DataAccessLayer.AddParameters(sqlcmd, "@Rollcalldate", SqlDbType.DateTime, cadet.TodayDate);

                DataTable dt = DataAccessLayer.ExecuteQuery(query, sqlcmd);

                if ((dt != null))
                {
                    dgrollcall.DataSource = dt;

                }
                else
                {
                    MessageBox.Show("No data found");

                }

            }
            catch (Exception ex)
            {
                this.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private void lblprofile_Click(object sender, EventArgs e)
        {
            FrmCadetProfile cdtpro = new FrmCadetProfile(cadet);
            cdtpro.Show();
            this.Close();
        }

        private void pbprofile_Click(object sender, EventArgs e)
        {
            FrmCadetProfile cdtpro = new FrmCadetProfile(cadet);
            cdtpro.Show();
            this.Close();
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
    }
    }

