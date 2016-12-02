using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Part_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string A;
        int B;
        decimal C;
        DateTime D;
        decimal E;
        int F;

        private void btnA_Click(object sender, EventArgs e)
        {
            A = txtBxA.Text;
            MessageBox.Show(A);
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            B = int.Parse(txtBxB.Text);
            MessageBox.Show(B.ToString());
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            C = decimal.Parse(txtBxC.Text);
            MessageBox.Show(C.ToString());
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            D = Convert.ToDateTime(txtBxD.Text);
            MessageBox.Show(D.ToString());
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            E = decimal.Parse(txtBxE.Text);
            MessageBox.Show(E.ToString("0.##"));
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            F = (int)Math.Round(Convert.ToDecimal(txtBxF.Text));
            MessageBox.Show(F.ToString());
        }


      
    }
}
