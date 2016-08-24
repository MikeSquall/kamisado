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

        public Plateau()
        {
            // constructeur vide, sert à la classe Sauvegarde
        }

        public Plateau(Case[] b, Pion[] t)
        {
            this.board = b;
            this.tours = t;
        }

        public List<int> deplacementOk(Pion p, Case c)
        {
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
                while ((pos + 7 * n) < 64 && this.board[pos + 7 * n].getOccupe() == false && n <= colonne)
                { // diagonale droite
                    casesCibles.Add(pos + 7 * n);
                    n++;
                }
                n = 1;
                while ((pos + 9 * n) < 64 && this.board[pos + 9 * n].getOccupe() == false && n <= (7 - colonne))
                { // diagonale gauche
                    casesCibles.Add(pos + 9 * n);
                    n++;
                }
            }
            
            return casesCibles;
        }

        public Pion getPion(int indice)
        {
            return this.tours[indice];
        }

        public void setPion(Pion[] tour)
        {
            this.tours = tour;
        }

        public Case getCase(int indice)
        {
            return this.board[indice];
        }

        public int getTag(int index)
        {
            int ind=-1;
            for (int i = 0; i < 16; i++)
            {
                if (tours[i].getIndex() == index)
                {
                    ind = tours[i].getNumPion();
                }
            }

            return ind;
        }
    }
}
