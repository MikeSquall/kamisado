namespace kamisado
{
    partial class nomsJoueurs
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
            this.label1 = new System.Windows.Forms.Label();
            this.nomJoueur1 = new System.Windows.Forms.TextBox();
            this.valideNomJoueur = new System.Windows.Forms.Button();
            this.nomJoueur2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom du joueur n°1 :";
            // 
            // nomJoueur1
            // 
            this.nomJoueur1.Location = new System.Drawing.Point(147, 37);
            this.nomJoueur1.Name = "nomJoueur1";
            this.nomJoueur1.Size = new System.Drawing.Size(187, 20);
            this.nomJoueur1.TabIndex = 1;
            this.nomJoueur1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.valideNomJoueur_KeyDown);
            // 
            // valideNomJoueur
            // 
            this.valideNomJoueur.Location = new System.Drawing.Point(120, 126);
            this.valideNomJoueur.Name = "valideNomJoueur";
            this.valideNomJoueur.Size = new System.Drawing.Size(165, 23);
            this.valideNomJoueur.TabIndex = 3;
            this.valideNomJoueur.Text = "Valider";
            this.valideNomJoueur.UseVisualStyleBackColor = true;
            this.valideNomJoueur.Click += new System.EventHandler(this.valideNomJoueur_Click);
            this.valideNomJoueur.KeyDown += new System.Windows.Forms.KeyEventHandler(this.valideNomJoueur_KeyDown);
            // 
            // nomJoueur2
            // 
            this.nomJoueur2.Location = new System.Drawing.Point(147, 73);
            this.nomJoueur2.Name = "nomJoueur2";
            this.nomJoueur2.Size = new System.Drawing.Size(187, 20);
            this.nomJoueur2.TabIndex = 2;
            this.nomJoueur2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.valideNomJoueur_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nom du joueur n°2 :";
            // 
            // nomsJoueurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 166);
            this.ControlBox = false;
            this.Controls.Add(this.nomJoueur2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.valideNomJoueur);
            this.Controls.Add(this.nomJoueur1);
            this.Controls.Add(this.label1);
            this.Name = "nomsJoueurs";
            this.Text = "Noms des Joueurs ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomJoueur1;
        private System.Windows.Forms.Button valideNomJoueur;
        private System.Windows.Forms.TextBox nomJoueur2;
        private System.Windows.Forms.Label label2;
    }
}