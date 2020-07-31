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
    public partial class StudentProfile : Form
    {
        public StudentProfile(string useremail)
        {
            InitializeComponent();
            studentname.Text = useremail;
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginform = new LoginForm();
            loginform.Show();
        }

        public string conString = "Data Source=AVIJIT-PC\\AVIJIT;Initial Catalog=sms;Integrated Security=True";
        private void StudentProfile_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter("select uname,roll,email,class,phone,dob from studentaccount where email= '" + studentname.Text.Trim() + "'", con);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dataGridView1.DataSource = dtbl;
                dataGridView1.AutoGenerateColumns = false;

               
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter("select course,day,stime,etime,teacher from routinetable where roll= '" + proll.Text.Trim() + "'", con);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dataGridView2.DataSource = dtbl;
                dataGridView2.AutoGenerateColumns = false;

                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditStudentData editStudentData = new EditStudentData();
            editStudentData.Show();
        }
    }
}
