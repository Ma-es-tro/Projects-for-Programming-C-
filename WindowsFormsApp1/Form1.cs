using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        bool checker = true;
        int PlayerO = 0;
        int PlayerX = 0;
        string a;
        string b;
        public Form1()
        {
            InitializeComponent();
        }


        void winner()
        {
            if (btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X")
            {
                lbl1.Text = $"The winner is {X.Text}";
                btn1.BackColor = Color.Cyan;
                btn2.BackColor = Color.Cyan;
                btn3.BackColor = Color.Cyan;

                PlayerX++;
                lbl3.Text = $"{PlayerX}";

                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;

                checker = true;
            }
            if (btn1.Text == "X" && btn4.Text == "X" && btn7.Text == "X")
            {
                lbl1.Text = $"The winner is {X.Text}";
                btn1.BackColor = Color.Cyan;
                btn4.BackColor = Color.Cyan;
                btn7.BackColor = Color.Cyan;

                PlayerX++;
                lbl3.Text = $"{PlayerX}";

                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;

                checker = true;
            }
            if (btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X")
            {
                lbl1.Text = $"The winner is {X.Text}";
                btn4.BackColor = Color.Cyan;
                btn5.BackColor = Color.Cyan;
                btn6.BackColor = Color.Cyan;

                PlayerX++;
                lbl3.Text = $"{PlayerX}";

                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;

                checker = true;
            }
            if (btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X")
            {
                lbl1.Text = $"The winner is {X.Text}";
                btn7.BackColor = Color.Cyan;
                btn8.BackColor = Color.Cyan;
                btn9.BackColor = Color.Cyan;

                PlayerX++;
                lbl3.Text = $"{PlayerX}";

                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;

                checker = true;
            }
            if (btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "X")
            {
                lbl1.Text = $"The winner is {X.Text}";
                btn2.BackColor = Color.Cyan;
                btn5.BackColor = Color.Cyan;
                btn8.BackColor = Color.Cyan;

                PlayerX++;
                lbl3.Text = $"{PlayerX}";

                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;

                checker = true;
            }
            if (btn3.Text == "X" && btn6.Text == "X" && btn9.Text == "X")
            {
                lbl1.Text = $"The winner is {X.Text}";
                btn3.BackColor = Color.Cyan;
                btn6.BackColor = Color.Cyan;
                btn9.BackColor = Color.Cyan;

                PlayerX++;
                lbl3.Text = $"{PlayerX}";

                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;

                checker = true;
            }
            if (btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X")
            {
                lbl1.Text = $"The winner is {X.Text}";
                btn1.BackColor = Color.Cyan;
                btn5.BackColor = Color.Cyan;
                btn9.BackColor = Color.Cyan;

                PlayerX++;
                lbl3.Text = $"{PlayerX}";

                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;

                checker = true;
            }
            if (btn7.Text == "X" && btn5.Text == "X" && btn3.Text == "X")
            {
                lbl1.Text = $"The winner is {X.Text}";
                btn7.BackColor = Color.Cyan;
                btn5.BackColor = Color.Cyan;
                btn3.BackColor = Color.Cyan;

                PlayerX++;
                lbl3.Text = $"{PlayerX}";

                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;

                checker = true;
            }
            if (btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O")
            {
                lbl1.Text = $"The winner is {O.Text}";
                btn1.BackColor = Color.Cyan;
                btn2.BackColor = Color.Cyan;
                btn3.BackColor = Color.Cyan;

                PlayerO++;
                lbl4.Text = $"{PlayerO}";

                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;

                checker = true;
            }
            if (btn1.Text == "O" && btn4.Text == "O" && btn7.Text == "O")
            {
                lbl1.Text = $"The winner is {O.Text}";
                btn1.BackColor = Color.Cyan;
                btn4.BackColor = Color.Cyan;
                btn7.BackColor = Color.Cyan;

                PlayerO++;
                lbl4.Text = $"{PlayerO}";

                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;

                checker = true;
            }
            if (btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O")
            {
                lbl1.Text = $"The winner is {O.Text}";
                btn4.BackColor = Color.Cyan;
                btn5.BackColor = Color.Cyan;
                btn6.BackColor = Color.Cyan;

                PlayerO++;
                lbl4.Text = $"{PlayerO}";

                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;

                checker = true;
            }
            if (btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O")
            {
                lbl1.Text = $"The winner is {O.Text}";
                btn7.BackColor = Color.Cyan;
                btn8.BackColor = Color.Cyan;
                btn9.BackColor = Color.Cyan;

                PlayerO++;
                lbl4.Text = $"{PlayerO}";

                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;

                checker = true;
            }
            if (btn2.Text == "O" && btn5.Text == "O" && btn8.Text == "O")
            {
                lbl1.Text = $"The winner is {O.Text}";
                btn2.BackColor = Color.Cyan;
                btn5.BackColor = Color.Cyan;
                btn8.BackColor = Color.Cyan;

                PlayerO++;
                lbl4.Text = $"{PlayerO}";

                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;

                checker = true;
            }
            if (btn3.Text == "O" && btn6.Text == "O" && btn9.Text == "O")
            {
                lbl1.Text = $"The winner is {O.Text}";
                btn3.BackColor = Color.Cyan;
                btn6.BackColor = Color.Cyan;
                btn9.BackColor = Color.Cyan;

                PlayerO++;
                lbl4.Text = $"{PlayerO}";

                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;

                checker = true;
            }
            if (btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O")
            {
                lbl1.Text = $"The winner is {O.Text}";
                btn1.BackColor = Color.Cyan;
                btn5.BackColor = Color.Cyan;
                btn9.BackColor = Color.Cyan;

                PlayerO++;
                lbl4.Text = $"{PlayerO}";

                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;

                checker = true;
            }
            if (btn7.Text == "O" && btn5.Text == "O" && btn3.Text == "O")
            {
                lbl1.Text = $"The winner is {O.Text}";
                btn7.BackColor = Color.Cyan;
                btn5.BackColor = Color.Cyan;
                btn3.BackColor = Color.Cyan;

                PlayerO++;
                lbl4.Text = $"{PlayerO}";

                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;
                
                checker = true;

            }

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string btn1Content = btn1.Text;

            if (!btn1Content.Contains("X") && !btn1Content.Contains("O"))
            {
                if (checker == true)
                {
                    btn1.Text = "X";
                    checker = false;
                }
                else
                {
                    btn1.Text = "O";
                    checker = true;
                }
                winner();
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            string btn2Content = btn2.Text;

            if (!btn2Content.Contains("X") && !btn2Content.Contains("O"))
            {
                if (checker == true)
                {
                    btn2.Text = "X";
                    checker = false;
                }
                else
                {
                    btn2.Text = "O";
                    checker = true;
                }
                winner();
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            string btn3Content = btn3.Text;

            if (!btn3Content.Contains("X") && !btn3Content.Contains("O"))
            {
                if (checker == true)
                {
                    btn3.Text = "X";
                    checker = false;
                }
                else
                {
                    btn3.Text = "O";
                    checker = true;
                }
                winner();
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            string btn4Content = btn4.Text;

            if (!btn4Content.Contains("X") && !btn4Content.Contains("O"))
            {
                if (checker == true)
                {
                    btn4.Text = "X";
                    checker = false;
                }
                else
                {
                    btn4.Text = "O";
                    checker = true;
                }
                winner();
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            string btn5Content = btn5.Text;

            if (!btn5Content.Contains("X") && !btn5Content.Contains("O"))
            {
                if (checker == true)
                {
                    btn5.Text = "X";
                    checker = false;
                }
                else
                {
                    btn5.Text = "O";
                    checker = true;
                }
                winner();
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            string btn6Content = btn6.Text;

            if (!btn6Content.Contains("X") && !btn6Content.Contains("O"))
            {
                if (checker == true)
                {
                    btn6.Text = "X";
                    checker = false;
                }
                else
                {
                    btn6.Text = "O";
                    checker = true;
                }
                winner();
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            string btn7Content = btn7.Text;

            if (!btn7Content.Contains("X") && !btn7Content.Contains("O"))
            {
                if (checker == true)
                {
                    btn7.Text = "X";
                    checker = false;
                }
                else
                {
                    btn7.Text = "O";
                    checker = true;
                }
                winner();
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            string btn8Content = btn8.Text;

            if (!btn8Content.Contains("X") && !btn8Content.Contains("O"))
            {
                if (checker == true)
                {
                    btn8.Text = "X";
                    checker = false;
                }
                else
                {
                    btn8.Text = "O";
                    checker = true;
                }
                winner();
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            string btn9Content = btn9.Text;

            if (!btn9Content.Contains("X") && !btn9Content.Contains("O"))
            {
                if (checker == true)
                {
                    btn9.Text = "X";
                    checker = false;
                }
                else
                {
                    btn9.Text = "O";
                    checker = true;
                }
                winner();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btn1.Text = " ";
            btn2.Text = " ";
            btn3.Text = " ";
            btn4.Text = " ";
            btn5.Text = " ";
            btn6.Text = " ";
            btn7.Text = " ";
            btn8.Text = " ";
            btn9.Text = " ";

            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

            btn1.BackColor = Color.White;
            btn2.BackColor = Color.White;
            btn3.BackColor = Color.White;
            btn4.BackColor = Color.White;
            btn5.BackColor = Color.White;
            btn6.BackColor = Color.White;
            btn7.BackColor = Color.White;
            btn8.BackColor = Color.White;
            btn9.BackColor = Color.White;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void player1_Click(object sender, EventArgs e)
        {
            a = tb1.Text;
            tb1.Text = "";
            X.Text = a;
            
        }

        private void X_Click(object sender, EventArgs e)
        {
            X.Text = a;
        }

        private void O_Click(object sender, EventArgs e)
        {
            O.Text = b;
        }

        private void New_Click(object sender, EventArgs e)
        {
            btn1.Text = " ";
            btn2.Text = " ";
            btn3.Text = " ";
            btn4.Text = " ";
            btn5.Text = " ";
            btn6.Text = " ";
            btn7.Text = " ";
            btn8.Text = " ";
            btn9.Text = " ";

            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

            btn1.BackColor = Color.White;
            btn2.BackColor = Color.White;
            btn3.BackColor = Color.White;
            btn4.BackColor = Color.White;
            btn5.BackColor = Color.White;
            btn6.BackColor = Color.White;
            btn7.BackColor = Color.White;
            btn8.BackColor = Color.White;
            btn9.BackColor = Color.White;

            lbl3.Text = "";
            lbl4.Text = "";
            PlayerO = 0;
            PlayerX = 0;
        }

        private void player2_Click_1(object sender, EventArgs e)
        {
            b = tb2.Text;
            tb2.Text = "";
            O.Text = b;
        }
    }
}

