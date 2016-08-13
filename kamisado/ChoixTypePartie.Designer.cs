namespace kamisado
{
    partial class ChoixTypePartie
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
            this.btnJ1J2 = new System.Windows.Forms.Button();
            this.btnJ1CPU = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnJ1J2
            // 
            this.btnJ1J2.Location = new System.Drawing.Point(36, 70);
            this.btnJ1J2.Name = "btnJ1J2";
            this.btnJ1J2.Size = new System.Drawing.Size(144, 64);
            this.btnJ1J2.TabIndex = 0;
            this.btnJ1J2.Text = "J1 vs J2";
            this.btnJ1J2.UseVisualStyleBackColor = true;
            this.btnJ1J2.Click += new System.EventHandler(this.btnJ1J2_Click);
            // 
            // btnJ1CPU
            // 
            this.btnJ1CPU.Enabled = false;
            this.btnJ1CPU.Location = new System.Drawing.Point(203, 70);
            this.btnJ1CPU.Name = "btnJ1CPU";
            this.btnJ1CPU.Size = new System.Drawing.Size(144, 64);
            this.btnJ1CPU.TabIndex = 1;
            this.btnJ1CPU.Text = "J1 vs CPU";
            this.btnJ1CPU.UseVisualStyleBackColor = true;
            // 
            // ChoixTypePartie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 201);
            this.ControlBox = false;
            this.Controls.Add(this.btnJ1CPU);
            this.Controls.Add(this.btnJ1J2);
            this.Name = "ChoixTypePartie";
            this.Text = "ChoixTypePartie";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnJ1J2;
        private System.Windows.Forms.Button btnJ1CPU;
    }
}