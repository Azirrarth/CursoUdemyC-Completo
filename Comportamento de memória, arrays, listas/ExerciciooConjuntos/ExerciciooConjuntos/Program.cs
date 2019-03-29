using System;
using System.Collections.Generic;

namespace ExerciciooConjuntos {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");

            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();

            Console.WriteLine("O curso A possue quantos alunos?");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso A:");
            for (int i = 0; i < N; i++) {
                int x = int.Parse(Console.ReadLine());
                A.Add(x);
            }
            Console.WriteLine("O curso B possue quantos alunos?");
            N = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso B:");
            for (int i = 0; i < N; i++) {
                int x = int.Parse(Console.ReadLine());
                B.Add(x);
            }
            Console.WriteLine("O curso C possue quantos alunos?");
            N = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso C:");
            for (int i = 0; i < N; i++) {
                int x = int.Parse(Console.ReadLine());
                C.Add(x);

                HashSet<int> Novo = new HashSet<int>();
                Novo.UnionWith(A);
                Novo.UnionWith(B);
                Novo.UnionWith(C);
                Console.WriteLine("Total de Alunos: " + Novo.Count);
                Console.ReadLine();
            }
        }
    }
}
