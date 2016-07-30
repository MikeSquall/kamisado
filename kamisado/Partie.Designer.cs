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
            // Partie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kamisado.Properties.Resources.fond;
            this.ClientSize = new System.Drawing.Size(1020, 681);
            this.Controls.Add(this.fond_board);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Partie";
            this.Text = "Kamisado";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.fond_board.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel board;
        private System.Windows.Forms.Panel fond_board;
        private System.Windows.Forms.ImageList imageList1;
    }
}

