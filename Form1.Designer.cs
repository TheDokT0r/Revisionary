namespace Revisionary
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_import = new System.Windows.Forms.Button();
            this.btn_profile = new System.Windows.Forms.Button();
            this.lbl_ver = new System.Windows.Forms.Label();
            this.lbl_credit = new System.Windows.Forms.Label();
            this.btn_exportSet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_title.Location = new System.Drawing.Point(419, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(317, 74);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Revisionary";
            // 
            // btn_create
            // 
            this.btn_create.BackColor = System.Drawing.Color.Transparent;
            this.btn_create.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_create.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_create.Location = new System.Drawing.Point(255, 579);
            this.btn_create.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(214, 68);
            this.btn_create.TabIndex = 1;
            this.btn_create.Text = "Create New Set";
            this.btn_create.UseVisualStyleBackColor = false;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_load
            // 
            this.btn_load.BackColor = System.Drawing.Color.Transparent;
            this.btn_load.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_load.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_load.Location = new System.Drawing.Point(12, 579);
            this.btn_load.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(214, 68);
            this.btn_load.TabIndex = 2;
            this.btn_load.Text = "Load Sets";
            this.btn_load.UseVisualStyleBackColor = false;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_import
            // 
            this.btn_import.BackColor = System.Drawing.Color.Transparent;
            this.btn_import.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_import.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_import.Location = new System.Drawing.Point(1017, 579);
            this.btn_import.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(214, 68);
            this.btn_import.TabIndex = 3;
            this.btn_import.Text = "Import Set";
            this.btn_import.UseVisualStyleBackColor = false;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // btn_profile
            // 
            this.btn_profile.BackgroundImage = global::Revisionary.Properties.Resources.button_profil_png_4;
            this.btn_profile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_profile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_profile.Location = new System.Drawing.Point(1175, 7);
            this.btn_profile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_profile.Name = "btn_profile";
            this.btn_profile.Size = new System.Drawing.Size(77, 63);
            this.btn_profile.TabIndex = 4;
            this.btn_profile.UseVisualStyleBackColor = true;
            this.btn_profile.Click += new System.EventHandler(this.btn_profile_Click);
            // 
            // lbl_ver
            // 
            this.lbl_ver.AutoSize = true;
            this.lbl_ver.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ver.Location = new System.Drawing.Point(3, 7);
            this.lbl_ver.Name = "lbl_ver";
            this.lbl_ver.Size = new System.Drawing.Size(110, 19);
            this.lbl_ver.TabIndex = 5;
            this.lbl_ver.Text = "Ver 1.0.1 - Static";
            // 
            // lbl_credit
            // 
            this.lbl_credit.AutoSize = true;
            this.lbl_credit.Location = new System.Drawing.Point(3, 26);
            this.lbl_credit.Name = "lbl_credit";
            this.lbl_credit.Size = new System.Drawing.Size(94, 30);
            this.lbl_credit.TabIndex = 6;
            this.lbl_credit.Text = "Created by Or. K\r\nDP2 year of 2022\r\n";
            // 
            // btn_exportSet
            // 
            this.btn_exportSet.BackColor = System.Drawing.Color.Transparent;
            this.btn_exportSet.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_exportSet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_exportSet.Location = new System.Drawing.Point(783, 579);
            this.btn_exportSet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_exportSet.Name = "btn_exportSet";
            this.btn_exportSet.Size = new System.Drawing.Size(214, 68);
            this.btn_exportSet.TabIndex = 7;
            this.btn_exportSet.Text = "Send Sets To Your Freinds!";
            this.btn_exportSet.UseVisualStyleBackColor = false;
            this.btn_exportSet.Click += new System.EventHandler(this.btn_exportSet_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btn_exportSet);
            this.Controls.Add(this.lbl_credit);
            this.Controls.Add(this.lbl_ver);
            this.Controls.Add(this.btn_profile);
            this.Controls.Add(this.btn_import);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.lbl_title);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Revisionary";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_title;
        private Button btn_create;
        private Button btn_load;
        private Button btn_import;
        private Button btn_profile;
        private Label lbl_ver;
        private Label lbl_credit;
        private Button btn_exportSet;
    }
}