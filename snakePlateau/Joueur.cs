using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snakePlateau
{
    internal class Joueur : IDisposable
    {
        Random rnd = new Random();
        static List<Joueur> joueurs = new List<Joueur>();
        private string _name;
        private int _number;
        private int _step;
        private int _position;
        private static List<bool> UsedCounter = new List<bool>();
        private static object Lock = new object();



        public Joueur(string name, int number)
        {
            Name = name;
            Position = 0;
            lock (Lock)
            {
                int index = GetAvailableIndex();
                if (index == -1)
                {
                    index = UsedCounter.Count;
                    UsedCounter.Add(true);
                }
                ID = index;
            }
            joueurs.Add(this);
        }

        public Joueur() : this("test", 0)
        {
        }
        
        // Encapsulation Champs
        public int ID { 
            get; 
            private set; 
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Number { get => _number; set => _number = value; }

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

        // Fonction de mouvement
        public int Move()
        {
            //Random dé 6 faces
            int dice = rnd.Next(1, 7);
            //Position actuelle
            int current_pos = Position;

            //Déplacement du joueur
            Position = current_pos + dice;

            return Position;
        }
        // Supprimer un Joueur
        public void Dispose()
        {
            lock (Lock)
            {
                UsedCounter[ID] = false;
            }
        }
        // Index Range
        private static int GetAvailableIndex()
        {
            for (int i = 0; i < UsedCounter.Count; i++)
            {
                if (!UsedCounter[i])
                {
                    return i;
                }
            }
            return -1;
        }
    }
}