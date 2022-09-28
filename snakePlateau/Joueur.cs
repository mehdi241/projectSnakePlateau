using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joueur
{
    partial class Joueur
    {
        Random rnd = new Random();
        private string _name;
        private int _step;
        private int _position;
        private int _number;

        public Joueur(string name, int step, int position, int number)
        {
            _name = name;
            _step = step;
            _position = position;
            _number = number;
        }

        public Joueur() : this("Gary", 4, 6, 1) { }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Step
        {
            get { return _step; }
            set { _step = value; }
        }

        public int Position
        {
            get { return _position; }
            set { _position = value; }
        }

        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }
        public void Move()
        {
            //Random dé 6 faces
            int dice = rnd.Next(1, 7);

            Step = dice;
            Position += Step;
        }
    }
}