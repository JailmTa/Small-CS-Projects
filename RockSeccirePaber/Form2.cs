using RockSeccirePaber.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockSeccirePaber
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void setPic(int Num)
        {
            if (Num == 0)
            {
                pictureBox2.Image = Resources.Screenshot_2024_07_04_010706;
                pictureBox2.Tag = 0;
            }
            else if (Num == 1)
            {
                pictureBox2.Image = Resources.Screenshot_2024_07_04_010732;
                pictureBox2.Tag = 1;
            }
            else
            {
                pictureBox2.Image = Resources.Screenshot_2024_07_04_010802;
                pictureBox2.Tag = 2;
            }
        }

     
        static int n = Result.NumberOfRounds;
        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbChoise.SelectedIndex == 0)
            {
                pictureBox1.Image = Resources.Screenshot_2024_07_04_010706;
                pictureBox1.Tag = 0;
            }
            else if (cbChoise.SelectedIndex == 1)
            {
                pictureBox1.Image = Resources.Screenshot_2024_07_04_010732;
                pictureBox1.Tag = 1;
            }
            else
            {
                pictureBox1.Image = Resources.Screenshot_2024_07_04_010802;
                pictureBox1.Tag = 2;
            }

            getWinner(Convert.ToInt32( pictureBox1.Tag));
            n--;
            if(n == 0)
            {
                cbChoise.Enabled = false;
                btnResult.Visible = true;
            }
        }

        private void getWinner(int User)
        {
            Random random = new Random();
            int Coumputer = random.Next(0, 3);
            setPic(Coumputer);
            if (User == 0 && Coumputer == 1)
            {
                Result.UserLoser++;
            }
            else if (User == 1 && Coumputer == 0)
            {
                Result.UserWiner++;
            }
            else if (User == 0 && Coumputer == 2)
            {
                Result.UserWiner++;
            }
            else if (User == 2 && Coumputer == 0)
            {
                Result.UserLoser++;
            }
            else if (User == 2 && Coumputer == 1)
            {
                Result.UserWiner++;
            }
            else if (User == 1 && Coumputer == 2)
            {
                Result.UserLoser++;
            }

        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rounds : "+Result.NumberOfRounds+Environment.NewLine+"User Winning Times : "+Result.UserWiner);
        }
    }
}
