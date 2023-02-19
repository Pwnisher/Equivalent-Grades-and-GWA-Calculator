namespace Equivalent_Grades_and_GWA_Calculator
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.titleBar = new System.Windows.Forms.Panel();
            this.tb_grade = new System.Windows.Forms.TextBox();
            this.lblSelectSubject = new System.Windows.Forms.Label();
            this.cb_subject = new System.Windows.Forms.ComboBox();
            this.cb_student = new System.Windows.Forms.ComboBox();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.lbl_gwa = new System.Windows.Forms.Label();
            this.lblSelectStudent = new System.Windows.Forms.Label();
            this.lblChangeGrade = new System.Windows.Forms.Label();
            this.pbBottomBG = new System.Windows.Forms.PictureBox();
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.bottomBG = new System.Windows.Forms.PictureBox();
            this.btnSaveChanges = new CustomControls.RoundedButton.RoundedButton();
            this.btnChangeGrade = new CustomControls.RoundedButton.RoundedButton();
            this.btnLogout = new CustomControls.RoundedButton.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbBottomBG)).BeginInit();
            this.table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bottomBG)).BeginInit();
            this.SuspendLayout();
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(950, 24);
            this.titleBar.TabIndex = 0;
            this.titleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.titleBar_Paint);
            this.titleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseDown);
            this.titleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseMove);
            this.titleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseUp);
            // 
            // tb_grade
            // 
            this.tb_grade.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Italic);
            this.tb_grade.Location = new System.Drawing.Point(260, 503);
            this.tb_grade.Margin = new System.Windows.Forms.Padding(2);
            this.tb_grade.Name = "tb_grade";
            this.tb_grade.Size = new System.Drawing.Size(66, 27);
            this.tb_grade.TabIndex = 24;
            this.tb_grade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_grade_KeyPress);
            // 
            // lblSelectSubject
            // 
            this.lblSelectSubject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSelectSubject.AutoSize = true;
            this.lblSelectSubject.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Italic);
            this.lblSelectSubject.Location = new System.Drawing.Point(109, 464);
            this.lblSelectSubject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectSubject.Name = "lblSelectSubject";
            this.lblSelectSubject.Size = new System.Drawing.Size(129, 28);
            this.lblSelectSubject.TabIndex = 28;
            this.lblSelectSubject.Text = "Select Subject:";
            // 
            // cb_subject
            // 
            this.cb_subject.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Italic);
            this.cb_subject.FormattingEnabled = true;
            this.cb_subject.Location = new System.Drawing.Point(260, 463);
            this.cb_subject.Margin = new System.Windows.Forms.Padding(2);
            this.cb_subject.Name = "cb_subject";
            this.cb_subject.Size = new System.Drawing.Size(366, 31);
            this.cb_subject.TabIndex = 23;
            // 
            // cb_student
            // 
            this.cb_student.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Italic);
            this.cb_student.FormattingEnabled = true;
            this.cb_student.Items.AddRange(new object[] {
            "Arroyo, Euclide Andrei (BSIT 1-1 1st Sem)",
            "Montemayor, Carl John (BSIT 1-1 2nd Sem)",
            "Astillo, Clouie (BSIT 2-1 1st Sem)",
            "Sensico, Ashley (BSIT 2-1 2nd Sem)",
            "Silva, Neon Genesis (BSIT 3-1 1st Sem)"});
            this.cb_student.Location = new System.Drawing.Point(260, 424);
            this.cb_student.Margin = new System.Windows.Forms.Padding(2);
            this.cb_student.Name = "cb_student";
            this.cb_student.Size = new System.Drawing.Size(366, 31);
            this.cb_student.TabIndex = 27;
            this.cb_student.Text = "-SELECT STUDENT-";
            this.cb_student.SelectedIndexChanged += new System.EventHandler(this.cb_student_SelectedIndexChanged);
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Poppins", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_welcome.Location = new System.Drawing.Point(18, 56);
            this.lbl_welcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(142, 42);
            this.lbl_welcome.TabIndex = 26;
            this.lbl_welcome.Text = "Welcome,";
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Poppins", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblUsername.Location = new System.Drawing.Point(151, 56);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(105, 42);
            this.lblUsername.TabIndex = 31;
            this.lblUsername.Text = "[user]!";
            // 
            // label41
            // 
            this.label41.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Poppins", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label41.Location = new System.Drawing.Point(608, 56);
            this.label41.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(92, 42);
            this.label41.TabIndex = 32;
            this.label41.Text = "GWA: ";
            this.label41.Click += new System.EventHandler(this.label41_Click);
            // 
            // lbl_gwa
            // 
            this.lbl_gwa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_gwa.AutoSize = true;
            this.lbl_gwa.Font = new System.Drawing.Font("Poppins", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_gwa.Location = new System.Drawing.Point(685, 56);
            this.lbl_gwa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_gwa.Name = "lbl_gwa";
            this.lbl_gwa.Size = new System.Drawing.Size(66, 42);
            this.lbl_gwa.TabIndex = 33;
            this.lbl_gwa.Text = "1.00";
            this.lbl_gwa.Click += new System.EventHandler(this.lbl_gwa_Click);
            // 
            // lblSelectStudent
            // 
            this.lblSelectStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSelectStudent.AutoSize = true;
            this.lblSelectStudent.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Italic);
            this.lblSelectStudent.Location = new System.Drawing.Point(109, 425);
            this.lblSelectStudent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectStudent.Name = "lblSelectStudent";
            this.lblSelectStudent.Size = new System.Drawing.Size(147, 28);
            this.lblSelectStudent.TabIndex = 36;
            this.lblSelectStudent.Text = "Select a Student:";
            // 
            // lblChangeGrade
            // 
            this.lblChangeGrade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblChangeGrade.AutoSize = true;
            this.lblChangeGrade.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Italic);
            this.lblChangeGrade.Location = new System.Drawing.Point(109, 503);
            this.lblChangeGrade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChangeGrade.Name = "lblChangeGrade";
            this.lblChangeGrade.Size = new System.Drawing.Size(104, 28);
            this.lblChangeGrade.TabIndex = 37;
            this.lblChangeGrade.Text = "New Grade:";
            // 
            // pbBottomBG
            // 
            this.pbBottomBG.Image = global::Equivalent_Grades_and_GWA_Calculator.Properties.Resources.bottomBG;
            this.pbBottomBG.Location = new System.Drawing.Point(0, 400);
            this.pbBottomBG.Name = "pbBottomBG";
            this.pbBottomBG.Size = new System.Drawing.Size(950, 150);
            this.pbBottomBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbBottomBG.TabIndex = 40;
            this.pbBottomBG.TabStop = false;
            this.pbBottomBG.Visible = false;
            // 
            // table
            // 
            this.table.BackColor = System.Drawing.Color.Transparent;
            this.table.BackgroundImage = global::Equivalent_Grades_and_GWA_Calculator.Properties.Resources.tableBG;
            this.table.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.table.ColumnCount = 4;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 185F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.table.Controls.Add(this.label40, 0, 9);
            this.table.Controls.Add(this.label39, 0, 9);
            this.table.Controls.Add(this.label38, 0, 9);
            this.table.Controls.Add(this.label27, 0, 9);
            this.table.Controls.Add(this.label16, 0, 5);
            this.table.Controls.Add(this.label15, 2, 4);
            this.table.Controls.Add(this.label14, 1, 4);
            this.table.Controls.Add(this.label13, 0, 4);
            this.table.Controls.Add(this.label12, 2, 3);
            this.table.Controls.Add(this.label11, 1, 3);
            this.table.Controls.Add(this.label10, 0, 3);
            this.table.Controls.Add(this.label9, 2, 2);
            this.table.Controls.Add(this.label8, 1, 2);
            this.table.Controls.Add(this.label7, 0, 2);
            this.table.Controls.Add(this.label6, 2, 1);
            this.table.Controls.Add(this.label5, 1, 1);
            this.table.Controls.Add(this.label4, 0, 1);
            this.table.Controls.Add(this.label1, 0, 0);
            this.table.Controls.Add(this.label17, 1, 5);
            this.table.Controls.Add(this.label18, 2, 5);
            this.table.Controls.Add(this.label19, 0, 6);
            this.table.Controls.Add(this.label20, 1, 6);
            this.table.Controls.Add(this.label21, 2, 6);
            this.table.Controls.Add(this.label22, 0, 7);
            this.table.Controls.Add(this.label23, 1, 7);
            this.table.Controls.Add(this.label24, 2, 7);
            this.table.Controls.Add(this.label25, 0, 8);
            this.table.Controls.Add(this.label28, 1, 8);
            this.table.Controls.Add(this.label29, 2, 8);
            this.table.Controls.Add(this.label3, 3, 0);
            this.table.Controls.Add(this.label2, 2, 0);
            this.table.Controls.Add(this.label31, 1, 0);
            this.table.Controls.Add(this.label26, 3, 1);
            this.table.Controls.Add(this.label30, 3, 2);
            this.table.Controls.Add(this.label33, 3, 3);
            this.table.Controls.Add(this.label32, 3, 4);
            this.table.Controls.Add(this.label34, 3, 5);
            this.table.Controls.Add(this.label35, 3, 6);
            this.table.Controls.Add(this.label36, 3, 7);
            this.table.Controls.Add(this.label37, 3, 8);
            this.table.Font = new System.Drawing.Font("Poppins ExtraBold", 12F, System.Drawing.FontStyle.Bold);
            this.table.ForeColor = System.Drawing.Color.Black;
            this.table.Location = new System.Drawing.Point(25, 100);
            this.table.Margin = new System.Windows.Forms.Padding(2);
            this.table.Name = "table";
            this.table.RowCount = 10;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.table.Size = new System.Drawing.Size(900, 300);
            this.table.TabIndex = 21;
            // 
            // label40
            // 
            this.label40.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(514, 275);
            this.label40.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(0, 19);
            this.label40.TabIndex = 38;
            // 
            // label39
            // 
            this.label39.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(234, 275);
            this.label39.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(0, 19);
            this.label39.TabIndex = 37;
            // 
            // label38
            // 
            this.label38.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(823, 275);
            this.label38.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(0, 19);
            this.label38.TabIndex = 36;
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(653, 275);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(0, 19);
            this.label27.TabIndex = 26;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(234, 159);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 19);
            this.label16.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(653, 130);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 19);
            this.label15.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(514, 130);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 19);
            this.label14.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(234, 130);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 19);
            this.label13.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(653, 101);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 19);
            this.label12.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(514, 101);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 19);
            this.label11.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(234, 101);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 19);
            this.label10.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(653, 72);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 19);
            this.label9.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(514, 72);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 19);
            this.label8.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(234, 72);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 19);
            this.label7.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(653, 43);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 19);
            this.label6.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(514, 43);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 19);
            this.label5.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(234, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 19);
            this.label4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(196, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.label1.Size = new System.Drawing.Size(76, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(514, 159);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 19);
            this.label17.TabIndex = 16;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(653, 159);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 19);
            this.label18.TabIndex = 17;
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(234, 188);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(0, 19);
            this.label19.TabIndex = 18;
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(514, 188);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(0, 19);
            this.label20.TabIndex = 19;
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(653, 188);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(0, 19);
            this.label21.TabIndex = 20;
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(234, 217);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(0, 19);
            this.label22.TabIndex = 21;
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(514, 217);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(0, 19);
            this.label23.TabIndex = 22;
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(653, 217);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(0, 19);
            this.label24.TabIndex = 23;
            // 
            // label25
            // 
            this.label25.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(234, 246);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(0, 19);
            this.label25.TabIndex = 24;
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(514, 246);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(0, 19);
            this.label28.TabIndex = 27;
            // 
            // label29
            // 
            this.label29.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(653, 246);
            this.label29.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(0, 19);
            this.label29.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(789, 4);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.label3.Size = new System.Drawing.Size(67, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Status";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(575, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.label2.Size = new System.Drawing.Size(156, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Equivalent Grade";
            // 
            // label31
            // 
            this.label31.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Poppins ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.White;
            this.label31.Location = new System.Drawing.Point(483, 4);
            this.label31.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label31.Name = "label31";
            this.label31.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.label31.Size = new System.Drawing.Size(63, 31);
            this.label31.TabIndex = 29;
            this.label31.Text = "Grade";
            // 
            // label26
            // 
            this.label26.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(823, 43);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(0, 19);
            this.label26.TabIndex = 25;
            // 
            // label30
            // 
            this.label30.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(823, 72);
            this.label30.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(0, 19);
            this.label30.TabIndex = 28;
            // 
            // label33
            // 
            this.label33.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(823, 101);
            this.label33.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(0, 19);
            this.label33.TabIndex = 31;
            // 
            // label32
            // 
            this.label32.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(823, 130);
            this.label32.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(0, 19);
            this.label32.TabIndex = 30;
            // 
            // label34
            // 
            this.label34.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(823, 159);
            this.label34.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(0, 19);
            this.label34.TabIndex = 32;
            // 
            // label35
            // 
            this.label35.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(823, 188);
            this.label35.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(0, 19);
            this.label35.TabIndex = 33;
            // 
            // label36
            // 
            this.label36.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(823, 217);
            this.label36.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(0, 19);
            this.label36.TabIndex = 34;
            // 
            // label37
            // 
            this.label37.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(823, 246);
            this.label37.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(0, 19);
            this.label37.TabIndex = 35;
            // 
            // bottomBG
            // 
            this.bottomBG.Image = global::Equivalent_Grades_and_GWA_Calculator.Properties.Resources.bottomBG;
            this.bottomBG.Location = new System.Drawing.Point(0, 400);
            this.bottomBG.Name = "bottomBG";
            this.bottomBG.Size = new System.Drawing.Size(950, 150);
            this.bottomBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bottomBG.TabIndex = 40;
            this.bottomBG.TabStop = false;
            this.bottomBG.Visible = false;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(205)))), ((int)(((byte)(85)))));
            this.btnSaveChanges.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(205)))), ((int)(((byte)(85)))));
            this.btnSaveChanges.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSaveChanges.BorderRadius = 12;
            this.btnSaveChanges.BorderSize = 0;
            this.btnSaveChanges.FlatAppearance.BorderSize = 0;
            this.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChanges.Font = new System.Drawing.Font("Poppins", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnSaveChanges.ForeColor = System.Drawing.Color.White;
            this.btnSaveChanges.Location = new System.Drawing.Point(678, 482);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.btnSaveChanges.Size = new System.Drawing.Size(164, 36);
            this.btnSaveChanges.TabIndex = 39;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.TextColor = System.Drawing.Color.White;
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnChangeGrade
            // 
            this.btnChangeGrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(144)))), ((int)(((byte)(215)))));
            this.btnChangeGrade.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(144)))), ((int)(((byte)(215)))));
            this.btnChangeGrade.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnChangeGrade.BorderRadius = 12;
            this.btnChangeGrade.BorderSize = 0;
            this.btnChangeGrade.FlatAppearance.BorderSize = 0;
            this.btnChangeGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeGrade.Font = new System.Drawing.Font("Poppins", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnChangeGrade.ForeColor = System.Drawing.Color.White;
            this.btnChangeGrade.Location = new System.Drawing.Point(678, 440);
            this.btnChangeGrade.Name = "btnChangeGrade";
            this.btnChangeGrade.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.btnChangeGrade.Size = new System.Drawing.Size(164, 36);
            this.btnChangeGrade.TabIndex = 38;
            this.btnChangeGrade.Text = "Change Grade";
            this.btnChangeGrade.TextColor = System.Drawing.Color.White;
            this.btnChangeGrade.UseVisualStyleBackColor = false;
            this.btnChangeGrade.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(144)))), ((int)(((byte)(215)))));
            this.btnLogout.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(144)))), ((int)(((byte)(215)))));
            this.btnLogout.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLogout.BorderRadius = 12;
            this.btnLogout.BorderSize = 0;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Poppins", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(775, 56);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(150, 36);
            this.btnLogout.TabIndex = 35;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.TextColor = System.Drawing.Color.White;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(950, 550);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.btnChangeGrade);
            this.Controls.Add(this.lblChangeGrade);
            this.Controls.Add(this.lblSelectStudent);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lbl_gwa);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.tb_grade);
            this.Controls.Add(this.lblSelectSubject);
            this.Controls.Add(this.cb_subject);
            this.Controls.Add(this.cb_student);
            this.Controls.Add(this.table);
            this.Controls.Add(this.lbl_welcome);
            this.Controls.Add(this.titleBar);
            this.Controls.Add(this.pbBottomBG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBottomBG)).EndInit();
            this.table.ResumeLayout(false);
            this.table.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bottomBG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel titleBar;
        private System.Windows.Forms.TextBox tb_grade;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblSelectSubject;
        private System.Windows.Forms.ComboBox cb_subject;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cb_student;
        private System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label lbl_gwa;
        private CustomControls.RoundedButton.RoundedButton btnLogout;
        private System.Windows.Forms.Label lblSelectStudent;
        private System.Windows.Forms.Label lblChangeGrade;
        private CustomControls.RoundedButton.RoundedButton btnChangeGrade;
        private CustomControls.RoundedButton.RoundedButton btnSaveChanges;
        private System.Windows.Forms.PictureBox pbBottomBG;
        private System.Windows.Forms.PictureBox bottomBG;
    }
}

