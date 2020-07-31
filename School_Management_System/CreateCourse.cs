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
    public partial class CreateCourse : Form
    {
        public CreateCourse(string adminemail)
        {
            InitializeComponent();
            auseremail.Text = adminemail;
        }

        private void label4_Click(object sender, EventArgs e)
        {

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
            Exit.ForeColor = Color.Red;
        }

        public string conString = "Data Source=AVIJIT-PC\\AVIJIT;Initial Catalog=sms;Integrated Security=True";
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                if (ccname.Text == "" || ccclass.Text == "" || ccsection.Text == "" || ccstime.Text == "" || ccetime.Text == "")
                {
                    MessageBox.Show("Plzzz Fill All Field...!");
                }
                else
                {
                    string coursecreateq = "insert into coursetable(cname,class,section,day,stime,etime)values('" + ccname.Text.ToString() + "','" + ccclass.Text.ToString() + "','" + ccsection.Text.ToString() + "','" + ccday.Text.ToString() + "','" + ccstime.Text.ToString() + "','" + ccetime.Text.ToString() + "')";
                    SqlCommand cm = new SqlCommand(coursecreateq, con);
                    cm.ExecuteNonQuery();

                    MessageBox.Show("Successfully Course Create...!");
                    this.Hide();
                    AdminProfile adminProfile = new AdminProfile(auseremail.Text);
                    adminProfile.Show();

                    
                    //clear();
                }

            }
        }


    }
}
