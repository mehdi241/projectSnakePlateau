﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snakePlateau
{
    public partial class composant_joueur : UserControl
    {
        public composant_joueur()
        {
            InitializeComponent();
        
        }

        public string Nom { get => textBox1.Text; set => textBox1.Text = value; }
        public string Img { get => pictureBox1.ImageLocation; set => pictureBox1.ImageLocation = value; }

        private void composant_joueur_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Récupérer les noms des joueurs
        }
    }
}
