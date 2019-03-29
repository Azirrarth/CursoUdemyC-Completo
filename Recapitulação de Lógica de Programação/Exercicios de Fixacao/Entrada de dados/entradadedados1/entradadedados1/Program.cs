using System;
using System.Globalization;

namespace entradadedados1 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Entre com seu nome completro");
            string nome = Console.ReadLine();
            Console.WriteLine(nome);
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine(quartos);
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            string[] V = Console.ReadLine().Split(' ');
            string nome1 = V[0];
            int idade = int.Parse(V[1]);
            double altura = double.Parse(V[2]);
            Console.WriteLine(nome1);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString ("F2", CultureInfo.InvariantCulture));


        }
    }
}
