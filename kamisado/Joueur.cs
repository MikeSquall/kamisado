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
        private int couleurPions; // 0 pour noir, 1 pour blanc
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

        public int getCouleurPions()
        {
            return this.couleurPions;
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
