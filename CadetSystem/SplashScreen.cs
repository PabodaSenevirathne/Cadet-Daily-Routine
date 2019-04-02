using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadetSystem
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            
        }

        private void timerLoading_Tick(object sender, EventArgs e)
        {
            pgbarLoading.Increment(1);

            if(pgbarLoading.Value == 100)
            {
                timerLoading.Stop();             
                FrmLogin frlog = new FrmLogin();
                frlog.Show();
                this.Hide();
            }


        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void pgbarLoading_Click(object sender, EventArgs e)
        {

        }
    }
}
