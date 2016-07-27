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
            this.board = new System.Windows.Forms.Panel();
            this.fond_board = new System.Windows.Forms.Panel();
            this.fond_board.SuspendLayout();
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
            // Partie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 581);
            this.Controls.Add(this.fond_board);
            this.Name = "Partie";
            this.Text = "Kamisado";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.fond_board.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel board;
        private System.Windows.Forms.Panel fond_board;
    }
}

