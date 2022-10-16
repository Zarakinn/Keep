namespace Keep
{
    partial class LoginForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.ProfilText = new System.Windows.Forms.Label();
            this.profileList = new System.Windows.Forms.ComboBox();
            this.ClefText = new System.Windows.Forms.Label();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.AddProfilButton = new System.Windows.Forms.Button();
            this.ConnexionButton = new System.Windows.Forms.Button();
            this.profilTextBox = new System.Windows.Forms.TextBox();
            this.NewProfilText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProfilText
            // 
            this.ProfilText.AutoSize = true;
            this.ProfilText.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.ProfilText.Location = new System.Drawing.Point(80, 81);
            this.ProfilText.Name = "ProfilText";
            this.ProfilText.Size = new System.Drawing.Size(96, 38);
            this.ProfilText.TabIndex = 0;
            this.ProfilText.Text = "Profil :";
            // 
            // profileList
            // 
            this.profileList.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.profileList.FormattingEnabled = true;
            this.profileList.Location = new System.Drawing.Point(87, 143);
            this.profileList.Name = "profileList";
            this.profileList.Size = new System.Drawing.Size(265, 45);
            this.profileList.TabIndex = 1;
            // 
            // ClefText
            // 
            this.ClefText.AutoSize = true;
            this.ClefText.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.ClefText.Location = new System.Drawing.Point(80, 214);
            this.ClefText.Name = "ClefText";
            this.ClefText.Size = new System.Drawing.Size(79, 38);
            this.ClefText.TabIndex = 2;
            this.ClefText.Text = "Clef :";
            // 
            // keyTextBox
            // 
            this.keyTextBox.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.keyTextBox.Location = new System.Drawing.Point(87, 278);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.PasswordChar = '*';
            this.keyTextBox.Size = new System.Drawing.Size(265, 43);
            this.keyTextBox.TabIndex = 3;
            // 
            // AddProfilButton
            // 
            this.AddProfilButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.AddProfilButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.AddProfilButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddProfilButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.AddProfilButton.Location = new System.Drawing.Point(449, 265);
            this.AddProfilButton.Name = "AddProfilButton";
            this.AddProfilButton.Size = new System.Drawing.Size(212, 69);
            this.AddProfilButton.TabIndex = 4;
            this.AddProfilButton.Text = "Ajouter Profil";
            this.AddProfilButton.UseVisualStyleBackColor = true;
            this.AddProfilButton.Click += new System.EventHandler(this.AddProfilButton_Click);
            // 
            // ConnexionButton
            // 
            this.ConnexionButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.ConnexionButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.ConnexionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConnexionButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.ConnexionButton.Location = new System.Drawing.Point(277, 376);
            this.ConnexionButton.Name = "ConnexionButton";
            this.ConnexionButton.Size = new System.Drawing.Size(212, 69);
            this.ConnexionButton.TabIndex = 5;
            this.ConnexionButton.Text = "Connexion";
            this.ConnexionButton.UseVisualStyleBackColor = true;
            this.ConnexionButton.Click += new System.EventHandler(this.ConnexionButton_Click);
            // 
            // profilTextBox
            // 
            this.profilTextBox.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.profilTextBox.Location = new System.Drawing.Point(449, 143);
            this.profilTextBox.Name = "profilTextBox";
            this.profilTextBox.Size = new System.Drawing.Size(212, 43);
            this.profilTextBox.TabIndex = 6;
            // 
            // NewProfilText
            // 
            this.NewProfilText.AutoSize = true;
            this.NewProfilText.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.NewProfilText.Location = new System.Drawing.Point(442, 81);
            this.NewProfilText.Name = "NewProfilText";
            this.NewProfilText.Size = new System.Drawing.Size(201, 38);
            this.NewProfilText.TabIndex = 7;
            this.NewProfilText.Text = "Nouveau profil";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(762, 493);
            this.Controls.Add(this.NewProfilText);
            this.Controls.Add(this.profilTextBox);
            this.Controls.Add(this.ConnexionButton);
            this.Controls.Add(this.AddProfilButton);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.ClefText);
            this.Controls.Add(this.profileList);
            this.Controls.Add(this.ProfilText);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "LoginForm";
            this.Text = "Keep";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProfilText;
        private System.Windows.Forms.ComboBox profileList;
        private System.Windows.Forms.Label ClefText;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Button AddProfilButton;
        private System.Windows.Forms.Button ConnexionButton;
        private System.Windows.Forms.TextBox profilTextBox;
        private System.Windows.Forms.Label NewProfilText;
    }
}

