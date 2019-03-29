using System;
using System.Collections.Generic;
using System.Globalization;

namespace DateTime1 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Hello World!");

            DateTime d1 = DateTime.Parse("2000-08-15");

            Console.WriteLine(d1);

            DateTime d2 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture );
            DateTime d3 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(d2);
            Console.WriteLine(d3);


        }
    }
}
