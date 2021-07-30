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
    public partial class alertt : Form
    {
        string globtx;
        Boolean criticalAlert;
        public alertt(string tttx, Boolean iscritical)
        {
            InitializeComponent();
            globtx = tttx;
            criticalAlert = iscritical;
        }

        private void alertt_Load(object sender, EventArgs e)
        {
            label1.Text = globtx;
            if (criticalAlert)
            {
                
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity = ((1 - this.Opacity) / 10) + this.Opacity;
            if(this.Opacity > 0.9)
            {
                timer1.Enabled = false;
                this.Opacity = 1;
                timer2.Enabled = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            timer3.Enabled = true;
        }

        private void alertt_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            timer1.Enabled = false;
            this.Opacity = 1;
            timer3.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            timer1.Enabled = false;
            this.Opacity = 1;
            timer3.Enabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            timer1.Enabled = false;
            this.Opacity = 1;
            timer3.Enabled = true;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            this.Opacity = ((0 - this.Opacity) / 10) + this.Opacity;
            if (this.Opacity < 0.1)
            {
                timer3.Enabled = false;
                this.Opacity = 0;
                this.Close();
            }
        }
    }
}
