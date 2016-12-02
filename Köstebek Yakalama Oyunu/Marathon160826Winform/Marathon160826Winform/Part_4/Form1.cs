using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_4
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
        object img1 = Image.FromFile(@"C:\Users\Public\Pictures\Sample Pictures\giphy.gif");
        object img2 = Image.FromFile(@"C:\Users\Public\Pictures\Sample Pictures\indir.jpg");
        Random rnd = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            
            for (int i = 0; i < 25; i++)
            {
                Button moleHome = new Button();
                moleHome.BackColor = Color.Black;
                moleHome.ForeColor = Color.White;
                moleHome.Width = 50;
                moleHome.Height = 50;
                moleHome.Text = (i + 1).ToString();
                flowLayoutPanel1.Controls.Add(moleHome);
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            int random = rnd.Next(1, 25);
            
            foreach (var moles in flowLayoutPanel1.Controls)
            {
                Button moleHome = moles as Button;
                if (moleHome.Text == random.ToString())
                {
                    moleHome.BackgroundImage = (Image)img1;
                   // moleHome.BackColor = Color.Red;
                  
                    moleHome.Click += new EventHandler(moleHome_Click);
                }
                else
                {
                    moleHome.BackgroundImage = (Image)img2;
                   // moleHome.BackColor = Color.Black;
                }
            
            }

        }
        void moleHome_Click(object sender, EventArgs e)
        {
            Button moleHome = sender as Button;
            if (moleHome.BackgroundImage==img1)
            {
                timer1.Stop();

                MessageBox.Show("Tebrikler Başarıyla Tıkladınız");
                Application.Exit();
            }
           
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
           
           
        }
    }
}
