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
    public partial class FrmCadetParadestate : Form
    {
        Ocadet cadet;
        public FrmCadetParadestate(Ocadet ocadet)
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



        private void btnsave_Click(object sender, EventArgs e)
        {
            
            if ( txtonparade.Text == "" || txtnotparade.Text == ""|| txtattendA.Text == "" 
                || txtattendB.Text == "" || txtattendC.Text == "" ||
                txtexpt.Text == "" || txtsickreports.Text == "" || txtmiroom.Text == "" 
                || txthospital.Text == "" || txtleave.Text == "" || txtextra.Text == "")

            {
                MessageBox.Show("Please fill the required fields.", "Message",MessageBoxButtons.RetryCancel,MessageBoxIcon.Warning);
            }
            else
            {

                SqlCommand sqlcmd = new SqlCommand();
                string query = @"INSERT INTO KDUparadestate (SVCCadets,Onparade,Notonparade,AttendA,AttendB,AttendC,ExPT,Sickreports,MIroom,
                    Hospital,Leave,ExtraClasses,Others,Paradedate,Intake,SubmittedBy,SubmittedOn)values (@SVCCadets,@Onparade,@Notonparade,@AttendA,@AttendB,@AttendC,@ExPT,@Sickreports,@MIroom,@Hospital,@Leave,@ExtraClasses,@Others,@Paradedate,@Intake,@SubmittedBy,GETDATE())";

                DataAccessLayer.AddParameters(sqlcmd, "@SVCCadets", SqlDbType.NVarChar, lblcount.Text);
                DataAccessLayer.AddParameters(sqlcmd, "@Onparade", SqlDbType.NVarChar, txtonparade.Text);
                DataAccessLayer.AddParameters(sqlcmd, "@Notonparade", SqlDbType.NVarChar, txtnotparade.Text);
                DataAccessLayer.AddParameters(sqlcmd, "@AttendA", SqlDbType.NVarChar, txtattendA.Text);
                DataAccessLayer.AddParameters(sqlcmd, "@AttendB", SqlDbType.NVarChar, txtattendB.Text);
                DataAccessLayer.AddParameters(sqlcmd, "@AttendC", SqlDbType.NVarChar, txtattendC.Text);
                DataAccessLayer.AddParameters(sqlcmd, "@ExPT", SqlDbType.NVarChar, txtexpt.Text);
                DataAccessLayer.AddParameters(sqlcmd, "@Sickreports", SqlDbType.NVarChar, txtsickreports.Text);
                DataAccessLayer.AddParameters(sqlcmd, "@MIroom", SqlDbType.NVarChar, txtmiroom.Text);
                DataAccessLayer.AddParameters(sqlcmd, "@Hospital", SqlDbType.NVarChar, txthospital.Text);
                DataAccessLayer.AddParameters(sqlcmd, "@Leave", SqlDbType.NVarChar, txtleave.Text);
                DataAccessLayer.AddParameters(sqlcmd, "@ExtraClasses", SqlDbType.NVarChar, txtextra.Text);
                DataAccessLayer.AddParameters(sqlcmd, "@Others", SqlDbType.NVarChar, txtotherdetails.Text);
                DataAccessLayer.AddParameters(sqlcmd, "@Intake", SqlDbType.Int, cadet.Intake);
                DataAccessLayer.AddParameters(sqlcmd, "@Paradedate", SqlDbType.DateTime, cadet.TodayDate);
                DataAccessLayer.AddParameters(sqlcmd, "@SubmittedBy", SqlDbType.NVarChar, cadet.Name);
                

                DataAccessLayer.ExecuteNonQuery(query, sqlcmd);
                MessageBox.Show("Saved Successfully");

                txtattendA.Text = "";
                txtattendB.Text = "";
                txtattendC.Text = "";
                txtsickreports.Text = "";
                txtexpt.Text = "";
                txtleave.Text = "";
                txtextra.Text = "";
                txtonparade.Text = "";
                txtnotparade.Text = "";
                txtmiroom.Text = "";
                txthospital.Text = "";
                txtotherdetails.Text = "";
            }
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

        private void FrmCadetParadestate_Load(object sender, EventArgs e)
        {
            lbllogger.Text = cadet.Name;
            lbldate.Text = cadet.TodayDate;

            try
            {
                SqlCommand sqlcmd1 = new SqlCommand();
                string query1 = "Select Count(u.Id) from KDUusers u, KDUcadetinfo c where  u.Id=c.Id and c.Intake= @Intake";
               
                DataAccessLayer.AddParameters(sqlcmd1, "@Intake", SqlDbType.Int, cadet.Intake);

                DataTable dt = DataAccessLayer.ExecuteQuery(query1, sqlcmd1);

                if ((dt != null) && (dt.Rows.Count > 0))
                {
                    lblcount.Text = dt.Rows[0][0].ToString();

                    lblcount.Visible = true;
                }
                else
                {
                    MessageBox.Show("No matching Data");
                }
              

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnview_Click(object sender, EventArgs e)
        {
            FrmCadetParadeView vwprd = new FrmCadetParadeView(cadet);
            vwprd.Show();
            this.Close();
        }
    }
}
