using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kamisado
{
    public partial class ChoixTypePartie : Form
    {
        public ChoixTypePartie()
        {
            InitializeComponent();
            btnJ1CPU.Text = "J1 vs CPU "+ Environment.NewLine +" bientôt disponible";
            this.CenterToParent();
        }

        private void btnJ1J2_Click(object sender, EventArgs e)
        {
            nomsJoueurs joueur1 = new nomsJoueurs();
            //nomsJoueurs joueur2 = new nomsJoueurs();
            joueur1.ShowDialog();
            this.Close();
        }
    }
}
