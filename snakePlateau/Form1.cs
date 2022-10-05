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
        Joueur j = new Joueur("Jeff");
        public frmSnakeBoard()
        {
            InitializeComponent();
        }
    }
}
