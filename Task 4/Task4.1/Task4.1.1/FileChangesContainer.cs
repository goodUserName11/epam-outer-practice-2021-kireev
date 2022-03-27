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
    /// Container for FileChange
    /// </summary>
    public class FileChangesContainer
    {
        public FileChangesContainer(string fullName)
        {
            FullName = fullName;

            FileChanges = new List<FileChange>();
        }

        [JsonConstructor]
        public FileChangesContainer(string fullName,
            IEnumerable<FileChange> fileChanges)
        {
            FullName = fullName;
            FileChanges = new List<FileChange>(fileChanges);
        }

        public string FullName
        {
            get;

            set;
        }

        public List<FileChange> FileChanges
        {
            get;

            private set;
        }
    }
}
