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
    public partial class SigninForm : Form
    {
        public SigninForm()
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

        private void label10_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginform = new LoginForm();
            loginform.Show();
        }

        public string conString = "Data Source=AVIJIT-PC\\AVIJIT;Initial Catalog=sms;Integrated Security=True";
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                if (susername.Text == "" || sroll.Text == "" || spass.Text == "" || sconpass.Text == "")
                {
                    MessageBox.Show("Plzzz fill mandatoiry field...!");
                }
                else if (tusername.Text != "" || tsubject.Text != "" || temail.Text != "" || tgender.Text != "" || tphone.Text != "" || tpass.Text != "" || tconpass.Text != "" || tepin.Text != "") 
                {
                    MessageBox.Show("You fill Unnecessary field Plzzz Clear it...!");
                }
                else
                {
                    string screateaccountq = "insert into studentaccount(uname,roll,email,gender,class,phone,pass,conpass,dob)values('" + susername.Text.ToString() + "','" + sroll.Text.ToString() + "','" + semail.Text.ToString() + "','" + sgender.Text.ToString() + "','" + sclass.Text.ToString() + "','" + sphone.Text.ToString() + "','" + spass.Text.ToString() + "','" + sconpass.Text.ToString() + "','" + sdob.Text.ToString() + "')";
                    SqlCommand cm = new SqlCommand(screateaccountq, con);
                    cm.ExecuteNonQuery();

                    MessageBox.Show("Your Account is Ready. Now Log In Your Account ...!");

                    this.Hide();
                    LoginForm loginform = new LoginForm();
                    loginform.Show();
                    //clear();
                }

            }
        }

        private void TeacherCreateAccount_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                if (tusername.Text == "" || temail.Text == "" || tpass.Text == "" || tconpass.Text == "" || tepin.Text == "")
                {
                    MessageBox.Show("Plzzz fill mandatoiry field...!");
                }
                else if (susername.Text != "" || sroll.Text != "" || semail.Text != "" || sgender.Text != "" || sclass.Text != "" || sphone.Text != "" || spass.Text != "" || sconpass.Text != "")
                {
                    MessageBox.Show("You fill Unnecessary field Plzzz Clear it...!");
                }
                else
                {
                    string verificationq = "select * from emplyeetable where epin= '" + tepin.Text.Trim() + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(verificationq, con);
                    DataTable db = new DataTable();
                    sda.Fill(db);
                    if (db.Rows.Count == 1)
                    {
                        string qu = "insert into teacheraccount(uname,sub,email,gender,jdate,phone,pass,conpass,epin)values('" + tusername.Text.ToString() + "','" + tsubject.Text.ToString() + "','" + temail.Text.ToString() + "','" + tgender.Text.ToString() + "','" + tjdate.Text.ToString() + "','" + tphone.Text.ToString() + "','" + tpass.Text.ToString() + "','" + tconpass.Text.ToString() + "','" + tepin.Text.ToString() + "')";
                        SqlCommand cm = new SqlCommand(qu, con);
                        cm.ExecuteNonQuery();

                        MessageBox.Show("Your Account is Ready. Now Log In Your Account ...!");

                        this.Hide();
                        LoginForm loginform = new LoginForm();
                        loginform.Show();
                        //clear();
                    }
                    else
                    {
                        MessageBox.Show("Plzzz Enter Valid Emplyee Pin..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }

            }
        }
    }
}
