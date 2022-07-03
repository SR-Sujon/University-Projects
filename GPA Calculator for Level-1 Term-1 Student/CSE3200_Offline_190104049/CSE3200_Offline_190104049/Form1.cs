using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace CSE3200_Offline_190104049
{
    public partial class Form1 : Form
    {

        public string std_Name, std_id;
        double sum,gpavg;
        decimal c1, c2, c3, c4, c5, c6, c7, c8, c9;


        public string id_regex_pattern1 = "^[1][7-9][0][1-2][0][4][0-1][0-9][0-9]$"; //Re-add, prev roll format
        public string id_regex_pattern2 = "^[2][0][2][0-1][0][1-2][0][4][0-1][0-9][0-9]$"; // New Roll format
        public string name_regex_pattern = "[0-9]";

        public Form1()
        {
            InitializeComponent();
            
        }


        private double gpa(decimal marks)
        {
            if (marks >= 80 && marks <= 100)

                return 4.00;

            else if (marks >= 75 && marks < 80)

                return 3.75;

            else if (marks >= 70 && marks < 75)

                return 3.50;

            else if (marks >= 65 && marks < 70)

                return 3.25;

            else if (marks >= 60 && marks < 65)

                return 3.00;

            else if (marks >= 55 && marks < 60)

                return 2.75;

            else if (marks >= 50 && marks < 55)

                return 2.50;

            else if (marks >= 45 && marks < 50)

                return 2.25;

            else if (marks >= 40 && marks < 45)

                return 2.00;

            else if (marks >= 0 && marks < 40)

                return 0.00;

            else
                return -1;

        }

        private bool IsNameValid(string name)
        {
            bool match1 = Regex.IsMatch(name, name_regex_pattern);
            if (name == "")
            {
                MessageBox.Show("Opps! Name feild is empty.\nPlease, provide a name.",
                    "Error!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return true;
            }

            else if (match1)
            {
                MessageBox.Show("Opps! Name can't include numbers.\nPlease, provide a valid name.\nEx: Sujon",
                    "Error!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return true;
            }

            return false;
        }


        private bool IsIDvalid(string id)
        {
            bool match1 = Regex.IsMatch(id, id_regex_pattern1);
            bool match2 = Regex.IsMatch(id, id_regex_pattern2);
            
            if (id == "")
            {
                MessageBox.Show("Opps! ID field cannot be empty.\nPlease, provide a valid ID of 11 digits.\nEx: 20210204***",
                    "Error!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return false;
            }

            else if (!(match1 || match2))
            {
                MessageBox.Show("Opps! ID format doesn't match.\nPlease, provide a valid ID of 11 digits if addmission year is on and after 2020.\nEx: 20210204***\nFor re-add:(Max limit)Ex. 170104***",
                    "Error!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return false;
            }
                
            return true;
        }

        private void switch__to_Form2(string name, double gpa)
        {
            Form2 f2 = new Form2();
            f2.f2_stdname = std_Name;
            f2.f2_gpa = Convert.ToString(gpavg);
            this.Hide();
            f2.Show();

        }
        private void Submit_Button_Click(object sender, EventArgs e)
        {
            std_Name = studentName.Text;
            std_id = studentId.Text;
            
            if(!IsNameValid(std_Name) && IsIDvalid(std_id))
            {
                c1 = crs1_marks.Value;
                c2 = crs2_marks.Value;
                c3 = crs3_marks.Value;
                c4 = crs4_marks.Value;
                c5 = crs5_marks.Value;
                c6 = crs6_marks.Value;
                c7 = crs7_marks.Value;
                c8 = crs8_marks.Value;
                c9 = crs9_marks.Value;

                int a = (int)gpa(c3);
                int b = (int)gpa(c4);
                int c = (int)gpa(c6);
                int d = (int)gpa(c9);

                if( a==0 || b==0 || c==0 || d == 0)
                {
                    MessageBox.Show("Sorry, You failed!\n You must pass all the lab courses.",
                    "Error!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );

                    gpavg = 0.000;

                } else
                {
                    sum += gpa(c1) * 3.00;
                    sum += gpa(c2) * 3.00;
                    sum += gpa(c3) * 1.50;
                    sum += gpa(c4) * 1.50;
                    sum += gpa(c5) * 3.00;
                    sum += gpa(c6) * 1.50;
                    sum += gpa(c7) * 3.00;
                    sum += gpa(c8) * 3.00;
                    sum += gpa(c9) * 0.75;
                    gpavg = Math.Round(sum / 20.25, 3);
                }
                switch__to_Form2(std_Name, gpavg);
            }

        }
    }
}