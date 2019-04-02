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
    public partial class FrmOfficerCadetView : Form
    {
        Officer oofficer;
        public FrmOfficerCadetView(Officer officer)
        {
            oofficer = officer;
            InitializeComponent();
        }

        private void FrmOfficerCadetView_Load(object sender, EventArgs e)
        {
            lbllogger.Text = oofficer.Name;
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                string query = "Select distinct Intake from KDUcadetinfo ";
                DataTable dt = DataAccessLayer.ExecuteQuery(query, sqlcmd);

                foreach (DataRow dr in dt.Rows)
                {
                    cmbintake.Items.Add(dr[0].ToString());
                }

                //cmbintake.DataSource = dt;
                //cmbintake.DisplayMember = "Intake";
                //cmbintake.ValueMember = "Intake";
                cmbintake.Text = "";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void pbclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmbintake_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(cmbintake.SelectedItem.ToString()))
                {
                    cmbcadetname.Items.Clear();
                    SqlCommand sqlcmd = new SqlCommand();
                    string query = "SELECT u.Id, u.Name FROM KDUusers u, KDUcadetinfo c WHERE u.Id = c.Id and c.Intake = @Intake";

                    DataAccessLayer.AddParameters(sqlcmd, "@Intake", SqlDbType.Int, cmbintake.SelectedItem.ToString());
                    DataTable dt = DataAccessLayer.ExecuteQuery(query, sqlcmd);

                    foreach (DataRow dr in dt.Rows)
                    {
                        ComboboxItem citem = new ComboboxItem();
                        citem.Value = dr[0].ToString();
                        citem.Text = dr[1].ToString();
                        cmbcadetname.Items.Add(citem);
                        
                    }
                    //cmbcadetname.DataSource = dt;
                    //cmbcadetname.DisplayMember = "Name";
                    //cmbcadetname.ValueMember = "Id";
                    cmbcadetname.Text = "";
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cmbcadetname_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(cmbcadetname.SelectedItem.ToString()))
                {

                    string query = @"SELECT u.Name,u.Birthday,u.NICno,u.Contactno,u.Hometown,u.Emailaddress,u.Emergencycontactname,
                u.Emergencycontacttelephoneno,r.Religion,n.Nationality,g.Gendertype,i.Userphoto from KDUusers u, KDUgenders g, KDUnationality n,KDUreligion r,KDUcadetinfo i where 
                u.GenderId=g.Id and u.NationalityId=n.Id and i.Id=u.Id and u.ReligionId=r.Id and u.Id = @Id ";
                    SqlCommand sqlcmd = new SqlCommand();

                    DataAccessLayer.AddParameters(sqlcmd, "@Id", SqlDbType.Int, (cmbcadetname.SelectedItem as ComboboxItem).Value.ToString());
                    DataTable dt = DataAccessLayer.ExecuteQuery(query, sqlcmd);

                    if ((dt != null) && (dt.Rows.Count == 1))
                    {
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
                            pbcadetview.Image = Image.FromStream(ms);
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
                    else
                    {
                        MessageBox.Show("No matching data");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void pbprofile_Click(object sender, EventArgs e)
        {
            FrmOfficerprofile pro = new FrmOfficerprofile(oofficer);
            pro.Show();
            this.Close();
        }

        private void lblprofile_Click(object sender, EventArgs e)
        {
            FrmOfficerprofile pro = new FrmOfficerprofile(oofficer);
            pro.Show();
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
            FrmOfficerHome hm = new FrmOfficerHome(oofficer);
            hm.Show();
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
    

