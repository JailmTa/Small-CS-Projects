using Pool_Project.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pool_Project
{
    public partial class PoolTable : UserControl
    {
        public PoolTable()
        {
            InitializeComponent();
        }

        private static int PoolTableCounter = 0;

        private static int PlayStationCounter = 0;

        public event Action<TimeSpan, float> OnEndTimer;
        public virtual void EndTimer(TimeSpan timer, float cost)
        {
            Action<TimeSpan, float> action = OnEndTimer;
            if (action != null)
            {
                action(timer, cost);
            }
        }

        private class clsGameInfo
        {
            public enPlayType GameMode { get; set; }
            public TimeSpan PlayingTime { get; set; }

            public float CostForHour { get; set; }
        }
        static float CPS = 100, CPB = 100;
        [Category("Game Settings")]
        public float CostForOneHourOfPlayingPS
        {
            get
            {
                return CPS;
            }
            set
            {
                CPS = value;
            }

        }
        [Category("Game Settings")]
        public float CostForOneHourOfPlayingPB
        {
            get
            {
                return CPB;
            }
            set
            {
                CPB = value;
            }

        }

        public enum enPlayType
        {
            PoolBall = 0,
            PlayStation = 1
        }
        TimeSpan Timer = new TimeSpan();
        private enPlayType _PlayGame;


        [Category("Game Settings")]
        public enPlayType PlayGame
        {
            get
            {
                return _PlayGame;
            }
            set
            {
                _PlayGame = value;
                switch (_PlayGame)
                {
                    case enPlayType.PoolBall:
                        pictureBox1.Image = Resources.icons8_pool_table_96;

                        break;
                    default:
                        pictureBox1.Image = Resources.icons8_ps_controller_96;

                        break;
                }
            }
        }

        private void PoolTable_Load(object sender, EventArgs e)
        {
            if (_PlayGame == enPlayType.PoolBall)
            {
                PoolTableCounter++;
                groupBox1.Text = "Table" + PoolTableCounter.ToString();
                guna2ToggleSwitch1.Checked = false;
            }
            else
            {
                PlayStationCounter++;
                groupBox1.Text = "PlayStation" + PlayStationCounter.ToString();
                guna2ToggleSwitch1.Checked = true;
            }

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (guna2Button1.Tag == "End")
            {
                timer1.Stop();
                clsGameInfo gameInfo = new clsGameInfo();
                gameInfo.GameMode = _PlayGame;
                gameInfo.PlayingTime = Timer;
                guna2Button1.Tag = "Start";
                guna2Button1.Text = "Start";
                switch (_PlayGame)
                {
                    case enPlayType.PoolBall:

                        gameInfo.CostForHour = CostForOneHourOfPlayingPB;
                        break;
                    default:

                        gameInfo.CostForHour = CostForOneHourOfPlayingPS;
                        break;
                }
                if (OnEndTimer != null)
                {
                    float HP = Timer.Hours * gameInfo.CostForHour;
                    float MP = Timer.Minutes * gameInfo.CostForHour / 60;
                    float SP = Timer.Seconds * gameInfo.CostForHour / 3600;
                    EndTimer(Timer, HP + MP + SP);
                }
                label1.Text = "00:00:00";
            }
            else
            {
                Counter = 0;
                label1.Text = "00:00:00";
                timer1.Start();
                guna2Button1.Tag = "End";
                guna2Button1.Text = "End";
            }
        }
        int Counter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Counter++;
            Timer = new TimeSpan(0, 0, Counter);
            label1.Text = Timer.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2ToggleSwitch1.Checked)
                PlayGame = (enPlayType)1;
            else
                PlayGame = (enPlayType)0;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            label1.Text = "00:00:00";
            timer1.Stop();
        }
    }
}
