namespace snakePlateau
{
    partial class CreationJoueur
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
            this.composant_joueur1 = new snakePlateau.composant_joueur();
            this.SuspendLayout();
            // 
            // composant_joueur1
            // 
            this.composant_joueur1.Location = new System.Drawing.Point(323, 57);
            this.composant_joueur1.Name = "composant_joueur1";
            this.composant_joueur1.Size = new System.Drawing.Size(410, 27);
            this.composant_joueur1.TabIndex = 0;
            // 
            // CreationJoueur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.composant_joueur1);
            this.Name = "CreationJoueur";
            this.Text = "CréationJoueur";
            this.ResumeLayout(false);

        }

        #endregion

        private composant_joueur composant_joueur1;
    }
}