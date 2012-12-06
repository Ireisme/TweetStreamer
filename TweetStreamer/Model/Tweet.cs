using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweetStreamer.Model
{
    public class Tweet
    {
        public List<Contributor> contributors { get; set; }
        public Coordinates coordinates { get; set; }
        public string created_at { get; set; }
        public object current_user_retweet { get; set; }
        public Entities entities { get; set; }
        public bool favorited { get; set; }
        public object geo { get; set; }
        public Int64 id { get; set; }
        public string id_str { get; set; }
        public string in_reply_to_screen_name { get; set; }
        public Int64? in_reply_to_status_id { get; set; }
        public string in_reply_to_status_id_str {get; set;}
        public Place place { get; set; }
        public bool possibly_sensitive { get; set; }
        public object scopes { get; set; }
        public int retweet_count { get; set; }
        public bool retweeted { get; set; }
        public string source { get; set; }
        public string text { get; set; }
        public bool truncated { get; set; }
        public User user { get; set; }
        public bool withheld_copyright { get; set; }
        public string[] withheld_in_countries { get; set; }
        public string withheld_scope { get; set; }

        public DateTime created_at_dt
        {
            get
            {
                string year = created_at.Substring(created_at.Length - 4);
                string date = created_at.Substring(0, 19);
                return DateTime.Parse(date.Insert(11, year + " "));
            }
        }
    }
}
