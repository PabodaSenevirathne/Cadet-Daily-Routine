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
    public partial class FrmAdminPasswordReset : Form
    {
        Instructor admin;
        public FrmAdminPasswordReset(Instructor kadmin)
        {
            admin = kadmin;
            InitializeComponent();
        }

        private void pbclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmAdminPasswordReset_Load(object sender, EventArgs e)
        {
            lbllogger.Text = admin.Name;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtold.Text == "")
                {
                    MessageBox.Show("Enter Current Password");

                }
                else if (txtold.Text == admin.Password)
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

                        DataAccessLayer.AddParameters(sqlcmd, "@Name", SqlDbType.NVarChar, admin.Name);
                        DataAccessLayer.AddParameters(sqlcmd, "@Userpassword", SqlDbType.NVarChar, txtconfirm.Text);

                        DataAccessLayer.ExecuteNonQuery(query, sqlcmd);

                        MessageBox.Show("Password Changed");
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

        private void lblprofile_Click(object sender, EventArgs e)
        {
            FrmAdminProfile pro = new FrmAdminProfile(admin);
            pro.Show();
            this.Close();
        }

        private void pbprofile_Click(object sender, EventArgs e)
        {
            FrmAdminProfile pro = new FrmAdminProfile(admin);
            pro.Show();
            this.Close();
        }

        private void lbladdcadet_Click(object sender, EventArgs e)
        {
            FrmAdminAddCadet adcdt = new FrmAdminAddCadet(admin);
            adcdt.Show();
            this.Close();
        }

        private void pbaddcadet_Click(object sender, EventArgs e)
        {
            FrmAdminAddCadet adcdt = new FrmAdminAddCadet(admin);
            adcdt.Show();
            this.Close();
        }

        private void lbladdofficer_Click(object sender, EventArgs e)
        {
            FrmAdminAddOfficer adoff = new FrmAdminAddOfficer(admin);
            adoff.Show();
            this.Close();
        }

        private void pbaddofficer_Click(object sender, EventArgs e)
        {
            FrmAdminAddOfficer adoff = new FrmAdminAddOfficer(admin);
            adoff.Show();
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
            FrmAdminHome hom = new FrmAdminHome(admin);
            hom.Show();
            this.Close();
        }

        private void pbhome_Click(object sender, EventArgs e)
        {
            FrmAdminHome hom = new FrmAdminHome(admin);
            hom.Show();
            this.Close();
        }
    }
}
