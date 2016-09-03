using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kamisado
{
    public class Pion
    {
        private int equipe;
        private int couleurPion;
        private int numPion;
        private int index_liste;
        private Case position;
        private int pouvoir;

        public Pion(int team, int color, int num, Case pos)
        {
            this.equipe = team;
            this.couleurPion = color;
            this.numPion = num;
            this.index_liste = num;
            this.position = pos;
            this.pouvoir = 0;
        }

        public String toString()
        {
            String desc_pion = "";

            if (this.equipe == 0)
            {
                desc_pion += "Equipe : Noir, Couleur : ";
            }
            else desc_pion += "Equipe : Blanc, Couleur : ";

            desc_pion += this.getCouleurPion();

            return desc_pion;
        }

        public int deplacePion() // à virer ?
        {
            int etat = 0;
            return etat;
        }

        public String aide() // à compléter
        {
            String message = "";
            return message;
        }

        public int getEquipe()
        {
            return this.equipe;
        }

        public String getCouleurPion()
        {
            String color = "";
            switch (this.couleurPion)
            {
                case 0:
                    color = "Orange";
                    break;
                case 1:
                    color = "Bleue";
                    break;
                case 2:
                    color = "Violette";
                    break;
                case 3:
                    color = "Rose";
                    break;
                case 4:
                    color = "Jaune";
                    break;
                case 5:
                    color = "Rouge";
                    break;
                case 6:
                    color = "Vert";
                    break;
                case 7:
                    color = "Marron";
                    break;
            }
            return color;
        }

        public int getNumPion()
        {
            return this.numPion;
        }

        public Case getPosition()
        {
            return this.position;
        }

        public void setPosition(Case c)
        {
            this.position = c;
        }

        public int getPouvoir()
        {
            return this.pouvoir;
        }

        public void setPouvoir(int n)
        {
            this.pouvoir = n;
        }

        public void setNumPion(int num)
        {
            this.numPion = num;
        }

        public int getIndex()
        {
            return this.index_liste;
        }

        public int getNumTag(int num)
        {
            int numero = -1;
            if (this.position.getNumCase() == num)
            {
                numero = this.numPion;
            }

            return numero;
        }
    }
}