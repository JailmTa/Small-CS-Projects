using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceShoting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void starsMoving()
        {
            foreach (Control control in this.Controls)
            {
                if (control is PictureBox && control.Tag == "Stars")
                {
                    if (control.Top < 400)
                        control.Top += 10;
                    else
                        control.Top = 0;
                }
            }
        }

        private void BultteMoving()
        {
            foreach (Control control in this.Controls)
            {
                if (control is PictureBox && control.Tag == "Bultte")
                {
                    if (control.Top > 0)
                        control.Top -= 10;
                    else
                        this.Controls.Remove(control);
                }
            }
        }

        private void RevBultteMoving()
        {
            foreach (Control control in this.Controls)
            {
                if (control is PictureBox && control.Tag == "RevBultte")
                {
                    if (control.Top < 500)
                        control.Top += 20;
                    else
                        this.Controls.Remove(control);
                }
            }
        }

        private void AddBultte()
        {
            PictureBox Bultte = new PictureBox();
            this.Controls.Add(Bultte);
            Bultte.BringToFront();
            Bultte.Size = new System.Drawing.Size(51/2, 65/2);
            //Bultte.Location = new System.Drawing.Point(Player.Left, Player.Top);
            Bultte.Left = Player.Left;
            Bultte.Top = Player.Top;
            Bultte.Visible = true;
            Bultte.BackColor = System.Drawing.Color.Transparent;
            Bultte.BackgroundImage = global::SpaceShoting.Properties.Resources.Screenshot_2024_07_24_040651;
            Bultte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            Bultte.Tag = "Bultte";

            String Number = "";
            for (int p = 8; p < lScore.Text.ToString().Length; p++)
            {
                Number += lScore.Text.ToString()[p];
            }

            if (Convert.ToInt32(Number) >= 10)
            {

                PictureBox Bultte2 = new PictureBox();
                this.Controls.Add(Bultte2);
                Bultte2.BringToFront();
                Bultte2.Size = new System.Drawing.Size(51 / 2, 65 / 2);
                //Bultte.Location = new System.Drawing.Point(Player.Left, Player.Top);
                Bultte2.Left = Player.Left + 25;
                Bultte2.Top = Player.Top;
                Bultte2.Visible = true;
                Bultte2.BackColor = System.Drawing.Color.Transparent;
                Bultte2.BackgroundImage = global::SpaceShoting.Properties.Resources.Screenshot_2024_07_24_040651;
                Bultte2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                Bultte2.Tag = "Bultte";
            }
        }

        private void AddRevBultte(Control c)
        {

            PictureBox RevBultte = new PictureBox();
            this.Controls.Add(RevBultte);
            RevBultte.BringToFront();
            RevBultte.Size = new System.Drawing.Size(51/2, 65/2);
            RevBultte.Left = c.Left;
            RevBultte.Top = c.Top;
            RevBultte.Visible = true;
            RevBultte.BackColor = System.Drawing.Color.Transparent;
            RevBultte.BackgroundImage = global::SpaceShoting.Properties.Resources.Screenshot_2024_07_24_040651___Copy;
            RevBultte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            RevBultte.Tag = "RevBultte";


        }

        private void EnemysMoving()
        {
            foreach (Control control in this.Controls)
            {
                if (control is PictureBox && control.Tag == "Enemy")
                {
                    if (control.Top < 400)
                        control.Top += 10;
                    else
                    {
                        Random random = new Random();
                        control.Top = 0;
                        control.Left = random.Next(25, 425);
                        String txt = "", Number = "";
                        for (int p = 0; p < 8; p++)
                        {
                            txt += lScore.Text.ToString()[p];
                        }
                        for (int p = 8; p < lScore.Text.ToString().Length; p++)
                        {
                            Number += lScore.Text.ToString()[p];
                        }

                        lScore.Text = txt + (Convert.ToInt32(Number) + 1).ToString();
                    }
                }
            }
        }

        private void checkWinner()
        {
            foreach (Control i in this.Controls)
            {
                foreach (Control j in this.Controls)
                {
                    if (i is PictureBox && i.Tag == "Bultte")
                    {
                        if (j is PictureBox && j.Tag == "Enemy")
                        {
                            if (j.Bounds.IntersectsWith(i.Bounds))
                            {

                                Random random = new Random();
                                j.Top = 0;
                                j.Left = random.Next(25, 425);
                                this.Controls.Remove(i);
                                String txt = "", Number = "";
                                for (int p = 0; p < 8; p++)
                                {
                                    txt += lScore.Text.ToString()[p];
                                }
                                for (int p = 8; p < lScore.Text.ToString().Length; p++)
                                {
                                    Number += lScore.Text.ToString()[p];
                                }

                                lScore.Text = txt + (Convert.ToInt32(Number) + 5).ToString();
                            }
                        }
                    }
                    else if (i is PictureBox && i.Tag == "Player")
                    {
                        if (j is PictureBox && (j.Tag == "Enemy" || j.Tag == "RevBultte"))
                        {
                            if (i.Bounds.IntersectsWith(j.Bounds))
                            {
                                timer1.Enabled = false;
                                lGameOver.Visible = true;
                                Player.Enabled = false;
                            }
                        }
                    }
                }
            }
        }



        private void pictureBox1_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            int MovingStep = 10;
            switch (e.KeyCode)
            {
                case Keys.Right:
                    if (Player.Left < 425 && Player.Enabled == true)
                        Player.Left += MovingStep;
                    checkWinner();
                    break;
                case Keys.Left:
                    if (Player.Left > 25 && Player.Enabled == true)
                        Player.Left -= MovingStep;
                    checkWinner();
                    break;
                case Keys.Space:
                    if (Player.Enabled == true)
                        AddBultte();
                    break;
                default:
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            starsMoving();
            EnemysMoving();
            BultteMoving();
            RevBultteMoving();
            foreach (Control control in this.Controls)
            {
                if (control is PictureBox && control.Tag == "Enemy".ToString() && control.Top==150)
                {
                    AddRevBultte(control);
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {

        }
    }
}
