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
    /// Class to watch over txt files and logs their changes
    /// </summary>
    public class DirectoryOverseer
    {
        /// <summary>
        /// The file to log to and to get old logs
        /// </summary>
        readonly string _changeLogPath;

        FileSystemWatcher _fileSystemWatcher;

        /// <summary>
        /// All file change events, except renamed
        /// </summary>
        public event FileSystemEventHandler FileAltered;

        public event RenamedEventHandler FileRenamed;

        public DirectoryOverseer(string directoryPath, 
            string changeLogPath = @"changes\log.json") 
        {
            DirectoryPath = directoryPath;

            _changeLogPath = changeLogPath;

            _fileSystemWatcher =
                new FileSystemWatcher(DirectoryPath, "*.txt");

            DeserializeLog();

            _fileSystemWatcher.Changed += OnChange;
            _fileSystemWatcher.Created += OnCreate;
            _fileSystemWatcher.Deleted += OnDelete;
            _fileSystemWatcher.Renamed += OnRename;

            _fileSystemWatcher.IncludeSubdirectories = true;
            _fileSystemWatcher.EnableRaisingEvents = true;
        }

        /// <summary>
        /// The path of the Directory to monitor
        /// </summary>
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

        private void OnDelete(object sender, FileSystemEventArgs e)
        {
            FileAltered?.Invoke(this, e);

            Containers.AddNewChangeByFullName(
                e.FullPath, "", e.ChangeType);
        }

        private void OnCreate(object sender, FileSystemEventArgs e)
        {
            FileAltered?.Invoke(this, e);

            Containers.Containers.
                Add(new FileChangesContainer(e.FullPath));

            Containers.AddNewChangeByFullName(
                e.FullPath, File.ReadAllText(e.FullPath), e.ChangeType);
        }

        private void OnChange(
            object sender, FileSystemEventArgs e)
        {
            FileAltered?.Invoke(this, e);

            Containers.AddNewChangeByFullName(
                e.FullPath, File.ReadAllText(e.FullPath), e.ChangeType);
        }

        private void OnRename(object sender, RenamedEventArgs e)
        {
            FileRenamed?.Invoke(this, e);

            var container = Containers.FindByFullName(e.OldFullPath);
            
            container.FullName = e.FullPath;

            container?.
            FileChanges.Add(
                new FileNameChange(e.FullPath, File.ReadAllText(e.FullPath), 
                e.ChangeType, e.OldFullPath));
        }

        private void DeserializeLog()
        {
            if (!File.Exists(_changeLogPath))
            {
                Containers = new ChangeContainers();
                return;
            }

            Containers =
                JsonConvert.
                DeserializeObject<ChangeContainers>(
                    File.ReadAllText(_changeLogPath));
        }

        public void WriteChanges()
        {
            var directory = PathExtensions.
                GetDirectoryFullPath(_changeLogPath);

            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            File.WriteAllText(_changeLogPath, 
                JsonConvert.SerializeObject(Containers));
        }
    }
}
