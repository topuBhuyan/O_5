using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuBar
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is Home Page", "HOME");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is About Page", "ABOUT");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is Skills Page", "SKILLS");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is Project Page", "Project");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("This is Contact Page", "CONTACT");
            // MessageBox.Show("NEW", "contact",MessageBoxButtons.YesNoCancel);
            MessageBox.Show("This is Contact Page", "Contact", MessageBoxButtons.AbortRetryIgnore);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("Timer");
        }
    }
}
