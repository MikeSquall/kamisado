﻿namespace kamisado
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
            this.label_duree = new System.Windows.Forms.Label();
            this.liste_duree = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom du joueur n°1 :";
            // 
            // nomJoueur1
            // 
            this.nomJoueur1.Location = new System.Drawing.Point(147, 27);
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
            this.nomJoueur2.Location = new System.Drawing.Point(147, 63);
            this.nomJoueur2.Name = "nomJoueur2";
            this.nomJoueur2.Size = new System.Drawing.Size(187, 20);
            this.nomJoueur2.TabIndex = 2;
            this.nomJoueur2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.valideNomJoueur_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nom du joueur n°2 :";
            // 
            // label_duree
            // 
            this.label_duree.AutoSize = true;
            this.label_duree.Location = new System.Drawing.Point(40, 101);
            this.label_duree.Name = "label_duree";
            this.label_duree.Size = new System.Drawing.Size(201, 13);
            this.label_duree.TabIndex = 4;
            this.label_duree.Text = "Temps maximum par joueur (en minutes) :";
            // 
            // liste_duree
            // 
            this.liste_duree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.liste_duree.FormattingEnabled = true;
            this.liste_duree.Items.AddRange(new object[] {
            "2",
            "3",
            "5",
            "7",
            "9",
            "10"});
            this.liste_duree.Location = new System.Drawing.Point(281, 96);
            this.liste_duree.Name = "liste_duree";
            this.liste_duree.Size = new System.Drawing.Size(53, 21);
            this.liste_duree.TabIndex = 5;
            // 
            // nomsJoueurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 166);
            this.ControlBox = false;
            this.Controls.Add(this.liste_duree);
            this.Controls.Add(this.label_duree);
            this.Controls.Add(this.nomJoueur2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.valideNomJoueur);
            this.Controls.Add(this.nomJoueur1);
            this.Controls.Add(this.label1);
            this.Name = "nomsJoueurs";
            this.Text = "Noms des Joueurs ";
            this.Load += new System.EventHandler(this.nomsJoueurs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomJoueur1;
        private System.Windows.Forms.Button valideNomJoueur;
        private System.Windows.Forms.TextBox nomJoueur2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_duree;
        private System.Windows.Forms.ComboBox liste_duree;
    }
}