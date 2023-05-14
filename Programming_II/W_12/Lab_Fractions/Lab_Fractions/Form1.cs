using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Fractions
{
    public partial class Form1 : Form
    {
        string operation = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void DoCalculation()
        {
            if (!String.IsNullOrEmpty(txtFirstTop.Text) &&
                !String.IsNullOrEmpty(txtFirstBottom.Text) &&
                !String.IsNullOrEmpty(txtSecondTop.Text) &&
                !String.IsNullOrEmpty(txtSecondBottom.Text))
            {
                Fraction first = new Fraction(txtFirstTop.Text, txtFirstBottom.Text);
                Fraction second = new Fraction(txtSecondTop.Text, txtSecondBottom.Text);
                Fraction res = new Fraction();

                if (String.IsNullOrEmpty(operation))
                {
                    MessageBox.Show("Please select one operation option");
                }
                else
                {
                    switch(operation)
                    {
                        case "+":
                            res = first + second; break;
                        case "-":
                            res = first - second; break;
                        case "*":
                            res = first * second; break;
                        case "/":
                            res= first / second; break;
                        default: MessageBox.Show("Please select one operation option"); break;

                    }
                    txtResTop.Text = res.Top.ToString();
                    txtResBottom.Text = res.Bottom.ToString();
                }

            }
            else
            {
                MessageBox.Show("Please complete all fields");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_click(object sender, EventArgs e)
        {
            DoCalculation();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FirstB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                return;
            else
                e.Handled = true;          //discard the non-digit entries

        }

        private void FirstT_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void SecondT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                return;
            else
                e.Handled = true;          //discard the non-digit entries
        }

        private void SecondB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                return;
            else
                e.Handled = true;          //discard the non-digit entries

        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var radioBtn = (RadioButton)sender;
            operation = radioBtn.Text;
            DoCalculation();
        }
    }
}
