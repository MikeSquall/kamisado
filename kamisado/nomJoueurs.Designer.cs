namespace kamisado
{
    partial class nomJoueurs
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
            this.label2 = new System.Windows.Forms.Label();
            this.nomJ1 = new System.Windows.Forms.TextBox();
            this.nomJ2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Joueur 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Joueur 2";
            // 
            // nomJ1
            // 
            this.nomJ1.Location = new System.Drawing.Point(135, 36);
            this.nomJ1.Name = "nomJ1";
            this.nomJ1.Size = new System.Drawing.Size(212, 20);
            this.nomJ1.TabIndex = 1;
            // 
            // nomJ2
            // 
            this.nomJ2.Location = new System.Drawing.Point(135, 113);
            this.nomJ2.Name = "nomJ2";
            this.nomJ2.Size = new System.Drawing.Size(212, 20);
            this.nomJ2.TabIndex = 1;
            // 
            // nomJoueurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 195);
            this.Controls.Add(this.nomJ2);
            this.Controls.Add(this.nomJ1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "nomJoueurs";
            this.Text = "Noms des joueurs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nomJ1;
        private System.Windows.Forms.TextBox nomJ2;
    }
}