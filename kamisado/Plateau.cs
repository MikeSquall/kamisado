using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kamisado
{
    public class Plateau
    {
        private Case[] board;
        private Pion[] tours;

        public Plateau(Case[] b, Pion[] t)
        {
            this.board = b;
            this.tours = t;
        }

        public bool deplacementOk(Pion p, Case c)
        {
            bool moveOk = true;
            int pos = p.getPosition().getNumCase(),
                n = 1,
                colonne = c.getNumCase() % 8;
            List<int> casesCibles = new List<int>();

            // pour le déplacement, les cases que l'on peut cibler sont :
            // - dans le plateau
            // - non occupée et avec une ligne de vue directe  
            if(p.getEquipe() == 0) // mouvements équipe noire -> du bas du plateau vers le haut
            {
                while ((pos - 8 * n) >= 0 && this.board[pos - 8 * n].getOccupe() == false)
                { // ligne droite
                    casesCibles.Add(pos - 8 * n);
                    n++;
                }
                n = 1;
                while ((pos - 7 * n) >= 0 && this.board[pos - 7 * n].getOccupe() == false && n <= (7 - colonne))
                { // diagonale droite
                    casesCibles.Add(pos - 7 * n);
                    n++;
                }
                n = 1;
                while ((pos - 9 * n) >= 0 && this.board[pos - 9 * n].getOccupe() == false && n <= colonne)
                { // diagonale gauche
                    casesCibles.Add(pos - 9 * n);
                    n++;
                }
            }
            else // mouvements équipe blanche -> du haut du plateau vers le bas
            {
                while ((pos + 8 * n) < 64 && this.board[pos + 8 * n].getOccupe() == false)
                { // ligne droite
                    casesCibles.Add(pos + 8 * n);
                    n++;
                }
                n = 1;
                while ((pos + 7 * n) < 64 && this.board[pos + 7 * n].getOccupe() == false && n <= (7 - colonne))
                { // diagonale droite
                    casesCibles.Add(pos + 7 * n);
                    n++;
                }
                n = 1;
                while ((pos + 9 * n) < 64 && this.board[pos + 9 * n].getOccupe() == false && n <= colonne)
                { // diagonale gauche
                    casesCibles.Add(pos + 9 * n);
                    n++;
                }
            }
            
            if (!casesCibles.Contains(c.getNumCase()))
            { // si la case ciblée n'est pas dans la liste des cases autorisées,
              // le mouvement n'est pas possible
                moveOk = false;
            }
            return moveOk;
        }
    }
}
