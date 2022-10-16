using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keep.Library
{
    public class PasswordModel
    {
        public int id { get; set; }

        public string password { get; set; }

        public PasswordModel(string p)
        {
            this.password = p;
        }

        public PasswordModel()
        {
            return;
        }
    }
}
