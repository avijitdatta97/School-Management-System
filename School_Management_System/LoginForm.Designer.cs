namespace finalproject
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.logbutton = new System.Windows.Forms.Button();
            this.lname = new System.Windows.Forms.Label();
            this.lpass = new System.Windows.Forms.Label();
            this.logemail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Label();
            this.logpass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.logstatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logbutton
            // 
            this.logbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logbutton.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logbutton.Location = new System.Drawing.Point(333, 381);
            this.logbutton.Name = "logbutton";
            this.logbutton.Size = new System.Drawing.Size(228, 67);
            this.logbutton.TabIndex = 0;
            this.logbutton.Text = "Log In";
            this.logbutton.UseVisualStyleBackColor = true;
            this.logbutton.Click += new System.EventHandler(this.logbutton_Click);
            // 
            // lname
            // 
            this.lname.AutoSize = true;
            this.lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname.Location = new System.Drawing.Point(109, 249);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(79, 29);
            this.lname.TabIndex = 1;
            this.lname.Text = "Email";
            // 
            // lpass
            // 
            this.lpass.AutoSize = true;
            this.lpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lpass.Location = new System.Drawing.Point(109, 316);
            this.lpass.Name = "lpass";
            this.lpass.Size = new System.Drawing.Size(128, 29);
            this.lpass.TabIndex = 2;
            this.lpass.Text = "Password";
            // 
            // logemail
            // 
            this.logemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logemail.Location = new System.Drawing.Point(271, 249);
            this.logemail.Name = "logemail";
            this.logemail.Size = new System.Drawing.Size(357, 38);
            this.logemail.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(76, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(661, 69);
            this.label3.TabIndex = 5;
            this.label3.Text = "Welcome to Our School";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(886, 105);
            this.panel1.TabIndex = 6;
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.Black;
            this.Exit.Location = new System.Drawing.Point(847, 10);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(30, 29);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "X";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            this.Exit.MouseEnter += new System.EventHandler(this.Exit_MouseEnter);
            this.Exit.MouseLeave += new System.EventHandler(this.Exit_MouseLeave);
            // 
            // logpass
            // 
            this.logpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logpass.Location = new System.Drawing.Point(271, 316);
            this.logpass.Name = "logpass";
            this.logpass.PasswordChar = '*';
            this.logpass.Size = new System.Drawing.Size(357, 38);
            this.logpass.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stencil", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(293, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(274, 51);
            this.label4.TabIndex = 8;
            this.label4.Text = "USER LOGIN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 477);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Don\'t have an account? Sign up";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Status";
            // 
            // logstatus
            // 
            this.logstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logstatus.FormattingEnabled = true;
            this.logstatus.Items.AddRange(new object[] {
            "Student",
            "Teacher",
            "Admin"});
            this.logstatus.Location = new System.Drawing.Point(271, 185);
            this.logstatus.Name = "logstatus";
            this.logstatus.Size = new System.Drawing.Size(357, 39);
            this.logstatus.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(635, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(635, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(635, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "*";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(887, 531);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.logstatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.logpass);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.logemail);
            this.Controls.Add(this.lpass);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.logbutton);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logbutton;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.Label lpass;
        private System.Windows.Forms.TextBox logemail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox logpass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox logstatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

