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
    public partial class AdminDelete : Form
    {
        public AdminDelete(string useremail)
        {
            InitializeComponent();
            auseremail.Text = useremail;
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
        private void Delete_student_Account_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {

                if (droll.Text == "")
                {
                    MessageBox.Show("Plzzz fill mandatoiry field...!");
                }
                else
                {
                    string screateaccountq = "DELETE FROM studentaccount WHERE roll= '" + droll.Text.ToString() + "' ";
                    SqlCommand cm = new SqlCommand(screateaccountq, con);
                    if (cm.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Account Delete...!");
                        this.Hide();
                        AdminProfile adminProfile = new AdminProfile(auseremail.Text);
                        adminProfile.Show();
                        
                    }
                    else
                    {
                        MessageBox.Show("Account Not Delete. Plzz Try Again...!");
                    }
                }


            }
        }

        private void Delete_Teacher_Account_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {

                if (depin.Text == "")
                {
                    MessageBox.Show("Plzzz fill mandatoiry field...!");
                }
                else
                {
                    string sdeleteaccountq = "DELETE FROM emplyeetable WHERE epin= '" + depin.Text.ToString() + "' ";
                    SqlCommand cm = new SqlCommand(sdeleteaccountq, con);

                    string sdeleteaccountq1 = "DELETE FROM teacheraccount WHERE epin= '" + depin.Text.ToString() + "' ";
                    SqlCommand cmd = new SqlCommand(sdeleteaccountq1, con);

                    if (cm.ExecuteNonQuery() == 1 && cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Account Delete...!");
                        this.Hide();
                        AdminProfile adminProfile = new AdminProfile(auseremail.Text);
                        adminProfile.Show();

                    }
                    else
                    {
                        MessageBox.Show("Account Not Delete. Plzz Try Again...!");
                    }
                }


            }
        }
    }
}
