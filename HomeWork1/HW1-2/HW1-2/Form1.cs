using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_MarginChanged(object sender, EventArgs e)
        {

        }

        
        private readonly object cmbTest;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

       

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            


        }

        private void button1_Click(object sender, EventArgs e) 
        {
            
            String num1 = textBox1.Text;
            int m = int.Parse(num1);

            String num2 = textBox2.Text;
            int n = int.Parse(num2);

            String sign = comboBox1.Text;

            if (sign == "+")
            {
                int t = m + n;
                String str = t.ToString();
                result.Text = str;
            }
            else if (sign == "-")
            {

                int t = m - n;
                String str = t.ToString();
                result.Text = str;

            }
            else if (sign == "*")
            {
                int t = m * n;
                String str = t.ToString();
                result.Text = str;

            }
            else if (sign == "/")
            {
                int t = m / n;
                String str = t.ToString();
                result.Text = str;

            }
            



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //String c = comboBox1.SelectedText;


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           

        }
    }
}
