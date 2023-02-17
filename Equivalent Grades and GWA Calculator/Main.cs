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
    public partial class Main : Form
    {
        int mov, movX, movY;
        public Main()
        {
            InitializeComponent();
            this.Location = Screen.AllScreens[0].WorkingArea.Location;
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

        private void titleBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void titleBar_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }
        //end titlebar

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // << ----  riulenn ---- >> //


        // method for inserting subjects from array -> subjects in table
        public void insertSubjectsToTable(string[] subjects)
        {
            for (int i = 0; i < subjects.Length; i++)
            {
                table.GetControlFromPosition(0, i + 1).Text = subjects[i];
            }

            cb_subject.Items.Clear();
            cb_subject.ResetText();
            addItemsToCB();
        }

        // method for clearing table
        public void clearTable()
        {
            for (int x = 1; x < 10; x++)
            {
                table.GetControlFromPosition(0, x).Text = "";
                table.GetControlFromPosition(1, x).Text = "";
                table.GetControlFromPosition(2, x).Text = "";
                table.GetControlFromPosition(3, x).Text = "";
            }
        }

        // put subjects from table -> combobox for subjects
        public void addItemsToCB()
        {
            for (int x = 1; x < 10; x++)
            {
                if (table.GetControlFromPosition(0, x).Text != "")
                {
                    cb_subject.Items.Add(table.GetControlFromPosition(0, x).Text);
                }
            }

        }

        // button for changing grade value
        private void button1_Click_1(object sender, EventArgs e)
        {
            int temp = 0;

            // find index of selected combobox item
            for (int i = 0; i < cb_subject.Items.Count; i++)
            {
                if (cb_subject.GetItemText(cb_subject.Items[i]) ==
                    cb_subject.GetItemText(cb_subject.SelectedItem))
                {
                    temp = i + 1;
                }
            }

            // set values for grade, equiv, and status
            if (temp != 0) // make sure that an item is selected
            {
                table.GetControlFromPosition(1, temp).Text = tb_grade.Text;

                equivCompute(Convert.ToInt32(tb_grade.Text));
                table.GetControlFromPosition(2, temp).Text = eq;
                table.GetControlFromPosition(3, temp).Text = s;

                saveChange(tb_grade.Text, temp);
            }
        }

        // method for replacing grades from selected student account -> new value from textbox
        public void saveChange(string newGrade, int temp)
        {
            switch (selectedStudent)
            {
                case 1: student1.SetValue(newGrade, temp - 1); break;
                case 2: student2.SetValue(newGrade, temp - 1); break;
                case 3: student3.SetValue(newGrade, temp - 1); break;
                case 4: student4.SetValue(newGrade, temp - 1); break;
                case 5: student5.SetValue(newGrade, temp - 1); break;
            }
        }

        // tb_grade only accept int
        private void tb_grade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;
        }

        // method for updating table data based on selected student
        private void updateTable(string[] studentGrades, string[] studentSubjects)
        {
            clearTable();

            insertSubjectsToTable(studentSubjects);
            for (int i = 0; i < studentGrades.Length; i++)
            {
                table.GetControlFromPosition(1, i + 1).Text = studentGrades[i];

                equivCompute(Convert.ToInt32(studentGrades[i]));
                table.GetControlFromPosition(2, i + 1).Text = eq;
                table.GetControlFromPosition(3, i + 1).Text = s;
            }
        }

        // selecting a student
        int selectedStudent;
        private void cb_student_SelectedIndexChanged(object sender, EventArgs e)
        {
            string studentName = cb_student.GetItemText(cb_student.SelectedItem);

            switch (studentName)
            {
                case "Arroyo, Euclide Andrei (BSIT 1-1 1st Sem)":
                    {
                        updateTable(student1, bsit1_1_1);
                        selectedStudent = 1;
                    }
                    break;

                case "Montemayor, Carl John (BSIT 1-1 2nd Sem)":
                    {
                        updateTable(student2, bsit1_1_2);
                        selectedStudent = 2;
                    }
                    break;

                case "Astillo, Clouie (BSIT 2-1 1st Sem)":
                    {
                        updateTable(student3, bsit2_1_1);
                        selectedStudent = 3;
                    }
                    break;

                case "Sensico, Ashley (BSIT 2-1 2nd Sem)":
                    {
                        updateTable(student4, bsit2_1_2);
                        selectedStudent = 4;
                    }
                    break;

                case "Silva, Neon Genesis (BSIT 3-1 1st Sem)":
                    {
                        updateTable(student5, bsit3_1_1);
                        selectedStudent = 5;
                    }
                    break;
            }
        }

        /*
            classic method for equiGrade
  
            g = grade
            e = equiv
            s = status
        */
        string eq, s;
        private void equivCompute(int g)
        {
            if (g >= 97 && g <= 100)
            {
                eq = "1.0";
                s = "Excellent";
            }
            else if (g >= 94 && g <= 96)
            {
                eq = "1.25";
                s = "Excellent";
            }
            else if (g >= 91 && g <= 93)
            {
                eq = "1.5";
                s = "Very Good";
            }
            else if (g >= 88 && g <= 90)
            {
                eq = "1.75";
                s = "Very Good";
            }
            else if (g >= 85 && g <= 97)
            {
                eq = "2.0";
                s = "Good";
            }
            else if (g >= 82 && g <= 84)
            {
                eq = "2.25";
                s = "Good";
            }
            else if (g >= 79 && g <= 81)
            {
                eq = "2.5";
                s = "Satisfactory";
            }
            else if (g >= 76 && g <= 78)
            {
                eq = "2.75";
                s = "Satisfactory";
            }
            else if (g == 75)
            {
                eq = "2.0";
                s = "Passing";
            }
            else if (g >= 65 && g <= 74)
            {
                eq = "4.0";
                s = "Conditional";
            }
            else if (g == 64)
            {
                eq = "5.0";
                s = "Failure";
            }
            else if (g == 63)
            {
                eq = "INC";
                s = "Incomplete";
            }
            else if (g == 62)
            {
                eq = "W";
                s = "Withrawn";
            }
            else
            {
                eq = "Invalid";
                s = "Invalid";
            }

        }

        // ---------------------------- data for demo accounts ---------------------------- //
        string[] bsit1_1_1 = { "Accounting Principles",
                                "Introduction to Computing",
                                "Computer Programming 1",
                                "Civic Welfare Training Service 1",
                                "Mathematics in the Modern World",
                                "Purposive Communication",
                                "Filipinolohiya at Pambansang Kaunlaran",
                                "Physical Fitness and Self-Testing Activities"
        };

        string[] bsit1_1_2 = { "Computer Programming 2",
                                "Discrete Structures 1",
                                "Civic Welfare Training Service 2",
                                "Reading in Philippine History",
                                "Pagsasalin on Kontekstong Filipino",
                                "Politics, Governance and Citizenship",
                                "Rythmic Activities"
        };

        string[] bsit2_1_1 = { "Data Structures and Algorithms",
                                "Operating Systems",
                                "Data Communications and Networking",
                                "Understanding the Self",
                                "World Literature",
                                "Reading Visual Arts",
                                "Programming 3 (Structured Programming)",
                                "Individual/Dual/Combative Sports"
        };

        string[] bsit2_1_2 = { "Object Oriented Programming",
                                "Information Management",
                                "Human Computer Interaction",
                                "Network Administration",
                                "Quantitative Methods with Modeling and Simulation",
                                "People and the Earth's Ecosystem",
                                "Integrative Programming and Technologies 1",
                                "Team Sports"
        };

        string[] bsit3_1_1 = { "Fundamentals of Research",
                                "Web Development",
                                "Database Administration",
                                "Art Appreciation",
                                "System Integration and Architecture 1",
                                "Multimedia",
                                "IT Elective 1"
        };

        string[] student1 = { "89", "78", "87", "71", "67", "83", "93", "99" };
        string[] student2 = { "90", "99", "74", "98", "78", "95", "62" };
        string[] student3 = { "66", "96", "81", "72", "64", "85", "89", "90" };
        string[] student4 = { "91", "92", "93", "89", "88", "87", "86", "94" };
        string[] student5 = { "88", "88", "88", "70", "98", "95", "91" };
        // ---------------------------- data for demo accounts ---------------------------- //
    
        
    }
}
