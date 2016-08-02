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
            this.tempsJ1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.scoreJ1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nomJoueur1 = new System.Windows.Forms.Label();
            this.infoboxJ2 = new System.Windows.Forms.Panel();
            this.tempsJ2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.scoreJ2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nomJoueur2 = new System.Windows.Forms.Label();
            this.listeCoups = new System.Windows.Forms.TextBox();
            this.picJ1 = new System.Windows.Forms.PictureBox();
            this.picJ2 = new System.Windows.Forms.PictureBox();
            this.fond_board.SuspendLayout();
            this.infoboxJ1.SuspendLayout();
            this.infoboxJ2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picJ1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJ2)).BeginInit();
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
            this.fond_board.Location = new System.Drawing.Point(105, 63);
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
            this.infoboxJ1.Controls.Add(this.picJ1);
            this.infoboxJ1.Controls.Add(this.tempsJ1);
            this.infoboxJ1.Controls.Add(this.label2);
            this.infoboxJ1.Controls.Add(this.label3);
            this.infoboxJ1.Controls.Add(this.scoreJ1);
            this.infoboxJ1.Controls.Add(this.label1);
            this.infoboxJ1.Controls.Add(this.nomJoueur1);
            this.infoboxJ1.Location = new System.Drawing.Point(652, 63);
            this.infoboxJ1.Name = "infoboxJ1";
            this.infoboxJ1.Size = new System.Drawing.Size(295, 58);
            this.infoboxJ1.TabIndex = 1;
            // 
            // tempsJ1
            // 
            this.tempsJ1.AutoSize = true;
            this.tempsJ1.Location = new System.Drawing.Point(204, 31);
            this.tempsJ1.Name = "tempsJ1";
            this.tempsJ1.Size = new System.Drawing.Size(40, 13);
            this.tempsJ1.TabIndex = 5;
            this.tempsJ1.Text = "timeleft";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "-->";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Temps restant";
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
            this.infoboxJ2.Controls.Add(this.picJ2);
            this.infoboxJ2.Controls.Add(this.tempsJ2);
            this.infoboxJ2.Controls.Add(this.label5);
            this.infoboxJ2.Controls.Add(this.label6);
            this.infoboxJ2.Controls.Add(this.scoreJ2);
            this.infoboxJ2.Controls.Add(this.label8);
            this.infoboxJ2.Controls.Add(this.nomJoueur2);
            this.infoboxJ2.Location = new System.Drawing.Point(652, 139);
            this.infoboxJ2.Name = "infoboxJ2";
            this.infoboxJ2.Size = new System.Drawing.Size(295, 58);
            this.infoboxJ2.TabIndex = 2;
            // 
            // tempsJ2
            // 
            this.tempsJ2.AutoSize = true;
            this.tempsJ2.Location = new System.Drawing.Point(204, 33);
            this.tempsJ2.Name = "tempsJ2";
            this.tempsJ2.Size = new System.Drawing.Size(40, 13);
            this.tempsJ2.TabIndex = 11;
            this.tempsJ2.Text = "timeleft";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "-->";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Temps restant";
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
            this.listeCoups.Enabled = false;
            this.listeCoups.Location = new System.Drawing.Point(652, 219);
            this.listeCoups.Multiline = true;
            this.listeCoups.Name = "listeCoups";
            this.listeCoups.ReadOnly = true;
            this.listeCoups.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.listeCoups.Size = new System.Drawing.Size(295, 300);
            this.listeCoups.TabIndex = 3;
            // 
            // picJ1
            // 
            this.picJ1.BackColor = System.Drawing.Color.Transparent;
            this.picJ1.Location = new System.Drawing.Point(261, 6);
            this.picJ1.Name = "picJ1";
            this.picJ1.Size = new System.Drawing.Size(22, 22);
            this.picJ1.TabIndex = 6;
            this.picJ1.TabStop = false;
            // 
            // picJ2
            // 
            this.picJ2.BackColor = System.Drawing.Color.Transparent;
            this.picJ2.Location = new System.Drawing.Point(261, 6);
            this.picJ2.Name = "picJ2";
            this.picJ2.Size = new System.Drawing.Size(22, 22);
            this.picJ2.TabIndex = 7;
            this.picJ2.TabStop = false;
            // 
            // Partie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kamisado.Properties.Resources.fond;
            this.ClientSize = new System.Drawing.Size(1020, 681);
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
            this.infoboxJ2.ResumeLayout(false);
            this.infoboxJ2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picJ1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJ2)).EndInit();
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
        private System.Windows.Forms.Label tempsJ1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label scoreJ1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nomJoueur1;
        private System.Windows.Forms.Label tempsJ2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label scoreJ2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label nomJoueur2;
        private System.Windows.Forms.PictureBox picJ1;
        private System.Windows.Forms.PictureBox picJ2;
    }
}

