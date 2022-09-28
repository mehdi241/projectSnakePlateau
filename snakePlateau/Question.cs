using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question
{
    partial class Question
    {
        string _question;
        List<string> _responses;
        int bonneReponse;

        public Question(string question, List<string> responses)
        {
            this._question = question;
            this._responses = responses;
        }

        public bool Repondre(int reponse) 
        {
            if(reponse == bonneReponse)
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