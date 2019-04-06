using System;
using System.IO;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string soucePath = @"D:\Curso Udemy C#\Trabalhando com Arquivos\temp\file1.txt";
            string targetPath = @"D:\Curso Udemy C#\Trabalhando com Arquivos\temp\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(soucePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(soucePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
