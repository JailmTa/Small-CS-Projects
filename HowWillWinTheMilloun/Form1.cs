using NAudio.Wave;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HowWillWinTheMilloun
{
    public partial class Form1 : Form
    {
        Random random=new Random();
        List<int> Array=new List<int>();
        int[] ArrayP = {100,200,300,500,1000,2000,4000,8000,16000,32000,64000,125000,250000,500000,1000000 };
        int Count = 0;
        AudioFileReader True,False;
        WaveOutEvent Wt = new WaveOutEvent(),Wf=new WaveOutEvent();
        public Form1()
        {
            InitializeComponent();
            
        }

        

        private void ييي_Click(object sender, EventArgs e)
        {

        }

       
        

        private void btnAudeinc_MouseEnter(object sender, EventArgs e)
        {
          
            btnAudeinc.UseVisualStyleBackColor = false;
        }
        int n = 0;
        private void setQustion()
        {
           
            n = random.Next(Array.Count);

            lQustion.Text = Question.ArrayQeustion[n].TextQustion;
            btnA.Text = Question.ArrayQeustion[n].A;
            btnB.Text = Question.ArrayQeustion[n].B;
            btnC.Text = Question.ArrayQeustion[n].C;
            btnD.Text = Question.ArrayQeustion[n].D;

            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
        }
        private void speak(int Num)
        {
            if (Num == 0)
            {
               

                Wt.Play();
            }
            else
            {
               

                Wf.Play();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           
            Question.addQ();
            for (int i = 0; i < Question.ArrayQeustion.Length; i++)
            {
                Array.Add(i);
            }
            setQustion();
        }

        private void CheckCklick(object sender, MouseEventArgs e)
        {
            
            if (((Button)sender).Tag == Question.ArrayQeustion[n].TrueAnswer)
            {
                Question.WinnigNumber = ArrayP[Count];
                Count++;
                MessageBox.Show("True");
                label1.Top -= 52;
                Array.Remove(n);
                setQustion();
                if (Count == ArrayP.Length)
                {
                    Form2 f= new Form2();
                    f.ShowDialog();
                    this.Close();
                 
                }
            }
            else
            {
                MessageBox.Show("False");
                Form2 f = new Form2();
                f.ShowDialog();
                this.Close();

            }

        }

        private void btnFriend_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I Think The True Is : " + Question.ArrayQeustion[n].TrueAnswer.ToString());
            btnFriend.Enabled = false;
        }

        private void btnAudeinc_Click(object sender, EventArgs e)
        {
            if (btnA.Tag == Question.ArrayQeustion[n].TrueAnswer)
            {
                MessageBox.Show("A : " +65+Environment.NewLine
                               + "B : " + 5 + Environment.NewLine
                               + "C : " + 20 + Environment.NewLine
                               + "D : " + 10 + Environment.NewLine);
            }else if(btnB.Tag == Question.ArrayQeustion[n].TrueAnswer)
            {
                MessageBox.Show("A : " + 5 + Environment.NewLine
                              + "B : " + 65 + Environment.NewLine
                              + "C : " + 20 + Environment.NewLine
                              + "D : " + 10 + Environment.NewLine);
            }else if (btnC.Tag == Question.ArrayQeustion[n].TrueAnswer)
            {
                MessageBox.Show("A : " + 20 + Environment.NewLine
                            + "B : " + 5 + Environment.NewLine
                            + "C : " + 65 + Environment.NewLine
                            + "D : " + 10 + Environment.NewLine);
            }
            else
            {
                MessageBox.Show("A : " + 5 + Environment.NewLine
                            + "B : " + 10 + Environment.NewLine
                            + "C : " + 20 + Environment.NewLine
                            + "D : " + 65 + Environment.NewLine);
            }
            btnAudeinc.Enabled = false; 
        }

        int Counter = 0;
        private void btnCancelAns_Click(object sender, EventArgs e)
        {
            if(Counter<2 && btnA.Tag!= Question.ArrayQeustion[n].TrueAnswer)
            {
                btnA.Text = " ";
                btnA.Enabled = false;
                Counter++;
            }
            if(Counter < 2 && btnB.Tag != Question.ArrayQeustion[n].TrueAnswer)
            {
                btnB.Text = " ";
                btnB.Enabled = false;
                Counter++;
            }
            if (Counter < 2 && btnC.Tag != Question.ArrayQeustion[n].TrueAnswer)
            {
                btnC.Text = " ";
                btnC.Enabled = false;
                Counter++;
            }
            if (Counter < 2 && btnD.Tag != Question.ArrayQeustion[n].TrueAnswer)
            {
                btnD.Text = " ";
                btnD.Enabled = false;
                Counter++;
            }
            btnCancelAns.Enabled = false;
        }
    }
}
