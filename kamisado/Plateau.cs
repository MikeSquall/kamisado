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
        List<int> casesDepartBlanches = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7 };
        List<int> casesDepartNoires = new List<int> { 56, 57, 58, 59, 60, 61, 62, 63 };


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
            bool blocage = true;
            bool limite_sumo = false; /*sera utilisé pour ne prendre en compte que les 5 premières possibilités pour les tours sumo*/

            // pour le déplacement, les cases que l'on peut cibler sont :
            // - dans le plateau
            // - non occupée et avec une ligne de vue directe  
            if (p.getEquipe() == 0) // mouvements équipe noire -> du bas du plateau vers le haut
            {
                while ((pos - 8 * n) >= 0 && this.board[pos - 8 * n].getOccupe() == false && limite_sumo == false)
                { // ligne droite
                    casesCibles.Add(pos - 8 * n);
                    n++;
                    blocage = false;
                    /*on check si on a atteint le déplacement maximum pour la tour sumo*/
                    if (p.getPouvoir() == 1 && n == 6)
                    {
                        limite_sumo = true;
                    }
                }
                /*cas de la tour sumo. On peut rajouter la case qui bloque en vue de faire un oshi*/
                if (blocage == true && p.getPouvoir() == 1 && (pos - 8 * n) >= 0 && this.board[pos - 8 * n].getOccupe() == true && (pos - (8 * (n + 1)) >=0 && this.board[pos - (8 * (n + 1))].getOccupe() == false && !casesDepartBlanches.Contains(pos - 8 * n)) && 
                    this.getEquipeNumCase(getCase(pos - 8 * n).getNumCase()) != 0)
                {
                    casesCibles.Add(pos - 8 * n);
                }

                n = 1;
                limite_sumo = false;
                while ((pos - 7 * n) >= 0 && this.board[pos - 7 * n].getOccupe() == false && n <= (7 - colonne) && limite_sumo == false)
                { // diagonale droite
                    casesCibles.Add(pos - 7 * n);
                    n++;
                    /*on check si on a atteint le déplacement maximum pour la tour sumo*/
                    if (p.getPouvoir() == 1 && n == 6)
                    {
                        limite_sumo = true;
                    }
                }

                n = 1;
                limite_sumo = false;
                while ((pos - 9 * n) >= 0 && this.board[pos - 9 * n].getOccupe() == false && n <= colonne && limite_sumo == false)
                { // diagonale gauche
                    casesCibles.Add(pos - 9 * n);
                    n++;
                    /*on check si on a atteint le déplacement maximum pour la tour sumo*/
                    if (p.getPouvoir() == 1 && n == 6)
                    {
                        limite_sumo = true;
                    }
                }
            }
            else // mouvements équipe blanche -> du haut du plateau vers le bas
            {
                while ((pos + 8 * n) < 64 && this.board[pos + 8 * n].getOccupe() == false && limite_sumo == false)
                { // ligne droite
                    casesCibles.Add(pos + 8 * n);
                    n++;
                    blocage = false;
                    /*on check si on a atteint le déplacement maximum pour la tour sumo*/
                    if (p.getPouvoir() == 1 && n == 6)
                    {
                        limite_sumo = true;
                    }
                }
                /*cas de la tour sumo. On peut rajouter la case qui bloque en vue de faire un oshi*/
                if (blocage == true && p.getPouvoir() == 1 && (pos + 8 * n) < 64 && this.board[pos + 8 * n].getOccupe() == true && (pos + (8 * (n + 1)) < 64 && this.board[pos + (8 * (n + 1))].getOccupe() == false && !casesDepartNoires.Contains(pos + 8 * n)) &&
                    this.getEquipeNumCase(getCase(pos + 8 * n).getNumCase()) != 1)
                {
                    casesCibles.Add(pos + 8 * n);
                }

                n = 1;
                limite_sumo = false;
                while ((pos + 7 * n) < 64 && this.board[pos + 7 * n].getOccupe() == false && n <= colonne && limite_sumo == false)
                { // diagonale droite
                    casesCibles.Add(pos + 7 * n);
                    n++;
                    /*on check si on a atteint le déplacement maximum pour la tour sumo*/
                    if (p.getPouvoir() == 1 && n == 6)
                    {
                        limite_sumo = true;
                    }
                }
                
                n = 1;
                limite_sumo = false;
                while ((pos + 9 * n) < 64 && this.board[pos + 9 * n].getOccupe() == false && n <= (7 - colonne) && limite_sumo == false)
                { // diagonale gauche
                    casesCibles.Add(pos + 9 * n);
                    n++;
                    /*on check si on a atteint le déplacement maximum pour la tour sumo*/
                    if (p.getPouvoir() == 1 && n == 6)
                    {
                        limite_sumo = true;
                    }
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

        //public int getTag(int index)
        //{
        //    int ind = -1;
        //    for (int i = 0; i < 16; i++)
        //    {
        //        if (tours[i].getIndex() == index)
        //        {
        //            ind = tours[i].getNumPion();
        //        }
        //    }

        //    return ind;
        //}

        public int getEquipeNumCase(int num_case)
        {
            int equipe = -1;
            for (int i = 0; i < 16; i++)
            {
                if (this.tours[i].getPosition().getNumCase() == num_case)
                {
                    equipe = this.tours[i].getEquipe();
                }
            }

            return equipe;
        }
    }
}