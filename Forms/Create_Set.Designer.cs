namespace Revisionary
{
    partial class Create_Set
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_addAnswer = new System.Windows.Forms.Button();
            this.tick_RightAnswer = new System.Windows.Forms.RadioButton();
            this.txb_question = new System.Windows.Forms.TextBox();
            this.txb_option0 = new System.Windows.Forms.TextBox();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_Done = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_title.Location = new System.Drawing.Point(396, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(374, 45);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Set Question Number #0";
            // 
            // btn_addAnswer
            // 
            this.btn_addAnswer.Location = new System.Drawing.Point(165, 158);
            this.btn_addAnswer.Name = "btn_addAnswer";
            this.btn_addAnswer.Size = new System.Drawing.Size(117, 45);
            this.btn_addAnswer.TabIndex = 2;
            this.btn_addAnswer.Text = "Add Answer";
            this.btn_addAnswer.UseVisualStyleBackColor = true;
            this.btn_addAnswer.Click += new System.EventHandler(this.btn_addAnswer_Click);
            // 
            // tick_RightAnswer
            // 
            this.tick_RightAnswer.AutoSize = true;
            this.tick_RightAnswer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tick_RightAnswer.Location = new System.Drawing.Point(721, 176);
            this.tick_RightAnswer.Name = "tick_RightAnswer";
            this.tick_RightAnswer.Size = new System.Drawing.Size(121, 25);
            this.tick_RightAnswer.TabIndex = 3;
            this.tick_RightAnswer.TabStop = true;
            this.tick_RightAnswer.Text = "Right Answer";
            this.tick_RightAnswer.UseVisualStyleBackColor = true;
            // 
            // txb_question
            // 
            this.txb_question.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_question.Location = new System.Drawing.Point(302, 72);
            this.txb_question.Name = "txb_question";
            this.txb_question.Size = new System.Drawing.Size(551, 35);
            this.txb_question.TabIndex = 1;
            this.txb_question.Text = "Question";
            this.txb_question.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txb_option0
            // 
            this.txb_option0.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_option0.Location = new System.Drawing.Point(302, 168);
            this.txb_option0.Name = "txb_option0";
            this.txb_option0.Size = new System.Drawing.Size(392, 35);
            this.txb_option0.TabIndex = 4;
            this.txb_option0.Text = "Insert Answer Here";
            this.txb_option0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(1121, 17);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(131, 46);
            this.btn_next.TabIndex = 5;
            this.btn_next.Text = "Next Question";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_Done
            // 
            this.btn_Done.Location = new System.Drawing.Point(1039, 69);
            this.btn_Done.Name = "btn_Done";
            this.btn_Done.Size = new System.Drawing.Size(213, 78);
            this.btn_Done.TabIndex = 6;
            this.btn_Done.Text = "Done";
            this.btn_Done.UseVisualStyleBackColor = true;
            this.btn_Done.Click += new System.EventHandler(this.btn_Done_Click);
            // 
            // Create_Set
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btn_Done);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.txb_option0);
            this.Controls.Add(this.tick_RightAnswer);
            this.Controls.Add(this.btn_addAnswer);
            this.Controls.Add(this.txb_question);
            this.Controls.Add(this.lbl_title);
            this.Name = "Create_Set";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Revisionary";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
            this.Load += new System.EventHandler(this.Create_Set_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_title;
        private Button btn_addAnswer;
        private RadioButton tick_RightAnswer;
        private TextBox txb_question;
        private TextBox txb_option0;
        private Button btn_next;
        private Button btn_Done;
    }
}