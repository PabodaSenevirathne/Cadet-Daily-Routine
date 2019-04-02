using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CadetSystem
{
    
    public partial class FrmOfficerAnnouncements : Form
    {
        Officer oofficer;
        
        public FrmOfficerAnnouncements(Officer officer)
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

        private void FrmOfficerAnnouncements_Load(object sender, EventArgs e)
        {
            lbllogger.Text = oofficer.Name;
            lbldate.Text = oofficer.TodayDate;

            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                string query = "Select distinct Intake from KDUcadetinfo ";
                DataTable dt = DataAccessLayer.ExecuteQuery(query, sqlcmd);

                foreach (DataRow dr in dt.Rows)
                {
                    cmbintake.Items.Add(dr[0].ToString());
                }

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

        private void btnSend_Click(object sender, EventArgs e)
        {

            DataTable dt = GetAllCadetEmailList(cmbintake.SelectedItem.ToString());
            string[] receipients = new string[dt.Rows.Count];
            for(int i=0; i < dt.Rows.Count; i++)
            {
                receipients[i] = dt.Rows[i][0].ToString();
            }



            EmailSender.SendEmail(txtsubject.Text, txtbody.Text + "\r\n\r\n Sent By:" + oofficer.Name +"\r\n General Sir John Korelawala Defence University, \r\n Southern Campus.", receipients);

            MessageBox.Show("Message Sent.");

            txtsubject.Text = "";
            txtbody.Text = "";
            cmbintake.Text = "";
        }


        private DataTable GetAllCadetEmailList(string intakeid)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                string query = "Select u.Emailaddress from KDUusers u, KDUcadetinfo c where u.Id=c.Id and c.Intake = @Intake";
                DataAccessLayer.AddParameters(sqlcmd, "@Intake", SqlDbType.Int, intakeid);
                return DataAccessLayer.ExecuteQuery(query, sqlcmd);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No data found");
                return null;
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

        
    }
}
