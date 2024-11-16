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
    public partial class frmSetNames : Form
    {
        public frmSetNames()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text != "" || guna2TextBox2.Text != "")
            {
                frmMain Main = new frmMain(guna2TextBox1.Text, guna2TextBox2.Text);
                this.Hide();
                Main.ShowDialog();
            }
            else
            {
                MessageBox.Show("You Should Enter The Names Before","Missing Info",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
