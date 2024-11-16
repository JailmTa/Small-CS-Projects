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
    public partial class ctrlTabController : UserControl
    {
        public ctrlTabController()
        {
            InitializeComponent();
            label1.Text = Text;
        }
        public string TextNumber { 
            get
            { return label1.Text; } 
            set
            { label1.Text = value; }
        }
        private void ctrlTabController_Load(object sender, EventArgs e)
        {

        }
    }
}
