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
    public partial class Form3 : Form
    {
        int _ID = 0;
        public Form3(int ID)
        {
            InitializeComponent();
            _ID = ID;
        }

      

        private void Form3_Load(object sender, EventArgs e)
        {
            dgvAllOrders.DataSource = clsBussness.GetAllOrders(_ID);
        }

        private void upDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(Convert.ToInt32(dgvAllOrders.CurrentRow.Cells[0].Value),
                  (dgvAllOrders.CurrentRow.Cells[2].Value).ToString(), (dgvAllOrders.CurrentRow.Cells[3].Value).ToString(),
                 (dgvAllOrders.CurrentRow.Cells[4].Value).ToString(), (dgvAllOrders.CurrentRow.Cells[5].Value).ToString(),
                 Convert.ToInt32(dgvAllOrders.CurrentRow.Cells[6].Value),
                 Convert.ToDateTime(dgvAllOrders.CurrentRow.Cells[7].Value));
            f.ShowDialog();
            dgvAllOrders.DataSource = clsBussness.GetAllOrders(_ID);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsBussness.DeleteOrder(Convert.ToInt32(dgvAllOrders.CurrentRow.Cells[0].Value));
            dgvAllOrders.DataSource = clsBussness.GetAllOrders(_ID);
        }
    }
}
