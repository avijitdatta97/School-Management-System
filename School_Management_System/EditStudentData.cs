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
    public partial class EditStudentData : Form
    {
        public EditStudentData()
        {
            InitializeComponent();
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

                if (udname.Text == "" || udemail.Text == "" || udphone.Text == "" || udopass.Text == "" || udnpass.Text == "" || udconpass.Text == "")
                {
                    MessageBox.Show("Plzzz fill mandatoiry field...!");
                }
                else
                {
                    string screateaccountq = "update studentaccount set uname='" + udname.Text.ToString() + "', email='" + udemail.Text.ToString() + "', phone='" + udphone.Text.ToString() + "', pass='" + udnpass.Text.ToString() + "', conpass='" + udconpass.Text.ToString() + "' where pass='" + udopass.Text.Trim() + "'";
                    SqlCommand cm = new SqlCommand(screateaccountq, con);
                    if (cm.ExecuteNonQuery() == 1)
                    {
                        this.Hide();
                        StudentProfile studentprofile = new StudentProfile(udemail.Text);
                        studentprofile.Show();
                        //MessageBox.Show("Data Update...!");
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
