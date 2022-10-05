namespace snakePlateau
{
    partial class frmSnakeBoard
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
            this.lblInfoTour = new System.Windows.Forms.Label();
            this.lblJoueurActu = new System.Windows.Forms.Label();
            this.btnTour = new System.Windows.Forms.Button();
            this.lblResultDe = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfoTour
            // 
            this.lblInfoTour.AutoSize = true;
            this.lblInfoTour.Location = new System.Drawing.Point(34, 593);
            this.lblInfoTour.Name = "lblInfoTour";
            this.lblInfoTour.Size = new System.Drawing.Size(65, 13);
            this.lblInfoTour.TabIndex = 1;
            this.lblInfoTour.Text = "Au tour de : ";
            // 
            // lblJoueurActu
            // 
            this.lblJoueurActu.AutoSize = true;
            this.lblJoueurActu.Location = new System.Drawing.Point(109, 593);
            this.lblJoueurActu.Name = "lblJoueurActu";
            this.lblJoueurActu.Size = new System.Drawing.Size(0, 13);
            this.lblJoueurActu.TabIndex = 2;
            // 
            // btnTour
            // 
            this.btnTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTour.Location = new System.Drawing.Point(240, 632);
            this.btnTour.Name = "btnTour";
            this.btnTour.Size = new System.Drawing.Size(187, 69);
            this.btnTour.TabIndex = 3;
            this.btnTour.Text = "Tirer Dé";
            this.btnTour.UseVisualStyleBackColor = true;
            // 
            // lblResultDe
            // 
            this.lblResultDe.AutoSize = true;
            this.lblResultDe.Location = new System.Drawing.Point(62, 632);
            this.lblResultDe.Name = "lblResultDe";
            this.lblResultDe.Size = new System.Drawing.Size(55, 13);
            this.lblResultDe.TabIndex = 4;
            this.lblResultDe.Text = "Résultat : ";
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(620, 671);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(100, 30);
            this.btnQuit.TabIndex = 5;
            this.btnQuit.Text = "Quitter";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(514, 671);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 30);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::snakePlateau.Properties.Resources.snakeBoard;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(735, 535);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmSnakeBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 741);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.lblResultDe);
            this.Controls.Add(this.btnTour);
            this.Controls.Add(this.lblJoueurActu);
            this.Controls.Add(this.lblInfoTour);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmSnakeBoard";
            this.Text = "Jeu de Plateau Snake";
            this.Load += new System.EventHandler(this.frmSnakeBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblInfoTour;
        private System.Windows.Forms.Label lblJoueurActu;
        private System.Windows.Forms.Button btnTour;
        private System.Windows.Forms.Label lblResultDe;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnReset;
    }
}

