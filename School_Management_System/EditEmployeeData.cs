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
    public partial class EditEmployeeData : Form
    {
        public EditEmployeeData(string usermail)
        {
            InitializeComponent();
            ademail.Text = usermail;
        }

        public string conString = "Data Source=AVIJIT-PC\\AVIJIT;Initial Catalog=sms;Integrated Security=True";
        private void Update_Employee_data_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {

                if (eename.Text == "" || eeemail.Text == "" || eephone.Text == "" || eeepin.Text == "" )
                {
                    MessageBox.Show("Plzzz fill mandatoiry field...!");
                }
                else
                {
                    string screateaccountq = "update emplyeetable set name='" + eename.Text.ToString() + "', phone='" + eephone.Text.ToString() + "', email='" + eeemail.Text.ToString() + "' where epin='" + eeepin.Text.Trim() + "'";
                    SqlCommand cm = new SqlCommand(screateaccountq, con);
                    if (cm.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Data Update...!");
                        this.Hide();
                        AdminProfile adminProfile = new AdminProfile(ademail.Text);
                        adminProfile.Show();  
                    }
                    else
                    {
                        MessageBox.Show("Data not Update...!");
                    }
                }


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

        private void Create_Employee_Button_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                if (ename.Text == "" || ephnone.Text == "" || eemail.Text == "" || eepin.Text == "" || ejdate.Text == "")
                {
                    MessageBox.Show("Plzzz fill mandatoiry field...!");
                }
              
                else
                {
                    string screateaccountq = "insert into emplyeetable(name,jdate,epin,phone,email) values('" + ename.Text.ToString() + "','" + ejdate.Text.ToString() + "','" + eepin.Text.ToString() + "','" + ephnone.Text.ToString() + "','" + eemail.Text.ToString() + "')";
                    SqlCommand cm = new SqlCommand(screateaccountq, con);
                    if (cm.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Your Account is Ready...!");

                        this.Hide();
                        AdminProfile adminProfile = new AdminProfile(ademail.Text);
                        adminProfile.Show();
                    }
                    else {
                        MessageBox.Show("Your Account is not Ready. Plzz Try Again...!");
                    }

                    
                    
                }
            }
        }
    }
}
