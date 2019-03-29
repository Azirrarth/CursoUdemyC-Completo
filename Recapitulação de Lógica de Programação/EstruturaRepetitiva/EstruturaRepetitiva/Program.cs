using System;
using System.Globalization;

namespace EstruturaRepetitiva {
    class Program {
        static void Main(string[] args) {

            Console.Write("Digite um número: ", (CultureInfo.InvariantCulture));
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (x >= 0.0) {
                double raiz = Math.Sqrt(x);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.Write("Digite Outro Numero: ");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.WriteLine("O numero digitado é negativo!!!");
        }
    }
}
