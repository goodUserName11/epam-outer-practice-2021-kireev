using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Globalization;

namespace Task4._1._1
{
    class Program
    {
        const string _directoryPath =
            @"D:\C#\sample";
        const string _changeLogPath =
            @"changes\log.json";

        private static void OnFileRename(object sender, RenamedEventArgs e)
        {
            Console.WriteLine(
                $"File {e.OldFullPath} changed: " +
                $"{e.ChangeType}, new name: {e.FullPath}");
        }

        private static void OnFileChange(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"File {e.FullPath} changed: {e.ChangeType}");
        }

        static void Main(string[] args)
        {

            if (args.Length > 0)
            {
                if (args.Any(str => str == "-w"))
                {
                    Watch();
                }
                else if (args.Any(str => str == "-r"))
                {
                    Restore();
                }

                return;
            }

            int choose;

            Console.WriteLine("Watch or restore files?\n" +
                "1. Watch;\n" +
                "2. Restore;\n" +
                "Print anything else to exit.\n:");

            int.TryParse(Console.ReadLine(), out choose);

            switch (choose)
            {
                case 1:
                    Watch();
                    break;

                case 2:
                    Restore();
                    break;

                default:
                    break;
            }
        }

        static void Watch()
        {
            DirectoryOverseer directoryOverseer =
                new DirectoryOverseer(_directoryPath, _changeLogPath);

            directoryOverseer.FileAltered += OnFileChange;
            directoryOverseer.FileRenamed += OnFileRename;


            Console.WriteLine("Watching...\nPress any key to stop and exit.");
            Console.ReadKey();

            directoryOverseer.WriteChanges();
        }

        static void Restore()
        {
            DateTime dateTime;

            DirectoryRestorer restorer = 
                new DirectoryRestorer(_directoryPath, _changeLogPath);

            Console.WriteLine("Enter date and time\n" +
                "format: \ndd.MM.yyyy-hh:mm");

            DateTime.TryParseExact(Console.ReadLine(), @"d.M.yyyy-H:m", 
                DateTimeFormatInfo.CurrentInfo, 
                DateTimeStyles.AssumeLocal, out dateTime);

            restorer.RestoreByDateTime(dateTime);

            Console.WriteLine(
                $"Restored to {dateTime.ToShortDateString()} : " +
                $"{dateTime.ToShortTimeString()}");

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
