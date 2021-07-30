using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Uranium_Playout
{
    public partial class StudioF : Form
    {
        Uraniumvideo uraniumvideo = new Uraniumvideo();
        
        double timee = 0;
        string[] flloc = { };
        int slec;
        int aftslec;
        string slectt;
        double leng;
        Boolean live;
        char ch;
        int currenttps = 2;
        int currentinterval = 500;
        int ctime = 0;
        

        public StudioF()
        {
            InitializeComponent();
        }

        private void StudioF_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void StudioF_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void StudioF_Load(object sender, EventArgs e)
        {
            uraniumvideo.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (uraniumvideo.readyy)
            {
                if (listBox1.Items.Count > 0)
                {
                    live = true;
                    timer1.Enabled = true;
                    label7.Visible = true;
                    
                    if (listBox1.Items.Count == 1)
                    {
                        listBox6.Items.Add("Play(count=1,start)");
                        uraniumvideo.play(listBox3.Items[listBox2.Items.IndexOf(listBox1.Items[0])].ToString());
                    }
                    else
                    {
                        listBox6.Items.Add("Play(start)");
                        uraniumvideo.play(listBox3.Items[listBox2.Items.IndexOf(listBox1.Items[0])].ToString());
                    }
                }
                else
                {
                    alertt alett = new alertt("Empty queue.", true);
                    alett.Show();
                }
            }
            else
            {
                alertt alett = new alertt("Please dock the render screen.",false);
                alett.Show();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView2_SizeChanged(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            listBox6.Items.Add("Timer tick " + timee * 2);
            timee = timee + 0.5;
            label6.Text = Convert.ToString(Math.Floor(timee / 3600)) + " : " + Convert.ToString(Math.Floor(timee / 60) % 60) + " : " + Convert.ToString(Math.Floor(timee) % 60);
            ctime = ctime + 1;
            if (ctime > Convert.ToInt32(listBox5.Items[listBox2.Items.IndexOf(listBox1.Items[0])]) * 2) {
                listBox1.Items.RemoveAt(0);
                ctime = 0;
                if (listBox1.Items.Count == 0)
                {
                    live = false;
                    timer1.Enabled = false;
                    timee = 0;
                    label6.Text = "0 : 0 : 0";
                    label7.Visible = false;
                    uraniumvideo.end();
                    listBox6.Items.Add("Stop");
                }
                else
                {
                    uraniumvideo.play(listBox3.Items[listBox2.Items.IndexOf(listBox1.Items[0])].ToString());
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            live = false;
            timer1.Enabled = false;
            timee = 0;
            label6.Text = "0 : 0 : 0";
            label7.Visible = false;
            uraniumvideo.end();
            listBox6.Items.Add("Stop");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label7_MouseEnter(object sender, EventArgs e)
        {
            
            
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            listBox2.Items.Add(openFileDialog1.SafeFileName);
            pictureBox2.Visible = false;
            listBox3.Items.Add(openFileDialog1.FileName);
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button8.Enabled = false;
            button7.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            drtpanel.Visible = true;
            label9.Text = "Set duration(second) for " + openFileDialog1.SafeFileName + " (If the set duration is longer than the actual duration of the media, there will be black cutouts in the broadcast)";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                listBox1.Items.Add(listBox2.SelectedItem);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != 0)
            {
                slec = listBox1.SelectedIndex;
                slectt = listBox1.SelectedItem.ToString();
                aftslec = listBox1.SelectedIndex - 1;
                listBox1.Items[slec] = listBox1.Items[aftslec];
                listBox1.Items[aftslec] = slectt;
                listBox1.SetSelected(aftslec,true);
                
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex + 1 != listBox1.Items.Count)
            {
                slec = listBox1.SelectedIndex;
                slectt = listBox1.SelectedItem.ToString();
                aftslec = listBox1.SelectedIndex + 1;
                listBox1.Items[slec] = listBox1.Items[aftslec];
                listBox1.Items[aftslec] = slectt;
                listBox1.SetSelected(aftslec, true);

            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            drtpanel.Visible = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button8.Enabled = true;
            button7.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            listBox5.Items.Add(numericUpDown1.Value);
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
           
        }

        private void StudioF_MouseClick(object sender, MouseEventArgs e)
        {
           
        }
        
    }
}
