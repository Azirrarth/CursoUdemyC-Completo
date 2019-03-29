using System;
using System.Globalization;

namespace ExercicioProposto1 {
    class Program {
        static void Main(string[] args) {

            Retangulo Retangulo1 = new Retangulo();
                        
            Console.WriteLine("Entre Com a Largura e a Altura do Retangulo");
            Retangulo1.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Retangulo1.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine("Area = " + Retangulo1.Area().ToString("F2",  CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro = " + Retangulo1.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = " + Retangulo1.Diagonal().ToString("F2", CultureInfo.InvariantCulture));

        }
        
    }
}
