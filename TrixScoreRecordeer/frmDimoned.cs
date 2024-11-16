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
    public partial class frmDimoned : Form
    {
        clsGameRecorder rec=null;
        public frmDimoned(clsGameRecorder rec,string t1, string t2   )
        {
            InitializeComponent();
            this.rec = rec;
            lblFirstTeam.Text = t1;
            lblSecondTeam.Text = t2;
        }

        private void guna2NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (((Guna2NumericUpDown)sender).Value != 0)
            {
                if (((Guna2NumericUpDown)sender).Name == guna2NumericUpDown1.Name)
                {
                    guna2NumericUpDown2.Maximum = 13 - guna2NumericUpDown1.Value;
                }
                else
                {
                    guna2NumericUpDown1.Maximum = 13 - guna2NumericUpDown2.Value;
                }
            }
            else
            {
                guna2NumericUpDown1.Maximum = 13;
                guna2NumericUpDown2.Maximum = 13;
            }
        }

        private void frmDimoned_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Convert.ToInt32(guna2NumericUpDown1.Value) + Convert.ToInt32(guna2NumericUpDown2.Value) == 13)
            {
                rec.FirstTeamScore = rec.FirstTeamScore - Convert.ToInt32(guna2NumericUpDown1.Value) * 15;
                rec.SecondTeamScore = rec.SecondTeamScore - Convert.ToInt32(guna2NumericUpDown2.Value) * 15;
                rec.GamePaleyed[3] = rec.Game[3];
            }
        }

        private void frmDimoned_Load(object sender, EventArgs e)
        {

        }
    }
}
