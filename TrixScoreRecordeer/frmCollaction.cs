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

namespace TrixScoreRecordeer
{
    public partial class frmCollaction : Form
    {
        clsGameRecorder rec=null;
        public frmCollaction(clsGameRecorder clsGame,string t1,string t2)
        {
            InitializeComponent();
            rec = clsGame;
            lblFirstTeam.Text = t1;
            lblSecondTeam.Text = t2;
        }

        private void guna2NumericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (((Guna2NumericUpDown)sender).Value != 0)
            {
                if (((Guna2NumericUpDown)sender).Name == guna2NumericUpDown1.Name)
                {
                    guna2NumericUpDown2.Maximum = 13-guna2NumericUpDown1.Value;
                }
                else
                {
                    guna2NumericUpDown1.Maximum = 13-guna2NumericUpDown2.Value;
                }
            }
            else
            {
                guna2NumericUpDown1.Maximum = 13;
                guna2NumericUpDown2.Maximum = 13;
            }
        }

        private void frmCollaction_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Convert.ToInt32(guna2NumericUpDown1.Value) + Convert.ToInt32(guna2NumericUpDown2.Value) == 13)
            {
                rec.FirstTeamScore = rec.FirstTeamScore - Convert.ToInt32(guna2NumericUpDown1.Value) * 10;
                rec.SecondTeamScore = rec.SecondTeamScore - Convert.ToInt32(guna2NumericUpDown2.Value) * 10;
                rec.GamePaleyed[1] = rec.Game[1];
            }   
        }

        private void frmCollaction_Load(object sender, EventArgs e)
        {

        }
    }
}
