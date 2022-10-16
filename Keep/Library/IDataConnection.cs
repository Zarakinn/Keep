using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keep.Library
{
    public interface IDataConnection
    {
        List<ProfileModel> LoadProfilesModel();

        void SaveProfilesModel(List<ProfileModel> profiles);

        void CreateProfileModel(ProfileModel p);



        List<SiteModel> LoadSitesModel();

        void SaveSitesModel(List<SiteModel> sites);

        void CreateSiteModel(SiteModel s);



        List<PasswordModel> LoadPasswordsModel();

        void SavePasswordModel(List<PasswordModel> passwords);

        void CreatePasswordModel(PasswordModel password);

    }
}
