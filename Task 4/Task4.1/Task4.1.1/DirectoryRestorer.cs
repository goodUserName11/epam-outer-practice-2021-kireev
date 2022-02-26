using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Task4._1._1
{
    /// <summary>
    /// Class that restoring files using log's data
    /// </summary>
    public class DirectoryRestorer
    {
        /// <summary>
        /// The file to get old logs
        /// </summary>
        readonly string _changeLogPath;

        public event Action FilesRestored;

        public DirectoryRestorer(string directoryPath,
            string changeLogPath = @"changes\log.json")
        {
            DirectoryPath = directoryPath;

            _changeLogPath = changeLogPath;

            DeserializeLog();
        }

        public string DirectoryPath
        {
            get;

            private set;
        }

        public ChangeContainers Containers
        {
            get;

            private set;
        }

        private void DeserializeLog()
        {
            if (!File.Exists(_changeLogPath))
                throw new FileNotFoundException();

            Containers = 
                JsonConvert.
                DeserializeObject<ChangeContainers>(
                    File.ReadAllText(_changeLogPath));
        }

        public void RestoreByDateTime(DateTime dateTime)
        {
            foreach (var container in Containers.Containers)
            {
                if (container.FileChanges.Count == 0)
                    continue;

                var fileChange = container.FileChanges.Find(
                    change => change.ChangeDateTime < dateTime);

                var newestFileName = container.FileChanges.FindLast(
                    change => change.ChangeType == WatcherChangeTypes.Renamed)?.FileFullName;

                if (fileChange == null)
                {
                    fileChange = container.FileChanges[0];

                    if (newestFileName == null)
                        newestFileName = fileChange.FileFullName;

                    if (File.Exists(newestFileName))
                        File.Delete(newestFileName); ;

                    return;
                }

                if (newestFileName == null)
                    newestFileName = fileChange.FileFullName;

                switch (fileChange.ChangeType)
                {
                    case WatcherChangeTypes.Created:
                        DirectoryRestore(fileChange.FileFullName);

                        if (fileChange.FileFullName != newestFileName &&
                            File.Exists(newestFileName))
                            File.Delete(newestFileName);

                        File.Create(fileChange.FileFullName);


                        break;

                    case WatcherChangeTypes.Deleted:
                        if (File.Exists(newestFileName))
                            File.Delete(newestFileName);
                        
                        break;

                    case WatcherChangeTypes.Renamed:
                    case WatcherChangeTypes.Changed:
                        DirectoryRestore(fileChange.FileFullName);

                        if (fileChange.FileFullName != newestFileName &&
                            File.Exists(newestFileName))
                            File.Delete(newestFileName);

                        File.WriteAllText(fileChange.FileFullName,
                            fileChange.FileText);

                        break;

                    default:
                        break;
                }

                
            }

            FilesRestored?.Invoke();
        }

        /// <summary>
        /// Creates directories if can't find file directory
        /// </summary>
        /// <remarks>Do nothing if finds directory</remarks>
        /// <param name="fullFileName"></param>
        private void DirectoryRestore(string fullFileName)
        {
            var directory =
                PathExtensions.
                GetDirectoryFullPath(
                    fullFileName);

            if (!Directory.Exists(fullFileName))
                Directory.CreateDirectory(directory);
        }    
    }

}
