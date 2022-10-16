using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Keep.Library
{
    public class TextConnection : IDataConnection
    {
  
        #region profileModel
        public List<ProfileModel> LoadProfilesModel()
        {
            return GlobalConfig.profilesFile.FullFilePath().LoadFile().ConvertToProfilModels();
        }

        public void SaveProfilesModel(List<ProfileModel> profiles)
        {
            File.WriteAllLines(GlobalConfig.profilesFile.FullFilePath(), profiles.ConvertProfilesToString());
        }

        public void CreateProfileModel(ProfileModel p)
        {
            List<ProfileModel> profiles = LoadProfilesModel();

            int id = 1;

            if (profiles.Count > 0)
                id = profiles.OrderBy(x => x.id).Last().id + 1;

            p.id = id;

            profiles.Add(p);

            SaveProfilesModel(profiles);
      
            return ;
        }
        #endregion

        #region sitesModel

        public List<SiteModel> LoadSitesModel()
        {
            return GlobalConfig.sitesFile.FullFilePath().LoadFile().ConvertToSiteModels();
        }

        public void SaveSitesModel(List<SiteModel> sites)
        {
            File.WriteAllLines(GlobalConfig.sitesFile.FullFilePath(), sites.ConvertSitesToString());
        }

        public void CreateSiteModel(SiteModel s)
        {
            List<SiteModel> sites = LoadSitesModel();

            int id = 1;

            if (sites.Count > 0)
                id = sites.OrderBy(x => x.id).Last().id + 1;

           s.id = id;

            sites.Add(s);

            SaveSitesModel(sites);

            return ;
        }

        #endregion

        #region passwordModel

        public List<PasswordModel> LoadPasswordsModel()
        {
            return GlobalConfig.passwordsFile.FullFilePath().LoadFile().ConvertToPasswordModels();
        }
    
        public void SavePasswordModel(List<PasswordModel> passwords)
        {
            File.WriteAllLines(GlobalConfig.passwordsFile.FullFilePath(), passwords.ConvertPasswordsToString());
        }

        public void CreatePasswordModel(PasswordModel password)
        {
            List<PasswordModel> passwords = LoadPasswordsModel();

            int id = 1;

            if (passwords.Count > 0)
                id = passwords.OrderBy(x => x.id).Last().id + 1;

            password.id = id;

            passwords.Add(password);

            SavePasswordModel(passwords);

            return ;
        }
        #endregion
    }
}
