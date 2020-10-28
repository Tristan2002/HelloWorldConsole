using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int input = int.Parse(textBox1.Text);
            int input2 = int.Parse(textBox2.Text);
            int output = input + input2;

            label1.Text = output.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int input = int.Parse(textBox1.Text);
            int input2 = int.Parse(textBox2.Text);
            int output = input * input2;

            label2.Text = output.ToString();
        }
    }
}
