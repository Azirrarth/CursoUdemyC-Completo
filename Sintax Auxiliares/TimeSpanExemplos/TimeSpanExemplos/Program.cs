using System;

namespace TimeSpanExemplos {
    class Program {
        static void Main(string[] args) {


            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58);

            DateTime d2 = d.AddHours(2);

            Console.WriteLine(d);
            Console.WriteLine(d2);


        }
    }
}
