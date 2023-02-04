using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                errorProvider1.SetError(textBox1, "Please Fill the Box!");
            else
            {
                errorProvider1.Clear();
                try
                {
                    int age = int.Parse(textBox1.Text);
                    MessageBox.Show("You are " + age + " Year Old.");
                }
                catch
                {
                    errorProvider1.SetError(textBox1, "Please Enter a Valid Age!");
                }
            }
        }
    }
}
