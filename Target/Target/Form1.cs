using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Target
{
    public partial class FRMMain : Form
    {
        public FRMMain()
        {
            InitializeComponent();
        }

        private void PCBBall_Click(object sender, EventArgs e)
        {
            LBLStart.Text = "";
            Random r = new Random();
            int p = r.Next(50, 880);
            int q = r.Next(50, 780);
            PCBBall.Location = new Point(p, q);
        }
    }
}
