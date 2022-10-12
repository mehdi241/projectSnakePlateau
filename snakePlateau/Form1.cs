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
                Joueur j = new Joueur("Jeff"); // debug
                bool victory = false;
                lblJoueurActu.Text = j.Name;
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
            
        }

        private void btnTour_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int step = rnd.Next(1, 7);

            lblResultDe.Text += " " + step.ToString() + " ";
        }
    }
}
