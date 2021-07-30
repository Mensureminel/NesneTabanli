using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uranium_Playout
{
    public partial class Form1 : Form
    {
        int cntt = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(cntt > 1)
            {
                timer1.Enabled = false;
                this.Hide();
                StudioF studiof = new StudioF();
                studiof.Show();
                
                
            }
            else
            {
                cntt = cntt + 1;
            }
        }
    }
}
