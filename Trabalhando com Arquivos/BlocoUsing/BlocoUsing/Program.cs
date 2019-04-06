using System;
using System.IO;


namespace BlocoUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Curso Udemy C#\Trabalhando com Arquivos\temp\file1.txt";

            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
            Console.WriteLine("GetFileName: " + Path.GetFileName(path));
            Console.WriteLine("GetExtension: " + Path.GetExtension(path));
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
            Console.WriteLine("GetTempPath: " + Path.GetTempPath());

            try
            {

                #region aulaDiretorios
                //var folder =  Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                //Console.WriteLine("Folders: ");
                //foreach (string s in folder)
                //{
                //    Console.WriteLine(s);
                //}
                //var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                //Console.WriteLine("Files: ");
                //foreach (string s in files)
                //{
                //    Console.WriteLine(s);
                //}
                //Directory.CreateDirectory(path + @"\newFolderOunao");
                #endregion 




            }
            catch (IOException e)
            {
                Console.WriteLine("Un error Occurred!!!");
                Console.WriteLine(e.Message);
            }

        }
    }
}
