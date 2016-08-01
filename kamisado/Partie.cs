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
    public partial class Partie : Form
    {
        List<int> casesOrange = new List<int> {0,9,18,27,36,45,54,63};
        List<int> casesBlue = new List<int> {1,12,23,26,37,40,51,62};
        List<int> casesViolet = new List<int> {2,15,20,25,38,43,48,61};
        List<int> casesPink = new List<int> {3,10,17,24,39,46,53,60};
        List<int> casesYellow = new List<int> {4,13,22,31,32,41,50,59};
        List<int> casesRed = new List<int> {5,8,19,30,33,44,55,58};
        List<int> casesGreen = new List<int> {6,11,16,29,34,47,52,57};
        List<int> casesBrown = new List<int> {7,14,21,28,35,42,49,56};
        public Partie()
        {
            InitializeComponent();
            this.nomJoueur1.Text = Accueil.nomJ1;
            this.nomJoueur2.Text = Accueil.nomJ2;
            this.scoreJ1.Text = "0 Point";
            this.scoreJ2.Text = "0 Point";
            this.chronoJ1.Text = string.Format("{0:00}:{1:00}", Convert.ToInt16(progressbarJ1.Value / 60), Convert.ToInt16(progressbarJ1.Value % 60));
            this.chronoJ2.Text = string.Format("{0:00}:{1:00}", Convert.ToInt16(progressbarJ2.Value / 60), Convert.ToInt16(progressbarJ2.Value % 60));
            //timerJ1.Enabled = true;
            //timerJ2.Enabled = true;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            int ligne = 0,
                colonne = 0,
                index_list = 0, //pour la gestion des images de l'ImageList qui contient les png des tours
                couleur = 0; //pour déterminer la couleur des tours
            bool occupee;

            //Création du tableau qui contiendra les cases du plateau
            Case[] plateau = new Case[64];
            //Création du tableau qui contiendra les 16 tours du jeu -> sert à des fins de test pour le moment
            Pion[] tours = new Pion[16];
            board.BringToFront();

            //Création du plateau au sens visuel du terme
            for (int n = 0; n < 64; n++)
            {
                occupee = false;
                if (n % 8 == 0 && n != 0)
                {
                    ligne += 52;
                    colonne = 0;
                }
                
                Label tmp = new Label();
                tmp.Size = new Size(50, 50);
                board.Controls.Add(tmp);
                tmp.Location = new Point(colonne, ligne);
                //tmp.BorderStyle = BorderStyle.FixedSingle;
                //tmp.Text = Convert.ToString(n); // sert aux tests de génération du plateau

                if (casesOrange.Contains(n))
                {
                    tmp.BackColor = Color.Orange;
                    //tmp.Tag = "orange";
                    couleur = 1;
                } else if (casesBlue.Contains(n))
                {
                    tmp.BackColor = Color.CornflowerBlue;
                    //tmp.Tag = "blue";
                    couleur = 2;
                } else if (casesViolet.Contains(n))
                {
                    tmp.BackColor = Color.DarkOrchid;
                    //tmp.Tag = "violet";
                    couleur = 3;
                } else if (casesPink.Contains(n))
                {
                    tmp.BackColor = Color.HotPink;
                    //tmp.Tag = "pink";
                    couleur = 4;
                } else if (casesYellow.Contains(n))
                {
                    tmp.BackColor = Color.Yellow;
                    //tmp.Tag = "yellow";
                    couleur = 5;
                } else if (casesRed.Contains(n))
                {
                    tmp.BackColor = Color.Crimson;
                    //tmp.Tag = "red";
                    couleur = 6;
                } else if (casesGreen.Contains(n))
                {
                    tmp.BackColor = Color.Green;
                    //tmp.Tag = "green";
                    couleur = 7;
                } else if (casesBrown.Contains(n))
                {
                    tmp.BackColor = Color.SaddleBrown;
                    //tmp.Tag = "brown";
                    couleur = 8;
                }
                
                if (n < 8 || n > 55)
                {
                    PictureBox pic = new PictureBox();
                    //pic.Parent = tmp;
                    pic.Visible = true;
                    pic.Size = new Size(45, 45);
                    board.Controls.Add(pic);
                    pic.Location = new Point(colonne + 2, ligne + 2);
                    pic.BringToFront();
                    pic.BackColor = tmp.BackColor;
                    //MessageBox.Show("Couleur du fond : " + tmp.BackColor, "Couleur du fond");
                    pic.Image = imageList1.Images[index_list];
                    index_list++;
                    occupee = true;
                }
                colonne += 52;

                //Création de la nouvelle case et ajout au tableau du plateau
                Case neuve = new Case(couleur, n, occupee);
                plateau[n] = neuve;

                                if (n < 8)
                {
                    Pion tour = new Pion(1, couleur, neuve);
                    tours[index_list - 1] = tour;
                }
                else if (n > 55)
                {
                    Pion tour = new Pion(0, couleur, neuve);
                    tours[index_list - 1] = tour;
                }  
            }

            //for (int i = 0; i<64; i++)
            //{
            //    MessageBox.Show(plateau[i].toString());
            //    if (i < 16)
            //    {
            //        MessageBox.Show(tours[i].toString());
            //    }
            //}
        }

        //gestion de l'évènement tick du timer du Joueur 1
        private void timerJ1_Tick(object sender, EventArgs e)
        {
            progressbarJ1.Value--;
            chronoJ1.Text = string.Format("{0:00}:{1:00}", Convert.ToInt16(progressbarJ1.Value / 60), Convert.ToInt16(progressbarJ1.Value % 60));
        }

        //gestion de l'évènement tick du timer du Joueur 2
        private void timerJ2_Tick(object sender, EventArgs e)
        {
            progressbarJ2.Value--;
            chronoJ2.Text = string.Format("{0:00}:{1:00}", Convert.ToInt16(progressbarJ2.Value / 60), Convert.ToInt16(progressbarJ2.Value % 60));
        }


    }
}
