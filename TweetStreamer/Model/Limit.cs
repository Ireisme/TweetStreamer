using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweetStreamer.Model
{
    public class MissedTweets
    {
        public Limit limit { get; set; }
    }

    public class Limit
    {
        public int track { get; set; }
    }
}
