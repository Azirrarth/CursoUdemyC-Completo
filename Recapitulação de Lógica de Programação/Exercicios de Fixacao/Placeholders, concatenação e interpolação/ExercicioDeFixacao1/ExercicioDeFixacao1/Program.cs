using System;
using System.Globalization;

namespace ExercicioDeFixacao1 {
    class Program {
        static void Main(string[] args) {

            string produto1 = "Computador";
            string produto2 = "Mesa de Escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo o preço é ${preco1}");
            Console.WriteLine($"{produto2}, cujo o preço é ${preco2}");
            Console.WriteLine();
            Console.WriteLine("Registro: {0} anos de idade, codigo {1} e genero {2}", idade, codigo, genero);
            Console.WriteLine();
            Console.WriteLine("medida com 8 casa decimais: " + medida);
            Console.WriteLine("Arredondando (tres casas decimais): " + medida.ToString("F3"));
            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));


            
        }
    }
}
