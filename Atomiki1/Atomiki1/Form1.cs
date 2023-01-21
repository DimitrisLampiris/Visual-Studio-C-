using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            richTextBox1.LoadFile("scores.txt", RichTextBoxStreamType.PlainText);
            richTextBox2.LoadFile("names.txt", RichTextBoxStreamType.PlainText);


        }


        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {



        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

        }
        int S;
        int score = 0;
        int scoreperclick;
        int maxscore;

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int x = rnd.Next(0, 900);
            int y = rnd.Next(100, 320);



            pictureBox1.Location = new Point(x, y);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                pictureBox1.Visible = true;
                timer1.Interval = 1000;
                timer1.Enabled = true;

                timer2.Enabled = true;
                scoreperclick = 10;
            }
            else
            {
                MessageBox.Show("Didnt give name!");
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            S = S + 1;
            label3.Text = S.ToString();
            if (S == 30)
            {
                pictureBox1.Visible = false;
                timer1.Enabled = false;
                timer2.Enabled = false;


                MessageBox.Show("END GAME.You have scored " + score + "points!");


                richTextBox2.Text +=Environment.NewLine + textBox1.Text + " " + score.ToString();

               


                if (richTextBox1.Text == string.Empty)
                {
                    richTextBox1.Text = textBox1.Text + " " + score.ToString();
                    maxscore = score;
                    
                    MessageBox.Show(maxscore.ToString());

                }
                else
                {
                    
                    foreach (string s in richTextBox1.Lines)
                    {
                        
                        String[] tmp = s.Split(' ');
                        
                        Int32.TryParse(tmp[1],out maxscore); //metatropi pontwn tou text se int metabliti maxscore
                        
                    }
                    if (score > maxscore)
                    {
                        richTextBox1.Text = textBox1.Text + " " + score.ToString();
                        MessageBox.Show("You have scored High Score");
                    }
                    else if (score == maxscore)
                    {
                        richTextBox1.Text += Environment.NewLine + textBox1.Text + " " + score.ToString();
                        MessageBox.Show("You have scored High Score");
                    }
                }

                richTextBox1.SaveFile("scores.txt", RichTextBoxStreamType.PlainText);
                richTextBox2.SaveFile("names.txt", RichTextBoxStreamType.PlainText);

                MessageBox.Show("New player enter name and click level!");
                S = 0;
                score = 0;
                textBox1.Text = "";
                label8.Text = "0";


            }
        }








        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                pictureBox1.Visible = true;
                scoreperclick = 20;
                timer1.Interval = 700;
                timer1.Enabled = true;
                timer2.Enabled = true;
            }
            else
            {
                MessageBox.Show("didnt give name");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "frog.gif";

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            score = score + scoreperclick;
            label8.Text = score.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To Level 1 Kineite pio arga alla gia kathe xtipima perneis 10 pontous eno sto level 2 einai pio grigoro kai gia kathe xtipima 20 pontous!");

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(richTextBox2.Text);


        }
    }
}