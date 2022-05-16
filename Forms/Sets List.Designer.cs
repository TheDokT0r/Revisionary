namespace Revisionary
{
    partial class Sets_List
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
            this.view_SetsList = new System.Windows.Forms.ListBox();
            this.btn_selectSet = new System.Windows.Forms.Button();
            this.btn_backToMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // view_SetsList
            // 
            this.view_SetsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.view_SetsList.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.view_SetsList.ForeColor = System.Drawing.Color.White;
            this.view_SetsList.FormattingEnabled = true;
            this.view_SetsList.ItemHeight = 40;
            this.view_SetsList.Location = new System.Drawing.Point(231, 117);
            this.view_SetsList.Name = "view_SetsList";
            this.view_SetsList.Size = new System.Drawing.Size(677, 364);
            this.view_SetsList.TabIndex = 0;
            this.view_SetsList.SelectedIndexChanged += new System.EventHandler(this.view_SetsList_SelectedIndexChanged);
            // 
            // btn_selectSet
            // 
            this.btn_selectSet.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btn_selectSet.BackColor = System.Drawing.Color.White;
            this.btn_selectSet.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_selectSet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_selectSet.Location = new System.Drawing.Point(981, 117);
            this.btn_selectSet.Name = "btn_selectSet";
            this.btn_selectSet.Size = new System.Drawing.Size(208, 76);
            this.btn_selectSet.TabIndex = 1;
            this.btn_selectSet.Text = "Select";
            this.btn_selectSet.UseVisualStyleBackColor = false;
            this.btn_selectSet.Click += new System.EventHandler(this.btn_selectSet_Click);
            // 
            // btn_backToMenu
            // 
            this.btn_backToMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btn_backToMenu.BackColor = System.Drawing.Color.White;
            this.btn_backToMenu.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_backToMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_backToMenu.Location = new System.Drawing.Point(981, 405);
            this.btn_backToMenu.Name = "btn_backToMenu";
            this.btn_backToMenu.Size = new System.Drawing.Size(208, 76);
            this.btn_backToMenu.TabIndex = 3;
            this.btn_backToMenu.Text = "Back to Menu";
            this.btn_backToMenu.UseVisualStyleBackColor = false;
            this.btn_backToMenu.Click += new System.EventHandler(this.btn_backToMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(444, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 54);
            this.label1.TabIndex = 4;
            this.label1.Text = "Export Set";
            // 
            // Sets_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_backToMenu);
            this.Controls.Add(this.btn_selectSet);
            this.Controls.Add(this.view_SetsList);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Sets_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sets_List";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
            this.Load += new System.EventHandler(this.Sets_List_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox view_SetsList;
        private Button btn_selectSet;
        private Button btn_backToMenu;
        private Label label1;
    }
}