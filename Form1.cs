﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatrice
{
    public partial class Form1 : Form
    {
        string total;
        string options;
        int num1, num2, result;
        public Form1()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textTotal.Text = textTotal.Text + button13.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textTotal.Text = textTotal.Text + button14.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textTotal.Text = textTotal.Text + button15.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textTotal.Text = textTotal.Text + button16.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textTotal.Text = textTotal.Text + button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textTotal.Text = textTotal.Text + button10.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textTotal.Text = textTotal.Text + button11.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textTotal.Text = textTotal.Text + button7.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textTotal.Text = textTotal.Text + button6.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            options = "-";
            num1 = int.Parse(textTotal.Text);
            textTotal.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            options = "*";
            num1 = int.Parse(textTotal.Text);
            textTotal.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            options = "/";
            num1 = int.Parse(textTotal.Text);
            textTotal.Clear();
        }

 

        private void button1_Click(object sender, EventArgs e)
        {
            textTotal.Clear();
            result = (0);
            num1 = (0);
            num2 = (0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textTotal.Clear();
            result = (0);
            num1 = (0);
            num2 = (0);
        }

        private void button17_Click(object sender, EventArgs e)
        {

            num2 = int.Parse(textTotal.Text);
            if (options == ("+"))
            {
                result = num1 + num2;
            }
            if (options == ("-"))
            {
                result = num1 - num2;
            }
            if (options == ("*"))
            {
                result = num1 * num2;
            }
            if (options == ("/"))
            {
                result = num1 / num2;
            }
            textTotal.Text = result + "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textTotal.Text = textTotal.Text + button5.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            options = "+";
            num1 = int.Parse(textTotal.Text);
            textTotal.Clear();
        }
    }
}
