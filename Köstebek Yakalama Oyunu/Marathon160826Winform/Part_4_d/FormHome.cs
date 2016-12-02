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
    public partial class FormHome : Form
    {
        public string choose;
        public FormHome()
        {
            InitializeComponent();
        }
        FormEasy frmEasy = new FormEasy();
       

        private void btnEasy_Click(object sender, EventArgs e)
        {
            frmEasy.Show();
            this.Hide();
        }
        FormMediumm frmMediumm = new FormMediumm();
        private void btnMedium_Click(object sender, EventArgs e)
        {
            frmMediumm.Show();
            this.Hide();
        }
        FormHard frmHard = new FormHard();
        private void btnHard_Click(object sender, EventArgs e)
        {
            frmHard.Show();
            this.Hide();
        }
        FormToHard frmToHard = new FormToHard();
        private void btnToHard_Click(object sender, EventArgs e)
        {
            frmToHard.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
    }
}
