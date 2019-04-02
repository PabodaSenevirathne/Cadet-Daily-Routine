using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadetSystem
{
    public partial class FrmAdminHome : Form
    {
        Instructor admin;
        public FrmAdminHome(Instructor kadmin)
        {
            admin = kadmin;
            InitializeComponent();
        }

        private void FrmAdminHome_Load(object sender, EventArgs e)
        {
            lbllogger.Text = admin.Name;
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
    }
}
