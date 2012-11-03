using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweetStreamer
{
    public class TweetStreamParameters
    {
        public string Username { get; internal set; }
        public string Password { get; internal set; }

        public List<TweetLocation> Locations { get; set; }
        public List<string> Filters { get; set; }
        public List<string> Users { get; set; }

        public TweetStreamParameters(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }

        public string PostParameters()
        {
            string filters = string.Empty;
            string users = string.Empty;
            string locations = string.Empty;

            if(Filters != null)
                filters = Filters.Count() > 0 ? string.Format("&track={0}", Filters.Aggregate((s1, s2) => s1 + "," + s2)) : string.Empty;
            if(Users != null)
                users = Users.Count() > 0 ? string.Format("&follow={0}", Users.Aggregate((u1, u2) => u1 + "," + u2)) : string.Empty;
            if(Locations != null)
                locations = Locations.Count() > 0 ? string.Format("&locations={0}", Locations.ConvertAll<string>(l => l.ToString()).Aggregate((l1, l2) => l1 + "," + l2)) : string.Empty;

            return string.Format("{0}{1}{2}", filters, users, locations);
        }
    }
}
