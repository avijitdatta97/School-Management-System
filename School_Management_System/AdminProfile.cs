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
    public partial class AdminProfile : Form
    {
        public AdminProfile(string useremail)
        {
            InitializeComponent();
            adminemail.Text = useremail;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateCourse createcourse = new CreateCourse(adminemail.Text);
            createcourse.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginform = new LoginForm();
            loginform.Show();
        }

        public string conString = "Data Source=AVIJIT-PC\\AVIJIT;Initial Catalog=sms;Integrated Security=True";
        private void AdminProfile_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter("select name,email,jdate from adminaccount where email= '" + adminemail.Text.Trim() + "'", con);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dataGridView1.DataSource = dtbl;
                dataGridView1.AutoGenerateColumns = false;
            }

            
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditAdminData editAdminData = new EditAdminData();
            editAdminData.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDelete adminDelete = new AdminDelete(adminemail.Text);
            adminDelete.Show();
        }

        private void aupdateaccount_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Adminupdate adminupdate = new Adminupdate(adminemail.Text);
            adminupdate.Show();
        }

        private void Edit_Employee_Panel_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditEmployeeData editEmployeeData = new EditEmployeeData(adminemail.Text);
            editEmployeeData.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowDetails showDetails = new ShowDetails(adminemail.Text);
            showDetails.Show();
        }
    }
}
