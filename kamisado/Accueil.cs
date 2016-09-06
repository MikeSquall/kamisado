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
    public partial class Accueil : Form
    {
        internal static Joueur J1, J2;
        internal static bool partie_complexe = false;
        internal static int tempsChoisi;

        public Accueil()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Accueil_Load(object sender, EventArgs e)
        {
            btn_newGame.BackgroundImageLayout = ImageLayout.Center;
            btn_newGame.BackgroundImage = boutonsList.Images[0];
            
            btn_quitGame.BackgroundImageLayout = ImageLayout.Center;
            btn_quitGame.BackgroundImage = boutonsList.Images[2];
        }

        private void btn_newGame_Click(object sender, EventArgs e)
        {
            ChoixTypePartie choix = new ChoixTypePartie();
            choix.ShowDialog();
            this.Visible = false;
            Partie game = new Partie();
            game.ShowDialog();
            this.Visible = true;
        }
        
        private void btn_quitGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
