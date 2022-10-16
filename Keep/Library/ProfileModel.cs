using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keep.Library
{
    public class ProfileModel
    {
        public string name { get; set; }

        public int id { get; set; }

        public ProfileModel(string n)
        {
            this.name = n;
        }

        public ProfileModel()
        {
            return;
        }


    }
}
