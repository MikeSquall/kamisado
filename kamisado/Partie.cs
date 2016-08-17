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
        List<int> casesOrange = new List<int> { 0, 9, 18, 27, 36, 45, 54, 63 };
        List<int> casesBlue = new List<int> { 1, 12, 23, 26, 37, 40, 51, 62 };
        List<int> casesViolet = new List<int> { 2, 15, 20, 25, 38, 43, 48, 61 };
        List<int> casesPink = new List<int> { 3, 10, 17, 24, 39, 46, 53, 60 };
        List<int> casesYellow = new List<int> { 4, 13, 22, 31, 32, 41, 50, 59 };
        List<int> casesRed = new List<int> { 5, 8, 19, 30, 33, 44, 55, 58 };
        List<int> casesGreen = new List<int> { 6, 11, 16, 29, 34, 47, 52, 57 };
        List<int> casesBrown = new List<int> { 7, 14, 21, 28, 35, 42, 49, 56 };
        Pion tourDeplacee;
        Case caseDepart;
        Plateau plateau;
        //int num_joueur = 0;
        Joueur joueurActif;

        public Partie()
        {
            InitializeComponent();
            this.nomJoueur1.Text = Accueil.J1.getNom();
            this.nomJoueur2.Text = Accueil.J2.getNom();
            this.scoreJ1.Text = Convert.ToString(Accueil.J1.getPoints()) + " Point";
            this.scoreJ2.Text = Convert.ToString(Accueil.J2.getPoints()) + " Point";
            this.picJ1.BackColor = Color.Black;
            this.picJ2.BackColor = Color.White;
            /*définition des valeurs des chronos selon le choix de l'utilisateur*/
            progressbarJ1.Value = Accueil.J1.getTime();
            progressbarJ1.Maximum = progressbarJ1.Value;
            progressbarJ2.Value = Accueil.J1.getTime();
            progressbarJ2.Maximum = progressbarJ2.Value;
            /*formatage de l'affichage du chrono*/
            chronoJ1.Text = string.Format("{0:00}:{1:00}", Convert.ToInt16(progressbarJ1.Value / 60), Convert.ToInt16(progressbarJ1.Value % 60));
            chronoJ2.Text = string.Format("{0:00}:{1:00}", Convert.ToInt16(progressbarJ2.Value / 60), Convert.ToInt16(progressbarJ2.Value % 60));
            timerJ1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int ligne = 0,
                colonne = 0,
                index_list = 0,
                num_color = -1;
            Case[] tabCases = new Case[64];
            Pion[] tabPions = new Pion[16];

            board.BringToFront();
            for (int n = 0; n < 64; n++)
            {
                if (n % 8 == 0 && n != 0)
                {
                    ligne += 52;
                    colonne = 0;
                }

                Label tmp = new Label();
                tmp.Name = Convert.ToString(n);
                tmp.Size = new Size(50, 50);
                board.Controls.Add(tmp);
                tmp.Location = new Point(colonne, ligne);
                //tmp.BorderStyle = BorderStyle.FixedSingle;
                //tmp.Text = Convert.ToString(n); // sert aux tests de génération du plateau
                tmp.DragEnter += new DragEventHandler(survol_cases);
                tmp.DragDrop += new DragEventHandler(depose_case);
                
                if (casesOrange.Contains(n))
                {
                    tmp.BackColor = Color.Orange;
                    tmp.Tag = 0; /*orange*/
                    num_color = 0;
                }
                else if (casesBlue.Contains(n))
                {
                    tmp.BackColor = Color.CornflowerBlue;
                    tmp.Tag = 1; /*blue*/ 
                    num_color = 1;
                }
                else if (casesViolet.Contains(n))
                {
                    tmp.BackColor = Color.DarkOrchid;
                    tmp.Tag = 2; /*violet*/;
                    num_color = 2;
                }
                else if (casesPink.Contains(n))
                {
                    tmp.BackColor = Color.HotPink;
                    tmp.Tag = 3; /*pink*/;
                    num_color = 3;
                }
                else if (casesYellow.Contains(n))
                {
                    tmp.BackColor = Color.Yellow;
                    tmp.Tag = 4; /*yellow*/
                    num_color = 4;
                }
                else if (casesRed.Contains(n))
                {
                    tmp.BackColor = Color.Crimson;
                    tmp.Tag = 5; /*red*/
                    num_color = 5;
                }
                else if (casesGreen.Contains(n))
                {
                    tmp.BackColor = Color.Green;
                    tmp.Tag = 6; /*green*/
                    num_color = 6;
                }
                else if (casesBrown.Contains(n))
                {
                    tmp.BackColor = Color.SaddleBrown;
                    tmp.Tag = 7; /*brown*/
                    num_color = 7;
                }
                Case c = new Case(num_color, n, false);
                tabCases[n] = c;

                if (n < 8 || n > 55)
                {
                    c.setOccupe();
                    PictureBox pic = new PictureBox();
                    pic.Visible = true;
                    pic.Size = new Size(45, 45);
                    board.Controls.Add(pic);
                    pic.Location = new Point(colonne + 2, ligne + 2);
                    pic.BringToFront();
                    pic.BackColor = tmp.BackColor;
                    //MessageBox.Show("Couleur du fond : " + tmp.BackColor, "Couleur du fond");
                    pic.Image = imageList1.Images[index_list];
                    pic.Tag = Convert.ToString(index_list);

                    /*branchement de l'évènement clic_souris uniquement sur les pions noirs dans un premier temps*/
                    if (n > 55)
                    {
                        pic.MouseDown += new MouseEventHandler(clic_souris);
                    }

                    // création d'une instance de Pion
                    int teamPion = -1, couleurPion = -1;
                    switch (index_list)
                    {
                        case 0:
                            teamPion = 1;
                            couleurPion = 0;
                            break;
                        case 1:
                            teamPion = 1;
                            couleurPion = 1;
                            break;
                        case 2:
                            teamPion = 1;
                            couleurPion = 2;
                            break;
                        case 3:
                            teamPion = 1;
                            couleurPion = 3;
                            break;
                        case 4:
                            teamPion = 1;
                            couleurPion = 4;
                            break;
                        case 5:
                            teamPion = 1;
                            couleurPion = 5;
                            break;
                        case 6:
                            teamPion = 1;
                            couleurPion = 6;
                            break;
                        case 7:
                            teamPion = 1;
                            couleurPion = 7;
                            break;
                        case 8:
                            teamPion = 0;
                            couleurPion = 7;
                            break;
                        case 9:
                            teamPion = 0;
                            couleurPion = 6;
                            break;
                        case 10:
                            teamPion = 0;
                            couleurPion = 5;
                            break;
                        case 11:
                            teamPion = 0;
                            couleurPion = 4;
                            break;
                        case 12:
                            teamPion = 0;
                            couleurPion = 3;
                            break;
                        case 13:
                            teamPion = 0;
                            couleurPion = 2;
                            break;
                        case 14:
                            teamPion = 0;
                            couleurPion = 1;
                            break;
                        case 15:
                            teamPion = 0;
                            couleurPion = 0;
                            break;
                    }
                    Pion p = new Pion(teamPion, couleurPion, index_list, c);
                    tabPions[index_list] = p;
                    index_list++;
                }

                colonne += 52;

            }
            plateau = new Plateau(tabCases, tabPions);
            joueurActif = Accueil.J1;
        }

        private void timerJ1_Tick(object sender, EventArgs e)
        {
            if (joueurActif.getCouleurPions() == 0)
            {
                Accueil.J1.setTime();
                progressbarJ1.Value = Accueil.J1.getTime();
                chronoJ1.Text = string.Format("{0:00}:{1:00}", Convert.ToInt16(progressbarJ1.Value / 60), Convert.ToInt16(progressbarJ1.Value % 60));
                dragonNoir.Visible = true;
                dragonBlanc.Visible = false;
            }
            else
            {
                Accueil.J2.setTime();
                progressbarJ2.Value = Accueil.J2.getTime();
                chronoJ2.Text = string.Format("{0:00}:{1:00}", Convert.ToInt16(progressbarJ2.Value / 60), Convert.ToInt16(progressbarJ2.Value % 60));
                dragonNoir.Visible = false;
                dragonBlanc.Visible = true;
            }

        }

        /*au clic de la souris, on récupère la picturebox sender*/
        private void clic_souris(object sender, MouseEventArgs e)
        {
            pic_temp = (PictureBox)sender;

            tourDeplacee = plateau.getPion(Convert.ToInt32(pic_temp.Tag));
            caseDepart = tourDeplacee.getPosition();
            List<int> cibles = plateau.deplacementOk(tourDeplacee, caseDepart);
            //var message = string.Join(Environment.NewLine, cibles);
            //MessageBox.Show(message);

            /*on désactive allow drop sur toutes les labels avant de le permettre uniquement sur les bons labels*/
            foreach (Control lab in board.Controls)
            {
                lab.AllowDrop = false;
            }

            foreach (Control c in board.Controls)
            {
                if (c is Label && cibles.Contains(Convert.ToInt32(c.Name)))
                {
                    c.AllowDrop = true;
                    //MessageBox.Show("Case n°:" + c.Name, "debug");
                }
            }
            plateau.getCase(caseDepart.getNumCase()).setNonOccupe();

            pic_temp.DoDragDrop("kamisado", DragDropEffects.Copy);
        }

        /*gestion du survol*/
        private void survol_cases(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        /*gestion du dépôt de la picturebox*/
        private void depose_case(object sender, DragEventArgs e)
        {
            Label lab = (Label)sender;
            PictureBox nvelle_tour = new PictureBox();
            nvelle_tour = pic_temp;
            nvelle_tour.Location = new Point(lab.Location.X + 2, lab.Location.Y + 2);
            nvelle_tour.BackColor = lab.BackColor;
            board.Controls.Add(nvelle_tour);
            nvelle_tour.Visible = true;
            nvelle_tour.BringToFront();
            plateau.getCase(Convert.ToInt32(lab.Name)).setOccupe();
            //MessageBox.Show("Etat de la case :" + plateau.getCase(Convert.ToInt32(lab.Name)).getOccupe());
            plateau.getPion(tourDeplacee.getNumPion()).setPosition(plateau.getCase(Convert.ToInt32(lab.Name)));

            // affichage du coup joué
            Coup coupJoue = new Coup(joueurActif, tourDeplacee, plateau.getCase(Convert.ToInt32(lab.Name)));
            listeCoups.Text += coupJoue.afficheCoup();

            /*on récupère l'index de la prochaine tour(picturebox) qui devra être jouée*/
            int index = Convert.ToInt16(lab.Tag);
            
            if (joueurActif.getCouleurPions() == 1)
            {
                index = 7 + (8 - index); /*si le joueur actif est celui avec les tours blanches, on rajoute la différence entre 8 et l'index à cause de la symétrie inverse*/
                joueurActif = Accueil.J1; ; /*on passe la main au joueur avec les tours noires*/
                timerJ2.Enabled = false; /*on arrête le chrono du joueur avec les tours blanches*/
                timerJ1.Enabled = true; /*on active le chrono du joueur avec les tours noires*/
            }
            else
            {
                joueurActif = Accueil.J2; /*on passe la main au joueur avec les tours blanches*/
                timerJ1.Enabled = false;
                timerJ2.Enabled = true;
            }

            // cas spécifique du blocage, on passe le tour du joueur dont le pion est bloqué
            if (this.pionBloque(index))
            {
                int casePionBloque = plateau.getPion(index).getPosition().getNumCase();
                int couleurCasePionBloque = plateau.getCase(casePionBloque).getCouleurNum();
                // on affiche un message et on change de joueur
                if (joueurActif.getCouleurPions() == 1)
                {
                    Coup coup = new Coup(joueurActif);
                    listeCoups.Text += coup.blocage();
                    joueurActif = Accueil.J1;
                    // on indique l'indice du pion qui récupère la main
                    index = 7 + (8 - couleurCasePionBloque);
                }
                else
                {
                    Coup coup = new Coup(joueurActif);
                    listeCoups.Text += coup.blocage();
                    joueurActif = Accueil.J2;
                    index = couleurCasePionBloque;
                }
            }
            
            /*on débranche le clic_souris de toutes les picturebox et on branche la picturebox qui devra être jouée au prochain tour*/
            foreach (Control ctrl in board.Controls)
            {
                if (ctrl is PictureBox && Convert.ToInt16(ctrl.Tag) != index)
                {
                    ctrl.MouseDown -= new MouseEventHandler(clic_souris);
                }
                else
                {
                    ctrl.MouseDown += new MouseEventHandler(clic_souris);
                }
            }
        }

        // test du blocage d'un pion
        private bool pionBloque(int index)
        {
            Pion p = plateau.getPion(index);
            Case c = p.getPosition();
            List<int> cibles = plateau.deplacementOk(p, c);

            if(cibles.Count() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // menu 'aide' => 'but du jeu"
        private void butJeu_Click(object sender, EventArgs e)
        {
            infos but = new infos();
            but.setOngletActif(0);
            but.ShowDialog();
        }

        // menu 'aide' => "règles partie simple"
        private void partieSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            infos regSimple = new infos();
            regSimple.setOngletActif(1);
            regSimple.ShowDialog();
        }

        // menu 'aide' => "règles partie complexe"
        private void partieComplexeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            infos regComplexe = new infos();
            regComplexe.setOngletActif(2);
            regComplexe.ShowDialog();
        }

        // menu 'Jeu' => "quitter partie"
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String titre = "Confirmation",
                   msg = "Êtes-vous sûr de vouloir quitter ?";
            DialogResult reponse;
            reponse = MessageBox.Show(msg,titre,MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(reponse == DialogResult.Yes)
            {
                // penser à rajouter proposition de sauvegarde si partie non sauvegardée
                this.Close();
            }
        }
    }
}
