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
            this.btn_import = new System.Windows.Forms.Button();
            this.btn_backToMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // view_SetsList
            // 
            this.view_SetsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.view_SetsList.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.view_SetsList.ForeColor = System.Drawing.Color.White;
            this.view_SetsList.FormattingEnabled = true;
            this.view_SetsList.ItemHeight = 32;
            this.view_SetsList.Location = new System.Drawing.Point(202, 88);
            this.view_SetsList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.view_SetsList.Name = "view_SetsList";
            this.view_SetsList.Size = new System.Drawing.Size(593, 292);
            this.view_SetsList.TabIndex = 0;
            this.view_SetsList.SelectedIndexChanged += new System.EventHandler(this.view_SetsList_SelectedIndexChanged);
            // 
            // btn_selectSet
            // 
            this.btn_selectSet.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btn_selectSet.BackColor = System.Drawing.Color.White;
            this.btn_selectSet.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_selectSet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_selectSet.Location = new System.Drawing.Point(858, 124);
            this.btn_selectSet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_selectSet.Name = "btn_selectSet";
            this.btn_selectSet.Size = new System.Drawing.Size(182, 57);
            this.btn_selectSet.TabIndex = 1;
            this.btn_selectSet.Text = "Select";
            this.btn_selectSet.UseVisualStyleBackColor = false;
            this.btn_selectSet.Visible = false;
            this.btn_selectSet.Click += new System.EventHandler(this.btn_selectSet_Click);
            // 
            // btn_import
            // 
            this.btn_import.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btn_import.BackColor = System.Drawing.Color.White;
            this.btn_import.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_import.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_import.Location = new System.Drawing.Point(858, 214);
            this.btn_import.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(182, 57);
            this.btn_import.TabIndex = 2;
            this.btn_import.Text = "Import Sets";
            this.btn_import.UseVisualStyleBackColor = false;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // btn_backToMenu
            // 
            this.btn_backToMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btn_backToMenu.BackColor = System.Drawing.Color.White;
            this.btn_backToMenu.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_backToMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_backToMenu.Location = new System.Drawing.Point(858, 312);
            this.btn_backToMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_backToMenu.Name = "btn_backToMenu";
            this.btn_backToMenu.Size = new System.Drawing.Size(182, 57);
            this.btn_backToMenu.TabIndex = 3;
            this.btn_backToMenu.Text = "Back to Menu";
            this.btn_backToMenu.UseVisualStyleBackColor = false;
            this.btn_backToMenu.Click += new System.EventHandler(this.btn_backToMenu_Click);
            // 
            // Sets_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1104, 505);
            this.Controls.Add(this.btn_backToMenu);
            this.Controls.Add(this.btn_import);
            this.Controls.Add(this.btn_selectSet);
            this.Controls.Add(this.view_SetsList);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Sets_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sets_List";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
            this.Load += new System.EventHandler(this.Sets_List_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox view_SetsList;
        private Button btn_selectSet;
        private Button btn_import;
        private Button btn_backToMenu;
    }
}