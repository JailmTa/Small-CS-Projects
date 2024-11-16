using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculeter
{
    public partial class Form1 : Form
    {
        float Ans ,Num1, Num2;
        string s = "";
        short re = 0;
        char op = ' ';
        public Form1()
        {
            InitializeComponent();
        }

       
        private void btnDel_Click(object sender, EventArgs e)
        {
            lAns.Text = " ";
            op = ' ';
            re = 0;
            Num1 = 0;
            Num2 = 0;
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (op == ' ')
            {
                lAns.Text += " - ";
                op = '-';

            }
            else
            {
                MessageBox.Show("You Can't Use Two Opreations At Same Time", "Fouces", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (op == ' ')
            {
                lAns.Text += " / ";
                op = '/';
            }
            else
            {
                MessageBox.Show("You Can't Use Two Opreations At Same Time", "Fouces", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
        }

        private void btnAns_Click(object sender, EventArgs e)
        {
            switch (op)
            {
                case '+':
                    Ans = Num1 + Num2;
                    break;
                case '-':
                    Ans = Num1 - Num2;
                    break;
                case '/':
                    Ans = (float)(Num1 / Num2);
                    break;
                case '*':
                    Ans = Num1 * Num2;
                    break;
            }
            Num1 = Ans;
            lAns.Text = Ans.ToString();
            op = ' ';
            re = 0;
        }

        private void click_Buttons(object sender, EventArgs e)
        {
            Button btn=(Button) sender;
            if (op == ' ')
            {
                if (re == 0)
                {
                    lAns.Text = btn.Tag.ToString();
                    Num1 = Convert.ToInt64(btn.Tag);
                    re++;
                }
                else
                {
                    lAns.Text += btn.Tag.ToString();
                    Num1 = (Num1 * 10) + Convert.ToInt64(btn.Tag);
                }
            }
            else
            {
                if (re == 0)
                {
                    lAns.Text += btn.Tag.ToString();
                    Num2 = Convert.ToInt64(btn.Tag);
                    re++;
                }
                else
                {
                    lAns.Text += btn.Tag.ToString();
                    Num2 = (Num2 * 10) + Convert.ToInt64(btn.Tag);
                }

            }
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            if (op == ' ')
            {
                lAns.Text += " * ";
            
                op = '*';
            }
            else
            {
                MessageBox.Show("You Can't Use Two Opreations At Same Time", "Fouces", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            if (op == ' ')
            {
                lAns.Text += " + ";
               
                op = '+';

            }
            else
            {
                MessageBox.Show("You Can't Use Two Opreations At Same Time", "Fouces", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

          
        }
    }
}
