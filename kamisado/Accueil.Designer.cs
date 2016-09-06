namespace kamisado
{
    partial class Accueil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
            this.boutonsList = new System.Windows.Forms.ImageList(this.components);
            this.btn_newGame = new System.Windows.Forms.PictureBox();
            this.btn_quitGame = new System.Windows.Forms.PictureBox();
            this.titreJeu = new System.Windows.Forms.PictureBox();
            this.toursDecoAccueil = new System.Windows.Forms.PictureBox();
            this.btn_rules = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_newGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_quitGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titreJeu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toursDecoAccueil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_rules)).BeginInit();
            this.SuspendLayout();
            // 
            // boutonsList
            // 
            this.boutonsList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("boutonsList.ImageStream")));
            this.boutonsList.TransparentColor = System.Drawing.Color.Transparent;
            this.boutonsList.Images.SetKeyName(0, "btn-newGame.png");
            this.boutonsList.Images.SetKeyName(1, "btn-rules.png");
            this.boutonsList.Images.SetKeyName(2, "btn-quitGame.png");
            // 
            // btn_newGame
            // 
            this.btn_newGame.Location = new System.Drawing.Point(444, 175);
            this.btn_newGame.Name = "btn_newGame";
            this.btn_newGame.Size = new System.Drawing.Size(150, 50);
            this.btn_newGame.TabIndex = 0;
            this.btn_newGame.TabStop = false;
            this.btn_newGame.Click += new System.EventHandler(this.btn_newGame_Click);
            // 
            // btn_quitGame
            // 
            this.btn_quitGame.Location = new System.Drawing.Point(444, 296);
            this.btn_quitGame.Name = "btn_quitGame";
            this.btn_quitGame.Size = new System.Drawing.Size(150, 50);
            this.btn_quitGame.TabIndex = 0;
            this.btn_quitGame.TabStop = false;
            this.btn_quitGame.Click += new System.EventHandler(this.btn_quitGame_Click);
            // 
            // titreJeu
            // 
            this.titreJeu.BackColor = System.Drawing.Color.Transparent;
            this.titreJeu.BackgroundImage = global::kamisado.Properties.Resources.kamisado_titre1;
            this.titreJeu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.titreJeu.Location = new System.Drawing.Point(151, 33);
            this.titreJeu.Name = "titreJeu";
            this.titreJeu.Size = new System.Drawing.Size(350, 100);
            this.titreJeu.TabIndex = 1;
            this.titreJeu.TabStop = false;
            // 
            // toursDecoAccueil
            // 
            this.toursDecoAccueil.BackColor = System.Drawing.Color.Transparent;
            this.toursDecoAccueil.BackgroundImage = global::kamisado.Properties.Resources.tour;
            this.toursDecoAccueil.Location = new System.Drawing.Point(124, 182);
            this.toursDecoAccueil.Name = "toursDecoAccueil";
            this.toursDecoAccueil.Size = new System.Drawing.Size(200, 200);
            this.toursDecoAccueil.TabIndex = 2;
            this.toursDecoAccueil.TabStop = false;
            // 
            // btn_rules
            // 
            this.btn_rules.Location = new System.Drawing.Point(444, 235);
            this.btn_rules.Name = "btn_rules";
            this.btn_rules.Size = new System.Drawing.Size(150, 50);
            this.btn_rules.TabIndex = 0;
            this.btn_rules.TabStop = false;
            this.btn_rules.Click += new System.EventHandler(this.btn_rules_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kamisado.Properties.Resources.fond;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(660, 392);
            this.ControlBox = false;
            this.Controls.Add(this.toursDecoAccueil);
            this.Controls.Add(this.titreJeu);
            this.Controls.Add(this.btn_quitGame);
            this.Controls.Add(this.btn_rules);
            this.Controls.Add(this.btn_newGame);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Accueil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_newGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_quitGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titreJeu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toursDecoAccueil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_rules)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList boutonsList;
        private System.Windows.Forms.PictureBox btn_newGame;
        private System.Windows.Forms.PictureBox btn_quitGame;
        private System.Windows.Forms.PictureBox titreJeu;
        private System.Windows.Forms.PictureBox toursDecoAccueil;
        private System.Windows.Forms.PictureBox btn_rules;
    }
}