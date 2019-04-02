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
    public partial class FrmCadetAttendanceView : Form
    {
        Ocadet cadet;
        public FrmCadetAttendanceView(Ocadet ocadet)
        {
            cadet = ocadet;
            InitializeComponent();
        }

        private void FrmCadetAttendanceView_Load(object sender, EventArgs e)
        {
            lbllogger.Text = cadet.Name;
            
            try
            {
                string query = "SELECT d.Absentname from KDUattendancedetails d,KDUattendance a where a.Id=d.AttendanceId and a.Attendancedate = @Attendancedate";
                SqlCommand sqlcmd = new SqlCommand();
                DataAccessLayer.AddParameters(sqlcmd, "@Attendancedate", SqlDbType.DateTime, cadet.TodayDate);

                DataTable dt = DataAccessLayer.ExecuteQuery(query, sqlcmd);

                if ((dt != null))
                {
                    dgattendance.DataSource = dt;

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

        private void pbclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void lblattendance_Click(object sender, EventArgs e)
        {
            FrmCadetAttendance att = new FrmCadetAttendance(cadet);
            att.Show();
            this.Close();
        }

        private void pbattendance_Click(object sender, EventArgs e)
        {
            FrmCadetAttendance att = new FrmCadetAttendance(cadet);
            att.Show();
            this.Close();
        }
    }
    }

