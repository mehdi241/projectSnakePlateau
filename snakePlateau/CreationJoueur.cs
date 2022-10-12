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
        decimal nbJoueurs;
        public CreationJoueur()
        {
            InitializeComponent();
        }

        private void CreationJoueur_Load(object sender, EventArgs e)
        {
            // Non fonctionnel
            // Initialize component for 8 gamers
            for (int i = 0; i < nbJoueurs; i++)
            {
                // Create a new label
                Label lbl = new Label();
                lbl.Text = "Joueur " + (i + 1);
                lbl.Location = new Point(10, 10 + (i * 30));
                lbl.Size = new Size(100, 20);
                lbl.Visible = true;
                this.Controls.Add(lbl);

                // Create a new textbox
                TextBox txt = new TextBox();
                txt.Location = new Point(120, 10 + (i * 30));
                txt.Size = new Size(100, 20);
                txt.Visible = true;
                this.Controls.Add(txt);

                // Create DomainUpDown
                DomainUpDown dud = new DomainUpDown();
                dud.Location = new Point(230, 10 + (i * 30));
            }
        }

        private void nudJoueursNombre_ValueChanged(object sender, EventArgs e)
        {
            //nbJoueurs = nudJoueursNombre.Value; // Non fonctionnel
        }
    }
}
