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
    /// Container for FileChangesContainer
    /// </summary>
    public class ChangeContainers
    {
        [JsonConstructor]
        public ChangeContainers()
        {
            Containers = new List<FileChangesContainer>();
        }

        public ChangeContainers(IEnumerable<FileChangesContainer> collection)
        {
            Containers = new List<FileChangesContainer>(collection);
        }

        public List<FileChangesContainer> Containers
        {
            get;

            private set;
        }

        public FileChangesContainer FindByFullName(string fullName)
        {
            var container = Containers.Find(
                    container => container.FullName == fullName);

            if (container == null)
            {
                container = new FileChangesContainer(fullName);

                this.Containers.Add(container);
            }

            return container;
        }

        public void AddNewChangeByFullName(string fullName, 
            string text, WatcherChangeTypes changeType)
        {
            this.FindByFullName(fullName).FileChanges.Add(
                new FileChange(fullName, text, changeType));
        }
    }
}
