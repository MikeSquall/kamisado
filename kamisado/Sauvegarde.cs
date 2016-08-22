using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace kamisado
{
    class Sauvegarde
    {
        static void Main(string[] args, Partie p)
        {
            sauver(p);
        }

        public class Donnees
        {
            public Plateau boardgame;
            public Joueur j1;
            public Joueur j2;
            public String histoCoups;
        }

        public static void sauver(Partie p)
        {
            Donnees enCours = new Donnees();
            enCours.boardgame = p.getPlateau();
            enCours.j1 = Accueil.J1;
            enCours.j2 = Accueil.J2;
            enCours.histoCoups = p.getHistoCoups();

            XmlSerializer serializer = new XmlSerializer(typeof(Donnees));

            var chemin = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "kamisado_save.xml";
            System.IO.FileStream fichier = System.IO.File.Create(chemin);

            serializer.Serialize(fichier, enCours);
            fichier.Close();
        }
    }
}
