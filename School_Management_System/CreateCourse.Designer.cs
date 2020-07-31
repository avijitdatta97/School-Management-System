namespace finalproject
{
    partial class CreateCourse
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
            this.ccname = new System.Windows.Forms.TextBox();
            this.courseclass = new System.Windows.Forms.Label();
            this.coursename = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ccclass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ccstime = new System.Windows.Forms.DateTimePicker();
            this.ccetime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.ccsection = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ccday = new System.Windows.Forms.ComboBox();
            this.auseremail = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ccname
            // 
            this.ccname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccname.Location = new System.Drawing.Point(217, 198);
            this.ccname.Name = "ccname";
            this.ccname.Size = new System.Drawing.Size(253, 30);
            this.ccname.TabIndex = 13;
            // 
            // courseclass
            // 
            this.courseclass.AutoSize = true;
            this.courseclass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseclass.Location = new System.Drawing.Point(68, 254);
            this.courseclass.Name = "courseclass";
            this.courseclass.Size = new System.Drawing.Size(60, 24);
            this.courseclass.TabIndex = 12;
            this.courseclass.Text = "Class";
            // 
            // coursename
            // 
            this.coursename.AutoSize = true;
            this.coursename.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursename.Location = new System.Drawing.Point(38, 198);
            this.coursename.Name = "coursename";
            this.coursename.Size = new System.Drawing.Size(138, 24);
            this.coursename.TabIndex = 11;
            this.coursename.Text = "Course Name";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(120, 528);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(255, 61);
            this.button1.TabIndex = 10;
            this.button1.Text = "Create Course";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.auseremail);
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 155);
            this.panel1.TabIndex = 14;
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.Black;
            this.Exit.Location = new System.Drawing.Point(503, 9);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(30, 29);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "X";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            this.Exit.MouseEnter += new System.EventHandler(this.Exit_MouseEnter);
            this.Exit.MouseLeave += new System.EventHandler(this.Exit_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stencil", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(433, 51);
            this.label4.TabIndex = 16;
            this.label4.Text = "Create Course BY";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ccclass
            // 
            this.ccclass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccclass.Location = new System.Drawing.Point(217, 254);
            this.ccclass.Name = "ccclass";
            this.ccclass.Size = new System.Drawing.Size(253, 30);
            this.ccclass.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Starting Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 458);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ending Time";
            // 
            // ccstime
            // 
            this.ccstime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccstime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.ccstime.Location = new System.Drawing.Point(217, 413);
            this.ccstime.Name = "ccstime";
            this.ccstime.ShowUpDown = true;
            this.ccstime.Size = new System.Drawing.Size(253, 22);
            this.ccstime.TabIndex = 20;
            // 
            // ccetime
            // 
            this.ccetime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccetime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.ccetime.Location = new System.Drawing.Point(217, 463);
            this.ccetime.Name = "ccetime";
            this.ccetime.ShowUpDown = true;
            this.ccetime.Size = new System.Drawing.Size(253, 22);
            this.ccetime.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 22;
            this.label3.Text = "Section";
            // 
            // ccsection
            // 
            this.ccsection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccsection.Location = new System.Drawing.Point(217, 304);
            this.ccsection.Name = "ccsection";
            this.ccsection.Size = new System.Drawing.Size(253, 30);
            this.ccsection.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(84, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 24);
            this.label5.TabIndex = 24;
            this.label5.Text = "Day";
            // 
            // ccday
            // 
            this.ccday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccday.FormattingEnabled = true;
            this.ccday.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.ccday.Location = new System.Drawing.Point(217, 352);
            this.ccday.Name = "ccday";
            this.ccday.Size = new System.Drawing.Size(253, 30);
            this.ccday.TabIndex = 25;
            // 
            // auseremail
            // 
            this.auseremail.AutoSize = true;
            this.auseremail.Font = new System.Drawing.Font("Stencil", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auseremail.Location = new System.Drawing.Point(128, 89);
            this.auseremail.Name = "auseremail";
            this.auseremail.Size = new System.Drawing.Size(143, 40);
            this.auseremail.TabIndex = 17;
            this.auseremail.Text = "label6";
            // 
            // CreateCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(545, 630);
            this.Controls.Add(this.ccday);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ccsection);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ccetime);
            this.Controls.Add(this.ccstime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ccname);
            this.Controls.Add(this.courseclass);
            this.Controls.Add(this.coursename);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ccclass);
            this.Name = "CreateCourse";
            this.Text = "CreateCourse";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ccname;
        private System.Windows.Forms.Label courseclass;
        private System.Windows.Forms.Label coursename;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ccclass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker ccstime;
        private System.Windows.Forms.DateTimePicker ccetime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ccsection;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ccday;
        private System.Windows.Forms.Label auseremail;
    }
}