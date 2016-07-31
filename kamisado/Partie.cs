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
    public partial class Partie : Form
    {
        List<int> casesOrange = new List<int> {0,9,18,27,36,45,54,63};
        List<int> casesBlue = new List<int> {1,12,23,26,37,40,51,62};
        List<int> casesViolet = new List<int> {2,15,20,25,38,43,48,61};
        List<int> casesPink = new List<int> {3,10,17,24,39,46,53,60};
        List<int> casesYellow = new List<int> {4,13,22,31,32,41,50,59};
        List<int> casesRed = new List<int> {5,8,19,30,33,44,55,58};
        List<int> casesGreen = new List<int> {6,11,16,29,34,47,52,57};
        List<int> casesBrown = new List<int> {7,14,21,28,35,42,49,56};
        public Partie()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            int ligne = 0,
                colonne = 0,
                index_list = 0;
                
            board.BringToFront();
            for (int n = 0; n < 64; n++)
            {
                if (n % 8 == 0 && n != 0)
                {
                    ligne += 52;
                    colonne = 0;
                }
                
                Label tmp = new Label();
                tmp.Size = new Size(50, 50);
                board.Controls.Add(tmp);
                tmp.Location = new Point(colonne, ligne);
                //tmp.BorderStyle = BorderStyle.FixedSingle;
                //tmp.Text = Convert.ToString(n); // sert aux tests de génération du plateau

                if (casesOrange.Contains(n))
                {
                    tmp.BackColor = Color.Orange;
                    tmp.Tag = "orange";
                } else if (casesBlue.Contains(n))
                {
                    tmp.BackColor = Color.CornflowerBlue;
                    tmp.Tag = "blue";
                } else if (casesViolet.Contains(n))
                {
                    tmp.BackColor = Color.DarkOrchid;
                    tmp.Tag = "violet";
                } else if (casesPink.Contains(n))
                {
                    tmp.BackColor = Color.HotPink;
                    tmp.Tag = "pink";
                } else if (casesYellow.Contains(n))
                {
                    tmp.BackColor = Color.Yellow;
                    tmp.Tag = "yellow";
                } else if (casesRed.Contains(n))
                {
                    tmp.BackColor = Color.Crimson;
                    tmp.Tag = "red";
                } else if (casesGreen.Contains(n))
                {
                    tmp.BackColor = Color.Green;
                    tmp.Tag = "green";
                } else if (casesBrown.Contains(n))
                {
                    tmp.BackColor = Color.SaddleBrown;
                    tmp.Tag = "brown";
                }
                
                if (n < 8 || n > 55)
                {
                    PictureBox pic = new PictureBox();
                    //pic.Parent = tmp;
                    pic.Visible = true;
                    pic.Size = new Size(45, 45);
                    board.Controls.Add(pic);
                    pic.Location = new Point(colonne + 2, ligne + 2);
                    pic.BringToFront();
                    pic.BackColor = tmp.BackColor;
                    //MessageBox.Show("Couleur du fond : " + tmp.BackColor, "Couleur du fond");
                    pic.Image = imageList1.Images[index_list];
                    index_list++;
                }

                colonne += 52;
                
            }
        }
    }
}
