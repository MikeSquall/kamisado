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
            this.btn_loadGame = new System.Windows.Forms.PictureBox();
            this.btn_quitGame = new System.Windows.Forms.PictureBox();
            this.btn_simpleGame = new System.Windows.Forms.PictureBox();
            this.btn_complexGame = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_newGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_loadGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_quitGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_simpleGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_complexGame)).BeginInit();
            this.SuspendLayout();
            // 
            // boutonsList
            // 
            this.boutonsList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("boutonsList.ImageStream")));
            this.boutonsList.TransparentColor = System.Drawing.Color.Transparent;
            this.boutonsList.Images.SetKeyName(0, "btn-newGame.png");
            this.boutonsList.Images.SetKeyName(1, "btn-loadGame.jpg");
            this.boutonsList.Images.SetKeyName(2, "btn-quitGame.jpg");
            this.boutonsList.Images.SetKeyName(3, "btn-simpleGame.jpg");
            this.boutonsList.Images.SetKeyName(4, "btn-complexGame.jpg");
            // 
            // btn_newGame
            // 
            this.btn_newGame.Location = new System.Drawing.Point(444, 155);
            this.btn_newGame.Name = "btn_newGame";
            this.btn_newGame.Size = new System.Drawing.Size(150, 50);
            this.btn_newGame.TabIndex = 0;
            this.btn_newGame.TabStop = false;
            this.btn_newGame.Click += new System.EventHandler(this.btn_newGame_Click);
            // 
            // btn_loadGame
            // 
            this.btn_loadGame.Location = new System.Drawing.Point(444, 211);
            this.btn_loadGame.Name = "btn_loadGame";
            this.btn_loadGame.Size = new System.Drawing.Size(150, 50);
            this.btn_loadGame.TabIndex = 0;
            this.btn_loadGame.TabStop = false;
            // 
            // btn_quitGame
            // 
            this.btn_quitGame.Location = new System.Drawing.Point(444, 267);
            this.btn_quitGame.Name = "btn_quitGame";
            this.btn_quitGame.Size = new System.Drawing.Size(150, 50);
            this.btn_quitGame.TabIndex = 0;
            this.btn_quitGame.TabStop = false;
            this.btn_quitGame.Click += new System.EventHandler(this.btn_quitGame_Click);
            // 
            // btn_simpleGame
            // 
            this.btn_simpleGame.Location = new System.Drawing.Point(242, 118);
            this.btn_simpleGame.Name = "btn_simpleGame";
            this.btn_simpleGame.Size = new System.Drawing.Size(150, 50);
            this.btn_simpleGame.TabIndex = 0;
            this.btn_simpleGame.TabStop = false;
            // 
            // btn_complexGame
            // 
            this.btn_complexGame.Location = new System.Drawing.Point(242, 186);
            this.btn_complexGame.Name = "btn_complexGame";
            this.btn_complexGame.Size = new System.Drawing.Size(150, 50);
            this.btn_complexGame.TabIndex = 0;
            this.btn_complexGame.TabStop = false;
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 392);
            this.Controls.Add(this.btn_complexGame);
            this.Controls.Add(this.btn_quitGame);
            this.Controls.Add(this.btn_simpleGame);
            this.Controls.Add(this.btn_loadGame);
            this.Controls.Add(this.btn_newGame);
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Accueil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_newGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_loadGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_quitGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_simpleGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_complexGame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList boutonsList;
        private System.Windows.Forms.PictureBox btn_newGame;
        private System.Windows.Forms.PictureBox btn_loadGame;
        private System.Windows.Forms.PictureBox btn_quitGame;
        private System.Windows.Forms.PictureBox btn_simpleGame;
        private System.Windows.Forms.PictureBox btn_complexGame;
    }
}