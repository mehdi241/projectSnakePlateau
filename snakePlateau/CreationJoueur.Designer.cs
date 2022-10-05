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
            this.lblInfoName = new System.Windows.Forms.Label();
            this.lblInfoPicture = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.dudPicture = new System.Windows.Forms.DomainUpDown();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.nudJoueursNombre = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudJoueursNombre)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfoName
            // 
            this.lblInfoName.AutoSize = true;
            this.lblInfoName.Location = new System.Drawing.Point(45, 50);
            this.lblInfoName.Name = "lblInfoName";
            this.lblInfoName.Size = new System.Drawing.Size(38, 13);
            this.lblInfoName.TabIndex = 0;
            this.lblInfoName.Text = "Nom : ";
            // 
            // lblInfoPicture
            // 
            this.lblInfoPicture.AutoSize = true;
            this.lblInfoPicture.Location = new System.Drawing.Point(45, 115);
            this.lblInfoPicture.Name = "lblInfoPicture";
            this.lblInfoPicture.Size = new System.Drawing.Size(49, 13);
            this.lblInfoPicture.TabIndex = 1;
            this.lblInfoPicture.Text = "Picture : ";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(124, 47);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(267, 20);
            this.tbxName.TabIndex = 2;
            // 
            // dudPicture
            // 
            this.dudPicture.Location = new System.Drawing.Point(125, 110);
            this.dudPicture.Name = "dudPicture";
            this.dudPicture.Size = new System.Drawing.Size(270, 20);
            this.dudPicture.TabIndex = 3;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(315, 153);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(35, 35);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(356, 153);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(35, 35);
            this.btnQuit.TabIndex = 5;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            // 
            // nudJoueursNombre
            // 
            this.nudJoueursNombre.Location = new System.Drawing.Point(349, 12);
            this.nudJoueursNombre.Name = "nudJoueursNombre";
            this.nudJoueursNombre.Size = new System.Drawing.Size(46, 20);
            this.nudJoueursNombre.TabIndex = 6;
            this.nudJoueursNombre.ValueChanged += new System.EventHandler(this.nudJoueursNombre_ValueChanged);
            // 
            // CreationJoueur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 200);
            this.Controls.Add(this.nudJoueursNombre);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.dudPicture);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblInfoPicture);
            this.Controls.Add(this.lblInfoName);
            this.Name = "CreationJoueur";
            this.Text = "Création Joueurs";
            this.Load += new System.EventHandler(this.CreationJoueur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudJoueursNombre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfoName;
        private System.Windows.Forms.Label lblInfoPicture;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.DomainUpDown dudPicture;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.NumericUpDown nudJoueursNombre;
    }
}