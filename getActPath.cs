using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace OpenPort
{
    internal class getActPath
    {
        public string getPath()
        {
            string dir = "";
            string[] SplitDir = Directory.GetCurrentDirectory().Split(@"\");
            foreach (string s in SplitDir)
            {
                if (s != "OpenPort")
                {
                    dir += @$"{s}\";
                }
                else
                {
                    dir += @$"{s}\{s}";
                    break;
                }
            }
            return dir;
        }
    }
}
