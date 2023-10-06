using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projLeds
{
    public partial class Form1 : Form
    {

        private Leds l;
        public Form1()
        {
            InitializeComponent();
            l = new Leds();
            label1.Text = l.getEstado().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            l.acender(1);
            label1.Text = l.getEstado().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            l.acender(8);
            label1.Text = l.getEstado().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            l.acender(2);
            label1.Text = l.getEstado().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            l.acender(3);
            label1.Text = l.getEstado().ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            l.acender(4);
            label1.Text = l.getEstado().ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            l.acender(5);
            label1.Text = l.getEstado().ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            l.acender(6);
            label1.Text = l.getEstado().ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            l.acender(7);
            label1.Text = l.getEstado().ToString();
        }
    }
}
