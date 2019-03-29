using System;
using System.Collections.Generic;

namespace Conjuntos {
    class Program {
        static void Main(string[] args) {

            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();

            A.Add(3);
            A.Add(5);
            A.Add(8);
            A.Add(9);

            B.Add(3);
            B.Add(4);
            B.Add(5);




            A.IntersectWith(B);

            foreach (int x in A) {
                Console.WriteLine(x);
            }



            //A.UnionWith(B);

            //foreach (int x in A) {
            //    Console.WriteLine(x);
            //}

            //A.ExceptWith(B);

            //foreach (int x in A) {
            //    Console.WriteLine(x);
            //}




            //Console.WriteLine("Digite um valor inteiro: ");
            //int n = int.Parse(Console.ReadLine());

            //if (B.Contains(n)) {
            //    Console.WriteLine(n + "Pertence ao conjunto B");
            //}
            //else {
            //    Console.WriteLine("Não Pertence ao conjunto B");
            //}
            //Console.WriteLine("Hello World!");
        }
    }
}
