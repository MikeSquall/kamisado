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
        //private Case depart;
        private Case arrivee;
        private Joueur joueurActif;

        public Coup(Joueur j, Pion p, Case a)
        {
            this.joueurActif = j;
            this.pionDeplace = p;
            //this.depart = d;
            this.arrivee = a;
        }

        public String afficheCoup()
        {
            int couleurPions = joueurActif.getCouleurPions();
            String team = " none";
            if(couleurPions == 0)
            {
                team = " (Noir)";
            }
            else
            {
                team = " (Blanc)";
            }
            return joueurActif.getNom() + team + " -> tour " + pionDeplace.getCouleurPion() + " sur case " + arrivee.getCouleur() + Environment.NewLine ;
        }
    }
}
