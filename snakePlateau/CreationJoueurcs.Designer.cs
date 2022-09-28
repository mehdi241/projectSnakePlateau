namespace snakePlateau
{
    partial class CreationJoueurcs
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
            this.userControl12 = new snakePlateau.UserControl1();
            this.SuspendLayout();
            // 
            // userControl12
            // 
            this.userControl12.Location = new System.Drawing.Point(39, 69);
            this.userControl12.Name = "userControl12";
            this.userControl12.Size = new System.Drawing.Size(497, 70);
            this.userControl12.TabIndex = 0;
            // 
            // CreationJoueurcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userControl12);
            this.Name = "CreationJoueurcs";
            this.Text = "CreationJoueurcs";
            this.ResumeLayout(false);

        }

        #endregion

        private composant_joueur userControl11;
        private snakePlateau.UserControl1 userControl12;
    }
}