using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revisionary
{
    public partial class Create_Set : Form
    {
        List<Card> cards;
        List<TextBox> wrongAnswersTxb;
        int questionsCounter;

        string title, subject;

        public Create_Set(string title, string subject)
        {
            InitializeComponent();
            cards = new List<Card>();
            wrongAnswersTxb = new List<TextBox>() { 
                txb_wrong1,
                txb_wrong2,
                txb_wrong3,
                txb_wrong4,
                txb_wrong5
            };

            questionsCounter = 0; //Sets the questions counter

            this.title = title;
            this.subject = subject;
        }

        private void Create_Set_Load(object sender, EventArgs e)
        {

        }

        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (!AllDataFilled())
            {
                MessageBox.Show("Not all data has been field. Please try again!");
                return;
            }

            saveData();
        }

        private void saveData()
        {
            //Saves the data to the cards list
            var wrongAnswers = new List<string>();

            foreach (var txb in wrongAnswersTxb)
            {
                if (txb.Text != "") //Only adds the answer if it has being filled
                {
                    wrongAnswers.Add(txb.Text);
                }
            }

            Card currentCard = new Card(txb_question.Text, txb_rightAnswer.Text, wrongAnswers.ToArray());
            cards.Add(currentCard);

            //Updates the questions counter
            questionsCounter++;
            lbl_questionNum.Text = "Question #" + questionsCounter;

            clearTxb();
        }

        
        private void clearTxb()
        {
            foreach(var txb in wrongAnswersTxb)
            {
                txb.Text = string.Empty;
            }

            txb_question.Text = string.Empty;
            txb_rightAnswer.Text = string.Empty;
        }



        private void btn_done_Click(object sender, EventArgs e)
        {
            /*if(questionsCounter < 1)
            {
                Menu menu = new Menu();
                menu.Show();
                Hide();

                return;
            }*/

            if(!AllDataFilled())
            {
                MessageBox.Show("Not all data has been field. Please try again!");
                return;
            }

            saveData();

            CardsSet cardsSet = new CardsSet(title, subject, cards.ToArray());

            MannageSets.SaveSet(cardsSet); //Saving the set into a json file

            MessageBox.Show("Set " + cardsSet.title + " was saved seccesfuly into the database", "Card set has been saved!", MessageBoxButtons.OK);

            ProfileMannager.CreatedSet();

            Menu menu1 = new Menu();
            menu1.Show();
            Hide();
        }

        private void btn_GoBack_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            Hide();
        }

        bool AllDataFilled()
        {
            if(txb_question.Text == "" || txb_rightAnswer.Text == "")
            {
                return false;
            }

            return true;
        }
    }
}
