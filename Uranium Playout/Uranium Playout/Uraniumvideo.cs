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
    
    public partial class Uraniumvideo : Form
    {
        public Boolean readyy = false;
        Boolean playsec = false;
        public Uraniumvideo()
        {
            InitializeComponent();
            
        }
      
        private void Uraniumvideo_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            button1.Visible = false;
            button1.Enabled = false;
            readyy = true;
            axWindowsMediaPlayer1.Visible = true;
            axWindowsMediaPlayer1.Dock = DockStyle.Fill;
        }

        private void Uraniumvideo_Load(object sender, EventArgs e)
        {

        }

        internal void play(string vidpath) {
            
            axWindowsMediaPlayer1.URL = vidpath;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
        internal void end()
        {

            axWindowsMediaPlayer1.Ctlcontrols.stop();
            

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
    }
}
