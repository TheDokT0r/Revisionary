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
        int currentQuestionPos;
        CardsSet cardsSet;
        List<TextBox> OptionsTB;
        List<RadioButton> IsRightAnswerList;
        List<int> RightAnswerPos; //Position of right answer in each question


        public Create_Set(string name, string subject)
        {
            currentQuestionPos = 0;
            cardsSet = new CardsSet(name, subject, new Card[0]);
            OptionsTB = new List<TextBox>();
            IsRightAnswerList = new List<RadioButton>();
            RightAnswerPos = new List<int>();

            InitializeComponent();
        }


        private void Create_Set_Load(object sender, EventArgs e)
        {
            OptionsTB.Add(txb_option0);
            IsRightAnswerList.Add(tick_RightAnswer);
        }


        void SetNextQuestion()
        {
            currentQuestionPos++;
            lbl_title.Text = "Set Question Number #" + currentQuestionPos + 1;

            txb_question.Text = "Question";

            for(int i = 0; i < OptionsTB.Count; i++)
            {
                if (i != 0) //Starts from 0 to not set an error in case of an emepty list
                {
                    OptionsTB[i].Visible = false;
                    IsRightAnswerList[i].Visible = false;
                }
            }

            try
            {
                var tempTextBox = OptionsTB[0];
                tempTextBox.Text = "Insert answer here";
                tempTextBox.Visible = true;

                OptionsTB.Clear();
                OptionsTB.Add(tempTextBox);

                var tempTick = IsRightAnswerList[0];
                IsRightAnswerList.Clear();
                IsRightAnswerList.Add(tempTick);
            }
            catch //Happends in the first time
            {
                OptionsTB.Clear();
                OptionsTB.Add(txb_option0);
            }
        }


        private void btn_addAnswer_Click(object sender, EventArgs e) //Adds a new answer textbox
        {
            if(OptionsTB.Count >= 5)
            {
                MessageBox.Show("Can only add maximun of 6 options", "Error");
                return;
            }

            //Make a copy of the last textbox in the list and call it "newTextBox"
            var newTextBox = new TextBox();
            newTextBox.Size = OptionsTB[OptionsTB.Count - 1].Size;
            newTextBox.Font = OptionsTB[OptionsTB.Count - 1].Font;
            newTextBox.Visible = true;
            newTextBox.TextAlign = HorizontalAlignment.Center;

            
            newTextBox.Text = "Insert answer here";

            //Put newTextBox below the last one in the list
            newTextBox.Location = OptionsTB[OptionsTB.Count - 1].Location;
            newTextBox.Location = new Point(newTextBox.Location.X, newTextBox.Location.Y + newTextBox.Height + 24);

            OptionsTB.Add(newTextBox);
            this.Controls.Add(OptionsTB[OptionsTB.Count - 1]);

            //Make a copy of the last RadioButton in the list and call it "newTick"
            var newTick = new RadioButton();
            newTick.Size = IsRightAnswerList[IsRightAnswerList.Count - 1].Size;
            newTick.Font = IsRightAnswerList[IsRightAnswerList.Count - 1].Font;
            newTick.Visible = true;
            newTick.Text = "Right Answer";

            //Put newTick below the last one in the list
            newTick.Location = IsRightAnswerList[IsRightAnswerList.Count - 1].Location;
            newTick.Location = new Point(newTick.Location.X, newTick.Location.Y + newTick.Height + 34);
            IsRightAnswerList.Add(newTick);
            Controls.Add(IsRightAnswerList[IsRightAnswerList.Count - 1]);

            //MessageBox.Show(Convert.ToString(Controls.Count)); //Debug
        }


        bool IsDataValid() //Checks if the data submited by the usr is valid
        {
            int rightAnswersCounter = 0;
            for (int i = 0; i < IsRightAnswerList.Count; i++)
            {
                if (IsRightAnswerList[i].Checked)
                {
                    rightAnswersCounter++;
                }
            }

            if (rightAnswersCounter != 1)
            {
                MessageBox.Show("There can only be one right answer!", "Error");
                return false;
            }

            if(txb_question.Text == string.Empty)
            {
                MessageBox.Show("Invalid question", "Error");
                return false;
            }

            return true;
        }


        void SubmitQuestion() 
        {
            int rightAnswerPos = -1;

            for (int i = 0; i < IsRightAnswerList.Count; i++)
            {
                if (IsRightAnswerList[i].Checked)
                {
                    rightAnswerPos = i;
                }
            }
            RightAnswerPos.Add(rightAnswerPos);

            //Sets the textBoxes into strings
            var wrongAnswers = new List<string>();

            for(int i = 0; i < OptionsTB.Count; i++)
            {
                if (i != rightAnswerPos)
                {
                    wrongAnswers.Add(OptionsTB[i].Text);
                }
            }
            
            var card = new Card(txb_question.Text, OptionsTB[rightAnswerPos].Text, wrongAnswers.ToArray());
            cardsSet.AddCard(card);
        }


        private void btn_next_Click(object sender, EventArgs e)
        {
            if(!IsDataValid())
            {
                return;
            }

            SubmitQuestion();
            SetNextQuestion();
        }


        private void btn_Done_Click(object sender, EventArgs e)
        {
            if(!IsDataValid())
            {
                return;
            }

            SubmitQuestion();
            MannageSets.SaveSet(cardsSet); //Saves set to json file

            MessageBox.Show("Done!");

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
