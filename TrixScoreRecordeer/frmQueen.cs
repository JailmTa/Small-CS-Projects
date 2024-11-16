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
    public partial class frmQueen : Form
    {
        clsGameRecorder rec;
        int Result1, Result2;
        public enum enMode {New=0,Edit=1};

        public enMode mode = enMode.New;
        public frmQueen(clsGameRecorder rec, string t1, string t2, enMode mode=enMode.New)
        {
            InitializeComponent();
            this.rec = rec;
            lblFirstTeam.Text = t1;
            lblSecondTeam.Text = t2;
            Result1 = rec.FirstTeamScore;
            Result2 = rec.SecondTeamScore;
            this.mode = mode;
        }

        private void guna2NumericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (mode == enMode.New)
            {
                if (((Guna2NumericUpDown)sender).Value != 0)
                {
                    if (((Guna2NumericUpDown)sender).Name == guna2NumericUpDown1.Name)
                    {
                        guna2NumericUpDown2.Maximum = 4 - guna2NumericUpDown1.Value;
                        if (guna2ToggleSwitch1.Checked == false)
                        {
                            rec.FirstTeamScore = rec.FirstTeamScore - 25;
                        }
                        else
                        {
                            rec.FirstTeamScore = rec.FirstTeamScore - 50;
                            rec.SecondTeamScore = rec.SecondTeamScore + 25;
                        }
                    }
                    else
                    {
                        guna2NumericUpDown1.Maximum = 4 - guna2NumericUpDown2.Value;
                        if (guna2ToggleSwitch1.Checked == false)
                        {
                            rec.SecondTeamScore = rec.SecondTeamScore - 25;
                        }
                        else
                        {
                            rec.FirstTeamScore = rec.FirstTeamScore + 25;
                            rec.SecondTeamScore = rec.SecondTeamScore - 50;
                        }
                    }
                }
                else
                {
                    guna2NumericUpDown1.Maximum = 4;
                    guna2NumericUpDown2.Maximum = 4;
                }
                guna2ToggleSwitch1.Checked = false;
            }
            else
            {
                if (((Guna2NumericUpDown)sender).Value != 0)
                {
                    if (((Guna2NumericUpDown)sender).Name == guna2NumericUpDown1.Name)
                    {
                        guna2NumericUpDown2.Maximum = 4 - guna2NumericUpDown1.Value;
                        if (guna2ToggleSwitch1.Checked == false)
                        {
                            Result1 = Result1 - 25;
                        }
                        else
                        {
                            Result1 = Result1 - 50;
                           Result2 = Result2 + 25;
                        }
                    }
                    else
                    {
                        guna2NumericUpDown1.Maximum = 4 - guna2NumericUpDown2.Value;
                        if (guna2ToggleSwitch1.Checked == false)
                        {
                           Result2 = Result2 - 25;
                        }
                        else
                        {
                            Result1 = Result1 + 25;
                           Result2 = Result2- 50;
                        }
                    }
                }
                else
                {
                    guna2NumericUpDown1.Maximum = 4;
                    guna2NumericUpDown2.Maximum = 4;
                }
                guna2ToggleSwitch1.Checked = false;
            }
        }

        private void frmQueen_Load(object sender, EventArgs e)
        {

        }

        private void frmQueen_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Convert.ToInt32(guna2NumericUpDown1.Value) + Convert.ToInt32(guna2NumericUpDown2.Value) == 4)
            {
                rec.GamePaleyed[4] = rec.Game[4];
                if (mode == enMode.Edit)
                {
                    rec.FirstTeamScore = Result1;
                    rec.SecondTeamScore = Result2;
                }
            }
            else
            {
                rec.FirstTeamScore = Result1;
                rec.SecondTeamScore = Result2;
            }
        }
    }
}
