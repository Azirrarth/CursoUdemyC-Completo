using System;
using System.Globalization;

namespace ProblemaSemOOB {
    class Program {
        static void Main(string[] args) {

            double xA, xB, xC, yA, yB, yC;
            Console.WriteLine("Entre com as medidas do triangulo X: ");
            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo Y: ");
            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double P = (xA + xB + xC) / 2.0;
            double areaX = Math.Sqrt(P * (P - xA) * (P - xB) * (P - xC));

            P = (yA + yB + yC) / 2.0;
            double areaY = Math.Sqrt(P * (P - yA) * (P - yB) * (P - yC));

            Console.WriteLine("Area de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY) {
                Console.WriteLine("Maior área é do triangulo X");
            }
            else {
                Console.WriteLine("Maior Area é do triangulo Y");
            }
        }
    }
}
