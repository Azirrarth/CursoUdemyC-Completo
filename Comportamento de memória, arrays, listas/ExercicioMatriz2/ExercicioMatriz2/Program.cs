using System;

namespace ExercicioMatriz2 {
    class Program {
        static void Main(string[] args) {

            string[] linha = Console.ReadLine().Split(' ');
            int m = int.Parse(linha[0]);
            int n = int.Parse(linha[1]);

            int[,] mat = new int[m, n];

            for (int i = 0; i < m; i++) {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; i++) {
                    mat[i, j] = int.Parse(valores[j]);
                }
            }


        }
    }
}