using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoustacheApp.Extensions
{
    public static class ExtensionMethods
    {
        public static string Truncate(this string source, int length, bool tail = false)
        {
            if (source.Length > length)
            {
                source = source.Substring(0, length);
                // add '..' if tail
                if (tail && source.LastIndexOf(' ') > 0)
                {
                    source = source.Substring(0, source.LastIndexOf(' ')) + "..";
                }
            }
            return source;
        }
    }
}
