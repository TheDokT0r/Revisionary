namespace Revisionary
{
    partial class Set_Title
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_title = new System.Windows.Forms.TextBox();
            this.btn_continue = new System.Windows.Forms.Button();
            this.btn_GoBack = new System.Windows.Forms.Button();
            this.cmb_subjects = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(181, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(139, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subject:";
            // 
            // txb_title
            // 
            this.txb_title.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_title.Location = new System.Drawing.Point(286, 72);
            this.txb_title.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txb_title.Name = "txb_title";
            this.txb_title.Size = new System.Drawing.Size(430, 52);
            this.txb_title.TabIndex = 2;
            // 
            // btn_continue
            // 
            this.btn_continue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_continue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_continue.Location = new System.Drawing.Point(367, 471);
            this.btn_continue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_continue.Name = "btn_continue";
            this.btn_continue.Size = new System.Drawing.Size(189, 80);
            this.btn_continue.TabIndex = 4;
            this.btn_continue.Text = "Continue";
            this.btn_continue.UseVisualStyleBackColor = true;
            this.btn_continue.Click += new System.EventHandler(this.btn_continue_Click);
            // 
            // btn_GoBack
            // 
            this.btn_GoBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_GoBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_GoBack.Location = new System.Drawing.Point(773, 16);
            this.btn_GoBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_GoBack.Name = "btn_GoBack";
            this.btn_GoBack.Size = new System.Drawing.Size(128, 67);
            this.btn_GoBack.TabIndex = 5;
            this.btn_GoBack.Text = "Back to Menu";
            this.btn_GoBack.UseVisualStyleBackColor = true;
            this.btn_GoBack.Click += new System.EventHandler(this.btn_GoBack_Click);
            // 
            // cmb_subjects
            // 
            this.cmb_subjects.BackColor = System.Drawing.Color.White;
            this.cmb_subjects.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_subjects.FormattingEnabled = true;
            this.cmb_subjects.Items.AddRange(new object[] {
            "Language and literature",
            "Language acquisition",
            "Individuals and societies",
            "Sciences",
            "Mathematics",
            "The arts",
            "Others"});
            this.cmb_subjects.Location = new System.Drawing.Point(286, 199);
            this.cmb_subjects.Name = "cmb_subjects";
            this.cmb_subjects.Size = new System.Drawing.Size(430, 53);
            this.cmb_subjects.TabIndex = 6;
            // 
            // Set_Title
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.cmb_subjects);
            this.Controls.Add(this.btn_GoBack);
            this.Controls.Add(this.btn_continue);
            this.Controls.Add(this.txb_title);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Set_Title";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Revisionary";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
            this.Load += new System.EventHandler(this.Set_Title_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txb_title;
        private Button btn_continue;
        private Button btn_GoBack;
        private ComboBox cmb_subjects;
    }
}