namespace kamisado
{
    partial class Partie
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Partie));
            this.board = new System.Windows.Forms.Panel();
            this.fond_board = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.infoboxJ1 = new System.Windows.Forms.Panel();
            this.chronoJ1 = new System.Windows.Forms.Label();
            this.progressbarJ1 = new System.Windows.Forms.ProgressBar();
            this.picJ1 = new System.Windows.Forms.PictureBox();
            this.scoreJ1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nomJoueur1 = new System.Windows.Forms.Label();
            this.infoboxJ2 = new System.Windows.Forms.Panel();
            this.chronoJ2 = new System.Windows.Forms.Label();
            this.progressbarJ2 = new System.Windows.Forms.ProgressBar();
            this.picJ2 = new System.Windows.Forms.PictureBox();
            this.scoreJ2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nomJoueur2 = new System.Windows.Forms.Label();
            this.listeCoups = new System.Windows.Forms.TextBox();
            this.timerJ1 = new System.Windows.Forms.Timer(this.components);
            this.timerJ2 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.jeuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sauvegarderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvellePartieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partieSimpleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.partieComplexeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.chargerPartieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.butJeu = new System.Windows.Forms.ToolStripMenuItem();
            this.reglesJeu = new System.Windows.Forms.ToolStripMenuItem();
            this.partieSimpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partieComplexeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queFaire = new System.Windows.Forms.ToolStripMenuItem();
            this.pic_temp = new System.Windows.Forms.PictureBox();
            this.dragonNoir = new System.Windows.Forms.PictureBox();
            this.dragonBlanc = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fond_board.SuspendLayout();
            this.infoboxJ1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picJ1)).BeginInit();
            this.infoboxJ2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picJ2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_temp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dragonNoir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dragonBlanc)).BeginInit();
            this.SuspendLayout();
            // 
            // board
            // 
            this.board.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.board.Location = new System.Drawing.Point(19, 19);
            this.board.Name = "board";
            this.board.Size = new System.Drawing.Size(416, 416);
            this.board.TabIndex = 0;
            // 
            // fond_board
            // 
            this.fond_board.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fond_board.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fond_board.Controls.Add(this.board);
            this.fond_board.Location = new System.Drawing.Point(46, 63);
            this.fond_board.Name = "fond_board";
            this.fond_board.Size = new System.Drawing.Size(456, 456);
            this.fond_board.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "0.png");
            this.imageList1.Images.SetKeyName(1, "1.png");
            this.imageList1.Images.SetKeyName(2, "2.png");
            this.imageList1.Images.SetKeyName(3, "3.png");
            this.imageList1.Images.SetKeyName(4, "4.png");
            this.imageList1.Images.SetKeyName(5, "5.png");
            this.imageList1.Images.SetKeyName(6, "6.png");
            this.imageList1.Images.SetKeyName(7, "7.png");
            this.imageList1.Images.SetKeyName(8, "56.png");
            this.imageList1.Images.SetKeyName(9, "57.png");
            this.imageList1.Images.SetKeyName(10, "58.png");
            this.imageList1.Images.SetKeyName(11, "59.png");
            this.imageList1.Images.SetKeyName(12, "60.png");
            this.imageList1.Images.SetKeyName(13, "61.png");
            this.imageList1.Images.SetKeyName(14, "62.png");
            this.imageList1.Images.SetKeyName(15, "63.png");
            // 
            // infoboxJ1
            // 
            this.infoboxJ1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.infoboxJ1.Controls.Add(this.chronoJ1);
            this.infoboxJ1.Controls.Add(this.progressbarJ1);
            this.infoboxJ1.Controls.Add(this.picJ1);
            this.infoboxJ1.Controls.Add(this.scoreJ1);
            this.infoboxJ1.Controls.Add(this.label1);
            this.infoboxJ1.Controls.Add(this.nomJoueur1);
            this.infoboxJ1.Location = new System.Drawing.Point(652, 63);
            this.infoboxJ1.Name = "infoboxJ1";
            this.infoboxJ1.Size = new System.Drawing.Size(295, 58);
            this.infoboxJ1.TabIndex = 1;
            // 
            // chronoJ1
            // 
            this.chronoJ1.AutoSize = true;
            this.chronoJ1.Location = new System.Drawing.Point(126, 33);
            this.chronoJ1.Name = "chronoJ1";
            this.chronoJ1.Size = new System.Drawing.Size(35, 13);
            this.chronoJ1.TabIndex = 10;
            this.chronoJ1.Text = "label2";
            // 
            // progressbarJ1
            // 
            this.progressbarJ1.Location = new System.Drawing.Point(5, 28);
            this.progressbarJ1.Maximum = 900;
            this.progressbarJ1.Name = "progressbarJ1";
            this.progressbarJ1.Size = new System.Drawing.Size(262, 23);
            this.progressbarJ1.TabIndex = 9;
            this.progressbarJ1.Value = 600;
            // 
            // picJ1
            // 
            this.picJ1.BackColor = System.Drawing.Color.Transparent;
            this.picJ1.Location = new System.Drawing.Point(271, -2);
            this.picJ1.Name = "picJ1";
            this.picJ1.Size = new System.Drawing.Size(22, 58);
            this.picJ1.TabIndex = 6;
            this.picJ1.TabStop = false;
            // 
            // scoreJ1
            // 
            this.scoreJ1.AutoSize = true;
            this.scoreJ1.Location = new System.Drawing.Point(204, 7);
            this.scoreJ1.Name = "scoreJ1";
            this.scoreJ1.Size = new System.Drawing.Size(44, 13);
            this.scoreJ1.TabIndex = 2;
            this.scoreJ1.Text = "scoreJ1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "-->";
            // 
            // nomJoueur1
            // 
            this.nomJoueur1.AutoSize = true;
            this.nomJoueur1.Location = new System.Drawing.Point(17, 7);
            this.nomJoueur1.Name = "nomJoueur1";
            this.nomJoueur1.Size = new System.Drawing.Size(38, 13);
            this.nomJoueur1.TabIndex = 0;
            this.nomJoueur1.Text = "nomJ1";
            // 
            // infoboxJ2
            // 
            this.infoboxJ2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.infoboxJ2.Controls.Add(this.chronoJ2);
            this.infoboxJ2.Controls.Add(this.progressbarJ2);
            this.infoboxJ2.Controls.Add(this.picJ2);
            this.infoboxJ2.Controls.Add(this.scoreJ2);
            this.infoboxJ2.Controls.Add(this.label8);
            this.infoboxJ2.Controls.Add(this.nomJoueur2);
            this.infoboxJ2.Location = new System.Drawing.Point(652, 139);
            this.infoboxJ2.Name = "infoboxJ2";
            this.infoboxJ2.Size = new System.Drawing.Size(295, 58);
            this.infoboxJ2.TabIndex = 2;
            // 
            // chronoJ2
            // 
            this.chronoJ2.AutoSize = true;
            this.chronoJ2.Location = new System.Drawing.Point(126, 35);
            this.chronoJ2.Name = "chronoJ2";
            this.chronoJ2.Size = new System.Drawing.Size(35, 13);
            this.chronoJ2.TabIndex = 11;
            this.chronoJ2.Text = "label3";
            // 
            // progressbarJ2
            // 
            this.progressbarJ2.Location = new System.Drawing.Point(5, 30);
            this.progressbarJ2.Maximum = 900;
            this.progressbarJ2.Name = "progressbarJ2";
            this.progressbarJ2.Size = new System.Drawing.Size(262, 23);
            this.progressbarJ2.TabIndex = 1;
            this.progressbarJ2.Value = 600;
            // 
            // picJ2
            // 
            this.picJ2.BackColor = System.Drawing.Color.Transparent;
            this.picJ2.Location = new System.Drawing.Point(271, -2);
            this.picJ2.Name = "picJ2";
            this.picJ2.Size = new System.Drawing.Size(22, 58);
            this.picJ2.TabIndex = 7;
            this.picJ2.TabStop = false;
            // 
            // scoreJ2
            // 
            this.scoreJ2.AutoSize = true;
            this.scoreJ2.Location = new System.Drawing.Point(204, 9);
            this.scoreJ2.Name = "scoreJ2";
            this.scoreJ2.Size = new System.Drawing.Size(44, 13);
            this.scoreJ2.TabIndex = 8;
            this.scoreJ2.Text = "scoreJ2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(130, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "-->";
            // 
            // nomJoueur2
            // 
            this.nomJoueur2.AutoSize = true;
            this.nomJoueur2.Location = new System.Drawing.Point(17, 9);
            this.nomJoueur2.Name = "nomJoueur2";
            this.nomJoueur2.Size = new System.Drawing.Size(38, 13);
            this.nomJoueur2.TabIndex = 6;
            this.nomJoueur2.Text = "nomJ2";
            // 
            // listeCoups
            // 
            this.listeCoups.Location = new System.Drawing.Point(652, 219);
            this.listeCoups.Multiline = true;
            this.listeCoups.Name = "listeCoups";
            this.listeCoups.ReadOnly = true;
            this.listeCoups.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.listeCoups.Size = new System.Drawing.Size(295, 300);
            this.listeCoups.TabIndex = 3;
            // 
            // timerJ1
            // 
            this.timerJ1.Interval = 1000;
            this.timerJ1.Tick += new System.EventHandler(this.timerJ1_Tick);
            // 
            // timerJ2
            // 
            this.timerJ2.Interval = 1000;
            this.timerJ2.Tick += new System.EventHandler(this.timerJ1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jeuToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1402, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // jeuToolStripMenuItem
            // 
            this.jeuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sauvegarderToolStripMenuItem,
            this.nouvellePartieToolStripMenuItem,
            this.chargerPartieToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.jeuToolStripMenuItem.Name = "jeuToolStripMenuItem";
            this.jeuToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.jeuToolStripMenuItem.Text = "Jeu";
            // 
            // sauvegarderToolStripMenuItem
            // 
            this.sauvegarderToolStripMenuItem.Name = "sauvegarderToolStripMenuItem";
            this.sauvegarderToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.sauvegarderToolStripMenuItem.Text = "Sauvegarder ";
            this.sauvegarderToolStripMenuItem.Click += new System.EventHandler(this.sauvegarderToolStripMenuItem_Click);
            // 
            // nouvellePartieToolStripMenuItem
            // 
            this.nouvellePartieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.partieSimpleToolStripMenuItem1,
            this.partieComplexeToolStripMenuItem1});
            this.nouvellePartieToolStripMenuItem.Name = "nouvellePartieToolStripMenuItem";
            this.nouvellePartieToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.nouvellePartieToolStripMenuItem.Text = "Nouvelle partie";
            // 
            // partieSimpleToolStripMenuItem1
            // 
            this.partieSimpleToolStripMenuItem1.Name = "partieSimpleToolStripMenuItem1";
            this.partieSimpleToolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.partieSimpleToolStripMenuItem1.Text = "Partie simple";
            // 
            // partieComplexeToolStripMenuItem1
            // 
            this.partieComplexeToolStripMenuItem1.Name = "partieComplexeToolStripMenuItem1";
            this.partieComplexeToolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.partieComplexeToolStripMenuItem1.Text = "Partie complexe";
            // 
            // chargerPartieToolStripMenuItem
            // 
            this.chargerPartieToolStripMenuItem.Name = "chargerPartieToolStripMenuItem";
            this.chargerPartieToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.chargerPartieToolStripMenuItem.Text = "Charger partie";
            this.chargerPartieToolStripMenuItem.Click += new System.EventHandler(this.chargerPartieToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.quitterToolStripMenuItem.Text = "Quitter partie";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.butJeu,
            this.reglesJeu,
            this.queFaire});
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // butJeu
            // 
            this.butJeu.Name = "butJeu";
            this.butJeu.Size = new System.Drawing.Size(130, 22);
            this.butJeu.Text = "But du jeu";
            this.butJeu.Click += new System.EventHandler(this.butJeu_Click);
            // 
            // reglesJeu
            // 
            this.reglesJeu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.partieSimpleToolStripMenuItem,
            this.partieComplexeToolStripMenuItem});
            this.reglesJeu.Name = "reglesJeu";
            this.reglesJeu.Size = new System.Drawing.Size(130, 22);
            this.reglesJeu.Text = "Règles";
            // 
            // partieSimpleToolStripMenuItem
            // 
            this.partieSimpleToolStripMenuItem.Name = "partieSimpleToolStripMenuItem";
            this.partieSimpleToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.partieSimpleToolStripMenuItem.Text = "Partie Simple";
            this.partieSimpleToolStripMenuItem.Click += new System.EventHandler(this.partieSimpleToolStripMenuItem_Click);
            // 
            // partieComplexeToolStripMenuItem
            // 
            this.partieComplexeToolStripMenuItem.Name = "partieComplexeToolStripMenuItem";
            this.partieComplexeToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.partieComplexeToolStripMenuItem.Text = "Partie Complexe";
            this.partieComplexeToolStripMenuItem.Click += new System.EventHandler(this.partieComplexeToolStripMenuItem_Click);
            // 
            // queFaire
            // 
            this.queFaire.Name = "queFaire";
            this.queFaire.Size = new System.Drawing.Size(130, 22);
            this.queFaire.Text = "Que faire ?";
            // 
            // pic_temp
            // 
            this.pic_temp.Location = new System.Drawing.Point(13, 619);
            this.pic_temp.Name = "pic_temp";
            this.pic_temp.Size = new System.Drawing.Size(100, 50);
            this.pic_temp.TabIndex = 4;
            this.pic_temp.TabStop = false;
            this.pic_temp.Visible = false;
            // 
            // dragonNoir
            // 
            this.dragonNoir.BackColor = System.Drawing.Color.Transparent;
            this.dragonNoir.BackgroundImage = global::kamisado.Properties.Resources.black_dragon;
            this.dragonNoir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dragonNoir.Location = new System.Drawing.Point(532, 63);
            this.dragonNoir.Name = "dragonNoir";
            this.dragonNoir.Size = new System.Drawing.Size(98, 58);
            this.dragonNoir.TabIndex = 5;
            this.dragonNoir.TabStop = false;
            this.dragonNoir.Visible = false;
            // 
            // dragonBlanc
            // 
            this.dragonBlanc.BackColor = System.Drawing.Color.Transparent;
            this.dragonBlanc.BackgroundImage = global::kamisado.Properties.Resources.white_dragon;
            this.dragonBlanc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dragonBlanc.Location = new System.Drawing.Point(532, 139);
            this.dragonBlanc.Name = "dragonBlanc";
            this.dragonBlanc.Size = new System.Drawing.Size(98, 58);
            this.dragonBlanc.TabIndex = 5;
            this.dragonBlanc.TabStop = false;
            this.dragonBlanc.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(977, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 410);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Etat du plateau";
            // 
            // Partie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kamisado.Properties.Resources.fond;
            this.ClientSize = new System.Drawing.Size(1402, 681);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dragonBlanc);
            this.Controls.Add(this.dragonNoir);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pic_temp);
            this.Controls.Add(this.listeCoups);
            this.Controls.Add(this.infoboxJ2);
            this.Controls.Add(this.infoboxJ1);
            this.Controls.Add(this.fond_board);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Partie";
            this.Text = "Kamisado";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.fond_board.ResumeLayout(false);
            this.infoboxJ1.ResumeLayout(false);
            this.infoboxJ1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picJ1)).EndInit();
            this.infoboxJ2.ResumeLayout(false);
            this.infoboxJ2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picJ2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_temp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dragonNoir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dragonBlanc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel board;
        private System.Windows.Forms.Panel fond_board;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel infoboxJ1;
        private System.Windows.Forms.Panel infoboxJ2;
        private System.Windows.Forms.TextBox listeCoups;
        private System.Windows.Forms.Label scoreJ1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nomJoueur1;
        private System.Windows.Forms.Label scoreJ2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label nomJoueur2;
        private System.Windows.Forms.PictureBox picJ1;
        private System.Windows.Forms.PictureBox picJ2;
        private System.Windows.Forms.Label chronoJ1;
        private System.Windows.Forms.ProgressBar progressbarJ1;
        private System.Windows.Forms.Label chronoJ2;
        private System.Windows.Forms.ProgressBar progressbarJ2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jeuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sauvegarderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouvellePartieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem partieSimpleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem partieComplexeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem chargerPartieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem butJeu;
        private System.Windows.Forms.ToolStripMenuItem reglesJeu;
        private System.Windows.Forms.ToolStripMenuItem queFaire;
        private System.Windows.Forms.PictureBox pic_temp;
        private System.Windows.Forms.ToolStripMenuItem partieSimpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem partieComplexeToolStripMenuItem;
        public System.Windows.Forms.Timer timerJ1;
        public System.Windows.Forms.Timer timerJ2;
        private System.Windows.Forms.PictureBox dragonNoir;
        private System.Windows.Forms.PictureBox dragonBlanc;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

