using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweetStreamer.Model
{
    public class Entities
    {
        public object[] hashtags { get; set; }
        public object[] media { get; set; }
        public object[] urls { get; set; }
        public object[] user_mentions { get; set; }
    }
}
