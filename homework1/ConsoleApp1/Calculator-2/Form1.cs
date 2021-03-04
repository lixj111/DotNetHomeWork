using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, y, z;
            x = Convert.ToSingle(textBox1.Text);
            y = Convert.ToSingle(textBox2.Text);
            z = x + y;
            textBox3.Text = z.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x, y, z;
            x = Convert.ToSingle(textBox1.Text);
            y = Convert.ToSingle(textBox2.Text);
            z = x - y;
            textBox3.Text = z.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double x, y, z;
            x = Convert.ToSingle(textBox1.Text);
            y = Convert.ToSingle(textBox2.Text);
            z = x * y;
            textBox3.Text = z.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double x, y, z;
            x = Convert.ToSingle(textBox1.Text);
            y = Convert.ToSingle(textBox2.Text);
            z = x / y;
            textBox3.Text = z.ToString();
        }
    }
}
