namespace finalproject
{
    partial class AdminProfile
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Delete_Account = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminemail = new System.Windows.Forms.Label();
            this.Edit_Employee_Panel = new System.Windows.Forms.Button();
            this.aupdateaccount = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1259, 112);
            this.panel1.TabIndex = 10;
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(1216, 8);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(30, 29);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "X";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            this.Exit.MouseEnter += new System.EventHandler(this.Exit_MouseEnter);
            this.Exit.MouseLeave += new System.EventHandler(this.Exit_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(445, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Profile";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 19.8F);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(131, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 38);
            this.label3.TabIndex = 14;
            this.label3.Text = "Details of";
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(217, 517);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 62);
            this.button2.TabIndex = 12;
            this.button2.Text = "Log Out";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(740, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(494, 62);
            this.button1.TabIndex = 11;
            this.button1.Text = "Edit Admin Account";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(740, 463);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(494, 62);
            this.button4.TabIndex = 16;
            this.button4.Text = "Create Course";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Delete_Account
            // 
            this.Delete_Account.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete_Account.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Account.Location = new System.Drawing.Point(740, 379);
            this.Delete_Account.Name = "Delete_Account";
            this.Delete_Account.Size = new System.Drawing.Size(494, 62);
            this.Delete_Account.TabIndex = 18;
            this.Delete_Account.Text = "Delete Account";
            this.Delete_Account.UseVisualStyleBackColor = true;
            this.Delete_Account.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(34, 289);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(576, 100);
            this.dataGridView1.TabIndex = 19;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "name";
            this.Column1.HeaderText = "Name";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "email";
            this.Column2.HeaderText = "Email";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "jdate";
            this.Column3.HeaderText = "Joining Date";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // adminemail
            // 
            this.adminemail.AutoSize = true;
            this.adminemail.Font = new System.Drawing.Font("Cooper Black", 19.8F);
            this.adminemail.ForeColor = System.Drawing.Color.DimGray;
            this.adminemail.Location = new System.Drawing.Point(319, 161);
            this.adminemail.Name = "adminemail";
            this.adminemail.Size = new System.Drawing.Size(117, 38);
            this.adminemail.TabIndex = 20;
            this.adminemail.Text = "label2";
            // 
            // Edit_Employee_Panel
            // 
            this.Edit_Employee_Panel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Edit_Employee_Panel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_Employee_Panel.Location = new System.Drawing.Point(740, 554);
            this.Edit_Employee_Panel.Name = "Edit_Employee_Panel";
            this.Edit_Employee_Panel.Size = new System.Drawing.Size(494, 62);
            this.Edit_Employee_Panel.TabIndex = 21;
            this.Edit_Employee_Panel.Text = "Edit Emplyee Panel";
            this.Edit_Employee_Panel.UseVisualStyleBackColor = true;
            this.Edit_Employee_Panel.Click += new System.EventHandler(this.Edit_Employee_Panel_Click);
            // 
            // aupdateaccount
            // 
            this.aupdateaccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aupdateaccount.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aupdateaccount.Location = new System.Drawing.Point(740, 214);
            this.aupdateaccount.Name = "aupdateaccount";
            this.aupdateaccount.Size = new System.Drawing.Size(494, 62);
            this.aupdateaccount.TabIndex = 15;
            this.aupdateaccount.Text = "Update Account";
            this.aupdateaccount.UseVisualStyleBackColor = true;
            this.aupdateaccount.Click += new System.EventHandler(this.aupdateaccount_Click_1);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(740, 295);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(494, 62);
            this.button5.TabIndex = 22;
            this.button5.Text = "Show Details";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // AdminProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1257, 625);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Edit_Employee_Panel);
            this.Controls.Add(this.adminemail);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Delete_Account);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.aupdateaccount);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "AdminProfile";
            this.Text = "AdminProfile";
            this.Load += new System.EventHandler(this.AdminProfile_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Delete_Account;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label adminemail;
        private System.Windows.Forms.Button Edit_Employee_Panel;
        private System.Windows.Forms.Button aupdateaccount;
        private System.Windows.Forms.Button button5;
    }
}