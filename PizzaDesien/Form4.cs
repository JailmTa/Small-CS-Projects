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
using BussnesLayer;

namespace PizzaDesien
{
    public partial class Form4 : Form
    {
        
        public Form4()
        {
            InitializeComponent();
        }

        private void PutErrorProvider(object textBox,CancelEventArgs e)
        {
            if(((Guna2TextBox)textBox).Text == "")
            {
                e.Cancel = true;
                ((Guna2TextBox)textBox).Focus();
                errorProvider1.SetError((Guna2TextBox)textBox, "You Must Fill The Text Box");
            }
            else
            {
                e.Cancel=false;
                errorProvider1.SetError((Guna2TextBox)textBox, "");
            }
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (tbFirstName.Text == "" || tbLastName.Text == "" || tbEmail.Text == "" || tbAddreass.Text == "" || tbPhoneNumber.Text == "" || tbUserName.Text == "" || tbPassWord.Text == "" || tbConfermPassWord.Text == "")
            {
                MessageBox.Show("The Are Missed Inforamtions !", "DenaySave", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tbPassWord.Text != tbConfermPassWord.Text)
            {
                MessageBox.Show("The PassWord Don't Copied !", "DenaySave", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(MessageBox.Show("Are You Sure You Want To Save ?","Conferm",MessageBoxButtons.OKCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2)==DialogResult.OK)
            {
                
                this.Close();
            }
        }

        private void btnCansel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llSetPic_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Filter = "ImagePNG (*.png)|*.png | ImageJPG (*.jpg)|*.jpg";
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                pbProfilPhoto.Image=Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
}
