using System;
using System.Globalization;

namespace ExercicioEstatico4 {
    class Program {
        static void Main(string[] args) {

            Console.Write("Qual é a cotação do Dolar? ");
            double cotacao = double.Parse(Console.ReadLine().ToString(), CultureInfo.InvariantCulture);

            Console.Write("Quantos Dolares Vai Comprar? ");
            double quantia = double.Parse(Console.ReadLine().ToString(), CultureInfo.InvariantCulture);
            double result = ConversorDeMoeda.DolarParaReal(quantia, cotacao);
            Console.WriteLine("Valor a ser Pago em reais: " + result.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
