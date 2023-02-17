using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Form main = new Main();
            this.Hide();
            main.ShowDialog();
            this.Show();
        }
    }
}
