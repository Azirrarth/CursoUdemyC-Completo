using System;
using System.Globalization;
namespace entradadedados {
    class Program {
        static void Main(string[] args) {

            //string frase = Console.ReadLine();
            //string x = Console.ReadLine();
            //string y = Console.ReadLine();
            //string z = Console.ReadLine();

            //string[] V = Console.ReadLine().Split(' ');
            //string a = V[0];
            //string b = V[1];
            //string c = V[2];

            //Console.WriteLine("Você digitou: ");
            //Console.WriteLine(frase);
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);

            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            string[] V = Console.ReadLine().Split(' ');
            string nome = V[0];
            char sexo = char.Parse(V[1]);
            int idade = int.Parse(V[2]);
            double altura = double.Parse(V[3], CultureInfo.InvariantCulture);

            Console.WriteLine("Você digitou : ");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));




        }
    }
}
