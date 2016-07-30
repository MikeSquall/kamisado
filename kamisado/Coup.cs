using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kamisado
{
    public class Coup
    {
        private Pion pionDeplace;
        private Case depart;
        private Case arrivee;
        private Joueur joueurActif;

        public Coup(Joueur j, Pion p, Case d, Case a)
        {
            this.joueurActif = j;
            this.pionDeplace = p;
            this.depart = d;
            this.arrivee = a;
        }

        public String afficheCoup()
        {
            return joueurActif.getNom() + " a joué sa tour " + pionDeplace.getCouleurPion() + " sur une case " + arrivee.toString();
        }
    }
}
