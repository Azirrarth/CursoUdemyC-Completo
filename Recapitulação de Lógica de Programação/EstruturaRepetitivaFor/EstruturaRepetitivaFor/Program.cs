using System;
using System.Globalization;

namespace EstruturaRepetitivaFor {
    class Program {
        static void Main(string[] args) {

            Console.Write("Quantos números inteiros você deseja digitar? R: ");
            int N = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            int soma = 0;
            for (int i = 1; i <= N; i++) {
                Console.WriteLine("Digite  o numero: {0}", i);
                int valor = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                 soma += valor;
            }
            Console.WriteLine("O valor total deu: " + soma);
        }
    }
}
