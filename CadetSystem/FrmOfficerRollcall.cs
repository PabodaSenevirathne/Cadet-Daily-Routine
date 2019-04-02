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
    public partial class FrmOfficerRollcall : Form
    {
        Officer oofficer;
        public FrmOfficerRollcall(Officer officer)
        {
            oofficer = officer;
            InitializeComponent();
        }

        private void lblprofile_Click(object sender, EventArgs e)
        {
            FrmOfficerprofile pro = new FrmOfficerprofile(oofficer);
            pro.Show();
            this.Close();
        }

        private void pbprofile_Click(object sender, EventArgs e)
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
            FrmOfficerHome off = new FrmOfficerHome(oofficer);
            off.Show();
            this.Close();

        }

       

        private void FrmOfficerRollcall_Load(object sender, EventArgs e)
        {
            
            lbllogger.Text = oofficer.Name;
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                string query = "Select distinct Intake from KDUcadetinfo ";
                DataTable dt = DataAccessLayer.ExecuteQuery(query, sqlcmd);

                cmbintake.DataSource = dt;
                cmbintake.DisplayMember = "Intake";
                cmbintake.Text = "";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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

        private void pbreports_Click(object sender, EventArgs e)
        {
            FrmOfficerReports rpt = new FrmOfficerReports(oofficer);
            rpt.Show();
            this.Close();
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbintake.Text == "")
                {
                    MessageBox.Show("Please select an Intake");
                }
                else
                {


                    string query = "SELECT Totalcount,Presentcount,Absentcount,Submittedby,SubmittedOn from KDUrollcall  where Intake = @Intake and Rollcalldate = @Rollcalldate";

                    SqlCommand sqlcmd = new SqlCommand();
                    DataAccessLayer.AddParameters(sqlcmd, "@Rollcalldate", SqlDbType.DateTime, dtpdate.Value.ToString("yyyy-MM-dd"));
                    DataAccessLayer.AddParameters(sqlcmd, "@Intake", SqlDbType.Int, cmbintake.Text);
                    DataTable dt = DataAccessLayer.ExecuteQuery(query, sqlcmd);

                    //if ((dt != null))
                    if ((dt != null) && (dt.Rows.Count > 0))
                    {

                        lblsubname.Text = dt.Rows[0]["Submittedby"].ToString();
                        lblsubdate.Text = dt.Rows[0]["SubmittedOn"].ToString();
                        lbltotal.Text = dt.Rows[0]["Totalcount"].ToString();
                        lblpresent.Text = dt.Rows[0]["Presentcount"].ToString();
                        lblabsent.Text = dt.Rows[0]["Absentcount"].ToString();

                        

                        lblsubname.Visible = true;
                        lblsubdate.Visible = true;
                        lbltotal.Visible = true;
                        lblpresent.Visible = true;
                        lblabsent.Visible = true;
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
            try
            {
              
                    string query = "select d.Absentname from KDUrollcalldetails d, KDUrollcall r where r.Id=d.RollcallId and r.Intake = @Intake and r.Rollcalldate = @Rollcalldate";

                    SqlCommand sqlcmd = new SqlCommand();
                    DataAccessLayer.AddParameters(sqlcmd, "@Rollcalldate", SqlDbType.DateTime, dtpdate.Value.ToString("yyyy-MM-dd"));
                    DataAccessLayer.AddParameters(sqlcmd, "@Intake", SqlDbType.Int, cmbintake.Text);

                    DataTable dt = DataAccessLayer.ExecuteQuery(query, sqlcmd);
                    dgrollcall.DataSource = dt;



                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private void lblcadet_Click(object sender, EventArgs e)
        {
            FrmOfficerCadetView cdtvw = new FrmOfficerCadetView(oofficer);
            cdtvw.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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

