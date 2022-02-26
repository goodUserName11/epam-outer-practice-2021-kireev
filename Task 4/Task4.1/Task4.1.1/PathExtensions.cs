using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._1._1
{
    public static class PathExtensions
    {
        public static string GetDirectoryFullPath(string path)
        {
            string fullPath = Path.GetFullPath(path);

            return fullPath.Replace('\\' + Path.GetFileName(path),"");
        }
    }
}
