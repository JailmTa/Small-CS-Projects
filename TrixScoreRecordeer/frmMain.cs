using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrixScoreRecordeer.Properties;

namespace TrixScoreRecordeer
{
    public partial class frmMain : Form
    {
        clsGameRecorder rec = new clsGameRecorder();
        int N = 0;
        string Team1 = "", Team2 = "";
        DataTable[] dt=new DataTable[4];
        public frmMain(string t1,string t2)
        {
            InitializeComponent();
            Team1 = t1;
            Team2 = t2;
        }
        ctrlTabController[] Tabs = new ctrlTabController[4];
        private void Form1_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.Rows.Clear();
            ctrlTabController2.Visible = false;
            ctrlTabController3.Visible = false;
            ctrlTabController4.Visible = false;
            Tabs[0] = ctrlTabController1;
            Tabs[1] = ctrlTabController2;
            Tabs[2] = ctrlTabController3;
            Tabs[3] = ctrlTabController4;
            dt[0]=new DataTable();
            dt[1]=new DataTable();
            dt[2]=new DataTable();
            dt[3]=new DataTable();
            rec.GamePaleyed[0] = clsGameRecorder.enGamesPlayed.Collactions;

        }




        private void button1_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show();
        }

        private void ctrlTabController1_Load(object sender, EventArgs e)
        {

        }

        private bool CheckToAddNew(ContextMenuStrip contextMenuStrip)
        {
            if (guna2DataGridView1.Rows.Count == 5)
            {
                kingOfHartToolStripMenuItem.Visible = true;
                trixToolStripMenuItem.Visible = true;
                dimondeToolStripMenuItem.Visible = true;
                collactionToolStripMenuItem.Visible = true;
                qeuensToolStripMenuItem.Visible = true;
                return true;
            }
            else
            {
                return false;
            }
        }

        private void kingOfHartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKingOfHart f = new frmKingOfHart(rec,Team1,Team2);
            f.ShowDialog();
            if (rec.GamePaleyed[2] == clsGameRecorder.enGamesPlayed.KingOfHarts)
            {
                if (dt[N].Columns.Count < 3)
                {
                    dt[N].Columns.Add(Team1, typeof(int));
                    dt[N].Columns.Add(Team2, typeof(int));
                    dt[N].Columns.Add("Description", typeof(string));
                }
                dt[N].Rows.Add(rec.FirstTeamScore, rec.SecondTeamScore, "KingOfHarts");
                guna2DataGridView1.DataSource = dt[N];
                kingOfHartToolStripMenuItem.Visible = false;
                if (CheckToAddNew(contextMenuStrip1))
                {

                    N++;
                    int Num = N;
                    Tabs[Num].Visible = true;

                }
            }
            else
            {

            }
        }

        private void trixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTrix tr = new frmTrix(rec, Team1, Team2);
            tr.ShowDialog();
            if (rec.GamePaleyed[0] == clsGameRecorder.enGamesPlayed.Trix)
            {
                if (dt[N].Columns.Count < 3)
                {
                    dt[N].Columns.Add(Team1, typeof(int));
                    dt[N].Columns.Add(Team2, typeof(int));
                    dt[N].Columns.Add("Description", typeof(string));
                }
                dt[N].Rows.Add(rec.FirstTeamScore, rec.SecondTeamScore, "Trix");
                guna2DataGridView1.DataSource = dt[N];
                trixToolStripMenuItem.Visible = false;
                if (CheckToAddNew(contextMenuStrip1))
                {

                    N++;
                    int Num = N;
                    Tabs[Num].Visible = true;

                }
            }
            else
            {

            }
        }
        

        private void collactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
                frmCollaction t = new frmCollaction(rec, Team1, Team2);
                t.ShowDialog();
            if (rec.GamePaleyed[1] == clsGameRecorder.enGamesPlayed.Collactions)
            {
                if (dt[N].Columns.Count < 3)
                {
                    dt[N].Columns.Add(Team1, typeof(int));
                    dt[N].Columns.Add(Team2, typeof(int));
                    dt[N].Columns.Add("Description", typeof(string));
                }
                dt[N].Rows.Add(rec.FirstTeamScore, rec.SecondTeamScore, "Collactions");
                guna2DataGridView1.DataSource = dt[N];
                collactionToolStripMenuItem.Visible = false;
                if (CheckToAddNew(contextMenuStrip1))
                {
                    N++;
                    int Num = N;
                    Tabs[Num].Visible = true;

                }
            }
            else
            {

            }
        }

        private void dimondeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDimoned d = new frmDimoned(rec, Team1, Team2);
            d.ShowDialog();
            if (rec.GamePaleyed[3] == clsGameRecorder.enGamesPlayed.Dimoned)
            {
                if (dt[N].Columns.Count < 3)
                {
                    dt[N].Columns.Add(Team1, typeof(int));
                    dt[N].Columns.Add(Team2, typeof(int));
                    dt[N].Columns.Add("Description", typeof(string));
                }
                dt[N].Rows.Add(rec.FirstTeamScore, rec.SecondTeamScore, "Dimoned");
                guna2DataGridView1.DataSource = dt[N];
                dimondeToolStripMenuItem.Visible = false;
                if (CheckToAddNew(contextMenuStrip1))
                {

                    N++;
                    int Num = N;
                    Tabs[Num].Visible = true;

                }
            }
            else
            {

            }
        }

        private void qeuensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQueen q = new frmQueen(rec, Team1, Team2);
            q.ShowDialog();
            if (rec.GamePaleyed[4] == clsGameRecorder.enGamesPlayed.Queen)
            {
                if (dt[N].Columns.Count < 3)
                {
                    dt[N].Columns.Add(Team1, typeof(int));
                    dt[N].Columns.Add(Team2, typeof(int));
                    dt[N].Columns.Add("Description", typeof(string));
                }
                dt[N].Rows.Add(rec.FirstTeamScore, rec.SecondTeamScore, "Queen");
                guna2DataGridView1.DataSource = dt[N];
                qeuensToolStripMenuItem.Visible = false;
                if (CheckToAddNew(contextMenuStrip1))
                {

                    N++;
                    int Num = N;
                    Tabs[Num].Visible = true;

                }
            }
            else
            {

            }
        }

        private void ctrlTabController1_Load_1(object sender, EventArgs e)
        {
           
        }

        private void ctrlTabController2_Load(object sender, EventArgs e)
        {
          
        }

        private void ctrlTabController3_Load(object sender, EventArgs e)
        {
            
        }

        private void ctrlTabController4_Load(object sender, EventArgs e)
        {
           
        }

        private void ctrlTabController1_Click(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource = dt[0];
        }

        private void ctrlTabController2_Click(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource = dt[1];
        }

        private void ctrlTabController3_Click(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource = dt[2];
        }

        private void ctrlTabController4_Click(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource = dt[3];
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void editToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string s = guna2DataGridView1.CurrentRow.Cells[2].Value.ToString();
            switch (s)
            {
                case "Queen":
                    frmQueen q = new frmQueen(rec, guna2DataGridView1.CurrentRow.Cells[0].Value.ToString(), guna2DataGridView1.CurrentRow.Cells[1].Value.ToString(),frmQueen.enMode.Edit);
                    q.ShowDialog();
                    break;
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
