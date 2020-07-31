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
    public partial class ShowDetails : Form
    {
        public ShowDetails(string useremail)
        {
            InitializeComponent();
            ademail.Text = useremail;
        }

        public string conString = "Data Source=AVIJIT-PC\\AVIJIT;Initial Catalog=sms;Integrated Security=True";
        private void roll_submit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter("select uname,roll,email,class,phone,dob from studentaccount where roll= '" + proll.Text.Trim() + "'", con);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dataGridView1.DataSource = dtbl;
                dataGridView1.AutoGenerateColumns = false;


                SqlDataAdapter sqlDar = new SqlDataAdapter("select course,day,stime,etime,teacher from routinetable where roll= '" + proll.Text.Trim() + "'", con);
                DataTable dtblr = new DataTable();
                sqlDar.Fill(dtblr);
                dataGridView2.DataSource = dtblr;
                dataGridView2.AutoGenerateColumns = false;


            }
        }

        private void Back_Admin_account_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminProfile adminProfile = new AdminProfile(ademail.Text);
            adminProfile.Show();
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

        
    }
}
