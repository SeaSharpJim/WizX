using System;
using System.Windows.Forms;

namespace Digital_Clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Digital Clock"; //To set the title
            timer1.Start(); //starting the timer
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //to display the time in the label
            label1.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
    }
}