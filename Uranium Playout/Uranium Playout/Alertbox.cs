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
    public partial class Alertbox : Form
    {
        public string txt;
        public Alertbox()
        {
            InitializeComponent();
        }

        private void Alertbox_Load(object sender, EventArgs e)
        {
            label1.Text = txt;
        }
    }
}
