using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace SimpleMetronome
{
    public partial class Form1 : Form
    {
        //The sound for metronome tick
        SoundPlayer tickPlay = new SoundPlayer(SimpleMetronome.Properties.Resources.tick);

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tickPlay.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        /*This two methods below get how many beats per minute from numericupdown value
         * change it on milliseconds and the result set the timer interval */
        private void upBpm(object sender, MouseEventArgs e)
        {
            int bpm = (int) (60 / numericUpDown1.Value * 1000);
            timer1.Interval = bpm;
        }

        private void upBpm(object sender, EventArgs e)
        {
            int bpm = (int)(60 / numericUpDown1.Value * 1000);
            timer1.Interval = bpm;
        }
    }
}
