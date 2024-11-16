using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EncryptionAndDecreption.Properties;

namespace EncryptionAndDecreption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLC_Click(object sender, EventArgs e)
        {
            String text = tbLA.Text.ToString();
            String EncString = "";
            foreach (char c in text)
            {
                if (c != ' ')
                {
                    EncString += (char)(((int)c) - 15);
                }
                else
                {
                    EncString += c;
                }
            }
            tbLB.Text = EncString.ToString();
        }

        private void btnRC_Click(object sender, EventArgs e)
        {
            String text = tbRA.Text.ToString();
            String DecString = "";
            foreach (char c in text)
            {
                if (c != ' ')
                {
                    DecString += (char)(((int)c) + 15);
                }
                else
                {
                    DecString += c;
                }
            }
            tbRB.Text = DecString.ToString();
        }

        private void btnLF_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "Text Files (*.txt)|*.text | All Files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String Path = openFileDialog1.FileName;
                try
                {
                    String fileContacted = File.ReadAllText(Path);
                    tbLA.Text = fileContacted.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The File IS Empty :(", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRF_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files (*.txt)|*.text | All Files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String Path = openFileDialog1.FileName;
                try
                {
                    String fileContacted = File.ReadAllText(Path);
                    tbRA.Text = fileContacted.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The File IS Empty :(", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        char Col = 'N';
        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (Col == 'N')
            {
                this.BackgroundImage = Resources.Neoneon__2_;
                tbLA.BackColor = System.Drawing.Color.FromArgb(171, 220, 245);
                tbLB.BackColor = System.Drawing.Color.FromArgb(171, 220, 245);
                tbRA.BackColor = System.Drawing.Color.FromArgb(171, 220, 245);
                tbRB.BackColor = System.Drawing.Color.FromArgb(171, 220, 245);
                tbLA.ForeColor = System.Drawing.Color.FromArgb(0,0,0);
                tbLB.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
                tbRA.ForeColor = System.Drawing.Color.FromArgb(0,0,0);
                tbRB.ForeColor = System.Drawing.Color.FromArgb(0,0,0);
                btnLC.Image = Resources.Screenshot_2024_07_08_185035;
                btnRC.Image = Resources.Screenshot_2024_07_08_185035;
                btnLF.Image = Resources.Screenshot_2024_07_08_185040;
                btnRF.Image = Resources.Screenshot_2024_07_08_185040;
                Col = 'L';
            }
            else
            {
                this.BackgroundImage = Resources.Neoneon__1_;
                tbLA.BackColor = System.Drawing.Color.FromArgb(0, 0, 0);
                tbLB.BackColor = System.Drawing.Color.FromArgb(0, 0, 0);
                tbRA.BackColor = System.Drawing.Color.FromArgb(0, 0, 0);
                tbRB.BackColor = System.Drawing.Color.FromArgb(0, 0, 0);
                tbLA.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
                tbLB.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
                tbRA.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
                tbRB.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
                btnLC.Image = Resources.Screenshot_2024_07_08_175256;
                btnRC.Image = Resources.Screenshot_2024_07_08_175256;
                btnLF.Image = Resources.Screenshot_2024_07_08_180624;
                btnRF.Image = Resources.Screenshot_2024_07_08_180624;
                Col = 'N';
            }
        }
    }
}
