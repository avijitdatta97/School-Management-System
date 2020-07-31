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
    public partial class CreateRoutine : Form
    {
        public CreateRoutine(string useremail)
        {
            InitializeComponent();
            uemail.Text = useremail;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
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
            Exit.ForeColor = Color.Black;
        }

        public string conString = "Data Source=AVIJIT-PC\\AVIJIT;Initial Catalog=sms;Integrated Security=True";
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                if (crname.Text == "" || crclass.Text == "" || crroll.Text == "" || crcourse.Text == "" || crday.Text == "" || crstime.Text == "" || cretime.Text == "" || crsection.Text == "")
                {
                    MessageBox.Show("Plzzz Fill All Field...!");
                }
                else
                {
                    string routineq = "insert into routinetable(name,class,roll,course,day,stime,etime,teacher,section)values('" + crname.Text.ToString() + "','" + crclass.Text.ToString() + "','" + crroll.Text.ToString() + "','" + crcourse.Text.ToString() + "','" + crday.Text.ToString() + "','" + crstime.Text.ToString() + "','" + cretime.Text.ToString() + "','" + crteacher.Text.ToString() + "','" + crsection.Text.ToString() + "')";
                    SqlCommand cm = new SqlCommand(routineq, con);
                    if (cm.ExecuteNonQuery() == 1)
                    {
                        this.Hide();
                        TeacherProfile teacherProfile = new TeacherProfile(uemail.Text);
                        teacherProfile.Show();
                    }
                    else
                    {
                        MessageBox.Show("Routine does not create...!");
                    }



                    //MessageBox.Show("Successfully Registered...!");
                    //clear();
                }

            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeacherProfile teacherProfile = new TeacherProfile(uemail.Text);
            teacherProfile.Show();
        }
    }
}
