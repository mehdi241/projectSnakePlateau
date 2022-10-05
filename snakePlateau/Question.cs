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
    internal class Question
    {
        static List<Question> list = new List<Question>();
        string _question;
        List<string> _responses;
        int bonneReponse;

        public Question(string question, List<string> responses)
        {
            this.Question_ = question;
            this.Responses = responses;

            list.Add(this);
        }

        public string Question_ { get => _question; set => _question = value; }
        public List<string> Responses { get => _responses; set => _responses = value; }
        public int BonneReponse { get => bonneReponse; set => bonneReponse = value; }

        public bool Repondre(int reponse) 
        {
            if(reponse == BonneReponse)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}