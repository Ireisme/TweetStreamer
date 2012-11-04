using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweetsToSqlite
{
    internal static class Log
    {
        public static Logger Instance { get; private set; }

        static Log()
        {
            Instance = LogManager.GetCurrentClassLogger();
        }
    }
}
