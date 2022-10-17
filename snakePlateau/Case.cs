using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using snakePlateau.Properties;

namespace snakePlateau
{
    internal class Case : FlowLayoutPanel
    {
        int _index;
        string _effect;
        //static List<Case> cases = new List<Case>();


        public int Index { get => _index; set => _index = value; }
        public string Effect { get => _effect; set => _effect = value; }

        public Case() : base()
        {
            this.SetStyle(ControlStyles.Opaque, true);
            /*cases.Add(this);
            Index = cases.Count() - 1;
            Effect = File.ReadAllLines("C:\\Users\\Lucien.Flr\\Desktop\\premierSemestre\\m426\\ids_CaseAEffect.txt")[cases.Count() - 1].Split(';')[1];*/
        }

        protected override CreateParams CreateParams
        {
            get
            {
                // Turn on the WS_EX_TRANSPARENT style
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x20;
                return cp;
            }
        }
    }
}