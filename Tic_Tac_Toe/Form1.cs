using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe.Properties;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Image.FromFile(@"C:\\Users\\JAILM\\Downloads\\Images (1)\\Images\\question-mark-96.png").Tag = '?';
            Image.FromFile(@"C:\\Users\\JAILM\\Downloads\\Images (1)\\Images\\O.png").Tag = 'O';
            Image.FromFile(@"C:\\Users\\JAILM\\Downloads\\Images (1)\\Images\\X.png").Tag = 'X';
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            Color White = Color.FromArgb(255, 255, 255, 255);
            Pen pen = new Pen(White, 10);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            e.Graphics.DrawLine(pen, 450, 50, 450, 350);
            e.Graphics.DrawLine(pen, 550, 50, 550, 350);
            e.Graphics.DrawLine(pen, 350, 150, 650, 150);
            e.Graphics.DrawLine(pen, 350, 250, 650, 250);
        }

        int Counter = 0;
        private void setImg(Button btn)
        {
            btn.Image = Resources.question_mark_96;
            btn.Tag = "?";
            btn.BackColor= Color.Black;
        }
        private void restart()
        {
            Counter = 0;
            setImg(btn1);
            setImg(btn2);   
            setImg(btn3);   
            setImg(btn4);
            setImg(btn5);
            setImg(btn6);
            setImg(btn7);
            setImg(btn8);   
            setImg(btn9);

            lTurnA.Text = "Player One";
            lWinnerA.Text = "In Progreas";
        }

        private void checkIfWin()
        {
            if (btn1.Tag == btn2.Tag && btn1.Tag == btn3.Tag && btn1.Tag != "?")
            {
                btn1.BackColor = Color.GreenYellow;
                btn2.BackColor = Color.GreenYellow;
                btn3.BackColor = Color.GreenYellow;
                lWinnerA.Text = "The Player " + ((Counter % 2) + 1);
                MessageBox.Show("Game Over");
                restart();
            }
            if (btn1.Tag == btn5.Tag && btn1.Tag == btn9.Tag && btn1.Tag != "?")
            {
                btn1.BackColor = Color.GreenYellow;
                btn5.BackColor = Color.GreenYellow;
                btn9.BackColor = Color.GreenYellow;
                lWinnerA.Text = "The Player " + ((Counter % 2) + 1);
                MessageBox.Show("Game Over");
                restart();
            }
            if (btn1.Tag == btn4.Tag && btn1.Tag == btn7.Tag && btn1.Tag != "?")
            {
                btn1.BackColor = Color.GreenYellow;
                btn4.BackColor = Color.GreenYellow;
                btn7.BackColor = Color.GreenYellow;
                lWinnerA.Text = "The Player " + ((Counter % 2) + 1);
                MessageBox.Show("Game Over");
                restart();
            }
            if (btn5.Tag == btn2.Tag && btn2.Tag == btn8.Tag && btn2.Tag != "?")
            {
                btn5.BackColor = Color.GreenYellow;
                btn2.BackColor = Color.GreenYellow;
                btn8.BackColor = Color.GreenYellow;
                lWinnerA.Text = "The Player " + ((Counter % 2) + 1);
                MessageBox.Show("Game Over");
                restart();
            }
            if (btn3.Tag == btn5.Tag && btn3.Tag == btn7.Tag && btn3.Tag != "?")
            {
                btn5.BackColor = Color.GreenYellow;
                btn7.BackColor = Color.GreenYellow;
                btn3.BackColor = Color.GreenYellow;
                lWinnerA.Text = "The Player " + ((Counter % 2) + 1);
                MessageBox.Show("Game Over");
                restart();
            }
            if (btn6.Tag == btn3.Tag && btn9.Tag == btn3.Tag && btn6.Tag != "?")
            {
                btn9.BackColor = Color.GreenYellow;
                btn6.BackColor = Color.GreenYellow;
                btn3.BackColor = Color.GreenYellow;
                lWinnerA.Text = "The Player " + ((Counter % 2) + 1);
                MessageBox.Show("Game Over");
                restart();
            }
            if (btn4.Tag == btn5.Tag && btn5.Tag == btn6.Tag && btn4.Tag != "?")
            {
                btn6.BackColor = Color.GreenYellow;
                btn5.BackColor = Color.GreenYellow;
                btn4.BackColor = Color.GreenYellow;
                lWinnerA.Text = "The Player " + ((Counter % 2) + 1);
                MessageBox.Show("Game Over");
                restart();
            }
            if (btn7.Tag == btn8.Tag && btn7.Tag == btn9.Tag && btn7.Tag != "?")
            {
                btn7.BackColor = Color.GreenYellow;
                btn8.BackColor = Color.GreenYellow;
                btn9.BackColor = Color.GreenYellow;
                lWinnerA.Text = "The Player " + ((Counter % 2) + 1);
                MessageBox.Show("Game Over");
                restart();
            }
            if (Counter == 9)
            {
                lWinnerA.Text = "Draw";
                MessageBox.Show("Game Over");
                restart();
            }

        }

        private void chingeImage(Button btn)
        {
            if (btn.Tag == "?" && Counter % 2 == 0)
            {
                btn.Image = Resources.X;
                btn.Tag = "X";
                lTurnA.Text = "Player Two";
                Counter++;
            }
            else if (btn.Tag == "?" && Counter % 2 == 1)
            {
                btn.Image = Resources.O;
                btn.Tag = "O";
                lTurnA.Text = "Player One";
                Counter++;
            }
            else
            {
                MessageBox.Show("The Opetion Isn't Avilabel :(", "Can't Change", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            checkIfWin();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            chingeImage((Button) sender);
        }

      
        private void btnRestartGame_Click(object sender, EventArgs e)
        {
            restart();
        }
    }
}
