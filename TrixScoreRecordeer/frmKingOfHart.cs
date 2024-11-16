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
    public partial class frmKingOfHart : Form
    {
        clsGameRecorder rec = null;
        public frmKingOfHart(clsGameRecorder rec, string t1, string t2)
        {
            InitializeComponent();
            this.rec = rec;
            lblFirstTeam.Text = t1;
            lblSecondTeam.Text = t2;
        }

        private void guna2NumericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            Guna2NumericUpDown b = ((Guna2NumericUpDown)sender);
            if (b.Value == 1)
            {
                if (b.Name == guna2NumericUpDown1.Name)
                {
                    guna2NumericUpDown2.Maximum = 0;
                }
                else
                {
                    guna2NumericUpDown1.Maximum = 0;
                }
            }
            else
            {
                guna2NumericUpDown1.Maximum = 1;
                guna2NumericUpDown2.Maximum = 1;
            }
        }

        private void frmKingOfHart_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Convert.ToInt32(guna2NumericUpDown1.Value) + Convert.ToInt32(guna2NumericUpDown2.Value) == 1)
            {
                if (guna2ToggleSwitch1.Checked == false)
                {

                    rec.FirstTeamScore = rec.FirstTeamScore - Convert.ToInt32(guna2NumericUpDown1.Value) * 75;
                    rec.SecondTeamScore = rec.SecondTeamScore - Convert.ToInt32(guna2NumericUpDown2.Value) * 75;

                }
                else
                {
                    if (Convert.ToInt32(guna2NumericUpDown1.Value) == 0)
                    {
                        rec.FirstTeamScore = rec.FirstTeamScore + 75;
                        rec.SecondTeamScore = rec.SecondTeamScore - 150;
                    }
                    else
                    {
                        rec.FirstTeamScore = rec.FirstTeamScore - 150;
                        rec.SecondTeamScore = rec.SecondTeamScore + 75;
                    }

                }
                guna2ToggleSwitch1.Checked = false;
                rec.GamePaleyed[2] = rec.Game[2];
            }
        }

        private void frmKingOfHart_Load(object sender, EventArgs e)
        {

        }
    }
}
