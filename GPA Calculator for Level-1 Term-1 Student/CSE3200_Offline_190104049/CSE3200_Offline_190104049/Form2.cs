using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSE3200_Offline_190104049
{
    public partial class Form2 : Form
    {
        public string f2_stdname { get; set; }
        public string f2_gpa { get; set; }
        public Form2()
        {
            InitializeComponent();
            
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            //this.Hide();
            this.Close();
            f1.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = $"Welcome {f2_stdname}, to the GPA Generator!";
            label2.Text = $"Your acquired GPA is: {f2_gpa}";
        }
    }
    
}
