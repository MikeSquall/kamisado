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
            //MessageBox.Show("Partie complexe?" + Accueil.partie_complexe);
        }

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
            }
            else
            {
                if (fin_partie_temps() == false)
                {
                    Accueil.J2.setTime();
                    progressbarJ2.Value = Accueil.J2.getTime();
                    chronoJ2.Text = string.Format("{0:00}:{1:00}", Convert.ToInt16(progressbarJ2.Value / 60), Convert.ToInt16(progressbarJ2.Value % 60));
                }
            }

        }

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
            foreach (Control lab in board.Controls)
            {
                lab.AllowDrop = false;
                lab.Text = "";
            }

            foreach (Control c in board.Controls)
            {
                if (c is Label && cibles.Contains(Convert.ToInt32(c.Name)))
                {
                    c.AllowDrop = true;
                    //c.Text = "X";
                    //MessageBox.Show("Case n°:" + c.Name, "debug");
                }
            }

            pic_temp.DoDragDrop("kamisado", DragDropEffects.Copy);

            if (partie_terminee == false)
            {
                timer1.Enabled = true;
            }

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
                int index = Convert.ToInt16(lab.Tag);

                if (joueurActif.getCouleurPions() == 1)
                {
                    index = 7 + (8 - index); /*si le joueur actif est celui avec les tours blanches, on rajoute la différence entre 8 et l'index à cause de la symétrie inverse*/
                    joueurActif = Accueil.J1; ; /*on passe la main au joueur avec les tours noires*/
                    timerJ2.Enabled = false; /*on arrête le chrono du joueur avec les tours blanches*/
                    timerJ1.Enabled = true; /*on active le chrono du joueur avec les tours noires*/
                    dragonNoir.Visible = true;
                    dragonBlanc.Visible = false;
                }
                else
                {
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

        /*gestion de la fin de partie par fin du temps*/
        public bool fin_partie_temps()
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
                    scoreJ1.Text = Convert.ToString(Accueil.J1.getPoints())+" point";
                    listeCoups.Text += Accueil.J1.getNom() + " a gagné!";
                    MessageBox.Show(Accueil.J1.getNom() + " a gagné, Bravo!","Nous avons un vainqueur!");
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

            return flag;
        }

        /*gestion de la fin de partie classique*/
        public bool fin_partie_classique(int num_case)
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
                    Accueil.J1.setPoints();
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
                    Accueil.J2.setPoints();
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

            /*si la partie est de type complexe alors on continue de jouer*/
            if (Accueil.partie_complexe == true && flag == true)
            {
                bool fin_partie = false;

                //MessageBox.Show("Debug 1 : on rentre dans le test");
                if (joueurActif.getCouleurPions() == 0)
                {
                    //MessageBox.Show("Debug 2 : test si le jouer Noir a 3 points");
                    if (Accueil.J1.getPoints() == 3)
                    {
                        fin_partie = true;
                        MessageBox.Show(Accueil.J1.getNom() + " gagne la partie! Félicitations", "Nous avons notre champion");
                    }
                }
                else if (joueurActif.getCouleurPions() == 1)
                {
                    //MessageBox.Show("Debug 2 : test si le jouer Blanc a 3 points");
                    if (Accueil.J2.getPoints() == 3)
                    {
                        fin_partie = true;
                        MessageBox.Show(Accueil.J2.getNom() + " gagne la partie! Félicitations", "Nous avons notre champion");
                    }
                }

                if (fin_partie == false)
                {
                    //MessageBox.Show("Debug 4 : on continue de jouer");
                    /*on replace les tours*/
                    partie_terminee = false;
                    replace_tours();
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
            return flag;
        }

        // fin de partie suite à impasse totale
        private void finPartieImpasseTotale(Pion p)
        {
            timerJ1.Enabled = false;
            timerJ2.Enabled = false;
            timer1.Enabled = false;
            if (p.getEquipe() == 0)
            {
                Accueil.J2.setPoints();
                scoreJ2.Text = Convert.ToString(Accueil.J2.getPoints()) + " point";
                listeCoups.Text += Accueil.J2.getNom() + " a gagné!";
                MessageBox.Show(Accueil.J2.getNom() + " a gagné, Bravo!", "Nous avons un vainqueur!");
            }
            else
            {
                Accueil.J1.setPoints();
                scoreJ1.Text = Convert.ToString(Accueil.J1.getPoints()) + " point";
                listeCoups.Text += Accueil.J1.getNom() + " a gagné!";
                MessageBox.Show(Accueil.J1.getNom() + " a gagné, Bravo!", "Nous avons un vainqueur!");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (Control c in board.Controls)
            {
                if (c is PictureBox)
                {
                    if (c == tourAjouer)
                    {
                        for (int i = 0; i<250; i++)
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

        // menu 'Jeu' => "Sauvegarder"
        private void sauvegarderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sauvegarde.sauver(this);
        }

        // menu 'Jeu' => "Charger partie"
        private void chargerPartieToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void replace_tours()
        {
            int depart = 7;
            int num_case = 56;
            Pion[] tabPions_replace = new Pion[16];

            //MessageBox.Show("Debug0 : début traitement tours blanches");
            /*on traite d'abord les tours blanches*/
            for (int i = 63; i > 0; i -= 8)
            {
                for (int j = i; j > i-8; j--)
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
                                depart++;
                                num_case++;
                            }
                        }
                    }
                }
            }

            //MessageBox.Show("Debug3 : fin traitement tours noires");

            /*on set toutes les cases du plateau à non_occupée*/
            for (int i = 0; i<64; i++)
            {
                plateau.getCase(i).setNonOccupe();
            }

            /*une fois les tours correctement placées dans le tableau temporaire, on les replace dans le tableau principal*/
            /*on réutilise la variable "depart" pour ne pas en créer une nouvelle*/
            depart = 0;
            for (int i = 0; i < 16; i++)
            {
                /*on place la tour qui se trouve en case i dans le tableau principal des tours qui se trouve dans la classe Plateau*/
                for (int j = 0; j <16; j++)
                {
                    if (tabPions_replace[j].getNumPion() == i)
                    {
                        plateau.setPion(tabPions_replace[j], i);
                        plateau.getPion(i).setPosition(plateau.getCase(depart)); /*on affecte les nouvelles cases aux tours*/
                        plateau.getCase(depart).setOccupe();/*on set la case ocupée*/
                        depart++;
                    }
                }

                /*on test pour passer à l'autre extrémité du plateau*/
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

            /*on les replace dans le nouvel ordre*/
            for (int i = 0; i < 8; i++)
            {
                PictureBox pic = new PictureBox();
                pic.Visible = true;
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
                pic.Image = imageList1.Images[plateau.getPion(i).getNumPion()];
                pic.Tag = Convert.ToString(i);
                colonne += 52;
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
                pic.Image = imageList1.Images[plateau.getPion(depart).getNumPion()];
                pic.Tag = Convert.ToString(depart);
                colonne += 52;
                depart++;
            }
        }

        public Plateau getPlateau()
        {
            return this.plateau;
        }

        public String getHistoCoups()
        {
            return this.listeCoups.Text;
        }
    }
}
