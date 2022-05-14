using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Revisionary
{
    public partial class Game : Form
    {
        CardsSet cardsSet;
        int currentCardIndex = 0;
        List<Button> Buttons;
        int rightAnswersCounter = 0;

        public Game(CardsSet set)
        {
            cardsSet = set;
            cardsSet.cards = RandomizeSet(cardsSet.cards);
            currentCardIndex = 0;

            //buttons = this.Controls.OfType<Button>().ToList();
            Buttons = new List<Button>();

            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            //Displays initial data
            lbl_title.Text = cardsSet.title + "\n" + cardsSet.subject;

            DisplayNextQuestion();
        }

                
        
        Card[] RandomizeSet(Card[] cards) //Randomizes the cards of the set to appear in a random order
        {
            Random random = new Random();
            cards = cards.OrderBy(x => random.Next()).ToArray();

            return cards;
        }


        string[] RandomizeAnswersOrder(Card card)
        {
            //Sets wrong and right answers to one array
            string[] options = new string[card.wrongAnswers.Length + 1];

            for (int i = 0; i < card.wrongAnswers.Length; i++)
            {
                options[i] = card.wrongAnswers[i];
            }

            options[options.Length - 1] = card.rightAnswer;


            //Randomizes
            Random rnd = new Random();
            var newArr = new List<string>();
            List<int> usedIndexes = new List<int>();

            while (newArr.Count < options.Length)
            {
                int index = rnd.Next(0, options.Length);

                if (!usedIndexes.Contains(index))
                {
                    usedIndexes.Add(index);
                    newArr.Add(options[index]);
                }
            }

            return newArr.ToArray();
        }


        void DisplayNextQuestion()
        {
            var currentCard = cardsSet.cards[currentCardIndex];
            var answers = RandomizeAnswersOrder(currentCard);

            //MessageBox.Show(Convert.ToString(buttons.Count));


            int left = 300;
            int top = 250;
            int btnCounter = 1;

            for(int i = 0; i < answers.Length; i++)
            {

                //Set a new button
                Button button = new Button();

                button.Left = left;
                button.Top = top;

                button.Size = new Size(150, 100);
                button.Text = answers[i];
                button.BackColor = Color.Beige;
                button.ForeColor = Color.Black;
                button.Click += new System.EventHandler(this.click_answer_handaler);

                this.Controls.Add(button);


                //Sets the place where the buttons would spawn
                if(btnCounter % 3 == 0 && btnCounter != 0)
                {
                    top += 200;

                    if (answers.Length < 6)
                    {
                        left = 400;
                    }
                    else
                    {
                        left = 300;
                    }
                }
                else
                {
                    left += 200;
                }

                btnCounter++;
                Buttons.Add(button);
            }


            //Sets other data
            lbl_question.Text = currentCard.question;
            lbl_questionNumber.Text = currentCardIndex + "/" + cardsSet.cards.Length;
        }


        private void click_answer_handaler(object sender, EventArgs e) //btn, when the user clicks on a day, it shall take him to the data on said day
        {
            var btn = sender as Button; //Sets the sender back as a button
            var currentCard = cardsSet.cards[currentCardIndex];

            if(btn.Text == currentCard.rightAnswer)
            {
                rightAnswersCounter++;
            }

            //Loops over the btns and set their color according to which one was right and which one wasn't
            for(int i = 0; i < Buttons.Count; i++)
            {
                if(Buttons[i].Text == currentCard.rightAnswer)
                {
                    Buttons[i].BackColor = Color.Green;
                }
                else
                {
                    Buttons[i].BackColor = Color.Red;
                }
            }


            //Displays if the answer was correct or wrong
            lbl_correctOrWrong.Visible = true;
            if(btn.Text == currentCard.rightAnswer)
            {
                lbl_correctOrWrong.ForeColor = Color.Green;
                lbl_correctOrWrong.Text = "Currect!";
            }
            else
            {
                lbl_correctOrWrong.ForeColor = Color.Red;
                lbl_correctOrWrong.Text = "Wrong!";
            }

            WaitNSeconds(2);
            MoveToNextQuestion();
        }


        private void WaitNSeconds(int segundos)
        {
            if (segundos < 1) return;
            DateTime _desired = DateTime.Now.AddSeconds(segundos);
            while (DateTime.Now < _desired)
            {
                Application.DoEvents();
            }
        }


        void MoveToNextQuestion() //Resets the form to be ready for the next card
        {
            currentCardIndex++;


            foreach(var btn in Buttons)
            {
                btn.Visible = false;
            }
            lbl_correctOrWrong.Visible = false;

            Buttons.RemoveRange(0, Buttons.Count); //Removes the buttons from the list


            if (currentCardIndex < cardsSet.cards.Length)
            {
                DisplayNextQuestion();
            }
            else
            {
                //Finsih the game, will you?
                lbl_stuts.Text = "You've answered " + rightAnswersCounter + "/" + cardsSet.cards.Length + "questions correctly!";

                lbl_stuts.TextAlign = ContentAlignment.MiddleCenter;
                lbl_stuts.Visible = true;
                btn_backToMenu.Visible = true;
                btn_playAgain.Visible = true;
            }
        }



        private void btn_playAgain_Click(object sender, EventArgs e)
        {
            Game game = new Game(cardsSet);
            game.Show();
            Hide();
        }

        private void btn_backToMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            Hide();
        }


        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
