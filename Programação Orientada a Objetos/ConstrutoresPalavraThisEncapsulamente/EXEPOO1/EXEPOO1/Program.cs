using System;
using System.Globalization;

namespace EXEPOO1 {
    class Program {
        private const string S = "s";

        static void Main(string[] args) {

            ContaBancaria contaBancaria;

            Console.Write("Entre com o numero da conta: ");
            int numeroDaConta = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Entre com o titular da conta: ");
            string titularDaConta = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Haverá deposito inicial? S/N: ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S') {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
                contaBancaria = new ContaBancaria(titularDaConta, numeroDaConta, depositoInicial);
                    }
            else {
                contaBancaria = new ContaBancaria(titularDaConta, numeroDaConta);
                Console.WriteLine();
                Console.WriteLine("Dados da conta");
                Console.WriteLine(contaBancaria);
            }
            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaBancaria.ValorDepositado(valor);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(contaBancaria);
            Console.WriteLine();

            Console.WriteLine("Entre um valor para saque:");
            double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaBancaria.ValorDeSaque(valorSaque);
            Console.WriteLine();

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(contaBancaria);
            Console.WriteLine();







        }










    }
}

