﻿using System;
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
    partial class Joueur : IDisposable
    {
        Random rnd = new Random();
        private string _name;
        private int _step;
        private int _position;
        private int _number;
        private static List<bool> UsedCounter = new List<bool>();
        private static object Lock = new object();



        public Joueur(string name, int step, int position, int index)
        {
            _name = name;
            _step = step;
            _position = position;
            _number = index;
        }
        public Joueur()
        {
            //Creation d'id pour l'ordre des joueurs
            lock (Lock)
            {
                int nextIndex = GetAvailableIndex();
                if (nextIndex == -1)
                {
                    nextIndex = UsedCounter.Count;
                    UsedCounter.Add(true);
                }
                ID = nextIndex;
            }
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