using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Task4._1._1
{
    /// <summary>
    /// Single file change
    /// </summary>
    public class FileChange
    {
        public FileChange(string fileFullName, string fileText, 
            WatcherChangeTypes changeType)
        {
            FileFullName = fileFullName;
            FileText = fileText;
            ChangeType = changeType;
            ChangeDateTime = DateTime.Now;
        }

        [JsonConstructor]
        public FileChange(DateTime changeDateTime, string fileFullName, 
            string fileText, WatcherChangeTypes changeType)
        {
            ChangeDateTime = changeDateTime;
            FileFullName = fileFullName;
            FileText = fileText;
            ChangeType = changeType;
        }

        public DateTime ChangeDateTime
        {
            get;

            private set;
        }

        public string FileFullName
        {
            get;

            private set;
        }

        public string FileText
        {
            get;

            private set;
        }

        public WatcherChangeTypes ChangeType
        {
            get;

            private set;
        }
    }
}
