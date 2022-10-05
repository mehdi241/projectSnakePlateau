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
    public partial class FrmQuestion : Form
    {
        Question a;
        public FrmQuestion(List<string> reponses, string question)
        {
            InitializeComponent();
            
            a = new Question(question, reponses);

            lblQuestion.Text = a.Question_;
            rBtnRep1.Text = a.Responses[0];
            rBtnRep2.Text = a.Responses[1];
            rBtnRep3.Text = a.Responses[2];

            rBtnRep1.Tag = 0;
            rBtnRep2.Tag = 1;
            rBtnRep3.Tag = 2;
        }
    }
}
