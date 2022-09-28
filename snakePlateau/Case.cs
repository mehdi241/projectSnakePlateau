using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakePlateau
{
    internal class Case : FlowLayoutPanel
    {
        int index;
        string effect;

        public int Index { get => index; set => index = value; }
        public string Effect { get => effect; set => effect = value; }

        public Case(int index, string effect) : base()
        {
            Index = index;
            Effect = effect;
        }
    }
}