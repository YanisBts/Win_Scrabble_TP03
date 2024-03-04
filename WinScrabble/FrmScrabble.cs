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
            
            textBox1.Text = Utilitaire.lettreRandom();
            textBox2.Text = Utilitaire.lettreRandom();
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            
            

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
                txtMotJ2.Enabled = false;
                btnValJ2.Enabled = false;

            }
            else
            {
                label3.Text += j2.GetNom();
                txtMotJ1.Enabled = false;
                btnValJ1.Enabled = false;
            }

            label4.Text += j1.GetNom();
            label5.Text += j2.GetNom();


        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            
            
            if (j1.GetNbMots() == 10 && j2.GetNbMots() == 10)
            {
                btnValJ1.Enabled = false;
                btnValJ2.Enabled = false;
                btnRes.Enabled = true;
                
            }
            else
            {
                txtMotJ2.Enabled = true;
                btnValJ2.Enabled = true;
                txtMotJ1.Enabled = false;
                btnValJ1.Enabled = false;
                j1.AjouterMot(textBox1.Text);
                txtMotJ1.Clear();
                textBox1.Clear();
                textBox1.Text = Utilitaire.lettreRandom();

                scoreJ1.Text = "Score : " + j1.GetTotalPoints().ToString();
            }


        }

        private void btnValJ2_Click(object sender, EventArgs e)
        {
            

            if (j1.GetNbMots() == 10 && j2.GetNbMots() == 10)
            {
                btnValJ1.Enabled = false;
                btnValJ2.Enabled = false;
                btnRes.Enabled = true;
                
            }
            else
            {
                txtMotJ1.Enabled = true;
                btnValJ1.Enabled = true;
                txtMotJ2.Enabled = false;
                btnValJ2.Enabled = false;
                j2.AjouterMot(textBox2.Text);
                txtMotJ2.Clear();
                textBox2.Text = Utilitaire.lettreRandom();
                scoreJ2.Text = "Score : " + j2.GetTotalPoints().ToString();
            }
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            btnRes.Enabled = false;
            if (j1.GetTotalPoints() > j2.GetTotalPoints())
            {
                label11.Text += j1.GetNom();
                label12.Text += j1.MotMeilleur();
                foreach (string mot in j1.GetLesMots())
                {
                    richTextBox1.Text += mot + "\t";
                }
            }
            else
            {
                label12.Text += j2.GetNom();
                foreach (string mot in j2.GetLesMots())
                {
                    richTextBox1.Text += mot + "\t";
                }
            }
            
        }
    }
}
