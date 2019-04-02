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
    public partial class FrmCadetParadeView : Form
    {
        Ocadet cadet;
        public FrmCadetParadeView(Ocadet ocadet)
        {
            cadet = ocadet;
            InitializeComponent();
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmParadeView_Load(object sender, EventArgs e)
        {
            lbllogger.Text = cadet.Name;
            try
            {
                string query = "SELECT SVCCadets,Onparade,Notonparade,AttendA,AttendB,AttendC,ExPT,Sickreports,MIroom,Hospital,Leave,ExtraClasses,Others from KDUparadestate where Paradedate = @Paradedate";

                SqlCommand sqlcmd = new SqlCommand();
                DataAccessLayer.AddParameters(sqlcmd, "@Paradedate", SqlDbType.DateTime,cadet.TodayDate);
                DataTable dt = DataAccessLayer.ExecuteQuery(query, sqlcmd);
                if ((dt != null) && (dt.Rows.Count == 1))
                {

                    lblcountsvc.Text = dt.Rows[0]["SVCCadets"].ToString();
                    lblcounton.Text = dt.Rows[0]["Onparade"].ToString();
                    lblcountnot.Text = dt.Rows[0]["Notonparade"].ToString();
                    lblcountA.Text = dt.Rows[0]["AttendA"].ToString();
                    lblcountB.Text = dt.Rows[0]["AttendB"].ToString();
                    lblcountC.Text = dt.Rows[0]["AttendC"].ToString();
                    lblcountexpt.Text = dt.Rows[0]["ExPT"].ToString();
                    lblcountsick.Text = dt.Rows[0]["Sickreports"].ToString();
                    lblcountmi.Text = dt.Rows[0]["MIroom"].ToString();
                    lblcounthospital.Text = dt.Rows[0]["Hospital"].ToString();
                    lblcountleave.Text = dt.Rows[0]["Leave"].ToString();
                    lblcountextra.Text = dt.Rows[0]["ExtraClasses"].ToString();
                    lblotherdetails.Text = dt.Rows[0]["Others"].ToString();

                    lblotherdetails.MaximumSize = new Size(400, 0);
                    lblotherdetails.AutoSize = true;

                    lblcountsvc.Visible = true;
                    lblcounton.Visible = true;
                    lblcountnot.Visible = true;
                    lblcountA.Visible = true;
                    lblcountB.Visible = true;
                    lblcountC.Visible = true;
                    lblcountexpt.Visible = true;
                    lblcountsick.Visible = true;
                    lblcountmi.Visible = true;
                    lblcounthospital.Visible = true;
                    lblcountleave.Visible = true;
                    lblcountextra.Visible = true;
                    lblotherdetails.Visible = true;
                }
                else
                {
                    MessageBox.Show("No data found");

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
           

        }
        private void pbclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblhome_Click(object sender, EventArgs e)
        {
            FrmCadetHome hm = new FrmCadetHome(cadet);
            hm.Show();
            this.Close();
        }

        private void pbhome_Click(object sender, EventArgs e)
        {
            FrmCadetHome hm = new FrmCadetHome(cadet);
            hm.Show();
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

        private void lblparade_Click(object sender, EventArgs e)
        {
            FrmCadetParadestate prd = new FrmCadetParadestate(cadet);
            prd.Show();
            this.Close();
        }

        private void pbparade_Click(object sender, EventArgs e)
        {
            FrmCadetParadestate prd = new FrmCadetParadestate(cadet);
            prd.Show();
            this.Close();
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
    }
}
