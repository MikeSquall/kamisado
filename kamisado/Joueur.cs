using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kamisado
{
    public class Joueur
    {
        private String nom;
        private int couleurPions;
        private int compteurPoints;
        // ajouter timer ==> voir comment faire

        public Joueur(String s, int n)
        {
            this.nom = s;
            this.couleurPions = n;
            this.compteurPoints = 0;
        }

        public String getNom()
        {
            return this.nom;
        }

        public int getPoints()
        {
            return this.compteurPoints;
        }

        public void setPoints()
        {
            this.compteurPoints++;
        }
    }
}
