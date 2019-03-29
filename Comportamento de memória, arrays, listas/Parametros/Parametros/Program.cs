using System;

namespace Parametros {
    class Program {
        static void Main(string[] args) {

            string[] vect = new string[] { "Marcos", "Jose", "Pop" };
            for (int i = 0; i < vect.Length; i++) {
                Console.WriteLine(vect[i]);
            }
            Console.WriteLine();
            Console.WriteLine();

            foreach (string teste in vect){
                Console.WriteLine(teste);
            }


        }
    }
}
