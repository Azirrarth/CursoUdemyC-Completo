using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {

            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais!", nome, idade, saldo);

            Console.WriteLine($"{nome} tem {idade} com saldo de {saldo:F2} reais na conta!" );
            Console.WriteLine(nome + " tem " + idade +" anos e tem " + saldo.ToString("F2", CultureInfo.InvariantCulture) +" reais");
        }
    }
}
