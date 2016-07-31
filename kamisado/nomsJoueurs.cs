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
                Accueil.nomJ1 = nomJoueur1.Text;
                Accueil.nomJ2 = nomJoueur2.Text;
                this.Hide();
            }
        }
    }
}
