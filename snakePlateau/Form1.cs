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
    public partial class frmSnakeBoard : Form
    {
        CreationJoueur cj;
        //Joueur j0 = new Joueur(); // debug
        Joueur currentPlayer = new Joueur();
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
                    // Assignation des pictureBox PictureBox des joueurs
                }
                if (cj.nbJoueurs == 2)
                {
                    prbJoueur1.Image = Resources.monkey_brown;
                    prbJoueur1.SizeMode = PictureBoxSizeMode.StretchImage;
                    prbJoueur2.Image = Resources.frog_green;
                    prbJoueur2.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else if (cj.nbJoueurs == 3)
                {
                    prbJoueur1.Image = Resources.monkey_brown;
                    prbJoueur1.SizeMode = PictureBoxSizeMode.StretchImage;
                    prbJoueur2.Image = Resources.frog_green;
                    prbJoueur2.SizeMode = PictureBoxSizeMode.StretchImage;
                    prbJoueur3.Image = Resources.mouse_blue;
                    prbJoueur3.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else if (cj.nbJoueurs == 4)
                {
                    prbJoueur1.Image = Resources.monkey_brown;
                    prbJoueur1.SizeMode = PictureBoxSizeMode.StretchImage;
                    prbJoueur2.Image = Resources.frog_green;
                    prbJoueur2.SizeMode = PictureBoxSizeMode.StretchImage;
                    prbJoueur3.Image = Resources.mouse_blue;
                    prbJoueur3.SizeMode = PictureBoxSizeMode.StretchImage;
                    prbJoueur4.Image = Resources.pig_rose;
                    prbJoueur4.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void frmSnakeBoard_Load(object sender, EventArgs e)
        {
            startGame();
            currentPlayer = currentPlayer.joueurs[0];
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void btnTour_Click(object sender, EventArgs e)
        {
            //j0.Step = step; // debug
            UpdateView();
        }

        public void UpdateView()
        {
            // Affiche les nouvelles infos à chaque tour
            int step = currentPlayer.Move();
            // Manque la gestion du déplacement des joueurs dans les cases
            lblResultDe.Text += " " + step.ToString() + " ";

            currentPlayer = currentPlayer.joueurs[currentPlayer.ID + 1];
        }


    }
}
