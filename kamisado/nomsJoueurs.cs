using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kamisado
{
    public partial class nomsJoueurs : Form
    {
        public nomsJoueurs()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        private void valideNomJoueur_Click(object sender, EventArgs e)
        {
            if(nomJoueur1.Text == "")
            {
                MessageBox.Show("Le nom du joueur n°1 ne peut pas être vide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (nomJoueur2.Text == "")
            {
                MessageBox.Show("Le nom du joueur n°2 ne peut pas être vide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Accueil.J1 = new Joueur(nomJoueur1.Text, 0, Convert.ToInt16(liste_duree.SelectedItem));
                Accueil.J2 = new Joueur(nomJoueur2.Text, 1, Convert.ToInt16(liste_duree.SelectedItem));
                if (partie_complexe.Checked == true)
                {
                    Accueil.partie_complexe = true;
                }
                this.Hide();
            }
        }

        private void valideNomJoueur_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                valideNomJoueur.PerformClick();
            }
        }

        private void nomsJoueurs_Load(object sender, EventArgs e)
        {
            liste_duree.SelectedIndex = 5; /*10 min par défaut*/
            partie_simple.Checked = true;
        }
    }
}
