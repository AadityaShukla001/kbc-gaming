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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Label l;
        SoundPlayer Suspense;
        private void label2_Click(object sender, EventArgs e)
        {
            l = (Label)sender;
            l.BackColor = Color.Red;
            timer1.Start();
            Suspense = new SoundPlayer(@"C:\Users\AADITYA SHUKLA\Downloads\Suspense.wav");
            Suspense.Play();

        }


        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        int sus = 1;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sus <= 5)
            {
                if (l.BackColor == Color.Red)
                {
                    l.BackColor = Color.Green;
                    sus++;
                }
                else if (l.BackColor == Color.Green)
                {
                    l.BackColor = Color.Red;
                    sus++;
                }
            }
            else
            {
                timer1.Stop();
                Suspense.Stop();
                if ((l.Name == "label2") && (label1.Text == "1.Who is the player to hit double century in odi?"))
                {
                    SoundPlayer kbc5000 = new SoundPlayer(@"C:\Users\AADITYA SHUKLA\Downloads\kbc5000.wav");
                    l.BackColor = Color.Green;
                    kbc5000.Play();
                    MessageBox.Show("You have won 5000");
                    //label10.ForeColor = Color.White; 
                    label9.ForeColor = Color.White;
                    chart1.Visible = false;
                    label9.ForeColor = Color.White;
                   label3.Visible = true;
                    label5.Visible = true;
                    l.BackColor = Color.Transparent;
                    sus = 1;
                    timer1.Start();
                    tick = 30;
                    timer2.Start();
                    tickmusic.Play();
                //  Suspense.();
                    label1.Text = "2.First PM of India?";
                    label2.Text = "Lal Bahadur Shastri";
                    label3.Text = "Indira Gandhi";
                    label4.Text = "Pt.Jawaharlal Nehru";
                    label5.Text = "Narendra Modi";
                }
                else if ((l.Name == "label4") &&(label1.Text == "2.First PM of India?"))
                 {
                    SoundPlayer kbc10000 = new SoundPlayer(@"C:\Users\AADITYA SHUKLA\Downloads\kbc10000.wav");
                    l.BackColor = Color.Green;
                    kbc10000.Play();
                    MessageBox.Show("You have won 10000");
                    chart1.Visible = false;
                    label10.ForeColor = Color.White;
                    label9.ForeColor = Color.Black;
                   label2.Visible = true;
                    label5.Visible = true;
                    l.BackColor = Color.Transparent;
                    sus = 1;
                    timer1.Start();
                    tick = 30;
                    timer2.Start();
                    tickmusic.Play();
                    label1.Text = "3.First Player to Score Four Hundred run in test?";
                    label2.Text = "Virat Kholi";
                    label3.Text = "Sachin Tendulkar";
                    label4.Text = "Rohit Sharma";
                    label5.Text = "Brian Lara";
                }
                else if ((l.Name == "label5") && (label1.Text == "3.First Player to Score Four Hundred run in test?"))
 {
                    SoundPlayer kbc20000 = new SoundPlayer(@"C:\Users\AADITYA SHUKLA\Downloads\kbc20000.wav");
                    kbc20000.Play();
                    MessageBox.Show("You Have Won Rs 20000");
                    chart1.Visible = false;
                    label11.ForeColor = Color.White;
                    label10.ForeColor = Color.Black;
                    label2.Visible = true;
                    label4.Visible = true;
                    l.BackColor = Color.Transparent;
                    sus = 1;
                    timer1.Start();
                   tick = 30;
                    timer2.Start();
                    tickmusic.Play();
                    label1.Text = "4.first man to land on moon?";
                    label2.Text = "Rakesh Sharma";
                    label3.Text = "Neil Armstrong";
                    label4.Text = "Kalpana Chawla";
                    label5.Text = "Nikola Tesla";
                }
         else if ((label1.Text == "4.first man to land on moon?") &&(l.Name == "label3"))
                {
                    SoundPlayer kbc40000 = new SoundPlayer(@"C:\Users\AADITYA SHUKLA\Downloads\kbc40000.wav");
                    kbc40000.Play();
                    MessageBox.Show("You Have Won Rs 40000");
                    chart1.Visible = false;
                   label12.ForeColor = Color.White;
                   label11.ForeColor = Color.Black;
                    label2.Visible = true;
                    label5.Visible = true;
                    l.BackColor = Color.Transparent;
                    sus = 1;
                    timer1.Start();
                    tick = 30;
                    timer2.Start();
                   tickmusic.Play();
                    label1.Text = "5.First Programming language?";
                    label2.Text = "Python";
                    label3.Text = "Java";
                    label4.Text = "C#";
                    label5.Text = "Fortran";
                }
                else if ((label1.Text == "5.First Programming language?")&&(l.Name == "label5"))
                {
                    SoundPlayer kbc80000 = new SoundPlayer(@"C:\Users\AADITYA SHUKLA\Downloads\kbc80000.wav");
                    kbc80000.Play();
                    MessageBox.Show("You Have Won Rs 80000");
                    chart1.Visible = false;
                    label13.ForeColor = Color.White;
                    label12.ForeColor = Color.Black;
                    l.BackColor = Color.Transparent;
                    sus = 1;
                    timer1.Start();
                    tick = 30;
                    timer2.Start();
                    tickmusic.Play();
                    label2.Visible = true;
                    label4.Visible = true;
                    label1.Text = "6.Who is Father of our india?";
                    label2.Text = "Bhagat Singh";
                    label3.Text = "Mahatama Gandhi";
                    label4.Text = "Chand Shekhar Azad";
                    label5.Text = "Lal Bahadur Shastri";
                }
                else if ((label1.Text == "6.Who is Father of our india?") &&(l.Name == "label3"))
                {
                    SoundPlayer kbc160000 = new SoundPlayer(@"C:\Users\AADITYA SHUKLA\Downloads\kbc160000.wav");
                    kbc160000.Play();
                    MessageBox.Show("You Have Won Rs 160000");
                    chart1.Visible = false;
                   label14.ForeColor = Color.White;
                    label13.ForeColor = Color.Black;
                    label2.Visible = true;
                    label4.Visible = true;
                    l.BackColor = Color.Transparent;
                    sus = 1;
                    timer1.Start();
                    tick = 30;
                    timer2.Start();
                   tickmusic.Play();
                    label1.Text = "7.who is father of computer?";
                    label2.Text = "Charles Babbage";
                    label3.Text = "Alan Turning";
                    label4.Text = "Ada Lovelace";
                    label5.Text = "Rangaswamy N";
                }
                else if ((label1.Text == "7.who is father of computer?") &&(l.Name == "label2"))
                {
                    SoundPlayer kbc320000 = new SoundPlayer(@"C:\Users\AADITYA SHUKLA\Downloads\kbc320000.wav");
                    kbc320000.Play();
                    MessageBox.Show("You Have Won Rs 320000");
                    label15.ForeColor = Color.White;
                  label14.ForeColor = Color.Black;
                  chart1.Visible = false;
                    label3.Visible = true;
                    label5.Visible = true;
                    l.BackColor = Color.Transparent;
                    sus = 1;
                    timer1.Start();
                   tick = 30;
                 timer2.Start();
                    tickmusic.Play();
                    label1.Text = "8.Who is father of Python?";
                    label2.Text = "John Mccarthy";
                    label3.Text = "Bills Gates";
                    label4.Text = "Guido Van Rossum";
                    label5.Text = "James Gosling";
                }
                else if ((label1.Text == "8.Who is father of Python?")&&(l.Name == "label4"))
                {
                    SoundPlayer kbc6400000 = new SoundPlayer(@"C:\Users\AADITYA SHUKLA\Downloads\kbc640.wav");
                    kbc6400000.Play();
                    MessageBox.Show("You Have Won Rs 6400000");
                    label16.ForeColor = Color.White;
                    label15.ForeColor = Color.Black;
                    chart1.Visible = false;
                    label2.Visible = true;
                    label5.Visible = true;
                    l.BackColor = Color.Transparent;
                    sus = 1;
                    timer1.Start();
                   tick = 30;
                    timer2.Start();
                   tickmusic.Play();
                    label1.Text = "9.Father of Java?";
                    label2.Text = "James Gosling";
                    label3.Text = "Guido Van R";
                    label4.Text = "Dennis Ritchie";
                    label5.Text = "Dr.E.F.Codd";
                }
                else if ((label1.Text == "9.Father of Java?") && (l.Name =="label2"))
                {
                    //125lakh
                    SoundPlayer kbc1250000 = new SoundPlayer(@"C:\Users\AADITYA SHUKLA\Downloads\kbc1250000.wav");
                    kbc1250000.Play();
                    MessageBox.Show("You Have Won Rs kbc1250000");
                   label17.ForeColor = Color.White;
                   label16.ForeColor = Color.Black;
                   chart1.Visible = false;
                    l.BackColor = Color.Transparent;
                    sus = 1;
                    timer1.Start();
                   tick = 30;
                    timer2.Start();
                   tickmusic.Play();
                    label3.Visible = true;
                    label4.Visible = true;
                    label1.Text = "10.Who is father of machine Learning?";
                    label2.Text = "John Mccarthy";
                    label3.Text = "Bills Gates";
                    label4.Text = "Geoffrey Chaucer";
                    label5.Text = "James Gosling";
                }
                else if ((label1.Text == "10.Who is father of machine Learning?")&&(l.Name == "label4"))
 {
                    SoundPlayer kbc2500000 = new SoundPlayer(@"C:\Users\AADITYA SHUKLA\Downloads\kbc2500000.wav");
                    kbc2500000.Play();
                    MessageBox.Show("You Have Won Rs kbc2500000");
                   label18.ForeColor = Color.White;
                    label17.ForeColor = Color.Black;
                    chart1.Visible = false;
                    l.BackColor = Color.Transparent;
                    sus = 1;
                    timer1.Start();
                  tick = 30;
                timer2.Start();
                 tickmusic.Play();
                    label2.Visible = true;
                    label5.Visible = true;
                    label1.Text = "11.Who is father of Blockchain?";
                    label2.Text = "James Gosling";
                    label3.Text = "Guido Van R";
                    label4.Text = "Dennis Ritchie";
                    label5.Text = "Satoshi Nakamoto";
                }
                else if ((label1.Text == "11.Who is father of Blockchain?")&&(l.Name == "label5"))
                {
                    SoundPlayer kbc50lpa = new SoundPlayer(@"C:\Users\AADITYA SHUKLA\Downloads\kbc50lpa.wav");
                    kbc50lpa.Play();
                    MessageBox.Show("You Have Won Rs 50lpa");
                    label19.ForeColor = Color.White;
                    label18.ForeColor = Color.Black;
                    l.BackColor = Color.Transparent;
                    chart1.Visible = false;
                    sus = 1;
                    timer1.Start();
                   tick = 30;
                    timer2.Start();
                    tickmusic.Play();
                    label2.Visible = true;
                    label4.Visible = true;
                    label1.Text = "12.Who is Father of Artifical Intelligence?";
               
                    label2.Text = "James Gosling";
                    label3.Text = "Alan Turning";
                    label4.Text = "Alan Mathison";
                    label5.Text = "John Mccarthy";
                }
                else if ((label1.Text == "12.Who is Father of Artifical Intelligence?") && (l.Name == "label5"))
 {
                    SoundPlayer kbc10000000 = new SoundPlayer(@"C:\Users\AADITYA SHUKLA\Downloads\kbc10000000.wav");
                    kbc10000000.Play();
                    MessageBox.Show("You Have Won Rs kbc10000000");
                    label20.ForeColor = Color.White;
                    label19.ForeColor = Color.Black;
                    l.BackColor = Color.Transparent;
                   chart1.Visible = false;
                    sus = 1;
                    timer1.Start();
                     tick = 30;
                timer2.Start();
                 tickmusic.Play();
                    label2.Visible = true;
                    label4.Visible = true;
                    label1.Text = "13.Who is Father of SemiConductor?";
                    label2.Text = "James Gosling";
                    label3.Text = "Alan Turning";
                    label4.Text = "Alan Mathison";
                    label5.Text = "Willam Shockley";
                }
                else if ((label1.Text == "13.Who is Father of SemiConductor?") && (l.Name == "label5"))
 {
                    SoundPlayer kbc5cr = new SoundPlayer(@"C:\Users\AADITYA SHUKLA\Downloads\kbc5cr.wav");
                    kbc5cr.Play();
                    MessageBox.Show("You Have Won Rs kbc5cr");
                  label21.ForeColor = Color.White;
                  label20.ForeColor = Color.Black;
                    l.BackColor = Color.Transparent;
                  chart1.Visible = false;
                    sus = 1;
                    timer1.Start();
                 tick = 30;
                 timer2.Start();
                  tickmusic.Play();
                    label2.Visible = true;
                    label4.Visible = true;
                    label1.Text = "14.Who is Father of Internet of Things?";
                    label2.Text = "James Gosling";
                    label3.Text = "Willam Shockley";
                    label4.Text = "Alan Mathison";
                    label5.Text = "Wendell Brown";
                }
 else if ((label1.Text == "14.Who is Father of Internet of Things?") && (l.Name == "label5"))
 {
                    SoundPlayer kbc7cr = new SoundPlayer(@"C:\Users\AADITYA SHUKLA\Downloads\kbc7cr.wav");
                    kbc7cr.Play();
                    MessageBox.Show("You Have Won Rs kbc7cr");
                  label22.ForeColor = Color.White;
                  label21.ForeColor = Color.Black;
                  l.BackColor = Color.Transparent;
                  chart1.Visible = false;
                    sus = 1;
                    timer1.Start();
                      tick = 30;
                       timer2.Start();
                       tickmusic.Play();
                    label2.Visible = true;
                       label4.Visible = true;
                }
                //else
                //{
                //}
                else
                {
                    DialogResult dr = MessageBox.Show("You Your Time Over","You Have Lost Press Yes To Play Again, No ToExit",MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    l.BackColor = Color.Red;
                    if (dr == DialogResult.Yes)
                    {
                        Application.Restart();
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
            }



        }
        SoundPlayer tickmusic;

        private void Form1_Load(object sender, EventArgs e)
        {
            tickmusic = new SoundPlayer(@"C:\Users\AADITYA SHUKLA\Downloads\tickmusic.wav");
            tickmusic.Play();
       timer2.Start();
         chart1.Visible = false;

        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (label1.Text == "1.Who is the player to hit double century in odi?")
            {
                label3.Visible = false;
                label5.Visible = false;
                label6.Enabled = false; // to one time only 50 50 option 
                
 }
            else if (label1.Text == "2.First PM of India?")
            {
                label2.Visible = false;
                label5.Visible = false;
                label6.Enabled = false;
            }
            else if (label1.Text == "3.First Player to Score Four Hundred run in test?")
 {
                label2.Visible = false;
                label4.Visible = false;
                label6.Enabled = false;
            }
 else if (label1.Text == "4.first man to land on moon?")
            {
                label2.Visible = false;
                label5.Visible = false;
                label6.Enabled = false;
            }
            else if (label1.Text == "5.First Programming language?")
            {
                label2.Visible = false;
                label4.Visible = false;
                label6.Enabled = false;
            }
            else if (label1.Text == "6.Who is Father of our india?")
            {
                label2.Visible = false;
                label4.Visible = false;
                label6.Enabled = false;
            }
            else if (label1.Text == "7.who is father of computer?")
            {
                label3.Visible = false;
                label5.Visible = false;
                label6.Enabled = false;
            }
            else if (label1.Text == "8.Who is father of Python?")
            {
                label2.Visible = false;
                label5.Visible = false;
                label6.Enabled = false;
            }
            else if (label1.Text == "9.Father of Java?")
            {
                label3.Visible = false;
                label4.Visible = false;
                label6.Enabled = false;
            }
            else if (label1.Text == "10.Who is father of machine Learning?")
            {
                label2.Visible = false;
                label5.Visible = false;
                label6.Enabled = false;
            }
            else if (label1.Text == "11.Who is father of Blockchain?")
            {
                label2.Visible = false;
                label4.Visible = false;
                label6.Enabled = false;
            }
            else if (label1.Text == "12.Who is Father of Artifical telligence?")
 {
                label2.Visible = false;
                label4.Visible = false;
                label6.Enabled = false;
            }
 else if (label1.Text == "13.Who is Father of SemiConductor?")
            {
                label2.Visible = false;
                label4.Visible = false;
                label6.Enabled = false;
            }
            else if (label1.Text == "14.Who is Father of Internet of Things?")
 {
                label2.Visible = false;
                label4.Visible = false;
                label6.Enabled = false;
            }
        }
        private void chart1_Click(object sender, EventArgs e)
        {
        }

        // private void label7_Click(object sender, EventArgs e)
        //{

        // }
        Random r = new Random();
        private void label7_Click_1(object sender, EventArgs e)
        {
            chart1.Visible = true;
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            if (label1.Text == "1.Who is the player to hit double century in odi?")
            {
                SoundPlayer kbcpoll = new SoundPlayer(@"C:\Users\AADITYA SHUKLA\Downloads\kbcpoll.wav");
                kbcpoll.Play();
                a = 45;
                b = r.Next(1, 26);
                c = r.Next(1, 26);
                d = 100 - (a + b + c);
                chart1.Series["Series1"].Points.AddXY("A", a.ToString());
                chart1.Series["Series1"].Points.AddXY("B", b.ToString());
                chart1.Series["Series1"].Points.AddXY("C", c.ToString());
                chart1.Series["Series1"].Points.AddXY("D", d.ToString());
                chart1.Visible = true;
                label7.Enabled = false;
            }
            else if (label1.Text == "2.First PM of India?")
            {
                SoundPlayer kbcpoll = new SoundPlayer(@"C:\Users\AADITYA SHUKLA\Downloads\kbcpoll.wav");
                kbcpoll.Play();
                a = 100-(a + b + c);
                b = r.Next(1, 26);
                c = 45;
                d = r.Next(1, 26);
                chart1.Series["Series1"].Points.AddXY("A", a.ToString());
                chart1.Series["Series1"].Points.AddXY("B", b.ToString());
                chart1.Series["Series1"].Points.AddXY("C", c.ToString());
                chart1.Series["Series1"].Points.AddXY("D", d.ToString());
                chart1.Visible = true;
                label7.Enabled = false;
            }
            else if (label1.Text == "3.First Player to Score Four Hundred run in test?")
            {
                SoundPlayer kbcpoll = new SoundPlayer(@"C:\Users\AADITYA SHUKLA\Downloads\kbcpoll.wav");
                kbcpoll.Play();
                a = r.Next(1,26); 
                b = 100-(a + b + c);
                c = r.Next(1, 26);
                d = 45;
                chart1.Series["Series1"].Points.AddXY("A", a.ToString());
                chart1.Series["Series1"].Points.AddXY("B", b.ToString());
                chart1.Series["Series1"].Points.AddXY("C", c.ToString());
                chart1.Series["Series1"].Points.AddXY("D", d.ToString());
                chart1.Visible = true;
                label7.Enabled = false;
            }
            else if (label1.Text == "4.first man to land on moon?")
            {
                SoundPlayer kbcpoll = new SoundPlayer(@"C:\Users\AADITYA SHUKLA\Downloads\kbcpoll.wav");
                kbcpoll.Play();
                a = r.Next(1, 26);
                b = 45;
                c = r.Next(1, 26);
                d = 100-(a + b + c);
                chart1.Series["Series1"].Points.AddXY("A", a.ToString());
                chart1.Series["Series1"].Points.AddXY("B", b.ToString());
                chart1.Series["Series1"].Points.AddXY("C", c.ToString());
                chart1.Series["Series1"].Points.AddXY("D", d.ToString());
                chart1.Visible = true;
                label7.Enabled = false;
            }
            else if (label1.Text == "5.First Programming language?")
            {
                SoundPlayer kbcpoll = new SoundPlayer(@"C:\Users\AADITYA SHUKLA\Downloads\kbcpoll.wav");
                kbcpoll.Play();
                a = 100-(a + b + c);
                b = r.Next(1, 26);
                c = r.Next(1, 26);
                d = 45;
                chart1.Series["Series1"].Points.AddXY("A", a.ToString());
                chart1.Series["Series1"].Points.AddXY("B", b.ToString());
                chart1.Series["Series1"].Points.AddXY("C", c.ToString());
                chart1.Series["Series1"].Points.AddXY("D", d.ToString());
                chart1.Visible = true;
                label7.Enabled = false;
            }
            else if (label1.Text == "6.Who is Father of our india?")
            {
                SoundPlayer kbcpoll = new SoundPlayer(@"C:\Users\AADITYA SHUKLA\Downloads\kbcpoll.wav");
                kbcpoll.Play();
                a = r.Next(1, 26);
                b = 45;
                c = r.Next(1, 26);
                d = 100-(a + b + c);
                chart1.Series["Series1"].Points.AddXY("A", a.ToString());
                chart1.Series["Series1"].Points.AddXY("B", b.ToString());
                chart1.Series["Series1"].Points.AddXY("C", c.ToString());
                chart1.Series["Series1"].Points.AddXY("D", d.ToString());
                chart1.Visible = true;
                label7.Enabled = false;
            }
            else if (label1.Text == "7.who is father of computer?")
            {
                SoundPlayer kbcpoll = new SoundPlayer(@"C:\Users\AADITYA SHUKLA\Downloads\kbcpoll.wav");
                kbcpoll.Play();
                a = 45;
                b = r.Next(1, 26);
                c = r.Next(1, 26);
                d = 100-(a + b + c);
                chart1.Series["Series1"].Points.AddXY("A", a.ToString());
                chart1.Series["Series1"].Points.AddXY("B", b.ToString());
                chart1.Series["Series1"].Points.AddXY("C", c.ToString());
                chart1.Series["Series1"].Points.AddXY("D", d.ToString());
                chart1.Visible = true;
                label7.Enabled = false;
            }
            else if (label1.Text == "8.Who is father of Python?")
            {
                SoundPlayer kbcpoll = new SoundPlayer(@"C:\Users\AADITYA SHUKLA\Downloads\kbcpoll.wav");
                kbcpoll.Play();
                a = r.Next(1, 26);
                b = r.Next(1, 26);
                c = 45;
                d = 100-(a + b + c);
                chart1.Series["Series1"].Points.AddXY("A", a.ToString());
                chart1.Series["Series1"].Points.AddXY("B", b.ToString());
                chart1.Series["Series1"].Points.AddXY("C", c.ToString());
                chart1.Series["Series1"].Points.AddXY("D", d.ToString());
                chart1.Visible = true;
                label7.Enabled = false;
            }
            else if (label1.Text == "9.Father of Java?")
            {
                SoundPlayer kbcpoll = new SoundPlayer(@"C:\Users\AADITYA SHUKLA\Downloads\kbcpoll.wav");
                kbcpoll.Play();
                a = 45;
                b = r.Next(1, 26);
                c = r.Next(1, 26);
                d = 100-(a + b + c);
                chart1.Series["Series1"].Points.AddXY("A", a.ToString());
                chart1.Series["Series1"].Points.AddXY("B", b.ToString());
                chart1.Series["Series1"].Points.AddXY("C", c.ToString());
                chart1.Series["Series1"].Points.AddXY("D", d.ToString());
                chart1.Visible = true;
                label7.Enabled = false;
            }
            else if (label1.Text == "10.Who is father of machine Learning?")
            {
                SoundPlayer kbcpoll = new SoundPlayer(@"C:\Users\AADITYA SHUKLA\Downloads\kbcpoll.wav");
                kbcpoll.Play();
                a = r.Next(1, 26);
                b = r.Next(1, 26);
                c = 45;
                d = 100-(a + b + c);
                chart1.Series["Series1"].Points.AddXY("A", a.ToString());
                chart1.Series["Series1"].Points.AddXY("B", b.ToString());
                chart1.Series["Series1"].Points.AddXY("C", c.ToString());
                chart1.Series["Series1"].Points.AddXY("D", d.ToString());
                chart1.Visible = true;
                label7.Enabled = false;
            }
            else if (label1.Text == "11.Who is father of Blockchain?")
            {
                SoundPlayer kbcpoll = new SoundPlayer(@"C:\Users\AADITYA SHUKLA\Downloads\kbcpoll.wav");
                kbcpoll.Play();
                a = 100-(a + b + c);
                b = r.Next(1, 26);
                c = r.Next(1, 26);
                d = 45;
                chart1.Series["Series1"].Points.AddXY("A", a.ToString());
                chart1.Series["Series1"].Points.AddXY("B", b.ToString());
                chart1.Series["Series1"].Points.AddXY("C", c.ToString());
                chart1.Series["Series1"].Points.AddXY("D", d.ToString());
                chart1.Visible = true;
                label7.Enabled = false;
            }
            else if (label1.Text == "12.Who is Father of Artifical Intelligence?")
            {
                SoundPlayer kbcpoll = new SoundPlayer(@"C:\Users\AADITYA SHUKLA\Downloads\kbcpoll.wav");
                kbcpoll.Play();
                a = 100-(a + b + c);
                b = r.Next(1, 26);
                c = r.Next(1, 26);
                d = 45; 
                chart1.Series["Series1"].Points.AddXY("A", a.ToString());
                chart1.Series["Series1"].Points.AddXY("B", b.ToString());
                chart1.Series["Series1"].Points.AddXY("C", c.ToString());
                chart1.Series["Series1"].Points.AddXY("D", d.ToString());
                chart1.Visible = true;
                label7.Enabled = false;
            }
            else if (label1.Text == "13.Who is Father of SemiConductor?")
            {
                SoundPlayer kbcpoll = new SoundPlayer(@"C:\Users\AADITYA SHUKLA\Downloads\kbcpoll.wav");
                kbcpoll.Play();
                a = 100-(a + b + c);
                b = r.Next(1, 26);
                c = r.Next(1, 26);
                d = 45;
                chart1.Series["Series1"].Points.AddXY("A", a.ToString());
                chart1.Series["Series1"].Points.AddXY("B", b.ToString());
                chart1.Series["Series1"].Points.AddXY("C", c.ToString());
                chart1.Series["Series1"].Points.AddXY("D", d.ToString());
                chart1.Visible = true;
                label7.Enabled = false;
            }
            else if (label1.Text == "14.Who is Father of Internet of Things?")
            {
                SoundPlayer kbcpoll = new SoundPlayer(@"C:\Users\AADITYA SHUKLA\Downloads\kbcpoll.wav");
                kbcpoll.Play();
                a = 100-(a + b + c);
                b = r.Next(1, 26);
                c = r.Next(1, 26);
                d = 45;
                chart1.Series["Series1"].Points.AddXY("A", a.ToString());
                chart1.Series["Series1"].Points.AddXY("B", b.ToString());
                chart1.Series["Series1"].Points.AddXY("C", c.ToString());
                chart1.Series["Series1"].Points.AddXY("D", d.ToString());
                chart1.Visible = true;
                label7.Enabled = false;
            }
            else // to enable wrong quest 
            {
                SoundPlayer WrongAnswer = new SoundPlayer(@"C:\Users\AADITYA SHUKLA\Downloads\WrongAnswer.wav");
                WrongAnswer.Play();
                MessageBox.Show("You Have Entered Wrong Answer");
            }
        }
        int tick = 30;

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (tick >= 0)
            {
                if (tick <= 9)
                {
                    label8.Text = "0"+tick.ToString();
                    tick--;
                }
                else
                {
                    label8.Text = tick.ToString();
                    tick--;
                }
            }
            else
            {
                SoundPlayer TimeOut = new SoundPlayer(@"C:\Users\AADITYA SHUKLA\Downloads\TimeOut.wav");
                TimeOut.Play();
                timer2.Stop();
                l.BackColor = Color.Red;
                DialogResult dr = MessageBox.Show("Your Time Over", "You Have Loss!Press Yes To Play Again, No To Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (dr == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
    }
}
   
         
