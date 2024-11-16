using Chess.Properties;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Chess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void _Swap(ref Button b1, ref Button b2)
        {
            char[] Name = (b1.Tag).ToString().ToCharArray();
            char[] NewName = (b2.Tag).ToString().ToCharArray();
            b1.Tag = "G" + b1.Tag.ToString()[2];
            b1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            b1.BackColor = System.Drawing.Color.Transparent;
            b1.BackgroundImage = null;
            if (NewName.Length == 2)
                Name[2] = NewName[1];
            else
                Name[2] = NewName[2];
            String txt = "";
            for (int i = 0; i < 3; i++)
            {
                txt += Name[i];
            }
            b2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            b2.BackgroundImage = System.Drawing.Image.FromFile(@"C:\\Users\\JAILM\\Pictures\\Screenshots\\" + txt + ".png");
            b2.Tag = txt.ToString();

        }

        private int[] SerchIndex(Button btn)
        {
            int[] Ans = new int[2];
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (btn.Name.ToString() == Arr[i, j].Name.ToString())
                    {
                        Ans[0] = i;
                        Ans[1] = j;
                        return Ans;
                    }
                }
            }
            return Ans;
        }

        private Button But(int[] Indexs)
        {
            return Arr[Indexs[0], Indexs[1]];
        }

        int Coun = 0;

        private void ConvertArmyToExtra(Button btn)
        {
            int[] Pos = SerchIndex(btn);
            if (btn.Tag.ToString()[1] == 'A' && (Pos[0] == 7 || Pos[0] == 0))
            {
                btn.Tag = btn.Tag.ToString()[0] + "E" + btn.Tag.ToString()[2];
                btn.BackgroundImage = System.Drawing.Image.FromFile(@"C:\\Users\\JAILM\\Pictures\\Screenshots\\" + btn.Tag.ToString() + ".png");
            }

        }

        private Button[,] _Arm(Button btn)
        {
            int[] Pos = SerchIndex(btn);
            Button[,] MovingArr = new Button[1, 3];
            if (CheckTurn(btn))
            {
                if (Col == 'B')
                {
                    if (Pos[0] != 7 && (Arr[Pos[0] + 1, Pos[1]].Tag.ToString()[0] == 'G' || Arr[Pos[0] + 1, Pos[1]].Tag.ToString()[0] != 'W'))
                    {
                        MovingArr[0, 0] = Arr[Pos[0] + 1, Pos[1]];

                    }
                    if (Pos[1] != 7 && (Arr[Pos[0] + 1, Pos[1] + 1].Tag.ToString()[0] != 'G' || Arr[Pos[0] + 1, Pos[1] + 1].Tag.ToString()[0] == 'W'))
                        MovingArr[0, 1] = Arr[Pos[0] + 1, Pos[1] + 1];
                    else
                        MovingArr[0, 1] = null;
                    if (Pos[1] != 0 && (Arr[Pos[0] + 1, Pos[1] - 1].Tag.ToString()[0] != 'G' || Arr[Pos[0] + 1, Pos[1] - 1].Tag.ToString()[0] == 'W'))
                        MovingArr[0, 2] = Arr[Pos[0] + 1, Pos[1] - 1];
                    else
                        MovingArr[0, 2] = null;
                }
                else
                {
                    if (Pos[0] != 0 && (Arr[Pos[0] - 1, Pos[1]].Tag.ToString()[0] == 'G' || Arr[Pos[0] - 1, Pos[1]].Tag.ToString()[0] != 'B'))
                        MovingArr[0, 0] = Arr[Pos[0] - 1, Pos[1]];
                    if (Pos[1] != 0 && (Arr[Pos[0] - 1, Pos[1] - 1].Tag.ToString()[0] != 'G' || Arr[Pos[0] - 1, Pos[1] - 1].Tag.ToString()[0] == 'B'))
                        MovingArr[0, 1] = Arr[Pos[0] - 1, Pos[1] - 1];
                    else
                        MovingArr[0, 1] = null;
                    if (Pos[1] != 7 && (Arr[Pos[0] - 1, Pos[1] + 1].Tag.ToString()[0] != 'G' || Arr[Pos[0] - 1, Pos[1] + 1].Tag.ToString()[0] == 'B'))
                        MovingArr[0, 2] = Arr[Pos[0] - 1, Pos[1] + 1];
                    else
                        MovingArr[0, 2] = null;
                }

             
                Coun = 1;
            }
            return MovingArr;
        }

        private Button[,] _King(Button btn)
        {
            int[] Pos = SerchIndex(btn);
            Button[,] MovingArr = new Button[8, 8];
            int i = Pos[0], j = Pos[1];
            if (CheckTurn(btn))
            {
                if (i - 1 >= 0 && (Arr[i - 1, j].Tag.ToString()[0] == 'G' || Arr[i - 1, j].Tag.ToString()[0] != Col))
                {
                    MovingArr[0, 0] = Arr[i - 1, j];
                }
                if (i + 1 <= 7 && (Arr[i + 1, j].Tag.ToString()[0] == 'G' || Arr[i + 1, j].Tag.ToString()[0] != Col))
                {
                    MovingArr[1, 0] = Arr[i + 1, j];
                }
                if (j - 1 >= 0 && (Arr[i, j - 1].Tag.ToString()[0] == 'G' || Arr[i, j - 1].Tag.ToString()[0] != Col))
                {
                    MovingArr[2, 0] = Arr[i, j - 1];
                }
                if (j + 1 <= 7 && (Arr[i, j + 1].Tag.ToString()[0] == 'G' || Arr[i, j + 1].Tag.ToString()[0] != Col))
                {
                    MovingArr[3, 0] = Arr[i, j + 1];
                }
                if (i - 1 >= 0 && j - 1 >= 0 && (Arr[i - 1, j - 1].Tag.ToString()[0] == 'G' || Arr[i - 1, j - 1].Tag.ToString()[0] != Col))
                {
                    MovingArr[4, 0] = Arr[i - 1, j - 1];
                }
                if (i - 1 >= 0 && j + 1 <= 7 && (Arr[i - 1, j + 1].Tag.ToString()[0] == 'G' || Arr[i - 1, j + 1].Tag.ToString()[0] != Col))
                {
                    MovingArr[5, 0] = Arr[i - 1, j + 1];
                }
                if (i + 1 <= 7 && j + 1 <= 7 && (Arr[i + 1, j + 1].Tag.ToString()[0] == 'G' || Arr[i + 1, j + 1].Tag.ToString()[0] != Col))
                {
                    MovingArr[6, 0] = Arr[i + 1, j + 1];
                }
                if (i + 1 <= 7 && j - 1 >= 0 && (Arr[i + 1, j - 1].Tag.ToString()[0] == 'G' || Arr[i + 1, j - 1].Tag.ToString()[0] != Col))
                {
                    MovingArr[7, 0] = Arr[i + 1, j - 1];
                }

                Coun = 1;
            }
            return MovingArr;
        }

        private Button[,] _Base(Button btn)
        {
            int[] Pos = SerchIndex(btn);
            Button[,] MovingArr = new Button[8, 8];
            int i1 = Pos[0], i2 = Pos[0], i3 = Pos[0], j1 = Pos[1], j2 = Pos[1];
            int Coul = 0, Rows = 0;
            if (CheckTurn(btn))
            {
                while (i1 != 0 && (Arr[i1 - 1, j1].Tag.ToString()[0] != 'G' || Arr[i1 - 1, j1].Tag.ToString()[0] != Col))
                {
                    i1--;
                    MovingArr[i1, j1] = Arr[i1, j1];
                    Rows++;
                }
                while (i2 != 7 && (Arr[i2 + 1, j1].Tag.ToString()[0] != 'G' || Arr[i2 + 1, j1].Tag.ToString()[0] != Col))
                {
                    i2++;
                    MovingArr[i2, j1] = Arr[i2, j1];
                    Rows++;
                }
                while (j1 != 0 && (Arr[i3, j1 - 1].Tag.ToString()[0] != 'G' || Arr[i3, j1 - 1].Tag.ToString()[0] != Col))
                {
                    j1--;
                    MovingArr[i3, j1] = Arr[i3, j1];
                    Coul++;
                }
                while (j2 != 7 && (Arr[i3, j2 + 1].Tag.ToString()[0] != 'G' || Arr[i3, j2 + 1].Tag.ToString()[0] != Col))
                {
                    j2++;
                    MovingArr[i3, j2] = Arr[i3, j2];
                    Coul++;
                }

                Coun = 1;
            }
            return MovingArr;
        }

        private Button[,] _Elevent(Button btn)
        {
            int[] Pos = SerchIndex(btn);
            Button[,] MovingArr = new Button[8, 8];
            int i1 = Pos[0], i2 = Pos[0], i3 = Pos[0], i4 = Pos[0], j1 = Pos[1], j2 = Pos[1], j3 = Pos[1], j4 = Pos[1];
            if (CheckTurn(btn))
            {
                while (i1 != 0 && j1 != 0 && (Arr[i1 - 1, j1 - 1].Tag.ToString()[0] == 'G' || Arr[i1 - 1, j1 - 1].Tag.ToString()[0] != Col))
                {
                    i1--;
                    j1--;
                    MovingArr[i1, j1] = Arr[i1, j1];
                }
                while (i2 != 0 && j2 != 7 && (Arr[i2 - 1, j2 + 1].Tag.ToString()[0] == 'G' || Arr[i2 - 1, j2 + 1].Tag.ToString()[0] != Col))
                {
                    i2--;
                    j2++;
                    MovingArr[i2, j2] = Arr[i2, j2];
                }
                while (i3 != 7 && j3 != 0 && (Arr[i3 + 1, j3 - 1].Tag.ToString()[0] == 'G' || Arr[i3 + 1, j3 - 1].Tag.ToString()[0] != Col))
                {
                    i3++;
                    j3--;
                    MovingArr[i3, j3] = Arr[i3, j3];
                }
                while (i4 != 7 && j4 != 7 && (Arr[i4 + 1, j4 + 1].Tag.ToString()[0] == 'G' || Arr[i4 + 1, j4 + 1].Tag.ToString()[0] != Col))
                {
                    j4++;
                    i4++;
                    MovingArr[i4, j4] = Arr[i4, j4];
                }

                Coun = 1;
            }
            return MovingArr;
        }
        private Button[,] _Hors(Button btn)
        {
            int[] Pos = SerchIndex(btn);
            Button[,] MovingArr = new Button[8, 8];
            int i = Pos[0], j = Pos[1];
            if (CheckTurn(btn))
            {
                if (i - 2 >= 0 && j - 1 >= 0 && (Arr[i - 2, j - 1].Tag.ToString()[0] == 'G' || Arr[i - 2, j - 1].Tag.ToString()[0] != Col))
                    MovingArr[i - 2, j - 1] = Arr[i - 2, j - 1];
                if (i - 2 >= 0 && j + 1 <= 7 && (Arr[i - 2, j + 1].Tag.ToString()[0] == 'G' || Arr[i - 2, j + 1].Tag.ToString()[0] != Col))
                    MovingArr[i - 2, j + 1] = Arr[i - 2, j + 1];
                if (i + 2 <= 7 && j - 1 >= 0 && (Arr[i + 2, j - 1].Tag.ToString()[0] == 'G' || Arr[i + 2, j - 1].Tag.ToString()[0] != Col))
                    MovingArr[i + 2, j - 1] = Arr[i + 2, j - 1];
                if (i + 2 <= 7 && j + 1 <= 7 && (Arr[i + 2, j + 1].Tag.ToString()[0] == 'G' || Arr[i + 2, j + 1].Tag.ToString()[0] != Col))
                    MovingArr[i + 2, j + 1] = Arr[i + 2, j + 1];
                if (i - 1 >= 0 && j - 2 >= 0 && (Arr[i - 1, j - 2].Tag.ToString()[0] == 'G' || Arr[i - 1, j - 2].Tag.ToString()[0] != Col))
                    MovingArr[i - 1, j - 2] = Arr[i - 1, j - 2];
                if (i + 1 <= 7 && j - 2 >= 0 && (Arr[i + 1, j - 2].Tag.ToString()[0] == 'G' || Arr[i + 1, j - 2].Tag.ToString()[0] != Col))
                    MovingArr[i + 1, j - 2] = Arr[i + 1, j - 2];
                if (i - 1 >= 0 && j + 2 <= 7 && (Arr[i - 1, j + 2].Tag.ToString()[0] == 'G' || Arr[i - 1, j + 2].Tag.ToString()[0] != Col))
                    MovingArr[i - 1, j + 2] = Arr[i - 1, j + 2];
                if (i + 1 <= 7 && j + 2 <= 7 && (Arr[i + 1, j + 2].Tag.ToString()[0] == 'G' || Arr[i + 1, j + 2].Tag.ToString()[0] != Col))
                    MovingArr[i + 1, j + 2] = Arr[i + 1, j + 2];
                Coun = 1;




            }
            return MovingArr;
        }
        private bool _TwoArrayCheck(Button[,] Arr1, int[] Arr2)
        {
            Button b = But(Arr2);
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    try
                    {
                        if (Arr1[i, j] != null)
                        {
                            if (Arr1[i, j].Name.ToString() == b.Name.ToString())
                            {
                                _Swap(ref p, ref b);
                                return true;
                            }
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
            return false;
        }

        private void BlackAllBtn()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Arr[i, j].Enabled = false;

                }
            }

        }

        private void CheckWinner()
        {
            bool WitheKing = false, BlackKing = false;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (Arr[i, j].Tag.ToString() == "WK1" || Arr[i, j].Tag.ToString() == "WK2")
                    {
                        WitheKing = true;
                    }
                    if (Arr[i, j].Tag.ToString() == "BK1" || Arr[i, j].Tag.ToString() == "BK2")
                    {
                        BlackKing = true;
                    }
                }
            }
            if (WitheKing == false)
            {
                lWinner.Text = "Black";
                BlackAllBtn();
            }
            if (BlackKing == false)
            {
                lWinner.Text = "Withe";
                BlackAllBtn();
            }
        }


        bool flag = false;
        private Button[,] _Elete(Button btn)
        {
            flag = true;
            Button[,] MovingArr = new Button[8, 8], Elevent = _Elevent(btn), Base = _Base(btn);

            if (CheckTurn(btn))
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (Elevent[i, j] != null)
                        {
                            MovingArr[i, j] = Elevent[i, j];
                        }
                        else if (Base[i, j] != null)
                        {
                            MovingArr[i, j] = Base[i, j];
                        }
                    }
                }

            }
            return MovingArr;

        }

        private bool CheckTurn(Button btn)
        {
            if (btn.Tag.ToString()[0] != Col)
            {
                MessageBox.Show("It Isn't Your Turn");
                return false;
            }
            return true;
        }

        Button[,] M = new Button[8, 8];
        Button p = new Button();
        char Col = 'W';
        private void Moving(object sender, EventArgs e)
        {
            char[] T = ((Button)sender).Tag.ToString().ToCharArray();
            if (T[0] != '0' && (Coun == 0 || ((Button)sender).Tag.ToString()[0] == Col))
            {
              
                if (T[1] == 'B')
                {
                    M = _Base((Button)sender);
                }
                else if (T[1] == 'A')
                {
                    M = _Arm((Button)sender);
                }
                else if (T[1] == 'X')
                {
                    M = _Elevent((Button)sender);
                }
                else if (T[1] == 'H')
                {
                    M = _Hors((Button)sender);
                }
                else if (T[1] == 'K')
                {
                    M = _King((Button)sender);
                }
                else
                {
                    M = _Elete((Button)sender);
                }
                p = (Button)sender;




            }
            else
            {

                int[] c = SerchIndex((Button)sender);
                if (_TwoArrayCheck(M, c))
                {
                    ConvertArmyToExtra((Button)sender);
                    Coun = 0;
                    if (Col == 'W')
                    {
                        Col = 'B';
                        lTurn.Text = "Black";
                    }
                    else
                    {
                        Col = 'W';
                        lTurn.Text = "White";
                    }
                    CheckWinner();
                }
                else
                {
                    MessageBox.Show("In Legail Move");
                }
            }
        }

        Button[,] Arr = new Button[8, 8];
        private void Form1_Load(object sender, EventArgs e)
        {
            Arr[0, 0] = btn11;
            Arr[0, 1] = btn12;
            Arr[0, 2] = btn13;
            Arr[0, 3] = btn14;
            Arr[0, 4] = btn15;
            Arr[0, 5] = btn16;
            Arr[0, 6] = btn17;
            Arr[0, 7] = btn18;
            Arr[1, 0] = btn21;
            Arr[1, 1] = btn22;
            Arr[1, 2] = btn23;
            Arr[1, 3] = btn24;
            Arr[1, 4] = btn25;
            Arr[1, 5] = btn26;
            Arr[1, 6] = btn27;
            Arr[1, 7] = btn28;
            Arr[2, 0] = btn31;
            Arr[2, 1] = btn32;
            Arr[2, 2] = btn33;
            Arr[2, 3] = btn34;
            Arr[2, 4] = btn35;
            Arr[2, 5] = btn36;
            Arr[2, 6] = btn37;
            Arr[2, 7] = btn38;
            Arr[3, 0] = btn41;
            Arr[3, 1] = btn42;
            Arr[3, 2] = btn43;
            Arr[3, 3] = btn44;
            Arr[3, 4] = btn45;
            Arr[3, 5] = btn46;
            Arr[3, 6] = btn47;
            Arr[3, 7] = btn48;
            Arr[4, 0] = btn51;
            Arr[4, 1] = btn52;
            Arr[4, 2] = btn53;
            Arr[4, 3] = btn54;
            Arr[4, 4] = btn55;
            Arr[4, 5] = btn56;
            Arr[4, 6] = btn57;
            Arr[4, 7] = btn58;
            Arr[5, 0] = btn61;
            Arr[5, 1] = btn62;
            Arr[5, 2] = btn63;
            Arr[5, 3] = btn64;
            Arr[5, 4] = btn65;
            Arr[5, 5] = btn66;
            Arr[5, 6] = btn67;
            Arr[5, 7] = btn68;
            Arr[6, 0] = btn71;
            Arr[6, 1] = btn72;
            Arr[6, 2] = btn73;
            Arr[6, 3] = btn74;
            Arr[6, 4] = btn75;
            Arr[6, 5] = btn76;
            Arr[6, 6] = btn77;
            Arr[6, 7] = btn78;
            Arr[7, 0] = btn81;
            Arr[7, 1] = btn82;
            Arr[7, 2] = btn83;
            Arr[7, 3] = btn84;
            Arr[7, 4] = btn85;
            Arr[7, 5] = btn86;
            Arr[7, 6] = btn87;
            Arr[7, 7] = btn88;

        }
    }
}
