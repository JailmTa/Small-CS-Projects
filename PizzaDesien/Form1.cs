using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussnesLayer;

namespace PizzaDesien
{
    public partial class Form1 : Form
    {
        int _ID = 0;

        public Form1()
        {
            InitializeComponent();
        }


        private int LogInCheck()
        {
            _ID = clsBussness.LogIn(tbUserName.Text, tbPassWord.Text);
            return _ID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (LogInCheck()>0)
            {
                this.Hide();
                Form2 f = new Form2(_ID);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("PassWord Or UserName Is InCorect","Denay Accsess",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnSingUp_Click(object sender, EventArgs e)
        {
            
            Form4 form4 = new Form4();  
            form4.ShowDialog(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
