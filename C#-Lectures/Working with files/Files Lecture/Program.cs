using System.IO;

namespace Files_Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            //DEMO FILE-FILEINFO
            /*
            var path = @"c:\temp\myfile.jpg";
            File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);
            File.Delete(path);
                if (File.Exists(path))
            {
                //
            }
            var content = File.ReadAllText(path);

            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("..", true);
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                //
            } */

            //DIRECTORY


            Directory.CreateDirectory(@"c:\Users\boly1\Documents\UABC BOLY\11er Semestre\GAUG\C#");
            var files = Directory.GetFiles(@"c:\Users\boly1\Documents\UABC BOLY\11er Semestre\GAUG\C#", "*.sln*", SearchOption.AllDirectories);
            foreach (var file in files)
                System.Console.WriteLine(file);

            var directories = Directory.GetDirectories(@"c:\Users\boly1\Documents\UABC BOLY\11er Semestre\GAUG\C#", "*.*", SearchOption.AllDirectories);
            foreach (var directory in directories)
                System.Console.WriteLine(directory);

            Directory.Exists("...");


            var directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();
        }

    }
}
