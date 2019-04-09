using System;

namespace System
{
    class Program 
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2019, 4, 9, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());
            string s1 = "God morning dear students!";
            Console.WriteLine(s1.Cut(10));
            
        }
    }
}
