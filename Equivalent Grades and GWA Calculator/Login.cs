using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Equivalent_Grades_and_GWA_Calculator
{
    public partial class Login : Form
    {
        int mov, movX, movY;//, selectedStudent;
        //string loginMode;
        public Login()
        {
            InitializeComponent();
            this.Location = Screen.AllScreens[0].WorkingArea.Location;

            loginForm();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            lblLoginAs.Parent = pictureBox2;
            lblOr.Parent = pictureBox2;
            lblLoginAs.BackColor = Color.Transparent;
            lblOr.BackColor = Color.Transparent;

            //checks and generates default values if file doesnt exist
            GenerateDefaultValues();            
        }

        //para ma-drag ung titlebar nang walang border ung form
        private void titleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }     

        private void titleBar_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void titleBar_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }
        //end titlebar

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnStudent_Click(object sender, EventArgs e)
        {
            /*
            loginMode = "Student";
            cbUsername.Visible = true;
            btnLogin.Visible = true;
            lblLoginAs.Visible = false;
            lblOr.Visible = false;
            btnAdmin.Visible = false;
            btnStudent.Visible = false;
            tbPassword.Visible = true;
            tbUsername.Visible = true;
            */
        } 
        
        private void roundedComboBox1_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            string studentName = cbUsername.SelectedItem.ToString();

            switch (studentName)
            {
                case "Arroyo, Euclide Andrei":
                    {
                        selectedStudent = 1;
                    }
                    break;

                case "Montemayor, Carl John":
                    {
                        selectedStudent = 2;
                    }
                    break;

                case "Astillo, Clouie":
                    {
                        selectedStudent = 3;
                    }
                    break;

                case "Sensico, Ashley":
                    {
                        selectedStudent = 4;
                    }
                    break;

                case "Silva, Neon Genesis":
                    {
                        selectedStudent = 5;
                    }
                    break;
            }
            */
        }

        private void loginForm()
        {
            cbUsername.Visible = false;
            btnLogin.Visible = true;
            lblLoginAs.Visible = false;
            lblOr.Visible = false;
            btnAdmin.Visible = false;
            btnStudent.Visible = false;
            tbPassword.Visible = true;
            tbUsername.Visible = true;
        }
        private void showMain(string loginMode, int user)
        {
            Form main = new Main(loginMode, user);
            this.Hide();
            main.ShowDialog();
            tbUsername.Texts = "";
            tbPassword.Texts = "";
            this.Show();
            loginForm();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string[] usernames = { "admin", "arroyo", "montemayor", "astillo", "sensico", "silva"};
            string[] passwords = { "admin123", "arroyo123", "montemayor123", "astillo123", "sensico123", "silva123" };

            for(int i = 0; i < usernames.Length; i++)
            {
                if (usernames[i] == tbUsername.Texts && passwords[i] == tbPassword.Texts)
                {
                    if (usernames[i] == "admin")
                    {
                        showMain("Admin", i);
                    }
                    else
                    {
                        showMain("Student", i);
                    }
                }
                else
                {
                    // show red "incorrect login details. please try again" text chuchu
                }
            }
            /*
            Form main = new Main(loginMode, selectedStudent);
            this.Hide();
            main.ShowDialog();
            this.Show();
            reset();
            */
        }
        
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            /*
            loginMode = "Admin";
            Form main = new Main(loginMode,0);
            this.Hide();
            main.ShowDialog();
            this.Show();
            reset();
            */
        }
        /*
        private void reset()
        {
            cbUsername.Visible = false;
            btnLogin.Visible = false;
            lblLoginAs.Visible = true;
            lblOr.Visible = true;
            btnAdmin.Visible = true;
            btnStudent.Visible = true;
            cbUsername.Texts = "-SELECT-";
            tbPassword.Visible = false;
            tbUsername.Visible = false;
        }
        */

            //method for checking and generating default values if file doesnt exist
            void GenerateDefaultValues()
        {
            if (!File.Exists("./student1.txt"))
            {
                TextWriter txt = new StreamWriter("./student1.txt");
                string student = "89\n78\n87\n71\n67\n83\n93\n99";
                txt.Write(student);
                txt.Close();
            }

            if (!File.Exists("./student2.txt"))
            {
                TextWriter txt = new StreamWriter("./student2.txt");
                string student = "90\n99\n74\n98\n78\n95\n62";
                txt.Write(student);
                txt.Close();
            }

            if (!File.Exists("./student3.txt"))
            {
                TextWriter txt = new StreamWriter("./student3.txt");
                string student = "66\n96\n81\n72\n64\n85\n89\n90";
                txt.Write(student);
                txt.Close();
            }

            if (!File.Exists("./student4.txt"))
            {
                TextWriter txt = new StreamWriter("./student4.txt");
                string student = "91\n92\n93\n89\n88\n87\n86\n94";
                txt.Write(student);
                txt.Close();
            }

            if (!File.Exists("./student5.txt"))
            {
                TextWriter txt = new StreamWriter("./student5.txt");
                string student = "88\n88\n88\n70\n98\n95\n91";
                txt.Write(student);
                txt.Close();
            }
        }
    }
}
