using System;
using System.Collections.Generic;
using System.Globalization;

namespace ListasFixaxao {
    class Program {
        static void Main(string[] args) {


            Console.Write("Quantos empregados serão registrados:");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> Lista = new List<Funcionario>();

            for (int i = 1; i <= n; i++) {
                Console.Write("Empregado #: ");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Lista.Add(new Funcionario(id, nome, salario));
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.Write(" Digite o ID do funcionário que terá o aumento de salário: ");
            int procurarID = int.Parse(Console.ReadLine());

            Funcionario funcionario = Lista.Find(x => x.Id == procurarID);

            if (funcionario != null) {
                Console.Write(" Digite a porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                funcionario.AumentarSalario(porcentagem);
            }
            else
                Console.WriteLine(" Este id não existe! ");

            Console.WriteLine();
            Console.WriteLine(" Lista atualizada de funcionários: ");
            foreach (Funcionario obj in Lista) {
                Console.WriteLine(obj);

            }
        }
    }
}
