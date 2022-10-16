using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Keep.Library;

namespace Keep
{
    public partial class LoginForm : Form
    {
        public List<ProfileModel> profilesAvailable = new List<ProfileModel>();


        public LoginForm()
        {
            InitializeComponent();

            UpdateProfilesList();
        }

        private void UpdateProfilesList()
        {
            profilesAvailable = GlobalConfig.CurrentConnection.LoadProfilesModel();
            LinkProfilesList();
            return;
        }

        private void LinkProfilesList()
        {
            profileList.DataSource = null;

            profileList.DataSource = profilesAvailable;
            profileList.DisplayMember = "name";
        }


        private void AddProfilButton_Click(object sender, EventArgs e)
        {
            if (ValidateAddProfilForm())
            {
                if (true) // vérifier qu'y avait pas profil avec meme nom
                {
                    ProfileModel p = new ProfileModel(profilTextBox.Text);

                    GlobalConfig.CurrentConnection.CreateProfileModel(p);

                    UpdateProfilesList();

                    profilTextBox.Text = "";
                }
                else
                {
                    MessageBox.Show("Un profil existe déjà avec le même nom.", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Données rentrées invalides, veuillez retenter.", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConnexionButton_Click(object sender, EventArgs e)
        {
            if (ValidateConnexionForm())
            {
                ProfileModel p = (ProfileModel)profileList.SelectedItem;

                MainForm m = new MainForm(p, keyTextBox.Text);

                SecurityUtil.setKey(keyTextBox.Text);

                MessageBox.Show(SecurityUtil.Decrypt(SecurityUtil.Encrypt("Ceci est un test")));

                this.Hide();
                m.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Données rentrées invalides, veuillez retenter.", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateAddProfilForm()
        {
            if (profilTextBox.Text == "")
            {
                return false;
            }

            if (profileList.Contains(profilTextBox))
            {
                return false;
            }

            return true;
        }

        private bool ValidateConnexionForm()
        {

            if (profileList.SelectedItem == null)
            {
                return false;
            }

            if (keyTextBox.Text == "")
            {
                return false;
            }

            return true;
        }
    }
}
