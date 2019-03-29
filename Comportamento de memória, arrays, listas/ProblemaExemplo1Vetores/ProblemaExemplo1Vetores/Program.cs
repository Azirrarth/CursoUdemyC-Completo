using System;
using System.Globalization;

namespace ProblemaExemplo1Vetores {
    class Program {
        static void Main(string[] args) {


            Console.Write("Digite quantos quartos serão alugados:");
            int n = int.Parse(Console.ReadLine());

            Quarto[] vect = new Quarto[8];

            for (int i = 0; i < n; i++) {
                Console.Write("Digite o numero do quarto a ser alugado: ");
                int numeroDoQuarto = int.Parse(Console.ReadLine());
                Console.Write("Digite o nome de locator: ");
                string nome = Console.ReadLine();
                Console.Write("Digite o e-mail: ");
                string email = Console.ReadLine();

                vect[i] = new Quarto { Numero = numeroDoQuarto, Nome = nome, Email = email };
            }
            Console.WriteLine();
            Console.WriteLine("Quartos Ocupados");
            for (int i = 0; i < 10; i++) {

                Console.WriteLine(i + " , " + vect[i].ToString());
            }

        }
    }
}