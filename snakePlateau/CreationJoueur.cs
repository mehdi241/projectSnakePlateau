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
        decimal nbJoueurs;
        public CreationJoueur()
        {
            InitializeComponent();
        }

        private void CreationJoueur_Load(object sender, EventArgs e)
        {
            
        }

        private void nudJoueursNombre_ValueChanged(object sender, EventArgs e)
        {
            //nbJoueurs = nudJoueursNombre.Value; // Non fonctionnel
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton a = sender as RadioButton;
            for(int i = 0; i< Convert.ToInt32(a.Tag); i++)
            {
                composant_joueur composant_Joueur = new composant_joueur();
                /*composant_Joueur.Width = 30;
                composant_Joueur.Height = 30;
                composant_Joueur.Location = new Point(10,10);*/
                this.Controls.Add(composant_Joueur);
            }   
        }
    }
}
