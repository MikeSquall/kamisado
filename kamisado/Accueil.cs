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

        public Accueil()
        {
            InitializeComponent();
        }

        private void Accueil_Load(object sender, EventArgs e)
        {
            btn_newGame.BackgroundImageLayout = ImageLayout.Center;
            btn_newGame.BackgroundImage = boutonsList.Images[0];
            btn_loadGame.BackgroundImageLayout = ImageLayout.Center;
            btn_loadGame.BackgroundImage = boutonsList.Images[1];
            btn_quitGame.BackgroundImageLayout = ImageLayout.Center;
            btn_quitGame.BackgroundImage = boutonsList.Images[2];
            
            btn_simpleGame.Visible = false;
            btn_simpleGame.BackgroundImageLayout = ImageLayout.Center;
            btn_simpleGame.BackgroundImage = boutonsList.Images[3];

            btn_complexGame.Visible = false;
            btn_complexGame.BackgroundImageLayout = ImageLayout.Center;
            btn_complexGame.BackgroundImage = boutonsList.Images[4];
        }

        private void btn_newGame_Click(object sender, EventArgs e)
        {
            //btn_newGame.Visible = false;
            //btn_loadGame.Visible = false;
            //btn_quitGame.Visible = false;
            //btn_simpleGame.Visible = true;
            //btn_complexGame.Visible = true;
            //this.Visible = false;

            ChoixTypePartie choix = new ChoixTypePartie();
            choix.ShowDialog();
            this.Visible = true;
            Partie game = new Partie();
            game.ShowDialog();
        }

        private void btn_quitGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
