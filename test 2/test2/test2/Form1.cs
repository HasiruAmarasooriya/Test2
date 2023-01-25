using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text== "Fahrenheit to Celcius")
            {
                double f = double.Parse(textBox1.Text);
                double c;

                c = (f - 32) * 5 / 9;

                textBox2.Text = c.ToString();

            }
            else if (comboBox1.Text == "Celcius to Fahrenheit") 
            {
                double c = double.Parse(textBox1.Text);
                double f;

               f = ( c * 9 / 5) + 32;

                textBox2.Text = f.ToString();
            }
            else 
            {
                textBox2.Text = "Please Select one from the above list";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                double f = double.Parse(textBox3.Text);
                double c;

                c = (f - 32) * 5 / 9;

                textBox4.Text = c.ToString();
            }
            else if (radioButton2.Checked == true) 
            {
                double c = double.Parse(textBox3.Text);
                double f;

                f = (c * 9 / 5) + 32;

                textBox4.Text = f.ToString();
            }
            else
            {
                textBox4.Text = "Please Select one from the above list";
            }
        }
    }
}
