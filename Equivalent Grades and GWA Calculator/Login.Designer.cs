namespace Equivalent_Grades_and_GWA_Calculator
{
    partial class Login
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblOr = new System.Windows.Forms.Label();
            this.lblLoginAs = new System.Windows.Forms.Label();
            this.btnAdmin = new CustomControls.RoundedButton.RoundedButton();
            this.btnStudent = new CustomControls.RoundedButton.RoundedButton();
            this.btnLogin = new CustomControls.RoundedButton.RoundedButton();
            this.cbUsername = new CustomControls.RJControls.RoundedComboBox();
            this.btnExit = new CustomControls.RoundedButton.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(30, 28);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Equivalent_Grades_and_GWA_Calculator.Properties.Resources.left_BGv2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 550);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Equivalent_Grades_and_GWA_Calculator.Properties.Resources.right_BGv3;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(350, 550);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnStudent);
            this.panel2.Controls.Add(this.btnAdmin);
            this.panel2.Controls.Add(this.btnLogin);
            this.panel2.Controls.Add(this.cbUsername);
            this.panel2.Controls.Add(this.lblOr);
            this.panel2.Controls.Add(this.lblLoginAs);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(400, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(351, 550);
            this.panel2.TabIndex = 5;
            // 
            // lblOr
            // 
            this.lblOr.AutoSize = true;
            this.lblOr.BackColor = System.Drawing.Color.Transparent;
            this.lblOr.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOr.Location = new System.Drawing.Point(162, 379);
            this.lblOr.Name = "lblOr";
            this.lblOr.Size = new System.Drawing.Size(37, 34);
            this.lblOr.TabIndex = 6;
            this.lblOr.Text = "Or";
            // 
            // lblLoginAs
            // 
            this.lblLoginAs.AutoSize = true;
            this.lblLoginAs.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginAs.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginAs.Location = new System.Drawing.Point(131, 298);
            this.lblLoginAs.Name = "lblLoginAs";
            this.lblLoginAs.Size = new System.Drawing.Size(98, 34);
            this.lblLoginAs.TabIndex = 5;
            this.lblLoginAs.Text = "Login As:";
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnAdmin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.btnAdmin.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAdmin.BorderRadius = 10;
            this.btnAdmin.BorderSize = 0;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Poppins", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.Location = new System.Drawing.Point(50, 416);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.btnAdmin.Size = new System.Drawing.Size(260, 40);
            this.btnAdmin.TabIndex = 4;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.TextColor = System.Drawing.Color.White;
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(144)))), ((int)(((byte)(215)))));
            this.btnStudent.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(144)))), ((int)(((byte)(215)))));
            this.btnStudent.BorderColor = System.Drawing.Color.White;
            this.btnStudent.BorderRadius = 10;
            this.btnStudent.BorderSize = 0;
            this.btnStudent.FlatAppearance.BorderSize = 0;
            this.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudent.Font = new System.Drawing.Font("Poppins", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudent.ForeColor = System.Drawing.Color.White;
            this.btnStudent.Location = new System.Drawing.Point(50, 336);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.btnStudent.Size = new System.Drawing.Size(260, 40);
            this.btnStudent.TabIndex = 3;
            this.btnStudent.Text = "Student";
            this.btnStudent.TextColor = System.Drawing.Color.White;
            this.btnStudent.UseVisualStyleBackColor = false;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(144)))), ((int)(((byte)(215)))));
            this.btnLogin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(144)))), ((int)(((byte)(215)))));
            this.btnLogin.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLogin.BorderRadius = 10;
            this.btnLogin.BorderSize = 0;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Poppins", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(50, 382);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.btnLogin.Size = new System.Drawing.Size(260, 40);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextColor = System.Drawing.Color.White;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Visible = false;
            this.btnLogin.Click += new System.EventHandler(this.roundedButton1_Click);
            // 
            // cbUsername
            // 
            this.cbUsername.BackColor = System.Drawing.Color.White;
            this.cbUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.cbUsername.BorderSize = 2;
            this.cbUsername.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUsername.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cbUsername.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cbUsername.Items.AddRange(new object[] {
            "Arroyo, Euclide Andrei",
            "Montemayor, Carl John",
            "Astillo, Clouie",
            "Sensico, Ashley",
            "Silva, Neon Genesis"});
            this.cbUsername.ListBackColor = System.Drawing.Color.White;
            this.cbUsername.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cbUsername.Location = new System.Drawing.Point(50, 324);
            this.cbUsername.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbUsername.Name = "cbUsername";
            this.cbUsername.Padding = new System.Windows.Forms.Padding(2);
            this.cbUsername.Size = new System.Drawing.Size(260, 40);
            this.cbUsername.TabIndex = 7;
            this.cbUsername.Texts = "-SELECT-";
            this.cbUsername.Visible = false;
            this.cbUsername.OnSelectedIndexChanged += new System.EventHandler(this.roundedComboBox1_OnSelectedIndexChanged);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(14)))), ((int)(((byte)(9)))));
            this.btnExit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(14)))), ((int)(((byte)(9)))));
            this.btnExit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnExit.BorderRadius = 15;
            this.btnExit.BorderSize = 0;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Poppins Black", 13F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(314, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btnExit.Size = new System.Drawing.Size(55, 33);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "X";
            this.btnExit.TextColor = System.Drawing.Color.White;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 550);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;        
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private CustomControls.RoundedButton.RoundedButton btnStudent;
        private CustomControls.RoundedButton.RoundedButton btnAdmin;
        private System.Windows.Forms.Panel panel2;
        private CustomControls.RoundedButton.RoundedButton btnExit;
        private System.Windows.Forms.Label lblLoginAs;
        private System.Windows.Forms.Label lblOr;
        private CustomControls.RoundedButton.RoundedButton btnLogin;
        private CustomControls.RJControls.RoundedComboBox cbUsername;
    }
}