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
    public partial class FrmCadetMeals : Form
    {
        Ocadet cadet;
        public FrmCadetMeals(Ocadet ocadet)
        {
            cadet = ocadet;
            InitializeComponent();
        }

        private void Frmmeals_Load(object sender, EventArgs e)
        {
            lbllogger.Text = cadet.Name;
            lbldate.Text = cadet.TodayDate;

        }

        private void pbclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnsave_Click(object sender, EventArgs e)

        {
            try
            {
                if (txtlunch.Text == "")
                {
                    MessageBox.Show("Fill the Lunch Field");
                }
                else if (txtdinner.Text == "")
                {
                    MessageBox.Show("Fill the Dinner Field");
                }
                else if (txtbreakfast.Text == "")
                {
                    MessageBox.Show("Fill the Breakfast Field");
                }
                else
                {
                    SqlCommand sqlcmd = new SqlCommand();
                    string query = "INSERT INTO KDUmeals (Lunch,Dinner,Breakfast,Remarklunch,Remarkdinner,Remarkbreakfast,Comments,Mealdate,Intake,SubmittedBy,SubmittedOn) VALUES(@Lunch, @Dinner, @Breakfast, @Remarklunch,@Remarkdinner,@Remarkbreakfast, @Comments,@Mealdate,@Intake,@SubmittedBy, GETDATE())";

                    DataAccessLayer.AddParameters(sqlcmd, "@SubmittedBy", SqlDbType.NVarChar, cadet.Name);
                    DataAccessLayer.AddParameters(sqlcmd, "@Lunch", SqlDbType.NVarChar, txtlunch.Text);
                    DataAccessLayer.AddParameters(sqlcmd, "@Dinner", SqlDbType.NVarChar, txtdinner.Text);
                    DataAccessLayer.AddParameters(sqlcmd, "@Breakfast", SqlDbType.NVarChar, txtbreakfast.Text);
                    DataAccessLayer.AddParameters(sqlcmd, "@Remarklunch", SqlDbType.NVarChar, cmbremarklunch.Text);
                    DataAccessLayer.AddParameters(sqlcmd, "@Comments", SqlDbType.NVarChar, txtcomment.Text);
                    DataAccessLayer.AddParameters(sqlcmd, "@Mealdate", SqlDbType.DateTime,cadet.TodayDate);
                    DataAccessLayer.AddParameters(sqlcmd, "@Intake", SqlDbType.Int, cadet.Intake);
                    DataAccessLayer.AddParameters(sqlcmd, "@Remarkdinner", SqlDbType.NVarChar, cmbremarkdinner.Text);
                    DataAccessLayer.AddParameters(sqlcmd, "@Remarkbreakfast", SqlDbType.NVarChar, cmbremarkbreak.Text);

                    DataAccessLayer.ExecuteNonQuery(query, sqlcmd);

                    {
                        MessageBox.Show("Saved Successfully");
                    }
                    txtbreakfast.Clear();
                    txtdinner.Clear();
                    txtlunch.Clear();
                    cmbremarklunch.Text = "";
                    txtcomment.Clear();
                    cmbremarkbreak.Text = "";
                    cmbremarkdinner.Text = "";

                }


            }
            catch (Exception ex)
            {
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

        private void btnview_Click(object sender, EventArgs e)
        {
            FrmCadetMealView mls = new FrmCadetMealView(cadet);
            mls.Show();
            this.Close();
        }
    }
}
