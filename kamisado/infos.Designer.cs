namespace kamisado
{
    partial class infos
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBoxBut = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBoxRegSimple = new System.Windows.Forms.TextBox();
            this.textBoxRegComplexe = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(558, 433);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBoxBut);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(550, 407);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "But du jeu";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBoxBut
            // 
            this.textBoxBut.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBut.Location = new System.Drawing.Point(0, 0);
            this.textBoxBut.Multiline = true;
            this.textBoxBut.Name = "textBoxBut";
            this.textBoxBut.Size = new System.Drawing.Size(550, 407);
            this.textBoxBut.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBoxRegSimple);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(550, 407);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Partie simple";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBoxRegComplexe);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(550, 407);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Partie complexe";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBoxRegSimple
            // 
            this.textBoxRegSimple.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRegSimple.Location = new System.Drawing.Point(0, 0);
            this.textBoxRegSimple.Multiline = true;
            this.textBoxRegSimple.Name = "textBoxRegSimple";
            this.textBoxRegSimple.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRegSimple.Size = new System.Drawing.Size(550, 407);
            this.textBoxRegSimple.TabIndex = 1;
            // 
            // textBoxRegComplexe
            // 
            this.textBoxRegComplexe.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRegComplexe.Location = new System.Drawing.Point(0, 0);
            this.textBoxRegComplexe.Multiline = true;
            this.textBoxRegComplexe.Name = "textBoxRegComplexe";
            this.textBoxRegComplexe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRegComplexe.Size = new System.Drawing.Size(550, 407);
            this.textBoxRegComplexe.TabIndex = 2;
            // 
            // infos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 457);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "infos";
            this.Text = "Informations";
            this.Load += new System.EventHandler(this.infos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxBut;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBoxRegSimple;
        private System.Windows.Forms.TextBox textBoxRegComplexe;
    }
}