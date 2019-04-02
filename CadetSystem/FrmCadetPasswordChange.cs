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
    public partial class FrmCadetPasswordChange : Form
    {
        Ocadet cadet;
        public FrmCadetPasswordChange(Ocadet ocadet)
        {
            cadet = ocadet;
            InitializeComponent();
        }

        private void FrmCadetPasswordChange_Load(object sender, EventArgs e)
        {
            lbllogger.Text = cadet.Name;
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

        private void lblprofile_Click(object sender, EventArgs e)
        {
            FrmCadetProfile pro = new FrmCadetProfile(cadet);
            pro.Show();
            this.Close();
        }

        private void pbprofile_Click(object sender, EventArgs e)
        {
            FrmCadetProfile pro = new FrmCadetProfile(cadet);
            pro.Show();
            this.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtold.Text == "")
                {
                    MessageBox.Show("Enter Current Password");

                }
                else if (txtold.Text == cadet.Password)
                {
                    if (txtnew.Text == "")
                    {
                        MessageBox.Show("Enter New Password");

                    } else if (txtconfirm.Text == "")
                    {
                        MessageBox.Show("Enter Confirmation Password");
                    }
                    else if ((txtnew.Text == txtconfirm.Text))
                    {

                        SqlCommand sqlcmd = new SqlCommand();
                        string query = "update KDUusers SET Userpassword = @Userpassword where Id = @Id";

                        DataAccessLayer.AddParameters(sqlcmd, "@Id", SqlDbType.NVarChar, cadet.Id);
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
                    MessageBox.Show("Current Password is Wrong");
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
    }
}
    

