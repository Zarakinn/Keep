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
    public partial class MainForm : Form
    {

        private List<SiteModel> sites = new List<SiteModel>();

        private ProfileModel currentProfilModel;
        private string currentKey;

        public MainForm(ProfileModel pm, string key)
        {
            InitializeComponent();

            currentProfilModel = pm;
            currentKey = key;

            UpdateSitesList();
        }

        private void UpdateSitesList()
        {
            sites = GlobalConfig.CurrentConnection.LoadSitesModel().Where( x => x.profilLinked.id == currentProfilModel.id).ToList();
            LinkSitesList();
        }

        private void LinkSitesList()
        {
            SiteslistBox.DataSource = null;
            SiteslistBox.DisplayMember = "";

            SiteslistBox.DataSource = sites;
            SiteslistBox.DisplayMember= "name";
        }

        private bool Validate_CC_Button()
        {
            return SiteslistBox.SelectedItem != null;
        }

        private void CCButton_Click(object sender, EventArgs e)
        {
            if (Validate_CC_Button())
            {
                SiteModel siteSelected = (SiteModel)SiteslistBox.SelectedItem;

                PasswordModel password = siteSelected.password;

                if (password.password == "" || password.password == null)
                {
                    MessageBox.Show("Erreur, aucun mot de passe n'a été enregistré.", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    Clipboard.SetText(SecurityUtil.Decrypt(password.password));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur s'est produit, vérifié que la clef rentré est correcte. \n\n");
                }
            
            }
            else
            {
                MessageBox.Show("Erreur, aucun site sélectionné.", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool Validate_Display_Button()
        {
            return SiteslistBox.SelectedItem != null;
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            if (Validate_Display_Button())
            {
                SiteModel siteSelected = (SiteModel)SiteslistBox.SelectedItem;

                PasswordModel password = siteSelected.password;

                if (password.password == "" || password.password == null)
                {
                    MessageBox.Show("Erreur, aucun mot de passe n'a été enregistré.", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    DisplayTextBox.Text = SecurityUtil.Decrypt(password.password);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur s'est produit, vérifié que la clef rentré est correcte. \n\n");
                }
            }
            else
            {
                MessageBox.Show("Erreur, aucun site sélectionné.", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show($"Etes vous sur de vouloir supprimer le mot de passe de {((SiteModel)SiteslistBox.SelectedItem).name} ?", "Confirmation.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                List<SiteModel> sites = GlobalConfig.CurrentConnection.LoadSitesModel();

                sites = sites.Where(x => x.id != ((SiteModel)SiteslistBox.SelectedItem).id).ToList();

                GlobalConfig.CurrentConnection.SaveSitesModel(sites);

                UpdateSitesList();
            }
        }

        private bool Validate_AddSite_Button()
        {
            if (SiteNameTextBox.Text =="")
            {
                MessageBox.Show("Erreur, pas de nom de site renseigné", "Message d'erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }

            if (PasswordTextBox.Text == "")
            {
                MessageBox.Show("Erreur, pas de mot de passe renseigné.", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (PasswordConfirmationTextBox.Text == "")
            {
                MessageBox.Show("Erreur, la confirmation de mot de passe est vide.", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (PasswordConfirmationTextBox.Text != PasswordTextBox.Text)
            {
                MessageBox.Show("Erreur, les deux mots de passe renseigné sont différent", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        
        private void AddSiteButton_Click(object sender, EventArgs e)
        {
            if (Validate_AddSite_Button())
            {
                List<SiteModel> sites = GlobalConfig.CurrentConnection.LoadSitesModel();

                string newName = SiteNameTextBox.Text;

                foreach (SiteModel site in sites)
                {
                    if (site.name == newName && site.profilLinked == currentProfilModel)
                    {
                        MessageBox.Show("Erreur, un site est déjà enregistré avec le même nom.","Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        SiteNameTextBox.Text = "";
                        PasswordTextBox.Text = "";
                        PasswordConfirmationTextBox.Text = "";
                        return;
                    }
                }
                
                List<PasswordModel> passwords = GlobalConfig.CurrentConnection.LoadPasswordsModel();

                //Récupère le mot de passe si il existe, le créé sinon
                PasswordModel password = passwords.GetPassword(SecurityUtil.Encrypt(PasswordTextBox.Text));
                
                SiteModel newSite = new SiteModel(newName, password, currentProfilModel);
                GlobalConfig.CurrentConnection.CreateSiteModel(newSite);
                
                UpdateSitesList();

                SiteNameTextBox.Text = "";
                PasswordTextBox.Text = "";
                PasswordConfirmationTextBox.Text = "";

                SiteslistBox.SelectedItem = newSite;

                return;
            }
            else
            {
                PasswordTextBox.Text = "";
                PasswordConfirmationTextBox.Text = "";
                return;
            }
        }

        private bool Validate_infoButton()
        {
            return SiteslistBox.SelectedItem != null;
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            if (Validate_infoButton())
            {
                SiteModel selected = (SiteModel)(SiteslistBox.SelectedItem);
                
                int nb_util = 0;

                foreach (SiteModel site in sites)
                {
                    if (site.password.id == selected.password.id)
                        nb_util++;
                }

                DateTime date = selected.date;
                MessageBox.Show($"Mot de passe utilisé pour {nb_util} site(s). Utilisé sur ce site depuis {date.ToShortDateString()}.","Information",MessageBoxButtons.OK,MessageBoxIcon.None);
            }
        }
    }
}
