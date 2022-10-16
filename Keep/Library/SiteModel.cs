using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keep.Library
{
    public class SiteModel
    {
        public int id { get; set; }

        public string name { get; set; }

        public PasswordModel password { get; set; }

        public ProfileModel profilLinked { get; set; }

        public DateTime date { get; set; }

        public SiteModel (string n, PasswordModel pm, ProfileModel prof)
        {
            this.name = n;
            this.password = pm;
            this.profilLinked = prof;
            this.date = DateTime.Today;
        }

        public SiteModel()
        {
            return;
        }
    }
}
