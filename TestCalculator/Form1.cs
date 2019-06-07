using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            //textBox4.Text = "mouse on add";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2, num3, total;
            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);
            num3 = Convert.ToInt32(textBox3.Text);
            total = num1 + num2 + num3;
            textBox4.Text = Convert.ToString(total);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-5]"))
            {
                MessageBox.Show("please enter numbers between 0 & 5");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "[^0-3]"))
            {
                MessageBox.Show("please enter numbers between 0 & 3");
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text, "[^0-7]"))
            {
                MessageBox.Show("please enter number between 0 & 7");
                textBox3.Text = textBox3.Text.Remove(textBox3.Text.Length - 1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "";
            //textBox2.Text = "";
            //textBox3.Text = "";
            //textBox4.Text = "";
            this.buttonClear(this);
        }

        private void buttonClear(Control control)
        {
            foreach (Control c in control.Controls)
            {
                var box = c as TextBox;
                if (box != null)
                {
                    box.Text = string.Empty;
                }
                this.buttonClear(c);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
