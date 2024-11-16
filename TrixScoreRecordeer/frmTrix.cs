using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;

namespace TrixScoreRecordeer
{
    public partial class frmTrix : Form
    {
        clsGameRecorder rec;
        public frmTrix(clsGameRecorder rec, string t1, string t2)
        {
            InitializeComponent();
            this.rec = rec;
            lblFirstTeam.Text = t1;
            lblSecondTeam.Text = t2;
        }
        int Num1 = 0, Num2 = 0, click = 0;
        private void guna2NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void guna2CircleButton1_Click_1(object sender, EventArgs e)
        {
            if (((Guna2CircleButton)sender).Tag == "1")
            {
                if (click == 0)
                {
                    Num1 += 200;
                }
                else if (click == 1)
                {
                    Num1 += 150;
                }
                else if (click == 2)
                {
                    Num1 += 100;
                }
                else
                {
                    Num1 += 50;
                }
            }
            else
            {
                if (click == 0)
                {
                    Num2 += 200;
                }
                else if (click == 1)
                {
                    Num2 += 150;
                }
                else if (click == 2)
                {
                    Num2 += 100;
                }
                else
                {
                    Num2 += 50;
                }
            }
            ((Guna2CircleButton)sender).Enabled = false;
            click++;
        }

        private void frmTrix_Load(object sender, EventArgs e)
        {

        }

        private void frmTrix_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (guna2CircleButton3.Enabled == false)
                if (guna2CircleButton3.Enabled == guna2CircleButton4.Enabled)
                    if (guna2CircleButton1.Enabled == guna2CircleButton2.Enabled)
                    {
                        rec.FirstTeamScore = rec.FirstTeamScore + Num1;
                        rec.SecondTeamScore = rec.SecondTeamScore + Num2;
                        rec.GamePaleyed[0] = rec.Game[0];
                    }
        }
    }
}
