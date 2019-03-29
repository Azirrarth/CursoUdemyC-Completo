using System;
using System.Globalization;

namespace SegundoExe {
    class Program {
        static void Main(string[] args) {
            FUncionario Funcionario1 = new FUncionario();


            Console.WriteLine("Digite os dados do Funcionario:");
            Funcionario1.Nome = Console.ReadLine();
            Funcionario1.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Funcionario1.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Funcionário: " + Funcionario1,  "F2", CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine("Digite a Porcentagem para aumentar o salário:");
            Funcionario1.AumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: " + Funcionario1);


        }
    }
}
