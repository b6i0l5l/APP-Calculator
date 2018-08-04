using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double value = 0;
        string operation = "";
        bool operation_pressed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (result.Text == "0" || operation_pressed == true)
            {
                result.Clear();
            }
            operation_pressed = false;
            Button b = (Button)sender;
            if (b.Text == ".")
            {
                if (!result.Text.Contains("."))
                {
                    result.Text = result.Text + b.Text;
                }
            }
            else
            {
                result.Text = result.Text + b.Text;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (value != 0)
            {

                equal.PerformClick();
                operation_pressed = true;
                operation = b.Text;
                equation.Text = value + " " + operation;

            }
            else
            {
                
                operation = b.Text;
                value = double.Parse(result.Text);
                operation_pressed = true;
                equation.Text = value + " " + operation;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            equation.Text = "";
            switch(operation)
            {
                case "+":
                    result.Text = (value + double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;
            }
            value = Int32.Parse(result.Text);
            operation = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            result.Clear();
            value = 0;
            equation.Text = "";
            result.Text = "0";
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch(e.KeyChar)
            {
                case(char)48:
                    zero.PerformClick();
                    break;
                case(char)49:
                    one.PerformClick();
                    break;
                case (char)50:
                    two.PerformClick();
                    break;
                case (char)51:
                    three.PerformClick();
                    break;
                case (char)52:
                    four.PerformClick();
                    break;
                case (char)53:
                    five.PerformClick();
                    break;
                case (char)54:
                    six.PerformClick();
                    break;
                case (char)55:
                    seven.PerformClick();
                    break;
                case (char)56:
                    eight.PerformClick();
                    break;
                case (char)57:
                    nine.PerformClick();
                    break;
                case (char)42:
                    times.PerformClick();
                    break;
                case (char)45:
                    sub.PerformClick();
                    break;
                case (char)43:
                    add.PerformClick();
                    break;
                case (char)47:
                    div.PerformClick();
                    break;
                case (char)61:
                    equal.PerformClick();
                    break;
                default:
                    break;

            }
            
        }

        private void convert_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Name == "kglb")
            {
                result.Text = (2.2 * double.Parse(result.Text)).ToString();
            }
            else if (b.Name=="lbkg")
            {
                result.Text = (0.455 * double.Parse(result.Text)).ToString();
            }
            else if (b.Name == "incm")
            {
                result.Text = (double.Parse(result.Text)*12*2.54).ToString();
            }
            else if (b.Name == "cmin")
            {
                result.Text = (double.Parse(result.Text)/2.54/12).ToString();
            }
        }

    }
    
    
}
