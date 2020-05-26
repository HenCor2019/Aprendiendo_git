using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculators
{
    public partial class Form1 : Form
    {
        private string first = "", second = "",ope="";
        private bool setOperation=false,setFirstDecimal=false,setSecondDecimal=false;
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonAction(double number)
        {
            if (!setOperation)
                first += number;
            else
                second += number;
            label1.Text = first + ope + second;
        }

        private void SetDot()
        {
            if (second.Equals("") && !setFirstDecimal)
            {
                first += ".";
                setFirstDecimal = true;
            }

            if (!second.Equals("") && !setSecondDecimal)
            {
                second += ".";
                setSecondDecimal = true;
            }

            label1.Text = first + ope + second;
        }
        private void OperatorAction(char c)
        {
            if (!first.Equals(""))
            {
                ope = c.ToString();
                Calculadora.A = Convert.ToDouble(first);
                Calculadora.Op = c;
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            ButtonAction(10);
        }

        private void buttonequals_Click(object sender, EventArgs e)
        {
            label1.Text = Calculadora.Calculate();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ButtonAction(7);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ButtonAction(9);
        }

        private void MultiplyButton_click(object sender, EventArgs e)
        {
            label1.Text = Calculadora.SetOperador('*');
            }

        private void button0_Click(object sender, EventArgs e)
        {
            ButtonAction(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ButtonAction(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ButtonAction(3);
        } 
        private void button4_Click(object sender, EventArgs e) 
        {
            ButtonAction(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ButtonAction(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ButtonAction(6);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ButtonAction(8);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ButtonAction(2);
        }

        private void doc_click()
        {
            
        }
    }
}