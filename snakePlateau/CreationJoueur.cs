﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snakePlateau
{
    public partial class CreationJoueur : Form
    {
        public decimal nbJoueurs;
        public string playerName;
        public CreationJoueur()
        {
            InitializeComponent();
        }

        private void CreationJoueur_Load(object sender, EventArgs e)
        {
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton a = sender as RadioButton;
            for(int i = 0; i< Convert.ToInt32(a.Tag); i++)
            {
                composant_joueur composant_Joueur = new composant_joueur();
                composant_Joueur.Location = new Point(100,30 + i*60);
                this.Controls.Add(composant_Joueur);
                //string name = composant_Joueur.textBox1.Text; // Je ne sais pas comment récupérer le text du textBox de la class composant_joueur /* Mehdi Calanducci
            }
            nbJoueurs = Convert.ToInt32(a.Tag);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Cliquer récupères les noms des joueurs dans une liste utilisable dans la forme principale
        }
    }
}
