using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_4_d
{
    public partial class FormEasy : Form
    {
        int time = 60;
        public FormEasy()
        {
            InitializeComponent();
        }
        object img3 = Image.FromFile(@"C:\Users\SERKAN\Desktop\uygulamalar\Marathon160826Winform (2)\Marathon160826Winform\Part_4_d\img\köstebek.png");
        object img4 = Image.FromFile(@"C:\Users\SERKAN\Desktop\uygulamalar\Marathon160826Winform (2)\Marathon160826Winform\Part_4_d\img\köstebek yuvası.png");
        int clickYes = 0;
        int clickNo = 0;
        Random rnd = new Random();
        private void FormEasy_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 25; i++)
            {
                Button moleHome = new Button();
                moleHome.BackgroundImage = (Image)img4;
                moleHome.Width = 70;
                moleHome.Height = 70;
                moleHome.TabStop = false;
                moleHome.FlatStyle = FlatStyle.Flat;
                moleHome.FlatAppearance.BorderSize = 0;
                moleHome.Text = (i + 1).ToString();
                flowLayoutPanel1.Controls.Add(moleHome);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            lblTime.Text = time.ToString();
            if (time < 1)
            {
                timer1.Enabled = false;

                MessageBox.Show("Süreniz Bitmiştir!  " + "  Yakalama Sayınız: " + clickYes + "\n" + "Kaçırma Sayınız: " + clickNo);
            }


            int random = rnd.Next(1, 25);

            foreach (var moles in flowLayoutPanel1.Controls)
            {
                Button moleHome = moles as Button;
                if (moleHome.Text == random.ToString())
                {
                    moleHome.BackgroundImage = (Image)img3;
                    moleHome.Click += new EventHandler(moleHome_Click);
                }
                else
                {
                    moleHome.BackgroundImage = (Image)img4;
                }
                lblClickYes1.Text = clickYes.ToString();
                lblClickNo1.Text = clickNo.ToString();
            }
        }
        void moleHome_Click(object sender, EventArgs e)
        {
            Button moleHome = sender as Button;
            if (moleHome.BackgroundImage == img3)
            {
                clickYes++;
            }
            else
            {
                clickNo++;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            btnStart.Text = "Devam Et";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clickYes = 0;
            clickNo = 0;
            time = 60;
        }
    }
}
