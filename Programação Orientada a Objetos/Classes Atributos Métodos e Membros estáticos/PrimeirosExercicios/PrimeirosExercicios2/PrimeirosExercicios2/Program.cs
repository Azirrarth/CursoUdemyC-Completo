using System;
using System.Globalization;

namespace PrimeirosExercicios2 {
    class Program {
        static void Main(string[] args) {
            Pessoas Pessoa1 = new Pessoas();
            Pessoas Pessoa2 = new Pessoas();
            double Media;

            Console.WriteLine("Dados do Primeiro funcionario.");
            Console.Write("Nome: ");
            Pessoa1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            Pessoa1.Salario = double.Parse (Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do Segundo funcionario.");
            Console.Write("Nome: ");
            Pessoa2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            Pessoa2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Media = (Pessoa1.Salario + Pessoa2.Salario) / 2;

            Console.WriteLine("Salário medio entre {0} e {1} é de: {2}",Pessoa1.Nome, Pessoa2.Nome, Media, "F2",  CultureInfo.InvariantCulture);


        }
    }
}
