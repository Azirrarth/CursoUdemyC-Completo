using System;

namespace OperadoresComparativos {
    class Program {
        static void Main(string[] args) {
            //Operadores Lógicos

            //int a = 10;
            //bool c1 = a < 10;
            //bool c2 = a < 20;
            //bool c3 = a > 10;
            //bool c4 = a > 5;

            //Console.WriteLine(c1);
            //Console.WriteLine(c2);
            //Console.WriteLine(c3);
            //Console.WriteLine(c4);
            //Console.WriteLine("__________________________");

            //bool c5 = a <= 10;
            //bool c6 = a >= 10;
            //bool c7 = a == 10; 
            //bool c8 = a != 10;

            //Console.WriteLine(c5);
            //Console.WriteLine(c6);
            //Console.WriteLine(c7);
            //Console.WriteLine(c8);

            //Operadores 

            bool c1 = 2 > 3 || 4 != 5;// true
            bool c2 = !(2 > 3) && 4 != 5; // true

            Console.WriteLine(c1);
            Console.WriteLine(c2); 
            Console.WriteLine("_________________________");

            bool c3 = 10 < 5; // false

            bool c4 = c1 || c2 && c3; // true

            Console.WriteLine(c3);
            Console.WriteLine(c4);

        }
    }
}
