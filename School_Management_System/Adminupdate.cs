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

namespace finalproject
{
    public partial class Adminupdate : Form
    {
        public Adminupdate(string ademail)
        {
            InitializeComponent();
            auseremail.Text = ademail;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Exit_MouseEnter(object sender, EventArgs e)
        {
            Exit.ForeColor = Color.Red;
        }

        private void Exit_MouseLeave(object sender, EventArgs e)
        {
            Exit.ForeColor = Color.Black;
        }

        public string conString = "Data Source=AVIJIT-PC\\AVIJIT;Initial Catalog=sms;Integrated Security=True";
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {

                if (autname.Text == "" || autemail.Text == "" || autphone.Text == "" || autpin.Text == "" || autpass.Text == "" || autconpass.Text == "")
                {
                    MessageBox.Show("Plzzz fill mandatoiry field...!");
                }
                else
                {
                    string screateaccountq = "update teacheraccount set uname='" + autname.Text.ToString() + "', email='" + autemail.Text.ToString() + "', phone='" + autphone.Text.ToString() + "', pass='" + autpass.Text.ToString() + "', conpass='" + autconpass.Text.ToString() + "' where epin='" + autpin.Text.Trim() + "'";
                    SqlCommand cm = new SqlCommand(screateaccountq, con);
                    if (cm.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Data Update...!");
                        this.Hide();
                        AdminProfile adminProfile = new AdminProfile(auseremail.Text);
                        adminProfile.Show();

                    }
                    else
                    {
                        MessageBox.Show("Data not Update...!");
                    }
                }


            }
        }

        private void admin_student_update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {

                if (ausname.Text == "" || ausemail.Text == "" || ausphone.Text == "" || ausroll.Text == "" || ausnpass.Text == "" || ausconpass.Text == "")
                {
                    MessageBox.Show("Plzzz fill mandatoiry field...!");
                }
                else
                {
                    string screateaccountq = "update studentaccount set uname='" + ausname.Text.ToString() + "', email='" + ausemail.Text.ToString() + "', phone='" + ausphone.Text.ToString() + "', pass='" + ausnpass.Text.ToString() + "', conpass='" + ausconpass.Text.ToString() + "' where roll='" + ausroll.Text.Trim() + "'";
                    SqlCommand cm = new SqlCommand(screateaccountq, con);
                    if (cm.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Data Update...!");
                        this.Hide();
                        AdminProfile adminProfile = new AdminProfile(auseremail.Text);
                        adminProfile.Show();

                    }
                    else
                    {
                        MessageBox.Show("Data not Update...!");
                    }
                }


            }
        }
    }
}
