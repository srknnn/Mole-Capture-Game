using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Player newPlayer = new Player();
        int counter = 1;
        private void btnCreate_Click(object sender, EventArgs e)
        {
           
            if (txtBxFirstName.Text != "" && txtBxLastName.Text != "" && txtBxSpecialShoot.Text != "")
            {
                newPlayer.Id = counter++;
                newPlayer.FirstName = txtBxFirstName.Text;
                newPlayer.LastName = txtBxLastName.Text;
                newPlayer.DateOfBirth = dateTimePicker.Value;
                newPlayer.Team = cmbBxTeams.SelectedText;
                newPlayer.SpecialShoot = txtBxSpecialShoot.Text;
                newPlayer.Shooting = int.Parse(nmrcUpDwnShoting.Value.ToString());
                newPlayer.Passing = int.Parse(nmrcUpDwnPassing.Value.ToString());
                newPlayer.Dribbling = int.Parse(nmrcUpDwnDribbling.Value.ToString());
                listBox1.Items.Add(newPlayer.ToString());
                txtBxFirstName.Text = "";
                txtBxLastName.Text = "";
                cmbBxTeams.SelectedText = "";
                txtBxSpecialShoot.Text = "";
                nmrcUpDwnShoting.Value = 0;
                nmrcUpDwnPassing.Value = 0;
                nmrcUpDwnDribbling.Value = 0;
            }
            else 
            {
                MessageBox.Show("Boş Değerleri Ekleyemessiniz!");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult delete = new DialogResult();

            delete = MessageBox.Show("silmek istediğinize Eminmisiniz?", "Silme Uyarısı!", MessageBoxButtons.YesNo);

            if (delete == DialogResult.Yes)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                MessageBox.Show("Veriniz Silindi");
            }




        }
        public class Player
        {
            public int Id;
            public string FirstName;
            public string LastName;
            public DateTime DateOfBirth;
            public string Team;
            public string SpecialShoot;
            public int Shooting;
            public int Passing;
            public int Dribbling;

            public override string ToString()
            {
                return"ID: "+Id+ " İsim:" + FirstName + "  " + "Soyisim:" + LastName + "  " + "Doğum Tarihi" + DateOfBirth + "  " + "Takımı:" + Team + "  " + "Özel Şut:" + SpecialShoot + "  " + "Şut Sayısı:" + Shooting + "  " + "Pas Sayısı:" + Passing + "  " + "Dribling Sayısı:" + Dribbling;
            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            listBox1.Items.Remove(listBox1.SelectedItem);
            if (txtBxFirstName.Text != "" && txtBxLastName.Text != "" && txtBxSpecialShoot.Text != "")
            {
              
                newPlayer.FirstName = txtBxFirstName.Text;
                newPlayer.LastName = txtBxLastName.Text;
                newPlayer.DateOfBirth = dateTimePicker.Value;
                newPlayer.Team = cmbBxTeams.SelectedText;
                newPlayer.SpecialShoot = txtBxSpecialShoot.Text;
                newPlayer.Shooting = int.Parse(nmrcUpDwnShoting.Value.ToString());
                newPlayer.Passing = int.Parse(nmrcUpDwnPassing.Value.ToString());
                newPlayer.Dribbling = int.Parse(nmrcUpDwnDribbling.Value.ToString());
                listBox1.Items.Insert(index, newPlayer);
                txtBxFirstName.Text = "";
                txtBxLastName.Text = "";
                cmbBxTeams.SelectedText = "";
                txtBxSpecialShoot.Text = "";
                nmrcUpDwnShoting.Value = 0;
                nmrcUpDwnPassing.Value = 0;
                nmrcUpDwnDribbling.Value = 0;
            }
            else
            {
                MessageBox.Show("Boş Değerleri Güncelleyemessiniz!");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Player persons = (Player)listBox1.SelectedItem;
            txtBxFirstName.Text = persons.FirstName;
            txtBxLastName.Text = persons.LastName;
            dateTimePicker.Value = persons.DateOfBirth;
            cmbBxTeams.SelectedItem = persons.Team;
            txtBxSpecialShoot.Text = persons.SpecialShoot;
            nmrcUpDwnShoting.Value = persons.Shooting;
            nmrcUpDwnPassing.Value = persons.Passing;
            nmrcUpDwnDribbling.Value =persons.Dribbling;
            

        }

       
    }
}
