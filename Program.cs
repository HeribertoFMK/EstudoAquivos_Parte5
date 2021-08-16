using System;
using System.IO;
using System.Collections.Generic;



namespace EstudoAquivos_Parte5
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = @"C:\csharp\myfolder";
            try
            {
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                System.Console.WriteLine("Folders");
                foreach (string folder in folders)
                {

                    System.Console.WriteLine(folder);


                }
                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                System.Console.WriteLine("Files");
                foreach (String file in files)
                {
                    System.Console.WriteLine(file);
                }

                Directory.CreateDirectory(path + @"\maisum");

            }
            catch (IOException e)
            {
                System.Console.WriteLine("An Error Occurred!");
                System.Console.WriteLine(e.Message);
            }

            try
            {
                DirectoryInfo di = new DirectoryInfo(path);
                IEnumerable<DirectoryInfo> folder = di.EnumerateDirectories("*.*", SearchOption.AllDirectories);
                System.Console.WriteLine("Folders");
                foreach (DirectoryInfo folders in folder)
                {

                    System.Console.WriteLine(folders);
                }

                DirectoryInfo si = new DirectoryInfo(path);
                var fd = si.EnumerateFiles("*.*", SearchOption.AllDirectories);

                System.Console.WriteLine("Files");
                foreach (var file in fd)
                {

                    System.Console.WriteLine(file);
                }

                DirectoryInfo crair = new DirectoryInfo(path);
                crair.CreateSubdirectory("outro");







            }
            catch (IOException e)
            {
                System.Console.WriteLine("An Error Occurred!");
                System.Console.WriteLine(e.Message);
            }
        }
    }
}
