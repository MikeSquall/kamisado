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
        private Case position;
        private int pouvoir;

        public Pion()
        {

        }

        public int deplacePion()
        {
            int etat=0;
            return etat;
        }

        public String aide()
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
    }   
}
