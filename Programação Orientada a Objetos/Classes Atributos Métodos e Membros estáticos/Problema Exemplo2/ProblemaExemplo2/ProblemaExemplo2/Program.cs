using System;
using System.Globalization;

namespace ProblemaExemplo2 {
    class Program {
        static void Main(string[] args) {

            Produto P = new Produto();



            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome do Produto: ");
            P.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            P.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no Estoque: ");
            P.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do Produto: " + P);
            Console.WriteLine("Digite a quantidade de Produtos a serem adicionados: ");
            int qtd = int.Parse(Console.ReadLine());
            P.AdicionarProdutos(qtd);
            Console.WriteLine("Dados do Produto Atualizado: " + P);
            Console.WriteLine("Digite a quantidades de Produtos a serem removidos: ");
            qtd = int.Parse(Console.ReadLine());
            P.RemoverProdutos(qtd);
            Console.WriteLine("Dados do Produto Atualizado: " + P);




        }
    }
}
