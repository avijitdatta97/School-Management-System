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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SigninForm signinform = new SigninForm();
            signinform.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void logbutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                if (logemail.Text == "" || logpass.Text == "" || logstatus.Text == "")
                {
                    MessageBox.Show("Plzzz fill mandatoiry field...!");
                }

                //Student
                else if (logstatus.Text == "Student")
                {
                    string logq = "select * from studentaccount where email= '" + logemail.Text.Trim() + "'and pass= '" + logpass.Text.Trim() + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(logq, con);
                    DataTable db = new DataTable();
                    sda.Fill(db);
                    if (db.Rows.Count == 1)
                    {
                        this.Hide();
                        StudentProfile studentprofile = new StudentProfile(logemail.Text);
                        studentprofile.Show();
                    }
                    else
                    {
                        MessageBox.Show("Login is not valied..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                //Teacher
                else if (logstatus.Text == "Teacher")
                {
                    string logq = "select * from teacheraccount where email= '" + logemail.Text.Trim() + "'and pass= '" + logpass.Text.Trim() + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(logq, con);
                    DataTable db = new DataTable();
                    sda.Fill(db);
                    if (db.Rows.Count == 1)
                    {
                        this.Hide();
                        TeacherProfile teacherprofile = new TeacherProfile(logemail.Text);
                        teacherprofile.Show();
                    }
                    else
                    {
                        MessageBox.Show("Login is not valied..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                // Admin
                else if (logstatus.Text == "Admin")
                {
                    string logq = "select * from adminaccount where email= '" + logemail.Text.Trim() + "'and pass= '" + logpass.Text.Trim() + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(logq, con);
                    DataTable db = new DataTable();
                    sda.Fill(db);
                    if (db.Rows.Count == 1)
                    {
                        this.Hide();
                        AdminProfile adminprofile = new AdminProfile(logemail.Text);
                        adminprofile.Show();
                    }
                    else
                    {
                        MessageBox.Show("Login is not valied..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else
                {
                    MessageBox.Show("Login is not valied..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
