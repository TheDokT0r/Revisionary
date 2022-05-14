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
            this.lbl_questionNum = new System.Windows.Forms.Label();
            this.txb_rightAnswer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_wrong1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_wrong2 = new System.Windows.Forms.TextBox();
            this.txb_wrong3 = new System.Windows.Forms.TextBox();
            this.txb_wrong4 = new System.Windows.Forms.TextBox();
            this.txb_wrong5 = new System.Windows.Forms.TextBox();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_done = new System.Windows.Forms.Button();
            this.txb_question = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_GoBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_questionNum
            // 
            this.lbl_questionNum.AutoSize = true;
            this.lbl_questionNum.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_questionNum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_questionNum.Location = new System.Drawing.Point(431, 9);
            this.lbl_questionNum.Name = "lbl_questionNum";
            this.lbl_questionNum.Size = new System.Drawing.Size(181, 41);
            this.lbl_questionNum.TabIndex = 4;
            this.lbl_questionNum.Text = "Question #0";
            // 
            // txb_rightAnswer
            // 
            this.txb_rightAnswer.Location = new System.Drawing.Point(249, 119);
            this.txb_rightAnswer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_rightAnswer.Name = "txb_rightAnswer";
            this.txb_rightAnswer.Size = new System.Drawing.Size(218, 23);
            this.txb_rightAnswer.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(46, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Right Answer:";
            // 
            // txb_wrong1
            // 
            this.txb_wrong1.Location = new System.Drawing.Point(736, 119);
            this.txb_wrong1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_wrong1.Name = "txb_wrong1";
            this.txb_wrong1.Size = new System.Drawing.Size(218, 23);
            this.txb_wrong1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(501, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 37);
            this.label4.TabIndex = 7;
            this.label4.Text = "Wrong Answers:";
            // 
            // txb_wrong2
            // 
            this.txb_wrong2.Location = new System.Drawing.Point(736, 156);
            this.txb_wrong2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_wrong2.Name = "txb_wrong2";
            this.txb_wrong2.Size = new System.Drawing.Size(218, 23);
            this.txb_wrong2.TabIndex = 9;
            // 
            // txb_wrong3
            // 
            this.txb_wrong3.Location = new System.Drawing.Point(736, 193);
            this.txb_wrong3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_wrong3.Name = "txb_wrong3";
            this.txb_wrong3.Size = new System.Drawing.Size(218, 23);
            this.txb_wrong3.TabIndex = 10;
            // 
            // txb_wrong4
            // 
            this.txb_wrong4.Location = new System.Drawing.Point(736, 234);
            this.txb_wrong4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_wrong4.Name = "txb_wrong4";
            this.txb_wrong4.Size = new System.Drawing.Size(218, 23);
            this.txb_wrong4.TabIndex = 11;
            // 
            // txb_wrong5
            // 
            this.txb_wrong5.Location = new System.Drawing.Point(736, 274);
            this.txb_wrong5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_wrong5.Name = "txb_wrong5";
            this.txb_wrong5.Size = new System.Drawing.Size(218, 23);
            this.txb_wrong5.TabIndex = 12;
            // 
            // btn_next
            // 
            this.btn_next.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_next.Location = new System.Drawing.Point(586, 415);
            this.btn_next.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(261, 53);
            this.btn_next.TabIndex = 13;
            this.btn_next.Text = "Next Card";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_done
            // 
            this.btn_done.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_done.Location = new System.Drawing.Point(213, 415);
            this.btn_done.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_done.Name = "btn_done";
            this.btn_done.Size = new System.Drawing.Size(261, 53);
            this.btn_done.TabIndex = 14;
            this.btn_done.Text = "Done";
            this.btn_done.UseVisualStyleBackColor = true;
            this.btn_done.Click += new System.EventHandler(this.btn_done_Click);
            // 
            // txb_question
            // 
            this.txb_question.Location = new System.Drawing.Point(501, 75);
            this.txb_question.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_question.Name = "txb_question";
            this.txb_question.Size = new System.Drawing.Size(218, 23);
            this.txb_question.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(344, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 37);
            this.label5.TabIndex = 15;
            this.label5.Text = "Question:";
            // 
            // btn_GoBack
            // 
            this.btn_GoBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_GoBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_GoBack.Location = new System.Drawing.Point(980, 12);
            this.btn_GoBack.Name = "btn_GoBack";
            this.btn_GoBack.Size = new System.Drawing.Size(112, 50);
            this.btn_GoBack.TabIndex = 17;
            this.btn_GoBack.Text = "Back to Menu";
            this.btn_GoBack.UseVisualStyleBackColor = true;
            this.btn_GoBack.Click += new System.EventHandler(this.btn_GoBack_Click);
            // 
            // Create_Set
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1104, 505);
            this.Controls.Add(this.btn_GoBack);
            this.Controls.Add(this.txb_question);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_done);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.txb_wrong5);
            this.Controls.Add(this.txb_wrong4);
            this.Controls.Add(this.txb_wrong3);
            this.Controls.Add(this.txb_wrong2);
            this.Controls.Add(this.txb_wrong1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txb_rightAnswer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_questionNum);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Create_Set";
            this.Text = "Create_Set";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
            this.Load += new System.EventHandler(this.Create_Set_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lbl_questionNum;
        private TextBox txb_rightAnswer;
        private Label label3;
        private TextBox txb_wrong1;
        private Label label4;
        private TextBox txb_wrong2;
        private TextBox txb_wrong3;
        private TextBox txb_wrong4;
        private TextBox txb_wrong5;
        private Button btn_next;
        private Button btn_done;
        private TextBox txb_question;
        private Label label5;
        private Button btn_GoBack;
    }
}