using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockSeccirePaber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Result.NumberOfRounds = (short)numRounds.Value;
            this.Hide();
            Form2 f=new Form2();
            f.ShowDialog();
        }

        private void numRounds_ValueChanged(object sender, EventArgs e)
        {
           
        }
    }
}
