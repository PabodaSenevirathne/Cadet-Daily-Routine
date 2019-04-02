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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btngo_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtusername.Text == "")
                {
                    MessageBox.Show("User ID is required");
                }
                else if (txtpassword.Text == "")
                {
                    MessageBox.Show("Password is required");
                }
                else if (txtusername.Text.Length > 9)
                {
                    MessageBox.Show("Please input valid username");
                }
                else
                {
                    //Username ok. Password ok. Now Login user.
                    string query = @"SELECT Id, Userid,Userpassword,Name, UsertypeId, GETDATE() AS 'TodayDate' 
                        FROM KDUusers WHERE Userid = @Userid AND Userpassword = @Userpassword AND UserStatusId = " + UserStatusId.Active.ToString() ;

                    SqlCommand sqlcmd = new SqlCommand();
                    DataAccessLayer.AddParameters(sqlcmd, "@Userid", SqlDbType.Int, txtusername.Text);
                    DataAccessLayer.AddParameters(sqlcmd, "@Userpassword", SqlDbType.NVarChar, txtpassword.Text);
                    DataTable dt = DataAccessLayer.ExecuteQuery(query, sqlcmd);
                    //Got data

                    if ((dt != null) && (dt.Rows.Count == 1))
                    {
                        //user found
                        int usertypeid = Convert.ToInt32(dt.Rows[0]["UsertypeId"]);
                        
                        if (usertypeid == UserTypeId.Cadet)
                        {
                            Ocadet c = new Ocadet();
                            c.Id = Convert.ToInt32(dt.Rows[0]["Id"]);
                            c.Name = dt.Rows[0]["Name"].ToString();
                            c.Userid = Convert.ToInt32(dt.Rows[0]["Userid"]);
                            c.Password = dt.Rows[0]["Userpassword"].ToString();
                            c.Intake = GetCadetIntake(Convert.ToInt32(dt.Rows[0]["Id"]));
                            c.TodayDate = Convert.ToDateTime(dt.Rows[0]["TodayDate"]).ToString("yyyy-MM-dd");


                            FrmCadetHome cdthm = new FrmCadetHome(c);
                            cdthm.Show();
                            this.Close();
                        }
                        else if (usertypeid == UserTypeId.Officer)
                        {
                            Officer o = new Officer();
                            o.Id = Convert.ToInt32(dt.Rows[0]["Id"]);
                            o.Name = dt.Rows[0]["Name"].ToString();
                            o.Userid = Convert.ToInt32(dt.Rows[0]["Userid"]);
                            o.Password = dt.Rows[0]["Userpassword"].ToString();
                            o.TodayDate = Convert.ToDateTime(dt.Rows[0]["TodayDate"]).ToString("yyyy-MM-dd");

                            FrmOfficerHome ofhm = new FrmOfficerHome(o);
                            ofhm.Show();
                            this.Close();
                        }
                        else if (usertypeid == UserTypeId.Instructor)
                        {
                            Instructor a = new Instructor();
                            a.Id = Convert.ToInt32(dt.Rows[0]["Id"]);
                            a.Name = dt.Rows[0]["Name"].ToString();
                            a.Userid = Convert.ToInt32(dt.Rows[0]["Userid"]);
                            a.Password = dt.Rows[0]["Userpassword"].ToString();

                            FrmAdminHome adhm = new FrmAdminHome(a);
                            adhm.Show();
                            this.Close();
                        }
                    }
                    else
                    {
                        //user not found
                        txtusername.Clear();
                        txtpassword.Clear();
                        MessageBox.Show("Check your Login Details!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
          
        }

    
      
     

        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lnklblpassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            FrmForgotPassword rst = new FrmForgotPassword();
            rst.Show();
            this.Close();
        }




        private int GetCadetIntake(int id)
        {
            int intake = 0;
            string query = "SELECT Intake FROM KDUcadetInfo WHERE Id = @Id";

            SqlCommand sqlcmd = new SqlCommand();
            DataAccessLayer.AddParameters(sqlcmd, "@Id", SqlDbType.Int, id);
            DataTable dt = DataAccessLayer.ExecuteQuery(query, sqlcmd);
            //Got data
            if ((dt != null) && (dt.Rows.Count == 1))
            {
                intake = Convert.ToInt32(dt.Rows[0]["Intake"]);
            }
            return intake;
        }
    }
}

