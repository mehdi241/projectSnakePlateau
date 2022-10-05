namespace snakePlateau
{
    partial class FrmQuestion
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rBtnRep1 = new System.Windows.Forms.RadioButton();
            this.rBtnRep2 = new System.Windows.Forms.RadioButton();
            this.rBtnRep3 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(48, 38);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(318, 25);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Exemple de question à poser";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBtnRep3);
            this.groupBox1.Controls.Add(this.rBtnRep2);
            this.groupBox1.Controls.Add(this.rBtnRep1);
            this.groupBox1.Location = new System.Drawing.Point(27, 217);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 221);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rBtnRep1
            // 
            this.rBtnRep1.AutoSize = true;
            this.rBtnRep1.Location = new System.Drawing.Point(26, 53);
            this.rBtnRep1.Name = "rBtnRep1";
            this.rBtnRep1.Size = new System.Drawing.Size(85, 17);
            this.rBtnRep1.TabIndex = 0;
            this.rBtnRep1.TabStop = true;
            this.rBtnRep1.Text = "radioButton1";
            this.rBtnRep1.UseVisualStyleBackColor = true;
            // 
            // rBtnRep2
            // 
            this.rBtnRep2.AutoSize = true;
            this.rBtnRep2.Location = new System.Drawing.Point(26, 107);
            this.rBtnRep2.Name = "rBtnRep2";
            this.rBtnRep2.Size = new System.Drawing.Size(85, 17);
            this.rBtnRep2.TabIndex = 1;
            this.rBtnRep2.TabStop = true;
            this.rBtnRep2.Text = "radioButton2";
            this.rBtnRep2.UseVisualStyleBackColor = true;
            // 
            // rBtnRep3
            // 
            this.rBtnRep3.AutoSize = true;
            this.rBtnRep3.Location = new System.Drawing.Point(26, 161);
            this.rBtnRep3.Name = "rBtnRep3";
            this.rBtnRep3.Size = new System.Drawing.Size(85, 17);
            this.rBtnRep3.TabIndex = 2;
            this.rBtnRep3.TabStop = true;
            this.rBtnRep3.Text = "radioButton3";
            this.rBtnRep3.UseVisualStyleBackColor = true;
            // 
            // FrmQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblQuestion);
            this.Name = "FrmQuestion";
            this.Text = "FrmQuestion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rBtnRep3;
        private System.Windows.Forms.RadioButton rBtnRep2;
        private System.Windows.Forms.RadioButton rBtnRep1;
    }
}