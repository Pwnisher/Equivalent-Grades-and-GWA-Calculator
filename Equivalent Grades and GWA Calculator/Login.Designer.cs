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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblLoginAs = new System.Windows.Forms.Label();
            this.lblOr = new System.Windows.Forms.Label();
            this.tbPassword = new CustomControls.RJControls.RoundedTextbox();
            this.tbUsername = new CustomControls.RJControls.RoundedTextbox();
            this.btnLogin = new CustomControls.RoundedButton.RoundedButton();
            this.btnExit = new CustomControls.RoundedButton.RoundedButton();
            this.btnStudent = new CustomControls.RoundedButton.RoundedButton();
            this.btnAdmin = new CustomControls.RoundedButton.RoundedButton();
            this.cbUsername = new CustomControls.RJControls.RoundedComboBox();
            this.roundedButton1 = new CustomControls.RoundedButton.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
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
            this.panel2.Controls.Add(this.roundedButton1);
            this.panel2.Controls.Add(this.tbPassword);
            this.panel2.Controls.Add(this.tbUsername);
            this.panel2.Controls.Add(this.btnLogin);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.btnStudent);
            this.panel2.Controls.Add(this.btnAdmin);
            this.panel2.Controls.Add(this.lblLoginAs);
            this.panel2.Controls.Add(this.lblOr);
            this.panel2.Controls.Add(this.cbUsername);
            this.panel2.Location = new System.Drawing.Point(400, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(351, 550);
            this.panel2.TabIndex = 5;
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
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.White;
            this.tbPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.tbPassword.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.tbPassword.BorderRadius = 0;
            this.tbPassword.BorderSize = 2;
            this.tbPassword.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Italic);
            this.tbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPassword.Location = new System.Drawing.Point(50, 373);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbPassword.Multiline = false;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Padding = new System.Windows.Forms.Padding(10, 9, 10, 7);
            this.tbPassword.PasswordChar = true;
            this.tbPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbPassword.PlaceholderText = "Password";
            this.tbPassword.Size = new System.Drawing.Size(260, 42);
            this.tbPassword.TabIndex = 9;
            this.tbPassword.Texts = "";
            this.tbPassword.UnderlinedStyle = false;
            this.tbPassword.Visible = false;
            // 
            // tbUsername
            // 
            this.tbUsername.BackColor = System.Drawing.Color.White;
            this.tbUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.tbUsername.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.tbUsername.BorderRadius = 0;
            this.tbUsername.BorderSize = 2;
            this.tbUsername.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Italic);
            this.tbUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbUsername.Location = new System.Drawing.Point(50, 323);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(4);
            this.tbUsername.Multiline = false;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Padding = new System.Windows.Forms.Padding(10, 9, 10, 7);
            this.tbUsername.PasswordChar = false;
            this.tbUsername.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbUsername.PlaceholderText = "Username";
            this.tbUsername.Size = new System.Drawing.Size(260, 42);
            this.tbUsername.TabIndex = 8;
            this.tbUsername.Texts = "";
            this.tbUsername.UnderlinedStyle = false;
            this.tbUsername.Visible = false;
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
            this.btnLogin.Location = new System.Drawing.Point(50, 425);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.btnLogin.Size = new System.Drawing.Size(260, 40);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextColor = System.Drawing.Color.White;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Visible = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
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
            this.cbUsername.Location = new System.Drawing.Point(50, 498);
            this.cbUsername.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbUsername.Name = "cbUsername";
            this.cbUsername.Padding = new System.Windows.Forms.Padding(2);
            this.cbUsername.Size = new System.Drawing.Size(260, 40);
            this.cbUsername.TabIndex = 7;
            this.cbUsername.Texts = "-SELECT-";
            this.cbUsername.Visible = false;
            this.cbUsername.OnSelectedIndexChanged += new System.EventHandler(this.roundedComboBox1_OnSelectedIndexChanged);
            // 
            // roundedButton1
            // 
            this.roundedButton1.BackColor = System.Drawing.Color.White;
            this.roundedButton1.BackgroundColor = System.Drawing.Color.White;
            this.roundedButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundedButton1.BorderRadius = 18;
            this.roundedButton1.BorderSize = 0;
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.Font = new System.Drawing.Font("Poppins Black", 13F, System.Drawing.FontStyle.Bold);
            this.roundedButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.roundedButton1.Location = new System.Drawing.Point(315, 515);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Padding = new System.Windows.Forms.Padding(2, 1, 0, 0);
            this.roundedButton1.Size = new System.Drawing.Size(35, 35);
            this.roundedButton1.TabIndex = 10;
            this.roundedButton1.Text = "!";
            this.roundedButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.roundedButton1.UseVisualStyleBackColor = false;
            this.roundedButton1.Click += new System.EventHandler(this.roundedButton1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 550);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private CustomControls.RJControls.RoundedTextbox tbPassword;
        private CustomControls.RJControls.RoundedTextbox tbUsername;
        private CustomControls.RoundedButton.RoundedButton roundedButton1;
    }
}