using BussnesLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaDesien
{
    public partial class Form2 : Form
    {
        int _ID = 0;
        short Price = 0;
        short Size, Thin, CheckBoxs;
        int Stutes = 0;

        private string getPrice(short n1, short n2, short n3)
        {
            short n = Convert.ToInt16(numericUpDown1.Value.ToString());
            Price = (short)((n1 + n2 + n3) * (n));
            return Price.ToString() + "$";
        }
        public Form2(int iD)
        {
            Stutes = 0;
            InitializeComponent();
            _ID = iD;
            btnOrder.Text = "Order";
        }

        public Form2(int iD, string Size, string Thin,
            string Place, string Extinshen, int NumberOfPizzas, DateTime DateOfOrder)
        {
            _ID = iD;
            Stutes = 1;
            InitializeComponent();
            if (Size == "Small")
            {
                rbSmall.Checked = true;
            }
            else if (Size == "Meduim")
            {
                rbMeduim.Checked = true;
            }
            else
            {
                rbLarg.Checked = true;
            }

            if (Thin == "Thin")
            {
                rbThin.Checked = true;
            }
            else
            {
                rbThik.Checked = true;
            }

            if (Place == "Eating InSide")
            {
                rbEatIn.Checked = true;
            }
            else
            {
                rbEatOut.Checked = true;
            }

            string[] Ex = Extinshen.Split('/');
            foreach (string i in Ex)
            {
                if (i == "Extra Chees")
                {
                    chkExtraChees.Checked = true;
                }
                else if (i == "Mushrooms")
                {
                    chkMushrooms.Checked = true;
                }
                else if (i == "Tomatoes")
                {
                    chkTomatoes.Checked = true;
                }
                else if (i == "Onion")
                {
                    chkOnion.Checked = true;
                }
                else if (i == "Olives")
                {
                    chkOlives.Checked = true;
                }
                else
                {
                    chkGreenPeppers.Checked = true;
                }
            }
            btnOrder.Text = "UpDate";
            numericUpDown1.Value = NumberOfPizzas;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void gbEat_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rbThik_CheckedChanged(object sender, EventArgs e)
        {
            Thin = Convert.ToInt16(rbThik.Tag);
            lCrustA.Text = "Thik";
            lPriceA.Text = getPrice(Size, Thin, CheckBoxs).ToString();
        }

        private void rbThin_CheckedChanged(object sender, EventArgs e)
        {
            Thin = Convert.ToInt16(rbThin.Tag);
            lCrustA.Text = "Thin";
            lPriceA.Text = getPrice(Size, Thin, CheckBoxs).ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lCrust_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            Size = 10;
            lSizeA.Text = "Small";
            lPriceA.Text = getPrice(Size, Thin, CheckBoxs).ToString();
        }

        private void rbMeduim_CheckedChanged(object sender, EventArgs e)
        {
            Size = 20;
            lSizeA.Text = "Meduim";
            lPriceA.Text = getPrice(Size, Thin, CheckBoxs).ToString();
        }

        private void rbLarg_CheckedChanged(object sender, EventArgs e)
        {
            Size = 30;
            lSizeA.Text = "Larg";
            lPriceA.Text = getPrice(Size, Thin, CheckBoxs).ToString();
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            lEatingPlaceA.Text = "Eating InSide";
            lPriceA.Text = getPrice(Size, Thin, CheckBoxs).ToString();
        }

        private void rbEatOut_CheckedChanged(object sender, EventArgs e)
        {
            lEatingPlaceA.Text = "Eating OutSide";
            lPriceA.Text = getPrice(Size, Thin, CheckBoxs).ToString();
        }

        private void chkExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExtraChees.Checked)
            {
                lExtraChees.Text = "Extra Chees";
                CheckBoxs += 5;
            }
            else
            {
                lExtraChees.Text = "";
                CheckBoxs -= 5;
            }
            lPriceA.Text = getPrice(Size, Thin, CheckBoxs).ToString();
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMushrooms.Checked)
            {
                lMushrooms.Text = "Mushrooms";
                CheckBoxs += 5;
            }
            else
            {
                lMushrooms.Text = "";
                CheckBoxs -= 5;
            }
            lPriceA.Text = getPrice(Size, Thin, CheckBoxs).ToString();
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTomatoes.Checked)
            {
                lTomatoes.Text = "Tomatoes";
                CheckBoxs += 5;
            }
            else
            {
                lTomatoes.Text = "";
                CheckBoxs -= 5;
            }
            lPriceA.Text = getPrice(Size, Thin, CheckBoxs).ToString();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {

            if (chkOnion.Checked)
            {
                lOnion.Text = "Onion";
                CheckBoxs += 5;
            }
            else
            {
                lOnion.Text = "";
                CheckBoxs -= 5;
            }
            lPriceA.Text = getPrice(Size, Thin, CheckBoxs).ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Are You sure ? ", "Comferm ", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2) == DialogResult.OK))
            {
                this.Close();
            }
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Are You sure ? ", "Comferm ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK))
            {
                MessageBox.Show("It Reset Sucssesfully :-)");
                this.Hide();
                Form2 form2 = new Form2(_ID);
                form2.ShowDialog();
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (Stutes == 0)
            {
                if ((MessageBox.Show("Are You sure ? ", "Comferm ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK))
                {
                    MessageBox.Show("It Ordered Sucssesfully :-)");
                    gbCrust.Enabled = false;
                    gbEat.Enabled = false;
                    gbT1.Enabled = false;
                    gbT2.Enabled = false;
                    groupBox1.Enabled = false;
                    numericUpDown1.Enabled = false;
                    string Ex = lExtraChees.Text +"/"+ lGreenPeppers.Text + "/" + lMushrooms.Text +"/"+ lOlives.Text +"/"+ lOnion.Text + "/" + lTomatoes.Text;
                    clsBussness.AddOrder(_ID, lSizeA.Text, lCrustA.Text, lEatingPlaceA.Text, Ex, Convert.ToInt32(numericUpDown1.Value), DateTime.Now);
                    this.Hide();
                    Form3 form3 = new Form3(_ID);
                    form3.ShowDialog();
                }
            }
            else
            {
                if ((MessageBox.Show("Are You sure ? ", "Comferm ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK))
                {
                    MessageBox.Show("It UpDated Sucssesfully :-)");
                    gbCrust.Enabled = false;
                    gbEat.Enabled = false;
                    gbT1.Enabled = false;
                    gbT2.Enabled = false;
                    groupBox1.Enabled = false;
                    numericUpDown1.Enabled = false;
                    string Ex = lExtraChees.Text +"/"+ lGreenPeppers.Text +"/"+ lMushrooms.Text +"/"+ lOlives.Text +"/"+ lOnion.Text + "/" + lTomatoes.Text;
                    clsBussness.UpDateOrder(_ID, lSizeA.Text, lCrustA.Text, lEatingPlaceA.Text, Ex, Convert.ToInt32(numericUpDown1.Value), DateTime.Now);
                    this.Hide();                  
                }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            lPriceA.Text = getPrice(Size, Thin, CheckBoxs);
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOlives.Checked)
            {
                lOlives.Text = "Olives";
                CheckBoxs += 5;
            }
            else
            {
                lOlives.Text = "";
                CheckBoxs -= 5;
            }
            lPriceA.Text = getPrice(Size, Thin, CheckBoxs).ToString();
        }

        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGreenPeppers.Checked)
            {
                lGreenPeppers.Text = "GreenPeppers";
                CheckBoxs += 5;
            }
            else
            {
                lGreenPeppers.Text = "";
                CheckBoxs -= 5;
            }
            lPriceA.Text = getPrice(Size, Thin, CheckBoxs).ToString();
        }
    }
}
