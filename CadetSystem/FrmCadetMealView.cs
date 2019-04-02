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
    public partial class FrmCadetMealView : Form
    { Ocadet cadet;

        public FrmCadetMealView(Ocadet ocadet)
        {
            cadet = ocadet;
            InitializeComponent();
        }

        private void FrmViewMeals_Load(object sender, EventArgs e)
        {
            lbllogger.Text = cadet.Name;
            try
            {
                string query = "SELECT Lunch,Dinner,Breakfast,Remarklunch,Remarkdinner,Remarkbreakfast,Comments from KDUmeals where Mealdate = @Mealdate";
                SqlCommand sqlcmd = new SqlCommand();
                DataAccessLayer.AddParameters(sqlcmd, "@Mealdate", SqlDbType.DateTime, cadet.TodayDate);
                
                DataTable dt = DataAccessLayer.ExecuteQuery(query, sqlcmd);

                if ((dt != null) && (dt.Rows.Count == 1))
                {
                    lbllunch.Text = dt.Rows[0]["Lunch"].ToString();
                    lbldinner.Text = dt.Rows[0]["Dinner"].ToString();
                    lblbreakfast.Text = dt.Rows[0]["Breakfast"].ToString();
                    lblremarks.Text = dt.Rows[0]["Remarklunch"].ToString();
                    lblcomments.Text = dt.Rows[0]["Comments"].ToString();  
                    lblremarks1.Text = dt.Rows[0]["Remarkdinner"].ToString();
                    lblremarks2.Text = dt.Rows[0]["Remarkbreakfast"].ToString();


                    lbllunch.MaximumSize= new Size(200,0);
                    lbllunch.AutoSize = true;
                    lbldinner.MaximumSize = new Size(200, 0);
                    lbldinner.AutoSize = true;
                    lblbreakfast.MaximumSize = new Size(200, 0);
                    lblbreakfast.AutoSize = true;

                    lbllunch.Visible = true;
                    lbldinner.Visible = true;
                    lblbreakfast.Visible = true;
                    lblremarks.Visible = true;
                    lblcomments.Visible = true;
                    lblremarks1.Visible = true;
                    lblremarks2.Visible = true;
                   
                }
                else
                {
                    
                    MessageBox.Show("No data found");
                  
                }

            }
            catch (Exception ex)
            {
                this.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmCadetMeals cdt = new FrmCadetMeals(cadet);
            cdt.Show();
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

        private void pbclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
