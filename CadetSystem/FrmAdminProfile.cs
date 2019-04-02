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
    public partial class FrmAdminProfile : Form
    {
        Instructor admin;
        public FrmAdminProfile(Instructor kadmin)
        {
            admin = kadmin;
            InitializeComponent();
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbladdcadet_Click(object sender, EventArgs e)
        {
            FrmAdminAddCadet cdt = new FrmAdminAddCadet(admin);
            cdt.Show();
            this.Close();
        }

        private void pbaddcadet_Click(object sender, EventArgs e)
        {
            FrmAdminAddCadet cdt = new FrmAdminAddCadet(admin);
            cdt.Show();
            this.Close();
        }

        private void lbladdofficer_Click(object sender, EventArgs e)
        {
            FrmAdminAddOfficer ofc = new FrmAdminAddOfficer(admin);
            ofc.Show();
            this.Close();
        }

        private void pbaddofficer_Click(object sender, EventArgs e)
        {
            FrmAdminAddOfficer ofc = new FrmAdminAddOfficer(admin);
            ofc.Show();
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
            FrmAdminHome hm = new FrmAdminHome(admin);
            hm.Show();
            this.Close();
        }

        private void pbhome_Click(object sender, EventArgs e)
        {
            FrmAdminHome hm = new FrmAdminHome(admin);
            hm.Show();
            this.Close();
        }

        private void FrmAdminProfile_Load(object sender, EventArgs e)
        {
            lbllogger.Text = admin.Name;

            try
            {

                string query = @"SELECT u.Name,u.Birthday,u.NICno,u.Contactno,u.Hometown,u.Emailaddress,u.Emergencycontactname,
                    u.Emergencycontacttelephoneno,g.Gendertype,n.Nationality,r.Religion FROM KDUusers u, KDUgenders g,KDUnationality n, KDUreligion r where Name = @Name and u.GenderId = g.Id and u.NationalityId = n.Id and u.ReligionId = r.Id ";

                SqlCommand sqlcmd = new SqlCommand();

                DataAccessLayer.AddParameters(sqlcmd, "@Name", SqlDbType.NVarChar, admin.Name);
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

        private void pbpasschange_Click(object sender, EventArgs e)
        {
            FrmAdminPasswordReset pswd = new FrmAdminPasswordReset(admin);
            pswd.Show();
            this.Close();
        }
    }
    }
