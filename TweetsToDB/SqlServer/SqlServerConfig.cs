using System;
using System.Collections.Generic;
using System.Xml;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace TweetsToDB.SqlServer
{
    public class SqlServerConfigSection : ConfigurationSection
    {
        [ConfigurationProperty("datasource")]
        public string DataSource
        {
            get { return (string)this["datasource"]; }
        }

        [ConfigurationProperty("database")]
        public string Database
        {
            get { return (string)this["database"]; }
        }

        [ConfigurationProperty("user")]
        public string User
        {
            get { return (string)this["user"]; }
        }

        [ConfigurationProperty("password")]
        public string Password
        {
            get { return (string)this["password"]; }
        }
    }

    public static class SqlServerConfig
    {
        public static SqlServerConfigSection Config
        {
            get
            {
                var a = ConfigurationManager.GetSection("SqlServer") as SqlServerConfigSection;
                return a;
            }
        }
    }
}
