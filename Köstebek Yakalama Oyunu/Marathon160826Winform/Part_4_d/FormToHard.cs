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
    public partial class FormToHard : Form
    {
        int time = 500;
        int counter = 25;
        int i;
        public FormToHard()
        {
            InitializeComponent();
        }
        object img3 = Image.FromFile(@"C:\Users\SERKAN\Desktop\uygulamalar\Marathon160826Winform (2)\Marathon160826Winform\Part_4_d\img\köstebek.png");
        object img4 = Image.FromFile(@"C:\Users\SERKAN\Desktop\uygulamalar\Marathon160826Winform (2)\Marathon160826Winform\Part_4_d\img\köstebek yuvası.png");
        int clickYes = 0;
        int clickNo = 0;
        Random rnd = new Random();

        private void FormToHard_Load(object sender, EventArgs e)
        {
            for (i = 0; i < counter; i++)
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

            int random = rnd.Next(1, counter);

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
            if (clickYes == 5)
            {
                timer1.Stop();
                MessageBox.Show("Tebrikler 2.Seviyeye Geçtiniz");
                timer1.Interval = 950;
                timer1.Start();
            }
            else if (clickYes == 10)
            {
                timer1.Stop();
                MessageBox.Show("Tebrikler 3.Seviyeye Geçtiniz");
                timer1.Interval = 900;
                timer1.Start();
            }
            else if (clickYes == 15)
            {
                timer1.Stop();
                MessageBox.Show("Tebrikler 4.Seviyeye Geçtiniz");
                timer1.Interval = 850;
                timer1.Start();
            }
            else if (clickYes == 20)
            {
                timer1.Stop();
                MessageBox.Show("Tebrikler 5.Seviyeye Geçtiniz");
                timer1.Interval = 800;
                timer1.Start();
            }
            else if (clickYes == 25)
            {
                timer1.Stop();
                MessageBox.Show("Tebrikler 6.Seviyeye Geçtiniz");
                timer1.Interval = 750;
                timer1.Start();
            }
            else if (clickYes == 30)
            {
                timer1.Stop();
                MessageBox.Show("Tebrikler 7.Seviyeye Geçtiniz");
                timer1.Interval = 700;
                timer1.Start();
            }
            else if (clickYes == 35)
            {
                timer1.Stop();
                MessageBox.Show("Tebrikler 8.Seviyeye Geçtiniz");
                timer1.Interval = 650;
                timer1.Start();
            }
            else if (clickYes == 40)
            {
                timer1.Stop();
                MessageBox.Show("Tebrikler 9.Seviyeye Geçtiniz");
                timer1.Interval = 600;
                timer1.Start();
            }
            else if (clickYes == 45)
            {
                timer1.Stop();
                MessageBox.Show("Tebrikler 10.Seviyeye Geçtiniz");
                timer1.Interval = 550;
                timer1.Start();
            }
            else if (clickYes == 50)
            {
                timer1.Stop();
                MessageBox.Show("Tebrikler 11.Seviyeye Geçtiniz");
                timer1.Interval = 500;
                timer1.Start();
            }
            else if (clickYes == 55)
            {
                timer1.Stop();
                MessageBox.Show("Tebrikler 12.Seviyeye Geçtiniz");
                timer1.Interval = 450;
                timer1.Start();
            }
            else if (clickYes == 60)
            {
                timer1.Stop();
                MessageBox.Show("Tebrikler 13.Seviyeye Geçtiniz");
                timer1.Interval = 400;
                timer1.Start();
            }
            else if (clickYes == 65)
            {
                timer1.Stop();
                MessageBox.Show("Tebrikler 14.Seviyeye Geçtiniz");
                timer1.Interval = 350;
                timer1.Start();
            }
            else if (clickYes == 70)
            {
                timer1.Stop();
                MessageBox.Show("Tebrikler 15.Seviyeye Geçtiniz");
                timer1.Interval = 300;
                timer1.Start();
            }
            else if (clickYes == 75)
            {
                timer1.Stop();
                MessageBox.Show("Tebrikler 16.Seviyeye Geçtiniz");
                timer1.Interval = 250;
                timer1.Start();
            }
            else if (clickYes == 80)
            {
                timer1.Stop();
                MessageBox.Show("Tebrikler 17.Seviyeye Geçtiniz");
                timer1.Interval = 200;
                timer1.Start();
            }
            else if (clickYes == 85)
            {
                timer1.Stop();
                MessageBox.Show("Tebrikler 18.Seviyeye Geçtiniz");
                timer1.Interval = 150;
                timer1.Start();
            }
            else if (clickYes == 90)
            {
                timer1.Stop();
                MessageBox.Show("Tebrikler Oyunu Kazandınız:)"+"\n Skorunuz: "+clickYes);
                timer1.Interval = 100;  
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
