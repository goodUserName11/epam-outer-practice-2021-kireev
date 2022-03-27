using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._1._1
{
    public class FileNameChange : FileChange
    {
        public FileNameChange(string fileName, string fileText,
            WatcherChangeTypes changeType, string fileOldFullName) :
            base( fileName, fileText, changeType)
        {
            FileOldFullName = fileOldFullName;
        }

        [JsonConstructor]
        public FileNameChange(DateTime changeDateTime, string fileName,
            string fileText, WatcherChangeTypes changeType, string fileOldFullName) :
            base(changeDateTime, fileName, fileText, changeType)
        {
            FileOldFullName = fileOldFullName;
        }

        public string FileOldFullName
        {
            get;

            private set;
        }
    }
}
