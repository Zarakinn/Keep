using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Keep.Library
{
    public static class TextConnectorProcessor
    {

        public static string FullFilePath(this string fileName)
        {
            string filePath = "../../data";
            return $"{filePath}\\{fileName}";
        }

        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }

        public static List<ProfileModel> ConvertToProfilModels(this List<string> lines)
        {
            List<ProfileModel> profiles = new List<ProfileModel>();

            foreach (string line in lines)
            {
                string[] columns = line.Split(',');

                ProfileModel p = new ProfileModel();

                p.id = int.Parse(columns[0]);
                p.name = columns[1];

                profiles.Add(p);
            }

            return profiles;
        }

        public static List<string> ConvertProfilesToString(this List<ProfileModel> profiles)
        {
            List<string> lines = new List<string>();

            foreach (ProfileModel profil in profiles)
            {
                lines.Add($"{profil.id},{profil.name}");
            }

            return lines;
        }

        public static List<SiteModel> ConvertToSiteModels(this List<string> lines)
        {
            List<SiteModel> sites = new List<SiteModel>();

            List<PasswordModel> passwords = GlobalConfig.CurrentConnection.LoadPasswordsModel();

            List<ProfileModel> profiles = GlobalConfig.CurrentConnection.LoadProfilesModel();

            foreach (string line in lines)
            {
                string[] columns = line.Split(',');

                SiteModel sm = new SiteModel();
                sm.id = int.Parse(columns[0]);
                sm.name = columns[1];
                int passwordModelId = int.Parse(columns[2]);

                sm.password = passwords.GetPasswordWithId(passwordModelId);

                int profileLinkedId = int.Parse(columns[3]);
                sm.profilLinked = profiles.GetProfileWithId(profileLinkedId);
                
                sm.date = DateTime.Parse(columns[4]);

                sites.Add(sm);
            }
            return sites;
        }

        public static List<string> ConvertSitesToString(this List<SiteModel> sites)
        {
            List<string> lines = new List<string>();

            foreach (SiteModel site in sites)
            {
                lines.Add($"{site.id},{site.name},{site.password.id},{site.profilLinked.id},{site.date.ToString()}");
            }

            return lines;
        }

        public static List<PasswordModel> ConvertToPasswordModels(this List<string> lines)
        {
            List<PasswordModel> passwords = new List<PasswordModel>();

            foreach (string line in lines)
            {
                string[] columns = line.Split(',');

                PasswordModel password = new PasswordModel();
                password.id = int.Parse(columns[0]);
                password.password = columns[1];
                passwords.Add(password);
            }

            return passwords;
        }

        public static List<string> ConvertPasswordsToString(this List<PasswordModel> passwords)
        {
            List<string> lines = new List<string>();

            foreach (PasswordModel password in passwords)
            {
                lines.Add($"{password.id},{password.password}");
            }

            return lines;
        }
        
        public static PasswordModel GetPassword(this List<PasswordModel> passwords, string newPassword)
        {
            foreach(PasswordModel pass in passwords)
            {
                if (pass.password == newPassword)
                {
                    return pass;
                }
            }

            PasswordModel retour = new PasswordModel(newPassword);

            GlobalConfig.CurrentConnection.CreatePasswordModel(retour);

            passwords.Add(retour);

            return retour;
        }

        public static PasswordModel GetPasswordWithId(this List<PasswordModel> passwords, int id)
        {
            foreach (PasswordModel pm in passwords)
            {
                if (pm.id == id)
                {
                    return pm;
                }
            }
            throw new Exception("L'id renseigné n'existe pas dans le fichier des mots de passe.");
        }

        public static ProfileModel GetProfileWithId(this List<ProfileModel> profiles, int id)
        {
            foreach (ProfileModel p in profiles)
            {
                if (p.id == id)
                {
                    return p;
                }
            }
            throw new Exception("L'id renseigné n'existe pas dans le fichier des profil");
        }
        
    }

}
