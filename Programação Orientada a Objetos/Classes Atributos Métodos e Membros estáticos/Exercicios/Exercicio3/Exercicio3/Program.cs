using System;
using System.Globalization;


namespace Exercicio3 {
    class Program {
        static void Main(string[] args) {
            Aluno Aluno1 = new Aluno();

            Console.WriteLine("Entre com o nome do aluno e suas Notas");
            Aluno1.Nome = Console.ReadLine();
            Aluno1.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Aluno1.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Aluno1.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine("Nota Final = " + Aluno1.Soma().ToString("F2", CultureInfo.InvariantCulture));

            if (Aluno1.Soma() > 60) {
                Console.WriteLine("Aprovado!");
            }
            else {
                Console.WriteLine("Reprovado!");
                Console.WriteLine("Faltam: " + Aluno1.Faltam().ToString("F2", CultureInfo.InvariantCulture));
            }


        }
    }
}
