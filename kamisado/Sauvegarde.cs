using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace kamisado
{
    public class Sauvegarde
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
            DialogResult reponse = new DialogResult();
            reponse = MessageBox.Show("Voulez-vous sauvegarder la partie ?"+ Environment.NewLine +"(cela effacera toute sauvegarde plus ancienne)", "Sauvegarde", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (reponse == DialogResult.Yes)
            {
                Donnees enCours = new Donnees();
                enCours.boardgame = p.getPlateau();
                enCours.j1 = new Joueur();
                {
                    enCours.j1.setNom(Accueil.J1.getNom());
                    enCours.j1.setCouleurPions(0);
                    enCours.j1.savePoints(Accueil.J1);
                    enCours.j1.saveTimer(Accueil.J1);
                }
                enCours.j2 = Accueil.J2;
                enCours.histoCoups = p.getHistoCoups();

                XmlSerializer serializer = new XmlSerializer(typeof(Donnees));

                var chemin = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\kamisado_save.xml";
                System.IO.FileStream fichier = System.IO.File.Create(chemin);
                
                serializer.Serialize(fichier, enCours);
                fichier.Close();

                MessageBox.Show("Partie sauvegardée", "Information", MessageBoxButtons.OK,MessageBoxIcon.Information);
            } 
        }
    }
}
