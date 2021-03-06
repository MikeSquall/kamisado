﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*Le code est organisé de la façon suivate:
    - Création du plateau
    - Gestion de la fin de partie par fin du temps
    - Gestion de la fin de partie classique
    - Gestion de la fin de partie par impasse totale
    - Procédures/Fonctions pour la gestion de la partie complexe
    - Gestion du Drag & Drop
    - Gestion des timers
    - Gestion des menus déroulants
    - Procédures/Fonctions de debug
*/

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
        /*liste des cases de la ligne de départ pour chaque joueur*/
        List<int> casesDepartBlanches = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7 };
        List<int> casesDepartNoires = new List<int> { 56, 57, 58, 59, 60, 61, 62, 63 };

        Pion tourDeplacee;
        Case caseDepart;
        Plateau plateau;
        Joueur joueurActif;
        PictureBox tourAjouer;
        bool partie_terminee = false;

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
            /*initialisation de la couleur du dragon*/
            dragonNoir.Visible = true;
            dragonBlanc.Visible = false;
        }



        /********************************************************************************************************************************************************************************************/
        /*****************************************************************************Création du plateau********************************************************************************************/
        /********************************************************************************************************************************************************************************************/

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
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
                    pic.Name = Convert.ToString(index_list);
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
                        pic.Cursor = Cursors.Hand;
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
            listeCoups.Text += Accueil.J1.getNom() + " peut jouer la tour de son choix" + Environment.NewLine;

            /*On crée un deuxième plateau pour voir le debug: le but est de pouvoir visualiser après chaque coup la situation du plateau afin de s'assurer que tout est OK*/
            /*penser à décommenter la ligne 887 plateau_temps_reel()*/
            //groupBox1.Visible = true;
            //groupBox1.BringToFront();
            //groupBox1.Size = new Size(420, 420);
            //groupBox1.Location = new Point(977, 85);
            //groupBox1.Text = "Etat du plateau en temps réel";
            //this.Width = 1418;
            //int x = 0, y = 0;
            //for (int i = 0; i < 64; i++)
            //{
            //    if (i % 8 == 0 && i != 0)
            //    {
            //        x += 52;
            //        y = 0;
            //    }

            //    Label tmp = new Label();
            //    tmp.Name = Convert.ToString(i);
            //    tmp.Size = new Size(50, 50);
            //    groupBox1.Controls.Add(tmp);
            //    tmp.Location = new Point(y, x);
            //    tmp.BorderStyle = BorderStyle.Fixed3D;
            //    tmp.Tag = Convert.ToString(i);
            //    //tmp.Text = Convert.ToString(i);
            //    if (i < 8 || i > 55)
            //    {
            //        tmp.Text = "X";
            //    }

            //    y += 52;
            //}
        }

        /********************************************************************************************************************************************************************************************/
        /*****************************************************************************Gestion de la fin de partie par fin du temps*******************************************************************/
        /********************************************************************************************************************************************************************************************/

        /*gestion de la fin de partie par fin du temps*/
        private bool fin_partie_temps()
        {
            /*gestion de la fin de partie par fin de chrono*/
            bool flag = false;

            if (joueurActif.getCouleurPions() == 0)
            {
                if (progressbarJ1.Value == 0)
                {
                    timerJ1.Enabled = false;
                    timerJ2.Enabled = false;
                    timer1.Enabled = false;
                    partie_terminee = true;
                    Accueil.J2.setPoints();
                    scoreJ2.Text = Convert.ToString(Accueil.J2.getPoints()) + " point";
                    listeCoups.Text += Accueil.J2.getNom() + " a gagné!";
                    MessageBox.Show(Accueil.J2.getNom() + " a gagné, Bravo!", "Nous avons un vainqueur!");
                    /*on débranche le clic_souris*/
                    foreach (Control ctrl in board.Controls)
                    {
                        if (ctrl is PictureBox)
                        {
                            ctrl.MouseDown -= new MouseEventHandler(clic_souris);
                        }
                    }

                    flag = true;
                }
            }
            else
            {
                if (progressbarJ2.Value == 0)
                {
                    timerJ1.Enabled = false;
                    timerJ2.Enabled = false;
                    timer1.Enabled = false;
                    partie_terminee = true;
                    Accueil.J1.setPoints();
                    scoreJ1.Text = Convert.ToString(Accueil.J1.getPoints()) + " point";
                    listeCoups.Text += Accueil.J1.getNom() + " a gagné!";
                    MessageBox.Show(Accueil.J1.getNom() + " a gagné, Bravo!", "Nous avons un vainqueur!");
                    /*on débranche le clic_souris*/
                    foreach (Control ctrl in board.Controls)
                    {
                        if (ctrl is PictureBox)
                        {
                            ctrl.MouseDown -= new MouseEventHandler(clic_souris);
                        }
                    }

                    flag = true;
                }
            }

            //check_si_partie_complexe();

            return flag;
        }


        /********************************************************************************************************************************************************************************************/
        /*****************************************************************************Gestion de la fin de partie classique**************************************************************************/
        /********************************************************************************************************************************************************************************************/
        
            /*gestion de la fin de partie classique*/
        private bool fin_partie_classique(int num_case)
        {
            /*fin de partie si :
                - l'un des joueurs a placé sa tour sur la ligne de départ de l'autre
                - en cas de déplacement impossible pour les deux joueurs --> à gérer plus tard            
            */
            bool flag = false;

            if (joueurActif.getCouleurPions() == 0) // joueur Noir marque
            {
                if (casesDepartBlanches.Contains(num_case))
                {
                    timerJ1.Enabled = false;
                    timerJ2.Enabled = false;
                    partie_terminee = true;
                    //MessageBox.Show("Numéro de case A: " + num_case);
                    if (plateau.getPion(Convert.ToInt16(tourAjouer.Tag)).getPouvoir() == 1)
                    {
                        /*si la tour qui marque est sumo, alors le joueur marque 2 points*/
                        Accueil.J1.setPoints();
                        Accueil.J1.setPoints();
                    }
                    else
                    {
                        /*sinon, c'est un seul point*/
                        Accueil.J1.setPoints();
                    }
                    /*la tour devient sumo*/
                    plateau.getPion(Convert.ToInt16(tourAjouer.Tag)).setPouvoir(1); /*1 = tour sumo*/
                    /*ça serait dommage d'avoir des fotes dortograf non??*/
                    if (Accueil.J1.getPoints() < 2)
                    {
                        scoreJ1.Text = Convert.ToString(Accueil.J1.getPoints()) + " point";
                    }
                    else
                    {
                        scoreJ1.Text = Convert.ToString(Accueil.J1.getPoints()) + " points";
                    }

                    listeCoups.Text += Accueil.J1.getNom() + " a gagné!";
                    MessageBox.Show(Accueil.J1.getNom() + " a gagné, Bravo!", "Nous avons un vainqueur!");
                    timer1.Enabled = false;
                    flag = true;
                    /*on débranche le clic_souris*/
                    foreach (Control ctrl in board.Controls)
                    {
                        if (ctrl is PictureBox)
                        {
                            ctrl.MouseDown -= new MouseEventHandler(clic_souris);
                        }
                    }
                }
            }
            else if (joueurActif.getCouleurPions() == 1) // joueur Blanc marque
            {
                if (casesDepartNoires.Contains(num_case))
                {
                    timerJ1.Enabled = false;
                    timerJ2.Enabled = false;
                    partie_terminee = true;
                    //MessageBox.Show("Numéro de case B: " + num_case);
                    if (plateau.getPion(Convert.ToInt16(tourAjouer.Tag)).getPouvoir() == 1)
                    {
                        /*si la tour qui marque est sumo, alors le joueur marque 2 points*/
                        Accueil.J2.setPoints();
                        Accueil.J2.setPoints();
                    }
                    else
                    {
                        /*sinon, c'est un seul point*/
                        Accueil.J2.setPoints();
                    }
                    /*la tour devient sumo*/
                    plateau.getPion(Convert.ToInt16(tourAjouer.Tag)).setPouvoir(1); /*1 = tour sumo*/
                    /*on évite les fautes d'ortographe, ça fait toujours plus sérieux ;) */
                    if (Accueil.J2.getPoints() < 2)
                    {
                        scoreJ2.Text = Convert.ToString(Accueil.J2.getPoints()) + " point";
                    }
                    else
                    {
                        scoreJ2.Text = Convert.ToString(Accueil.J2.getPoints()) + " points";
                    }

                    listeCoups.Text += Accueil.J2.getNom() + " a gagné!";
                    MessageBox.Show(Accueil.J2.getNom() + " a gagné, Bravo!", "Nous avons un vainqueur!");
                    timer1.Enabled = false;
                    flag = true;
                    /*on débranche le clic_souris*/
                    foreach (Control ctrl in board.Controls)
                    {
                        if (ctrl is PictureBox)
                        {
                            ctrl.MouseDown -= new MouseEventHandler(clic_souris);
                        }
                    }
                }
            }

            if (flag == true)
            {
                check_si_partie_complexe();
            }

            return flag;
        }

        /********************************************************************************************************************************************************************************************/
        /*****************************************************************************Gestion de la fin de partie par impasse totale*****************************************************************/
        /********************************************************************************************************************************************************************************************/

        // fin de partie suite à impasse totale
        private void finPartieImpasseTotale(Pion p)
        {
            timerJ1.Enabled = false;
            timerJ2.Enabled = false;
            timer1.Enabled = false;
            if (p.getEquipe() == 0)
            {
                Accueil.J2.setPoints();
                if (Accueil.J2.getPoints() > 1)
                {
                    scoreJ2.Text = Convert.ToString(Accueil.J2.getPoints()) + " points";
                }
                else
                {
                    scoreJ2.Text = Convert.ToString(Accueil.J2.getPoints()) + " point";
                }

                listeCoups.Text += Accueil.J2.getNom() + " a gagné!";
                MessageBox.Show(Accueil.J2.getNom() + " a gagné, Bravo!", "Nous avons un vainqueur!");
            }
            else
            {
                Accueil.J1.setPoints();
                if (Accueil.J1.getPoints() > 1)
                {
                    scoreJ1.Text = Convert.ToString(Accueil.J1.getPoints()) + " points";
                }
                else
                {
                    scoreJ1.Text = Convert.ToString(Accueil.J1.getPoints()) + " point";
                }
                listeCoups.Text += Accueil.J1.getNom() + " a gagné!";
                MessageBox.Show(Accueil.J1.getNom() + " a gagné, Bravo!", "Nous avons un vainqueur!");
            }

            check_si_partie_complexe();
        }

        // test du blocage d'un pion
        private bool pionBloque(int index)
        {
            Pion p = plateau.getPion(index);
            Case c = p.getPosition();
            List<int> cibles = plateau.deplacementOk(p, c);

            if (cibles.Count() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /********************************************************************************************************************************************************************************************/
        /*****************************************************************************Procédures/Fonctions Partie complexe***************************************************************************************/
        /********************************************************************************************************************************************************************************************/

        /*traitements communs aux procédures/fonctions de fin de partie*/
        private void check_si_partie_complexe()
        {
            /*si la partie est de type complexe alors on continue de jouer*/
            if (Accueil.partie_complexe == true)
            {
                bool fin_partie = false;

                if(Accueil.J1.getPoints() >= 3 || Accueil.J2.getPoints() >= 3)
                {
                	fin_partie = true;
                	MessageBox.Show(joueurActif.getNom() + " gagne la partie! Félicitations", "Nous avons notre champion");
                }

                if (fin_partie == false)
                {
                    //MessageBox.Show("Debug 4 : on continue de jouer");
                    /*on replace les tours*/
                    partie_terminee = false;
                    replace_tours();
                    //check_pouvoir();
                    listeCoups.Text += Environment.NewLine + "Nouvelle manche : ";
                    if (joueurActif.getCouleurPions() == 0) /*si joueur avec tours noires a gagné*/
                    {
                        joueurActif = Accueil.J2;
                        foreach (Control c in board.Controls)
                        {
                            if (c is PictureBox && Convert.ToInt16(c.Tag) < 8)
                            {
                                c.MouseDown += new MouseEventHandler(clic_souris);
                            }
                        }
                        listeCoups.Text += Accueil.J2.getNom() + " prend la main" + Environment.NewLine;
                        listeCoups.Text += Accueil.J2.getNom() + " peut jouer la tour de son choix" + Environment.NewLine;
                        timerJ2.Enabled = true;
                        timer1.Enabled = true;
                        dragonBlanc.Visible = true;
                        dragonNoir.Visible = false;
                    }
                    else
                    {
                        joueurActif = Accueil.J1;
                        foreach (Control c in board.Controls)
                        {
                            if (c is PictureBox && Convert.ToInt16(c.Tag) > 7)
                            {
                                c.MouseDown += new MouseEventHandler(clic_souris);
                            }
                        }
                        listeCoups.Text += Accueil.J1.getNom() + " prend la main" + Environment.NewLine;
                        listeCoups.Text += Accueil.J1.getNom() + " peut jouer la tour de son choix" + Environment.NewLine;
                        timerJ1.Enabled = true;
                        timer1.Enabled = true;
                        dragonNoir.Visible = true;
                        dragonBlanc.Visible = false;
                    }
                }
            }
        }

        
        /*procédure de replacement des tours pour la partie complexe*/
        private void replace_tours()
        {
            int depart = 7;
            //int depart = 0;
            Pion[] tabPions_replace = new Pion[16];

            //MessageBox.Show("Debug0 : début traitement tours blanches");
            /*on traite d'abord les tours blanches*/
            for (int i = 63; i > 0; i -= 8)
            {
                for (int j = i; j > i - 8; j--)
                {
                    //MessageBox.Show("i = " + i +", j = "+j);
                    if (plateau.getCase(j).getOccupe() == true)
                    {
                        //MessageBox.Show("Case occupée est : " + plateau.getCase(j).getNumCase());
                        for (int k = 0; k < 16; k++)/*on teste tous les pions pour trouver le bon*/
                        {
                            if (plateau.getPion(k).getPosition().getNumCase() == j && plateau.getPion(k).getEquipe() == 1)
                            {
                                //MessageBox.Show("Case occupée est : " + plateau.getCase(j).getNumCase() + ", sa couleur est :"+plateau.getCase(j).getCouleur());
                                //MessageBox.Show("Le pion qui s'y trouve est de couleur : " + plateau.getPion(k).getCouleurPion());
                                /*on range la tour dans le tableau des cases à replacer*/
                                tabPions_replace[depart] = plateau.getPion(k);
                                tabPions_replace[depart].setNumPion(depart);
                                //tabPions_replace[depart].setPosition(plateau.getCase(depart));
                                depart--;
                            }
                        }
                    }
                }
            }

            //MessageBox.Show("Debug1 : fin traitement des tours blanches");

            depart = 8;
            //MessageBox.Show("Debug2 : debut traitement tours noires");

            /*on traite ensuite les tours noires*/
            for (int i = 0; i < 64; i += 8)
            {
                for (int j = i; j < i + 8; j++)
                {
                    //MessageBox.Show("i = " + i + ", j = " + j);
                    if (plateau.getCase(j).getOccupe() == true)
                    {
                        for (int k = 0; k < 16; k++)/*on teste tous les pions*/
                        {
                            if (plateau.getPion(k).getPosition().getNumCase() == j && plateau.getPion(k).getEquipe() == 0)
                            {
                                //MessageBox.Show("Case occupée est : " + plateau.getCase(j).getNumCase() + ", sa couleur est :" + plateau.getCase(j).getCouleur());
                                //MessageBox.Show("Le pion qui s'y trouve est de couleur : " + plateau.getPion(k).getCouleurPion());
                                /*on range la tour dans le tableau des cases à replacer*/
                                tabPions_replace[depart] = plateau.getPion(k);
                                tabPions_replace[depart].setNumPion(depart);
                                depart++;
                            }
                        }
                    }
                }
            }

            //MessageBox.Show("Debug3 : fin traitement tours noires");

            /*on set toutes les cases du plateau à non_occupée*/
            for (int i = 0; i < 64; i++)
            {
                plateau.getCase(i).setNonOccupe();
            }

            /*une fois les tours correctement placées dans le tableau temporaire, on les replace dans le tableau principal*/
            /*on réutilise la variable "depart" pour ne pas en créer une nouvelle*/
            depart = 0;
            plateau.setPion(tabPions_replace);
            for (int i = 0; i < 16; i++)
            {

                plateau.getCase(depart).setOccupe();/*on set la case ocupée*/
                //tabPions_replace[i].setPosition(plateau.getCase(depart));
                plateau.getPion(i).setPosition(plateau.getCase(depart));
                depart++;

                ///*on test pour passer à l'autre extrémité du plateau*/
                if (i == 7)
                {
                    depart = 56;
                }
            }

            //MessageBox.Show("Debug4 : fin du replacement des tours dans le nouvel ordre");

            /*on supprime les picturebox des tours dans le panel board*/
            for (int i = board.Controls.Count - 1; i >= 0; i--)
            {
                if (board.Controls[i] is PictureBox)
                {
                    board.Controls[i].Dispose();
                }
            }


            //MessageBox.Show("Debug5 : fin de la suppression des picturebox");
            int ligne = 0,
                colonne = 0;

            depart = 0;
            /*on les replace dans le nouvel ordre*/
            for (int i = 0; i < 8; i++)
            {
                PictureBox pic = new PictureBox();
                pic.Visible = true;
                pic.Name = Convert.ToString(plateau.getPion(depart).getIndex());
                pic.Size = new Size(45, 45);
                board.Controls.Add(pic);
                pic.Location = new Point(colonne + 2, ligne + 2);
                pic.BringToFront();
                /*on adapte le fond de la picturebox*/
                if (casesOrange.Contains(i))
                {
                    pic.BackColor = Color.Orange;
                }
                else if (casesBlue.Contains(i))
                {
                    pic.BackColor = Color.CornflowerBlue;
                }
                else if (casesViolet.Contains(i))
                {
                    pic.BackColor = Color.DarkOrchid;
                }
                else if (casesPink.Contains(i))
                {
                    pic.BackColor = Color.HotPink;
                }
                else if (casesYellow.Contains(i))
                {
                    pic.BackColor = Color.Yellow;
                }
                else if (casesRed.Contains(i))
                {
                    pic.BackColor = Color.Crimson;
                }
                else if (casesGreen.Contains(i))
                {
                    pic.BackColor = Color.Green;
                }
                else if (casesBrown.Contains(i))
                {
                    pic.BackColor = Color.SaddleBrown;
                }
                //MessageBox.Show("Couleur du fond : " + tmp.BackColor, "Couleur du fond");
                /*on sélectionne la bonne picturebox selon le pouvoir du pion*/
                if (plateau.getPion(i).getPouvoir() == 1)
                {
                    pic.Image = imageList2.Images[plateau.getPion(i).getIndex()];
                }
                else
                {
                    pic.Image = imageList1.Images[plateau.getPion(i).getIndex()];
                }
                //pic.Tag = Convert.ToString(i);
                pic.Tag = Convert.ToString(plateau.getPion(depart).getNumPion());
                //MessageBox.Show("En case " + depart + " se trouve le pion : " + plateau.getPion(depart).getCouleurPion());
                //MessageBox.Show("Son tag est : " + Convert.ToString(plateau.getPion(depart).getNumPion()) + " et son indice est : " + plateau.getPion(i).getIndex());
                colonne += 52;
                depart++;
            }

            //MessageBox.Show("Debug6 : fin replacement picturebox tours blanches");

            ligne = 364;
            colonne = 0;
            depart = 8; /*afin d'éviter de créer une variable, on réutilise la variable "départ" pour prendre les bonnes images depuis l'imagelist1*/

            /*on les replace dans le nouvel ordre*/
            for (int i = 56; i < 64; i++)
            {
                PictureBox pic = new PictureBox();
                pic.Visible = true;
                pic.Name = Convert.ToString(plateau.getPion(depart).getIndex());
                pic.Size = new Size(45, 45);
                board.Controls.Add(pic);
                pic.Location = new Point(colonne + 2, ligne + 2);
                pic.BringToFront();
                /*on adapte le fond de la picturebox*/
                if (casesOrange.Contains(i))
                {
                    pic.BackColor = Color.Orange;
                }
                else if (casesBlue.Contains(i))
                {
                    pic.BackColor = Color.CornflowerBlue;
                }
                else if (casesViolet.Contains(i))
                {
                    pic.BackColor = Color.DarkOrchid;
                }
                else if (casesPink.Contains(i))
                {
                    pic.BackColor = Color.HotPink;
                }
                else if (casesYellow.Contains(i))
                {
                    pic.BackColor = Color.Yellow;
                }
                else if (casesRed.Contains(i))
                {
                    pic.BackColor = Color.Crimson;
                }
                else if (casesGreen.Contains(i))
                {
                    pic.BackColor = Color.Green;
                }
                else if (casesBrown.Contains(i))
                {
                    pic.BackColor = Color.SaddleBrown;
                }
                /*on sélectionne la bonne picturebox selon le pouvoir du pion*/
                if (plateau.getPion(depart).getPouvoir() == 1)
                {
                    pic.Image = imageList2.Images[plateau.getPion(depart).getIndex()];
                }
                else
                {
                    pic.Image = imageList1.Images[plateau.getPion(depart).getIndex()];
                }
                pic.Tag = Convert.ToString(plateau.getPion(depart).getNumPion());
                colonne += 52;
                //MessageBox.Show("En case " + depart + " se trouve le pion : " + plateau.getPion(depart).getCouleurPion());
                //MessageBox.Show("Son tag est : " + Convert.ToString(plateau.getPion(depart).getNumPion()) + " et son indice est : " + plateau.getPion(depart).getIndex());
                depart++;
            }
        }


        /********************************************************************************************************************************************************************************************/
        /*****************************************************************************Gestion du Drag and Drop***************************************************************************************/
        /********************************************************************************************************************************************************************************************/

        /*au clic de la souris, on récupère la picturebox sender*/
        private void clic_souris(object sender, MouseEventArgs e)
        {
            pic_temp = (PictureBox)sender;
            timer1.Enabled = false;
            tourDeplacee = plateau.getPion(Convert.ToInt32(pic_temp.Tag));
            caseDepart = tourDeplacee.getPosition();
            List<int> cibles = plateau.deplacementOk(tourDeplacee, caseDepart);
            //var message = string.Join(Environment.NewLine, cibles);
            //MessageBox.Show(message);

            /*on désactive allow drop sur toutes les labels avant de le permettre uniquement sur les bons labels*/
            foreach (Control c in board.Controls)
            {
                c.AllowDrop = false;
                //c.Text = "";
            }

            foreach (Control c in board.Controls)
            {
                if (c is Label && cibles.Contains(Convert.ToInt32(c.Name)))
                {
                    if (plateau.getCase(Convert.ToInt32(c.Name)).getOccupe() == false)
                    {
                        c.AllowDrop = true;
                        //c.Text = "X";
                        //MessageBox.Show("Case n°:" + c.Name, "debug");
                    }
                    else
                    {
                        for (int i = 0; i < board.Controls.Count - 1; i++)
                        {
                            if (board.Controls[i] is PictureBox)
                            {
                                if (plateau.getPion(Convert.ToInt16(board.Controls[i].Tag)).getNumTag(Convert.ToInt16(c.Name)) == Convert.ToInt16(board.Controls[i].Tag))
                                {
                                    board.Controls[i].DragEnter += new DragEventHandler(survol_cases);
                                    board.Controls[i].DragDrop += new DragEventHandler(depose_case);
                                    board.Controls[i].AllowDrop = true;
                                }
                            }
                        }
                    }
                }
            }

            pic_temp.DoDragDrop("kamisado", DragDropEffects.Copy);

            if (partie_terminee == false)
            {
                timer1.Enabled = true;
            }

            //plateau_temps_reel();
            //MessageBox.Show("Debug : fin branchement des évènements", "debug");
        }

        /*gestion du survol*/
        private void survol_cases(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        /*gestion du dépôt de la picturebox*/
        private void depose_case(object sender, DragEventArgs e)
        {
            if (sender is Label)
            {
                Label lab = (Label)sender;
                PictureBox nvelle_tour = new PictureBox();
                nvelle_tour = pic_temp;
                nvelle_tour.Location = new Point(lab.Location.X + 2, lab.Location.Y + 2);
                nvelle_tour.BackColor = lab.BackColor;
                board.Controls.Add(nvelle_tour);
                nvelle_tour.Visible = true;
                nvelle_tour.BringToFront();
                /*l'état de la case d'arrivée passe à Occupée*/
                plateau.getCase(Convert.ToInt32(lab.Name)).setOccupe();
                /*on libère la case de départ*/
                plateau.getCase(caseDepart.getNumCase()).setNonOccupe();
                //MessageBox.Show("Etat de la case :" + plateau.getCase(Convert.ToInt32(lab.Name)).getOccupe());
                plateau.getPion(tourDeplacee.getNumPion()).setPosition(plateau.getCase(Convert.ToInt32(lab.Name)));

                int test = plateau.getCase(Convert.ToInt32(lab.Name)).getNumCase();
                //MessageBox.Show("Numéro de la case : " + test);
                // affichage du coup joué
                Coup coupJoue = new Coup(joueurActif, tourDeplacee, plateau.getCase(Convert.ToInt32(lab.Name)));
                listeCoups.Text += coupJoue.afficheCoup();

                /*fin de partie?*/
                if (fin_partie_classique(test) == false)
                {
                    /*on récupère l'index de la prochaine tour(picturebox) qui devra être jouée*/
                    int index;
                    //int index = plateau.getTag(Convert.ToInt16(lab.Tag));
                    if (joueurActif.getCouleurPions() == 1)
                    {
                        //index = plateau.getPion(7+(8-Convert.ToInt16(lab.Tag))).getIndex(); /*si le joueur actif est celui avec les tours blanches, on rajoute la différence entre 8 et l'index à cause de la symétrie inverse*/
                        index = plateau.getTag(7 + (8 - Convert.ToInt16(lab.Tag)));
                        joueurActif = Accueil.J1; ; /*on passe la main au joueur avec les tours noires*/
                        timerJ2.Enabled = false; /*on arrête le chrono du joueur avec les tours blanches*/
                        timerJ1.Enabled = true; /*on active le chrono du joueur avec les tours noires*/
                        dragonNoir.Visible = true;
                        dragonBlanc.Visible = false;
                    }
                    else
                    {
                        //index = plateau.getPion(Convert.ToInt16(lab.Tag)).getIndex();
                        index = plateau.getTag(Convert.ToInt16(lab.Tag));
                        joueurActif = Accueil.J2; /*on passe la main au joueur avec les tours blanches*/
                        timerJ1.Enabled = false;
                        timerJ2.Enabled = true;
                        dragonNoir.Visible = false;
                        dragonBlanc.Visible = true;
                    }

                    // cas spécifique du blocage, on passe le tour du joueur dont le pion est bloqué
                    int compteurBlocage = 0;
                    while (this.pionBloque(index))
                    {
                        //MessageBox.Show("Le pion bloqué est : " + Convert.ToString(index));
                        int casePionBloque = plateau.getPion(index).getPosition().getNumCase();
                        int couleurCasePionBloque = plateau.getCase(casePionBloque).getCouleurNum();
                        Coup coup;
                        // on affiche un message et on change de joueur
                        if (joueurActif.getCouleurPions() == 1)
                        {
                            coup = new Coup(joueurActif);
                            listeCoups.Text += coup.blocage();
                            joueurActif = Accueil.J1;
                            dragonNoir.Visible = true;
                            dragonBlanc.Visible = false;
                            // on indique l'indice du pion qui récupère la main
                            //index = 7 + (8 - couleurCasePionBloque);
                            index = plateau.getTag(7 + (8 - couleurCasePionBloque));
                        }
                        else
                        {
                            coup = new Coup(joueurActif);
                            listeCoups.Text += coup.blocage();
                            joueurActif = Accueil.J2;
                            dragonNoir.Visible = false;
                            dragonBlanc.Visible = true;
                            //index = couleurCasePionBloque;
                            index = plateau.getTag(couleurCasePionBloque);
                        }
                        compteurBlocage++;
                        if (compteurBlocage > 15)
                        {
                            //fin_partie_classique(plateau.getPion(tourDeplacee.getNumPion()).getPosition().getNumCase());
                            finPartieImpasseTotale(plateau.getPion(tourDeplacee.getNumPion()));
                            break;
                        }
                    }

                    /*on débranche le clic_souris de toutes les picturebox et on branche la picturebox qui devra être jouée au prochain tour*/
                    foreach (Control ctrl in board.Controls)
                    {
                        if (ctrl is PictureBox && Convert.ToInt16(ctrl.Tag) != index)
                        {
                            ctrl.MouseDown -= new MouseEventHandler(clic_souris);
                            ctrl.Cursor = Cursors.No;
                        }
                        else if (ctrl is PictureBox && Convert.ToInt16(ctrl.Tag) == index)
                        {
                            ctrl.MouseDown += new MouseEventHandler(clic_souris);
                            tourAjouer = (PictureBox)ctrl;
                            ctrl.Cursor = Cursors.Hand;
                        }
                    }
                }
            }
            else if (sender is PictureBox)
            {
                PictureBox pic = (PictureBox)sender;
                PictureBox nvelle_tour = new PictureBox();
                nvelle_tour = tourAjouer;
                nvelle_tour.Location = pic.Location; //elle prend la place de la tour sender
                nvelle_tour.BackColor = pic.BackColor;
                board.Controls.Add(nvelle_tour);
                nvelle_tour.Visible = true;
                nvelle_tour.BringToFront();

                /*on calcule la différence entre le numéro de la case d'arrivée et celle de la case de départ pour déterminer la position de la tour qui subit le oshi*/

                int difference = plateau.getPion(Convert.ToInt16(pic.Tag)).getPosition().getNumCase() - plateau.getPion(Convert.ToInt16(tourAjouer.Tag)).getPosition().getNumCase();
                //MessageBox.Show("Différence = " + difference);

                switch (difference)
                {
                    case (-8): /*ligne droite tour noire*/
                        pic.Location = new Point(pic.Location.X, pic.Location.Y - 52);
                        break;
                    case 8: /*ligne droite tour blanche*/
                        pic.Location = new Point(pic.Location.X, pic.Location.Y + 52);
                        break;
                }

                /*on adapte la couleur du fond de la picturebox déplacée à la couleur du nouveau label*/
                //int index = -1;
                int index = Convert.ToInt16(tourAjouer.Tag);
                for (int i = 0; i < board.Controls.Count - 1; i++)
                {
                    if (board.Controls[i] is Label && Convert.ToInt16(board.Controls[i].Name) == plateau.getPion(Convert.ToInt16(pic.Tag)).getPosition().getNumCase() + difference)
                    {
                        pic.BackColor = board.Controls[i].BackColor;
                        /* et on en profite pour repérer la prochaine toûr qui devra être jouée*/
                        if (joueurActif.getCouleurPions() == 1)
                        {
                            index = plateau.getTag(Convert.ToInt16(board.Controls[i].Tag));
                        }
                        else
                        {
                            index = plateau.getTag(7 + (8 - Convert.ToInt16(board.Controls[i].Tag)));
                        }
                    }
                }

                /*libérer la case de la tour qui fait le oshi*/
                plateau.getCase(plateau.getPion(Convert.ToInt16(tourAjouer.Tag)).getPosition().getNumCase()).setNonOccupe();

                /*on met à jour la position de la tour qui fait le oshi*/
                plateau.getPion(Convert.ToInt16(tourAjouer.Tag)).setPosition(plateau.getCase(plateau.getPion(Convert.ToInt16(pic.Tag)).getPosition().getNumCase()));
                //MessageBox.Show("la position de la tour qui fait le oshi est : " + plateau.getPion(Convert.ToInt16(tourAjouer.Tag)).getPosition().getNumCase());

                /*on met à jour la position de la tour qui subit le oshi*/
                plateau.getPion(Convert.ToInt16(pic.Tag)).setPosition(plateau.getCase(plateau.getPion(Convert.ToInt16(tourAjouer.Tag)).getPosition().getNumCase() + difference)); /*les deux tours bougent du même nombre de cases*/
                //MessageBox.Show("la position de la tour qui subit le oshi est : " + plateau.getPion(Convert.ToInt16(pic.Tag)).getPosition().getNumCase());

                /*on set la case à "occupée"*/
                plateau.getCase(plateau.getPion(Convert.ToInt16(tourAjouer.Tag)).getPosition().getNumCase() + difference).setOccupe();
                /*pas la peine de redonner la main au joueur qui a fait le oshi car il continue de jouer*/

                // affichage du coup
                Coup coupSumo = new Coup(joueurActif, plateau.getPion(Convert.ToInt16(tourAjouer.Tag)), plateau.getPion(Convert.ToInt16(tourAjouer.Tag)).getPosition());
                Joueur adv = new Joueur();
                if(joueurActif == Accueil.J1)
                {
                    adv = Accueil.J2;
                } else
                {
                    adv = Accueil.J1;
                }
                listeCoups.Text += coupSumo.oshi(plateau.getPion(Convert.ToInt16(pic.Tag)), adv);

                // cas spécifique du blocage, on passe le tour du joueur dont le pion est bloqué
                int compteurBlocage = 0;
                while (this.pionBloque(index))
                {
                    int casePionBloque = plateau.getPion(index).getPosition().getNumCase();
                    int couleurCasePionBloque = plateau.getCase(casePionBloque).getCouleurNum();
                    Coup coup;
                    // on affiche un message et on change de joueur
                    if (joueurActif.getCouleurPions() == 1)
                    {
                        coup = new Coup(joueurActif);
                        listeCoups.Text += coup.blocage();
                        joueurActif = Accueil.J1;
                        dragonNoir.Visible = true;
                        dragonBlanc.Visible = false;
                        // on indique l'indice du pion qui récupère la main
                        index = 7 + (8 - couleurCasePionBloque);
                    }
                    else
                    {
                        coup = new Coup(joueurActif);
                        listeCoups.Text += coup.blocage();
                        joueurActif = Accueil.J2;
                        dragonNoir.Visible = false;
                        dragonBlanc.Visible = true;
                        index = couleurCasePionBloque;
                    }
                    compteurBlocage++;
                    if (compteurBlocage > 15)
                    {
                        //fin_partie_classique(plateau.getPion(tourDeplacee.getNumPion()).getPosition().getNumCase());
                        finPartieImpasseTotale(plateau.getPion(tourDeplacee.getNumPion()));
                        break;
                    }
                }

                /*on débranche le clic_souris de toutes les picturebox et on branche la picturebox qui devra être jouée au prochain tour*/
                foreach (Control ctrl in board.Controls)
                {
                    if (ctrl is PictureBox && Convert.ToInt16(ctrl.Tag) != index)
                    {
                        ctrl.MouseDown -= new MouseEventHandler(clic_souris);
                        ctrl.DragEnter -= new DragEventHandler(survol_cases);
                        ctrl.DragDrop -= new DragEventHandler(depose_case);
                        ctrl.AllowDrop = false;
                        ctrl.Cursor = Cursors.No;
                    }
                    else if (ctrl is PictureBox && Convert.ToInt16(ctrl.Tag) == index)
                    {
                        ctrl.MouseDown += new MouseEventHandler(clic_souris);
                        tourAjouer = (PictureBox)ctrl;
                        ctrl.Cursor = Cursors.Hand;
                    }
                }
            }
        }

        /********************************************************************************************************************************************************************************************/
        /*****************************************************************************Gestion des timers*********************************************************************************************/
        /********************************************************************************************************************************************************************************************/

        /*timer gestion du temps des joueurs*/
        private void timerJ1_Tick(object sender, EventArgs e)
        {
            if (joueurActif.getCouleurPions() == 0)
            {
                if (fin_partie_temps() == false)
                {
                    Accueil.J1.setTime();
                    progressbarJ1.Value = Accueil.J1.getTime();
                    chronoJ1.Text = string.Format("{0:00}:{1:00}", Convert.ToInt16(progressbarJ1.Value / 60), Convert.ToInt16(progressbarJ1.Value % 60));
                }
                else
                {
                    check_si_partie_complexe();
                }
            }
            else
            {
                if (fin_partie_temps() == false)
                {
                    Accueil.J2.setTime();
                    progressbarJ2.Value = Accueil.J2.getTime();
                    chronoJ2.Text = string.Format("{0:00}:{1:00}", Convert.ToInt16(progressbarJ2.Value / 60), Convert.ToInt16(progressbarJ2.Value % 60));
                }
                else
                {
                    check_si_partie_complexe();
                }
            }

        }

        /*Timer gestion de l'animation de la tour à jouer*/
        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (Control c in board.Controls)
            {
                if (c is PictureBox)
                {
                    if (c == tourAjouer)
                    {
                        for (int i = 0; i < 250; i++)
                        {
                            c.Location = new Point(c.Location.X, c.Location.Y - 2);
                            c.Location = new Point(c.Location.X, c.Location.Y + 2);
                            c.Location = new Point(c.Location.X, c.Location.Y + 2);
                            c.Location = new Point(c.Location.X, c.Location.Y - 2);
                            c.Location = new Point(c.Location.X - 2, c.Location.Y);
                            c.Location = new Point(c.Location.X + 2, c.Location.Y);
                            c.Location = new Point(c.Location.X + 2, c.Location.Y);
                            c.Location = new Point(c.Location.X - 2, c.Location.Y);
                        }
                    }
                }
            }
        }

        /********************************************************************************************************************************************************************************************/
        /***************************************************************************** Gestion des menus ********************************************************************************************/
        /********************************************************************************************************************************************************************************************/

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
            reponse = MessageBox.Show(msg, titre, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (reponse == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // menu 'Jeu' => 'Nouvelle Partie" => "Partie simple"
        private void nouvellePartie(object sender, EventArgs e)
        {
            String titre = "Confirmation",
                   msg = "Êtes-vous sûr de vouloir lancer une nouvelle partie ?" 
                   + Environment.NewLine + "Cela quittera la partie en cours";
            DialogResult reponse;
            reponse = MessageBox.Show(msg, titre, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (reponse == DialogResult.Yes)
            {
                this.Dispose();
                Accueil.J1.resetPointsEtTimer();
                Accueil.J2.resetPointsEtTimer();
                if(((ToolStripMenuItem)sender).Name == "partieSimpleMenu")
                {
                    Accueil.partie_complexe = false;
                } else
                {
                    Accueil.partie_complexe = true;
                }
                Partie game = new Partie();
                game.ShowDialog();
            }
        }

        /********************************************************************************************************************************************************************************************/
        /*****************************************************************************Procédures Debug***********************************************************************************************/
        /********************************************************************************************************************************************************************************************/

        private void check_pouvoir()
        {
            for (int i = 0; i < 16; i++)
            {
                MessageBox.Show("Le pouvoir de la tour est :" + plateau.getPion(i).getPouvoir(), Convert.ToString(i));
            }
        }

        /*pour voir l'état du plateau en temps réél*/
        private void plateau_temps_reel()
        {
            foreach (Label lab in groupBox1.Controls)
            {
                lab.Text = "";
            }

            for (int i = 0; i < 64; i++)
            {
                if (plateau.getCase(i).getOccupe() == true)
                {
                    groupBox1.Controls[i].Text = "X";
                }
            }
        }
    }
}
 