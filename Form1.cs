//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace WindowsFormsApp3
//{
//    public partial class Form1 : Form
//    {
//        string text;
//        public Form1()
//        {
//            InitializeComponent();
//        }

//        private void button1_Click(object sender, EventArgs e)
//        {
//            text = textBox1.Text;
//            textBox1.Text = "";
//        }
//        private void button2_Click(object sender, EventArgs e)
//        {
//            textBox2.Text = text;
//        }

//        private void textBox1_TextChanged(object sender, EventArgs e)
//        {

//        }

//        private void textBox2_TextChanged(object sender, EventArgs e)
//        {

//        }

        
//    }
//}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        float a,b;
        char znak;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Calculator";
            Size = new Size(342, 582);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
        }
        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
        }
        private void button18_Click(object sender, EventArgs e)
        {
            //%
            while (textBox1.Text != " ")
            {
                a = float.Parse(textBox1.Text);
                textBox1.Text = " ";
                znak = '%';
            }
        }
        private void buttonDelenie_Click(object sender, EventArgs e)
        {
            while (textBox1.Text != " ")
            {
                a = float.Parse(textBox1.Text);
                textBox1.Text = " ";
                znak = '/';
            }
        }

        private void buttonUmnoz_Click(object sender, EventArgs e)
        {
            while (textBox1.Text != " ")
            {
                a = float.Parse(textBox1.Text);
                textBox1.Text = " ";
                znak = '*';
            }
            
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            while (textBox1.Text != " ")
            {
                a = float.Parse(textBox1.Text);
                textBox1.Text = " ";
                znak = '-';
            }
            
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            while (textBox1.Text != " ")
            {
                a = float.Parse(textBox1.Text);
                textBox1.Text = " ";
                znak = '+';
            }
            
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            if (znak == '+')
            {
                if (textBox1.Text != " ")
                {
                    b = a + float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                }
                
            }           
            else if (znak == '-')
            {
                if (textBox1.Text != " ")
                {
                    b = a - float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                }
            }
            else if (znak == '*')
            {
                if (textBox1.Text != " ")
                {
                    b = a * float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                }
            }
            else if (znak == '/')
            {
                if (textBox1.Text != " ")
                {
                    if (float.Parse(textBox1.Text) != 0)
                        b = a / float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                }
            }
            else if (znak == '%')
            {
                if (textBox1.Text != " ")
                {
                    b = a % float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                }
            }
        }
        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
        private void textBox1_TextChanged(object sender, EventArgs e) {}
        
        
    }
}