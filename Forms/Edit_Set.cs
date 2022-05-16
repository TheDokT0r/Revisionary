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
    public partial class Edit_Set : Form
    {
        CardsSet set;
        List<TextBox> textBoxes;
        int index;
        public Edit_Set(CardsSet set)
        {
            InitializeComponent();

            this.set = set;
            textBoxes = new List<TextBox>();
        }

        private void Edit_Set_Load(object sender, EventArgs e)
        {
            foreach(var card in set.cards)
            {
                lst_questions.Items.Add(card.question);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if(lst_questions.SelectedItems == null || lst_questions.SelectedIndex < 0)
            {
                return;
            }

            index = lst_questions.SelectedIndex;

            setForEdit(lst_questions.SelectedIndex);
        }

        void setForEdit(int index) //Sets the form for editing
        {
            btn_edit.Visible = false;
            lbl_title.Visible = false;
            lst_questions.Visible = false;
            btn_submit.Visible = true;

            var usedCard = set.cards[index];

            //Creats a textbox for each answer in the usedCard object
            for (int i = 0; i < usedCard.wrongAnswers.Length; i++)
            {
                var answer = usedCard.wrongAnswers[i];
                var txt_answer = new TextBox();
                txt_answer.Text = answer;
                txt_answer.Location = new Point(10, 10 + (i * 30));
                txt_answer.Size = new Size(200, 20);
                txt_answer.Name = "txt_answer" + i;
                txt_answer.TabIndex = i;
                txt_answer.TextChanged += new EventHandler(txt_answer_TextChanged);
                //Increase the size of the text in txt_answer to 14
                txt_answer.Font = new Font(txt_answer.Font.FontFamily, 20);

                txt_answer.AutoSize = true;

                txt_answer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

                textBoxes.Add(txt_answer);
                this.Controls.Add(txt_answer);
            }


            //Create a new label (font 20) with the name "lbl_rightAnswer", to the right of the textboxes
            var lbl_rightAnswer = new Label();
            lbl_rightAnswer.Text = "Right Answer:";
            lbl_rightAnswer.Location = new Point(220, 10);
            lbl_rightAnswer.Size = new Size(100, 20);
            lbl_rightAnswer.Name = "lbl_rightAnswer";
            lbl_rightAnswer.TabIndex = 0;
            lbl_rightAnswer.AutoSize = true;
            lbl_rightAnswer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_rightAnswer.Font = new Font(lbl_rightAnswer.Font.FontFamily, 20);
            this.Controls.Add(lbl_rightAnswer);


            //Put to the right of lbl_rightAnswer a textbox with the name "txt_rightAnswer", in the same size of the textboxes
            var txt_rightAnswer = new TextBox();
            txt_rightAnswer.Text = usedCard.rightAnswer;
            txt_rightAnswer.Location = new Point(lbl_rightAnswer.Location.X, lbl_rightAnswer.Location.Y - 60);
            txt_rightAnswer.Size = new Size(200, 20);
            txt_rightAnswer.Name = "txt_rightAnswer";
            txt_rightAnswer.TabIndex = 1;
            txt_rightAnswer.Font = new Font(txt_rightAnswer.Font.FontFamily, 20);
            txt_rightAnswer.AutoSize = true;
            txt_rightAnswer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxes.Add(txt_rightAnswer);
            this.Controls.Add(txt_rightAnswer);
            textBoxes.Add(txt_rightAnswer);


            for (int i = 0; i < textBoxes.Count; i++)
            {
                textBoxes[i].Location = new Point(textBoxes[i].Location.X, textBoxes[i].Location.Y + (i * 40));
            }

        }

        private void txt_answer_TextChanged(object sender, EventArgs e)
        {
            var txt_answer = sender as TextBox;
            var index = txt_answer.TabIndex;
            var answer = txt_answer.Text;
            var usedCard = set.cards[index];
            usedCard.wrongAnswers[index] = answer;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < textBoxes.Count - 2; i++)
            {
                MessageBox.Show(Convert.ToString(i));
                set.cards[index].wrongAnswers[i] = textBoxes[i].Text;
            }
            set.cards[index].rightAnswer = textBoxes[textBoxes.Count - 1].Text;


            MannageSets.modifySet(set);
            MessageBox.Show("Set has been modified seccesfully!");

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
