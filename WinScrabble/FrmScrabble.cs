using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinScrabble
{

    public partial class FrmScrabble : Form
    {
        Joueur j1;
        Joueur j2;
        public FrmScrabble()
        {
            InitializeComponent();
        }

        private void FrmScrabble_Load(object sender, EventArgs e)
        {
            
            
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            j1 = new Joueur(txtJ1.Text);
            j2 = new Joueur(txtJ2.Text);
            button1.Enabled = false;
            txtJ1.Enabled = false;
            txtJ2.Enabled = false;
            Random r = new Random();
            int nbR = r.Next(1, 3);
            if (nbR == 1)
            {
                label3.Text += j1.GetNom();
            }
            else
                label3.Text += j2.GetNom();

            label4.Text += j1.GetNom();
            label5.Text += j2.GetNom();


        }
    }
}
