using System;

namespace PrimeirosExercicios {
    class Program {
        static void Main(string[] args) {

            Pessoas Pessoa1 = new Pessoas();
            Pessoas Pessoa2 = new Pessoas();

            Console.WriteLine("Dados da Primeira Pessoa.");
            Console.Write("Nome:");
            Pessoa1.nome = Console.ReadLine();
            Console.Write("Idade:");
            Pessoa1.idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Dados da Segunda Pessoa.");
            Console.Write("Nome:");
            Pessoa2.nome = Console.ReadLine();
            Console.Write("Idade:");
            Pessoa2.idade = int.Parse(Console.ReadLine());

            if (Pessoa1.idade > Pessoa2.idade) {
                Console.WriteLine("A Pessoa mais velha é {0}", Pessoa1.nome);
            }
            else {
                Console.WriteLine("A Pessoa mais velha é {0}", Pessoa2.nome);
            }

        }
    }
}
