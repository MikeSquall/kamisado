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

        public int getCouleurPion()
        {
            return this.couleurPion;
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
