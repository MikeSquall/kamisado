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
        private int timer;
        
        public Joueur()
        {
            // constructeur vide, sert à la classe Sauvegarde
        }

        public Joueur(String s, int n, int t)
        {
            this.nom = s;
            this.couleurPions = n;
            this.timer = t*60; 
            this.compteurPoints = 0;
        }

        public String getNom()
        {
            return this.nom;
        }

        public void setNom(String n)
        {
            this.nom = n;
        }

        public int getCouleurPions()
        {
            return this.couleurPions;
        }

        public void setCouleurPions(int c)
        {
            this.couleurPions = c;
        }

        public int getPoints()
        {
            return this.compteurPoints;
        }

        public void setPoints()
        {
            this.compteurPoints++;
        }

        public void savePoints(Joueur j)
        {
            this.compteurPoints = j.getPoints();
        }

        public int getTime()
        {
            return this.timer;
        }

        public void setTime()
        {
            this.timer--;
        }

        public void saveTimer(Joueur j)
        {
            this.timer = j.getTime();
        }
    }
}
