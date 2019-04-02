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
    public partial class FrmAdminAddOfficer : Form
    {
        Instructor admin;
        public FrmAdminAddOfficer(Instructor kadmin)
        {
            admin = kadmin;
            InitializeComponent();
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void FrmAdminAddOfficer_Load(object sender, EventArgs e)
        {
            lbllogger.Text = admin.Name;

            try
            {

                SqlCommand sqlcmd = new SqlCommand();
                string query = "Select  Id, Gendertype from KDUgenders";
                DataTable dt = DataAccessLayer.ExecuteQuery(query, sqlcmd);

                cmbgender.DataSource = dt;
                cmbgender.DisplayMember = "Gendertype";
                cmbgender.ValueMember = "Id";
                cmbgender.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


            try
            {

                SqlCommand sqlcmd = new SqlCommand();
                string query = "Select Id,Nationality from KDUnationality";
                DataTable dt = DataAccessLayer.ExecuteQuery(query, sqlcmd);

                cmbnationality.DataSource = dt;
                cmbnationality.DisplayMember = "Nationality";
                cmbnationality.ValueMember = "Id";
                cmbnationality.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            try
            {

                SqlCommand sqlcmd = new SqlCommand();
                string query = "Select Id,Religion from KDUreligion";
                DataTable dt = DataAccessLayer.ExecuteQuery(query, sqlcmd);

                cmbreligion.DataSource = dt;
                cmbreligion.DisplayMember = "Religion";
                cmbreligion.ValueMember = "Id";
                cmbreligion.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            if (txtname.Text == "" || txttown.Text == "" || cmbgender.Text == ""
                || txtbday.Text == "" || txtnic.Text == "" || cmbnationality.Text == "" ||
                cmbreligion.Text == "" || txttp.Text == "" || txtemail.Text == ""
                || txtemename.Text == "" || txtemetp.Text == "" || txtrank.Text == ""
                || txtpassword.Text == "" || txtid.Text == "")

            {
                MessageBox.Show("Please fill the required fields.", "Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand sqlcmd = new SqlCommand();
                string query = @"INSERT INTO KDUusers(Userid,Userpassword,Name,Birthday,NICno,GenderId,NationalityId,ReligionId,Contactno,Hometown,Emailaddress,Emergencycontactname,
                    Emergencycontacttelephoneno,UsertypeId,UserstatusId)VALUES(@Userid,@Userpassword,@Name,@Birthday,@NICno,@GenderId,@NationalityId,@ReligionId,@Contactno,@Hometown,@Emailaddress,@Emergencycontactname,
                    @Emergencycontacttelephoneno,@UsertypeId,@UserstatusId)";

                DataAccessLayer.AddParameters(sqlcmd, "@Name", SqlDbType.NVarChar, txtname.Text);
                DataAccessLayer.AddParameters(sqlcmd, "@Hometown", SqlDbType.NVarChar, txttown.Text);
                DataAccessLayer.AddParameters(sqlcmd, "@Birthday", SqlDbType.Date, txtbday.Text);
                DataAccessLayer.AddParameters(sqlcmd, "@NICno", SqlDbType.NVarChar, txtnic.Text);
                DataAccessLayer.AddParameters(sqlcmd, "@Contactno", SqlDbType.Int, txttp.Text);
                DataAccessLayer.AddParameters(sqlcmd, "@Emailaddress", SqlDbType.NVarChar, txtemail.Text);
                DataAccessLayer.AddParameters(sqlcmd, "@Emergencycontactname", SqlDbType.NVarChar, txtemename.Text);
                DataAccessLayer.AddParameters(sqlcmd, "@Emergencycontacttelephoneno", SqlDbType.Int, txtemetp.Text);
                DataAccessLayer.AddParameters(sqlcmd, "@Userpassword", SqlDbType.NVarChar, txtpassword.Text);
                DataAccessLayer.AddParameters(sqlcmd, "@Userid", SqlDbType.Int, txtid.Text);
                DataAccessLayer.AddParameters(sqlcmd, "@GenderId", SqlDbType.Int, cmbgender.SelectedValue.ToString());
                DataAccessLayer.AddParameters(sqlcmd, "@NationalityId", SqlDbType.Int, cmbnationality.SelectedValue.ToString());
                DataAccessLayer.AddParameters(sqlcmd, "@ReligionId", SqlDbType.Int, cmbreligion.SelectedValue.ToString());
                DataAccessLayer.AddParameters(sqlcmd, "@UsertypeId", SqlDbType.Int, UserTypeId.Officer);
                DataAccessLayer.AddParameters(sqlcmd, "@UserstatusId", SqlDbType.Int, UserStatusId.Active);

                DataAccessLayer.ExecuteNonQuery(query, sqlcmd);

                SqlCommand sqlcmd0 = new SqlCommand();
                string query0 = "SELECT Id FROM KDUusers WHERE NICno = @NICno AND UsertypeId =" + UserTypeId.Officer.ToString();
                DataAccessLayer.AddParameters(sqlcmd0, "@NICno", SqlDbType.NVarChar, txtnic.Text);
                DataAccessLayer.AddParameters(sqlcmd0, "@UsertypeId", SqlDbType.Int, UserTypeId.Officer);
                DataTable dtid = DataAccessLayer.ExecuteQuery(query0, sqlcmd0);
                int officerid = 0;
                if ((dtid != null) && (dtid.Rows.Count == 1))
                {
                    officerid = Convert.ToInt32(dtid.Rows[0]["Id"]);
                }

                string img = string.Empty;

                if (!string.IsNullOrEmpty(lblImgPath.Text))
                {
                    using (Image image = Image.FromFile(lblImgPath.Text))
                    {
                        using (MemoryStream m = new MemoryStream())
                        {
                            image.Save(m, image.RawFormat);
                            byte[] imageBytes = m.ToArray();

                            // Convert byte[] to Base64 String
                            img = Convert.ToBase64String(imageBytes);
                        }
                    }
                }

                SqlCommand sqlcmd1 = new SqlCommand();
                string query1 = @"INSERT INTO KDUofficerinfo(Id,Rank,Userphoto)VALUES(@officerid,@Rank,@Userphoto)";
                DataAccessLayer.AddParameters(sqlcmd1, "@officerid", SqlDbType.Int, officerid);
                DataAccessLayer.AddParameters(sqlcmd1, "@Rank", SqlDbType.NVarChar, txtrank.Text);
                DataAccessLayer.AddParameters(sqlcmd1, "@Userphoto", SqlDbType.NVarChar, img);
                DataAccessLayer.ExecuteNonQuery(query1, sqlcmd1);


                MessageBox.Show("Saved Successfully");

                txtname.Text = "";
                txttown.Text = "";
                cmbgender.Text = "";
                txtbday.Text = "";
                txtnic.Text = "";
                cmbnationality.Text = "";
                cmbreligion.Text = "";
                txttp.Text = "";
                txtemail.Text = "";
                txtemename.Text = "";
                txtemetp.Text = "";
                txtpassword.Text = "";
                txtid.Text = "";
                txtrank.Text = "";
                pbcadetpic.Image = null;
            }
        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            {
                OpenFileDialog dlog = new OpenFileDialog();
                dlog.Filter = "png files(*.png)|*.png|jpg files (*.jpg)|*.jpg| all files (*.*)|*.*";
                if (dlog.ShowDialog() == DialogResult.OK)
                {
                    pbcadetpic.ImageLocation = dlog.FileName.ToString();
                    lblImgPath.Text = dlog.FileName.ToString();

                }
            }
        }
    }
}
