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
            this.case10 = new snakePlateau.Case();
            this.case9 = new snakePlateau.Case();
            this.case8 = new snakePlateau.Case();
            this.case7 = new snakePlateau.Case();
            this.case6 = new snakePlateau.Case();
            this.case5 = new snakePlateau.Case();
            this.case4 = new snakePlateau.Case();
            this.case3 = new snakePlateau.Case();
            this.case2 = new snakePlateau.Case();
            this.case1 = new snakePlateau.Case();
            this.case11 = new snakePlateau.Case();
            this.case12 = new snakePlateau.Case();
            this.case13 = new snakePlateau.Case();
            this.case14 = new snakePlateau.Case();
            this.case15 = new snakePlateau.Case();
            this.case16 = new snakePlateau.Case();
            this.case17 = new snakePlateau.Case();
            this.case18 = new snakePlateau.Case();
            this.case19 = new snakePlateau.Case();
            this.case20 = new snakePlateau.Case();
            this.case21 = new snakePlateau.Case();
            this.case22 = new snakePlateau.Case();
            this.case23 = new snakePlateau.Case();
            this.case24 = new snakePlateau.Case();
            this.case25 = new snakePlateau.Case();
            this.case26 = new snakePlateau.Case();
            this.case27 = new snakePlateau.Case();
            this.case28 = new snakePlateau.Case();
            this.case29 = new snakePlateau.Case();
            this.case30 = new snakePlateau.Case();
            this.case31 = new snakePlateau.Case();
            this.case32 = new snakePlateau.Case();
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
            this.btnTour.Click += new System.EventHandler(this.btnTour_Click);
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
            this.pictureBox1.Location = new System.Drawing.Point(17, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(726, 535);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // case10
            // 
            this.case10.Effect = "ladder";
            this.case10.Index = 0;
            this.case10.Location = new System.Drawing.Point(367, 334);
            this.case10.Name = "case10";
            this.case10.Size = new System.Drawing.Size(89, 67);
            this.case10.TabIndex = 15;
            // 
            // case9
            // 
            this.case9.Effect = "ladder";
            this.case9.Index = 0;
            this.case9.Location = new System.Drawing.Point(282, 335);
            this.case9.Name = "case9";
            this.case9.Size = new System.Drawing.Size(83, 67);
            this.case9.TabIndex = 14;
            // 
            // case8
            // 
            this.case8.Effect = "ladder";
            this.case8.Index = 0;
            this.case8.Location = new System.Drawing.Point(198, 335);
            this.case8.Name = "case8";
            this.case8.Size = new System.Drawing.Size(84, 67);
            this.case8.TabIndex = 13;
            // 
            // case7
            // 
            this.case7.Effect = "ladder";
            this.case7.Index = 0;
            this.case7.Location = new System.Drawing.Point(115, 335);
            this.case7.Name = "case7";
            this.case7.Size = new System.Drawing.Size(81, 71);
            this.case7.TabIndex = 13;
            // 
            // case6
            // 
            this.case6.Effect = "ladder";
            this.case6.Index = 0;
            this.case6.Location = new System.Drawing.Point(115, 405);
            this.case6.Name = "case6";
            this.case6.Size = new System.Drawing.Size(84, 85);
            this.case6.TabIndex = 12;
            // 
            // case5
            // 
            this.case5.Effect = "ladder";
            this.case5.Index = 0;
            this.case5.Location = new System.Drawing.Point(205, 424);
            this.case5.Name = "case5";
            this.case5.Size = new System.Drawing.Size(75, 67);
            this.case5.TabIndex = 11;
            // 
            // case4
            // 
            this.case4.Effect = "ladder";
            this.case4.Index = 0;
            this.case4.Location = new System.Drawing.Point(281, 424);
            this.case4.Name = "case4";
            this.case4.Size = new System.Drawing.Size(65, 67);
            this.case4.TabIndex = 10;
            // 
            // case3
            // 
            this.case3.Effect = "ladder";
            this.case3.Index = 0;
            this.case3.Location = new System.Drawing.Point(347, 425);
            this.case3.Name = "case3";
            this.case3.Size = new System.Drawing.Size(87, 67);
            this.case3.TabIndex = 9;
            // 
            // case2
            // 
            this.case2.Effect = "ladder";
            this.case2.Index = 0;
            this.case2.Location = new System.Drawing.Point(438, 424);
            this.case2.Name = "case2";
            this.case2.Size = new System.Drawing.Size(77, 67);
            this.case2.TabIndex = 8;
            // 
            // case1
            // 
            this.case1.Effect = "ladder";
            this.case1.Index = 0;
            this.case1.Location = new System.Drawing.Point(514, 423);
            this.case1.Name = "case1";
            this.case1.Size = new System.Drawing.Size(84, 67);
            this.case1.TabIndex = 7;
            // 
            // case11
            // 
            this.case11.Effect = "ladder";
            this.case11.Index = 0;
            this.case11.Location = new System.Drawing.Point(458, 334);
            this.case11.Name = "case11";
            this.case11.Size = new System.Drawing.Size(78, 67);
            this.case11.TabIndex = 16;
            // 
            // case12
            // 
            this.case12.Effect = "ladder";
            this.case12.Index = 0;
            this.case12.Location = new System.Drawing.Point(544, 335);
            this.case12.Name = "case12";
            this.case12.Size = new System.Drawing.Size(70, 65);
            this.case12.TabIndex = 17;
            // 
            // case13
            // 
            this.case13.Effect = "ladder";
            this.case13.Index = 0;
            this.case13.Location = new System.Drawing.Point(591, 268);
            this.case13.Name = "case13";
            this.case13.Size = new System.Drawing.Size(78, 67);
            this.case13.TabIndex = 18;
            // 
            // case14
            // 
            this.case14.Effect = "ladder";
            this.case14.Index = 0;
            this.case14.Location = new System.Drawing.Point(504, 249);
            this.case14.Name = "case14";
            this.case14.Size = new System.Drawing.Size(78, 67);
            this.case14.TabIndex = 19;
            // 
            // case15
            // 
            this.case15.Effect = "ladder";
            this.case15.Index = 0;
            this.case15.Location = new System.Drawing.Point(427, 250);
            this.case15.Name = "case15";
            this.case15.Size = new System.Drawing.Size(78, 67);
            this.case15.TabIndex = 20;
            // 
            // case16
            // 
            this.case16.Effect = "ladder";
            this.case16.Index = 0;
            this.case16.Location = new System.Drawing.Point(335, 250);
            this.case16.Name = "case16";
            this.case16.Size = new System.Drawing.Size(88, 67);
            this.case16.TabIndex = 21;
            // 
            // case17
            // 
            this.case17.Effect = "ladder";
            this.case17.Index = 0;
            this.case17.Location = new System.Drawing.Point(263, 250);
            this.case17.Name = "case17";
            this.case17.Size = new System.Drawing.Size(73, 67);
            this.case17.TabIndex = 22;
            // 
            // case18
            // 
            this.case18.Effect = "ladder";
            this.case18.Index = 0;
            this.case18.Location = new System.Drawing.Point(184, 250);
            this.case18.Name = "case18";
            this.case18.Size = new System.Drawing.Size(73, 67);
            this.case18.TabIndex = 23;
            // 
            // case19
            // 
            this.case19.Effect = "ladder";
            this.case19.Index = 0;
            this.case19.Location = new System.Drawing.Point(109, 216);
            this.case19.Name = "case19";
            this.case19.Size = new System.Drawing.Size(73, 67);
            this.case19.TabIndex = 24;
            // 
            // case20
            // 
            this.case20.Effect = "ladder";
            this.case20.Index = 0;
            this.case20.Location = new System.Drawing.Point(158, 164);
            this.case20.Name = "case20";
            this.case20.Size = new System.Drawing.Size(73, 67);
            this.case20.TabIndex = 25;
            // 
            // case21
            // 
            this.case21.Effect = "ladder";
            this.case21.Index = 0;
            this.case21.Location = new System.Drawing.Point(240, 164);
            this.case21.Name = "case21";
            this.case21.Size = new System.Drawing.Size(78, 66);
            this.case21.TabIndex = 25;
            // 
            // case22
            // 
            this.case22.Effect = "ladder";
            this.case22.Index = 0;
            this.case22.Location = new System.Drawing.Point(318, 164);
            this.case22.Name = "case22";
            this.case22.Size = new System.Drawing.Size(73, 67);
            this.case22.TabIndex = 25;
            // 
            // case23
            // 
            this.case23.Effect = "ladder";
            this.case23.Index = 0;
            this.case23.Location = new System.Drawing.Point(393, 164);
            this.case23.Name = "case23";
            this.case23.Size = new System.Drawing.Size(73, 67);
            this.case23.TabIndex = 25;
            // 
            // case24
            // 
            this.case24.Effect = "ladder";
            this.case24.Index = 0;
            this.case24.Location = new System.Drawing.Point(468, 165);
            this.case24.Name = "case24";
            this.case24.Size = new System.Drawing.Size(73, 67);
            this.case24.TabIndex = 26;
            // 
            // case25
            // 
            this.case25.Effect = "ladder";
            this.case25.Index = 0;
            this.case25.Location = new System.Drawing.Point(543, 164);
            this.case25.Name = "case25";
            this.case25.Size = new System.Drawing.Size(73, 67);
            this.case25.TabIndex = 26;
            // 
            // case26
            // 
            this.case26.Effect = "ladder";
            this.case26.Index = 0;
            this.case26.Location = new System.Drawing.Point(600, 114);
            this.case26.Name = "case26";
            this.case26.Size = new System.Drawing.Size(73, 67);
            this.case26.TabIndex = 26;
            // 
            // case27
            // 
            this.case27.Effect = "ladder";
            this.case27.Index = 0;
            this.case27.Location = new System.Drawing.Point(549, 72);
            this.case27.Name = "case27";
            this.case27.Size = new System.Drawing.Size(73, 67);
            this.case27.TabIndex = 27;
            // 
            // case28
            // 
            this.case28.Effect = "ladder";
            this.case28.Index = 0;
            this.case28.Location = new System.Drawing.Point(470, 72);
            this.case28.Name = "case28";
            this.case28.Size = new System.Drawing.Size(73, 67);
            this.case28.TabIndex = 27;
            // 
            // case29
            // 
            this.case29.Effect = "ladder";
            this.case29.Index = 0;
            this.case29.Location = new System.Drawing.Point(385, 73);
            this.case29.Name = "case29";
            this.case29.Size = new System.Drawing.Size(73, 67);
            this.case29.TabIndex = 27;
            // 
            // case30
            // 
            this.case30.Effect = "ladder";
            this.case30.Index = 0;
            this.case30.Location = new System.Drawing.Point(304, 71);
            this.case30.Name = "case30";
            this.case30.Size = new System.Drawing.Size(73, 67);
            this.case30.TabIndex = 27;
            // 
            // case31
            // 
            this.case31.Effect = "ladder";
            this.case31.Index = 0;
            this.case31.Location = new System.Drawing.Point(232, 71);
            this.case31.Name = "case31";
            this.case31.Size = new System.Drawing.Size(73, 67);
            this.case31.TabIndex = 27;
            // 
            // case32
            // 
            this.case32.Effect = "ladder";
            this.case32.Index = 0;
            this.case32.Location = new System.Drawing.Point(169, 70);
            this.case32.Name = "case32";
            this.case32.Size = new System.Drawing.Size(63, 67);
            this.case32.TabIndex = 28;
            // 
            // frmSnakeBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 741);
            this.Controls.Add(this.case32);
            this.Controls.Add(this.case31);
            this.Controls.Add(this.case30);
            this.Controls.Add(this.case29);
            this.Controls.Add(this.case28);
            this.Controls.Add(this.case27);
            this.Controls.Add(this.case26);
            this.Controls.Add(this.case25);
            this.Controls.Add(this.case24);
            this.Controls.Add(this.case23);
            this.Controls.Add(this.case22);
            this.Controls.Add(this.case21);
            this.Controls.Add(this.case20);
            this.Controls.Add(this.case19);
            this.Controls.Add(this.case18);
            this.Controls.Add(this.case17);
            this.Controls.Add(this.case16);
            this.Controls.Add(this.case15);
            this.Controls.Add(this.case14);
            this.Controls.Add(this.case13);
            this.Controls.Add(this.case12);
            this.Controls.Add(this.case11);
            this.Controls.Add(this.case10);
            this.Controls.Add(this.case9);
            this.Controls.Add(this.case8);
            this.Controls.Add(this.case7);
            this.Controls.Add(this.case6);
            this.Controls.Add(this.case5);
            this.Controls.Add(this.case4);
            this.Controls.Add(this.case3);
            this.Controls.Add(this.case2);
            this.Controls.Add(this.case1);
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
        private Case case1;
        private Case case2;
        private Case case3;
        private Case case4;
        private Case case5;
        private Case case6;
        private Case case7;
        private Case case8;
        private Case case9;
        private Case case10;
        private Case case11;
        private Case case12;
        private Case case13;
        private Case case14;
        private Case case15;
        private Case case16;
        private Case case17;
        private Case case18;
        private Case case19;
        private Case case20;
        private Case case21;
        private Case case22;
        private Case case23;
        private Case case24;
        private Case case25;
        private Case case26;
        private Case case27;
        private Case case28;
        private Case case29;
        private Case case30;
        private Case case31;
        private Case case32;
    }
}

