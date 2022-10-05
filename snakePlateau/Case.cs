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

        public int Index { get => _index; set => _index = value; }
        public string Effect { get => _effect; set => _effect = value; }

        public Case(int index, string effect) : base()
        {
            Index = index;
            Effect = effect;
        }
        public void case_effect(int case_id)
        {
            List<int> effects = new List<int>();
            List<int> snakes = new List<int>();
            List<int> ladders = new List<int>();

            for (int i = 0; i < effects.Count; i++)
            {
                if (case_id == effects[i])
                {
                    //Effect Check
                    if (case_id == snakes[i])
                    {
                        //Move to head of the snake

                    }
                    else if (case_id == ladders[i])
                    {
                        //Move to the top of the ladder
                    }
                }
            }
        }
    }
}