using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kamisado
{
    public class Case
    {
        private int couleur;
        private int numero;
        private bool occupee;

        public Case(int color, int num, bool statut)
        {
            this.couleur = color;
            this.numero = num;
            this.occupee = statut;
        }

        public String toString()
        {
            String color = "";
            switch (this.couleur)
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

            color += this.numero.ToString();

            switch (this.occupee)
            {
                case false:
                    color += " Libre";
                    break;
                case true:
                    color += " Occupée";
                    break;
            }

            return color;
        }

        public String num_case()
        {
            return this.numero.ToString();
        }
    }
}