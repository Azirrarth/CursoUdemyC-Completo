using System;
using System.Globalization;

namespace VetorExemplo2 {
    class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            Prodoct[] vect = new Prodoct[n];
            
            for (int i = 0; i < n; i++) {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Prodoct { Name = name, Price = price };
                }
            double soma = 0.00;
            for (int i = 0; i < n; i++) {
                soma += vect[i].Price;
            }
            double media = soma / n;
            Console.WriteLine("A Média dos produtos é: " + media, "F2", CultureInfo.InvariantCulture);
        
        }
    }
}
