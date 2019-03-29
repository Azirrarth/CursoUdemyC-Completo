using System;
using System.Globalization;

namespace ConstrutoresEncap {
    class Program {
        static void Main(string[] args) {

            Produtos p = new Produtos("TV", 500.00, 10);

            p.Nome = "T";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine();

        }
    }
}
