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
        int mov, movX, movY;
        public Login()
        {
            InitializeComponent();
            this.Location = Screen.AllScreens[0].WorkingArea.Location;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox2;
            label2.Parent = pictureBox2;
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;

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
            string loginMode = "student";
            Form main = new Main(loginMode);
            this.Hide();
            main.ShowDialog();
            this.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            string loginMode = "admin";
            Form main = new Main(loginMode);
            this.Hide();
            main.ShowDialog();
            this.Show();
        }

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
