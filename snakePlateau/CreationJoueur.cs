using snakePlateau.Properties;
using System;
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
        static List<Image> image = new List<Image>();

        List<Joueur> joueurList = new List<Joueur>();
        
        public CreationJoueur()
        {
            InitializeComponent();
            image.Add(Resources.monkey_brown);
            image.Add(Resources.frog_green);
            image.Add(Resources.mouse_blue);
            image.Add(Resources.pig_rose);
        }

        private void CreationJoueur_Load(object sender, EventArgs e)
        {
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {           
            groupBox1.Controls.Clear();
            RadioButton a = sender as RadioButton;
            for(int i = 0; i< Convert.ToInt32(a.Tag); i++)
            {
                composant_joueur composant_Joueur = new composant_joueur();
                composant_Joueur.Location = new Point(80,30 + i*60);
                composant_Joueur.Nom = $"Joueur {i+1}";
                composant_Joueur.Img = image[i];
                groupBox1.Controls.Add(composant_Joueur);
                string name = composant_Joueur.Nom;
            }
            nbJoueurs = Convert.ToInt32(a.Tag);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            
        }
    }
}
