using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keep.Library
{
    public static class GlobalConfig
    {
        public const string profilesFile = "profiles.csv";
        public const string sitesFile = "sites.csv";
        public const string passwordsFile = "password.csv";

        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        public static IDataConnection CurrentConnection;

        public static void InitializeConnection()
        {
            CurrentConnection = new TextConnection();
        }
    }
}
