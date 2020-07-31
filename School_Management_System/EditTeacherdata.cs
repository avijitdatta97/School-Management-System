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
    public partial class EditTeacherdata : Form
    {
        public EditTeacherdata()
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

                if (udtname.Text == "" || udtemail.Text == "" || udtphone.Text == "" || udtopass.Text == "" || udtnpass.Text == "" || udtconpass.Text == "")
                {
                    MessageBox.Show("Plzzz fill mandatoiry field...!");
                }
                else
                {
                    string screateaccountq = "update teacheraccount set uname='" + udtname.Text.ToString() + "', email='" + udtemail.Text.ToString() + "', phone='" + udtphone.Text.ToString() + "', pass='" + udtnpass.Text.ToString() + "', conpass='" + udtconpass.Text.ToString() + "' where pass='" + udtopass.Text.Trim() + "'";
                    SqlCommand cm = new SqlCommand(screateaccountq, con);
                    if (cm.ExecuteNonQuery() == 1)
                    {
                        this.Hide();
                        TeacherProfile teacherProfile = new TeacherProfile(udtemail.Text);
                        teacherProfile.Show();
                        
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
