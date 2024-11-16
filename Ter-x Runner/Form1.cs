using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ter_x_Runner.Properties;

namespace Ter_x_Runner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Runner.Image = Image.FromFile("C:\\Users\\JAILM\\Downloads\\mooict-t-rex-endless-running-game-assets\\running.gif");
            Pirds.Image = Image.FromFile("C:\\Users\\JAILM\\Downloads\\SHAREit\\bird.gif");
        }

        private void CheckScore()
        {
            foreach (Control i in this.Controls)
            {
                foreach (Control j in this.Controls)
                {
                    if (i is PictureBox && i.Tag == "Runner")
                    {
                        if (j is PictureBox && j.Tag == "Tree")
                        {
                            if (j.Bounds.IntersectsWith(i.Bounds))
                            {
                                timer1.Enabled = false;
                                ((PictureBox)i).Image = Resources.dead;
                            }
                        }
                    }
                }
            }
        }

        private void MovingTrees()
        {
            foreach (Control i in this.Controls)
            {
                Random random = new Random();
                if (i.Tag == "Tree")
                {
                    if (i.Left >= 10)
                    {
                        i.Left -= 10;
                    }
                    else
                    {
                        i.Left = random.Next(810, 830);
                    }
                }
            }
        }

        bool Space = false, Top = false;
        int Jump = 0;
        private void MovingRu()
        {
            if (!Top)
            {
                Runner.Top -= 10;
                Jump += 10;
                if (Jump == 60)
                {
                    Jump = 0;
                    Top = true;
                }
            }
            else
            {
                Runner.Top += 10;
                Jump += 10;
                if (Jump == 60)
                {
                    Jump = 0;
                    Top = false;
                    Space = false;
                }
            }

        }
        int Counter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Counter++;
            if (Counter >= 100)
            {
                timer1.Interval = 40;
            }
            MovingTrees();
            CheckScore();
            if (Space)
            {
                MovingRu();
            }
            String txt = "", Number = "";
            for (int p = 0; p < 8; p++)
            {
                txt += lScore.Text.ToString()[p];
            }
            for (int p = 8; p < lScore.Text.ToString().Length; p++)
            {
                Number += lScore.Text.ToString()[p];
            }

            lScore.Text = txt + (Counter).ToString();
        }
    
    

        private void Runner_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Space)
            {
                Space = true;
            }
            if(e.KeyCode == Keys.R)
            {
                this.Hide();
                Form1 f=new Form1();
                f.Show();
            }
        }
    }
}
