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
    public partial class infos : Form
    {
        public infos()
        {
            InitializeComponent();
        }

        private void infos_Load(object sender, EventArgs e)
        {
            textBoxBut.Text = 
                "Kamisado est un jeu de stratégie pour deux joueurs." 
                + Environment.NewLine + Environment.NewLine +
                "Chaque joueur possède huit tours Dragon de couleurs différentes." 
                + Environment.NewLine + Environment.NewLine + 
                "Le but du jeu est d'être le premier à placer une tour sur la ligne de départ de l'adversaire.";

            textBoxRegSimple.Text =
                "Déroulement du jeu :"
                + Environment.NewLine +
                "Le Joueur 1 (tours noires) commence et choisit n'importe quelle tour pour son premier coup."
                + Environment.NewLine +
                "Après ce coup d'ouverture du Joueur 1, chacun joue une de ses tours à tour de rôle en respectant 3 règles :"
                + Environment.NewLine + Environment.NewLine +
                "1. Déplacement"
                + Environment.NewLine +
                "Une tour peut être déplacée d'un nombre quelconque de cases vers l'avant, soit en ligne droite, soit en diagonale (mais jamais latéralement, ni en arrière). Elle ne peut être déplacée ou s'arrêter que sur des cases libres. Il est donc interdit de sauter par-dessus les autres tours. Une tour peut passer diagonalement entre deux tours occupant deux cases qui se touchent par un coin."
                + Environment.NewLine + Environment.NewLine +
                "2. Tour active"
                + Environment.NewLine +
                "Quand vient son tour, le joueur doit déplacer la tour dont la couleur correspond à celle de la case sur laquelle s'est arrêté son adversaire au tour précédent. C'est la sa tour active."
                + Environment.NewLine + Environment.NewLine +
                "3. Impasse"
                + Environment.NewLine +
                "Quand vient son tour, le joueur doit, si possible, déplacer sa tour active. Cela lui est impossible si toutes les cases devant lui, en ligne droite ou en diagonale sont bloquées. Dans ce cas, son adversaire rejoue avec la tour dont la couleur correspond à celle de la case sur laquelle cette tour adverse est bloquée. En théorie, il peut arriver que les deux joueurs soient complètement bloqués. Dans ce cas, le perdant est le dernier joueur dont le précédent coup a provoqué cette impasse totale."
                + Environment.NewLine + Environment.NewLine +
                "Fin de la partie"
                + Environment.NewLine +
                "Le joueur qui atteint la rangée de base adverse avec une de ses tours remporte la partie."
                ;

            textBoxRegComplexe.Text =
                "En plus des règles existantes pour les parties simples, les parties complexes comprennent certaines règles additionnelles."
                + Environment.NewLine +
                "Le vainqueur d'une partie complexe est le premier Joueur a totaliser 3 points. La partie se déroule selon les règles de base. À la fin de la première manche, deux changements importants interviennent :"
                + Environment.NewLine + Environment.NewLine +
                "1. Naissance du Sumo"
                + Environment.NewLine +
                "La tour qui a atteint la rangée adverse est promue 'Sumo'. Un Sumo ne peut plus se déplacer d'autant de cases qu'avant mais peut effectuer un 'Oshi'. Dans le cas d'une partie gagnée suite à une impasse totale, c'est la tour qui l'a provoquée qui devient un Sumo."
                + Environment.NewLine + Environment.NewLine +
                "Particularités du Sumo :"
                + Environment.NewLine +
                "- il ne peut avancer que de cinq cases"
                + Environment.NewLine +
                "- s'il se retrouve dans une impasse, il peut effectuer un Oshi : il repousse d'une case la tour située devant lui (pas en diagonale) qui le bloque et avance d'une case"
                + Environment.NewLine +
                "- la case située derrière la tour repoussée doit être libre"
                + Environment.NewLine +
                "- juste après un Oshi, l'adversaire passe son tour et le joueur rejoue directement la tour de la couleur de la case sur laquelle a été repoussée la tour qui bloquait le Sumo"
                + Environment.NewLine + Environment.NewLine +
                "2. Position de départ des manches suivantes"
                + Environment.NewLine +
                "Lors du replacement des tours, celles-ci sont replacées de gauche à droite (de la case marron à la case orange) selon leur position finale sur le plateau : la tour la plus proche et la plus à gauche de la rangée adverse est replacée en premier puis les autres suivent jusqu'à replacer toutes les tours d'une même équipe sur la rangée de départ.";
        }
    }
}
