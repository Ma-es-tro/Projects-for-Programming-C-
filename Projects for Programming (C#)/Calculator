using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projects_for_Programming__C__
{
    public partial class Form1 : Form
    {
        decimal a, b;
        decimal result;
        char operation;
        string number;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;


            Screen.Text += button.Text;

        }

        private void button4_Click(object sender, EventArgs e)
        {

            Button operationB = (Button)sender;
            a = decimal.Parse(Screen.Text);
            Screen.Text = "";
            operation = char.Parse(operationB.Text);

        }

        private void button15_Click(object sender, EventArgs e)
        {

            {
                b = decimal.Parse(Screen.Text);

                switch (operation)
                {
                    case '+':
                        result = a + b;
                        break;
                    case '-':
                        result = a - b;
                        break;
                    case '*':
                        result = a * b;
                        break;
                    case '/':
                        if (b == 0)
                        {
                            MessageBox.Show("Cannot divide by zero.");
                            return;
                        }
                        result = a / b;
                        break;
                    default:
                        MessageBox.Show("Invalid operation.");
                        return;
                }
                number = a.ToString();

                if (number.Contains('.'))
                {
                    Screen.Text = result.ToString();
                }
                else if (Screen.Text.Contains('.'))
                {
                    Screen.Text = result.ToString();
                }
                else
                { Screen.Text = result.ToString("#,##0"); }

            }

        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            Screen.Text = "";
        }

        private void NotNo_Click(object sender, EventArgs e)
        {
            Button ButOn = (Button)sender;


            if (!Screen.Text.Contains('.'))
                Screen.Text += ButOn.Text;
        }
        private void Comma_Click(object sender, EventArgs e)
        {
            Button ButOn = (Button)sender;

            if (!Screen.Text.Contains(','))
                Screen.Text += ButOn.Text;

        }
    }
}
