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
    internal class Case : FlowLayoutPanel
    {
        int _index;
        string _effect;
        static List<Case> cases =  new List<Case>();

        public int Index { get => _index; set => _index = value; }
        public string Effect { get => _effect; set => _effect = value; }

        public Case(int index, string effect) : base()
        {
            Index = index;
            Effect = effect;
            cases.Add(this);
        }

        public Case() : this(0, "")
        {  
        }
    }
}