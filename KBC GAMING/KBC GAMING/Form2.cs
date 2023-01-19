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

namespace KBC_GAMING
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int i = 1;
        //int tick = 10;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i <= 10)
            {
                i++;
            }
            else
            {
                timer1.Stop();
                Form1 f1 = new Form1();
                f1.Show();
            }
        }  
       
        private void Form2_Load(object sender, EventArgs e)
        {
            SoundPlayer kbctitle = new SoundPlayer(@"C:\Users\AADITYA SHUKLA\Downloads\kbctitle.wav");
            kbctitle.Play();
            timer1.Start();
            timer2.Start();  

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        int tick = 9;
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (tick >= 0)
            {
                if (tick <= 9)
                {
                    label2.Text = "0" + tick.ToString();
                    tick--;
                }
                else
                {
                    label2.Text = tick.ToString();
                    tick--;
                }
            }
            else
            {
                //SoundPlayer TimeOut = new SoundPlayer(@"C:\Users\AADITYA SHUKLA\Downloads\TimeOut.wav");
                // TimeOut.Play();
                timer2.Stop();

            }
        }
    }
}
