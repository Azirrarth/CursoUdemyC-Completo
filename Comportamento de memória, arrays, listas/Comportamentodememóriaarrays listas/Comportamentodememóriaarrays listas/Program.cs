using System;

namespace Comportamentodememóriaarrays_listas {
    class Program {
        static void Main(string[] args) {

            double? x = null;
            double? y = 10;

            double A = x ?? 5;
            double B = y ?? 5;

            Console.WriteLine(A);
            Console.WriteLine(B);
        }
    }
}
