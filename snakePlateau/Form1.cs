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
    public partial class frmSnakeBoard : Form
    {
        CreationJoueur cj;
        Joueur j0 = new Joueur(); // debug
        int nbJoueurs = 0;
        public frmSnakeBoard()
        {
            InitializeComponent();
            cj = new CreationJoueur();
        }
        
        public void startGame()
        {
            DialogResult response = cj.ShowDialog();
            if (response == DialogResult.OK)
            {
                // Assignation des images au joueurs
                // bool victory = false; // Boolean de vérification de victoire
                for (int i = 0; i < cj.nbJoueurs; i++)
                {
                    Joueur j = new Joueur(cj.Name, i);
                    nbJoueurs++;
                    // Creation PictureBox des joueurs
                    PictureBox pb = new PictureBox();
                    pb.Name = "prbJoueur" + i;
                    pb.Dock = DockStyle.Fill;
                    pb.Location = new Point(0, 0); // Position encore expérimentale
                    pb.Size = new Size(10, 10);
                    Controls.Add(pb);
                }
            }
        }

        private void frmSnakeBoard_Load(object sender, EventArgs e)
        {
            startGame();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Reset Joueurs et Joueurs.Position
            j0.Position = 0;
            
        }

        private void btnTour_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int step = rnd.Next(1, 7);

            lblResultDe.Text += " " + step.ToString() + " ";
            j0.Step = step; // debug
        }

        public void UpdateView()
        {
            // Affiche les nouvelles infos à chaque tour
        }
    }
}
