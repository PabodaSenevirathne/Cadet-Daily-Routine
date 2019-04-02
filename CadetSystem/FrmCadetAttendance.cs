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

    public partial class FrmCadetAttendance : Form
    {
        Ocadet cadet;
        DataTable dtAllCadets;
        DataTable dtAbsentCadets;

        public FrmCadetAttendance(Ocadet ocadet)
        {
            cadet = ocadet;
            InitializeComponent();
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

        private DataTable GetAllCadetList()
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                string query = "Select u.Name from KDUusers u, KDUcadetinfo c where u.Id=c.Id and c.Intake = @Intake";
                DataAccessLayer.AddParameters(sqlcmd, "@Intake", SqlDbType.Int, cadet.Intake);
                return DataAccessLayer.ExecuteQuery(query, sqlcmd);               
            }
            catch (Exception ex)
            {
                MessageBox.Show("No data found");
                return null;
            }
        }

        private void FrmCadetAttendance_Load(object sender, EventArgs e)
        {
            lbllogger.Text = cadet.Name;
            lbldate.Text = cadet.TodayDate;

            dtAbsentCadets = new DataTable();
            dtAbsentCadets.Columns.Add("Name", typeof(string));

            dtAllCadets = new DataTable();
            dtAllCadets = GetAllCadetList();

            foreach (DataRow dr in dtAllCadets.Rows)
            {
                cmbcadetname.Items.Add(dr[0].ToString());
            }

            //cmbcadetname.DataSource = dtAllCadets;
            //cmbcadetname.DisplayMember = "Name";
            //cmbcadetname.ValueMember = "Name";
            cmbcadetname.Text = "";

            lbltotal.Text = dtAllCadets.Rows.Count.ToString();
            lblpresent.Text = dtAllCadets.Rows.Count.ToString();
            lblabsent.Text = "0";
           
        }
     

        private void btnselect_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbcadetname.Text == "")
                {
                    MessageBox.Show("Select Absent Cadets ");
                }
                else
                {
                    cmbcadetname.Enabled = false;

                    string absentcadet = cmbcadetname.SelectedItem.ToString();
                    dtAbsentCadets.Rows.Add(absentcadet);
                    dgattendance.DataSource = dtAbsentCadets;
                    dgattendance.Refresh();
                    
                    cmbcadetname.Items.Remove(cmbcadetname.SelectedItem);
                    cmbcadetname.SelectedText = "";

                    int p = Convert.ToInt32(lblpresent.Text);
                    int a = Convert.ToInt32(lblabsent.Text);

                    lblpresent.Text = (p - 1).ToString();
                    lblabsent.Text = (a + 1).ToString();

                    cmbcadetname.Enabled = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        
    }


        private void btnview_Click(object sender, EventArgs e)
        {
            FrmCadetAttendanceView attvw = new FrmCadetAttendanceView(cadet);
            attvw.Show();
            this.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            
           
                SqlCommand sqlcmd = new SqlCommand();
                string query = @"INSERT INTO KDUattendance(Attendancedate,Intake,Totalcount,Presentcount,Absentcount,Submittedby,SubmittedOn)VALUES(@Attendancedate,@Intake,@Totalcount,@Presentcount,@Absentcount,@Submittedby,GETDATE())";

                DataAccessLayer.AddParameters(sqlcmd, "@Attendancedate", SqlDbType.DateTime, cadet.TodayDate);
                DataAccessLayer.AddParameters(sqlcmd, "@Intake", SqlDbType.Int, cadet.Intake);
                DataAccessLayer.AddParameters(sqlcmd, "@Totalcount", SqlDbType.Int, lbltotal.Text);
                DataAccessLayer.AddParameters(sqlcmd, "@Presentcount", SqlDbType.Int, lblpresent.Text);
                DataAccessLayer.AddParameters(sqlcmd, "@Absentcount", SqlDbType.Int, lblabsent.Text);
                DataAccessLayer.AddParameters(sqlcmd, "@Submittedby", SqlDbType.NVarChar, cadet.Name);

            DataAccessLayer.ExecuteNonQuery(query, sqlcmd);

                SqlCommand sqlcmd0 = new SqlCommand();
                string query0 = "SELECT Id FROM KDUattendance WHERE Intake=@Intake AND Attendancedate=@Attendancedate";
                DataAccessLayer.AddParameters(sqlcmd0, "@Intake", SqlDbType.Int, cadet.Intake);
                DataAccessLayer.AddParameters(sqlcmd0, "@Attendancedate", SqlDbType.DateTime, cadet.TodayDate);
                

            DataTable dtid = DataAccessLayer.ExecuteQuery(query0, sqlcmd0);
                int attendanceid = 0;
                if ((dtid != null) && (dtid.Rows.Count > 0))
                {
                    attendanceid = Convert.ToInt32(dtid.Rows[0]["Id"]);
                }


                foreach (DataRow dr in dtAbsentCadets.Rows)
                {
                    SqlCommand sqlcmd1 = new SqlCommand();
                    string query1 = "INSERT INTO KDUattendancedetails(AttendanceId,Absentname)VALUES(@AttendanceId,@Absentname)";
                    DataAccessLayer.AddParameters(sqlcmd1, "@AttendanceId", SqlDbType.Int, attendanceid);
                    DataAccessLayer.AddParameters(sqlcmd1, "@Absentname", SqlDbType.NVarChar, dr[0].ToString());
                    
                DataAccessLayer.ExecuteNonQuery(query1, sqlcmd1);

                }
                MessageBox.Show("Saved Successfully");

                lbltotal.Text = "";
                lblpresent.Text = "";
                lblabsent.Text = "";
                dgattendance.Text = "";
              
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


            


