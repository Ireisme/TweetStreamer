using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TweetStreamer
{
    public class TweetLocation
    {
        public PointF SouthWestCorner { get; set; }
        public PointF NorthEastCorner { get; set; }

        public override string ToString()
        {
            return string.Format("{0},{1}", SouthWestCorner.ToString(), NorthEastCorner.ToString());
        }
    }
}
