using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABSTRACT_CLASS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        abstract class vehicule
        {
            public abstract double getFieulAmount();
        }

        class Bus: vehicule
        {
            public override double getFieulAmount()
            {
                return 240;
            }
        }

        class Track: vehicule
        {
            public override double getFieulAmount()
            {
                return 1400;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Text = "";
            vehicule vc;
            Bus bus = new Bus();
            Track track = new Track();
            Text += "Abstract Calss Bus : "+  bus.getFieulAmount() + Environment.NewLine;
            Text += "Abstract Class Track: "+ track.getFieulAmount() + Environment.NewLine;

            textBox1.Text = Text;

        }
    }
}
