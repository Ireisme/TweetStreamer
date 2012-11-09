using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TweetStreamer.Model;

namespace TweetsToDB
{
    public interface ICanPersistTweet
    {
        bool PersistTweet(Tweet tweet);
    }
}
