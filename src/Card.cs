using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisionary
{
    public class Card //Cards that contain questions and answers
    {
        public string question;
        public string rightAnswer;
        public string[] wrongAnswers;

        public Card(string question, string rightAnswer, string[] wrongAnswers)
        {
            this.question = question;
            this.rightAnswer = rightAnswer;
            this.wrongAnswers = wrongAnswers;
        }
    }
}
