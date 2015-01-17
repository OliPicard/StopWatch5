using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatch5
{
    public partial class Form1 : Form
    {
        TimeSpan StartTime = new TimeSpan(0, 0, 0);
        TimeSpan addTime = new TimeSpan(0, 0, 1);
        int apple;
        int pear;
        int cherry;
        int lp = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            StartTime = StartTime + addTime;
            label1.Text = StartTime.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            StartTime = new TimeSpan(0, 0, 0);
            label1.Text = StartTime.ToString();
            label2.Text = ("Lap 1");
            label3.Text = ("Lap 2");
            label4.Text = ("Lap 3");
            label5.Text = ("");
            lp = 0;
            Lap.Enabled = true;
        }
        public void Lap_Click(object sender, EventArgs e)
        {
            lp++;
            timer1.Enabled = false;
            switch (lp)
            {
                case 1:
                    label2.Text = StartTime.ToString();
                    string what = StartTime.ToString();
                    what = what.Replace(":", "");
                    apple = Convert.ToInt16(what);
                    calcFTOne();
                    StartTime = new TimeSpan(0, 0, 0);
                    label1.Text = StartTime.ToString();
                    timer1.Enabled = true;
                    break;
                case 2:
                    label3.Text = StartTime.ToString();
                    string who = StartTime.ToString();
                    who = who.Replace(":", "");
                    pear = Convert.ToInt16(who);
                    calcFTTwo();
                    StartTime = new TimeSpan(0, 0, 0);
                    label1.Text = StartTime.ToString();
                    timer1.Enabled = true;
                    break;
                case 3:
                    Lap.Enabled = false;
                    label4.Text = StartTime.ToString();
                    string why = StartTime.ToString();
                    why = why.Replace(":", "");
                    cherry = Convert.ToInt16(why);
                    calcFTThree();
                    label1.Text = StartTime.ToString();
                    timer1.Enabled = true;
                    break;
            }

        }
        public void calcFTOne()
        {

            if (apple == apple)
            {
                label5.Text = ("Fastest Lap 1: " + StartTime);
            }
        }
        public void calcFTTwo()
        {
            if (pear < apple)
            {
                label5.Text = ("Fastest Lap 2: " + StartTime);
            }
            if (pear == apple)
            {
                label5.Text = ("Tie between Lap 1 and Lap 2: " + StartTime);
            }
            if (pear == cherry)
            {
                label5.Text = ("Tie between Lap 1 and  Lap 3: " + StartTime);
            }
        }
        public void calcFTThree()
        {
            if (cherry < apple && cherry < pear)
            {
                label5.Text = ("Fastest Lap 3: " + StartTime);
            }
            if (cherry == apple)
            {
                label5.Text = ("Tie between Lap 2 and 3! " + StartTime);
            }
            if (cherry == apple && cherry == pear && cherry == cherry)
            {
                label5.Text = ("Tie between Lap 1, 2 and 3! " + StartTime);
            }
        }

    }
}
