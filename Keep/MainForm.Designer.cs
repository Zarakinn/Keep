namespace Keep
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SiteslistBox = new System.Windows.Forms.ListBox();
            this.SitesText = new System.Windows.Forms.Label();
            this.CCButton = new System.Windows.Forms.Button();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.DisplayTextBox = new System.Windows.Forms.TextBox();
            this.AddSiteButton = new System.Windows.Forms.Button();
            this.AddSiteLabel = new System.Windows.Forms.Label();
            this.SiteNameLabel = new System.Windows.Forms.Label();
            this.SiteNameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordConfirmationTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordConfirmationLabel = new System.Windows.Forms.Label();
            this.infoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SiteslistBox
            // 
            this.SiteslistBox.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.SiteslistBox.FormattingEnabled = true;
            this.SiteslistBox.ItemHeight = 37;
            this.SiteslistBox.Location = new System.Drawing.Point(42, 100);
            this.SiteslistBox.Name = "SiteslistBox";
            this.SiteslistBox.Size = new System.Drawing.Size(261, 374);
            this.SiteslistBox.TabIndex = 0;
            // 
            // SitesText
            // 
            this.SitesText.AutoSize = true;
            this.SitesText.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.SitesText.Location = new System.Drawing.Point(35, 28);
            this.SitesText.Name = "SitesText";
            this.SitesText.Size = new System.Drawing.Size(89, 38);
            this.SitesText.TabIndex = 1;
            this.SitesText.Text = "Sites :";
            // 
            // CCButton
            // 
            this.CCButton.BackColor = System.Drawing.Color.White;
            this.CCButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CCButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CCButton.Location = new System.Drawing.Point(330, 100);
            this.CCButton.Name = "CCButton";
            this.CCButton.Size = new System.Drawing.Size(183, 74);
            this.CCButton.TabIndex = 2;
            this.CCButton.Text = "Copie Presse Papier";
            this.CCButton.UseVisualStyleBackColor = true;
            this.CCButton.Click += new System.EventHandler(this.CCButton_Click);
            // 
            // DisplayButton
            // 
            this.DisplayButton.BackColor = System.Drawing.Color.White;
            this.DisplayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DisplayButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayButton.Location = new System.Drawing.Point(330, 195);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(183, 74);
            this.DisplayButton.TabIndex = 3;
            this.DisplayButton.Text = "Afficher en clair";
            this.DisplayButton.UseVisualStyleBackColor = true;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.White;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(330, 295);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(183, 74);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Supprimer";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // DisplayTextBox
            // 
            this.DisplayTextBox.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.DisplayTextBox.Location = new System.Drawing.Point(330, 402);
            this.DisplayTextBox.Name = "DisplayTextBox";
            this.DisplayTextBox.Size = new System.Drawing.Size(183, 43);
            this.DisplayTextBox.TabIndex = 5;
            // 
            // AddSiteButton
            // 
            this.AddSiteButton.BackColor = System.Drawing.Color.White;
            this.AddSiteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSiteButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSiteButton.Location = new System.Drawing.Point(551, 421);
            this.AddSiteButton.Name = "AddSiteButton";
            this.AddSiteButton.Size = new System.Drawing.Size(183, 53);
            this.AddSiteButton.TabIndex = 6;
            this.AddSiteButton.Text = "Ajouter";
            this.AddSiteButton.UseVisualStyleBackColor = true;
            this.AddSiteButton.Click += new System.EventHandler(this.AddSiteButton_Click);
            // 
            // AddSiteLabel
            // 
            this.AddSiteLabel.AutoSize = true;
            this.AddSiteLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSiteLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.AddSiteLabel.Location = new System.Drawing.Point(550, 34);
            this.AddSiteLabel.Name = "AddSiteLabel";
            this.AddSiteLabel.Size = new System.Drawing.Size(184, 32);
            this.AddSiteLabel.TabIndex = 7;
            this.AddSiteLabel.Text = "Ajouter un site :";
            // 
            // SiteNameLabel
            // 
            this.SiteNameLabel.AutoSize = true;
            this.SiteNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SiteNameLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.SiteNameLabel.Location = new System.Drawing.Point(551, 100);
            this.SiteNameLabel.Name = "SiteNameLabel";
            this.SiteNameLabel.Size = new System.Drawing.Size(119, 28);
            this.SiteNameLabel.TabIndex = 8;
            this.SiteNameLabel.Text = "Nom du site";
            // 
            // SiteNameTextBox
            // 
            this.SiteNameTextBox.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.SiteNameTextBox.Location = new System.Drawing.Point(551, 142);
            this.SiteNameTextBox.Name = "SiteNameTextBox";
            this.SiteNameTextBox.Size = new System.Drawing.Size(183, 43);
            this.SiteNameTextBox.TabIndex = 9;
            // 
            // PasswordConfirmationTextBox
            // 
            this.PasswordConfirmationTextBox.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.PasswordConfirmationTextBox.Location = new System.Drawing.Point(551, 351);
            this.PasswordConfirmationTextBox.Name = "PasswordConfirmationTextBox";
            this.PasswordConfirmationTextBox.PasswordChar = '*';
            this.PasswordConfirmationTextBox.Size = new System.Drawing.Size(183, 43);
            this.PasswordConfirmationTextBox.TabIndex = 11;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.PasswordTextBox.Location = new System.Drawing.Point(551, 245);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(183, 43);
            this.PasswordTextBox.TabIndex = 10;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.PasswordLabel.Location = new System.Drawing.Point(549, 205);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(129, 28);
            this.PasswordLabel.TabIndex = 12;
            this.PasswordLabel.Text = "Mot de passe";
            // 
            // PasswordConfirmationLabel
            // 
            this.PasswordConfirmationLabel.AutoSize = true;
            this.PasswordConfirmationLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordConfirmationLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.PasswordConfirmationLabel.Location = new System.Drawing.Point(549, 305);
            this.PasswordConfirmationLabel.Name = "PasswordConfirmationLabel";
            this.PasswordConfirmationLabel.Size = new System.Drawing.Size(127, 28);
            this.PasswordConfirmationLabel.TabIndex = 13;
            this.PasswordConfirmationLabel.Text = "Confirmation";
            // 
            // infoButton
            // 
            this.infoButton.BackColor = System.Drawing.Color.White;
            this.infoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoButton.ForeColor = System.Drawing.Color.Transparent;
            this.infoButton.Image = global::Keep.Properties.Resources.icon32;
            this.infoButton.Location = new System.Drawing.Point(142, 480);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(32, 32);
            this.infoButton.TabIndex = 14;
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(772, 532);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.PasswordConfirmationLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.PasswordConfirmationTextBox);
            this.Controls.Add(this.SiteNameTextBox);
            this.Controls.Add(this.SiteNameLabel);
            this.Controls.Add(this.AddSiteLabel);
            this.Controls.Add(this.AddSiteButton);
            this.Controls.Add(this.DisplayTextBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.DisplayButton);
            this.Controls.Add(this.CCButton);
            this.Controls.Add(this.SitesText);
            this.Controls.Add(this.SiteslistBox);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Keep";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.ListBox SiteslistBox;
        private System.Windows.Forms.Label SitesText;
        private System.Windows.Forms.Button CCButton;
        private System.Windows.Forms.Button DisplayButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TextBox DisplayTextBox;
        private System.Windows.Forms.Button AddSiteButton;
        private System.Windows.Forms.Label AddSiteLabel;
        private System.Windows.Forms.Label SiteNameLabel;
        private System.Windows.Forms.TextBox SiteNameTextBox;
        private System.Windows.Forms.TextBox PasswordConfirmationTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label PasswordConfirmationLabel;
        private System.Windows.Forms.Button infoButton;
    }
}